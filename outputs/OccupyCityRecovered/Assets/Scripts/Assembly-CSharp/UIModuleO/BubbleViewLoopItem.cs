using System.Runtime.InteropServices;
using Il2CppDummyDll;
using StrConstants;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000821")]
	public class BubbleViewLoopItem : MonoBehaviour
	{
		[Token(Token = "0x4003E0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Button ButtonBubble;

		[Token(Token = "0x4003E0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Button ButtonEquip;

		[Token(Token = "0x4003E10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TextMeshProUGUI BubbleText;

		[Token(Token = "0x4003E11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image BgImage;

		[Token(Token = "0x4003E12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject Select;

		[Token(Token = "0x4003E13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BubbleTextConstants.BubbleTextInfo _bubbleInfo;

		[Token(Token = "0x4003E14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private ExpressionView _parentView;

		[Token(Token = "0x4003E15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool _isOwned;

		[Token(Token = "0x6002D61")]
		[Address(RVA = "0x400D55C", Offset = "0x400955C", VA = "0x400D55C")]
		public void Bind(BubbleTextConstants.BubbleTextInfo bubbleInfo, ExpressionView parentView)
		{
		}

		[Token(Token = "0x6002D62")]
		[Address(RVA = "0x400D808", Offset = "0x4009808", VA = "0x400D808")]
		private void Awake()
		{
		}

		[Token(Token = "0x6002D63")]
		[Address(RVA = "0x400D98C", Offset = "0x400998C", VA = "0x400D98C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6002D64")]
		[Address(RVA = "0x400DAE4", Offset = "0x4009AE4", VA = "0x400DAE4")]
		public void BindReferences(Button buttonBubble, Button buttonEquip, TextMeshProUGUI bubbleText, Image bgImage, [Optional] GameObject select)
		{
		}

		[Token(Token = "0x6002D65")]
		[Address(RVA = "0x400D724", Offset = "0x4009724", VA = "0x400D724")]
		public void RefreshSelectedState()
		{
		}

		[Token(Token = "0x6002D66")]
		[Address(RVA = "0x400DB10", Offset = "0x4009B10", VA = "0x400DB10")]
		private void OnEquipClicked()
		{
		}

		[Token(Token = "0x6002D67")]
		[Address(RVA = "0x400D680", Offset = "0x4009680", VA = "0x400D680")]
		private static bool IsBubbleOwned(string bubbleId)
		{
			return default;
		}

		[Token(Token = "0x6002D68")]
		[Address(RVA = "0x400DB74", Offset = "0x4009B74", VA = "0x400DB74")]
		public BubbleViewLoopItem()
		{
		}
	}
}
