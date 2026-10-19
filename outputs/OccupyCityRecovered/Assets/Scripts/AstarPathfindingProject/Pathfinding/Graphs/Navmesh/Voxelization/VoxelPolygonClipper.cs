using Il2CppDummyDll;
using Unity.Burst;

namespace Pathfinding.Graphs.Navmesh.Voxelization
{
	[Token(Token = "0x20001D9")]
	internal struct VoxelPolygonClipper
	{
		[Token(Token = "0x40008BF")]
		[FieldOffset(Offset = "0x0")]
		public unsafe fixed float x[8];

		[Token(Token = "0x40008C0")]
		[FieldOffset(Offset = "0x20")]
		public unsafe fixed float y[8];

		[Token(Token = "0x40008C1")]
		[FieldOffset(Offset = "0x40")]
		public unsafe fixed float z[8];

		[Token(Token = "0x40008C2")]
		[FieldOffset(Offset = "0x60")]
		public int n;

		[Token(Token = "0x1700020D")]
		public int this[int i]
		{
			[Token(Token = "0x6000D2A")]
			[Address(RVA = "0x45A3840", Offset = "0x459F840", VA = "0x45A3840")]
			set
			{
			}
		}

		[Token(Token = "0x6000D2B")]
		[Address(RVA = "0x45A3854", Offset = "0x459F854", VA = "0x45A3854")]
		public void ClipPolygonAlongX([NoAlias] ref VoxelPolygonClipper result, float multi, float offset)
		{
		}

		[Token(Token = "0x6000D2C")]
		[Address(RVA = "0x45A3948", Offset = "0x459F948", VA = "0x45A3948")]
		public void ClipPolygonAlongZWithYZ([NoAlias] ref VoxelPolygonClipper result, float multi, float offset)
		{
		}

		[Token(Token = "0x6000D2D")]
		[Address(RVA = "0x45A3A70", Offset = "0x459FA70", VA = "0x45A3A70")]
		public void ClipPolygonAlongZWithY([NoAlias] ref VoxelPolygonClipper result, float multi, float offset)
		{
		}
	}
}
