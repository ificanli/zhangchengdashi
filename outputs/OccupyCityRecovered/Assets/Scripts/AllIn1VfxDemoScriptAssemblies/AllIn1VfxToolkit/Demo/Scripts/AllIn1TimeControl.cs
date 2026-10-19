using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace AllIn1VfxToolkit.Demo.Scripts
{
	[Token(Token = "0x2000013")]
	public class AllIn1TimeControl : MonoBehaviour
	{
		[Token(Token = "0x4000062")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private KeyCode increaseTimeScale;

		[Token(Token = "0x4000063")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private KeyCode increaseTimeScaleAlt;

		[Token(Token = "0x4000064")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private KeyCode decreaseTimeScale;

		[Token(Token = "0x4000065")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private KeyCode decreaseTimeScaleAlt;

		[Token(Token = "0x4000066")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private KeyCode pauseKey;

		[Token(Token = "0x4000067")]
		[FieldOffset(Offset = "0x34")]
		[Range(0f, 1f)]
		[SerializeField]
		private float timeScaleInterval;

		[Token(Token = "0x4000068")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Slider timeScaleSlider;

		[Token(Token = "0x4000069")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image pausedButtonImage;

		[Token(Token = "0x400006A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Color pausedButtonColor;

		[Token(Token = "0x400006B")]
		[FieldOffset(Offset = "0x58")]
		private bool timeScaleSliderNotNull;

		[Token(Token = "0x400006C")]
		[FieldOffset(Offset = "0x5C")]
		private float lastChangeTime;

		[Token(Token = "0x400006D")]
		[FieldOffset(Offset = "0x60")]
		private AllIn1DemoScaleTween pausedButtonTween;

		[Token(Token = "0x400006E")]
		[FieldOffset(Offset = "0x68")]
		private Text pausedButtonText;

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x3CF08C4", Offset = "0x3CEC8C4", VA = "0x3CF08C4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x3CF0B2C", Offset = "0x3CECB2C", VA = "0x3CF0B2C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x3CF0C8C", Offset = "0x3CECC8C", VA = "0x3CF0C8C")]
		private void ChangeTimeScale(float changeAmount)
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x3CF0A1C", Offset = "0x3CECA1C", VA = "0x3CF0A1C")]
		private void UpdateTimeScaleUI()
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x3CF0CE0", Offset = "0x3CECCE0", VA = "0x3CF0CE0")]
		public void PauseUiButton()
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x3CF0D1C", Offset = "0x3CECD1C", VA = "0x3CF0D1C")]
		public void CurrentEffectChanged()
		{
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x3CF0D60", Offset = "0x3CECD60", VA = "0x3CF0D60")]
		public AllIn1TimeControl()
		{
		}
	}
}
