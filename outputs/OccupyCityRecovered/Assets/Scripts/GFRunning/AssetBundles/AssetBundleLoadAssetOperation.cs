using Il2CppDummyDll;
using UnityEngine;

namespace AssetBundles
{
	[Token(Token = "0x200019E")]
	public abstract class AssetBundleLoadAssetOperation : AssetBundleLoadOperation
	{
		[Token(Token = "0x60013AD")]
		public abstract T GetAsset<T>() where T : Object;

		[Token(Token = "0x60013AE")]
		[Address(RVA = "0x73616D0", Offset = "0x735D6D0", VA = "0x73616D0")]
		protected AssetBundleLoadAssetOperation()
		{
		}
	}
}
