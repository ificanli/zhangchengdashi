using Il2CppDummyDll;

namespace DBTSDK
{
	[Token(Token = "0x2000206")]
	public class IapAndroid
	{
		[Token(Token = "0x6001A8C")]
		[Address(RVA = "0x70C9A88", Offset = "0x70C5A88", VA = "0x70C9A88")]
		public static bool HasUnFinishOrderStatic(string productID)
		{
			return default;
		}

		[Token(Token = "0x6001A8D")]
		[Address(RVA = "0x70C9C40", Offset = "0x70C5C40", VA = "0x70C9C40")]
		public static void NewOrderInfoByGameStatic(string productID, string ext)
		{
		}

		[Token(Token = "0x6001A8E")]
		[Address(RVA = "0x70C9E60", Offset = "0x70C5E60", VA = "0x70C9E60")]
		public static void BuySuccessCallBackFormUserStatic(string orderId)
		{
		}

		[Token(Token = "0x6001A8F")]
		[Address(RVA = "0x70C9FE0", Offset = "0x70C5FE0", VA = "0x70C9FE0")]
		public static void GetFailedOrdersByPlatStatic()
		{
		}

		[Token(Token = "0x6001A90")]
		[Address(RVA = "0x70CA0A0", Offset = "0x70C60A0", VA = "0x70CA0A0")]
		public static void GetFixOrdersByPlatStatic()
		{
		}

		[Token(Token = "0x6001A91")]
		[Address(RVA = "0x70CA160", Offset = "0x70C6160", VA = "0x70CA160")]
		public static void FixOrderResultByPlatStatic(string orderId, string orderStats, string msg)
		{
		}

		[Token(Token = "0x6001A92")]
		[Address(RVA = "0x70CA3DC", Offset = "0x70C63DC", VA = "0x70CA3DC")]
		public static bool IsNeedResotreStatic()
		{
			return default;
		}

		[Token(Token = "0x6001A93")]
		[Address(RVA = "0x70CA5B0", Offset = "0x70C65B0", VA = "0x70CA5B0")]
		public static void StartRestoreStatic()
		{
		}

		[Token(Token = "0x6001A94")]
		[Address(RVA = "0x70CA714", Offset = "0x70C6714", VA = "0x70CA714")]
		public static int GetZhifuCheckIntervalStatic()
		{
			return default;
		}

		[Token(Token = "0x6001A95")]
		[Address(RVA = "0x70CA8DC", Offset = "0x70C68DC", VA = "0x70CA8DC")]
		public static void GetSubscriptionResultStatic(string pProductID, string pProductKey)
		{
		}

		[Token(Token = "0x6001A96")]
		[Address(RVA = "0x70CAAFC", Offset = "0x70C6AFC", VA = "0x70CAAFC")]
		public static int GetMarketTypeStatic()
		{
			return default;
		}

		[Token(Token = "0x6001A97")]
		[Address(RVA = "0x70CACC4", Offset = "0x70C6CC4", VA = "0x70CACC4")]
		public static void LoadProductInfoStatic(string skus)
		{
		}

		[Token(Token = "0x6001A98")]
		[Address(RVA = "0x70CAE44", Offset = "0x70C6E44", VA = "0x70CAE44")]
		public static string GetProductInfoStatic(string skus)
		{
			return null;
		}

		[Token(Token = "0x6001A99")]
		[Address(RVA = "0x70CB054", Offset = "0x70C7054", VA = "0x70CB054")]
		public static void ManageAllSubscriptionStatic()
		{
		}

		[Token(Token = "0x6001A9A")]
		[Address(RVA = "0x70CB1B8", Offset = "0x70C71B8", VA = "0x70CB1B8")]
		public static void ManageSubscriptionStatic(string sku)
		{
		}

		[Token(Token = "0x6001A9B")]
		[Address(RVA = "0x70CB338", Offset = "0x70C7338", VA = "0x70CB338")]
		public static void GetRefundProductStatic()
		{
		}

		[Token(Token = "0x6001A9C")]
		[Address(RVA = "0x70CB49C", Offset = "0x70C749C", VA = "0x70CB49C")]
		public static void RefundProductFinishStatic(string orderNo)
		{
		}

		[Token(Token = "0x6001A9D")]
		[Address(RVA = "0x70CB61C", Offset = "0x70C761C", VA = "0x70CB61C")]
		public static void GetQryGivenGiftStatic()
		{
		}

		[Token(Token = "0x6001A9E")]
		[Address(RVA = "0x70CB780", Offset = "0x70C7780", VA = "0x70CB780")]
		public static void UpSendGivenGiftResultStatic(string orderNo)
		{
		}

		[Token(Token = "0x6001A9F")]
		[Address(RVA = "0x70CB900", Offset = "0x70C7900", VA = "0x70CB900")]
		public static void ShowPayFailToastStatic(bool isShow)
		{
		}

		[Token(Token = "0x6001AA0")]
		[Address(RVA = "0x70CBAA4", Offset = "0x70C7AA4", VA = "0x70CBAA4")]
		public static void NewOrderInfoByStrongNetGameStatic(string pProductID, string businessInfo)
		{
		}

		[Token(Token = "0x6001AA1")]
		[Address(RVA = "0x70CBCC4", Offset = "0x70C7CC4", VA = "0x70CBCC4")]
		public static void SetBizInfoForStrongNetGameStatic(string businessInfo)
		{
		}

		[Token(Token = "0x6001AA2")]
		[Address(RVA = "0x70CBE44", Offset = "0x70C7E44", VA = "0x70CBE44")]
		public static void GetExternalPurchaseResultStatic()
		{
		}

		[Token(Token = "0x6001AA3")]
		[Address(RVA = "0x70CBFA8", Offset = "0x70C7FA8", VA = "0x70CBFA8")]
		public IapAndroid()
		{
		}
	}
}
