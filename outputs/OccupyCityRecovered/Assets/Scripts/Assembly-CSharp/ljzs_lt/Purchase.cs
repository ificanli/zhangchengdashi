using System;
using DBTSDK.Iap;
using Il2CppDummyDll;
using UnityEngine.Events;

namespace ljzs_lt
{
	[Token(Token = "0x2000F4D")]
	public class Purchase : IapNewProcedureBase
	{
		[Token(Token = "0x40069C6")]
		[FieldOffset(Offset = "0x78")]
		private readonly Action<string, int> _queryCallBack;

		[Token(Token = "0x40069C7")]
		[FieldOffset(Offset = "0x80")]
		private readonly Action<CommdityChannel, string[]> _buyCallBack;

		[Token(Token = "0x40069C8")]
		[FieldOffset(Offset = "0x88")]
		private readonly Action<NonConsumableState> _reshNonConsumableStateCallBack;

		[Token(Token = "0x40069C9")]
		[FieldOffset(Offset = "0x90")]
		private readonly Action<bool, int> _productBuyOverCallBack;

		[Token(Token = "0x40069CA")]
		[FieldOffset(Offset = "0x98")]
		private readonly Action<string> _cdkCallback;

		[Token(Token = "0x40069CB")]
		[FieldOffset(Offset = "0xA0")]
		public bool IsInit;

		[Token(Token = "0x6005B96")]
		[Address(RVA = "0x439E0E8", Offset = "0x439A0E8", VA = "0x439E0E8")]
		public Purchase(Action<string, int> queryCallBack, Action<CommdityChannel, string[]> buyCallBack, Action<bool, int> productBuyOverCallBack, Action<NonConsumableState> reshNonConsumableStateCallBack, Action<string> cdkCallback)
		{
		}

		[Token(Token = "0x6005B97")]
		[Address(RVA = "0x439EF54", Offset = "0x439AF54", VA = "0x439EF54", Slot = "4")]
		public override void InitIap(bool useDefaultLoadingUI = false, bool useDefaultBuyConfirmUI = false)
		{
		}

		[Token(Token = "0x6005B98")]
		[Address(RVA = "0x439EF7C", Offset = "0x439AF7C", VA = "0x439EF7C", Slot = "16")]
		protected override void CloseWaitLodingUI()
		{
		}

		[Token(Token = "0x6005B99")]
		[Address(RVA = "0x439EFEC", Offset = "0x439AFEC", VA = "0x439EFEC", Slot = "20")]
		protected override void ReceiveConsumableCommodity(CommdityChannel commdityChannel, params string[] gameKey)
		{
		}

		[Token(Token = "0x6005B9A")]
		[Address(RVA = "0x439F084", Offset = "0x439B084", VA = "0x439F084", Slot = "22")]
		protected override void ReshNonConsumableState(string gameKey)
		{
		}

		[Token(Token = "0x6005B9B")]
		[Address(RVA = "0x439F108", Offset = "0x439B108", VA = "0x439F108", Slot = "23")]
		protected override void ReshNonConsumableState(string gameKey, int state)
		{
		}

		[Token(Token = "0x6005B9C")]
		[Address(RVA = "0x439F1DC", Offset = "0x439B1DC", VA = "0x439F1DC", Slot = "24")]
		protected override void ReshNonConsumableState(NonConsumableState state)
		{
		}

		[Token(Token = "0x6005B9D")]
		[Address(RVA = "0x439F2A8", Offset = "0x439B2A8", VA = "0x439F2A8", Slot = "19")]
		protected override void ReceiveGivenGiftProduct(string id, string count)
		{
		}

		[Token(Token = "0x6005B9E")]
		[Address(RVA = "0x439F388", Offset = "0x439B388", VA = "0x439F388", Slot = "14")]
		protected override void ShowUnFinishOrderTips(UnityAction<int> result)
		{
		}

		[Token(Token = "0x6005B9F")]
		[Address(RVA = "0x439F3CC", Offset = "0x439B3CC", VA = "0x439F3CC", Slot = "8")]
		protected override void ProductBuyOver(bool isSucceed, int errorCode)
		{
		}

		[Token(Token = "0x6005BA0")]
		[Address(RVA = "0x439F4BC", Offset = "0x439B4BC", VA = "0x439F4BC", Slot = "15")]
		protected override void ShowWaitLodingUI()
		{
		}
	}
}
