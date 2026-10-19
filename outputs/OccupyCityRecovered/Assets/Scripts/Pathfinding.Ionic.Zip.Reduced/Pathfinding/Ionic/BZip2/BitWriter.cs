using System.IO;
using Il2CppDummyDll;

namespace Pathfinding.Ionic.BZip2
{
	[Token(Token = "0x2000045")]
	internal class BitWriter
	{
		[Token(Token = "0x40001F6")]
		[FieldOffset(Offset = "0x10")]
		private uint accumulator;

		[Token(Token = "0x40001F7")]
		[FieldOffset(Offset = "0x14")]
		private int nAccumulatedBits;

		[Token(Token = "0x40001F8")]
		[FieldOffset(Offset = "0x18")]
		private Stream output;

		[Token(Token = "0x40001F9")]
		[FieldOffset(Offset = "0x20")]
		private int totalBytesWrittenOut;

		[Token(Token = "0x170000D4")]
		public byte RemainingBits
		{
			[Token(Token = "0x600034E")]
			[Address(RVA = "0x78641C4", Offset = "0x78601C4", VA = "0x78641C4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000D5")]
		public int NumRemainingBits
		{
			[Token(Token = "0x600034F")]
			[Address(RVA = "0x78641D4", Offset = "0x78601D4", VA = "0x78641D4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000D6")]
		public int TotalBytesWrittenOut
		{
			[Token(Token = "0x6000350")]
			[Address(RVA = "0x78641DC", Offset = "0x78601DC", VA = "0x78641DC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x7863948", Offset = "0x785F948", VA = "0x7863948")]
		public BitWriter(Stream s)
		{
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x78641E4", Offset = "0x78601E4", VA = "0x78641E4")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x7864238", Offset = "0x7860238", VA = "0x7864238")]
		public void WriteBits(int nbits, uint value)
		{
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x7863C34", Offset = "0x785FC34", VA = "0x7863C34")]
		public void WriteByte(byte b)
		{
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x7863C40", Offset = "0x785FC40", VA = "0x7863C40")]
		public void WriteInt(uint u)
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x7863B84", Offset = "0x785FB84", VA = "0x7863B84")]
		public void Flush()
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x7863C94", Offset = "0x785FC94", VA = "0x7863C94")]
		public void FinishAndPad()
		{
		}
	}
}
