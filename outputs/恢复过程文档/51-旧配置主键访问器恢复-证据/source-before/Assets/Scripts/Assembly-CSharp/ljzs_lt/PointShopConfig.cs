using System;
using Beebyte.Obfuscator;
using GameFramework;
using Il2CppDummyDll;

namespace ljzs_lt
{
	[Serializable]
	[Token(Token = "0x2000F30")]
	[Skip]
	public class PointShopConfig : BaseConfig
	{
		[Token(Token = "0x400692E")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		[Token(Token = "0x400692F")]
		[FieldOffset(Offset = "0x14")]
		public int itemType;

		[Token(Token = "0x4006930")]
		[FieldOffset(Offset = "0x18")]
		public int item;

		[Token(Token = "0x4006931")]
		[FieldOffset(Offset = "0x1C")]
		public int count;

		[Token(Token = "0x4006932")]
		[FieldOffset(Offset = "0x20")]
		public int buyItem;

		[Token(Token = "0x4006933")]
		[FieldOffset(Offset = "0x24")]
		public int buyCount;

		[Token(Token = "0x4006934")]
		[FieldOffset(Offset = "0x28")]
		public string saleLimit;

		[Token(Token = "0x17000F5B")]
		public override object UniqueID
		{
			[Token(Token = "0x6005B1A")]
			[Address(RVA = "0x439B23C", Offset = "0x439723C", VA = "0x439B23C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005B1B")]
		[Address(RVA = "0x439B298", Offset = "0x4397298", VA = "0x439B298")]
		public PointShopConfig()
		{
		}
	}
}
