using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000060")]
public class UpdateManager : MonoBehaviour
{
	[Token(Token = "0x2000061")]
	public delegate void UpdateHandle();

	[Token(Token = "0x400012B")]
	[FieldOffset(Offset = "0x0")]
	private static UpdateManager O_00BEªA_00BE_007C;

	[Token(Token = "0x400012C")]
	[FieldOffset(Offset = "0x20")]
	private Dictionary<int, UpdateHandle> ºº_0098X_008C_0095;

	[Token(Token = "0x400012D")]
	[FieldOffset(Offset = "0x28")]
	public bool isPause;

	[Token(Token = "0x400012E")]
	[FieldOffset(Offset = "0x2C")]
	private int _0094_007BZ_0095_009Dm;

	[Token(Token = "0x400012F")]
	[FieldOffset(Offset = "0x30")]
	private List<UpdateHandle> j_009Aj_00B9Z_0085;

	[Token(Token = "0x4000130")]
	[FieldOffset(Offset = "0x38")]
	private List<UpdateHandle> _008DL_007E_0091_0088_00B9;

	[Token(Token = "0x4000131")]
	[FieldOffset(Offset = "0x40")]
	private List<UpdateHandle> _00B1KS_00BB_00A6J;

	[Token(Token = "0x4000132")]
	[FieldOffset(Offset = "0x48")]
	private List<UpdateHandle> _0095_0085_0060_00B7W_0060;

	[Token(Token = "0x4000133")]
	[FieldOffset(Offset = "0x50")]
	private List<int> _008C_00B4cx_009B_00AE;

	[Token(Token = "0x4000134")]
	[FieldOffset(Offset = "0x58")]
	private List<UpdateHandle> _00A8S_0098_0092Q_009B;

	[Token(Token = "0x4000135")]
	[FieldOffset(Offset = "0x60")]
	private Dictionary<int, UpdateData> _00A1_0098Á_00B6b_00B3;

	[Token(Token = "0x4000136")]
	[FieldOffset(Offset = "0x68")]
	private int B_0090rE_00AC_007D;

	[Token(Token = "0x4000137")]
	[FieldOffset(Offset = "0x70")]
	private List<UpdateHandle> _00A3_008Dª_00B9_00BC_005E;

	[Token(Token = "0x17000032")]
	public static UpdateManager Instance
	{
		[Token(Token = "0x6000418")]
		[Address(RVA = "0x7087AF4", Offset = "0x7083AF4", VA = "0x7087AF4")]
		get
		{
            if (O_00BEªA_00BE_007C == null)
            {
                GameObject host = GameObject.Find("UpdateManager");
                if (host == null) { host = new GameObject(); host.name = "UpdateManager"; }
                O_00BEªA_00BE_007C = host.GetComponent<UpdateManager>();
                if (O_00BEªA_00BE_007C == null) O_00BEªA_00BE_007C = host.AddComponent<UpdateManager>();
                UnityEngine.Object.DontDestroyOnLoad(host);
            }
            return O_00BEªA_00BE_007C;
		}
	}

	[Token(Token = "0x17000033")]
	public Dictionary<int, UpdateHandle> IndexDict
	{
		[Token(Token = "0x6000424")]
		[Address(RVA = "0x7095098", Offset = "0x7091098", VA = "0x7095098")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000447")]
		[Address(RVA = "0x7097578", Offset = "0x7093578", VA = "0x7097578")]
		set
		{
		}
	}

	[Token(Token = "0x17000034")]
	public List<UpdateHandle> HandleList
	{
		[Token(Token = "0x600040D")]
		[Address(RVA = "0x70953C0", Offset = "0x70913C0", VA = "0x70953C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000035")]
	public List<UpdateHandle> ForceHandleList
	{
		[Token(Token = "0x600042C")]
		[Address(RVA = "0x7095020", Offset = "0x7091020", VA = "0x7095020")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000428")]
		[Address(RVA = "0x7096BD8", Offset = "0x7092BD8", VA = "0x7096BD8")]
		set
		{
		}
	}

	[Token(Token = "0x17000036")]
	public List<UpdateHandle> FixedUpdateHandle
	{
		[Token(Token = "0x6000445")]
		[Address(RVA = "0x7095830", Offset = "0x7091830", VA = "0x7095830")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000037")]
	public int TimePreFrame
	{
		[Token(Token = "0x600043C")]
		[Address(RVA = "0x70974DC", Offset = "0x70934DC", VA = "0x70974DC")]
		get
		{
			return default;
		}
		[Token(Token = "0x600043A")]
		[Address(RVA = "0x70974B4", Offset = "0x70934B4", VA = "0x70974B4")]
		set
		{
		}
	}

	[Token(Token = "0x6000403")]
	[Address(RVA = "0x7094EBC", Offset = "0x7090EBC", VA = "0x7094EBC")]
	private int Wq_0098_0097B_0095(UpdateHandle A_0085_007D_0092_00BDr)
	{
		return default;
	}

	[SpecialName]
	[Token(Token = "0x6000404")]
	[Address(RVA = "0x7095110", Offset = "0x7091110", VA = "0x7095110")]
	public int a_0081g_00A3Á_00BF()
	{
		return default;
	}

	[Token(Token = "0x6000405")]
	[Address(RVA = "0x7095118", Offset = "0x7091118", VA = "0x7095118")]
	private void Update()
	{
	}

	[Token(Token = "0x6000406")]
	[Address(RVA = "0x7095438", Offset = "0x7091438", VA = "0x7095438")]
	private void _00B9_007D_0097c_0097_0093()
	{
	}

	[Token(Token = "0x6000407")]
	[Address(RVA = "0x7095580", Offset = "0x7091580", VA = "0x7095580")]
	private void fE_00B4K_008ET(UpdateHandle A_0085_007D_0092_00BDr)
	{
	}

	[SpecialName]
	[Token(Token = "0x6000408")]
	[Address(RVA = "0x70883BC", Offset = "0x70843BC", VA = "0x70883BC")]
	public static UpdateManager HBpfB_0080()
	{
		return null;
	}

	[Token(Token = "0x6000409")]
	[Address(RVA = "0x70958A8", Offset = "0x70918A8", VA = "0x70958A8")]
	private void _0093Y_00AEy_0092_007E()
	{
	}

	[SpecialName]
	[Token(Token = "0x600040A")]
	[Address(RVA = "0x70959D8", Offset = "0x70919D8", VA = "0x70959D8")]
	public void _0092_0090_00ADRw_0095(List<UpdateHandle> _00A3_0092T_007E_00ABc)
	{
	}

	[Token(Token = "0x600040B")]
	[Address(RVA = "0x70959E0", Offset = "0x70919E0", VA = "0x70959E0")]
	private void _008BYo_0088_00AEF(int _00B2_0097_005Biy_00B6)
	{
	}

	[SpecialName]
	[Token(Token = "0x600040C")]
	[Address(RVA = "0x7095AB0", Offset = "0x7091AB0", VA = "0x7095AB0")]
	public static UpdateManager _008EmjM_0097_009B()
	{
		return null;
	}

	[Token(Token = "0x600040E")]
	[Address(RVA = "0x7089468", Offset = "0x7085468", VA = "0x7089468")]
	public static void RemoveHandleById(int _0086Lji_00A7_00B7)
	{
	}

	[SpecialName]
	[Token(Token = "0x600040F")]
	[Address(RVA = "0x7095C8C", Offset = "0x7091C8C", VA = "0x7095C8C")]
	public void fI_00BD_005Dº_007B(Dictionary<int, UpdateHandle> _00A3_0092T_007E_00ABc)
	{
	}

	[SpecialName]
	[Token(Token = "0x6000410")]
	[Address(RVA = "0x7095C94", Offset = "0x7091C94", VA = "0x7095C94")]
	public void _0091qi_00BFJ_00A1(List<UpdateHandle> _00A3_0092T_007E_00ABc)
	{
	}

	[SpecialName]
	[Token(Token = "0x6000411")]
	[Address(RVA = "0x7095C9C", Offset = "0x7091C9C", VA = "0x7095C9C")]
	public void q_0091bF_00B0_0090(List<UpdateHandle> _00A3_0092T_007E_00ABc)
	{
	}

	[Token(Token = "0x6000412")]
	[Address(RVA = "0x7095CA4", Offset = "0x7091CA4", VA = "0x7095CA4")]
	public static void _0082_009CI_00A6_00B6_0097(UpdateHandle A_0085_007D_0092_00BDr)
	{
	}

	[Token(Token = "0x6000413")]
	[Address(RVA = "0x7095F70", Offset = "0x7091F70", VA = "0x7095F70")]
	private void _00AB_0080_0085r_0087_00A5()
	{
	}

	[Token(Token = "0x6000414")]
	[Address(RVA = "0x7096028", Offset = "0x7092028", VA = "0x7096028")]
	private int _00AC_00ABl_0087_0098c(UpdateHandle A_0085_007D_0092_00BDr)
	{
		return default;
	}

	[SpecialName]
	[Token(Token = "0x6000415")]
	[Address(RVA = "0x708861C", Offset = "0x708461C", VA = "0x708861C")]
	public static UpdateManager y_00A8s_0087F_00BD()
	{
		return null;
	}

	[Token(Token = "0x6000416")]
	[Address(RVA = "0x709610C", Offset = "0x709210C", VA = "0x709610C")]
	public static int AddForceHandle(UpdateHandle A_0085_007D_0092_00BDr)
	{
		return default;
	}

	[Token(Token = "0x6000417")]
	[Address(RVA = "0x709612C", Offset = "0x709212C", VA = "0x709612C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000419")]
	[Address(RVA = "0x70961F0", Offset = "0x70921F0", VA = "0x70961F0")]
	private int ºº_0090_008AA_00A8()
	{
		return default;
	}

	[SpecialName]
	[Token(Token = "0x600041A")]
	[Address(RVA = "0x7096268", Offset = "0x7092268", VA = "0x7096268")]
	public Dictionary<int, UpdateHandle> r_00B8FhQb()
	{
		return null;
	}

	[Token(Token = "0x600041B")]
	[Address(RVA = "0x70962E0", Offset = "0x70922E0", VA = "0x70962E0")]
	private void _007F_008F_00BB_009B_0081_0084(int _0086Lji_00A7_00B7)
	{
	}

	[SpecialName]
	[Token(Token = "0x600041C")]
	[Address(RVA = "0x7095CC4", Offset = "0x7091CC4", VA = "0x7095CC4")]
	public static UpdateManager c_00B4_00A8HOf()
	{
		return null;
	}

	[SpecialName]
	[Token(Token = "0x600041D")]
	[Address(RVA = "0x70963D8", Offset = "0x70923D8", VA = "0x70963D8")]
	public List<UpdateHandle> _009FdR_009CW_008A()
	{
		return null;
	}

	[Token(Token = "0x600041E")]
	[Address(RVA = "0x7096450", Offset = "0x7092450", VA = "0x7096450")]
	private void Start()
	{
	}

	[Token(Token = "0x600041F")]
	[Address(RVA = "0x7094FA0", Offset = "0x7090FA0", VA = "0x7094FA0")]
	private int j_008AaWg_00A6()
	{
		return default;
	}

	[Token(Token = "0x6000420")]
	[Address(RVA = "0x7096454", Offset = "0x7092454", VA = "0x7096454")]
	public UpdateManager()
	{
            _008C_00B4cx_009B_00AE = new List<int>();
            _00A8S_0098_0092Q_009B = new List<UpdateHandle>();
            _00A1_0098Á_00B6b_00B3 = new Dictionary<int, UpdateData>();
            B_0090rE_00AC_007D = 16;
		}

	[Token(Token = "0x6000421")]
	[Address(RVA = "0x7096568", Offset = "0x7092568", VA = "0x7096568")]
	private int _009EAbFdc(UpdateHandle A_0085_007D_0092_00BDr)
	{
		return default;
	}

	[Token(Token = "0x6000422")]
	[Address(RVA = "0x709664C", Offset = "0x709264C", VA = "0x709664C")]
	private int _0085_00ACzÀÀM(UpdateHandle A_0085_007D_0092_00BDr)
	{
		return default;
	}

	[SpecialName]
	[Token(Token = "0x6000423")]
	[Address(RVA = "0x7087EC0", Offset = "0x7083EC0", VA = "0x7087EC0")]
	public static UpdateManager V_007E_0082_00B0x_00B9()
	{
		return null;
	}

	[Token(Token = "0x6000425")]
	[Address(RVA = "0x7096730", Offset = "0x7092730", VA = "0x7096730")]
	public static void gqM_0084N_0097(int _0086Lji_00A7_00B7, string _00A5_00B3s_00A1_00BBc, string t_008C_007CÂ_0090_00A0)
	{
	}

	[Token(Token = "0x6000426")]
	[Address(RVA = "0x7096AF0", Offset = "0x7092AF0", VA = "0x7096AF0")]
	private int dY_0081_00B7_0080_005D(UpdateHandle A_0085_007D_0092_00BDr)
	{
		return default;
	}

	[Token(Token = "0x6000427")]
	[Address(RVA = "0x7096BD4", Offset = "0x7092BD4", VA = "0x7096BD4")]
	private void _00A7rmÀN_0087()
	{
	}

	[Token(Token = "0x6000429")]
	[Address(RVA = "0x7096BE0", Offset = "0x7092BE0", VA = "0x7096BE0")]
	private void _00A1UNt_0060J(int _00B2_0097_005Biy_00B6)
	{
	}

	[Token(Token = "0x600042A")]
	[Address(RVA = "0x7089448", Offset = "0x7085448", VA = "0x7089448")]
	public static int AddHandle(UpdateHandle A_0085_007D_0092_00BDr)
	{
		return default;
	}

	[Token(Token = "0x600042B")]
	[Address(RVA = "0x7096CB0", Offset = "0x7092CB0", VA = "0x7096CB0")]
	public static void AddUpdateData(int _0086Lji_00A7_00B7, string _00A5_00B3s_00A1_00BBc, string t_008C_007CÂ_0090_00A0)
	{
	}

	[SpecialName]
	[Token(Token = "0x600042D")]
	[Address(RVA = "0x7095960", Offset = "0x7091960", VA = "0x7095960")]
	public List<UpdateHandle> _00ABJ_0098Dz_0098()
	{
		return null;
	}

	[Token(Token = "0x600042E")]
	[Address(RVA = "0x7096CE8", Offset = "0x7092CE8", VA = "0x7096CE8")]
	private void P_0098_008B_0089c_009B()
	{
	}

	[Token(Token = "0x600042F")]
	[Address(RVA = "0x7097110", Offset = "0x7093110", VA = "0x7097110")]
	private void _00AE_009Ei_00A1_0081_0097(int _00B2_0097_005Biy_00B6)
	{
	}

	[Token(Token = "0x6000430")]
	[Address(RVA = "0x70971E4", Offset = "0x70931E4", VA = "0x70971E4")]
	public static void RemoveHandle(UpdateHandle A_0085_007D_0092_00BDr)
	{
	}

	[Token(Token = "0x6000431")]
	[Address(RVA = "0x7097204", Offset = "0x7093204", VA = "0x7097204")]
	public static void Z_0084_005BI_009A_005B(UpdateHandle A_0085_007D_0092_00BDr)
	{
	}

	[Token(Token = "0x6000432")]
	[Address(RVA = "0x7097224", Offset = "0x7093224", VA = "0x7097224")]
	private int _00B3XV_00B1K_0060(UpdateHandle A_0085_007D_0092_00BDr)
	{
		return default;
	}

	[Token(Token = "0x6000433")]
	[Address(RVA = "0x7095238", Offset = "0x7091238", VA = "0x7095238")]
	private void _00A1Â_00A5M_00AFa()
	{
	}

	[Token(Token = "0x6000434")]
	[Address(RVA = "0x7097308", Offset = "0x7093308", VA = "0x7097308")]
	public static int _0081_00AD_008Fl_00AD_00A7(UpdateHandle A_0085_007D_0092_00BDr)
	{
		return default;
	}

	[Token(Token = "0x6000435")]
	[Address(RVA = "0x7097328", Offset = "0x7093328", VA = "0x7097328")]
	public static int AddFixedHandle(UpdateHandle A_0085_007D_0092_00BDr)
	{
		return default;
	}

	[SpecialName]
	[Token(Token = "0x6000436")]
	[Address(RVA = "0x7096768", Offset = "0x7092768", VA = "0x7096768")]
	public static UpdateManager _007F_009Ast_007CS()
	{
		return null;
	}

	[SpecialName]
	[Token(Token = "0x6000437")]
	[Address(RVA = "0x709742C", Offset = "0x709342C", VA = "0x709742C")]
	public void Qr_0093_00A6_0091_00A4(Dictionary<int, UpdateHandle> _00A3_0092T_007E_00ABc)
	{
	}

	[Token(Token = "0x6000438")]
	[Address(RVA = "0x7096E58", Offset = "0x7092E58", VA = "0x7096E58")]
	private void _007C_00B1oW_0084i(UpdateHandle A_0085_007D_0092_00BDr)
	{
	}

	[SpecialName]
	[Token(Token = "0x6000439")]
	[Address(RVA = "0x70974AC", Offset = "0x70934AC", VA = "0x70974AC")]
	public void _007D_005DlÀT_00A2(Dictionary<int, UpdateHandle> _00A3_0092T_007E_00ABc)
	{
	}

	[Token(Token = "0x600043B")]
	[Address(RVA = "0x70974BC", Offset = "0x70934BC", VA = "0x70974BC")]
	public static int C_00B2_008D_009B_007D_00B4(UpdateHandle A_0085_007D_0092_00BDr)
	{
		return default;
	}

	[SpecialName]
	[Token(Token = "0x600043D")]
	[Address(RVA = "0x70974E4", Offset = "0x70934E4", VA = "0x70974E4")]
	public int _0080_00B7S_007D_00A7_0080()
	{
		return default;
	}

	[SpecialName]
	[Token(Token = "0x600043E")]
	[Address(RVA = "0x70974EC", Offset = "0x70934EC", VA = "0x70974EC")]
	public List<UpdateHandle> VQ_00B4_008E_005B_00A7()
	{
		return null;
	}

	[SpecialName]
	[Token(Token = "0x600043F")]
	[Address(RVA = "0x7097434", Offset = "0x7093434", VA = "0x7097434")]
	public List<UpdateHandle> wW_0097_00A8_008C_00A3()
	{
		return null;
	}

	[Token(Token = "0x6000440")]
	[Address(RVA = "0x7095EA0", Offset = "0x7091EA0", VA = "0x7095EA0")]
	private void _0089Jjµc_00A6(UpdateHandle A_0085_007D_0092_00BDr)
	{
	}

	[Token(Token = "0x6000441")]
	[Address(RVA = "0x7097564", Offset = "0x7093564", VA = "0x7097564")]
	private void OnApplicationPause(bool jQO_007E_007FO)
	{
	}

	[SpecialName]
	[Token(Token = "0x6000442")]
	[Address(RVA = "0x7097568", Offset = "0x7093568", VA = "0x7097568")]
	public void _00A8_00B4_00BCWF_00B7(Dictionary<int, UpdateHandle> _00A3_0092T_007E_00ABc)
	{
	}

	[Token(Token = "0x6000443")]
	[Address(RVA = "0x7089F48", Offset = "0x7085F48", VA = "0x7089F48")]
	public static int _0080u_007Fj_00B4_007B(UpdateHandle A_0085_007D_0092_00BDr)
	{
		return default;
	}

	[Token(Token = "0x6000444")]
	[Address(RVA = "0x7097348", Offset = "0x7093348", VA = "0x7097348")]
	private int _008B_007F_00AB_0093be(UpdateHandle A_0085_007D_0092_00BDr)
	{
		return default;
	}

	[Token(Token = "0x6000446")]
	[Address(RVA = "0x7096944", Offset = "0x7092944", VA = "0x7096944")]
	private void X_00A9W_0093_0085_007C(int _0086Lji_00A7_00B7, string _009F_009By_00B6_0094I, string t_008C_007CÂ_0090_00A0)
	{
	}
}
