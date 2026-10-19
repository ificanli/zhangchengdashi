using System;
using Il2CppDummyDll;
using UnityEngine;

namespace SuperScrollView
{
	[Serializable]
	[Token(Token = "0x2000C6E")]
	public class ItemPrefabConfData
	{
		[Token(Token = "0x4005913")]
		[FieldOffset(Offset = "0x10")]
		public GameObject mItemPrefab;

		[Token(Token = "0x4005914")]
		[FieldOffset(Offset = "0x18")]
		public float mPadding;

		[Token(Token = "0x4005915")]
		[FieldOffset(Offset = "0x1C")]
		public int mInitCreateCount;

		[Token(Token = "0x4005916")]
		[FieldOffset(Offset = "0x20")]
		public float mStartPosOffset;

		[Token(Token = "0x6004D36")]
		[Address(RVA = "0x427F838", Offset = "0x427B838", VA = "0x427F838")]
		public ItemPrefabConfData()
		{
		}
	}
}
