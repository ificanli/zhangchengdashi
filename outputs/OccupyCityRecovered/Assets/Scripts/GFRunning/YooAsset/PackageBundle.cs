using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace YooAsset
{
	[Serializable]
	[Token(Token = "0x2000123")]
	internal class PackageBundle
	{
		[Token(Token = "0x4000448")]
		[FieldOffset(Offset = "0x10")]
		public string BundleName;

		[Token(Token = "0x4000449")]
		[FieldOffset(Offset = "0x18")]
		public uint UnityCRC;

		[Token(Token = "0x400044A")]
		[FieldOffset(Offset = "0x20")]
		public string FileHash;

		[Token(Token = "0x400044B")]
		[FieldOffset(Offset = "0x28")]
		public string FileCRC;

		[Token(Token = "0x400044C")]
		[FieldOffset(Offset = "0x30")]
		public long FileSize;

		[Token(Token = "0x400044D")]
		[FieldOffset(Offset = "0x38")]
		public bool IsRawFile;

		[Token(Token = "0x400044E")]
		[FieldOffset(Offset = "0x39")]
		public byte LoadMethod;

		[Token(Token = "0x400044F")]
		[FieldOffset(Offset = "0x40")]
		public string[] Tags;

		[Token(Token = "0x4000450")]
		[FieldOffset(Offset = "0x48")]
		public int[] ReferenceIDs;

		[Token(Token = "0x4000452")]
		[FieldOffset(Offset = "0x58")]
		private string _cachedDataFilePath;

		[Token(Token = "0x4000453")]
		[FieldOffset(Offset = "0x60")]
		private string _cachedInfoFilePath;

		[Token(Token = "0x4000454")]
		[FieldOffset(Offset = "0x68")]
		private string _tempDataFilePath;

		[Token(Token = "0x4000455")]
		[FieldOffset(Offset = "0x70")]
		private string _streamingFilePath;

		[Token(Token = "0x4000456")]
		[FieldOffset(Offset = "0x78")]
		private string _fileName;

		[Token(Token = "0x4000457")]
		[FieldOffset(Offset = "0x80")]
		private string _fileExtension;

		[Token(Token = "0x170000B7")]
		public string PackageName
		{
			[Token(Token = "0x6000F2C")]
			[Address(RVA = "0x7336B3C", Offset = "0x7332B3C", VA = "0x7336B3C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000F34")]
			[Address(RVA = "0x7336F88", Offset = "0x7332F88", VA = "0x7336F88")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000B8")]
		public string CacheGUID
		{
			[Token(Token = "0x6000F3E")]
			[Address(RVA = "0x73375A0", Offset = "0x73335A0", VA = "0x73375A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B9")]
		public string CachedDataFilePath
		{
			[Token(Token = "0x6000F2B")]
			[Address(RVA = "0x7336A28", Offset = "0x7332A28", VA = "0x7336A28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BA")]
		public string CachedInfoFilePath
		{
			[Token(Token = "0x6000F4D")]
			[Address(RVA = "0x7337A8C", Offset = "0x7333A8C", VA = "0x7337A8C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BB")]
		public string TempDataFilePath
		{
			[Token(Token = "0x6000F35")]
			[Address(RVA = "0x7336F90", Offset = "0x7332F90", VA = "0x7336F90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BC")]
		public string StreamingFilePath
		{
			[Token(Token = "0x6000F31")]
			[Address(RVA = "0x7336C74", Offset = "0x7332C74", VA = "0x7336C74")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BD")]
		public string FileName
		{
			[Token(Token = "0x6000F43")]
			[Address(RVA = "0x7336E40", Offset = "0x7332E40", VA = "0x7336E40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BE")]
		public string FileExtension
		{
			[Token(Token = "0x6000F1E")]
			[Address(RVA = "0x73364DC", Offset = "0x73324DC", VA = "0x73364DC")]
			get
			{
				return null;
			}
		}

		[SpecialName]
		[Token(Token = "0x6000F1F")]
		[Address(RVA = "0x7336548", Offset = "0x7332548", VA = "0x7336548")]
		public string ÀN_009D_009Cb_007C()
		{
			return null;
		}

		[Token(Token = "0x6000F20")]
		[Address(RVA = "0x73365B4", Offset = "0x73325B4", VA = "0x73365B4")]
		public void ParseBundle(string _008Ffª_008C_007Fi, int _007B_00BC_0084_00B9_00B1_00A9)
		{
		}

		[Token(Token = "0x6000F21")]
		[Address(RVA = "0x7336600", Offset = "0x7332600", VA = "0x7336600")]
		public bool HasTag(string[] _005BMu_005Eµ_00AF)
		{
			return default;
		}

		[SpecialName]
		[Token(Token = "0x6000F22")]
		[Address(RVA = "0x73366B8", Offset = "0x73326B8", VA = "0x73366B8")]
		public string E_00BDH_007C_00A4m()
		{
			return null;
		}

		[SpecialName]
		[Token(Token = "0x6000F23")]
		[Address(RVA = "0x7336724", Offset = "0x7332724", VA = "0x7336724")]
		private void a_00BB_00B2_0099_0091_00B6(string _00A3_0092T_007E_00ABc)
		{
		}

		[SpecialName]
		[Token(Token = "0x6000F24")]
		[Address(RVA = "0x733672C", Offset = "0x733272C", VA = "0x733672C")]
		private void _008C_00B0_00B8H_009DN(string _00A3_0092T_007E_00ABc)
		{
		}

		[SpecialName]
		[Token(Token = "0x6000F25")]
		[Address(RVA = "0x7336734", Offset = "0x7332734", VA = "0x7336734")]
		public string ºd_0081C_007E_00A7()
		{
			return null;
		}

		[Token(Token = "0x6000F26")]
		[Address(RVA = "0x7336848", Offset = "0x7332848", VA = "0x7336848")]
		public bool _00A0_0089_007F_007F_00B1_00A7(string[] _005BMu_005Eµ_00AF)
		{
			return default;
		}

		[Token(Token = "0x6000F27")]
		[Address(RVA = "0x7336904", Offset = "0x7332904", VA = "0x7336904")]
		public void _009AG_00B2T_00BC_00AD(string _008Ffª_008C_007Fi, int _007B_00BC_0084_00B9_00B1_00A9)
		{
		}

		[Token(Token = "0x6000F28")]
		[Address(RVA = "0x7336950", Offset = "0x7332950", VA = "0x7336950")]
		public void _008D_00BEtI_00B3y(string _008Ffª_008C_007Fi, int _007B_00BC_0084_00B9_00B1_00A9)
		{
		}

		[SpecialName]
		[Token(Token = "0x6000F29")]
		[Address(RVA = "0x733699C", Offset = "0x733299C", VA = "0x733699C")]
		public string A_00B0_0098_009FP_009E()
		{
			return null;
		}

		[Token(Token = "0x6000F2A")]
		[Address(RVA = "0x7336A08", Offset = "0x7332A08", VA = "0x7336A08")]
		public bool Equals(PackageBundle _0089aI_008D_008BC)
		{
			return default;
		}

		[SpecialName]
		[Token(Token = "0x6000F2D")]
		[Address(RVA = "0x7336B44", Offset = "0x7332B44", VA = "0x7336B44")]
		public string _00B4Je_00A6_00ADÁ()
		{
			return null;
		}

		[SpecialName]
		[Token(Token = "0x6000F2E")]
		[Address(RVA = "0x7336B4C", Offset = "0x7332B4C", VA = "0x7336B4C")]
		public string _0090e_00B6anz()
		{
			return null;
		}

		[Token(Token = "0x6000F2F")]
		[Address(RVA = "0x7336BBC", Offset = "0x7332BBC", VA = "0x7336BBC")]
		public void _0092u_007B_007BL_007E(string _008Ffª_008C_007Fi, int _007B_00BC_0084_00B9_00B1_00A9)
		{
		}

		[SpecialName]
		[Token(Token = "0x6000F30")]
		[Address(RVA = "0x7336C08", Offset = "0x7332C08", VA = "0x7336C08")]
		public string Z_00BF_00AEKÂR()
		{
			return null;
		}

		[SpecialName]
		[Token(Token = "0x6000F32")]
		[Address(RVA = "0x7336EAC", Offset = "0x7332EAC", VA = "0x7336EAC")]
		public string _00A1hSµdu()
		{
			return null;
		}

		[SpecialName]
		[Token(Token = "0x6000F33")]
		[Address(RVA = "0x7336F18", Offset = "0x7332F18", VA = "0x7336F18")]
		public string m_008DFu_0084µ()
		{
			return null;
		}

		[SpecialName]
		[Token(Token = "0x6000F36")]
		[Address(RVA = "0x7337000", Offset = "0x7333000", VA = "0x7337000")]
		public string Y_007F_0089_008Bs_008D()
		{
			return null;
		}

		[SpecialName]
		[Token(Token = "0x6000F37")]
		[Address(RVA = "0x7337134", Offset = "0x7333134", VA = "0x7337134")]
		public string ÂbyH_00BF_0060()
		{
			return null;
		}

		[SpecialName]
		[Token(Token = "0x6000F38")]
		[Address(RVA = "0x733736C", Offset = "0x733336C", VA = "0x733736C")]
		public string _00ABVZ_00A6S_009E()
		{
			return null;
		}

		[Token(Token = "0x6000F39")]
		[Address(RVA = "0x73373DC", Offset = "0x73333DC", VA = "0x73373DC")]
		public PackageBundle()
		{
		}

		[Token(Token = "0x6000F3A")]
		[Address(RVA = "0x73373E4", Offset = "0x73333E4", VA = "0x73373E4")]
		public bool HasTagOne(string N_00BFA_007Ev_00A2)
		{
			return default;
		}

		[SpecialName]
		[Token(Token = "0x6000F3B")]
		[Address(RVA = "0x7337454", Offset = "0x7333454", VA = "0x7337454")]
		public string _00A2_00B1_00AF_009C_00A8_0091()
		{
			return null;
		}

		[Token(Token = "0x6000F3C")]
		[Address(RVA = "0x73374C0", Offset = "0x73334C0", VA = "0x73374C0")]
		public bool _00B8N_00B8v_0082G(string N_00BFA_007Ev_00A2)
		{
			return default;
		}

		[SpecialName]
		[Token(Token = "0x6000F3D")]
		[Address(RVA = "0x7337530", Offset = "0x7333530", VA = "0x7337530")]
		public string _0084_0096C_00B2_00AD_009E()
		{
			return null;
		}

		[Token(Token = "0x6000F3F")]
		[Address(RVA = "0x73375A8", Offset = "0x73335A8", VA = "0x73375A8")]
		public bool ON_0088_0088_007DU(string[] _005BMu_005Eµ_00AF)
		{
			return default;
		}

		[SpecialName]
		[Token(Token = "0x6000F40")]
		[Address(RVA = "0x7337654", Offset = "0x7333654", VA = "0x7337654")]
		public string fu_00B4_007CR_008C()
		{
			return null;
		}

		[Token(Token = "0x6000F41")]
		[Address(RVA = "0x733765C", Offset = "0x733365C", VA = "0x733765C")]
		public bool HasAnyTags()
		{
			return default;
		}

		[Token(Token = "0x6000F42")]
		[Address(RVA = "0x733767C", Offset = "0x733367C", VA = "0x733767C")]
		public void tn_00AF_0084Wh(string _008Ffª_008C_007Fi, int _007B_00BC_0084_00B9_00B1_00A9)
		{
		}

		[Token(Token = "0x6000F44")]
		[Address(RVA = "0x73376C8", Offset = "0x73336C8", VA = "0x73376C8")]
		public bool _008AQ_00A4Cu_0080(string N_00BFA_007Ev_00A2)
		{
			return default;
		}

		[SpecialName]
		[Token(Token = "0x6000F45")]
		[Address(RVA = "0x7337738", Offset = "0x7333738", VA = "0x7337738")]
		public string _00BD_00A1_0094gp_0083()
		{
			return null;
		}

		[SpecialName]
		[Token(Token = "0x6000F46")]
		[Address(RVA = "0x733790C", Offset = "0x733390C", VA = "0x733790C")]
		public string _008E_0085_00ABMªI()
		{
			return null;
		}

		[SpecialName]
		[Token(Token = "0x6000F47")]
		[Address(RVA = "0x7337914", Offset = "0x7333914", VA = "0x7337914")]
		public string _00BFA_0093_00B2Hº()
		{
			return null;
		}

		[SpecialName]
		[Token(Token = "0x6000F48")]
		[Address(RVA = "0x7337300", Offset = "0x7333300", VA = "0x7337300")]
		public string _0092_008A_00B3_008Ff_00BE()
		{
			return null;
		}

		[Token(Token = "0x6000F49")]
		[Address(RVA = "0x7337980", Offset = "0x7333980", VA = "0x7337980")]
		public bool _00AF_007B_00ACy_008FZ(PackageBundle _0089aI_008D_008BC)
		{
			return default;
		}

		[SpecialName]
		[Token(Token = "0x6000F4A")]
		[Address(RVA = "0x73379A8", Offset = "0x73339A8", VA = "0x73379A8")]
		public string Bf_00B3Rªt()
		{
			return null;
		}

		[SpecialName]
		[Token(Token = "0x6000F4B")]
		[Address(RVA = "0x7337A18", Offset = "0x7333A18", VA = "0x7337A18")]
		private void lc_008C_00A5_00A0I(string _00A3_0092T_007E_00ABc)
		{
		}

		[SpecialName]
		[Token(Token = "0x6000F4C")]
		[Address(RVA = "0x7337A20", Offset = "0x7333A20", VA = "0x7337A20")]
		public string _005B_0085CN_0087_00A8()
		{
			return null;
		}

		[SpecialName]
		[Token(Token = "0x6000F4E")]
		[Address(RVA = "0x7337B78", Offset = "0x7333B78", VA = "0x7337B78")]
		public string EzÂ_00BB_007C_005D()
		{
			return null;
		}
	}
}
