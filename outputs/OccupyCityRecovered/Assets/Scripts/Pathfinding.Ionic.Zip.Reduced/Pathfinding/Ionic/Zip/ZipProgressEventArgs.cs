using System;
using Il2CppDummyDll;

namespace Pathfinding.Ionic.Zip
{
	[Token(Token = "0x2000009")]
	public class ZipProgressEventArgs : EventArgs
	{
		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x10")]
		private int _entriesTotal;

		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x14")]
		private bool _cancel;

		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x18")]
		private ZipEntry _latestEntry;

		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x20")]
		private ZipProgressEventType _flavor;

		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x28")]
		private string _archiveName;

		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x30")]
		private long _bytesTransferred;

		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x38")]
		private long _totalBytesToTransfer;

		[Token(Token = "0x17000001")]
		public int EntriesTotal
		{
			[Token(Token = "0x600001A")]
			[Address(RVA = "0x7838BFC", Offset = "0x7834BFC", VA = "0x7838BFC")]
			get
			{
				return default;
			}
			[Token(Token = "0x600001B")]
			[Address(RVA = "0x7838C04", Offset = "0x7834C04", VA = "0x7838C04")]
			set
			{
			}
		}

		[Token(Token = "0x17000002")]
		public ZipEntry CurrentEntry
		{
			[Token(Token = "0x600001C")]
			[Address(RVA = "0x7838C0C", Offset = "0x7834C0C", VA = "0x7838C0C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600001D")]
			[Address(RVA = "0x7838C14", Offset = "0x7834C14", VA = "0x7838C14")]
			set
			{
			}
		}

		[Token(Token = "0x17000003")]
		public bool Cancel
		{
			[Token(Token = "0x600001E")]
			[Address(RVA = "0x7838C1C", Offset = "0x7834C1C", VA = "0x7838C1C")]
			get
			{
				return default;
			}
			[Token(Token = "0x600001F")]
			[Address(RVA = "0x7838C24", Offset = "0x7834C24", VA = "0x7838C24")]
			set
			{
			}
		}

		[Token(Token = "0x17000004")]
		public ZipProgressEventType EventType
		{
			[Token(Token = "0x6000020")]
			[Address(RVA = "0x7838C50", Offset = "0x7834C50", VA = "0x7838C50")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000021")]
			[Address(RVA = "0x7838C58", Offset = "0x7834C58", VA = "0x7838C58")]
			set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public string ArchiveName
		{
			[Token(Token = "0x6000022")]
			[Address(RVA = "0x7838C60", Offset = "0x7834C60", VA = "0x7838C60")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000023")]
			[Address(RVA = "0x7838C68", Offset = "0x7834C68", VA = "0x7838C68")]
			set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public long BytesTransferred
		{
			[Token(Token = "0x6000024")]
			[Address(RVA = "0x7838C70", Offset = "0x7834C70", VA = "0x7838C70")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000025")]
			[Address(RVA = "0x7838C78", Offset = "0x7834C78", VA = "0x7838C78")]
			set
			{
			}
		}

		[Token(Token = "0x17000007")]
		public long TotalBytesToTransfer
		{
			[Token(Token = "0x6000026")]
			[Address(RVA = "0x7838C80", Offset = "0x7834C80", VA = "0x7838C80")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000027")]
			[Address(RVA = "0x7838C88", Offset = "0x7834C88", VA = "0x7838C88")]
			set
			{
			}
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x7838B30", Offset = "0x7834B30", VA = "0x7838B30")]
		internal ZipProgressEventArgs()
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x7838B88", Offset = "0x7834B88", VA = "0x7838B88")]
		internal ZipProgressEventArgs(string archiveName, ZipProgressEventType flavor)
		{
		}
	}
}
