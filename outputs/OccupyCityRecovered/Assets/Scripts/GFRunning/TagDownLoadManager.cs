using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GameFramework;
using Il2CppDummyDll;
using YooAsset;

[Token(Token = "0x2000030")]
public class TagDownLoadManager : GFMonoSingleton<TagDownLoadManager>
{
	[Token(Token = "0x2000031")]
	public enum TagDownloadState
	{
		[Token(Token = "0x4000092")]
		NOTDOWNLOAD = 0,
		[Token(Token = "0x4000093")]
		NEEDUPDATE = 1,
		[Token(Token = "0x4000094")]
		DOWINLOADING = 2,
		[Token(Token = "0x4000095")]
		ISLATEST = 3,
		[Token(Token = "0x4000096")]
		TAGERROR = 4
	}

	[Token(Token = "0x2000032")]
	public class ResourceDownloaderWrapper
	{
		[Token(Token = "0x4000097")]
		[FieldOffset(Offset = "0x10")]
		public ResourceDownloaderOperation resourceDownloaderOperation;

		[Token(Token = "0x4000098")]
		[FieldOffset(Offset = "0x18")]
		public string[] _tags;

		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0x20")]
		public string _tagsKey;

		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0x28")]
		public TagDownLoadManager _tagDownLoadManager;

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x70848D4", Offset = "0x70808D4", VA = "0x70848D4")]
		public TagDownloadState _00A3_008B_0098_0087_007D_008D(out TagsDownloadInfo _0060I_00A2Fib)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED TagDownLoadManager.ResourceDownloaderWrapper._00A3_008B_0098_0087_007D_008D RVA=0x70848D4 Token=0x600024A");
}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x7083378", Offset = "0x707F378", VA = "0x7083378")]
		public ResourceDownloaderWrapper(ResourceDownloaderOperation rÂ_0087w_0088_0085, TagDownLoadManager Àg_00B7_009FaG, string[] _005BMu_005Eµ_00AF)
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x7084B58", Offset = "0x7080B58", VA = "0x7084B58")]
		public TagDownloadState _007FzAº_00B8_0083(out TagsDownloadInfo _0060I_00A2Fib)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED TagDownLoadManager.ResourceDownloaderWrapper._007FzAº_00B8_0083 RVA=0x7084B58 Token=0x600024C");
}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x7084DD8", Offset = "0x7080DD8", VA = "0x7084DD8")]
		public TagDownloadState v_00BE_007Etv_00B8(out TagsDownloadInfo _0060I_00A2Fib)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED TagDownLoadManager.ResourceDownloaderWrapper.v_00BE_007Etv_00B8 RVA=0x7084DD8 Token=0x600024D");
}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x7085058", Offset = "0x7081058", VA = "0x7085058")]
		public TagDownloadState _00A2_00AD_00B8a_00A4_008C(out TagsDownloadInfo _0060I_00A2Fib)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED TagDownLoadManager.ResourceDownloaderWrapper._00A2_00AD_00B8a_00A4_008C RVA=0x7085058 Token=0x600024E");
}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x70852CC", Offset = "0x70812CC", VA = "0x70852CC")]
		private void _00A1l_00AD_0083_0082_009D(bool µ_008B_0086XD_008B)
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x70853C0", Offset = "0x70813C0", VA = "0x70853C0")]
		[CompilerGenerated]
		private void zµcBk_0097(bool µ_008B_0086XD_008B)
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x70854B0", Offset = "0x70814B0", VA = "0x70854B0")]
		public void _00AB_009F_0092_008Eg_0090()
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x7085558", Offset = "0x7081558", VA = "0x7085558")]
		public void P_00A3_008C_0086OW()
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x7085644", Offset = "0x7081644", VA = "0x7085644")]
		public void _0092qa_008F_0088µ()
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x7085730", Offset = "0x7081730", VA = "0x7085730")]
		public TagDownloadState o_00A9_0084_009C_0093l(out TagsDownloadInfo _0060I_00A2Fib)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED TagDownLoadManager.ResourceDownloaderWrapper.o_00A9_0084_009C_0093l RVA=0x7085730 Token=0x6000254");
}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x70859A8", Offset = "0x70819A8", VA = "0x70859A8")]
		public TagDownloadState PµUo_0088_00A0(out TagsDownloadInfo _0060I_00A2Fib)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED TagDownLoadManager.ResourceDownloaderWrapper.PµUo_0088_00A0 RVA=0x70859A8 Token=0x6000255");
}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x7085C2C", Offset = "0x7081C2C", VA = "0x7085C2C")]
		private void u_0089x_00B7_007D_008B(bool µ_008B_0086XD_008B)
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x7085D20", Offset = "0x7081D20", VA = "0x7085D20")]
		public TagDownloadState ªW_00A9m_009Dº(out TagsDownloadInfo _0060I_00A2Fib)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED TagDownLoadManager.ResourceDownloaderWrapper.ªW_00A9m_009Dº RVA=0x7085D20 Token=0x6000257");
}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x7085F9C", Offset = "0x7081F9C", VA = "0x7085F9C")]
		public void _0089_009A_005De_007F_008C()
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x7086044", Offset = "0x7082044", VA = "0x7086044")]
		public void _00BD_0098j_0093m_0080()
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x708612C", Offset = "0x708212C", VA = "0x708612C")]
		public void I_0087_0099_00ADG_0093()
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x7086214", Offset = "0x7082214", VA = "0x7086214")]
		private void _00A6S_007E_00A6Y_0092(bool µ_008B_0086XD_008B)
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x7086304", Offset = "0x7082304", VA = "0x7086304")]
		private void µJ_007DQx_008C(bool µ_008B_0086XD_008B)
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x70863F4", Offset = "0x70823F4", VA = "0x70863F4")]
		public void S_009E_00A9_00B9_0080a()
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x708649C", Offset = "0x708249C", VA = "0x708649C")]
		public TagDownloadState _00A6_0096kµ_008Ez(out TagsDownloadInfo _0060I_00A2Fib)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED TagDownLoadManager.ResourceDownloaderWrapper._00A6_0096kµ_008Ez RVA=0x708649C Token=0x600025E");
}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x7086720", Offset = "0x7082720", VA = "0x7086720")]
		public TagDownloadState _00AF_0093_0087Qg_0091(out TagsDownloadInfo _0060I_00A2Fib)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED TagDownLoadManager.ResourceDownloaderWrapper._00AF_0093_0087Qg_0091 RVA=0x7086720 Token=0x600025F");
}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x708699C", Offset = "0x708299C", VA = "0x708699C")]
		private void _005B_0096PKI_0080(bool µ_008B_0086XD_008B)
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x7086A88", Offset = "0x7082A88", VA = "0x7086A88")]
		private void _009F_0084_00BF_0097_0060_0096(bool µ_008B_0086XD_008B)
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x7086B78", Offset = "0x7082B78", VA = "0x7086B78")]
		public void _00A8_009B_00B1À_005Dz()
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x7086C20", Offset = "0x7082C20", VA = "0x7086C20")]
		private void X_0096_00A3V_00B0u(bool µ_008B_0086XD_008B)
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x7086D0C", Offset = "0x7082D0C", VA = "0x7086D0C")]
		public TagDownloadState _0081W_00BDb_0081_0082(out TagsDownloadInfo _0060I_00A2Fib)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED TagDownLoadManager.ResourceDownloaderWrapper._0081W_00BDb_0081_0082 RVA=0x7086D0C Token=0x6000264");
}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x7086F78", Offset = "0x7082F78", VA = "0x7086F78")]
		public TagDownloadState _00A2nA_0090_0092D(out TagsDownloadInfo _0060I_00A2Fib)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED TagDownLoadManager.ResourceDownloaderWrapper._00A2nA_0090_0092D RVA=0x7086F78 Token=0x6000265");
}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x70871FC", Offset = "0x70831FC", VA = "0x70871FC")]
		public void _008C_00B3vQÁE()
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x70872E4", Offset = "0x70832E4", VA = "0x70872E4")]
		public void _009D_00BF_007C_005D_00BF_0081()
		{
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x70838A4", Offset = "0x707F8A4", VA = "0x70838A4")]
		public TagDownloadState GetDownLoadState(out TagsDownloadInfo _0060I_00A2Fib)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED TagDownLoadManager.ResourceDownloaderWrapper.GetDownLoadState RVA=0x70838A4 Token=0x6000268");
}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x708738C", Offset = "0x708338C", VA = "0x708738C")]
		public void _0086_00A5xe_007B_009D()
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x7087474", Offset = "0x7083474", VA = "0x7087474")]
		public void ª_00BBJ_00ACa_009C()
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x708751C", Offset = "0x708351C", VA = "0x708751C")]
		public void c_0094gFoc()
		{
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x70875C4", Offset = "0x70835C4", VA = "0x70875C4")]
		public void RemoveSelf()
		{
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x708766C", Offset = "0x708366C", VA = "0x708766C")]
		private void _0089H_00B2X_007F_00A0(bool µ_008B_0086XD_008B)
		{
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x708775C", Offset = "0x708375C", VA = "0x708775C")]
		public void BeginDownload()
		{
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x7087848", Offset = "0x7083848", VA = "0x7087848")]
		private void hadlf_00A8(bool µ_008B_0086XD_008B)
		{
		}
	}

	[Token(Token = "0x2000033")]
	public class TagsDownloadInfo
	{
		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0x10")]
		public long CurrentDownloadBytes;

		[Token(Token = "0x400009C")]
		[FieldOffset(Offset = "0x18")]
		public long TotalDownloadBytes;

		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0x20")]
		public ResourceDownloaderWrapper ResourceDownloaderWrapper;

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x708793C", Offset = "0x708393C", VA = "0x708793C")]
		public TagsDownloadInfo()
		{
		}
	}

	[Token(Token = "0x400008F")]
	[FieldOffset(Offset = "0x20")]
	private ResourcePackage _00B1N_005D_009EV_009F;

	[Token(Token = "0x4000090")]
	[FieldOffset(Offset = "0x28")]
	private Dictionary<string, ResourceDownloaderWrapper> t_0091_008A_0091ag;

	[Token(Token = "0x6000212")]
	[Address(RVA = "0x70824D8", Offset = "0x707E4D8", VA = "0x70824D8")]
	public void _00BE_00B9_0098_0089_007FG()
	{
	}

	[Token(Token = "0x6000213")]
	[Address(RVA = "0x7082528", Offset = "0x707E528", VA = "0x7082528")]
	private static bool Á_007EBGyq()
	{
		return default;
	}

	[Token(Token = "0x6000214")]
	[Address(RVA = "0x7082664", Offset = "0x707E664", VA = "0x7082664")]
	public void _0089_00BFrnm_00A1(string[] _005BMu_005Eµ_00AF)
	{
	}

	[Token(Token = "0x6000215")]
	[Address(RVA = "0x70827D8", Offset = "0x707E7D8", VA = "0x70827D8")]
	public PreDownloadContentOperation _0096_0087_0094_00BD_00ACQ(string _00AF_0086_00BE_00B3_00B4_008E)
	{
		return null;
	}

	[Token(Token = "0x6000216")]
	[Address(RVA = "0x70829B0", Offset = "0x707E9B0", VA = "0x70829B0")]
	public void SaveTagsHasDownLoad(string[] _005BMu_005Eµ_00AF)
	{
	}

	[Token(Token = "0x6000217")]
	[Address(RVA = "0x7082BDC", Offset = "0x707EBDC", VA = "0x7082BDC")]
	public void J_0085_0082_00A3JÀ()
	{
	}

	[Token(Token = "0x6000218")]
	[Address(RVA = "0x7082AA0", Offset = "0x707EAA0", VA = "0x7082AA0")]
	private static bool Of_0097FiI()
	{
		return default;
	}

	[Token(Token = "0x6000219")]
	[Address(RVA = "0x7082C2C", Offset = "0x707EC2C", VA = "0x7082C2C")]
	public void AddDownloaderWrapper(ResourceDownloaderWrapper _00ACs_0087Gdb)
	{
	}

	[Token(Token = "0x600021A")]
	[Address(RVA = "0x7082CCC", Offset = "0x707ECCC", VA = "0x7082CCC")]
	public void p_00BC_00A1D_0089_0086(string N_00BFA_007Ev_00A2)
	{
	}

	[Token(Token = "0x600021B")]
	[Address(RVA = "0x7082F10", Offset = "0x707EF10", VA = "0x7082F10")]
	public bool jK_005D_0098C_0093(string N_00BFA_007Ev_00A2)
	{
		return default;
	}

	[Token(Token = "0x600021C")]
	[Address(RVA = "0x7082F68", Offset = "0x707EF68", VA = "0x7082F68")]
	public void kH_007D_007B_008EÀ(string _0099_009DÂµ_0096_00AC)
	{
	}

	[Token(Token = "0x600021D")]
	[Address(RVA = "0x7082FA0", Offset = "0x707EFA0", VA = "0x7082FA0")]
	public void _00BE_0084_00BDGHe()
	{
	}

	[Token(Token = "0x600021E")]
	[Address(RVA = "0x7082FD8", Offset = "0x707EFD8", VA = "0x7082FD8")]
	public void ForceUnloadAllAssets()
	{
	}

	[Token(Token = "0x600021F")]
	[Address(RVA = "0x708307C", Offset = "0x707F07C", VA = "0x708307C")]
	private ResourceDownloaderWrapper j_009A_0085U_00BE_0090(string[] _005BMu_005Eµ_00AF, int Y_0089lev_0083 = 10, int _00BD_00B2F_00AF_00B8t = 3, int _00AFF_00BD_0083_0087X = 30)
	{
		return null;
	}

	[Token(Token = "0x6000220")]
	[Address(RVA = "0x70833D4", Offset = "0x707F3D4", VA = "0x70833D4")]
	public PreDownloadContentOperation i_00A8mvbF(string _00AF_0086_00BE_00B3_00B4_008E)
	{
		return null;
	}

	[Token(Token = "0x6000221")]
	[Address(RVA = "0x70833E8", Offset = "0x707F3E8", VA = "0x70833E8")]
	public bool f_008Drµ_00A9_005D(string[] _005BMu_005Eµ_00AF)
	{
		return default;
	}

	[Token(Token = "0x6000222")]
	[Address(RVA = "0x7083578", Offset = "0x707F578", VA = "0x7083578")]
	public void _0080_0087y_0090_008EJ(string[] _005BMu_005Eµ_00AF)
	{
	}

	[Token(Token = "0x6000223")]
	[Address(RVA = "0x7083668", Offset = "0x707F668", VA = "0x7083668")]
	public void k_0094tBR_008C()
	{
	}

	[Token(Token = "0x6000224")]
	[Address(RVA = "0x70836EC", Offset = "0x707F6EC", VA = "0x70836EC")]
	public TagDownloadState GetDownloadState(string[] _005BMu_005Eµ_00AF, out TagsDownloadInfo _0060I_00A2Fib)
	{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED TagDownLoadManager.GetDownloadState RVA=0x70836EC Token=0x6000224");
}

	[Token(Token = "0x6000225")]
	[Address(RVA = "0x7083B18", Offset = "0x707FB18", VA = "0x7083B18")]
	public PreDownloadContentOperation PreDownloadContentAsync(string _00AF_0086_00BE_00B3_00B4_008E)
	{
		return null;
	}

	[Token(Token = "0x6000226")]
	[Address(RVA = "0x7083B6C", Offset = "0x707FB6C", VA = "0x7083B6C")]
	public void CleanDownloaderWrapper()
	{
	}

	[Token(Token = "0x6000227")]
	[Address(RVA = "0x7083174", Offset = "0x707F174", VA = "0x7083174")]
	public static string GetTagsName(string[] _005BMu_005Eµ_00AF)
	{
		return null;
	}

	[Token(Token = "0x6000228")]
	[Address(RVA = "0x7083BBC", Offset = "0x707FBBC", VA = "0x7083BBC")]
	public UpdatePackageVersionOperation GetServerVersionCodeAsync()
	{
		return null;
	}

	[Token(Token = "0x6000229")]
	[Address(RVA = "0x7083C00", Offset = "0x707FC00", VA = "0x7083C00")]
	public void DestroyPackage()
	{
	}

	[Token(Token = "0x600022A")]
	[Address(RVA = "0x7083C84", Offset = "0x707FC84", VA = "0x7083C84")]
	public void _00A9_009C_0096_007Cq_0089()
	{
	}

	[Token(Token = "0x600022B")]
	[Address(RVA = "0x7083CDC", Offset = "0x707FCDC", VA = "0x7083CDC")]
	public TagDownLoadManager()
	{
	}

	[Token(Token = "0x600022C")]
	[Address(RVA = "0x7083D6C", Offset = "0x707FD6C", VA = "0x7083D6C")]
	public PreDownloadContentOperation _00A0_00ABx_009Et_0090(string _00AF_0086_00BE_00B3_00B4_008E)
	{
		return null;
	}

	[Token(Token = "0x600022D")]
	[Address(RVA = "0x7083DC0", Offset = "0x707FDC0", VA = "0x7083DC0")]
	public void DeleteCfg()
	{
	}

	[Token(Token = "0x600022E")]
	[Address(RVA = "0x7083E60", Offset = "0x707FE60", VA = "0x7083E60")]
	public void _009DbO_0090D_0086(string[] _005BMu_005Eµ_00AF)
	{
	}

	[Token(Token = "0x600022F")]
	[Address(RVA = "0x7082924", Offset = "0x707E924", VA = "0x7082924")]
	private void k_007BDµ_00BDZ()
	{
	}

	[Token(Token = "0x6000230")]
	[Address(RVA = "0x7083E98", Offset = "0x707FE98", VA = "0x7083E98", Slot = "24")]
	protected override void InitializeSingleton()
	{
	}

	[Token(Token = "0x6000231")]
	[Address(RVA = "0x7083EF4", Offset = "0x707FEF4", VA = "0x7083EF4")]
	public UpdatePackageManifestOperation o_00BEc_008E_00A2X(string _00A9gR_0085_00A0m)
	{
		return null;
	}

	[Token(Token = "0x6000232")]
	[Address(RVA = "0x7083F08", Offset = "0x707FF08", VA = "0x7083F08")]
	public void SaveTagHasDownLoad(string N_00BFA_007Ev_00A2)
	{
	}

	[Token(Token = "0x6000233")]
	[Address(RVA = "0x7084018", Offset = "0x7080018", VA = "0x7084018")]
	public void Clear()
	{
	}

	[Token(Token = "0x6000234")]
	[Address(RVA = "0x7084070", Offset = "0x7080070", VA = "0x7084070")]
	public UpdatePackageManifestOperation _00B8_009E_00B8_007B_00A0_00AF(string _00A9gR_0085_00A0m)
	{
		return null;
	}

	[Token(Token = "0x6000235")]
	[Address(RVA = "0x7083428", Offset = "0x707F428", VA = "0x7083428")]
	public bool TagHasDownLoad(string N_00BFA_007Ev_00A2)
	{
		return default;
	}

	[Token(Token = "0x6000236")]
	[Address(RVA = "0x7084084", Offset = "0x7080084", VA = "0x7084084")]
	public void _00BE_00A1_009D_008FE_00A6()
	{
	}

	[Token(Token = "0x6000237")]
	[Address(RVA = "0x70840BC", Offset = "0x70800BC", VA = "0x70840BC")]
	public bool _00B0_0086_00B7_00B2_00B2_00A4(string[] _005BMu_005Eµ_00AF)
	{
		return default;
	}

	[Token(Token = "0x6000238")]
	[Address(RVA = "0x70837AC", Offset = "0x707F7AC", VA = "0x70837AC")]
	private ResourceDownloaderWrapper Âa_00A5_0086Wi(string[] _005BMu_005Eµ_00AF, int Y_0089lev_0083 = 10, int _00BD_00B2F_00AF_00B8t = 3, int _00AFF_00BD_0083_0087X = 30)
	{
		return null;
	}

	[Token(Token = "0x6000239")]
	[Address(RVA = "0x70842BC", Offset = "0x70802BC", VA = "0x70842BC")]
	public UpdatePackageVersionOperation _0088yW_005E_0091ª()
	{
		return null;
	}

	[Token(Token = "0x600023A")]
	[Address(RVA = "0x70842D0", Offset = "0x70802D0", VA = "0x70842D0")]
	public UpdatePackageManifestOperation _00B8r_007F_00B1_00AB_00B4(string _00A9gR_0085_00A0m)
	{
		return null;
	}

	[Token(Token = "0x600023B")]
	[Address(RVA = "0x7084314", Offset = "0x7080314", VA = "0x7084314")]
	public bool _0082sX_005B_0095F(string[] _005BMu_005Eµ_00AF)
	{
		return default;
	}

	[Token(Token = "0x600023C")]
	[Address(RVA = "0x70843D0", Offset = "0x70803D0", VA = "0x70843D0")]
	public void z_0095pÁ_00A4_0091()
	{
	}

	[Token(Token = "0x600023D")]
	[Address(RVA = "0x7084474", Offset = "0x7080474", VA = "0x7084474")]
	public void _0081_0060_0086_0087HB()
	{
	}

	[Token(Token = "0x600023E")]
	[Address(RVA = "0x7082DD8", Offset = "0x707EDD8", VA = "0x7082DD8")]
	private static bool _0093_00B6C_0081AD()
	{
		return default;
	}

	[Token(Token = "0x600023F")]
	[Address(RVA = "0x7084514", Offset = "0x7080514", VA = "0x7084514")]
	public UpdatePackageVersionOperation _0098Cd_00A4_0091_009E()
	{
		return null;
	}

	[Token(Token = "0x6000240")]
	[Address(RVA = "0x7084528", Offset = "0x7080528", VA = "0x7084528")]
	public bool TagsHasDownLoad(string[] _005BMu_005Eµ_00AF)
	{
		return default;
	}

	[Token(Token = "0x6000241")]
	[Address(RVA = "0x708269C", Offset = "0x707E69C", VA = "0x708269C")]
	private static bool ce_00A1Kµ_009A()
	{
		return default;
	}

	[Token(Token = "0x6000242")]
	[Address(RVA = "0x7084624", Offset = "0x7080624", VA = "0x7084624")]
	public void SetLatestCompatibleAppVersion(string _0099_009DÂµ_0096_00AC)
	{
	}

	[Token(Token = "0x6000243")]
	[Address(RVA = "0x70846C0", Offset = "0x70806C0", VA = "0x70846C0")]
	public UpdatePackageManifestOperation _008BQ_00B6_00B8_00AF_0084(string _00A9gR_0085_00A0m)
	{
		return null;
	}

	[Token(Token = "0x6000244")]
	[Address(RVA = "0x70846D4", Offset = "0x70806D4", VA = "0x70846D4")]
	public UpdatePackageManifestOperation UpdatePackageManifestAsync(string _00A9gR_0085_00A0m)
	{
		return null;
	}

	[Token(Token = "0x6000245")]
	[Address(RVA = "0x7084180", Offset = "0x7080180", VA = "0x7084180")]
	private static bool _00B6U_008C_00BE_00AD_008C()
	{
		return default;
	}

	[Token(Token = "0x6000246")]
	[Address(RVA = "0x708472C", Offset = "0x708072C", VA = "0x708472C")]
	public void Z_0089ªJDµ()
	{
	}

	[Token(Token = "0x6000247")]
	[Address(RVA = "0x7084764", Offset = "0x7080764", VA = "0x7084764")]
	public static string _007BmM_00ADH_0097(string[] _005BMu_005Eµ_00AF)
	{
		return null;
	}

	[Token(Token = "0x6000248")]
	[Address(RVA = "0x7084804", Offset = "0x7080804", VA = "0x7084804")]
	public bool tar_0087_0088_0095(string[] _005BMu_005Eµ_00AF)
	{
		return default;
	}

	[Token(Token = "0x6000249")]
	[Address(RVA = "0x70827EC", Offset = "0x707E7EC", VA = "0x70827EC")]
	private static bool C_00A0B_005DKC()
	{
		return default;
	}
}
