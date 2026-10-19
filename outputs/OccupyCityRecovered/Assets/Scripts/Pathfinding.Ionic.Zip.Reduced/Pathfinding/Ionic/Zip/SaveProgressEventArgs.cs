using Il2CppDummyDll;

namespace Pathfinding.Ionic.Zip
{
	[Token(Token = "0x200000C")]
	public class SaveProgressEventArgs : ZipProgressEventArgs
	{
		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x40")]
		private int _entriesSaved;

		[Token(Token = "0x17000008")]
		public int EntriesSaved
		{
			[Token(Token = "0x600003A")]
			[Address(RVA = "0x7839198", Offset = "0x7835198", VA = "0x7839198")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x7839004", Offset = "0x7835004", VA = "0x7839004")]
		internal SaveProgressEventArgs(string archiveName, bool before, int entriesTotal, int entriesSaved, ZipEntry entry)
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x783904C", Offset = "0x783504C", VA = "0x783904C")]
		internal SaveProgressEventArgs()
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x7839050", Offset = "0x7835050", VA = "0x7839050")]
		internal SaveProgressEventArgs(string archiveName, ZipProgressEventType flavor)
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x7839054", Offset = "0x7835054", VA = "0x7839054")]
		internal static SaveProgressEventArgs ByteUpdate(string archiveName, ZipEntry entry, long bytesXferred, long totalBytes)
		{
			return null;
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x78390E0", Offset = "0x78350E0", VA = "0x78390E0")]
		internal static SaveProgressEventArgs Started(string archiveName)
		{
			return null;
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x783913C", Offset = "0x783513C", VA = "0x783913C")]
		internal static SaveProgressEventArgs Completed(string archiveName)
		{
			return null;
		}
	}
}
