using Il2CppDummyDll;

namespace DBTSDK
{
	[Token(Token = "0x2000212")]
	public class WXCreateRewardedVideoAdParam
	{
		[Token(Token = "0x4000753")]
		[FieldOffset(Offset = "0x10")]
		public string adUnitId;

		[Token(Token = "0x4000754")]
		[FieldOffset(Offset = "0x18")]
		public bool multiton;

		[Token(Token = "0x6001B44")]
		[Address(RVA = "0x70D86F4", Offset = "0x70D46F4", VA = "0x70D86F4")]
		public WXCreateRewardedVideoAdParam()
		{
		}
	}
}
