using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GPUInstancer
{
	[Token(Token = "0x200003D")]
	public class GPUInstancerPrefabCell : GPUInstancerCell
	{
		[Token(Token = "0x40002D8")]
		[FieldOffset(Offset = "0x50")]
		public Dictionary<int, List<Matrix4x4>> prefabInstanceList;

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x73DB5C4", Offset = "0x73D75C4", VA = "0x73DB5C4")]
		public GPUInstancerPrefabCell(int coordX, int coordY, int coordZ)
		{
		}
	}
}
