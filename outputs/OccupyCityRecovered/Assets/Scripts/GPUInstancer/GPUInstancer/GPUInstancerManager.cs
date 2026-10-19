using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using Il2CppDummyDll;
using UnityEngine;

namespace GPUInstancer
{
	[Token(Token = "0x2000028")]
	public abstract class GPUInstancerManager : MonoBehaviour
	{
		[Token(Token = "0x2000029")]
		public class GPUIThreadData
		{
			[Token(Token = "0x4000182")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Thread thread;

			[Token(Token = "0x4000183")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public object parameter;

			[Token(Token = "0x6000130")]
			[Address(RVA = "0x73D74C8", Offset = "0x73D34C8", VA = "0x73D74C8")]
			public GPUIThreadData()
			{
			}
		}

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<GPUInstancerPrototype> prototypeList;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool autoSelectCamera;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GPUInstancerCameraData cameraData;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool useFloatingOriginHandler;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		public bool applyFloatingOriginRotationAndScale;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform floatingOriginTransform;

		[NonSerialized]
		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public GPUInstancerFloatingOriginHandler floatingOriginHandler;

		[NonSerialized]
		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public List<GPUInstancerRuntimeData> runtimeDataList;

		[NonSerialized]
		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Bounds instancingBounds;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public bool isFrustumCulling;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
		public bool isOcclusionCulling;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float minCullingDistance;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected GPUInstancerSpatialPartitioningData<GPUInstancerCell> spData;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static List<GPUInstancerManager> activeManagerList;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static bool showRenderedAmount;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected static ComputeShader _cameraComputeShader;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected static ComputeShader _cameraComputeShaderVR;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected static int[] _cameraComputeKernelIDs;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected static ComputeShader _visibilityComputeShader;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected static int[] _instanceVisibilityComputeKernelIDs;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected static ComputeShader _bufferToTextureComputeShader;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected static int _bufferToTextureComputeKernelID;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		protected static int _bufferToTextureCrossFadeComputeKernelID;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected static ComputeShader _argsBufferComputeShader;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected static int _argsBufferDoubleInstanceCountComputeKernelID;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public static int maxThreads;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public readonly List<Thread> activeThreads;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public readonly Queue<GPUIThreadData> threadStartQueue;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public readonly Queue<Action> threadQueue;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static int lastTreePositionUpdate;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static GameObject treeProxyParent;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static Dictionary<GameObject, Transform> treeProxyList;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static int lastDrawCallFrame;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public static float lastDrawCallTime;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static float timeSinceLastDrawCall;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		protected static Vector4 _windVector;

		[NonSerialized]
		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		protected bool isInitial;

		[NonSerialized]
		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x99")]
		public bool isInitialized;

		[NonSerialized]
		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9A")]
		public bool isQuiting;

		[NonSerialized]
		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Dictionary<GPUInstancerPrototype, GPUInstancerRuntimeData> runtimeDataDictionary;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public LayerMask layerMask;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public bool lightProbeDisabled;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public Exception threadException;

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x73B9010", Offset = "0x73B5010", VA = "0x73B9010", Slot = "4")]
		public virtual void Awake()
		{
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x73B98B8", Offset = "0x73B58B8", VA = "0x73B98B8", Slot = "5")]
		public virtual void Start()
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x73B9A88", Offset = "0x73B5A88", VA = "0x73B9A88", Slot = "6")]
		public virtual void OnEnable()
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x73BA02C", Offset = "0x73B602C", VA = "0x73BA02C", Slot = "7")]
		public virtual void Update()
		{
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x73BA458", Offset = "0x73B6458", VA = "0x73BA458", Slot = "8")]
		public virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x73BAF00", Offset = "0x73B6F00", VA = "0x73BAF00", Slot = "9")]
		public virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x73BAF04", Offset = "0x73B6F04", VA = "0x73BAF04", Slot = "10")]
		public virtual void Reset()
		{
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x73BAF68", Offset = "0x73B6F68", VA = "0x73BAF68", Slot = "11")]
		public virtual void OnDisable()
		{
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x73BB1D4", Offset = "0x73B71D4", VA = "0x73BB1D4")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x73BB1E0", Offset = "0x73B71E0", VA = "0x73BB1E0", Slot = "12")]
		public virtual void ClearInstancingData()
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x73BB880", Offset = "0x73B7880", VA = "0x73BB880", Slot = "13")]
		public virtual void GeneratePrototypes(bool forceNew = false)
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x73BBA14", Offset = "0x73B7A14", VA = "0x73BBA14", Slot = "14")]
		public virtual void InitializeRuntimeDataAndBuffers(bool forceNew = true)
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x73BBC90", Offset = "0x73B7C90", VA = "0x73BBC90", Slot = "15")]
		public virtual void InitializeSpatialPartitioning()
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x73BBC94", Offset = "0x73B7C94", VA = "0x73BBC94", Slot = "16")]
		public virtual void UpdateSpatialPartitioningCells(GPUInstancerCameraData renderingCameraData)
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x73BBC98", Offset = "0x73B7C98", VA = "0x73BBC98", Slot = "17")]
		public virtual void DeletePrototype(GPUInstancerPrototype prototype, bool removeSO = true)
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x73BBD68", Offset = "0x73B7D68", VA = "0x73BBD68", Slot = "18")]
		public virtual void RemoveInstancesInsideBounds(Bounds bounds, float offset, [Optional] List<GPUInstancerPrototype> prototypeFilter)
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x73BBF18", Offset = "0x73B7F18", VA = "0x73BBF18", Slot = "19")]
		public virtual void RemoveInstancesInsideCollider(Collider collider, float offset, [Optional] List<GPUInstancerPrototype> prototypeFilter)
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x73BC25C", Offset = "0x73B825C", VA = "0x73BC25C", Slot = "20")]
		public virtual void SetGlobalPositionOffset(Vector3 offsetPosition)
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x73BC260", Offset = "0x73B8260", VA = "0x73BC260", Slot = "21")]
		public virtual void SetGlobalMatrixOffset(Matrix4x4 offsetMatrix)
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x73BA394", Offset = "0x73B6394", VA = "0x73BA394")]
		public void ClearCompletedThreads()
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x73B9808", Offset = "0x73B5808", VA = "0x73B9808")]
		public void InitializeCameraData()
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x73B9934", Offset = "0x73B5934", VA = "0x73B9934")]
		public void SetupOcclusionCulling(GPUInstancerCameraData renderingCameraData)
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x73B9DF4", Offset = "0x73B5DF4", VA = "0x73B9DF4")]
		public void HandleFloatingOrigin()
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x73BC264", Offset = "0x73B8264", VA = "0x73BC264")]
		public void UpdateBuffers()
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x73BA968", Offset = "0x73B6968", VA = "0x73BA968")]
		public void UpdateBuffers(GPUInstancerCameraData renderingCameraData)
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x73B7A9C", Offset = "0x73B3A9C", VA = "0x73B7A9C")]
		public void SetCamera(Camera camera)
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x73B7DA8", Offset = "0x73B3DA8", VA = "0x73B7DA8")]
		public ComputeBuffer GetTransformDataBuffer(GPUInstancerPrototype prototype)
		{
			return null;
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x73B7DD4", Offset = "0x73B3DD4", VA = "0x73B7DD4")]
		public void SetLODBias(float newLODBias, List<GPUInstancerPrototype> prototypeFilter)
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x73BA4E8", Offset = "0x73B64E8", VA = "0x73BA4E8")]
		public void UpdateTreeMPB()
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x73BC26C", Offset = "0x73B826C", VA = "0x73BC26C")]
		public static void AddTreeProxy(GPUInstancerPrototype treePrototype, GPUInstancerRuntimeData runtimeData)
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x73BCAF4", Offset = "0x73B8AF4", VA = "0x73BCAF4")]
		public static void InstantiateTreeProxyObject(GameObject treePrefab, GameObject proxyObjectParent, Material[] proxyMaterials, Mesh proxyMesh, bool setBounds)
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x73BCEE0", Offset = "0x73B8EE0", VA = "0x73BCEE0")]
		public static Vector4 GetWindVector()
		{
			return default;
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x73BCFE0", Offset = "0x73B8FE0", VA = "0x73BCFE0")]
		public static void UpdateSceneWind()
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x73BD13C", Offset = "0x73B913C", VA = "0x73BD13C")]
		public void LogThreadException()
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x73B8358", Offset = "0x73B4358", VA = "0x73B8358")]
		public GPUInstancerRuntimeData GetRuntimeData(GPUInstancerPrototype prototype, bool logError = false)
		{
			return null;
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x73BD198", Offset = "0x73B9198", VA = "0x73BD198")]
		protected GPUInstancerManager()
		{
		}
	}
}
