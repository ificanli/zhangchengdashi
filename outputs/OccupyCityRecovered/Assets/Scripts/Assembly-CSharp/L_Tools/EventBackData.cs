using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace L_Tools
{
	[Serializable]
	[Token(Token = "0x2000F96")]
	public class EventBackData
	{
		[Token(Token = "0x4006B3C")]
		[FieldOffset(Offset = "0x10")]
		public string category;

		[Token(Token = "0x4006B3D")]
		[FieldOffset(Offset = "0x18")]
		public List<PopCallBackData> data;

		[Token(Token = "0x6005D5E")]
		[Address(RVA = "0x43B8EFC", Offset = "0x43B4EFC", VA = "0x43B8EFC")]
		public EventBackData()
		{
		}
	}
}
