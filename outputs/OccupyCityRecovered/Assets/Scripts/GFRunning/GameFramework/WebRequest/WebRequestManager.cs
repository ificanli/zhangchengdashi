using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GameFramework.Base;
using Il2CppDummyDll;
using UnityEngine;

namespace GameFramework.WebRequest
{
	[Token(Token = "0x2000441")]
	public class WebRequestManager : MonoBehaviour
	{
		[Token(Token = "0x4001DDC")]
		[FieldOffset(Offset = "0x0")]
		private static WebRequestManager O_00BEªA_00BE_007C;

		[Token(Token = "0x4001DDD")]
		[FieldOffset(Offset = "0x20")]
		private global::_00BCV_00B7_00A5_0096_007B<_0082c_00A0_00A2JK> _008CEcO_00A0_007F;

		[Token(Token = "0x4001DDE")]
		[FieldOffset(Offset = "0x28")]
		private float _00ABTZ_00BC_0094_00AC;

		[Token(Token = "0x4001DDF")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<string, string> ap_0095_0086b_0081;

		[Token(Token = "0x4001DE0")]
		[FieldOffset(Offset = "0x38")]
		private Type _009EÀvNrx;

		[Token(Token = "0x4001DE1")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<string, int> _008E_008DPLC_0060;

		[Token(Token = "0x4001DE2")]
		[FieldOffset(Offset = "0x48")]
		private Dictionary<string, int> _00A7_00AE_00B4Â_0083o;

		[Token(Token = "0x4001DE3")]
		[FieldOffset(Offset = "0x50")]
		private float _0088_007BK_00B6_00A3L;

		[Token(Token = "0x1700118F")]
		public static WebRequestManager Instance
		{
			[Token(Token = "0x60068CD")]
			[Address(RVA = "0x7270DE0", Offset = "0x726CDE0", VA = "0x7270DE0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001190")]
		public int TotalAgentCount
		{
			[Token(Token = "0x60068BF")]
			[Address(RVA = "0x726F6BC", Offset = "0x726B6BC", VA = "0x726F6BC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17001191")]
		public int FreeAgentCount
		{
			[Token(Token = "0x60068D2")]
			[Address(RVA = "0x726F934", Offset = "0x726B934", VA = "0x726F934")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17001192")]
		public int WorkingAgentCount
		{
			[Token(Token = "0x60068B6")]
			[Address(RVA = "0x726EF1C", Offset = "0x726AF1C", VA = "0x726EF1C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17001193")]
		public int WaitingTaskCount
		{
			[Token(Token = "0x60068F1")]
			[Address(RVA = "0x7272618", Offset = "0x726E618", VA = "0x7272618")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17001194")]
		public float Timeout
		{
			[Token(Token = "0x60068F0")]
			[Address(RVA = "0x7272610", Offset = "0x726E610", VA = "0x7272610")]
			get
			{
				return default;
			}
			[Token(Token = "0x60068D9")]
			[Address(RVA = "0x72713C8", Offset = "0x726D3C8", VA = "0x72713C8")]
			set
			{
			}
		}

		[Token(Token = "0x17001195")]
		public int WorkingTaskCapacity
		{
			[Token(Token = "0x60068B7")]
			[Address(RVA = "0x726EF6C", Offset = "0x726AF6C", VA = "0x726EF6C")]
			get
			{
				return default;
			}
			[Token(Token = "0x60068E4")]
			[Address(RVA = "0x7271BAC", Offset = "0x726DBAC", VA = "0x7271BAC")]
			set
			{
			}
		}

		[Token(Token = "0x60068B5")]
		[Address(RVA = "0x726ED58", Offset = "0x726AD58", VA = "0x726ED58")]
		public int AddWebRequest(string _008E_00B0_008Au_007D_009C, Action<int, GameFrameworkEventArgs> _0060_00A9_00ACaJ_00A2)
		{
			return default;
		}

		[SpecialName]
		[Token(Token = "0x60068B8")]
		[Address(RVA = "0x726EFB4", Offset = "0x726AFB4", VA = "0x726EFB4")]
		public static WebRequestManager _008CÀÁ_00A0y_00B9()
		{
			return null;
		}

		[SpecialName]
		[Token(Token = "0x60068B9")]
		[Address(RVA = "0x726F228", Offset = "0x726B228", VA = "0x726F228")]
		public int xC_00AFy_00B3c()
		{
			return default;
		}

		[Token(Token = "0x60068BA")]
		[Address(RVA = "0x726F278", Offset = "0x726B278", VA = "0x726F278")]
		private void _00A9_00BD_008F_008Eek(_00A4ºbYj_0099 _00B2w_00B7_00A7h_00B9)
		{
		}

		[Token(Token = "0x60068BB")]
		[Address(RVA = "0x726F2E8", Offset = "0x726B2E8", VA = "0x726F2E8")]
		public void Shutdown()
		{
		}

		[SpecialName]
		[Token(Token = "0x60068BC")]
		[Address(RVA = "0x726F39C", Offset = "0x726B39C", VA = "0x726F39C")]
		public static WebRequestManager v_00B0_0093O_00BED()
		{
			return null;
		}

		[SpecialName]
		[Token(Token = "0x60068BD")]
		[Address(RVA = "0x726F614", Offset = "0x726B614", VA = "0x726F614")]
		public int f_0087_00A2_00AC_005D_00A9()
		{
			return default;
		}

		[Token(Token = "0x60068BE")]
		[Address(RVA = "0x726F664", Offset = "0x726B664", VA = "0x726F664")]
		public bool ª_00AFb_005EÂE(int zy_0086NXI)
		{
			return default;
		}

		[Token(Token = "0x60068C0")]
		[Address(RVA = "0x726F70C", Offset = "0x726B70C", VA = "0x726F70C")]
		public TaskInfo[] GetAllWebRequestInfos()
		{
			return null;
		}

		[Token(Token = "0x60068C1")]
		[Address(RVA = "0x726F75C", Offset = "0x726B75C", VA = "0x726F75C")]
		public int _00B2d_00A5_009E_00B1l(string _008E_00B0_008Au_007D_009C, Action<int, GameFrameworkEventArgs> _0060_00A9_00ACaJ_00A2)
		{
			return default;
		}

		[Token(Token = "0x60068C2")]
		[Address(RVA = "0x726F770", Offset = "0x726B770", VA = "0x726F770")]
		public int _00B9_0096_008AZÁ_00A8(string _008E_00B0_008Au_007D_009C, Action<int, GameFrameworkEventArgs> _0060_00A9_00ACaJ_00A2)
		{
			return default;
		}

		[Token(Token = "0x60068C3")]
		[Address(RVA = "0x726F784", Offset = "0x726B784", VA = "0x726F784")]
		public int _00BC_0091_009D_00A5_0082_00A4(string _008E_00B0_008Au_007D_009C, byte[] _008E_00A2_0090_008EP_009C, int rVlHªB, object _00B4sT_00ABV_007E, Action<int, GameFrameworkEventArgs> _0060_00A9_00ACaJ_00A2)
		{
			return default;
		}

		[Token(Token = "0x60068C4")]
		[Address(RVA = "0x726F58C", Offset = "0x726B58C", VA = "0x726F58C")]
		private void _009E_00A5_0087Qd_005B()
		{
		}

		[Token(Token = "0x60068C5")]
		[Address(RVA = "0x7270704", Offset = "0x726C704", VA = "0x7270704")]
		public int _0090_008F_009Dª_008F_009E(string _008E_00B0_008Au_007D_009C, object _008E_00A2_0090_008EP_009C, int rVlHªB, Action<int, GameFrameworkEventArgs> _0060_00A9_00ACaJ_00A2)
		{
			return default;
		}

		[Token(Token = "0x60068C6")]
		[Address(RVA = "0x72707D4", Offset = "0x726C7D4", VA = "0x72707D4")]
		private void Update()
		{
		}

		[Token(Token = "0x60068C7")]
		[Address(RVA = "0x727092C", Offset = "0x726C92C", VA = "0x727092C")]
		public int _00BCz_0088zy_00B0(string _008E_00B0_008Au_007D_009C, object _00B4sT_00ABV_007E, Action<int, GameFrameworkEventArgs> _0060_00A9_00ACaJ_00A2)
		{
			return default;
		}

		[SpecialName]
		[Token(Token = "0x60068C8")]
		[Address(RVA = "0x7270940", Offset = "0x726C940", VA = "0x7270940")]
		public int _0097º_00B1iYB()
		{
			return default;
		}

		[Token(Token = "0x60068C9")]
		[Address(RVA = "0x7270990", Offset = "0x726C990", VA = "0x7270990")]
		public int À_0091_00A0_008Da_009B(string _008E_00B0_008Au_007D_009C, string _008E_00A2_0090_008EP_009C, Action<int, GameFrameworkEventArgs> _0060_00A9_00ACaJ_00A2, object _00B4sT_00ABV_007E)
		{
			return default;
		}

		[Token(Token = "0x60068CA")]
		[Address(RVA = "0x7270BC0", Offset = "0x726CBC0", VA = "0x7270BC0")]
		private void _0094_0082_0089AJ_00A2()
		{
		}

		[Token(Token = "0x60068CB")]
		[Address(RVA = "0x7270D20", Offset = "0x726CD20", VA = "0x7270D20")]
		public void _009F_005Bm_00A2x_00BC()
		{
		}

		[Token(Token = "0x60068CC")]
		[Address(RVA = "0x7270D70", Offset = "0x726CD70", VA = "0x7270D70")]
		private void X_00AD_00AF_0086_00B3_00B8(_00A4ºbYj_0099 _00B2w_00B7_00A7h_00B9, string _00A6_008D_0086_007Cq_0095)
		{
		}

		[Token(Token = "0x60068CE")]
		[Address(RVA = "0x7270FBC", Offset = "0x726CFBC", VA = "0x7270FBC")]
		public int AddWebRequest(string _008E_00B0_008Au_007D_009C, string _008E_00A2_0090_008EP_009C, Action<int, GameFrameworkEventArgs> _0060_00A9_00ACaJ_00A2, object _00B4sT_00ABV_007E)
		{
			return default;
		}

		[Token(Token = "0x60068CF")]
		[Address(RVA = "0x727103C", Offset = "0x726D03C", VA = "0x727103C")]
		public void SetRequestHeader(string _0088_00A7_00B0_00B8Y_0090, string _00A3_0092T_007E_00ABc)
		{
		}

		[Token(Token = "0x60068D0")]
		[Address(RVA = "0x726F1A4", Offset = "0x726B1A4", VA = "0x726F1A4")]
		private void _00B4_00ABl_00A0_008A_005B()
		{
		}

		[Token(Token = "0x60068D1")]
		[Address(RVA = "0x7271230", Offset = "0x726D230", VA = "0x7271230")]
		private void _0083y_0095_00BB_00A9I(_00A4ºbYj_0099 _00B2w_00B7_00A7h_00B9, byte[] _00A4PCA_00A2_00AD)
		{
		}

		[Token(Token = "0x60068D3")]
		[Address(RVA = "0x72712A0", Offset = "0x726D2A0", VA = "0x72712A0")]
		public void _0086Na_0089_007D_0094()
		{
		}

		[SpecialName]
		[Token(Token = "0x60068D4")]
		[Address(RVA = "0x72712F8", Offset = "0x726D2F8", VA = "0x72712F8")]
		public int t_00B6_005Db_009AU()
		{
			return default;
		}

		[Token(Token = "0x60068D5")]
		[Address(RVA = "0x7271340", Offset = "0x726D340", VA = "0x7271340")]
		public int t_00B3_0092jÂg(string _008E_00B0_008Au_007D_009C, byte[] _008E_00A2_0090_008EP_009C, Action<int, GameFrameworkEventArgs> _0060_00A9_00ACaJ_00A2)
		{
			return default;
		}

		[Token(Token = "0x60068D6")]
		[Address(RVA = "0x7271350", Offset = "0x726D350", VA = "0x7271350")]
		public int AddWebRequest(string _008E_00B0_008Au_007D_009C, object _00B4sT_00ABV_007E, Action<int, GameFrameworkEventArgs> _0060_00A9_00ACaJ_00A2)
		{
			return default;
		}

		[SpecialName]
		[Token(Token = "0x60068D7")]
		[Address(RVA = "0x7271364", Offset = "0x726D364", VA = "0x7271364")]
		public int urD_0091_0080_00A3()
		{
			return default;
		}

		[Token(Token = "0x60068D8")]
		[Address(RVA = "0x72713B4", Offset = "0x726D3B4", VA = "0x72713B4")]
		public int z_0060º_00AF_0090N(string _008E_00B0_008Au_007D_009C, Action<int, GameFrameworkEventArgs> _0060_00A9_00ACaJ_00A2)
		{
			return default;
		}

		[Token(Token = "0x60068DA")]
		[Address(RVA = "0x726F984", Offset = "0x726B984", VA = "0x726F984")]
		private void xyp_00ACK_00BB(IWebRequestAgentHelper _0082EÂ_005B_009At)
		{
		}

		[Token(Token = "0x60068DB")]
		[Address(RVA = "0x72713D0", Offset = "0x726D3D0", VA = "0x72713D0")]
		private void _0092Iº_005DTe(string _008E_00B0_008Au_007D_009C)
		{
		}

		[Token(Token = "0x60068DC")]
		[Address(RVA = "0x7270554", Offset = "0x726C554", VA = "0x7270554")]
		private void x_0085Jcmo()
		{
		}

		[Token(Token = "0x60068DD")]
		[Address(RVA = "0x72719A8", Offset = "0x726D9A8", VA = "0x72719A8")]
		private void y_00A4_0082_0060hD(_00A4ºbYj_0099 _00B2w_00B7_00A7h_00B9, byte[] _00A4PCA_00A2_00AD)
		{
		}

		[SpecialName]
		[Token(Token = "0x60068DE")]
		[Address(RVA = "0x7271A18", Offset = "0x726DA18", VA = "0x7271A18")]
		public void _009CGio_00A5_0090(float _00A3_0092T_007E_00ABc)
		{
		}

		[Token(Token = "0x60068DF")]
		[Address(RVA = "0x726ED6C", Offset = "0x726AD6C", VA = "0x726ED6C")]
		public int AddWebRequest(string _008E_00B0_008Au_007D_009C, byte[] _008E_00A2_0090_008EP_009C, int rVlHªB, object _00B4sT_00ABV_007E, Action<int, GameFrameworkEventArgs> _0060_00A9_00ACaJ_00A2)
		{
			return default;
		}

		[Token(Token = "0x60068E0")]
		[Address(RVA = "0x7271A20", Offset = "0x726DA20", VA = "0x7271A20")]
		public void ClearRequestHeader()
		{
		}

		[SpecialName]
		[Token(Token = "0x60068E1")]
		[Address(RVA = "0x7271A78", Offset = "0x726DA78", VA = "0x7271A78")]
		public int W_00BD_00BB_00A6Ch()
		{
			return default;
		}

		[Token(Token = "0x60068E2")]
		[Address(RVA = "0x7271AC8", Offset = "0x726DAC8", VA = "0x7271AC8")]
		public int AddWebRequest(string _008E_00B0_008Au_007D_009C, object _008E_00A2_0090_008EP_009C, int rVlHªB, Action<int, GameFrameworkEventArgs> _0060_00A9_00ACaJ_00A2)
		{
			return default;
		}

		[Token(Token = "0x60068E3")]
		[Address(RVA = "0x7271B98", Offset = "0x726DB98", VA = "0x7271B98")]
		public int AddWebRequest(string _008E_00B0_008Au_007D_009C, int rVlHªB, Action<int, GameFrameworkEventArgs> _0060_00A9_00ACaJ_00A2)
		{
			return default;
		}

		[Token(Token = "0x60068E5")]
		[Address(RVA = "0x7270A10", Offset = "0x726CA10", VA = "0x7270A10")]
		public int _00B0W_0088_008Aº_00A7(string _008E_00B0_008Au_007D_009C, byte[] _008E_00A2_0090_008EP_009C, int rVlHªB, object _00B4sT_00ABV_007E, Action<int, GameFrameworkEventArgs> _0060_00A9_00ACaJ_00A2)
		{
			return default;
		}

		[Token(Token = "0x60068E6")]
		[Address(RVA = "0x7271E4C", Offset = "0x726DE4C", VA = "0x7271E4C")]
		public void RemoveAllWebRequests()
		{
		}

		[Token(Token = "0x60068E7")]
		[Address(RVA = "0x7271E9C", Offset = "0x726DE9C", VA = "0x7271E9C")]
		public int AddWebRequest(string _008E_00B0_008Au_007D_009C, object _008E_00A2_0090_008EP_009C, Action<int, GameFrameworkEventArgs> _0060_00A9_00ACaJ_00A2, object _00B4sT_00ABV_007E)
		{
			return default;
		}

		[Token(Token = "0x60068E8")]
		[Address(RVA = "0x72720D0", Offset = "0x726E0D0", VA = "0x72720D0")]
		public bool RemoveWebRequest(int zy_0086NXI)
		{
			return default;
		}

		[Token(Token = "0x60068E9")]
		[Address(RVA = "0x7272128", Offset = "0x726E128", VA = "0x7272128")]
		private void m_00A4_008Dc_00A6_00B9()
		{
		}

		[SpecialName]
		[Token(Token = "0x60068EA")]
		[Address(RVA = "0x727228C", Offset = "0x726E28C", VA = "0x727228C")]
		public void _0088_00ADd_0098_008B_007C(int _00A3_0092T_007E_00ABc)
		{
		}

		[Token(Token = "0x60068EB")]
		[Address(RVA = "0x72722D8", Offset = "0x726E2D8", VA = "0x72722D8")]
		public int _009E_005Bm_00AD_00BF_0088(string _008E_00B0_008Au_007D_009C, int rVlHªB, Action<int, GameFrameworkEventArgs> _0060_00A9_00ACaJ_00A2)
		{
			return default;
		}

		[Token(Token = "0x60068EC")]
		[Address(RVA = "0x72722EC", Offset = "0x726E2EC", VA = "0x72722EC")]
		public int AddWebRequest(string _008E_00B0_008Au_007D_009C, byte[] _008E_00A2_0090_008EP_009C, int rVlHªB, Action<int, GameFrameworkEventArgs> _0060_00A9_00ACaJ_00A2)
		{
			return default;
		}

		[Token(Token = "0x60068ED")]
		[Address(RVA = "0x72722F8", Offset = "0x726E2F8", VA = "0x72722F8")]
		public WebRequestManager()
		{
		}

		[Token(Token = "0x60068EE")]
		[Address(RVA = "0x7272388", Offset = "0x726E388", VA = "0x7272388")]
		public bool FQU_0060ÂP(int zy_0086NXI)
		{
			return default;
		}

		[Token(Token = "0x60068EF")]
		[Address(RVA = "0x72723E0", Offset = "0x726E3E0", VA = "0x72723E0")]
		public int H_008B_005Dkª_00A9(string _008E_00B0_008Au_007D_009C, object _008E_00A2_0090_008EP_009C, Action<int, GameFrameworkEventArgs> _0060_00A9_00ACaJ_00A2, object _00B4sT_00ABV_007E)
		{
			return default;
		}

		[Token(Token = "0x60068F2")]
		[Address(RVA = "0x7272668", Offset = "0x726E668", VA = "0x7272668")]
		public int _00BFc_0089_00AB_00A5_00A7(string _008E_00B0_008Au_007D_009C, object _00B4sT_00ABV_007E, Action<int, GameFrameworkEventArgs> _0060_00A9_00ACaJ_00A2)
		{
			return default;
		}

		[SpecialName]
		[Token(Token = "0x60068F3")]
		[Address(RVA = "0x727267C", Offset = "0x726E67C", VA = "0x727267C")]
		public int _00B0_0088_00B2_00B9À_00BE()
		{
			return default;
		}

		[Token(Token = "0x60068F4")]
		[Address(RVA = "0x72726CC", Offset = "0x726E6CC", VA = "0x72726CC")]
		public TaskInfo[] _0083c_00B2_008Cz_009F()
		{
			return null;
		}

		[Token(Token = "0x60068F5")]
		[Address(RVA = "0x726FD14", Offset = "0x726BD14", VA = "0x726FD14")]
		private void _008CK_00A1_008E_00B4q(string _008E_00B0_008Au_007D_009C)
		{
		}

		[Token(Token = "0x60068F6")]
		[Address(RVA = "0x727271C", Offset = "0x726E71C", VA = "0x727271C")]
		public void _0087f_00AC_00A8j_008A(string _0088_00A7_00B0_00B8Y_0090, string _00A3_0092T_007E_00ABc)
		{
		}

		[Token(Token = "0x60068F7")]
		[Address(RVA = "0x7272914", Offset = "0x726E914", VA = "0x7272914")]
		public TaskInfo[] _008A_009A_007Bf_0099_0084()
		{
			return null;
		}

		[Token(Token = "0x60068F8")]
		[Address(RVA = "0x7272964", Offset = "0x726E964", VA = "0x7272964")]
		public int _0088_00A8_007CM_008D_008E(string _008E_00B0_008Au_007D_009C, byte[] _008E_00A2_0090_008EP_009C, int rVlHªB, Action<int, GameFrameworkEventArgs> _0060_00A9_00ACaJ_00A2)
		{
			return default;
		}

		[Token(Token = "0x60068F9")]
		[Address(RVA = "0x7272970", Offset = "0x726E970", VA = "0x7272970")]
		public int mÂU_007C_008BH(string _008E_00B0_008Au_007D_009C, byte[] _008E_00A2_0090_008EP_009C, int rVlHªB, Action<int, GameFrameworkEventArgs> _0060_00A9_00ACaJ_00A2)
		{
			return default;
		}

		[Token(Token = "0x60068FA")]
		[Address(RVA = "0x727297C", Offset = "0x726E97C", VA = "0x727297C")]
		public int N_0085jV_00B4Q(string _008E_00B0_008Au_007D_009C, Action<int, GameFrameworkEventArgs> _0060_00A9_00ACaJ_00A2)
		{
			return default;
		}

		[Token(Token = "0x60068FB")]
		[Address(RVA = "0x7272990", Offset = "0x726E990", VA = "0x7272990")]
		private void _00AFm_008E_0086_0082_00B3(_00A4ºbYj_0099 _00B2w_00B7_00A7h_00B9, string _00A6_008D_0086_007Cq_0095)
		{
		}

		[Token(Token = "0x60068FC")]
		[Address(RVA = "0x7272A00", Offset = "0x726EA00", VA = "0x7272A00")]
		private void l_009C_0098_00B2_0084_00BC(_00A4ºbYj_0099 _00B2w_00B7_00A7h_00B9)
		{
		}

		[Token(Token = "0x60068FD")]
		[Address(RVA = "0x7272A70", Offset = "0x726EA70", VA = "0x7272A70")]
		public int AddWebRequest(string _008E_00B0_008Au_007D_009C, byte[] _008E_00A2_0090_008EP_009C, Action<int, GameFrameworkEventArgs> _0060_00A9_00ACaJ_00A2)
		{
			return default;
		}
	}
}
