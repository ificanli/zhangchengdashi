using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GameFramework
{
	[Serializable]
	[Token(Token = "0x2000381")]
	public class AddressPathPair
	{
		[Token(Token = "0x4001B2B")]
		[FieldOffset(Offset = "0x10")]
		[Tooltip("资源地址")]
		public string Address;

		[Token(Token = "0x4001B2C")]
		[FieldOffset(Offset = "0x18")]
		[Tooltip("资源路径")]
		public string AssetPath;

		[Token(Token = "0x6005A6E")]
		[Address(RVA = "0x71A5DDC", Offset = "0x71A1DDC", VA = "0x71A5DDC")]
		public AddressPathPair()
		{
		}

		[Token(Token = "0x6005A6F")]
		[Address(RVA = "0x71A5DE4", Offset = "0x71A1DE4", VA = "0x71A5DE4")]
		public AddressPathPair(string _00AFdV_00B0_0099_0082, string _005Efc_0089º_0089)
		{
		}
	}
}
