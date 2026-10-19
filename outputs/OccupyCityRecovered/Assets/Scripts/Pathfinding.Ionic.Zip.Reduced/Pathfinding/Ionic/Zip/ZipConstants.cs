using Il2CppDummyDll;

namespace Pathfinding.Ionic.Zip
{
	[Token(Token = "0x2000026")]
	internal static class ZipConstants
	{
		[Token(Token = "0x4000063")]
		public const uint PackedToRemovableMedia = 808471376u;

		[Token(Token = "0x4000064")]
		public const uint Zip64EndOfCentralDirectoryRecordSignature = 101075792u;

		[Token(Token = "0x4000065")]
		public const uint Zip64EndOfCentralDirectoryLocatorSignature = 117853008u;

		[Token(Token = "0x4000066")]
		public const uint EndOfCentralDirectorySignature = 101010256u;

		[Token(Token = "0x4000067")]
		public const int ZipEntrySignature = 67324752;

		[Token(Token = "0x4000068")]
		public const int ZipEntryDataDescriptorSignature = 134695760;

		[Token(Token = "0x4000069")]
		public const int SplitArchiveSignature = 134695760;

		[Token(Token = "0x400006A")]
		public const int ZipDirEntrySignature = 33639248;

		[Token(Token = "0x400006B")]
		public const int AesKeySize = 192;

		[Token(Token = "0x400006C")]
		public const int AesBlockSize = 128;

		[Token(Token = "0x400006D")]
		public const ushort AesAlgId128 = 26126;

		[Token(Token = "0x400006E")]
		public const ushort AesAlgId192 = 26127;

		[Token(Token = "0x400006F")]
		public const ushort AesAlgId256 = 26128;
	}
}
