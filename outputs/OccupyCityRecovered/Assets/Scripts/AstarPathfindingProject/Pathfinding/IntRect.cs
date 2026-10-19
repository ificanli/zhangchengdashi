using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	[Serializable]
	[Token(Token = "0x2000034")]
	public struct IntRect
	{
		[Token(Token = "0x4000182")]
		[FieldOffset(Offset = "0x0")]
		public int xmin;

		[Token(Token = "0x4000183")]
		[FieldOffset(Offset = "0x4")]
		public int ymin;

		[Token(Token = "0x4000184")]
		[FieldOffset(Offset = "0x8")]
		public int xmax;

		[Token(Token = "0x4000185")]
		[FieldOffset(Offset = "0xC")]
		public int ymax;

		[Token(Token = "0x170000BB")]
		public Vector2Int Min
		{
			[Token(Token = "0x6000272")]
			[Address(RVA = "0x445E460", Offset = "0x445A460", VA = "0x445E460")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000BC")]
		public Vector2Int Max
		{
			[Token(Token = "0x6000273")]
			[Address(RVA = "0x445E468", Offset = "0x445A468", VA = "0x445E468")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000BD")]
		public int Width
		{
			[Token(Token = "0x6000274")]
			[Address(RVA = "0x445E470", Offset = "0x445A470", VA = "0x445E470")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000BE")]
		public int Height
		{
			[Token(Token = "0x6000275")]
			[Address(RVA = "0x445E484", Offset = "0x445A484", VA = "0x445E484")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000BF")]
		public int Area
		{
			[Token(Token = "0x6000276")]
			[Address(RVA = "0x445E498", Offset = "0x445A498", VA = "0x445E498")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x445E3D4", Offset = "0x445A3D4", VA = "0x445E3D4")]
		public IntRect(int xmin, int ymin, int xmax, int ymax)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED IntRect..ctor RVA=0x445E3D4 Token=0x600026F");
}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x445E3E0", Offset = "0x445A3E0", VA = "0x445E3E0")]
		public bool Contains(int x, int y)
		{
			return default;
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x445E41C", Offset = "0x445A41C", VA = "0x445E41C")]
		public bool Contains(IntRect other)
		{
			return default;
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x445E4B4", Offset = "0x445A4B4", VA = "0x445E4B4")]
		public bool IsValid()
		{
			return default;
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x445E4E0", Offset = "0x445A4E0", VA = "0x445E4E0")]
		public static bool operator ==(IntRect a, IntRect b)
		{
			return default;
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x445E524", Offset = "0x445A524", VA = "0x445E524")]
		public static bool operator !=(IntRect a, IntRect b)
		{
			return default;
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x445E568", Offset = "0x445A568", VA = "0x445E568")]
		public static explicit operator Rect(IntRect r)
		{
			return default;
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x445E594", Offset = "0x445A594", VA = "0x445E594", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default;
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x445E63C", Offset = "0x445A63C", VA = "0x445E63C", Slot = "2")]
		public override int GetHashCode()
		{
			return default;
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x445E664", Offset = "0x445A664", VA = "0x445E664")]
		public static IntRect Intersection(IntRect a, IntRect b)
		{
			return default;
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x445E740", Offset = "0x445A740", VA = "0x445E740")]
		public static bool Intersects(IntRect a, IntRect b)
		{
			return default;
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x445E784", Offset = "0x445A784", VA = "0x445E784")]
		public static IntRect Union(IntRect a, IntRect b)
		{
			return default;
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x445E860", Offset = "0x445A860", VA = "0x445E860")]
		public static IntRect Exclude(IntRect a, IntRect b)
		{
			return default;
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x445E9CC", Offset = "0x445A9CC", VA = "0x445E9CC")]
		public IntRect ExpandToContain(int x, int y)
		{
			return default;
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x445EA9C", Offset = "0x445AA9C", VA = "0x445EA9C")]
		public IntRect Offset(Vector2Int offset)
		{
			return default;
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x445EAC4", Offset = "0x445AAC4", VA = "0x445EAC4")]
		public IntRect Expand(int range)
		{
			return default;
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x445EAEC", Offset = "0x445AAEC", VA = "0x445EAEC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x445EC60", Offset = "0x445AC60", VA = "0x445EC60")]
		public List<Vector2Int> GetInnerCoordinates()
		{
			return null;
		}
	}
}
