using DG.Tweening;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace PufferMiniGame
{
	[Token(Token = "0x2000D4E")]
	public class TipPopUI : MonoBehaviour
	{
		[Token(Token = "0x4005F07")]
		[FieldOffset(Offset = "0x20")]
		public bool active;

		[Token(Token = "0x4005F08")]
		[FieldOffset(Offset = "0x28")]
		private Image _backImg;

		[Token(Token = "0x4005F09")]
		[FieldOffset(Offset = "0x30")]
		private TextMeshProUGUI _text;

		[Token(Token = "0x4005F0A")]
		[FieldOffset(Offset = "0x38")]
		private RectTransform _rect;

		[Token(Token = "0x4005F0B")]
		[FieldOffset(Offset = "0x40")]
		private float _timer;

		[Token(Token = "0x4005F0C")]
		[FieldOffset(Offset = "0x44")]
		private Vector2 _originPos;

		[Token(Token = "0x4005F0D")]
		[FieldOffset(Offset = "0x50")]
		private Tween _tween;

		[Token(Token = "0x4005F0E")]
		[FieldOffset(Offset = "0x58")]
		private TipPanel _tipPanel;

		[Token(Token = "0x6005261")]
		[Address(RVA = "0x4300D60", Offset = "0x42FCD60", VA = "0x4300D60")]
		private void Awake()
		{
		}

		[Token(Token = "0x6005262")]
		[Address(RVA = "0x4300A30", Offset = "0x42FCA30", VA = "0x4300A30")]
		public void Show(string str, TipPanel panel)
		{
		}

		[Token(Token = "0x6005263")]
		[Address(RVA = "0x4300CA8", Offset = "0x42FCCA8", VA = "0x4300CA8")]
		public void UpdatePos(int index)
		{
		}

		[Token(Token = "0x6005264")]
		[Address(RVA = "0x4300E1C", Offset = "0x42FCE1C", VA = "0x4300E1C")]
		private void Update()
		{
		}

		[Token(Token = "0x6005265")]
		[Address(RVA = "0x4300F18", Offset = "0x42FCF18", VA = "0x4300F18")]
		public TipPopUI()
		{
		}
	}
}
