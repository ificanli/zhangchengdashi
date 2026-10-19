using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x20002F8")]
	public class EnemyPropBattleEntry
	{
		[Token(Token = "0x40022DC")]
		[FieldOffset(Offset = "0x10")]
		public string infoId;

		[Token(Token = "0x40022DD")]
		[FieldOffset(Offset = "0x18")]
		public int level;

		[Token(Token = "0x40022DE")]
		[FieldOffset(Offset = "0x1C")]
		public int startLevel;

		[Token(Token = "0x6000D3C")]
		[Address(RVA = "0x3D5876C", Offset = "0x3D5476C", VA = "0x3D5876C")]
		public EnemyPropBattleEntry()
		{
		}
	}
}
