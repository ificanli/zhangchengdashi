using System;
using Il2CppDummyDll;
using UnityEngine;

namespace AssetBundles
{
	[Serializable]
	[Token(Token = "0x20001AA")]
	public class LoadedAssetBundle
	{
		[Token(Token = "0x4000541")]
		[FieldOffset(Offset = "0x10")]
		public AssetBundle m_AssetBundle;

		[Token(Token = "0x4000542")]
		[FieldOffset(Offset = "0x18")]
		public int m_ReferencedCount;

		[Token(Token = "0x4000543")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		internal string m_assetBundleName;

		[Token(Token = "0x4000544")]
		[FieldOffset(Offset = "0x28")]
		internal float m_retrieveStartTime;

		[Token(Token = "0x4000545")]
		[FieldOffset(Offset = "0x2C")]
		internal float m_SpawnTime;

		[Token(Token = "0x60013DE")]
		[Address(RVA = "0x73624E8", Offset = "0x735E4E8", VA = "0x73624E8")]
		public LoadedAssetBundle(AssetBundle n_008A_007B_0081_00B6_00B0, string µ_007EQORz, float W_0093g_009D_009BQ)
		{
		}
	}
}
