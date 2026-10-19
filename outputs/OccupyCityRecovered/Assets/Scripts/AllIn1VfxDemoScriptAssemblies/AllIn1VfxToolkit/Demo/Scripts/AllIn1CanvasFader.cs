using Il2CppDummyDll;
using UnityEngine;

namespace AllIn1VfxToolkit.Demo.Scripts
{
	[Token(Token = "0x200000B")]
	public class AllIn1CanvasFader : MonoBehaviour
	{
		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private KeyCode fadeToggleKey;

		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float tweenSpeed;

		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AllIn1DemoScaleTween hideUiButtonTween;

		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x30")]
		private bool isTweening;

		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x34")]
		private float currentAlpha;

		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x38")]
		private float targetAlpha;

		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x40")]
		private CanvasGroup canvasGroup;

		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0x48")]
		private bool hideUiButtonTweenNotNull;

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x3CEF3C8", Offset = "0x3CEB3C8", VA = "0x3CEF3C8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x3CEF46C", Offset = "0x3CEB46C", VA = "0x3CEF46C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x3CEF500", Offset = "0x3CEB500", VA = "0x3CEF500")]
		public void HideUiButtonPressed()
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x3CEF55C", Offset = "0x3CEB55C", VA = "0x3CEF55C")]
		private void MakeCanvasVisibleTween()
		{
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x3CEF570", Offset = "0x3CEB570", VA = "0x3CEF570")]
		private void MakeCanvasInvisibleTween()
		{
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x3CEF580", Offset = "0x3CEB580", VA = "0x3CEF580")]
		public AllIn1CanvasFader()
		{
		}
	}
}
