using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace DataModule
{
	[Token(Token = "0x2000EDE")]
	public class UserCardTalentData
	{
		[Token(Token = "0x4006723")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty("mctn")]
		public int maxCostTalentNumber;

		[Token(Token = "0x4006724")]
		[FieldOffset(Offset = "0x18")]
		[JsonProperty("ctl")]
		public List<int> cardTalentList;

		[Token(Token = "0x60059E2")]
		[Address(RVA = "0x4370798", Offset = "0x436C798", VA = "0x4370798")]
		public bool AddOneCardTalent(int i)
		{
			return default;
		}

		[Token(Token = "0x60059E3")]
		[Address(RVA = "0x43772E4", Offset = "0x43732E4", VA = "0x43772E4")]
		public void RemoveOneCardTalent(int index)
		{
		}

		[Token(Token = "0x60059E4")]
		[Address(RVA = "0x4370790", Offset = "0x436C790", VA = "0x4370790")]
		public UserCardTalentData()
		{
		}
	}
}
