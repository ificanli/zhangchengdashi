using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BrainFailProductions.PolyFew.AsImpL
{
	[Serializable]
	[Token(Token = "0x2000D08")]
	public class ModelImportInfo
	{
		[Token(Token = "0x4005D3A")]
		[FieldOffset(Offset = "0x10")]
		[Tooltip("Name for the game object created\n(leave it blank to use its file name)")]
		public string name;

		[Token(Token = "0x4005D3B")]
		[FieldOffset(Offset = "0x18")]
		[Tooltip("Path relative to the project folder")]
		public string path;

		[Token(Token = "0x4005D3C")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("Check this to skip this model")]
		public bool skip;

		[Token(Token = "0x4005D3D")]
		[FieldOffset(Offset = "0x28")]
		public ImportOptions loaderOptions;

		[Token(Token = "0x600511E")]
		[Address(RVA = "0x42D87B0", Offset = "0x42D47B0", VA = "0x42D87B0")]
		public ModelImportInfo()
		{
		}
	}
}
