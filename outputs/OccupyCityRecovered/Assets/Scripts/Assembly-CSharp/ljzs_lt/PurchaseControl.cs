using System;
using System.Collections.Generic;
using DBTSDK.Iap;
using GameFramework;
using Il2CppDummyDll;
using L_Tools;

namespace ljzs_lt
{
	[Token(Token = "0x2000F4C")]
	[ControlRegister(10)]
	public class PurchaseControl : RichControlBase<PurchaseControl>, IControl
	{
		[Token(Token = "0x40069BA")]
		[FieldOffset(Offset = "0x30")]
		private Action<bool, PurchaseConfig> _onPurchaseFinish;

		[Token(Token = "0x40069BB")]
		[FieldOffset(Offset = "0x38")]
		private Action<PurchaseConfig> _unfinish;

		[Token(Token = "0x40069BC")]
		[FieldOffset(Offset = "0x40")]
		private Action<string> _customOrder;

		[Token(Token = "0x40069BD")]
		[FieldOffset(Offset = "0x48")]
		private Action<string> _onCdkCallback;

		[Token(Token = "0x40069BE")]
		[FieldOffset(Offset = "0x50")]
		private Action _onCheckAllSubscriptionFinish;

		[Token(Token = "0x40069BF")]
		[FieldOffset(Offset = "0x58")]
		private Purchase _purchase;

		[Token(Token = "0x40069C0")]
		[FieldOffset(Offset = "0x60")]
		public bool _isInitGFIAP;

		[Token(Token = "0x40069C1")]
		[FieldOffset(Offset = "0x0")]
		public static bool isDY_IOS;

		[Token(Token = "0x40069C2")]
		[FieldOffset(Offset = "0x68")]
		private Dictionary<string, PurchaseConfig> _dicPurchaseData2ID;

		[Token(Token = "0x40069C3")]
		[FieldOffset(Offset = "0x70")]
		private Dictionary<string, PurchaseConfig> _dicPurchaseID2Config;

		[Token(Token = "0x40069C4")]
		[FieldOffset(Offset = "0x78")]
		private Dictionary<string, NonConsumableState> _dicNonConsumableState;

		[Token(Token = "0x40069C5")]
		[FieldOffset(Offset = "0x80")]
		private readonly List<string> _needReportShow;

		[Token(Token = "0x17000F74")]
		public static bool IsIOSPay
		{
			[Token(Token = "0x6005B80")]
			[Address(RVA = "0x439D87C", Offset = "0x439987C", VA = "0x439D87C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6005B81")]
		[Address(RVA = "0x439D974", Offset = "0x4399974", VA = "0x439D974")]
		public void InitDIC()
		{
		}

		[Token(Token = "0x6005B82")]
		[Address(RVA = "0x439DE64", Offset = "0x4399E64", VA = "0x439DE64", Slot = "8")]
		public override void OnInit()
		{
		}

		[Token(Token = "0x6005B83")]
		[Address(RVA = "0x439DEB4", Offset = "0x4399EB4", VA = "0x439DEB4", Slot = "9")]
		public override void InitAfterLogin()
		{
		}

		[Token(Token = "0x6005B84")]
		[Address(RVA = "0x439E144", Offset = "0x439A144", VA = "0x439E144")]
		public void InitIAP(Action<bool, PurchaseConfig> onPurchaseFinish, Action<PurchaseConfig> unfinish, Action<string> customOrder, Action<string> onCdkCallback)
		{
		}

		[Token(Token = "0x6005B85")]
		[Address(RVA = "0x439E280", Offset = "0x439A280", VA = "0x439E280")]
		public (string, string, string, string, string) GetProductInfo(string prodKey)
		{
			return default;
		}

		[Token(Token = "0x6005B86")]
		[Address(RVA = "0x439E360", Offset = "0x439A360", VA = "0x439E360")]
		public void Restore()
		{
		}

		[Token(Token = "0x6005B87")]
		[Address(RVA = "0x439E3C4", Offset = "0x439A3C4", VA = "0x439E3C4")]
		public void RequestBuyProductWithProductData(string productData)
		{
		}

		[Token(Token = "0x6005B88")]
		[Address(RVA = "0x439E620", Offset = "0x439A620", VA = "0x439E620")]
		public bool VerifyNotConsumeByData(string prodKey)
		{
			return default;
		}

		[Token(Token = "0x6005B89")]
		[Address(RVA = "0x439E4D0", Offset = "0x439A4D0", VA = "0x439E4D0")]
		public void RequestBuyProduct(string prodKey)
		{
		}

		[Token(Token = "0x6005B8A")]
		[Address(RVA = "0x439E634", Offset = "0x439A634", VA = "0x439E634")]
		public void RequestCheckAllSubscription(Action callback)
		{
		}

		[Token(Token = "0x6005B8B")]
		[Address(RVA = "0x439E664", Offset = "0x439A664", VA = "0x439E664")]
		private void QueryCallBack(string gameKey, int state)
		{
		}

		[Token(Token = "0x6005B8C")]
		[Address(RVA = "0x439E750", Offset = "0x439A750", VA = "0x439E750")]
		private void BuyCallBack(CommdityChannel commodityChannel, params string[] gameKeys)
		{
		}

		[Token(Token = "0x6005B8D")]
		[Address(RVA = "0x439E898", Offset = "0x439A898", VA = "0x439E898")]
		private void OnBuySuccess(string gameKey, CommdityChannel commodityChannel)
		{
		}

		[Token(Token = "0x6005B8E")]
		[Address(RVA = "0x439EA30", Offset = "0x439AA30", VA = "0x439EA30")]
		private void ProductBuyOverCallBack(bool isSucceed, int errorCode)
		{
		}

		[Token(Token = "0x6005B8F")]
		[Address(RVA = "0x439EAFC", Offset = "0x439AAFC", VA = "0x439EAFC")]
		private void ReshNonConsumableStateCallBack(NonConsumableState state)
		{
		}

		[Token(Token = "0x6005B90")]
		[Address(RVA = "0x439EC6C", Offset = "0x439AC6C", VA = "0x439EC6C")]
		private void OnCdkCallback(string cdk)
		{
		}

		[Token(Token = "0x6005B91")]
		[Address(RVA = "0x439E458", Offset = "0x439A458", VA = "0x439E458")]
		public PurchaseConfig GetProductConfigByData(string prodData)
		{
			return null;
		}

		[Token(Token = "0x6005B92")]
		[Address(RVA = "0x439EC88", Offset = "0x439AC88", VA = "0x439EC88")]
		public Commodity TryGetCommodity(string gameKey)
		{
			return null;
		}

		[Token(Token = "0x6005B93")]
		[Address(RVA = "0x439ECBC", Offset = "0x439ACBC", VA = "0x439ECBC")]
		public void ReportIAPShow(string purchaseID)
		{
		}

		[Token(Token = "0x6005B94")]
		[Address(RVA = "0x439EE24", Offset = "0x439AE24", VA = "0x439EE24")]
		public List<PurchaseConfig> GetAllPurchaseConfig()
		{
			return null;
		}

		[Token(Token = "0x6005B95")]
		[Address(RVA = "0x439EEC4", Offset = "0x439AEC4", VA = "0x439EEC4")]
		public PurchaseControl()
		{
		}
	}
}
