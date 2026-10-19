using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace GPUInstancer
{
	[Token(Token = "0x2000025")]
	public static class GPUInstancerAPI
	{
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x73AC994", Offset = "0x73A8994", VA = "0x73AC994")]
		public static void InitializeGPUInstancer(GPUInstancerManager manager, bool forceNew = true)
		{
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x73ADBD8", Offset = "0x73A9BD8", VA = "0x73ADBD8")]
		public static void SetCamera(GPUInstancerManager manager, Camera camera)
		{
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x73B159C", Offset = "0x73AD59C", VA = "0x73B159C")]
		public static void SetCamera(Camera camera)
		{
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x73B7C64", Offset = "0x73B3C64", VA = "0x73B7C64")]
		public static List<GPUInstancerManager> GetActiveManagers()
		{
			return null;
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x73B12A4", Offset = "0x73AD2A4", VA = "0x73B12A4")]
		public static void StartListeningGPUIEvent(GPUInstancerEventType eventType, UnityAction callback)
		{
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x73B18AC", Offset = "0x73AD8AC", VA = "0x73B18AC")]
		public static void StopListeningGPUIEvent(GPUInstancerEventType eventType, UnityAction callback)
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x73B7D00", Offset = "0x73B3D00", VA = "0x73B7D00")]
		public static void SetGlobalPositionOffset(GPUInstancerManager manager, Vector3 offsetPosition)
		{
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x73B7D08", Offset = "0x73B3D08", VA = "0x73B7D08")]
		public static void SetGlobalMatrixOffset(GPUInstancerManager manager, Matrix4x4 offsetMatrix)
		{
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x73B7D38", Offset = "0x73B3D38", VA = "0x73B7D38")]
		public static void RemoveInstancesInsideBounds(GPUInstancerManager manager, Bounds bounds, [Optional][DefaultParameterValue(0f)] float offset, [Optional] List<GPUInstancerPrototype> prototypeFilter)
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x73B7D88", Offset = "0x73B3D88", VA = "0x73B7D88")]
		public static void RemoveInstancesInsideCollider(GPUInstancerManager manager, Collider collider, [Optional][DefaultParameterValue(0f)] float offset, [Optional] List<GPUInstancerPrototype> prototypeFilter)
		{
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x73AB07C", Offset = "0x73A707C", VA = "0x73AB07C")]
		public static ComputeBuffer GetTransformDataBuffer(GPUInstancerManager manager, GPUInstancerPrototype prototype)
		{
			return null;
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x73B7DC4", Offset = "0x73B3DC4", VA = "0x73B7DC4")]
		public static void SetLODBias(GPUInstancerManager manager, float newLODBias, [Optional] List<GPUInstancerPrototype> prototypeFilter)
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x73B8044", Offset = "0x73B4044", VA = "0x73B8044")]
		public static void ChangeMaterial(GPUInstancerManager manager, GPUInstancerPrototype prototype, Material material, int lodLevel = 0, int rendererIndex = 0, int subMeshIndex = 0)
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x73B8474", Offset = "0x73B4474", VA = "0x73B8474")]
		public static void ChangeMesh(GPUInstancerManager manager, GPUInstancerPrototype prototype, Mesh mesh, int lodLevel = 0, int rendererIndex = 0)
		{
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x73B86F4", Offset = "0x73B46F4", VA = "0x73B86F4")]
		public static void SetRenderingLayerMask(GPUInstancerManager manager, GPUInstancerPrototype prototype, uint renderingLayerMask, int lodLevel = -1, int rendererIndex = -1)
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x73B30E0", Offset = "0x73AF0E0", VA = "0x73B30E0")]
		public static void SetInstanceCount(GPUInstancerManager manager, GPUInstancerPrototype prototype, int instanceCount)
		{
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x73B877C", Offset = "0x73B477C", VA = "0x73B877C")]
		[Obsolete("GetInstanceDataArray method is obsolete. Use GetInstanceDataNativeArray instead.", true)]
		public static Matrix4x4[] GetInstanceDataArray(GPUInstancerManager manager, GPUInstancerPrototype prototype)
		{
			return null;
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x73B8784", Offset = "0x73B4784", VA = "0x73B8784")]
		public static NativeArray<Matrix4x4> GetInstanceDataNativeArray(GPUInstancerManager manager, GPUInstancerPrototype prototype)
		{
			return default;
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x73B8800", Offset = "0x73B4800", VA = "0x73B8800")]
		public static List<GPUInstancerPrototype> GetPrototypeList(GPUInstancerManager manager)
		{
			return null;
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x73B8850", Offset = "0x73B4850", VA = "0x73B8850")]
		public static void ChangeLODShadow(GPUInstancerPrototype prototype, int lodLevel, bool isShadowCasting, int shadowLOD = -1)
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x73B88BC", Offset = "0x73B48BC", VA = "0x73B88BC")]
		public static void ReleaseInstanceBuffers(GPUInstancerManager manager)
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x73B8950", Offset = "0x73B4950", VA = "0x73B8950")]
		public static void ReleaseInstanceBuffers(GPUInstancerManager manager, GPUInstancerPrototype prototype)
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x73B09B4", Offset = "0x73AC9B4", VA = "0x73B09B4")]
		public static void RegisterPrefabInstanceList(GPUInstancerPrefabManager manager, IEnumerable<GPUInstancerPrefab> prefabInstanceList)
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x73B8A00", Offset = "0x73B4A00", VA = "0x73B8A00")]
		public static void UnregisterPrefabInstanceList(GPUInstancerPrefabManager manager, IEnumerable<GPUInstancerPrefab> prefabInstanceList)
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x73B8A20", Offset = "0x73B4A20", VA = "0x73B8A20")]
		public static void ClearRegisteredPrefabInstances(GPUInstancerPrefabManager manager)
		{
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x73B8A40", Offset = "0x73B4A40", VA = "0x73B8A40")]
		public static void ClearRegisteredPrefabInstances(GPUInstancerPrefabManager manager, GPUInstancerPrototype prototype)
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x73AF098", Offset = "0x73AB098", VA = "0x73AF098")]
		public static void AddPrefabInstance(GPUInstancerPrefabManager manager, GPUInstancerPrefab prefabInstance, bool autoIncreaseBufferSize = false)
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x73AF63C", Offset = "0x73AB63C", VA = "0x73AF63C")]
		public static void RemovePrefabInstance(GPUInstancerPrefabManager manager, GPUInstancerPrefab prefabInstance, bool setRenderersEnabled = true)
		{
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x73B8A54", Offset = "0x73B4A54", VA = "0x73B8A54")]
		public static void DisableIntancingForInstance(GPUInstancerPrefabManager manager, GPUInstancerPrefab prefabInstance, bool setRenderersEnabled = true)
		{
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x73B8A78", Offset = "0x73B4A78", VA = "0x73B8A78")]
		public static void EnableInstancingForInstance(GPUInstancerPrefabManager manager, GPUInstancerPrefab prefabInstance, bool setRenderersDisabled = true)
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x73B8A9C", Offset = "0x73B4A9C", VA = "0x73B8A9C")]
		public static void UpdateTransformDataForInstance(GPUInstancerPrefabManager manager, GPUInstancerPrefab prefabInstance)
		{
		}

		[Token(Token = "0x60000EC")]
		public static void DefinePrototypeVariationBuffer<T>(GPUInstancerPrefabManager manager, GPUInstancerPrefabPrototype prototype, string bufferName)
		{
		}

		[Token(Token = "0x60000ED")]
		public static void AddVariation<T>(GPUInstancerPrefab prefabInstance, string bufferName, T value)
		{
		}

		[Token(Token = "0x60000EE")]
		public static void UpdateVariation<T>(GPUInstancerPrefabManager manager, GPUInstancerPrefab prefabInstance, string bufferName, T value)
		{
		}

		[Token(Token = "0x60000EF")]
		public static PrefabVariationData<T> DefineAndAddVariationFromArray<T>(GPUInstancerPrefabManager manager, GPUInstancerPrefabPrototype prototype, string bufferName, T[] variationArray)
		{
			return null;
		}

		[Token(Token = "0x60000F0")]
		public static PrefabVariationData<T> DefineAndAddVariationFromArray<T>(GPUInstancerPrefabManager manager, GPUInstancerPrefabPrototype prototype, string bufferName, NativeArray<T> variationArray) where T : struct
		{
			return null;
		}

		[Token(Token = "0x60000F1")]
		public static void UpdateVariationFromArray<T>(GPUInstancerPrefabManager manager, GPUInstancerPrefabPrototype prototype, string bufferName, T[] variationArray, int arrayStartIndex = 0, int bufferStartIndex = 0, int count = 0)
		{
		}

		[Token(Token = "0x60000F2")]
		public static void UpdateVariationFromArray<T>(GPUInstancerPrefabManager manager, GPUInstancerPrefabPrototype prototype, string bufferName, NativeArray<T> variationArray, int arrayStartIndex = 0, int bufferStartIndex = 0, int count = 0) where T : struct
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x73B8ABC", Offset = "0x73B4ABC", VA = "0x73B8ABC")]
		public static ComputeBuffer GetVariationBuffer(GPUInstancerPrefabManager manager, GPUInstancerPrefabPrototype prototype, string bufferName)
		{
			return null;
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x73AB074", Offset = "0x73A7074", VA = "0x73AB074")]
		public static void InitializeWithMatrix4x4Array(GPUInstancerPrefabManager prefabManager, GPUInstancerPrefabPrototype prototype, Matrix4x4[] matrix4x4Array)
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x73B8AD0", Offset = "0x73B4AD0", VA = "0x73B8AD0")]
		public static void InitializePrototype(GPUInstancerPrefabManager prefabManager, GPUInstancerPrefabPrototype prototype, int bufferSize, int instanceCount = 0)
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x73B3868", Offset = "0x73AF868", VA = "0x73B3868")]
		public static void UpdateVisibilityBufferWithMatrix4x4Array(GPUInstancerPrefabManager prefabManager, GPUInstancerPrefabPrototype prototype, Matrix4x4[] matrix4x4Array, int arrayStartIndex = 0, int bufferStartIndex = 0, int count = 0)
		{
		}

		[Token(Token = "0x60000F7")]
		public static void UpdateVisibilityBufferWithNativeArray<T>(GPUInstancerPrefabManager prefabManager, GPUInstancerPrefabPrototype prototype, NativeArray<T> float4x4Array, int arrayStartIndex = 0, int bufferStartIndex = 0, int count = 0) where T : struct
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x73AFC58", Offset = "0x73ABC58", VA = "0x73AFC58")]
		public static GPUInstancerPrefabPrototype DefineGameObjectAsPrefabPrototypeAtRuntime(GPUInstancerPrefabManager prefabManager, GameObject prototypeGameObject, bool attachScript = true)
		{
			return null;
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x73B8AD8", Offset = "0x73B4AD8", VA = "0x73B8AD8")]
		public static GPUInstancerRuntimeData InitializeGPUInstancer(GPUInstancerPrefabManager prefabManager, GPUInstancerPrefabPrototype prototype)
		{
			return null;
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x73AFC7C", Offset = "0x73ABC7C", VA = "0x73AFC7C")]
		public static void AddInstancesToPrefabPrototypeAtRuntime(GPUInstancerPrefabManager prefabManager, GPUInstancerPrefabPrototype prefabPrototype, IEnumerable<GameObject> instances)
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x73B0544", Offset = "0x73AC544", VA = "0x73B0544")]
		public static void RemovePrototypeAtRuntime(GPUInstancerPrefabManager prefabManager, GPUInstancerPrefabPrototype prefabPrototype)
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x73B8B28", Offset = "0x73B4B28", VA = "0x73B8B28")]
		public static GPUInstancerPrefabPrototype ClonePrototypeAtRuntime(GPUInstancerPrefabManager prefabManager, GPUInstancerPrefabPrototype originalPrototype)
		{
			return null;
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x73B8C20", Offset = "0x73B4C20", VA = "0x73B8C20")]
		public static void AddPrototoypeToManager(GPUInstancerPrefabManager prefabManager, GPUInstancerPrefabPrototype prototype)
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x73AC974", Offset = "0x73A8974", VA = "0x73AC974")]
		public static void SetupManagerWithTerrain(GPUInstancerTerrainManager manager, Terrain terrain)
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x73ACBEC", Offset = "0x73A8BEC", VA = "0x73ACBEC")]
		public static void UpdateDetailInstances(GPUInstancerDetailManager manager, bool updateMeshes = false)
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x73B1570", Offset = "0x73AD570", VA = "0x73B1570")]
		public static List<int[,]> GetDetailMapData(GPUInstancerDetailManager manager)
		{
			return null;
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x73B8DEC", Offset = "0x73B4DEC", VA = "0x73B8DEC")]
		public static int[,] GetDetailLayer(GPUInstancerDetailManager manager, int layerIndex)
		{
			return null;
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x73B1584", Offset = "0x73AD584", VA = "0x73B1584")]
		public static void SetDetailMapData(GPUInstancerDetailManager manager, List<int[,]> detailMapData)
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x73B8E00", Offset = "0x73B4E00", VA = "0x73B8E00")]
		public static void AddTerrainToManager(GPUInstancerTreeManager manager, Terrain terrain)
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x73B8E20", Offset = "0x73B4E20", VA = "0x73B8E20")]
		public static void RemoveTerrainFromManager(GPUInstancerTreeManager manager, Terrain terrain)
		{
		}
	}
}
