using System;
using Il2CppDummyDll;

namespace DBTSDK
{
	[Token(Token = "0x2000210")]
	public abstract class WXSdkHandler
	{
		[Token(Token = "0x6001B32")]
		public abstract void Update();

		[Token(Token = "0x6001B33")]
		public abstract void CreateBanner(params WXCreateBannerAdParam[] AdParam);

		[Token(Token = "0x6001B34")]
		public abstract void CreateInterstitial(params WXCreateInterstitialAdParam[] AdParam);

		[Token(Token = "0x6001B35")]
		public abstract void CreateVideo(params WXCreateRewardedVideoAdParam[] AdParam);

		[Token(Token = "0x6001B36")]
		public abstract void ShowBanner();

		[Token(Token = "0x6001B37")]
		public abstract void HideBanner();

		[Token(Token = "0x6001B38")]
		public abstract void ShowInterstitial();

		[Token(Token = "0x6001B39")]
		public abstract void ShowVideo(Action<string, bool> CallBack);

		[Token(Token = "0x6001B3A")]
		public abstract bool AdsIsReady();

		[Token(Token = "0x6001B3B")]
		public abstract void ReportEventNow(string eventStr, string labelStr);

		[Token(Token = "0x6001B3C")]
		public abstract void ReportEventCount(string eventStr, string labelStr, WxReportType type);

		[Token(Token = "0x6001B3D")]
		public abstract void OnNewEvent(string eventId, string jsonProperties);

		[Token(Token = "0x6001B3E")]
		public abstract void ShareAppMessage(string title, string imgURL);

		[Token(Token = "0x6001B3F")]
		public abstract string GetOnlineConfigParams(string paramKey);

		[Token(Token = "0x6001B40")]
		public abstract void ShowToast(string msg);

		[Token(Token = "0x6001B41")]
		public abstract WXAccountInfo GetAccountInfoSync();

		[Token(Token = "0x6001B42")]
		[Address(RVA = "0x70D86E8", Offset = "0x70D46E8", VA = "0x70D86E8", Slot = "20")]
		public virtual void Login(int inOrOut, Action<int, string> LoginCallBack)
		{
		}

		[Token(Token = "0x6001B43")]
		[Address(RVA = "0x70D86EC", Offset = "0x70D46EC", VA = "0x70D86EC")]
		protected WXSdkHandler()
		{
		}
	}
}
