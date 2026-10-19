using System;
using GameFramework.Net.Http;
using Il2CppDummyDll;

namespace L_Tools
{
	[Serializable]
	[Token(Token = "0x2000F94")]
	public class PopEventData : IRequesData
	{
		[Token(Token = "0x4006B31")]
		[FieldOffset(Offset = "0x10")]
		public int mode;

		[Token(Token = "0x4006B32")]
		[FieldOffset(Offset = "0x18")]
		public string category;

		[Token(Token = "0x4006B33")]
		[FieldOffset(Offset = "0x20")]
		public string uid;

		[Token(Token = "0x4006B34")]
		[FieldOffset(Offset = "0x28")]
		public int number;

		[Token(Token = "0x6005D5C")]
		[Address(RVA = "0x43B8E38", Offset = "0x43B4E38", VA = "0x43B8E38")]
		public PopEventData()
		{
		}
	}
}
