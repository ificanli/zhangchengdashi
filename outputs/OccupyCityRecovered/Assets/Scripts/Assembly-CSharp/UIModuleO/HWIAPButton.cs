using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using StrConstants;
using UnityEngine;

namespace UIModuleO
{
	[Token(Token = "0x2000919")]
	public class HWIAPButton : HWIAPButtonComponents
	{
		[Token(Token = "0x4004462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool hadInit;

		[Token(Token = "0x4004463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Header("内购表的ID")]
		public string productInfoId;

		[Token(Token = "0x4004464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Header("IAP触发入口标识")]
		[IAPPlacementDropdown]
		public string placement;

		[Token(Token = "0x4004465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private string productId;

		[Token(Token = "0x4004466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Action<bool> onPurchaseProductOver;

		[Token(Token = "0x6003498")]
		[Address(RVA = "0x40AAD88", Offset = "0x40A6D88", VA = "0x40AAD88", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6003499")]
		[Address(RVA = "0x40AADF8", Offset = "0x40A6DF8", VA = "0x40AADF8")]
		public void Init([Optional] string _productInfoId, [Optional] Action<bool> onPurchaseProductOver, [Optional] string placement)
		{
		}

		[Token(Token = "0x600349A")]
		[Address(RVA = "0x40AB1CC", Offset = "0x40A71CC", VA = "0x40AB1CC")]
		public void InitByStoreProductId(string storeProductId, [Optional] Action<bool> onPurchaseProductOver, [Optional] string placement)
		{
		}

		[Token(Token = "0x600349B")]
		[Address(RVA = "0x40AAF80", Offset = "0x40A6F80", VA = "0x40AAF80")]
		private void UpdatePriceText()
		{
		}

		[Token(Token = "0x600349C")]
		[Address(RVA = "0x40AB314", Offset = "0x40A7314", VA = "0x40AB314")]
		public void PurchaseProduct()
		{
		}

		[Token(Token = "0x600349D")]
		[Address(RVA = "0x40AB370", Offset = "0x40A7370", VA = "0x40AB370", Slot = "12")]
		protected override void OnButtonExtendHWIAPButtonClicked()
		{
		}

		[Token(Token = "0x600349E")]
		[Address(RVA = "0x40AB3F4", Offset = "0x40A73F4", VA = "0x40AB3F4")]
		public HWIAPButton()
		{
		}
	}
}
