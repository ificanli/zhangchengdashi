using Il2CppDummyDll;

namespace UIModuleO
{
	[Token(Token = "0x2000A19")]
	internal static class MysteryAdventurePanelConsts
	{
		[Token(Token = "0x4004ADA")]
		public const string AutoRollPrefKey = "MysteryAdventure_AutoRoll";

		[Token(Token = "0x4004ADB")]
		public const string TenRollPrefKey = "MysteryAdventure_TenRoll";

		[Token(Token = "0x4004ADC")]
		public const string SkipAnimPrefKey = "MysteryAdventure_SkipAnim";

		[Token(Token = "0x4004ADD")]
		public const int TenRollDiceCost = 10;

		[Token(Token = "0x4004ADE")]
		public const int TenRollUnlockLapLevel = 2;

		[Token(Token = "0x4004ADF")]
		public const string TenRollToggleLabel = "十倍消耗";

		[Token(Token = "0x4004AE0")]
		public const string TenRollInsufficientDiceMessage = "骰子不足（十倍消耗需10个骰子）";

		[Token(Token = "0x4004AE1")]
		public const string TenRollExitInsufficientDiceTip = "骰子不足,退出十倍消耗";

		[Token(Token = "0x4004AE2")]
		public const float AutoRollRewardPanelCloseDelay = 0.5f;

		[Token(Token = "0x4004AE3")]
		public const float AutoRollGetNewCardPanelShowSeconds = 1.5f;

		[Token(Token = "0x4004AE4")]
		public const float AutoRollGetNewCardQueueGraceSeconds = 0.5f;

		[Token(Token = "0x4004AE5")]
		public const float AutoRollRuinsPanelDisplayDelay = 0.5f;

		[Token(Token = "0x4004AE6")]
		public const float LapRewardPopupAutoCloseSeconds = 5f;

		[Token(Token = "0x4004AE7")]
		public const float LapRewardPopupAutoCloseSecondsInAutoRoll = 1f;

		[Token(Token = "0x4004AE8")]
		public const float LapRewardPopupTweenDuration = 0.3f;

		[Token(Token = "0x4004AE9")]
		public const float LandingEffectBeforeRewardDelay = 0.1f;

		[Token(Token = "0x4004AEA")]
		public const float InsufficientDiceGiftPanelDelay = 0.6f;

		[Token(Token = "0x4004AEB")]
		public const string InsufficientDiceMessage = "骰子不足";

		[Token(Token = "0x4004AEC")]
		public const string AdventureBusyTip = "棋子正在冒险，稍等一下";

		[Token(Token = "0x4004AED")]
		public const string AutoRollDiceExhaustedMessage = "骰子耗尽，自动模式结束";

		[Token(Token = "0x4004AEE")]
		public const string AutoRollStoppedByUserMessage = "自动冒险已停止";

		[Token(Token = "0x4004AEF")]
		public const string ComingSoonTip = "功能即将开放，敬请期待";

		[Token(Token = "0x4004AF0")]
		public const string DiscountShopSideEntryFormat = "商店次数：{0}";

		[Token(Token = "0x4004AF1")]
		public const string DiscountShopRemainCountFormat = "剩余次数：{0}";

		[Token(Token = "0x6003C22")]
		[Address(RVA = "0x4145C7C", Offset = "0x4141C7C", VA = "0x4145C7C")]
		public static int GetPanelPrefInt(string key, int defaultValue = 0)
		{
			return default;
		}

		[Token(Token = "0x6003C23")]
		[Address(RVA = "0x4145D68", Offset = "0x4141D68", VA = "0x4145D68")]
		public static void SetPanelPrefInt(string key, int value)
		{
		}
	}
}
