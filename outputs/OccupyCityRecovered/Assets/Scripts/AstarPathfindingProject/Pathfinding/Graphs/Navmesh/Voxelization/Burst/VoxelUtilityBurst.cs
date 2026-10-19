using Il2CppDummyDll;
using Unity.Collections;

namespace Pathfinding.Graphs.Navmesh.Voxelization.Burst
{
	[Token(Token = "0x20001F1")]
	internal static class VoxelUtilityBurst
	{
		[Token(Token = "0x400092B")]
		public const int TagRegMask = 16383;

		[Token(Token = "0x400092C")]
		public const int TagReg = 16384;

		[Token(Token = "0x400092D")]
		public const ushort BorderReg = 32768;

		[Token(Token = "0x400092E")]
		public const int RC_BORDER_VERTEX = 65536;

		[Token(Token = "0x400092F")]
		public const int RC_AREA_BORDER = 131072;

		[Token(Token = "0x4000930")]
		public const int VERTEX_BUCKET_COUNT = 4096;

		[Token(Token = "0x4000931")]
		public const int RC_CONTOUR_TESS_WALL_EDGES = 1;

		[Token(Token = "0x4000932")]
		public const int RC_CONTOUR_TESS_AREA_EDGES = 2;

		[Token(Token = "0x4000933")]
		public const int RC_CONTOUR_TESS_TILE_EDGES = 4;

		[Token(Token = "0x4000934")]
		public const int ContourRegMask = 65535;

		[Token(Token = "0x4000935")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int[] DX;

		[Token(Token = "0x4000936")]
		[FieldOffset(Offset = "0x8")]
		public static readonly int[] DZ;

		[Token(Token = "0x6000D6D")]
		[Address(RVA = "0x446BF74", Offset = "0x4467F74", VA = "0x446BF74")]
		public static void CalculateDistanceField(CompactVoxelField field, NativeArray<ushort> output)
		{
		}

		[Token(Token = "0x6000D6E")]
		[Address(RVA = "0x446C8F0", Offset = "0x44688F0", VA = "0x446C8F0")]
		public static void BoxBlur(CompactVoxelField field, NativeArray<ushort> src, NativeArray<ushort> dst)
		{
		}
	}
}
