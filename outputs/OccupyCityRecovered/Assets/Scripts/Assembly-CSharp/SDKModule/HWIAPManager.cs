using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using GameModule;
using Il2CppDummyDll;
using ToolModule;
using ljzs_lt;

namespace SDKModule
{
	[Token(Token = "0x200017A")]
	public class HWIAPManager : ManagerBase<HWIAPManager>
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200017E")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__8 : IAsyncStateMachine
		{
			[Token(Token = "0x4001A6A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001A6B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x6000616")]
			[Address(RVA = "0x3F76448", Offset = "0x3F72448", VA = "0x3F76448", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000617")]
			[Address(RVA = "0x3F764FC", Offset = "0x3F724FC", VA = "0x3F764FC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4001A5D")]
		private const float LocalPriceLogThrottleSeconds = 30f;

		[Token(Token = "0x4001A5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly string _noAdsProductId;

		[Token(Token = "0x4001A5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Action<bool> _onComplete;

		[Token(Token = "0x4001A60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<string> _unfinishedPurchase;

		[Token(Token = "0x4001A61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly Dictionary<string, float> _lastLocalPriceFallbackLogTime;

		[Token(Token = "0x4001A62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly Dictionary<string, float> _lastPlaceholderPriceLogTime;

		[Token(Token = "0x4001A63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly Dictionary<string, string> _cdkConfigs;

		[Token(Token = "0x4001A64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool isPurchaseInitFinished;

		[Token(Token = "0x4001A65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private readonly Dictionary<string, Action<string>> _purchaseCompleteCallbacks;

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x3F74310", Offset = "0x3F70310", VA = "0x3F74310", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__8))]
		public override UniTask Init()
		{
			return default;
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x3F74390", Offset = "0x3F70390", VA = "0x3F74390")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x3F74394", Offset = "0x3F70394", VA = "0x3F74394")]
		public void EnterHomeInit()
		{
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x3F74534", Offset = "0x3F70534", VA = "0x3F74534")]
		private void InitCdkConfig()
		{
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x3F746F0", Offset = "0x3F706F0", VA = "0x3F746F0")]
		private void OnPurchaseFinish(bool purchased, PurchaseConfig config)
		{
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x3F74DB0", Offset = "0x3F70DB0", VA = "0x3F74DB0")]
		private void UnfinishedPurchase(PurchaseConfig config)
		{
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x3F74F98", Offset = "0x3F70F98", VA = "0x3F74F98")]
		private void OnCustomOrder(string data)
		{
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0x3F74FA0", Offset = "0x3F70FA0", VA = "0x3F74FA0")]
		public void GetCustomReward(string data, CurrencyTransactionSceneType type)
		{
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0x3F75140", Offset = "0x3F71140", VA = "0x3F75140")]
		private void OnCdkCallback(string cdk)
		{
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0x3F75040", Offset = "0x3F71040", VA = "0x3F75040")]
		private static bool IsValidRewardDataFormat(string data)
		{
			return default;
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0x3F7528C", Offset = "0x3F7128C", VA = "0x3F7528C")]
		private void ProcessUnfinishedPurchase()
		{
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0x3F748B0", Offset = "0x3F708B0", VA = "0x3F748B0")]
		private void ProcessProduct(string productData)
		{
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0x3F75450", Offset = "0x3F71450", VA = "0x3F75450")]
		public void AddPurchaseCompleteListener(string purchaseId, Action<string> callback)
		{
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0x3F755F0", Offset = "0x3F715F0", VA = "0x3F755F0")]
		public void PurchaseProduct(string productData, string placement, [Optional] Action<bool> onComplete)
		{
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0x3F758E4", Offset = "0x3F718E4", VA = "0x3F758E4")]
		public string GetLocalizedPrice(string productKey)
		{
			return null;
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0x3F75CC0", Offset = "0x3F71CC0", VA = "0x3F75CC0")]
		private static PurchaseConfig TryResolvePurchaseConfig(string productKey)
		{
			return null;
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0x3F75E84", Offset = "0x3F71E84", VA = "0x3F75E84")]
		private static bool TryGetLocalizedPriceFromSdk(string prodKeyForSdk, out string localized)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED HWIAPManager.TryGetLocalizedPriceFromSdk RVA=0x3F75E84 Token=0x6000609");
}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0x3F76188", Offset = "0x3F72188", VA = "0x3F76188")]
		private static string FormatSdkPriceDisplay(string price)
		{
			return null;
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0x3F75F64", Offset = "0x3F71F64", VA = "0x3F75F64")]
		private static string NormalizePriceDisplay(string price)
		{
			return null;
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0x3F75FBC", Offset = "0x3F71FBC", VA = "0x3F75FBC")]
		private void TryLogLocalPriceFallback(string productKey, string configProductId, string reason)
		{
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0x3F75B50", Offset = "0x3F71B50", VA = "0x3F75B50")]
		private void TryLogPlaceholderPrice(string productKey, string reason)
		{
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0x3F76234", Offset = "0x3F72234", VA = "0x3F76234")]
		public HWIAPManager()
		{
		}
	}
}
