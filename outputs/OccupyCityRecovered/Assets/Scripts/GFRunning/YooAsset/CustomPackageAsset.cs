using System;
using Il2CppDummyDll;

namespace YooAsset
{
	[Serializable]
	[Token(Token = "0x20000DF")]
	internal class CustomPackageAsset
	{
		[Token(Token = "0x4000319")]
		[FieldOffset(Offset = "0x10")]
		public PackageAsset AssetInfo;

		[Token(Token = "0x400031A")]
		[FieldOffset(Offset = "0x18")]
		public string MainBundleName;

		[Token(Token = "0x400031B")]
		[FieldOffset(Offset = "0x20")]
		public string[] DependBundles;

		[Token(Token = "0x6000C4C")]
		[Address(RVA = "0x7322BC8", Offset = "0x731EBC8", VA = "0x7322BC8")]
		public CustomPackageAsset()
		{
		}
	}
}
