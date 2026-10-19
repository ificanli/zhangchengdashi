using Il2CppDummyDll;
using UnityEngine;

namespace BrainFailProductions.PolyFew.UnityMeshSimplifier
{
	[Token(Token = "0x2000012")]
	internal class DebugMeshPerf
	{
		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0x10")]
		public int nrErrorEval;

		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0x14")]
		public int nrEdgeReinsert;

		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0x18")]
		public int nrLoopTest;

		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0x1C")]
		public int nrLoopComplete;

		[Token(Token = "0x4000079")]
		[FieldOffset(Offset = "0x20")]
		public int nrErrorTypeEllipsoid;

		[Token(Token = "0x400007A")]
		[FieldOffset(Offset = "0x24")]
		public int nrErrorTypeVertex;

		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x28")]
		public int nrBorder2D;

		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x2C")]
		public int nrUVSeamEdge;

		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0x30")]
		public int nrUVFoldoverEdge;

		[Token(Token = "0x400007E")]
		[FieldOffset(Offset = "0x34")]
		public int nrEdgeLag;

		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0x38")]
		public int nrEdgeRejected;

		[Token(Token = "0x4000080")]
		[FieldOffset(Offset = "0x3C")]
		public int nrTrisBefore;

		[Token(Token = "0x4000081")]
		[FieldOffset(Offset = "0x40")]
		public int nrTrisAfter;

		[Token(Token = "0x4000082")]
		[FieldOffset(Offset = "0x48")]
		public double lastErrorValue;

		[Token(Token = "0x4000083")]
		[FieldOffset(Offset = "0x50")]
		public int[] Triplets;

		[Token(Token = "0x4000084")]
		[FieldOffset(Offset = "0x0")]
		private static DebugMeshPerf singleton;

		[Token(Token = "0x17000035")]
		public static DebugMeshPerf Data
		{
			[Token(Token = "0x60000EC")]
			[Address(RVA = "0x8567F28", Offset = "0x8563F28", VA = "0x8567F28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x8567E78", Offset = "0x8563E78", VA = "0x8567E78")]
		private DebugMeshPerf()
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x8567ED0", Offset = "0x8563ED0", VA = "0x8567ED0")]
		public void Reset()
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x8567F9C", Offset = "0x8563F9C", VA = "0x8567F9C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x85684D4", Offset = "0x85644D4", VA = "0x85684D4")]
		public static Color[] UpdateVertexColor(Vertex[] vertices, Edge[] v2e)
		{
			return null;
		}
	}
}
