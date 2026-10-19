using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GPUInstancer
{
	[Token(Token = "0x200003A")]
	public class GPUInstancerDetailCell : GPUInstancerCell
	{
		[Token(Token = "0x40002B2")]
		[FieldOffset(Offset = "0x50")]
		public Dictionary<int, Matrix4x4[]> detailInstanceList;

		[Token(Token = "0x40002B3")]
		[FieldOffset(Offset = "0x58")]
		public Dictionary<int, ComputeBuffer> detailInstanceBuffers;

		[Token(Token = "0x40002B4")]
		[FieldOffset(Offset = "0x60")]
		public float[] heightMapData;

		[Token(Token = "0x40002B5")]
		[FieldOffset(Offset = "0x68")]
		public List<int[]> detailMapData;

		[Token(Token = "0x40002B6")]
		[FieldOffset(Offset = "0x70")]
		public List<int> totalDetailCounts;

		[Token(Token = "0x40002B7")]
		[FieldOffset(Offset = "0x78")]
		public Vector3 instanceStartPosition;

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x73DB454", Offset = "0x73D7454", VA = "0x73DB454")]
		public GPUInstancerDetailCell(int coordX, int coordZ)
		{
		}
	}
}
