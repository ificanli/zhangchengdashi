using System;
using GameModule;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace DataModule
{
	[Token(Token = "0x2000EE5")]
	public class UserHeroCardData : UserAssetData
	{
		[Token(Token = "0x400675B")]
		[FieldOffset(Offset = "0x70")]
		[JsonProperty("l")]
		public int level;

		[Token(Token = "0x400675C")]
		[FieldOffset(Offset = "0x74")]
		[JsonProperty("ie")]
		public bool isEquip;

		[Token(Token = "0x400675D")]
		[FieldOffset(Offset = "0x75")]
		[Obsolete("此字段已废弃，CardIsBTest已固定返回false")]
		[JsonProperty("if")]
		public bool isFound;

		[Token(Token = "0x400675E")]
		[FieldOffset(Offset = "0x78")]
		private GlobalHeroCardInfo _globalHeroCardInfo;

		[Token(Token = "0x17000F38")]
		public int Count
		{
			[Token(Token = "0x60059F1")]
			[Address(RVA = "0x4377E64", Offset = "0x4373E64", VA = "0x4377E64")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60059F2")]
		[Address(RVA = "0x4377E70", Offset = "0x4373E70", VA = "0x4377E70")]
		public UserHeroCardData()
		{
		}

		[Token(Token = "0x60059F3")]
		[Address(RVA = "0x436FFBC", Offset = "0x436BFBC", VA = "0x436FFBC")]
		public UserHeroCardData(GlobalHeroCardInfo heroCardInfo, bool isEquip = false)
		{
		}

		[Token(Token = "0x60059F4")]
		[Address(RVA = "0x4377E78", Offset = "0x4373E78", VA = "0x4377E78")]
		public void ChangeCardCount(int cardCount, CurrencyTransactionSceneType type)
		{
		}

		[Token(Token = "0x60059F5")]
		[Address(RVA = "0x4370018", Offset = "0x436C018", VA = "0x4370018")]
		public void AddCardLevel()
		{
		}

		[Token(Token = "0x60059F6")]
		[Address(RVA = "0x4378150", Offset = "0x4374150", VA = "0x4378150")]
		public new GlobalHeroCardInfo GetInfo()
		{
			return null;
		}

		[Token(Token = "0x60059F7")]
		[Address(RVA = "0x4378224", Offset = "0x4374224", VA = "0x4378224", Slot = "5")]
		public virtual RareLevel GetRareLevel()
		{
			return default;
		}

		[Token(Token = "0x60059F8")]
		[Address(RVA = "0x4378338", Offset = "0x4374338", VA = "0x4378338")]
		public bool IsUnlock()
		{
			return default;
		}
	}
}
