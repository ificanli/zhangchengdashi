using Il2CppDummyDll;

namespace DBTSDK
{
	[Token(Token = "0x2000213")]
	public class WXCreateBannerAdParam
	{
		[Token(Token = "0x4000755")]
		[FieldOffset(Offset = "0x10")]
		public string adUnitId;

		[Token(Token = "0x4000756")]
		[FieldOffset(Offset = "0x18")]
		public int adIntervals;

		[Token(Token = "0x4000757")]
		[FieldOffset(Offset = "0x1C")]
		public int FixedHeight;

		[Token(Token = "0x4000758")]
		[FieldOffset(Offset = "0x20")]
		public Style style;

		[Token(Token = "0x6001B45")]
		[Address(RVA = "0x70D86FC", Offset = "0x70D46FC", VA = "0x70D86FC")]
		public WXCreateBannerAdParam()
		{
		}
	}
}
