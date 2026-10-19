using Il2CppDummyDll;
using Unity.Collections;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	[Token(Token = "0x20000CC")]
	public class MB_Utility
	{
		[Token(Token = "0x20000CD")]
		public struct MeshAnalysisResult
		{
			[Token(Token = "0x40002E3")]
			[FieldOffset(Offset = "0x0")]
			public Rect uvRect;

			[Token(Token = "0x40002E4")]
			[FieldOffset(Offset = "0x10")]
			public bool hasOutOfBoundsUVs;

			[Token(Token = "0x40002E5")]
			[FieldOffset(Offset = "0x11")]
			public bool hasOverlappingSubmeshVerts;

			[Token(Token = "0x40002E6")]
			[FieldOffset(Offset = "0x12")]
			public bool hasUVs;

			[Token(Token = "0x40002E7")]
			[FieldOffset(Offset = "0x14")]
			public float submeshArea;
		}

		[Token(Token = "0x20000CE")]
		private class MB_Triangle
		{
			[Token(Token = "0x40002E8")]
			[FieldOffset(Offset = "0x10")]
			private int submeshIdx;

			[Token(Token = "0x40002E9")]
			[FieldOffset(Offset = "0x18")]
			private int[] vs;

			[Token(Token = "0x6000447")]
			[Address(RVA = "0x74875E4", Offset = "0x74835E4", VA = "0x74875E4")]
			public bool isSame(object obj)
			{
				return default;
			}

			[Token(Token = "0x6000448")]
			[Address(RVA = "0x74876F8", Offset = "0x74836F8", VA = "0x74876F8")]
			public bool sharesVerts(MB_Triangle obj)
			{
				return default;
			}

			[Token(Token = "0x6000449")]
			[Address(RVA = "0x748781C", Offset = "0x748381C", VA = "0x748781C")]
			public void Initialize(int[] ts, int idx, int sIdx)
			{
			}

			[Token(Token = "0x600044A")]
			[Address(RVA = "0x74878EC", Offset = "0x74838EC", VA = "0x74878EC")]
			public MB_Triangle()
			{
			}
		}

		[Token(Token = "0x40002E2")]
		[FieldOffset(Offset = "0x0")]
		public static bool DO_INTEGRITY_CHECKS;

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x7485B04", Offset = "0x7481B04", VA = "0x7485B04")]
		public static Texture2D createTextureCopy(Texture2D source, bool expectedToBeGammaCorrectedHint)
		{
			return null;
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x7485BE8", Offset = "0x7481BE8", VA = "0x7485BE8")]
		public static bool ArrayBIsSubsetOfA(object[] a, object[] b)
		{
			return default;
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x7485C7C", Offset = "0x7481C7C", VA = "0x7485C7C")]
		public static Material[] GetGOMaterials(GameObject go)
		{
			return null;
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x74820E0", Offset = "0x747E0E0", VA = "0x74820E0")]
		public static Mesh GetMesh(GameObject go)
		{
			return null;
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x748617C", Offset = "0x748217C", VA = "0x748617C")]
		public static void SetMesh(GameObject go, Mesh m)
		{
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x74862CC", Offset = "0x74822CC", VA = "0x74862CC")]
		public static Renderer GetRenderer(GameObject go)
		{
			return null;
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x74863E0", Offset = "0x74823E0", VA = "0x74863E0")]
		public static void DisableRendererInSource(GameObject go)
		{
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x748650C", Offset = "0x748250C", VA = "0x748650C")]
		public static bool hasOutOfBoundsUVs(Mesh m, ref Rect uvBounds)
		{
			return default;
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x7486548", Offset = "0x7482548", VA = "0x7486548")]
		public static bool hasOutOfBoundsUVs(Mesh m, ref MeshAnalysisResult putResultHere, int submeshIndex = -1, int uvChannel = 0)
		{
			return default;
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x7486654", Offset = "0x7482654", VA = "0x7486654")]
		public static bool hasOutOfBoundsUVs(Vector2[] uvs, Mesh m, ref MeshAnalysisResult putResultHere, int submeshIndex = -1)
		{
			return default;
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x748680C", Offset = "0x748280C", VA = "0x748680C")]
		public static bool hasOutOfBoundsUVs(NativeArray<Vector2> uvs, Mesh m, ref MeshAnalysisResult putResultHere, int submeshIndex = -1)
		{
			return default;
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x74869B4", Offset = "0x74829B4", VA = "0x74869B4")]
		public static void setSolidColor(Texture2D t, Color c)
		{
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x7486A50", Offset = "0x7482A50", VA = "0x7486A50")]
		public static Texture2D resampleTexture(Texture2D source, bool expectToBeGammaCorrectedHint, int newWidth, int newHeight)
		{
			return null;
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x7486C90", Offset = "0x7482C90", VA = "0x7486C90")]
		public static bool AreAllSharedMaterialsDistinct(Material[] sharedMaterials)
		{
			return default;
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x7486DA8", Offset = "0x7482DA8", VA = "0x7486DA8")]
		public static void doSubmeshesShareVertsOrTris(Mesh m, ref MeshAnalysisResult mar)
		{
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x7486FAC", Offset = "0x7482FAC", VA = "0x7486FAC")]
		public static bool GetBounds(GameObject go, out Bounds b)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED MB_Utility.GetBounds RVA=0x7486FAC Token=0x6000441");
}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x748025C", Offset = "0x747C25C", VA = "0x748025C")]
		public static void Destroy(Object o)
		{
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x74871F8", Offset = "0x74831F8", VA = "0x74871F8")]
		public static string ConvertAssetsRelativePathToFullSystemPath(string pth)
		{
			return null;
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x7487298", Offset = "0x7483298", VA = "0x7487298")]
		public static bool IsSceneInstance(GameObject go)
		{
			return default;
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x74872CC", Offset = "0x74832CC", VA = "0x74872CC")]
		public static string BoneWeightToString(BoneWeight bw)
		{
			return null;
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x74875DC", Offset = "0x74835DC", VA = "0x74875DC")]
		public MB_Utility()
		{
		}
	}
}
