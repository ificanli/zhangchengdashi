using GameModule;
using Il2CppDummyDll;

namespace DataModule
{
	[Token(Token = "0x2000E5F")]
	public class GlobalCardTalentInfo : GlobalInfoBase
	{
		[Token(Token = "0x400640D")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		[Token(Token = "0x400640E")]
		[FieldOffset(Offset = "0x20")]
		public string iLocNameKey;

		[Token(Token = "0x400640F")]
		[FieldOffset(Offset = "0x28")]
		public string iLocDesKey;

		[Token(Token = "0x4006410")]
		[FieldOffset(Offset = "0x30")]
		public string des;

		[Token(Token = "0x4006411")]
		[FieldOffset(Offset = "0x38")]
		public string value;

		[Token(Token = "0x4006412")]
		[FieldOffset(Offset = "0x40")]
		public string valueType;

		[Token(Token = "0x4006413")]
		[FieldOffset(Offset = "0x48")]
		public string upgradePrice;

		[Token(Token = "0x4006414")]
		[FieldOffset(Offset = "0x50")]
		public string rareLevel;

		[Token(Token = "0x4006415")]
		[FieldOffset(Offset = "0x58")]
		public string triggerTiming;

		[Token(Token = "0x4006416")]
		[FieldOffset(Offset = "0x60")]
		public string talentPriority;

		[Token(Token = "0x4006417")]
		[FieldOffset(Offset = "0x68")]
		public string talentIconPath;

		[Token(Token = "0x6005803")]
		[Address(RVA = "0x435A6C4", Offset = "0x43566C4", VA = "0x435A6C4")]
		public GameEventType GetTriggerType()
		{
			return default;
		}

		[Token(Token = "0x6005804")]
		[Address(RVA = "0x435A734", Offset = "0x4356734", VA = "0x435A734")]
		public GlobalCardTalentInfo()
		{
		}
	}
}
