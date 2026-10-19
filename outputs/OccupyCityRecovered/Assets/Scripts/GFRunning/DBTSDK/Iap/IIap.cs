using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Events;
using UnityEngine.Networking;

namespace DBTSDK.Iap
{
	[Token(Token = "0x20002C9")]
	public abstract class IIap
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002CB")]
		[CompilerGenerated]
		private struct _003CAutoCloseBuyProduct_003Ed__28 : IAsyncStateMachine
		{
			[Token(Token = "0x4001788")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001789")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400178A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private object _003C_003Eu__1;

			[Token(Token = "0x60050D5")]
			[Address(RVA = "0x7115EA0", Offset = "0x7111EA0", VA = "0x7115EA0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60050D6")]
			[Address(RVA = "0x7116084", Offset = "0x7112084", VA = "0x7116084", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x20002CC")]
		[CompilerGenerated]
		private sealed class _003CReadProductConfigs_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400178B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400178C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400178D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Action<byte[], bool> callBack;

			[Token(Token = "0x400178E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UnityWebRequest _003Crequestdb_003E5__2;

			[Token(Token = "0x400178F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UnityWebRequest _003Crequest_003E5__3;

			[Token(Token = "0x17001092")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60050DA")]
				[Address(RVA = "0x7116608", Offset = "0x7112608", VA = "0x7116608", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17001093")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60050DC")]
				[Address(RVA = "0x7116648", Offset = "0x7112648", VA = "0x7116648", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60050D7")]
			[Address(RVA = "0x7116090", Offset = "0x7112090", VA = "0x7116090")]
			[DebuggerHidden]
			public _003CReadProductConfigs_003Ed__21(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60050D8")]
			[Address(RVA = "0x71160B8", Offset = "0x71120B8", VA = "0x71160B8", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60050D9")]
			[Address(RVA = "0x71160BC", Offset = "0x71120BC", VA = "0x71160BC", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60050DA")]
			[Address(RVA = "0x7116608", Offset = "0x7112608", VA = "0x7116608", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60050DB")]
			[Address(RVA = "0x7116610", Offset = "0x7112610", VA = "0x7116610", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60050DC")]
			[Address(RVA = "0x7116648", Offset = "0x7112648", VA = "0x7116648", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002CD")]
		[CompilerGenerated]
		private struct _003CTestBuy_003Ed__29 : IAsyncStateMachine
		{
			[Token(Token = "0x4001790")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001791")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001792")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public IIap _003C_003E4__this;

			[Token(Token = "0x4001793")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string productID;

			[Token(Token = "0x4001794")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private object _003C_003Eu__1;

			[Token(Token = "0x60050DD")]
			[Address(RVA = "0x7116650", Offset = "0x7112650", VA = "0x7116650", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60050DE")]
			[Address(RVA = "0x71168F8", Offset = "0x71128F8", VA = "0x71168F8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002CE")]
		[CompilerGenerated]
		private struct _003CTestRestore_003Ed__53 : IAsyncStateMachine
		{
			[Token(Token = "0x4001795")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001796")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001797")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public IIap _003C_003E4__this;

			[Token(Token = "0x4001798")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private object _003C_003Eu__1;

			[Token(Token = "0x60050DF")]
			[Address(RVA = "0x7116904", Offset = "0x7112904", VA = "0x7116904", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60050E0")]
			[Address(RVA = "0x7116B10", Offset = "0x7112B10", VA = "0x7116B10", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4001772")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal Dictionary<string, int> dicUnFinishOrder;

		[Token(Token = "0x4001773")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool isSupportPay;

		[Token(Token = "0x4001774")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private int UnFinishTipsCount;

		[Token(Token = "0x4001775")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool IsInitialization;

		[Token(Token = "0x4001776")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		private bool UseDefaultLoadingUI;

		[Token(Token = "0x4001777")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		private bool UseDefaultBuyConfirmUI;

		[Token(Token = "0x4001778")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected Dictionary<string, ProductData> dicProductConfigs;

		[Token(Token = "0x4001779")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal string ProductKey;

		[Token(Token = "0x400177A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected float UpdateFixOrdersTimes;

		[Token(Token = "0x400177B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		protected float UpdateFailedOrdersTimes;

		[Token(Token = "0x400177C")]
		private const int checkMaxCount = 5;

		[Token(Token = "0x400177D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		internal bool _removeCheckFaillimit;

		[Token(Token = "0x400177E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int checkFixCount;

		[Token(Token = "0x400177F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int checkFailedCount;

		[Token(Token = "0x4001780")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float weekTimesFixOrders;

		[Token(Token = "0x4001781")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float weekTimesFailedOrders;

		[Token(Token = "0x4001782")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private string currOrderId;

		[Token(Token = "0x4001783")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool IsUserServer;

		[Token(Token = "0x4001784")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool TestIsSucceed;

		[Token(Token = "0x4001785")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool IsStartCheckTimeOut;

		[Token(Token = "0x4001786")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float weekTime;

		[Token(Token = "0x6005098")]
		[Address(RVA = "0x710CD6C", Offset = "0x7108D6C", VA = "0x710CD6C", Slot = "4")]
		public virtual void InitIap(bool UseDefaultLoadingUI = true, bool UseDefaultBuyConfirmUI = true)
		{
		}

		[Token(Token = "0x6005099")]
		[Address(RVA = "0x71108F4", Offset = "0x710C8F4", VA = "0x71108F4")]
		private void MineGameExitLogic(object[] Args)
		{
		}

		[Token(Token = "0x600509A")]
		[Address(RVA = "0x71108F8", Offset = "0x710C8F8", VA = "0x71108F8")]
		private void CloseIap()
		{
		}

		[Token(Token = "0x600509B")]
		[Address(RVA = "0x711088C", Offset = "0x710C88C", VA = "0x711088C")]
		[IteratorStateMachine(typeof(_003CReadProductConfigs_003Ed__21))]
		private IEnumerator ReadProductConfigs(Action<byte[], bool> callBack)
		{
			return null;
		}

		[Token(Token = "0x600509C")]
		[Address(RVA = "0x7110978", Offset = "0x710C978", VA = "0x7110978")]
		private void WaitLoadProductConfigs(byte[] data, bool isUseXml = true)
		{
		}

		[Token(Token = "0x600509D")]
		[Address(RVA = "0x71114DC", Offset = "0x710D4DC", VA = "0x71114DC")]
		private void ReadProductConfigsByDB(byte[] text)
		{
		}

		[Token(Token = "0x600509E")]
		[Address(RVA = "0x7110B24", Offset = "0x710CB24", VA = "0x7110B24")]
		private void ReadProductConfigs(byte[] text)
		{
		}

		[Token(Token = "0x600509F")]
		[Address(RVA = "0x710D8C4", Offset = "0x71098C4", VA = "0x710D8C4")]
		internal void StartBuyProduct(string productID, string productType, string businessInfo, string ext = "", bool testIsSucceed = true, bool hasUnFinishOrder = false)
		{
		}

		[Token(Token = "0x60050A0")]
		[Address(RVA = "0x7111954", Offset = "0x710D954", VA = "0x7111954")]
		private void BugProduct(string productID, string productType, string ext, string businessInfo)
		{
		}

		[Token(Token = "0x60050A1")]
		[Address(RVA = "0x7111B88", Offset = "0x710DB88", VA = "0x7111B88")]
		[AsyncStateMachine(typeof(_003CAutoCloseBuyProduct_003Ed__28))]
		private void AutoCloseBuyProduct()
		{
		}

		[Token(Token = "0x60050A2")]
		[Address(RVA = "0x7111C0C", Offset = "0x710DC0C", VA = "0x7111C0C")]
		[AsyncStateMachine(typeof(_003CTestBuy_003Ed__29))]
		private void TestBuy(string productID)
		{
		}

		[Token(Token = "0x60050A3")]
		[Address(RVA = "0x7111CA4", Offset = "0x710DCA4", VA = "0x7111CA4", Slot = "5")]
		public virtual void StartNewOrder(string orderId)
		{
		}

		[Token(Token = "0x60050A4")]
		[Address(RVA = "0x7111B4C", Offset = "0x710DB4C", VA = "0x7111B4C")]
		private void ShowLoadingUI()
		{
		}

		[Token(Token = "0x60050A5")]
		[Address(RVA = "0x7111DE0", Offset = "0x710DDE0", VA = "0x7111DE0")]
		private void CloseLoadingUI()
		{
		}

		[Token(Token = "0x60050A6")]
		[Address(RVA = "0x7111CAC", Offset = "0x710DCAC", VA = "0x7111CAC")]
		private void StartLoadingTimeOut()
		{
		}

		[Token(Token = "0x60050A7")]
		[Address(RVA = "0x7111E20", Offset = "0x710DE20", VA = "0x7111E20")]
		private void StopLoadingTimeOut()
		{
		}

		[Token(Token = "0x60050A8")]
		[Address(RVA = "0x7111E2C", Offset = "0x710DE2C", VA = "0x7111E2C")]
		private void CheckLoadingTimeOut()
		{
		}

		[Token(Token = "0x60050A9")]
		[Address(RVA = "0x7111F54", Offset = "0x710DF54", VA = "0x7111F54")]
		internal void BuyException()
		{
		}

		[Token(Token = "0x60050AA")]
		[Address(RVA = "0x7111FA4", Offset = "0x710DFA4", VA = "0x7111FA4")]
		internal void BuySucceed(string orderId, string Json = "")
		{
		}

		[Token(Token = "0x60050AB")]
		[Address(RVA = "0x71129B8", Offset = "0x710E9B8", VA = "0x71129B8", Slot = "6")]
		protected virtual void SendOrderServer(params ServerOrderInfo[] orderInfo)
		{
		}

		[Token(Token = "0x60050AC")]
		[Address(RVA = "0x71129BC", Offset = "0x710E9BC", VA = "0x71129BC")]
		public void ReceiveServerBuyResult(string orderId, CommdityChannel commdityChannel, int result)
		{
		}

		[Token(Token = "0x60050AD")]
		[Address(RVA = "0x71128A0", Offset = "0x710E8A0", VA = "0x71128A0")]
		private void DeliveryCompleted(string orderId)
		{
		}

		[Token(Token = "0x60050AE")]
		[Address(RVA = "0x710DB94", Offset = "0x7109B94", VA = "0x710DB94", Slot = "7")]
		internal virtual bool SendProductBase(OrderInfo orderInfo)
		{
			return default;
		}

		[Token(Token = "0x60050AF")]
		[Address(RVA = "0x7112B2C", Offset = "0x710EB2C", VA = "0x7112B2C")]
		private void BuySuccessCallBackFormUser(string orderId)
		{
		}

		[Token(Token = "0x60050B0")]
		[Address(RVA = "0x7112B88", Offset = "0x710EB88", VA = "0x7112B88")]
		internal void BuyFailed(string orderId, string errorMsg, int errorCode)
		{
		}

		[Token(Token = "0x60050B1")]
		[Address(RVA = "0x7112C3C", Offset = "0x710EC3C", VA = "0x7112C3C", Slot = "8")]
		protected virtual void ProductBuyOver(bool IsSucceed, int errorCode = 0)
		{
		}

		[Token(Token = "0x60050B2")]
		[Address(RVA = "0x7112C40", Offset = "0x710EC40", VA = "0x7112C40")]
		private void ShowDefaultConfirmUI(Action<int> result)
		{
		}

		[Token(Token = "0x60050B3")]
		[Address(RVA = "0x7112D64", Offset = "0x710ED64", VA = "0x7112D64", Slot = "9")]
		internal virtual void Update()
		{
		}

		[Token(Token = "0x60050B4")]
		[Address(RVA = "0x7112F18", Offset = "0x710EF18", VA = "0x7112F18")]
		internal void ExceptionOrder(bool isFixOrders, List<OrderInfo> orderInfos)
		{
		}

		[Token(Token = "0x60050B5")]
		[Address(RVA = "0x710F000", Offset = "0x710B000", VA = "0x710F000", Slot = "10")]
		internal virtual void SendFixOrdersProductBase(List<OrderInfo> productList)
		{
		}

		[Token(Token = "0x60050B6")]
		[Address(RVA = "0x710F00C", Offset = "0x710B00C", VA = "0x710F00C", Slot = "11")]
		internal virtual void SendFailedOrdersProductBase(List<OrderInfo> productList)
		{
		}

		[Token(Token = "0x60050B7")]
		[Address(RVA = "0x710F2A4", Offset = "0x710B2A4", VA = "0x710F2A4")]
		internal void RestoreBuy()
		{
		}

		[Token(Token = "0x60050B8")]
		[Address(RVA = "0x7113EE8", Offset = "0x710FEE8", VA = "0x7113EE8")]
		[AsyncStateMachine(typeof(_003CTestRestore_003Ed__53))]
		private void TestRestore()
		{
		}

		[Token(Token = "0x60050B9")]
		[Address(RVA = "0x7113F78", Offset = "0x710FF78", VA = "0x7113F78")]
		internal void RestoreOrder(List<OrderInfo> orderInfos)
		{
		}

		[Token(Token = "0x60050BA")]
		[Address(RVA = "0x710F38C", Offset = "0x710B38C", VA = "0x710F38C", Slot = "12")]
		internal virtual void SendRestoreOrdersProductBase(List<OrderInfo> productList)
		{
		}

		[Token(Token = "0x60050BB")]
		[Address(RVA = "0x710E6F0", Offset = "0x710A6F0", VA = "0x710E6F0")]
		internal void CheckSubscription(string GameKey)
		{
		}

		[Token(Token = "0x60050BC")]
		[Address(RVA = "0x710D854", Offset = "0x7109854", VA = "0x710D854")]
		internal ProductData FindProduct(string GameKey)
		{
			return null;
		}

		[Token(Token = "0x60050BD")]
		[Address(RVA = "0x710E438", Offset = "0x710A438", VA = "0x710E438")]
		internal ProductData FindProductByPId(string ProductId)
		{
			return null;
		}

		[Token(Token = "0x60050BE")]
		[Address(RVA = "0x71145BC", Offset = "0x71105BC", VA = "0x71145BC")]
		internal void getSubscriptionResultCallBack(string pProductID, string iStatue, string expiresDate)
		{
		}

		[Token(Token = "0x60050BF")]
		[Address(RVA = "0x710EFF4", Offset = "0x710AFF4", VA = "0x710EFF4", Slot = "13")]
		internal virtual void SubscriptionResultBase(string productId, int state, string dateTime)
		{
		}

		[Token(Token = "0x60050C0")]
		[Address(RVA = "0x7114744", Offset = "0x7110744", VA = "0x7114744")]
		public void ManageAllSubscription()
		{
		}

		[Token(Token = "0x60050C1")]
		[Address(RVA = "0x7114798", Offset = "0x7110798", VA = "0x7114798")]
		public void ManageSubscription(string GameKey)
		{
		}

		[Token(Token = "0x60050C2")]
		[Address(RVA = "0x71149EC", Offset = "0x71109EC", VA = "0x71149EC")]
		public void ReportPayShow(params string[] GameKeys)
		{
		}

		[Token(Token = "0x60050C3")]
		[Address(RVA = "0x7113E2C", Offset = "0x710FE2C", VA = "0x7113E2C")]
		public void ReportResumeRequest()
		{
		}

		[Token(Token = "0x60050C4")]
		[Address(RVA = "0x7114404", Offset = "0x7110404", VA = "0x7114404")]
		public void ReportResumeSuccess(List<OrderInfo> products)
		{
		}

		[Token(Token = "0x60050C5")]
		[Address(RVA = "0x7114EF0", Offset = "0x7110EF0", VA = "0x7114EF0")]
		public void LoadProductInfo(params string[] GameKey)
		{
		}

		[Token(Token = "0x60050C6")]
		[Address(RVA = "0x7115298", Offset = "0x7111298", VA = "0x7115298")]
		public (string, string, string, string, string) GetProductInfo(string GameKey)
		{
			return default;
		}

		[Token(Token = "0x60050C7")]
		[Address(RVA = "0x7115840", Offset = "0x7111840", VA = "0x7115840")]
		internal void getRefundProduct(List<RefundProduct> datas)
		{
		}

		[Token(Token = "0x60050C8")]
		[Address(RVA = "0x7115B88", Offset = "0x7111B88", VA = "0x7115B88")]
		internal void getGivenGiftProduct(List<RefundProduct> datas)
		{
		}

		[Token(Token = "0x60050C9")]
		protected abstract void ShowUnFinishOrderTips(UnityAction<int> result);

		[Token(Token = "0x60050CA")]
		protected abstract void ShowWaitLodingUI();

		[Token(Token = "0x60050CB")]
		protected abstract void CloseWaitLodingUI();

		[Token(Token = "0x60050CC")]
		[Address(RVA = "0x710F4D0", Offset = "0x710B4D0", VA = "0x710F4D0", Slot = "17")]
		protected virtual void InitOver()
		{
		}

		[Token(Token = "0x60050CD")]
		[Address(RVA = "0x710F394", Offset = "0x710B394", VA = "0x710F394", Slot = "18")]
		protected virtual void ReceiveRefundProduct(string gameKey, int count)
		{
		}

		[Token(Token = "0x60050CE")]
		[Address(RVA = "0x7115E4C", Offset = "0x7111E4C", VA = "0x7115E4C", Slot = "19")]
		protected virtual void ReceiveGivenGiftProduct(string Id, string count)
		{
		}

		[Token(Token = "0x60050CF")]
		[Address(RVA = "0x710F85C", Offset = "0x710B85C", VA = "0x710F85C")]
		protected IIap()
		{
		}
	}
}
