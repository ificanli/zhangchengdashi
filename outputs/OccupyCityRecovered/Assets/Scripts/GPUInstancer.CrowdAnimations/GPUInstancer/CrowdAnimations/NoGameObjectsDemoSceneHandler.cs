using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace GPUInstancer.CrowdAnimations
{
	[Token(Token = "0x2000010")]
	public class NoGameObjectsDemoSceneHandler : MonoBehaviour
	{
		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0x20")]
		public GPUICrowdManager gpuiCrowdManager;

		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0x28")]
		public GPUInstancerLODColorDebugger gpuiLODColorDebugger;

		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0x30")]
		public Slider sliderSpeed;

		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0x38")]
		public Text textSpeedValue;

		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0x40")]
		public Text textInstanceCount;

		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0x48")]
		private int _selectedPrototypeIndex;

		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0x4C")]
		private int _rowCount;

		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0x50")]
		private int _collumnCount;

		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0x54")]
		private float _space;

		[Token(Token = "0x4000079")]
		[FieldOffset(Offset = "0x58")]
		private Matrix4x4[] _instanceDataArray;

		[Token(Token = "0x400007A")]
		[FieldOffset(Offset = "0x60")]
		private GPUICrowdAnimator[] _animators;

		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x68")]
		private int _instanceCount;

		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x70")]
		private GPUICrowdPrototype _crowdPrototype;

		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0x78")]
		private GPUICrowdRuntimeData _runtimeData;

		[Token(Token = "0x400007E")]
		[FieldOffset(Offset = "0x80")]
		private string _prototypeNameText;

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x73C1E24", Offset = "0x73BDE24", VA = "0x73C1E24")]
		public void Start()
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x73C2690", Offset = "0x73BE690", VA = "0x73C2690")]
		public void ChangeLODColors(bool isColored)
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x73C2764", Offset = "0x73BE764", VA = "0x73C2764")]
		public void RandomizeClips()
		{
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x73C28E0", Offset = "0x73BE8E0", VA = "0x73C28E0")]
		public void RandomizeFrames()
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x73C2BD4", Offset = "0x73BEBD4", VA = "0x73C2BD4")]
		public void ResetAnimations()
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x73C2D74", Offset = "0x73BED74", VA = "0x73C2D74")]
		public void SetCrowdAnimatorSpeed(float speed)
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x73C3138", Offset = "0x73BF138", VA = "0x73C3138")]
		public void RandomizeSpeeds()
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x73C3238", Offset = "0x73BF238", VA = "0x73C3238")]
		public void SwitchProtoype()
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x73C3554", Offset = "0x73BF554", VA = "0x73C3554")]
		public void AddInstances()
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x73C373C", Offset = "0x73BF73C", VA = "0x73C373C")]
		public void RemoveInstances()
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x73C23FC", Offset = "0x73BE3FC", VA = "0x73C23FC")]
		private void SetPrototypeInfoText()
		{
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x73C382C", Offset = "0x73BF82C", VA = "0x73C382C")]
		public NoGameObjectsDemoSceneHandler()
		{
		}
	}
}
