﻿#if SILICONSTUDIO_XENKO_GRAPHICS_API_OPENGLES
//------------------------------------------------------------------------------
// <auto-generated>
//     Xenko Effect Compiler File Generated:
//     Effect [UIEffect]
//
//     Command Line: C:\DEV\xenko\sources\engine\SiliconStudio.Xenko.Graphics\Shaders.Bytecodes\..\..\..\..\Bin\Windows-Direct3D11\SiliconStudio.Assets.CompilerApp.exe --profile=Windows-OpenGLES --platform=Windows --output-path=C:\DEV\xenko\sources\engine\SiliconStudio.Xenko.Graphics\Shaders.Bytecodes\obj\app_data --build-path=C:\DEV\xenko\sources\engine\SiliconStudio.Xenko.Graphics\Shaders.Bytecodes\obj\build_app_data --package-file=Graphics.xkpkg
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SiliconStudio.Xenko.Graphics 
{
    internal partial class UIEffect
    {
        private static readonly byte[] binaryBytecodeSRgb = new byte[] {
4, 192, 254, 239, 0, 0, 0, 0, 0, 0, 0, 2, 0, 0, 0, 0, 18, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 84, 101, 120, 116, 117, 114, 101, 48, 9, 0, 0, 0, 7, 0, 0, 0, 0, 13, 84, 101, 120, 116, 117, 114, 101, 48, 95, 105, 100, 49, 51, 1, 5, 0, 0, 0, 255, 255, 
255, 255, 1, 0, 0, 0, 1, 0, 17, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 83, 97, 109, 112, 108, 101, 114, 8, 0, 0, 0, 10, 0, 0, 0, 0, 12, 83, 97, 109, 112, 108, 101, 114, 95, 105, 100, 52, 49, 1, 5, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 1, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 5, 0, 0, 0, 14, 85, 73, 69, 102, 102, 101, 99, 116, 83, 104, 97, 100, 101, 114, 1, 254, 143, 46, 68, 16, 2, 249, 40, 153, 196, 26, 236, 77, 131, 222, 33, 10, 83, 104, 97, 100, 101, 114, 66, 97, 115, 101, 1, 92, 49, 
96, 204, 191, 147, 108, 94, 16, 43, 217, 49, 95, 15, 148, 106, 16, 83, 104, 97, 100, 101, 114, 66, 97, 115, 101, 83, 116, 114, 101, 97, 109, 1, 246, 153, 8, 5, 148, 172, 99, 193, 243, 129, 64, 222, 87, 206, 26, 123, 9, 84, 101, 120, 116, 117, 114, 105, 110, 103, 1, 169, 217, 238, 31, 185, 
166, 138, 247, 206, 107, 18, 41, 22, 134, 250, 234, 12, 67, 111, 108, 111, 114, 85, 116, 105, 108, 105, 116, 121, 1, 96, 154, 198, 92, 221, 250, 146, 113, 24, 1, 64, 172, 43, 176, 156, 191, 0, 2, 0, 0, 0, 0, 1, 0, 0, 0, 1, 4, 22, 230, 239, 34, 175, 185, 22, 93, 29, 19, 199, 
81, 165, 125, 193, 0, 0, 8, 0, 0, 139, 5, 35, 118, 101, 114, 115, 105, 111, 110, 32, 49, 48, 48, 10, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 104, 105, 103, 104, 112, 32, 105, 110, 116, 59, 10, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 104, 105, 103, 104, 112, 32, 102, 108, 111, 
97, 116, 59, 10, 118, 97, 114, 121, 105, 110, 103, 32, 118, 101, 99, 52, 32, 118, 95, 67, 79, 76, 79, 82, 48, 59, 10, 118, 97, 114, 121, 105, 110, 103, 32, 118, 101, 99, 50, 32, 118, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 59, 10, 118, 97, 114, 121, 105, 110, 103, 32, 102, 108, 111, 
97, 116, 32, 118, 95, 66, 65, 84, 67, 72, 95, 83, 87, 73, 90, 90, 76, 69, 48, 59, 10, 97, 116, 116, 114, 105, 98, 117, 116, 101, 32, 118, 101, 99, 52, 32, 97, 95, 80, 79, 83, 73, 84, 73, 79, 78, 48, 59, 10, 97, 116, 116, 114, 105, 98, 117, 116, 101, 32, 118, 101, 99, 52, 32, 
97, 95, 67, 79, 76, 79, 82, 48, 59, 10, 97, 116, 116, 114, 105, 98, 117, 116, 101, 32, 118, 101, 99, 50, 32, 97, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 59, 10, 97, 116, 116, 114, 105, 98, 117, 116, 101, 32, 102, 108, 111, 97, 116, 32, 97, 95, 66, 65, 84, 67, 72, 95, 83, 87, 
73, 90, 90, 76, 69, 48, 59, 10, 118, 111, 105, 100, 32, 109, 97, 105, 110, 32, 40, 41, 10, 123, 10, 32, 32, 118, 101, 99, 52, 32, 116, 109, 112, 118, 97, 114, 95, 49, 59, 10, 32, 32, 116, 109, 112, 118, 97, 114, 95, 49, 46, 120, 121, 122, 32, 61, 32, 40, 97, 95, 67, 79, 76, 79, 
82, 48, 46, 120, 121, 122, 32, 42, 32, 40, 40, 97, 95, 67, 79, 76, 79, 82, 48, 46, 120, 121, 122, 32, 42, 32, 10, 32, 32, 32, 32, 40, 40, 97, 95, 67, 79, 76, 79, 82, 48, 46, 120, 121, 122, 32, 42, 32, 48, 46, 51, 48, 53, 51, 48, 54, 41, 32, 43, 32, 48, 46, 54, 56, 
50, 49, 55, 49, 49, 41, 10, 32, 32, 41, 32, 43, 32, 48, 46, 48, 49, 50, 53, 50, 50, 56, 56, 41, 41, 59, 10, 32, 32, 116, 109, 112, 118, 97, 114, 95, 49, 46, 119, 32, 61, 32, 97, 95, 67, 79, 76, 79, 82, 48, 46, 119, 59, 10, 32, 32, 103, 108, 95, 80, 111, 115, 105, 116, 
105, 111, 110, 46, 120, 119, 32, 61, 32, 97, 95, 80, 79, 83, 73, 84, 73, 79, 78, 48, 46, 120, 119, 59, 10, 32, 32, 118, 95, 67, 79, 76, 79, 82, 48, 32, 61, 32, 116, 109, 112, 118, 97, 114, 95, 49, 59, 10, 32, 32, 118, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 32, 61, 32, 
97, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 59, 10, 32, 32, 118, 95, 66, 65, 84, 67, 72, 95, 83, 87, 73, 90, 90, 76, 69, 48, 32, 61, 32, 97, 95, 66, 65, 84, 67, 72, 95, 83, 87, 73, 90, 90, 76, 69, 48, 59, 10, 32, 32, 103, 108, 95, 80, 111, 115, 105, 116, 105, 111, 
110, 46, 122, 32, 61, 32, 40, 40, 97, 95, 80, 79, 83, 73, 84, 73, 79, 78, 48, 46, 122, 32, 42, 32, 50, 46, 48, 41, 32, 45, 32, 97, 95, 80, 79, 83, 73, 84, 73, 79, 78, 48, 46, 119, 41, 59, 10, 32, 32, 103, 108, 95, 80, 111, 115, 105, 116, 105, 111, 110, 46, 121, 32, 61, 
32, 45, 40, 97, 95, 80, 79, 83, 73, 84, 73, 79, 78, 48, 46, 121, 41, 59, 10, 125, 10, 10, 236, 7, 35, 118, 101, 114, 115, 105, 111, 110, 32, 51, 48, 48, 32, 101, 115, 10, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 108, 111, 119, 112, 32, 117, 115, 97, 109, 112, 108, 101, 114, 50, 
68, 65, 114, 114, 97, 121, 59, 10, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 108, 111, 119, 112, 32, 117, 115, 97, 109, 112, 108, 101, 114, 67, 117, 98, 101, 59, 10, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 108, 111, 119, 112, 32, 117, 115, 97, 109, 112, 108, 101, 114, 51, 68, 59, 10, 
112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 108, 111, 119, 112, 32, 117, 115, 97, 109, 112, 108, 101, 114, 50, 68, 59, 10, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 108, 111, 119, 112, 32, 105, 115, 97, 109, 112, 108, 101, 114, 50, 68, 65, 114, 114, 97, 121, 59, 10, 112, 114, 101, 99, 105, 
115, 105, 111, 110, 32, 108, 111, 119, 112, 32, 105, 115, 97, 109, 112, 108, 101, 114, 67, 117, 98, 101, 59, 10, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 108, 111, 119, 112, 32, 105, 115, 97, 109, 112, 108, 101, 114, 51, 68, 59, 10, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 108, 111, 119, 
112, 32, 105, 115, 97, 109, 112, 108, 101, 114, 50, 68, 59, 10, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 108, 111, 119, 112, 32, 115, 97, 109, 112, 108, 101, 114, 50, 68, 65, 114, 114, 97, 121, 83, 104, 97, 100, 111, 119, 59, 10, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 108, 111, 119, 
112, 32, 115, 97, 109, 112, 108, 101, 114, 50, 68, 65, 114, 114, 97, 121, 59, 10, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 108, 111, 119, 112, 32, 115, 97, 109, 112, 108, 101, 114, 50, 68, 83, 104, 97, 100, 111, 119, 59, 10, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 108, 111, 119, 112, 
32, 115, 97, 109, 112, 108, 101, 114, 67, 117, 98, 101, 83, 104, 97, 100, 111, 119, 59, 10, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 108, 111, 119, 112, 32, 115, 97, 109, 112, 108, 101, 114, 51, 68, 59, 10, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 104, 105, 103, 104, 112, 32, 105, 110, 
116, 59, 10, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 104, 105, 103, 104, 112, 32, 102, 108, 111, 97, 116, 59, 10, 111, 117, 116, 32, 118, 101, 99, 52, 32, 118, 95, 67, 79, 76, 79, 82, 48, 59, 10, 111, 117, 116, 32, 118, 101, 99, 50, 32, 118, 95, 84, 69, 88, 67, 79, 79, 82, 68, 
48, 59, 10, 111, 117, 116, 32, 102, 108, 111, 97, 116, 32, 118, 95, 66, 65, 84, 67, 72, 95, 83, 87, 73, 90, 90, 76, 69, 48, 59, 10, 105, 110, 32, 118, 101, 99, 52, 32, 97, 95, 80, 79, 83, 73, 84, 73, 79, 78, 48, 59, 10, 105, 110, 32, 118, 101, 99, 52, 32, 97, 95, 67, 79, 
76, 79, 82, 48, 59, 10, 105, 110, 32, 118, 101, 99, 50, 32, 97, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 59, 10, 105, 110, 32, 102, 108, 111, 97, 116, 32, 97, 95, 66, 65, 84, 67, 72, 95, 83, 87, 73, 90, 90, 76, 69, 48, 59, 10, 118, 111, 105, 100, 32, 109, 97, 105, 110, 32, 
40, 41, 10, 123, 10, 32, 32, 118, 101, 99, 52, 32, 116, 109, 112, 118, 97, 114, 95, 49, 59, 10, 32, 32, 116, 109, 112, 118, 97, 114, 95, 49, 46, 120, 121, 122, 32, 61, 32, 40, 97, 95, 67, 79, 76, 79, 82, 48, 46, 120, 121, 122, 32, 42, 32, 40, 40, 97, 95, 67, 79, 76, 79, 82, 
48, 46, 120, 121, 122, 32, 42, 32, 10, 32, 32, 32, 32, 40, 40, 97, 95, 67, 79, 76, 79, 82, 48, 46, 120, 121, 122, 32, 42, 32, 48, 46, 51, 48, 53, 51, 48, 54, 41, 32, 43, 32, 48, 46, 54, 56, 50, 49, 55, 49, 49, 41, 10, 32, 32, 41, 32, 43, 32, 48, 46, 48, 49, 50, 
53, 50, 50, 56, 56, 41, 41, 59, 10, 32, 32, 116, 109, 112, 118, 97, 114, 95, 49, 46, 119, 32, 61, 32, 97, 95, 67, 79, 76, 79, 82, 48, 46, 119, 59, 10, 32, 32, 103, 108, 95, 80, 111, 115, 105, 116, 105, 111, 110, 46, 120, 119, 32, 61, 32, 97, 95, 80, 79, 83, 73, 84, 73, 79, 
78, 48, 46, 120, 119, 59, 10, 32, 32, 118, 95, 67, 79, 76, 79, 82, 48, 32, 61, 32, 116, 109, 112, 118, 97, 114, 95, 49, 59, 10, 32, 32, 118, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 32, 61, 32, 97, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 59, 10, 32, 32, 118, 95, 66, 
65, 84, 67, 72, 95, 83, 87, 73, 90, 90, 76, 69, 48, 32, 61, 32, 97, 95, 66, 65, 84, 67, 72, 95, 83, 87, 73, 90, 90, 76, 69, 48, 59, 10, 32, 32, 103, 108, 95, 80, 111, 115, 105, 116, 105, 111, 110, 46, 122, 32, 61, 32, 40, 40, 97, 95, 80, 79, 83, 73, 84, 73, 79, 78, 
48, 46, 122, 32, 42, 32, 50, 46, 48, 41, 32, 45, 32, 97, 95, 80, 79, 83, 73, 84, 73, 79, 78, 48, 46, 119, 41, 59, 10, 32, 32, 103, 108, 95, 80, 111, 115, 105, 116, 105, 111, 110, 46, 121, 32, 61, 32, 45, 40, 97, 95, 80, 79, 83, 73, 84, 73, 79, 78, 48, 46, 121, 41, 59, 
10, 125, 10, 10, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 0, 0, 0, 1, 39, 149, 31, 119, 10, 63, 254, 26, 127, 95, 245, 62, 167, 218, 95, 105, 0, 0, 8, 0, 0, 169, 4, 35, 118, 101, 114, 115, 105, 111, 110, 32, 49, 48, 48, 10, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 104, 105, 103, 
104, 112, 32, 105, 110, 116, 59, 10, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 104, 105, 103, 104, 112, 32, 102, 108, 111, 97, 116, 59, 10, 117, 110, 105, 102, 111, 114, 109, 32, 115, 97, 109, 112, 108, 101, 114, 50, 68, 32, 84, 101, 120, 116, 117, 114, 101, 48, 95, 105, 100, 49, 51, 95, 83, 
97, 109, 112, 108, 101, 114, 95, 105, 100, 52, 49, 59, 10, 118, 97, 114, 121, 105, 110, 103, 32, 118, 101, 99, 52, 32, 118, 95, 67, 79, 76, 79, 82, 48, 59, 10, 118, 97, 114, 121, 105, 110, 103, 32, 118, 101, 99, 50, 32, 118, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 59, 10, 118, 97, 
114, 121, 105, 110, 103, 32, 102, 108, 111, 97, 116, 32, 118, 95, 66, 65, 84, 67, 72, 95, 83, 87, 73, 90, 90, 76, 69, 48, 59, 10, 118, 111, 105, 100, 32, 109, 97, 105, 110, 32, 40, 41, 10, 123, 10, 32, 32, 109, 101, 100, 105, 117, 109, 112, 32, 118, 101, 99, 52, 32, 116, 109, 112, 118, 
97, 114, 95, 49, 59, 10, 32, 32, 108, 111, 119, 112, 32, 118, 101, 99, 52, 32, 116, 109, 112, 118, 97, 114, 95, 50, 59, 10, 32, 32, 108, 111, 119, 112, 32, 118, 101, 99, 52, 32, 116, 109, 112, 118, 97, 114, 95, 51, 59, 10, 32, 32, 116, 109, 112, 118, 97, 114, 95, 51, 32, 61, 32, 116, 
101, 120, 116, 117, 114, 101, 50, 68, 32, 40, 84, 101, 120, 116, 117, 114, 101, 48, 95, 105, 100, 49, 51, 95, 83, 97, 109, 112, 108, 101, 114, 95, 105, 100, 52, 49, 44, 32, 118, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 41, 59, 10, 32, 32, 108, 111, 119, 112, 32, 118, 101, 99, 52, 32, 
116, 109, 112, 118, 97, 114, 95, 52, 59, 10, 32, 32, 105, 102, 32, 40, 40, 118, 95, 66, 65, 84, 67, 72, 95, 83, 87, 73, 90, 90, 76, 69, 48, 32, 61, 61, 32, 48, 46, 48, 41, 41, 32, 123, 10, 32, 32, 32, 32, 116, 109, 112, 118, 97, 114, 95, 52, 32, 61, 32, 116, 109, 112, 118, 
97, 114, 95, 51, 59, 10, 32, 32, 125, 32, 101, 108, 115, 101, 32, 123, 10, 32, 32, 32, 32, 116, 109, 112, 118, 97, 114, 95, 52, 32, 61, 32, 116, 109, 112, 118, 97, 114, 95, 51, 46, 120, 120, 120, 120, 59, 10, 32, 32, 125, 59, 10, 32, 32, 116, 109, 112, 118, 97, 114, 95, 50, 32, 61, 
32, 40, 116, 109, 112, 118, 97, 114, 95, 52, 32, 42, 32, 118, 95, 67, 79, 76, 79, 82, 48, 41, 59, 10, 32, 32, 116, 109, 112, 118, 97, 114, 95, 49, 32, 61, 32, 116, 109, 112, 118, 97, 114, 95, 50, 59, 10, 32, 32, 103, 108, 95, 70, 114, 97, 103, 68, 97, 116, 97, 91, 48, 93, 32, 
61, 32, 116, 109, 112, 118, 97, 114, 95, 49, 59, 10, 125, 10, 10, 151, 7, 35, 118, 101, 114, 115, 105, 111, 110, 32, 51, 48, 48, 32, 101, 115, 10, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 108, 111, 119, 112, 32, 117, 115, 97, 109, 112, 108, 101, 114, 50, 68, 65, 114, 114, 97, 121, 59, 
10, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 108, 111, 119, 112, 32, 117, 115, 97, 109, 112, 108, 101, 114, 67, 117, 98, 101, 59, 10, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 108, 111, 119, 112, 32, 117, 115, 97, 109, 112, 108, 101, 114, 51, 68, 59, 10, 112, 114, 101, 99, 105, 115, 105, 
111, 110, 32, 108, 111, 119, 112, 32, 117, 115, 97, 109, 112, 108, 101, 114, 50, 68, 59, 10, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 108, 111, 119, 112, 32, 105, 115, 97, 109, 112, 108, 101, 114, 50, 68, 65, 114, 114, 97, 121, 59, 10, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 108, 111, 
119, 112, 32, 105, 115, 97, 109, 112, 108, 101, 114, 67, 117, 98, 101, 59, 10, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 108, 111, 119, 112, 32, 105, 115, 97, 109, 112, 108, 101, 114, 51, 68, 59, 10, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 108, 111, 119, 112, 32, 105, 115, 97, 109, 112, 
108, 101, 114, 50, 68, 59, 10, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 108, 111, 119, 112, 32, 115, 97, 109, 112, 108, 101, 114, 50, 68, 65, 114, 114, 97, 121, 83, 104, 97, 100, 111, 119, 59, 10, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 108, 111, 119, 112, 32, 115, 97, 109, 112, 108, 
101, 114, 50, 68, 65, 114, 114, 97, 121, 59, 10, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 108, 111, 119, 112, 32, 115, 97, 109, 112, 108, 101, 114, 50, 68, 83, 104, 97, 100, 111, 119, 59, 10, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 108, 111, 119, 112, 32, 115, 97, 109, 112, 108, 101, 
114, 67, 117, 98, 101, 83, 104, 97, 100, 111, 119, 59, 10, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 108, 111, 119, 112, 32, 115, 97, 109, 112, 108, 101, 114, 51, 68, 59, 10, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 104, 105, 103, 104, 112, 32, 105, 110, 116, 59, 10, 112, 114, 101, 99, 
105, 115, 105, 111, 110, 32, 104, 105, 103, 104, 112, 32, 102, 108, 111, 97, 116, 59, 10, 117, 110, 105, 102, 111, 114, 109, 32, 115, 97, 109, 112, 108, 101, 114, 50, 68, 32, 84, 101, 120, 116, 117, 114, 101, 48, 95, 105, 100, 49, 51, 95, 83, 97, 109, 112, 108, 101, 114, 95, 105, 100, 52, 49, 59, 
10, 108, 97, 121, 111, 117, 116, 40, 108, 111, 99, 97, 116, 105, 111, 110, 61, 48, 41, 32, 111, 117, 116, 32, 108, 111, 119, 112, 32, 118, 101, 99, 52, 32, 111, 117, 116, 95, 103, 108, 95, 102, 114, 97, 103, 100, 97, 116, 97, 95, 67, 111, 108, 111, 114, 84, 97, 114, 103, 101, 116, 95, 105, 100, 
49, 59, 10, 105, 110, 32, 118, 101, 99, 52, 32, 118, 95, 67, 79, 76, 79, 82, 48, 59, 10, 105, 110, 32, 118, 101, 99, 50, 32, 118, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 59, 10, 105, 110, 32, 102, 108, 111, 97, 116, 32, 118, 95, 66, 65, 84, 67, 72, 95, 83, 87, 73, 90, 90, 
76, 69, 48, 59, 10, 118, 111, 105, 100, 32, 109, 97, 105, 110, 32, 40, 41, 10, 123, 10, 32, 32, 108, 111, 119, 112, 32, 118, 101, 99, 52, 32, 116, 109, 112, 118, 97, 114, 95, 49, 59, 10, 32, 32, 116, 109, 112, 118, 97, 114, 95, 49, 32, 61, 32, 116, 101, 120, 116, 117, 114, 101, 32, 40, 
84, 101, 120, 116, 117, 114, 101, 48, 95, 105, 100, 49, 51, 95, 83, 97, 109, 112, 108, 101, 114, 95, 105, 100, 52, 49, 44, 32, 118, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 41, 59, 10, 32, 32, 108, 111, 119, 112, 32, 118, 101, 99, 52, 32, 116, 109, 112, 118, 97, 114, 95, 50, 59, 10, 
32, 32, 105, 102, 32, 40, 40, 118, 95, 66, 65, 84, 67, 72, 95, 83, 87, 73, 90, 90, 76, 69, 48, 32, 61, 61, 32, 48, 46, 48, 41, 41, 32, 123, 10, 32, 32, 32, 32, 116, 109, 112, 118, 97, 114, 95, 50, 32, 61, 32, 116, 109, 112, 118, 97, 114, 95, 49, 59, 10, 32, 32, 125, 32, 
101, 108, 115, 101, 32, 123, 10, 32, 32, 32, 32, 116, 109, 112, 118, 97, 114, 95, 50, 32, 61, 32, 116, 109, 112, 118, 97, 114, 95, 49, 46, 120, 120, 120, 120, 59, 10, 32, 32, 125, 59, 10, 32, 32, 111, 117, 116, 95, 103, 108, 95, 102, 114, 97, 103, 100, 97, 116, 97, 95, 67, 111, 108, 111, 
114, 84, 97, 114, 103, 101, 116, 95, 105, 100, 49, 32, 61, 32, 40, 116, 109, 112, 118, 97, 114, 95, 50, 32, 42, 32, 118, 95, 67, 79, 76, 79, 82, 48, 41, 59, 10, 125, 10, 10, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
        };
    }
}
#endif
