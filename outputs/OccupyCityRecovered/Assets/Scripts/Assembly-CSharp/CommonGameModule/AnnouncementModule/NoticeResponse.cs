using System.Collections.Generic;
using Il2CppDummyDll;

namespace CommonGameModule.AnnouncementModule
{
	[Token(Token = "0x2000FD4")]
	public class NoticeResponse
	{
		[Token(Token = "0x4006BF5")]
		[FieldOffset(Offset = "0x10")]
		public long clientVersion;

		[Token(Token = "0x4006BF6")]
		[FieldOffset(Offset = "0x18")]
		public long serverVersion;

		[Token(Token = "0x4006BF7")]
		[FieldOffset(Offset = "0x20")]
		public List<NoticeDO> list;

		[Token(Token = "0x6005ED7")]
		[Address(RVA = "0x43FF030", Offset = "0x43FB030", VA = "0x43FF030")]
		public NoticeResponse()
		{
		}
	}
}
