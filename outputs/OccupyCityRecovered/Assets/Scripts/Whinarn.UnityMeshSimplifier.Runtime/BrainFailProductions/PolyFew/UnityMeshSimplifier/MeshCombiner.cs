using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace BrainFailProductions.PolyFew.UnityMeshSimplifier
{
	[Token(Token = "0x200000F")]
	public static class MeshCombiner
	{
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x8552410", Offset = "0x854E410", VA = "0x8552410")]
		public static Mesh CombineMeshes(Transform rootTransform, MeshRenderer[] renderers, out Material[] resultMaterials, [Optional] Dictionary<Transform, Transform> topLevelParents, [Optional] Dictionary<string, BlendShapeFrame> blendShapes)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED MeshCombiner.CombineMeshes RVA=0x8552410 Token=0x6000060");
}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x8552B7C", Offset = "0x854EB7C", VA = "0x8552B7C")]
		public static Mesh CombineMeshes(Transform rootTransform, SkinnedMeshRenderer[] renderers, out Material[] resultMaterials, out Transform[] resultBones)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED MeshCombiner.CombineMeshes RVA=0x8552B7C Token=0x6000061");
}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x85556FC", Offset = "0x85516FC", VA = "0x85556FC")]
		public static Mesh CombineMeshes(Mesh[] meshes, Matrix4x4[] transforms, Tuple<Matrix4x4, bool>[] normalsTransforms, Material[][] materials, out Material[] resultMaterials, [Optional] Dictionary<string, BlendShapeFrame> blendShapes)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED MeshCombiner.CombineMeshes RVA=0x85556FC Token=0x6000062");
}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x85557BC", Offset = "0x85517BC", VA = "0x85557BC")]
		public static Mesh CombineMeshes(Mesh[] meshes, Matrix4x4[] transforms, Tuple<Matrix4x4, bool>[] normalsTransforms, Material[][] materials, Transform[][] bones, out Material[] resultMaterials, out Transform[] resultBones, [Optional] Dictionary<string, BlendShapeFrame> blendShapes)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED MeshCombiner.CombineMeshes RVA=0x85557BC Token=0x6000063");
}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x8557410", Offset = "0x8553410", VA = "0x8557410")]
		private static Transform GetTopLevelParent(Transform forObject)
		{
			return null;
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x8557318", Offset = "0x8553318", VA = "0x8557318")]
		private static void CopyVertexPositions(List<Vector3> list, Vector3[] arr)
		{
		}

		[Token(Token = "0x6000066")]
		private static void CopyVertexAttributes<T>(ref List<T> dest, IEnumerable<T> src, int previousVertexCount, int meshVertexCount, int totalVertexCount, T defaultValue)
		{
		}

		[Token(Token = "0x6000067")]
		private static T[] MergeArrays<T>(T[] arr1, T[] arr2)
		{
			return null;
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x855700C", Offset = "0x855300C", VA = "0x855700C")]
		private static void TransformVertices(Vector3[] vertices, ref Matrix4x4 transform)
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x8557090", Offset = "0x8553090", VA = "0x8557090")]
		private static void TransformNormals(Vector3[] normals, ref Tuple<Matrix4x4, bool> transform)
		{
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x8557248", Offset = "0x8553248", VA = "0x8557248")]
		private static void TransformTangents(Vector4[] tangents, ref Tuple<Matrix4x4, bool> transform)
		{
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x8556E14", Offset = "0x8552E14", VA = "0x8556E14")]
		private static void RemapBones(BoneWeight[] boneWeights, int[] boneIndices)
		{
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x85574A8", Offset = "0x85534A8", VA = "0x85574A8")]
		private static Matrix4x4 ScaleMatrix(ref Matrix4x4 matrix, float scale)
		{
			return default;
		}
	}
}
