using Il2CppDummyDll;
using Pathfinding.Jobs;
using Unity.Collections;
using Unity.Mathematics;

namespace Pathfinding.Graphs.Grid
{
	[Token(Token = "0x2000209")]
	public static class GridIterationUtilities
	{
		[Token(Token = "0x200020A")]
		public interface ISliceAction
		{
			[Token(Token = "0x6000DC3")]
			void Execute(uint outerIdx, uint innerIdx);
		}

		[Token(Token = "0x200020B")]
		public interface ISliceActionWithCoords
		{
			[Token(Token = "0x6000DC4")]
			void Execute(uint outerIdx, uint innerIdx, int3 innerCoords);
		}

		[Token(Token = "0x200020C")]
		public interface ICellAction
		{
			[Token(Token = "0x6000DC5")]
			void Execute(uint idx, int x, int y, int z);
		}

		[Token(Token = "0x200020D")]
		public interface INodeModifier
		{
			[Token(Token = "0x6000DC6")]
			void ModifyNode(int dataIndex, int dataX, int dataLayer, int dataZ);
		}

		[Token(Token = "0x200020E")]
		public interface IConnectionFilter
		{
			[Token(Token = "0x6000DC7")]
			bool IsValidConnection(int dataIndex, int dataX, int dataLayer, int dataZ, int direction, int neighbourDataIndex);
		}

		[Token(Token = "0x6000DBD")]
		public static void ForEachCellIn3DSlice<T>(Slice3D slice, ref T action) where T : struct, ISliceAction
		{
		}

		[Token(Token = "0x6000DBE")]
		public static void ForEachCellIn3DSliceWithCoords<T>(Slice3D slice, ref T action) where T : struct, ISliceActionWithCoords
		{
		}

		[Token(Token = "0x6000DBF")]
		public static void ForEachCellIn3DArray<T>(int3 size, ref T action) where T : struct, ICellAction
		{
		}

		[Token(Token = "0x6000DC0")]
		public static void ForEachNode<T>(int3 arrayBounds, NativeArray<float4> nodeNormals, ref T callback) where T : struct, INodeModifier
		{
		}

		[Token(Token = "0x6000DC1")]
		public static void FilterNodeConnections<T>(IntBounds bounds, NativeArray<ulong> nodeConnections, bool layeredDataLayout, ref T filter) where T : struct, IConnectionFilter
		{
		}

		[Token(Token = "0x6000DC2")]
		[Address(RVA = "0x4476C30", Offset = "0x4472C30", VA = "0x4476C30")]
		public static int? GetNeighbourDataIndex(IntBounds bounds, NativeArray<ulong> nodeConnections, bool layeredDataLayout, int dataX, int dataLayer, int dataZ, int direction)
		{
			return null;
		}
	}
}
