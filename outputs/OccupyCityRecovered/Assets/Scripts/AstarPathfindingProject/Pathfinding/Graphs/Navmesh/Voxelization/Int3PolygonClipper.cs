using Il2CppDummyDll;
using Pathfinding.Collections;

namespace Pathfinding.Graphs.Navmesh.Voxelization
{
	[Token(Token = "0x20001D7")]
	internal struct Int3PolygonClipper
	{
		[Token(Token = "0x40008BD")]
		[FieldOffset(Offset = "0x0")]
		private unsafe fixed float clipPolygonCache[21];

		[Token(Token = "0x6000D29")]
		[Address(RVA = "0x459B064", Offset = "0x4597064", VA = "0x459B064")]
		public int ClipPolygon(UnsafeSpan<Int3> vIn, int n, UnsafeSpan<Int3> vOut, int multi, int offset, int axis)
		{
			return default;
		}
	}
}
