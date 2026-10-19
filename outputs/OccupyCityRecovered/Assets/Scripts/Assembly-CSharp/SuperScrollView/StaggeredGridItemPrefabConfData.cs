using System;
using Il2CppDummyDll;
using UnityEngine;

namespace SuperScrollView
{
	[Serializable]
	[Token(Token = "0x2000C76")]
	public class StaggeredGridItemPrefabConfData
	{
		[Token(Token = "0x4005983")]
		[FieldOffset(Offset = "0x10")]
		public GameObject mItemPrefab;

		[Token(Token = "0x4005984")]
		[FieldOffset(Offset = "0x18")]
		public float mPadding;

		[Token(Token = "0x4005985")]
		[FieldOffset(Offset = "0x1C")]
		public int mInitCreateCount;

		[Token(Token = "0x6004DC9")]
		[Address(RVA = "0x429D3C8", Offset = "0x42993C8", VA = "0x429D3C8")]
		public StaggeredGridItemPrefabConfData()
		{
		}
	}
}
