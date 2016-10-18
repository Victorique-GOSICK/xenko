using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using SiliconStudio.Core.Reflection;
using SiliconStudio.Core.Yaml.Serialization;
using DictionaryDescriptor = SiliconStudio.Core.Yaml.Serialization.Descriptors.DictionaryDescriptor;
using ITypeDescriptor = SiliconStudio.Core.Yaml.Serialization.ITypeDescriptor;

namespace SiliconStudio.Core.Yaml
{
    /// <summary>
    /// An implementation of <see cref="CollectionWithIdsSerializerBase"/> for dictionaries.
    /// </summary>
    public class DictionaryWithIdsSerializer : CollectionWithIdsSerializerBase
    {
        /// <inheritdoc/>
        public override IYamlSerializable TryCreate(SerializerContext context, ITypeDescriptor typeDescriptor)
        {
            if (typeDescriptor is DictionaryDescriptor)
            {
                var dataStyle = typeDescriptor.Type.GetCustomAttribute<DataStyleAttribute>();
                if (dataStyle == null || dataStyle.Style != DataStyle.Compact)
                    return this;
            }
            return null;
        }

        /// <inheritdoc/>
        protected override void TransformObjectAfterRead(ref ObjectContext objectContext)
        {
            if (!AreCollectionItemsIdentifiable(ref objectContext))
            {
                base.TransformObjectAfterRead(ref objectContext);
                return;
            }

            var info = (InstanceInfo)objectContext.Properties[InstanceInfoKey];

            // This is to be backward compatible with previous serialization. We fetch ids from the ~Id member of each item
            if (info.Instance != null)
            {
                object property;
                var deletedItems = objectContext.Properties.TryGetValue(DeletedItemsKey, out property) ? (ICollection<Guid>)property : null;
                TransformAfterDeserialization((IDictionary)objectContext.Instance, info.Descriptor, info.Instance, deletedItems);
            }
            objectContext.Instance = info.Instance;

            var enumerable = objectContext.Instance as IEnumerable;
            if (enumerable != null)
            {
                var ids = CollectionItemIdHelper.GetCollectionItemIds(objectContext.Instance);
                var descriptor = (DictionaryDescriptor)info.Descriptor;
                foreach (var item in descriptor.GetEnumerator(objectContext.Instance))
                {
                    Guid id;
                    if (ids.TryGet(item.Key, out id) && id != Guid.Empty)
                        continue;

                    id = IdentifiableHelper.GetId(item.Value);
                    ids[item.Key] = id != Guid.Empty ? id : Guid.NewGuid();
                }
            }

            base.TransformObjectAfterRead(ref objectContext);
        }

        /// <inheritdoc/>
        protected override object TransformForSerialization(ITypeDescriptor descriptor, object collection)
        {
            var dictionaryDescriptor = (DictionaryDescriptor)descriptor;
            var instance = CreatEmptyContainer(descriptor);

            var identifier = CollectionItemIdHelper.GetCollectionItemIds(collection);
            var keyWithIdType = typeof(KeyWithId<>).MakeGenericType(dictionaryDescriptor.KeyType);
            foreach (var item in dictionaryDescriptor.GetEnumerator(collection))
            {
                Guid id;
                if (!identifier.TryGet(item.Key, out id))
                {
                    id = Guid.NewGuid();
                }
                var keyWithId = Activator.CreateInstance(keyWithIdType, id, item.Key);
                instance.Add(keyWithId, item.Value);
            }

            return instance;
        }

        /// <inheritdoc/>
        protected override IDictionary CreatEmptyContainer(ITypeDescriptor descriptor)
        {
            var dictionaryDescriptor = (DictionaryDescriptor)descriptor;
            var type = typeof(DictionaryWithItemIds<,>).MakeGenericType(dictionaryDescriptor.KeyType, dictionaryDescriptor.ValueType);
            if (type.GetConstructor(Type.EmptyTypes) == null)
                throw new InvalidOperationException("The type of dictionary does not have a parameterless constructor.");
            return (IDictionary)Activator.CreateInstance(type);
        }

        /// <inheritdoc/>
        protected override void TransformAfterDeserialization(IDictionary container, ITypeDescriptor targetDescriptor, object targetCollection, ICollection<Guid> deletedItems = null)
        {
            var dictionaryDescriptor = (DictionaryDescriptor)targetDescriptor;
            var type = typeof(DictionaryWithItemIds<,>).MakeGenericType(dictionaryDescriptor.KeyType, dictionaryDescriptor.ValueType);
            if (!type.IsInstanceOfType(container))
                throw new InvalidOperationException("The given container does not match the expected type.");
            var identifier = CollectionItemIdHelper.GetCollectionItemIds(targetCollection);
            identifier.Clear();
            var enumerator = container.GetEnumerator();
            while (enumerator.MoveNext())
            {
                var keyWithId = (IKeyWithId)enumerator.Key;
                dictionaryDescriptor.AddToDictionary(targetCollection, keyWithId.Key, enumerator.Value);
                identifier.Add(keyWithId.Key, keyWithId.Id);
            }
            if (deletedItems != null)
            {
                foreach (var deletedItem in deletedItems)
                {
                    identifier.MarkAsDeleted(deletedItem);
                }
            }
        }
    }
}
