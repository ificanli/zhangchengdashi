using DataModule;
using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x200048F")]
	public static class CardLevelResetService
	{
		[Token(Token = "0x2000490")]
		public sealed class Preview
		{
			[Token(Token = "0x4002B2B")]
			[FieldOffset(Offset = "0x10")]
			public UserHeroCardData CardData;

			[Token(Token = "0x4002B2C")]
			[FieldOffset(Offset = "0x18")]
			public int CurrentLevel;

			[Token(Token = "0x4002B2D")]
			[FieldOffset(Offset = "0x1C")]
			public int ResetLevel;

			[Token(Token = "0x4002B2E")]
			[FieldOffset(Offset = "0x20")]
			public int ReturnCoin;

			[Token(Token = "0x4002B2F")]
			[FieldOffset(Offset = "0x24")]
			public int ReturnCardCount;

			[Token(Token = "0x4002B30")]
			[FieldOffset(Offset = "0x28")]
			public int ReturnAbilityStone;

			[Token(Token = "0x4002B31")]
			[FieldOffset(Offset = "0x2C")]
			public int CostCount;

			[Token(Token = "0x4002B32")]
			[FieldOffset(Offset = "0x30")]
			public int HaveCostCount;

			[Token(Token = "0x4002B33")]
			[FieldOffset(Offset = "0x34")]
			public bool CanReset;

			[Token(Token = "0x4002B34")]
			[FieldOffset(Offset = "0x38")]
			public string ErrorMessage;

			[Token(Token = "0x600166D")]
			[Address(RVA = "0x3E4797C", Offset = "0x3E4397C", VA = "0x3E4797C")]
			public Preview()
			{
			}
		}

		[Token(Token = "0x4002B29")]
		public const int ResetCostCount = 1;

		[Token(Token = "0x4002B2A")]
		private const int GoldCardInitialAbilityStoneCost = 600;

		[Token(Token = "0x6001666")]
		[Address(RVA = "0x3E4783C", Offset = "0x3E4383C", VA = "0x3E4783C")]
		public static Preview BuildPreview(UserHeroCardData data)
		{
			return null;
		}

		[Token(Token = "0x6001667")]
		[Address(RVA = "0x3E47F7C", Offset = "0x3E43F7C", VA = "0x3E47F7C")]
		public static bool TryReset(UserHeroCardData data, out Preview preview)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED CardLevelResetService.TryReset RVA=0x3E47F7C Token=0x6001667");
}

		[Token(Token = "0x6001668")]
		[Address(RVA = "0x3E486A4", Offset = "0x3E446A4", VA = "0x3E486A4")]
		public static string BuildReturnRewardRaw(Preview preview)
		{
			return null;
		}

		[Token(Token = "0x6001669")]
		[Address(RVA = "0x3E47990", Offset = "0x3E43990", VA = "0x3E47990")]
		private static int CalculateReturnCoin(UserHeroCardData data)
		{
			return default;
		}

		[Token(Token = "0x600166A")]
		[Address(RVA = "0x3E47BBC", Offset = "0x3E43BBC", VA = "0x3E47BBC")]
		private static int CalculateReturnCardCount(UserHeroCardData data)
		{
			return default;
		}

		[Token(Token = "0x600166B")]
		[Address(RVA = "0x3E47D18", Offset = "0x3E43D18", VA = "0x3E47D18")]
		private static int CalculateReturnAbilityStone(string cardId)
		{
			return default;
		}

		[Token(Token = "0x600166C")]
		[Address(RVA = "0x3E4834C", Offset = "0x3E4434C", VA = "0x3E4834C")]
		private static void ResetTalent2Data(string cardId)
		{
		}
	}
}
