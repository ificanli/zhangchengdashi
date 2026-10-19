using Il2CppDummyDll;
using Pathfinding.Collections;
using Unity.Mathematics;
using UnityEngine;

namespace Pathfinding.Graphs.Navmesh.Voxelization.Burst
{
	[Token(Token = "0x20001E7")]
	public struct RasterizationMesh
	{
		[Token(Token = "0x40008F9")]
		[FieldOffset(Offset = "0x0")]
		public UnsafeSpan<float3> vertices;

		[Token(Token = "0x40008FA")]
		[FieldOffset(Offset = "0x10")]
		public UnsafeSpan<int> triangles;

		[Token(Token = "0x40008FB")]
		[FieldOffset(Offset = "0x20")]
		public UnsafeSpan<int> areas;

		[Token(Token = "0x40008FC")]
		[FieldOffset(Offset = "0x30")]
		public int area;

		[Token(Token = "0x40008FD")]
		[FieldOffset(Offset = "0x34")]
		public Bounds bounds;

		[Token(Token = "0x40008FE")]
		[FieldOffset(Offset = "0x4C")]
		public Matrix4x4 matrix;

		[Token(Token = "0x40008FF")]
		[FieldOffset(Offset = "0x8C")]
		public bool solid;

		[Token(Token = "0x4000900")]
		[FieldOffset(Offset = "0x8D")]
		public bool doubleSided;

		[Token(Token = "0x4000901")]
		[FieldOffset(Offset = "0x8E")]
		public bool flatten;
	}
}
