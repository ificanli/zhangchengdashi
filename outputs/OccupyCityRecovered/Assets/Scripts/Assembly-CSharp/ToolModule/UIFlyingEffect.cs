using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace ToolModule
{
	[Token(Token = "0x20001AA")]
	public class UIFlyingEffect : MonoBehaviour
	{
		[Token(Token = "0x4001AD8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AnimationCurve moveCurve;

		[Token(Token = "0x4001AD9")]
		[FieldOffset(Offset = "0x28")]
		private RectTransform selfRect;

		[Token(Token = "0x4001ADA")]
		[FieldOffset(Offset = "0x30")]
		private Vector2 startPos;

		[Token(Token = "0x4001ADB")]
		[FieldOffset(Offset = "0x38")]
		private Vector2 endPos;

		[Token(Token = "0x4001ADC")]
		[FieldOffset(Offset = "0x40")]
		private float duration;

		[Token(Token = "0x4001ADD")]
		[FieldOffset(Offset = "0x44")]
		private float elapsed;

		[Token(Token = "0x4001ADE")]
		[FieldOffset(Offset = "0x48")]
		private bool playing;

		[Token(Token = "0x4001ADF")]
		[FieldOffset(Offset = "0x50")]
		private UnityAction onComplete;

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x3F83174", Offset = "0x3F7F174", VA = "0x3F83174")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x3F831E0", Offset = "0x3F7F1E0", VA = "0x3F831E0")]
		public void Init(Vector2 startLocalPos, RectTransform targetRect, RectTransform canvasRoot, float moveDuration, UnityAction onCompleteCallback)
		{
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x3F83474", Offset = "0x3F7F474", VA = "0x3F83474")]
		private void Update()
		{
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x3F835A0", Offset = "0x3F7F5A0", VA = "0x3F835A0")]
		public UIFlyingEffect()
		{
		}
	}
}
