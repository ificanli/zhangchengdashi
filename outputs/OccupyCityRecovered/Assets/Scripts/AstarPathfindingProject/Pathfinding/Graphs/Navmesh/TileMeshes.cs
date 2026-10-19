using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding.Graphs.Navmesh
{
	[Token(Token = "0x20001D2")]
	public struct TileMeshes
	{
		[Token(Token = "0x40008A8")]
		[FieldOffset(Offset = "0x0")]
		public TileMesh[] tileMeshes;

		[Token(Token = "0x40008A9")]
		[FieldOffset(Offset = "0x8")]
		public IntRect tileRect;

		[Token(Token = "0x40008AA")]
		[FieldOffset(Offset = "0x18")]
		public Vector2 tileWorldSize;

		[Token(Token = "0x6000CF2")]
		[Address(RVA = "0x45A0384", Offset = "0x459C384", VA = "0x45A0384")]
		public void Rotate(int rotation)
		{
		}

		[Token(Token = "0x6000CF3")]
		[Address(RVA = "0x45A071C", Offset = "0x459C71C", VA = "0x45A071C")]
		public byte[] Serialize()
		{
			return null;
		}

		[Token(Token = "0x6000CF4")]
		[Address(RVA = "0x45A0AA0", Offset = "0x459CAA0", VA = "0x45A0AA0")]
		public static TileMeshes Deserialize(byte[] bytes)
		{
			return default;
		}
	}
}
