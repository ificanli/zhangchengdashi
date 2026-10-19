using System;
using Il2CppDummyDll;
using UnityEngine.Networking;

namespace GameFramework.Download
{
	[Token(Token = "0x200049C")]
	public class UnityWebRequestDownloadAgentHelper : DownloadAgentHelperBase
	{
		[Token(Token = "0x200049D")]
		private sealed class _005Dq_0094_00A6SU : DownloadHandlerScript
		{
			[Token(Token = "0x4001F03")]
			[FieldOffset(Offset = "0x18")]
			private readonly UnityWebRequestDownloadAgentHelper _0091_00A7_00BFx_00AD_00BB;

			[Token(Token = "0x6006DA2")]
			[Address(RVA = "0x729D8E4", Offset = "0x72998E4", VA = "0x729D8E4", Slot = "9")]
			protected override bool ReceiveData(byte[] _009F_0080_005B_009F_0086_0089, int _008E_00A7pq_00A4z)
			{
				return default;
			}

			[Token(Token = "0x6006DA3")]
			[Address(RVA = "0x729BE38", Offset = "0x7297E38", VA = "0x729BE38")]
			public _005Dq_0094_00A6SU(UnityWebRequestDownloadAgentHelper Z_009Aj_009Bqd)
			{
			}
		}

		[Token(Token = "0x4001EFB")]
		private const int µ_009CN_008Ex_00B7 = 4096;

		[Token(Token = "0x4001EFC")]
		[FieldOffset(Offset = "0x20")]
		private readonly byte[] rPm_00A9KN;

		[Token(Token = "0x4001EFD")]
		[FieldOffset(Offset = "0x28")]
		private UnityWebRequest _007C_009FMª_0092_007E;

		[Token(Token = "0x4001EFE")]
		[FieldOffset(Offset = "0x30")]
		private bool YDSE_0060u;

		[Token(Token = "0x4001EFF")]
		[FieldOffset(Offset = "0x38")]
		private EventHandler<DownloadAgentHelperUpdateBytesEventArgs> uy_0098QrO;

		[Token(Token = "0x4001F00")]
		[FieldOffset(Offset = "0x40")]
		private EventHandler<DownloadAgentHelperUpdateLengthEventArgs> M_00B6_0096G_0060M;

		[Token(Token = "0x4001F01")]
		[FieldOffset(Offset = "0x48")]
		private EventHandler<DownloadAgentHelperCompleteEventArgs> _0083ar_008Ao_0096;

		[Token(Token = "0x4001F02")]
		[FieldOffset(Offset = "0x50")]
		private EventHandler<DownloadAgentHelperErrorEventArgs> _008CMP_009F_008Ae;

		[Token(Token = "0x14000025")]
		public override event EventHandler<DownloadAgentHelperUpdateBytesEventArgs> DownloadAgentHelperUpdateBytes
		{
			[Token(Token = "0x6006DA0")]
			[Address(RVA = "0x729D808", Offset = "0x7299808", VA = "0x729D808", Slot = "17")]
			add
			{
			}
			[Token(Token = "0x6006D98")]
			[Address(RVA = "0x729D3E0", Offset = "0x72993E0", VA = "0x729D3E0", Slot = "18")]
			remove
			{
			}
		}

		[Token(Token = "0x14000026")]
		public override event EventHandler<DownloadAgentHelperUpdateLengthEventArgs> DownloadAgentHelperUpdateLength
		{
			[Token(Token = "0x6006D9D")]
			[Address(RVA = "0x729D680", Offset = "0x7299680", VA = "0x729D680", Slot = "19")]
			add
			{
			}
			[Token(Token = "0x6006D69")]
			[Address(RVA = "0x729B060", Offset = "0x7297060", VA = "0x729B060", Slot = "20")]
			remove
			{
			}
		}

		[Token(Token = "0x14000027")]
		public override event EventHandler<DownloadAgentHelperCompleteEventArgs> DownloadAgentHelperComplete
		{
			[Token(Token = "0x6006D6C")]
			[Address(RVA = "0x729B1E8", Offset = "0x72971E8", VA = "0x729B1E8", Slot = "21")]
			add
			{
			}
			[Token(Token = "0x6006D8E")]
			[Address(RVA = "0x729CF3C", Offset = "0x7298F3C", VA = "0x729CF3C", Slot = "22")]
			remove
			{
			}
		}

		[Token(Token = "0x14000028")]
		public override event EventHandler<DownloadAgentHelperErrorEventArgs> DownloadAgentHelperError
		{
			[Token(Token = "0x6006D6A")]
			[Address(RVA = "0x729B108", Offset = "0x7297108", VA = "0x729B108", Slot = "23")]
			add
			{
			}
			[Token(Token = "0x6006D70")]
			[Address(RVA = "0x729B54C", Offset = "0x729754C", VA = "0x729B54C", Slot = "24")]
			remove
			{
			}
		}

		[Token(Token = "0x6006D6B")]
		[Address(RVA = "0x729B1B0", Offset = "0x72971B0", VA = "0x729B1B0", Slot = "30")]
		protected virtual void _0098N_009C_008Bar(bool _008ASp_0084_009D_008C)
		{
		}

		[Token(Token = "0x6006D6D")]
		[Address(RVA = "0x729B290", Offset = "0x7297290", VA = "0x729B290")]
		public void _008F_0089_00B1K_00A0_00B4()
		{
		}

		[Token(Token = "0x6006D6E")]
		[Address(RVA = "0x729B300", Offset = "0x7297300", VA = "0x729B300", Slot = "31")]
		protected virtual void Dispose(bool _008ASp_0084_009D_008C)
		{
		}

		[Token(Token = "0x6006D6F")]
		[Address(RVA = "0x729B338", Offset = "0x7297338", VA = "0x729B338")]
		private void f_00BC_00B8_00A7_00AEd()
		{
		}

		[Token(Token = "0x6006D71")]
		[Address(RVA = "0x729B5F4", Offset = "0x72975F4", VA = "0x729B5F4")]
		public void A_00AFK_009BÂ_0093()
		{
		}

		[Token(Token = "0x6006D72")]
		[Address(RVA = "0x729B664", Offset = "0x7297664", VA = "0x729B664")]
		private void H_0098QfN_0090()
		{
		}

		[Token(Token = "0x6006D73")]
		[Address(RVA = "0x729B7D0", Offset = "0x72977D0", VA = "0x729B7D0")]
		private void d_00A3_005B_00A5Jr()
		{
		}

		[Token(Token = "0x6006D74")]
		[Address(RVA = "0x729B9E8", Offset = "0x72979E8", VA = "0x729B9E8")]
		public void _007F_00B1_008B_007Bg_005B()
		{
		}

		[Token(Token = "0x6006D75")]
		[Address(RVA = "0x729BA58", Offset = "0x7297A58", VA = "0x729BA58")]
		public void J_00B8_00B0ªlH()
		{
		}

		[Token(Token = "0x6006D76")]
		[Address(RVA = "0x729BAC8", Offset = "0x7297AC8", VA = "0x729BAC8")]
		private void m_00A4_008Dc_00A6_00B9()
		{
		}

		[Token(Token = "0x6006D77")]
		[Address(RVA = "0x729BC34", Offset = "0x7297C34", VA = "0x729BC34", Slot = "27")]
		public override void Download(string _0060_00A6zºZ_00B4, int _0095Ad_00BCVO, int zÀ_0084L_00A8_0089, object _00B4sT_00ABV_007E)
		{
		}

		[Token(Token = "0x6006D78")]
		[Address(RVA = "0x729BE6C", Offset = "0x7297E6C", VA = "0x729BE6C", Slot = "32")]
		protected virtual void QY_009D_0088_007DK(bool _008ASp_0084_009D_008C)
		{
		}

		[Token(Token = "0x6006D79")]
		[Address(RVA = "0x729BEA4", Offset = "0x7297EA4", VA = "0x729BEA4")]
		private void x_008Fc_0098_00A1_00A8()
		{
		}

		[Token(Token = "0x6006D7A")]
		[Address(RVA = "0x729C0B8", Offset = "0x72980B8", VA = "0x729C0B8", Slot = "25")]
		public override void Download(string _0060_00A6zºZ_00B4, object _00B4sT_00ABV_007E)
		{
		}

		[Token(Token = "0x6006D7B")]
		[Address(RVA = "0x729C230", Offset = "0x7298230", VA = "0x729C230", Slot = "33")]
		protected virtual void AYmÀm_00B9(bool _008ASp_0084_009D_008C)
		{
		}

		[Token(Token = "0x6006D7C")]
		[Address(RVA = "0x729C268", Offset = "0x7298268", VA = "0x729C268")]
		private void Update()
		{
		}

		[Token(Token = "0x6006D7D")]
		[Address(RVA = "0x729C364", Offset = "0x7298364", VA = "0x729C364", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006D7E")]
		[Address(RVA = "0x729C3AC", Offset = "0x72983AC", VA = "0x729C3AC")]
		public void _007B_0093_00A8_005E_0060_008C()
		{
		}

		[Token(Token = "0x6006D7F")]
		[Address(RVA = "0x729C41C", Offset = "0x729841C", VA = "0x729C41C")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6006D80")]
		[Address(RVA = "0x729C48C", Offset = "0x729848C", VA = "0x729C48C")]
		private void _0083MND_008AM()
		{
		}

		[Token(Token = "0x6006D81")]
		[Address(RVA = "0x729C630", Offset = "0x7298630", VA = "0x729C630")]
		public void ew_00B2_00A9º_008D()
		{
		}

		[Token(Token = "0x6006D82")]
		[Address(RVA = "0x729C6A0", Offset = "0x72986A0", VA = "0x729C6A0")]
		public void k_00B4ÁE_007Ea()
		{
		}

		[Token(Token = "0x6006D83")]
		[Address(RVA = "0x729C710", Offset = "0x7298710", VA = "0x729C710")]
		private void bWdsPA()
		{
		}

		[Token(Token = "0x6006D84")]
		[Address(RVA = "0x729C8B4", Offset = "0x72988B4", VA = "0x729C8B4")]
		public void lhº_0080iQ()
		{
		}

		[Token(Token = "0x6006D85")]
		[Address(RVA = "0x729C924", Offset = "0x7298924", VA = "0x729C924")]
		public void º_00BEr_0080jB()
		{
		}

		[Token(Token = "0x6006D86")]
		[Address(RVA = "0x729C994", Offset = "0x7298994", VA = "0x729C994")]
		private void r_0090_0081kvU()
		{
		}

		[Token(Token = "0x6006D87")]
		[Address(RVA = "0x729CB3C", Offset = "0x7298B3C", VA = "0x729CB3C", Slot = "34")]
		protected virtual void y_0092BR_007CÁ(bool _008ASp_0084_009D_008C)
		{
		}

		[Token(Token = "0x6006D88")]
		[Address(RVA = "0x729CB74", Offset = "0x7298B74", VA = "0x729CB74")]
		private void _0081LY_00AF_0092b()
		{
		}

		[Token(Token = "0x6006D89")]
		[Address(RVA = "0x729CC70", Offset = "0x7298C70", VA = "0x729CC70")]
		public void _008B_00B1_008C_0096Tk()
		{
		}

		[Token(Token = "0x6006D8A")]
		[Address(RVA = "0x729CCE0", Offset = "0x7298CE0", VA = "0x729CCE0", Slot = "35")]
		protected virtual void _0083_00A1_00B7_009C_00A8_00A5(bool _008ASp_0084_009D_008C)
		{
		}

		[Token(Token = "0x6006D8B")]
		[Address(RVA = "0x729CD18", Offset = "0x7298D18", VA = "0x729CD18")]
		public void _00B1_007CsYr_00BC()
		{
		}

		[Token(Token = "0x6006D8C")]
		[Address(RVA = "0x729CD88", Offset = "0x7298D88", VA = "0x729CD88", Slot = "29")]
		public override void Shutdown()
		{
		}

		[Token(Token = "0x6006D8D")]
		[Address(RVA = "0x729CDFC", Offset = "0x7298DFC", VA = "0x729CDFC", Slot = "26")]
		public override void Download(string _0060_00A6zºZ_00B4, int _0095Ad_00BCVO, object _00B4sT_00ABV_007E)
		{
		}

		[Token(Token = "0x6006D8F")]
		[Address(RVA = "0x729CFE4", Offset = "0x7298FE4", VA = "0x729CFE4", Slot = "36")]
		protected virtual void c_0098_00B4_009C_00B0_008D(bool _008ASp_0084_009D_008C)
		{
		}

		[Token(Token = "0x6006D90")]
		[Address(RVA = "0x729D01C", Offset = "0x729901C", VA = "0x729D01C", Slot = "37")]
		protected virtual void ª_008Dr_005B_007B_0092(bool _008ASp_0084_009D_008C)
		{
		}

		[Token(Token = "0x6006D91")]
		[Address(RVA = "0x729D050", Offset = "0x7299050", VA = "0x729D050")]
		public void C_0097TTk_0088()
		{
		}

		[Token(Token = "0x6006D92")]
		[Address(RVA = "0x729D0C0", Offset = "0x72990C0", VA = "0x729D0C0", Slot = "38")]
		protected virtual void _0090P_0091k_008B_00AF(bool _008ASp_0084_009D_008C)
		{
		}

		[Token(Token = "0x6006D93")]
		[Address(RVA = "0x729D0F4", Offset = "0x72990F4", VA = "0x729D0F4", Slot = "39")]
		protected virtual void _00A8Á_00A2_00A8_0095n(bool _008ASp_0084_009D_008C)
		{
		}

		[Token(Token = "0x6006D94")]
		[Address(RVA = "0x729D128", Offset = "0x7299128", VA = "0x729D128")]
		public void _008CF_007C_0086ªh()
		{
		}

		[Token(Token = "0x6006D95")]
		[Address(RVA = "0x729D198", Offset = "0x7299198", VA = "0x729D198")]
		private void _0091GX_0094zA()
		{
		}

		[Token(Token = "0x6006D96")]
		[Address(RVA = "0x729D33C", Offset = "0x729933C", VA = "0x729D33C")]
		public void _007F_0082_00ABaXx()
		{
		}

		[Token(Token = "0x6006D97")]
		[Address(RVA = "0x729D3AC", Offset = "0x72993AC", VA = "0x729D3AC", Slot = "40")]
		protected virtual void _007Cw_007C_009C_00A6H(bool _008ASp_0084_009D_008C)
		{
		}

		[Token(Token = "0x6006D99")]
		[Address(RVA = "0x729D488", Offset = "0x7299488", VA = "0x729D488")]
		public void _00AD_0085_009B_008B_005BJ()
		{
		}

		[Token(Token = "0x6006D9A")]
		[Address(RVA = "0x729D4F8", Offset = "0x72994F8", VA = "0x729D4F8", Slot = "41")]
		protected virtual void _00BC_00B9_0088_005B_00A8_0094(bool _008ASp_0084_009D_008C)
		{
		}

		[Token(Token = "0x6006D9B")]
		[Address(RVA = "0x729D52C", Offset = "0x729952C", VA = "0x729D52C")]
		private void i_0080_008B_00B9_00B0_0093()
		{
		}

		[Token(Token = "0x6006D9C")]
		[Address(RVA = "0x729D628", Offset = "0x7299628", VA = "0x729D628")]
		public UnityWebRequestDownloadAgentHelper()
		{
		}

		[Token(Token = "0x6006D9E")]
		[Address(RVA = "0x729D728", Offset = "0x7299728", VA = "0x729D728")]
		public void v_00BFGa_00A6_0081()
		{
		}

		[Token(Token = "0x6006D9F")]
		[Address(RVA = "0x729D798", Offset = "0x7299798", VA = "0x729D798")]
		public void rA_00A7F_00BE_005D()
		{
		}

		[Token(Token = "0x6006DA1")]
		[Address(RVA = "0x729D8B0", Offset = "0x72998B0", VA = "0x729D8B0", Slot = "42")]
		protected virtual void gh_0089k_00AC_0097(bool _008ASp_0084_009D_008C)
		{
		}
	}
}
