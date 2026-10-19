using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace YooAsset
{
	[Token(Token = "0x200012A")]
	public class ResourcePackage
	{
		[Token(Token = "0x4000474")]
		[FieldOffset(Offset = "0x10")]
		private bool _009D_007B_00A4_009F_009DÂ;

		[Token(Token = "0x4000475")]
		[FieldOffset(Offset = "0x18")]
		private string HRW_00B4_008B_008C;

		[Token(Token = "0x4000476")]
		[FieldOffset(Offset = "0x20")]
		private EOperationStatus J_0090_0090I_0098_00B0;

		[Token(Token = "0x4000477")]
		[FieldOffset(Offset = "0x24")]
		private EPlayMode _009C_00A4_007C_00A1_0083_0084;

		[Token(Token = "0x4000478")]
		[FieldOffset(Offset = "0x28")]
		private P_007C_00A4_007E_0096º O_00BEEuBz;

		[Token(Token = "0x4000479")]
		[FieldOffset(Offset = "0x30")]
		private h_0097_00B2BuH _007E_0090A_005B_008CQ;

		[Token(Token = "0x400047A")]
		[FieldOffset(Offset = "0x38")]
		private _0087LLP_0097_00B8 A_00B9O_00B3_0089K;

		[Token(Token = "0x400047B")]
		[FieldOffset(Offset = "0x40")]
		private string _00B1_008ADB_00AFl;

		[Token(Token = "0x170000C9")]
		public string PackageName
		{
			[Token(Token = "0x60010A4")]
			[Address(RVA = "0x7347944", Offset = "0x7343944", VA = "0x7347944")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60010C4")]
			[Address(RVA = "0x7348B90", Offset = "0x7344B90", VA = "0x7348B90")]
			private set
			{
				S_008B_00BD_0086Y_00B7(value);
			}
		}

		[Token(Token = "0x170000CA")]
		public EOperationStatus InitializeStatus
		{
			[Token(Token = "0x60010AD")]
			[Address(RVA = "0x7347F2C", Offset = "0x7343F2C", VA = "0x7347F2C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600106B")]
		[Address(RVA = "0x7344F68", Offset = "0x7340F68", VA = "0x7344F68")]
		public ResourceUnpackerOperation Â_005Dy_0088_005E_008F(int aªF_00A8_00BF_00BF, int _00BD_00B2F_00AF_00B8t)
		{
			return null;
		}

		[Token(Token = "0x600106C")]
		[Address(RVA = "0x7345028", Offset = "0x7341028", VA = "0x7345028")]
		public ResourceDownloaderOperation KµH_0083nµ(AssetInfo y_0091_00A0K_0096F, int _00AC_0083X_009D_00AEp, int _00BD_00B2F_00AF_00B8t, int _00AFF_00BD_0083_0087X = 60)
		{
			return null;
		}

		[Token(Token = "0x600106D")]
		[Address(RVA = "0x7345158", Offset = "0x7341158", VA = "0x7345158")]
		public string GetPackageBuildinRootDirectory()
		{
			return null;
		}

		[Token(Token = "0x600106E")]
		[Address(RVA = "0x73451C4", Offset = "0x73411C4", VA = "0x73451C4")]
		public ResourceDownloaderOperation CreateResourceDownloader(string N_00BFA_007Ev_00A2, int _00AC_0083X_009D_00AEp, int _00BD_00B2F_00AF_00B8t, int _00AFF_00BD_0083_0087X = 60)
		{
			return null;
		}

		[Token(Token = "0x600106F")]
		[Address(RVA = "0x73452D0", Offset = "0x73412D0", VA = "0x73452D0")]
		public ResourceDownloaderOperation CreateBundleDownloader(AssetInfo[] _00BBV_00B8CwÀ, int _00AC_0083X_009D_00AEp, int _00BD_00B2F_00AF_00B8t, int _00AFF_00BD_0083_0087X = 60)
		{
			return null;
		}

		[Token(Token = "0x6001070")]
		[Address(RVA = "0x73453A4", Offset = "0x73413A4", VA = "0x73453A4")]
		internal DebugPackageData _00AB_0083_00AD_00BCRN()
		{
			return null;
		}

		[Token(Token = "0x6001071")]
		[Address(RVA = "0x7345420", Offset = "0x7341420", VA = "0x7345420")]
		public bool _009Aafq_008D_0093(string _00B8_007CL_0094_0090l)
		{
			return default;
		}

		[Token(Token = "0x6001072")]
		[Address(RVA = "0x73454E8", Offset = "0x73414E8", VA = "0x73454E8")]
		public SceneOperationHandle LoadSceneAsync(string _00B8_007CL_0094_0090l, LoadSceneMode VEQ_00BF_00BDG = LoadSceneMode.Single, bool _00A7Â_007By_007D_008A = false, int rVlHªB = 100)
		{
			return null;
		}

		[Token(Token = "0x6001073")]
		[Address(RVA = "0x7345604", Offset = "0x7341604", VA = "0x7345604")]
		public AssetOperationHandle LoadAssetAsync(string _00B8_007CL_0094_0090l, Type _007BgpR_00A0V)
		{
			return null;
		}

		[Token(Token = "0x6001074")]
		[Address(RVA = "0x7345678", Offset = "0x7341678", VA = "0x7345678")]
		private AssetInfo _0093_005E_009FºI_008A(string vA_00A7_00B1ps, Type o_00B2cª_0090v)
		{
			return null;
		}

		[Token(Token = "0x6001075")]
		[Address(RVA = "0x734573C", Offset = "0x734173C", VA = "0x734573C")]
		internal void _0083_0087_00BDlj_00BC()
		{
		}

		[Token(Token = "0x6001076")]
		[Address(RVA = "0x7345750", Offset = "0x7341750", VA = "0x7345750")]
		public bool CheckLocationValid(string _00B8_007CL_0094_0090l)
		{
			return default;
		}

		[Token(Token = "0x6001077")]
		[Address(RVA = "0x7345818", Offset = "0x7341818", VA = "0x7345818")]
		public string _0092kg_007C_0060E()
		{
			return null;
		}

		[Token(Token = "0x6001078")]
		[Address(RVA = "0x7345884", Offset = "0x7341884", VA = "0x7345884")]
		public int Vt_0097_0085_0096r(string j_0081xY_0088_0088)
		{
			return default;
		}

		[Token(Token = "0x6001079")]
		[Address(RVA = "0x7345890", Offset = "0x7341890", VA = "0x7345890")]
		private SubAssetsOperationHandle ZgKHl_00AE(AssetInfo y_0091_00A0K_0096F, bool _007B_0095_0060_008Ax_0096)
		{
			return null;
		}

		[Token(Token = "0x600107A")]
		[Address(RVA = "0x73458D8", Offset = "0x73418D8", VA = "0x73458D8")]
		public ResourceDownloaderOperation _007CMCLul(string[] nG_009B_0083_00B2H, int _00AC_0083X_009D_00AEp, int _00BD_00B2F_00AF_00B8t, int _00AFF_00BD_0083_0087X = 60)
		{
			return null;
		}

		[Token(Token = "0x600107B")]
		[Address(RVA = "0x7345AB0", Offset = "0x7341AB0", VA = "0x7345AB0")]
		private void _00A2_008E_00A7_00A3l_00A5(InitializeParameters _00A1PGyl_0097)
		{
		}

		[Token(Token = "0x600107C")]
		[Address(RVA = "0x7345E48", Offset = "0x7341E48", VA = "0x7345E48")]
		public string GetPackageSandboxRootDirectory()
		{
			return null;
		}

		[Token(Token = "0x600107D")]
		[Address(RVA = "0x7345EB4", Offset = "0x7341EB4", VA = "0x7345EB4")]
		public AssetOperationHandle LoadAssetSync(string _00B8_007CL_0094_0090l, Type _007BgpR_00A0V)
		{
			return null;
		}

		[Token(Token = "0x600107E")]
		[Address(RVA = "0x7345ED4", Offset = "0x7341ED4", VA = "0x7345ED4")]
		public SubAssetsOperationHandle LoadSubAssetsAsync(AssetInfo y_0091_00A0K_0096F)
		{
			return null;
		}

		[Token(Token = "0x600107F")]
		[Address(RVA = "0x7345F38", Offset = "0x7341F38", VA = "0x7345F38")]
		private void _008BNX_00BF_005DX(string _00ACl_0082X_009F_008E)
		{
		}

		[Token(Token = "0x6001080")]
		[Address(RVA = "0x7346124", Offset = "0x7342124", VA = "0x7346124")]
		public ResourceDownloaderOperation _0089_00BF_005D_007FZF(AssetInfo[] _00BBV_00B8CwÀ, int _00AC_0083X_009D_00AEp, int _00BD_00B2F_00AF_00B8t, int _00AFF_00BD_0083_0087X = 60)
		{
			return null;
		}

		[Token(Token = "0x6001081")]
		[Address(RVA = "0x73461F8", Offset = "0x73421F8", VA = "0x73461F8")]
		public ResourceUnpackerOperation c_00B9sX_0084X(int aªF_00A8_00BF_00BF, int _00BD_00B2F_00AF_00B8t)
		{
			return null;
		}

		[Token(Token = "0x6001082")]
		[Address(RVA = "0x73462B8", Offset = "0x73422B8", VA = "0x73462B8")]
		public ClearAllCacheFilesOperation ClearAllCacheFilesAsync()
		{
			return null;
		}

		[Token(Token = "0x6001083")]
		[Address(RVA = "0x734634C", Offset = "0x734234C", VA = "0x734634C")]
		private void Â_00B7_00AF_0089º_0080(string _00ACl_0082X_009F_008E)
		{
		}

		[Token(Token = "0x6001084")]
		[Address(RVA = "0x7346538", Offset = "0x7342538", VA = "0x7346538")]
		[Conditional("DEBUG")]
		private void T_0084_0099_00B3e_0094()
		{
		}

		[Token(Token = "0x6001085")]
		[Address(RVA = "0x73465BC", Offset = "0x73425BC", VA = "0x73465BC")]
		private RawFileOperationHandle A_00B3iINf(AssetInfo y_0091_00A0K_0096F, bool _007B_0095_0060_008Ax_0096)
		{
			return null;
		}

		[Token(Token = "0x6001086")]
		[Address(RVA = "0x7346604", Offset = "0x7342604", VA = "0x7346604")]
		public SubAssetsOperationHandle sjss_008D_00BC(AssetInfo y_0091_00A0K_0096F)
		{
			return null;
		}

		[Token(Token = "0x6001087")]
		[Address(RVA = "0x734660C", Offset = "0x734260C", VA = "0x734660C")]
		internal bool _00B7t_009F_00B3_0060y(string c_00B0º_007FW_005B)
		{
			return default;
		}

		[Token(Token = "0x6001088")]
		[Address(RVA = "0x73466DC", Offset = "0x73426DC", VA = "0x73466DC")]
		public ResourceDownloaderOperation kj_008E_0089_00B3y(int _00AC_0083X_009D_00AEp, int _00BD_00B2F_00AF_00B8t, int _00AFF_00BD_0083_0087X = 60)
		{
			return null;
		}

		[Token(Token = "0x6001089")]
		[Address(RVA = "0x73467A0", Offset = "0x73427A0", VA = "0x73467A0")]
		public AssetOperationHandle _00A3_0097ePl_0089(string _00B8_007CL_0094_0090l)
		{
			return null;
		}

		[Token(Token = "0x600108A")]
		[Address(RVA = "0x7346848", Offset = "0x7342848", VA = "0x7346848")]
		public ResourceDownloaderOperation CreateBundleDownloader(string[] nG_009B_0083_00B2H, int _00AC_0083X_009D_00AEp, int _00BD_00B2F_00AF_00B8t, int _00AFF_00BD_0083_0087X = 60)
		{
			return null;
		}

		[Token(Token = "0x600108B")]
		[Address(RVA = "0x7346A44", Offset = "0x7342A44", VA = "0x7346A44")]
		public bool IsNeedDownloadFromRemote(AssetInfo y_0091_00A0K_0096F)
		{
			return default;
		}

		[Token(Token = "0x600108C")]
		[Address(RVA = "0x7345EF0", Offset = "0x7341EF0", VA = "0x7345EF0")]
		private SubAssetsOperationHandle fs_00B0H_0089_00A0(AssetInfo y_0091_00A0K_0096F, bool _007B_0095_0060_008Ax_0096)
		{
			return null;
		}

		[Token(Token = "0x600108D")]
		[Address(RVA = "0x7346B28", Offset = "0x7342B28", VA = "0x7346B28")]
		internal void _0084_00A8bMDx()
		{
		}

		[Token(Token = "0x600108E")]
		[Address(RVA = "0x7346B3C", Offset = "0x7342B3C", VA = "0x7346B3C")]
		public ResourceDownloaderOperation CreateBundleDownloader(string _00B8_007CL_0094_0090l, int _00AC_0083X_009D_00AEp, int _00BD_00B2F_00AF_00B8t, int _00AFF_00BD_0083_0087X = 60)
		{
			return null;
		}

		[Token(Token = "0x600108F")]
		[Address(RVA = "0x7346C84", Offset = "0x7342C84", VA = "0x7346C84")]
		public AssetOperationHandle µwmI_009E_0093(string _00B8_007CL_0094_0090l)
		{
			return null;
		}

		[Token(Token = "0x6001090")]
		[Address(RVA = "0x7346D20", Offset = "0x7342D20", VA = "0x7346D20")]
		public AssetInfo r_007B_00AE_009A_008E_00B4(string vA_00A7_00B1ps)
		{
			return null;
		}

		[Token(Token = "0x6001091")]
		[Address(RVA = "0x7346D28", Offset = "0x7342D28", VA = "0x7346D28")]
		public bool IsNeedDownloadFromRemote(string _00B8_007CL_0094_0090l)
		{
			return default;
		}

		[Token(Token = "0x6001092")]
		[Address(RVA = "0x7346E1C", Offset = "0x7342E1C", VA = "0x7346E1C")]
		public string GetBundleName(string _00B8_007CL_0094_0090l)
		{
			return null;
		}

		[Token(Token = "0x6001093")]
		[Address(RVA = "0x7346FC0", Offset = "0x7342FC0", VA = "0x7346FC0")]
		public ResourceUnpackerOperation CreateResourceUnpacker(string[] _005BMu_005Eµ_00AF, int aªF_00A8_00BF_00BF, int _00BD_00B2F_00AF_00B8t)
		{
			return null;
		}

		[Token(Token = "0x6001094")]
		[Address(RVA = "0x7347088", Offset = "0x7343088", VA = "0x7347088")]
		public AllAssetsOperationHandle LoadAllAssetsAsync(string _00B8_007CL_0094_0090l)
		{
			return null;
		}

		[Token(Token = "0x6001095")]
		[Address(RVA = "0x7347178", Offset = "0x7343178", VA = "0x7347178")]
		public void ClearPackageSandbox()
		{
		}

		[Token(Token = "0x6001096")]
		[Address(RVA = "0x73471E4", Offset = "0x73431E4", VA = "0x73471E4")]
		public RawFileOperationHandle LoadRawFileSync(AssetInfo y_0091_00A0K_0096F)
		{
			return null;
		}

		[Token(Token = "0x6001097")]
		[Address(RVA = "0x7345630", Offset = "0x7341630", VA = "0x7345630")]
		private AssetOperationHandle _005DJº_00A8º_0088(AssetInfo y_0091_00A0K_0096F, bool _007B_0095_0060_008Ax_0096)
		{
			return null;
		}

		[Token(Token = "0x6001098")]
		[Address(RVA = "0x73471EC", Offset = "0x73431EC", VA = "0x73471EC")]
		public AllAssetsOperationHandle _0060_00BEft_0087J(string _00B8_007CL_0094_0090l)
		{
			return null;
		}

		[Token(Token = "0x6001099")]
		public AllAssetsOperationHandle LoadAllAssetsSync<TObject>(string _00B8_007CL_0094_0090l) where TObject : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x600109A")]
		[Address(RVA = "0x7347288", Offset = "0x7343288", VA = "0x7347288")]
		public AllAssetsOperationHandle LoadAllAssetsSync(string _00B8_007CL_0094_0090l)
		{
			return null;
		}

		[Token(Token = "0x600109B")]
		[Address(RVA = "0x7347324", Offset = "0x7343324", VA = "0x7347324")]
		public AssetOperationHandle BgT_009F_0060_009B(string _00B8_007CL_0094_0090l, Type _007BgpR_00A0V)
		{
			return null;
		}

		[Token(Token = "0x600109C")]
		[Address(RVA = "0x7347350", Offset = "0x7343350", VA = "0x7347350")]
		public AssetOperationHandle LoadAssetAsync(string _00B8_007CL_0094_0090l)
		{
			return null;
		}

		[Token(Token = "0x600109D")]
		[Address(RVA = "0x73473F8", Offset = "0x73433F8", VA = "0x73473F8")]
		public UpdatePackageVersionOperation _00A4_0060_0088D_008E_0083(bool vc_0089_0095_008A_007E = true, int _00AFF_00BD_0083_0087X = 60)
		{
			return null;
		}

		[Token(Token = "0x600109E")]
		[Address(RVA = "0x73474B4", Offset = "0x73434B4", VA = "0x73474B4")]
		public ClearUnusedCacheFilesOperation _00B9_0060y_00B4_00B7_007C()
		{
			return null;
		}

		[Token(Token = "0x600109F")]
		[Address(RVA = "0x7347548", Offset = "0x7343548", VA = "0x7347548")]
		public SubAssetsOperationHandle LoadSubAssetsSync(AssetInfo y_0091_00A0K_0096F)
		{
			return null;
		}

		[Token(Token = "0x60010A0")]
		[Address(RVA = "0x7347550", Offset = "0x7343550", VA = "0x7347550")]
		public AllAssetsOperationHandle LoadAllAssetsSync(string _00B8_007CL_0094_0090l, Type _007BgpR_00A0V)
		{
			return null;
		}

		[Token(Token = "0x60010A1")]
		[Address(RVA = "0x7347570", Offset = "0x7343570", VA = "0x7347570")]
		public RawFileOperationHandle LoadRawFileSync(string _00B8_007CL_0094_0090l)
		{
			return null;
		}

		[Token(Token = "0x60010A2")]
		[Address(RVA = "0x7347594", Offset = "0x7343594", VA = "0x7347594")]
		public void _00B2_007C_00B2n_009Ad()
		{
		}

		[Token(Token = "0x60010A3")]
		[Address(RVA = "0x7347780", Offset = "0x7343780", VA = "0x7347780")]
		public void Z_0089ªJDµ()
		{
		}

		[Token(Token = "0x60010A5")]
		[Address(RVA = "0x734794C", Offset = "0x734394C", VA = "0x734794C")]
		public AllAssetsOperationHandle LoadAllAssetsAsync(string _00B8_007CL_0094_0090l, Type _007BgpR_00A0V)
		{
			return null;
		}

		[Token(Token = "0x60010A6")]
		[Address(RVA = "0x7347978", Offset = "0x7343978", VA = "0x7347978")]
		public SubAssetsOperationHandle H_0087r_009AHc(string _00B8_007CL_0094_0090l, Type _007BgpR_00A0V)
		{
			return null;
		}

		[Token(Token = "0x60010A7")]
		[Address(RVA = "0x7347998", Offset = "0x7343998", VA = "0x7347998")]
		public RawFileOperationHandle LoadRawFileAsync(string _00B8_007CL_0094_0090l)
		{
			return null;
		}

		[Token(Token = "0x60010A8")]
		[Address(RVA = "0x73479C8", Offset = "0x73439C8", VA = "0x73479C8")]
		public InitializationOperation InitializeAsync(InitializeParameters _00A1PGyl_0097)
		{
			return null;
		}

		[Token(Token = "0x60010A9")]
		[Address(RVA = "0x7347E2C", Offset = "0x7343E2C", VA = "0x7347E2C")]
		public AllAssetsOperationHandle LoadAllAssetsAsync(AssetInfo y_0091_00A0K_0096F)
		{
			return null;
		}

		[Token(Token = "0x60010AA")]
		[Address(RVA = "0x7347E48", Offset = "0x7343E48", VA = "0x7347E48")]
		public SubAssetsOperationHandle LoadSubAssetsSync(string _00B8_007CL_0094_0090l, Type _007BgpR_00A0V)
		{
			return null;
		}

		[Token(Token = "0x60010AB")]
		[Address(RVA = "0x7347E68", Offset = "0x7343E68", VA = "0x7347E68")]
		public UpdatePackageVersionOperation _009Ec_005DwVF(bool vc_0089_0095_008A_007E = true, int _00AFF_00BD_0083_0087X = 60)
		{
			return null;
		}

		[Token(Token = "0x60010AC")]
		[Address(RVA = "0x7347F24", Offset = "0x7343F24", VA = "0x7347F24")]
		public AssetInfo GetAssetInfoByGUID(string vA_00A7_00B1ps)
		{
			return null;
		}

		[Token(Token = "0x60010AE")]
		[Address(RVA = "0x7347F34", Offset = "0x7343F34", VA = "0x7347F34")]
		public PreDownloadContentOperation PreDownloadContentAsync(string _00A9gR_0085_00A0m, int _00AFF_00BD_0083_0087X = 60)
		{
			return null;
		}

		[Token(Token = "0x60010AF")]
		[Address(RVA = "0x7347FF0", Offset = "0x7343FF0", VA = "0x7347FF0")]
		private void _00B0wµ_007Eq_00A1(AsyncOperationBase _005B_0083_0090CÀ_00B2)
		{
		}

		[Token(Token = "0x60010B0")]
		[Address(RVA = "0x7348014", Offset = "0x7344014", VA = "0x7348014")]
		internal void _0082h_0086_00A5j_008A()
		{
		}

		[Token(Token = "0x60010B1")]
		[Address(RVA = "0x7348028", Offset = "0x7344028", VA = "0x7348028")]
		public AssetOperationHandle _007E_00AFºN_007C_0095(string _00B8_007CL_0094_0090l)
		{
			return null;
		}

		[Token(Token = "0x60010B2")]
		[Address(RVA = "0x73480D0", Offset = "0x73440D0", VA = "0x73480D0")]
		private void _00B4q_00B0_009A_00B1_009F(AsyncOperationBase _005B_0083_0090CÀ_00B2)
		{
		}

		[Token(Token = "0x60010B3")]
		[Address(RVA = "0x73480F4", Offset = "0x73440F4", VA = "0x73480F4")]
		public ResourceDownloaderOperation Qe_0086v_00BEp(string _00B8_007CL_0094_0090l, int _00AC_0083X_009D_00AEp, int _00BD_00B2F_00AF_00B8t, int _00AFF_00BD_0083_0087X = 60)
		{
			return null;
		}

		[Token(Token = "0x60010B4")]
		[Address(RVA = "0x7348240", Offset = "0x7344240", VA = "0x7348240")]
		internal ResourcePackage(string _008Ffª_008C_007Fi)
		{
		}

		[Token(Token = "0x60010B5")]
		[Address(RVA = "0x73482AC", Offset = "0x73442AC", VA = "0x73482AC")]
		public ResourceUnpackerOperation CreateResourceUnpacker(int aªF_00A8_00BF_00BF, int _00BD_00B2F_00AF_00B8t)
		{
			return null;
		}

		[Token(Token = "0x60010B6")]
		[Address(RVA = "0x734836C", Offset = "0x734436C", VA = "0x734836C")]
		public RawFileOperationHandle LoadRawFileAsync(AssetInfo y_0091_00A0K_0096F)
		{
			return null;
		}

		[Token(Token = "0x60010B7")]
		[Address(RVA = "0x7348388", Offset = "0x7344388", VA = "0x7348388")]
		public ResourceDownloaderOperation CreateResourceDownloader(string[] _005BMu_005Eµ_00AF, int _00AC_0083X_009D_00AEp, int _00BD_00B2F_00AF_00B8t, int _00AFF_00BD_0083_0087X = 60)
		{
			return null;
		}

		[Token(Token = "0x60010B8")]
		public AssetOperationHandle LoadAssetAsync<TObject>(string _00B8_007CL_0094_0090l) where TObject : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x60010B9")]
		[Address(RVA = "0x734845C", Offset = "0x734445C", VA = "0x734845C")]
		public ResourceDownloaderOperation CreateBundleDownloader(AssetInfo y_0091_00A0K_0096F, int _00AC_0083X_009D_00AEp, int _00BD_00B2F_00AF_00B8t, int _00AFF_00BD_0083_0087X = 60)
		{
			return null;
		}

		[Token(Token = "0x60010BA")]
		[Address(RVA = "0x734858C", Offset = "0x734458C", VA = "0x734858C")]
		public void DeleteCfg()
		{
		}

		[Token(Token = "0x60010BB")]
		[Address(RVA = "0x7348778", Offset = "0x7344778", VA = "0x7348778")]
		public UpdatePackageVersionOperation UpdatePackageVersionAsync(bool vc_0089_0095_008A_007E = true, int _00AFF_00BD_0083_0087X = 60)
		{
			return null;
		}

		[Token(Token = "0x60010BC")]
		[Address(RVA = "0x7345540", Offset = "0x7341540", VA = "0x7345540")]
		private AssetInfo f_0097q_007D_009F_00A3(string _00B8_007CL_0094_0090l, Type o_00B2cª_0090v)
		{
			return null;
		}

		[Token(Token = "0x60010BD")]
		[Address(RVA = "0x7348834", Offset = "0x7344834", VA = "0x7348834")]
		public ResourceUnpackerOperation _00A8S_0099_00BCC_00BB(string[] _005BMu_005Eµ_00AF, int aªF_00A8_00BF_00BF, int _00BD_00B2F_00AF_00B8t)
		{
			return null;
		}

		[Token(Token = "0x60010BE")]
		[Address(RVA = "0x73488FC", Offset = "0x73448FC", VA = "0x73488FC")]
		public string GetPackageVerDesc()
		{
			return null;
		}

		[Token(Token = "0x60010BF")]
		[Address(RVA = "0x7348A1C", Offset = "0x7344A1C", VA = "0x7348A1C")]
		public string ShowAllABInfoInRuntime()
		{
			return null;
		}

		[Token(Token = "0x60010C0")]
		[Address(RVA = "0x7348A28", Offset = "0x7344A28", VA = "0x7348A28")]
		public AssetInfo aoMN_00B1_0088(string _00B8_007CL_0094_0090l)
		{
			return null;
		}

		[Token(Token = "0x60010C1")]
		[Address(RVA = "0x7348A30", Offset = "0x7344A30", VA = "0x7348A30")]
		public ClearUnusedCacheFilesOperation ClearUnusedCacheFilesAsync()
		{
			return null;
		}

		[Token(Token = "0x60010C2")]
		[Address(RVA = "0x7348AC4", Offset = "0x7344AC4", VA = "0x7348AC4")]
		public AllAssetsOperationHandle LoadAllAssetsSync(AssetInfo y_0091_00A0K_0096F)
		{
			return null;
		}

		[Token(Token = "0x60010C3")]
		[Address(RVA = "0x7348ACC", Offset = "0x7344ACC", VA = "0x7348ACC")]
		public UpdatePackageManifestOperation UpdatePackageManifestAsync(string _00A9gR_0085_00A0m, bool qB_008E_00B0H_009F = true, int _00AFF_00BD_0083_0087X = 60)
		{
			return null;
		}

		[Token(Token = "0x60010C4")]
		[Address(RVA = "0x7348B90", Offset = "0x7344B90", VA = "0x7348B90")]
		private void S_008B_00BD_0086Y_00B7(string _00A3_0092T_007E_00ABc)
		{
		}

		[Token(Token = "0x60010C5")]
		[Address(RVA = "0x7348B98", Offset = "0x7344B98", VA = "0x7348B98")]
		public ResourceUnpackerOperation CreateResourceUnpacker(string N_00BFA_007Ev_00A2, int aªF_00A8_00BF_00BF, int _00BD_00B2F_00AF_00B8t)
		{
			return null;
		}

		[Token(Token = "0x60010C6")]
		[Address(RVA = "0x7348CA0", Offset = "0x7344CA0", VA = "0x7348CA0")]
		[Conditional("DEBUG")]
		private void _005EN_00A9_0083_007Dº(bool Q_00B4Y_009C_007FS = true)
		{
		}

		[Token(Token = "0x60010C7")]
		[Address(RVA = "0x7346FB8", Offset = "0x7342FB8", VA = "0x7346FB8")]
		public AssetInfo GetAssetInfo(string _00B8_007CL_0094_0090l)
		{
			return null;
		}

		[Token(Token = "0x60010C8")]
		[Address(RVA = "0x7348E24", Offset = "0x7344E24", VA = "0x7348E24")]
		public AssetOperationHandle LoadAssetSync(AssetInfo y_0091_00A0K_0096F)
		{
			return null;
		}

		[Token(Token = "0x60010C9")]
		[Address(RVA = "0x7348E2C", Offset = "0x7344E2C", VA = "0x7348E2C")]
		public SubAssetsOperationHandle D_00B3xDsT(string _00B8_007CL_0094_0090l, Type _007BgpR_00A0V)
		{
			return null;
		}

		[Token(Token = "0x60010CA")]
		[Address(RVA = "0x7348E4C", Offset = "0x7344E4C", VA = "0x7348E4C")]
		public SubAssetsOperationHandle LoadSubAssetsSync(string _00B8_007CL_0094_0090l)
		{
			return null;
		}

		[Token(Token = "0x60010CB")]
		[Address(RVA = "0x7348EE8", Offset = "0x7344EE8", VA = "0x7348EE8")]
		private ResourcePackage()
		{
		}

		[Token(Token = "0x60010CC")]
		[Address(RVA = "0x7347130", Offset = "0x7343130", VA = "0x7347130")]
		private AllAssetsOperationHandle g_008Abe_0090_005E(AssetInfo y_0091_00A0K_0096F, bool _007B_0095_0060_008Ax_0096)
		{
			return null;
		}

		[Token(Token = "0x60010CD")]
		[Address(RVA = "0x7348F40", Offset = "0x7344F40", VA = "0x7348F40")]
		public AssetOperationHandle LoadAssetAsync(AssetInfo y_0091_00A0K_0096F)
		{
			return null;
		}

		[Token(Token = "0x60010CE")]
		[Address(RVA = "0x7348F5C", Offset = "0x7344F5C", VA = "0x7348F5C")]
		public int GetIgnoreFileSizeInBuildPackage(string j_0081xY_0088_0088)
		{
			return default;
		}

		[Token(Token = "0x60010CF")]
		[Address(RVA = "0x7348F68", Offset = "0x7344F68", VA = "0x7348F68")]
		public void _00ACU_007E_00BD_007C_007B()
		{
		}

		[Token(Token = "0x60010D0")]
		[Address(RVA = "0x7348F84", Offset = "0x7344F84", VA = "0x7348F84")]
		public SceneOperationHandle LoadSceneAsync(AssetInfo y_0091_00A0K_0096F, LoadSceneMode VEQ_00BF_00BDG = LoadSceneMode.Single, bool _00A7Â_007By_007D_008A = false, int rVlHªB = 100)
		{
			return null;
		}

		[Token(Token = "0x60010D1")]
		public AllAssetsOperationHandle LoadAllAssetsAsync<TObject>(string _00B8_007CL_0094_0090l) where TObject : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x60010D2")]
		[Address(RVA = "0x7348FA4", Offset = "0x7344FA4", VA = "0x7348FA4")]
		public ResourceDownloaderOperation CreateResourceDownloader(int _00AC_0083X_009D_00AEp, int _00BD_00B2F_00AF_00B8t, int _00AFF_00BD_0083_0087X = 60)
		{
			return null;
		}

		[Token(Token = "0x60010D3")]
		[Address(RVA = "0x7349068", Offset = "0x7345068", VA = "0x7349068")]
		public bool IsInPackageBuild(string _0084H_007Fp_0060i, string j_0081xY_0088_0088)
		{
			return default;
		}

		[Token(Token = "0x60010D4")]
		[Address(RVA = "0x73491A8", Offset = "0x73451A8", VA = "0x73491A8")]
		public SubAssetsOperationHandle LoadSubAssetsAsync(string _00B8_007CL_0094_0090l, Type _007BgpR_00A0V)
		{
			return null;
		}

		[Token(Token = "0x60010D5")]
		[Address(RVA = "0x73491D4", Offset = "0x73451D4", VA = "0x73491D4")]
		internal void GÁx_00A7_00A2_00A3()
		{
		}

		[Token(Token = "0x60010D6")]
		public AssetOperationHandle LoadAssetSync<TObject>(string _00B8_007CL_0094_0090l) where TObject : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x60010D7")]
		[Address(RVA = "0x734924C", Offset = "0x734524C", VA = "0x734924C")]
		private SubAssetsOperationHandle g_00A8_009C_00AC_005BE(AssetInfo y_0091_00A0K_0096F, bool _007B_0095_0060_008Ax_0096)
		{
			return null;
		}

		[Token(Token = "0x60010D8")]
		[Address(RVA = "0x7347DB8", Offset = "0x7343DB8", VA = "0x7347DB8")]
		private void _00BEK_0089_007E_00AC_00A4()
		{
		}

		[Token(Token = "0x60010D9")]
		[Address(RVA = "0x7349294", Offset = "0x7345294", VA = "0x7349294")]
		public AssetInfo[] GetAssetInfos(string N_00BFA_007Ev_00A2)
		{
			return null;
		}

		[Token(Token = "0x60010DA")]
		public SubAssetsOperationHandle LoadSubAssetsSync<TObject>(string _00B8_007CL_0094_0090l) where TObject : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x60010DB")]
		[Address(RVA = "0x7349388", Offset = "0x7345388", VA = "0x7349388")]
		public AssetInfo[] GetAssetInfos(string[] _005BMu_005Eµ_00AF)
		{
			return null;
		}

		[Token(Token = "0x60010DC")]
		[Address(RVA = "0x734943C", Offset = "0x734543C", VA = "0x734943C")]
		internal DebugPackageData _007E_0060y_0093bW()
		{
			return null;
		}

		[Token(Token = "0x60010DD")]
		[Address(RVA = "0x73494B8", Offset = "0x73454B8", VA = "0x73494B8")]
		public void e_008B_0094_009BAW()
		{
		}

		[Token(Token = "0x60010DE")]
		[Address(RVA = "0x73494E8", Offset = "0x73454E8", VA = "0x73494E8")]
		public SubAssetsOperationHandle LoadSubAssetsAsync(string _00B8_007CL_0094_0090l)
		{
			return null;
		}

		[Token(Token = "0x60010DF")]
		[Address(RVA = "0x7349590", Offset = "0x7345590", VA = "0x7349590")]
		public void UnloadUnusedAssets()
		{
		}

		[Token(Token = "0x60010E0")]
		[Address(RVA = "0x73495C0", Offset = "0x73455C0", VA = "0x73495C0")]
		public AssetOperationHandle LoadAssetSync(string _00B8_007CL_0094_0090l)
		{
			return null;
		}

		[Token(Token = "0x60010E1")]
		public SubAssetsOperationHandle LoadSubAssetsAsync<TObject>(string _00B8_007CL_0094_0090l) where TObject : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x60010E2")]
		[Address(RVA = "0x734965C", Offset = "0x734565C", VA = "0x734965C")]
		public string GetPackageVersion()
		{
			return null;
		}

		[Token(Token = "0x60010E3")]
		[Address(RVA = "0x734970C", Offset = "0x734570C", VA = "0x734970C")]
		public void ForceUnloadAllAssets()
		{
		}

		[Token(Token = "0x60010E4")]
		[Address(RVA = "0x7349728", Offset = "0x7345728", VA = "0x7349728")]
		public AllAssetsOperationHandle _007EP_00B9_009Dh_008F(string _00B8_007CL_0094_0090l)
		{
			return null;
		}

		[Token(Token = "0x60010E5")]
		[Address(RVA = "0x73497C4", Offset = "0x73457C4", VA = "0x73497C4")]
		public AssetInfo M_008C_00B4_007C_0095_00A1(string _00B8_007CL_0094_0090l)
		{
			return null;
		}
	}
}
