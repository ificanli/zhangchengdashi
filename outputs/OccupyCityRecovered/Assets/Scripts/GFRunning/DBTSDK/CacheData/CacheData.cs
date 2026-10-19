using System.Collections.Generic;
using Il2CppDummyDll;

namespace DBTSDK.CacheData
{
	[Token(Token = "0x2000216")]
	public class CacheData
	{
		[Token(Token = "0x400075E")]
		[FieldOffset(Offset = "0x10")]
		public List<GuideCacheData> StartguideCount;

		[Token(Token = "0x400075F")]
		[FieldOffset(Offset = "0x18")]
		public List<GuideCacheData> CompleteguideCount;

		[Token(Token = "0x4000760")]
		[FieldOffset(Offset = "0x20")]
		public List<string> OnceReportKeys;

		[Token(Token = "0x4000761")]
		[FieldOffset(Offset = "0x28")]
		public int RemoveAdsState;

		[Token(Token = "0x4000762")]
		[FieldOffset(Offset = "0x30")]
		public List<string> OnceReportEvent;

		[Token(Token = "0x4000763")]
		[FieldOffset(Offset = "0x38")]
		public List<string> EventReportQueue;

		[Token(Token = "0x4000764")]
		[FieldOffset(Offset = "0x40")]
		public List<string> EventReportFailQueue;

		[Token(Token = "0x6001B47")]
		[Address(RVA = "0x70D870C", Offset = "0x70D470C", VA = "0x70D870C")]
		public static GuideCacheData GetGuideCacheData(int GuideID, List<GuideCacheData> Data)
		{
			return null;
		}

		[Token(Token = "0x6001B48")]
		[Address(RVA = "0x70D8874", Offset = "0x70D4874", VA = "0x70D8874")]
		public CacheData()
		{
		}
	}
}
