using System;
using Il2CppDummyDll;

namespace DBTSDK
{
	[Token(Token = "0x200020F")]
	public class WXSdkManager
	{
		[Token(Token = "0x400074F")]
		[FieldOffset(Offset = "0x10")]
		private WXSdkHandler adsHandler;

		[Token(Token = "0x6001B1E")]
		[Address(RVA = "0x70D7F74", Offset = "0x70D3F74", VA = "0x70D7F74")]
		public void Init(WXSdkHandler handler)
		{
		}

		[Token(Token = "0x6001B1F")]
		[Address(RVA = "0x70D7F7C", Offset = "0x70D3F7C", VA = "0x70D7F7C")]
		public void CreateBanner(params WXCreateBannerAdParam[] AdParam)
		{
		}

		[Token(Token = "0x6001B20")]
		[Address(RVA = "0x70D7F94", Offset = "0x70D3F94", VA = "0x70D7F94")]
		public void CreateInterstitial(params WXCreateInterstitialAdParam[] AdParam)
		{
		}

		[Token(Token = "0x6001B21")]
		[Address(RVA = "0x70D7FAC", Offset = "0x70D3FAC", VA = "0x70D7FAC")]
		public void CreateVideo(params WXCreateRewardedVideoAdParam[] AdParam)
		{
		}

		[Token(Token = "0x6001B22")]
		[Address(RVA = "0x70D7FC4", Offset = "0x70D3FC4", VA = "0x70D7FC4")]
		internal void ShowBanner()
		{
		}

		[Token(Token = "0x6001B23")]
		[Address(RVA = "0x70D7FDC", Offset = "0x70D3FDC", VA = "0x70D7FDC")]
		internal void HideBanner()
		{
		}

		[Token(Token = "0x6001B24")]
		[Address(RVA = "0x70D7FF4", Offset = "0x70D3FF4", VA = "0x70D7FF4")]
		internal void ShowInterstitial()
		{
		}

		[Token(Token = "0x6001B25")]
		[Address(RVA = "0x70D800C", Offset = "0x70D400C", VA = "0x70D800C")]
		internal void ShowVideo(Action<string, bool> CallBack)
		{
		}

		[Token(Token = "0x6001B26")]
		[Address(RVA = "0x70D8024", Offset = "0x70D4024", VA = "0x70D8024")]
		internal bool AdsIsReady()
		{
			return default;
		}

		[Token(Token = "0x6001B27")]
		[Address(RVA = "0x70D80B4", Offset = "0x70D40B4", VA = "0x70D80B4")]
		internal void Update()
		{
		}

		[Token(Token = "0x6001B28")]
		[Address(RVA = "0x70D80CC", Offset = "0x70D40CC", VA = "0x70D80CC")]
		internal void ReportEventNow(string eventStr, string labelStr)
		{
		}

		[Token(Token = "0x6001B29")]
		[Address(RVA = "0x70D80E8", Offset = "0x70D40E8", VA = "0x70D80E8")]
		internal void ReportEventCount(string eventStr, string labelStr, WxReportType type)
		{
		}

		[Token(Token = "0x6001B2A")]
		[Address(RVA = "0x70D8104", Offset = "0x70D4104", VA = "0x70D8104")]
		internal void OnNewEvent(string eventId, string jsonProperties)
		{
		}

		[Token(Token = "0x6001B2B")]
		[Address(RVA = "0x70D8120", Offset = "0x70D4120", VA = "0x70D8120")]
		internal void OnNewEventOnlyOnce(string eventId, string jsonProperties)
		{
		}

		[Token(Token = "0x6001B2C")]
		[Address(RVA = "0x70D8654", Offset = "0x70D4654", VA = "0x70D8654")]
		internal void ShareAppMessage(string title, string imgURL)
		{
		}

		[Token(Token = "0x6001B2D")]
		[Address(RVA = "0x70D8670", Offset = "0x70D4670", VA = "0x70D8670")]
		internal string GetOnlineConfigParams(string paramKey)
		{
			return null;
		}

		[Token(Token = "0x6001B2E")]
		[Address(RVA = "0x70D868C", Offset = "0x70D468C", VA = "0x70D868C")]
		internal void ShowToast(string msg)
		{
		}

		[Token(Token = "0x6001B2F")]
		[Address(RVA = "0x70D86A8", Offset = "0x70D46A8", VA = "0x70D86A8")]
		internal WXAccountInfo GetAccountInfoSync()
		{
			return null;
		}

		[Token(Token = "0x6001B30")]
		[Address(RVA = "0x70D86C4", Offset = "0x70D46C4", VA = "0x70D86C4")]
		internal void Login(int inOrOut, Action<int, string> LoginCallBack)
		{
		}

		[Token(Token = "0x6001B31")]
		[Address(RVA = "0x70D86E0", Offset = "0x70D46E0", VA = "0x70D86E0")]
		public WXSdkManager()
		{
		}
	}
}
