using System;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace DataModule
{
	[Serializable]
	[Token(Token = "0x2000ED8")]
	public class TimeInfo
	{
		[Token(Token = "0x4006700")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty("k")]
		public string Key;

		[Token(Token = "0x4006701")]
		[FieldOffset(Offset = "0x18")]
		[JsonProperty("st")]
		public DateTime StartTime;

		[Token(Token = "0x4006702")]
		[FieldOffset(Offset = "0x20")]
		[JsonProperty("tet")]
		public DateTime TargetEndTime;

		[Token(Token = "0x4006703")]
		[FieldOffset(Offset = "0x28")]
		[JsonProperty("usnt")]
		public bool useStandardNetTime;

		[Token(Token = "0x60059C5")]
		[Address(RVA = "0x4376B90", Offset = "0x4372B90", VA = "0x4376B90")]
		public TimeInfo()
		{
		}
	}
}
