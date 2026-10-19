using Il2CppDummyDll;
using UnityEngine.UI;

namespace DBTSDK
{
	[Token(Token = "0x20001C6")]
	public abstract class ISDK
	{
		[Token(Token = "0x170000ED")]
		public virtual bool CanReadLocalData
		{
			[Token(Token = "0x600167F")]
			[Address(RVA = "0x7387898", Offset = "0x7383898", VA = "0x7387898", Slot = "298")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6001559")]
		[Address(RVA = "0x73871E8", Offset = "0x73831E8", VA = "0x73871E8", Slot = "4")]
		public virtual string GetPackageName()
		{
			return null;
		}

		[Token(Token = "0x600155A")]
		[Address(RVA = "0x73871F0", Offset = "0x73831F0", VA = "0x73871F0", Slot = "5")]
		public virtual string GetVersionName()
		{
			return null;
		}

		[Token(Token = "0x600155B")]
		[Address(RVA = "0x73871F8", Offset = "0x73831F8", VA = "0x73871F8", Slot = "6")]
		public virtual string GetInstallVersion()
		{
			return null;
		}

		[Token(Token = "0x600155C")]
		[Address(RVA = "0x7387200", Offset = "0x7383200", VA = "0x7387200", Slot = "7")]
		public virtual bool IsInstallVersion()
		{
			return default;
		}

		[Token(Token = "0x600155D")]
		[Address(RVA = "0x7387208", Offset = "0x7383208", VA = "0x7387208", Slot = "8")]
		public virtual string GetAppChannel()
		{
			return null;
		}

		[Token(Token = "0x600155E")]
		[Address(RVA = "0x7387210", Offset = "0x7383210", VA = "0x7387210", Slot = "9")]
		public virtual int GetAppChannelId()
		{
			return default;
		}

		[Token(Token = "0x600155F")]
		[Address(RVA = "0x7387218", Offset = "0x7383218", VA = "0x7387218", Slot = "10")]
		public virtual void SetAppChannelId(int channelId)
		{
		}

		[Token(Token = "0x6001560")]
		[Address(RVA = "0x738721C", Offset = "0x738321C", VA = "0x738721C", Slot = "11")]
		public virtual bool IsFirstStartVer()
		{
			return default;
		}

		[Token(Token = "0x6001561")]
		[Address(RVA = "0x7387224", Offset = "0x7383224", VA = "0x7387224", Slot = "12")]
		public virtual int GetStartNum()
		{
			return default;
		}

		[Token(Token = "0x6001562")]
		[Address(RVA = "0x738722C", Offset = "0x738322C", VA = "0x738722C", Slot = "13")]
		public virtual long GetFirstInstallTime()
		{
			return default;
		}

		[Token(Token = "0x6001563")]
		[Address(RVA = "0x7387234", Offset = "0x7383234", VA = "0x7387234", Slot = "14")]
		public virtual int GetScreenWidth()
		{
			return default;
		}

		[Token(Token = "0x6001564")]
		[Address(RVA = "0x738723C", Offset = "0x738323C", VA = "0x738723C", Slot = "15")]
		public virtual int GetScreenHeight()
		{
			return default;
		}

		[Token(Token = "0x6001565")]
		[Address(RVA = "0x7387244", Offset = "0x7383244", VA = "0x7387244", Slot = "16")]
		public virtual int GetSystemLanguage()
		{
			return default;
		}

		[Token(Token = "0x6001566")]
		[Address(RVA = "0x738724C", Offset = "0x738324C", VA = "0x738724C", Slot = "17")]
		public virtual string GetDeviceId()
		{
			return null;
		}

		[Token(Token = "0x6001567")]
		[Address(RVA = "0x7387254", Offset = "0x7383254", VA = "0x7387254", Slot = "18")]
		public virtual string GetUUID()
		{
			return null;
		}

		[Token(Token = "0x6001568")]
		[Address(RVA = "0x738725C", Offset = "0x738325C", VA = "0x738725C", Slot = "19")]
		public virtual bool IsWifi()
		{
			return default;
		}

		[Token(Token = "0x6001569")]
		[Address(RVA = "0x7387264", Offset = "0x7383264", VA = "0x7387264", Slot = "20")]
		public virtual bool IsRootSystem()
		{
			return default;
		}

		[Token(Token = "0x600156A")]
		[Address(RVA = "0x738726C", Offset = "0x738326C", VA = "0x738726C", Slot = "21")]
		public virtual string GetOsCountryCode()
		{
			return null;
		}

		[Token(Token = "0x600156B")]
		[Address(RVA = "0x7387274", Offset = "0x7383274", VA = "0x7387274", Slot = "22")]
		public virtual int GetPublishCountryCode()
		{
			return default;
		}

		[Token(Token = "0x600156C")]
		[Address(RVA = "0x738727C", Offset = "0x738327C", VA = "0x738727C", Slot = "23")]
		public virtual string GetPhoneInfo()
		{
			return null;
		}

		[Token(Token = "0x600156D")]
		[Address(RVA = "0x7387284", Offset = "0x7383284", VA = "0x7387284", Slot = "24")]
		public virtual string GetLocalMacAddress()
		{
			return null;
		}

		[Token(Token = "0x600156E")]
		[Address(RVA = "0x738728C", Offset = "0x738328C", VA = "0x738728C", Slot = "25")]
		public virtual string GetIDFA()
		{
			return null;
		}

		[Token(Token = "0x600156F")]
		[Address(RVA = "0x7387294", Offset = "0x7383294", VA = "0x7387294", Slot = "26")]
		public virtual string GetAndroidId()
		{
			return null;
		}

		[Token(Token = "0x6001570")]
		[Address(RVA = "0x738729C", Offset = "0x738329C", VA = "0x738729C", Slot = "27")]
		public virtual string GetIMEI()
		{
			return null;
		}

		[Token(Token = "0x6001571")]
		[Address(RVA = "0x73872A4", Offset = "0x73832A4", VA = "0x73872A4", Slot = "28")]
		public virtual string GetIMSI()
		{
			return null;
		}

		[Token(Token = "0x6001572")]
		[Address(RVA = "0x73872AC", Offset = "0x73832AC", VA = "0x73872AC", Slot = "29")]
		public virtual long GetAppBuildTime()
		{
			return default;
		}

		[Token(Token = "0x6001573")]
		[Address(RVA = "0x73872B4", Offset = "0x73832B4", VA = "0x73872B4", Slot = "30")]
		public virtual void ShowPreferences()
		{
		}

		[Token(Token = "0x6001574")]
		[Address(RVA = "0x73872B8", Offset = "0x73832B8", VA = "0x73872B8", Slot = "31")]
		public virtual int GetSDAvailableSizeStatic()
		{
			return default;
		}

		[Token(Token = "0x6001575")]
		[Address(RVA = "0x73872C0", Offset = "0x73832C0", VA = "0x73872C0", Slot = "32")]
		public virtual int GetDesignModeStatic()
		{
			return default;
		}

		[Token(Token = "0x6001576")]
		[Address(RVA = "0x73872C8", Offset = "0x73832C8", VA = "0x73872C8", Slot = "33")]
		public virtual bool ShowMoreGameStatic()
		{
			return default;
		}

		[Token(Token = "0x6001577")]
		[Address(RVA = "0x73872D0", Offset = "0x73832D0", VA = "0x73872D0", Slot = "34")]
		public virtual string GetOnlineConfigParams(string param)
		{
			return null;
		}

		[Token(Token = "0x6001578")]
		[Address(RVA = "0x73872D8", Offset = "0x73832D8", VA = "0x73872D8", Slot = "35")]
		public virtual string GetOnlineConfigParamsByAppVer(string param)
		{
			return null;
		}

		[Token(Token = "0x6001579")]
		[Address(RVA = "0x73872E0", Offset = "0x73832E0", VA = "0x73872E0", Slot = "36")]
		public virtual int GetATTrackStateStatic()
		{
			return default;
		}

		[Token(Token = "0x600157A")]
		[Address(RVA = "0x73872E8", Offset = "0x73832E8", VA = "0x73872E8", Slot = "37")]
		public virtual void ShowAllowedUserATTrackStatic()
		{
		}

		[Token(Token = "0x600157B")]
		[Address(RVA = "0x73872EC", Offset = "0x73832EC", VA = "0x73872EC", Slot = "38")]
		public virtual int GetDeviceLocalStatic()
		{
			return default;
		}

		[Token(Token = "0x600157C")]
		[Address(RVA = "0x73872F4", Offset = "0x73832F4", VA = "0x73872F4", Slot = "39")]
		public virtual void JumpToAppSetting()
		{
		}

		[Token(Token = "0x600157D")]
		[Address(RVA = "0x73872F8", Offset = "0x73832F8", VA = "0x73872F8", Slot = "40")]
		public virtual void GetOnlineOsCountryCode()
		{
		}

		[Token(Token = "0x600157E")]
		[Address(RVA = "0x73872FC", Offset = "0x73832FC", VA = "0x73872FC", Slot = "41")]
		public virtual int GetLocaleLanguageCode()
		{
			return default;
		}

		[Token(Token = "0x600157F")]
		[Address(RVA = "0x7387304", Offset = "0x7383304", VA = "0x7387304", Slot = "42")]
		public virtual long GetAppLastLaunchTimeStatic()
		{
			return default;
		}

		[Token(Token = "0x6001580")]
		[Address(RVA = "0x738730C", Offset = "0x738330C", VA = "0x738730C", Slot = "43")]
		public virtual string GetUmengAppKey()
		{
			return null;
		}

		[Token(Token = "0x6001581")]
		[Address(RVA = "0x7387314", Offset = "0x7383314", VA = "0x7387314", Slot = "44")]
		public virtual string GetAllOnlineConfigParamsStatic()
		{
			return null;
		}

		[Token(Token = "0x6001582")]
		[Address(RVA = "0x738731C", Offset = "0x738331C", VA = "0x738731C", Slot = "45")]
		public virtual void OpenPrivacyRecallActStatic()
		{
		}

		[Token(Token = "0x6001583")]
		[Address(RVA = "0x7387320", Offset = "0x7383320", VA = "0x7387320", Slot = "46")]
		public virtual void JumpToPermissionSettingStatic()
		{
		}

		[Token(Token = "0x6001584")]
		[Address(RVA = "0x7387324", Offset = "0x7383324", VA = "0x7387324", Slot = "47")]
		public virtual bool ShowPrivacyRecallStatic()
		{
			return default;
		}

		[Token(Token = "0x6001585")]
		[Address(RVA = "0x738732C", Offset = "0x738332C", VA = "0x738732C", Slot = "48")]
		public virtual int GetLocaleCountryCode()
		{
			return default;
		}

		[Token(Token = "0x6001586")]
		[Address(RVA = "0x7387334", Offset = "0x7383334", VA = "0x7387334", Slot = "49")]
		public virtual string GetChannelInfoStatic()
		{
			return null;
		}

		[Token(Token = "0x6001587")]
		[Address(RVA = "0x738733C", Offset = "0x738333C", VA = "0x738733C", Slot = "50")]
		public virtual string GetAllOnlineConfigJsonParamsStatic()
		{
			return null;
		}

		[Token(Token = "0x6001588")]
		[Address(RVA = "0x7387344", Offset = "0x7383344", VA = "0x7387344", Slot = "51")]
		public virtual bool LinkToWeiboProfileInfo(string eurl)
		{
			return default;
		}

		[Token(Token = "0x6001589")]
		[Address(RVA = "0x738734C", Offset = "0x738334C", VA = "0x738734C", Slot = "52")]
		public virtual bool IsOnlineParamReady()
		{
			return default;
		}

		[Token(Token = "0x600158A")]
		[Address(RVA = "0x7387354", Offset = "0x7383354", VA = "0x7387354", Slot = "53")]
		public virtual string GetAppChannelGroup()
		{
			return null;
		}

		[Token(Token = "0x600158B")]
		[Address(RVA = "0x738735C", Offset = "0x738335C", VA = "0x738735C", Slot = "54")]
		public virtual int GetNotchHeightStatic()
		{
			return default;
		}

		[Token(Token = "0x600158C")]
		[Address(RVA = "0x7387364", Offset = "0x7383364", VA = "0x7387364", Slot = "55")]
		public virtual string GetNotchInfoStatic()
		{
			return null;
		}

		[Token(Token = "0x600158D")]
		[Address(RVA = "0x738736C", Offset = "0x738336C", VA = "0x738736C", Slot = "56")]
		public virtual int GetBottomNotchHeightStatic()
		{
			return default;
		}

		[Token(Token = "0x600158E")]
		[Address(RVA = "0x7387374", Offset = "0x7383374", VA = "0x7387374", Slot = "57")]
		public virtual void ShowBannerStatic(int pos)
		{
		}

		[Token(Token = "0x600158F")]
		[Address(RVA = "0x7387378", Offset = "0x7383378", VA = "0x7387378", Slot = "58")]
		public virtual void ShowBannerStatic(int pos, bool filterHighMemorySDK)
		{
		}

		[Token(Token = "0x6001590")]
		[Address(RVA = "0x738737C", Offset = "0x738337C", VA = "0x738737C", Slot = "59")]
		public virtual void HideBannerStatic()
		{
		}

		[Token(Token = "0x6001591")]
		[Address(RVA = "0x7387380", Offset = "0x7383380", VA = "0x7387380", Slot = "60")]
		public virtual void ShowInterstitialStatic(string game)
		{
		}

		[Token(Token = "0x6001592")]
		[Address(RVA = "0x7387384", Offset = "0x7383384", VA = "0x7387384", Slot = "61")]
		public virtual bool IsShowVideoStatic()
		{
			return default;
		}

		[Token(Token = "0x6001593")]
		[Address(RVA = "0x738738C", Offset = "0x738338C", VA = "0x738738C", Slot = "62")]
		public virtual bool IsVideoReadyStatic()
		{
			return default;
		}

		[Token(Token = "0x6001594")]
		[Address(RVA = "0x7387394", Offset = "0x7383394", VA = "0x7387394", Slot = "63")]
		public virtual void ShowVideoStatic(int flag)
		{
		}

		[Token(Token = "0x6001595")]
		[Address(RVA = "0x7387398", Offset = "0x7383398", VA = "0x7387398", Slot = "64")]
		public virtual int GetAdsStatusStatic(int scene, int id)
		{
			return default;
		}

		[Token(Token = "0x6001596")]
		[Address(RVA = "0x73873A0", Offset = "0x73833A0", VA = "0x73873A0", Slot = "65")]
		public virtual int ShowAdsStatic(int scene, int id, int[] rootRect, int[] pictureRect, int[] footerRect, int[] titleColor, int[] actionBackgroundColor, int[] actionColor)
		{
			return default;
		}

		[Token(Token = "0x6001597")]
		[Address(RVA = "0x73873A8", Offset = "0x73833A8", VA = "0x73873A8", Slot = "66")]
		public virtual void RemoveAdsWidgetStatic(int index)
		{
		}

		[Token(Token = "0x6001598")]
		[Address(RVA = "0x73873AC", Offset = "0x73833AC", VA = "0x73873AC", Slot = "67")]
		public virtual void SetAdsVisibleStatic(int index, bool visible)
		{
		}

		[Token(Token = "0x6001599")]
		[Address(RVA = "0x73873B0", Offset = "0x73833B0", VA = "0x73873B0", Slot = "68")]
		public virtual void SetRemoveAdsStatic()
		{
		}

		[Token(Token = "0x600159A")]
		[Address(RVA = "0x73873B4", Offset = "0x73833B4", VA = "0x73873B4", Slot = "69")]
		public virtual int GetRemoveAdsState()
		{
			return default;
		}

		[Token(Token = "0x600159B")]
		[Address(RVA = "0x73873BC", Offset = "0x73833BC", VA = "0x73873BC", Slot = "70")]
		public virtual bool IsOpenRemoveAds()
		{
			return default;
		}

		[Token(Token = "0x600159C")]
		[Address(RVA = "0x73873C4", Offset = "0x73833C4", VA = "0x73873C4", Slot = "71")]
		public virtual void SetRestoreAdsStatic()
		{
		}

		[Token(Token = "0x600159D")]
		[Address(RVA = "0x73873C8", Offset = "0x73833C8", VA = "0x73873C8", Slot = "72")]
		public virtual int GetVideoStatus()
		{
			return default;
		}

		[Token(Token = "0x600159E")]
		[Address(RVA = "0x73873D0", Offset = "0x73833D0", VA = "0x73873D0", Slot = "73")]
		public virtual float GetBannerSizeScale(int pos)
		{
			return default;
		}

		[Token(Token = "0x600159F")]
		[Address(RVA = "0x73873D8", Offset = "0x73833D8", VA = "0x73873D8", Slot = "74")]
		public virtual bool DelayShowBigAdsStatic()
		{
			return default;
		}

		[Token(Token = "0x60015A0")]
		[Address(RVA = "0x73873E0", Offset = "0x73833E0", VA = "0x73873E0", Slot = "75")]
		public virtual void RequestGameOverBigAdsStatic()
		{
		}

		[Token(Token = "0x60015A1")]
		[Address(RVA = "0x73873E4", Offset = "0x73833E4", VA = "0x73873E4", Slot = "76")]
		public virtual int GetDrawVideoButtonStatusStatic()
		{
			return default;
		}

		[Token(Token = "0x60015A2")]
		[Address(RVA = "0x73873EC", Offset = "0x73833EC", VA = "0x73873EC", Slot = "77")]
		public virtual void ShowDrawVideoStatic()
		{
		}

		[Token(Token = "0x60015A3")]
		[Address(RVA = "0x73873F0", Offset = "0x73833F0", VA = "0x73873F0", Slot = "78")]
		public virtual bool ShowInterstitialResult(string game, string interName, string mtype)
		{
			return default;
		}

		[Token(Token = "0x60015A4")]
		[Address(RVA = "0x73873F8", Offset = "0x73833F8", VA = "0x73873F8", Slot = "79")]
		public virtual bool IsInterstitialReadyStatic(string game, string mtype)
		{
			return default;
		}

		[Token(Token = "0x60015A5")]
		[Address(RVA = "0x7387400", Offset = "0x7383400", VA = "0x7387400", Slot = "80")]
		public virtual void RequestVideoStatic(int flag)
		{
		}

		[Token(Token = "0x60015A6")]
		[Address(RVA = "0x7387404", Offset = "0x7383404", VA = "0x7387404", Slot = "81")]
		public virtual bool IsCustomVideoReadyStatic(int flag)
		{
			return default;
		}

		[Token(Token = "0x60015A7")]
		[Address(RVA = "0x738740C", Offset = "0x738340C", VA = "0x738740C", Slot = "82")]
		public virtual void SetRemoveVideoAdsStatic()
		{
		}

		[Token(Token = "0x60015A8")]
		[Address(RVA = "0x7387410", Offset = "0x7383410", VA = "0x7387410", Slot = "83")]
		public virtual int GetRemoveVideoAdsState()
		{
			return default;
		}

		[Token(Token = "0x60015A9")]
		[Address(RVA = "0x7387418", Offset = "0x7383418", VA = "0x7387418", Slot = "84")]
		public virtual void SetRestoreVideoAdsStatic()
		{
		}

		[Token(Token = "0x60015AA")]
		[Address(RVA = "0x738741C", Offset = "0x738341C", VA = "0x738741C", Slot = "85")]
		public virtual bool IsVideoDefaultShowStatic()
		{
			return default;
		}

		[Token(Token = "0x60015AB")]
		[Address(RVA = "0x7387424", Offset = "0x7383424", VA = "0x7387424", Slot = "86")]
		public virtual void ShowIconAds()
		{
		}

		[Token(Token = "0x60015AC")]
		[Address(RVA = "0x7387428", Offset = "0x7383428", VA = "0x7387428", Slot = "87")]
		public virtual void AdsGameAdStatusCallBack(string upType, string pid, string revenue)
		{
		}

		[Token(Token = "0x60015AD")]
		[Address(RVA = "0x738742C", Offset = "0x738342C", VA = "0x738742C", Slot = "88")]
		public virtual void ShowNatGameAd(float topX, float topY, float maxWith, float maxHeight)
		{
		}

		[Token(Token = "0x60015AE")]
		[Address(RVA = "0x7387430", Offset = "0x7383430", VA = "0x7387430", Slot = "89")]
		public virtual void HideNatGameAd()
		{
		}

		[Token(Token = "0x60015AF")]
		[Address(RVA = "0x7387434", Offset = "0x7383434", VA = "0x7387434", Slot = "90")]
		public virtual string GetRewardAd()
		{
			return null;
		}

		[Token(Token = "0x60015B0")]
		[Address(RVA = "0x738743C", Offset = "0x738343C", VA = "0x738743C", Slot = "91")]
		public virtual void OnEvent(string event_id, string label)
		{
		}

		[Token(Token = "0x60015B1")]
		[Address(RVA = "0x7387440", Offset = "0x7383440", VA = "0x7387440", Slot = "92")]
		public virtual void OnEvent(string event_id, string label, int n)
		{
		}

		[Token(Token = "0x60015B2")]
		[Address(RVA = "0x7387444", Offset = "0x7383444", VA = "0x7387444", Slot = "93")]
		public virtual void OnEventDuration(string event_id, int ms)
		{
		}

		[Token(Token = "0x60015B3")]
		[Address(RVA = "0x7387448", Offset = "0x7383448", VA = "0x7387448", Slot = "94")]
		public virtual void OnEventDuration(string event_id, string label, int ms)
		{
		}

		[Token(Token = "0x60015B4")]
		[Address(RVA = "0x738744C", Offset = "0x738344C", VA = "0x738744C", Slot = "95")]
		public virtual void OnEventOnlyOnce(string event_id, string label)
		{
		}

		[Token(Token = "0x60015B5")]
		[Address(RVA = "0x7387450", Offset = "0x7383450", VA = "0x7387450", Slot = "96")]
		public virtual void OnEventOnlyOnce(string event_id, string label, int n)
		{
		}

		[Token(Token = "0x60015B6")]
		[Address(RVA = "0x7387454", Offset = "0x7383454", VA = "0x7387454", Slot = "97")]
		public virtual void TrackVideoStatic(int type)
		{
		}

		[Token(Token = "0x60015B7")]
		[Address(RVA = "0x7387458", Offset = "0x7383458", VA = "0x7387458", Slot = "98")]
		public virtual void OnEventHomeApp()
		{
		}

		[Token(Token = "0x60015B8")]
		[Address(RVA = "0x738745C", Offset = "0x738345C", VA = "0x738745C", Slot = "99")]
		public virtual void OnNewEvent(string eventId)
		{
		}

		[Token(Token = "0x60015B9")]
		[Address(RVA = "0x7387460", Offset = "0x7383460", VA = "0x7387460", Slot = "100")]
		public virtual void OnNewEvent(string eventId, string jsonProperties)
		{
		}

		[Token(Token = "0x60015BA")]
		[Address(RVA = "0x7387464", Offset = "0x7383464", VA = "0x7387464", Slot = "101")]
		public virtual void OnNewEventOnlyOnce(string eventId)
		{
		}

		[Token(Token = "0x60015BB")]
		[Address(RVA = "0x7387468", Offset = "0x7383468", VA = "0x7387468", Slot = "102")]
		public virtual void OnNewEventOnlyOnce(string eventId, string jsonProperties)
		{
		}

		[Token(Token = "0x60015BC")]
		[Address(RVA = "0x738746C", Offset = "0x738346C", VA = "0x738746C", Slot = "103")]
		public virtual void OnNewEventToGravity(string eventId, string jsonProperties)
		{
		}

		[Token(Token = "0x60015BD")]
		[Address(RVA = "0x7387470", Offset = "0x7383470", VA = "0x7387470", Slot = "104")]
		public virtual void OnNewEventToApplovin(string eventId, string jsonProperties)
		{
		}

		[Token(Token = "0x60015BE")]
		[Address(RVA = "0x7387474", Offset = "0x7383474", VA = "0x7387474", Slot = "105")]
		public virtual bool IsShowShare()
		{
			return default;
		}

		[Token(Token = "0x60015BF")]
		[Address(RVA = "0x738747C", Offset = "0x738347C", VA = "0x738747C", Slot = "106")]
		public virtual int GetShareMode()
		{
			return default;
		}

		[Token(Token = "0x60015C0")]
		[Address(RVA = "0x7387484", Offset = "0x7383484", VA = "0x7387484", Slot = "107")]
		public virtual void ShareImage(string title, string content, string url, string imgFile)
		{
		}

		[Token(Token = "0x60015C1")]
		[Address(RVA = "0x7387488", Offset = "0x7383488", VA = "0x7387488", Slot = "108")]
		public virtual void ShareText(string title, string content, string url)
		{
		}

		[Token(Token = "0x60015C2")]
		[Address(RVA = "0x738748C", Offset = "0x738348C", VA = "0x738748C", Slot = "109")]
		public virtual string GetShareUrl()
		{
			return null;
		}

		[Token(Token = "0x60015C3")]
		[Address(RVA = "0x7387494", Offset = "0x7383494", VA = "0x7387494", Slot = "110")]
		public virtual void ShareApp(int Sharetype, string title, string content, string imgFile, string[] Args, int count)
		{
		}

		[Token(Token = "0x60015C4")]
		[Address(RVA = "0x7387498", Offset = "0x7383498", VA = "0x7387498", Slot = "111")]
		public virtual bool ShowLogin()
		{
			return default;
		}

		[Token(Token = "0x60015C5")]
		[Address(RVA = "0x73874A0", Offset = "0x73834A0", VA = "0x73874A0", Slot = "112")]
		public virtual void LoginComStatic(int inOrOut)
		{
		}

		[Token(Token = "0x60015C6")]
		[Address(RVA = "0x73874A4", Offset = "0x73834A4", VA = "0x73874A4", Slot = "113")]
		public virtual bool IsShowFeedback()
		{
			return default;
		}

		[Token(Token = "0x60015C7")]
		[Address(RVA = "0x73874AC", Offset = "0x73834AC", VA = "0x73874AC", Slot = "114")]
		public virtual void ShowFeedback()
		{
		}

		[Token(Token = "0x60015C8")]
		[Address(RVA = "0x73874B0", Offset = "0x73834B0", VA = "0x73874B0", Slot = "115")]
		public virtual void ShowUpdateDalogStatic()
		{
		}

		[Token(Token = "0x60015C9")]
		[Address(RVA = "0x73874B4", Offset = "0x73834B4", VA = "0x73874B4", Slot = "116")]
		public virtual bool IsRequestLocationInEeaOrUnknownStatic()
		{
			return default;
		}

		[Token(Token = "0x60015CA")]
		[Address(RVA = "0x73874BC", Offset = "0x73834BC", VA = "0x73874BC", Slot = "117")]
		public virtual void ShowGDPRDialogStatic()
		{
		}

		[Token(Token = "0x60015CB")]
		[Address(RVA = "0x73874C0", Offset = "0x73834C0", VA = "0x73874C0", Slot = "118")]
		public virtual bool IsShowEvaluate()
		{
			return default;
		}

		[Token(Token = "0x60015CC")]
		[Address(RVA = "0x73874C8", Offset = "0x73834C8", VA = "0x73874C8", Slot = "119")]
		public virtual int GetEvaluateMode()
		{
			return default;
		}

		[Token(Token = "0x60015CD")]
		[Address(RVA = "0x73874D0", Offset = "0x73834D0", VA = "0x73874D0", Slot = "120")]
		public virtual void ShowEvaluate()
		{
		}

		[Token(Token = "0x60015CE")]
		[Address(RVA = "0x73874D4", Offset = "0x73834D4", VA = "0x73874D4", Slot = "121")]
		public virtual void CheckNeedCertification()
		{
		}

		[Token(Token = "0x60015CF")]
		[Address(RVA = "0x73874D8", Offset = "0x73834D8", VA = "0x73874D8", Slot = "122")]
		public virtual void ShowCertification()
		{
		}

		[Token(Token = "0x60015D0")]
		[Address(RVA = "0x73874DC", Offset = "0x73834DC", VA = "0x73874DC", Slot = "123")]
		public virtual int LoginServerStateStatic()
		{
			return default;
		}

		[Token(Token = "0x60015D1")]
		[Address(RVA = "0x73874E4", Offset = "0x73834E4", VA = "0x73874E4", Slot = "124")]
		public virtual void LoginAppServerStatic()
		{
		}

		[Token(Token = "0x60015D2")]
		[Address(RVA = "0x73874E8", Offset = "0x73834E8", VA = "0x73874E8", Slot = "125")]
		public virtual void LoginUploadUserDataStatic(string keyInfo, string valueInfo)
		{
		}

		[Token(Token = "0x60015D3")]
		[Address(RVA = "0x73874EC", Offset = "0x73834EC", VA = "0x73874EC", Slot = "126")]
		public virtual void LoginGetUserDataStatic(string keyInfo)
		{
		}

		[Token(Token = "0x60015D4")]
		[Address(RVA = "0x73874F0", Offset = "0x73834F0", VA = "0x73874F0", Slot = "127")]
		public virtual string LoginGetCurrentUserInfo()
		{
			return null;
		}

		[Token(Token = "0x60015D5")]
		[Address(RVA = "0x73874F8", Offset = "0x73834F8", VA = "0x73874F8", Slot = "128")]
		public virtual void LoginDismissDialog()
		{
		}

		[Token(Token = "0x60015D6")]
		[Address(RVA = "0x73874FC", Offset = "0x73834FC", VA = "0x73874FC", Slot = "129")]
		public virtual int GetUnderAgeLimitLevelStatic()
		{
			return default;
		}

		[Token(Token = "0x60015D7")]
		[Address(RVA = "0x7387504", Offset = "0x7383504", VA = "0x7387504", Slot = "130")]
		public virtual void ShowEligibleAgeAlertStatic()
		{
		}

		[Token(Token = "0x60015D8")]
		[Address(RVA = "0x7387508", Offset = "0x7383508", VA = "0x7387508", Slot = "131")]
		public virtual void GameShareDynamicLinks(string aJson)
		{
		}

		[Token(Token = "0x60015D9")]
		[Address(RVA = "0x738750C", Offset = "0x738350C", VA = "0x738750C", Slot = "132")]
		public virtual string GameGetCurDynamicLinks()
		{
			return null;
		}

		[Token(Token = "0x60015DA")]
		[Address(RVA = "0x7387514", Offset = "0x7383514", VA = "0x7387514", Slot = "133")]
		public virtual bool IsShowForeignPolicy()
		{
			return default;
		}

		[Token(Token = "0x60015DB")]
		[Address(RVA = "0x738751C", Offset = "0x738351C", VA = "0x738751C", Slot = "134")]
		public virtual void GotoPrivacyPolicyForeignStatic()
		{
		}

		[Token(Token = "0x60015DC")]
		[Address(RVA = "0x7387520", Offset = "0x7383520", VA = "0x7387520", Slot = "135")]
		public virtual void GotoTermsServiceForeignStatic()
		{
		}

		[Token(Token = "0x60015DD")]
		[Address(RVA = "0x7387524", Offset = "0x7383524", VA = "0x7387524", Slot = "136")]
		public virtual void DoAccountLoginOffStatic()
		{
		}

		[Token(Token = "0x60015DE")]
		[Address(RVA = "0x7387528", Offset = "0x7383528", VA = "0x7387528", Slot = "137")]
		public virtual void DoAccountLoginOffSuccessStatic()
		{
		}

		[Token(Token = "0x60015DF")]
		[Address(RVA = "0x738752C", Offset = "0x738352C", VA = "0x738752C", Slot = "138")]
		public virtual void ServerLoginShowUserCenterStatic()
		{
		}

		[Token(Token = "0x60015E0")]
		[Address(RVA = "0x7387530", Offset = "0x7383530", VA = "0x7387530", Slot = "139")]
		public virtual void ServerLoginAppStatic()
		{
		}

		[Token(Token = "0x60015E1")]
		[Address(RVA = "0x7387534", Offset = "0x7383534", VA = "0x7387534", Slot = "140")]
		public virtual void ServerLoginAppOtherTypeStatic(int atype)
		{
		}

		[Token(Token = "0x60015E2")]
		[Address(RVA = "0x7387538", Offset = "0x7383538", VA = "0x7387538", Slot = "141")]
		public virtual string ServerLoginSupportItemInfoStatic()
		{
			return null;
		}

		[Token(Token = "0x60015E3")]
		[Address(RVA = "0x7387540", Offset = "0x7383540", VA = "0x7387540", Slot = "142")]
		public virtual void ServerNoUiLoginAppStatic(string atype, string openId, string unionPassword)
		{
		}

		[Token(Token = "0x60015E4")]
		[Address(RVA = "0x7387544", Offset = "0x7383544", VA = "0x7387544", Slot = "143")]
		public virtual void ServerLoginGetUnionCodeStatic(string atype, string enumber)
		{
		}

		[Token(Token = "0x60015E5")]
		[Address(RVA = "0x7387548", Offset = "0x7383548", VA = "0x7387548", Slot = "144")]
		public virtual void ServerLoginExitStatic()
		{
		}

		[Token(Token = "0x60015E6")]
		[Address(RVA = "0x738754C", Offset = "0x738354C", VA = "0x738754C", Slot = "145")]
		public virtual int ServerLoginStateStatic()
		{
			return default;
		}

		[Token(Token = "0x60015E7")]
		[Address(RVA = "0x7387554", Offset = "0x7383554", VA = "0x7387554", Slot = "146")]
		public virtual string ServerLoginGetUserInfoStatic()
		{
			return null;
		}

		[Token(Token = "0x60015E8")]
		[Address(RVA = "0x738755C", Offset = "0x738355C", VA = "0x738755C", Slot = "147")]
		public virtual void SetFirebaseUserPropertyStatic(string key, string value)
		{
		}

		[Token(Token = "0x60015E9")]
		[Address(RVA = "0x7387560", Offset = "0x7383560", VA = "0x7387560", Slot = "148")]
		public virtual void SetUserPropertyStatic(string ekey, string evalue)
		{
		}

		[Token(Token = "0x60015EA")]
		[Address(RVA = "0x7387564", Offset = "0x7383564", VA = "0x7387564", Slot = "149")]
		public virtual void ServerNoUiLoginSwitchAccount(string atype, string openId, string unionPassword)
		{
		}

		[Token(Token = "0x60015EB")]
		[Address(RVA = "0x7387568", Offset = "0x7383568", VA = "0x7387568", Slot = "150")]
		public virtual void SetCertification(int status)
		{
		}

		[Token(Token = "0x60015EC")]
		[Address(RVA = "0x738756C", Offset = "0x738356C", VA = "0x738756C", Slot = "151")]
		public virtual void ShowCertificationDialog()
		{
		}

		[Token(Token = "0x60015ED")]
		[Address(RVA = "0x7387570", Offset = "0x7383570", VA = "0x7387570", Slot = "152")]
		public virtual void ServerLoginClearInfoStatic()
		{
		}

		[Token(Token = "0x60015EE")]
		[Address(RVA = "0x7387574", Offset = "0x7383574", VA = "0x7387574", Slot = "153")]
		public virtual string GetUatt()
		{
			return null;
		}

		[Token(Token = "0x60015EF")]
		[Address(RVA = "0x738757C", Offset = "0x738357C", VA = "0x738757C", Slot = "154")]
		public virtual void GetGameCenterStatusStatic()
		{
		}

		[Token(Token = "0x60015F0")]
		[Address(RVA = "0x7387580", Offset = "0x7383580", VA = "0x7387580", Slot = "155")]
		public virtual void SubmitScoreToGameCenterStatic(string leaderboardID, int score)
		{
		}

		[Token(Token = "0x60015F1")]
		[Address(RVA = "0x7387584", Offset = "0x7383584", VA = "0x7387584", Slot = "156")]
		public virtual void ShowGameCenterLeaderboardStatic(string leaderboardID)
		{
		}

		[Token(Token = "0x60015F2")]
		[Address(RVA = "0x7387588", Offset = "0x7383588", VA = "0x7387588", Slot = "157")]
		public virtual void SubmitAchievementToGameCenterStatic(string achievementID, float percent)
		{
		}

		[Token(Token = "0x60015F3")]
		[Address(RVA = "0x738758C", Offset = "0x738358C", VA = "0x738758C", Slot = "158")]
		public virtual void ShowGameCenterAchievementStatic(string achievementID)
		{
		}

		[Token(Token = "0x60015F4")]
		[Address(RVA = "0x7387590", Offset = "0x7383590", VA = "0x7387590", Slot = "159")]
		public virtual void GetGameCenterScoreListStatic(string leaderboardID, int timeScopeType)
		{
		}

		[Token(Token = "0x60015F5")]
		[Address(RVA = "0x7387594", Offset = "0x7383594", VA = "0x7387594", Slot = "160")]
		public virtual string GetAttributionData()
		{
			return null;
		}

		[Token(Token = "0x60015F6")]
		[Address(RVA = "0x738759C", Offset = "0x738359C", VA = "0x738759C", Slot = "161")]
		public virtual void PreloadRecommend()
		{
		}

		[Token(Token = "0x60015F7")]
		[Address(RVA = "0x73875A0", Offset = "0x73835A0", VA = "0x73875A0", Slot = "162")]
		public virtual void ShowRecommend()
		{
		}

		[Token(Token = "0x60015F8")]
		[Address(RVA = "0x73875A4", Offset = "0x73835A4", VA = "0x73875A4", Slot = "163")]
		public virtual void GameServiceSignIn()
		{
		}

		[Token(Token = "0x60015F9")]
		[Address(RVA = "0x73875A8", Offset = "0x73835A8", VA = "0x73875A8", Slot = "164")]
		public virtual void GameServiceUnlockAchievements(int atype, string achievementID, int percent)
		{
		}

		[Token(Token = "0x60015FA")]
		[Address(RVA = "0x73875AC", Offset = "0x73835AC", VA = "0x73875AC", Slot = "165")]
		public virtual void GameServiceShowAchievements()
		{
		}

		[Token(Token = "0x60015FB")]
		[Address(RVA = "0x73875B0", Offset = "0x73835B0", VA = "0x73875B0", Slot = "166")]
		public virtual bool GameServiceIsShowAchievements()
		{
			return default;
		}

		[Token(Token = "0x60015FC")]
		[Address(RVA = "0x73875B8", Offset = "0x73835B8", VA = "0x73875B8", Slot = "167")]
		public virtual void VibrateStatic(long milliseconds, int shakeLevel)
		{
		}

		[Token(Token = "0x60015FD")]
		[Address(RVA = "0x73875BC", Offset = "0x73835BC", VA = "0x73875BC", Slot = "168")]
		public virtual void ShowToast(string msg)
		{
		}

		[Token(Token = "0x60015FE")]
		[Address(RVA = "0x73875C0", Offset = "0x73835C0", VA = "0x73875C0", Slot = "169")]
		public virtual void ShowExitDialog()
		{
		}

		[Token(Token = "0x60015FF")]
		[Address(RVA = "0x73875C4", Offset = "0x73835C4", VA = "0x73875C4", Slot = "170")]
		public virtual void OpenUrl(string url)
		{
		}

		[Token(Token = "0x6001600")]
		[Address(RVA = "0x73875C8", Offset = "0x73835C8", VA = "0x73875C8", Slot = "171")]
		public virtual void CopyMsgToClipboard(string msg)
		{
		}

		[Token(Token = "0x6001601")]
		[Address(RVA = "0x73875CC", Offset = "0x73835CC", VA = "0x73875CC", Slot = "172")]
		public virtual string GetClipboardMsg()
		{
			return null;
		}

		[Token(Token = "0x6001602")]
		[Address(RVA = "0x73875D4", Offset = "0x73835D4", VA = "0x73875D4", Slot = "173")]
		public virtual void Copy2SystemDCIM(string copyFile)
		{
		}

		[Token(Token = "0x6001603")]
		[Address(RVA = "0x73875D8", Offset = "0x73835D8", VA = "0x73875D8", Slot = "174")]
		public virtual void GotoAppStore(string packageName)
		{
		}

		[Token(Token = "0x6001604")]
		[Address(RVA = "0x73875DC", Offset = "0x73835DC", VA = "0x73875DC", Slot = "175")]
		public virtual string GetNetworkTypeStatic()
		{
			return null;
		}

		[Token(Token = "0x6001605")]
		[Address(RVA = "0x73875E4", Offset = "0x73835E4", VA = "0x73875E4", Slot = "176")]
		public virtual bool IsShowPolicy()
		{
			return default;
		}

		[Token(Token = "0x6001606")]
		[Address(RVA = "0x73875EC", Offset = "0x73835EC", VA = "0x73875EC", Slot = "177")]
		public virtual void GotoTermsServiceStatic()
		{
		}

		[Token(Token = "0x6001607")]
		[Address(RVA = "0x73875F0", Offset = "0x73835F0", VA = "0x73875F0", Slot = "178")]
		public virtual void GotoPrivacyPolicyStatic()
		{
		}

		[Token(Token = "0x6001608")]
		[Address(RVA = "0x73875F4", Offset = "0x73835F4", VA = "0x73875F4", Slot = "179")]
		public virtual void OpenApp(int id)
		{
		}

		[Token(Token = "0x6001609")]
		[Address(RVA = "0x73875F8", Offset = "0x73835F8", VA = "0x73875F8", Slot = "180")]
		public virtual bool IsAppInstalled(int id)
		{
			return default;
		}

		[Token(Token = "0x600160A")]
		[Address(RVA = "0x7387600", Offset = "0x7383600", VA = "0x7387600", Slot = "181")]
		public virtual bool IsShowRealNameRegistration()
		{
			return default;
		}

		[Token(Token = "0x600160B")]
		[Address(RVA = "0x7387608", Offset = "0x7383608", VA = "0x7387608", Slot = "182")]
		public virtual bool IsShowContactInformation()
		{
			return default;
		}

		[Token(Token = "0x600160C")]
		[Address(RVA = "0x7387610", Offset = "0x7383610", VA = "0x7387610", Slot = "183")]
		public virtual int GetDurationTimeStatic()
		{
			return default;
		}

		[Token(Token = "0x600160D")]
		[Address(RVA = "0x7387618", Offset = "0x7383618", VA = "0x7387618", Slot = "184")]
		public virtual bool OnlineResStatic()
		{
			return default;
		}

		[Token(Token = "0x600160E")]
		[Address(RVA = "0x7387620", Offset = "0x7383620", VA = "0x7387620", Slot = "185")]
		public virtual void U3DGameStart()
		{
		}

		[Token(Token = "0x600160F")]
		[Address(RVA = "0x7387624", Offset = "0x7383624", VA = "0x7387624", Slot = "186")]
		public virtual void PreloadEffect(string path)
		{
		}

		[Token(Token = "0x6001610")]
		[Address(RVA = "0x7387628", Offset = "0x7383628", VA = "0x7387628", Slot = "187")]
		public virtual int PlayEffect(string path, bool isLoop)
		{
			return default;
		}

		[Token(Token = "0x6001611")]
		[Address(RVA = "0x7387630", Offset = "0x7383630", VA = "0x7387630", Slot = "188")]
		public virtual int PlayEffect(string path, bool isLoop, float pitch, float pan, float gain)
		{
			return default;
		}

		[Token(Token = "0x6001612")]
		[Address(RVA = "0x7387638", Offset = "0x7383638", VA = "0x7387638", Slot = "189")]
		public virtual void PauseEffect(int soundId)
		{
		}

		[Token(Token = "0x6001613")]
		[Address(RVA = "0x738763C", Offset = "0x738363C", VA = "0x738763C", Slot = "190")]
		public virtual void ResumeEffect(int soundId)
		{
		}

		[Token(Token = "0x6001614")]
		[Address(RVA = "0x7387640", Offset = "0x7383640", VA = "0x7387640", Slot = "191")]
		public virtual void StopEffect(int soundId)
		{
		}

		[Token(Token = "0x6001615")]
		[Address(RVA = "0x7387644", Offset = "0x7383644", VA = "0x7387644", Slot = "192")]
		public virtual float GetEffectsVolume()
		{
			return default;
		}

		[Token(Token = "0x6001616")]
		[Address(RVA = "0x738764C", Offset = "0x738364C", VA = "0x738764C", Slot = "193")]
		public virtual void SetEffectsVolume(float volume)
		{
		}

		[Token(Token = "0x6001617")]
		[Address(RVA = "0x7387650", Offset = "0x7383650", VA = "0x7387650", Slot = "194")]
		public virtual void UnloadEffect(string path)
		{
		}

		[Token(Token = "0x6001618")]
		[Address(RVA = "0x7387654", Offset = "0x7383654", VA = "0x7387654", Slot = "195")]
		public virtual void PauseAllEffects()
		{
		}

		[Token(Token = "0x6001619")]
		[Address(RVA = "0x7387658", Offset = "0x7383658", VA = "0x7387658", Slot = "196")]
		public virtual void ResumeAllEffects()
		{
		}

		[Token(Token = "0x600161A")]
		[Address(RVA = "0x738765C", Offset = "0x738365C", VA = "0x738765C", Slot = "197")]
		public virtual void StopAllEffects()
		{
		}

		[Token(Token = "0x600161B")]
		[Address(RVA = "0x7387660", Offset = "0x7383660", VA = "0x7387660", Slot = "198")]
		public virtual void SetAudioFocus(bool isAudioFocus)
		{
		}

		[Token(Token = "0x600161C")]
		[Address(RVA = "0x7387664", Offset = "0x7383664", VA = "0x7387664", Slot = "199")]
		public virtual void End()
		{
		}

		[Token(Token = "0x600161D")]
		[Address(RVA = "0x7387668", Offset = "0x7383668", VA = "0x7387668", Slot = "200")]
		public virtual int GetDaysByFirstLaunch()
		{
			return default;
		}

		[Token(Token = "0x600161E")]
		[Address(RVA = "0x7387670", Offset = "0x7383670", VA = "0x7387670", Slot = "201")]
		public virtual bool IsDebugVersion()
		{
			return default;
		}

		[Token(Token = "0x600161F")]
		[Address(RVA = "0x7387678", Offset = "0x7383678", VA = "0x7387678", Slot = "202")]
		public virtual int GetGameBanHaoType()
		{
			return default;
		}

		[Token(Token = "0x6001620")]
		[Address(RVA = "0x7387680", Offset = "0x7383680", VA = "0x7387680", Slot = "203")]
		public virtual void ShowGameBanHao()
		{
		}

		[Token(Token = "0x6001621")]
		[Address(RVA = "0x7387684", Offset = "0x7383684", VA = "0x7387684", Slot = "204")]
		public virtual string CreateQRcodeSyncStatic(string content, int widthPix, int heightPix, int padding)
		{
			return null;
		}

		[Token(Token = "0x6001622")]
		[Address(RVA = "0x738768C", Offset = "0x738368C", VA = "0x738768C", Slot = "205")]
		public virtual void CreateQRcodeAsyncStatic(string content, int widthPix, int heightPix, int padding)
		{
		}

		[Token(Token = "0x6001623")]
		[Address(RVA = "0x7387690", Offset = "0x7383690", VA = "0x7387690", Slot = "206")]
		public virtual string CheckSensitiveWord(string content)
		{
			return null;
		}

		[Token(Token = "0x6001624")]
		[Address(RVA = "0x7387698", Offset = "0x7383698", VA = "0x7387698", Slot = "207")]
		public virtual void ShowUnionGameStatic(int gameType, string gameName)
		{
		}

		[Token(Token = "0x6001625")]
		[Address(RVA = "0x738769C", Offset = "0x738369C", VA = "0x738769C", Slot = "208")]
		public virtual void GoUnionGameHomeStatic()
		{
		}

		[Token(Token = "0x6001626")]
		[Address(RVA = "0x73876A0", Offset = "0x73836A0", VA = "0x73876A0", Slot = "209")]
		public virtual int GetGameHomePageEngineStatic()
		{
			return default;
		}

		[Token(Token = "0x6001627")]
		[Address(RVA = "0x73876A8", Offset = "0x73836A8", VA = "0x73876A8", Slot = "210")]
		public virtual int IsAllowedUserNotificationStatic()
		{
			return default;
		}

		[Token(Token = "0x6001628")]
		[Address(RVA = "0x73876B0", Offset = "0x73836B0", VA = "0x73876B0", Slot = "211")]
		public virtual void ShowAllowedUserNotificationStatic()
		{
		}

		[Token(Token = "0x6001629")]
		[Address(RVA = "0x73876B4", Offset = "0x73836B4", VA = "0x73876B4", Slot = "212")]
		public virtual void CancelUserNotificationInfoStatic()
		{
		}

		[Token(Token = "0x600162A")]
		[Address(RVA = "0x73876B8", Offset = "0x73836B8", VA = "0x73876B8", Slot = "213")]
		public virtual void CreateUserNotificationInfoStatic(string title, string content, string dateStr, int type)
		{
		}

		[Token(Token = "0x600162B")]
		[Address(RVA = "0x73876BC", Offset = "0x73836BC", VA = "0x73876BC", Slot = "214")]
		public virtual void CreateBadgeNumberNotificationInfoStatic(string dateStr)
		{
		}

		[Token(Token = "0x600162C")]
		[Address(RVA = "0x73876C0", Offset = "0x73836C0", VA = "0x73876C0", Slot = "215")]
		public virtual string GetPreviousVersion()
		{
			return null;
		}

		[Token(Token = "0x600162D")]
		[Address(RVA = "0x73876C8", Offset = "0x73836C8", VA = "0x73876C8", Slot = "216")]
		public virtual int GetNetworkingStateStatic()
		{
			return default;
		}

		[Token(Token = "0x600162E")]
		[Address(RVA = "0x73876D0", Offset = "0x73836D0", VA = "0x73876D0", Slot = "217")]
		public virtual string GetShiLingTiShiStatic()
		{
			return null;
		}

		[Token(Token = "0x600162F")]
		[Address(RVA = "0x73876D8", Offset = "0x73836D8", VA = "0x73876D8", Slot = "218")]
		public virtual void SetAppDebugStatic(int debug)
		{
		}

		[Token(Token = "0x6001630")]
		[Address(RVA = "0x73876DC", Offset = "0x73836DC", VA = "0x73876DC", Slot = "219")]
		public virtual int GetAppDebugStatic(int debugLevel)
		{
			return default;
		}

		[Token(Token = "0x6001631")]
		[Address(RVA = "0x73876E4", Offset = "0x73836E4", VA = "0x73876E4", Slot = "220")]
		public virtual bool CanShowOppoGameCenterStatic()
		{
			return default;
		}

		[Token(Token = "0x6001632")]
		[Address(RVA = "0x73876EC", Offset = "0x73836EC", VA = "0x73876EC", Slot = "221")]
		public virtual void OpenOppoGameCenterStatic()
		{
		}

		[Token(Token = "0x6001633")]
		[Address(RVA = "0x73876F0", Offset = "0x73836F0", VA = "0x73876F0", Slot = "222")]
		public virtual int GetKeyboardHeightStatic()
		{
			return default;
		}

		[Token(Token = "0x6001634")]
		[Address(RVA = "0x73876F8", Offset = "0x73836F8", VA = "0x73876F8", Slot = "223")]
		public virtual int GetPhotoCameraAuthorizationStateStatic(int ptype)
		{
			return default;
		}

		[Token(Token = "0x6001635")]
		[Address(RVA = "0x7387700", Offset = "0x7383700", VA = "0x7387700", Slot = "224")]
		public virtual void ShowPhotoCameraAuthorizationStatic(int ptype)
		{
		}

		[Token(Token = "0x6001636")]
		[Address(RVA = "0x7387704", Offset = "0x7383704", VA = "0x7387704", Slot = "225")]
		public virtual long GetServerTimeByServerTimeZoneStatic()
		{
			return default;
		}

		[Token(Token = "0x6001637")]
		[Address(RVA = "0x738770C", Offset = "0x738370C", VA = "0x738770C", Slot = "226")]
		public virtual int GetAppInfoPageVersion()
		{
			return default;
		}

		[Token(Token = "0x6001638")]
		[Address(RVA = "0x7387714", Offset = "0x7383714", VA = "0x7387714", Slot = "227")]
		public virtual void DownloadGoogleAsset(string moduleName)
		{
		}

		[Token(Token = "0x6001639")]
		[Address(RVA = "0x7387718", Offset = "0x7383718", VA = "0x7387718", Slot = "228")]
		public virtual string GetGoogleAssetPath(string moduleName)
		{
			return null;
		}

		[Token(Token = "0x600163A")]
		[Address(RVA = "0x7387720", Offset = "0x7383720", VA = "0x7387720", Slot = "229")]
		public virtual void GameShowDelayNotify(string jsonStr)
		{
		}

		[Token(Token = "0x600163B")]
		[Address(RVA = "0x7387724", Offset = "0x7383724", VA = "0x7387724", Slot = "230")]
		public virtual void GameClearLocalNotify(string notifyId)
		{
		}

		[Token(Token = "0x600163C")]
		[Address(RVA = "0x7387728", Offset = "0x7383728", VA = "0x7387728", Slot = "231")]
		public virtual bool GameGetNotificationOpenState()
		{
			return default;
		}

		[Token(Token = "0x600163D")]
		[Address(RVA = "0x7387730", Offset = "0x7383730", VA = "0x7387730", Slot = "232")]
		public virtual string GetGlobeIntent()
		{
			return null;
		}

		[Token(Token = "0x600163E")]
		[Address(RVA = "0x7387738", Offset = "0x7383738", VA = "0x7387738", Slot = "233")]
		public virtual bool IsPocoTestStatic()
		{
			return default;
		}

		[Token(Token = "0x600163F")]
		[Address(RVA = "0x7387740", Offset = "0x7383740", VA = "0x7387740", Slot = "234")]
		public virtual void SetUserProperty(string jsonString, bool isSaveToLocal)
		{
		}

		[Token(Token = "0x6001640")]
		[Address(RVA = "0x7387744", Offset = "0x7383744", VA = "0x7387744", Slot = "235")]
		public virtual void CheckSensitiveWordByUrlStatic(string value)
		{
		}

		[Token(Token = "0x6001641")]
		[Address(RVA = "0x7387748", Offset = "0x7383748", VA = "0x7387748", Slot = "236")]
		public virtual void RedeemGetAllInfoStatic()
		{
		}

		[Token(Token = "0x6001642")]
		[Address(RVA = "0x738774C", Offset = "0x738374C", VA = "0x738774C", Slot = "237")]
		public virtual void RedeemGetCodeStatic(string InfoId)
		{
		}

		[Token(Token = "0x6001643")]
		[Address(RVA = "0x7387750", Offset = "0x7383750", VA = "0x7387750", Slot = "238")]
		public virtual void RedeemVerifyCodeStatic(string CdkCode)
		{
		}

		[Token(Token = "0x6001644")]
		[Address(RVA = "0x7387754", Offset = "0x7383754", VA = "0x7387754", Slot = "239")]
		public virtual void RedeemOffCodeStatic(string InfoId, string CdkCode)
		{
		}

		[Token(Token = "0x6001645")]
		[Address(RVA = "0x7387758", Offset = "0x7383758", VA = "0x7387758", Slot = "240")]
		public virtual string GetGameCDNDomainStatic(string key)
		{
			return null;
		}

		[Token(Token = "0x6001646")]
		[Address(RVA = "0x7387760", Offset = "0x7383760", VA = "0x7387760", Slot = "241")]
		public virtual string GetGameBizDomainStatic(string gamename, string businessName)
		{
			return null;
		}

		[Token(Token = "0x6001647")]
		[Address(RVA = "0x7387768", Offset = "0x7383768", VA = "0x7387768", Slot = "242")]
		public virtual string GetGameBizIpStatic(string gamename, string businessName)
		{
			return null;
		}

		[Token(Token = "0x6001648")]
		[Address(RVA = "0x7387770", Offset = "0x7383770", VA = "0x7387770", Slot = "243")]
		public virtual bool CheckCanOpenAppStatic(string packageName, string appleUrl)
		{
			return default;
		}

		[Token(Token = "0x6001649")]
		[Address(RVA = "0x7387778", Offset = "0x7383778", VA = "0x7387778", Slot = "244")]
		public virtual bool OpenJumpAppActionStatic(string packageName, string appleUrl)
		{
			return default;
		}

		[Token(Token = "0x600164A")]
		[Address(RVA = "0x7387780", Offset = "0x7383780", VA = "0x7387780", Slot = "245")]
		public virtual string GetOpenAppUserInfoStatic()
		{
			return null;
		}

		[Token(Token = "0x600164B")]
		[Address(RVA = "0x7387788", Offset = "0x7383788", VA = "0x7387788", Slot = "246")]
		public virtual bool IsSupportLogStatic()
		{
			return default;
		}

		[Token(Token = "0x600164C")]
		[Address(RVA = "0x7387790", Offset = "0x7383790", VA = "0x7387790", Slot = "247")]
		public virtual void SetForbiddenBackPressStatic(bool forbidden)
		{
		}

		[Token(Token = "0x600164D")]
		[Address(RVA = "0x7387794", Offset = "0x7383794", VA = "0x7387794", Slot = "248")]
		public virtual void FileSelectorStatic(string fileFormat)
		{
		}

		[Token(Token = "0x600164E")]
		[Address(RVA = "0x7387798", Offset = "0x7383798", VA = "0x7387798", Slot = "249")]
		public virtual long GetServerTimeStatic()
		{
			return default;
		}

		[Token(Token = "0x600164F")]
		[Address(RVA = "0x73877A0", Offset = "0x73837A0", VA = "0x73877A0", Slot = "250")]
		public virtual bool IsCurrentVersionOnlineParam()
		{
			return default;
		}

		[Token(Token = "0x6001650")]
		[Address(RVA = "0x73877A8", Offset = "0x73837A8", VA = "0x73877A8", Slot = "251")]
		public virtual void StartSettingStatic(string pageTitle)
		{
		}

		[Token(Token = "0x6001651")]
		[Address(RVA = "0x73877AC", Offset = "0x73837AC", VA = "0x73877AC", Slot = "252")]
		public virtual bool IsShowMoreSettingStatic()
		{
			return default;
		}

		[Token(Token = "0x6001652")]
		[Address(RVA = "0x73877B4", Offset = "0x73837B4", VA = "0x73877B4", Slot = "253")]
		public virtual void SetGlobeIntent(string value)
		{
		}

		[Token(Token = "0x6001653")]
		[Address(RVA = "0x73877B8", Offset = "0x73837B8", VA = "0x73877B8", Slot = "254")]
		public virtual void CheckThirdSensitiveInfoStatic(int etype, string checkInfo, string scenestr)
		{
		}

		[Token(Token = "0x6001654")]
		[Address(RVA = "0x73877BC", Offset = "0x73837BC", VA = "0x73877BC", Slot = "255")]
		public virtual long GetGoogleAssetTotalSize(string moduleName)
		{
			return default;
		}

		[Token(Token = "0x6001655")]
		[Address(RVA = "0x73877C4", Offset = "0x73837C4", VA = "0x73877C4", Slot = "256")]
		public virtual long GetGoogleAssetDownloadSize(string moduleName)
		{
			return default;
		}

		[Token(Token = "0x6001656")]
		[Address(RVA = "0x73877CC", Offset = "0x73837CC", VA = "0x73877CC", Slot = "257")]
		public virtual int GameGetDevicePerformanceScore()
		{
			return default;
		}

		[Token(Token = "0x6001657")]
		[Address(RVA = "0x73877D4", Offset = "0x73837D4", VA = "0x73877D4", Slot = "258")]
		public virtual string GameGetDevicePerformanceJson()
		{
			return null;
		}

		[Token(Token = "0x6001658")]
		[Address(RVA = "0x73877DC", Offset = "0x73837DC", VA = "0x73877DC", Slot = "259")]
		public virtual string GetGameNetGroup()
		{
			return null;
		}

		[Token(Token = "0x6001659")]
		[Address(RVA = "0x73877E4", Offset = "0x73837E4", VA = "0x73877E4", Slot = "260")]
		public virtual void ReportException(int etype, string ename, string message, string stackTrace, bool quitProgram)
		{
		}

		[Token(Token = "0x600165A")]
		[Address(RVA = "0x73877E8", Offset = "0x73837E8", VA = "0x73877E8", Slot = "261")]
		public virtual void SetGameLoginAccountId(string accountId, string serverGroupId, string serverId)
		{
		}

		[Token(Token = "0x600165B")]
		[Address(RVA = "0x73877EC", Offset = "0x73837EC", VA = "0x73877EC", Slot = "262")]
		public virtual void UploadCloudArchive(string key, string value)
		{
		}

		[Token(Token = "0x600165C")]
		[Address(RVA = "0x73877F0", Offset = "0x73837F0", VA = "0x73877F0", Slot = "263")]
		public virtual void PullCloudArchive(string key)
		{
		}

		[Token(Token = "0x600165D")]
		[Address(RVA = "0x73877F4", Offset = "0x73837F4", VA = "0x73877F4", Slot = "264")]
		public virtual void RestartAppStatic()
		{
		}

		[Token(Token = "0x600165E")]
		[Address(RVA = "0x73877F8", Offset = "0x73837F8", VA = "0x73877F8", Slot = "265")]
		public virtual string GetGameBizInfoStatic(string gamename, string businessName)
		{
			return null;
		}

		[Token(Token = "0x600165F")]
		[Address(RVA = "0x7387800", Offset = "0x7383800", VA = "0x7387800", Slot = "266")]
		public virtual void GetChannelGiftGoods()
		{
		}

		[Token(Token = "0x6001660")]
		[Address(RVA = "0x7387804", Offset = "0x7383804", VA = "0x7387804", Slot = "267")]
		public virtual void ClaimChannelGiftGoods(string idList)
		{
		}

		[Token(Token = "0x6001661")]
		[Address(RVA = "0x7387808", Offset = "0x7383808", VA = "0x7387808", Slot = "268")]
		public virtual void GameOpenFacebookUrl(string url)
		{
		}

		[Token(Token = "0x6001662")]
		[Address(RVA = "0x738780C", Offset = "0x738380C", VA = "0x738780C", Slot = "269")]
		public virtual string QuerySqliteDataByKey(string key)
		{
			return null;
		}

		[Token(Token = "0x6001663")]
		[Address(RVA = "0x7387814", Offset = "0x7383814", VA = "0x7387814", Slot = "270")]
		public virtual void RequestNoticificationPermission()
		{
		}

		[Token(Token = "0x6001664")]
		[Address(RVA = "0x7387818", Offset = "0x7383818", VA = "0x7387818", Slot = "271")]
		public virtual void ScheduleInAppMessageStatic()
		{
		}

		[Token(Token = "0x6001665")]
		[Address(RVA = "0x738781C", Offset = "0x738381C", VA = "0x738781C", Slot = "272")]
		public virtual void JumpToNotificationSettings()
		{
		}

		[Token(Token = "0x6001666")]
		[Address(RVA = "0x7387820", Offset = "0x7383820", VA = "0x7387820", Slot = "273")]
		public virtual void LogD(string tag, string msg)
		{
		}

		[Token(Token = "0x6001667")]
		[Address(RVA = "0x7387824", Offset = "0x7383824", VA = "0x7387824", Slot = "274")]
		public virtual bool HasUnFinishOrderStatic(string productID)
		{
			return default;
		}

		[Token(Token = "0x6001668")]
		[Address(RVA = "0x738782C", Offset = "0x738382C", VA = "0x738782C", Slot = "275")]
		public virtual void NewOrderInfoByGameStatic(string productID, string ext)
		{
		}

		[Token(Token = "0x6001669")]
		[Address(RVA = "0x7387830", Offset = "0x7383830", VA = "0x7387830", Slot = "276")]
		public virtual void BuySuccessCallBackFormUserStatic(string orderId)
		{
		}

		[Token(Token = "0x600166A")]
		[Address(RVA = "0x7387834", Offset = "0x7383834", VA = "0x7387834", Slot = "277")]
		public virtual void GetFailedOrdersByPlatStatic()
		{
		}

		[Token(Token = "0x600166B")]
		[Address(RVA = "0x7387838", Offset = "0x7383838", VA = "0x7387838", Slot = "278")]
		public virtual void GetFixOrdersByPlatStatic()
		{
		}

		[Token(Token = "0x600166C")]
		[Address(RVA = "0x738783C", Offset = "0x738383C", VA = "0x738783C", Slot = "279")]
		public virtual void FixOrderResultByPlatStatic(string orderId, string orderStats, string msg)
		{
		}

		[Token(Token = "0x600166D")]
		[Address(RVA = "0x7387840", Offset = "0x7383840", VA = "0x7387840", Slot = "280")]
		public virtual bool IsNeedResotreStatic()
		{
			return default;
		}

		[Token(Token = "0x600166E")]
		[Address(RVA = "0x7387848", Offset = "0x7383848", VA = "0x7387848", Slot = "281")]
		public virtual void StartRestoreStatic()
		{
		}

		[Token(Token = "0x600166F")]
		[Address(RVA = "0x738784C", Offset = "0x738384C", VA = "0x738784C", Slot = "282")]
		public virtual int GetZhifuCheckIntervalStatic()
		{
			return default;
		}

		[Token(Token = "0x6001670")]
		[Address(RVA = "0x7387854", Offset = "0x7383854", VA = "0x7387854", Slot = "283")]
		public virtual void GetSubscriptionResultStatic(string pProductID, string pProductKey)
		{
		}

		[Token(Token = "0x6001671")]
		[Address(RVA = "0x7387858", Offset = "0x7383858", VA = "0x7387858", Slot = "284")]
		public virtual int GetMarketTypeStatic()
		{
			return default;
		}

		[Token(Token = "0x6001672")]
		[Address(RVA = "0x7387860", Offset = "0x7383860", VA = "0x7387860", Slot = "285")]
		public virtual void LoadProductInfoStatic(string skus)
		{
		}

		[Token(Token = "0x6001673")]
		[Address(RVA = "0x7387864", Offset = "0x7383864", VA = "0x7387864", Slot = "286")]
		public virtual string GetProductInfoStatic(string skus)
		{
			return null;
		}

		[Token(Token = "0x6001674")]
		[Address(RVA = "0x738786C", Offset = "0x738386C", VA = "0x738786C", Slot = "287")]
		public virtual void ManageAllSubscriptionStatic()
		{
		}

		[Token(Token = "0x6001675")]
		[Address(RVA = "0x7387870", Offset = "0x7383870", VA = "0x7387870", Slot = "288")]
		public virtual void ManageSubscriptionStatic(string sku)
		{
		}

		[Token(Token = "0x6001676")]
		[Address(RVA = "0x7387874", Offset = "0x7383874", VA = "0x7387874", Slot = "289")]
		public virtual void GetRefundProductStatic()
		{
		}

		[Token(Token = "0x6001677")]
		[Address(RVA = "0x7387878", Offset = "0x7383878", VA = "0x7387878", Slot = "290")]
		public virtual void RefundProductFinishStatic(string orderNo)
		{
		}

		[Token(Token = "0x6001678")]
		[Address(RVA = "0x738787C", Offset = "0x738387C", VA = "0x738787C", Slot = "291")]
		public virtual void GetQryGivenGiftStatic()
		{
		}

		[Token(Token = "0x6001679")]
		[Address(RVA = "0x7387880", Offset = "0x7383880", VA = "0x7387880", Slot = "292")]
		public virtual void UpSendGivenGiftResultStatic(string orderNo)
		{
		}

		[Token(Token = "0x600167A")]
		[Address(RVA = "0x7387884", Offset = "0x7383884", VA = "0x7387884", Slot = "293")]
		public virtual void ShowPayFailToastStatic(bool isShow)
		{
		}

		[Token(Token = "0x600167B")]
		[Address(RVA = "0x7387888", Offset = "0x7383888", VA = "0x7387888", Slot = "294")]
		public virtual void NewOrderInfoByStrongNetGameStatic(string pProductID, string businessInfo)
		{
		}

		[Token(Token = "0x600167C")]
		[Address(RVA = "0x738788C", Offset = "0x738388C", VA = "0x738788C", Slot = "295")]
		public virtual void SetBizInfoForStrongNetGameStatic(string businessInfo)
		{
		}

		[Token(Token = "0x600167D")]
		[Address(RVA = "0x7387890", Offset = "0x7383890", VA = "0x7387890", Slot = "296")]
		public virtual void GetExternalPurchaseResultStatic()
		{
		}

		[Token(Token = "0x600167E")]
		[Address(RVA = "0x7387894", Offset = "0x7383894", VA = "0x7387894", Slot = "297")]
		public virtual void ShowPromoCodesStatic()
		{
		}

		[Token(Token = "0x6001680")]
		[Address(RVA = "0x73878A0", Offset = "0x73838A0", VA = "0x73878A0", Slot = "299")]
		public virtual void WebGlSetStringSync(string key, string value)
		{
		}

		[Token(Token = "0x6001681")]
		[Address(RVA = "0x73878A4", Offset = "0x73838A4", VA = "0x73878A4", Slot = "300")]
		public virtual string WebGlGetStringSync(string key, string defaultValue)
		{
			return null;
		}

		[Token(Token = "0x6001682")]
		[Address(RVA = "0x73878AC", Offset = "0x73838AC", VA = "0x73878AC", Slot = "301")]
		public virtual void CleanAllFileCache()
		{
		}

		[Token(Token = "0x6001683")]
		[Address(RVA = "0x73878B0", Offset = "0x73838B0", VA = "0x73878B0", Slot = "302")]
		public virtual void AppQuit()
		{
		}

		[Token(Token = "0x6001684")]
		[Address(RVA = "0x73878B4", Offset = "0x73838B4", VA = "0x73878B4", Slot = "303")]
		public virtual string GetDbtId()
		{
			return null;
		}

		[Token(Token = "0x6001685")]
		[Address(RVA = "0x73878BC", Offset = "0x73838BC", VA = "0x73878BC", Slot = "304")]
		public virtual string GetSensitiveConfig()
		{
			return null;
		}

		[Token(Token = "0x6001686")]
		[Address(RVA = "0x73878C4", Offset = "0x73838C4", VA = "0x73878C4", Slot = "305")]
		public virtual void OnBindFunctionBtn(SDKOpenFunction function, Button btn, params object[] Args)
		{
		}

		[Token(Token = "0x6001687")]
		[Address(RVA = "0x73878C8", Offset = "0x73838C8", VA = "0x73878C8", Slot = "306")]
		public virtual void ReportGameInteractive(string info = "")
		{
		}

		[Token(Token = "0x6001688")]
		[Address(RVA = "0x73878CC", Offset = "0x73838CC", VA = "0x73878CC", Slot = "307")]
		public virtual void ShowVideoStatic(int flag, int tag)
		{
		}

		[Token(Token = "0x6001689")]
		[Address(RVA = "0x73878DC", Offset = "0x73838DC", VA = "0x73878DC")]
		protected ISDK()
		{
		}
	}
}
