using Il2CppDummyDll;

namespace GameFramework.Net.Http
{
	[Token(Token = "0x200046A")]
	public class RequestList : IRequesData
	{
		[Token(Token = "0x4001E78")]
		[FieldOffset(Offset = "0x10")]
		public string[] keys;

		[Token(Token = "0x6006BBD")]
		[Address(RVA = "0x7285F38", Offset = "0x7281F38", VA = "0x7285F38")]
		public RequestList()
		{
		}
	}
}
