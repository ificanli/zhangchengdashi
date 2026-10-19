using System.Collections.Generic;
using Il2CppDummyDll;

namespace DataModule
{
	[Token(Token = "0x2000EAC")]
	public class PlayerExpressionData
	{
		[Token(Token = "0x4006605")]
		[FieldOffset(Offset = "0x10")]
		public List<string> HaveExpression;

		[Token(Token = "0x4006606")]
		[FieldOffset(Offset = "0x18")]
		public List<string> UseExpression;

		[Token(Token = "0x600591D")]
		[Address(RVA = "0x4368CC8", Offset = "0x4364CC8", VA = "0x4368CC8")]
		public PlayerExpressionData()
		{
		}
	}
}
