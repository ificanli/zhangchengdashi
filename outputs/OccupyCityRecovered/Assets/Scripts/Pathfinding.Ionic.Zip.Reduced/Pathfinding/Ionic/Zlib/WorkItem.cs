using Il2CppDummyDll;

namespace Pathfinding.Ionic.Zlib
{
	[Token(Token = "0x2000058")]
	internal class WorkItem
	{
		[Token(Token = "0x40002F2")]
		[FieldOffset(Offset = "0x10")]
		public byte[] buffer;

		[Token(Token = "0x40002F3")]
		[FieldOffset(Offset = "0x18")]
		public byte[] compressed;

		[Token(Token = "0x40002F4")]
		[FieldOffset(Offset = "0x20")]
		public int crc;

		[Token(Token = "0x40002F5")]
		[FieldOffset(Offset = "0x24")]
		public int index;

		[Token(Token = "0x40002F6")]
		[FieldOffset(Offset = "0x28")]
		public int ordinal;

		[Token(Token = "0x40002F7")]
		[FieldOffset(Offset = "0x2C")]
		public int inputBytesAvailable;

		[Token(Token = "0x40002F8")]
		[FieldOffset(Offset = "0x30")]
		public int compressedBytesAvailable;

		[Token(Token = "0x40002F9")]
		[FieldOffset(Offset = "0x38")]
		public ZlibCodec compressor;

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x78714B8", Offset = "0x786D4B8", VA = "0x78714B8")]
		public WorkItem(int size, CompressionLevel compressLevel, CompressionStrategy strategy, int ix)
		{
		}
	}
}
