using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace L_Tools
{
	[Serializable]
	[Token(Token = "0x2000F95")]
	public class PopCallBackData
	{
		[Token(Token = "0x4006B35")]
		[FieldOffset(Offset = "0x10")]
		public int mode;

		[Token(Token = "0x4006B36")]
		[FieldOffset(Offset = "0x18")]
		public string category;

		[Token(Token = "0x4006B37")]
		[FieldOffset(Offset = "0x20")]
		public string fromUid;

		[Token(Token = "0x4006B38")]
		[FieldOffset(Offset = "0x28")]
		public List<string> receiveUid;

		[Token(Token = "0x4006B39")]
		[FieldOffset(Offset = "0x30")]
		public int exporeAt;

		[Token(Token = "0x4006B3A")]
		[FieldOffset(Offset = "0x38")]
		public string key;

		[Token(Token = "0x4006B3B")]
		[FieldOffset(Offset = "0x40")]
		public string body;

		[Token(Token = "0x6005D5D")]
		[Address(RVA = "0x43B8E88", Offset = "0x43B4E88", VA = "0x43B8E88")]
		public PopCallBackData()
		{
		}
	}
}
