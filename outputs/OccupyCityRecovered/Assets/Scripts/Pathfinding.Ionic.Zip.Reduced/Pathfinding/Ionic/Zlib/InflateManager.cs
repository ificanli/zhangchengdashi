using Il2CppDummyDll;

namespace Pathfinding.Ionic.Zlib
{
	[Token(Token = "0x2000056")]
	internal sealed class InflateManager
	{
		[Token(Token = "0x2000057")]
		private enum InflateManagerMode
		{
			[Token(Token = "0x40002E4")]
			METHOD = 0,
			[Token(Token = "0x40002E5")]
			FLAG = 1,
			[Token(Token = "0x40002E6")]
			DICT4 = 2,
			[Token(Token = "0x40002E7")]
			DICT3 = 3,
			[Token(Token = "0x40002E8")]
			DICT2 = 4,
			[Token(Token = "0x40002E9")]
			DICT1 = 5,
			[Token(Token = "0x40002EA")]
			DICT0 = 6,
			[Token(Token = "0x40002EB")]
			BLOCKS = 7,
			[Token(Token = "0x40002EC")]
			CHECK4 = 8,
			[Token(Token = "0x40002ED")]
			CHECK3 = 9,
			[Token(Token = "0x40002EE")]
			CHECK2 = 10,
			[Token(Token = "0x40002EF")]
			CHECK1 = 11,
			[Token(Token = "0x40002F0")]
			DONE = 12,
			[Token(Token = "0x40002F1")]
			BAD = 13
		}

		[Token(Token = "0x40002D7")]
		private const int PRESET_DICT = 32;

		[Token(Token = "0x40002D8")]
		private const int Z_DEFLATED = 8;

		[Token(Token = "0x40002D9")]
		[FieldOffset(Offset = "0x10")]
		private InflateManagerMode mode;

		[Token(Token = "0x40002DA")]
		[FieldOffset(Offset = "0x18")]
		internal ZlibCodec _codec;

		[Token(Token = "0x40002DB")]
		[FieldOffset(Offset = "0x20")]
		internal int method;

		[Token(Token = "0x40002DC")]
		[FieldOffset(Offset = "0x24")]
		internal uint computedCheck;

		[Token(Token = "0x40002DD")]
		[FieldOffset(Offset = "0x28")]
		internal uint expectedCheck;

		[Token(Token = "0x40002DE")]
		[FieldOffset(Offset = "0x2C")]
		internal int marker;

		[Token(Token = "0x40002DF")]
		[FieldOffset(Offset = "0x30")]
		private bool _handleRfc1950HeaderBytes;

		[Token(Token = "0x40002E0")]
		[FieldOffset(Offset = "0x34")]
		internal int wbits;

		[Token(Token = "0x40002E1")]
		[FieldOffset(Offset = "0x38")]
		internal InflateBlocks blocks;

		[Token(Token = "0x40002E2")]
		[FieldOffset(Offset = "0x0")]
		private static readonly byte[] mark;

		[Token(Token = "0x170000F7")]
		internal bool HandleRfc1950HeaderBytes
		{
			[Token(Token = "0x60003FC")]
			[Address(RVA = "0x78704F0", Offset = "0x786C4F0", VA = "0x78704F0")]
			get
			{
				return default;
			}
			[Token(Token = "0x60003FD")]
			[Address(RVA = "0x78704F8", Offset = "0x786C4F8", VA = "0x78704F8")]
			set
			{
			}
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x787041C", Offset = "0x786C41C", VA = "0x787041C")]
		public InflateManager()
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x787042C", Offset = "0x786C42C", VA = "0x787042C")]
		public InflateManager(bool expectRfc1950HeaderBytes)
		{
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x7870504", Offset = "0x786C504", VA = "0x7870504")]
		internal int Reset()
		{
			return default;
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x7870550", Offset = "0x786C550", VA = "0x7870550")]
		internal int End()
		{
			return default;
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x7870578", Offset = "0x786C578", VA = "0x7870578")]
		internal int Initialize(ZlibCodec codec, int w)
		{
			return default;
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x78706E0", Offset = "0x786C6E0", VA = "0x78706E0")]
		internal int Inflate(FlushType flush)
		{
			return default;
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x7870E0C", Offset = "0x786CE0C", VA = "0x7870E0C")]
		internal int SetDictionary(byte[] dictionary)
		{
			return default;
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x78712F8", Offset = "0x786D2F8", VA = "0x78712F8")]
		internal int Sync()
		{
			return default;
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x787149C", Offset = "0x786D49C", VA = "0x787149C")]
		internal int SyncPoint(ZlibCodec z)
		{
			return default;
		}
	}
}
