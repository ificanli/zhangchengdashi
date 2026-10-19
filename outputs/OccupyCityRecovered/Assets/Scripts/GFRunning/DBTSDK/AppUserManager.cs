using System;
using System.Runtime.InteropServices;
using DBTSDK.Evaluate;
using GameFramework.Login;
using Il2CppDummyDll;
using UnityEngine;

namespace DBTSDK
{
	[Token(Token = "0x20001D8")]
	public class AppUserManager : MonoBehaviour
	{
		[Token(Token = "0x400064F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static AppUserManager Instance;

		[Token(Token = "0x4000650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GameObject AntiAddictionPrefab;

		[Token(Token = "0x4000651")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IAntiAddiction antiAddiction;

		[Token(Token = "0x4000652")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float FirstEvaluateTimes;

		[Token(Token = "0x4000653")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public ILoginProcedure LoginProcedure;

		[Token(Token = "0x4000654")]
		public const int MaxShowEvaluateCount = 3;

		[Token(Token = "0x4000655")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		internal IDriveEvaluateProcedure driveEvaluate;

		[Token(Token = "0x4000656")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool IsCloseAntiAddiction;

		[Token(Token = "0x4000657")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Action<int, string> LoginCallBack;

		[Token(Token = "0x4000658")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Action m_serverLoginUserOver;

		[Token(Token = "0x4000659")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Action<int, int> m_certificationDialogCallback;

		[Token(Token = "0x400065A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Action<string> m_uattCallBack;

		[Token(Token = "0x400065B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Action<string> m_xyxuattCallBack;

		[Token(Token = "0x400065C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Action<int> _getGameCebterCallback;

		[Token(Token = "0x400065D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Action<int> _submitCallback;

		[Token(Token = "0x400065E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Action<int> _showGameCenterCallback;

		[Token(Token = "0x400065F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Action<int> _submitAchievementCallback;

		[Token(Token = "0x4000660")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Action<int> _showAchievementCallback;

		[Token(Token = "0x4000661")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Action<int, string> _getGameCenterScoreCallback;

		[Token(Token = "0x4000662")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Action<int, int, string> m_gdprCallBack;

		[Token(Token = "0x170000FE")]
		internal bool IsUseServer
		{
			[Token(Token = "0x600183F")]
			[Address(RVA = "0x73A154C", Offset = "0x739D54C", VA = "0x73A154C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1400000C")]
		public event Action SDKLoginOutUserOver
		{
			[Token(Token = "0x600185A")]
			[Address(RVA = "0x73A40D8", Offset = "0x73A00D8", VA = "0x73A40D8")]
			add
			{
			}
			[Token(Token = "0x600185B")]
			[Address(RVA = "0x73A4158", Offset = "0x73A0158", VA = "0x73A4158")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000D")]
		public event Action<string> UttCallBack
		{
			[Token(Token = "0x6001864")]
			[Address(RVA = "0x73A5390", Offset = "0x73A1390", VA = "0x73A5390")]
			add
			{
			}
			[Token(Token = "0x6001865")]
			[Address(RVA = "0x73A5438", Offset = "0x73A1438", VA = "0x73A5438")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000E")]
		public event Action<string> XyxUttCallBack
		{
			[Token(Token = "0x6001867")]
			[Address(RVA = "0x73A583C", Offset = "0x73A183C", VA = "0x73A583C")]
			add
			{
			}
			[Token(Token = "0x6001868")]
			[Address(RVA = "0x73A58E4", Offset = "0x73A18E4", VA = "0x73A58E4")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000F")]
		public event Action<int, int, string> GDPRCallBack
		{
			[Token(Token = "0x6001879")]
			[Address(RVA = "0x73A6FBC", Offset = "0x73A2FBC", VA = "0x73A6FBC")]
			add
			{
			}
			[Token(Token = "0x600187A")]
			[Address(RVA = "0x73A7064", Offset = "0x73A3064", VA = "0x73A7064")]
			remove
			{
			}
		}

		[Token(Token = "0x6001840")]
		[Address(RVA = "0x73A1634", Offset = "0x739D634", VA = "0x73A1634")]
		private void Awake()
		{
		}

		[Token(Token = "0x6001841")]
		[Address(RVA = "0x73A1810", Offset = "0x739D810", VA = "0x73A1810")]
		public void SetFirstEvaluateTimes(float tiems)
		{
		}

		[Token(Token = "0x6001842")]
		[Address(RVA = "0x73A1818", Offset = "0x739D818", VA = "0x73A1818")]
		public void SetDriveEvaluateProcedure(IDriveEvaluateProcedure DriveEvaluate)
		{
		}

		[Token(Token = "0x6001843")]
		[Address(RVA = "0x73A1820", Offset = "0x739D820", VA = "0x73A1820")]
		public void DriveEvaluateUserChoise(int StarNum)
		{
		}

		[Token(Token = "0x6001844")]
		[Address(RVA = "0x73A1910", Offset = "0x739D910", VA = "0x73A1910")]
		[Obsolete("请使用新版的公共资源管理控制域名资源", false)]
		public bool ShowEvaluate_M(DomainGroup domainGroup, [Optional] Action CloseBackCall)
		{
			return default;
		}

		[Token(Token = "0x6001845")]
		[Address(RVA = "0x73A2148", Offset = "0x739E148", VA = "0x73A2148")]
		public bool ShowEvaluate_M([Optional] Action CloseBackCall)
		{
			return default;
		}

		[Token(Token = "0x6001846")]
		[Address(RVA = "0x73A251C", Offset = "0x739E51C", VA = "0x73A251C")]
		public bool ShowEvaluate_M(GameObject EvaluatePrefab, Action CloseBackCall)
		{
			return default;
		}

		[Token(Token = "0x6001847")]
		[Address(RVA = "0x73A1B58", Offset = "0x739DB58", VA = "0x73A1B58")]
		public bool IsCanShowEvaluate()
		{
			return default;
		}

		[Token(Token = "0x6001848")]
		[Address(RVA = "0x73A16FC", Offset = "0x739D6FC", VA = "0x73A16FC")]
		private void LoadAntiAddiction()
		{
		}

		[Token(Token = "0x6001849")]
		[Address(RVA = "0x73A25C8", Offset = "0x739E5C8", VA = "0x73A25C8")]
		public void ShowAntiAddiction(bool IsTop, float OffsetY, string ContentCorlor = "", string txtContent = "")
		{
		}

		[Token(Token = "0x600184A")]
		[Address(RVA = "0x73A28EC", Offset = "0x739E8EC", VA = "0x73A28EC")]
		public void CloseAntiAddiction()
		{
		}

		[Token(Token = "0x600184B")]
		[Address(RVA = "0x73A29D0", Offset = "0x739E9D0", VA = "0x73A29D0")]
		public bool IsShowShare_Override()
		{
			return default;
		}

		[Token(Token = "0x600184C")]
		[Address(RVA = "0x73A2B64", Offset = "0x739EB64", VA = "0x73A2B64")]
		[Obsolete("请用ShowShareApp替换")]
		public void ShowShare(string DefaultTitle, string Url = "")
		{
		}

		[Token(Token = "0x600184D")]
		[Address(RVA = "0x73A2EA4", Offset = "0x739EEA4", VA = "0x73A2EA4")]
		public void ShowShareApp(int ShareType, string Title, string DefaulContent)
		{
		}

		[Token(Token = "0x600184E")]
		[Address(RVA = "0x73A2F8C", Offset = "0x739EF8C", VA = "0x73A2F8C")]
		public void ShowShareApp(int ShareType, string Title, string DefaulContent, params string[] Args)
		{
		}

		[Token(Token = "0x600184F")]
		[Address(RVA = "0x73A2F78", Offset = "0x739EF78", VA = "0x73A2F78")]
		public void ShowShareApp(int ShareType, string Title, string DefaulContent, string ShareImg, params string[] Args)
		{
		}

		[Token(Token = "0x6001850")]
		[Address(RVA = "0x73A31A8", Offset = "0x739F1A8", VA = "0x73A31A8")]
		public void WXShareAppMessage(string title, string imgURL)
		{
		}

		[Token(Token = "0x6001851")]
		[Address(RVA = "0x73A320C", Offset = "0x739F20C", VA = "0x73A320C")]
		public void FirebaseDynamicLinks(string Title, string DefaulContent, string urlparam)
		{
		}

		[Token(Token = "0x6001852")]
		[Address(RVA = "0x73A34A4", Offset = "0x739F4A4", VA = "0x73A34A4")]
		public string FirebaseGetDynamicLinks()
		{
			return null;
		}

		[Token(Token = "0x6001853")]
		[Address(RVA = "0x73A36A0", Offset = "0x739F6A0", VA = "0x73A36A0")]
		public void Login(int inOrOut)
		{
		}

		[Token(Token = "0x6001854")]
		[Address(RVA = "0x73A3828", Offset = "0x739F828", VA = "0x73A3828")]
		private void HttpServerErrorCode(object[] Args)
		{
		}

		[Token(Token = "0x6001855")]
		[Address(RVA = "0x73A3978", Offset = "0x739F978", VA = "0x73A3978")]
		public bool ShowLogin_Override()
		{
			return default;
		}

		[Token(Token = "0x6001856")]
		[Address(RVA = "0x73A3B0C", Offset = "0x739FB0C", VA = "0x73A3B0C")]
		public void LoginComStatic_Override(int inOrOut, Action<int, string> LoginCallBack)
		{
		}

		[Token(Token = "0x6001857")]
		[Address(RVA = "0x73A3B14", Offset = "0x739FB14", VA = "0x73A3B14")]
		internal void loginCallback(string data)
		{
		}

		[Token(Token = "0x6001858")]
		[Address(RVA = "0x73A3EE0", Offset = "0x739FEE0", VA = "0x73A3EE0")]
		internal void serverLoginStateExitCallBack()
		{
		}

		[Token(Token = "0x6001859")]
		[Address(RVA = "0x73A3FE0", Offset = "0x739FFE0", VA = "0x73A3FE0")]
		internal void serverNoUiLoginAccountExitCallBack()
		{
		}

		[Token(Token = "0x600185C")]
		[Address(RVA = "0x73A41D8", Offset = "0x73A01D8", VA = "0x73A41D8")]
		internal void serverLoginUserOverCallBack()
		{
		}

		[Token(Token = "0x600185D")]
		[Address(RVA = "0x73A42DC", Offset = "0x73A02DC", VA = "0x73A42DC")]
		internal void serverNoUiLoginCallBack(string data)
		{
		}

		[Token(Token = "0x600185E")]
		[Address(RVA = "0x73A4D8C", Offset = "0x73A0D8C", VA = "0x73A4D8C")]
		internal void serverLoginResultCallBack(string data)
		{
		}

		[Token(Token = "0x600185F")]
		[Address(RVA = "0x73A43F8", Offset = "0x73A03F8", VA = "0x73A43F8")]
		private int ParseLoginCode(string data, string key)
		{
			return default;
		}

		[Token(Token = "0x6001860")]
		[Address(RVA = "0x73A476C", Offset = "0x73A076C", VA = "0x73A476C")]
		private void loginCallBack(int IntCode)
		{
		}

		[Token(Token = "0x6001861")]
		[Address(RVA = "0x73A4FD0", Offset = "0x73A0FD0", VA = "0x73A4FD0")]
		public bool IsShowGameCollection()
		{
			return default;
		}

		[Token(Token = "0x6001862")]
		[Address(RVA = "0x73A5020", Offset = "0x73A1020", VA = "0x73A5020")]
		public void ShowCertificationDialog_M(Action<int, int> callback)
		{
		}

		[Token(Token = "0x6001863")]
		[Address(RVA = "0x73A514C", Offset = "0x73A114C", VA = "0x73A514C")]
		internal void certificationDialogCallback(string data)
		{
		}

		[Token(Token = "0x6001866")]
		[Address(RVA = "0x73A54E0", Offset = "0x73A14E0", VA = "0x73A54E0")]
		internal void uattCallBack(string data)
		{
		}

		[Token(Token = "0x6001869")]
		[Address(RVA = "0x73A598C", Offset = "0x73A198C", VA = "0x73A598C")]
		private void attributionDataCallBack(string data)
		{
		}

		[Token(Token = "0x600186A")]
		[Address(RVA = "0x73A5C7C", Offset = "0x73A1C7C", VA = "0x73A5C7C")]
		private void GameCenterCallBackPares(Action<int> callback, string data)
		{
		}

		[Token(Token = "0x600186B")]
		[Address(RVA = "0x73A5EEC", Offset = "0x73A1EEC", VA = "0x73A5EEC")]
		public void getGameCenterStatusStatic_M(Action<int> callback)
		{
		}

		[Token(Token = "0x600186C")]
		[Address(RVA = "0x73A6018", Offset = "0x73A2018", VA = "0x73A6018")]
		internal void getGameCenterStatusCallback(string data)
		{
		}

		[Token(Token = "0x600186D")]
		[Address(RVA = "0x73A6114", Offset = "0x73A2114", VA = "0x73A6114")]
		internal void gameServiceSignInCallback(string data)
		{
		}

		[Token(Token = "0x600186E")]
		[Address(RVA = "0x73A6210", Offset = "0x73A2210", VA = "0x73A6210")]
		public void submitScoreStatic_M(string leaderboardID, int score, Action<int> callback)
		{
		}

		[Token(Token = "0x600186F")]
		[Address(RVA = "0x73A6348", Offset = "0x73A2348", VA = "0x73A6348")]
		internal void submitScoreToGameCenterCallback(string data)
		{
		}

		[Token(Token = "0x6001870")]
		[Address(RVA = "0x73A6444", Offset = "0x73A2444", VA = "0x73A6444")]
		public void showGameCenterLeaderboardStatic_M(string leaderboardID, Action<int> callback)
		{
		}

		[Token(Token = "0x6001871")]
		[Address(RVA = "0x73A6568", Offset = "0x73A2568", VA = "0x73A6568")]
		internal void showGameCenterLeaderboardCallback(string data)
		{
		}

		[Token(Token = "0x6001872")]
		[Address(RVA = "0x73A6664", Offset = "0x73A2664", VA = "0x73A6664")]
		public void SubmitAchievementToGameCenterStatic_M(string achievementID, float percent, Action<int> callback)
		{
		}

		[Token(Token = "0x6001873")]
		[Address(RVA = "0x73A6850", Offset = "0x73A2850", VA = "0x73A6850")]
		public void SubmitAchievementToPGSStatic(int type, string achievementID, int increment)
		{
		}

		[Token(Token = "0x6001874")]
		[Address(RVA = "0x73A6854", Offset = "0x73A2854", VA = "0x73A6854")]
		internal void submitAchievementToGameCenterCallback(string data)
		{
		}

		[Token(Token = "0x6001875")]
		[Address(RVA = "0x73A6950", Offset = "0x73A2950", VA = "0x73A6950")]
		public void ShowGameCenterAchievementStatic_M(string achievementID, Action<int> callback)
		{
		}

		[Token(Token = "0x6001876")]
		[Address(RVA = "0x73A6A7C", Offset = "0x73A2A7C", VA = "0x73A6A7C")]
		internal void showGameCenterAchievementCallback(string data)
		{
		}

		[Token(Token = "0x6001877")]
		[Address(RVA = "0x73A6B78", Offset = "0x73A2B78", VA = "0x73A6B78")]
		public void GetGameCenterScoreListStatic_M(string leaderboardID, int timeScopeType, Action<int, string> callback)
		{
		}

		[Token(Token = "0x6001878")]
		[Address(RVA = "0x73A6CB0", Offset = "0x73A2CB0", VA = "0x73A6CB0")]
		internal void getGameCenterScoreListCallback(string data)
		{
		}

		[Token(Token = "0x600187B")]
		[Address(RVA = "0x73A710C", Offset = "0x73A310C", VA = "0x73A710C")]
		internal void showSatisfiedGDPRDialogCallBack(string data)
		{
		}

		[Token(Token = "0x600187C")]
		[Address(RVA = "0x73A7560", Offset = "0x73A3560", VA = "0x73A7560")]
		internal void showGDPRInAppCallback(string data)
		{
		}

		[Token(Token = "0x600187D")]
		[Address(RVA = "0x73A7208", Offset = "0x73A3208", VA = "0x73A7208")]
		private void GDPRCallBackPares(string data)
		{
		}

		[Token(Token = "0x600187E")]
		[Address(RVA = "0x73A765C", Offset = "0x73A365C", VA = "0x73A765C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600187F")]
		[Address(RVA = "0x73A2A3C", Offset = "0x739EA3C", VA = "0x73A2A3C")]
		public bool IsShowShare()
		{
			return default;
		}

		[Token(Token = "0x6001880")]
		[Address(RVA = "0x73A76F4", Offset = "0x73A36F4", VA = "0x73A76F4")]
		public int GetShareMode()
		{
			return default;
		}

		[Token(Token = "0x6001881")]
		[Address(RVA = "0x73A781C", Offset = "0x73A381C", VA = "0x73A781C")]
		internal void ShareImage(string title, string content, string url, string imgFile)
		{
		}

		[Token(Token = "0x6001882")]
		[Address(RVA = "0x73A2D4C", Offset = "0x739ED4C", VA = "0x73A2D4C")]
		internal void ShareText(string title, string content, string url)
		{
		}

		[Token(Token = "0x6001883")]
		[Address(RVA = "0x73A2C24", Offset = "0x739EC24", VA = "0x73A2C24")]
		public string GetShareUrl()
		{
			return null;
		}

		[Token(Token = "0x6001884")]
		[Address(RVA = "0x73A300C", Offset = "0x739F00C", VA = "0x73A300C")]
		internal void ShareApp(int Sharetype, string title, string content, string imgFile, string[] Args, int count)
		{
		}

		[Token(Token = "0x6001885")]
		[Address(RVA = "0x73A39E4", Offset = "0x739F9E4", VA = "0x73A39E4")]
		public bool ShowLogin()
		{
			return default;
		}

		[Token(Token = "0x6001886")]
		[Address(RVA = "0x73A36F8", Offset = "0x739F6F8", VA = "0x73A36F8")]
		public void LoginComStatic(int inOrOut)
		{
		}

		[Token(Token = "0x6001887")]
		[Address(RVA = "0x73A7990", Offset = "0x73A3990", VA = "0x73A7990")]
		public bool IsShowFeedback()
		{
			return default;
		}

		[Token(Token = "0x6001888")]
		[Address(RVA = "0x73A7AB8", Offset = "0x73A3AB8", VA = "0x73A7AB8")]
		public void ShowFeedback()
		{
		}

		[Token(Token = "0x6001889")]
		[Address(RVA = "0x73A7BDC", Offset = "0x73A3BDC", VA = "0x73A7BDC")]
		public void ShowUpdateDalogStatic()
		{
		}

		[Token(Token = "0x600188A")]
		[Address(RVA = "0x73A7D00", Offset = "0x73A3D00", VA = "0x73A7D00")]
		public bool IsRequestLocationInEeaOrUnknownStatic()
		{
			return default;
		}

		[Token(Token = "0x600188B")]
		[Address(RVA = "0x73A7E28", Offset = "0x73A3E28", VA = "0x73A7E28")]
		public void ShowGDPRDialogStatic()
		{
		}

		[Token(Token = "0x600188C")]
		[Address(RVA = "0x73A7F4C", Offset = "0x73A3F4C", VA = "0x73A7F4C")]
		public bool IsShowEvaluate()
		{
			return default;
		}

		[Token(Token = "0x600188D")]
		[Address(RVA = "0x73A8074", Offset = "0x73A4074", VA = "0x73A8074")]
		public int GetEvaluateMode()
		{
			return default;
		}

		[Token(Token = "0x600188E")]
		[Address(RVA = "0x73A819C", Offset = "0x73A419C", VA = "0x73A819C")]
		internal void ShowEvaluate()
		{
		}

		[Token(Token = "0x600188F")]
		[Address(RVA = "0x73A82C0", Offset = "0x73A42C0", VA = "0x73A82C0")]
		public void CheckNeedCertification()
		{
		}

		[Token(Token = "0x6001890")]
		[Address(RVA = "0x73A83E4", Offset = "0x73A43E4", VA = "0x73A83E4")]
		public void ShowCertification()
		{
		}

		[Token(Token = "0x6001891")]
		[Address(RVA = "0x73A8508", Offset = "0x73A4508", VA = "0x73A8508")]
		public int LoginServerStateStatic()
		{
			return default;
		}

		[Token(Token = "0x6001892")]
		[Address(RVA = "0x73A8630", Offset = "0x73A4630", VA = "0x73A8630")]
		public void LoginAppServerStatic()
		{
		}

		[Token(Token = "0x6001893")]
		[Address(RVA = "0x73A8754", Offset = "0x73A4754", VA = "0x73A8754")]
		public void LoginUploadUserDataStatic(string keyInfo, string valueInfo)
		{
		}

		[Token(Token = "0x6001894")]
		[Address(RVA = "0x73A88A0", Offset = "0x73A48A0", VA = "0x73A88A0")]
		public void LoginGetUserDataStatic(string keyInfo)
		{
		}

		[Token(Token = "0x6001895")]
		[Address(RVA = "0x73A89D0", Offset = "0x73A49D0", VA = "0x73A89D0")]
		public string LoginGetCurrentUserInfo()
		{
			return null;
		}

		[Token(Token = "0x6001896")]
		[Address(RVA = "0x73A8AF8", Offset = "0x73A4AF8", VA = "0x73A8AF8")]
		public void LoginDismissDialog()
		{
		}

		[Token(Token = "0x6001897")]
		[Address(RVA = "0x73A8C1C", Offset = "0x73A4C1C", VA = "0x73A8C1C")]
		public int GetUnderAgeLimitLevelStatic()
		{
			return default;
		}

		[Token(Token = "0x6001898")]
		[Address(RVA = "0x73A8D44", Offset = "0x73A4D44", VA = "0x73A8D44")]
		public void ShowEligibleAgeAlertStatic()
		{
		}

		[Token(Token = "0x6001899")]
		[Address(RVA = "0x73A32B4", Offset = "0x739F2B4", VA = "0x73A32B4")]
		internal void GameShareDynamicLinks(string aJson)
		{
		}

		[Token(Token = "0x600189A")]
		[Address(RVA = "0x73A34A8", Offset = "0x739F4A8", VA = "0x73A34A8")]
		internal string GameGetCurDynamicLinks()
		{
			return null;
		}

		[Token(Token = "0x600189B")]
		[Address(RVA = "0x73A8E68", Offset = "0x73A4E68", VA = "0x73A8E68")]
		internal bool IsShowForeignPolicy()
		{
			return default;
		}

		[Token(Token = "0x600189C")]
		[Address(RVA = "0x73A8F90", Offset = "0x73A4F90", VA = "0x73A8F90")]
		internal void GotoPrivacyPolicyForeignStatic()
		{
		}

		[Token(Token = "0x600189D")]
		[Address(RVA = "0x73A90B4", Offset = "0x73A50B4", VA = "0x73A90B4")]
		internal void GotoTermsServiceForeignStatic()
		{
		}

		[Token(Token = "0x600189E")]
		[Address(RVA = "0x73A91D8", Offset = "0x73A51D8", VA = "0x73A91D8")]
		public void DoAccountLoginOffStatic()
		{
		}

		[Token(Token = "0x600189F")]
		[Address(RVA = "0x73A92FC", Offset = "0x73A52FC", VA = "0x73A92FC")]
		public void DoAccountLoginOffSuccessStatic()
		{
		}

		[Token(Token = "0x60018A0")]
		[Address(RVA = "0x73A9420", Offset = "0x73A5420", VA = "0x73A9420")]
		public void ServerLoginShowUserCenterStatic()
		{
		}

		[Token(Token = "0x60018A1")]
		[Address(RVA = "0x73A9544", Offset = "0x73A5544", VA = "0x73A9544")]
		public void ServerLoginAppStatic()
		{
		}

		[Token(Token = "0x60018A2")]
		[Address(RVA = "0x73A9668", Offset = "0x73A5668", VA = "0x73A9668")]
		public void ServerLoginAppOtherTypeStatic(int atype)
		{
		}

		[Token(Token = "0x60018A3")]
		[Address(RVA = "0x73A9798", Offset = "0x73A5798", VA = "0x73A9798")]
		public string ServerLoginSupportItemInfoStatic()
		{
			return null;
		}

		[Token(Token = "0x60018A4")]
		[Address(RVA = "0x73A98C0", Offset = "0x73A58C0", VA = "0x73A98C0")]
		public void ServerNoUiLoginAppStatic(string atype, string openId, string unionPassword)
		{
		}

		[Token(Token = "0x60018A5")]
		[Address(RVA = "0x73A9A18", Offset = "0x73A5A18", VA = "0x73A9A18")]
		public void ServerLoginGetUnionCodeStatic(string atype, string enumber)
		{
		}

		[Token(Token = "0x60018A6")]
		[Address(RVA = "0x73A9B64", Offset = "0x73A5B64", VA = "0x73A9B64")]
		public void ServerLoginExitStatic()
		{
		}

		[Token(Token = "0x60018A7")]
		[Address(RVA = "0x73A9C88", Offset = "0x73A5C88", VA = "0x73A9C88")]
		public int ServerLoginStateStatic()
		{
			return default;
		}

		[Token(Token = "0x60018A8")]
		[Address(RVA = "0x73A4EA8", Offset = "0x73A0EA8", VA = "0x73A4EA8")]
		public string ServerLoginGetUserInfoStatic()
		{
			return null;
		}

		[Token(Token = "0x60018A9")]
		[Address(RVA = "0x73A9DB0", Offset = "0x73A5DB0", VA = "0x73A9DB0")]
		public void SetFirebaseUserPropertyStatic(string key, string value)
		{
		}

		[Token(Token = "0x60018AA")]
		[Address(RVA = "0x73A9EE0", Offset = "0x73A5EE0", VA = "0x73A9EE0")]
		public void SetUserPropertyStatic(string ekey, string evalue)
		{
		}

		[Token(Token = "0x60018AB")]
		[Address(RVA = "0x73AA02C", Offset = "0x73A602C", VA = "0x73AA02C")]
		public void ServerNoUiLoginSwitchAccount(string atype, string openId, string unionPassword)
		{
		}

		[Token(Token = "0x60018AC")]
		[Address(RVA = "0x73AA184", Offset = "0x73A6184", VA = "0x73AA184")]
		public void SetCertification(int status)
		{
		}

		[Token(Token = "0x60018AD")]
		[Address(RVA = "0x73A5028", Offset = "0x73A1028", VA = "0x73A5028")]
		internal void ShowCertificationDialog()
		{
		}

		[Token(Token = "0x60018AE")]
		[Address(RVA = "0x73AA2B4", Offset = "0x73A62B4", VA = "0x73AA2B4")]
		public void ServerLoginClearInfoStatic()
		{
		}

		[Token(Token = "0x60018AF")]
		[Address(RVA = "0x73AA3D8", Offset = "0x73A63D8", VA = "0x73AA3D8")]
		public string GetUatt()
		{
			return null;
		}

		[Token(Token = "0x60018B0")]
		[Address(RVA = "0x73AA500", Offset = "0x73A6500", VA = "0x73AA500")]
		internal void GetGameCenterStatusStatic()
		{
		}

		[Token(Token = "0x60018B1")]
		[Address(RVA = "0x73A6218", Offset = "0x73A2218", VA = "0x73A6218")]
		internal void SubmitScoreToGameCenterStatic(string leaderboardID, int score)
		{
		}

		[Token(Token = "0x60018B2")]
		[Address(RVA = "0x73A644C", Offset = "0x73A244C", VA = "0x73A644C")]
		internal void ShowGameCenterLeaderboardStatic(string leaderboardID)
		{
		}

		[Token(Token = "0x60018B3")]
		[Address(RVA = "0x73AA614", Offset = "0x73A6614", VA = "0x73AA614")]
		internal void SubmitAchievementToGameCenterStatic(string achievementID, float percent)
		{
		}

		[Token(Token = "0x60018B4")]
		[Address(RVA = "0x73AA744", Offset = "0x73A6744", VA = "0x73AA744")]
		internal void ShowGameCenterAchievementStatic(string achievementID)
		{
		}

		[Token(Token = "0x60018B5")]
		[Address(RVA = "0x73A6B80", Offset = "0x73A2B80", VA = "0x73A6B80")]
		internal void GetGameCenterScoreListStatic(string leaderboardID, int timeScopeType)
		{
		}

		[Token(Token = "0x60018B6")]
		[Address(RVA = "0x73AA860", Offset = "0x73A6860", VA = "0x73AA860")]
		public string GetAttributionData()
		{
			return null;
		}

		[Token(Token = "0x60018B7")]
		[Address(RVA = "0x73AA988", Offset = "0x73A6988", VA = "0x73AA988")]
		public void PreloadRecommend()
		{
		}

		[Token(Token = "0x60018B8")]
		[Address(RVA = "0x73AAAAC", Offset = "0x73A6AAC", VA = "0x73AAAAC")]
		public void ShowRecommend()
		{
		}

		[Token(Token = "0x60018B9")]
		[Address(RVA = "0x73A5EF4", Offset = "0x73A1EF4", VA = "0x73A5EF4")]
		internal void GameServiceSignIn()
		{
		}

		[Token(Token = "0x60018BA")]
		[Address(RVA = "0x73A66F8", Offset = "0x73A26F8", VA = "0x73A66F8")]
		internal void GameServiceUnlockAchievements(int atype, string achievementID, int percent)
		{
		}

		[Token(Token = "0x60018BB")]
		[Address(RVA = "0x73A6958", Offset = "0x73A2958", VA = "0x73A6958")]
		internal void GameServiceShowAchievements()
		{
		}

		[Token(Token = "0x60018BC")]
		[Address(RVA = "0x73AABD0", Offset = "0x73A6BD0", VA = "0x73AABD0")]
		internal bool GameServiceIsShowAchievements()
		{
			return default;
		}

		[Token(Token = "0x60018BD")]
		[Address(RVA = "0x73AACF8", Offset = "0x73A6CF8", VA = "0x73AACF8")]
		public AppUserManager()
		{
		}
	}
}
