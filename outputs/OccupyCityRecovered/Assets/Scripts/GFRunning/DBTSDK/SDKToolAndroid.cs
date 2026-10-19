using Il2CppDummyDll;

namespace DBTSDK
{
	[Token(Token = "0x2000208")]
	public class SDKToolAndroid
	{
		[Token(Token = "0x6001AB3")]
		[Address(RVA = "0x70CD0E8", Offset = "0x70C90E8", VA = "0x70CD0E8")]
		public static void VibrateStatic(long milliseconds, int shakeLevel)
		{
		}

		[Token(Token = "0x6001AB4")]
		[Address(RVA = "0x70CD308", Offset = "0x70C9308", VA = "0x70CD308")]
		public static void ShowToast(string msg)
		{
		}

		[Token(Token = "0x6001AB5")]
		[Address(RVA = "0x70CD488", Offset = "0x70C9488", VA = "0x70CD488")]
		public static void ShowExitDialog()
		{
		}

		[Token(Token = "0x6001AB6")]
		[Address(RVA = "0x70CD5EC", Offset = "0x70C95EC", VA = "0x70CD5EC")]
		public static void OpenUrl(string url)
		{
		}

		[Token(Token = "0x6001AB7")]
		[Address(RVA = "0x70CD76C", Offset = "0x70C976C", VA = "0x70CD76C")]
		public static void CopyMsgToClipboard(string msg)
		{
		}

		[Token(Token = "0x6001AB8")]
		[Address(RVA = "0x70CD8EC", Offset = "0x70C98EC", VA = "0x70CD8EC")]
		public static string GetClipboardMsg()
		{
			return null;
		}

		[Token(Token = "0x6001AB9")]
		[Address(RVA = "0x70CDAA8", Offset = "0x70C9AA8", VA = "0x70CDAA8")]
		public static void Copy2SystemDCIM(string copyFile)
		{
		}

		[Token(Token = "0x6001ABA")]
		[Address(RVA = "0x70CDC28", Offset = "0x70C9C28", VA = "0x70CDC28")]
		public static void GotoAppStore(string packageName)
		{
		}

		[Token(Token = "0x6001ABB")]
		[Address(RVA = "0x70CDDA8", Offset = "0x70C9DA8", VA = "0x70CDDA8")]
		public static string GetNetworkTypeStatic()
		{
			return null;
		}

		[Token(Token = "0x6001ABC")]
		[Address(RVA = "0x70CDF64", Offset = "0x70C9F64", VA = "0x70CDF64")]
		public static bool IsShowPolicy()
		{
			return default;
		}

		[Token(Token = "0x6001ABD")]
		[Address(RVA = "0x70CE138", Offset = "0x70CA138", VA = "0x70CE138")]
		public static void GotoTermsServiceStatic()
		{
		}

		[Token(Token = "0x6001ABE")]
		[Address(RVA = "0x70CE29C", Offset = "0x70CA29C", VA = "0x70CE29C")]
		public static void GotoPrivacyPolicyStatic()
		{
		}

		[Token(Token = "0x6001ABF")]
		[Address(RVA = "0x70CE400", Offset = "0x70CA400", VA = "0x70CE400")]
		public static void OpenApp(int id)
		{
		}

		[Token(Token = "0x6001AC0")]
		[Address(RVA = "0x70CE5A4", Offset = "0x70CA5A4", VA = "0x70CE5A4")]
		public static bool IsAppInstalled(int id)
		{
			return default;
		}

		[Token(Token = "0x6001AC1")]
		[Address(RVA = "0x70CE7A0", Offset = "0x70CA7A0", VA = "0x70CE7A0")]
		public static bool IsShowRealNameRegistration()
		{
			return default;
		}

		[Token(Token = "0x6001AC2")]
		[Address(RVA = "0x70CE974", Offset = "0x70CA974", VA = "0x70CE974")]
		public static bool IsShowContactInformation()
		{
			return default;
		}

		[Token(Token = "0x6001AC3")]
		[Address(RVA = "0x70CEB48", Offset = "0x70CAB48", VA = "0x70CEB48")]
		public static int GetDurationTimeStatic()
		{
			return default;
		}

		[Token(Token = "0x6001AC4")]
		[Address(RVA = "0x70CED10", Offset = "0x70CAD10", VA = "0x70CED10")]
		public static bool OnlineResStatic()
		{
			return default;
		}

		[Token(Token = "0x6001AC5")]
		[Address(RVA = "0x70CEEE4", Offset = "0x70CAEE4", VA = "0x70CEEE4")]
		public static void U3DGameStart()
		{
		}

		[Token(Token = "0x6001AC6")]
		[Address(RVA = "0x70CF048", Offset = "0x70CB048", VA = "0x70CF048")]
		public static void PreloadEffect(string path)
		{
		}

		[Token(Token = "0x6001AC7")]
		[Address(RVA = "0x70CF1C8", Offset = "0x70CB1C8", VA = "0x70CF1C8")]
		public static int PlayEffect(string path, bool isLoop)
		{
			return default;
		}

		[Token(Token = "0x6001AC8")]
		[Address(RVA = "0x70CF304", Offset = "0x70CB304", VA = "0x70CF304")]
		public static int PlayEffect(string path, bool isLoop, float pitch, float pan, float gain)
		{
			return default;
		}

		[Token(Token = "0x6001AC9")]
		[Address(RVA = "0x70CF52C", Offset = "0x70CB52C", VA = "0x70CF52C")]
		public static void PauseEffect(int soundId)
		{
		}

		[Token(Token = "0x6001ACA")]
		[Address(RVA = "0x70CF6D0", Offset = "0x70CB6D0", VA = "0x70CF6D0")]
		public static void ResumeEffect(int soundId)
		{
		}

		[Token(Token = "0x6001ACB")]
		[Address(RVA = "0x70CF874", Offset = "0x70CB874", VA = "0x70CF874")]
		public static void StopEffect(int soundId)
		{
		}

		[Token(Token = "0x6001ACC")]
		[Address(RVA = "0x70CF96C", Offset = "0x70CB96C", VA = "0x70CF96C")]
		public static float GetEffectsVolume()
		{
			return default;
		}

		[Token(Token = "0x6001ACD")]
		[Address(RVA = "0x70CFB40", Offset = "0x70CBB40", VA = "0x70CFB40")]
		public static void SetEffectsVolume(float volume)
		{
		}

		[Token(Token = "0x6001ACE")]
		[Address(RVA = "0x70CFCE4", Offset = "0x70CBCE4", VA = "0x70CFCE4")]
		public static void UnloadEffect(string path)
		{
		}

		[Token(Token = "0x6001ACF")]
		[Address(RVA = "0x70CFE64", Offset = "0x70CBE64", VA = "0x70CFE64")]
		public static void PauseAllEffects()
		{
		}

		[Token(Token = "0x6001AD0")]
		[Address(RVA = "0x70CFFC8", Offset = "0x70CBFC8", VA = "0x70CFFC8")]
		public static void ResumeAllEffects()
		{
		}

		[Token(Token = "0x6001AD1")]
		[Address(RVA = "0x70D012C", Offset = "0x70CC12C", VA = "0x70D012C")]
		public static void StopAllEffects()
		{
		}

		[Token(Token = "0x6001AD2")]
		[Address(RVA = "0x70D0290", Offset = "0x70CC290", VA = "0x70D0290")]
		public static void SetAudioFocus(bool isAudioFocus)
		{
		}

		[Token(Token = "0x6001AD3")]
		[Address(RVA = "0x70D0434", Offset = "0x70CC434", VA = "0x70D0434")]
		public static void End()
		{
		}

		[Token(Token = "0x6001AD4")]
		[Address(RVA = "0x70D0598", Offset = "0x70CC598", VA = "0x70D0598")]
		public static int GetDaysByFirstLaunch()
		{
			return default;
		}

		[Token(Token = "0x6001AD5")]
		[Address(RVA = "0x70D0760", Offset = "0x70CC760", VA = "0x70D0760")]
		public static bool IsDebugVersion()
		{
			return default;
		}

		[Token(Token = "0x6001AD6")]
		[Address(RVA = "0x70D0934", Offset = "0x70CC934", VA = "0x70D0934")]
		public static int GetGameBanHaoType()
		{
			return default;
		}

		[Token(Token = "0x6001AD7")]
		[Address(RVA = "0x70D0AFC", Offset = "0x70CCAFC", VA = "0x70D0AFC")]
		public static void ShowGameBanHao()
		{
		}

		[Token(Token = "0x6001AD8")]
		[Address(RVA = "0x70D0C60", Offset = "0x70CCC60", VA = "0x70D0C60")]
		public static string CreateQRcodeSyncStatic(string content, int widthPix, int heightPix, int padding)
		{
			return null;
		}

		[Token(Token = "0x6001AD9")]
		[Address(RVA = "0x70D0FE4", Offset = "0x70CCFE4", VA = "0x70D0FE4")]
		public static void CreateQRcodeAsyncStatic(string content, int widthPix, int heightPix, int padding)
		{
		}

		[Token(Token = "0x6001ADA")]
		[Address(RVA = "0x70D1320", Offset = "0x70CD320", VA = "0x70D1320")]
		public static string CheckSensitiveWord(string content)
		{
			return null;
		}

		[Token(Token = "0x6001ADB")]
		[Address(RVA = "0x70D1530", Offset = "0x70CD530", VA = "0x70D1530")]
		public static void ShowUnionGameStatic(int gameType, string gameName)
		{
		}

		[Token(Token = "0x6001ADC")]
		[Address(RVA = "0x70D170C", Offset = "0x70CD70C", VA = "0x70D170C")]
		public static void GoUnionGameHomeStatic()
		{
		}

		[Token(Token = "0x6001ADD")]
		[Address(RVA = "0x70D1870", Offset = "0x70CD870", VA = "0x70D1870")]
		public static int GetGameHomePageEngineStatic()
		{
			return default;
		}

		[Token(Token = "0x6001ADE")]
		[Address(RVA = "0x70D1A38", Offset = "0x70CDA38", VA = "0x70D1A38")]
		public static string GetPreviousVersion()
		{
			return null;
		}

		[Token(Token = "0x6001ADF")]
		[Address(RVA = "0x70D1BF4", Offset = "0x70CDBF4", VA = "0x70D1BF4")]
		public static int GetNetworkingStateStatic()
		{
			return default;
		}

		[Token(Token = "0x6001AE0")]
		[Address(RVA = "0x70D1DBC", Offset = "0x70CDDBC", VA = "0x70D1DBC")]
		public static string GetShiLingTiShiStatic()
		{
			return null;
		}

		[Token(Token = "0x6001AE1")]
		[Address(RVA = "0x70D1F78", Offset = "0x70CDF78", VA = "0x70D1F78")]
		public static void SetAppDebugStatic(int debug)
		{
		}

		[Token(Token = "0x6001AE2")]
		[Address(RVA = "0x70D211C", Offset = "0x70CE11C", VA = "0x70D211C")]
		public static int GetAppDebugStatic(int debugLevel)
		{
			return default;
		}

		[Token(Token = "0x6001AE3")]
		[Address(RVA = "0x70D2300", Offset = "0x70CE300", VA = "0x70D2300")]
		public static bool CanShowOppoGameCenterStatic()
		{
			return default;
		}

		[Token(Token = "0x6001AE4")]
		[Address(RVA = "0x70D24D4", Offset = "0x70CE4D4", VA = "0x70D24D4")]
		public static void OpenOppoGameCenterStatic()
		{
		}

		[Token(Token = "0x6001AE5")]
		[Address(RVA = "0x70D2638", Offset = "0x70CE638", VA = "0x70D2638")]
		public static int GetKeyboardHeightStatic()
		{
			return default;
		}

		[Token(Token = "0x6001AE6")]
		[Address(RVA = "0x70D2800", Offset = "0x70CE800", VA = "0x70D2800")]
		public static int GetPhotoCameraAuthorizationStateStatic(int ptype)
		{
			return default;
		}

		[Token(Token = "0x6001AE7")]
		[Address(RVA = "0x70D29E4", Offset = "0x70CE9E4", VA = "0x70D29E4")]
		public static void ShowPhotoCameraAuthorizationStatic(int ptype)
		{
		}

		[Token(Token = "0x6001AE8")]
		[Address(RVA = "0x70D2B88", Offset = "0x70CEB88", VA = "0x70D2B88")]
		public static long GetServerTimeByServerTimeZoneStatic()
		{
			return default;
		}

		[Token(Token = "0x6001AE9")]
		[Address(RVA = "0x70D2C5C", Offset = "0x70CEC5C", VA = "0x70D2C5C")]
		public static int GetAppInfoPageVersion()
		{
			return default;
		}

		[Token(Token = "0x6001AEA")]
		[Address(RVA = "0x70D2E24", Offset = "0x70CEE24", VA = "0x70D2E24")]
		public static void DownloadGoogleAsset(string moduleName)
		{
		}

		[Token(Token = "0x6001AEB")]
		[Address(RVA = "0x70D2FA4", Offset = "0x70CEFA4", VA = "0x70D2FA4")]
		public static string GetGoogleAssetPath(string moduleName)
		{
			return null;
		}

		[Token(Token = "0x6001AEC")]
		[Address(RVA = "0x70D31B4", Offset = "0x70CF1B4", VA = "0x70D31B4")]
		public static void GameShowDelayNotify(string jsonStr)
		{
		}

		[Token(Token = "0x6001AED")]
		[Address(RVA = "0x70D3334", Offset = "0x70CF334", VA = "0x70D3334")]
		public static void GameClearLocalNotify(string notifyId)
		{
		}

		[Token(Token = "0x6001AEE")]
		[Address(RVA = "0x70D34B4", Offset = "0x70CF4B4", VA = "0x70D34B4")]
		public static bool GameGetNotificationOpenState()
		{
			return default;
		}

		[Token(Token = "0x6001AEF")]
		[Address(RVA = "0x70D3688", Offset = "0x70CF688", VA = "0x70D3688")]
		public static string GetGlobeIntent()
		{
			return null;
		}

		[Token(Token = "0x6001AF0")]
		[Address(RVA = "0x70D3844", Offset = "0x70CF844", VA = "0x70D3844")]
		public static bool IsPocoTestStatic()
		{
			return default;
		}

		[Token(Token = "0x6001AF1")]
		[Address(RVA = "0x70D3A18", Offset = "0x70CFA18", VA = "0x70D3A18")]
		public static void SetUserProperty(string jsonString, bool isSaveToLocal)
		{
		}

		[Token(Token = "0x6001AF2")]
		[Address(RVA = "0x70D3BF8", Offset = "0x70CFBF8", VA = "0x70D3BF8")]
		public static void CheckSensitiveWordByUrlStatic(string value)
		{
		}

		[Token(Token = "0x6001AF3")]
		[Address(RVA = "0x70D3D78", Offset = "0x70CFD78", VA = "0x70D3D78")]
		public static void RedeemGetAllInfoStatic()
		{
		}

		[Token(Token = "0x6001AF4")]
		[Address(RVA = "0x70D3EDC", Offset = "0x70CFEDC", VA = "0x70D3EDC")]
		public static void RedeemGetCodeStatic(string InfoId)
		{
		}

		[Token(Token = "0x6001AF5")]
		[Address(RVA = "0x70D405C", Offset = "0x70D005C", VA = "0x70D405C")]
		public static void RedeemVerifyCodeStatic(string CdkCode)
		{
		}

		[Token(Token = "0x6001AF6")]
		[Address(RVA = "0x70D41DC", Offset = "0x70D01DC", VA = "0x70D41DC")]
		public static void RedeemOffCodeStatic(string InfoId, string CdkCode)
		{
		}

		[Token(Token = "0x6001AF7")]
		[Address(RVA = "0x70D43FC", Offset = "0x70D03FC", VA = "0x70D43FC")]
		public static string GetGameCDNDomainStatic(string key)
		{
			return null;
		}

		[Token(Token = "0x6001AF8")]
		[Address(RVA = "0x70D460C", Offset = "0x70D060C", VA = "0x70D460C")]
		public static string GetGameBizDomainStatic(string gamename, string businessName)
		{
			return null;
		}

		[Token(Token = "0x6001AF9")]
		[Address(RVA = "0x70D4880", Offset = "0x70D0880", VA = "0x70D4880")]
		public static string GetGameBizIpStatic(string gamename, string businessName)
		{
			return null;
		}

		[Token(Token = "0x6001AFA")]
		[Address(RVA = "0x70D4AF4", Offset = "0x70D0AF4", VA = "0x70D4AF4")]
		public static bool OpenJumpAppActionStatic(string packageName, string appleUrl)
		{
			return default;
		}

		[Token(Token = "0x6001AFB")]
		[Address(RVA = "0x70D4CE4", Offset = "0x70D0CE4", VA = "0x70D4CE4")]
		public static bool IsSupportLogStatic()
		{
			return default;
		}

		[Token(Token = "0x6001AFC")]
		[Address(RVA = "0x70D4EB8", Offset = "0x70D0EB8", VA = "0x70D4EB8")]
		public static void SetForbiddenBackPressStatic(bool forbidden)
		{
		}

		[Token(Token = "0x6001AFD")]
		[Address(RVA = "0x70D505C", Offset = "0x70D105C", VA = "0x70D505C")]
		public static void FileSelectorStatic(string fileFormat)
		{
		}

		[Token(Token = "0x6001AFE")]
		[Address(RVA = "0x70D51DC", Offset = "0x70D11DC", VA = "0x70D51DC")]
		public static long GetServerTimeStatic()
		{
			return default;
		}

		[Token(Token = "0x6001AFF")]
		[Address(RVA = "0x70D53A4", Offset = "0x70D13A4", VA = "0x70D53A4")]
		public static bool IsCurrentVersionOnlineParam()
		{
			return default;
		}

		[Token(Token = "0x6001B00")]
		[Address(RVA = "0x70D5578", Offset = "0x70D1578", VA = "0x70D5578")]
		public static void StartSettingStatic(string pageTitle)
		{
		}

		[Token(Token = "0x6001B01")]
		[Address(RVA = "0x70D56F8", Offset = "0x70D16F8", VA = "0x70D56F8")]
		public static bool IsShowMoreSettingStatic()
		{
			return default;
		}

		[Token(Token = "0x6001B02")]
		[Address(RVA = "0x70D58CC", Offset = "0x70D18CC", VA = "0x70D58CC")]
		public static void SetGlobeIntent(string value)
		{
		}

		[Token(Token = "0x6001B03")]
		[Address(RVA = "0x70D5A4C", Offset = "0x70D1A4C", VA = "0x70D5A4C")]
		public static void CheckThirdSensitiveInfoStatic(int etype, string checkInfo, string scenestr)
		{
		}

		[Token(Token = "0x6001B04")]
		[Address(RVA = "0x70D5C58", Offset = "0x70D1C58", VA = "0x70D5C58")]
		public static long GetGoogleAssetTotalSize(string moduleName)
		{
			return default;
		}

		[Token(Token = "0x6001B05")]
		[Address(RVA = "0x70D5E0C", Offset = "0x70D1E0C", VA = "0x70D5E0C")]
		public static long GetGoogleAssetDownloadSize(string moduleName)
		{
			return default;
		}

		[Token(Token = "0x6001B06")]
		[Address(RVA = "0x70D5FC0", Offset = "0x70D1FC0", VA = "0x70D5FC0")]
		public static int GameGetDevicePerformanceScore()
		{
			return default;
		}

		[Token(Token = "0x6001B07")]
		[Address(RVA = "0x70D6188", Offset = "0x70D2188", VA = "0x70D6188")]
		public static string GameGetDevicePerformanceJson()
		{
			return null;
		}

		[Token(Token = "0x6001B08")]
		[Address(RVA = "0x70D6344", Offset = "0x70D2344", VA = "0x70D6344")]
		public static string GetGameNetGroup()
		{
			return null;
		}

		[Token(Token = "0x6001B09")]
		[Address(RVA = "0x70D6500", Offset = "0x70D2500", VA = "0x70D6500")]
		public static void ReportException(int etype, string ename, string message, string stackTrace, bool quitProgram)
		{
		}

		[Token(Token = "0x6001B0A")]
		[Address(RVA = "0x70D6888", Offset = "0x70D2888", VA = "0x70D6888")]
		public static void SetGameLoginAccountId(string accountId, string serverGroupId, string serverId)
		{
		}

		[Token(Token = "0x6001B0B")]
		[Address(RVA = "0x70D6B04", Offset = "0x70D2B04", VA = "0x70D6B04")]
		public static void UploadCloudArchive(string key, string value)
		{
		}

		[Token(Token = "0x6001B0C")]
		[Address(RVA = "0x70D6D24", Offset = "0x70D2D24", VA = "0x70D6D24")]
		public static void PullCloudArchive(string key)
		{
		}

		[Token(Token = "0x6001B0D")]
		[Address(RVA = "0x70D6EA4", Offset = "0x70D2EA4", VA = "0x70D6EA4")]
		public static void RestartAppStatic()
		{
		}

		[Token(Token = "0x6001B0E")]
		[Address(RVA = "0x70D7008", Offset = "0x70D3008", VA = "0x70D7008")]
		public static string GetGameBizInfoStatic(string gamename, string businessName)
		{
			return null;
		}

		[Token(Token = "0x6001B0F")]
		[Address(RVA = "0x70D727C", Offset = "0x70D327C", VA = "0x70D727C")]
		public static void GetChannelGiftGoods()
		{
		}

		[Token(Token = "0x6001B10")]
		[Address(RVA = "0x70D73E0", Offset = "0x70D33E0", VA = "0x70D73E0")]
		public static void ClaimChannelGiftGoods(string idList)
		{
		}

		[Token(Token = "0x6001B11")]
		[Address(RVA = "0x70D7560", Offset = "0x70D3560", VA = "0x70D7560")]
		public static void GameOpenFacebookUrl(string url)
		{
		}

		[Token(Token = "0x6001B12")]
		[Address(RVA = "0x70D76E0", Offset = "0x70D36E0", VA = "0x70D76E0")]
		public static string QuerySqliteDataByKey(string key)
		{
			return null;
		}

		[Token(Token = "0x6001B13")]
		[Address(RVA = "0x70D78F0", Offset = "0x70D38F0", VA = "0x70D78F0")]
		public static void RequestNoticificationPermission()
		{
		}

		[Token(Token = "0x6001B14")]
		[Address(RVA = "0x70D7A54", Offset = "0x70D3A54", VA = "0x70D7A54")]
		public static void ScheduleInAppMessageStatic()
		{
		}

		[Token(Token = "0x6001B15")]
		[Address(RVA = "0x70D7BB8", Offset = "0x70D3BB8", VA = "0x70D7BB8")]
		public static void JumpToNotificationSettings()
		{
		}

		[Token(Token = "0x6001B16")]
		[Address(RVA = "0x70D7D1C", Offset = "0x70D3D1C", VA = "0x70D7D1C")]
		public static void LogD(string tag, string msg)
		{
		}

		[Token(Token = "0x6001B17")]
		[Address(RVA = "0x70D7F3C", Offset = "0x70D3F3C", VA = "0x70D7F3C")]
		public SDKToolAndroid()
		{
		}
	}
}
