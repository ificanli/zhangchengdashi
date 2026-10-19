using Il2CppDummyDll;

namespace AssetBundles
{
	[Token(Token = "0x20001A5")]
	public class AssetBundleLoadOperationFull : AssetBundleLoadBundleOperation
	{
		[Token(Token = "0x4000538")]
		[FieldOffset(Offset = "0x10")]
		protected string m_AssetBundleName;

		[Token(Token = "0x4000539")]
		[FieldOffset(Offset = "0x18")]
		protected string m_DownloadingError;

		[Token(Token = "0x400053A")]
		[FieldOffset(Offset = "0x20")]
		internal _008F_00A9_008B_008DMQ _009Bh_0084JKV;

		[Token(Token = "0x400053B")]
		[FieldOffset(Offset = "0x28")]
		protected LoadedAssetBundle bundle;

		[Token(Token = "0x60013C6")]
		[Address(RVA = "0x7361E20", Offset = "0x735DE20", VA = "0x7361E20", Slot = "9")]
		public override float Progress()
		{
			return default;
		}

		[Token(Token = "0x60013C7")]
		[Address(RVA = "0x7361E4C", Offset = "0x735DE4C", VA = "0x7361E4C", Slot = "8")]
		public override bool IsDone()
		{
			return default;
		}

		[Token(Token = "0x60013C8")]
		[Address(RVA = "0x7361FA0", Offset = "0x735DFA0", VA = "0x7361FA0", Slot = "7")]
		public override bool Update()
		{
			return default;
		}

		[Token(Token = "0x60013C9")]
		[Address(RVA = "0x7362020", Offset = "0x735E020", VA = "0x7362020", Slot = "10")]
		public override LoadedAssetBundle GetAssetBundle()
		{
			return null;
		}

		[Token(Token = "0x60013CA")]
		[Address(RVA = "0x7362028", Offset = "0x735E028", VA = "0x7362028")]
		public AssetBundleLoadOperationFull(string j_0081xY_0088_0088)
		{
		}
	}
}
