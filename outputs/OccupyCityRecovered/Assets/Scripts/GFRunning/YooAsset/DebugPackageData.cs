using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace YooAsset
{
	[Serializable]
	[Token(Token = "0x20000B9")]
	internal class DebugPackageData
	{
		[Token(Token = "0x4000277")]
		[FieldOffset(Offset = "0x10")]
		public string PackageName;

		[Token(Token = "0x4000278")]
		[FieldOffset(Offset = "0x18")]
		public List<DebugProviderInfo> ProviderInfos;

		[Token(Token = "0x60009A0")]
		[Address(RVA = "0x730D408", Offset = "0x7309408", VA = "0x730D408")]
		public DebugPackageData()
		{
		}
	}
}
