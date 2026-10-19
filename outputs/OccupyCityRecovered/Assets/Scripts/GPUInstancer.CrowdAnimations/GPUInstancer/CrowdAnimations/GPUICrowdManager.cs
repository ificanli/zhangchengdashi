using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace GPUInstancer.CrowdAnimations
{
	[Token(Token = "0x2000033")]
	[DefaultExecutionOrder(-1010)]
	[ExecuteInEditMode]
	public class GPUICrowdManager : GPUInstancerPrefabManager
	{
		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		protected List<AnimatorClipInfo> _animatorClipInfos;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private ComputeShader _skinnedMeshAnimateComputeShader;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private int _animateBonesKernelID;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		private int _animateBonesLerpedKernelID;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private int _fixWeightsKernelID;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private ComputeShader _crowdAnimatorComputeShader;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private int _crowdAnimatorKernelID;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private ComputeShader _asyncBoneUpdateComputeShader;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private int _asyncBoneUpdateKernelID;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private ComputeShader _optionalRendererBufferCopyComputeShader;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private int _optionalRendererBufferCopyKernelID;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private ComputeShader _animationBufferToTextureComputeShader;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private int _animationBufferToTextureKernelID;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		private float _lastRootMotionUpdateTime;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private float _lastTransitionUpdateTime;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static float _transitionFrequency;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		private float _lastUpdateTime;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private float _lastAnimateTime;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		public List<GPUIAnimationEvent> animationEvents;

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x73D24D0", Offset = "0x73CE4D0", VA = "0x73D24D0", Slot = "4")]
		public override void Awake()
		{
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x73D26B4", Offset = "0x73CE6B4", VA = "0x73D26B4", Slot = "5")]
		public override void Start()
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x73D2928", Offset = "0x73CE928", VA = "0x73D2928", Slot = "6")]
		public override void OnEnable()
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x73D3324", Offset = "0x73CF324", VA = "0x73D3324", Slot = "7")]
		public override void Update()
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x73D3940", Offset = "0x73CF940", VA = "0x73D3940", Slot = "8")]
		public override void LateUpdate()
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x73D49A0", Offset = "0x73D09A0", VA = "0x73D49A0", Slot = "13")]
		public override void GeneratePrototypes(bool forceNew = false)
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x73D4B5C", Offset = "0x73D0B5C", VA = "0x73D4B5C", Slot = "14")]
		public override void InitializeRuntimeDataAndBuffers(bool forceNew = true)
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x73D5130", Offset = "0x73D1130", VA = "0x73D5130", Slot = "23")]
		public override GPUInstancerRuntimeData InitializeRuntimeDataForPrefabPrototype(GPUInstancerPrefabPrototype p, int additionalBufferSize = 0)
		{
			return null;
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x73D5510", Offset = "0x73D1510", VA = "0x73D5510", Slot = "24")]
		public override void SetRenderersEnabled(GPUInstancerPrefab prefabInstance, bool enabled)
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x73D3B38", Offset = "0x73CFB38", VA = "0x73D3B38")]
		public void UpdateAnimatorsData(GPUICrowdRuntimeData runtimeData)
		{
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x73D30A0", Offset = "0x73CF0A0", VA = "0x73D30A0")]
		public GPUICrowdPrototype DefineGameObjectAsCrowdPrototypeAtRuntime(GameObject prototypeGameObject, GPUICrowdAnimationData animationData, [Optional][DefaultParameterValue(true)] bool attachScript, [Optional] GPUICrowdPrototype copySettingsFrom)
		{
			return null;
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x73D5BA8", Offset = "0x73D1BA8", VA = "0x73D5BA8", Slot = "17")]
		public override void DeletePrototype(GPUInstancerPrototype prototype, bool removeSO = true)
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x73D5C00", Offset = "0x73D1C00", VA = "0x73D5C00", Slot = "29")]
		public override void AddPrefabInstance(GPUInstancerPrefab prefabInstance, bool automaticallyIncreaseBufferSize = false)
		{
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x73D5E70", Offset = "0x73D1E70", VA = "0x73D5E70")]
		public GPUICrowdManager()
		{
		}
	}
}
