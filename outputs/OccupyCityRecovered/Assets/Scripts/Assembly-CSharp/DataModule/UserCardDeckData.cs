using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace DataModule
{
	[Serializable]
	[Token(Token = "0x2000EDD")]
	public class UserCardDeckData
	{
		[Token(Token = "0x4006722")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty("cdl")]
		public List<int> cardDeckList;

		[Token(Token = "0x60059E1")]
		[Address(RVA = "0x4370188", Offset = "0x436C188", VA = "0x4370188")]
		public UserCardDeckData()
		{
		}
	}
}
