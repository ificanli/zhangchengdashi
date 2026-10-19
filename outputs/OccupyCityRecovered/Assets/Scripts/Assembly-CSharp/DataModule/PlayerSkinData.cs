using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace DataModule
{
	[Serializable]
	[Token(Token = "0x2000EAD")]
	public class PlayerSkinData
	{
		[Token(Token = "0x4006607")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty("hb")]
		public List<string> HaveBanner;

		[Token(Token = "0x4006608")]
		[FieldOffset(Offset = "0x18")]
		[JsonProperty("ub")]
		public string UseBanner;

		[Token(Token = "0x600591E")]
		[Address(RVA = "0x4368D60", Offset = "0x4364D60", VA = "0x4368D60")]
		public PlayerSkinData()
		{
		}
	}
}
