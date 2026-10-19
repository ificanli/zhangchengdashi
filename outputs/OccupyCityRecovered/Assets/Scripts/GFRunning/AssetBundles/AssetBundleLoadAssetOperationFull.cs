using System;
using Il2CppDummyDll;
using UnityEngine;

namespace AssetBundles
{
	[Token(Token = "0x20001A2")]
	public class AssetBundleLoadAssetOperationFull : AssetBundleLoadAssetOperation
	{
		[Token(Token = "0x4000532")]
		[FieldOffset(Offset = "0x10")]
		protected string m_AssetBundleName;

		[Token(Token = "0x4000533")]
		[FieldOffset(Offset = "0x18")]
		protected string m_AssetName;

		[Token(Token = "0x4000534")]
		[FieldOffset(Offset = "0x20")]
		protected string m_DownloadingError;

		[Token(Token = "0x4000535")]
		[FieldOffset(Offset = "0x28")]
		protected Type m_Type;

		[Token(Token = "0x4000536")]
		[FieldOffset(Offset = "0x30")]
		protected AssetBundleRequest m_Request;

		[Token(Token = "0x60013BA")]
		[Address(RVA = "0x7361B10", Offset = "0x735DB10", VA = "0x7361B10")]
		public AssetBundleLoadAssetOperationFull(string j_0081xY_0088_0088, string M_009E_00AD_005B_007CO, Type _007BgpR_00A0V)
		{
		}

		[Token(Token = "0x60013BB")]
		[Address(RVA = "0x7361B4C", Offset = "0x735DB4C", VA = "0x7361B4C", Slot = "9")]
		public override float Progress()
		{
			return default;
		}

		[Token(Token = "0x60013BC")]
		[Address(RVA = "0x7361B64", Offset = "0x735DB64", VA = "0x7361B64", Slot = "7")]
		public override bool Update()
		{
			return default;
		}

		[Token(Token = "0x60013BD")]
		public override T GetAsset<T>()
		{
			return null;
		}

		[Token(Token = "0x60013BE")]
		[Address(RVA = "0x7361C18", Offset = "0x735DC18", VA = "0x7361C18", Slot = "8")]
		public override bool IsDone()
		{
			return default;
		}
	}
}
