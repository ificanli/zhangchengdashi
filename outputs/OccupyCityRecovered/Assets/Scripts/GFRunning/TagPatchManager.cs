using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using YooAsset;

[Token(Token = "0x2000034")]
public class TagPatchManager
{
	[Token(Token = "0x2000035")]
	private sealed class b_008BHPL_008C : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40000A9")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40000AA")]
		[FieldOffset(Offset = "0x20")]
		public TagPatchManager _003C_003E4__this;

		[Token(Token = "0x40000AB")]
		[FieldOffset(Offset = "0x28")]
		public Action callBack;

		[Token(Token = "0x40000AC")]
		[FieldOffset(Offset = "0x30")]
		public string[] tags;

		[Token(Token = "0x40000AD")]
		[FieldOffset(Offset = "0x38")]
		public Action<string> errorCallBack;

		[Token(Token = "0x40000AE")]
		[FieldOffset(Offset = "0x40")]
		private ResourceDownloaderOperation _003Cdownloader_003E5__2;

		[Token(Token = "0x1700002F")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600029E")]
			[Address(RVA = "0x7088A64", Offset = "0x7084A64", VA = "0x7088A64", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000030")]
object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002A0")]
			[Address(RVA = "0x7088AA4", Offset = "0x7084AA4", VA = "0x7088AA4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x7087E1C", Offset = "0x7083E1C", VA = "0x7087E1C")]
		[DebuggerHidden]
		public b_008BHPL_008C(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x7088808", Offset = "0x7084808", VA = "0x7088808", Slot = "5")]
		[DebuggerHidden]
void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x708880C", Offset = "0x708480C", VA = "0x708880C", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x7088A64", Offset = "0x7084A64", VA = "0x7088A64", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x7088A6C", Offset = "0x7084A6C", VA = "0x7088A6C", Slot = "8")]
		[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
		{
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x7088AA4", Offset = "0x7084AA4", VA = "0x7088AA4", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x400009E")]
	[FieldOffset(Offset = "0x10")]
	private EPlayMode _009C_00A4_007C_00A1_0083_0084;

	[Token(Token = "0x400009F")]
	[FieldOffset(Offset = "0x18")]
	private ResourcePackage _00B1N_005D_009EV_009F;

	[Token(Token = "0x40000A0")]
	private const int Y_0089lev_0083 = 10;

	[Token(Token = "0x40000A1")]
	private const int _00BD_00B2F_00AF_00B8t = 3;

	[Token(Token = "0x40000A2")]
	private const int _00AFF_00BD_0083_0087X = 10;

	[Token(Token = "0x40000A3")]
	[FieldOffset(Offset = "0x20")]
	private readonly string lj_0090_0085ºc;

	[Token(Token = "0x40000A4")]
	[FieldOffset(Offset = "0x28")]
	private DownloaderOperation.OnDownloadProgress dX_00BC_009C_00BE_00B8;

	[Token(Token = "0x40000A5")]
	[FieldOffset(Offset = "0x30")]
	private DownloaderOperation.OnStartDownloadFile h_00AC_00BFc_00B1_0085;

	[Token(Token = "0x40000A6")]
	[FieldOffset(Offset = "0x38")]
	private DownloaderOperation.OnDownloadOver _005E_00A0_009C_0083_00B3_00B1;

	[Token(Token = "0x40000A7")]
	[FieldOffset(Offset = "0x40")]
	private Action<string> _007BE_00B1_009Eº_00B6;

	[Token(Token = "0x1700002B")]
	public DownloaderOperation.OnDownloadProgress OnDownloadProgressCallback
	{
		[Token(Token = "0x6000272")]
		[Address(RVA = "0x7087D3C", Offset = "0x7083D3C", VA = "0x7087D3C")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600027B")]
		[Address(RVA = "0x7087D84", Offset = "0x7083D84", VA = "0x7087D84")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700002C")]
	public DownloaderOperation.OnStartDownloadFile OnStartDownloadFileCallback
	{
		[Token(Token = "0x600027C")]
		[Address(RVA = "0x7087D8C", Offset = "0x7083D8C", VA = "0x7087D8C")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000282")]
		[Address(RVA = "0x708809C", Offset = "0x708409C", VA = "0x708809C")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700002D")]
	public DownloaderOperation.OnDownloadOver OnDownloadOverCallback
	{
		[Token(Token = "0x600028B")]
		[Address(RVA = "0x7088250", Offset = "0x7084250", VA = "0x7088250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000289")]
		[Address(RVA = "0x70881C4", Offset = "0x70841C4", VA = "0x70881C4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700002E")]
	public Action<string> ErrorAction
	{
		[Token(Token = "0x600029A")]
		[Address(RVA = "0x7088800", Offset = "0x7084800", VA = "0x7088800")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000283")]
		[Address(RVA = "0x70880A4", Offset = "0x70840A4", VA = "0x70880A4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x6000271")]
	[Address(RVA = "0x7087944", Offset = "0x7083944", VA = "0x7087944")]
	public void StartPatch(string[] _005BMu_005Eµ_00AF, Action _00A3Y_0082I_00A7_00B4, Action<string> G_0092_009D_00A2gW)
	{
	}

	[SpecialName]
	[Token(Token = "0x6000273")]
	[Address(RVA = "0x7087D44", Offset = "0x7083D44", VA = "0x7087D44")]
	public void ulr_007B_007Bp(DownloaderOperation.OnStartDownloadFile _00A3_0092T_007E_00ABc)
	{
	}

	[SpecialName]
	[Token(Token = "0x6000274")]
	[Address(RVA = "0x7087D4C", Offset = "0x7083D4C", VA = "0x7087D4C")]
	public void _00B0D_00A2d_00A7j(DownloaderOperation.OnDownloadOver _00A3_0092T_007E_00ABc)
	{
	}

	[SpecialName]
	[Token(Token = "0x6000275")]
	[Address(RVA = "0x7087D54", Offset = "0x7083D54", VA = "0x7087D54")]
	public void _00B7_008Bk_008CÂ_007D(Action<string> _00A3_0092T_007E_00ABc)
	{
	}

	[SpecialName]
	[Token(Token = "0x6000276")]
	[Address(RVA = "0x7087D5C", Offset = "0x7083D5C", VA = "0x7087D5C")]
	public DownloaderOperation.OnDownloadProgress s_00AC_00A9DB_0098()
	{
		return null;
	}

	[SpecialName]
	[Token(Token = "0x6000277")]
	[Address(RVA = "0x7087D64", Offset = "0x7083D64", VA = "0x7087D64")]
	public DownloaderOperation.OnDownloadOver _0090_00B1qZ_00AF_007C()
	{
		return null;
	}

	[SpecialName]
	[Token(Token = "0x6000278")]
	[Address(RVA = "0x7087D6C", Offset = "0x7083D6C", VA = "0x7087D6C")]
	public DownloaderOperation.OnStartDownloadFile _0060p_008C_0091_0089F()
	{
		return null;
	}

	[SpecialName]
	[Token(Token = "0x6000279")]
	[Address(RVA = "0x7087D74", Offset = "0x7083D74", VA = "0x7087D74")]
	public Action<string> _0095N_005BCV_009A()
	{
		return null;
	}

	[SpecialName]
	[Token(Token = "0x600027A")]
	[Address(RVA = "0x7087D7C", Offset = "0x7083D7C", VA = "0x7087D7C")]
	public void _0099H_008Aº_008E_0082(DownloaderOperation.OnStartDownloadFile _00A3_0092T_007E_00ABc)
	{
	}

	[SpecialName]
	[Token(Token = "0x600027D")]
	[Address(RVA = "0x7087D94", Offset = "0x7083D94", VA = "0x7087D94")]
	public DownloaderOperation.OnDownloadOver Hp_00BBq_009A_0093()
	{
		return null;
	}

	[Token(Token = "0x600027E")]
	[Address(RVA = "0x7087D9C", Offset = "0x7083D9C", VA = "0x7087D9C")]
	private IEnumerator r_00BCÀ_00B4NX(string[] _005BMu_005Eµ_00AF, Action _009F_00A4WY_0097_00B1, Action<string> G_0092_009D_00A2gW)
	{
		return null;
	}

	[Token(Token = "0x600027F")]
	[Address(RVA = "0x70879B8", Offset = "0x70839B8", VA = "0x70879B8")]
	private static bool Of_0097FiI()
	{
		return default;
	}

	[SpecialName]
	[Token(Token = "0x6000280")]
	[Address(RVA = "0x7087E44", Offset = "0x7083E44", VA = "0x7087E44")]
	public void _0090_00A4_007F_008C_0085X(Action<string> _00A3_0092T_007E_00ABc)
	{
	}

	[Token(Token = "0x6000281")]
	[Address(RVA = "0x7087E4C", Offset = "0x7083E4C", VA = "0x7087E4C")]
	public void _00AF_0080_009A_00BBbs(string[] _005BMu_005Eµ_00AF, Action _00A3Y_0082I_00A7_00B4, Action<string> G_0092_009D_00A2gW)
	{
	}

	[SpecialName]
	[Token(Token = "0x6000284")]
	[Address(RVA = "0x70880AC", Offset = "0x70840AC", VA = "0x70880AC")]
	public DownloaderOperation.OnDownloadProgress j_00AFÀ_009C_0088o()
	{
		return null;
	}

	[SpecialName]
	[Token(Token = "0x6000285")]
	[Address(RVA = "0x70880B4", Offset = "0x70840B4", VA = "0x70880B4")]
	public Action<string> R_0080jTp_00A8()
	{
		return null;
	}

	[Token(Token = "0x6000286")]
	[Address(RVA = "0x70880BC", Offset = "0x70840BC", VA = "0x70880BC")]
	public void _008DATgX_0083(string[] _005BMu_005Eµ_00AF, Action _00A3Y_0082I_00A7_00B4, Action<string> G_0092_009D_00A2gW)
	{
	}

	[SpecialName]
	[Token(Token = "0x6000287")]
	[Address(RVA = "0x70881B4", Offset = "0x70841B4", VA = "0x70881B4")]
	public void _0098_00B4bfms(Action<string> _00A3_0092T_007E_00ABc)
	{
	}

	[SpecialName]
	[Token(Token = "0x6000288")]
	[Address(RVA = "0x70881BC", Offset = "0x70841BC", VA = "0x70881BC")]
	public void TB_0083Â_00AF_00B0(DownloaderOperation.OnDownloadOver _00A3_0092T_007E_00ABc)
	{
	}

	[Token(Token = "0x600028A")]
	[Address(RVA = "0x70881CC", Offset = "0x70841CC", VA = "0x70881CC")]
	private IEnumerator wW_008Af_0093y(string[] _005BMu_005Eµ_00AF, Action _009F_00A4WY_0097_00B1, Action<string> G_0092_009D_00A2gW)
	{
		return null;
	}

	[SpecialName]
	[Token(Token = "0x600028C")]
	[Address(RVA = "0x7088258", Offset = "0x7084258", VA = "0x7088258")]
	public void nY_009FBN_0092(Action<string> _00A3_0092T_007E_00ABc)
	{
	}

	[SpecialName]
	[Token(Token = "0x600028D")]
	[Address(RVA = "0x7088260", Offset = "0x7084260", VA = "0x7088260")]
	public DownloaderOperation.OnStartDownloadFile lGA_00A7_0095Â()
	{
		return null;
	}

	[SpecialName]
	[Token(Token = "0x600028E")]
	[Address(RVA = "0x7088268", Offset = "0x7084268", VA = "0x7088268")]
	public void _0060_0081_00B2_00B2_008Ca(DownloaderOperation.OnDownloadOver _00A3_0092T_007E_00ABc)
	{
	}

	[Token(Token = "0x600028F")]
	[Address(RVA = "0x7088130", Offset = "0x7084130", VA = "0x7088130")]
	private IEnumerator _00AEc_00A7_0092rv(string[] _005BMu_005Eµ_00AF, Action _009F_00A4WY_0097_00B1, Action<string> G_0092_009D_00A2gW)
	{
		return null;
	}

	[SpecialName]
	[Token(Token = "0x6000290")]
	[Address(RVA = "0x7088270", Offset = "0x7084270", VA = "0x7088270")]
	public void _0086_0087_00A5_00ACx_00BC(Action<string> _00A3_0092T_007E_00ABc)
	{
	}

	[SpecialName]
	[Token(Token = "0x6000291")]
	[Address(RVA = "0x7088278", Offset = "0x7084278", VA = "0x7088278")]
	public void _0085_00AF_0085I_009Aq(Action<string> _00A3_0092T_007E_00ABc)
	{
	}

	[SpecialName]
	[Token(Token = "0x6000292")]
	[Address(RVA = "0x7088280", Offset = "0x7084280", VA = "0x7088280")]
	public void _007Eo_0086_005D_00A6a(DownloaderOperation.OnDownloadProgress _00A3_0092T_007E_00ABc)
	{
	}

	[Token(Token = "0x6000293")]
	[Address(RVA = "0x7088288", Offset = "0x7084288", VA = "0x7088288")]
	public TagPatchManager()
	{
	}

	[Token(Token = "0x6000294")]
	[Address(RVA = "0x7088348", Offset = "0x7084348", VA = "0x7088348")]
	public void _00ADªOdI_00BE(string[] _005BMu_005Eµ_00AF, Action _00A3Y_0082I_00A7_00B4, Action<string> G_0092_009D_00A2gW)
	{
	}

	[SpecialName]
	[Token(Token = "0x6000295")]
	[Address(RVA = "0x7088598", Offset = "0x7084598", VA = "0x7088598")]
	public Action<string> B_007Eo_00BC_00A4X()
	{
		return null;
	}

	[Token(Token = "0x6000296")]
	[Address(RVA = "0x7087CBC", Offset = "0x7083CBC", VA = "0x7087CBC")]
	[IteratorStateMachine(typeof(b_008BHPL_008C))]
	private IEnumerator dB_0080_009F_0088_00AC(string[] _005BMu_005Eµ_00AF, Action _009F_00A4WY_0097_00B1, Action<string> G_0092_009D_00A2gW)
	{
		return null;
	}

	[SpecialName]
	[Token(Token = "0x6000297")]
	[Address(RVA = "0x70885A0", Offset = "0x70845A0", VA = "0x70885A0")]
	public void _007Em_0095_0060_00A0_0095(DownloaderOperation.OnDownloadProgress _00A3_0092T_007E_00ABc)
	{
	}

	[Token(Token = "0x6000298")]
	[Address(RVA = "0x70885A8", Offset = "0x70845A8", VA = "0x70885A8")]
	public void ygHµok(string[] _005BMu_005Eµ_00AF, Action _00A3Y_0082I_00A7_00B4, Action<string> G_0092_009D_00A2gW)
	{
	}

	[SpecialName]
	[Token(Token = "0x6000299")]
	[Address(RVA = "0x70887F8", Offset = "0x70847F8", VA = "0x70887F8")]
	public void _008C_0087_00ACq_008Ex(DownloaderOperation.OnDownloadOver _00A3_0092T_007E_00ABc)
	{
	}
}
