using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x200041A")]
	public class BattleResult
	{
		[Token(Token = "0x40028CE")]
		[FieldOffset(Offset = "0x10")]
		public BattleContext BattleContext;

		[Token(Token = "0x40028CF")]
		[FieldOffset(Offset = "0x18")]
		public bool isVictory;

		[Token(Token = "0x6001366")]
		[Address(RVA = "0x3DE3A94", Offset = "0x3DDFA94", VA = "0x3DE3A94")]
		public BattleResult()
		{
		}
	}
}
