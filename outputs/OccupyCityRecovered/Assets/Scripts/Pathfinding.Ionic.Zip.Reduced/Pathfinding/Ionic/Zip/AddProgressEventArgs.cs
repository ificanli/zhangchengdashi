using Il2CppDummyDll;

namespace Pathfinding.Ionic.Zip
{
	[Token(Token = "0x200000B")]
	public class AddProgressEventArgs : ZipProgressEventArgs
	{
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x7838EC8", Offset = "0x7834EC8", VA = "0x7838EC8")]
		internal AddProgressEventArgs()
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x7838ECC", Offset = "0x7834ECC", VA = "0x7838ECC")]
		private AddProgressEventArgs(string archiveName, ZipProgressEventType flavor)
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x7838ED0", Offset = "0x7834ED0", VA = "0x7838ED0")]
		internal static AddProgressEventArgs AfterEntry(string archiveName, ZipEntry entry, int entriesTotal)
		{
			return null;
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x7838F4C", Offset = "0x7834F4C", VA = "0x7838F4C")]
		internal static AddProgressEventArgs Started(string archiveName)
		{
			return null;
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x7838FA8", Offset = "0x7834FA8", VA = "0x7838FA8")]
		internal static AddProgressEventArgs Completed(string archiveName)
		{
			return null;
		}
	}
}
