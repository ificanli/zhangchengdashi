using DataModule;
using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x200034F")]
	public class DeadUnitInfo
	{
		[Token(Token = "0x4002462")]
		[FieldOffset(Offset = "0x10")]
		public GlobalRoleInfo roleInfo;

		[Token(Token = "0x4002463")]
		[FieldOffset(Offset = "0x18")]
		public bool isEnemy;

		[Token(Token = "0x4002464")]
		[FieldOffset(Offset = "0x1C")]
		public int cardLevel;

		[Token(Token = "0x4002465")]
		[FieldOffset(Offset = "0x20")]
		public RareLevel rareLevel;

		[Token(Token = "0x4002466")]
		[FieldOffset(Offset = "0x28")]
		public string cardId;

		[Token(Token = "0x4002467")]
		[FieldOffset(Offset = "0x30")]
		public CardFettersType cardFettersType;

		[Token(Token = "0x4002468")]
		[FieldOffset(Offset = "0x34")]
		public AtkWayType atkWayType;

		[Token(Token = "0x6000EC3")]
		[Address(RVA = "0x3D78180", Offset = "0x3D74180", VA = "0x3D78180")]
		public DeadUnitInfo(GlobalRoleInfo roleInfo, bool isEnemy, int cardLevel, RareLevel rareLevel, string cardId, CardFettersType cardFettersType, AtkWayType atkWayType)
		{
		}
	}
}
