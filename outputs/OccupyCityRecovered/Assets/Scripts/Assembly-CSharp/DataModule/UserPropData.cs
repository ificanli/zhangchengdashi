using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GameModule;
using Il2CppDummyDll;
using Newtonsoft.Json;
using ljzs_lt;

namespace DataModule
{
	[Token(Token = "0x2000EED")]
	public class UserPropData : UserDataBase
	{
		[Token(Token = "0x2000EEE")]
		[Flags]
		public enum PropCannotUpgradeLevelReason
		{
			[Token(Token = "0x40067BA")]
			None = 0,
			[Token(Token = "0x40067BB")]
			NoPropInfo = 1,
			[Token(Token = "0x40067BC")]
			IsMaxLevel = 2,
			[Token(Token = "0x40067BD")]
			NeedRank = 4,
			[Token(Token = "0x40067BE")]
			NotEnoughCrystal = 8
		}

		[Token(Token = "0x40067AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[JsonProperty("l")]
		public int level;

		[Token(Token = "0x40067B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[JsonProperty("ie")]
		public bool isEquip;

		[Token(Token = "0x40067B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[JsonProperty("ii")]
		public string infoId;

		[Token(Token = "0x40067B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[JsonProperty("c")]
		public string count;

		[Token(Token = "0x40067B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int startLevel;

		[Token(Token = "0x40067B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public List<string> traitList;

		[Token(Token = "0x40067B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool hadGetRareLevel;

		[Token(Token = "0x40067B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private RareLevel _rareLevel;

		[Token(Token = "0x40067B7")]
		public const int MaxLevel = 150;

		[Token(Token = "0x40067B8")]
		public const int MaxStarLevel = 30;

		[Token(Token = "0x17000F39")]
		public int Count
		{
			[Token(Token = "0x6005A13")]
			[Address(RVA = "0x4379A00", Offset = "0x4375A00", VA = "0x4379A00")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6005A14")]
		[Address(RVA = "0x436E638", Offset = "0x436A638", VA = "0x436E638")]
		public UserPropData()
		{
		}

		[Token(Token = "0x6005A15")]
		[Address(RVA = "0x436D538", Offset = "0x4369538", VA = "0x436D538")]
		public UserPropData(GlobalPropInfo assetInfo)
		{
		}

		[Token(Token = "0x6005A16")]
		[Address(RVA = "0x4379A0C", Offset = "0x4375A0C", VA = "0x4379A0C")]
		public GlobalPropInfo GetInfo()
		{
			return null;
		}

		[Token(Token = "0x6005A17")]
		[Address(RVA = "0x4379A88", Offset = "0x4375A88", VA = "0x4379A88", Slot = "4")]
		public virtual RareLevel GetRareLevel()
		{
			return default;
		}

		[Token(Token = "0x6005A18")]
		[Address(RVA = "0x4379B74", Offset = "0x4375B74", VA = "0x4379B74")]
		public void AddPropLevel()
		{
		}

		[Token(Token = "0x6005A19")]
		[Address(RVA = "0x4379C3C", Offset = "0x4375C3C", VA = "0x4379C3C")]
		public void AddStarLevel()
		{
		}

		[Token(Token = "0x6005A1A")]
		[Address(RVA = "0x436DE9C", Offset = "0x4369E9C", VA = "0x436DE9C")]
		public void ChangePropCount(int cardCount, CurrencyTransactionSceneType type)
		{
		}

		[Token(Token = "0x6005A1B")]
		[Address(RVA = "0x4379E3C", Offset = "0x4375E3C", VA = "0x4379E3C")]
		public int GetUpgradeCrystalCost([Optional] PropUpgradeInfoConfig upgradeInfo)
		{
			return default;
		}

		[Token(Token = "0x6005A1C")]
		[Address(RVA = "0x4379D2C", Offset = "0x4375D2C", VA = "0x4379D2C")]
		public int GetStarUpgradeCost()
		{
			return default;
		}

		[Token(Token = "0x6005A1D")]
		[Address(RVA = "0x4379F38", Offset = "0x4375F38", VA = "0x4379F38")]
		public bool IsUpgrade(out uint reason, out int needStar)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED UserPropData.IsUpgrade RVA=0x4379F38 Token=0x6005A1D");
}

		[Token(Token = "0x6005A1E")]
		[Address(RVA = "0x437A0E8", Offset = "0x43760E8", VA = "0x437A0E8")]
		public bool IsUpgradeStar()
		{
			return default;
		}

		[Token(Token = "0x6005A1F")]
		[Address(RVA = "0x437A13C", Offset = "0x437613C", VA = "0x437A13C")]
		public float GetStarUpgradeProgress()
		{
			return default;
		}

		[Token(Token = "0x6005A20")]
		[Address(RVA = "0x4379C2C", Offset = "0x4375C2C", VA = "0x4379C2C")]
		public bool IsMaxLevel()
		{
			return default;
		}

		[Token(Token = "0x6005A21")]
		[Address(RVA = "0x437A12C", Offset = "0x437612C", VA = "0x437A12C")]
		public bool IsMaxStar()
		{
			return default;
		}

		[Token(Token = "0x6005A22")]
		[Address(RVA = "0x437A198", Offset = "0x4376198", VA = "0x437A198")]
		public bool IsUnlock()
		{
			return default;
		}
	}
}
