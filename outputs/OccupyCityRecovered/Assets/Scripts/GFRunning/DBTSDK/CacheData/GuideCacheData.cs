using Il2CppDummyDll;

namespace DBTSDK.CacheData
{
	[Token(Token = "0x2000218")]
	public class GuideCacheData
	{
		[Token(Token = "0x4000768")]
		[FieldOffset(Offset = "0x10")]
		public int guideId;

		[Token(Token = "0x4000769")]
		[FieldOffset(Offset = "0x14")]
		public int count;

		[Token(Token = "0x6001B4A")]
		[Address(RVA = "0x70D886C", Offset = "0x70D486C", VA = "0x70D886C")]
		public GuideCacheData()
		{
		}
	}
}
