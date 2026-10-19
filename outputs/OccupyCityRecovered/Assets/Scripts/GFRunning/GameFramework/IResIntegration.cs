using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;
using YooAsset;

namespace GameFramework
{
	[Token(Token = "0x2000387")]
	public interface IResIntegration
	{
		[Token(Token = "0x6005B23")]
		AssetOperationHandle LoadAsset<T>(string µZºV_0089_00AB, [Optional] Action<AssetOperationHandle> _0091_00BF_0099sB_007E, [Optional] object[] h_00A6_00BB_00B2_0089w) where T : UnityEngine.Object;

		[Token(Token = "0x6005B24")]
		AssetOperationHandle LoadAsset(string µZºV_0089_00AB, [Optional] Action<AssetOperationHandle> _0091_00BF_0099sB_007E, [Optional] object[] h_00A6_00BB_00B2_0089w);

		[Token(Token = "0x6005B25")]
		AssetOperationHandle LoadAssetSync<T>(string µZºV_0089_00AB) where T : UnityEngine.Object;

		[Token(Token = "0x6005B26")]
		AssetOperationHandle LoadAssetSync(string µZºV_0089_00AB);

		[Token(Token = "0x6005B27")]
		AssetOperationHandle LoadPrefab(string µZºV_0089_00AB, [Optional] Action<AssetOperationHandle> _0091_00BF_0099sB_007E, params object[] h_00A6_00BB_00B2_0089w);

		[Token(Token = "0x6005B28")]
		SceneOperationHandle LoadScene(string x_008A_00BE_0098_007Ej, [Optional] Action<SceneOperationHandle> _0091_00BF_0099sB_007E, [Optional][DefaultParameterValue(false)] bool _005Ddk_00A3Ol, [Optional][DefaultParameterValue(false)] bool _00A7Â_007By_007D_008A, [Optional] object[] h_00A6_00BB_00B2_0089w);

		[Token(Token = "0x6005B29")]
		Task<AssetOperationHandle> LoadAssetAsync<T>(string µZºV_0089_00AB) where T : UnityEngine.Object;

		[Token(Token = "0x6005B2A")]
		Task<AssetOperationHandle> LoadPrefabAsync(string µZºV_0089_00AB, [Optional] string M_009E_00AD_005B_007CO);

		[Token(Token = "0x6005B2B")]
		void UnloadUnusedAssets();

		[Token(Token = "0x6005B2C")]
		Task<AssetOperationHandle> GetSpriteByTexture(string µZºV_0089_00AB);

		[Token(Token = "0x6005B2D")]
		AssetOperationHandle LoadSpriteAtlas(string µZºV_0089_00AB, [Optional] Action<AssetOperationHandle> _0091_00BF_0099sB_007E, [Optional] object[] h_00A6_00BB_00B2_0089w);

		[Token(Token = "0x6005B2E")]
		AllAssetsOperationHandle LoadAllAssets(string _00B8_007CL_0094_0090l, [Optional] Action<AllAssetsOperationHandle> _0091_00BF_0099sB_007E);
	}
}
