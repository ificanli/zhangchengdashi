using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace GameFramework.Net.Http
{
	[Token(Token = "0x200048C")]
	public class HttpManager : MonoBehaviour, IDisposable
	{
		[Token(Token = "0x4001ED0")]
		[FieldOffset(Offset = "0x0")]
		private static HttpManager O_00BEªA_00BE_007C;

		[Token(Token = "0x4001ED1")]
		[FieldOffset(Offset = "0x20")]
		private LoginTransmitter e_0093G_0098_0091x;

		[Token(Token = "0x4001ED2")]
		[FieldOffset(Offset = "0x28")]
		private bool h_008BgX_0090S;

		[Token(Token = "0x4001ED3")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<int, BaseHttpNetTransmitter> _00A7iMÂ_00ACc;

		[Token(Token = "0x4001ED4")]
		[FieldOffset(Offset = "0x8")]
		internal static string _00A5_0090vp_00A5_00A5;

		[Token(Token = "0x4001ED5")]
		[FieldOffset(Offset = "0x10")]
		internal static bool _0097_009E_0097d_00A7_007C;

		[Token(Token = "0x170011D4")]
		public static HttpManager Instance
		{
			[Token(Token = "0x6006C30")]
			[Address(RVA = "0x728E83C", Offset = "0x728A83C", VA = "0x728E83C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170011D5")]
		public LoginTransmitter LoginTransmitter
		{
			[Token(Token = "0x6006C16")]
			[Address(RVA = "0x728CEC4", Offset = "0x7288EC4", VA = "0x728CEC4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6006C02")]
		[Address(RVA = "0x728BD20", Offset = "0x7287D20", VA = "0x728BD20")]
		internal static void _009A_0087xk_005B_0080(string À_00AC_0088uv_0097, long i_009C_008ESjf)
		{
		}

		[Token(Token = "0x6006C03")]
		[Address(RVA = "0x728BF80", Offset = "0x7287F80", VA = "0x728BF80")]
		internal void ºc_008Aª_0097N(string[] T_0087_007DvBs)
		{
		}

		[Token(Token = "0x6006C04")]
		[Address(RVA = "0x728C014", Offset = "0x7288014", VA = "0x728C014")]
		public void RequestCutoverLoginData(string _00A5_0092_0087_00BEn_0088, string _007EK_00A5_007B_0096_00AC, long _0091_008Co_0097cE)
		{
		}

		[Token(Token = "0x6006C05")]
		[Address(RVA = "0x728C0BC", Offset = "0x72880BC", VA = "0x728C0BC")]
		internal void nrJ_00A1v_0091(string _0096_008BÁ_00B2u_009C, string _00BD_00BD_0098_00B8U_00B4)
		{
		}

		[SpecialName]
		[Token(Token = "0x6006C06")]
		[Address(RVA = "0x728C1B4", Offset = "0x72881B4", VA = "0x728C1B4")]
		public static HttpManager _0092_008B_00A3nKx()
		{
			return null;
		}

		[Token(Token = "0x6006C07")]
		[Address(RVA = "0x728C3E4", Offset = "0x72883E4", VA = "0x728C3E4")]
		public void bv_0084P_0098_0081(string _00B4_0080c_00ABtM)
		{
		}

		[Token(Token = "0x6006C08")]
		[Address(RVA = "0x728C494", Offset = "0x7288494", VA = "0x728C494")]
		internal void _00B4_008F_005E_008AEw()
		{
		}

		[Token(Token = "0x6006C09")]
		[Address(RVA = "0x728C4C8", Offset = "0x72884C8", VA = "0x728C4C8", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6006C0A")]
		[Address(RVA = "0x728C5F4", Offset = "0x72885F4", VA = "0x728C5F4")]
		public static void yh_00A4g_008A_00BC()
		{
		}

		[Token(Token = "0x6006C0C")]
		[Address(RVA = "0x728C75C", Offset = "0x728875C", VA = "0x728C75C")]
		public HttpManager()
		{
		}

		[SpecialName]
		[Token(Token = "0x6006C0D")]
		[Address(RVA = "0x728C7D8", Offset = "0x72887D8", VA = "0x728C7D8")]
		public static HttpManager _005D_0081_009F_009D_00A6L()
		{
			return null;
		}

		[Token(Token = "0x6006C0E")]
		[Address(RVA = "0x728CA08", Offset = "0x7288A08", VA = "0x728CA08")]
		public void _00A6_009BkWÀC()
		{
		}

		[Token(Token = "0x6006C0F")]
		[Address(RVA = "0x728CA3C", Offset = "0x7288A3C", VA = "0x728CA3C")]
		public void _007B_0085_008B_009AXF()
		{
		}

		[SpecialName]
		[Token(Token = "0x6006C10")]
		[Address(RVA = "0x728CA60", Offset = "0x7288A60", VA = "0x728CA60")]
		public static HttpManager y_00A8s_0087F_00BD()
		{
			return null;
		}

		[Token(Token = "0x6006C11")]
		[Address(RVA = "0x728CC90", Offset = "0x7288C90", VA = "0x728CC90")]
		public BaseHttpNetTransmitter GetTransmotter(int _009DZa_00B2_00A3C)
		{
			return null;
		}

		[Token(Token = "0x6006C12")]
		[Address(RVA = "0x728CD00", Offset = "0x7288D00", VA = "0x728CD00")]
		public static void _0082e_0097OTc()
		{
		}

		[Token(Token = "0x6006C13")]
		[Address(RVA = "0x728CE00", Offset = "0x7288E00", VA = "0x728CE00")]
		internal void ª_009E_007D_00A1_007C_00AD(string _0096_008BÁ_00B2u_009C, string _00BD_00BD_0098_00B8U_00B4)
		{
		}

		[Token(Token = "0x6006C14")]
		[Address(RVA = "0x728CE18", Offset = "0x7288E18", VA = "0x728CE18")]
		internal void _008AqZl_007F_0086(string[] T_0087_007DvBs)
		{
		}

		[Token(Token = "0x6006C15")]
		[Address(RVA = "0x728CE30", Offset = "0x7288E30", VA = "0x728CE30")]
		internal void _0093oy_00BDIB(params string[] T_0087_007DvBs)
		{
		}

		[Token(Token = "0x6006C17")]
		[Address(RVA = "0x728CECC", Offset = "0x7288ECC", VA = "0x728CECC")]
		public void _00A4º_0082F_00B3r(string zz_007E_00AC_0096U)
		{
		}

		[Token(Token = "0x6006C18")]
		[Address(RVA = "0x728D07C", Offset = "0x728907C", VA = "0x728D07C")]
		public BaseHttpNetTransmitter _0087pK_00AF_00B1_0098(int _009DZa_00B2_00A3C)
		{
			return null;
		}

		[SpecialName]
		[Token(Token = "0x6006C19")]
		[Address(RVA = "0x728D0EC", Offset = "0x72890EC", VA = "0x728D0EC")]
		public static HttpManager LÁY_0093k_0084()
		{
			return null;
		}

		[Token(Token = "0x6006C1A")]
		[Address(RVA = "0x728D31C", Offset = "0x728931C", VA = "0x728D31C")]
		public BaseHttpNetTransmitter EÂTª_009B_00AC(int _009DZa_00B2_00A3C)
		{
			return null;
		}

		[Token(Token = "0x6006C1B")]
		[Address(RVA = "0x728D38C", Offset = "0x728938C", VA = "0x728D38C")]
		internal void _00A4Md_00A1Ki()
		{
		}

		[Token(Token = "0x6006C1C")]
		[Address(RVA = "0x728D3C0", Offset = "0x72893C0", VA = "0x728D3C0")]
		internal void p_00A9A_009C_0090o(ResponseLoginInfo fM_0082_00B3We)
		{
		}

		[Token(Token = "0x6006C1D")]
		[Address(RVA = "0x728BE58", Offset = "0x7287E58", VA = "0x728BE58")]
		private static void _0096_008B_0082_00AFsi(string _00A3_0092T_007E_00ABc)
		{
		}

		[Token(Token = "0x6006C1E")]
		[Address(RVA = "0x728D428", Offset = "0x7289428", VA = "0x728D428", Slot = "5")]
		public void _007F_00B1_008B_007Bg_005B()
		{
		}

		[Token(Token = "0x6006C1F")]
		[Address(RVA = "0x728D4D4", Offset = "0x72894D4", VA = "0x728D4D4")]
		internal void Hp_007D_0085k_0087(ResponseLoginInfo fM_0082_00B3We)
		{
		}

		[Token(Token = "0x6006C20")]
		[Address(RVA = "0x728D53C", Offset = "0x728953C", VA = "0x728D53C")]
		internal void Á_0090_0090_00B8_00B9_0086(params string[] T_0087_007DvBs)
		{
		}

		[SpecialName]
		[Token(Token = "0x6006C21")]
		[Address(RVA = "0x728D554", Offset = "0x7289554", VA = "0x728D554")]
		public static HttpManager OS_00B0F_009E_00A1()
		{
			return null;
		}

		[Token(Token = "0x6006C22")]
		[Address(RVA = "0x728D784", Offset = "0x7289784", VA = "0x728D784")]
		internal int ª_009E_007D_00A1_007C_00AD(Dictionary<string, string> _007F_008A_00B6_00B4J_007C)
		{
			return default;
		}

		[Token(Token = "0x6006C23")]
		[Address(RVA = "0x728D848", Offset = "0x7289848", VA = "0x728D848")]
		internal void _008F_0086_009CÂGD()
		{
		}

		[SpecialName]
		[Token(Token = "0x6006C24")]
		[Address(RVA = "0x728DB04", Offset = "0x7289B04", VA = "0x728DB04")]
		public static HttpManager _00BDB_0097_00ADZ_008A()
		{
			return null;
		}

		[Token(Token = "0x6006C25")]
		[Address(RVA = "0x728DD34", Offset = "0x7289D34", VA = "0x728DD34")]
		internal static void A_00AB_00A2CPe(string À_00AC_0088uv_0097, long i_009C_008ESjf)
		{
		}

		[Token(Token = "0x6006C26")]
		[Address(RVA = "0x728DE6C", Offset = "0x7289E6C", VA = "0x728DE6C")]
		public void _008F_0084_0080BµC(string zz_007E_00AC_0096U)
		{
		}

		[Token(Token = "0x6006C27")]
		[Address(RVA = "0x728DFD0", Offset = "0x7289FD0", VA = "0x728DFD0")]
		private static void re_007F_009A_0086_008D(string _00A3_0092T_007E_00ABc)
		{
		}

		[Token(Token = "0x6006C28")]
		public T CreateTransmotter<T>(string _009E_008Fjc_008AI, bool _0095Á_00A0_0060_00BB_00A7 = false) where T : BaseHttpNetTransmitter, new()
		{
			return null;
		}

		[Token(Token = "0x6006C29")]
		[Address(RVA = "0x728E0F4", Offset = "0x728A0F4", VA = "0x728E0F4")]
		private static void _007DFpj_00A1_008C(string _00A3_0092T_007E_00ABc)
		{
		}

		[Token(Token = "0x6006C2A")]
		[Address(RVA = "0x728E218", Offset = "0x728A218", VA = "0x728E218", Slot = "6")]
		public void qlhfv_007B()
		{
		}

		[Token(Token = "0x6006C2B")]
		[Address(RVA = "0x728E2C8", Offset = "0x728A2C8", VA = "0x728E2C8")]
		private void Update()
		{
		}

		[Token(Token = "0x6006C2C")]
		[Address(RVA = "0x728E438", Offset = "0x728A438", VA = "0x728E438")]
		public void V_00B3H_0097_0094_00A0(string zz_007E_00AC_0096U)
		{
		}

		[Token(Token = "0x6006C2D")]
		[Address(RVA = "0x728E5EC", Offset = "0x728A5EC", VA = "0x728E5EC")]
		public void UploadUserExtNet(string zz_007E_00AC_0096U)
		{
		}

		[Token(Token = "0x6006C2E")]
		[Address(RVA = "0x728E720", Offset = "0x728A720", VA = "0x728E720")]
		internal void _00B4_00B2z_0087_009D_005D(string _0096_008BÁ_00B2u_009C, string _00BD_00BD_0098_00B8U_00B4)
		{
		}

		[Token(Token = "0x6006C2F")]
		[Address(RVA = "0x728E738", Offset = "0x728A738", VA = "0x728E738")]
		public static void H_005DA_0092Uh()
		{
		}

		[Token(Token = "0x6006C31")]
		[Address(RVA = "0x728EA58", Offset = "0x728AA58", VA = "0x728EA58")]
		[Obsolete("请用CreateTransmotter替换")]
		public void Init(string _00B4_0080c_00ABtM)
		{
		}

		[Token(Token = "0x6006C32")]
		[Address(RVA = "0x728EB0C", Offset = "0x728AB0C", VA = "0x728EB0C")]
		public BaseHttpNetTransmitter v_00A8_005E_00BD_0081_009D(int _009DZa_00B2_00A3C)
		{
			return null;
		}

		[Token(Token = "0x6006C33")]
		[Address(RVA = "0x728EB7C", Offset = "0x728AB7C", VA = "0x728EB7C")]
		internal static void _0092_00ABQ_00B6Qr(string À_00AC_0088uv_0097, long i_009C_008ESjf)
		{
		}

		[Token(Token = "0x6006C34")]
		[Address(RVA = "0x728ECB0", Offset = "0x728ACB0", VA = "0x728ECB0")]
		public static void xxxqqweew()
		{
		}

		[Token(Token = "0x6006C35")]
		[Address(RVA = "0x728EDB4", Offset = "0x728ADB4", VA = "0x728EDB4")]
		public void qsF_008AE_00B1(string zz_007E_00AC_0096U)
		{
		}

		[Token(Token = "0x6006C36")]
		[Address(RVA = "0x728EF3C", Offset = "0x728AF3C", VA = "0x728EF3C")]
		public void RequestServerTime()
		{
		}

		[Token(Token = "0x6006C37")]
		[Address(RVA = "0x728EF60", Offset = "0x728AF60", VA = "0x728EF60")]
		public static void _00A0_0091_008Ec_005De()
		{
		}

		[Token(Token = "0x6006C38")]
		[Address(RVA = "0x728F064", Offset = "0x728B064", VA = "0x728F064")]
		internal void _00BEºhI_00B0_0092()
		{
		}

		[Token(Token = "0x6006C39")]
		[Address(RVA = "0x728F088", Offset = "0x728B088", VA = "0x728F088")]
		internal int sqD_008E_008BÂ(Dictionary<string, string> _007F_008A_00B6_00B4J_007C)
		{
			return default;
		}
	}
}
