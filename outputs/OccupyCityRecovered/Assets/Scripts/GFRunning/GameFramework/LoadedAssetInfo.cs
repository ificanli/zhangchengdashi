using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GameFramework
{
	[Serializable]
	[Token(Token = "0x200038D")]
	public class LoadedAssetInfo
	{
		[Token(Token = "0x4001B54")]
		[FieldOffset(Offset = "0x10")]
		[Tooltip("资源地址")]
		public string Address;

		[Token(Token = "0x4001B55")]
		[FieldOffset(Offset = "0x18")]
		[Tooltip("所属收集器")]
		public string Collector;

		[Token(Token = "0x4001B56")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("资源路径")]
		public string AssetPath;

		[Token(Token = "0x6005B81")]
		[Address(RVA = "0x71B3710", Offset = "0x71AF710", VA = "0x71B3710")]
		public LoadedAssetInfo()
		{
		}

		[Token(Token = "0x6005B82")]
		[Address(RVA = "0x71AE028", Offset = "0x71AA028", VA = "0x71AE028")]
		public LoadedAssetInfo(string _00AFdV_00B0_0099_0082, string _00BC_00A8_008DVUg, string _005Efc_0089º_0089)
		{
		}
	}
}
