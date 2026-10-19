using System;
using Il2CppDummyDll;

namespace DBTSDK.Iap
{
	[Serializable]
	[Token(Token = "0x20002C0")]
	public class ProductData
	{
		[Token(Token = "0x400170B")]
		[FieldOffset(Offset = "0x10")]
		public string GameKey;

		[Token(Token = "0x400170C")]
		[FieldOffset(Offset = "0x18")]
		public string productID;

		[Token(Token = "0x400170D")]
		[FieldOffset(Offset = "0x20")]
		public string productType;

		[Token(Token = "0x400170E")]
		[FieldOffset(Offset = "0x28")]
		public string GameName;

		[Token(Token = "0x6005058")]
		[Address(RVA = "0x710C990", Offset = "0x7108990", VA = "0x710C990")]
		public ProductData()
		{
		}
	}
}
