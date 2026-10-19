using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Il2CppDummyDll;

namespace VXJSON
{
	[Token(Token = "0x20001AF")]
	public static class Json
	{
		[Token(Token = "0x20001B0")]
		private sealed class µ_00ABosR_00B0 : IDisposable
		{
			[Token(Token = "0x20001B1")]
			private enum nqBCg_008F
			{
				[Token(Token = "0x4000561")]
				NONE = 0,
				[Token(Token = "0x4000562")]
				CURLY_OPEN = 1,
				[Token(Token = "0x4000563")]
				CURLY_CLOSE = 2,
				[Token(Token = "0x4000564")]
				SQUARED_OPEN = 3,
				[Token(Token = "0x4000565")]
				SQUARED_CLOSE = 4,
				[Token(Token = "0x4000566")]
				COLON = 5,
				[Token(Token = "0x4000567")]
				COMMA = 6,
				[Token(Token = "0x4000568")]
				STRING = 7,
				[Token(Token = "0x4000569")]
				NUMBER = 8,
				[Token(Token = "0x400056A")]
				TRUE = 9,
				[Token(Token = "0x400056B")]
				FALSE = 10,
				[Token(Token = "0x400056C")]
				NULL = 11
			}

			[Token(Token = "0x400055E")]
			private const string _00A2_0095_00AE_007E_0085_00BD = "{}[],:\"";

			[Token(Token = "0x400055F")]
			[FieldOffset(Offset = "0x10")]
			private StringReader º_0086_005Bfbµ;

			[Token(Token = "0x170000DE")]
			private char _0092o_005E_0084_0086_00AE
			{
				[Token(Token = "0x6001453")]
				[Address(RVA = "0x736EDE4", Offset = "0x736ADE4", VA = "0x736EDE4")]
				get
				{
					return _0096U_0085_008A_00BCX();
				}
			}

			[Token(Token = "0x170000DF")]
			private char pK_00BBºt_009E
			{
				[Token(Token = "0x600145D")]
				[Address(RVA = "0x736F678", Offset = "0x736B678", VA = "0x736F678")]
				get
				{
					return R_00BB_00A5_008EN_0099();
				}
			}

			[Token(Token = "0x170000E0")]
			private string _0099_008B_009AaU_008C
			{
				[Token(Token = "0x6001465")]
				[Address(RVA = "0x736F388", Offset = "0x736B388", VA = "0x736F388")]
				get
				{
					return _009Al_0093Â_009CÁ();
				}
			}

			[Token(Token = "0x170000E1")]
			private nqBCg_008F _0084_0095_00A9pga
			{
				[Token(Token = "0x600146E")]
				[Address(RVA = "0x736E984", Offset = "0x736A984", VA = "0x736E984")]
				get
				{
					return _007E_00ABmCrP();
				}
			}

			[Token(Token = "0x6001452")]
			[Address(RVA = "0x736E860", Offset = "0x736A860", VA = "0x736E860")]
			private Dictionary<string, object> QM_00A0_0096t_0060()
			{
				return null;
			}

			[Token(Token = "0x6001453")]
			[Address(RVA = "0x736EDE4", Offset = "0x736ADE4", VA = "0x736EDE4")]
			private char _0096U_0085_008A_00BCX()
			{
				return default;
			}

			[Token(Token = "0x6001454")]
			[Address(RVA = "0x736EE5C", Offset = "0x736AE5C", VA = "0x736EE5C")]
			private List<object> Z_0096_00A8_008F_00A0d()
			{
				return null;
			}

			[SpecialName]
			[Token(Token = "0x6001455")]
			[Address(RVA = "0x736F168", Offset = "0x736B168", VA = "0x736F168")]
			private nqBCg_008F _007DL_00B7ª_00A8_00BE()
			{
				return default;
			}

			[Token(Token = "0x6001456")]
			[Address(RVA = "0x736F43C", Offset = "0x736B43C", VA = "0x736F43C")]
			private µ_00ABosR_00B0(string l_00A8_0096AQ_007C)
			{
			}

			[SpecialName]
			[Token(Token = "0x6001457")]
			[Address(RVA = "0x736F4B0", Offset = "0x736B4B0", VA = "0x736F4B0")]
			private string _009D_0090_00AE_0087GR()
			{
				return null;
			}

			[Token(Token = "0x6001458")]
			[Address(RVA = "0x736F6F0", Offset = "0x736B6F0", VA = "0x736F6F0", Slot = "5")]
			public void QY_009D_0088_007DK()
			{
			}

			[Token(Token = "0x6001459")]
			[Address(RVA = "0x736F718", Offset = "0x736B718", VA = "0x736F718")]
			private object F_00BE_0098CH_0082()
			{
				return null;
			}

			[Token(Token = "0x600145A")]
			[Address(RVA = "0x736F734", Offset = "0x736B734", VA = "0x736F734")]
			public static bool CD_0097_0098_00B7_005D(char Á_0060eb_0080_0082)
			{
				return default;
			}

			[SpecialName]
			[Token(Token = "0x600145B")]
			[Address(RVA = "0x736F564", Offset = "0x736B564", VA = "0x736F564")]
			private char _00A8D_007D_00B7Y_00A0()
			{
				return default;
			}

			[SpecialName]
			[Token(Token = "0x600145C")]
			[Address(RVA = "0x736F7D0", Offset = "0x736B7D0", VA = "0x736F7D0")]
			private nqBCg_008F H_00B3_00AE_0083_0083w()
			{
				return default;
			}

			[Token(Token = "0x600145D")]
			[Address(RVA = "0x736F678", Offset = "0x736B678", VA = "0x736F678")]
			private char R_00BB_00A5_008EN_0099()
			{
				return default;
			}

			[Token(Token = "0x600145E")]
			[Address(RVA = "0x736FA2C", Offset = "0x736BA2C", VA = "0x736FA2C")]
			private Dictionary<string, object> s_00BBU_0097qc()
			{
				return null;
			}

			[SpecialName]
			[Token(Token = "0x600145F")]
			[Address(RVA = "0x736FBF4", Offset = "0x736BBF4", VA = "0x736FBF4")]
			private char _005DXºXT_00A3()
			{
				return default;
			}

			[Token(Token = "0x6001460")]
			[Address(RVA = "0x736FC6C", Offset = "0x736BC6C", VA = "0x736FC6C")]
			private void _007D_005BS_0086_0060_009C()
			{
			}

			[Token(Token = "0x6001461")]
			[Address(RVA = "0x736FD18", Offset = "0x736BD18", VA = "0x736FD18")]
			private void u_0080_00A8_008A_0097_00AF()
			{
			}

			[Token(Token = "0x6001462")]
			[Address(RVA = "0x736FDC4", Offset = "0x736BDC4", VA = "0x736FDC4")]
			public static object tlJ_00B7G_00A0(string l_00A8_0096AQ_007C)
			{
				return null;
			}

			[SpecialName]
			[Token(Token = "0x6001463")]
			[Address(RVA = "0x736FF88", Offset = "0x736BF88", VA = "0x736FF88")]
			private nqBCg_008F I_0087_009F_007FFM()
			{
				return default;
			}

			[SpecialName]
			[Token(Token = "0x6001464")]
			[Address(RVA = "0x736F310", Offset = "0x736B310", VA = "0x736F310")]
			private char GH_00B1i_0096w()
			{
				return default;
			}

			[Token(Token = "0x6001465")]
			[Address(RVA = "0x736F388", Offset = "0x736B388", VA = "0x736F388")]
			private string _009Al_0093Â_009CÁ()
			{
				return null;
			}

			[Token(Token = "0x6001466")]
			[Address(RVA = "0x7370160", Offset = "0x736C160", VA = "0x7370160")]
			public static bool _00A9_005Db_00B7Â_0095(char Á_0060eb_0080_0082)
			{
				return default;
			}

			[Token(Token = "0x6001467")]
			[Address(RVA = "0x736FB44", Offset = "0x736BB44", VA = "0x736FB44")]
			private string FMsxS_00BD()
			{
				return null;
			}

			[Token(Token = "0x6001468")]
			[Address(RVA = "0x73702EC", Offset = "0x736C2EC", VA = "0x73702EC")]
			private List<object> _00BFn_00A1jT_007C()
			{
				return null;
			}

			[Token(Token = "0x6001469")]
			[Address(RVA = "0x7370414", Offset = "0x736C414", VA = "0x7370414")]
			private object C_0086jµÀY()
			{
				return null;
			}

			[Token(Token = "0x600146A")]
			[Address(RVA = "0x73700C4", Offset = "0x736C0C4", VA = "0x73700C4")]
			public static bool IsWordBreak(char Á_0060eb_0080_0082)
			{
				return default;
			}

			[Token(Token = "0x600146B")]
			[Address(RVA = "0x736EB48", Offset = "0x736AB48", VA = "0x736EB48")]
			private string fo_00A3zºf()
			{
				return null;
			}

			[Token(Token = "0x600146C")]
			[Address(RVA = "0x736EDC8", Offset = "0x736ADC8", VA = "0x736EDC8")]
			private object _0099Uq_007DO_0097()
			{
				return null;
			}

			[SpecialName]
			[Token(Token = "0x600146D")]
			[Address(RVA = "0x736F978", Offset = "0x736B978", VA = "0x736F978")]
			private string _0082_00AB_00A3_00BE_0092F()
			{
				return null;
			}

			[Token(Token = "0x600146E")]
			[Address(RVA = "0x736E984", Offset = "0x736A984", VA = "0x736E984")]
			private nqBCg_008F _007E_00ABmCrP()
			{
				return default;
			}

			[Token(Token = "0x600146F")]
			[Address(RVA = "0x736F8CC", Offset = "0x736B8CC", VA = "0x736F8CC")]
			private void t_00B6H_007CN_00AE()
			{
			}

			[SpecialName]
			[Token(Token = "0x6001470")]
			[Address(RVA = "0x73701FC", Offset = "0x736C1FC", VA = "0x73701FC")]
			private char Â_00B0zÀ_00A8l()
			{
				return default;
			}

			[Token(Token = "0x6001471")]
			[Address(RVA = "0x7370430", Offset = "0x736C430", VA = "0x7370430", Slot = "6")]
			public void JXkD_0099_00BB()
			{
			}

			[Token(Token = "0x6001472")]
			[Address(RVA = "0x7370458", Offset = "0x736C458", VA = "0x7370458")]
			private object lJ_0085_009C_009Au()
			{
				return null;
			}

			[Token(Token = "0x6001473")]
			[Address(RVA = "0x736F264", Offset = "0x736B264", VA = "0x736F264")]
			private void _008D_007Bu_008Ee_0080()
			{
			}

			[Token(Token = "0x6001474")]
			[Address(RVA = "0x7370474", Offset = "0x736C474", VA = "0x7370474", Slot = "4")]
			public void Dispose()
			{
			}

			[Token(Token = "0x6001475")]
			[Address(RVA = "0x737049C", Offset = "0x736C49C", VA = "0x737049C")]
			private object i_0080_00B2_00BFz_0060()
			{
				return null;
			}

			[Token(Token = "0x6001476")]
			[Address(RVA = "0x737056C", Offset = "0x736C56C", VA = "0x737056C")]
			private List<object> _00ADh_008A_00AF_00B7S()
			{
				return null;
			}

			[SpecialName]
			[Token(Token = "0x6001477")]
			[Address(RVA = "0x737068C", Offset = "0x736C68C", VA = "0x737068C")]
			private string Àb_00A4K_0083_00BE()
			{
				return null;
			}

			[SpecialName]
			[Token(Token = "0x6001478")]
			[Address(RVA = "0x736EF7C", Offset = "0x736AF7C", VA = "0x736EF7C")]
			private nqBCg_008F _005B_00A9_0092m_00B8c()
			{
				return default;
			}

			[Token(Token = "0x6001479")]
			[Address(RVA = "0x7370740", Offset = "0x736C740", VA = "0x7370740")]
			private Dictionary<string, object> jºO_00A8DN()
			{
				return null;
			}

			[SpecialName]
			[Token(Token = "0x600147A")]
			[Address(RVA = "0x7370274", Offset = "0x736C274", VA = "0x7370274")]
			private char P_0095KiOj()
			{
				return default;
			}

			[SpecialName]
			[Token(Token = "0x600147B")]
			[Address(RVA = "0x7370864", Offset = "0x736C864", VA = "0x7370864")]
			private nqBCg_008F _00B6_00AEPi_0060i()
			{
				return default;
			}

			[Token(Token = "0x600147C")]
			[Address(RVA = "0x7370960", Offset = "0x736C960", VA = "0x7370960", Slot = "7")]
			public void _007Cw_007C_009C_00A6H()
			{
			}

			[Token(Token = "0x600147D")]
			[Address(RVA = "0x736FF6C", Offset = "0x736BF6C", VA = "0x736FF6C")]
			private object Áb_00B7x_0084_00B3()
			{
				return null;
			}

			[Token(Token = "0x600147E")]
			[Address(RVA = "0x736E640", Offset = "0x736A640", VA = "0x736E640")]
			public static object Parse(string l_00A8_0096AQ_007C)
			{
				return null;
			}

			[Token(Token = "0x600147F")]
			[Address(RVA = "0x736F5DC", Offset = "0x736B5DC", VA = "0x736F5DC")]
			public static bool T_00A5_00A9_005E_00AD_0086(char Á_0060eb_0080_0082)
			{
				return default;
			}

			[Token(Token = "0x6001480")]
			[Address(RVA = "0x7370988", Offset = "0x736C988", VA = "0x7370988")]
			private object fO_00BCpªg()
			{
				return null;
			}

			[Token(Token = "0x6001481")]
			[Address(RVA = "0x736FBD8", Offset = "0x736BBD8", VA = "0x736FBD8")]
			private object _0060_0089_00A8_007EzT()
			{
				return null;
			}

			[Token(Token = "0x6001482")]
			[Address(RVA = "0x736F078", Offset = "0x736B078", VA = "0x736F078")]
			private object _00B9G_0095XU_007D(nqBCg_008F _0086i_0094_00BBt_00B8)
			{
				return null;
			}
		}

		[Token(Token = "0x20001B2")]
		private sealed class C_00B6_00AB_00BCjµ
		{
			[Token(Token = "0x400056D")]
			[FieldOffset(Offset = "0x10")]
			private StringBuilder _005EV_0097_0094W_00BC;

			[Token(Token = "0x6001483")]
			[Address(RVA = "0x7370A58", Offset = "0x736CA58", VA = "0x7370A58")]
			private void P_008BPzZ_00A0(string _008C_00A8_00A1cf_00A6)
			{
			}

			[Token(Token = "0x6001484")]
			[Address(RVA = "0x7370CE8", Offset = "0x736CCE8", VA = "0x7370CE8")]
			private void Mkv_008C_00AD_00B4(IDictionary _008EBÂ_008F_00BB_008B)
			{
			}

			[Token(Token = "0x6001485")]
			[Address(RVA = "0x737159C", Offset = "0x736D59C", VA = "0x737159C")]
			private void ÀM_00A5_008A_0086T(string _008C_00A8_00A1cf_00A6)
			{
			}

			[Token(Token = "0x6001486")]
			[Address(RVA = "0x73717F8", Offset = "0x736D7F8", VA = "0x73717F8")]
			private void On_00B2_0085_00BBB(object _00A3_0092T_007E_00ABc)
			{
			}

			[Token(Token = "0x6001487")]
			[Address(RVA = "0x7371CC8", Offset = "0x736DCC8", VA = "0x7371CC8")]
			private void _00BE_0087Y_0093AB(object _00A3_0092T_007E_00ABc)
			{
			}

			[Token(Token = "0x6001488")]
			[Address(RVA = "0x7372154", Offset = "0x736E154", VA = "0x7372154")]
			private void Q_008B_0098N_00BF_0099(IList uGYQ_008A_00B8)
			{
			}

			[Token(Token = "0x6001489")]
			[Address(RVA = "0x73724B4", Offset = "0x736E4B4", VA = "0x73724B4")]
			private void g_009A_0097E_00B9_0085(IDictionary _008EBÂ_008F_00BB_008B)
			{
			}

			[Token(Token = "0x600148A")]
			[Address(RVA = "0x7372BC4", Offset = "0x736EBC4", VA = "0x7372BC4")]
			private void F_0092CvFh(IList uGYQ_008A_00B8)
			{
			}

			[Token(Token = "0x600148B")]
			[Address(RVA = "0x7372F24", Offset = "0x736EF24", VA = "0x7372F24")]
			public static string zwJtpZ(object _008EBÂ_008F_00BB_008B)
			{
				return null;
			}

			[Token(Token = "0x600148C")]
			[Address(RVA = "0x7372FFC", Offset = "0x736EFFC", VA = "0x7372FFC")]
			private void x_008DHxk_00A7(IDictionary _008EBÂ_008F_00BB_008B)
			{
			}

			[Token(Token = "0x600148D")]
			[Address(RVA = "0x7373904", Offset = "0x736F904", VA = "0x7373904")]
			private void _00A7_00BE_007Dµ_0082_008A(string _008C_00A8_00A1cf_00A6)
			{
			}

			[Token(Token = "0x600148E")]
			[Address(RVA = "0x7373B6C", Offset = "0x736FB6C", VA = "0x7373B6C")]
			private void h_009DA_007E_0099_00B9(IDictionary _008EBÂ_008F_00BB_008B)
			{
			}

			[Token(Token = "0x600148F")]
			[Address(RVA = "0x736E7EC", Offset = "0x736A7EC", VA = "0x736E7EC")]
			public static string Serialize(object _008EBÂ_008F_00BB_008B)
			{
				return null;
			}

			[Token(Token = "0x6001490")]
			[Address(RVA = "0x73741D0", Offset = "0x73701D0", VA = "0x73741D0")]
			private void VFff_0094Q(object _00A3_0092T_007E_00ABc)
			{
			}

			[Token(Token = "0x6001491")]
			[Address(RVA = "0x73746F0", Offset = "0x73706F0", VA = "0x73746F0")]
			private void _00A4D_00AF_0088_0093_0060(string _008C_00A8_00A1cf_00A6)
			{
			}

			[Token(Token = "0x6001492")]
			[Address(RVA = "0x7372F98", Offset = "0x736EF98", VA = "0x7372F98")]
			private C_00B6_00AB_00BCjµ()
			{
			}

			[Token(Token = "0x6001493")]
			[Address(RVA = "0x7374998", Offset = "0x7370998", VA = "0x7374998")]
			private void _0097_0081_00ADDrf(object _00A3_0092T_007E_00ABc)
			{
			}

			[Token(Token = "0x6001494")]
			[Address(RVA = "0x7371174", Offset = "0x736D174", VA = "0x7371174")]
			private void _0096moF_007B_0090(string _008C_00A8_00A1cf_00A6)
			{
			}

			[Token(Token = "0x6001495")]
			[Address(RVA = "0x7374E94", Offset = "0x7370E94", VA = "0x7374E94")]
			private void _00AB_009DªYÂ_0092(object _00A3_0092T_007E_00ABc)
			{
			}

			[Token(Token = "0x6001496")]
			[Address(RVA = "0x7375124", Offset = "0x7371124", VA = "0x7375124")]
			public static string Y_00B4_009A_0098_00AD_0091(object _008EBÂ_008F_00BB_008B)
			{
				return null;
			}

			[Token(Token = "0x6001497")]
			[Address(RVA = "0x7372940", Offset = "0x736E940", VA = "0x7372940")]
			private void _0080e_0090_00AED_00AB(object _00A3_0092T_007E_00ABc)
			{
			}

			[Token(Token = "0x6001498")]
			[Address(RVA = "0x7374C28", Offset = "0x7370C28", VA = "0x7374C28")]
			private void _008Av_0086_00AD_0087c(string _008C_00A8_00A1cf_00A6)
			{
			}

			[Token(Token = "0x6001499")]
			[Address(RVA = "0x7375198", Offset = "0x7371198", VA = "0x7375198")]
			private void _0084i_00B4_0093Q_0095(IDictionary _008EBÂ_008F_00BB_008B)
			{
			}

			[Token(Token = "0x600149A")]
			[Address(RVA = "0x73755EC", Offset = "0x73715EC", VA = "0x73755EC")]
			private void U_0099b_007E_00A0_0081(IDictionary _008EBÂ_008F_00BB_008B)
			{
			}

			[Token(Token = "0x600149B")]
			[Address(RVA = "0x7375C38", Offset = "0x7371C38", VA = "0x7375C38")]
			private void _009Dq_007B_0095KP(IDictionary _008EBÂ_008F_00BB_008B)
			{
			}

			[Token(Token = "0x600149C")]
			[Address(RVA = "0x737629C", Offset = "0x737229C", VA = "0x737629C")]
			private void _005BG_00A6_0096_008BR(object _00A3_0092T_007E_00ABc)
			{
			}

			[Token(Token = "0x600149D")]
			[Address(RVA = "0x7375A60", Offset = "0x7371A60", VA = "0x7375A60")]
			private void _009F_007C_0089_00A2_00B4_005E(object _00A3_0092T_007E_00ABc)
			{
			}

			[Token(Token = "0x600149E")]
			[Address(RVA = "0x737652C", Offset = "0x737252C", VA = "0x737652C")]
			private void _0099_0098hq_00AF_0096(IList uGYQ_008A_00B8)
			{
			}

			[Token(Token = "0x600149F")]
			[Address(RVA = "0x7371E98", Offset = "0x736DE98", VA = "0x7371E98")]
			private void _008F_0083_009B_008A_00BE_007C(string _008C_00A8_00A1cf_00A6)
			{
			}

			[Token(Token = "0x60014A0")]
			[Address(RVA = "0x73713C4", Offset = "0x736D3C4", VA = "0x73713C4")]
			private void _00BE_005D_008E_00A8L_008C(object _00A3_0092T_007E_00ABc)
			{
			}

			[Token(Token = "0x60014A1")]
			[Address(RVA = "0x737372C", Offset = "0x736F72C", VA = "0x737372C")]
			private void _0085_00B7À_00A2_00B3_0082(object _00A3_0092T_007E_00ABc)
			{
			}

			[Token(Token = "0x60014A2")]
			[Address(RVA = "0x7371A88", Offset = "0x736DA88", VA = "0x7371A88")]
			private void _00A2n_00A6_009DZC(string _008C_00A8_00A1cf_00A6)
			{
			}

			[Token(Token = "0x60014A3")]
			[Address(RVA = "0x7374460", Offset = "0x7370460", VA = "0x7374460")]
			private void t_00B8_0096_00AEµR(string _008C_00A8_00A1cf_00A6)
			{
			}

			[Token(Token = "0x60014A4")]
			[Address(RVA = "0x7376D00", Offset = "0x7372D00", VA = "0x7376D00")]
			private void L_00A0_00A2PÂ_009D(IDictionary _008EBÂ_008F_00BB_008B)
			{
			}

			[Token(Token = "0x60014A5")]
			[Address(RVA = "0x737718C", Offset = "0x737318C", VA = "0x737718C")]
			private void _00BC_007B_008A_00AF_00A2h(string _008C_00A8_00A1cf_00A6)
			{
			}

			[Token(Token = "0x60014A6")]
			[Address(RVA = "0x73760C4", Offset = "0x73720C4", VA = "0x73760C4")]
			private void _00B4r_00ADf_00A2_00AB(object _00A3_0092T_007E_00ABc)
			{
			}

			[Token(Token = "0x60014A7")]
			[Address(RVA = "0x7376874", Offset = "0x7372874", VA = "0x7376874")]
			private void wD_00BExK_00BB(IDictionary _008EBÂ_008F_00BB_008B)
			{
			}

			[Token(Token = "0x60014A8")]
			[Address(RVA = "0x7377414", Offset = "0x7373414", VA = "0x7377414")]
			private void _00A9h_0099_0096Jv(object _00A3_0092T_007E_00ABc)
			{
			}

			[Token(Token = "0x60014A9")]
			[Address(RVA = "0x7373FF8", Offset = "0x736FFF8", VA = "0x7373FF8")]
			private void _00AF_00ACV_0080_0096P(object _00A3_0092T_007E_00ABc)
			{
			}

			[Token(Token = "0x60014AA")]
			[Address(RVA = "0x7373488", Offset = "0x736F488", VA = "0x7373488")]
			private void M_0098_008F_0095_009BO(string _008C_00A8_00A1cf_00A6)
			{
			}

			[Token(Token = "0x60014AB")]
			[Address(RVA = "0x73776A4", Offset = "0x73736A4", VA = "0x73776A4")]
			private void _0085_00B9bc_00A6l(object _00A3_0092T_007E_00ABc)
			{
			}
		}

		[Token(Token = "0x6001450")]
		[Address(RVA = "0x736E634", Offset = "0x736A634", VA = "0x736E634")]
		public static object Deserialize(string º_0086_005Bfbµ)
		{
			return null;
		}

		[Token(Token = "0x6001451")]
		[Address(RVA = "0x736E7E8", Offset = "0x736A7E8", VA = "0x736E7E8")]
		public static string Serialize(object _008EBÂ_008F_00BB_008B)
		{
			return null;
		}
	}
}
