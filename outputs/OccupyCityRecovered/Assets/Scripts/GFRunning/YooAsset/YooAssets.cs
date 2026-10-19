using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

namespace YooAsset
{
	[Token(Token = "0x200013F")]
	public static class YooAssets
	{
		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool _009D_007B_00A4_009F_009DÂ;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static GameObject czUZ_009A_007F;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly List<ResourcePackage> _00AB_005E_0080_0088hk;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Func<string[]> IgnoreFilesHashFunc;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Dictionary<string, string> IgnoreFilesFuncDic;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static bool _00A7Z_00B7z_008F_007F;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static ResourcePackage _00B0R_0060hRl;

		[Token(Token = "0x170000D1")]
		public static bool IsQuitting
		{
			[Token(Token = "0x60011F3")]
			[Address(RVA = "0x73517A8", Offset = "0x734D7A8", VA = "0x73517A8")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x60011F4")]
			[Address(RVA = "0x7351800", Offset = "0x734D800", VA = "0x7351800")]
			private set
			{
				_0083_007By_00A9_00A1s(value);
			}
		}

		[Token(Token = "0x60011F2")]
		[Address(RVA = "0x735174C", Offset = "0x734D74C", VA = "0x735174C")]
		public static void SetCustomerIgnoreFileCRCFunc(Func<string, bool> _0099_00B8_00B9_008A_007C_00A0)
		{
		}

		[Token(Token = "0x60011F4")]
		[Address(RVA = "0x7351800", Offset = "0x734D800", VA = "0x7351800")]
		private static void _0083_007By_00A9_00A1s(bool _00A3_0092T_007E_00ABc)
		{
		}

		[Token(Token = "0x60011F5")]
		[Address(RVA = "0x7351860", Offset = "0x734D860", VA = "0x7351860")]
		private static void N_00ACmEZi()
		{
		}

		[Token(Token = "0x60011F6")]
		[Address(RVA = "0x7351B4C", Offset = "0x734DB4C", VA = "0x7351B4C")]
		public static bool GetIsIgnoreFileHash(string Yº_00AD_00B0_008FO)
		{
			return default;
		}

		[Token(Token = "0x60011F7")]
		[Address(RVA = "0x7351D3C", Offset = "0x734DD3C", VA = "0x7351D3C")]
		public static void Initialize([Optional] ILogger _007F_0093_0083j_00A0Â)
		{
		}

		[Token(Token = "0x60011F8")]
		[Address(RVA = "0x7351FC8", Offset = "0x734DFC8", VA = "0x7351FC8")]
		public static void Destroy()
		{
		}

		[Token(Token = "0x60011F9")]
		[Address(RVA = "0x73522CC", Offset = "0x734E2CC", VA = "0x73522CC")]
		internal static void _007EZ_00A7_008E_0095U()
		{
		}

		[Token(Token = "0x60011FA")]
		[Address(RVA = "0x7352460", Offset = "0x734E460", VA = "0x7352460")]
		public static ResourcePackage CreatePackage(string _008Ffª_008C_007Fi)
		{
			return null;
		}

		[Token(Token = "0x60011FB")]
		[Address(RVA = "0x7352878", Offset = "0x734E878", VA = "0x7352878")]
		public static ResourcePackage GetPackage(string _008Ffª_008C_007Fi)
		{
			return null;
		}

		[Token(Token = "0x60011FC")]
		[Address(RVA = "0x7352904", Offset = "0x734E904", VA = "0x7352904")]
		public static ResourcePackage TryGetPackage(string _008Ffª_008C_007Fi)
		{
			return null;
		}

		[Token(Token = "0x60011FD")]
		[Address(RVA = "0x7352B20", Offset = "0x734EB20", VA = "0x7352B20")]
		public static void DestroyPackage(string _008Ffª_008C_007Fi)
		{
		}

		[Token(Token = "0x60011FE")]
		[Address(RVA = "0x7352678", Offset = "0x734E678", VA = "0x7352678")]
		public static bool HasPackage(string _008Ffª_008C_007Fi)
		{
			return default;
		}

		[Token(Token = "0x60011FF")]
		[Address(RVA = "0x7352C08", Offset = "0x734EC08", VA = "0x7352C08")]
		public static void StartOperation(GameAsyncOperation _008E_0087_00AE_0060f_0095)
		{
		}

		[Token(Token = "0x6001200")]
		[Address(RVA = "0x7352C60", Offset = "0x734EC60", VA = "0x7352C60")]
		public static void SetDownLoadRequesetDelegate(DownloadRequestDelegate P_00A3_00BFÁ_00ABt)
		{
		}

		[Token(Token = "0x6001201")]
		[Address(RVA = "0x7352CBC", Offset = "0x734ECBC", VA = "0x7352CBC")]
		public static void SetDownloadSystemBreakpointResumeFileSize(int _0098_005Di_00B2Q_00BB)
		{
		}

		[Token(Token = "0x6001202")]
		[Address(RVA = "0x7352D48", Offset = "0x734ED48", VA = "0x7352D48")]
		public static void SetDownloadSystemClearFileResponseCode(List<long> _0085_008E_0098_007FFt)
		{
		}

		[Token(Token = "0x6001203")]
		[Address(RVA = "0x7352DD4", Offset = "0x734EDD4", VA = "0x7352DD4")]
		public static void SetDownloadSystemCertificateHandler(CertificateHandler _009Bs_005E_00B4g_0092)
		{
		}

		[Token(Token = "0x6001204")]
		[Address(RVA = "0x7352E30", Offset = "0x734EE30", VA = "0x7352E30")]
		public static void SetDownloadSystemUnityWebRequest(DownloadRequestDelegate µs_00A0g_005B_00BF)
		{
		}

		[Token(Token = "0x6001205")]
		[Address(RVA = "0x7352E8C", Offset = "0x734EE8C", VA = "0x7352E8C")]
		public static void SetDownloadSystemRedirectLimit(int xÀnpZN)
		{
		}

		[Token(Token = "0x6001206")]
		[Address(RVA = "0x7352F78", Offset = "0x734EF78", VA = "0x7352F78")]
		public static void SetOperationSystemMaxTimeSlice(long f_00B9_00BD_0091_0094µ)
		{
		}

		[Token(Token = "0x6001207")]
		[Address(RVA = "0x735302C", Offset = "0x734F02C", VA = "0x735302C")]
		public static void SetCacheSystemCachedFileVerifyLevel(EVerifyLevel k_0093_008C_005DÁ_0088)
		{
		}

		[Token(Token = "0x6001208")]
		[Address(RVA = "0x73530B8", Offset = "0x734F0B8", VA = "0x73530B8")]
		public static void SetCacheSystemDisableCacheOnWebGL()
		{
		}

		[Token(Token = "0x6001209")]
		[Address(RVA = "0x7353114", Offset = "0x734F114", VA = "0x7353114")]
		internal static DebugReport _00A9_007E_00BB_00A2g_0085()
		{
			return null;
		}

		[Token(Token = "0x600120A")]
		[Address(RVA = "0x7353344", Offset = "0x734F344", VA = "0x7353344")]
		public static void SetDefaultPackage(ResourcePackage TC_0083sn_0082)
		{
		}

		[Token(Token = "0x600120B")]
		[Address(RVA = "0x73533A0", Offset = "0x734F3A0", VA = "0x73533A0")]
		public static bool IsNeedDownloadFromRemote(string _00B8_007CL_0094_0090l)
		{
			return default;
		}

		[Token(Token = "0x600120C")]
		[Address(RVA = "0x735340C", Offset = "0x734F40C", VA = "0x735340C")]
		public static bool IsNeedDownloadFromRemote(AssetInfo y_0091_00A0K_0096F)
		{
			return default;
		}

		[Token(Token = "0x600120D")]
		[Address(RVA = "0x7353478", Offset = "0x734F478", VA = "0x7353478")]
		public static AssetInfo[] GetAssetInfos(string N_00BFA_007Ev_00A2)
		{
			return null;
		}

		[Token(Token = "0x600120E")]
		[Address(RVA = "0x73534E4", Offset = "0x734F4E4", VA = "0x73534E4")]
		public static AssetInfo[] GetAssetInfos(string[] _005BMu_005Eµ_00AF)
		{
			return null;
		}

		[Token(Token = "0x600120F")]
		[Address(RVA = "0x7353550", Offset = "0x734F550", VA = "0x7353550")]
		public static AssetInfo GetAssetInfo(string _00B8_007CL_0094_0090l)
		{
			return null;
		}

		[Token(Token = "0x6001210")]
		[Address(RVA = "0x73535BC", Offset = "0x734F5BC", VA = "0x73535BC")]
		public static bool CheckLocationValid(string _00B8_007CL_0094_0090l)
		{
			return default;
		}

		[Token(Token = "0x6001211")]
		[Address(RVA = "0x7353628", Offset = "0x734F628", VA = "0x7353628")]
		public static RawFileOperationHandle LoadRawFileSync(AssetInfo y_0091_00A0K_0096F)
		{
			return null;
		}

		[Token(Token = "0x6001212")]
		[Address(RVA = "0x7353694", Offset = "0x734F694", VA = "0x7353694")]
		public static RawFileOperationHandle LoadRawFileSync(string _00B8_007CL_0094_0090l)
		{
			return null;
		}

		[Token(Token = "0x6001213")]
		[Address(RVA = "0x7353700", Offset = "0x734F700", VA = "0x7353700")]
		public static RawFileOperationHandle LoadRawFileAsync(AssetInfo y_0091_00A0K_0096F)
		{
			return null;
		}

		[Token(Token = "0x6001214")]
		[Address(RVA = "0x735376C", Offset = "0x734F76C", VA = "0x735376C")]
		public static RawFileOperationHandle LoadRawFileAsync(string _00B8_007CL_0094_0090l)
		{
			return null;
		}

		[Token(Token = "0x6001215")]
		[Address(RVA = "0x73537D8", Offset = "0x734F7D8", VA = "0x73537D8")]
		public static SceneOperationHandle LoadSceneAsync(string _00B8_007CL_0094_0090l, LoadSceneMode VEQ_00BF_00BDG = LoadSceneMode.Single, bool _00A7Â_007By_007D_008A = false, int rVlHªB = 100)
		{
			return null;
		}

		[Token(Token = "0x6001216")]
		[Address(RVA = "0x735386C", Offset = "0x734F86C", VA = "0x735386C")]
		public static SceneOperationHandle LoadSceneAsync(AssetInfo y_0091_00A0K_0096F, LoadSceneMode VEQ_00BF_00BDG = LoadSceneMode.Single, bool _00A7Â_007By_007D_008A = false, int rVlHªB = 100)
		{
			return null;
		}

		[Token(Token = "0x6001217")]
		[Address(RVA = "0x7353900", Offset = "0x734F900", VA = "0x7353900")]
		public static AssetOperationHandle LoadAssetSync(AssetInfo y_0091_00A0K_0096F)
		{
			return null;
		}

		[Token(Token = "0x6001218")]
		public static AssetOperationHandle LoadAssetSync<TObject>(string _00B8_007CL_0094_0090l) where TObject : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x6001219")]
		[Address(RVA = "0x735396C", Offset = "0x734F96C", VA = "0x735396C")]
		public static AssetOperationHandle LoadAssetSync(string _00B8_007CL_0094_0090l, Type _007BgpR_00A0V)
		{
			return null;
		}

		[Token(Token = "0x600121A")]
		[Address(RVA = "0x73539E8", Offset = "0x734F9E8", VA = "0x73539E8")]
		public static AssetOperationHandle LoadAssetAsync(AssetInfo y_0091_00A0K_0096F)
		{
			return null;
		}

		[Token(Token = "0x600121B")]
		public static AssetOperationHandle LoadAssetAsync<TObject>(string _00B8_007CL_0094_0090l) where TObject : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x600121C")]
		[Address(RVA = "0x7353A54", Offset = "0x734FA54", VA = "0x7353A54")]
		public static AssetOperationHandle LoadAssetAsync(string _00B8_007CL_0094_0090l, Type _007BgpR_00A0V)
		{
			return null;
		}

		[Token(Token = "0x600121D")]
		[Address(RVA = "0x7353AD0", Offset = "0x734FAD0", VA = "0x7353AD0")]
		public static SubAssetsOperationHandle LoadSubAssetsSync(AssetInfo y_0091_00A0K_0096F)
		{
			return null;
		}

		[Token(Token = "0x600121E")]
		public static SubAssetsOperationHandle LoadSubAssetsSync<TObject>(string _00B8_007CL_0094_0090l) where TObject : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x600121F")]
		[Address(RVA = "0x7353B3C", Offset = "0x734FB3C", VA = "0x7353B3C")]
		public static SubAssetsOperationHandle LoadSubAssetsSync(string _00B8_007CL_0094_0090l, Type _007BgpR_00A0V)
		{
			return null;
		}

		[Token(Token = "0x6001220")]
		[Address(RVA = "0x7353BB8", Offset = "0x734FBB8", VA = "0x7353BB8")]
		public static SubAssetsOperationHandle LoadSubAssetsAsync(AssetInfo y_0091_00A0K_0096F)
		{
			return null;
		}

		[Token(Token = "0x6001221")]
		public static SubAssetsOperationHandle LoadSubAssetsAsync<TObject>(string _00B8_007CL_0094_0090l) where TObject : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x6001222")]
		[Address(RVA = "0x7353C24", Offset = "0x734FC24", VA = "0x7353C24")]
		public static SubAssetsOperationHandle LoadSubAssetsAsync(string _00B8_007CL_0094_0090l, Type _007BgpR_00A0V)
		{
			return null;
		}

		[Token(Token = "0x6001223")]
		[Address(RVA = "0x7353CA0", Offset = "0x734FCA0", VA = "0x7353CA0")]
		public static AllAssetsOperationHandle LoadAllAssetsSync(AssetInfo y_0091_00A0K_0096F)
		{
			return null;
		}

		[Token(Token = "0x6001224")]
		public static AllAssetsOperationHandle LoadAllAssetsSync<TObject>(string _00B8_007CL_0094_0090l) where TObject : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x6001225")]
		[Address(RVA = "0x7353D0C", Offset = "0x734FD0C", VA = "0x7353D0C")]
		public static AllAssetsOperationHandle LoadAllAssetsSync(string _00B8_007CL_0094_0090l, Type _007BgpR_00A0V)
		{
			return null;
		}

		[Token(Token = "0x6001226")]
		[Address(RVA = "0x7353D88", Offset = "0x734FD88", VA = "0x7353D88")]
		public static AllAssetsOperationHandle LoadAllAssetsAsync(AssetInfo y_0091_00A0K_0096F)
		{
			return null;
		}

		[Token(Token = "0x6001227")]
		public static AllAssetsOperationHandle LoadAllAssetsAsync<TObject>(string _00B8_007CL_0094_0090l) where TObject : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x6001228")]
		[Address(RVA = "0x7353DF4", Offset = "0x734FDF4", VA = "0x7353DF4")]
		public static AllAssetsOperationHandle LoadAllAssetsAsync(string _00B8_007CL_0094_0090l, Type _007BgpR_00A0V)
		{
			return null;
		}

		[Token(Token = "0x6001229")]
		[Address(RVA = "0x7353E70", Offset = "0x734FE70", VA = "0x7353E70")]
		public static ResourceDownloaderOperation CreateResourceDownloader(int _00AC_0083X_009D_00AEp, int _00BD_00B2F_00AF_00B8t)
		{
			return null;
		}

		[Token(Token = "0x600122A")]
		[Address(RVA = "0x7353EF0", Offset = "0x734FEF0", VA = "0x7353EF0")]
		public static ResourceDownloaderOperation CreateResourceDownloader(string N_00BFA_007Ev_00A2, int _00AC_0083X_009D_00AEp, int _00BD_00B2F_00AF_00B8t)
		{
			return null;
		}

		[Token(Token = "0x600122B")]
		[Address(RVA = "0x7353FB0", Offset = "0x734FFB0", VA = "0x7353FB0")]
		public static ResourceDownloaderOperation CreateResourceDownloader(string[] _005BMu_005Eµ_00AF, int _00AC_0083X_009D_00AEp, int _00BD_00B2F_00AF_00B8t)
		{
			return null;
		}

		[Token(Token = "0x600122C")]
		[Address(RVA = "0x7354038", Offset = "0x7350038", VA = "0x7354038")]
		public static ResourceDownloaderOperation CreateBundleDownloader(string _00B8_007CL_0094_0090l, int _00AC_0083X_009D_00AEp, int _00BD_00B2F_00AF_00B8t)
		{
			return null;
		}

		[Token(Token = "0x600122D")]
		[Address(RVA = "0x73540C0", Offset = "0x73500C0", VA = "0x73540C0")]
		public static ResourceDownloaderOperation CreateBundleDownloader(string[] nG_009B_0083_00B2H, int _00AC_0083X_009D_00AEp, int _00BD_00B2F_00AF_00B8t)
		{
			return null;
		}

		[Token(Token = "0x600122E")]
		[Address(RVA = "0x7354148", Offset = "0x7350148", VA = "0x7354148")]
		public static ResourceDownloaderOperation CreateBundleDownloader(AssetInfo y_0091_00A0K_0096F, int _00AC_0083X_009D_00AEp, int _00BD_00B2F_00AF_00B8t)
		{
			return null;
		}

		[Token(Token = "0x600122F")]
		[Address(RVA = "0x73541D0", Offset = "0x73501D0", VA = "0x73541D0")]
		public static ResourceDownloaderOperation CreateBundleDownloader(AssetInfo[] _00BBV_00B8CwÀ, int _00AC_0083X_009D_00AEp, int _00BD_00B2F_00AF_00B8t)
		{
			return null;
		}

		[Token(Token = "0x6001230")]
		[Address(RVA = "0x7354258", Offset = "0x7350258", VA = "0x7354258")]
		public static ResourceUnpackerOperation CreateResourceUnpacker(string N_00BFA_007Ev_00A2, int aªF_00A8_00BF_00BF, int _00BD_00B2F_00AF_00B8t)
		{
			return null;
		}

		[Token(Token = "0x6001231")]
		[Address(RVA = "0x73542DC", Offset = "0x73502DC", VA = "0x73542DC")]
		public static ResourceUnpackerOperation CreateResourceUnpacker(string[] _005BMu_005Eµ_00AF, int aªF_00A8_00BF_00BF, int _00BD_00B2F_00AF_00B8t)
		{
			return null;
		}

		[Token(Token = "0x6001232")]
		[Address(RVA = "0x7354360", Offset = "0x7350360", VA = "0x7354360")]
		public static ResourceUnpackerOperation CreateResourceUnpacker(int aªF_00A8_00BF_00BF, int _00BD_00B2F_00AF_00B8t)
		{
			return null;
		}

		[Token(Token = "0x6001233")]
		[Address(RVA = "0x73543DC", Offset = "0x73503DC", VA = "0x73543DC")]
		[Conditional("DEBUG")]
		private static void o_00BEc_00B0_0092H()
		{
		}
	}
}
