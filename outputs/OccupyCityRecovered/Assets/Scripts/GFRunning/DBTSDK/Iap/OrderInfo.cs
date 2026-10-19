using Il2CppDummyDll;

namespace DBTSDK.Iap
{
	[Token(Token = "0x20002C2")]
	public struct OrderInfo
	{
		[Token(Token = "0x4001713")]
		[FieldOffset(Offset = "0x0")]
		public string orderId;

		[Token(Token = "0x4001714")]
		[FieldOffset(Offset = "0x8")]
		public string productID;

		[Token(Token = "0x4001715")]
		[FieldOffset(Offset = "0x10")]
		public string orderStats;

		[Token(Token = "0x4001716")]
		[FieldOffset(Offset = "0x18")]
		public string clientStatus;

		[Token(Token = "0x4001717")]
		[FieldOffset(Offset = "0x20")]
		public string msg;

		[Token(Token = "0x4001718")]
		[FieldOffset(Offset = "0x28")]
		public string orderSign;

		[Token(Token = "0x4001719")]
		[FieldOffset(Offset = "0x30")]
		public string platOrderNo;

		[Token(Token = "0x400171A")]
		[FieldOffset(Offset = "0x38")]
		public string productId;

		[Token(Token = "0x400171B")]
		[FieldOffset(Offset = "0x40")]
		public string productPrice;

		[Token(Token = "0x400171C")]
		[FieldOffset(Offset = "0x48")]
		public string platCreateTime;

		[Token(Token = "0x400171D")]
		[FieldOffset(Offset = "0x50")]
		public bool isAcknowledged;

		[Token(Token = "0x400171E")]
		[FieldOffset(Offset = "0x58")]
		public string offerType;

		[Token(Token = "0x400171F")]
		[FieldOffset(Offset = "0x60")]
		public string offerIdentifier;
	}
}
