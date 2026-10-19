using Il2CppDummyDll;

namespace GameFramework.Net.Http
{
	[Token(Token = "0x200046D")]
	public class CutoverLoginData : IRequesData
	{
		[Token(Token = "0x4001E7D")]
		[FieldOffset(Offset = "0x10")]
		public string userId;

		[Token(Token = "0x4001E7E")]
		[FieldOffset(Offset = "0x18")]
		public long mainUid;

		[Token(Token = "0x4001E7F")]
		[FieldOffset(Offset = "0x20")]
		public string guestUserId;

		[Token(Token = "0x4001E80")]
		[FieldOffset(Offset = "0x28")]
		public long guestUid;

		[Token(Token = "0x4001E81")]
		[FieldOffset(Offset = "0x30")]
		public bool keepGuestUserId;

		[Token(Token = "0x4001E82")]
		[FieldOffset(Offset = "0x38")]
		public string attachment;

		[Token(Token = "0x6006BC0")]
		[Address(RVA = "0x7285FC4", Offset = "0x7281FC4", VA = "0x7285FC4")]
		public CutoverLoginData()
		{
		}
	}
}
