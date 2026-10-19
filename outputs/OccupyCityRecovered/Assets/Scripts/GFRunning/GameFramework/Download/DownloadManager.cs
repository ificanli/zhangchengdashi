using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GameFramework.Base;
using Il2CppDummyDll;
using UnityEngine;

namespace GameFramework.Download
{
	[Token(Token = "0x20004A9")]
	public class DownloadManager : MonoBehaviour
	{
		[Token(Token = "0x4001F19")]
		[FieldOffset(Offset = "0x0")]
		private static DownloadManager O_00BEªA_00BE_007C;

		[Token(Token = "0x4001F1A")]
		private const int _00BEºTlk_00B9 = 1048576;

		[Token(Token = "0x4001F1B")]
		[FieldOffset(Offset = "0x20")]
		private global::_00BCV_00B7_00A5_0096_007B<_00AF_0083a_00A2S_0060> _008CEcO_00A0_007F;

		[Token(Token = "0x4001F1C")]
		[FieldOffset(Offset = "0x28")]
		private _00AF_009AnZ_00B6c _009EÁ_0099p_00A2E;

		[Token(Token = "0x4001F1D")]
		[FieldOffset(Offset = "0x30")]
		private int _0082lRxzh;

		[Token(Token = "0x4001F1E")]
		[FieldOffset(Offset = "0x34")]
		private float _00ABTZ_00BC_0094_00AC;

		[Token(Token = "0x4001F1F")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<string, _00AF_0083a_00A2S_0060> k_009F_00B3_008F_00A6n;

		[Token(Token = "0x4001F20")]
		[FieldOffset(Offset = "0x40")]
		private EventHandler<DownloadStartEventArgs> w_007CpUµ_00B9;

		[Token(Token = "0x4001F21")]
		[FieldOffset(Offset = "0x48")]
		private EventHandler<DownloadUpdateEventArgs> _00A9N_008BP_00BDµ;

		[Token(Token = "0x4001F22")]
		[FieldOffset(Offset = "0x50")]
		private EventHandler<DownloadSuccessEventArgs> _00B3R_00A0_00B3Y_009D;

		[Token(Token = "0x4001F23")]
		[FieldOffset(Offset = "0x58")]
		private EventHandler<DownloadFailureEventArgs> _008F_00B6_00BE_00BCB_00B8;

		[Token(Token = "0x17001209")]
		public static DownloadManager Instance
		{
			[Token(Token = "0x6006F91")]
			[Address(RVA = "0x72A6EA0", Offset = "0x72A2EA0", VA = "0x72A6EA0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700120A")]
		public bool Paused
		{
			[Token(Token = "0x6006F88")]
			[Address(RVA = "0x72A6A08", Offset = "0x72A2A08", VA = "0x72A6A08")]
			get
			{
				return default;
			}
			[Token(Token = "0x6006F82")]
			[Address(RVA = "0x72A67F8", Offset = "0x72A27F8", VA = "0x72A67F8")]
			set
			{
			}
		}

		[Token(Token = "0x1700120B")]
		public int TotalAgentCount
		{
			[Token(Token = "0x6006F92")]
			[Address(RVA = "0x72A50AC", Offset = "0x72A10AC", VA = "0x72A50AC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700120C")]
		public int FreeAgentCount
		{
			[Token(Token = "0x6006F8B")]
			[Address(RVA = "0x72A514C", Offset = "0x72A114C", VA = "0x72A514C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700120D")]
		public int WorkingAgentCount
		{
			[Token(Token = "0x6006F73")]
			[Address(RVA = "0x72A6058", Offset = "0x72A2058", VA = "0x72A6058")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700120E")]
		public int WaitingTaskCount
		{
			[Token(Token = "0x6006F72")]
			[Address(RVA = "0x72A50FC", Offset = "0x72A10FC", VA = "0x72A50FC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700120F")]
		public float Timeout
		{
			[Token(Token = "0x6006F8C")]
			[Address(RVA = "0x72A6C20", Offset = "0x72A2C20", VA = "0x72A6C20")]
			get
			{
				return default;
			}
			[Token(Token = "0x6006F5D")]
			[Address(RVA = "0x72A4E08", Offset = "0x72A0E08", VA = "0x72A4E08")]
			set
			{
			}
		}

		[Token(Token = "0x17001210")]
		public int FlushSize
		{
			[Token(Token = "0x6006F59")]
			[Address(RVA = "0x72A4D10", Offset = "0x72A0D10", VA = "0x72A4D10")]
			get
			{
				return default;
			}
			[Token(Token = "0x6006F95")]
			[Address(RVA = "0x72A71CC", Offset = "0x72A31CC", VA = "0x72A71CC")]
			set
			{
			}
		}

		[Token(Token = "0x17001211")]
		public float CurrentSpeed
		{
			[Token(Token = "0x6006F66")]
			[Address(RVA = "0x72A57F0", Offset = "0x72A17F0", VA = "0x72A57F0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x14000029")]
		public event EventHandler<DownloadStartEventArgs> DownloadStart
		{
			[Token(Token = "0x6006F86")]
			[Address(RVA = "0x72A68F8", Offset = "0x72A28F8", VA = "0x72A68F8")]
			add
			{
			}
			[Token(Token = "0x6006F6B")]
			[Address(RVA = "0x72A5AD4", Offset = "0x72A1AD4", VA = "0x72A5AD4")]
			remove
			{
			}
		}

		[Token(Token = "0x1400002A")]
		public event EventHandler<DownloadUpdateEventArgs> DownloadUpdate
		{
			[Token(Token = "0x6006F5E")]
			[Address(RVA = "0x72A4E10", Offset = "0x72A0E10", VA = "0x72A4E10")]
			add
			{
			}
			[Token(Token = "0x6006F79")]
			[Address(RVA = "0x72A62D8", Offset = "0x72A22D8", VA = "0x72A62D8")]
			remove
			{
			}
		}

		[Token(Token = "0x1400002B")]
		public event EventHandler<DownloadSuccessEventArgs> DownloadSuccess
		{
			[Token(Token = "0x6006F69")]
			[Address(RVA = "0x72A5A20", Offset = "0x72A1A20", VA = "0x72A5A20")]
			add
			{
			}
			[Token(Token = "0x6006F9A")]
			[Address(RVA = "0x72A7244", Offset = "0x72A3244", VA = "0x72A7244")]
			remove
			{
			}
		}

		[Token(Token = "0x1400002C")]
		public event EventHandler<DownloadFailureEventArgs> DownloadFailure
		{
			[Token(Token = "0x6006F78")]
			[Address(RVA = "0x72A6230", Offset = "0x72A2230", VA = "0x72A6230")]
			add
			{
			}
			[Token(Token = "0x6006F75")]
			[Address(RVA = "0x72A6174", Offset = "0x72A2174", VA = "0x72A6174")]
			remove
			{
			}
		}

		[SpecialName]
		[Token(Token = "0x6006F56")]
		[Address(RVA = "0x72A4B70", Offset = "0x72A0B70", VA = "0x72A4B70")]
		public void JJzy_0084_005B(EventHandler<DownloadUpdateEventArgs> _00A3_0092T_007E_00ABc)
		{
		}

		[Token(Token = "0x6006F57")]
		[Address(RVA = "0x72A4C18", Offset = "0x72A0C18", VA = "0x72A4C18")]
		private void Update()
		{
		}

		[SpecialName]
		[Token(Token = "0x6006F58")]
		[Address(RVA = "0x72A4CC0", Offset = "0x72A0CC0", VA = "0x72A4CC0")]
		public int _007Fm_008B_009FAe()
		{
			return default;
		}

		[SpecialName]
		[Token(Token = "0x6006F5A")]
		[Address(RVA = "0x72A4D18", Offset = "0x72A0D18", VA = "0x72A4D18")]
		public int _00B2zÀ_0098O_00BD()
		{
			return default;
		}

		[Token(Token = "0x6006F5B")]
		[Address(RVA = "0x72A4D68", Offset = "0x72A0D68", VA = "0x72A4D68")]
		public void RemoveAllDownloads()
		{
		}

		[SpecialName]
		[Token(Token = "0x6006F5C")]
		[Address(RVA = "0x72A4DB8", Offset = "0x72A0DB8", VA = "0x72A4DB8")]
		public void ÁX_00B2_00BDFh(bool _00A3_0092T_007E_00ABc)
		{
		}

		[Token(Token = "0x6006F5F")]
		[Address(RVA = "0x72A4EB8", Offset = "0x72A0EB8", VA = "0x72A4EB8")]
		public int AddDownload(string SY_009B_0089_00A7µ, string _0060_00A6zºZ_00B4, int rVlHªB, object _00B4sT_00ABV_007E)
		{
			return default;
		}

		[Token(Token = "0x6006F60")]
		[Address(RVA = "0x72A5548", Offset = "0x72A1548", VA = "0x72A5548")]
		public void Shutdown()
		{
		}

		[Token(Token = "0x6006F61")]
		[Address(RVA = "0x72A560C", Offset = "0x72A160C", VA = "0x72A560C")]
		public void Â_008D_005DX_00A5_009A(int zy_0086NXI, int rVlHªB)
		{
		}

		[Token(Token = "0x6006F62")]
		[Address(RVA = "0x72A5674", Offset = "0x72A1674", VA = "0x72A5674")]
		public bool RemoveDownload(int zy_0086NXI)
		{
			return default;
		}

		[SpecialName]
		[Token(Token = "0x6006F63")]
		[Address(RVA = "0x72A56CC", Offset = "0x72A16CC", VA = "0x72A56CC")]
		public void _009CGio_00A5_0090(float _00A3_0092T_007E_00ABc)
		{
		}

		[Token(Token = "0x6006F64")]
		[Address(RVA = "0x72A56D4", Offset = "0x72A16D4", VA = "0x72A56D4")]
		private void _0094_00A1_0098_008Eµ_00B8(_0088B_00A1_0084Q_008A _00B2w_00B7_00A7h_00B9, int _00BC_00AF_0094FxP)
		{
		}

		[Token(Token = "0x6006F65")]
		[Address(RVA = "0x72A57A0", Offset = "0x72A17A0", VA = "0x72A57A0")]
		public TaskInfo[] _00BDq_007D_0083pR()
		{
			return null;
		}

		[Token(Token = "0x6006F67")]
		[Address(RVA = "0x72A580C", Offset = "0x72A180C", VA = "0x72A580C")]
		private void _00AE_00A3_007Cº_0099q(_0088B_00A1_0084Q_008A _00B2w_00B7_00A7h_00B9, string _00A6_008D_0086_007Cq_0095)
		{
		}

		[Token(Token = "0x6006F68")]
		[Address(RVA = "0x72A5920", Offset = "0x72A1920", VA = "0x72A5920")]
		private void _009A_00B6_005BJ_00B1E()
		{
		}

		[Token(Token = "0x6006F6A")]
		[Address(RVA = "0x72A5AC8", Offset = "0x72A1AC8", VA = "0x72A5AC8")]
		public int _00BCo_0093_007DD_00B0(string SY_009B_0089_00A7µ, string _0060_00A6zºZ_00B4)
		{
			return default;
		}

		[Token(Token = "0x6006F6C")]
		[Address(RVA = "0x72A5B7C", Offset = "0x72A1B7C", VA = "0x72A5B7C")]
		public DownloadManager()
		{
		}

		[SpecialName]
		[Token(Token = "0x6006F6D")]
		[Address(RVA = "0x72A5BF8", Offset = "0x72A1BF8", VA = "0x72A5BF8")]
		public static DownloadManager V_0099_005By_0092_0093()
		{
			return null;
		}

		[SpecialName]
		[Token(Token = "0x6006F6E")]
		[Address(RVA = "0x72A5DE8", Offset = "0x72A1DE8", VA = "0x72A5DE8")]
		public void Fy_00A5_0081_0095_00BC(EventHandler<DownloadSuccessEventArgs> _00A3_0092T_007E_00ABc)
		{
		}

		[Token(Token = "0x6006F6F")]
		[Address(RVA = "0x72A5E90", Offset = "0x72A1E90", VA = "0x72A5E90")]
		private void pµ_009D_0095F_0092(_0088B_00A1_0084Q_008A _00B2w_00B7_00A7h_00B9)
		{
		}

		[Token(Token = "0x6006F70")]
		[Address(RVA = "0x72A5F48", Offset = "0x72A1F48", VA = "0x72A5F48")]
		public bool HaveDownTask(int zy_0086NXI)
		{
			return default;
		}

		[Token(Token = "0x6006F71")]
		[Address(RVA = "0x72A5FA0", Offset = "0x72A1FA0", VA = "0x72A5FA0")]
		private void t_008E_00ADq_0095y(_0088B_00A1_0084Q_008A _00B2w_00B7_00A7h_00B9)
		{
		}

		[Token(Token = "0x6006F74")]
		[Address(RVA = "0x72A60A8", Offset = "0x72A20A8", VA = "0x72A60A8")]
		private void _00BC_0088_00ABOÂ_00B1(_0088B_00A1_0084Q_008A _00B2w_00B7_00A7h_00B9, int _00BC_00AF_0094FxP)
		{
		}

		[SpecialName]
		[Token(Token = "0x6006F76")]
		[Address(RVA = "0x72A621C", Offset = "0x72A221C", VA = "0x72A621C")]
		public int _00BFKÀt_00A4_0094()
		{
			return default;
		}

		[Token(Token = "0x6006F77")]
		[Address(RVA = "0x72A6224", Offset = "0x72A2224", VA = "0x72A6224")]
		public int _00A0lB_00B4q_008E(string SY_009B_0089_00A7µ, string _0060_00A6zºZ_00B4, object _00B4sT_00ABV_007E)
		{
			return default;
		}

		[Token(Token = "0x6006F7A")]
		[Address(RVA = "0x72A6380", Offset = "0x72A2380", VA = "0x72A6380")]
		private void _00B3c_00A4_00B3_005E_00BF()
		{
		}

		[Token(Token = "0x6006F7B")]
		[Address(RVA = "0x72A648C", Offset = "0x72A248C", VA = "0x72A648C")]
		public int _00A8B_00ADb_0095H(string SY_009B_0089_00A7µ, string _0060_00A6zºZ_00B4)
		{
			return default;
		}

		[SpecialName]
		[Token(Token = "0x6006F7C")]
		[Address(RVA = "0x72A6498", Offset = "0x72A2498", VA = "0x72A6498")]
		public int mI_00B3rÁ_00AC()
		{
			return default;
		}

		[SpecialName]
		[Token(Token = "0x6006F7D")]
		[Address(RVA = "0x72A64E8", Offset = "0x72A24E8", VA = "0x72A64E8")]
		public void _00AFvsc_00B2_00A8(EventHandler<DownloadFailureEventArgs> _00A3_0092T_007E_00ABc)
		{
		}

		[SpecialName]
		[Token(Token = "0x6006F7E")]
		[Address(RVA = "0x72A6590", Offset = "0x72A2590", VA = "0x72A6590")]
		public int _0087_0081Á_0095_00B0k()
		{
			return default;
		}

		[Token(Token = "0x6006F7F")]
		[Address(RVA = "0x72A65E0", Offset = "0x72A25E0", VA = "0x72A65E0")]
		public TaskInfo[] GetAllDownloadInfos()
		{
			return null;
		}

		[Token(Token = "0x6006F80")]
		[Address(RVA = "0x72A6630", Offset = "0x72A2630", VA = "0x72A6630")]
		public int HaveDownTask(string _0060_00A6zºZ_00B4)
		{
			return default;
		}

		[Token(Token = "0x6006F81")]
		[Address(RVA = "0x72A66C8", Offset = "0x72A26C8", VA = "0x72A66C8")]
		private void _00B3_0081NMH_00AF(_0088B_00A1_0084Q_008A _00B2w_00B7_00A7h_00B9, int _00BC_00AF_0094FxP)
		{
		}

		[SpecialName]
		[Token(Token = "0x6006F83")]
		[Address(RVA = "0x72A6848", Offset = "0x72A2848", VA = "0x72A6848")]
		public void K_009A_0088HOª(EventHandler<DownloadStartEventArgs> _00A3_0092T_007E_00ABc)
		{
		}

		[SpecialName]
		[Token(Token = "0x6006F84")]
		[Address(RVA = "0x72A68F0", Offset = "0x72A28F0", VA = "0x72A68F0")]
		public void _00A9_00B9_005E_00A7_007B_005B(int _00A3_0092T_007E_00ABc)
		{
		}

		[Token(Token = "0x6006F85")]
		[Address(RVA = "0x72A519C", Offset = "0x72A119C", VA = "0x72A519C")]
		public void AddDownloadAgentHelper(IDownloadAgentHelper _00B7_00B9_009A_00A8b_00AE)
		{
		}

		[Token(Token = "0x6006F87")]
		[Address(RVA = "0x72A69A0", Offset = "0x72A29A0", VA = "0x72A69A0")]
		public void ChangeDownTaskPriority(int zy_0086NXI, int rVlHªB)
		{
		}

		[Token(Token = "0x6006F89")]
		[Address(RVA = "0x72A6A50", Offset = "0x72A2A50", VA = "0x72A6A50")]
		public void N_008FaVdT()
		{
		}

		[Token(Token = "0x6006F8A")]
		[Address(RVA = "0x72A6B14", Offset = "0x72A2B14", VA = "0x72A6B14")]
		private void VÂ_009E_009FA_0094()
		{
		}

		[SpecialName]
		[Token(Token = "0x6006F8D")]
		[Address(RVA = "0x72A6C28", Offset = "0x72A2C28", VA = "0x72A6C28")]
		public void _00BE_0084_008A_005E_008C_0091(EventHandler<DownloadUpdateEventArgs> _00A3_0092T_007E_00ABc)
		{
		}

		[Token(Token = "0x6006F8E")]
		[Address(RVA = "0x72A6CD0", Offset = "0x72A2CD0", VA = "0x72A6CD0")]
		public int _009EH_00B0_0060T_008D(string _0060_00A6zºZ_00B4)
		{
			return default;
		}

		[Token(Token = "0x6006F8F")]
		[Address(RVA = "0x72A6D68", Offset = "0x72A2D68", VA = "0x72A6D68")]
		public int AddDownload(string SY_009B_0089_00A7µ, string _0060_00A6zºZ_00B4, int rVlHªB)
		{
			return default;
		}

		[Token(Token = "0x6006F90")]
		[Address(RVA = "0x72A6D70", Offset = "0x72A2D70", VA = "0x72A6D70")]
		private void _0083_009CaCO_00A9(_0088B_00A1_0084Q_008A _00B2w_00B7_00A7h_00B9, int _00BC_00AF_0094FxP)
		{
		}

		[SpecialName]
		[Token(Token = "0x6006F93")]
		[Address(RVA = "0x72A707C", Offset = "0x72A307C", VA = "0x72A707C")]
		public void _009E_008C_005B_00BE_00B1_00BF(EventHandler<DownloadFailureEventArgs> _00A3_0092T_007E_00ABc)
		{
		}

		[SpecialName]
		[Token(Token = "0x6006F94")]
		[Address(RVA = "0x72A7124", Offset = "0x72A3124", VA = "0x72A7124")]
		public void VROÀ_0090M(EventHandler<DownloadUpdateEventArgs> _00A3_0092T_007E_00ABc)
		{
		}

		[SpecialName]
		[Token(Token = "0x6006F96")]
		[Address(RVA = "0x72A71D4", Offset = "0x72A31D4", VA = "0x72A71D4")]
		public int _00B4ºXz_0060_00B4()
		{
			return default;
		}

		[Token(Token = "0x6006F97")]
		[Address(RVA = "0x72A7224", Offset = "0x72A3224", VA = "0x72A7224")]
		public int AddDownload(string SY_009B_0089_00A7µ, string _0060_00A6zºZ_00B4)
		{
			return default;
		}

		[SpecialName]
		[Token(Token = "0x6006F98")]
		[Address(RVA = "0x72A7230", Offset = "0x72A3230", VA = "0x72A7230")]
		public int _00BC_007Dr_00B0_0083_00BC()
		{
			return default;
		}

		[Token(Token = "0x6006F99")]
		[Address(RVA = "0x72A7238", Offset = "0x72A3238", VA = "0x72A7238")]
		public int AddDownload(string SY_009B_0089_00A7µ, string _0060_00A6zºZ_00B4, object _00B4sT_00ABV_007E)
		{
			return default;
		}

		[Token(Token = "0x6006F9B")]
		[Address(RVA = "0x72A72EC", Offset = "0x72A32EC", VA = "0x72A72EC")]
		public int L_00AFµgzo(string SY_009B_0089_00A7µ, string _0060_00A6zºZ_00B4, object _00B4sT_00ABV_007E)
		{
			return default;
		}
	}
}
