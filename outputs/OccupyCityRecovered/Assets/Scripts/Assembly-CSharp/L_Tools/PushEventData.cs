using System;
using System.Collections.Generic;
using GameFramework.Net.Http;
using Il2CppDummyDll;

namespace L_Tools
{
	[Serializable]
	[Token(Token = "0x2000F92")]
	public class PushEventData : IRequesData
	{
		[Token(Token = "0x4006B28")]
		[FieldOffset(Offset = "0x10")]
		public int mode;

		[Token(Token = "0x4006B29")]
		[FieldOffset(Offset = "0x18")]
		public string category;

		[Token(Token = "0x4006B2A")]
		[FieldOffset(Offset = "0x20")]
		public string fromUid;

		[Token(Token = "0x4006B2B")]
		[FieldOffset(Offset = "0x28")]
		public List<string> receiveUid;

		[Token(Token = "0x4006B2C")]
		[FieldOffset(Offset = "0x30")]
		public int exporeAt;

		[Token(Token = "0x4006B2D")]
		[FieldOffset(Offset = "0x38")]
		public List<KeyValues> overLayData;

		[Token(Token = "0x4006B2E")]
		[FieldOffset(Offset = "0x40")]
		public string appendData;

		[Token(Token = "0x6005D5A")]
		[Address(RVA = "0x43B8D98", Offset = "0x43B4D98", VA = "0x43B8D98")]
		public PushEventData()
		{
		}
	}
}
