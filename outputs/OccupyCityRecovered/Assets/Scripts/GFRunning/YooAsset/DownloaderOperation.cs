using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace YooAsset
{
	[Token(Token = "0x20000E4")]
	public abstract class DownloaderOperation : AsyncOperationBase
	{
		[Token(Token = "0x20000E5")]
		private enum _0092Z_00BC_00B9_007F_005B
		{
			[Token(Token = "0x400033A")]
			None = 0,
			[Token(Token = "0x400033B")]
			Check = 1,
			[Token(Token = "0x400033C")]
			Loading = 2,
			[Token(Token = "0x400033D")]
			Done = 3
		}

		[Token(Token = "0x20000E6")]
		public delegate void OnDownloadOver(bool µ_008B_0086XD_008B);

		[Token(Token = "0x20000E7")]
		public delegate void OnDownloadProgress(int _0091OPnÁn, int _007B_009DO_0097C_0082, long _0087_00B0qd_00A1_00BB, long vV_00B6l_0096_0094);

		[Token(Token = "0x20000E8")]
		public delegate void OnDownloadError(string _0084H_007Fp_0060i, string Á_009B_0082E_00AC_009B);

		[Token(Token = "0x20000E9")]
		public delegate void OnStartDownloadFile(string _0084H_007Fp_0060i, long V_00BB_00BE_007BY_00AF);

		[Token(Token = "0x4000324")]
		private const int UH_007D_00A0_00BDM = 64;

		[Token(Token = "0x4000325")]
		[FieldOffset(Offset = "0x40")]
		private readonly int _00A3gÀ_008E_0094W;

		[Token(Token = "0x4000326")]
		[FieldOffset(Offset = "0x44")]
		private readonly int _008B_009C_0094lS_00BE;

		[Token(Token = "0x4000327")]
		[FieldOffset(Offset = "0x48")]
		private readonly int _00B8_00A9z_00BD_00A0_0082;

		[Token(Token = "0x4000328")]
		[FieldOffset(Offset = "0x50")]
		private readonly List<_007DYXCc_008B> N_005D_00B8_00ADa_00BD;

		[Token(Token = "0x4000329")]
		[FieldOffset(Offset = "0x58")]
		private readonly List<_00A3_00BD_00B8Mpb> G_007B_008An_008Es;

		[Token(Token = "0x400032A")]
		[FieldOffset(Offset = "0x60")]
		private readonly List<_00A3_00BD_00B8Mpb> µ_00BD_0091pN_0082;

		[Token(Token = "0x400032B")]
		[FieldOffset(Offset = "0x68")]
		private readonly List<_00A3_00BD_00B8Mpb> bY_009B_0099yz;

		[Token(Token = "0x400032C")]
		[FieldOffset(Offset = "0x70")]
		private bool mN_00A4L_009Ee;

		[Token(Token = "0x400032D")]
		[FieldOffset(Offset = "0x78")]
		private long _00B6u_007C_0092_00A6_00A3;

		[Token(Token = "0x400032E")]
		[FieldOffset(Offset = "0x80")]
		private int _0093g_00B8ÁOd;

		[Token(Token = "0x400032F")]
		[FieldOffset(Offset = "0x88")]
		private long gG_0081_007B_00B2_008C;

		[Token(Token = "0x4000330")]
		[FieldOffset(Offset = "0x90")]
		private int _0081Sch_00A3Â;

		[Token(Token = "0x4000331")]
		[FieldOffset(Offset = "0x94")]
		private _0092Z_00BC_00B9_007F_005B _008F_009DWK_0080_008A;

		[Token(Token = "0x4000332")]
		[FieldOffset(Offset = "0x98")]
		private int j_009Fi_0085_008B_0095;

		[Token(Token = "0x4000333")]
		[FieldOffset(Offset = "0xA0")]
		private long i_00AB_0097_00AB_0089_008A;

		[Token(Token = "0x4000334")]
		[FieldOffset(Offset = "0xA8")]
		private bool _00B0_00A8_008F_00B6_0089s;

		[Token(Token = "0x4000335")]
		[FieldOffset(Offset = "0xB0")]
		private OnDownloadOver _005E_00A0_009C_0083_00B3_00B1;

		[Token(Token = "0x4000336")]
		[FieldOffset(Offset = "0xB8")]
		private OnDownloadProgress dX_00BC_009C_00BE_00B8;

		[Token(Token = "0x4000337")]
		[FieldOffset(Offset = "0xC0")]
		private OnDownloadError _009D_008D_00B0tI_00A9;

		[Token(Token = "0x4000338")]
		[FieldOffset(Offset = "0xC8")]
		private OnStartDownloadFile h_00AC_00BFc_00B1_0085;

		[Token(Token = "0x1700009E")]
		public int TotalDownloadCount
		{
			[Token(Token = "0x6000C58")]
			[Address(RVA = "0x73236B4", Offset = "0x731F6B4", VA = "0x73236B4")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x6000C57")]
			[Address(RVA = "0x73236AC", Offset = "0x731F6AC", VA = "0x73236AC")]
			private set
			{
				Keª_0083ª_008D(value);
			}
		}

		[Token(Token = "0x1700009F")]
		public long TotalDownloadBytes
		{
			[Token(Token = "0x6000C5A")]
			[Address(RVA = "0x73236C4", Offset = "0x731F6C4", VA = "0x73236C4")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x6000C59")]
			[Address(RVA = "0x73236BC", Offset = "0x731F6BC", VA = "0x73236BC")]
			private set
			{
				ÀyO_00B6k_00BD(value);
			}
		}

		[Token(Token = "0x170000A0")]
		public int CurrentDownloadCount
		{
			[Token(Token = "0x6000C5B")]
			[Address(RVA = "0x73236CC", Offset = "0x731F6CC", VA = "0x73236CC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000A1")]
		public long CurrentDownloadBytes
		{
			[Token(Token = "0x6000C5C")]
			[Address(RVA = "0x73236D4", Offset = "0x731F6D4", VA = "0x73236D4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000A2")]
		public bool ErrorTagRet
		{
			[Token(Token = "0x6000C5E")]
			[Address(RVA = "0x73236E8", Offset = "0x731F6E8", VA = "0x73236E8")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x6000C5D")]
			[Address(RVA = "0x73236DC", Offset = "0x731F6DC", VA = "0x73236DC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000A3")]
		public OnDownloadOver OnDownloadOverCallback
		{
			[Token(Token = "0x6000C60")]
			[Address(RVA = "0x73236F8", Offset = "0x731F6F8", VA = "0x73236F8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C5F")]
			[Address(RVA = "0x73236F0", Offset = "0x731F6F0", VA = "0x73236F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000A4")]
		public OnDownloadProgress OnDownloadProgressCallback
		{
			[Token(Token = "0x6000C62")]
			[Address(RVA = "0x7323708", Offset = "0x731F708", VA = "0x7323708")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C61")]
			[Address(RVA = "0x7323700", Offset = "0x731F700", VA = "0x7323700")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000A5")]
		public OnDownloadError OnDownloadErrorCallback
		{
			[Token(Token = "0x6000C64")]
			[Address(RVA = "0x7323718", Offset = "0x731F718", VA = "0x7323718")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C63")]
			[Address(RVA = "0x7323710", Offset = "0x731F710", VA = "0x7323710")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000A6")]
		public OnStartDownloadFile OnStartDownloadFileCallback
		{
			[Token(Token = "0x6000C66")]
			[Address(RVA = "0x7323728", Offset = "0x731F728", VA = "0x7323728")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C65")]
			[Address(RVA = "0x7323720", Offset = "0x731F720", VA = "0x7323720")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000C57")]
		[Address(RVA = "0x73236AC", Offset = "0x731F6AC", VA = "0x73236AC")]
		private void Keª_0083ª_008D(int _00A3_0092T_007E_00ABc)
		{
		}

		[Token(Token = "0x6000C59")]
		[Address(RVA = "0x73236BC", Offset = "0x731F6BC", VA = "0x73236BC")]
		private void ÀyO_00B6k_00BD(long _00A3_0092T_007E_00ABc)
		{
		}

		[Token(Token = "0x6000C67")]
		[Address(RVA = "0x7323730", Offset = "0x731F730", VA = "0x7323730")]
		internal DownloaderOperation(List<_007DYXCc_008B> V_007B_00A9i_007BV, int _00AC_0083X_009D_00AEp, int _00BD_00B2F_00AF_00B8t, int _00AFF_00BD_0083_0087X)
		{
		}

		[Token(Token = "0x6000C68")]
		[Address(RVA = "0x7323AF4", Offset = "0x731FAF4", VA = "0x7323AF4", Slot = "7")]
		internal override void GL_008Ccx_00A1()
		{
		}

		[Token(Token = "0x6000C69")]
		[Address(RVA = "0x7323B00", Offset = "0x731FB00", VA = "0x7323B00", Slot = "8")]
		internal override void _007EZ_00A7_008E_0095U()
		{
		}

		[Token(Token = "0x6000C6A")]
		[Address(RVA = "0x73242B4", Offset = "0x73202B4", VA = "0x73242B4")]
		public void BeginDownload()
		{
		}

		[Token(Token = "0x6000C6B")]
		[Address(RVA = "0x7324320", Offset = "0x7320320", VA = "0x7324320")]
		public void PauseDownload()
		{
		}

		[Token(Token = "0x6000C6C")]
		[Address(RVA = "0x732432C", Offset = "0x732032C", VA = "0x732432C")]
		public void ResumeDownload()
		{
		}

		[Token(Token = "0x6000C6D")]
		[Address(RVA = "0x7324334", Offset = "0x7320334", VA = "0x7324334")]
		public void CancelDownload()
		{
		}
	}
}
