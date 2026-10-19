using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace BrainFailProductions.PolyFew.AsImpL
{
	[Token(Token = "0x2000D09")]
	public class MultiObjectImporter : ObjectImporter
	{
		[Token(Token = "0x4005D3E")]
		[FieldOffset(Offset = "0x68")]
		[Tooltip("Load models in the list on start")]
		public bool autoLoadOnStart;

		[Token(Token = "0x4005D3F")]
		[FieldOffset(Offset = "0x70")]
		[Tooltip("Models to load on startup")]
		public List<ModelImportInfo> objectsList;

		[Token(Token = "0x4005D40")]
		[FieldOffset(Offset = "0x78")]
		[Tooltip("Default import options")]
		public ImportOptions defaultImportOptions;

		[Token(Token = "0x4005D41")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private PathSettings pathSettings;

		[Token(Token = "0x17000E52")]
		public string RootPath
		{
			[Token(Token = "0x600511F")]
			[Address(RVA = "0x42D87B8", Offset = "0x42D47B8", VA = "0x42D87B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005120")]
		[Address(RVA = "0x42D8960", Offset = "0x42D4960", VA = "0x42D8960")]
		public void ImportModelListAsync(ModelImportInfo[] modelsInfo)
		{
		}

		[Token(Token = "0x6005121")]
		[Address(RVA = "0x42D8C88", Offset = "0x42D4C88", VA = "0x42D8C88", Slot = "10")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6005122")]
		[Address(RVA = "0x42D8CF8", Offset = "0x42D4CF8", VA = "0x42D8CF8")]
		public MultiObjectImporter()
		{
		}
	}
}
