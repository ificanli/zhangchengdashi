using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace BrainFailProductions.PolyFew.AsImpL
{
	[Token(Token = "0x2000CD9")]
	public class DataSet
	{
		[Token(Token = "0x2000CDA")]
		public struct FaceIndices
		{
			[Token(Token = "0x4005BF6")]
			[FieldOffset(Offset = "0x0")]
			public int vertIdx;

			[Token(Token = "0x4005BF7")]
			[FieldOffset(Offset = "0x4")]
			public int uvIdx;

			[Token(Token = "0x4005BF8")]
			[FieldOffset(Offset = "0x8")]
			public int normIdx;
		}

		[Token(Token = "0x2000CDB")]
		public class ObjectData
		{
			[Token(Token = "0x4005BF9")]
			[FieldOffset(Offset = "0x10")]
			public string name;

			[Token(Token = "0x4005BFA")]
			[FieldOffset(Offset = "0x18")]
			public List<FaceGroupData> faceGroups;

			[Token(Token = "0x4005BFB")]
			[FieldOffset(Offset = "0x20")]
			public List<FaceIndices> allFaces;

			[Token(Token = "0x4005BFC")]
			[FieldOffset(Offset = "0x28")]
			public bool hasNormals;

			[Token(Token = "0x4005BFD")]
			[FieldOffset(Offset = "0x29")]
			public bool hasColors;

			[Token(Token = "0x6005058")]
			[Address(RVA = "0x42C3B04", Offset = "0x42BFB04", VA = "0x42C3B04")]
			public ObjectData()
			{
			}
		}

		[Token(Token = "0x2000CDC")]
		public class FaceGroupData
		{
			[Token(Token = "0x4005BFE")]
			[FieldOffset(Offset = "0x10")]
			public string name;

			[Token(Token = "0x4005BFF")]
			[FieldOffset(Offset = "0x18")]
			public string materialName;

			[Token(Token = "0x4005C00")]
			[FieldOffset(Offset = "0x20")]
			public List<FaceIndices> faces;

			[Token(Token = "0x17000E37")]
			public bool IsEmpty
			{
				[Token(Token = "0x600505A")]
				[Address(RVA = "0x42C4000", Offset = "0x42C0000", VA = "0x42C4000")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x6005059")]
			[Address(RVA = "0x42C3BC8", Offset = "0x42BFBC8", VA = "0x42C3BC8")]
			public FaceGroupData()
			{
			}
		}

		[Token(Token = "0x4005BED")]
		[FieldOffset(Offset = "0x10")]
		public List<ObjectData> objectList;

		[Token(Token = "0x4005BEE")]
		[FieldOffset(Offset = "0x18")]
		public List<Vector3> vertList;

		[Token(Token = "0x4005BEF")]
		[FieldOffset(Offset = "0x20")]
		public List<Vector2> uvList;

		[Token(Token = "0x4005BF0")]
		[FieldOffset(Offset = "0x28")]
		public List<Vector3> normalList;

		[Token(Token = "0x4005BF1")]
		[FieldOffset(Offset = "0x30")]
		public List<Color> colorList;

		[Token(Token = "0x4005BF2")]
		[FieldOffset(Offset = "0x38")]
		private int unnamedGroupIndex;

		[Token(Token = "0x4005BF3")]
		[FieldOffset(Offset = "0x40")]
		private ObjectData currObjData;

		[Token(Token = "0x4005BF4")]
		[FieldOffset(Offset = "0x48")]
		private FaceGroupData currGroup;

		[Token(Token = "0x4005BF5")]
		[FieldOffset(Offset = "0x50")]
		private bool noFaceDefined;

		[Token(Token = "0x17000E35")]
		public string CurrGroupName
		{
			[Token(Token = "0x600504A")]
			[Address(RVA = "0x42C35E0", Offset = "0x42BF5E0", VA = "0x42C35E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000E36")]
		public bool IsEmpty
		{
			[Token(Token = "0x600504B")]
			[Address(RVA = "0x42C3634", Offset = "0x42BF634", VA = "0x42C3634")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600504C")]
		[Address(RVA = "0x42C3684", Offset = "0x42BF684", VA = "0x42C3684")]
		public static string GetFaceIndicesKey(FaceIndices fi)
		{
			return null;
		}

		[Token(Token = "0x600504D")]
		[Address(RVA = "0x42C3784", Offset = "0x42BF784", VA = "0x42C3784")]
		public static string FixMaterialName(string mtlName)
		{
			return null;
		}

		[Token(Token = "0x600504E")]
		[Address(RVA = "0x42C3830", Offset = "0x42BF830", VA = "0x42C3830")]
		public DataSet()
		{
		}

		[Token(Token = "0x600504F")]
		[Address(RVA = "0x42C3C48", Offset = "0x42BFC48", VA = "0x42C3C48")]
		public void AddObject(string objectName)
		{
		}

		[Token(Token = "0x6005050")]
		[Address(RVA = "0x42C3E48", Offset = "0x42BFE48", VA = "0x42C3E48")]
		public void AddGroup(string groupName)
		{
		}

		[Token(Token = "0x6005051")]
		[Address(RVA = "0x42C4050", Offset = "0x42C0050", VA = "0x42C4050")]
		public void AddMaterialName(string matName)
		{
		}

		[Token(Token = "0x6005052")]
		[Address(RVA = "0x42C40E8", Offset = "0x42C00E8", VA = "0x42C40E8")]
		public void AddVertex(Vector3 vertex)
		{
		}

		[Token(Token = "0x6005053")]
		[Address(RVA = "0x42C41BC", Offset = "0x42C01BC", VA = "0x42C41BC")]
		public void AddUV(Vector2 uv)
		{
		}

		[Token(Token = "0x6005054")]
		[Address(RVA = "0x42C4274", Offset = "0x42C0274", VA = "0x42C4274")]
		public void AddNormal(Vector3 normal)
		{
		}

		[Token(Token = "0x6005055")]
		[Address(RVA = "0x42C4348", Offset = "0x42C0348", VA = "0x42C4348")]
		public void AddColor(Color color)
		{
		}

		[Token(Token = "0x6005056")]
		[Address(RVA = "0x42C4424", Offset = "0x42C0424", VA = "0x42C4424")]
		public void AddFaceIndices(FaceIndices faceIdx)
		{
		}

		[Token(Token = "0x6005057")]
		[Address(RVA = "0x42C4570", Offset = "0x42C0570", VA = "0x42C4570")]
		public void PrintSummary()
		{
		}
	}
}
