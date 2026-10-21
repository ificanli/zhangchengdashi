using System;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace DataModule
{
	[Serializable]
	[Token(Token = "0x2000ED7")]
	public class Talent2Data
	{
		[Token(Token = "0x40066FC")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		[Token(Token = "0x40066FD")]
		[FieldOffset(Offset = "0x18")]
		[JsonProperty("bid")]
		public string baseId;

		[Token(Token = "0x40066FE")]
		[FieldOffset(Offset = "0x20")]
		[JsonProperty("l")]
		public int level;

		[Token(Token = "0x40066FF")]
		[FieldOffset(Offset = "0x24")]
		[JsonProperty("ti")]
		public int talentIndex;

		[Token(Token = "0x60059C3")]
		[Address(RVA = "0x4376B78", Offset = "0x4372B78", VA = "0x4376B78")]
		public bool IsUnLock()
		{ return level > 0; }

		[Token(Token = "0x60059C4")]
		[Address(RVA = "0x4376B88", Offset = "0x4372B88", VA = "0x4376B88")]
		public Talent2Data()
		{
		}
	}
}
