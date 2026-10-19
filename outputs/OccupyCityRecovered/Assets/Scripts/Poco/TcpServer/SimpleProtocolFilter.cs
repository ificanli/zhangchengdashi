using System.Collections.Generic;
using Il2CppDummyDll;

namespace TcpServer
{
	[Token(Token = "0x2000023")]
	public class SimpleProtocolFilter : ProtoFilter
	{
		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x10")]
		private byte[] buf;

		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x18")]
		private int HEADER_SIZE;

		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x20")]
		private List<string> msgs;

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x7882658", Offset = "0x787E658", VA = "0x7882658", Slot = "4")]
		public void input(byte[] data)
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x78828C4", Offset = "0x787E8C4", VA = "0x78828C4", Slot = "5")]
		public List<string> swap_msgs()
		{
			return null;
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x787B5A8", Offset = "0x78775A8", VA = "0x787B5A8")]
		public byte[] pack(string content)
		{
			return null;
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x788279C", Offset = "0x787E79C", VA = "0x788279C")]
		private static byte[] Combine(byte[] first, byte[] second)
		{
			return null;
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x7882840", Offset = "0x787E840", VA = "0x7882840")]
		public byte[] Slice(byte[] source, int start, int end)
		{
			return null;
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x7879174", Offset = "0x7875174", VA = "0x7879174")]
		public SimpleProtocolFilter()
		{
		}
	}
}
