using Il2CppDummyDll;

namespace GameFramework
{
	[Token(Token = "0x200040B")]
	public class MulTouchData
	{
		[Token(Token = "0x4001D4C")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		[Token(Token = "0x4001D4D")]
		[FieldOffset(Offset = "0x14")]
		public float x;

		[Token(Token = "0x4001D4E")]
		[FieldOffset(Offset = "0x18")]
		public float y;

		[Token(Token = "0x60062B5")]
		[Address(RVA = "0x720592C", Offset = "0x720192C", VA = "0x720592C")]
		public MulTouchData()
		{
		}
	}
}
