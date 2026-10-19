using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GPUInstancer
{
	[Token(Token = "0x2000050")]
	public class GPUInstancerSpatialPartitioningData<T> where T : GPUInstancerCell
	{
		[Token(Token = "0x4000354")]
		[FieldOffset(Offset = "0x0")]
		public int cellRowAndCollumnCountPerTerrain;

		[Token(Token = "0x4000355")]
		[FieldOffset(Offset = "0x0")]
		public List<T> activeCellList;

		[Token(Token = "0x4000356")]
		[FieldOffset(Offset = "0x0")]
		private Dictionary<int, T> _cellHashList;

		[Token(Token = "0x4000357")]
		[FieldOffset(Offset = "0x0")]
		private List<T> _cellList;

		[Token(Token = "0x60001AE")]
		public GPUInstancerSpatialPartitioningData()
		{
		}

		[Token(Token = "0x60001AF")]
		public void AddCell(T cell)
		{
		}

		[Token(Token = "0x60001B0")]
		public bool GetCell(int hash, out T cell)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED GPUInstancerSpatialPartitioningData.GetCell RVA= Token=0x60001B0");
}

		[Token(Token = "0x60001B1")]
		public List<T> GetCellList()
		{
			return null;
		}

		[Token(Token = "0x60001B2")]
		public void GetCell(T cell)
		{
		}

		[Token(Token = "0x60001B3")]
		public bool IsActiveCellUpdateRequired(Vector3 position)
		{
			return default;
		}

		[Token(Token = "0x60001B4")]
		public bool CalculateActiveCells(Vector3 position)
		{
			return default;
		}
	}
}
