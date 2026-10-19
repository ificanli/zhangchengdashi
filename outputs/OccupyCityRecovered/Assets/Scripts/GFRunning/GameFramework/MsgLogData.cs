using System;
using Il2CppDummyDll;

namespace GameFramework
{
	[Serializable]
	[Token(Token = "0x2000415")]
	internal struct MsgLogData
	{
		[Token(Token = "0x4001D72")]
		[FieldOffset(Offset = "0x0")]
		public string time;

		[Token(Token = "0x4001D73")]
		[FieldOffset(Offset = "0x8")]
		public string appver;

		[Token(Token = "0x4001D74")]
		[FieldOffset(Offset = "0x10")]
		public string pkg;

		[Token(Token = "0x4001D75")]
		[FieldOffset(Offset = "0x18")]
		public string dev_id;

		[Token(Token = "0x4001D76")]
		[FieldOffset(Offset = "0x20")]
		public string message;

		[Token(Token = "0x4001D77")]
		[FieldOffset(Offset = "0x28")]
		public string dbt_id;

		[Token(Token = "0x4001D78")]
		[FieldOffset(Offset = "0x30")]
		public int seq;
	}
}
