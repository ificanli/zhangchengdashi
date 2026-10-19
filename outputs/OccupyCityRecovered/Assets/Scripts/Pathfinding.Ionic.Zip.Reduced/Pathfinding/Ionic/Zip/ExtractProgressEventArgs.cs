using Il2CppDummyDll;

namespace Pathfinding.Ionic.Zip
{
	[Token(Token = "0x200000D")]
	public class ExtractProgressEventArgs : ZipProgressEventArgs
	{
		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x40")]
		private int _entriesExtracted;

		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x48")]
		private string _target;

		[Token(Token = "0x17000009")]
		public int EntriesExtracted
		{
			[Token(Token = "0x6000044")]
			[Address(RVA = "0x78394EC", Offset = "0x78354EC", VA = "0x78394EC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700000A")]
		public string ExtractLocation
		{
			[Token(Token = "0x6000045")]
			[Address(RVA = "0x78394F4", Offset = "0x78354F4", VA = "0x78394F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x78391A0", Offset = "0x78351A0", VA = "0x78391A0")]
		internal ExtractProgressEventArgs(string archiveName, bool before, int entriesTotal, int entriesExtracted, ZipEntry entry, string extractLocation)
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x78391F0", Offset = "0x78351F0", VA = "0x78391F0")]
		internal ExtractProgressEventArgs(string archiveName, ZipProgressEventType flavor)
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x78391F4", Offset = "0x78351F4", VA = "0x78391F4")]
		internal ExtractProgressEventArgs()
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x78391F8", Offset = "0x78351F8", VA = "0x78391F8")]
		internal static ExtractProgressEventArgs BeforeExtractEntry(string archiveName, ZipEntry entry, string extractLocation)
		{
			return null;
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x7839278", Offset = "0x7835278", VA = "0x7839278")]
		internal static ExtractProgressEventArgs ExtractExisting(string archiveName, ZipEntry entry, string extractLocation)
		{
			return null;
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x78392F8", Offset = "0x78352F8", VA = "0x78392F8")]
		internal static ExtractProgressEventArgs AfterExtractEntry(string archiveName, ZipEntry entry, string extractLocation)
		{
			return null;
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x7839378", Offset = "0x7835378", VA = "0x7839378")]
		internal static ExtractProgressEventArgs ExtractAllStarted(string archiveName, string extractLocation)
		{
			return null;
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x78393EC", Offset = "0x78353EC", VA = "0x78393EC")]
		internal static ExtractProgressEventArgs ExtractAllCompleted(string archiveName, string extractLocation)
		{
			return null;
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x7839460", Offset = "0x7835460", VA = "0x7839460")]
		internal static ExtractProgressEventArgs ByteUpdate(string archiveName, ZipEntry entry, long bytesWritten, long totalBytes)
		{
			return null;
		}
	}
}
