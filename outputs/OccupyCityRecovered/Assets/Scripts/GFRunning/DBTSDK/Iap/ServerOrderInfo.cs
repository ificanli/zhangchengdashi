using Il2CppDummyDll;

namespace DBTSDK.Iap
{
	[Token(Token = "0x20002C4")]
	public class ServerOrderInfo
	{
		[Token(Token = "0x4001725")]
		[FieldOffset(Offset = "0x10")]
		public string gameKey;

		[Token(Token = "0x4001726")]
		[FieldOffset(Offset = "0x18")]
		public string orderNo;

		[Token(Token = "0x4001727")]
		[FieldOffset(Offset = "0x20")]
		public string orderSign;

		[Token(Token = "0x4001728")]
		[FieldOffset(Offset = "0x28")]
		public string gameId;

		[Token(Token = "0x4001729")]
		[FieldOffset(Offset = "0x30")]
		public int gameChannel;

		[Token(Token = "0x400172A")]
		[FieldOffset(Offset = "0x38")]
		public string platOrderNo;

		[Token(Token = "0x400172B")]
		[FieldOffset(Offset = "0x40")]
		public string platCreateTime;

		[Token(Token = "0x400172C")]
		[FieldOffset(Offset = "0x48")]
		public string productId;

		[Token(Token = "0x400172D")]
		[FieldOffset(Offset = "0x50")]
		public int productPrice;

		[Token(Token = "0x400172E")]
		[FieldOffset(Offset = "0x54")]
		public int commdityChannel;

		[Token(Token = "0x400172F")]
		[FieldOffset(Offset = "0x58")]
		public string offerType;

		[Token(Token = "0x4001730")]
		[FieldOffset(Offset = "0x60")]
		public string offerIdentifier;

		[Token(Token = "0x600505A")]
		[Address(RVA = "0x710C9A0", Offset = "0x71089A0", VA = "0x710C9A0")]
		public ServerOrderInfo()
		{
		}
	}
}
