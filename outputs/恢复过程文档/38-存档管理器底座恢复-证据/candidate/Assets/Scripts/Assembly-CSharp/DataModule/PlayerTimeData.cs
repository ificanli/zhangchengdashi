using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace DataModule
{
	[Token(Token = "0x2000ED6")]
	public class PlayerTimeData : ServerBaseData
	{
		[Token(Token = "0x40066FA")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty("tid")]
		public Dictionary<string, TimeInfo> timeInfoDic;

		[Token(Token = "0x40066FB")]
		[FieldOffset(Offset = "0x18")]
		[JsonProperty("legt")]
		public DateTime lastExitGameTime;

		[Token(Token = "0x60059C2")]
		[Address(RVA = "0x4376AFC", Offset = "0x4372AFC", VA = "0x4376AFC")]
		public PlayerTimeData()
		{
    timeInfoDic = new Dictionary<string, TimeInfo>();
}
	}
}
