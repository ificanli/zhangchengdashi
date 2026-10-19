using System;
using System.Collections.Generic;
using DBTSDK.Iap;
using Il2CppDummyDll;
using UnityEngine;

namespace DBTSDK
{
	[Token(Token = "0x20001E0")]
	public class IapManager : MonoBehaviour
	{
		[Token(Token = "0x400067C")]
		[FieldOffset(Offset = "0x0")]
		public static IapManager Instance;

		[Token(Token = "0x400067D")]
		[FieldOffset(Offset = "0x20")]
		internal IIap IapProcedure;

		[Token(Token = "0x400067E")]
		[FieldOffset(Offset = "0x28")]
		public IapNewProcedureBase IapImp;

		[Token(Token = "0x400067F")]
		[FieldOffset(Offset = "0x30")]
		private bool m_activeIapProduct;

		[Token(Token = "0x170000FF")]
		public bool ActiveIapProduct
		{
			[Token(Token = "0x60018C5")]
			[Address(RVA = "0x70A2EC0", Offset = "0x709EEC0", VA = "0x70A2EC0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60018C6")]
		[Address(RVA = "0x70A2EC8", Offset = "0x709EEC8", VA = "0x70A2EC8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60018C7")]
		[Address(RVA = "0x70A2F14", Offset = "0x709EF14", VA = "0x70A2F14")]
		private void Start()
		{
		}

		[Token(Token = "0x60018C8")]
		[Address(RVA = "0x70A2FBC", Offset = "0x709EFBC", VA = "0x70A2FBC")]
		public int GetMarketType_Override()
		{
			return default;
		}

		[Token(Token = "0x60018C9")]
		[Address(RVA = "0x70A30E8", Offset = "0x709F0E8", VA = "0x70A30E8")]
		[Obsolete("请使用IapNewProcedureBase.LoadProductInfo替换")]
		public void LoadProductInfo_Override(params string[] GameKey)
		{
		}

		[Token(Token = "0x60018CA")]
		[Address(RVA = "0x70A3260", Offset = "0x709F260", VA = "0x70A3260")]
		[Obsolete("请使用IapNewProcedureBase.GetProductInfo")]
		public (string, string, string, string, string) GetProductInfo_Override(string GameKey)
		{
			return default;
		}

		[Token(Token = "0x60018CB")]
		[Address(RVA = "0x70A33E0", Offset = "0x709F3E0", VA = "0x70A33E0")]
		public bool IsSupportPayStatic()
		{
			return default;
		}

		[Token(Token = "0x60018CC")]
		[Address(RVA = "0x70A37A8", Offset = "0x709F7A8", VA = "0x70A37A8")]
		internal void startNewOrderCallback(string data)
		{
		}

		[Token(Token = "0x60018CD")]
		[Address(RVA = "0x70A3BC4", Offset = "0x709FBC4", VA = "0x70A3BC4")]
		internal void platSucceedCallback(string data)
		{
		}

		[Token(Token = "0x60018CE")]
		[Address(RVA = "0x70A3F00", Offset = "0x709FF00", VA = "0x70A3F00")]
		internal void onExternalPurchaseSuccessCallBack(string data)
		{
		}

		[Token(Token = "0x60018CF")]
		[Address(RVA = "0x70A423C", Offset = "0x70A023C", VA = "0x70A423C")]
		internal void payFailedCallback(string data)
		{
		}

		[Token(Token = "0x60018D0")]
		[Address(RVA = "0x70A4644", Offset = "0x70A0644", VA = "0x70A4644")]
		internal void getFailedOrdersByPlatCallback(string data)
		{
		}

		[Token(Token = "0x60018D1")]
		[Address(RVA = "0x70A4E34", Offset = "0x70A0E34", VA = "0x70A4E34")]
		internal void getFixOrdersByPlatCallback(string data)
		{
		}

		[Token(Token = "0x60018D2")]
		[Address(RVA = "0x70A4FE0", Offset = "0x70A0FE0", VA = "0x70A4FE0")]
		internal void startRestoreStaticCallback(string data)
		{
		}

		[Token(Token = "0x60018D3")]
		[Address(RVA = "0x70A47E8", Offset = "0x70A07E8", VA = "0x70A47E8")]
		private List<OrderInfo> DataParesOrders(string data)
		{
			return null;
		}

		[Token(Token = "0x60018D4")]
		[Address(RVA = "0x70A5434", Offset = "0x70A1434", VA = "0x70A5434")]
		internal void getRefundProductCallback(string data)
		{
		}

		[Token(Token = "0x60018D5")]
		[Address(RVA = "0x70A5690", Offset = "0x70A1690", VA = "0x70A5690")]
		internal void getQryGivenGiftCallback(string data)
		{
		}

		[Token(Token = "0x60018D6")]
		[Address(RVA = "0x70A58EC", Offset = "0x70A18EC", VA = "0x70A58EC")]
		internal void getSubscriptionResultCallBack(string data)
		{
		}

		[Token(Token = "0x60018D7")]
		[Address(RVA = "0x70A5BC0", Offset = "0x70A1BC0", VA = "0x70A5BC0")]
		private void Update()
		{
		}

		[Token(Token = "0x60018D8")]
		[Address(RVA = "0x70A5BD8", Offset = "0x70A1BD8", VA = "0x70A5BD8")]
		public void CloseIapProcedure()
		{
		}

		[Token(Token = "0x60018D9")]
		[Address(RVA = "0x70A5BE0", Offset = "0x70A1BE0", VA = "0x70A5BE0")]
		internal bool HasUnFinishOrderStatic(string productID)
		{
			return default;
		}

		[Token(Token = "0x60018DA")]
		[Address(RVA = "0x70A5E08", Offset = "0x70A1E08", VA = "0x70A5E08")]
		internal void NewOrderInfoByGameStatic(string productID, string ext)
		{
		}

		[Token(Token = "0x60018DB")]
		[Address(RVA = "0x70A6080", Offset = "0x70A2080", VA = "0x70A6080")]
		internal void BuySuccessCallBackFormUserStatic(string orderId)
		{
		}

		[Token(Token = "0x60018DC")]
		[Address(RVA = "0x70A6270", Offset = "0x70A2270", VA = "0x70A6270")]
		internal void GetFailedOrdersByPlatStatic()
		{
		}

		[Token(Token = "0x60018DD")]
		[Address(RVA = "0x70A6394", Offset = "0x70A2394", VA = "0x70A6394")]
		internal void GetFixOrdersByPlatStatic()
		{
		}

		[Token(Token = "0x60018DE")]
		[Address(RVA = "0x70A64B8", Offset = "0x70A24B8", VA = "0x70A64B8")]
		internal void FixOrderResultByPlatStatic(string orderId, string orderStats, string msg)
		{
		}

		[Token(Token = "0x60018DF")]
		[Address(RVA = "0x70A676C", Offset = "0x70A276C", VA = "0x70A676C")]
		public bool IsNeedResotreStatic()
		{
			return default;
		}

		[Token(Token = "0x60018E0")]
		[Address(RVA = "0x70A697C", Offset = "0x70A297C", VA = "0x70A697C")]
		internal void StartRestoreStatic()
		{
		}

		[Token(Token = "0x60018E1")]
		[Address(RVA = "0x70A6B34", Offset = "0x70A2B34", VA = "0x70A6B34")]
		public int GetZhifuCheckIntervalStatic()
		{
			return default;
		}

		[Token(Token = "0x60018E2")]
		[Address(RVA = "0x70A6D40", Offset = "0x70A2D40", VA = "0x70A6D40")]
		internal void GetSubscriptionResultStatic(string pProductID, string pProductKey)
		{
		}

		[Token(Token = "0x60018E3")]
		[Address(RVA = "0x70A2FC0", Offset = "0x709EFC0", VA = "0x70A2FC0")]
		internal int GetMarketTypeStatic()
		{
			return default;
		}

		[Token(Token = "0x60018E4")]
		[Address(RVA = "0x70A6FB8", Offset = "0x70A2FB8", VA = "0x70A6FB8")]
		internal void LoadProductInfoStatic(string skus)
		{
		}

		[Token(Token = "0x60018E5")]
		[Address(RVA = "0x70A70E8", Offset = "0x70A30E8", VA = "0x70A70E8")]
		internal string GetProductInfoStatic(string skus)
		{
			return null;
		}

		[Token(Token = "0x60018E6")]
		[Address(RVA = "0x70A721C", Offset = "0x70A321C", VA = "0x70A721C")]
		internal void ManageAllSubscriptionStatic()
		{
		}

		[Token(Token = "0x60018E7")]
		[Address(RVA = "0x70A7340", Offset = "0x70A3340", VA = "0x70A7340")]
		internal void ManageSubscriptionStatic(string sku)
		{
		}

		[Token(Token = "0x60018E8")]
		[Address(RVA = "0x70A7470", Offset = "0x70A3470", VA = "0x70A7470")]
		internal void GetRefundProductStatic()
		{
		}

		[Token(Token = "0x60018E9")]
		[Address(RVA = "0x70A7594", Offset = "0x70A3594", VA = "0x70A7594")]
		internal void RefundProductFinishStatic(string orderNo)
		{
		}

		[Token(Token = "0x60018EA")]
		[Address(RVA = "0x70A76C4", Offset = "0x70A36C4", VA = "0x70A76C4")]
		internal void GetQryGivenGiftStatic()
		{
		}

		[Token(Token = "0x60018EB")]
		[Address(RVA = "0x70A77E8", Offset = "0x70A37E8", VA = "0x70A77E8")]
		internal void UpSendGivenGiftResultStatic(string orderNo)
		{
		}

		[Token(Token = "0x60018EC")]
		[Address(RVA = "0x70A7918", Offset = "0x70A3918", VA = "0x70A7918")]
		public void ShowPayFailToastStatic(bool isShow)
		{
		}

		[Token(Token = "0x60018ED")]
		[Address(RVA = "0x70A7A48", Offset = "0x70A3A48", VA = "0x70A7A48")]
		internal void NewOrderInfoByStrongNetGameStatic(string pProductID, string businessInfo)
		{
		}

		[Token(Token = "0x60018EE")]
		[Address(RVA = "0x70A7B94", Offset = "0x70A3B94", VA = "0x70A7B94")]
		public void SetBizInfoForStrongNetGameStatic(string businessInfo)
		{
		}

		[Token(Token = "0x60018EF")]
		[Address(RVA = "0x70A7CC4", Offset = "0x70A3CC4", VA = "0x70A7CC4")]
		public void GetExternalPurchaseResultStatic()
		{
		}

		[Token(Token = "0x60018F0")]
		[Address(RVA = "0x70A7DE8", Offset = "0x70A3DE8", VA = "0x70A7DE8")]
		public void ShowPromoCodesStatic()
		{
		}

		[Token(Token = "0x60018F1")]
		[Address(RVA = "0x70A7EFC", Offset = "0x70A3EFC", VA = "0x70A7EFC")]
		public IapManager()
		{
		}
	}
}
