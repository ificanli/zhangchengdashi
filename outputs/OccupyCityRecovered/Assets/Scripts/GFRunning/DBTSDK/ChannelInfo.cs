using Il2CppDummyDll;

namespace DBTSDK
{
	[Token(Token = "0x20001D7")]
	public class ChannelInfo
	{
		[Token(Token = "0x400064B")]
		[FieldOffset(Offset = "0x10")]
		public string chnlAzb;

		[Token(Token = "0x400064C")]
		[FieldOffset(Offset = "0x18")]
		public string chnlAb;

		[Token(Token = "0x400064D")]
		[FieldOffset(Offset = "0x20")]
		public string chnlFlag;

		[Token(Token = "0x400064E")]
		[FieldOffset(Offset = "0x28")]
		public string chnlCountry;

		[Token(Token = "0x600183E")]
		[Address(RVA = "0x739D3E4", Offset = "0x73993E4", VA = "0x739D3E4")]
		public ChannelInfo()
		{
		}
	}
}
