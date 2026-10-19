using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace BrainFailProductions.PolyFew.UnityMeshSimplifier
{
	[Token(Token = "0x2000018")]
	public class Edge
	{
		[Token(Token = "0x2000019")]
		public enum QState
		{
			[Token(Token = "0x40000AD")]
			QIsNotCalculated = 0,
			[Token(Token = "0x40000AE")]
			QIsCalculated = 1,
			[Token(Token = "0x40000AF")]
			QPenaltyIsCalculated = 2,
			[Token(Token = "0x40000B0")]
			ErrorIsCalculated = 3
		}

		[Token(Token = "0x4000096")]
		[FieldOffset(Offset = "0x10")]
		public Triangle containingTriangle;

		[Token(Token = "0x4000097")]
		[FieldOffset(Offset = "0x18")]
		public int vertexA;

		[Token(Token = "0x4000098")]
		[FieldOffset(Offset = "0x1C")]
		public int vertexB;

		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0x20")]
		public int vSmall;

		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0x24")]
		public int vLarge;

		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0x28")]
		public ulong key;

		[Token(Token = "0x400009C")]
		[FieldOffset(Offset = "0x30")]
		public int hashCode;

		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0x38")]
		public double error;

		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0x40")]
		public double errorKeyed;

		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0x48")]
		public Vector3d p;

		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0x60")]
		public SymmetricMatrix q;

		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0x68")]
		public SymmetricMatrix qTwice;

		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0x70")]
		public SymmetricMatrix qPenaltyBorderVertexA;

		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0x78")]
		public SymmetricMatrix qPenaltyBorderVertexB;

		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0x80")]
		public bool isDeleted;

		[Token(Token = "0x40000A5")]
		[FieldOffset(Offset = "0x81")]
		public bool isBorder2D;

		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0x82")]
		public bool isUVSeam;

		[Token(Token = "0x40000A7")]
		[FieldOffset(Offset = "0x83")]
		public bool isUVFoldover;

		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0x84")]
		public int index;

		[Token(Token = "0x40000A9")]
		[FieldOffset(Offset = "0x88")]
		public QState flagCalculateQstate;

		[Token(Token = "0x40000AA")]
		[FieldOffset(Offset = "0x8C")]
		public readonly int ova;

		[Token(Token = "0x40000AB")]
		[FieldOffset(Offset = "0x90")]
		public readonly int ovb;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x8569190", Offset = "0x8565190", VA = "0x8569190")]
		public Edge(int vertexA, int vertexB)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x85692C4", Offset = "0x85652C4", VA = "0x85692C4")]
		private void InitIndex(int vertexA, int vertexB)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000100")]
		[Address(RVA = "0x85693C4", Offset = "0x85653C4", VA = "0x85693C4")]
		public void ReplaceVertex(int oldVertex, int newVertex)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000101")]
		[Address(RVA = "0x856945C", Offset = "0x856545C", VA = "0x856945C")]
		public static ulong CalculateKey(int vertexA, int vertexB)
		{
			return default;
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x856947C", Offset = "0x856547C", VA = "0x856947C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
