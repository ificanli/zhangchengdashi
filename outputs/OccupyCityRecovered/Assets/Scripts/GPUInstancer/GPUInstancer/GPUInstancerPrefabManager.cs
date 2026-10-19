using System.Collections.Generic;
using Il2CppDummyDll;
using Unity.Collections;
using UnityEngine;

namespace GPUInstancer
{
	[Token(Token = "0x2000070")]
	[ExecuteInEditMode]
	public class GPUInstancerPrefabManager : GPUInstancerManager
	{
		[Token(Token = "0x400041B")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		public List<RegisteredPrefabsData> registeredPrefabs;

		[Token(Token = "0x400041C")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		public List<GameObject> prefabList;

		[Token(Token = "0x400041D")]
		[FieldOffset(Offset = "0xC8")]
		public bool enableMROnManagerDisable;

		[Token(Token = "0x400041E")]
		[FieldOffset(Offset = "0xC9")]
		public bool enableMROnRemoveInstance;

		[Token(Token = "0x400041F")]
		[FieldOffset(Offset = "0xD0")]
		protected List<GPUInstancerModificationCollider> _modificationColliders;

		[Token(Token = "0x4000420")]
		[FieldOffset(Offset = "0xD8")]
		protected Dictionary<GPUInstancerPrototype, List<GPUInstancerPrefab>> _registeredPrefabsRuntimeData;

		[Token(Token = "0x4000421")]
		[FieldOffset(Offset = "0xE0")]
		protected List<IPrefabVariationData> _variationDataList;

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x7400AF4", Offset = "0x73FCAF4", VA = "0x7400AF4", Slot = "4")]
		public override void Awake()
		{
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x7400B74", Offset = "0x73FCB74", VA = "0x7400B74", Slot = "10")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x7400B9C", Offset = "0x73FCB9C", VA = "0x7400B9C", Slot = "7")]
		public override void Update()
		{
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x7400DD0", Offset = "0x73FCDD0", VA = "0x7400DD0", Slot = "8")]
		public override void LateUpdate()
		{
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x7400FB8", Offset = "0x73FCFB8", VA = "0x7400FB8", Slot = "12")]
		public override void ClearInstancingData()
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x7401504", Offset = "0x73FD504", VA = "0x7401504", Slot = "13")]
		public override void GeneratePrototypes(bool forceNew = false)
		{
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x7401548", Offset = "0x73FD548", VA = "0x7401548", Slot = "14")]
		public override void InitializeRuntimeDataAndBuffers(bool forceNew = true)
		{
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x7401A50", Offset = "0x73FDA50", VA = "0x7401A50", Slot = "17")]
		public override void DeletePrototype(GPUInstancerPrototype prototype, bool removeSO = true)
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x7401BB4", Offset = "0x73FDBB4", VA = "0x7401BB4", Slot = "22")]
		public virtual void InitializeRuntimeDataRegisteredPrefabs(int additionalBufferSize = 0)
		{
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x7401DE4", Offset = "0x73FDDE4", VA = "0x7401DE4", Slot = "23")]
		public virtual GPUInstancerRuntimeData InitializeRuntimeDataForPrefabPrototype(GPUInstancerPrefabPrototype p, int additionalBufferSize = 0)
		{
			return null;
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x7402EFC", Offset = "0x73FEEFC", VA = "0x7402EFC", Slot = "24")]
		public virtual void SetRenderersEnabled(GPUInstancerPrefab prefabInstance, bool enabled)
		{
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x740333C", Offset = "0x73FF33C", VA = "0x740333C")]
		public static void ExpandBufferSize(GPUInstancerRuntimeData runtimeData, int newBufferSize)
		{
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x740345C", Offset = "0x73FF45C", VA = "0x740345C", Slot = "25")]
		public virtual void SetInstanceTransform(GPUInstancerRuntimeData runtimeData, int index, Transform transform)
		{
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x740358C", Offset = "0x73FF58C", VA = "0x740358C", Slot = "26")]
		public virtual void DisableIntancingForInstance(GPUInstancerPrefab prefabInstance, bool setRenderersEnabled = true)
		{
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x7403764", Offset = "0x73FF764", VA = "0x7403764", Slot = "27")]
		public virtual void EnableInstancingForInstance(GPUInstancerPrefab prefabInstance, bool setRenderersDisabled = true)
		{
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x7403950", Offset = "0x73FF950", VA = "0x7403950", Slot = "28")]
		public virtual void UpdateTransformDataForInstance(GPUInstancerPrefab prefabInstance)
		{
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x7403AE0", Offset = "0x73FFAE0", VA = "0x7403AE0", Slot = "29")]
		public virtual void AddPrefabInstance(GPUInstancerPrefab prefabInstance, bool automaticallyIncreaseBufferSize = false)
		{
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x74045CC", Offset = "0x74005CC", VA = "0x74045CC", Slot = "30")]
		public virtual void AddPrefabInstances(IEnumerable<GPUInstancerPrefab> prefabInstances)
		{
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x7404BA8", Offset = "0x7400BA8", VA = "0x7404BA8", Slot = "31")]
		public virtual void AddPrefabInstances(GPUInstancerPrefabPrototype prototype, IEnumerable<GPUInstancerPrefab> prefabInstances)
		{
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x7404EF4", Offset = "0x7400EF4", VA = "0x7404EF4", Slot = "32")]
		public virtual void UpdateInstanceDataArray(GPUInstancerRuntimeData runtimeData, List<GPUInstancerPrefab> prefabList)
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x740510C", Offset = "0x740110C", VA = "0x740510C", Slot = "33")]
		public virtual void RemovePrefabInstance(GPUInstancerPrefab prefabInstance, bool setRenderersEnabled = true)
		{
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x74058EC", Offset = "0x74018EC", VA = "0x74058EC", Slot = "34")]
		public virtual void RemovePrefabInstances(IEnumerable<GPUInstancerPrefab> prefabInstances)
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x7405EC8", Offset = "0x7401EC8", VA = "0x7405EC8", Slot = "35")]
		public virtual void RemovePrefabInstances(GPUInstancerPrefabPrototype prototype, IEnumerable<GPUInstancerPrefab> prefabInstances)
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x74062F8", Offset = "0x74022F8", VA = "0x74062F8", Slot = "36")]
		public virtual void RegisterPrefabsInScene()
		{
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x74065EC", Offset = "0x74025EC", VA = "0x74065EC", Slot = "37")]
		public virtual void RegisterPrefabInstanceList(IEnumerable<GPUInstancerPrefab> prefabInstanceList)
		{
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x7406BDC", Offset = "0x7402BDC", VA = "0x7406BDC", Slot = "38")]
		public virtual void UnregisterPrefabInstanceList(IEnumerable<GPUInstancerPrefab> prefabInstanceList)
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x7407184", Offset = "0x7403184", VA = "0x7407184", Slot = "39")]
		public virtual void ClearRegisteredPrefabInstances()
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x7407338", Offset = "0x7403338", VA = "0x7407338")]
		public void ClearRegisteredPrefabInstances(GPUInstancerPrototype p)
		{
		}

		[Token(Token = "0x60002E3")]
		public virtual PrefabVariationData<T> DefinePrototypeVariationBuffer<T>(GPUInstancerPrefabPrototype prototype, string bufferName)
		{
			return null;
		}

		[Token(Token = "0x60002E4")]
		public virtual void UpdateVariationData<T>(GPUInstancerPrefab prefabInstance, string bufferName, T value)
		{
		}

		[Token(Token = "0x60002E5")]
		public virtual PrefabVariationData<T> DefineAndAddVariationFromArray<T>(GPUInstancerPrefabPrototype prototype, string bufferName, T[] variationArray)
		{
			return null;
		}

		[Token(Token = "0x60002E6")]
		public virtual PrefabVariationData<T> DefineAndAddVariationFromArray<T>(GPUInstancerPrefabPrototype prototype, string bufferName, NativeArray<T> variationArray) where T : struct
		{
			return null;
		}

		[Token(Token = "0x60002E7")]
		public virtual PrefabVariationData<T> UpdateVariationsFromArray<T>(GPUInstancerPrefabPrototype prototype, string bufferName, T[] variationArray, int arrayStartIndex = 0, int bufferStartIndex = 0, int count = 0)
		{
			return null;
		}

		[Token(Token = "0x60002E8")]
		public virtual PrefabVariationData<T> UpdateVariationsFromArray<T>(GPUInstancerPrefabPrototype prototype, string bufferName, NativeArray<T> variationArray, int arrayStartIndex = 0, int bufferStartIndex = 0, int count = 0) where T : struct
		{
			return null;
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x74073E0", Offset = "0x74033E0", VA = "0x74073E0")]
		public ComputeBuffer GetVariationBuffer(GPUInstancerPrefabPrototype prototype, string bufferName)
		{
			return null;
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x7407760", Offset = "0x7403760", VA = "0x7407760", Slot = "46")]
		public virtual GPUInstancerPrefabPrototype DefineGameObjectAsPrefabPrototypeAtRuntime(GameObject prototypeGameObject, bool attachScript = true)
		{
			return null;
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x74079CC", Offset = "0x74039CC", VA = "0x74079CC", Slot = "47")]
		public virtual void AddInstancesToPrefabPrototypeAtRuntime(GPUInstancerPrefabPrototype prefabPrototype, IEnumerable<GameObject> instances)
		{
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x7408584", Offset = "0x7404584", VA = "0x7408584", Slot = "48")]
		public virtual void RemovePrototypeAtRuntime(GPUInstancerPrefabPrototype prefabPrototype)
		{
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x740897C", Offset = "0x740497C", VA = "0x740897C", Slot = "49")]
		public virtual void AddRegisteredPrefab(GPUInstancerPrefab prefabInstance)
		{
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x7408B9C", Offset = "0x7404B9C", VA = "0x7408B9C", Slot = "50")]
		public virtual void AddRuntimeRegisteredPrefab(GPUInstancerPrefab prefabInstance)
		{
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x7408D14", Offset = "0x7404D14", VA = "0x7408D14", Slot = "51")]
		public virtual void AddModificationCollider(GPUInstancerModificationCollider modificationCollider)
		{
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x7408E00", Offset = "0x7404E00", VA = "0x7408E00", Slot = "52")]
		public virtual int GetEnabledPrefabCount()
		{
			return default;
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x7408EA4", Offset = "0x7404EA4", VA = "0x7408EA4", Slot = "53")]
		public virtual Dictionary<GPUInstancerPrototype, List<GPUInstancerPrefab>> GetRegisteredPrefabsRuntimeData()
		{
			return null;
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x7408EAC", Offset = "0x7404EAC", VA = "0x7408EAC")]
		public GPUInstancerPrefabManager()
		{
		}
	}
}
