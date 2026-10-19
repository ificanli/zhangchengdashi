using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace GPUInstancer.CrowdAnimations
{
	[Token(Token = "0x200000B")]
	public class CrowdAnimationsDemoSceneHandler : MonoBehaviour
	{
		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x20")]
		public GPUICrowdManager gpuiCrowdManager;

		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x28")]
		public GPUInstancerLODColorDebugger gpuiLODColorDebugger;

		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x30")]
		public GPUICrowdAnimatorRandomizer gpuiCrowdAnimatorRandomizer;

		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0x38")]
		public Image imageManagerToggle;

		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x40")]
		public Button buttonMecanimAnimator;

		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0x48")]
		public Button buttonCrowdAnimator;

		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0x50")]
		public Text textSpeedValue;

		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0x58")]
		public Slider sliderSpeed;

		[Token(Token = "0x400003F")]
		[FieldOffset(Offset = "0x60")]
		public Button buttonRandomizeClips;

		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0x68")]
		public Button buttonRandomizeFrames;

		[Token(Token = "0x4000041")]
		[FieldOffset(Offset = "0x70")]
		public Button buttonRandomizeSpeeds;

		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0x78")]
		public Button buttonResetAnimations;

		[Token(Token = "0x4000043")]
		[FieldOffset(Offset = "0x80")]
		public Image imageLODWithColorToggle;

		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0x88")]
		public GameObject panelAnimatorControl;

		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0x90")]
		public GameObject panelPrototypeControl;

		[Token(Token = "0x4000046")]
		[FieldOffset(Offset = "0x98")]
		public Text textInstanceCount;

		[Token(Token = "0x4000047")]
		[FieldOffset(Offset = "0xA0")]
		private int _selectedPrototypeIndex;

		[Token(Token = "0x4000048")]
		[FieldOffset(Offset = "0xA4")]
		private int _rowCount;

		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0xA8")]
		private int _collumnCount;

		[Token(Token = "0x400004A")]
		[FieldOffset(Offset = "0xAC")]
		private float _space;

		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0xB0")]
		private List<GPUInstancerPrototype> _prototypeList;

		[Token(Token = "0x400004C")]
		[FieldOffset(Offset = "0xB8")]
		private string _prototypeNameText;

		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0xC0")]
		private List<GPUInstancerPrefab> _instanceList;

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x73BF274", Offset = "0x73BB274", VA = "0x73BF274")]
		private void Start()
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x73BF8E8", Offset = "0x73BB8E8", VA = "0x73BF8E8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x73BFA98", Offset = "0x73BBA98", VA = "0x73BFA98")]
		public void ChangeLODColors(bool isColored)
		{
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x73BFB6C", Offset = "0x73BBB6C", VA = "0x73BFB6C")]
		public void RandomizeClips(bool randomizeClips)
		{
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x73BFC60", Offset = "0x73BBC60", VA = "0x73BFC60")]
		public void RandomizeFrames(bool randomizeFrame)
		{
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x73BFD58", Offset = "0x73BBD58", VA = "0x73BFD58")]
		public void ResetAnimations()
		{
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x73BFE84", Offset = "0x73BBE84", VA = "0x73BFE84")]
		public void ToggleCrowdManager(bool enabled)
		{
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x73BFFA8", Offset = "0x73BBFA8", VA = "0x73BFFA8")]
		public void ToggleCrowdAnimator(bool enabled)
		{
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x73C0178", Offset = "0x73BC178", VA = "0x73C0178")]
		public void SetCrowdAnimatorSpeed(float speed)
		{
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x73C04D4", Offset = "0x73BC4D4", VA = "0x73C04D4")]
		public void RandomizeSpeeds()
		{
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x73C0708", Offset = "0x73BC708", VA = "0x73C0708")]
		public void SwitchProtoype()
		{
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x73C09B8", Offset = "0x73BC9B8", VA = "0x73C09B8")]
		public void AddInstances()
		{
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x73C0D84", Offset = "0x73BCD84", VA = "0x73C0D84")]
		public void QuitDemo()
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x73C0DD4", Offset = "0x73BCDD4", VA = "0x73C0DD4")]
		public CrowdAnimationsDemoSceneHandler()
		{
		}
	}
}
