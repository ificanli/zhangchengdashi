using Il2CppDummyDll;

namespace DBTSDK
{
	[Token(Token = "0x2000205")]
	public class AppUserAndroid
	{
		[Token(Token = "0x6001A54")]
		[Address(RVA = "0x70C3C4C", Offset = "0x70BFC4C", VA = "0x70C3C4C")]
		public static bool IsShowShare()
		{
			return default;
		}

		[Token(Token = "0x6001A55")]
		[Address(RVA = "0x70C3E1C", Offset = "0x70BFE1C", VA = "0x70C3E1C")]
		public static int GetShareMode()
		{
			return default;
		}

		[Token(Token = "0x6001A56")]
		[Address(RVA = "0x70C3FE0", Offset = "0x70BFFE0", VA = "0x70C3FE0")]
		public static void ShareImage(string title, string content, string url, string imgFile)
		{
		}

		[Token(Token = "0x6001A57")]
		[Address(RVA = "0x70C42BC", Offset = "0x70C02BC", VA = "0x70C42BC")]
		public static void ShareText(string title, string content, string url)
		{
		}

		[Token(Token = "0x6001A58")]
		[Address(RVA = "0x70C4534", Offset = "0x70C0534", VA = "0x70C4534")]
		public static string GetShareUrl()
		{
			return null;
		}

		[Token(Token = "0x6001A59")]
		[Address(RVA = "0x70C46EC", Offset = "0x70C06EC", VA = "0x70C46EC")]
		public static void ShareApp(int Sharetype, string title, string content, string imgFile, string[] Args, int count)
		{
		}

		[Token(Token = "0x6001A5A")]
		[Address(RVA = "0x70C4AAC", Offset = "0x70C0AAC", VA = "0x70C4AAC")]
		public static bool ShowLogin()
		{
			return default;
		}

		[Token(Token = "0x6001A5B")]
		[Address(RVA = "0x70C4C7C", Offset = "0x70C0C7C", VA = "0x70C4C7C")]
		public static void LoginComStatic(int inOrOut)
		{
		}

		[Token(Token = "0x6001A5C")]
		[Address(RVA = "0x70C4E1C", Offset = "0x70C0E1C", VA = "0x70C4E1C")]
		public static bool IsShowFeedback()
		{
			return default;
		}

		[Token(Token = "0x6001A5D")]
		[Address(RVA = "0x70C4FEC", Offset = "0x70C0FEC", VA = "0x70C4FEC")]
		public static void ShowFeedback()
		{
		}

		[Token(Token = "0x6001A5E")]
		[Address(RVA = "0x70C514C", Offset = "0x70C114C", VA = "0x70C514C")]
		public static void ShowUpdateDalogStatic()
		{
		}

		[Token(Token = "0x6001A5F")]
		[Address(RVA = "0x70C52AC", Offset = "0x70C12AC", VA = "0x70C52AC")]
		public static bool IsRequestLocationInEeaOrUnknownStatic()
		{
			return default;
		}

		[Token(Token = "0x6001A60")]
		[Address(RVA = "0x70C547C", Offset = "0x70C147C", VA = "0x70C547C")]
		public static void ShowGDPRDialogStatic()
		{
		}

		[Token(Token = "0x6001A61")]
		[Address(RVA = "0x70C55DC", Offset = "0x70C15DC", VA = "0x70C55DC")]
		public static bool IsShowEvaluate()
		{
			return default;
		}

		[Token(Token = "0x6001A62")]
		[Address(RVA = "0x70C57AC", Offset = "0x70C17AC", VA = "0x70C57AC")]
		public static int GetEvaluateMode()
		{
			return default;
		}

		[Token(Token = "0x6001A63")]
		[Address(RVA = "0x70C5970", Offset = "0x70C1970", VA = "0x70C5970")]
		public static void ShowEvaluate()
		{
		}

		[Token(Token = "0x6001A64")]
		[Address(RVA = "0x70C5AD0", Offset = "0x70C1AD0", VA = "0x70C5AD0")]
		public static void CheckNeedCertification()
		{
		}

		[Token(Token = "0x6001A65")]
		[Address(RVA = "0x70C5C30", Offset = "0x70C1C30", VA = "0x70C5C30")]
		public static void ShowCertification()
		{
		}

		[Token(Token = "0x6001A66")]
		[Address(RVA = "0x70C5D90", Offset = "0x70C1D90", VA = "0x70C5D90")]
		public static int LoginServerStateStatic()
		{
			return default;
		}

		[Token(Token = "0x6001A67")]
		[Address(RVA = "0x70C5F54", Offset = "0x70C1F54", VA = "0x70C5F54")]
		public static void LoginAppServerStatic()
		{
		}

		[Token(Token = "0x6001A68")]
		[Address(RVA = "0x70C60B4", Offset = "0x70C20B4", VA = "0x70C60B4")]
		public static void LoginUploadUserDataStatic(string keyInfo, string valueInfo)
		{
		}

		[Token(Token = "0x6001A69")]
		[Address(RVA = "0x70C62D0", Offset = "0x70C22D0", VA = "0x70C62D0")]
		public static void LoginGetUserDataStatic(string keyInfo)
		{
		}

		[Token(Token = "0x6001A6A")]
		[Address(RVA = "0x70C644C", Offset = "0x70C244C", VA = "0x70C644C")]
		public static string LoginGetCurrentUserInfo()
		{
			return null;
		}

		[Token(Token = "0x6001A6B")]
		[Address(RVA = "0x70C6604", Offset = "0x70C2604", VA = "0x70C6604")]
		public static void LoginDismissDialog()
		{
		}

		[Token(Token = "0x6001A6C")]
		[Address(RVA = "0x70C6764", Offset = "0x70C2764", VA = "0x70C6764")]
		public static int GetUnderAgeLimitLevelStatic()
		{
			return default;
		}

		[Token(Token = "0x6001A6D")]
		[Address(RVA = "0x70C6928", Offset = "0x70C2928", VA = "0x70C6928")]
		public static void ShowEligibleAgeAlertStatic()
		{
		}

		[Token(Token = "0x6001A6E")]
		[Address(RVA = "0x70C6A88", Offset = "0x70C2A88", VA = "0x70C6A88")]
		public static void GameShareDynamicLinks(string aJson)
		{
		}

		[Token(Token = "0x6001A6F")]
		[Address(RVA = "0x70C6C04", Offset = "0x70C2C04", VA = "0x70C6C04")]
		public static string GameGetCurDynamicLinks()
		{
			return null;
		}

		[Token(Token = "0x6001A70")]
		[Address(RVA = "0x70C6DBC", Offset = "0x70C2DBC", VA = "0x70C6DBC")]
		public static bool IsShowForeignPolicy()
		{
			return default;
		}

		[Token(Token = "0x6001A71")]
		[Address(RVA = "0x70C6F8C", Offset = "0x70C2F8C", VA = "0x70C6F8C")]
		public static void GotoPrivacyPolicyForeignStatic()
		{
		}

		[Token(Token = "0x6001A72")]
		[Address(RVA = "0x70C70EC", Offset = "0x70C30EC", VA = "0x70C70EC")]
		public static void GotoTermsServiceForeignStatic()
		{
		}

		[Token(Token = "0x6001A73")]
		[Address(RVA = "0x70C724C", Offset = "0x70C324C", VA = "0x70C724C")]
		public static void DoAccountLoginOffStatic()
		{
		}

		[Token(Token = "0x6001A74")]
		[Address(RVA = "0x70C73AC", Offset = "0x70C33AC", VA = "0x70C73AC")]
		public static void DoAccountLoginOffSuccessStatic()
		{
		}

		[Token(Token = "0x6001A75")]
		[Address(RVA = "0x70C750C", Offset = "0x70C350C", VA = "0x70C750C")]
		public static void ServerLoginShowUserCenterStatic()
		{
		}

		[Token(Token = "0x6001A76")]
		[Address(RVA = "0x70C766C", Offset = "0x70C366C", VA = "0x70C766C")]
		public static void ServerLoginAppStatic()
		{
		}

		[Token(Token = "0x6001A77")]
		[Address(RVA = "0x70C77CC", Offset = "0x70C37CC", VA = "0x70C77CC")]
		public static void ServerLoginAppOtherTypeStatic(int atype)
		{
		}

		[Token(Token = "0x6001A78")]
		[Address(RVA = "0x70C796C", Offset = "0x70C396C", VA = "0x70C796C")]
		public static string ServerLoginSupportItemInfoStatic()
		{
			return null;
		}

		[Token(Token = "0x6001A79")]
		[Address(RVA = "0x70C7B24", Offset = "0x70C3B24", VA = "0x70C7B24")]
		public static void ServerNoUiLoginAppStatic(string atype, string openId, string unionPassword)
		{
		}

		[Token(Token = "0x6001A7A")]
		[Address(RVA = "0x70C7D9C", Offset = "0x70C3D9C", VA = "0x70C7D9C")]
		public static void ServerLoginGetUnionCodeStatic(string atype, string enumber)
		{
		}

		[Token(Token = "0x6001A7B")]
		[Address(RVA = "0x70C7FB8", Offset = "0x70C3FB8", VA = "0x70C7FB8")]
		public static void ServerLoginExitStatic()
		{
		}

		[Token(Token = "0x6001A7C")]
		[Address(RVA = "0x70C8118", Offset = "0x70C4118", VA = "0x70C8118")]
		public static int ServerLoginStateStatic()
		{
			return default;
		}

		[Token(Token = "0x6001A7D")]
		[Address(RVA = "0x70C82DC", Offset = "0x70C42DC", VA = "0x70C82DC")]
		public static string ServerLoginGetUserInfoStatic()
		{
			return null;
		}

		[Token(Token = "0x6001A7E")]
		[Address(RVA = "0x70C8494", Offset = "0x70C4494", VA = "0x70C8494")]
		public static void SetUserPropertyStatic(string ekey, string evalue)
		{
		}

		[Token(Token = "0x6001A7F")]
		[Address(RVA = "0x70C86B0", Offset = "0x70C46B0", VA = "0x70C86B0")]
		public static void ServerNoUiLoginSwitchAccount(string atype, string openId, string unionPassword)
		{
		}

		[Token(Token = "0x6001A80")]
		[Address(RVA = "0x70C8928", Offset = "0x70C4928", VA = "0x70C8928")]
		public static void SetCertification(int status)
		{
		}

		[Token(Token = "0x6001A81")]
		[Address(RVA = "0x70C8AC8", Offset = "0x70C4AC8", VA = "0x70C8AC8")]
		public static void ShowCertificationDialog()
		{
		}

		[Token(Token = "0x6001A82")]
		[Address(RVA = "0x70C8C28", Offset = "0x70C4C28", VA = "0x70C8C28")]
		public static void ServerLoginClearInfoStatic()
		{
		}

		[Token(Token = "0x6001A83")]
		[Address(RVA = "0x70C8D88", Offset = "0x70C4D88", VA = "0x70C8D88")]
		public static string GetUatt()
		{
			return null;
		}

		[Token(Token = "0x6001A84")]
		[Address(RVA = "0x70C8F40", Offset = "0x70C4F40", VA = "0x70C8F40")]
		public static string GetAttributionData()
		{
			return null;
		}

		[Token(Token = "0x6001A85")]
		[Address(RVA = "0x70C90F8", Offset = "0x70C50F8", VA = "0x70C90F8")]
		public static void PreloadRecommend()
		{
		}

		[Token(Token = "0x6001A86")]
		[Address(RVA = "0x70C9258", Offset = "0x70C5258", VA = "0x70C9258")]
		public static void ShowRecommend()
		{
		}

		[Token(Token = "0x6001A87")]
		[Address(RVA = "0x70C93B8", Offset = "0x70C53B8", VA = "0x70C93B8")]
		public static void GameServiceSignIn()
		{
		}

		[Token(Token = "0x6001A88")]
		[Address(RVA = "0x70C9518", Offset = "0x70C5518", VA = "0x70C9518")]
		public static void GameServiceUnlockAchievements(int atype, string achievementID, int percent)
		{
		}

		[Token(Token = "0x6001A89")]
		[Address(RVA = "0x70C9750", Offset = "0x70C5750", VA = "0x70C9750")]
		public static void GameServiceShowAchievements()
		{
		}

		[Token(Token = "0x6001A8A")]
		[Address(RVA = "0x70C98B0", Offset = "0x70C58B0", VA = "0x70C98B0")]
		public static bool GameServiceIsShowAchievements()
		{
			return default;
		}

		[Token(Token = "0x6001A8B")]
		[Address(RVA = "0x70C9A80", Offset = "0x70C5A80", VA = "0x70C9A80")]
		public AppUserAndroid()
		{
		}
	}
}
