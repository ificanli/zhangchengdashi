using Il2CppDummyDll;

namespace GameFramework.Net.Http
{
	[Token(Token = "0x200046E")]
	public class LoginOutData : IRequesData
	{
		[Token(Token = "0x4001E83")]
		[FieldOffset(Offset = "0x10")]
		public int mode;

		[Token(Token = "0x4001E84")]
		[FieldOffset(Offset = "0x18")]
		public string userId;

		[Token(Token = "0x4001E85")]
		[FieldOffset(Offset = "0x20")]
		public long uid;

		[Token(Token = "0x6006BC1")]
		[Address(RVA = "0x7285FCC", Offset = "0x7281FCC", VA = "0x7285FCC")]
		public LoginOutData()
		{
		}
	}
}
