using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace BrainFailProductions.PolyFew.UnityMeshSimplifier
{
	[Token(Token = "0x200000A")]
	public static class LODGenerator
	{
		[Token(Token = "0x200000B")]
		public struct StaticRenderer
		{
			[Token(Token = "0x400001A")]
			[FieldOffset(Offset = "0x0")]
			public string name;

			[Token(Token = "0x400001B")]
			[FieldOffset(Offset = "0x8")]
			public bool isNewMesh;

			[Token(Token = "0x400001C")]
			[FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x400001D")]
			[FieldOffset(Offset = "0x18")]
			public Mesh mesh;

			[Token(Token = "0x400001E")]
			[FieldOffset(Offset = "0x20")]
			public Material[] materials;

			[Token(Token = "0x400001F")]
			[FieldOffset(Offset = "0x28")]
			public MeshRenderer originalRenderer;
		}

		[Token(Token = "0x200000C")]
		public struct SkinnedRenderer
		{
			[Token(Token = "0x4000020")]
			[FieldOffset(Offset = "0x0")]
			public bool hasBlendShapes;

			[Token(Token = "0x4000021")]
			[FieldOffset(Offset = "0x8")]
			public string name;

			[Token(Token = "0x4000022")]
			[FieldOffset(Offset = "0x10")]
			public bool isNewMesh;

			[Token(Token = "0x4000023")]
			[FieldOffset(Offset = "0x18")]
			public Transform transform;

			[Token(Token = "0x4000024")]
			[FieldOffset(Offset = "0x20")]
			public Mesh mesh;

			[Token(Token = "0x4000025")]
			[FieldOffset(Offset = "0x28")]
			public Material[] materials;

			[Token(Token = "0x4000026")]
			[FieldOffset(Offset = "0x30")]
			public Transform rootBone;

			[Token(Token = "0x4000027")]
			[FieldOffset(Offset = "0x38")]
			public Transform[] bones;

			[Token(Token = "0x4000028")]
			[FieldOffset(Offset = "0x40")]
			public SkinnedMeshRenderer originalRenderer;
		}

		[Token(Token = "0x4000018")]
		public const string LODParentGameObjectName = "_UMS_LODs_";

		[Token(Token = "0x4000019")]
		public const string LODAssetParentPath = "Assets/UMS_LODs/";

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x854F54C", Offset = "0x854B54C", VA = "0x854F54C")]
		public static LODGroup GenerateLODs(LODGeneratorHelper generatorHelper)
		{
			return null;
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x855044C", Offset = "0x854C44C", VA = "0x855044C")]
		public static LODGroup GenerateLODs(GameObject gameObject, LODLevel[] levels, bool autoCollectRenderers, SimplificationOptions simplificationOptions)
		{
			return null;
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x854F68C", Offset = "0x854B68C", VA = "0x854F68C")]
		public static LODGroup GenerateLODs(GameObject gameObject, LODLevel[] levels, bool autoCollectRenderers, SimplificationOptions simplificationOptions, string saveAssetsPath)
		{
			return null;
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x85520CC", Offset = "0x854E0CC", VA = "0x85520CC")]
		public static bool DestroyLODs(LODGeneratorHelper generatorHelper)
		{
			return default;
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x855218C", Offset = "0x854E18C", VA = "0x855218C")]
		public static bool DestroyLODs(GameObject gameObject)
		{
			return default;
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x85511A8", Offset = "0x854D1A8", VA = "0x85511A8")]
		public static StaticRenderer[] GetStaticRenderers(MeshRenderer[] renderers)
		{
			return null;
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x85514F0", Offset = "0x854D4F0", VA = "0x85514F0")]
		public static SkinnedRenderer[] GetSkinnedRenderers(SkinnedMeshRenderer[] renderers)
		{
			return null;
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x85507BC", Offset = "0x854C7BC", VA = "0x85507BC")]
		public static StaticRenderer[] CombineStaticMeshes(Transform transform, int levelIndex, MeshRenderer[] renderers, bool autoName = true, string combinedBaseName = "")
		{
			return null;
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x8550A78", Offset = "0x854CA78", VA = "0x8550A78")]
		public static SkinnedRenderer[] CombineSkinnedMeshes(Transform transform, int levelIndex, SkinnedMeshRenderer[] renderers, ref SkinnedMeshRenderer[] renderersActuallyCombined, bool autoName = true, string combinedBaseName = "")
		{
			return null;
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x8550628", Offset = "0x854C628", VA = "0x8550628")]
		private static void ParentAndResetTransform(Transform transform, Transform parentTransform)
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x8553924", Offset = "0x854F924", VA = "0x8553924")]
		private static void ParentAndOffsetTransform(Transform transform, Transform parentTransform, Transform originalTransform)
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x8551BB8", Offset = "0x854DBB8", VA = "0x8551BB8")]
		private static MeshRenderer CreateLevelRenderer(string name, Transform parentTransform, Transform originalTransform, Mesh mesh, Material[] materials, ref LODLevel level)
		{
			return null;
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x8551E28", Offset = "0x854DE28", VA = "0x8551E28")]
		private static SkinnedMeshRenderer CreateSkinnedLevelRenderer(string name, Transform parentTransform, Transform originalTransform, Mesh mesh, Material[] materials, Transform rootBone, Transform[] bones, ref LODLevel level)
		{
			return null;
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x8553780", Offset = "0x854F780", VA = "0x8553780")]
		private static Transform FindBestRootBone(Transform transform, SkinnedMeshRenderer[] skinnedMeshRenderers)
		{
			return null;
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x8553AE4", Offset = "0x854FAE4", VA = "0x8553AE4")]
		private static Transform FindBestRootBone(Dictionary<Transform, Transform> topLevelParents, SkinnedMeshRenderer[] skinnedMeshRenderers)
		{
			return null;
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x85539A8", Offset = "0x854F9A8", VA = "0x85539A8")]
		private static void SetupLevelRenderer(Renderer renderer, ref LODLevel level)
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x8550710", Offset = "0x854C710", VA = "0x8550710")]
		private static Renderer[] GetChildRenderersForLOD(GameObject gameObject)
		{
			return null;
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x8553CD8", Offset = "0x854FCD8", VA = "0x8553CD8")]
		private static void CollectChildRenderersForLOD(Transform transform, List<Renderer> resultRenderers)
		{
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x85517B8", Offset = "0x854D7B8", VA = "0x85517B8")]
		private static Mesh SimplifyMesh(Mesh mesh, float quality, SimplificationOptions options)
		{
			return null;
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x8551AF4", Offset = "0x854DAF4", VA = "0x8551AF4")]
		private static void DestroyObject(Object obj)
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x855205C", Offset = "0x854E05C", VA = "0x855205C")]
		private static void CreateBackup(GameObject gameObject, Renderer[] originalRenderers)
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x8552318", Offset = "0x854E318", VA = "0x8552318")]
		private static void RestoreBackup(GameObject gameObject)
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x855240C", Offset = "0x854E40C", VA = "0x855240C")]
		private static void DestroyLODAssets(Transform transform)
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x8554E38", Offset = "0x8550E38", VA = "0x8554E38")]
		private static void DestroyLODMaterialAsset(Material material)
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x8554E94", Offset = "0x8550E94", VA = "0x8554E94")]
		private static void DestroyLODAsset(Object asset)
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x85518D4", Offset = "0x854D8D4", VA = "0x85518D4")]
		private static void SaveLODMeshAsset(Object asset, string gameObjectName, string rendererName, int levelIndex, string meshName, string saveAssetsPath)
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x855501C", Offset = "0x855101C", VA = "0x855501C")]
		private static void SaveAsset(Object asset, string path)
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x8555020", Offset = "0x8551020", VA = "0x8555020")]
		private static void CreateParentDirectory(string path)
		{
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x8554EF0", Offset = "0x8550EF0", VA = "0x8554EF0")]
		private static string MakePathSafe(string name)
		{
			return null;
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x8550478", Offset = "0x854C478", VA = "0x8550478")]
		private static string ValidateSaveAssetsPath(string saveAssetsPath)
		{
			return null;
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x8555024", Offset = "0x8551024", VA = "0x8555024")]
		private static bool DeleteEmptyDirectory(string path)
		{
			return default;
		}
	}
}
