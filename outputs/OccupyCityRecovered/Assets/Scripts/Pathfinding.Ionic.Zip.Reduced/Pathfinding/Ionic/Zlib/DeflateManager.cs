using Il2CppDummyDll;

namespace Pathfinding.Ionic.Zlib
{
	[Token(Token = "0x200004C")]
	internal sealed class DeflateManager
	{
		[Token(Token = "0x200004D")]
		internal delegate BlockState CompressFunc(FlushType flush);

		[Token(Token = "0x200004E")]
		internal class Config
		{
			[Token(Token = "0x4000271")]
			[FieldOffset(Offset = "0x10")]
			internal int GoodLength;

			[Token(Token = "0x4000272")]
			[FieldOffset(Offset = "0x14")]
			internal int MaxLazy;

			[Token(Token = "0x4000273")]
			[FieldOffset(Offset = "0x18")]
			internal int NiceLength;

			[Token(Token = "0x4000274")]
			[FieldOffset(Offset = "0x1C")]
			internal int MaxChainLength;

			[Token(Token = "0x4000275")]
			[FieldOffset(Offset = "0x20")]
			internal DeflateFlavor Flavor;

			[Token(Token = "0x4000276")]
			[FieldOffset(Offset = "0x0")]
			private static readonly Config[] Table;

			[Token(Token = "0x60003A5")]
			[Address(RVA = "0x786A418", Offset = "0x7866418", VA = "0x786A418")]
			private Config(int goodLength, int maxLazy, int niceLength, int maxChainLength, DeflateFlavor flavor)
			{
			}

			[Token(Token = "0x60003A6")]
			[Address(RVA = "0x786A468", Offset = "0x7866468", VA = "0x786A468")]
			static Config()
			{
			}

			[Token(Token = "0x60003A7")]
			[Address(RVA = "0x7866270", Offset = "0x7862270", VA = "0x7866270")]
			public static Config Lookup(CompressionLevel level)
			{
				return null;
			}
		}

		[Token(Token = "0x4000227")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int MEM_LEVEL_MAX;

		[Token(Token = "0x4000228")]
		[FieldOffset(Offset = "0x4")]
		private static readonly int MEM_LEVEL_DEFAULT;

		[Token(Token = "0x4000229")]
		[FieldOffset(Offset = "0x10")]
		private CompressFunc DeflateFunction;

		[Token(Token = "0x400022A")]
		[FieldOffset(Offset = "0x8")]
		private static readonly string[] _ErrorMessage;

		[Token(Token = "0x400022B")]
		[FieldOffset(Offset = "0x10")]
		private static readonly int PRESET_DICT;

		[Token(Token = "0x400022C")]
		[FieldOffset(Offset = "0x14")]
		private static readonly int INIT_STATE;

		[Token(Token = "0x400022D")]
		[FieldOffset(Offset = "0x18")]
		private static readonly int BUSY_STATE;

		[Token(Token = "0x400022E")]
		[FieldOffset(Offset = "0x1C")]
		private static readonly int FINISH_STATE;

		[Token(Token = "0x400022F")]
		[FieldOffset(Offset = "0x20")]
		private static readonly int Z_DEFLATED;

		[Token(Token = "0x4000230")]
		[FieldOffset(Offset = "0x24")]
		private static readonly int STORED_BLOCK;

		[Token(Token = "0x4000231")]
		[FieldOffset(Offset = "0x28")]
		private static readonly int STATIC_TREES;

		[Token(Token = "0x4000232")]
		[FieldOffset(Offset = "0x2C")]
		private static readonly int DYN_TREES;

		[Token(Token = "0x4000233")]
		[FieldOffset(Offset = "0x30")]
		private static readonly int Z_BINARY;

		[Token(Token = "0x4000234")]
		[FieldOffset(Offset = "0x34")]
		private static readonly int Z_ASCII;

		[Token(Token = "0x4000235")]
		[FieldOffset(Offset = "0x38")]
		private static readonly int Z_UNKNOWN;

		[Token(Token = "0x4000236")]
		[FieldOffset(Offset = "0x3C")]
		private static readonly int Buf_size;

		[Token(Token = "0x4000237")]
		[FieldOffset(Offset = "0x40")]
		private static readonly int MIN_MATCH;

		[Token(Token = "0x4000238")]
		[FieldOffset(Offset = "0x44")]
		private static readonly int MAX_MATCH;

		[Token(Token = "0x4000239")]
		[FieldOffset(Offset = "0x48")]
		private static readonly int MIN_LOOKAHEAD;

		[Token(Token = "0x400023A")]
		[FieldOffset(Offset = "0x4C")]
		private static readonly int HEAP_SIZE;

		[Token(Token = "0x400023B")]
		[FieldOffset(Offset = "0x50")]
		private static readonly int END_BLOCK;

		[Token(Token = "0x400023C")]
		[FieldOffset(Offset = "0x18")]
		internal ZlibCodec _codec;

		[Token(Token = "0x400023D")]
		[FieldOffset(Offset = "0x20")]
		internal int status;

		[Token(Token = "0x400023E")]
		[FieldOffset(Offset = "0x28")]
		internal byte[] pending;

		[Token(Token = "0x400023F")]
		[FieldOffset(Offset = "0x30")]
		internal int nextPending;

		[Token(Token = "0x4000240")]
		[FieldOffset(Offset = "0x34")]
		internal int pendingCount;

		[Token(Token = "0x4000241")]
		[FieldOffset(Offset = "0x38")]
		internal sbyte data_type;

		[Token(Token = "0x4000242")]
		[FieldOffset(Offset = "0x3C")]
		internal int last_flush;

		[Token(Token = "0x4000243")]
		[FieldOffset(Offset = "0x40")]
		internal int w_size;

		[Token(Token = "0x4000244")]
		[FieldOffset(Offset = "0x44")]
		internal int w_bits;

		[Token(Token = "0x4000245")]
		[FieldOffset(Offset = "0x48")]
		internal int w_mask;

		[Token(Token = "0x4000246")]
		[FieldOffset(Offset = "0x50")]
		internal byte[] window;

		[Token(Token = "0x4000247")]
		[FieldOffset(Offset = "0x58")]
		internal int window_size;

		[Token(Token = "0x4000248")]
		[FieldOffset(Offset = "0x60")]
		internal short[] prev;

		[Token(Token = "0x4000249")]
		[FieldOffset(Offset = "0x68")]
		internal short[] head;

		[Token(Token = "0x400024A")]
		[FieldOffset(Offset = "0x70")]
		internal int ins_h;

		[Token(Token = "0x400024B")]
		[FieldOffset(Offset = "0x74")]
		internal int hash_size;

		[Token(Token = "0x400024C")]
		[FieldOffset(Offset = "0x78")]
		internal int hash_bits;

		[Token(Token = "0x400024D")]
		[FieldOffset(Offset = "0x7C")]
		internal int hash_mask;

		[Token(Token = "0x400024E")]
		[FieldOffset(Offset = "0x80")]
		internal int hash_shift;

		[Token(Token = "0x400024F")]
		[FieldOffset(Offset = "0x84")]
		internal int block_start;

		[Token(Token = "0x4000250")]
		[FieldOffset(Offset = "0x88")]
		private Config config;

		[Token(Token = "0x4000251")]
		[FieldOffset(Offset = "0x90")]
		internal int match_length;

		[Token(Token = "0x4000252")]
		[FieldOffset(Offset = "0x94")]
		internal int prev_match;

		[Token(Token = "0x4000253")]
		[FieldOffset(Offset = "0x98")]
		internal int match_available;

		[Token(Token = "0x4000254")]
		[FieldOffset(Offset = "0x9C")]
		internal int strstart;

		[Token(Token = "0x4000255")]
		[FieldOffset(Offset = "0xA0")]
		internal int match_start;

		[Token(Token = "0x4000256")]
		[FieldOffset(Offset = "0xA4")]
		internal int lookahead;

		[Token(Token = "0x4000257")]
		[FieldOffset(Offset = "0xA8")]
		internal int prev_length;

		[Token(Token = "0x4000258")]
		[FieldOffset(Offset = "0xAC")]
		internal CompressionLevel compressionLevel;

		[Token(Token = "0x4000259")]
		[FieldOffset(Offset = "0xB0")]
		internal CompressionStrategy compressionStrategy;

		[Token(Token = "0x400025A")]
		[FieldOffset(Offset = "0xB8")]
		internal short[] dyn_ltree;

		[Token(Token = "0x400025B")]
		[FieldOffset(Offset = "0xC0")]
		internal short[] dyn_dtree;

		[Token(Token = "0x400025C")]
		[FieldOffset(Offset = "0xC8")]
		internal short[] bl_tree;

		[Token(Token = "0x400025D")]
		[FieldOffset(Offset = "0xD0")]
		internal Tree treeLiterals;

		[Token(Token = "0x400025E")]
		[FieldOffset(Offset = "0xD8")]
		internal Tree treeDistances;

		[Token(Token = "0x400025F")]
		[FieldOffset(Offset = "0xE0")]
		internal Tree treeBitLengths;

		[Token(Token = "0x4000260")]
		[FieldOffset(Offset = "0xE8")]
		internal short[] bl_count;

		[Token(Token = "0x4000261")]
		[FieldOffset(Offset = "0xF0")]
		internal int[] heap;

		[Token(Token = "0x4000262")]
		[FieldOffset(Offset = "0xF8")]
		internal int heap_len;

		[Token(Token = "0x4000263")]
		[FieldOffset(Offset = "0xFC")]
		internal int heap_max;

		[Token(Token = "0x4000264")]
		[FieldOffset(Offset = "0x100")]
		internal sbyte[] depth;

		[Token(Token = "0x4000265")]
		[FieldOffset(Offset = "0x108")]
		internal int _lengthOffset;

		[Token(Token = "0x4000266")]
		[FieldOffset(Offset = "0x10C")]
		internal int lit_bufsize;

		[Token(Token = "0x4000267")]
		[FieldOffset(Offset = "0x110")]
		internal int last_lit;

		[Token(Token = "0x4000268")]
		[FieldOffset(Offset = "0x114")]
		internal int _distanceOffset;

		[Token(Token = "0x4000269")]
		[FieldOffset(Offset = "0x118")]
		internal int opt_len;

		[Token(Token = "0x400026A")]
		[FieldOffset(Offset = "0x11C")]
		internal int static_len;

		[Token(Token = "0x400026B")]
		[FieldOffset(Offset = "0x120")]
		internal int matches;

		[Token(Token = "0x400026C")]
		[FieldOffset(Offset = "0x124")]
		internal int last_eob_len;

		[Token(Token = "0x400026D")]
		[FieldOffset(Offset = "0x128")]
		internal short bi_buf;

		[Token(Token = "0x400026E")]
		[FieldOffset(Offset = "0x12C")]
		internal int bi_valid;

		[Token(Token = "0x400026F")]
		[FieldOffset(Offset = "0x130")]
		private bool Rfc1950BytesEmitted;

		[Token(Token = "0x4000270")]
		[FieldOffset(Offset = "0x131")]
		private bool _WantRfc1950HeaderBytes;

		[Token(Token = "0x170000E0")]
		internal bool WantRfc1950HeaderBytes
		{
			[Token(Token = "0x6000395")]
			[Address(RVA = "0x78691D8", Offset = "0x78651D8", VA = "0x78691D8")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000396")]
			[Address(RVA = "0x78691E0", Offset = "0x78651E0", VA = "0x78691E0")]
			set
			{
			}
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x7865D3C", Offset = "0x7861D3C", VA = "0x7865D3C")]
		internal DeflateManager()
		{
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x7866198", Offset = "0x7862198", VA = "0x7866198")]
		private void _InitializeLazyMatch()
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x78663B0", Offset = "0x78623B0", VA = "0x78663B0")]
		private void _InitializeTreeData()
		{
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x7866468", Offset = "0x7862468", VA = "0x7866468")]
		internal void _InitializeBlocks()
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x7866638", Offset = "0x7862638", VA = "0x7866638")]
		internal void pqdownheap(short[] tree, int k)
		{
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x78667EC", Offset = "0x78627EC", VA = "0x78667EC")]
		internal static bool _IsSmaller(short[] tree, int n, int m, sbyte[] depth)
		{
			return default;
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x7866878", Offset = "0x7862878", VA = "0x7866878")]
		internal void scan_tree(short[] tree, int max_code)
		{
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x7866AB8", Offset = "0x7862AB8", VA = "0x7866AB8")]
		internal int build_bl_tree()
		{
			return default;
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x7866C14", Offset = "0x7862C14", VA = "0x7866C14")]
		internal void send_all_trees(int lcodes, int dcodes, int blcodes)
		{
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x7866E78", Offset = "0x7862E78", VA = "0x7866E78")]
		internal void send_tree(short[] tree, int max_code)
		{
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x78670B8", Offset = "0x78630B8", VA = "0x78670B8")]
		private void put_bytes(byte[] p, int start, int len)
		{
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x7867074", Offset = "0x7863074", VA = "0x7867074")]
		internal void send_code(int c, short[] tree)
		{
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x7866D44", Offset = "0x7862D44", VA = "0x7866D44")]
		internal void send_bits(int value, int length)
		{
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x7867100", Offset = "0x7863100", VA = "0x7867100")]
		internal void _tr_align()
		{
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x7867320", Offset = "0x7863320", VA = "0x7867320")]
		internal bool _tr_tally(int dist, int lc)
		{
			return default;
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x7867634", Offset = "0x7863634", VA = "0x7867634")]
		internal void send_compressed_block(short[] ltree, short[] dtree)
		{
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x7867930", Offset = "0x7863930", VA = "0x7867930")]
		internal void set_data_type()
		{
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x786724C", Offset = "0x786324C", VA = "0x786724C")]
		internal void bi_flush()
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x7867A9C", Offset = "0x7863A9C", VA = "0x7867A9C")]
		internal void bi_windup()
		{
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x7867B4C", Offset = "0x7863B4C", VA = "0x7867B4C")]
		internal void copy_block(int buf, int len, bool header)
		{
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x7867C64", Offset = "0x7863C64", VA = "0x7867C64")]
		internal void flush_block_only(bool eof)
		{
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x7867EC0", Offset = "0x7863EC0", VA = "0x7867EC0")]
		internal BlockState DeflateNone(FlushType flush)
		{
			return default;
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x7868284", Offset = "0x7864284", VA = "0x7868284")]
		internal void _tr_stored_block(int buf, int stored_len, bool eof)
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x7867CAC", Offset = "0x7863CAC", VA = "0x7867CAC")]
		internal void _tr_flush_block(int buf, int stored_len, bool eof)
		{
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x786803C", Offset = "0x786403C", VA = "0x786803C")]
		private void _fillWindow()
		{
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x7868328", Offset = "0x7864328", VA = "0x7868328")]
		internal BlockState DeflateFast(FlushType flush)
		{
			return default;
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x7868C54", Offset = "0x7864C54", VA = "0x7868C54")]
		internal BlockState DeflateSlow(FlushType flush)
		{
			return default;
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x7868798", Offset = "0x7864798", VA = "0x7868798")]
		internal int longest_match(int cur_match)
		{
			return default;
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x78691EC", Offset = "0x78651EC", VA = "0x78691EC")]
		internal int Initialize(ZlibCodec codec, CompressionLevel level)
		{
			return default;
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x7869204", Offset = "0x7865204", VA = "0x7869204")]
		internal int Initialize(ZlibCodec codec, CompressionLevel level, int bits)
		{
			return default;
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x7869518", Offset = "0x7865518", VA = "0x7869518")]
		internal int Initialize(ZlibCodec codec, CompressionLevel level, int bits, CompressionStrategy compressionStrategy)
		{
			return default;
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x7869298", Offset = "0x7865298", VA = "0x7869298")]
		internal int Initialize(ZlibCodec codec, CompressionLevel level, int windowBits, int memLevel, CompressionStrategy strategy)
		{
			return default;
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x78695B0", Offset = "0x78655B0", VA = "0x78695B0")]
		internal void Reset()
		{
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x78696A0", Offset = "0x78656A0", VA = "0x78696A0")]
		internal int End()
		{
			return default;
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x78662EC", Offset = "0x78622EC", VA = "0x78662EC")]
		private void SetDeflater()
		{
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x7869818", Offset = "0x7865818", VA = "0x7869818")]
		internal int SetParams(CompressionLevel level, CompressionStrategy strategy)
		{
			return default;
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x78698F8", Offset = "0x78658F8", VA = "0x78698F8")]
		internal int SetDictionary(byte[] dictionary)
		{
			return default;
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x7869BC8", Offset = "0x7865BC8", VA = "0x7869BC8")]
		internal int Deflate(FlushType flush)
		{
			return default;
		}
	}
}
