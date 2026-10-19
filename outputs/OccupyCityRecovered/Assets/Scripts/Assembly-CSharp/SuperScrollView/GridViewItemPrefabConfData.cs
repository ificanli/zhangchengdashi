using System;
using Il2CppDummyDll;
using UnityEngine;

namespace SuperScrollView
{
	[Serializable]
	[Token(Token = "0x2000C66")]
	public class GridViewItemPrefabConfData
	{
		[Token(Token = "0x40058B3")]
		[FieldOffset(Offset = "0x10")]
		public GameObject mItemPrefab;

		[Token(Token = "0x40058B4")]
		[FieldOffset(Offset = "0x18")]
		public int mInitCreateCount;

		[Token(Token = "0x6004CA7")]
		[Address(RVA = "0x4279F9C", Offset = "0x4275F9C", VA = "0x4279F9C")]
		public GridViewItemPrefabConfData()
		{
		}
	}
}
