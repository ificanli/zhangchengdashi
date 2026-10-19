using Il2CppDummyDll;

namespace DataModule
{
	[Token(Token = "0x2000E85")]
	public class GlobalMainCityTitleInfo : GlobalInfoBase
	{
		[Token(Token = "0x400652D")]
		[FieldOffset(Offset = "0x18")]
		public string titleLevel;

		[Token(Token = "0x400652E")]
		[FieldOffset(Offset = "0x20")]
		public string hexLevel;

		[Token(Token = "0x400652F")]
		[FieldOffset(Offset = "0x28")]
		public string hexPrice;

		[Token(Token = "0x4006530")]
		[FieldOffset(Offset = "0x30")]
		public string name;

		[Token(Token = "0x4006531")]
		[FieldOffset(Offset = "0x38")]
		public string cnName;

		[Token(Token = "0x4006532")]
		[FieldOffset(Offset = "0x40")]
		public string reward1_Gem;

		[Token(Token = "0x4006533")]
		[FieldOffset(Offset = "0x48")]
		public string reward2_Gem;

		[Token(Token = "0x4006534")]
		[FieldOffset(Offset = "0x50")]
		public string reward3_Gem;

		[Token(Token = "0x4006535")]
		[FieldOffset(Offset = "0x58")]
		public string reward2_OutsideGold;

		[Token(Token = "0x4006536")]
		[FieldOffset(Offset = "0x60")]
		public string reward3_OutsideGold;

		[Token(Token = "0x4006537")]
		[FieldOffset(Offset = "0x68")]
		public string nameKey;

		[Token(Token = "0x4006538")]
		[FieldOffset(Offset = "0x70")]
		public string icon;

		[Token(Token = "0x4006539")]
		[FieldOffset(Offset = "0x78")]
		public string attack;

		[Token(Token = "0x400653A")]
		[FieldOffset(Offset = "0x80")]
		public string hp;

		[Token(Token = "0x400653B")]
		[FieldOffset(Offset = "0x88")]
		public string gold;

		[Token(Token = "0x400653C")]
		[FieldOffset(Offset = "0x90")]
		public string idleRewardPerMins;

		[Token(Token = "0x400653D")]
		[FieldOffset(Offset = "0x98")]
		public string maxRewardMins;

		[Token(Token = "0x60058AB")]
		[Address(RVA = "0x436487C", Offset = "0x436087C", VA = "0x436487C")]
		public GlobalMainCityTitleInfo()
		{
		}
	}
}
