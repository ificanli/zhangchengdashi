using System;
using Beebyte.Obfuscator;
using GameFramework;
using Il2CppDummyDll;

namespace ljzs_lt
{
	[Serializable]
	[Token(Token = "0x2000F38")]
	[Skip]
	public class PurchaseConfig : BaseConfig
	{
		[Token(Token = "0x4006958")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		[Token(Token = "0x4006959")]
		[FieldOffset(Offset = "0x14")]
		public int channel;

		[Token(Token = "0x400695A")]
		[FieldOffset(Offset = "0x18")]
		public int type;

		[Token(Token = "0x400695B")]
		[FieldOffset(Offset = "0x20")]
		public string productID;

		[Token(Token = "0x400695C")]
		[FieldOffset(Offset = "0x28")]
		public int price;

		[Token(Token = "0x400695D")]
		[FieldOffset(Offset = "0x30")]
		public string productName;

		[Token(Token = "0x400695E")]
		[FieldOffset(Offset = "0x38")]
		public string Des;

		[Token(Token = "0x400695F")]
		[FieldOffset(Offset = "0x40")]
		public string ProductData;

		[Token(Token = "0x4006960")]
		[FieldOffset(Offset = "0x48")]
		public int ABTest;

		[Token(Token = "0x17000F63")]
		public override object UniqueID
		{
			[Token(Token = "0x6005B2A")]
			[Address(RVA = "0x439B55C", Offset = "0x439755C", VA = "0x439B55C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005B2B")]
		[Address(RVA = "0x439B5B8", Offset = "0x43975B8", VA = "0x439B5B8")]
		public PurchaseConfig()
		{
		}
	}
}
