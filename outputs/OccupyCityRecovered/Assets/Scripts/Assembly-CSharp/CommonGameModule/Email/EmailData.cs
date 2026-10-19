using System;
using Il2CppDummyDll;

namespace CommonGameModule.Email
{
	[Serializable]
	[Token(Token = "0x2001000")]
	public class EmailData
	{
		[Token(Token = "0x4006CA5")]
		[FieldOffset(Offset = "0x10")]
		public string attachment;

		[Token(Token = "0x4006CA6")]
		[FieldOffset(Offset = "0x18")]
		public string body;

		[Token(Token = "0x4006CA7")]
		[FieldOffset(Offset = "0x20")]
		public int form;

		[Token(Token = "0x4006CA8")]
		[FieldOffset(Offset = "0x28")]
		public long id;

		[Token(Token = "0x4006CA9")]
		[FieldOffset(Offset = "0x30")]
		public int state;

		[Token(Token = "0x4006CAA")]
		[FieldOffset(Offset = "0x38")]
		public long timeCreated;

		[Token(Token = "0x4006CAB")]
		[FieldOffset(Offset = "0x40")]
		public long timeExpired;

		[Token(Token = "0x4006CAC")]
		[FieldOffset(Offset = "0x48")]
		public string title;

		[Token(Token = "0x6005FEF")]
		[Address(RVA = "0x440D944", Offset = "0x4409944", VA = "0x440D944")]
		public EmailData()
		{
		}
	}
}
