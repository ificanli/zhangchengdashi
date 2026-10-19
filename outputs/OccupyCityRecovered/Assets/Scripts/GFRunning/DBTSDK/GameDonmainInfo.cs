using System.Collections.Generic;
using Il2CppDummyDll;

namespace DBTSDK
{
	[Token(Token = "0x20001BD")]
	public class GameDonmainInfo
	{
		[Token(Token = "0x40005AD")]
		[FieldOffset(Offset = "0x10")]
		public string group;

		[Token(Token = "0x40005AE")]
		[FieldOffset(Offset = "0x18")]
		public Publish publish;

		[Token(Token = "0x40005AF")]
		[FieldOffset(Offset = "0x20")]
		public List<Game> game;

		[Token(Token = "0x40005B0")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, SdkDomain> sdk;

		[Token(Token = "0x40005B1")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<string, CDNDomain> cdn;

		[Token(Token = "0x6001547")]
		[Address(RVA = "0x7384E64", Offset = "0x7380E64", VA = "0x7384E64")]
		public void Log(int logLv = 0)
		{
		}

		[Token(Token = "0x6001548")]
		[Address(RVA = "0x73852B0", Offset = "0x73812B0", VA = "0x73852B0")]
		public GameDonmainInfo()
		{
		}
	}
}
