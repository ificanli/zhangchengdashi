using Il2CppDummyDll;

namespace DBTSDK
{
	[Token(Token = "0x20001FF")]
	public class Plugin
	{
		[Token(Token = "0x4000742")]
		[FieldOffset(Offset = "0x10")]
		public string appId;

		[Token(Token = "0x4000743")]
		[FieldOffset(Offset = "0x18")]
		public string version;

		[Token(Token = "0x60019E9")]
		[Address(RVA = "0x70B8E94", Offset = "0x70B4E94", VA = "0x70B8E94")]
		public Plugin()
		{
		}
	}
}
