using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GameFramework.GameData
{
	[Token(Token = "0x20004B3")]
	public class GameDataVersionMgr
	{
		[Token(Token = "0x4001F39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static GameDataVersionMgr _0060_0083_00A4_00A6_0095t;

		[Token(Token = "0x4001F3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static bool IsUseOldDataUpload;

		[Token(Token = "0x4001F3B")]
		private const string _008Bv_0060A_008C_009F = "GameDataVer";

		[Token(Token = "0x4001F3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Dictionary<string, GameDataVer> dicLocalDataVer;

		[Token(Token = "0x4001F3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Dictionary<string, GameDataVer> dicServerDataVer;

		[Token(Token = "0x4001F3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[CompilerGenerated]
		private Action<string, int, int> A_00A6_00B0D_0094i;

		[Token(Token = "0x4001F3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[CompilerGenerated]
		private static Func<ManualHandleDataDelegate, bool> _00B1LY_0089JY;

		[Token(Token = "0x4001F40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool P_00B1_009CLVN;

		[Token(Token = "0x4001F41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		private bool _00B1e_00B0q_005B_0080;

		[Token(Token = "0x4001F42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		private bool R_007EF_00A4_00B1_009A;

		[Token(Token = "0x4001F43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<GameReportDataVer> _00B9À_005Bc_005B_0085;

		[Token(Token = "0x4001F44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<GameReportDataVer> _00A0_00AD_007E_0096Ke;

		[Token(Token = "0x4001F45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool _00B8_00A2_0087_009A_00B4O;

		[Token(Token = "0x4001F46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		private bool zsV_0084G_0060;

		[Token(Token = "0x4001F47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x42")]
		private bool b_008F_009Eu_00BB_0096;

		[Token(Token = "0x4001F48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Dictionary<RevServerGameData, string> I_00B4À_00B2J_00AD;

		[Token(Token = "0x4001F49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Action<List<RevServerGameData>, bool> _0082_00BD_009B_00AB_00B0w;

		[Token(Token = "0x4001F4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int _0087_00B0G_009EL_00BB;

		[Token(Token = "0x4001F4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private List<GameDataVer> _00AF_0083_0093_00BDlV;

		[Token(Token = "0x4001F4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool _009BAcÁn_009E;

		[Token(Token = "0x17001221")]
		public static GameDataVersionMgr Instance
		{
			[Token(Token = "0x600703F")]
			[Address(RVA = "0x72ABB64", Offset = "0x72A7B64", VA = "0x72ABB64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001222")]
		public bool IsHandlingGameVer
		{
			[Token(Token = "0x6007038")]
			[Address(RVA = "0x72AA858", Offset = "0x72A6858", VA = "0x72AA858")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1400002D")]
		public event Action<string, int, int> onDataVersionChanged
		{
			[Token(Token = "0x600705A")]
			[Address(RVA = "0x72B0DE0", Offset = "0x72ACDE0", VA = "0x72B0DE0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6007039")]
			[Address(RVA = "0x72AA878", Offset = "0x72A6878", VA = "0x72AA878")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400002E")]
		public static event Func<ManualHandleDataDelegate, bool> onManualHandleData
		{
			[Token(Token = "0x6007062")]
			[Address(RVA = "0x72B2504", Offset = "0x72AE504", VA = "0x72B2504")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6007067")]
			[Address(RVA = "0x72B2FE0", Offset = "0x72AEFE0", VA = "0x72B2FE0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x600703A")]
		[Address(RVA = "0x72AA928", Offset = "0x72A6928", VA = "0x72AA928")]
		private void o_005D_00A3_0095g_0093(GameDataUseType Á_009F_00BFµ_00A2_00B3)
		{
		}

		[Token(Token = "0x600703B")]
		[Address(RVA = "0x72AB584", Offset = "0x72A7584", VA = "0x72AB584")]
		private void _00A6_00A1_0084_0090c_005E()
		{
		}

		[Token(Token = "0x600703C")]
		[Address(RVA = "0x72AB7CC", Offset = "0x72A77CC", VA = "0x72AB7CC")]
		private void Ls_009E_0088_00A1z(GameDataUseType Á_009F_00BFµ_00A2_00B3)
		{
		}

		[Token(Token = "0x600703D")]
		[Address(RVA = "0x72AB934", Offset = "0x72A7934", VA = "0x72AB934")]
		public void CloseSynData()
		{
		}

		[Token(Token = "0x600703E")]
		[Address(RVA = "0x72AB9DC", Offset = "0x72A79DC", VA = "0x72AB9DC")]
		public void RequestGameDataOnly(Action<List<RevServerGameData>, bool> _00A3Y_0082I_00A7_00B4, float _00AFF_00BD_0083_0087X = 5f, params string[] T_0087_007DvBs)
		{
		}

		[Token(Token = "0x6007040")]
		[Address(RVA = "0x72ABE30", Offset = "0x72A7E30", VA = "0x72ABE30")]
		private void N_00B3YL_0080Â(object[] Tª_0096ºb_0083)
		{
		}

		[SpecialName]
		[Token(Token = "0x6007041")]
		[Address(RVA = "0x72ABF80", Offset = "0x72A7F80", VA = "0x72ABF80")]
		public static void _008CGJ_0086_0094_00B9(Func<ManualHandleDataDelegate, bool> _00A3_0092T_007E_00ABc)
		{
		}

		[Token(Token = "0x6007042")]
		[Address(RVA = "0x72AC074", Offset = "0x72A8074", VA = "0x72AC074")]
		private void _0086z_009E_00A1U_00AD()
		{
		}

		[Token(Token = "0x6007043")]
		[Address(RVA = "0x72AC560", Offset = "0x72A8560", VA = "0x72AC560")]
		private void a_005E_00BF_0099µ_0092(object[] Tª_0096ºb_0083)
		{
		}

		[Token(Token = "0x6007044")]
		[Address(RVA = "0x72AC6AC", Offset = "0x72A86AC", VA = "0x72AC6AC")]
		internal void d_008F_007F_009E_00B0_00A2(Dictionary<string, int> _0097E_00BC_007DPs)
		{
		}

		[Token(Token = "0x6007045")]
		[Address(RVA = "0x72ACB38", Offset = "0x72A8B38", VA = "0x72ACB38")]
		internal void _009Fg_00AB_0085LI(string[] T_0087_007DvBs)
		{
		}

		[Token(Token = "0x6007046")]
		[Address(RVA = "0x72ACBA0", Offset = "0x72A8BA0", VA = "0x72ACBA0")]
		private void o_008C_008C_008Ew_00BB(GameDataUseType Á_009F_00BFµ_00A2_00B3)
		{
		}

		[Token(Token = "0x6007048")]
		[Address(RVA = "0x72ABEEC", Offset = "0x72A7EEC", VA = "0x72ABEEC")]
		private void _00BE_008E_00A5RD_00AE()
		{
		}

		[Token(Token = "0x6007049")]
		[Address(RVA = "0x72ACD38", Offset = "0x72A8D38", VA = "0x72ACD38")]
		private void HIIÂS_008F()
		{
		}

		[Token(Token = "0x600704A")]
		[Address(RVA = "0x72ACDC8", Offset = "0x72A8DC8", VA = "0x72ACDC8")]
		internal void ad_0088i_005Eb(string[] T_0087_007DvBs)
		{
		}

		[Token(Token = "0x600704B")]
		[Address(RVA = "0x72ACE30", Offset = "0x72A8E30", VA = "0x72ACE30")]
		private void _00BC_0091_00A2G_008EW(string _00AC_008B_007B_009F_00B6_00AB)
		{
		}

		[Token(Token = "0x600704C")]
		[Address(RVA = "0x72AD800", Offset = "0x72A9800", VA = "0x72AD800")]
		private void _0084_00B8_009C_0090U_0083()
		{
		}

		[Token(Token = "0x600704D")]
		[Address(RVA = "0x72AD890", Offset = "0x72A9890", VA = "0x72AD890")]
		public void _00ACE_00BE_00B2e_00BB(Action<List<RevServerGameData>, bool> _00A3Y_0082I_00A7_00B4, [Optional][DefaultParameterValue(5f)] float _00AFF_00BD_0083_0087X, string[] T_0087_007DvBs)
		{
		}

		[Token(Token = "0x600704E")]
		[Address(RVA = "0x72AC61C", Offset = "0x72A861C", VA = "0x72AC61C")]
		private void _00AE_0083e_00AF_00A9_00B6()
		{
		}

		[Token(Token = "0x600704F")]
		[Address(RVA = "0x72ADA18", Offset = "0x72A9A18", VA = "0x72ADA18")]
		public void UserLogin(long _0091_008Co_0097cE, bool R_007EF_00A4_00B1_009A = false, bool crhª_00A7_0098 = false)
		{
		}

		[Token(Token = "0x6007050")]
		[Address(RVA = "0x72AE514", Offset = "0x72AA514", VA = "0x72AE514")]
		public void _00B3_008B_0081x_009Eb()
		{
		}

		[Token(Token = "0x6007051")]
		[Address(RVA = "0x72AE5BC", Offset = "0x72AA5BC", VA = "0x72AE5BC")]
		internal void _005E_0080_0096_00A3f_0097(string _0096_008BÁ_00B2u_009C)
		{
		}

		[Token(Token = "0x6007052")]
		[Address(RVA = "0x72AEB30", Offset = "0x72AAB30", VA = "0x72AEB30")]
		internal void _0082sj_00B1D_00A1(Dictionary<string, int> Q_008CÂ_0097_005Bn)
		{
		}

		[Token(Token = "0x6007053")]
		[Address(RVA = "0x72AF30C", Offset = "0x72AB30C", VA = "0x72AF30C")]
		internal void Á_0090_0090_00B8_00B9_0086(params string[] T_0087_007DvBs)
		{
		}

		[Token(Token = "0x6007054")]
		[Address(RVA = "0x72AC23C", Offset = "0x72A823C", VA = "0x72AC23C")]
		private void _008C_007E_009E_00AF_00B1j()
		{
		}

		[Token(Token = "0x6007055")]
		[Address(RVA = "0x72AF374", Offset = "0x72AB374", VA = "0x72AF374")]
		public void _009C_00B6_0080jµ_00B3()
		{
		}

		[Token(Token = "0x6007056")]
		[Address(RVA = "0x72AF41C", Offset = "0x72AB41C", VA = "0x72AF41C")]
		private void _00A7Et_00A8_008F_00B6()
		{
		}

		[Token(Token = "0x6007057")]
		[Address(RVA = "0x72AF528", Offset = "0x72AB528", VA = "0x72AF528")]
		internal void _00ABF_0087Iv_00B4(List<RevServerGameData> r_00B8ÀCkU)
		{
		}

		[Token(Token = "0x6007058")]
		[Address(RVA = "0x72AFF18", Offset = "0x72ABF18", VA = "0x72AFF18")]
		internal void Wi_007F_007F_009E_007B(string[] T_0087_007DvBs)
		{
		}

		[Token(Token = "0x6007059")]
		[Address(RVA = "0x72AFF80", Offset = "0x72ABF80", VA = "0x72AFF80")]
		private void _00BC_00A2B_00A4_0094J()
		{
		}

		[Token(Token = "0x600705B")]
		[Address(RVA = "0x72B0E90", Offset = "0x72ACE90", VA = "0x72B0E90")]
		private void _00A3_00AC_00BB_00B6X_00BB()
		{
		}

		[Token(Token = "0x600705C")]
		[Address(RVA = "0x72AAA90", Offset = "0x72A6A90", VA = "0x72AAA90")]
		private void sqhX_0094_0091()
		{
		}

		[SpecialName]
		[Token(Token = "0x600705D")]
		[Address(RVA = "0x72B1820", Offset = "0x72AD820", VA = "0x72B1820")]
		public void p_0083Il_008DB(Action<string, int, int> _00A3_0092T_007E_00ABc)
		{
		}

		[Token(Token = "0x600705E")]
		[Address(RVA = "0x72B18D0", Offset = "0x72AD8D0", VA = "0x72B18D0")]
		public void TZ_0098_00ADB_0099(long _0091_008Co_0097cE, bool R_007EF_00A4_00B1_009A = false, bool crhª_00A7_0098 = false)
		{
		}

		[SpecialName]
		[Token(Token = "0x600705F")]
		[Address(RVA = "0x72B224C", Offset = "0x72AE24C", VA = "0x72B224C")]
		public bool _007FQ_005E_00AB_007Ew()
		{
			return default;
		}

		[Token(Token = "0x6007060")]
		[Address(RVA = "0x72B226C", Offset = "0x72AE26C", VA = "0x72B226C")]
		internal void µT_007E_00A9tf(string _0096_008BÁ_00B2u_009C)
		{
		}

		[Token(Token = "0x6007061")]
		[Address(RVA = "0x72B24BC", Offset = "0x72AE4BC", VA = "0x72B24BC")]
		internal void k_00A3m_00B1_00B2_007E(List<RevServerGameData> xe_005B_0084_005B_008C, bool _00BEY_009D_0084_008E_008A)
		{
		}

		[Token(Token = "0x6007063")]
		[Address(RVA = "0x72B25F8", Offset = "0x72AE5F8", VA = "0x72B25F8")]
		internal bool lW_00A2_0097_008E_0088()
		{
			return default;
		}

		[Token(Token = "0x6007064")]
		[Address(RVA = "0x72ABC04", Offset = "0x72A7C04", VA = "0x72ABC04")]
		public GameDataVersionMgr()
		{
		}

		[Token(Token = "0x6007065")]
		[Address(RVA = "0x72B2608", Offset = "0x72AE608", VA = "0x72B2608")]
		private void E_00B2_00A2_00BBuÁ(string _00AC_008B_007B_009F_00B6_00AB)
		{
		}

		[Token(Token = "0x6007066")]
		[Address(RVA = "0x72AE808", Offset = "0x72AA808", VA = "0x72AE808")]
		private void _00BFÀ_00AB_005Ba_0096()
		{
		}

		[Token(Token = "0x6007068")]
		[Address(RVA = "0x72B30D4", Offset = "0x72AF0D4", VA = "0x72B30D4")]
		[CompilerGenerated]
		private void _007B_00A9_0094_009Bfa()
		{
		}

		[Token(Token = "0x6007069")]
		[Address(RVA = "0x72B31E0", Offset = "0x72AF1E0", VA = "0x72B31E0")]
		private void xpD_0082_0089º()
		{
		}

		[Token(Token = "0x600706A")]
		[Address(RVA = "0x72B3328", Offset = "0x72AF328", VA = "0x72B3328")]
		internal void _0089_00AF_00BF_00A4_008C_00AD(Dictionary<string, int> _0097E_00BC_007DPs)
		{
		}

		[Token(Token = "0x600706B")]
		[Address(RVA = "0x72AB6CC", Offset = "0x72A76CC", VA = "0x72AB6CC")]
		private void BD_00B0_0095_00B8_00B2()
		{
		}

		[Token(Token = "0x600706C")]
		[Address(RVA = "0x72B3888", Offset = "0x72AF888", VA = "0x72B3888")]
		internal void _0093_009BH_0092_00A1w(string _0096_008BÁ_00B2u_009C)
		{
		}

		[Token(Token = "0x600706D")]
		[Address(RVA = "0x72B0FE0", Offset = "0x72ACFE0", VA = "0x72B0FE0")]
		private void _00B6Mºu_00A6_00B2()
		{
		}

		[Token(Token = "0x600706E")]
		[Address(RVA = "0x72B3D3C", Offset = "0x72AFD3C", VA = "0x72B3D3C")]
		internal void e_00A8_00A9ª_0080t(List<RevServerGameData> xe_005B_0084_005B_008C, bool _00BEY_009D_0084_008E_008A)
		{
		}

		[Token(Token = "0x600706F")]
		[Address(RVA = "0x72B3D84", Offset = "0x72AFD84", VA = "0x72B3D84")]
		private void _005D_0083_00B4LJo()
		{
		}

		[SpecialName]
		[Token(Token = "0x6007070")]
		[Address(RVA = "0x72B4ABC", Offset = "0x72B0ABC", VA = "0x72B4ABC")]
		public void _008ET_0095hJ_00B6(Action<string, int, int> _00A3_0092T_007E_00ABc)
		{
		}

		[SpecialName]
		[Token(Token = "0x6007071")]
		[Address(RVA = "0x72B4B6C", Offset = "0x72B0B6C", VA = "0x72B4B6C")]
		public void _00B4_00A0tº_00AF_00B0(Action<string, int, int> _00A3_0092T_007E_00ABc)
		{
		}

		[Token(Token = "0x6007072")]
		[Address(RVA = "0x72B4C1C", Offset = "0x72B0C1C", VA = "0x72B4C1C")]
		internal void ºq_00B6WWh(List<RevServerGameData> xe_005B_0084_005B_008C, bool _00BEY_009D_0084_008E_008A)
		{
		}

		[SpecialName]
		[Token(Token = "0x6007073")]
		[Address(RVA = "0x72B4C64", Offset = "0x72B0C64", VA = "0x72B4C64")]
		public static void z_00A3_0090_00BF_0060_00BB(Func<ManualHandleDataDelegate, bool> _00A3_0092T_007E_00ABc)
		{
		}

		[Token(Token = "0x6007074")]
		[Address(RVA = "0x72AD22C", Offset = "0x72A922C", VA = "0x72AD22C")]
		private void YbRkMs()
		{
		}

		[Token(Token = "0x6007075")]
		[Address(RVA = "0x72B4D58", Offset = "0x72B0D58", VA = "0x72B4D58")]
		internal void _0091_009Bj_0088_007E_00B9(List<RevServerGameData> xe_005B_0084_005B_008C, bool _00BEY_009D_0084_008E_008A)
		{
		}

		[Token(Token = "0x6007076")]
		[Address(RVA = "0x72B4DA0", Offset = "0x72B0DA0", VA = "0x72B4DA0")]
		public void _00B8AYjeH(long _0091_008Co_0097cE, bool R_007EF_00A4_00B1_009A = false, bool crhª_00A7_0098 = false)
		{
		}

		[Token(Token = "0x6007077")]
		[Address(RVA = "0x72B2A08", Offset = "0x72AEA08", VA = "0x72B2A08")]
		private void z_009Ed_008DM_00AE()
		{
		}

		[Token(Token = "0x6007078")]
		[Address(RVA = "0x72B07C4", Offset = "0x72AC7C4", VA = "0x72B07C4")]
		private void ÂÂmÁ_009D_007D()
		{
		}

		[Token(Token = "0x6007079")]
		[Address(RVA = "0x72B5870", Offset = "0x72B1870", VA = "0x72B5870")]
		internal void SZ_00B4Â_0085d(List<RevServerGameData> xe_005B_0084_005B_008C, bool _00BEY_009D_0084_008E_008A)
		{
		}
	}
}
