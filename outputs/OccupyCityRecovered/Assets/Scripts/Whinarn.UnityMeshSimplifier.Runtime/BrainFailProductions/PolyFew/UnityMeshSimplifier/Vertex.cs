using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace BrainFailProductions.PolyFew.UnityMeshSimplifier
{
	[Token(Token = "0x200001E")]
	public class Vertex : IEquatable<Vertex>
	{
		[Token(Token = "0x40000D0")]
		[FieldOffset(Offset = "0x10")]
		public int index;

		[Token(Token = "0x40000D1")]
		[FieldOffset(Offset = "0x18")]
		public Vector3d p;

		[Token(Token = "0x40000D2")]
		[FieldOffset(Offset = "0x30")]
		public int tstart;

		[Token(Token = "0x40000D3")]
		[FieldOffset(Offset = "0x34")]
		public int tcount;

		[Token(Token = "0x40000D4")]
		[FieldOffset(Offset = "0x38")]
		public int estart;

		[Token(Token = "0x40000D5")]
		[FieldOffset(Offset = "0x3C")]
		public int ecount;

		[Token(Token = "0x40000D6")]
		[FieldOffset(Offset = "0x40")]
		public SymmetricMatrix q;

		[Token(Token = "0x40000D7")]
		[FieldOffset(Offset = "0x48")]
		public SymmetricMatrix qPenaltyEdge;

		[Token(Token = "0x40000D8")]
		[FieldOffset(Offset = "0x50")]
		public bool borderEdge;

		[Token(Token = "0x40000D9")]
		[FieldOffset(Offset = "0x51")]
		public bool uvSeamEdge;

		[Token(Token = "0x40000DA")]
		[FieldOffset(Offset = "0x52")]
		public bool uvFoldoverEdge;

		[Token(Token = "0x40000DB")]
		[FieldOffset(Offset = "0x58")]
		public ToleranceSphere enclosingSphere;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600011E")]
		[Address(RVA = "0x8569FB8", Offset = "0x8565FB8", VA = "0x8569FB8")]
		public Vertex(int index, Vector3d p)
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x856A09C", Offset = "0x856609C", VA = "0x856A09C", Slot = "2")]
		public override int GetHashCode()
		{
			return default;
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x856A0A4", Offset = "0x85660A4", VA = "0x856A0A4", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default;
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x856A130", Offset = "0x8566130", VA = "0x856A130", Slot = "4")]
		public bool Equals(Vertex other)
		{
			return default;
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x856A154", Offset = "0x8566154", VA = "0x856A154", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
