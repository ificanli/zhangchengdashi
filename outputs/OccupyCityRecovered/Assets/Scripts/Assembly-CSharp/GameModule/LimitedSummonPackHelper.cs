using System.Collections.Generic;
using Il2CppDummyDll;
using ljzs_lt;

namespace GameModule
{
	[Token(Token = "0x20004D5")]
	public static class LimitedSummonPackHelper
	{
		[Token(Token = "0x4002C63")]
		private const int LimitTypeDaily = 0;

		[Token(Token = "0x4002C64")]
		private const int LimitTypeWeekly = 1;

		[Token(Token = "0x4002C65")]
		private const int PackTypeFree = 0;

		[Token(Token = "0x4002C66")]
		private const int PackTypeAd = 1;

		[Token(Token = "0x4002C67")]
		private const int PackTypeIap = 2;

		[Token(Token = "0x4002C68")]
		[FieldOffset(Offset = "0x0")]
		private static bool _listenersRegistered;

		[Token(Token = "0x4002C69")]
		[FieldOffset(Offset = "0x1")]
		private static bool _iapListenersRegistered;

		[Token(Token = "0x4002C6A")]
		[FieldOffset(Offset = "0x2")]
		private static bool _packDataInitialized;

		[Token(Token = "0x4002C6B")]
		private const string SpecialSummonGiftPackPrefix = "SpecialSummonGiftPack_";

		[Token(Token = "0x4002C6C")]
		private const string SpecialSummonGiftPackWeeklyPeriodKey = "SpecialSummonGiftPackWeeklyPeriod";

		[Token(Token = "0x600183A")]
		[Address(RVA = "0x3E761D8", Offset = "0x3E721D8", VA = "0x3E761D8")]
		private static string GetSpecialSummonGiftPackKey(int packId)
		{
			return null;
		}

		[Token(Token = "0x600183B")]
		[Address(RVA = "0x3E76238", Offset = "0x3E72238", VA = "0x3E76238")]
		private static bool TryGetRemainCountFromPrefs(int packId, out int remain)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED LimitedSummonPackHelper.TryGetRemainCountFromPrefs RVA=0x3E76238 Token=0x600183B");
}

		[Token(Token = "0x600183C")]
		[Address(RVA = "0x3E762EC", Offset = "0x3E722EC", VA = "0x3E762EC")]
		private static void SetRemainCountToPrefs(int packId, int remain)
		{
		}

		[Token(Token = "0x600183D")]
		[Address(RVA = "0x3E76364", Offset = "0x3E72364", VA = "0x3E76364")]
		private static bool TryGetWeeklyPeriodFromPrefs(out int period)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED LimitedSummonPackHelper.TryGetWeeklyPeriodFromPrefs RVA=0x3E76364 Token=0x600183D");
}

		[Token(Token = "0x600183E")]
		[Address(RVA = "0x3E76418", Offset = "0x3E72418", VA = "0x3E76418")]
		private static void SetWeeklyPeriodToPrefs(int period)
		{
		}

		[Token(Token = "0x600183F")]
		[Address(RVA = "0x3E76488", Offset = "0x3E72488", VA = "0x3E76488")]
		private static void SaveShopDataAndPrefs()
		{
		}

		[Token(Token = "0x6001840")]
		[Address(RVA = "0x3E7653C", Offset = "0x3E7253C", VA = "0x3E7653C")]
		public static void EnsureListening()
		{
		}

		[Token(Token = "0x6001841")]
		[Address(RVA = "0x3E766A8", Offset = "0x3E726A8", VA = "0x3E766A8")]
		public static void EnsurePackDataInitialized()
		{
		}

		[Token(Token = "0x6001842")]
		[Address(RVA = "0x3E76710", Offset = "0x3E72710", VA = "0x3E76710")]
		private static void EnsureRemainDictFromConfig()
		{
		}

		[Token(Token = "0x6001843")]
		[Address(RVA = "0x3E76EB8", Offset = "0x3E72EB8", VA = "0x3E76EB8")]
		public static void RegisterIapListeners()
		{
		}

		[Token(Token = "0x6001844")]
		[Address(RVA = "0x3E77030", Offset = "0x3E73030", VA = "0x3E77030")]
		public static List<LimitedPropPackConfig> GetSortedPackList()
		{
			return null;
		}

		[Token(Token = "0x6001845")]
		[Address(RVA = "0x3E7731C", Offset = "0x3E7331C", VA = "0x3E7731C")]
		public static int GetRemainCount(int packId)
		{
			return default;
		}

		[Token(Token = "0x6001846")]
		[Address(RVA = "0x3E774F0", Offset = "0x3E734F0", VA = "0x3E774F0")]
		public static bool CanClaim(LimitedPropPackConfig pack)
		{
			return default;
		}

		[Token(Token = "0x6001847")]
		[Address(RVA = "0x3E77510", Offset = "0x3E73510", VA = "0x3E77510")]
		public static bool AnyFreePackClaimable()
		{
			return default;
		}

		[Token(Token = "0x6001848")]
		[Address(RVA = "0x3E7768C", Offset = "0x3E7368C", VA = "0x3E7768C")]
		public static string BuildRewardString(string[] rewards)
		{
			return null;
		}

		[Token(Token = "0x6001849")]
		[Address(RVA = "0x3E7773C", Offset = "0x3E7373C", VA = "0x3E7773C")]
		public static RewardConfig BuildRewardConfig(LimitedPropPackConfig pack)
		{
			return null;
		}

		[Token(Token = "0x600184A")]
		[Address(RVA = "0x3E777C4", Offset = "0x3E737C4", VA = "0x3E777C4")]
		public static bool GrantPack(LimitedPropPackConfig pack, bool showRewardPanel = true)
		{
			return default;
		}

		[Token(Token = "0x600184B")]
		[Address(RVA = "0x3E76BC8", Offset = "0x3E72BC8", VA = "0x3E76BC8")]
		public static void SyncWeeklyPackFromAnchor()
		{
		}

		[Token(Token = "0x600184C")]
		[Address(RVA = "0x3E77EB8", Offset = "0x3E73EB8", VA = "0x3E77EB8")]
		public static void ResetDailyPacks()
		{
		}

		[Token(Token = "0x600184D")]
		[Address(RVA = "0x3E77A50", Offset = "0x3E73A50", VA = "0x3E77A50")]
		private static void RefreshGiftFreeRedDotSafe()
		{
		}

		[Token(Token = "0x600184E")]
		[Address(RVA = "0x3E78114", Offset = "0x3E74114", VA = "0x3E78114")]
		private static void OnTimeToZero(object obj)
		{
		}

		[Token(Token = "0x600184F")]
		[Address(RVA = "0x3E78124", Offset = "0x3E74124", VA = "0x3E78124")]
		private static void OnArtifactsFeatureUnlocked(object obj)
		{
		}

		[Token(Token = "0x6001850")]
		[Address(RVA = "0x3E78134", Offset = "0x3E74134", VA = "0x3E78134")]
		private static void OnIapPurchaseComplete(string productId)
		{
		}

		[Token(Token = "0x6001851")]
		[Address(RVA = "0x3E7744C", Offset = "0x3E7344C", VA = "0x3E7744C")]
		private static LimitedPropPackConfig FindPackById(int packId)
		{
			return null;
		}

		[Token(Token = "0x6001852")]
		[Address(RVA = "0x3E78154", Offset = "0x3E74154", VA = "0x3E78154")]
		private static LimitedPropPackConfig FindPackByPackId(string packId)
		{
			return null;
		}

		[Token(Token = "0x6001853")]
		[Address(RVA = "0x3E775C8", Offset = "0x3E735C8", VA = "0x3E775C8")]
		private static bool IsArtifactsFeatureUnlocked()
		{
			return default;
		}
	}
}
