using Il2CppDummyDll;

namespace YooAsset
{
	[Token(Token = "0x200012C")]
	public struct TFileInfo
	{
		[Token(Token = "0x400047C")]
		[FieldOffset(Offset = "0x0")]
		public string BundleName;

		[Token(Token = "0x400047D")]
		[FieldOffset(Offset = "0x8")]
		public string FilePath;

		[Token(Token = "0x400047E")]
		[FieldOffset(Offset = "0x10")]
		public byte[] Data;

		[Token(Token = "0x400047F")]
		[FieldOffset(Offset = "0x18")]
		public int Count;

		[Token(Token = "0x4000480")]
		[FieldOffset(Offset = "0x1C")]
		public byte BytesFun;
	}
}
