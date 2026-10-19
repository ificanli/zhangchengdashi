using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ljzs_lt;

namespace GameModule
{
	[Token(Token = "0x2000601")]
	internal sealed class WorldCupDailyGiftService
	{
		[Token(Token = "0x4003219")]
		[FieldOffset(Offset = "0x10")]
		private readonly WorldCupActivityState _state;

		[Token(Token = "0x400321A")]
		[FieldOffset(Offset = "0x18")]
		private readonly Action _refreshAll;

		[Token(Token = "0x400321B")]
		[FieldOffset(Offset = "0x20")]
		private readonly List<string> _registeredIapProductIds;

		[Token(Token = "0x400321C")]
		[FieldOffset(Offset = "0x28")]
		private bool _iapListenersRegistered;

		[Token(Token = "0x6001FD1")]
		[Address(RVA = "0x3F0AE10", Offset = "0x3F06E10", VA = "0x3F0AE10")]
		public WorldCupDailyGiftService(WorldCupActivityState state, Action refreshAll)
		{
		}

		[Token(Token = "0x6001FD2")]
		[Address(RVA = "0x3F0AEA4", Offset = "0x3F06EA4", VA = "0x3F0AEA4")]
		public void RegisterIapListeners()
		{
		}

		[Token(Token = "0x6001FD3")]
		[Address(RVA = "0x3F0B150", Offset = "0x3F07150", VA = "0x3F0B150")]
		public void UnregisterIapListeners()
		{
		}

		[Token(Token = "0x6001FD4")]
		[Address(RVA = "0x3F0B258", Offset = "0x3F07258", VA = "0x3F0B258")]
		public int GetPackDailyBuyCount(int packId)
		{
			return default;
		}

		[Token(Token = "0x6001FD5")]
		[Address(RVA = "0x3F0B404", Offset = "0x3F07404", VA = "0x3F0B404")]
		public bool HasClaimableGift()
		{
			return default;
		}

		[Token(Token = "0x6001FD6")]
		[Address(RVA = "0x3F0B58C", Offset = "0x3F0758C", VA = "0x3F0B58C")]
		public int GetPackRemainBuyCount(WorldCupdailyPriceConfig config)
		{
			return default;
		}

		[Token(Token = "0x6001FD7")]
		[Address(RVA = "0x3F0B5BC", Offset = "0x3F075BC", VA = "0x3F0B5BC")]
		public bool TryClaimFreeGift(int configId, out string errorMessage)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED WorldCupDailyGiftService.TryClaimFreeGift RVA=0x3F0B5BC Token=0x6001FD7");
}

		[Token(Token = "0x6001FD8")]
		[Address(RVA = "0x3F0B8A0", Offset = "0x3F078A0", VA = "0x3F0B8A0")]
		public bool TryGrantPurchasedGift(int configId, out string errorMessage)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED WorldCupDailyGiftService.TryGrantPurchasedGift RVA=0x3F0B8A0 Token=0x6001FD8");
}

		[Token(Token = "0x6001FD9")]
		[Address(RVA = "0x3F0B2A0", Offset = "0x3F072A0", VA = "0x3F0B2A0")]
		public void EnsureData()
		{
		}

		[Token(Token = "0x6001FDA")]
		[Address(RVA = "0x3F0BA84", Offset = "0x3F07A84", VA = "0x3F0BA84")]
		private void OnPurchaseComplete(string productId)
		{
		}

		[Token(Token = "0x6001FDB")]
		[Address(RVA = "0x3F0B7A0", Offset = "0x3F077A0", VA = "0x3F0B7A0")]
		private void MarkPackBought(int configId)
		{
		}

		[Token(Token = "0x6001FDC")]
		[Address(RVA = "0x3F0B884", Offset = "0x3F07884", VA = "0x3F0B884")]
		private void NotifyRefresh()
		{
		}
	}
}
