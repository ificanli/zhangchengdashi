using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	[Serializable]
	[Token(Token = "0x2000035")]
	public struct GraphMask
	{
		[Token(Token = "0x4000186")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private int value;

		[Token(Token = "0x4000187")]
		private const uint LargeGraphIndicesBit = 2147483648u;

		[Token(Token = "0x4000188")]
		private const uint InvertedBit = 1073741824u;

		[Token(Token = "0x4000189")]
		private const uint SmallestLargeGraphIndex = 30u;

		[Token(Token = "0x400018A")]
		private const uint RemainingGraphIndicesBit = 1073741824u;

		[Token(Token = "0x400018B")]
		private const uint Everything = uint.MaxValue;

		[Token(Token = "0x170000C0")]
		public static GraphMask everything
		{
			[Token(Token = "0x6000286")]
			[Address(RVA = "0x445B954", Offset = "0x4457954", VA = "0x445B954")]
			get
			{
                return new GraphMask { value = -1 };
            }
		}

		[Token(Token = "0x170000C1")]
		public bool containsAllGraphs
		{
			[Token(Token = "0x6000287")]
			[Address(RVA = "0x445C39C", Offset = "0x445839C", VA = "0x445C39C")]
			get
			{ return value == -1; }
		}

		[Token(Token = "0x170000C2")]
		public bool isPureBitmask
		{
			[Token(Token = "0x6000288")]
			[Address(RVA = "0x445EDB8", Offset = "0x445ADB8", VA = "0x445EDB8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x445EDC8", Offset = "0x445ADC8", VA = "0x445EDC8")]
		public GraphMask(uint value)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED GraphMask..ctor RVA=0x445EDC8 Token=0x6000289");
}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x445EDD0", Offset = "0x445ADD0", VA = "0x445EDD0")]
		public static GraphMask operator |(GraphMask lhs, GraphMask rhs)
		{
			return default;
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x445EECC", Offset = "0x445AECC", VA = "0x445EECC")]
		private unsafe static void InsertMask(uint* indices, ref int cnt, uint mask)
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x445EFD4", Offset = "0x445AFD4", VA = "0x445EFD4")]
		private unsafe static void InsertSorted(uint* indices, ref int cnt, uint value)
		{
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x445F198", Offset = "0x445B198", VA = "0x445F198")]
		public static GraphMask operator ~(GraphMask lhs)
		{
			return default;
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x445F1C0", Offset = "0x445B1C0", VA = "0x445F1C0")]
		public static bool operator ==(GraphMask lhs, GraphMask rhs)
		{
			return default;
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x445F1CC", Offset = "0x445B1CC", VA = "0x445F1CC")]
		public static bool operator !=(GraphMask lhs, GraphMask rhs)
		{
			return default;
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x445F1D8", Offset = "0x445B1D8", VA = "0x445F1D8", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default;
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x445F250", Offset = "0x445B250", VA = "0x445F250", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default;
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x445F258", Offset = "0x445B258", VA = "0x445F258")]
		public readonly bool Contains(NavGraph graph)
		{
			return default;
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x445F270", Offset = "0x445B270", VA = "0x445F270")]
		public readonly bool Contains(uint graphIndex)
		{
			return default;
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x445F2E0", Offset = "0x445B2E0", VA = "0x445F2E0")]
		public static GraphMask FromGraph(NavGraph graph)
		{
			return default;
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x445F334", Offset = "0x445B334", VA = "0x445F334", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x445F314", Offset = "0x445B314", VA = "0x445F314")]
		public static GraphMask FromGraphIndex(uint graphIndex)
		{
			return default;
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x445F394", Offset = "0x445B394", VA = "0x445F394")]
		public static GraphMask FromGraphName(string graphName)
		{
			return default;
		}
	}
}
