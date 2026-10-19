using Il2CppDummyDll;

namespace GameFramework.Net.Http
{
	[Token(Token = "0x2000468")]
	public class RequestLogin : IRequesData
	{
		[Token(Token = "0x4001E6A")]
		[FieldOffset(Offset = "0x10")]
		public string userId;

		[Token(Token = "0x4001E6B")]
		[FieldOffset(Offset = "0x18")]
		public string userCategory;

		[Token(Token = "0x4001E6C")]
		[FieldOffset(Offset = "0x20")]
		public string userExt;

		[Token(Token = "0x4001E6D")]
		[FieldOffset(Offset = "0x28")]
		public string phone;

		[Token(Token = "0x4001E6E")]
		[FieldOffset(Offset = "0x30")]
		public string channel;

		[Token(Token = "0x4001E6F")]
		[FieldOffset(Offset = "0x38")]
		public string env;

		[Token(Token = "0x4001E70")]
		[FieldOffset(Offset = "0x40")]
		public string packVersion;

		[Token(Token = "0x4001E71")]
		[FieldOffset(Offset = "0x48")]
		public string deviceID;

		[Token(Token = "0x4001E72")]
		[FieldOffset(Offset = "0x50")]
		public string packId;

		[Token(Token = "0x4001E73")]
		[FieldOffset(Offset = "0x58")]
		public string os;

		[Token(Token = "0x4001E74")]
		[FieldOffset(Offset = "0x60")]
		public string subjectChangeBind;

		[Token(Token = "0x4001E75")]
		[FieldOffset(Offset = "0x68")]
		public string rdid;

		[Token(Token = "0x6006BBB")]
		[Address(RVA = "0x7285F28", Offset = "0x7281F28", VA = "0x7285F28")]
		public RequestLogin()
		{
		}
	}
}
