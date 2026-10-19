using System;
using Il2CppDummyDll;

namespace YooAsset
{
	[Serializable]
	[Token(Token = "0x20000E1")]
	internal class CustomManifest
	{
		[Token(Token = "0x400031E")]
		[FieldOffset(Offset = "0x10")]
		public string PackageName;

		[Token(Token = "0x400031F")]
		[FieldOffset(Offset = "0x18")]
		public string PackageVersion;

		[Token(Token = "0x4000320")]
		[FieldOffset(Offset = "0x20")]
		public CustomPackageAsset[] CustomAssetArray;

		[Token(Token = "0x4000321")]
		[FieldOffset(Offset = "0x28")]
		public CustomPackageBundle[] CustomBundleArray;

		[Token(Token = "0x6000C4E")]
		[Address(RVA = "0x7322C4C", Offset = "0x731EC4C", VA = "0x7322C4C")]
		public CustomManifest()
		{
		}
	}
}
