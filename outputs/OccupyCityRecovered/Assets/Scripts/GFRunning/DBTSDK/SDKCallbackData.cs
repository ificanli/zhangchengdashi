using Il2CppDummyDll;

namespace DBTSDK
{
	[Token(Token = "0x20001B9")]
	internal class SDKCallbackData
	{
		[Token(Token = "0x4000596")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		[Token(Token = "0x4000597")]
		[FieldOffset(Offset = "0x18")]
		public string json;

		[Token(Token = "0x6001545")]
		[Address(RVA = "0x7384E54", Offset = "0x7380E54", VA = "0x7384E54")]
		public SDKCallbackData()
		{
		}
	}
}
