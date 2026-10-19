using Il2CppDummyDll;

namespace Pathfinding.Ionic.Zip
{
	[Token(Token = "0x200000A")]
	public class ReadProgressEventArgs : ZipProgressEventArgs
	{
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x7838C90", Offset = "0x7834C90", VA = "0x7838C90")]
		internal ReadProgressEventArgs()
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x7838C94", Offset = "0x7834C94", VA = "0x7838C94")]
		private ReadProgressEventArgs(string archiveName, ZipProgressEventType flavor)
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x7838C98", Offset = "0x7834C98", VA = "0x7838C98")]
		internal static ReadProgressEventArgs Before(string archiveName, int entriesTotal)
		{
			return null;
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x7838D0C", Offset = "0x7834D0C", VA = "0x7838D0C")]
		internal static ReadProgressEventArgs After(string archiveName, ZipEntry entry, int entriesTotal)
		{
			return null;
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x7838D88", Offset = "0x7834D88", VA = "0x7838D88")]
		internal static ReadProgressEventArgs Started(string archiveName)
		{
			return null;
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x7838DE4", Offset = "0x7834DE4", VA = "0x7838DE4")]
		internal static ReadProgressEventArgs ByteUpdate(string archiveName, ZipEntry entry, long bytesXferred, long totalBytes)
		{
			return null;
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x7838E6C", Offset = "0x7834E6C", VA = "0x7838E6C")]
		internal static ReadProgressEventArgs Completed(string archiveName)
		{
			return null;
		}
	}
}
