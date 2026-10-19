using System.IO;
using System.Text;
using Il2CppDummyDll;
using Pathfinding.Ionic.Zlib;

namespace Pathfinding.Ionic.Zip
{
	[Token(Token = "0x200003A")]
	internal class ZipContainer
	{
		[Token(Token = "0x4000161")]
		[FieldOffset(Offset = "0x10")]
		private ZipFile _zf;

		[Token(Token = "0x4000162")]
		[FieldOffset(Offset = "0x18")]
		private ZipOutputStream _zos;

		[Token(Token = "0x4000163")]
		[FieldOffset(Offset = "0x20")]
		private ZipInputStream _zis;

		[Token(Token = "0x170000AC")]
		public ZipFile ZipFile
		{
			[Token(Token = "0x60002BE")]
			[Address(RVA = "0x785B620", Offset = "0x7857620", VA = "0x785B620")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AD")]
		public ZipOutputStream ZipOutputStream
		{
			[Token(Token = "0x60002BF")]
			[Address(RVA = "0x785B628", Offset = "0x7857628", VA = "0x785B628")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AE")]
		public string Name
		{
			[Token(Token = "0x60002C0")]
			[Address(RVA = "0x785B630", Offset = "0x7857630", VA = "0x785B630")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AF")]
		public string Password
		{
			[Token(Token = "0x60002C1")]
			[Address(RVA = "0x785B69C", Offset = "0x785769C", VA = "0x785B69C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B0")]
		public Zip64Option Zip64
		{
			[Token(Token = "0x60002C2")]
			[Address(RVA = "0x785B6DC", Offset = "0x78576DC", VA = "0x785B6DC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000B1")]
		public int BufferSize
		{
			[Token(Token = "0x60002C3")]
			[Address(RVA = "0x785B748", Offset = "0x7857748", VA = "0x785B748")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000B2")]
		public ParallelDeflateOutputStream ParallelDeflater
		{
			[Token(Token = "0x60002C4")]
			[Address(RVA = "0x785B7A4", Offset = "0x78577A4", VA = "0x785B7A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002C5")]
			[Address(RVA = "0x785B7E4", Offset = "0x78577E4", VA = "0x785B7E4")]
			set
			{
			}
		}

		[Token(Token = "0x170000B3")]
		public long ParallelDeflateThreshold
		{
			[Token(Token = "0x60002C6")]
			[Address(RVA = "0x785B808", Offset = "0x7857808", VA = "0x785B808")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000B4")]
		public int ParallelDeflateMaxBufferPairs
		{
			[Token(Token = "0x60002C7")]
			[Address(RVA = "0x785B838", Offset = "0x7857838", VA = "0x785B838")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000B5")]
		public int CodecBufferSize
		{
			[Token(Token = "0x60002C8")]
			[Address(RVA = "0x785B868", Offset = "0x7857868", VA = "0x785B868")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000B6")]
		public CompressionStrategy Strategy
		{
			[Token(Token = "0x60002C9")]
			[Address(RVA = "0x785B8A8", Offset = "0x78578A8", VA = "0x785B8A8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000B7")]
		public Zip64Option UseZip64WhenSaving
		{
			[Token(Token = "0x60002CA")]
			[Address(RVA = "0x785B8D8", Offset = "0x78578D8", VA = "0x785B8D8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000B8")]
		public Encoding AlternateEncoding
		{
			[Token(Token = "0x60002CB")]
			[Address(RVA = "0x7859ADC", Offset = "0x7855ADC", VA = "0x7859ADC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B9")]
		public Encoding DefaultEncoding
		{
			[Token(Token = "0x60002CC")]
			[Address(RVA = "0x7859B08", Offset = "0x7855B08", VA = "0x7859B08")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BA")]
		public ZipOption AlternateEncodingUsage
		{
			[Token(Token = "0x60002CD")]
			[Address(RVA = "0x7859AB4", Offset = "0x7855AB4", VA = "0x7859AB4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000BB")]
		public Stream ReadStream
		{
			[Token(Token = "0x60002CE")]
			[Address(RVA = "0x785B908", Offset = "0x7857908", VA = "0x785B908")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x784DE48", Offset = "0x7849E48", VA = "0x784DE48")]
		public ZipContainer(object o)
		{
		}
	}
}
