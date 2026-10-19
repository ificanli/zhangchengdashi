using System.Collections.Generic;
using Il2CppDummyDll;

namespace DataModule
{
	[Token(Token = "0x2000EAB")]
	public class PlayerBubbleData
	{
		[Token(Token = "0x4006603")]
		[FieldOffset(Offset = "0x10")]
		public List<string> HaveBubble;

		[Token(Token = "0x4006604")]
		[FieldOffset(Offset = "0x18")]
		public List<string> UseBubble;

		[Token(Token = "0x600591C")]
		[Address(RVA = "0x4368C30", Offset = "0x4364C30", VA = "0x4368C30")]
		public PlayerBubbleData()
		{
		}
	}
}
