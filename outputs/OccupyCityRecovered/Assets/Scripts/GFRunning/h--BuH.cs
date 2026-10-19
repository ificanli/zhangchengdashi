using Il2CppDummyDll;
using YooAsset;

[Token(Token = "0x2000131")]
internal interface h_0097_00B2BuH
{
	[Token(Token = "0x170000CB")]
	PackageManifest ActiveManifest
	{
		[Token(Token = "0x60010F2")]
		get;
		[Token(Token = "0x60010F1")]
		set;
	}

	[Token(Token = "0x170000CC")]
	PackageManifest InPackageManifest
	{
		[Token(Token = "0x60010F4")]
		get;
		[Token(Token = "0x60010F3")]
		set;
	}

	[Token(Token = "0x60010F5")]
	void FlushManifestVersionFile();

	[Token(Token = "0x60010F6")]
	UpdatePackageVersionOperation UpdatePackageVersionAsync(bool vc_0089_0095_008A_007E, int _00AFF_00BD_0083_0087X);

	[Token(Token = "0x60010F7")]
	UpdatePackageManifestOperation UpdatePackageManifestAsync(string _00A9gR_0085_00A0m, bool qB_008E_00B0H_009F, int _00AFF_00BD_0083_0087X);

	[Token(Token = "0x60010F8")]
	PreDownloadContentOperation PreDownloadContentAsync(string _00A9gR_0085_00A0m, int _00AFF_00BD_0083_0087X);

	[Token(Token = "0x60010F9")]
	ResourceDownloaderOperation CreateResourceDownloaderByAll(int _00AC_0083X_009D_00AEp, int _00BD_00B2F_00AF_00B8t, int _00AFF_00BD_0083_0087X);

	[Token(Token = "0x60010FA")]
	ResourceDownloaderOperation CreateResourceDownloaderByTags(string[] _005BMu_005Eµ_00AF, int _00AC_0083X_009D_00AEp, int _00BD_00B2F_00AF_00B8t, int _00AFF_00BD_0083_0087X);

	[Token(Token = "0x60010FB")]
	ResourceDownloaderOperation CreateResourceDownloaderByPaths(AssetInfo[] _00BBV_00B8CwÀ, int _00AC_0083X_009D_00AEp, int _00BD_00B2F_00AF_00B8t, int _00AFF_00BD_0083_0087X);

	[Token(Token = "0x60010FC")]
	ResourceUnpackerOperation CreateResourceUnpackerByAll(int _0086_00A3pY_0094G, int _00BD_00B2F_00AF_00B8t, int _00AFF_00BD_0083_0087X);

	[Token(Token = "0x60010FD")]
	ResourceUnpackerOperation CreateResourceUnpackerByTags(string[] _005BMu_005Eµ_00AF, int _0086_00A3pY_0094G, int _00BD_00B2F_00AF_00B8t, int _00AFF_00BD_0083_0087X);
}
