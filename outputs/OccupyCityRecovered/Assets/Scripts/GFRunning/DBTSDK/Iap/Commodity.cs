using Il2CppDummyDll;

namespace DBTSDK.Iap
{
	[Token(Token = "0x20002C1")]
	public class Commodity
	{
		[Token(Token = "0x400170F")]
		[FieldOffset(Offset = "0x10")]
		public string GameKey;

		[Token(Token = "0x4001710")]
		[FieldOffset(Offset = "0x18")]
		public string productType;

		[Token(Token = "0x4001711")]
		[FieldOffset(Offset = "0x20")]
		public int state;

		[Token(Token = "0x4001712")]
		[FieldOffset(Offset = "0x28")]
		public string dataTime;

		[Token(Token = "0x6005059")]
		[Address(RVA = "0x710C998", Offset = "0x7108998", VA = "0x710C998")]
		public Commodity()
		{
		}
	}
}
