using System.Collections.Generic;
using DataModule;
using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x200047F")]
	public static class ArtifactPackHelper
	{
		[Token(Token = "0x4002B09")]
		[FieldOffset(Offset = "0x0")]
		private static bool _listenersRegistered;

		[Token(Token = "0x4002B0A")]
		[FieldOffset(Offset = "0x8")]
		private static string _pendingPurchasedTierPriceValue;

		[Token(Token = "0x4002B0B")]
		[FieldOffset(Offset = "0x10")]
		private static readonly string[] TierPriceValues;

		[Token(Token = "0x6001607")]
		[Address(RVA = "0x3E25170", Offset = "0x3E21170", VA = "0x3E25170")]
		public static void EnsureListening()
		{
		}

		[Token(Token = "0x6001608")]
		[Address(RVA = "0x3E25304", Offset = "0x3E21304", VA = "0x3E25304")]
		public static void EnsureInitialized()
		{
		}

		[Token(Token = "0x6001609")]
		[Address(RVA = "0x3E258A0", Offset = "0x3E218A0", VA = "0x3E258A0")]
		public static void SetPendingPurchasedTier(string priceValue)
		{
		}

		[Token(Token = "0x600160A")]
		[Address(RVA = "0x3E25920", Offset = "0x3E21920", VA = "0x3E25920")]
		public static string ConsumePendingPurchasedTierPriceValue()
		{
			return null;
		}

		[Token(Token = "0x600160B")]
		[Address(RVA = "0x3E2599C", Offset = "0x3E2199C", VA = "0x3E2599C")]
		public static List<GlobalShopInfo> GetTierShopInfoList()
		{
			return null;
		}

		[Token(Token = "0x600160C")]
		[Address(RVA = "0x3E25C48", Offset = "0x3E21C48", VA = "0x3E25C48")]
		public static GlobalShopInfo GetShopInfoByPriceValue(string priceValue)
		{
			return null;
		}

		[Token(Token = "0x600160D")]
		[Address(RVA = "0x3E25D64", Offset = "0x3E21D64", VA = "0x3E25D64")]
		public static string GetTierProductId(GlobalShopInfo tier)
		{
			return null;
		}

		[Token(Token = "0x600160E")]
		[Address(RVA = "0x3E25EA4", Offset = "0x3E21EA4", VA = "0x3E25EA4")]
		public static int GetWeeklyBuyCount(GlobalShopInfo tier)
		{
			return default;
		}

		[Token(Token = "0x600160F")]
		[Address(RVA = "0x3E25FAC", Offset = "0x3E21FAC", VA = "0x3E25FAC")]
		public static bool IsTierSoldOut(GlobalShopInfo tier)
		{
			return default;
		}

		[Token(Token = "0x6001610")]
		[Address(RVA = "0x3E26030", Offset = "0x3E22030", VA = "0x3E26030")]
		public static GlobalShopInfo GetCurrentDisplayShopInfo()
		{
			return null;
		}

		[Token(Token = "0x6001611")]
		[Address(RVA = "0x3E26124", Offset = "0x3E22124", VA = "0x3E26124")]
		public static GlobalShopInfo GetDisplayShopInfoForUI()
		{
			return null;
		}

		[Token(Token = "0x6001612")]
		[Address(RVA = "0x3E2623C", Offset = "0x3E2223C", VA = "0x3E2623C")]
		public static bool HasAnyPurchasableTier()
		{
			return default;
		}

		[Token(Token = "0x6001613")]
		[Address(RVA = "0x3E26294", Offset = "0x3E22294", VA = "0x3E26294")]
		public static bool CanShowPurchasePopup()
		{
			return default;
		}

		[Token(Token = "0x6001614")]
		[Address(RVA = "0x3E26378", Offset = "0x3E22378", VA = "0x3E26378")]
		public static void EnsureWeeklyBuyCountKey(GlobalShopInfo tier)
		{
		}

		[Token(Token = "0x6001615")]
		[Address(RVA = "0x3E2580C", Offset = "0x3E2180C", VA = "0x3E2580C")]
		public static void SyncDisplayTierFromBuyCount()
		{
		}

		[Token(Token = "0x6001616")]
		[Address(RVA = "0x3E264A0", Offset = "0x3E224A0", VA = "0x3E264A0")]
		public static int GetDisplayPropCount(GlobalShopInfo displayTier)
		{
			return default;
		}

		[Token(Token = "0x6001617")]
		[Address(RVA = "0x3E2654C", Offset = "0x3E2254C", VA = "0x3E2654C")]
		public static string BuildRewardSegments(GlobalShopInfo tierRow)
		{
			return null;
		}

		[Token(Token = "0x6001618")]
		[Address(RVA = "0x3E254B0", Offset = "0x3E214B0", VA = "0x3E254B0")]
		public static void RefreshFromGlobalTemplate()
		{
		}

		[Token(Token = "0x6001619")]
		[Address(RVA = "0x3E2571C", Offset = "0x3E2171C", VA = "0x3E2571C")]
		public static void SyncPropCountFromDisplayTierIfChanged()
		{
		}

		[Token(Token = "0x600161A")]
		[Address(RVA = "0x3E26768", Offset = "0x3E22768", VA = "0x3E26768")]
		public static void RefreshPropAfterPurchase(GlobalShopInfo purchasedTier)
		{
		}

		[Token(Token = "0x600161B")]
		[Address(RVA = "0x3E26984", Offset = "0x3E22984", VA = "0x3E26984")]
		private static List<GlobalPropInfo> BuildSameRarePool(string rareLevel)
		{
			return null;
		}

		[Token(Token = "0x600161C")]
		[Address(RVA = "0x3E26B18", Offset = "0x3E22B18", VA = "0x3E26B18")]
		private static GlobalPropInfo PickWithoutReplacement(List<GlobalPropInfo> pool, string oldId, List<string> drawnPropIds)
		{
			return null;
		}

		[Token(Token = "0x600161D")]
		[Address(RVA = "0x3E26C4C", Offset = "0x3E22C4C", VA = "0x3E26C4C")]
		private static List<GlobalPropInfo> BuildCandidates(List<GlobalPropInfo> pool, string oldId, List<string> drawnPropIds)
		{
			return null;
		}

		[Token(Token = "0x600161E")]
		[Address(RVA = "0x3E255E0", Offset = "0x3E215E0", VA = "0x3E255E0")]
		private static void RecordDrawnPropId(string propId)
		{
		}

		[Token(Token = "0x600161F")]
		[Address(RVA = "0x3E25404", Offset = "0x3E21404", VA = "0x3E25404")]
		private static void EnsureDrawnList()
		{
		}

		[Token(Token = "0x6001620")]
		[Address(RVA = "0x3E26E1C", Offset = "0x3E22E1C", VA = "0x3E26E1C")]
		private static void OnTimeToMonDayZero(object o)
		{
		}

		[Token(Token = "0x6001621")]
		[Address(RVA = "0x3E26E68", Offset = "0x3E22E68", VA = "0x3E26E68")]
		private static void OnWeekPassed()
		{
		}
	}
}
