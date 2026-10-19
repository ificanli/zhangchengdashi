using Il2CppDummyDll;

namespace AssetBundles
{
	[Token(Token = "0x200019F")]
	public abstract class AssetBundleLoadBundleOperation : AssetBundleLoadOperation
	{
		[Token(Token = "0x60013AF")]
		public abstract LoadedAssetBundle GetAssetBundle();

		[Token(Token = "0x60013B0")]
		[Address(RVA = "0x73616D8", Offset = "0x735D6D8", VA = "0x73616D8")]
		protected AssetBundleLoadBundleOperation()
		{
		}
	}
}
