using System;
using Il2CppDummyDll;
using ljzs_lt;

namespace GameModule
{
	[Token(Token = "0x2000610")]
	public class WorldCupPointShopService
	{
		[Token(Token = "0x4003259")]
		[FieldOffset(Offset = "0x10")]
		private readonly WorldCupActivityState _state;

		[Token(Token = "0x400325A")]
		[FieldOffset(Offset = "0x18")]
		private readonly Action _refreshAll;

		[Token(Token = "0x6002062")]
		[Address(RVA = "0x3F05944", Offset = "0x3F01944", VA = "0x3F05944")]
		public WorldCupPointShopService(WorldCupActivityState state, Action refreshAll)
		{
		}

		[Token(Token = "0x6002063")]
		[Address(RVA = "0x3F074C0", Offset = "0x3F034C0", VA = "0x3F074C0")]
		public int GetShopBuyCount(int configId)
		{
			return default;
		}

		[Token(Token = "0x6002064")]
		[Address(RVA = "0x3F0750C", Offset = "0x3F0350C", VA = "0x3F0750C")]
		public int GetShopRemainBuyCount(PointShopConfig config)
		{
			return default;
		}

		[Token(Token = "0x6002065")]
		[Address(RVA = "0x3F07590", Offset = "0x3F03590", VA = "0x3F07590")]
		public bool IsShopSoldOut(PointShopConfig config)
		{
			return default;
		}

		[Token(Token = "0x6002066")]
		[Address(RVA = "0x3F075CC", Offset = "0x3F035CC", VA = "0x3F075CC")]
		public bool TryPurchasePointShopItem(int configId, out string errorMessage)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED WorldCupPointShopService.TryPurchasePointShopItem RVA=0x3F075CC Token=0x6002066");
}

		[Token(Token = "0x6002067")]
		[Address(RVA = "0x3F077A0", Offset = "0x3F037A0", VA = "0x3F077A0")]
		public bool TryValidatePointShopPurchase(int configId, out string errorMessage)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED WorldCupPointShopService.TryValidatePointShopPurchase RVA=0x3F077A0 Token=0x6002067");
}

		[Token(Token = "0x6002068")]
		[Address(RVA = "0x3F0FF50", Offset = "0x3F0BF50", VA = "0x3F0FF50")]
		private bool TryGetBuyCurrencyCount(int buyItem, out int balance)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED WorldCupPointShopService.TryGetBuyCurrencyCount RVA=0x3F0FF50 Token=0x6002068");
}

		[Token(Token = "0x6002069")]
		[Address(RVA = "0x3F0FE2C", Offset = "0x3F0BE2C", VA = "0x3F0FE2C")]
		private bool TryConsumeBuyCurrency(int buyItem, int count)
		{
			return default;
		}
	}
}
