using Il2CppDummyDll;

namespace L_Tools
{
	[Token(Token = "0x2000FBA")]
	public class FringeConfig
	{
		[Token(Token = "0x4006BA2")]
		[FieldOffset(Offset = "0x10")]
		public float LeftOffset;

		[Token(Token = "0x4006BA3")]
		[FieldOffset(Offset = "0x14")]
		public float RightOffset;

		[Token(Token = "0x6005E3D")]
		[Address(RVA = "0x43FAA30", Offset = "0x43F6A30", VA = "0x43FAA30")]
		public FringeConfig(float LeftOffset, float RightOffset)
		{
		}
	}
}
