using System;
using Il2CppDummyDll;

namespace FeedbackModule
{
	[Serializable]
	[Token(Token = "0x2000628")]
	public class PlayerFeedbackPayload
	{
		[Token(Token = "0x400327F")]
		[FieldOffset(Offset = "0x10")]
		public string reportType;

		[Token(Token = "0x4003280")]
		[FieldOffset(Offset = "0x18")]
		public string feedbackContent;

		[Token(Token = "0x4003281")]
		[FieldOffset(Offset = "0x20")]
		public string contactEmail;

		[Token(Token = "0x4003282")]
		[FieldOffset(Offset = "0x28")]
		public string playerId;

		[Token(Token = "0x4003283")]
		[FieldOffset(Offset = "0x30")]
		public string appVersion;

		[Token(Token = "0x4003284")]
		[FieldOffset(Offset = "0x38")]
		public string buildNumber;

		[Token(Token = "0x4003285")]
		[FieldOffset(Offset = "0x40")]
		public string timestamp;

		[Token(Token = "0x4003286")]
		[FieldOffset(Offset = "0x48")]
		public string deviceModel;

		[Token(Token = "0x4003287")]
		[FieldOffset(Offset = "0x50")]
		public string osVersion;

		[Token(Token = "0x4003288")]
		[FieldOffset(Offset = "0x58")]
		public string cpuModel;

		[Token(Token = "0x4003289")]
		[FieldOffset(Offset = "0x60")]
		public int systemMemory;

		[Token(Token = "0x400328A")]
		[FieldOffset(Offset = "0x68")]
		public string networkType;

		[Token(Token = "0x400328B")]
		[FieldOffset(Offset = "0x70")]
		public string saveDataString;

		[Token(Token = "0x600209C")]
		[Address(RVA = "0x3F1192C", Offset = "0x3F0D92C", VA = "0x3F1192C")]
		public PlayerFeedbackPayload()
		{
		}
	}
}
