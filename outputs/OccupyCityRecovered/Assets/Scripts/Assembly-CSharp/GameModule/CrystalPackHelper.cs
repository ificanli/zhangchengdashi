using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TimeModuleO;
using ljzs_lt;

namespace GameModule
{
	[Token(Token = "0x2000492")]
	public static class CrystalPackHelper
	{
		[Token(Token = "0x4002B37")]
		private const int LimitTypeDaily = 0;

		[Token(Token = "0x4002B38")]
		private const int LimitTypeWeekly = 1;

		[Token(Token = "0x4002B39")]
		[FieldOffset(Offset = "0x0")]
		private static bool _listenersRegistered;

		[Token(Token = "0x4002B3A")]
		[FieldOffset(Offset = "0x1")]
		private static bool _iapListenersRegistered;

		[Token(Token = "0x4002B3B")]
		[FieldOffset(Offset = "0x8")]
		private static readonly TimeSpan PushWindowDuration;

		[Token(Token = "0x6001671")]
		[Address(RVA = "0x3E48A60", Offset = "0x3E44A60", VA = "0x3E48A60")]
		public static void EnsureListening()
		{
		}

		[Token(Token = "0x6001672")]
		[Address(RVA = "0x3E48C6C", Offset = "0x3E44C6C", VA = "0x3E48C6C")]
		public static void EnsureInitialized()
		{
		}

		[Token(Token = "0x6001673")]
		[Address(RVA = "0x3E48F30", Offset = "0x3E44F30", VA = "0x3E48F30")]
		public static void RegisterIapListeners()
		{
		}

		[Token(Token = "0x6001674")]
		[Address(RVA = "0x3E490C0", Offset = "0x3E450C0", VA = "0x3E490C0")]
		public static List<CrystalPackConfig> GetSortedPackList()
		{
			return null;
		}

		[Token(Token = "0x6001675")]
		[Address(RVA = "0x3E493C8", Offset = "0x3E453C8", VA = "0x3E493C8")]
		public static int GetRemainCount(int packId)
		{
			return default;
		}

		[Token(Token = "0x6001676")]
		[Address(RVA = "0x3E49570", Offset = "0x3E45570", VA = "0x3E49570")]
		public static bool CanPurchase(CrystalPackConfig pack)
		{
			return default;
		}

		[Token(Token = "0x6001677")]
		[Address(RVA = "0x3E495E0", Offset = "0x3E455E0", VA = "0x3E495E0")]
		public static CrystalPackConfig GetCurrentDisplayPack()
		{
			return null;
		}

		[Token(Token = "0x6001678")]
		[Address(RVA = "0x3E49728", Offset = "0x3E45728", VA = "0x3E49728")]
		public static bool HasAnyPurchasablePack()
		{
			return default;
		}

		[Token(Token = "0x6001679")]
		[Address(RVA = "0x3E49780", Offset = "0x3E45780", VA = "0x3E49780")]
		public static bool IsPushWindowActive()
		{
			return default;
		}

		[Token(Token = "0x600167A")]
		[Address(RVA = "0x3E49854", Offset = "0x3E45854", VA = "0x3E49854")]
		public static bool ShouldShowInShop()
		{
			return default;
		}

		[Token(Token = "0x600167B")]
		[Address(RVA = "0x3E498CC", Offset = "0x3E458CC", VA = "0x3E498CC")]
		public static void TryPushCrystalPack()
		{
		}

		[Token(Token = "0x600167C")]
		[Address(RVA = "0x3E49B9C", Offset = "0x3E45B9C", VA = "0x3E49B9C")]
		public static string GetPushRemainingFormatted()
		{
			return null;
		}

		[Token(Token = "0x600167D")]
		[Address(RVA = "0x3E49C38", Offset = "0x3E45C38", VA = "0x3E49C38")]
		public static string BuildRewardString(string[] rewards)
		{
			return null;
		}

		[Token(Token = "0x600167E")]
		[Address(RVA = "0x3E49CE8", Offset = "0x3E45CE8", VA = "0x3E49CE8")]
		public static RewardConfig BuildRewardConfig(CrystalPackConfig pack)
		{
			return null;
		}

		[Token(Token = "0x600167F")]
		[Address(RVA = "0x3E49D98", Offset = "0x3E45D98", VA = "0x3E49D98")]
		public static List<RewardConfigSingle> BuildPreviewRewardList(CrystalPackConfig pack)
		{
			return null;
		}

		[Token(Token = "0x6001680")]
		[Address(RVA = "0x3E49E6C", Offset = "0x3E45E6C", VA = "0x3E49E6C")]
		public static bool GrantPack(CrystalPackConfig pack, bool showRewardPanel = true)
		{
			return default;
		}

		[Token(Token = "0x6001681")]
		[Address(RVA = "0x3E4A168", Offset = "0x3E46168", VA = "0x3E4A168")]
		public static void OnPurchaseComplete(string productId)
		{
		}

		[Token(Token = "0x6001682")]
		[Address(RVA = "0x3E4A578", Offset = "0x3E46578", VA = "0x3E4A578")]
		public static void ResetDailyPacks()
		{
		}

		[Token(Token = "0x6001683")]
		[Address(RVA = "0x3E4A804", Offset = "0x3E46804", VA = "0x3E4A804")]
		public static void ResetWeeklyPacks()
		{
		}

		[Token(Token = "0x6001684")]
		[Address(RVA = "0x3E48CBC", Offset = "0x3E44CBC", VA = "0x3E48CBC")]
		private static void EnsureRemainDictFromConfig()
		{
		}

		[Token(Token = "0x6001685")]
		[Address(RVA = "0x3E49A58", Offset = "0x3E45A58", VA = "0x3E49A58")]
		private static void RestartPushTimer()
		{
		}

		[Token(Token = "0x6001686")]
		[Address(RVA = "0x3E4A4D8", Offset = "0x3E464D8", VA = "0x3E4A4D8")]
		private static void ClearPushTimer()
		{
		}

		[Token(Token = "0x6001687")]
		[Address(RVA = "0x3E497EC", Offset = "0x3E457EC", VA = "0x3E497EC")]
		private static TimeManager.Timer GetPushTimer()
		{
			return null;
		}

		[Token(Token = "0x6001688")]
		[Address(RVA = "0x3E4AA94", Offset = "0x3E46A94", VA = "0x3E4AA94")]
		private static void OnTimeToZero(object obj)
		{
		}

		[Token(Token = "0x6001689")]
		[Address(RVA = "0x3E4AAE0", Offset = "0x3E46AE0", VA = "0x3E4AAE0")]
		private static void OnTimeToMonDayZero(object obj)
		{
		}

		[Token(Token = "0x600168A")]
		[Address(RVA = "0x3E4AB2C", Offset = "0x3E46B2C", VA = "0x3E4AB2C")]
		private static void OnWeekPassed()
		{
		}

		[Token(Token = "0x600168B")]
		[Address(RVA = "0x3E4AB78", Offset = "0x3E46B78", VA = "0x3E4AB78")]
		private static void OnIapPurchaseComplete(string productId)
		{
		}

		[Token(Token = "0x600168C")]
		[Address(RVA = "0x3E494BC", Offset = "0x3E454BC", VA = "0x3E494BC")]
		private static CrystalPackConfig FindPackById(int packId)
		{
			return null;
		}

		[Token(Token = "0x600168D")]
		[Address(RVA = "0x3E4A340", Offset = "0x3E46340", VA = "0x3E4A340")]
		private static CrystalPackConfig FindPackByPackId(string packId)
		{
			return null;
		}
	}
}
