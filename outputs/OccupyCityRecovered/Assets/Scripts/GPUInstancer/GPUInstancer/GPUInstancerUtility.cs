using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Jobs;

namespace GPUInstancer
{
	[Token(Token = "0x2000055")]
	public static class GPUInstancerUtility
	{
		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Texture2D dummyHiZTex;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static GPUIMatrixHandlingType matrixHandlingType;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Dictionary<GPUInstancerEventType, UnityEvent> _eventDictionary;

		[Token(Token = "0x60001BF")]
		public static void InitializeGPUBuffers<T>(List<T> runtimeDataList) where T : GPUInstancerRuntimeData
		{
		}

		[Token(Token = "0x60001C0")]
		public static void InitializeGPUBuffer<T>(T runtimeData) where T : GPUInstancerRuntimeData
		{
		}

		[Token(Token = "0x60001C1")]
		public static void SetAppendBuffers<T>(T runtimeData) where T : GPUInstancerRuntimeData
		{
		}

		[Token(Token = "0x60001C2")]
		private static void SetAppendBuffersDefault<T>(T runtimeData) where T : GPUInstancerRuntimeData
		{
		}

		[Token(Token = "0x60001C3")]
		private static void SetAppendBuffersVulkan<T>(T runtimeData) where T : GPUInstancerRuntimeData
		{
		}

		[Token(Token = "0x60001C4")]
		private static void SetAppendBuffersGLES3<T>(T runtimeData) where T : GPUInstancerRuntimeData
		{
		}

		[Token(Token = "0x60001C5")]
		private static void SetRenderingLayerMask<T>(T runtimeData, GPUInstancerRenderer renderer, uint renderingLayerMask) where T : GPUInstancerRuntimeData
		{
		}

		[Token(Token = "0x60001C6")]
		private static void SetRenderingLayerMask<T>(T runtimeData, GPUInstancerRenderer renderer) where T : GPUInstancerRuntimeData
		{
		}

		[Token(Token = "0x60001C7")]
		public static void SetRenderingLayerMask<T>(T runtimeData, uint renderingLayerMask, int lodLevel = -1, int rendererIndex = -1) where T : GPUInstancerRuntimeData
		{
		}

		[Token(Token = "0x60001C8")]
		public static void UpdateGPUBuffers<T>(ComputeShader cameraComputeShader, int[] cameraComputeKernelIDs, ComputeShader visibilityComputeShader, int[] instanceVisibilityComputeKernelIDs, List<T> runtimeDataList, GPUInstancerCameraData cameraData, bool isManagerFrustumCulling, bool isManagerOcclusionCulling, bool showRenderedAmount, bool isInitial) where T : GPUInstancerRuntimeData
		{
		}

		[Token(Token = "0x60001C9")]
		public static void UpdateGPUBuffer<T>(ComputeShader cameraComputeShader, int[] cameraComputeKernelIDs, ComputeShader visibilityComputeShader, int[] instanceVisibilityComputeKernelIDs, T runtimeData, GPUInstancerCameraData cameraData, bool isManagerFrustumCulling, bool isManagerOcclusionCulling, bool showRenderedAmount, bool isInitial) where T : GPUInstancerRuntimeData
		{
		}

		[Token(Token = "0x60001CA")]
		public static void DispatchCSInstancedCameraCalculation<T>(ComputeShader cameraComputeShader, int[] cameraComputeKernelIDs, T runtimeData, GPUInstancerCameraData cameraData, bool isManagerFrustumCulling, bool isManagerOcclusionCulling, bool isInitial) where T : GPUInstancerRuntimeData
		{
		}

		[Token(Token = "0x60001CB")]
		public static void DispatchCSInstancedVisibilityCalculation<T>(ComputeShader visibilityComputeShader, int instanceVisibilityComputeKernelId, T runtimeData, bool isShadow, int lodShift, int lodAppendIndex) where T : GPUInstancerRuntimeData
		{
		}

		[Token(Token = "0x60001CC")]
		public static void GPUIDrawMeshInstancedIndirect<T>(List<T> runtimeDataList, Bounds instancingBounds, GPUInstancerCameraData cameraData, int layerMask = -1, bool lightProbeDisabled = false) where T : GPUInstancerRuntimeData
		{
		}

		[Token(Token = "0x60001CD")]
		public static void DispatchBufferToTexture<T>(List<T> runtimeDataList, ComputeShader bufferToTextureComputeShader, int bufferToTextureComputeKernelID, int bufferToTextureCrossFadeKernelID = 1) where T : GPUInstancerRuntimeData
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x73E261C", Offset = "0x73DE61C", VA = "0x73E261C")]
		public static bool IsInLayer(int layerMask, int layer)
		{
			return default;
		}

		[Token(Token = "0x60001CF")]
		public static void ReleaseInstanceBuffers<T>(List<T> runtimeDataList) where T : GPUInstancerRuntimeData
		{
		}

		[Token(Token = "0x60001D0")]
		public static void ReleaseInstanceBuffers<T>(T runtimeData) where T : GPUInstancerRuntimeData
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x73E2634", Offset = "0x73DE634", VA = "0x73E2634")]
		public static void ReleaseSPBuffers(GPUInstancerSpatialPartitioningData<GPUInstancerCell> spData)
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x73E26BC", Offset = "0x73DE6BC", VA = "0x73E26BC")]
		public static void ReleaseSPCell(GPUInstancerCell spCell)
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x73E2868", Offset = "0x73DE868", VA = "0x73E2868")]
		public static void SetDetailInstancePrototypes(GameObject gameObject, List<GPUInstancerPrototype> detailInstancePrototypes, DetailPrototype[] detailPrototypes, int quadCount, GPUInstancerTerrainSettings terrainSettings, bool forceNew)
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x73E29C8", Offset = "0x73DE9C8", VA = "0x73E29C8")]
		public static void AddDetailInstancePrototypeFromTerrainPrototype(GameObject gameObject, List<GPUInstancerPrototype> detailInstancePrototypes, DetailPrototype terrainDetailPrototype, int detailIndex, int quadCount, GPUInstancerTerrainSettings terrainSettings, [Optional] GameObject replacementPrefab)
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x73E507C", Offset = "0x73E107C", VA = "0x73E507C")]
		public static void ImportFoliageSRPShader()
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x73E5080", Offset = "0x73E1080", VA = "0x73E5080")]
		public static void ImportFoliageSRPShaderPopup()
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x73E5084", Offset = "0x73E1084", VA = "0x73E5084")]
		public static void OnFoliageSRPShaderImportCompleted(string foliageShaderPackageName)
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x73E5088", Offset = "0x73E1088", VA = "0x73E5088")]
		public static void AddDetailInstanceRuntimeDataToList(List<GPUInstancerRuntimeData> runtimeDataList, List<GPUInstancerPrototype> detailPrototypes, GPUInstancerTerrainSettings terrainSettings, int detailLayer)
		{
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x73E7178", Offset = "0x73E3178", VA = "0x73E7178")]
		public static void UpdateDetailInstanceRuntimeDataList(List<GPUInstancerRuntimeData> runtimeDataList, GPUInstancerTerrainSettings terrainSettings, bool updateMeshes = false, int detailLayer = 0)
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x73E7158", Offset = "0x73E3158", VA = "0x73E7158")]
		public static float GetDistanceRelativeHeight(GPUInstancerDetailPrototype detailPrototype)
		{
			return default;
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x73E8090", Offset = "0x73E4090", VA = "0x73E8090")]
		public static void SetPrefabInstancePrototypes(GameObject gameObject, List<GPUInstancerPrototype> prototypeList, List<GameObject> prefabList, bool forceNew)
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x73E8334", Offset = "0x73E4334", VA = "0x73E8334")]
		public static GPUInstancerPrefabPrototype GeneratePrefabPrototype(GameObject go, bool forceNew, bool attachScript = true)
		{
			return null;
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x73E887C", Offset = "0x73E487C", VA = "0x73E887C")]
		public static void SetTreeInstancePrototypes(GameObject gameObject, List<GPUInstancerPrototype> treeIntancePrototypes, TreePrototype[] treePrototypes, GPUInstancerTerrainSettings terrainSettings, bool forceNew)
		{
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x73E89CC", Offset = "0x73E49CC", VA = "0x73E89CC")]
		public static void AddTreeInstancePrototypeFromTerrainPrototype(GameObject gameObject, List<GPUInstancerPrototype> treeInstancePrototypes, TreePrototype terrainTreePrototype, int treeIndex, GPUInstancerTerrainSettings terrainSettings)
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x73E8C58", Offset = "0x73E4C58", VA = "0x73E8C58")]
		public static void AddTreeInstanceRuntimeDataToList(List<GPUInstancerRuntimeData> runtimeDataList, List<GPUInstancerPrototype> treePrototypes, GPUInstancerTerrainSettings terrainSettings)
		{
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x73E3234", Offset = "0x73DF234", VA = "0x73E3234")]
		public static void DetermineTreePrototypeType(GPUInstancerPrototype prototype)
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x73E8EB4", Offset = "0x73E4EB4", VA = "0x73E8EB4")]
		public static void ImportSpeedTree8Shader()
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x73E8EB8", Offset = "0x73E4EB8", VA = "0x73E8EB8")]
		public static void ImportSpeedTree8ShaderPopup()
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x73E6980", Offset = "0x73E2980", VA = "0x73E6980")]
		public static Mesh CreateCrossQuadsMeshForDetailGrass(float width, float height, string name, int quality)
		{
			return null;
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x73E8EBC", Offset = "0x73E4EBC", VA = "0x73E8EBC")]
		public static Mesh GenerateQuadMesh(float width, float height, [Optional] Rect? uvRect, bool centerPivotAtBottom = false, float pivotOffsetX = 0f, float pivotOffsetY = 0f)
		{
			return null;
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x73E9380", Offset = "0x73E5380", VA = "0x73E9380")]
		public static List<int[]> GetDetailMapsFromTerrain(Terrain terrain, List<GPUInstancerPrototype> detailPrototypeList)
		{
			return null;
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x73E965C", Offset = "0x73E565C", VA = "0x73E965C")]
		public static Bounds GenerateBoundsFromTerrainPositionAndSize(Vector3 position, Vector3 size)
		{
			return default;
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x73E9688", Offset = "0x73E5688", VA = "0x73E9688")]
		public static float SampleTerrainHeight(float px, float py, float leftBottomH, float leftTopH, float rightBottomH, float rightTopH)
		{
			return default;
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x73E96D0", Offset = "0x73E56D0", VA = "0x73E96D0")]
		public static Vector3 ComputeTerrainNormal(float leftBottomH, float leftTopH, float rightBottomH, float scale)
		{
			return default;
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x73E97BC", Offset = "0x73E57BC", VA = "0x73E97BC")]
		public static int GCD(int[] numbers)
		{
			return default;
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x73E9854", Offset = "0x73E5854", VA = "0x73E9854")]
		public static int GCD(int a, int b)
		{
			return default;
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x73E987C", Offset = "0x73E587C", VA = "0x73E987C")]
		public static IEnumerable<int> GetDivisors(int n)
		{
			return null;
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x73E9968", Offset = "0x73E5968", VA = "0x73E9968")]
		public static void AssignBillboardBinding(GPUInstancerPrototype prototype)
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x73E393C", Offset = "0x73DF93C", VA = "0x73E393C")]
		public static void GeneratePrototypeBillboard(GPUInstancerPrototype prototype, bool forceRegenerate = false)
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x73E9AAC", Offset = "0x73E5AAC", VA = "0x73E9AAC")]
		public static Texture2D DilateBillboardTexture(Texture2D billboardTexture, int frameCount, bool isNormal)
		{
			return null;
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x73E6050", Offset = "0x73E2050", VA = "0x73E6050")]
		public static void AddBillboardToRuntimeData(GPUInstancerRuntimeData runtimeData)
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x73E9EF4", Offset = "0x73E5EF4", VA = "0x73E9EF4")]
		public static Material GetBillboardMaterial(GPUInstancerPrototype prototype)
		{
			return null;
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x73EACC8", Offset = "0x73E6CC8", VA = "0x73EACC8")]
		public static string GetBillboardShaderName(GPUInstancerPrototype prototype)
		{
			return null;
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x73E38F0", Offset = "0x73DF8F0", VA = "0x73E38F0")]
		public static bool IsBillboardGeneratedByDefault(GPUInstancerPrototype prototype)
		{
			return default;
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x73EB358", Offset = "0x73E7358", VA = "0x73EB358")]
		public static void ShowBillboardQuad(GPUInstancerPrototype prototype, Vector3 quadPos)
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x73E29C4", Offset = "0x73DE9C4", VA = "0x73E29C4")]
		public static void RemoveAssetsOfType(UnityEngine.Object baseAsset, Type type)
		{
		}

		[Token(Token = "0x60001F5")]
		public static void RemoveUnusedAssets<T>(UnityEngine.Object baseAsset, List<T> prototypeList, Type prototypeType) where T : GPUInstancerPrototype
		{
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x73E4C50", Offset = "0x73E0C50", VA = "0x73E4C50")]
		public static void AddObjectToAsset(UnityEngine.Object baseAsset, UnityEngine.Object objectToAdd)
		{
		}

		[Token(Token = "0x60001F7")]
		public static void SetPrototypeListFromAssets<T>(UnityEngine.Object baseAsset, List<T> prototypeList, Type prototypeType) where T : GPUInstancerPrototype
		{
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x73D8014", Offset = "0x73D4014", VA = "0x73D8014")]
		public static string GetAssetGUID(UnityEngine.Object assetObject)
		{
			return null;
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x73EB690", Offset = "0x73E7690", VA = "0x73EB690")]
		public static void CalculateSpatialPartitioningValuesFromTerrain(GPUInstancerSpatialPartitioningData<GPUInstancerCell> spData, Terrain terrain, float maxDetailDistance, float preferedCellSize = 0f)
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x73E4C54", Offset = "0x73E0C54", VA = "0x73E4C54")]
		public static void GenerateInstancedShadersForGameObject(GPUInstancerPrototype prototype)
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x73EBCC0", Offset = "0x73E7CC0", VA = "0x73EBCC0")]
		public static bool IsShaderInstanced(Shader shader)
		{
			return default;
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x73E1D18", Offset = "0x73DDD18", VA = "0x73E1D18")]
		public static Shader CreateInstancedShader(Shader originalShader, bool useOriginal = false)
		{
			return null;
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x73EBE28", Offset = "0x73E7E28", VA = "0x73EBE28")]
		public static Shader CreateInstancedShaderPack(Shader originalShader, string originalAssetPath)
		{
			return null;
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x73DF31C", Offset = "0x73DB31C", VA = "0x73DF31C")]
		public static Shader FindShader(string shaderName, bool loadFromAddressables = true)
		{
			return null;
		}

		[Token(Token = "0x60001FF")]
		public static T[] MirrorAndFlatten<T>(this T[,] array2D)
		{
			return null;
		}

		[Token(Token = "0x6000200")]
		public static T[] MirrorAndFlatten<T>(this T[,] array2D, int xBase, int yBase, int width, int height)
		{
			return null;
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x73EBE30", Offset = "0x73E7E30", VA = "0x73EBE30")]
		public static float Range(this System.Random prng, float min, float max)
		{
			return default;
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x73EBE78", Offset = "0x73E7E78", VA = "0x73EBE78")]
		public static void Matrix4x4ToFloatArray(this Matrix4x4 matrix4x4, float[] floatArray)
		{
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x73EC098", Offset = "0x73E8098", VA = "0x73EC098")]
		public static Matrix4x4 Matrix4x4FromString(string matrixStr)
		{
			return default;
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x73EC1B0", Offset = "0x73E81B0", VA = "0x73EC1B0")]
		public static string Matrix4x4ToString(Matrix4x4 matrix4x4)
		{
			return null;
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x73EC26C", Offset = "0x73E826C", VA = "0x73EC26C")]
		public static void SetMatrix4x4ToTransform(this Transform transform, Matrix4x4 matrix)
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x73EC48C", Offset = "0x73E848C", VA = "0x73EC48C")]
		public static float[] Matrix4x4ToFloatArray(this Matrix4x4 matrix4x4)
		{
			return null;
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x73EC504", Offset = "0x73E8504", VA = "0x73EC504")]
		public static void SetDataSingle(this ComputeBuffer computeBuffer, Matrix4x4[] data, int managedBufferStartIndex, int computeBufferStartIndex)
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x73EC844", Offset = "0x73E8844", VA = "0x73EC844")]
		public static void SetDataPartial(this ComputeBuffer computeBuffer, Matrix4x4[] data, int managedBufferStartIndex, int computeBufferStartIndex, int count, [Optional] ComputeBuffer managedBuffer, [Optional] Matrix4x4[] managedData)
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x73ECB74", Offset = "0x73E8B74", VA = "0x73ECB74")]
		public static void CopyComputeBuffer(this ComputeBuffer computeBuffer, int computeBufferStartIndex, int count, ComputeBuffer managedBuffer)
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x73ECD7C", Offset = "0x73E8D7C", VA = "0x73ECD7C")]
		public static ComputeBuffer MergeComputeBuffers(this ComputeBuffer computeBuffer, ComputeBuffer bufferToMerge, bool releaseMergedBuffers)
		{
			return null;
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x73ED1B4", Offset = "0x73E91B4", VA = "0x73ED1B4")]
		public static void SetGlobalPositionOffset(GPUInstancerManager manager, Vector3 offsetPosition)
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x73ED5C8", Offset = "0x73E95C8", VA = "0x73ED5C8")]
		public static void SetGlobalMatrixOffset(GPUInstancerManager manager, Matrix4x4 offsetMatrix)
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x73ED9F0", Offset = "0x73E99F0", VA = "0x73ED9F0")]
		public static void RemoveInstancesInsideBounds(ComputeBuffer instanceDataBuffer, Vector3 center, Vector3 extents, float offset)
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x73EDC94", Offset = "0x73E9C94", VA = "0x73EDC94")]
		public static void RemoveInstancesInsideBoxCollider(ComputeBuffer instanceDataBuffer, BoxCollider boxCollider, float offset)
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x73EDFCC", Offset = "0x73E9FCC", VA = "0x73EDFCC")]
		public static void RemoveInstancesInsideSphereCollider(ComputeBuffer instanceDataBuffer, SphereCollider sphereCollider, float offset)
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x73EE2D0", Offset = "0x73EA2D0", VA = "0x73EE2D0")]
		public static void RemoveInstancesInsideCapsuleCollider(ComputeBuffer instanceDataBuffer, CapsuleCollider capsuleCollider, float offset)
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x73EE8C0", Offset = "0x73EA8C0", VA = "0x73EE8C0")]
		public static void InitializeWithMatrix4x4Array(GPUInstancerPrefabManager prefabManager, GPUInstancerPrefabPrototype prototype, Matrix4x4[] matrix4x4Array)
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x73EEAA8", Offset = "0x73EAAA8", VA = "0x73EEAA8")]
		public static void InitializePrototype(GPUInstancerPrefabManager prefabManager, GPUInstancerPrefabPrototype prototype, int bufferSize, int instanceCount = 0)
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x73EEC78", Offset = "0x73EAC78", VA = "0x73EEC78")]
		public static void UpdateVisibilityBufferWithMatrix4x4Array(GPUInstancerPrefabManager prefabManager, GPUInstancerPrefabPrototype prototype, Matrix4x4[] matrix4x4Array, int arrayStartIndex = 0, int bufferStartIndex = 0, int count = 0)
		{
		}

		[Token(Token = "0x6000214")]
		public static void UpdateVisibilityBufferWithNativeArray<T>(GPUInstancerPrefabManager prefabManager, GPUInstancerPrefabPrototype prototype, NativeArray<T> float4x4Array, int arrayStartIndex = 0, int bufferStartIndex = 0, int count = 0) where T : struct
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x73EEDE4", Offset = "0x73EADE4", VA = "0x73EEDE4")]
		public static void CopyTextureWithComputeShader(Texture source, Texture destination, int offsetX, int sourceMip = 0, int destinationMip = 0, bool reverseZ = true)
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x73EF0D8", Offset = "0x73EB0D8", VA = "0x73EF0D8")]
		public static void CopyTextureArrayWithComputeShader(Texture source, Texture destination, int offsetX, int textureArrayIndex, int sourceMip = 0, int destinationMip = 0, bool reverseZ = true)
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x73EF3F4", Offset = "0x73EB3F4", VA = "0x73EF3F4")]
		public static void ReduceTextureWithComputeShader(Texture source, Texture destination, int offsetX, int sourceMip = 0, int destinationMip = 0)
		{
		}

		[Token(Token = "0x6000218")]
		public static NativeArray<T> ResizeNativeArray<T>(NativeArray<T> previousArray, int newSize, Allocator allocator) where T : struct
		{
			return default;
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x73EF750", Offset = "0x73EB750", VA = "0x73EF750")]
		public static TransformAccessArray ResizeTransformAccessArray(TransformAccessArray previousArray, int newSize, Transform defaultTransform)
		{
			return default;
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x73EBCC8", Offset = "0x73E7CC8", VA = "0x73EBCC8")]
		public static void DestroyObject(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x600021B")]
		public static T LoadResource<T>(string path, bool loadFromAddressables = true) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x600021C")]
		public static T FindObjectOfType<T>() where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x600021D")]
		public static T[] FindObjectsOfType<T>() where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x73EF8C0", Offset = "0x73EB8C0", VA = "0x73EF8C0")]
		public static void StartListening(GPUInstancerEventType eventType, UnityAction listener)
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x73EFA44", Offset = "0x73EBA44", VA = "0x73EFA44")]
		public static void StopListening(GPUInstancerEventType eventType, UnityAction listener)
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x73EFAE4", Offset = "0x73EBAE4", VA = "0x73EFAE4")]
		public static void TriggerEvent(GPUInstancerEventType eventType)
		{
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x73EFBB0", Offset = "0x73EBBB0", VA = "0x73EFBB0")]
		public static void VersionControlCheckout(UnityEngine.Object assetObject)
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x73EFBB4", Offset = "0x73EBBB4", VA = "0x73EFBB4")]
		public static void VersionControlCheckout(string path)
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x73EFBB8", Offset = "0x73EBBB8", VA = "0x73EFBB8")]
		public static void SetPlatformDependentVariables()
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x73EFCE4", Offset = "0x73EBCE4", VA = "0x73EFCE4")]
		public static GPUIPlatform DeterminePlatform()
		{
			return default;
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x73EFD1C", Offset = "0x73EBD1C", VA = "0x73EFD1C")]
		public static void UpdatePlatformDependentFiles()
		{
		}
	}
}
