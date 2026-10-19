using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace BrainFailProductions.PolyFewRuntime
{
	[Token(Token = "0x2000D1D")]
	public static class MeshCombiner
	{
		[Token(Token = "0x2000D1E")]
		public struct StaticRenderer
		{
			[Token(Token = "0x4005DC2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string name;

			[Token(Token = "0x4005DC3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public bool isNewMesh;

			[Token(Token = "0x4005DC4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x4005DC5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Mesh mesh;

			[Token(Token = "0x4005DC6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Material[] materials;
		}

		[Token(Token = "0x2000D1F")]
		public struct SkinnedRenderer
		{
			[Token(Token = "0x4005DC7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool hasBlendShapes;

			[Token(Token = "0x4005DC8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string name;

			[Token(Token = "0x4005DC9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool isNewMesh;

			[Token(Token = "0x4005DCA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform transform;

			[Token(Token = "0x4005DCB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Mesh mesh;

			[Token(Token = "0x4005DCC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Material[] materials;

			[Token(Token = "0x4005DCD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Transform rootBone;

			[Token(Token = "0x4005DCE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform[] bones;
		}

		[Serializable]
		[Token(Token = "0x2000D20")]
		public struct BlendShape
		{
			[Token(Token = "0x4005DCF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string ShapeName;

			[Token(Token = "0x4005DD0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public BlendShapeFrame[] Frames;

			[Token(Token = "0x60051A6")]
			[Address(RVA = "0x42E71C0", Offset = "0x42E31C0", VA = "0x42E71C0")]
			public BlendShape(string shapeName, BlendShapeFrame[] frames)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED MeshCombiner.BlendShape..ctor RVA=0x42E71C0 Token=0x60051A6");
}
		}

		[Serializable]
		[Token(Token = "0x2000D21")]
		public struct BlendShapeFrame
		{
			[Token(Token = "0x4005DD1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string shapeName;

			[Token(Token = "0x4005DD2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float frameWeight;

			[Token(Token = "0x4005DD3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3[] deltaVertices;

			[Token(Token = "0x4005DD4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3[] deltaNormals;

			[Token(Token = "0x4005DD5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3[] deltaTangents;

			[Token(Token = "0x4005DD6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int vertexOffset;

			[Token(Token = "0x60051A7")]
			[Address(RVA = "0x42E71C8", Offset = "0x42E31C8", VA = "0x42E71C8")]
			public BlendShapeFrame(float frameWeight, Vector3[] deltaVertices, Vector3[] deltaNormals, Vector3[] deltaTangents)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED MeshCombiner.BlendShapeFrame..ctor RVA=0x42E71C8 Token=0x60051A7");
}

			[Token(Token = "0x60051A8")]
			[Address(RVA = "0x42E4F84", Offset = "0x42E0F84", VA = "0x42E4F84")]
			public BlendShapeFrame(string shapeName, float frameWeight, Vector3[] deltaVertices, Vector3[] deltaNormals, Vector3[] deltaTangents, int vertexOffset)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED MeshCombiner.BlendShapeFrame..ctor RVA=0x42E4F84 Token=0x60051A8");
}
		}

		[Token(Token = "0x2000D22")]
		public static class MeshUtils
		{
			[Token(Token = "0x4005DD7")]
			public const int UVChannelCount = 8;

			[Token(Token = "0x60051A9")]
			[Address(RVA = "0x42E724C", Offset = "0x42E324C", VA = "0x42E724C")]
			public static Mesh CreateMesh(Vector3[] vertices, int[][] indices, Vector3[] normals, Vector4[] tangents, Color[] colors, BoneWeight[] boneWeights, List<Vector2>[] uvs, Matrix4x4[] bindposes, BlendShape[] blendShapes)
			{
				return null;
			}

			[Token(Token = "0x60051AA")]
			[Address(RVA = "0x42E6D78", Offset = "0x42E2D78", VA = "0x42E6D78")]
			public static Mesh CreateMesh(Vector3[] vertices, int[][] indices, Vector3[] normals, Vector4[] tangents, Color[] colors, BoneWeight[] boneWeights, List<Vector4>[] uvs, Matrix4x4[] bindposes, BlendShape[] blendShapes)
			{
				return null;
			}

			[Token(Token = "0x60051AB")]
			[Address(RVA = "0x42E7274", Offset = "0x42E3274", VA = "0x42E7274")]
			public static Mesh CreateMesh(Vector3[] vertices, int[][] indices, Vector3[] normals, Vector4[] tangents, Color[] colors, BoneWeight[] boneWeights, List<Vector2>[] uvs2D, List<Vector3>[] uvs3D, List<Vector4>[] uvs4D, Matrix4x4[] bindposes, BlendShape[] blendShapes)
			{
				return null;
			}

			[Token(Token = "0x60051AC")]
			[Address(RVA = "0x42E78F0", Offset = "0x42E38F0", VA = "0x42E78F0")]
			public static BlendShape[] GetMeshBlendShapes(Mesh mesh)
			{
				return null;
			}

			[Token(Token = "0x60051AD")]
			[Address(RVA = "0x42E778C", Offset = "0x42E378C", VA = "0x42E778C")]
			public static void ApplyMeshBlendShapes(Mesh mesh, BlendShape[] blendShapes)
			{
			}

			[Token(Token = "0x60051AE")]
			[Address(RVA = "0x42E663C", Offset = "0x42E263C", VA = "0x42E663C")]
			public static List<Vector4>[] GetMeshUVs(Mesh mesh)
			{
				return null;
			}

			[Token(Token = "0x60051AF")]
			[Address(RVA = "0x42E7BC8", Offset = "0x42E3BC8", VA = "0x42E7BC8")]
			public static List<Vector4> GetMeshUVs(Mesh mesh, int channel)
			{
				return null;
			}

			[Token(Token = "0x60051B0")]
			[Address(RVA = "0x42E7D30", Offset = "0x42E3D30", VA = "0x42E7D30")]
			public static int GetUsedUVComponents(List<Vector4> uvs)
			{
				return default;
			}

			[Token(Token = "0x60051B1")]
			[Address(RVA = "0x42E7ED8", Offset = "0x42E3ED8", VA = "0x42E7ED8")]
			public static Vector2[] ConvertUVsTo2D(List<Vector4> uvs)
			{
				return null;
			}

			[Token(Token = "0x60051B2")]
			[Address(RVA = "0x42E7FB0", Offset = "0x42E3FB0", VA = "0x42E7FB0")]
			public static Vector3[] ConvertUVsTo3D(List<Vector4> uvs)
			{
				return null;
			}

			[Token(Token = "0x60051B3")]
			[Address(RVA = "0x42E760C", Offset = "0x42E360C", VA = "0x42E760C")]
			public static Vector2Int[] GetSubMeshIndexMinMax(int[][] indices, out IndexFormat indexFormat)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED MeshCombiner.MeshUtils.GetSubMeshIndexMinMax RVA=0x42E760C Token=0x60051B3");
}

			[Token(Token = "0x60051B4")]
			[Address(RVA = "0x42E8088", Offset = "0x42E4088", VA = "0x42E8088")]
			private static void GetIndexMinMax(int[] indices, out int minIndex, out int maxIndex)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED MeshCombiner.MeshUtils.GetIndexMinMax RVA=0x42E8088 Token=0x60051B4");
}
		}

		[Token(Token = "0x4005DBE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static MeshRenderer[] unityCombinedMeshRenderers;

		[Token(Token = "0x4005DBF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Material[] unityCombinedMeshesMats;

		[Token(Token = "0x4005DC0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static bool didUseUnityCombine;

		[Token(Token = "0x4005DC1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public static bool generateUV2;

		[Token(Token = "0x6005190")]
		[Address(RVA = "0x42E17F0", Offset = "0x42DD7F0", VA = "0x42E17F0")]
		public static StaticRenderer[] GetStaticRenderers(MeshRenderer[] renderers)
		{
			return null;
		}

		[Token(Token = "0x6005191")]
		[Address(RVA = "0x42E1B20", Offset = "0x42DDB20", VA = "0x42E1B20")]
		public static SkinnedRenderer[] GetSkinnedRenderers(SkinnedMeshRenderer[] renderers)
		{
			return null;
		}

		[Token(Token = "0x6005192")]
		[Address(RVA = "0x42E1DD4", Offset = "0x42DDDD4", VA = "0x42E1DD4")]
		public static StaticRenderer[] CombineStaticMeshes(Transform transform, int levelIndex, MeshRenderer[] renderers, bool autoName = true, string combinedBaseName = "")
		{
			return null;
		}

		[Token(Token = "0x6005193")]
		[Address(RVA = "0x42E38DC", Offset = "0x42DF8DC", VA = "0x42E38DC")]
		public static SkinnedRenderer[] CombineSkinnedMeshes(Transform transform, int levelIndex, SkinnedMeshRenderer[] renderers, ref SkinnedMeshRenderer[] renderersActuallyCombined, bool autoName = true, string combinedBaseName = "")
		{
			return null;
		}

		[Token(Token = "0x6005194")]
		[Address(RVA = "0x42E30F4", Offset = "0x42DF0F4", VA = "0x42E30F4")]
		public static Mesh CombineMeshes(Transform rootTransform, MeshRenderer[] renderers, out Material[] resultMaterials, [Optional] Dictionary<Transform, Transform> topLevelParents, [Optional] Dictionary<string, BlendShapeFrame> blendShapes)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED MeshCombiner.CombineMeshes RVA=0x42E30F4 Token=0x6005194");
}

		[Token(Token = "0x6005195")]
		[Address(RVA = "0x42E4008", Offset = "0x42E0008", VA = "0x42E4008")]
		public static Mesh CombineMeshes(Transform rootTransform, SkinnedMeshRenderer[] renderers, out Material[] resultMaterials, out Transform[] resultBones)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED MeshCombiner.CombineMeshes RVA=0x42E4008 Token=0x6005195");
}

		[Token(Token = "0x6005196")]
		[Address(RVA = "0x42E4EC4", Offset = "0x42E0EC4", VA = "0x42E4EC4")]
		public static Mesh CombineMeshes(Mesh[] meshes, Matrix4x4[] transforms, Tuple<Matrix4x4, bool>[] normalsTransforms, Material[][] materials, out Material[] resultMaterials, [Optional] Dictionary<string, BlendShapeFrame> blendShapes)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED MeshCombiner.CombineMeshes RVA=0x42E4EC4 Token=0x6005196");
}

		[Token(Token = "0x6005197")]
		[Address(RVA = "0x42E4F9C", Offset = "0x42E0F9C", VA = "0x42E4F9C")]
		public static Mesh CombineMeshes(Mesh[] meshes, Matrix4x4[] transforms, Tuple<Matrix4x4, bool>[] normalsTransforms, Material[][] materials, Transform[][] bones, out Material[] resultMaterials, out Transform[] resultBones, [Optional] Dictionary<string, BlendShapeFrame> blendShapes)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED MeshCombiner.CombineMeshes RVA=0x42E4F9C Token=0x6005197");
}

		[Token(Token = "0x6005198")]
		[Address(RVA = "0x42E6DA4", Offset = "0x42E2DA4", VA = "0x42E6DA4")]
		private static void ParentAndResetTransform(Transform transform, Transform parentTransform)
		{
		}

		[Token(Token = "0x6005199")]
		[Address(RVA = "0x42E6E8C", Offset = "0x42E2E8C", VA = "0x42E6E8C")]
		private static void ParentAndOffsetTransform(Transform transform, Transform parentTransform, Transform originalTransform)
		{
		}

		[Token(Token = "0x600519A")]
		[Address(RVA = "0x42E4D20", Offset = "0x42E0D20", VA = "0x42E4D20")]
		private static Transform FindBestRootBone(Transform transform, SkinnedMeshRenderer[] skinnedMeshRenderers)
		{
			return null;
		}

		[Token(Token = "0x600519B")]
		[Address(RVA = "0x42E6F10", Offset = "0x42E2F10", VA = "0x42E6F10")]
		private static Transform FindBestRootBone(Dictionary<Transform, Transform> topLevelParents, SkinnedMeshRenderer[] skinnedMeshRenderers)
		{
			return null;
		}

		[Token(Token = "0x600519C")]
		[Address(RVA = "0x42E7104", Offset = "0x42E3104", VA = "0x42E7104")]
		private static Transform GetTopLevelParent(Transform forObject)
		{
			return null;
		}

		[Token(Token = "0x600519D")]
		[Address(RVA = "0x42E6C80", Offset = "0x42E2C80", VA = "0x42E6C80")]
		private static void CopyVertexPositions(List<Vector3> list, Vector3[] arr)
		{
		}

		[Token(Token = "0x600519E")]
		private static void CopyVertexAttributes<T>(ref List<T> dest, IEnumerable<T> src, int previousVertexCount, int meshVertexCount, int totalVertexCount, T defaultValue)
		{
		}

		[Token(Token = "0x600519F")]
		private static T[] MergeArrays<T>(T[] arr1, T[] arr2)
		{
			return null;
		}

		[Token(Token = "0x60051A0")]
		[Address(RVA = "0x42E6974", Offset = "0x42E2974", VA = "0x42E6974")]
		private static void TransformVertices(Vector3[] vertices, ref Matrix4x4 transform)
		{
		}

		[Token(Token = "0x60051A1")]
		[Address(RVA = "0x42E69F8", Offset = "0x42E29F8", VA = "0x42E69F8")]
		private static void TransformNormals(Vector3[] normals, ref Tuple<Matrix4x4, bool> transform)
		{
		}

		[Token(Token = "0x60051A2")]
		[Address(RVA = "0x42E6BB0", Offset = "0x42E2BB0", VA = "0x42E6BB0")]
		private static void TransformTangents(Vector4[] tangents, ref Tuple<Matrix4x4, bool> transform)
		{
		}

		[Token(Token = "0x60051A3")]
		[Address(RVA = "0x42E677C", Offset = "0x42E277C", VA = "0x42E677C")]
		private static void RemapBones(BoneWeight[] boneWeights, int[] boneIndices)
		{
		}

		[Token(Token = "0x60051A4")]
		[Address(RVA = "0x42E719C", Offset = "0x42E319C", VA = "0x42E719C")]
		private static Matrix4x4 ScaleMatrix(ref Matrix4x4 matrix, float scale)
		{
			return default;
		}

		[Token(Token = "0x60051A5")]
		[Address(RVA = "0x42E23DC", Offset = "0x42DE3DC", VA = "0x42E23DC")]
		private static void CombineMeshesUnity(Transform parentTransform, MeshFilter[] meshFilters)
		{
		}
	}
}
