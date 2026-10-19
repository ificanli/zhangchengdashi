using Il2CppDummyDll;

namespace CommonGameModule.AnnouncementModule
{
	[Token(Token = "0x2000FD5")]
	public class NoticeDO
	{
		[Token(Token = "0x4006BF8")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		[Token(Token = "0x4006BF9")]
		[FieldOffset(Offset = "0x14")]
		public int sort;

		[Token(Token = "0x4006BFA")]
		[FieldOffset(Offset = "0x18")]
		public string category;

		[Token(Token = "0x4006BFB")]
		[FieldOffset(Offset = "0x20")]
		public string title;

		[Token(Token = "0x4006BFC")]
		[FieldOffset(Offset = "0x28")]
		public string body;

		[Token(Token = "0x4006BFD")]
		[FieldOffset(Offset = "0x30")]
		public long startAt;

		[Token(Token = "0x4006BFE")]
		[FieldOffset(Offset = "0x38")]
		public long endAt;

		[Token(Token = "0x6005ED8")]
		[Address(RVA = "0x43FF038", Offset = "0x43FB038", VA = "0x43FF038")]
		public NoticeDO()
		{
		}
	}
}
