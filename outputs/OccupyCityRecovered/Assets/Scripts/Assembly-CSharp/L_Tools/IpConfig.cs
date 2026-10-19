using System;
using Il2CppDummyDll;

namespace L_Tools
{
	[Serializable]
	[Token(Token = "0x2000F8D")]
	public class IpConfig
	{
		[Token(Token = "0x4006AFF")]
		[FieldOffset(Offset = "0x10")]
		public string NickName;

		[Token(Token = "0x4006B00")]
		[FieldOffset(Offset = "0x18")]
		public string URL;

		[Token(Token = "0x4006B01")]
		[FieldOffset(Offset = "0x20")]
		public int Port;

		[Token(Token = "0x4006B02")]
		[FieldOffset(Offset = "0x28")]
		public string GameKey;

		[Token(Token = "0x4006B03")]
		[FieldOffset(Offset = "0x30")]
		public string BusinessName;

		[Token(Token = "0x6005D4C")]
		[Address(RVA = "0x43B8794", Offset = "0x43B4794", VA = "0x43B8794")]
		public string GetFullURL(string url)
		{
			return null;
		}

		[Token(Token = "0x6005D4D")]
		[Address(RVA = "0x43B8878", Offset = "0x43B4878", VA = "0x43B8878")]
		public string GetURL()
		{
			return null;
		}

		[Token(Token = "0x6005D4E")]
		[Address(RVA = "0x43B8904", Offset = "0x43B4904", VA = "0x43B8904")]
		public IpConfig()
		{
		}
	}
}
