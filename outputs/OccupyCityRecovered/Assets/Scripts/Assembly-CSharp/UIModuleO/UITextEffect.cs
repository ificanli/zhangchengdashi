using Il2CppDummyDll;
using UnityEngine;

namespace UIModuleO
{
	[Token(Token = "0x2000BD0")]
	public class UITextEffect : UITextEffectComponents
	{
		[Token(Token = "0x40055CB")]
		[FieldOffset(Offset = "0x50")]
		private CanvasGroup _canvasGroup;

		[Token(Token = "0x40055CC")]
		[FieldOffset(Offset = "0x58")]
		private float _alpha;

		[Token(Token = "0x60048E9")]
		[Address(RVA = "0x423F9C8", Offset = "0x423B9C8", VA = "0x423F9C8", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60048EA")]
		[Address(RVA = "0x423FA58", Offset = "0x423BA58", VA = "0x423FA58")]
		public void Show(string text, Vector2 anchorPos, float endScale)
		{
		}

		[Token(Token = "0x60048EB")]
		[Address(RVA = "0x423FD70", Offset = "0x423BD70", VA = "0x423FD70")]
		public void Show(string text, Vector3 uiPosition, float endScale)
		{
		}

		[Token(Token = "0x60048EC")]
		[Address(RVA = "0x423FF5C", Offset = "0x423BF5C", VA = "0x423FF5C")]
		private void Update()
		{
		}

		[Token(Token = "0x60048ED")]
		[Address(RVA = "0x42400A8", Offset = "0x423C0A8", VA = "0x42400A8", Slot = "11")]
		protected override void BindButtonEvent()
		{
		}

		[Token(Token = "0x60048EE")]
		[Address(RVA = "0x42400AC", Offset = "0x423C0AC", VA = "0x42400AC")]
		public UITextEffect()
		{
		}
	}
}
