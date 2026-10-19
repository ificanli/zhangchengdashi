using System;
using Il2CppDummyDll;
using UnityEngine;

namespace DBTSDK
{
	[Token(Token = "0x20001D6")]
	public class AppInfoManager : MonoBehaviour
	{
		[Token(Token = "0x4000642")]
		[FieldOffset(Offset = "0x0")]
		public static AppInfoManager Instance;

		[Token(Token = "0x4000643")]
		[FieldOffset(Offset = "0x20")]
		private Action<string> OsCountryCodeCallBack;

		[Token(Token = "0x4000644")]
		private const string oppo = "oppo";

		[Token(Token = "0x4000645")]
		private const string vivo = "vivo";

		[Token(Token = "0x4000646")]
		private const string xiaomi = "xiaomi";

		[Token(Token = "0x4000647")]
		private const string huawei = "huawei";

		[Token(Token = "0x4000648")]
		private const string google = "google";

		[Token(Token = "0x4000649")]
		private const string toutiao = "toutiao";

		[Token(Token = "0x400064A")]
		[FieldOffset(Offset = "0x28")]
		private ChannelInfo channelInfo;

		[Token(Token = "0x170000FD")]
		public string Dev_ID
		{
			[Token(Token = "0x60017FA")]
			[Address(RVA = "0x739C6D0", Offset = "0x73986D0", VA = "0x739C6D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60017FB")]
		[Address(RVA = "0x739C764", Offset = "0x7398764", VA = "0x739C764")]
		private void Awake()
		{
		}

		[Token(Token = "0x60017FC")]
		[Address(RVA = "0x739C7B0", Offset = "0x73987B0", VA = "0x739C7B0")]
		public void GetOnlineOsCountryCode_Override(Action<string> CallBack)
		{
		}

		[Token(Token = "0x60017FD")]
		[Address(RVA = "0x739C8DC", Offset = "0x73988DC", VA = "0x739C8DC")]
		internal void OnlineIsoCountryCodeCallback(string data)
		{
		}

		[Token(Token = "0x60017FE")]
		[Address(RVA = "0x739CC50", Offset = "0x7398C50", VA = "0x739CC50")]
		public (int, int) GetAppChannel_Override()
		{
			return default;
		}

		[Token(Token = "0x60017FF")]
		[Address(RVA = "0x739CFE8", Offset = "0x7398FE8", VA = "0x739CFE8")]
		private int GetAppChannelChild(string Channel, string key)
		{
			return default;
		}

		[Token(Token = "0x6001800")]
		[Address(RVA = "0x739D06C", Offset = "0x739906C", VA = "0x739D06C")]
		public ChannelInfo GetChannelInfoStatic_Override()
		{
			return null;
		}

		[Token(Token = "0x6001801")]
		[Address(RVA = "0x739D3EC", Offset = "0x73993EC", VA = "0x739D3EC")]
		public string GetOnlineConfigParams_Override(string paramKey)
		{
			return null;
		}

		[Token(Token = "0x6001802")]
		[Address(RVA = "0x739D524", Offset = "0x7399524", VA = "0x739D524")]
		public bool IsOnlineParamReady_Override()
		{
			return default;
		}

		[Token(Token = "0x6001803")]
		[Address(RVA = "0x739D650", Offset = "0x7399650", VA = "0x739D650")]
		internal void onlineParamLoadStateCallBack(string data)
		{
		}

		[Token(Token = "0x6001804")]
		[Address(RVA = "0x739D8A0", Offset = "0x73998A0", VA = "0x739D8A0")]
		public string GetDbtId()
		{
			return null;
		}

		[Token(Token = "0x6001805")]
		[Address(RVA = "0x739DA6C", Offset = "0x7399A6C", VA = "0x739DA6C")]
		public int GetNotchHeightStatic_M()
		{
			return default;
		}

		[Token(Token = "0x6001806")]
		[Address(RVA = "0x739DB98", Offset = "0x7399B98", VA = "0x739DB98")]
		public string GetNotchInfoStatic_M()
		{
			return null;
		}

		[Token(Token = "0x6001807")]
		[Address(RVA = "0x739DCC4", Offset = "0x7399CC4", VA = "0x739DCC4")]
		public int GetBottomNotchHeightStatic_M()
		{
			return default;
		}

		[Token(Token = "0x6001808")]
		[Address(RVA = "0x739DDE0", Offset = "0x7399DE0", VA = "0x739DDE0")]
		public string GetPackageName()
		{
			return null;
		}

		[Token(Token = "0x6001809")]
		[Address(RVA = "0x739DF04", Offset = "0x7399F04", VA = "0x739DF04")]
		public string GetVersionName()
		{
			return null;
		}

		[Token(Token = "0x600180A")]
		[Address(RVA = "0x739E028", Offset = "0x739A028", VA = "0x739E028")]
		public string GetInstallVersion()
		{
			return null;
		}

		[Token(Token = "0x600180B")]
		[Address(RVA = "0x739E14C", Offset = "0x739A14C", VA = "0x739E14C")]
		public bool IsInstallVersion()
		{
			return default;
		}

		[Token(Token = "0x600180C")]
		[Address(RVA = "0x739CEC4", Offset = "0x7398EC4", VA = "0x739CEC4")]
		public string GetAppChannel()
		{
			return null;
		}

		[Token(Token = "0x600180D")]
		[Address(RVA = "0x739E270", Offset = "0x739A270", VA = "0x739E270")]
		public int GetAppChannelId()
		{
			return default;
		}

		[Token(Token = "0x600180E")]
		[Address(RVA = "0x739E394", Offset = "0x739A394", VA = "0x739E394")]
		public void SetAppChannelId(int channelId)
		{
		}

		[Token(Token = "0x600180F")]
		[Address(RVA = "0x739E4C0", Offset = "0x739A4C0", VA = "0x739E4C0")]
		public bool IsFirstStartVer()
		{
			return default;
		}

		[Token(Token = "0x6001810")]
		[Address(RVA = "0x739E5E4", Offset = "0x739A5E4", VA = "0x739E5E4")]
		public int GetStartNum()
		{
			return default;
		}

		[Token(Token = "0x6001811")]
		[Address(RVA = "0x739E708", Offset = "0x739A708", VA = "0x739E708")]
		public long GetFirstInstallTime()
		{
			return default;
		}

		[Token(Token = "0x6001812")]
		[Address(RVA = "0x739E830", Offset = "0x739A830", VA = "0x739E830")]
		public int GetScreenWidth()
		{
			return default;
		}

		[Token(Token = "0x6001813")]
		[Address(RVA = "0x739E958", Offset = "0x739A958", VA = "0x739E958")]
		public int GetScreenHeight()
		{
			return default;
		}

		[Token(Token = "0x6001814")]
		[Address(RVA = "0x739EA80", Offset = "0x739AA80", VA = "0x739EA80")]
		public int GetSystemLanguage()
		{
			return default;
		}

		[Token(Token = "0x6001815")]
		[Address(RVA = "0x739EBA8", Offset = "0x739ABA8", VA = "0x739EBA8")]
		public string GetDeviceId()
		{
			return null;
		}

		[Token(Token = "0x6001816")]
		[Address(RVA = "0x739ECD0", Offset = "0x739ACD0", VA = "0x739ECD0")]
		public string GetUUID()
		{
			return null;
		}

		[Token(Token = "0x6001817")]
		[Address(RVA = "0x739EDF8", Offset = "0x739ADF8", VA = "0x739EDF8")]
		public bool IsWifi()
		{
			return default;
		}

		[Token(Token = "0x6001818")]
		[Address(RVA = "0x739EF20", Offset = "0x739AF20", VA = "0x739EF20")]
		public bool IsRootSystem()
		{
			return default;
		}

		[Token(Token = "0x6001819")]
		[Address(RVA = "0x739CB28", Offset = "0x7398B28", VA = "0x739CB28")]
		public string GetOsCountryCode()
		{
			return null;
		}

		[Token(Token = "0x600181A")]
		[Address(RVA = "0x739F048", Offset = "0x739B048", VA = "0x739F048")]
		public int GetPublishCountryCode()
		{
			return default;
		}

		[Token(Token = "0x600181B")]
		[Address(RVA = "0x739F170", Offset = "0x739B170", VA = "0x739F170")]
		public string GetPhoneInfo()
		{
			return null;
		}

		[Token(Token = "0x600181C")]
		[Address(RVA = "0x739F298", Offset = "0x739B298", VA = "0x739F298")]
		public string GetLocalMacAddress()
		{
			return null;
		}

		[Token(Token = "0x600181D")]
		[Address(RVA = "0x739F3C0", Offset = "0x739B3C0", VA = "0x739F3C0")]
		public string GetIDFA()
		{
			return null;
		}

		[Token(Token = "0x600181E")]
		[Address(RVA = "0x739F5B0", Offset = "0x739B5B0", VA = "0x739F5B0")]
		public string GetAndroidId()
		{
			return null;
		}

		[Token(Token = "0x600181F")]
		[Address(RVA = "0x739F7A8", Offset = "0x739B7A8", VA = "0x739F7A8")]
		public string GetIMEI()
		{
			return null;
		}

		[Token(Token = "0x6001820")]
		[Address(RVA = "0x739F9A0", Offset = "0x739B9A0", VA = "0x739F9A0")]
		public string GetIMSI()
		{
			return null;
		}

		[Token(Token = "0x6001821")]
		[Address(RVA = "0x739FB98", Offset = "0x739BB98", VA = "0x739FB98")]
		public long GetAppBuildTime()
		{
			return default;
		}

		[Token(Token = "0x6001822")]
		[Address(RVA = "0x739FCC0", Offset = "0x739BCC0", VA = "0x739FCC0")]
		public void ShowPreferences()
		{
		}

		[Token(Token = "0x6001823")]
		[Address(RVA = "0x739FDE4", Offset = "0x739BDE4", VA = "0x739FDE4")]
		public int GetSDAvailableSizeStatic()
		{
			return default;
		}

		[Token(Token = "0x6001824")]
		[Address(RVA = "0x739FF0C", Offset = "0x739BF0C", VA = "0x739FF0C")]
		public int GetDesignModeStatic()
		{
			return default;
		}

		[Token(Token = "0x6001825")]
		[Address(RVA = "0x73A0034", Offset = "0x739C034", VA = "0x73A0034")]
		public bool ShowMoreGameStatic()
		{
			return default;
		}

		[Token(Token = "0x6001826")]
		[Address(RVA = "0x739D3F0", Offset = "0x73993F0", VA = "0x739D3F0")]
		public string GetOnlineConfigParams(string param)
		{
			return null;
		}

		[Token(Token = "0x6001827")]
		[Address(RVA = "0x73A015C", Offset = "0x739C15C", VA = "0x73A015C")]
		public string GetOnlineConfigParamsByAppVer(string param)
		{
			return null;
		}

		[Token(Token = "0x6001828")]
		[Address(RVA = "0x73A0290", Offset = "0x739C290", VA = "0x73A0290")]
		public int GetATTrackStateStatic()
		{
			return default;
		}

		[Token(Token = "0x6001829")]
		[Address(RVA = "0x73A0490", Offset = "0x739C490", VA = "0x73A0490")]
		public void ShowAllowedUserATTrackStatic()
		{
		}

		[Token(Token = "0x600182A")]
		[Address(RVA = "0x73A063C", Offset = "0x739C63C", VA = "0x73A063C")]
		public int GetDeviceLocalStatic()
		{
			return default;
		}

		[Token(Token = "0x600182B")]
		[Address(RVA = "0x73A0764", Offset = "0x739C764", VA = "0x73A0764")]
		public void JumpToAppSetting()
		{
		}

		[Token(Token = "0x600182C")]
		[Address(RVA = "0x739C7B8", Offset = "0x73987B8", VA = "0x739C7B8")]
		internal void GetOnlineOsCountryCode()
		{
		}

		[Token(Token = "0x600182D")]
		[Address(RVA = "0x73A0888", Offset = "0x739C888", VA = "0x73A0888")]
		public int GetLocaleLanguageCode()
		{
			return default;
		}

		[Token(Token = "0x600182E")]
		[Address(RVA = "0x73A09B0", Offset = "0x739C9B0", VA = "0x73A09B0")]
		public long GetAppLastLaunchTimeStatic()
		{
			return default;
		}

		[Token(Token = "0x600182F")]
		[Address(RVA = "0x73A0AD8", Offset = "0x739CAD8", VA = "0x73A0AD8")]
		public string GetUmengAppKey()
		{
			return null;
		}

		[Token(Token = "0x6001830")]
		[Address(RVA = "0x73A0C00", Offset = "0x739CC00", VA = "0x73A0C00")]
		public string GetAllOnlineConfigParamsStatic()
		{
			return null;
		}

		[Token(Token = "0x6001831")]
		[Address(RVA = "0x73A0D28", Offset = "0x739CD28", VA = "0x73A0D28")]
		public void OpenPrivacyRecallActStatic()
		{
		}

		[Token(Token = "0x6001832")]
		[Address(RVA = "0x73A0E4C", Offset = "0x739CE4C", VA = "0x73A0E4C")]
		public void JumpToPermissionSettingStatic()
		{
		}

		[Token(Token = "0x6001833")]
		[Address(RVA = "0x73A0F70", Offset = "0x739CF70", VA = "0x73A0F70")]
		public bool ShowPrivacyRecallStatic()
		{
			return default;
		}

		[Token(Token = "0x6001834")]
		[Address(RVA = "0x73A1098", Offset = "0x739D098", VA = "0x73A1098")]
		public int GetLocaleCountryCode()
		{
			return default;
		}

		[Token(Token = "0x6001835")]
		[Address(RVA = "0x739D2BC", Offset = "0x73992BC", VA = "0x739D2BC")]
		internal string GetChannelInfoStatic()
		{
			return null;
		}

		[Token(Token = "0x6001836")]
		[Address(RVA = "0x73A11C0", Offset = "0x739D1C0", VA = "0x73A11C0")]
		public string GetAllOnlineConfigJsonParamsStatic()
		{
			return null;
		}

		[Token(Token = "0x6001837")]
		[Address(RVA = "0x73A12E8", Offset = "0x739D2E8", VA = "0x73A12E8")]
		public bool LinkToWeiboProfileInfo(string eurl)
		{
			return default;
		}

		[Token(Token = "0x6001838")]
		[Address(RVA = "0x739D528", Offset = "0x7399528", VA = "0x739D528")]
		internal bool IsOnlineParamReady()
		{
			return default;
		}

		[Token(Token = "0x6001839")]
		[Address(RVA = "0x73A141C", Offset = "0x739D41C", VA = "0x73A141C")]
		public string GetAppChannelGroup()
		{
			return null;
		}

		[Token(Token = "0x600183A")]
		[Address(RVA = "0x739DA70", Offset = "0x7399A70", VA = "0x739DA70")]
		internal int GetNotchHeightStatic()
		{
			return default;
		}

		[Token(Token = "0x600183B")]
		[Address(RVA = "0x739DB9C", Offset = "0x7399B9C", VA = "0x739DB9C")]
		internal string GetNotchInfoStatic()
		{
			return null;
		}

		[Token(Token = "0x600183C")]
		[Address(RVA = "0x739DCC8", Offset = "0x7399CC8", VA = "0x739DCC8")]
		internal int GetBottomNotchHeightStatic()
		{
			return default;
		}

		[Token(Token = "0x600183D")]
		[Address(RVA = "0x73A1544", Offset = "0x739D544", VA = "0x73A1544")]
		public AppInfoManager()
		{
		}
	}
}
