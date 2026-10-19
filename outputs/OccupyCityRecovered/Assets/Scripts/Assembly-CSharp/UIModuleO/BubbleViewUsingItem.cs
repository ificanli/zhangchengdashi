using DG.Tweening;
using Il2CppDummyDll;
using StrConstants;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000822")]
	public class BubbleViewUsingItem : MonoBehaviour
	{
		[Token(Token = "0x4003E16")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Button ButtonUsingItem;

		[Token(Token = "0x4003E17")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextMeshProUGUI BubbleText;

		[Token(Token = "0x4003E18")]
		[FieldOffset(Offset = "0x30")]
		private int _index;

		[Token(Token = "0x4003E19")]
		[FieldOffset(Offset = "0x38")]
		private BubbleTextConstants.BubbleTextInfo? _bubbleInfo;

		[Token(Token = "0x4003E1A")]
		[FieldOffset(Offset = "0x50")]
		private ExpressionView _expressionView;

		[Token(Token = "0x4003E1B")]
		[FieldOffset(Offset = "0x58")]
		private Tweener _replaceShakeTween;

		[Token(Token = "0x4003E1C")]
		[FieldOffset(Offset = "0x60")]
		private Quaternion _originLocalRotation;

		[Token(Token = "0x6002D69")]
		[Address(RVA = "0x400DB7C", Offset = "0x4009B7C", VA = "0x400DB7C")]
		public void InitBubble(int index, BubbleTextConstants.BubbleTextInfo? bubbleInfo, ExpressionView expressionView)
		{
		}

		[Token(Token = "0x6002D6A")]
		[Address(RVA = "0x400DC9C", Offset = "0x4009C9C", VA = "0x400DC9C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6002D6B")]
		[Address(RVA = "0x400DD74", Offset = "0x4009D74", VA = "0x400DD74")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6002D6C")]
		[Address(RVA = "0x400DE9C", Offset = "0x4009E9C", VA = "0x400DE9C")]
		public void BindReferences(Button buttonUsingItem, TextMeshProUGUI bubbleText)
		{
		}

		[Token(Token = "0x6002D6D")]
		[Address(RVA = "0x400DEA4", Offset = "0x4009EA4", VA = "0x400DEA4")]
		public void PlayReplaceShake()
		{
		}

		[Token(Token = "0x6002D6E")]
		[Address(RVA = "0x400DE54", Offset = "0x4009E54", VA = "0x400DE54")]
		public void StopReplaceShake()
		{
		}

		[Token(Token = "0x6002D6F")]
		[Address(RVA = "0x400DFB0", Offset = "0x4009FB0", VA = "0x400DFB0")]
		private void OnUsingItemClicked()
		{
		}

		[Token(Token = "0x6002D70")]
		[Address(RVA = "0x400E160", Offset = "0x400A160", VA = "0x400E160")]
		public BubbleViewUsingItem()
		{
		}
	}
}
