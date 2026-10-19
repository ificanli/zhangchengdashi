using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace BrainFailProductions.PolyFew.UnityMeshSimplifier
{
	[Token(Token = "0x2000020")]
	public static class MeshUtils
	{
		[Token(Token = "0x40000E2")]
		public const int UVChannelCount = 8;

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x856A56C", Offset = "0x856656C", VA = "0x856A56C")]
		public static Mesh CreateMesh(Vector3[] vertices, int[][] indices, Vector3[] normals, Vector4[] tangents, Color[] colors, BoneWeight[] boneWeights, List<Vector2>[] uvs, Matrix4x4[] bindposes, BlendShape[] blendShapes)
		{
			return null;
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x856A92C", Offset = "0x856692C", VA = "0x856A92C")]
		public static Mesh CreateMesh(Vector3[] vertices, int[][] indices, Vector3[] normals, Vector4[] tangents, Color[] colors, BoneWeight[] boneWeights, List<Vector4>[] uvs, Matrix4x4[] bindposes, BlendShape[] blendShapes)
		{
			return null;
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x856A594", Offset = "0x8566594", VA = "0x856A594")]
		public static Mesh CreateMesh(Vector3[] vertices, int[][] indices, Vector3[] normals, Vector4[] tangents, Color[] colors, BoneWeight[] boneWeights, List<Vector2>[] uvs2D, List<Vector3>[] uvs3D, List<Vector4>[] uvs4D, Matrix4x4[] bindposes, BlendShape[] blendShapes)
		{
			return null;
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x856AE48", Offset = "0x8566E48", VA = "0x856AE48")]
		public static BlendShape[] GetMeshBlendShapes(Mesh mesh)
		{
			return null;
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x856B128", Offset = "0x8567128", VA = "0x856B128")]
		public static void LOG(string s)
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x856AAD8", Offset = "0x8566AD8", VA = "0x856AAD8")]
		public static void ApplyMeshBlendShapes(Mesh mesh, BlendShape[] blendShapes)
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x856B180", Offset = "0x8567180", VA = "0x856B180")]
		public static List<Vector4>[] GetMeshUVs(Mesh mesh)
		{
			return null;
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x856B2C0", Offset = "0x85672C0", VA = "0x856B2C0")]
		public static List<Vector4> GetMeshUVs(Mesh mesh, int channel)
		{
			return null;
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x856B428", Offset = "0x8567428", VA = "0x856B428")]
		public static int GetUsedUVComponents(List<Vector4> uvs)
		{
			return default;
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x856B5D0", Offset = "0x85675D0", VA = "0x856B5D0")]
		public static Vector2[] ConvertUVsTo2D(List<Vector4> uvs)
		{
			return null;
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x856B6A8", Offset = "0x85676A8", VA = "0x856B6A8")]
		public static Vector3[] ConvertUVsTo3D(List<Vector4> uvs)
		{
			return null;
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x856A958", Offset = "0x8566958", VA = "0x856A958")]
		public static Vector2Int[] GetSubMeshIndexMinMax(int[][] indices, out IndexFormat indexFormat)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED MeshUtils.GetSubMeshIndexMinMax RVA=0x856A958 Token=0x6000131");
}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x856B780", Offset = "0x8567780", VA = "0x856B780")]
		private static void GetIndexMinMax(int[] indices, out int minIndex, out int maxIndex)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED MeshUtils.GetIndexMinMax RVA=0x856B780 Token=0x6000132");
}
	}
}
