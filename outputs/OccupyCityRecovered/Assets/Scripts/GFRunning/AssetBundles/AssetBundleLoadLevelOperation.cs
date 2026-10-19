using Il2CppDummyDll;
using UnityEngine;

namespace AssetBundles
{
	[Token(Token = "0x20001A0")]
	public class AssetBundleLoadLevelOperation : AssetBundleLoadOperation
	{
		[Token(Token = "0x400052C")]
		[FieldOffset(Offset = "0x10")]
		protected string m_AssetBundleName;

		[Token(Token = "0x400052D")]
		[FieldOffset(Offset = "0x18")]
		protected string m_LevelName;

		[Token(Token = "0x400052E")]
		[FieldOffset(Offset = "0x20")]
		protected bool m_IsAdditive;

		[Token(Token = "0x400052F")]
		[FieldOffset(Offset = "0x28")]
		protected string m_DownloadingError;

		[Token(Token = "0x4000530")]
		[FieldOffset(Offset = "0x30")]
		protected AsyncOperation m_Request;

		[Token(Token = "0x60013B1")]
		[Address(RVA = "0x73616E0", Offset = "0x735D6E0", VA = "0x73616E0", Slot = "8")]
		public override bool IsDone()
		{
			return default;
		}

		[Token(Token = "0x60013B2")]
		[Address(RVA = "0x7361780", Offset = "0x735D780", VA = "0x7361780", Slot = "9")]
		public override float Progress()
		{
			return default;
		}

		[Token(Token = "0x60013B3")]
		[Address(RVA = "0x7361798", Offset = "0x735D798", VA = "0x7361798")]
		public AssetBundleLoadLevelOperation(string _005B_008E_00B6THd, string gK_00BC_00B2QG, bool _005Ddk_00A3Ol)
		{
		}

		[Token(Token = "0x60013B4")]
		[Address(RVA = "0x73617D4", Offset = "0x735D7D4", VA = "0x73617D4", Slot = "7")]
		public override bool Update()
		{
			return default;
		}
	}
}
