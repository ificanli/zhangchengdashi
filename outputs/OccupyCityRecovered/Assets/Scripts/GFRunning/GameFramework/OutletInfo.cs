using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GameFramework
{
	[Serializable]
	[Token(Token = "0x20003C4")]
	public class OutletInfo
	{
		[Token(Token = "0x4001C55")]
		[FieldOffset(Offset = "0x10")]
		public string Name;

		[Token(Token = "0x4001C56")]
		[FieldOffset(Offset = "0x18")]
		public string ComponentType;

		[Token(Token = "0x4001C57")]
		[FieldOffset(Offset = "0x20")]
		public UnityEngine.Object Object;

		[Token(Token = "0x6005F1F")]
		[Address(RVA = "0x71D5048", Offset = "0x71D1048", VA = "0x71D5048")]
		public OutletInfo()
		{
		}
	}
}
