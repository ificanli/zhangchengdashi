using System;
using System.IO;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Scripting;

namespace GameFramework
{
	[Token(Token = "0x20003EE")]
	[Preserve]
	public static class AssetBundleHelper
	{
		[Token(Token = "0x20003EF")]
		private enum O_0060rB_0084W
		{
			[Token(Token = "0x4001CE9")]
			DirectAes = 0,
			[Token(Token = "0x4001CEA")]
			ReverseAes = 1,
			[Token(Token = "0x4001CEB")]
			MaskedAes = 2,
			[Token(Token = "0x4001CEC")]
			RotatedAes = 3,
			[Token(Token = "0x4001CED")]
			SwappedAes = 4,
			[Token(Token = "0x4001CEE")]
			MirroredAes = 5,
			[Token(Token = "0x4001CEF")]
			AdditiveAes = 6,
			[Token(Token = "0x4001CF0")]
			DeltaAes = 7,
			[Token(Token = "0x4001CF1")]
			NibbleAes = 8,
			[Token(Token = "0x4001CF2")]
			ReservedAes = 9
		}

		[Token(Token = "0x20003F0")]
		private enum _009Fgt_0088C_0086
		{
			[Token(Token = "0x4001CF4")]
			Game = 0,
			[Token(Token = "0x4001CF5")]
			Raw = 1,
			[Token(Token = "0x4001CF6")]
			Extra = 2,
			[Token(Token = "0x4001CF7")]
			Remote = 3,
			[Token(Token = "0x4001CF8")]
			Buildin = 4,
			[Token(Token = "0x4001CF9")]
			Fallback = 5
		}

		[Token(Token = "0x20003F1")]
		private readonly struct _0088_0088_00BD_00BBH_0088
		{
			[Token(Token = "0x4001CFA")]
			[FieldOffset(Offset = "0x0")]
			private readonly int _0086I_009F_0090_005D_00B1;

			[Token(Token = "0x4001CFB")]
			[FieldOffset(Offset = "0x4")]
			private readonly int _00A4a_00A5_00ACT_008B;

			[Token(Token = "0x4001CFC")]
			[FieldOffset(Offset = "0x8")]
			private readonly ulong _0095Z_007B_009CYB;

			[Token(Token = "0x17001173")]
			internal int _00BE_00B9R_005B_00AEc
			{
				[Token(Token = "0x6006138")]
				[Address(RVA = "0x71F293C", Offset = "0x71EE93C", VA = "0x71F293C")]
				get
				{
					return LnF_007C_0090M();
				}
			}

			[Token(Token = "0x17001174")]
			internal int N_009E_0097B_0083j
			{
				[Token(Token = "0x600613F")]
				[Address(RVA = "0x71F2974", Offset = "0x71EE974", VA = "0x71F2974")]
				get
				{
					return _00A6_009ECjBk();
				}
			}

			[Token(Token = "0x17001175")]
			internal ulong Eq_0089_00BC_00B3_00BE
			{
				[Token(Token = "0x6006131")]
				[Address(RVA = "0x71F2904", Offset = "0x71EE904", VA = "0x71F2904")]
				get
				{
					return _00BE_007BlI_007Eµ();
				}
			}

			[SpecialName]
			[Token(Token = "0x6006125")]
			[Address(RVA = "0x71F28A4", Offset = "0x71EE8A4", VA = "0x71F28A4")]
			internal ulong QR_0096_00BC_0082o()
			{
				return default;
			}

			[SpecialName]
			[Token(Token = "0x6006126")]
			[Address(RVA = "0x71F28AC", Offset = "0x71EE8AC", VA = "0x71F28AC")]
			internal ulong D_0091b_0097_0087_0090()
			{
				return default;
			}

			[SpecialName]
			[Token(Token = "0x6006127")]
			[Address(RVA = "0x71F28B4", Offset = "0x71EE8B4", VA = "0x71F28B4")]
			internal int j_00A3_00B1_00B9Vv()
			{
				return default;
			}

			[SpecialName]
			[Token(Token = "0x6006128")]
			[Address(RVA = "0x71F28BC", Offset = "0x71EE8BC", VA = "0x71F28BC")]
			internal ulong _007E_00A7_0081Lµ_0091()
			{
				return default;
			}

			[SpecialName]
			[Token(Token = "0x6006129")]
			[Address(RVA = "0x71F28C4", Offset = "0x71EE8C4", VA = "0x71F28C4")]
			internal int ZR_00BCºe_0095()
			{
				return default;
			}

			[SpecialName]
			[Token(Token = "0x600612A")]
			[Address(RVA = "0x71F28CC", Offset = "0x71EE8CC", VA = "0x71F28CC")]
			internal ulong _00B2h_0089_00A6qF()
			{
				return default;
			}

			[SpecialName]
			[Token(Token = "0x600612B")]
			[Address(RVA = "0x71F28D4", Offset = "0x71EE8D4", VA = "0x71F28D4")]
			internal int _007C_00BD_00A0_009C_0060H()
			{
				return default;
			}

			[SpecialName]
			[Token(Token = "0x600612C")]
			[Address(RVA = "0x71F28DC", Offset = "0x71EE8DC", VA = "0x71F28DC")]
			internal ulong _00B1G_009E_00B8i_00B2()
			{
				return default;
			}

			[SpecialName]
			[Token(Token = "0x600612D")]
			[Address(RVA = "0x71F28E4", Offset = "0x71EE8E4", VA = "0x71F28E4")]
			internal int _0090_00B2_00B2_00A6_005D_0097()
			{
				return default;
			}

			[SpecialName]
			[Token(Token = "0x600612E")]
			[Address(RVA = "0x71F28EC", Offset = "0x71EE8EC", VA = "0x71F28EC")]
			internal int _00A3_007Eh_005B_008AS()
			{
				return default;
			}

			[SpecialName]
			[Token(Token = "0x600612F")]
			[Address(RVA = "0x71F28F4", Offset = "0x71EE8F4", VA = "0x71F28F4")]
			internal int _0060_00A9tnq_00B8()
			{
				return default;
			}

			[SpecialName]
			[Token(Token = "0x6006130")]
			[Address(RVA = "0x71F28FC", Offset = "0x71EE8FC", VA = "0x71F28FC")]
			internal int _00ADl_00ABR_00B4_009F()
			{
				return default;
			}

			[Token(Token = "0x6006131")]
			[Address(RVA = "0x71F2904", Offset = "0x71EE904", VA = "0x71F2904")]
			internal ulong _00BE_007BlI_007Eµ()
			{
				return default;
			}

			[SpecialName]
			[Token(Token = "0x6006132")]
			[Address(RVA = "0x71F290C", Offset = "0x71EE90C", VA = "0x71F290C")]
			internal int t_0082_0080tJV()
			{
				return default;
			}

			[SpecialName]
			[Token(Token = "0x6006133")]
			[Address(RVA = "0x71F2914", Offset = "0x71EE914", VA = "0x71F2914")]
			internal int Á_0099Ui_008B_005D()
			{
				return default;
			}

			[SpecialName]
			[Token(Token = "0x6006134")]
			[Address(RVA = "0x71F291C", Offset = "0x71EE91C", VA = "0x71F291C")]
			internal int _00A8_007EIiKt()
			{
				return default;
			}

			[SpecialName]
			[Token(Token = "0x6006135")]
			[Address(RVA = "0x71F2924", Offset = "0x71EE924", VA = "0x71F2924")]
			internal int _008B_008Fº_0084_0095_0096()
			{
				return default;
			}

			[SpecialName]
			[Token(Token = "0x6006136")]
			[Address(RVA = "0x71F292C", Offset = "0x71EE92C", VA = "0x71F292C")]
			internal int bv_00B6_00A8ªl()
			{
				return default;
			}

			[SpecialName]
			[Token(Token = "0x6006137")]
			[Address(RVA = "0x71F2934", Offset = "0x71EE934", VA = "0x71F2934")]
			internal ulong _007C_0087z_00B1Q_00A0()
			{
				return default;
			}

			[Token(Token = "0x6006138")]
			[Address(RVA = "0x71F293C", Offset = "0x71EE93C", VA = "0x71F293C")]
			internal int LnF_007C_0090M()
			{
				return default;
			}

			[SpecialName]
			[Token(Token = "0x6006139")]
			[Address(RVA = "0x71F2944", Offset = "0x71EE944", VA = "0x71F2944")]
			internal ulong hc_007D_0097nR()
			{
				return default;
			}

			[SpecialName]
			[Token(Token = "0x600613A")]
			[Address(RVA = "0x71F294C", Offset = "0x71EE94C", VA = "0x71F294C")]
			internal int l_0087NuaS()
			{
				return default;
			}

			[SpecialName]
			[Token(Token = "0x600613B")]
			[Address(RVA = "0x71F2954", Offset = "0x71EE954", VA = "0x71F2954")]
			internal int h_00AE_009CJA_00AD()
			{
				return default;
			}

			[SpecialName]
			[Token(Token = "0x600613C")]
			[Address(RVA = "0x71F295C", Offset = "0x71EE95C", VA = "0x71F295C")]
			internal int UJ_00A3_0099G_009F()
			{
				return default;
			}

			[SpecialName]
			[Token(Token = "0x600613D")]
			[Address(RVA = "0x71F2964", Offset = "0x71EE964", VA = "0x71F2964")]
			internal int _007C_00BE_00BE_0096wv()
			{
				return default;
			}

			[SpecialName]
			[Token(Token = "0x600613E")]
			[Address(RVA = "0x71F296C", Offset = "0x71EE96C", VA = "0x71F296C")]
			internal int _0060PrV_009D_00B7()
			{
				return default;
			}

			[Token(Token = "0x600613F")]
			[Address(RVA = "0x71F2974", Offset = "0x71EE974", VA = "0x71F2974")]
			internal int _00A6_009ECjBk()
			{
				return default;
			}

			[SpecialName]
			[Token(Token = "0x6006140")]
			[Address(RVA = "0x71F297C", Offset = "0x71EE97C", VA = "0x71F297C")]
			internal int RSj_009BNs()
			{
				return default;
			}

			[SpecialName]
			[Token(Token = "0x6006141")]
			[Address(RVA = "0x71F2984", Offset = "0x71EE984", VA = "0x71F2984")]
			internal int _008Fv_0080_00B1_00ADZ()
			{
				return default;
			}

			[SpecialName]
			[Token(Token = "0x6006142")]
			[Address(RVA = "0x71F298C", Offset = "0x71EE98C", VA = "0x71F298C")]
			internal int ZG_00A9ez_009D()
			{
				return default;
			}

			[SpecialName]
			[Token(Token = "0x6006143")]
			[Address(RVA = "0x71F2994", Offset = "0x71EE994", VA = "0x71F2994")]
			internal ulong K_00BC_0082_0086_0086_0089()
			{
				return default;
			}

			[SpecialName]
			[Token(Token = "0x6006144")]
			[Address(RVA = "0x71F299C", Offset = "0x71EE99C", VA = "0x71F299C")]
			internal ulong pC_00B8cÀ_00B0()
			{
				return default;
			}

			[SpecialName]
			[Token(Token = "0x6006145")]
			[Address(RVA = "0x71F29A4", Offset = "0x71EE9A4", VA = "0x71F29A4")]
			internal int P_0081t_008D_0081_007B()
			{
				return default;
			}

			[Token(Token = "0x6006146")]
			[Address(RVA = "0x71F29AC", Offset = "0x71EE9AC", VA = "0x71F29AC")]
			internal _0088_0088_00BD_00BBH_0088(int LGg_0083_007EK, int _0081H_0086Mt_00A7, ulong e_00A7_0098_00BFD_0094)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED AssetBundleHelper._0088_0088_00BD_00BBH_0088..ctor RVA=0x71F29AC Token=0x6006146");
}

			[SpecialName]
			[Token(Token = "0x6006147")]
			[Address(RVA = "0x71F29B8", Offset = "0x71EE9B8", VA = "0x71F29B8")]
			internal int _0098_00A1_0083_00B1_00B0_008B()
			{
				return default;
			}

			[SpecialName]
			[Token(Token = "0x6006148")]
			[Address(RVA = "0x71F29C0", Offset = "0x71EE9C0", VA = "0x71F29C0")]
			internal ulong n_00BE_009Aa_00BB_009F()
			{
				return default;
			}

			[SpecialName]
			[Token(Token = "0x6006149")]
			[Address(RVA = "0x71F29C8", Offset = "0x71EE9C8", VA = "0x71F29C8")]
			internal ulong _00B2_0060_008F_0092A_005D()
			{
				return default;
			}

			[SpecialName]
			[Token(Token = "0x600614A")]
			[Address(RVA = "0x71F29D0", Offset = "0x71EE9D0", VA = "0x71F29D0")]
			internal ulong _00A0_008BM_00BE_0089_0096()
			{
				return default;
			}

			[SpecialName]
			[Token(Token = "0x600614B")]
			[Address(RVA = "0x71F29D8", Offset = "0x71EE9D8", VA = "0x71F29D8")]
			internal int HY_005E_005B_007B_00BD()
			{
				return default;
			}

			[SpecialName]
			[Token(Token = "0x600614C")]
			[Address(RVA = "0x71F29E0", Offset = "0x71EE9E0", VA = "0x71F29E0")]
			internal int _00A8_00A5Y_005EH_00B1()
			{
				return default;
			}

			[SpecialName]
			[Token(Token = "0x600614D")]
			[Address(RVA = "0x71F29E8", Offset = "0x71EE9E8", VA = "0x71F29E8")]
			internal ulong ÁZ_009F_007ESx()
			{
				return default;
			}

			[SpecialName]
			[Token(Token = "0x600614E")]
			[Address(RVA = "0x71F29F0", Offset = "0x71EE9F0", VA = "0x71F29F0")]
			internal int w_00A3ªw_00ADv()
			{
				return default;
			}

			[SpecialName]
			[Token(Token = "0x600614F")]
			[Address(RVA = "0x71F29F8", Offset = "0x71EE9F8", VA = "0x71F29F8")]
			internal int ljÀZf_00A7()
			{
				return default;
			}
		}

		[Token(Token = "0x20003F2")]
		[Preserve]
		internal static class AssetBundleServices
		{
			[Token(Token = "0x4001CFD")]
			[FieldOffset(Offset = "0x0")]
			private static Func<byte[], string, byte[]> JFkz_008A_0089;

			[Token(Token = "0x4001CFE")]
			[FieldOffset(Offset = "0x8")]
			private static Func<byte[], string, byte[]> jvEe_008A_0094;

			[Token(Token = "0x4001CFF")]
			[FieldOffset(Offset = "0x10")]
			private static Func<string, byte[], bool> GµmX_00B6_007F;

			[Token(Token = "0x4001D00")]
			[FieldOffset(Offset = "0x18")]
			private static Func<string> M_009A_00A8_0086ra;

			[Token(Token = "0x4001D01")]
			[FieldOffset(Offset = "0x20")]
			private static Delegate[] _0092N_00B4_00B6dº;

			[Token(Token = "0x4001D02")]
			[FieldOffset(Offset = "0x28")]
			private static Type[] G_00BE_00A0_007FRu;

			[Token(Token = "0x6006150")]
			[Address(RVA = "0x71F2A00", Offset = "0x71EEA00", VA = "0x71F2A00")]
			[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
			[Preserve]
			private static void Initialize()
			{
			}
		}

		[Token(Token = "0x20003F3")]
		[Preserve]
		internal static class zlX_00A4µ_009B
		{
			[Token(Token = "0x4001D03")]
			private const int xj_00AFºp_0096 = 1048576;

			[Token(Token = "0x4001D04")]
			private const int ÀR_00BF_00ACqW = 24;

			[Token(Token = "0x6006151")]
			[Address(RVA = "0x71F3790", Offset = "0x71EF790", VA = "0x71F3790")]
			[Preserve]
			internal static AssetBundle _0098_009BÀ_005B_0098S(string _00B6_0082TS_00BDI, string j_0081xY_0088_0088, int LGg_0083_007EK, int _0081H_0086Mt_00A7, ulong e_00A7_0098_00BFD_0094 = 0uL)
			{
				return null;
			}

			[Token(Token = "0x6006152")]
			[Address(RVA = "0x71F3CB8", Offset = "0x71EFCB8", VA = "0x71F3CB8")]
			[Preserve]
			internal static AssetBundle _0083hF_0091_00A8_008E(string _009CxC_00A0_0060_00A8, byte[] _009F_0080_005B_009F_0086_0089, string j_0081xY_0088_0088, int LGg_0083_007EK, int _0081H_0086Mt_00A7)
			{
				return null;
			}

			[Token(Token = "0x6006153")]
			[Address(RVA = "0x71F3D40", Offset = "0x71EFD40", VA = "0x71F3D40")]
			[Preserve]
			internal static AssetBundle _009D_00BB_00A4_00AF_009F_007D(string _009CxC_00A0_0060_00A8, Stream _007D_0091_00ACS_00BF_009F, string j_0081xY_0088_0088, int LGg_0083_007EK, int _0081H_0086Mt_00A7)
			{
				return null;
			}

			[Token(Token = "0x6006154")]
			[Address(RVA = "0x71F3BB4", Offset = "0x71EFBB4", VA = "0x71F3BB4")]
			private static byte[] H_00ACµKG_0099(string _009CxC_00A0_0060_00A8, string j_0081xY_0088_0088, byte[] _0081C_0082m_00A4G, int LGg_0083_007EK, int _0081H_0086Mt_00A7)
			{
				return null;
			}

			[Token(Token = "0x6006155")]
			[Address(RVA = "0x71F3A60", Offset = "0x71EFA60", VA = "0x71F3A60")]
			private static string _007B_008BxZm_007C(string _009CxC_00A0_0060_00A8, string j_0081xY_0088_0088, string _00B2_008C_00A8BcG)
			{
				return null;
			}

			[Token(Token = "0x6006156")]
			[Address(RVA = "0x71F40C0", Offset = "0x71F00C0", VA = "0x71F40C0")]
			private static byte[] _00A8J_008B_00BC_005E_00A7(string _009CxC_00A0_0060_00A8, string j_0081xY_0088_0088, byte[] _0081C_0082m_00A4G)
			{
				return null;
			}

			[Token(Token = "0x6006157")]
			[Address(RVA = "0x71F42A8", Offset = "0x71F02A8", VA = "0x71F42A8")]
			private static byte[] _008CÂ_005DeY_00A5(string _009CxC_00A0_0060_00A8, string j_0081xY_0088_0088, byte[] VVx_0088_005Dr, int _0081H_0086Mt_00A7)
			{
				return null;
			}

			[Token(Token = "0x6006158")]
			[Address(RVA = "0x71F4650", Offset = "0x71F0650", VA = "0x71F4650")]
			private static byte[] ºÂD_0097kº(string _009CxC_00A0_0060_00A8, string j_0081xY_0088_0088, byte[] µm_00BB_00A0_0080k, int LGg_0083_007EK, int _0081H_0086Mt_00A7)
			{
				return null;
			}

			[Token(Token = "0x6006159")]
			[Address(RVA = "0x71F49B0", Offset = "0x71F09B0", VA = "0x71F49B0")]
			private static byte[] Âr_00B1_00AB_008E_00A8(string _009CxC_00A0_0060_00A8, string j_0081xY_0088_0088, byte[] VVx_0088_005Dr, byte[] Ki_00A9_0091Y_00BB, int _0081H_0086Mt_00A7)
			{
				return null;
			}

			[Token(Token = "0x600615A")]
			[Address(RVA = "0x71F4C5C", Offset = "0x71F0C5C", VA = "0x71F4C5C")]
			private static byte[] p_00BE_00AB_009DKl(string _009CxC_00A0_0060_00A8, string j_0081xY_0088_0088, byte[] _008Eg_007C_00BF_0095_0085, byte[] µm_00BB_00A0_0080k)
			{
				return null;
			}

			[Token(Token = "0x600615B")]
			[Address(RVA = "0x71F4F4C", Offset = "0x71F0F4C", VA = "0x71F4F4C")]
			private static byte[] _00B1_009Ek_00A2pA(byte[] KOz_0086_009Fn, byte[] Y_00A1E_0099_00ACD, byte[] _0086F_00B6_0092Mr)
			{
				return null;
			}

			[Token(Token = "0x600615C")]
			[Address(RVA = "0x71F50E8", Offset = "0x71F10E8", VA = "0x71F50E8")]
			private static void s_0087X_0094_00A2c(byte[] a_009Cy_00AE_00BDf, byte[] _0081À_00BC_0097_00A9_00B3, int _0080_009A_00AElX_00BC, int _0086F_00B6_0092Mr)
			{
			}

			[Token(Token = "0x600615D")]
			[Address(RVA = "0x71F5310", Offset = "0x71F1310", VA = "0x71F5310")]
			private static byte[] C_008D_00AF_00B0i_00BD(byte[][] RV_0060_0081_009D_005B, byte[] µm_00BB_00A0_0080k)
			{
				return null;
			}

			[Token(Token = "0x600615E")]
			[Address(RVA = "0x71F51E0", Offset = "0x71F11E0", VA = "0x71F51E0")]
			private static byte[] mg_0096zº_00BB(byte[] _0088I_0098_0080_00A5_009F, byte[] E_00ABKb_00BD_0086, int _00BEHAM_0091_0089)
			{
				return null;
			}

			[Token(Token = "0x600615F")]
			[Address(RVA = "0x71F5534", Offset = "0x71F1534", VA = "0x71F5534")]
			private static byte[] _009C_00AC_00BB_008E_0090_00BF(byte[] _0081C_0082m_00A4G, int wv_00B4_0091dh)
			{
				return null;
			}

			[Token(Token = "0x6006160")]
			[Address(RVA = "0x71F3E54", Offset = "0x71EFE54", VA = "0x71F3E54")]
			private static byte[] _00A0_00A5p_00A7Jt(Stream _007D_0091_00ACS_00BF_009F)
			{
				return null;
			}

			[Token(Token = "0x6006161")]
			[Address(RVA = "0x71F55EC", Offset = "0x71F15EC", VA = "0x71F55EC")]
			private static void _0082P_00A8MxH(string P_0084c_007DÀ_00A3)
			{
			}
		}

		[Token(Token = "0x20003F4")]
		[Preserve]
		internal static class _0096myru_00BB
		{
			[Token(Token = "0x6006162")]
			[Address(RVA = "0x71F569C", Offset = "0x71F169C", VA = "0x71F569C")]
			[Preserve]
			internal static AssetBundle _0098_009BÀ_005B_0098S(string _00B6_0082TS_00BDI, string j_0081xY_0088_0088)
			{
				return null;
			}

			[Token(Token = "0x6006163")]
			[Address(RVA = "0x71F5718", Offset = "0x71F1718", VA = "0x71F5718")]
			[Preserve]
			internal static AssetBundle _0083hF_0091_00A8_008E(byte[] _009F_0080_005B_009F_0086_0089, string j_0081xY_0088_0088)
			{
				return null;
			}

			[Token(Token = "0x6006164")]
			[Address(RVA = "0x71F57D8", Offset = "0x71F17D8", VA = "0x71F57D8")]
			[Preserve]
			internal static AssetBundle _009D_00BB_00A4_00AF_009F_007D(Stream _007D_0091_00ACS_00BF_009F, string j_0081xY_0088_0088)
			{
				return null;
			}
		}

		[Token(Token = "0x20003F5")]
		[Preserve]
		internal static class _009FjIx_009FK
		{
			[Token(Token = "0x6006165")]
			[Address(RVA = "0x71F5898", Offset = "0x71F1898", VA = "0x71F5898")]
			[Preserve]
			internal static AssetBundle _0098_009BÀ_005B_0098S(string _00B6_0082TS_00BDI, string j_0081xY_0088_0088)
			{
				return null;
			}

			[Token(Token = "0x6006166")]
			[Address(RVA = "0x71F5914", Offset = "0x71F1914", VA = "0x71F5914")]
			[Preserve]
			internal static AssetBundle _0083hF_0091_00A8_008E(byte[] _009F_0080_005B_009F_0086_0089, string j_0081xY_0088_0088)
			{
				return null;
			}

			[Token(Token = "0x6006167")]
			[Address(RVA = "0x71F59D4", Offset = "0x71F19D4", VA = "0x71F59D4")]
			[Preserve]
			internal static AssetBundle _009D_00BB_00A4_00AF_009F_007D(Stream _007D_0091_00ACS_00BF_009F, string j_0081xY_0088_0088)
			{
				return null;
			}
		}

		[Token(Token = "0x20003F6")]
		[Preserve]
		internal static class º_00B1_0093_00A6_008B_007B
		{
			[Token(Token = "0x6006168")]
			[Address(RVA = "0x71F5A94", Offset = "0x71F1A94", VA = "0x71F5A94")]
			[Preserve]
			internal static AssetBundle _0098_009BÀ_005B_0098S(string _00B6_0082TS_00BDI, string j_0081xY_0088_0088)
			{
				return null;
			}

			[Token(Token = "0x6006169")]
			[Address(RVA = "0x71F5B10", Offset = "0x71F1B10", VA = "0x71F5B10")]
			[Preserve]
			internal static AssetBundle _0083hF_0091_00A8_008E(byte[] _009F_0080_005B_009F_0086_0089, string j_0081xY_0088_0088)
			{
				return null;
			}

			[Token(Token = "0x600616A")]
			[Address(RVA = "0x71F5BD0", Offset = "0x71F1BD0", VA = "0x71F5BD0")]
			[Preserve]
			internal static AssetBundle _009D_00BB_00A4_00AF_009F_007D(Stream _007D_0091_00ACS_00BF_009F, string j_0081xY_0088_0088)
			{
				return null;
			}
		}

		[Token(Token = "0x20003F7")]
		[Preserve]
		internal static class _008C_0095_0098v_009FP
		{
			[Token(Token = "0x600616B")]
			[Address(RVA = "0x71F5C90", Offset = "0x71F1C90", VA = "0x71F5C90")]
			[Preserve]
			internal static AssetBundle _0098_009BÀ_005B_0098S(string _00B6_0082TS_00BDI, string j_0081xY_0088_0088)
			{
				return null;
			}

			[Token(Token = "0x600616C")]
			[Address(RVA = "0x71F5D0C", Offset = "0x71F1D0C", VA = "0x71F5D0C")]
			[Preserve]
			internal static AssetBundle _0083hF_0091_00A8_008E(byte[] _009F_0080_005B_009F_0086_0089, string j_0081xY_0088_0088)
			{
				return null;
			}

			[Token(Token = "0x600616D")]
			[Address(RVA = "0x71F5DCC", Offset = "0x71F1DCC", VA = "0x71F5DCC")]
			[Preserve]
			internal static AssetBundle _009D_00BB_00A4_00AF_009F_007D(Stream _007D_0091_00ACS_00BF_009F, string j_0081xY_0088_0088)
			{
				return null;
			}
		}

		[Token(Token = "0x20003F8")]
		[Preserve]
		internal static class _00A1O_0091_007C_00AEt
		{
			[Token(Token = "0x600616E")]
			[Address(RVA = "0x71F5E8C", Offset = "0x71F1E8C", VA = "0x71F5E8C")]
			[Preserve]
			internal static AssetBundle _0098_009BÀ_005B_0098S(string _00B6_0082TS_00BDI, string j_0081xY_0088_0088)
			{
				return null;
			}

			[Token(Token = "0x600616F")]
			[Address(RVA = "0x71F5F08", Offset = "0x71F1F08", VA = "0x71F5F08")]
			[Preserve]
			internal static AssetBundle _0083hF_0091_00A8_008E(byte[] _009F_0080_005B_009F_0086_0089, string j_0081xY_0088_0088)
			{
				return null;
			}

			[Token(Token = "0x6006170")]
			[Address(RVA = "0x71F5FC8", Offset = "0x71F1FC8", VA = "0x71F5FC8")]
			[Preserve]
			internal static AssetBundle _009D_00BB_00A4_00AF_009F_007D(Stream _007D_0091_00ACS_00BF_009F, string j_0081xY_0088_0088)
			{
				return null;
			}
		}

		[Token(Token = "0x20003F9")]
		[Preserve]
		internal static class º_00BEºEÂ_008B
		{
			[Token(Token = "0x6006171")]
			[Address(RVA = "0x71F6088", Offset = "0x71F2088", VA = "0x71F6088")]
			[Preserve]
			internal static AssetBundle _0098_009BÀ_005B_0098S(string _00B6_0082TS_00BDI, string j_0081xY_0088_0088)
			{
				return null;
			}

			[Token(Token = "0x6006172")]
			[Address(RVA = "0x71F6104", Offset = "0x71F2104", VA = "0x71F6104")]
			[Preserve]
			internal static AssetBundle _0083hF_0091_00A8_008E(byte[] _009F_0080_005B_009F_0086_0089, string j_0081xY_0088_0088)
			{
				return null;
			}

			[Token(Token = "0x6006173")]
			[Address(RVA = "0x71F61C4", Offset = "0x71F21C4", VA = "0x71F61C4")]
			[Preserve]
			internal static AssetBundle _009D_00BB_00A4_00AF_009F_007D(Stream _007D_0091_00ACS_00BF_009F, string j_0081xY_0088_0088)
			{
				return null;
			}
		}

		[Token(Token = "0x4001CE0")]
		private const int qµ_00A1_0099_00A2_00B9 = 16;

		[Token(Token = "0x4001CE1")]
		private const int _009Af_00BFk_00A9F = 16;

		[Token(Token = "0x4001CE2")]
		[FieldOffset(Offset = "0x0")]
		private static string W_0087cq_005E_00B3;

		[Token(Token = "0x4001CE3")]
		[FieldOffset(Offset = "0x8")]
		private static byte[] P_007ELF_00B4N;

		[Token(Token = "0x4001CE4")]
		[FieldOffset(Offset = "0x10")]
		private static readonly byte[] À_00B3d_0094s_00B4;

		[Token(Token = "0x4001CE5")]
		[FieldOffset(Offset = "0x18")]
		private static readonly byte[] U_00AE_0091G_0099Á;

		[Token(Token = "0x4001CE6")]
		[FieldOffset(Offset = "0x20")]
		private static readonly int[] _00B4qp_0099wS;

		[Token(Token = "0x4001CE7")]
		[FieldOffset(Offset = "0x28")]
		private static readonly int[] ÀN_0093_009E_0082B;

		[Token(Token = "0x60060F9")]
		[Address(RVA = "0x71EDA90", Offset = "0x71E9A90", VA = "0x71EDA90")]
		public static byte[] DecryptBytes(byte[] _009F_0080_005B_009F_0086_0089, string _009D_0097K_00A9a_00A3)
		{
			return null;
		}

		[Token(Token = "0x60060FA")]
		[Address(RVA = "0x71EE1C8", Offset = "0x71EA1C8", VA = "0x71EE1C8")]
		public static byte[] EncryptBytes(byte[] _009F_0080_005B_009F_0086_0089, string _009D_0097K_00A9a_00A3)
		{
			return null;
		}

		[Token(Token = "0x60060FB")]
		[Address(RVA = "0x71EE798", Offset = "0x71EA798", VA = "0x71EE798")]
		[Preserve]
		public static byte[] EncryptAssetBundle(byte[] _009F_0080_005B_009F_0086_0089, string j_0081xY_0088_0088)
		{
			return null;
		}

		[Token(Token = "0x60060FC")]
		[Address(RVA = "0x71EE8F4", Offset = "0x71EA8F4", VA = "0x71EE8F4")]
		[Preserve]
		public static byte[] DecryptAssetBundle(byte[] _009F_0080_005B_009F_0086_0089, string j_0081xY_0088_0088)
		{
			return null;
		}

		[Token(Token = "0x60060FD")]
		[Address(RVA = "0x71EEA4C", Offset = "0x71EAA4C", VA = "0x71EEA4C")]
		[Preserve]
		public static bool CheckAssetBundleData(string j_0081xY_0088_0088, byte[] _009F_0080_005B_009F_0086_0089)
		{
			return default;
		}

		[Token(Token = "0x60060FE")]
		[Address(RVA = "0x71EEC9C", Offset = "0x71EAC9C", VA = "0x71EEC9C")]
		[Preserve]
		public static string GetAssetBundleSeed()
		{
			return null;
		}

		[Token(Token = "0x60060FF")]
		[Address(RVA = "0x71EF12C", Offset = "0x71EB12C", VA = "0x71EF12C")]
		[Preserve]
		public static byte[] EncryptAssetBundleFile(string _00B6_0082TS_00BDI, string j_0081xY_0088_0088)
		{
			return null;
		}

		[Token(Token = "0x6006100")]
		[Address(RVA = "0x71EE820", Offset = "0x71EA820", VA = "0x71EE820")]
		private static byte[] wSD_0093_00B4c(byte[] _009F_0080_005B_009F_0086_0089, string j_0081xY_0088_0088, string _009CxC_00A0_0060_00A8)
		{
			return null;
		}

		[Token(Token = "0x6006101")]
		[Address(RVA = "0x71EE97C", Offset = "0x71EA97C", VA = "0x71EE97C")]
		private static byte[] PÂA_007Fd_0098(byte[] _009F_0080_005B_009F_0086_0089, string j_0081xY_0088_0088, string _009CxC_00A0_0060_00A8)
		{
			return null;
		}

		[Token(Token = "0x6006102")]
		[Address(RVA = "0x71EEAD4", Offset = "0x71EAAD4", VA = "0x71EEAD4")]
		private static bool _0086giN_008CF(string j_0081xY_0088_0088, byte[] _009F_0080_005B_009F_0086_0089, string _009CxC_00A0_0060_00A8)
		{
			return default;
		}

		[Token(Token = "0x6006103")]
		[Address(RVA = "0x71EF518", Offset = "0x71EB518", VA = "0x71EF518")]
		private static byte[] µT_009ADZD(O_0060rB_0084W GDQ_00A3_0098_00A1, string j_0081xY_0088_0088, string _009CxC_00A0_0060_00A8)
		{
			return null;
		}

		[Token(Token = "0x6006104")]
		[Address(RVA = "0x71EFFD8", Offset = "0x71EBFD8", VA = "0x71EFFD8")]
		private static byte[] x_0091Zb_0089B(O_0060rB_0084W GDQ_00A3_0098_00A1, string j_0081xY_0088_0088, string _009CxC_00A0_0060_00A8)
		{
			return null;
		}

		[Token(Token = "0x6006105")]
		[Address(RVA = "0x71EF230", Offset = "0x71EB230", VA = "0x71EF230")]
		private static O_0060rB_0084W _005Br_0085s_00AE_0080(string _009CxC_00A0_0060_00A8, string j_0081xY_0088_0088)
		{
			return default;
		}

		[Token(Token = "0x6006106")]
		[Address(RVA = "0x71F1C28", Offset = "0x71EDC28", VA = "0x71F1C28")]
		private static string _0091Lg_007EG_009B(string _009CxC_00A0_0060_00A8, string j_0081xY_0088_0088)
		{
			return null;
		}

		[Token(Token = "0x6006107")]
		[Address(RVA = "0x71F1D38", Offset = "0x71EDD38", VA = "0x71F1D38")]
		private static ulong _00AB_008B_0060K_0095u(string _00B0_0085_00B1_0085mv)
		{
			return default;
		}

		[Token(Token = "0x6006108")]
		[Address(RVA = "0x71F2014", Offset = "0x71EE014", VA = "0x71F2014")]
		private static ulong k_007D_0060_009ACm(ulong _00A3_0092T_007E_00ABc, byte[] lD_009F_0098_0080_00B0, ulong _009D_0097K_00A9a_00A3)
		{
			return default;
		}

		[Token(Token = "0x6006109")]
		[Address(RVA = "0x71F0FC4", Offset = "0x71ECFC4", VA = "0x71F0FC4")]
		private static byte[] _00ACc_00AF_00A5bW(O_0060rB_0084W GDQ_00A3_0098_00A1, string j_0081xY_0088_0088, string _009CxC_00A0_0060_00A8)
		{
			return null;
		}

		[Token(Token = "0x600610A")]
		[Address(RVA = "0x71EF2C0", Offset = "0x71EB2C0", VA = "0x71EF2C0")]
		private static byte[] _008C_007F_00AB_0097U_009A(O_0060rB_0084W GDQ_00A3_0098_00A1, byte[] _009F_0080_005B_009F_0086_0089, string j_0081xY_0088_0088, string _009CxC_00A0_0060_00A8)
		{
			return null;
		}

		[Token(Token = "0x600610B")]
		[Address(RVA = "0x71F0C60", Offset = "0x71ECC60", VA = "0x71F0C60")]
		private static byte[] _0082_008Bv_00A9dV(O_0060rB_0084W GDQ_00A3_0098_00A1, byte[] _009F_0080_005B_009F_0086_0089, string j_0081xY_0088_0088, string _009CxC_00A0_0060_00A8)
		{
			return null;
		}

		[Token(Token = "0x600610C")]
		[Address(RVA = "0x71F242C", Offset = "0x71EE42C", VA = "0x71F242C")]
		private static byte[] _00AEI_0088_00BEvX(byte[] _009F_0080_005B_009F_0086_0089, byte[] c_009E_00A0_007B_00A7A, bool _0087_0089_0080LoH)
		{
			return null;
		}

		[Token(Token = "0x600610D")]
		[Address(RVA = "0x71F0420", Offset = "0x71EC420", VA = "0x71F0420")]
		private static byte[] _00B6_00AE_00A3_00AEzj(byte[] _009F_0080_005B_009F_0086_0089, byte[] _0088_00A7_00B0_00B8Y_0090, byte[] _00A6i_007Bx_00AD_007C)
		{
			return null;
		}

		[Token(Token = "0x600610E")]
		[Address(RVA = "0x71F0840", Offset = "0x71EC840", VA = "0x71F0840")]
		private static byte[] i_0086J_009Efr(byte[] _009F_0080_005B_009F_0086_0089, byte[] _0088_00A7_00B0_00B8Y_0090, byte[] _00A6i_007Bx_00AD_007C)
		{
			return null;
		}

		[Token(Token = "0x600610F")]
		[Address(RVA = "0x71F130C", Offset = "0x71ED30C", VA = "0x71F130C")]
		private static byte[] _00BFR_00B0O_00AE_00B3(byte[] _0081À_00BC_0097_00A9_00B3, int _00ACrP_008AEz, byte _0086F_00B6_0092Mr)
		{
			return null;
		}

		[Token(Token = "0x6006110")]
		[Address(RVA = "0x71F21FC", Offset = "0x71EE1FC", VA = "0x71F21FC")]
		private static byte[] c_00ACªBS_00A3(byte[] _009F_0080_005B_009F_0086_0089, byte[] c_009E_00A0_007B_00A7A, bool _0087_0089_0080LoH)
		{
			return null;
		}

		[Token(Token = "0x6006111")]
		[Address(RVA = "0x71F1A20", Offset = "0x71EDA20", VA = "0x71F1A20")]
		private static byte[] _005D_007CKB_00A6_0081(byte[] _009F_0080_005B_009F_0086_0089, byte[] c_009E_00A0_007B_00A7A, bool _0087_0089_0080LoH)
		{
			return null;
		}

		[Token(Token = "0x6006112")]
		[Address(RVA = "0x71F1B18", Offset = "0x71EDB18", VA = "0x71F1B18")]
		private static byte[] _0060vFQ_007F_005B(byte[] _009F_0080_005B_009F_0086_0089, byte[] c_009E_00A0_007B_00A7A)
		{
			return null;
		}

		[Token(Token = "0x6006113")]
		[Address(RVA = "0x71F15D4", Offset = "0x71ED5D4", VA = "0x71F15D4")]
		private static byte[] _008Bk_009C_00BEU_0095(byte[] _009F_0080_005B_009F_0086_0089, byte[] c_009E_00A0_007B_00A7A)
		{
			return null;
		}

		[Token(Token = "0x6006114")]
		[Address(RVA = "0x71F2370", Offset = "0x71EE370", VA = "0x71F2370")]
		private static byte[] _0087t_0098ª_0087_0088(byte[] _009F_0080_005B_009F_0086_0089)
		{
			return null;
		}

		[Token(Token = "0x6006115")]
		[Address(RVA = "0x71F18D4", Offset = "0x71ED8D4", VA = "0x71F18D4")]
		private static byte[] QkaL_00AB_00B9(byte[] _009F_0080_005B_009F_0086_0089, int L_008A_00A3_007D_009EV)
		{
			return null;
		}

		[Token(Token = "0x6006116")]
		[Address(RVA = "0x71F16A0", Offset = "0x71ED6A0", VA = "0x71F16A0")]
		private static byte[] h_0082_0081_0092º_0087(byte[] _009F_0080_005B_009F_0086_0089)
		{
			return null;
		}

		[Token(Token = "0x6006117")]
		[Address(RVA = "0x71F11D8", Offset = "0x71ED1D8", VA = "0x71F11D8")]
		private static byte[] d_007E_0096Z_00BCb(byte[] KOz_0086_009Fn, byte[] Y_00A1E_0099_00ACD)
		{
			return null;
		}

		[Token(Token = "0x6006118")]
		[Address(RVA = "0x71EEF28", Offset = "0x71EAF28", VA = "0x71EEF28")]
		private static byte[] _009F_0094i_008A_0093_008A(byte[] _009F_0080_005B_009F_0086_0089)
		{
			return null;
		}

		[Token(Token = "0x6006119")]
		[Address(RVA = "0x71F20B0", Offset = "0x71EE0B0", VA = "0x71F20B0")]
		private static byte[] _0081_0084g_00BD_0083W(byte[] _009F_0080_005B_009F_0086_0089)
		{
			return null;
		}

		[Token(Token = "0x600611A")]
		[Address(RVA = "0x71F24A4", Offset = "0x71EE4A4", VA = "0x71F24A4")]
		private static byte y_009D_008AV_008F_008C(byte _00A3_0092T_007E_00ABc, int _007Ew_009ATu_00AE)
		{
			return default;
		}

		[Token(Token = "0x600611B")]
		[Address(RVA = "0x71F24C0", Offset = "0x71EE4C0", VA = "0x71F24C0")]
		private static byte _009B_007CV_0098_00A8_00B6(byte _00A3_0092T_007E_00ABc, int _007Ew_009ATu_00AE)
		{
			return default;
		}

		[Token(Token = "0x600611C")]
		[Address(RVA = "0x71F174C", Offset = "0x71ED74C", VA = "0x71F174C")]
		private static byte[] _005D_00A9_007DOz_00B7(byte[] _009F_0080_005B_009F_0086_0089)
		{
			return null;
		}

		[Token(Token = "0x600611D")]
		[Address(RVA = "0x71EE040", Offset = "0x71EA040", VA = "0x71EE040")]
		private static byte[] w_00A0z_009Ab_009B(byte[] _009F_0080_005B_009F_0086_0089)
		{
			return null;
		}

		[Token(Token = "0x600611E")]
		[Address(RVA = "0x71EEFA4", Offset = "0x71EAFA4", VA = "0x71EEFA4")]
		private static byte[] ISMoU_009A(byte[] _009F_0080_005B_009F_0086_0089)
		{
			return null;
		}

		[Token(Token = "0x600611F")]
		[Address(RVA = "0x71F0ECC", Offset = "0x71ECECC", VA = "0x71F0ECC")]
		private static byte[] iFKPxn(byte[] _0096_0085_009F_00B1Q_00A4)
		{
			return null;
		}

		[Token(Token = "0x6006120")]
		[Address(RVA = "0x71F114C", Offset = "0x71ED14C", VA = "0x71F114C")]
		private static int _0084_00BFFH_00A0_00B6(int g_0097mKyÂ)
		{
			return default;
		}

		[Token(Token = "0x6006121")]
		[Address(RVA = "0x71F2190", Offset = "0x71EE190", VA = "0x71F2190")]
		private static byte _0095_0093s_00AC_0085_00BC(O_0060rB_0084W GDQ_00A3_0098_00A1)
		{
			return default;
		}

		[Token(Token = "0x6006122")]
		[Address(RVA = "0x71F24DC", Offset = "0x71EE4DC", VA = "0x71F24DC")]
		private static _0088_0088_00BD_00BBH_0088 _0085_0099ZÁ_00AC_007D(_009Fgt_0088C_0086 w_0083_00B3_00BFCx)
		{
			return default;
		}

		[Token(Token = "0x6006123")]
		[Address(RVA = "0x71F25C4", Offset = "0x71EE5C4", VA = "0x71F25C4")]
		private static byte[] _0092µ_00BC_0098_0090_00AD()
		{
			return null;
		}
	}
}
