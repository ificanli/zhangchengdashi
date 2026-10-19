using System.Collections.Generic;
using System.IO;
using System.Text;
using Il2CppDummyDll;

namespace Pathfinding.Ionic.Zip
{
	[Token(Token = "0x2000034")]
	internal static class ZipOutput
	{
		[Token(Token = "0x6000266")]
		[Address(RVA = "0x78556F4", Offset = "0x78516F4", VA = "0x78556F4")]
		public static bool WriteCentralDirectoryStructure(Stream s, ICollection<ZipEntry> entries, uint numSegments, Zip64Option zip64, string comment, ZipContainer container)
		{
			return default;
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x78599C8", Offset = "0x78559C8", VA = "0x78599C8")]
		private static Encoding GetEncoding(ZipContainer container, string t)
		{
			return null;
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x7859668", Offset = "0x7855668", VA = "0x7859668")]
		private static byte[] GenCentralDirectoryFooter(long StartOfCentralDirectory, long EndOfCentralDirectory, Zip64Option zip64, int entryCount, string comment, ZipContainer container)
		{
			return null;
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x7859410", Offset = "0x7855410", VA = "0x7859410")]
		private static byte[] GenZip64EndOfCentralDirectory(long StartOfCentralDirectory, long EndOfCentralDirectory, int entryCount, uint numSegments)
		{
			return null;
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x785912C", Offset = "0x785512C", VA = "0x785912C")]
		private static int CountEntries(ICollection<ZipEntry> _entries)
		{
			return default;
		}
	}
}
