using System.Collections.Generic;
using Il2CppDummyDll;

namespace DBTSDK
{
	[Token(Token = "0x20001EC")]
	public class ChannelGiftGoods
	{
		[Token(Token = "0x20001ED")]
		public class Goods
		{
			[Token(Token = "0x40006C0")]
			[FieldOffset(Offset = "0x10")]
			public string goods_id;

			[Token(Token = "0x40006C1")]
			[FieldOffset(Offset = "0x18")]
			public int goods_num;

			[Token(Token = "0x60019CA")]
			[Address(RVA = "0x70B8204", Offset = "0x70B4204", VA = "0x70B8204")]
			public Goods()
			{
			}
		}

		[Token(Token = "0x40006BD")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		[Token(Token = "0x40006BE")]
		[FieldOffset(Offset = "0x18")]
		public string gift_id;

		[Token(Token = "0x40006BF")]
		[FieldOffset(Offset = "0x20")]
		public List<Goods> goods_list;

		[Token(Token = "0x60019C9")]
		[Address(RVA = "0x70B81FC", Offset = "0x70B41FC", VA = "0x70B81FC")]
		public ChannelGiftGoods()
		{
		}
	}
}
