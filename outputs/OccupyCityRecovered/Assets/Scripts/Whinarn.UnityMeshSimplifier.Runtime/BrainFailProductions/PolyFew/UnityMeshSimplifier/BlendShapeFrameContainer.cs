using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace BrainFailProductions.PolyFew.UnityMeshSimplifier
{
	[Token(Token = "0x2000015")]
	internal class BlendShapeFrameContainer
	{
		[Token(Token = "0x400008F")]
		[FieldOffset(Offset = "0x10")]
		private readonly float frameWeight;

		[Token(Token = "0x4000090")]
		[FieldOffset(Offset = "0x18")]
		private readonly ResizableArray<Vector3> deltaVertices;

		[Token(Token = "0x4000091")]
		[FieldOffset(Offset = "0x20")]
		private readonly ResizableArray<Vector3> deltaNormals;

		[Token(Token = "0x4000092")]
		[FieldOffset(Offset = "0x28")]
		private readonly ResizableArray<Vector3> deltaTangents;

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x856889C", Offset = "0x856489C", VA = "0x856889C")]
		public BlendShapeFrameContainer(BlendShapeFrame frame)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x8568D6C", Offset = "0x8564D6C", VA = "0x8568D6C")]
		public void MoveVertexElement(int dst, int src)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x8568EA4", Offset = "0x8564EA4", VA = "0x8568EA4")]
		public void InterpolateVertexAttributes(int dst, int i0, int i1, int i2, ref Vector3 barycentricCoord)
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x8568AFC", Offset = "0x8564AFC", VA = "0x8568AFC")]
		public void Resize(int length, bool trimExess = false)
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x8568CB8", Offset = "0x8564CB8", VA = "0x8568CB8")]
		public BlendShapeFrame ToBlendShapeFrame()
		{
			return default;
		}
	}
}
