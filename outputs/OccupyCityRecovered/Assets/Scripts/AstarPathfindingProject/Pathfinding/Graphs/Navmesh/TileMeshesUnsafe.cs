using Il2CppDummyDll;
using Unity.Collections;
using UnityEngine;

namespace Pathfinding.Graphs.Navmesh
{
	[Token(Token = "0x20001D3")]
	public struct TileMeshesUnsafe
	{
		[Token(Token = "0x40008AB")]
		[FieldOffset(Offset = "0x0")]
		public NativeArray<TileMesh.TileMeshUnsafe> tileMeshes;

		[Token(Token = "0x40008AC")]
		[FieldOffset(Offset = "0x10")]
		public IntRect tileRect;

		[Token(Token = "0x40008AD")]
		[FieldOffset(Offset = "0x20")]
		public Vector2 tileWorldSize;

		[Token(Token = "0x6000CF5")]
		[Address(RVA = "0x45950F0", Offset = "0x45910F0", VA = "0x45950F0")]
		public TileMeshesUnsafe(NativeArray<TileMesh.TileMeshUnsafe> tileMeshes, IntRect tileRect, Vector2 tileWorldSize)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED TileMeshesUnsafe..ctor RVA=0x45950F0 Token=0x6000CF5");
}

		[Token(Token = "0x6000CF6")]
		[Address(RVA = "0x45A0F34", Offset = "0x459CF34", VA = "0x45A0F34")]
		public TileMeshes ToManaged()
		{
			return default;
		}

		[Token(Token = "0x6000CF7")]
		[Address(RVA = "0x4595ABC", Offset = "0x4591ABC", VA = "0x4595ABC")]
		public void Dispose(Allocator allocator)
		{
		}
	}
}
