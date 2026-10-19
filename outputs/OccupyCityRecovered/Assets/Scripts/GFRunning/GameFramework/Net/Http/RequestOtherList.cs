using Il2CppDummyDll;

namespace GameFramework.Net.Http
{
	[Token(Token = "0x200046B")]
	public class RequestOtherList : IRequesData
	{
		[Token(Token = "0x4001E79")]
		[FieldOffset(Offset = "0x10")]
		public long uid;

		[Token(Token = "0x4001E7A")]
		[FieldOffset(Offset = "0x18")]
		public string[] keys;

		[Token(Token = "0x6006BBE")]
		[Address(RVA = "0x7285F40", Offset = "0x7281F40", VA = "0x7285F40")]
		public RequestOtherList()
		{
		}
	}
}
