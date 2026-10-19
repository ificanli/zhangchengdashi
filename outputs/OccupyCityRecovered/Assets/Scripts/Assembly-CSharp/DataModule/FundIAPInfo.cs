using System.Collections.Generic;
using Il2CppDummyDll;

namespace DataModule
{
	[Token(Token = "0x2000E4B")]
	public class FundIAPInfo : GlobalInfoBase
	{
		[Token(Token = "0x4006384")]
		[FieldOffset(Offset = "0x18")]
		public string iapID1;

		[Token(Token = "0x4006385")]
		[FieldOffset(Offset = "0x20")]
		public string iapID2;

		[Token(Token = "0x4006386")]
		[FieldOffset(Offset = "0x28")]
		public string reward1IAPID;

		[Token(Token = "0x4006387")]
		[FieldOffset(Offset = "0x30")]
		public string reward2IAPID;

		[Token(Token = "0x4006388")]
		[FieldOffset(Offset = "0x38")]
		public string reward3IAPID;

		[Token(Token = "0x4006389")]
		[FieldOffset(Offset = "0x40")]
		public string name;

		[Token(Token = "0x400638A")]
		[FieldOffset(Offset = "0x48")]
		public string des;

		[Token(Token = "0x400638B")]
		[FieldOffset(Offset = "0x50")]
		private List<string> allIAPIDs;

		[Token(Token = "0x400638C")]
		[FieldOffset(Offset = "0x58")]
		public string fundBtnIconPath;

		[Token(Token = "0x400638D")]
		[FieldOffset(Offset = "0x60")]
		public string bgIconPath;

		[Token(Token = "0x400638E")]
		[FieldOffset(Offset = "0x68")]
		public string fundIntroduction;

		[Token(Token = "0x400638F")]
		[FieldOffset(Offset = "0x70")]
		public string currentActivityIntroduction;

		[Token(Token = "0x60057C0")]
		[Address(RVA = "0x4357C78", Offset = "0x4353C78", VA = "0x4357C78")]
		public List<string> GetAllIAPID()
		{
			return null;
		}

		[Token(Token = "0x60057C1")]
		[Address(RVA = "0x4357E30", Offset = "0x4353E30", VA = "0x4357E30")]
		public FundIAPInfo()
		{
		}
	}
}
