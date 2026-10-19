using Il2CppDummyDll;
using Pathfinding.Collections;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;

namespace Pathfinding.Graphs.Navmesh.Voxelization.Burst
{
	[Token(Token = "0x20001E6")]
	[BurstCompile]
	public struct JobBuildMesh : IJob
	{
		[Token(Token = "0x40008F5")]
		[FieldOffset(Offset = "0x0")]
		public NativeList<int> contourVertices;

		[Token(Token = "0x40008F6")]
		[FieldOffset(Offset = "0x8")]
		public NativeList<VoxelContour> contours;

		[Token(Token = "0x40008F7")]
		[FieldOffset(Offset = "0x10")]
		public VoxelMesh mesh;

		[Token(Token = "0x40008F8")]
		[FieldOffset(Offset = "0x28")]
		public CompactVoxelField field;

		[Token(Token = "0x6000D4C")]
		[Address(RVA = "0x4468500", Offset = "0x4464500", VA = "0x4468500")]
		private static bool Diagonal(int i, int j, int n, NativeArray<int> verts, NativeArray<int> indices)
		{
			return default;
		}

		[Token(Token = "0x6000D4D")]
		[Address(RVA = "0x446857C", Offset = "0x446457C", VA = "0x446857C")]
		private static bool InCone(int i, int j, int n, NativeArray<int> verts, NativeArray<int> indices)
		{
			return default;
		}

		[Token(Token = "0x6000D4E")]
		[Address(RVA = "0x4468854", Offset = "0x4464854", VA = "0x4468854")]
		private static bool Left(int a, int b, int c, NativeArray<int> verts)
		{
			return default;
		}

		[Token(Token = "0x6000D4F")]
		[Address(RVA = "0x446883C", Offset = "0x446483C", VA = "0x446883C")]
		private static bool LeftOn(int a, int b, int c, NativeArray<int> verts)
		{
			return default;
		}

		[Token(Token = "0x6000D50")]
		[Address(RVA = "0x44688A8", Offset = "0x44648A8", VA = "0x44688A8")]
		private static bool Collinear(int a, int b, int c, NativeArray<int> verts)
		{
			return default;
		}

		[Token(Token = "0x6000D51")]
		[Address(RVA = "0x4468868", Offset = "0x4464868", VA = "0x4468868")]
		public static int Area2(int a, int b, int c, NativeArray<int> verts)
		{
			return default;
		}

		[Token(Token = "0x6000D52")]
		[Address(RVA = "0x44686B0", Offset = "0x44646B0", VA = "0x44686B0")]
		private static bool Diagonalie(int i, int j, int n, NativeArray<int> verts, NativeArray<int> indices)
		{
			return default;
		}

		[Token(Token = "0x6000D53")]
		[Address(RVA = "0x44689B8", Offset = "0x44649B8", VA = "0x44689B8")]
		private static bool Xorb(bool x, bool y)
		{
			return default;
		}

		[Token(Token = "0x6000D54")]
		[Address(RVA = "0x44689C4", Offset = "0x44649C4", VA = "0x44689C4")]
		private static bool IntersectProp(int a, int b, int c, int d, NativeArray<int> verts)
		{
			return default;
		}

		[Token(Token = "0x6000D55")]
		[Address(RVA = "0x4468B04", Offset = "0x4464B04", VA = "0x4468B04")]
		private static bool Between(int a, int b, int c, NativeArray<int> verts)
		{
			return default;
		}

		[Token(Token = "0x6000D56")]
		[Address(RVA = "0x44688F4", Offset = "0x44648F4", VA = "0x44688F4")]
		private static bool Intersect(int a, int b, int c, int d, NativeArray<int> verts)
		{
			return default;
		}

		[Token(Token = "0x6000D57")]
		[Address(RVA = "0x44688C0", Offset = "0x44648C0", VA = "0x44688C0")]
		private static bool Vequal(int a, int b, NativeArray<int> verts)
		{
			return default;
		}

		[Token(Token = "0x6000D58")]
		[Address(RVA = "0x4468828", Offset = "0x4464828", VA = "0x4468828")]
		private static int Prev(int i, int n)
		{
			return default;
		}

		[Token(Token = "0x6000D59")]
		[Address(RVA = "0x4468818", Offset = "0x4464818", VA = "0x4468818")]
		private static int Next(int i, int n)
		{
			return default;
		}

		[Token(Token = "0x6000D5A")]
		[Address(RVA = "0x4468BC4", Offset = "0x4464BC4", VA = "0x4468BC4")]
		private static int AddVertex(NativeList<Int3> vertices, NativeHashMap<Int3, int> vertexMap, Int3 vertex)
		{
			return default;
		}

		[Token(Token = "0x6000D5B")]
		[Address(RVA = "0x4468CEC", Offset = "0x4464CEC", VA = "0x4468CEC", Slot = "4")]
		public void Execute()
		{
		}

		[Token(Token = "0x6000D5C")]
		[Address(RVA = "0x446971C", Offset = "0x446571C", VA = "0x446971C")]
		private void RemoveTileBorderVertices(ref VoxelMesh mesh, NativeArray<bool> verticesToRemove)
		{
		}

		[Token(Token = "0x6000D5D")]
		[Address(RVA = "0x44698EC", Offset = "0x44658EC", VA = "0x44698EC")]
		private bool CanRemoveVertex(ref VoxelMesh mesh, int vertexToRemove, UnsafeSpan<byte> vertexScratch)
		{
			return default;
		}

		[Token(Token = "0x6000D5E")]
		[Address(RVA = "0x4469CE0", Offset = "0x4465CE0", VA = "0x4469CE0")]
		private void RemoveVertex(ref VoxelMesh mesh, int vertexToRemove)
		{
		}

		[Token(Token = "0x6000D5F")]
		[Address(RVA = "0x4469404", Offset = "0x4465404", VA = "0x4469404")]
		private static int Triangulate(int n, NativeArray<int> verts, NativeArray<int> indices, NativeArray<int> tris)
		{
			return default;
		}
	}
}
