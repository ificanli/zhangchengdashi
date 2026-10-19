using Il2CppDummyDll;

namespace GameFramework.Resources
{
	[Token(Token = "0x20004D1")]
	public interface IBundleServices
	{
		[Token(Token = "0x60072F1")]
		bool CheckContentIntegrity(string j_0081xY_0088_0088);

		[Token(Token = "0x60072F2")]
		BundleAssetInfo GetAssetBundleInfo(string j_0081xY_0088_0088);

		[Token(Token = "0x60072F3")]
		RawAssetInfo GetRawAssetInfo(string M_009E_00AD_005B_007CO);

		[Token(Token = "0x60072F4")]
		bool CheckHaveLocalAsset(string j_0081xY_0088_0088);
	}
}
