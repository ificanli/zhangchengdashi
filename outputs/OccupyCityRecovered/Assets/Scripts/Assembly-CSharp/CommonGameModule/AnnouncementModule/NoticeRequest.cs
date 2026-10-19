using GameFramework.Net.Http;
using Il2CppDummyDll;

namespace CommonGameModule.AnnouncementModule
{
	[Token(Token = "0x2000FD3")]
	public class NoticeRequest : IRequesData
	{
		[Token(Token = "0x4006BF3")]
		[FieldOffset(Offset = "0x10")]
		public string clientTags;

		[Token(Token = "0x4006BF4")]
		[FieldOffset(Offset = "0x18")]
		public long clientVersion;

		[Token(Token = "0x6005ED6")]
		[Address(RVA = "0x43FF028", Offset = "0x43FB028", VA = "0x43FF028")]
		public NoticeRequest()
		{
		}
	}
}
