using System.Collections.Generic;
using Il2CppDummyDll;

namespace DBTSDK.CacheData
{
	[Token(Token = "0x2000217")]
	public class GlobalCacheData
	{
		[Token(Token = "0x4000765")]
		[FieldOffset(Offset = "0x10")]
		public List<string> GameIsplayed;

		[Token(Token = "0x4000766")]
		[FieldOffset(Offset = "0x18")]
		public string lastGameName;

		[Token(Token = "0x4000767")]
		[FieldOffset(Offset = "0x20")]
		public string dev_id;

		[Token(Token = "0x6001B49")]
		[Address(RVA = "0x70D8998", Offset = "0x70D4998", VA = "0x70D8998")]
		public GlobalCacheData()
		{
		}
	}
}
