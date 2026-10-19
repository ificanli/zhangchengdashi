using Il2CppDummyDll;

namespace DBTSDK
{
	[Token(Token = "0x2000203")]
	public class AdsAndroid
	{
		[Token(Token = "0x6001A01")]
		[Address(RVA = "0x70BAAF4", Offset = "0x70B6AF4", VA = "0x70BAAF4")]
		public static void ShowBannerStatic(int pos)
		{
		}

		[Token(Token = "0x6001A02")]
		[Address(RVA = "0x70BAC94", Offset = "0x70B6C94", VA = "0x70BAC94")]
		public static void ShowBannerStatic(int pos, bool filterHighMemorySDK)
		{
		}

		[Token(Token = "0x6001A03")]
		[Address(RVA = "0x70BAEB4", Offset = "0x70B6EB4", VA = "0x70BAEB4")]
		public static void HideBannerStatic()
		{
		}

		[Token(Token = "0x6001A04")]
		[Address(RVA = "0x70BB014", Offset = "0x70B7014", VA = "0x70BB014")]
		public static void ShowInterstitialStatic(string game)
		{
		}

		[Token(Token = "0x6001A05")]
		[Address(RVA = "0x70BB190", Offset = "0x70B7190", VA = "0x70BB190")]
		public static bool IsShowVideoStatic()
		{
			return default;
		}

		[Token(Token = "0x6001A06")]
		[Address(RVA = "0x70BB360", Offset = "0x70B7360", VA = "0x70BB360")]
		public static bool IsVideoReadyStatic()
		{
			return default;
		}

		[Token(Token = "0x6001A07")]
		[Address(RVA = "0x70BB530", Offset = "0x70B7530", VA = "0x70BB530")]
		public static void ShowVideoStatic(int flag)
		{
		}

		[Token(Token = "0x6001A08")]
		[Address(RVA = "0x70BB6D0", Offset = "0x70B76D0", VA = "0x70BB6D0")]
		public static int GetAdsStatusStatic(int scene, int id)
		{
			return default;
		}

		[Token(Token = "0x6001A09")]
		[Address(RVA = "0x70BB908", Offset = "0x70B7908", VA = "0x70BB908")]
		public static int ShowAdsStatic(int scene, int id, int[] rootRect, int[] pictureRect, int[] footerRect, int[] titleColor, int[] actionBackgroundColor, int[] actionColor)
		{
			return default;
		}

		[Token(Token = "0x6001A0A")]
		[Address(RVA = "0x70BBDF4", Offset = "0x70B7DF4", VA = "0x70BBDF4")]
		public static void RemoveAdsWidgetStatic(int index)
		{
		}

		[Token(Token = "0x6001A0B")]
		[Address(RVA = "0x70BBF94", Offset = "0x70B7F94", VA = "0x70BBF94")]
		public static void SetAdsVisibleStatic(int index, bool visible)
		{
		}

		[Token(Token = "0x6001A0C")]
		[Address(RVA = "0x70BC1B4", Offset = "0x70B81B4", VA = "0x70BC1B4")]
		public static void SetRemoveAdsStatic()
		{
		}

		[Token(Token = "0x6001A0D")]
		[Address(RVA = "0x70BC314", Offset = "0x70B8314", VA = "0x70BC314")]
		public static int GetRemoveAdsState()
		{
			return default;
		}

		[Token(Token = "0x6001A0E")]
		[Address(RVA = "0x70BC4D8", Offset = "0x70B84D8", VA = "0x70BC4D8")]
		public static bool IsOpenRemoveAds()
		{
			return default;
		}

		[Token(Token = "0x6001A0F")]
		[Address(RVA = "0x70BC6A8", Offset = "0x70B86A8", VA = "0x70BC6A8")]
		public static void SetRestoreAdsStatic()
		{
		}

		[Token(Token = "0x6001A10")]
		[Address(RVA = "0x70BC808", Offset = "0x70B8808", VA = "0x70BC808")]
		public static int GetVideoStatus()
		{
			return default;
		}

		[Token(Token = "0x6001A11")]
		[Address(RVA = "0x70BC9CC", Offset = "0x70B89CC", VA = "0x70BC9CC")]
		public static float GetBannerSizeScale(int pos)
		{
			return default;
		}

		[Token(Token = "0x6001A12")]
		[Address(RVA = "0x70BCBC4", Offset = "0x70B8BC4", VA = "0x70BCBC4")]
		public static bool DelayShowBigAdsStatic()
		{
			return default;
		}

		[Token(Token = "0x6001A13")]
		[Address(RVA = "0x70BCD94", Offset = "0x70B8D94", VA = "0x70BCD94")]
		public static void RequestGameOverBigAdsStatic()
		{
		}

		[Token(Token = "0x6001A14")]
		[Address(RVA = "0x70BCEF4", Offset = "0x70B8EF4", VA = "0x70BCEF4")]
		public static int GetDrawVideoButtonStatusStatic()
		{
			return default;
		}

		[Token(Token = "0x6001A15")]
		[Address(RVA = "0x70BD0B8", Offset = "0x70B90B8", VA = "0x70BD0B8")]
		public static void ShowDrawVideoStatic()
		{
		}

		[Token(Token = "0x6001A16")]
		[Address(RVA = "0x70BD218", Offset = "0x70B9218", VA = "0x70BD218")]
		public static bool ShowInterstitialResult(string game, string interName, string mtype)
		{
			return default;
		}

		[Token(Token = "0x6001A17")]
		[Address(RVA = "0x70BD4DC", Offset = "0x70B94DC", VA = "0x70BD4DC")]
		public static bool IsInterstitialReadyStatic(string game, string mtype)
		{
			return default;
		}

		[Token(Token = "0x6001A18")]
		[Address(RVA = "0x70BD6C8", Offset = "0x70B96C8", VA = "0x70BD6C8")]
		public static void RequestVideoStatic(int flag)
		{
		}

		[Token(Token = "0x6001A19")]
		[Address(RVA = "0x70BD868", Offset = "0x70B9868", VA = "0x70BD868")]
		public static bool IsCustomVideoReadyStatic(int flag)
		{
			return default;
		}

		[Token(Token = "0x6001A1A")]
		[Address(RVA = "0x70BDA60", Offset = "0x70B9A60", VA = "0x70BDA60")]
		public static void SetRemoveVideoAdsStatic()
		{
		}

		[Token(Token = "0x6001A1B")]
		[Address(RVA = "0x70BDBC0", Offset = "0x70B9BC0", VA = "0x70BDBC0")]
		public static int GetRemoveVideoAdsState()
		{
			return default;
		}

		[Token(Token = "0x6001A1C")]
		[Address(RVA = "0x70BDD84", Offset = "0x70B9D84", VA = "0x70BDD84")]
		public static void SetRestoreVideoAdsStatic()
		{
		}

		[Token(Token = "0x6001A1D")]
		[Address(RVA = "0x70BDEE4", Offset = "0x70B9EE4", VA = "0x70BDEE4")]
		public static void AdsGameAdStatusCallBack(string upType, string pid, string revenue)
		{
		}

		[Token(Token = "0x6001A1E")]
		[Address(RVA = "0x70BE15C", Offset = "0x70BA15C", VA = "0x70BE15C")]
		public static void ShowNatGameAd(float topX, float topY, float maxWith, float maxHeight)
		{
		}

		[Token(Token = "0x6001A1F")]
		[Address(RVA = "0x70BE4BC", Offset = "0x70BA4BC", VA = "0x70BE4BC")]
		public static void HideNatGameAd()
		{
		}

		[Token(Token = "0x6001A20")]
		[Address(RVA = "0x70BE61C", Offset = "0x70BA61C", VA = "0x70BE61C")]
		public static string GetRewardAd()
		{
			return null;
		}

		[Token(Token = "0x6001A21")]
		[Address(RVA = "0x70BE7D4", Offset = "0x70BA7D4", VA = "0x70BE7D4")]
		public AdsAndroid()
		{
		}
	}
}
