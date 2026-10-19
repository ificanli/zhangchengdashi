using Il2CppDummyDll;

namespace YooAsset
{
	[Token(Token = "0x200012E")]
	public struct DeliveryFileInfo
	{
		[Token(Token = "0x4000481")]
		[FieldOffset(Offset = "0x0")]
		public string DeliveryFilePath;

		[Token(Token = "0x4000482")]
		[FieldOffset(Offset = "0x8")]
		public ulong DeliveryFileOffset;
	}
}
