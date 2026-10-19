using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.UI;

namespace GPUInstancer.CrowdAnimations
{
	[Token(Token = "0x2000011")]
	[DefaultExecutionOrder(1000)]
	public class NoGameObjectsWithJobsDemoSceneHandler : MonoBehaviour
	{
		[Token(Token = "0x2000012")]
		private struct CrowdInstanceState
		{
			[Token(Token = "0x4000090")]
			[FieldOffset(Offset = "0x0")]
			public int animationIndex;

			[Token(Token = "0x4000091")]
			[FieldOffset(Offset = "0x4")]
			public float animationSpeed;

			[Token(Token = "0x4000092")]
			[FieldOffset(Offset = "0x8")]
			public float animationStartTimeMultiplier;

			[Token(Token = "0x4000093")]
			[FieldOffset(Offset = "0xC")]
			public StateModificationType modificationType;
		}

		[Token(Token = "0x2000013")]
		private enum StateModificationType
		{
			[Token(Token = "0x4000095")]
			None = 0,
			[Token(Token = "0x4000096")]
			All = 1,
			[Token(Token = "0x4000097")]
			Clip = 2,
			[Token(Token = "0x4000098")]
			Speed = 3,
			[Token(Token = "0x4000099")]
			StartTime = 4
		}

		[Token(Token = "0x2000014")]
		[BurstCompile]
		private struct ApplyAnimationStateJob : IJobParallelFor
		{
			[Token(Token = "0x400009A")]
			[FieldOffset(Offset = "0x0")]
			[ReadOnly]
			public NativeArray<GPUIAnimationClipData> clipDatas;

			[Token(Token = "0x400009B")]
			[FieldOffset(Offset = "0x10")]
			[ReadOnly]
			public NativeArray<CrowdInstanceState> instanceStateArray;

			[Token(Token = "0x400009C")]
			[FieldOffset(Offset = "0x20")]
			[NativeDisableParallelForRestriction]
			public NativeArray<Vector4> animationData;

			[Token(Token = "0x400009D")]
			[FieldOffset(Offset = "0x30")]
			[NativeDisableParallelForRestriction]
			public NativeArray<Vector4> crowdAnimatorControllerData;

			[Token(Token = "0x600004F")]
			[Address(RVA = "0x73C4E60", Offset = "0x73C0E60", VA = "0x73C4E60", Slot = "4")]
			public void Execute(int index)
			{
			}
		}

		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0x20")]
		public GPUICrowdManager gpuiCrowdManager;

		[Token(Token = "0x4000080")]
		[FieldOffset(Offset = "0x28")]
		public GPUInstancerLODColorDebugger gpuiLODColorDebugger;

		[Token(Token = "0x4000081")]
		[FieldOffset(Offset = "0x30")]
		public Slider sliderSpeed;

		[Token(Token = "0x4000082")]
		[FieldOffset(Offset = "0x38")]
		public Text textSpeedValue;

		[Token(Token = "0x4000083")]
		[FieldOffset(Offset = "0x40")]
		public Text textInstanceCount;

		[Token(Token = "0x4000084")]
		[FieldOffset(Offset = "0x48")]
		private int _selectedPrototypeIndex;

		[Token(Token = "0x4000085")]
		[FieldOffset(Offset = "0x4C")]
		private int _rowCount;

		[Token(Token = "0x4000086")]
		[FieldOffset(Offset = "0x50")]
		private int _collumnCount;

		[Token(Token = "0x4000087")]
		[FieldOffset(Offset = "0x54")]
		private float _space;

		[Token(Token = "0x4000088")]
		[FieldOffset(Offset = "0x58")]
		private NativeArray<Matrix4x4> _instanceMatrixArray;

		[Token(Token = "0x4000089")]
		[FieldOffset(Offset = "0x68")]
		private NativeArray<CrowdInstanceState> _instanceStateArray;

		[Token(Token = "0x400008A")]
		[FieldOffset(Offset = "0x78")]
		private int _instanceCount;

		[Token(Token = "0x400008B")]
		[FieldOffset(Offset = "0x80")]
		private GPUICrowdPrototype _crowdPrototype;

		[Token(Token = "0x400008C")]
		[FieldOffset(Offset = "0x88")]
		private GPUICrowdRuntimeData _runtimeData;

		[Token(Token = "0x400008D")]
		[FieldOffset(Offset = "0x90")]
		private string _prototypeNameText;

		[Token(Token = "0x400008E")]
		[FieldOffset(Offset = "0x98")]
		private readonly int _bufferSize;

		[Token(Token = "0x400008F")]
		[FieldOffset(Offset = "0x9C")]
		private bool _isStateModified;

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x73C3844", Offset = "0x73BF844", VA = "0x73C3844")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x73C4058", Offset = "0x73C0058", VA = "0x73C4058")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x73C40F4", Offset = "0x73C00F4", VA = "0x73C40F4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x73C41A4", Offset = "0x73C01A4", VA = "0x73C41A4")]
		public void ChangeLODColors(bool isColored)
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x73C4278", Offset = "0x73C0278", VA = "0x73C4278")]
		public void RandomizeClips()
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x73C43A8", Offset = "0x73C03A8", VA = "0x73C43A8")]
		public void RandomizeFrames()
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x73C44B4", Offset = "0x73C04B4", VA = "0x73C44B4")]
		public void ResetAnimations()
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x73C45F8", Offset = "0x73C05F8", VA = "0x73C45F8")]
		public void SetCrowdAnimatorSpeed(float speed)
		{
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x73C4740", Offset = "0x73C0740", VA = "0x73C4740")]
		public void RandomizeSpeeds()
		{
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x73C4854", Offset = "0x73C0854", VA = "0x73C4854")]
		public void SwitchProtoype()
		{
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x73C4BC8", Offset = "0x73C0BC8", VA = "0x73C4BC8")]
		public void AddInstances()
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x73C4D50", Offset = "0x73C0D50", VA = "0x73C4D50")]
		public void RemoveInstances()
		{
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x73C3DC4", Offset = "0x73BFDC4", VA = "0x73C3DC4")]
		private void SetPrototypeInfoText()
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x73C4E40", Offset = "0x73C0E40", VA = "0x73C4E40")]
		public NoGameObjectsWithJobsDemoSceneHandler()
		{
		}
	}
}
