using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.Jobs;
using UnityEngine.Rendering;

namespace GPUInstancer.CrowdAnimations
{
	[Token(Token = "0x2000028")]
	public class GPUICrowdRuntimeData : GPUInstancerRuntimeData
	{
		[Token(Token = "0x400012A")]
		[FieldOffset(Offset = "0xD8")]
		public ComputeBuffer animationDataBuffer;

		[Token(Token = "0x400012B")]
		[FieldOffset(Offset = "0xE0")]
		public ComputeBuffer animationBakeBuffer;

		[Token(Token = "0x400012C")]
		[FieldOffset(Offset = "0xE8")]
		public RenderTexture animationBakeTexture;

		[Token(Token = "0x400012D")]
		[FieldOffset(Offset = "0xF0")]
		public NativeArray<Vector4> animationData;

		[Token(Token = "0x400012E")]
		[FieldOffset(Offset = "0x100")]
		public Dictionary<int, GPUIAnimationClipData> animationClipDataDict;

		[Token(Token = "0x400012F")]
		[FieldOffset(Offset = "0x108")]
		public Dictionary<int, GPUIAnimatorState> animatorStateDict;

		[Token(Token = "0x4000130")]
		[FieldOffset(Offset = "0x110")]
		public NativeArray<Vector4> crowdAnimatorControllerData;

		[Token(Token = "0x4000131")]
		[FieldOffset(Offset = "0x120")]
		public ComputeBuffer crowdAnimatorControllerBuffer;

		[Token(Token = "0x4000132")]
		[FieldOffset(Offset = "0x128")]
		public bool disableFrameLerp;

		[Token(Token = "0x4000133")]
		[FieldOffset(Offset = "0x130")]
		public List<GPUICrowdAnimator> transitioningAnimators;

		[Token(Token = "0x4000134")]
		[FieldOffset(Offset = "0x138")]
		public bool isUVsSet;

		[Token(Token = "0x4000135")]
		[FieldOffset(Offset = "0x139")]
		public bool hasEvents;

		[Token(Token = "0x4000136")]
		[FieldOffset(Offset = "0x140")]
		public Dictionary<int, List<GPUIAnimationEvent>> eventDict;

		[Token(Token = "0x4000137")]
		[FieldOffset(Offset = "0x148")]
		public TransformAccessArray boneTransformAccessArray;

		[Token(Token = "0x4000138")]
		[FieldOffset(Offset = "0x150")]
		public NativeArray<Matrix4x4> bindPoses;

		[Token(Token = "0x4000139")]
		[FieldOffset(Offset = "0x160")]
		public bool waitingBoneDataRequest;

		[Token(Token = "0x400013A")]
		[FieldOffset(Offset = "0x168")]
		public JobHandle boneTransformUpdateJobHandle;

		[Token(Token = "0x400013B")]
		[FieldOffset(Offset = "0x178")]
		public ComputeBuffer asyncBoneUpdateFilterBuffer;

		[Token(Token = "0x400013C")]
		[FieldOffset(Offset = "0x180")]
		public ComputeBuffer asyncBoneUpdateDataBuffer;

		[Token(Token = "0x400013D")]
		[FieldOffset(Offset = "0x188")]
		public NativeArray<int> boneUpdateFilter;

		[Token(Token = "0x400013E")]
		[FieldOffset(Offset = "0x198")]
		private Action<AsyncGPUReadbackRequest> _boneDataRequestCallback;

		[Token(Token = "0x400013F")]
		[FieldOffset(Offset = "0x1A0")]
		private AsyncGPUReadbackRequest _boneDataRequest;

		[Token(Token = "0x4000140")]
		[FieldOffset(Offset = "0x1B0")]
		private int _boneDataRequestFrame;

		[Token(Token = "0x4000141")]
		[FieldOffset(Offset = "0x1B8")]
		public NativeArray<Matrix4x4> bakedAnimationData;

		[Token(Token = "0x4000142")]
		[FieldOffset(Offset = "0x1C8")]
		private bool _isSynchronousBoneUpdate;

		[Token(Token = "0x4000143")]
		[FieldOffset(Offset = "0x1D0")]
		public NativeArray<GPUIAnimationClipData> clipDatas;

		[Token(Token = "0x4000144")]
		[FieldOffset(Offset = "0x1E0")]
		public NativeArray<GPUIRootMotion> rootMotions;

		[Token(Token = "0x4000145")]
		[FieldOffset(Offset = "0x1F0")]
		public bool animationDataModified;

		[Token(Token = "0x4000146")]
		[FieldOffset(Offset = "0x1F1")]
		public bool crowdAnimatorDataModified;

		[Token(Token = "0x4000147")]
		[FieldOffset(Offset = "0x1F2")]
		public bool isChildRuntimeData;

		[Token(Token = "0x4000148")]
		[FieldOffset(Offset = "0x1F8")]
		public GPUICrowdRuntimeData parentRuntimeData;

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x73CB3D4", Offset = "0x73C73D4", VA = "0x73CB3D4")]
		public GPUICrowdRuntimeData(GPUInstancerPrototype prototype) : base(prototype)
        {
            throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED GPUICrowdRuntimeData.ctor body RVA=0x73CB3D4; native base argument restored only");
        }

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x73CB550", Offset = "0x73C7550", VA = "0x73CB550", Slot = "4")]
		public override void InitializeData()
		{
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x73CC41C", Offset = "0x73C841C", VA = "0x73CC41C", Slot = "5")]
		public override void ReleaseBuffers()
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x73CC6BC", Offset = "0x73C86BC", VA = "0x73CC6BC", Slot = "11")]
		public override bool GenerateLODsFromLODGroup(GPUInstancerPrototype prototype)
		{
			return default;
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x73CCFE8", Offset = "0x73C8FE8", VA = "0x73CCFE8", Slot = "12")]
		public override bool CreateRenderersFromMeshRenderers(int lod, GPUInstancerPrototype prototype)
		{
			return default;
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x73CDC84", Offset = "0x73C9C84", VA = "0x73CDC84", Slot = "9")]
		public override void CalculateBounds()
		{
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x73CDAC4", Offset = "0x73C9AC4", VA = "0x73CDAC4")]
		public void GetSkinnedMeshRenderersOfTransform(Transform objectTransform, List<SkinnedMeshRenderer> skinnedMeshRenderers)
		{
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x73CE298", Offset = "0x73CA298", VA = "0x73CE298")]
		public void MakeBoneDataRequest()
		{
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x73CE41C", Offset = "0x73CA41C", VA = "0x73CE41C")]
		public bool CompleteAsyncBoneDataRequest(bool forceComplete, int asyncBoneUpdateMaxLatency)
		{
			return default;
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x73CE480", Offset = "0x73CA480", VA = "0x73CE480")]
		public void BoneDataRequestCompeleted(AsyncGPUReadbackRequest obj)
		{
		}
	}
}
