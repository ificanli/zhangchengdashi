using System;
using Il2CppDummyDll;

namespace SDKModule
{
	[Serializable]
	[Token(Token = "0x2000171")]
	public class InterstitialInfoV1
	{
		[Token(Token = "0x4001A47")]
		[FieldOffset(Offset = "0x10")]
		public int MinutesSinceInstall;

		[Token(Token = "0x4001A48")]
		[FieldOffset(Offset = "0x14")]
		public bool TriggerWinEnabled;

		[Token(Token = "0x4001A49")]
		[FieldOffset(Offset = "0x15")]
		public bool TriggerLoseEnabled;

		[Token(Token = "0x4001A4A")]
		[FieldOffset(Offset = "0x16")]
		public bool IsAdBreakEnabled;

		[Token(Token = "0x4001A4B")]
		[FieldOffset(Offset = "0x17")]
		public bool IsPayingUserFilterEnabled;

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x3F7392C", Offset = "0x3F6F92C", VA = "0x3F7392C")]
		public InterstitialInfoV1()
		{
		}
	}
}
