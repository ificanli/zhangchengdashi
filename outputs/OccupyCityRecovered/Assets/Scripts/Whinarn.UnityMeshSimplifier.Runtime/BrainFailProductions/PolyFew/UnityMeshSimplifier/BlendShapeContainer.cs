using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace BrainFailProductions.PolyFew.UnityMeshSimplifier
{
	[Token(Token = "0x2000014")]
	public class BlendShapeContainer
	{
		[Token(Token = "0x400008D")]
		[FieldOffset(Offset = "0x10")]
		private readonly string shapeName;

		[Token(Token = "0x400008E")]
		[FieldOffset(Offset = "0x18")]
		private readonly BlendShapeFrameContainer[] frames;

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x8568758", Offset = "0x8564758", VA = "0x8568758")]
		public BlendShapeContainer(BlendShape blendShape)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x8568978", Offset = "0x8564978", VA = "0x8568978")]
		public void MoveVertexElement(int dst, int src)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x85689F0", Offset = "0x85649F0", VA = "0x85689F0")]
		public void InterpolateVertexAttributes(int dst, int i0, int i1, int i2, ref Vector3 barycentricCoord)
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x8568A88", Offset = "0x8564A88", VA = "0x8568A88")]
		public void Resize(int length, bool trimExess = false)
		{
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x8568BA4", Offset = "0x8564BA4", VA = "0x8568BA4")]
		public BlendShape ToBlendShape()
		{
			return default;
		}
	}
}
