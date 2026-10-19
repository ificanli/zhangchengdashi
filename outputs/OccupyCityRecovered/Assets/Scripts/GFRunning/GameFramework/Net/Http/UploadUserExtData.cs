using Il2CppDummyDll;

namespace GameFramework.Net.Http
{
	[Token(Token = "0x200046F")]
	public class UploadUserExtData : IRequesData
	{
		[Token(Token = "0x4001E86")]
		[FieldOffset(Offset = "0x10")]
		public string userExt;

		[Token(Token = "0x6006BC2")]
		[Address(RVA = "0x7285FD4", Offset = "0x7281FD4", VA = "0x7285FD4")]
		public UploadUserExtData()
		{
		}
	}
}
