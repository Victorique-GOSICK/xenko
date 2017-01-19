// Copyright (c) 2014 Silicon Studio Corp. (http://siliconstudio.co.jp)
// This file is distributed under GPL v3. See LICENSE.md for details.

using System;
using System.Collections.Generic;
using SiliconStudio.Core.Annotations;
using SiliconStudio.Core.Reflection;
using SiliconStudio.Quantum.Commands;
using SiliconStudio.Quantum.Contents;

namespace SiliconStudio.Quantum
{
    public interface IObjectNode : IContentNode
    {
        /// <summary>
        /// Gets the member corresponding to the given name.
        /// </summary>
        /// <param name="name">The name of the member to retrieve.</param>
        /// <returns>The member corresponding to the given name.</returns>
        /// <exception cref="KeyNotFoundException">This node has no member that matches the given name.</exception>
        IMemberNode this[string name] { get; }

        /// <summary>
        /// Gets the collection of members of this node.
        /// </summary>
        IReadOnlyCollection<IMemberNode> Members { get; }

        /// <summary>
        /// Attempts to retrieve the child node of this <see cref="IContentNode"/> that matches the given name.
        /// </summary>
        /// <param name="name">The name of the child to retrieve.</param>
        /// <returns>The child node that matches the given name, or <c>null</c> if no child matches.</returns>
        IMemberNode TryGetChild(string name);
    }

    public interface IMemberNode : IContentNode
    {
        /// <summary>
        /// Gets the member name.
        /// </summary>
        [NotNull]
        string Name { get; }

        /// <summary>
        /// Gets the <see cref="IObjectNode"/> containing this member node.
        /// </summary>
        [NotNull]
        IObjectNode Parent { get; }

        /// <summary>
        /// Gets the member descriptor corresponding to this member node.
        /// </summary>
        [NotNull]
        IMemberDescriptor MemberDescriptor { get; }

        /// <summary>
        /// Raised before a change to this node occurs and before the <see cref="Changing"/> event is raised.
        /// </summary>
        event EventHandler<MemberNodeChangeEventArgs> PrepareChange;

        /// <summary>
        /// Raised after a change to this node has occurred and after the <see cref="Changed"/> event is raised.
        /// </summary>
        event EventHandler<MemberNodeChangeEventArgs> FinalizeChange;

        /// <summary>
        /// Raised just before a change to this node occurs.
        /// </summary>
        event EventHandler<MemberNodeChangeEventArgs> Changing;

        /// <summary>
        /// Raised when a change to this node has occurred.
        /// </summary>
        event EventHandler<MemberNodeChangeEventArgs> Changed;
    }

    public interface IInitializingGraphNode : IContentNode
    {
        /// <summary>
        /// Seal the node, indicating its construction is finished and that no more children or commands will be added.
        /// </summary>
        void Seal();

        /// <summary>
        /// Add a command to this node. The node must not have been sealed yet.
        /// </summary>
        /// <param name="command">The node command to add.</param>
        void AddCommand(INodeCommand command);
    }

    public interface IInitializingObjectNode : IInitializingGraphNode, IObjectNode
    {
        /// <summary>
        /// Add a member to this node. This node and the member node must not have been sealed yet.
        /// </summary>
        /// <param name="member">The member to add to this node.</param>
        /// <param name="allowIfReference">if set to <c>false</c> throw an exception if <see cref="IContentNode.Reference"/> is not null.</param>
        void AddMember(IInitializingMemberNode member, bool allowIfReference = false);
    }

    public interface IInitializingMemberNode : IInitializingGraphNode, IMemberNode
    {
        /// <summary>
        /// Sets the <see cref="IObjectNode"/> containing this member node.
        /// </summary>
        /// <param name="parent">The parent node containing this member node.</param>
        /// <seealso cref="IMemberNode.Parent"/>
        void SetParent(IObjectNode parent);
    }
}
