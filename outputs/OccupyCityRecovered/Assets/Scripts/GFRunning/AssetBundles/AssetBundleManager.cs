using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GameFramework;
using GameFramework.Resources;
using Il2CppDummyDll;
using UnityEngine;

namespace AssetBundles
{
	[Token(Token = "0x20001AB")]
	public class AssetBundleManager : MonoBehaviour
	{
		[Token(Token = "0x20001AC")]
		public enum LogMode
		{
			[Token(Token = "0x4000556")]
			All = 0,
			[Token(Token = "0x4000557")]
			JustErrors = 1
		}

		[Token(Token = "0x20001AD")]
		public enum LogType
		{
			[Token(Token = "0x4000559")]
			Info = 0,
			[Token(Token = "0x400055A")]
			Warning = 1,
			[Token(Token = "0x400055B")]
			Error = 2
		}

		[Token(Token = "0x4000546")]
		[FieldOffset(Offset = "0x0")]
		private static LogMode _008AtjIiH;

		[Token(Token = "0x4000547")]
		[FieldOffset(Offset = "0x8")]
		private static string _00B3_00BB_00BB_00B1_0095f;

		[Token(Token = "0x4000548")]
		[FieldOffset(Offset = "0x10")]
		private static string[] _00AE_00A8_007FT_00A1J;

		[Token(Token = "0x4000549")]
		[FieldOffset(Offset = "0x18")]
		private static AssetBundleManifest UpBzLc;

		[Token(Token = "0x400054A")]
		[FieldOffset(Offset = "0x20")]
		public static Dictionary<string, LoadedAssetBundle> m_LoadedAssetBundles;

		[Token(Token = "0x400054B")]
		[FieldOffset(Offset = "0x28")]
		private static Dictionary<string, _008F_00A9_008B_008DMQ> z_0090h_00A0_0086_0085;

		[Token(Token = "0x400054C")]
		[FieldOffset(Offset = "0x30")]
		private static Dictionary<string, string> _009A_009C_00BD_009D_0095B;

		[Token(Token = "0x400054D")]
		[FieldOffset(Offset = "0x38")]
		private static List<AssetBundleLoadOperation> Â_00A4_0094b_0084_0086;

		[Token(Token = "0x400054E")]
		[FieldOffset(Offset = "0x40")]
		private static Dictionary<string, string[]> n_00A0_00A2dqo;

		[Token(Token = "0x400054F")]
		[FieldOffset(Offset = "0x48")]
		internal static GameObject Yu_00B6_009E_00A6_008F;

		[Token(Token = "0x4000550")]
		[FieldOffset(Offset = "0x50")]
		private static ulong e_00A7_0098_00BFD_0094;

		[Token(Token = "0x4000551")]
		[FieldOffset(Offset = "0x58")]
		private static Dictionary<string, int> _005B_009FzP_0085L;

		[Token(Token = "0x4000552")]
		[FieldOffset(Offset = "0x60")]
		[Obsolete("慎用")]
		public static bool CloseAutoUnLoadAssetBundle;

		[Token(Token = "0x4000553")]
		[FieldOffset(Offset = "0x68")]
		private static List<LoadedAssetBundle> _009ADX_0084_005D_0089;

		[Token(Token = "0x4000554")]
		[FieldOffset(Offset = "0x20")]
		private List<LoadedAssetBundle> _0080_00B6e_00B9_008Fa;

		[Token(Token = "0x170000DA")]
		public static LogMode logMode
		{
			[Token(Token = "0x6001424")]
			[Address(RVA = "0x736B490", Offset = "0x7367490", VA = "0x736B490")]
			get
			{
				return default;
			}
			[Token(Token = "0x60013FE")]
			[Address(RVA = "0x7366630", Offset = "0x7362630", VA = "0x7366630")]
			set
			{
			}
		}

		[Token(Token = "0x170000DB")]
		public static string BaseDownloadingURL
		{
			[Token(Token = "0x60013F3")]
			[Address(RVA = "0x7364AAC", Offset = "0x7360AAC", VA = "0x7364AAC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60013E2")]
			[Address(RVA = "0x7362D28", Offset = "0x735ED28", VA = "0x7362D28")]
			set
			{
			}
		}

		[Token(Token = "0x170000DC")]
		public static string[] ActiveVariants
		{
			[Token(Token = "0x6001410")]
			[Address(RVA = "0x7368990", Offset = "0x7364990", VA = "0x7368990")]
			get
			{
				return null;
			}
			[Token(Token = "0x60013FF")]
			[Address(RVA = "0x736668C", Offset = "0x736268C", VA = "0x736668C")]
			set
			{
			}
		}

		[Token(Token = "0x170000DD")]
		public static AssetBundleManifest AssetBundleManifestObject
		{
			[Token(Token = "0x600140E")]
			[Address(RVA = "0x7368760", Offset = "0x7364760", VA = "0x7368760")]
			get
			{
				return null;
			}
			[Token(Token = "0x60013F2")]
			[Address(RVA = "0x7364A50", Offset = "0x7360A50", VA = "0x7364A50")]
			set
			{
			}
		}

		[Token(Token = "0x60013DF")]
		[Address(RVA = "0x7362530", Offset = "0x735E530", VA = "0x7362530")]
		private static void _00AF_008B_00A1sc_007F(LoadedAssetBundle _00B4_00BC_00B1eU_009A)
		{
		}

		[Token(Token = "0x60013E0")]
		[Address(RVA = "0x736275C", Offset = "0x735E75C", VA = "0x736275C")]
		public static void Shutdown()
		{
		}

		[Token(Token = "0x60013E1")]
		[Address(RVA = "0x7362AF4", Offset = "0x735EAF4", VA = "0x7362AF4")]
		private static void j_0090VCkY(LoadedAssetBundle _00B4_00BC_00B1eU_009A)
		{
		}

		[Token(Token = "0x60013E3")]
		[Address(RVA = "0x7362D84", Offset = "0x735ED84", VA = "0x7362D84")]
		public static AssetBundleLoadManifestOperation _007F_00B4_0097_00B8_0080_00B4(string _00A9_00BD_00A1B_009CN)
		{
			return null;
		}

		[Token(Token = "0x60013E4")]
		[Address(RVA = "0x73620A0", Offset = "0x735E0A0", VA = "0x73620A0")]
		internal static _008F_00A9_008B_008DMQ ru_009AÂR_009D(string µZºV_0089_00AB)
		{
			return null;
		}

		[SpecialName]
		[Token(Token = "0x60013E5")]
		[Address(RVA = "0x7363114", Offset = "0x735F114", VA = "0x7363114")]
		public static void _0099_00A3ZUu_009C(LogMode _00A3_0092T_007E_00ABc)
		{
		}

		[Token(Token = "0x60013E6")]
		[Address(RVA = "0x7363170", Offset = "0x735F170", VA = "0x7363170")]
		public static void _009C_00AC_007B_00B6U_008E(string _0091_005EL_008B_007FE)
		{
		}

		[SpecialName]
		[Token(Token = "0x60013E7")]
		[Address(RVA = "0x7363258", Offset = "0x735F258", VA = "0x7363258")]
		public static string[] XÁwÁ_00B9s()
		{
			return null;
		}

		[Token(Token = "0x60013E8")]
		[Address(RVA = "0x73632B0", Offset = "0x735F2B0", VA = "0x73632B0")]
		public static void _008B_00A9s_0091d_0093(string µZºV_0089_00AB)
		{
		}

		[Token(Token = "0x60013E9")]
		[Address(RVA = "0x73635C4", Offset = "0x735F5C4", VA = "0x73635C4")]
		public static AssetBundleLoadAssetOperation LoadAssetAsync(string µZºV_0089_00AB, string M_009E_00AD_005B_007CO, Type _007BgpR_00A0V)
		{
			return null;
		}

		[SpecialName]
		[Token(Token = "0x60013EA")]
		[Address(RVA = "0x7363958", Offset = "0x735F958", VA = "0x7363958")]
		public static string Y_009A_0090_005EhA()
		{
			return null;
		}

		[Token(Token = "0x60013EB")]
		[Address(RVA = "0x73639B0", Offset = "0x735F9B0", VA = "0x73639B0")]
		public static AssetBundleLoadManifestOperation LoadManifest(string _00A9_00BD_00A1B_009CN)
		{
			return null;
		}

		[SpecialName]
		[Token(Token = "0x60013EC")]
		[Address(RVA = "0x7363BFC", Offset = "0x735FBFC", VA = "0x7363BFC")]
		public static string[] H_00BC_0086_0084_00B9_0090()
		{
			return null;
		}

		[SpecialName]
		[Token(Token = "0x60013ED")]
		[Address(RVA = "0x7363C54", Offset = "0x735FC54", VA = "0x7363C54")]
		public static void À_0083HR_008E_005D(LogMode _00A3_0092T_007E_00ABc)
		{
		}

		[Token(Token = "0x60013EE")]
		[Address(RVA = "0x7363CB0", Offset = "0x735FCB0", VA = "0x7363CB0")]
		public static AssetBundleLoadOperation _007CNG_0060b_00A1(string µZºV_0089_00AB, string gK_00BC_00B2QG, bool _005Ddk_00A3Ol)
		{
			return null;
		}

		[Token(Token = "0x60013EF")]
		[Address(RVA = "0x7363F34", Offset = "0x735FF34", VA = "0x7363F34")]
		protected static bool LoadAssetBundleInternal(string µZºV_0089_00AB, bool ZK_0094_0081hl, bool _0094H_009B_0060K_00B4 = true)
		{
			return default;
		}

		[Token(Token = "0x60013F0")]
		[Address(RVA = "0x736479C", Offset = "0x736079C", VA = "0x736479C")]
		private static BundleAssetInfo E_0094_005E_0090F_007C(string j_0081xY_0088_0088)
		{
			return null;
		}

		[SpecialName]
		[Token(Token = "0x60013F1")]
		[Address(RVA = "0x73649F8", Offset = "0x73609F8", VA = "0x73649F8")]
		public static string _00ABqFc_00B1G()
		{
			return null;
		}

		[Token(Token = "0x60013F4")]
		[Address(RVA = "0x7364B04", Offset = "0x7360B04", VA = "0x7364B04")]
		protected static string _008C_00BD_0060ho_00AD(string µZºV_0089_00AB)
		{
			return null;
		}

		[Token(Token = "0x60013F5")]
		[Address(RVA = "0x7364D24", Offset = "0x7360D24", VA = "0x7364D24")]
		private void _007DyX_005D_0092_005B()
		{
		}

		[Token(Token = "0x60013F6")]
		[Address(RVA = "0x73650E4", Offset = "0x73610E4", VA = "0x73650E4")]
		internal static void _00B1_007DH_00AE_00A2R(string µZºV_0089_00AB)
		{
		}

		[Token(Token = "0x60013F7")]
		[Address(RVA = "0x7362FD0", Offset = "0x735EFD0", VA = "0x7362FD0")]
		protected static void LoadAssetBundle(string µZºV_0089_00AB, bool ZK_0094_0081hl = false)
		{
		}

		[Token(Token = "0x60013F8")]
		[Address(RVA = "0x7365778", Offset = "0x7361778", VA = "0x7365778")]
		public static void UnloadAssetBundle(string µZºV_0089_00AB)
		{
		}

		[Token(Token = "0x60013F9")]
		[Address(RVA = "0x73657D4", Offset = "0x73617D4", VA = "0x73657D4")]
		protected static void _00BB_00A1_009CNO_00A1(string µZºV_0089_00AB)
		{
		}

		[Token(Token = "0x60013FA")]
		[Address(RVA = "0x73658A8", Offset = "0x73618A8", VA = "0x73658A8")]
		public static AssetBundleLoadBundleOperation LoadAssetBundleAsync(string µZºV_0089_00AB)
		{
			return null;
		}

		[Token(Token = "0x60013FB")]
		[Address(RVA = "0x7365AAC", Offset = "0x7361AAC", VA = "0x7365AAC")]
		public static AssetBundleLoadManifestOperation _005B_007DO_009D_00ABo(string _00A9_00BD_00A1B_009CN)
		{
			return null;
		}

		[Token(Token = "0x60013FC")]
		[Address(RVA = "0x7365CF8", Offset = "0x7361CF8", VA = "0x7365CF8")]
		public static void Cm_0099_00AE_00B2_0087()
		{
		}

		[Token(Token = "0x60013FD")]
		[Address(RVA = "0x7365E68", Offset = "0x7361E68", VA = "0x7365E68")]
		private void _009B_00A4E_007E_0099_007B()
		{
		}

		[Token(Token = "0x6001400")]
		[Address(RVA = "0x73666E8", Offset = "0x73626E8", VA = "0x73666E8")]
		public static AssetBundleLoadManifestOperation _008DkZg_0080_00A9(string _00A9_00BD_00A1B_009CN)
		{
			return null;
		}

		[Token(Token = "0x6001401")]
		[Address(RVA = "0x7366934", Offset = "0x7362934", VA = "0x7366934")]
		public static DebugReport d_00B0_0081J_009DN()
		{
			return null;
		}

		[Token(Token = "0x6001402")]
		[Address(RVA = "0x73651D8", Offset = "0x73611D8", VA = "0x73651D8")]
		protected static void LoadDependencies(string µZºV_0089_00AB)
		{
		}

		[Token(Token = "0x6001403")]
		[Address(RVA = "0x7366E28", Offset = "0x7362E28", VA = "0x7366E28")]
		private static void Flºm_00AEg()
		{
		}

		[SpecialName]
		[Token(Token = "0x6001404")]
		[Address(RVA = "0x7366FA8", Offset = "0x7362FA8", VA = "0x7366FA8")]
		public static void V_008Aj_00B6_008Bu(LogMode _00A3_0092T_007E_00ABc)
		{
		}

		[Token(Token = "0x6001405")]
		[Address(RVA = "0x7367004", Offset = "0x7363004", VA = "0x7367004")]
		protected static void wvg_0081_00A1_0094(string µZºV_0089_00AB)
		{
		}

		[Token(Token = "0x6001406")]
		[Address(RVA = "0x73677B8", Offset = "0x73637B8", VA = "0x73677B8")]
		public static void SetSourceAssetBundleURL(string _0091_005EL_008B_007FE)
		{
		}

		[Token(Token = "0x6001407")]
		[Address(RVA = "0x73678A0", Offset = "0x73638A0", VA = "0x73678A0")]
		public static void ÀiÂA_00AF_0085()
		{
		}

		[Token(Token = "0x6001408")]
		[Address(RVA = "0x73678EC", Offset = "0x73638EC", VA = "0x73678EC")]
		internal void f_0091_008A_00AC_009F_0097(List<string> ED_005EKK_0080)
		{
		}

		[Token(Token = "0x6001409")]
		[Address(RVA = "0x736330C", Offset = "0x735F30C", VA = "0x736330C")]
		protected static void UnloadAssetBundleInternal(string µZºV_0089_00AB)
		{
		}

		[SpecialName]
		[Token(Token = "0x600140A")]
		[Address(RVA = "0x7367F90", Offset = "0x7363F90", VA = "0x7367F90")]
		public static void µkgA_0098_0097(LogMode _00A3_0092T_007E_00ABc)
		{
		}

		[Token(Token = "0x600140B")]
		[Address(RVA = "0x7364544", Offset = "0x7360544", VA = "0x7364544")]
		private static BundleAssetInfo _0080PsI_008Cn(string j_0081xY_0088_0088)
		{
			return null;
		}

		[Token(Token = "0x600140C")]
		[Address(RVA = "0x7367FEC", Offset = "0x7363FEC", VA = "0x7367FEC")]
		public static void SetDevelopmentAssetBundleServer()
		{
		}

		[Token(Token = "0x600140D")]
		[Address(RVA = "0x736815C", Offset = "0x736415C", VA = "0x736815C")]
		protected static bool _007EbqK_009AR(string µZºV_0089_00AB, bool ZK_0094_0081hl, bool _0094H_009B_0060K_00B4 = true)
		{
			return default;
		}

		[Token(Token = "0x600140F")]
		[Address(RVA = "0x73687B8", Offset = "0x73647B8", VA = "0x73687B8")]
		public static void SetSourceAssetBundleDirectory(string _00A3_00A9_005B_008Ds_00B9)
		{
		}

		[Token(Token = "0x6001411")]
		[Address(RVA = "0x73689E8", Offset = "0x73649E8", VA = "0x73689E8")]
		public static void Initialize()
		{
		}

		[Token(Token = "0x6001412")]
		[Address(RVA = "0x73634CC", Offset = "0x735F4CC", VA = "0x73634CC")]
		protected static void UnloadDependencies(string µZºV_0089_00AB)
		{
		}

		[Token(Token = "0x6001413")]
		[Address(RVA = "0x7368A34", Offset = "0x7364A34", VA = "0x7368A34")]
		public static DebugReport GetDebugReport()
		{
			return null;
		}

		[Token(Token = "0x6001414")]
		[Address(RVA = "0x7367578", Offset = "0x7363578", VA = "0x7367578")]
		protected static string qH_0089_009EF_008D(string µZºV_0089_00AB)
		{
			return null;
		}

		[SpecialName]
		[Token(Token = "0x6001415")]
		[Address(RVA = "0x7368F20", Offset = "0x7364F20", VA = "0x7368F20")]
		public static string[] _007B_00A2jlk_0082()
		{
			return null;
		}

		[Token(Token = "0x6001416")]
		[Address(RVA = "0x7363718", Offset = "0x735F718", VA = "0x7363718")]
		protected static string RemapVariantName(string µZºV_0089_00AB)
		{
			return null;
		}

		[Token(Token = "0x6001417")]
		[Address(RVA = "0x7368F78", Offset = "0x7364F78", VA = "0x7368F78")]
		public static AssetBundleLoadOperation A_0083_00ACgU_0099(string µZºV_0089_00AB, string gK_00BC_00B2QG, bool _005Ddk_00A3Ol)
		{
			return null;
		}

		[Token(Token = "0x6001418")]
		[Address(RVA = "0x73691F4", Offset = "0x73651F4", VA = "0x73691F4")]
		protected static void _00A7_0081_0089_00A6Ub(string µZºV_0089_00AB)
		{
		}

		[Token(Token = "0x6001419")]
		[Address(RVA = "0x736978C", Offset = "0x736578C", VA = "0x736978C")]
		protected static void ÂJXHiS(string µZºV_0089_00AB)
		{
		}

		[Token(Token = "0x600141A")]
		[Address(RVA = "0x7369D0C", Offset = "0x7365D0C", VA = "0x7369D0C")]
		public AssetBundleManager()
		{
		}

		[Token(Token = "0x600141C")]
		[Address(RVA = "0x73618A8", Offset = "0x735D8A8", VA = "0x73618A8")]
		public static LoadedAssetBundle GetLoadedAssetBundle(string µZºV_0089_00AB, out string Á_009B_0082E_00AC_009B, out int _00AC_008B_0098T_008E_00A3)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED AssetBundleManager.GetLoadedAssetBundle RVA=0x73618A8 Token=0x600141C");
}

		[Token(Token = "0x600141D")]
		[Address(RVA = "0x7368858", Offset = "0x7364858", VA = "0x7368858")]
		private static string _007C_00B6a_0099_0084_00B8()
		{
			return null;
		}

		[SpecialName]
		[Token(Token = "0x600141E")]
		[Address(RVA = "0x736A034", Offset = "0x7366034", VA = "0x736A034")]
		public static void W_00A1K_0098fu(string[] _00A3_0092T_007E_00ABc)
		{
		}

		[Token(Token = "0x600141F")]
		[Address(RVA = "0x736A090", Offset = "0x7366090", VA = "0x736A090")]
		private void Update()
		{
		}

		[SpecialName]
		[Token(Token = "0x6001420")]
		[Address(RVA = "0x736A85C", Offset = "0x736685C", VA = "0x736A85C")]
		public static AssetBundleManifest F_00BC_0082b_00BCg()
		{
			return null;
		}

		[Token(Token = "0x6001421")]
		[Address(RVA = "0x736A8B4", Offset = "0x73668B4", VA = "0x736A8B4")]
		public static AssetBundleLoadOperation N_0095amx_00BF(string µZºV_0089_00AB, string gK_00BC_00B2QG, bool _005Ddk_00A3Ol)
		{
			return null;
		}

		[Token(Token = "0x6001422")]
		[Address(RVA = "0x736AB34", Offset = "0x7366B34", VA = "0x736AB34")]
		internal void ÁPª_0087_008Db(List<string> ED_005EKK_0080)
		{
		}

		[Token(Token = "0x6001423")]
		[Address(RVA = "0x736B1F4", Offset = "0x73671F4", VA = "0x736B1F4")]
		public static AssetBundleLoadOperation LoadLevelAsync(string µZºV_0089_00AB, string gK_00BC_00B2QG, bool _005Ddk_00A3Ol)
		{
			return null;
		}

		[Token(Token = "0x6001425")]
		[Address(RVA = "0x736B4E8", Offset = "0x73674E8", VA = "0x736B4E8")]
		private static BundleAssetInfo _00A6c_007Cl_0082d(string j_0081xY_0088_0088)
		{
			return null;
		}

		[Token(Token = "0x6001426")]
		[Address(RVA = "0x736B744", Offset = "0x7367744", VA = "0x736B744")]
		protected static void _00A9_0081_0088_005B_00B8_008C(string µZºV_0089_00AB)
		{
		}
	}
}
