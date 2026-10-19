using System;
using Il2CppDummyDll;
using UnityEngine;

namespace DBT
{
	[Serializable]
	[Token(Token = "0x2000F6C")]
	public class FlyItemData
	{
		[Token(Token = "0x4006A80")]
		[FieldOffset(Offset = "0x10")]
		public FlyItemType itemType;

		[Token(Token = "0x4006A81")]
		[FieldOffset(Offset = "0x18")]
		public GameObject currenyGO;

		[Token(Token = "0x4006A82")]
		[FieldOffset(Offset = "0x20")]
		public Vector3 currenyScreenPos;

		[Token(Token = "0x4006A83")]
		[FieldOffset(Offset = "0x30")]
		public GameObject itemPrefab;

		[Token(Token = "0x6005C9A")]
		[Address(RVA = "0x43B1440", Offset = "0x43AD440", VA = "0x43B1440")]
		public void Init(Canvas canvas)
		{
		}

		[Token(Token = "0x6005C9B")]
		[Address(RVA = "0x43B1E80", Offset = "0x43ADE80", VA = "0x43B1E80")]
		public FlyItemData()
		{
		}
	}
}
