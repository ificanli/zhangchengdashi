using System.Collections.Generic;
using Il2CppDummyDll;

namespace I2.Loc
{
	[Token(Token = "0x2000DC1")]
	internal class ArabicTable
	{
		[Token(Token = "0x40060C3")]
		[FieldOffset(Offset = "0x0")]
		private static List<ArabicMapping> mapList;

		[Token(Token = "0x40060C4")]
		[FieldOffset(Offset = "0x8")]
		private static ArabicTable arabicMapper;

		[Token(Token = "0x17000E7B")]
		internal static ArabicTable ArabicMapper
		{
			[Token(Token = "0x600552D")]
			[Address(RVA = "0x432EB00", Offset = "0x432AB00", VA = "0x432EB00")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600552C")]
		[Address(RVA = "0x432D500", Offset = "0x4329500", VA = "0x432D500")]
		private ArabicTable()
		{
		}

		[Token(Token = "0x600552E")]
		[Address(RVA = "0x432EB68", Offset = "0x432AB68", VA = "0x432EB68")]
		internal int Convert(int toBeConverted)
		{
			return default;
		}
	}
}
