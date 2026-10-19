using System;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

namespace YooAsset
{
	[Serializable]
	[Token(Token = "0x2000124")]
	internal class PackageManifest
	{
		[Token(Token = "0x4000458")]
		[FieldOffset(Offset = "0x10")]
		public bool LocationToLower;

		[Token(Token = "0x4000459")]
		[FieldOffset(Offset = "0x11")]
		public bool IncludeAssetGUID;

		[Token(Token = "0x400045A")]
		[FieldOffset(Offset = "0x14")]
		public int OutputNameStyle;

		[Token(Token = "0x400045B")]
		[FieldOffset(Offset = "0x18")]
		public string PackageName;

		[Token(Token = "0x400045C")]
		[FieldOffset(Offset = "0x20")]
		public string PackageVersion;

		[Token(Token = "0x400045D")]
		[FieldOffset(Offset = "0x28")]
		public string PackageVerDesc;

		[Token(Token = "0x400045E")]
		[FieldOffset(Offset = "0x30")]
		public List<PackageAsset> AssetList;

		[Token(Token = "0x400045F")]
		[FieldOffset(Offset = "0x38")]
		public List<PackageBundle> BundleList;

		[NonSerialized]
		[Token(Token = "0x4000460")]
		[FieldOffset(Offset = "0x40")]
		public Dictionary<string, PackageBundle> BundleDic;

		[NonSerialized]
		[Token(Token = "0x4000461")]
		[FieldOffset(Offset = "0x48")]
		public Dictionary<string, PackageAsset> AssetDic;

		[NonSerialized]
		[Token(Token = "0x4000462")]
		[FieldOffset(Offset = "0x50")]
		public Dictionary<string, string> AssetPathMapping1;

		[NonSerialized]
		[Token(Token = "0x4000463")]
		[FieldOffset(Offset = "0x58")]
		public Dictionary<string, string> AssetPathMapping2;

		[NonSerialized]
		[Token(Token = "0x4000464")]
		[FieldOffset(Offset = "0x60")]
		public HashSet<string> CacheGUIDs;

		[Token(Token = "0x6000F4F")]
		[Address(RVA = "0x7337BE8", Offset = "0x7333BE8", VA = "0x7337BE8")]
		private string _0084_0088Âe_009A_009D(string _00B8_007CL_0094_0090l)
		{
			return null;
		}

		[Token(Token = "0x6000F50")]
		[Address(RVA = "0x7337CF8", Offset = "0x7333CF8", VA = "0x7337CF8")]
		private string _00BB_00A4NSjD(string _00B8_007CL_0094_0090l)
		{
			return null;
		}

		[Token(Token = "0x6000F51")]
		[Address(RVA = "0x7337E08", Offset = "0x7333E08", VA = "0x7337E08")]
		public string[] _007C_008D_0086µT_0095(string _005Efc_0089º_0089)
		{
			return null;
		}

		[Token(Token = "0x6000F52")]
		[Address(RVA = "0x73380DC", Offset = "0x73340DC", VA = "0x73380DC")]
		public AssetInfo[] c_0099_00A5z_009DF(string[] _005BMu_005Eµ_00AF)
		{
			return null;
		}

		[Token(Token = "0x6000F53")]
		[Address(RVA = "0x7338360", Offset = "0x7334360", VA = "0x7338360")]
		[Conditional("DEBUG")]
		private void _0096r_0084g_00A8_0086(string _00B8_007CL_0094_0090l)
		{
		}

		[Token(Token = "0x6000F54")]
		[Address(RVA = "0x73384A4", Offset = "0x73344A4", VA = "0x73384A4")]
		public string o_0096c_00AD_00B4B(string _00B8_007CL_0094_0090l)
		{
			return null;
		}

		[Token(Token = "0x6000F55")]
		[Address(RVA = "0x7338564", Offset = "0x7334564", VA = "0x7338564")]
		public bool _00A7N_007E_0091_0088t(string j_0081xY_0088_0088, out PackageBundle H_009CVRM_005D)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED PackageManifest._00A7N_007E_0091_0088t RVA=0x7338564 Token=0x6000F55");
}

		[Token(Token = "0x6000F56")]
		[Address(RVA = "0x73385CC", Offset = "0x73345CC", VA = "0x73385CC")]
		public PackageBundle[] GetAllDependencies(string _005Efc_0089º_0089)
		{
			return null;
		}

		[Token(Token = "0x6000F57")]
		[Address(RVA = "0x733886C", Offset = "0x733486C", VA = "0x733886C")]
		public PackageBundle GetMainPackageBundle(string _005Efc_0089º_0089)
		{
			return null;
		}

		[Token(Token = "0x6000F58")]
		[Address(RVA = "0x73389E4", Offset = "0x73349E4", VA = "0x73389E4")]
		public string _00ABÁ_0087ofz(int jxLjk_0096)
		{
			return null;
		}

		[Token(Token = "0x6000F59")]
		[Address(RVA = "0x7338ADC", Offset = "0x7334ADC", VA = "0x7338ADC")]
		public AssetInfo[] GetAssetsInfoByTags(string[] _005BMu_005Eµ_00AF)
		{
			return null;
		}

		[Token(Token = "0x6000F5A")]
		[Address(RVA = "0x7338D60", Offset = "0x7334D60", VA = "0x7338D60")]
		public bool t_0085_00AF_00A7_00A2o(string j_0081xY_0088_0088, out PackageBundle H_009CVRM_005D)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED PackageManifest.t_0085_00AF_00A7_00A2o RVA=0x7338D60 Token=0x6000F5A");
}

		[Token(Token = "0x6000F5B")]
		[Address(RVA = "0x7338DC8", Offset = "0x7334DC8", VA = "0x7338DC8")]
		public bool _0099Ok_0094A_00B8(string j_0081xY_0088_0088, out PackageBundle H_009CVRM_005D)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED PackageManifest._0099Ok_0094A_00B8 RVA=0x7338DC8 Token=0x6000F5B");
}

		[Token(Token = "0x6000F5C")]
		[Address(RVA = "0x7338E30", Offset = "0x7334E30", VA = "0x7338E30")]
		public bool g_00B2_008AOÁª(string _005Efc_0089º_0089, out PackageAsset H_009CVRM_005D)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED PackageManifest.g_00B2_008AOÁª RVA=0x7338E30 Token=0x6000F5C");
}

		[Token(Token = "0x6000F5D")]
		[Address(RVA = "0x7338E98", Offset = "0x7334E98", VA = "0x7338E98")]
		public string GetBundleName(int jxLjk_0096)
		{
			return null;
		}

		[Token(Token = "0x6000F5E")]
		[Address(RVA = "0x7338F90", Offset = "0x7334F90", VA = "0x7338F90")]
		public AssetInfo _00B1_0085_005DQ_00A8B(string vA_00A7_00B1ps, Type o_00B2cª_0090v)
		{
			return null;
		}

		[Token(Token = "0x6000F5F")]
		[Address(RVA = "0x73391EC", Offset = "0x73351EC", VA = "0x73391EC")]
		public AssetInfo _008C_00B1_00B9_0094_005E_009A(string _00B8_007CL_0094_0090l, Type o_00B2cª_0090v)
		{
			return null;
		}

		[Token(Token = "0x6000F60")]
		[Address(RVA = "0x73392F4", Offset = "0x73352F4", VA = "0x73392F4")]
		public bool IsIncludeBundleFile(string c_00B0º_007FW_005B)
		{
			return default;
		}

		[Token(Token = "0x6000F61")]
		[Address(RVA = "0x733934C", Offset = "0x733534C", VA = "0x733934C")]
		public string[] jj_00BBUnO(string _005Efc_0089º_0089)
		{
			return null;
		}

		[Token(Token = "0x6000F62")]
		[Address(RVA = "0x7339620", Offset = "0x7335620", VA = "0x7339620")]
		private void _007BShpdX(string _00B8_007CL_0094_0090l)
		{
		}

		[Token(Token = "0x6000F63")]
		[Address(RVA = "0x73390F8", Offset = "0x73350F8", VA = "0x73390F8")]
		private string _005E_00BFa_00A1F_008B(string vA_00A7_00B1ps)
		{
			return null;
		}

		[Token(Token = "0x6000F64")]
		[Address(RVA = "0x7339758", Offset = "0x7335758", VA = "0x7339758")]
		public bool X_00B9_00A4_00B2_00B6_00BC(string _005Efc_0089º_0089, out PackageAsset H_009CVRM_005D)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED PackageManifest.X_00B9_00A4_00B2_00B6_00BC RVA=0x7339758 Token=0x6000F64");
}

		[Token(Token = "0x6000F65")]
		[Address(RVA = "0x73397C0", Offset = "0x73357C0", VA = "0x73397C0")]
		public PackageManifest()
		{
		}

		[Token(Token = "0x6000F66")]
		[Address(RVA = "0x73398CC", Offset = "0x73358CC", VA = "0x73398CC")]
		public bool h_008E_005E_007D_00A9V(string _005Efc_0089º_0089, out PackageAsset H_009CVRM_005D)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED PackageManifest.h_008E_005E_007D_00A9V RVA=0x73398CC Token=0x6000F66");
}

		[Token(Token = "0x6000F67")]
		[Address(RVA = "0x73395B8", Offset = "0x73355B8", VA = "0x73395B8")]
		public bool _00A1_00BFHsT_009B(string _005Efc_0089º_0089, out PackageAsset H_009CVRM_005D)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED PackageManifest._00A1_00BFHsT_009B RVA=0x73395B8 Token=0x6000F67");
}

		[Token(Token = "0x6000F68")]
		[Address(RVA = "0x7339934", Offset = "0x7335934", VA = "0x7339934")]
		public string _00BD_00BB_00A9_007F_0087_0099(string _00B8_007CL_0094_0090l)
		{
			return null;
		}

		[Token(Token = "0x6000F69")]
		[Address(RVA = "0x73399F4", Offset = "0x73359F4", VA = "0x73399F4")]
		public bool N_009A_0091_00AC_009FJ(string j_0081xY_0088_0088, out PackageBundle H_009CVRM_005D)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED PackageManifest.N_009A_0091_00AC_009FJ RVA=0x73399F4 Token=0x6000F69");
}

		[Token(Token = "0x6000F6A")]
		[Address(RVA = "0x7339A5C", Offset = "0x7335A5C", VA = "0x7339A5C")]
		private void S_00A7_009Ff_0084M(string _00B8_007CL_0094_0090l)
		{
		}

		[Token(Token = "0x6000F6B")]
		[Address(RVA = "0x7339BAC", Offset = "0x7335BAC", VA = "0x7339BAC")]
		public PackageBundle G_007C_0096_0083_00BDl(string _005Efc_0089º_0089)
		{
			return null;
		}

		[Token(Token = "0x6000F6C")]
		[Address(RVA = "0x7338074", Offset = "0x7334074", VA = "0x7338074")]
		public bool TryGetPackageAsset(string _005Efc_0089º_0089, out PackageAsset H_009CVRM_005D)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED PackageManifest.TryGetPackageAsset RVA=0x7338074 Token=0x6000F6C");
}

		[Token(Token = "0x6000F6D")]
		[Address(RVA = "0x7339D28", Offset = "0x7335D28", VA = "0x7339D28")]
		public string TryMappingToAssetPath(string _00B8_007CL_0094_0090l)
		{
			return null;
		}

		[Token(Token = "0x6000F6E")]
		[Address(RVA = "0x7339DE8", Offset = "0x7335DE8", VA = "0x7339DE8")]
		public bool d_0085_00A5_0096_00A1c(string c_00B0º_007FW_005B)
		{
			return default;
		}

		[Token(Token = "0x6000F6F")]
		[Address(RVA = "0x7339E40", Offset = "0x7335E40", VA = "0x7339E40")]
		public string H_00BE_00A5_00B1_0082o(int jxLjk_0096)
		{
			return null;
		}

		[Token(Token = "0x6000F70")]
		[Address(RVA = "0x7339F38", Offset = "0x7335F38", VA = "0x7339F38")]
		public PackageBundle[] _0090_009F_005B_007B_00A2_009E(string _005Efc_0089º_0089)
		{
			return null;
		}

		[Token(Token = "0x6000F71")]
		[Address(RVA = "0x733A1D8", Offset = "0x73361D8", VA = "0x733A1D8")]
		private string _008F_007Fla_00A0_0098(string _00B8_007CL_0094_0090l)
		{
			return null;
		}

		[Token(Token = "0x6000F72")]
		[Address(RVA = "0x733A2E8", Offset = "0x73362E8", VA = "0x733A2E8")]
		public bool _005D_00A8_00ABÀ_00B6_009D(string _005Efc_0089º_0089, out PackageAsset H_009CVRM_005D)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED PackageManifest._005D_00A8_00ABÀ_00B6_009D RVA=0x733A2E8 Token=0x6000F72");
}

		[Token(Token = "0x6000F73")]
		[Address(RVA = "0x733A350", Offset = "0x7336350", VA = "0x733A350")]
		public PackageBundle[] _0086_0084_00BF_0085_00B0r(string _005Efc_0089º_0089)
		{
			return null;
		}

		[Token(Token = "0x6000F74")]
		[Address(RVA = "0x733A5D8", Offset = "0x73365D8", VA = "0x733A5D8")]
		public PackageBundle gN_0087_00B3RE(string _005Efc_0089º_0089)
		{
			return null;
		}

		[Token(Token = "0x6000F75")]
		[Address(RVA = "0x733A754", Offset = "0x7336754", VA = "0x733A754")]
		public bool TryGetPackageBundle(string j_0081xY_0088_0088, out PackageBundle H_009CVRM_005D)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED PackageManifest.TryGetPackageBundle RVA=0x733A754 Token=0x6000F75");
}

		[Token(Token = "0x6000F76")]
		[Address(RVA = "0x733A7BC", Offset = "0x73367BC", VA = "0x733A7BC")]
		private string w_00A6f_00BC_00BBq(string vA_00A7_00B1ps)
		{
			return null;
		}

		[Token(Token = "0x6000F77")]
		[Address(RVA = "0x733A8B0", Offset = "0x73368B0", VA = "0x733A8B0")]
		public bool nxf_0099_00ACj(string c_00B0º_007FW_005B)
		{
			return default;
		}

		[Token(Token = "0x6000F78")]
		[Address(RVA = "0x733A908", Offset = "0x7336908", VA = "0x733A908")]
		private string YFp_009Ft_00BD(string vA_00A7_00B1ps)
		{
			return null;
		}

		[Token(Token = "0x6000F79")]
		[Address(RVA = "0x733A9FC", Offset = "0x73369FC", VA = "0x733A9FC")]
		public AssetInfo ConvertLocationToAssetInfo(string _00B8_007CL_0094_0090l, Type o_00B2cª_0090v)
		{
			return null;
		}

		[Token(Token = "0x6000F7A")]
		[Address(RVA = "0x733AB04", Offset = "0x7336B04", VA = "0x733AB04")]
		public AssetInfo[] _00AF_00AFI_00B6AV(string[] _005BMu_005Eµ_00AF)
		{
			return null;
		}

		[Token(Token = "0x6000F7B")]
		[Address(RVA = "0x733AD88", Offset = "0x7336D88", VA = "0x733AD88")]
		private string GIpeo_00BC(string vA_00A7_00B1ps)
		{
			return null;
		}

		[Token(Token = "0x6000F7C")]
		[Address(RVA = "0x733AE7C", Offset = "0x7336E7C", VA = "0x733AE7C")]
		public PackageBundle _0060YvMS_007B(string _005Efc_0089º_0089)
		{
			return null;
		}

		[Token(Token = "0x6000F7D")]
		[Address(RVA = "0x733AFF8", Offset = "0x7336FF8", VA = "0x733AFF8")]
		public PackageBundle[] g_00A2zX_007E_0082(string _005Efc_0089º_0089)
		{
			return null;
		}

		[Token(Token = "0x6000F7E")]
		[Address(RVA = "0x733B284", Offset = "0x7337284", VA = "0x733B284")]
		private void _009Cpr_008C_00AFX(string _00B8_007CL_0094_0090l)
		{
		}

		[Token(Token = "0x6000F7F")]
		[Address(RVA = "0x733B3C8", Offset = "0x73373C8", VA = "0x733B3C8")]
		public AssetInfo ConvertAssetGUIDToAssetInfo(string vA_00A7_00B1ps, Type o_00B2cª_0090v)
		{
			return null;
		}

		[Token(Token = "0x6000F80")]
		[Address(RVA = "0x733B530", Offset = "0x7337530", VA = "0x733B530")]
		public bool _00A2_005EV_007E_007DE(string _005Efc_0089º_0089, out PackageAsset H_009CVRM_005D)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED PackageManifest._00A2_005EV_007E_007DE RVA=0x733B530 Token=0x6000F80");
}

		[Token(Token = "0x6000F81")]
		[Address(RVA = "0x733B598", Offset = "0x7337598", VA = "0x733B598")]
		public PackageBundle i_0091c_00BEiZ(string _005Efc_0089º_0089)
		{
			return null;
		}

		[Token(Token = "0x6000F82")]
		[Address(RVA = "0x733B710", Offset = "0x7337710", VA = "0x733B710")]
		public string[] GetBundleIncludeAssets(string _005Efc_0089º_0089)
		{
			return null;
		}

		[Token(Token = "0x6000F83")]
		[Address(RVA = "0x733B97C", Offset = "0x733797C", VA = "0x733B97C")]
		private string _0097fDUa_009D(string _00B8_007CL_0094_0090l)
		{
			return null;
		}

		[Token(Token = "0x6000F84")]
		[Address(RVA = "0x733BA8C", Offset = "0x7337A8C", VA = "0x733BA8C")]
		public AssetInfo s_00B1Bm_00A9q(string vA_00A7_00B1ps, Type o_00B2cª_0090v)
		{
			return null;
		}
	}
}
