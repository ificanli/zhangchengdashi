using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace YooAsset
{
	[Serializable]
	[Token(Token = "0x20000E0")]
	internal class CustomPackageBundle
	{
		[Token(Token = "0x400031C")]
		[FieldOffset(Offset = "0x10")]
		public PackageBundle BundleInfo;

		[Token(Token = "0x400031D")]
		[FieldOffset(Offset = "0x18")]
		public List<string> AllBuiltinAssets;

		[Token(Token = "0x6000C4D")]
		[Address(RVA = "0x7322BD0", Offset = "0x731EBD0", VA = "0x7322BD0")]
		public CustomPackageBundle()
		{
		}
	}
}
