using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace GameFramework
{
	[Token(Token = "0x2000403")]
	public class InputManager : MonoBehaviour
	{
		[Token(Token = "0x2000404")]
		public delegate void OnTouchDebugHandle(string _008C_00A8_00A1cf_00A6);

		[Token(Token = "0x2000405")]
		public delegate void OnTouchHandle(float µª_009Ey_00BB_00AE, float _0082To_00B4Gw);

		[Token(Token = "0x2000406")]
		public delegate void OnMulTouchHandle(int y_0086lp_007D_0098, List<MulTouchData> Er_0060L_0081_00B3);

		[Token(Token = "0x2000407")]
		public delegate void OnMulTouchEndHandle();

		[Token(Token = "0x2000408")]
		public delegate void OnScaleHandle(float _00B2_0080n_0097_00B3E);

		[Token(Token = "0x2000409")]
		public delegate void OnKeyHandle(KeyCode _0088_00A7_00B0_00B8Y_0090);

		[Token(Token = "0x200040A")]
		public delegate void OnKeyHoldHandle(List<KeyCode> fS_009DG_0098_009F);

		[Token(Token = "0x4001D2F")]
		[FieldOffset(Offset = "0x0")]
		public static int MoveStep;

		[Token(Token = "0x4001D30")]
		[FieldOffset(Offset = "0x8")]
		private static InputManager O_00BEªA_00BE_007C;

		[Token(Token = "0x4001D31")]
		[FieldOffset(Offset = "0x20")]
		private float gµ_00A4_0098_00A3_00AF;

		[Token(Token = "0x4001D32")]
		[FieldOffset(Offset = "0x24")]
		private float _00B4fI_0082O_0089;

		[Token(Token = "0x4001D33")]
		[FieldOffset(Offset = "0x28")]
		private KeyCode H_007Bk_0092O_00B4;

		[Token(Token = "0x4001D34")]
		[FieldOffset(Offset = "0x30")]
		private List<KeyCode> o_0090_00B4B_00B9U;

		[Token(Token = "0x4001D35")]
		[FieldOffset(Offset = "0x38")]
		private Vector3 dk_009F_009E_009AI;

		[Token(Token = "0x4001D36")]
		[FieldOffset(Offset = "0x44")]
		private int l_0094C_00B2_00B7l;

		[Token(Token = "0x4001D37")]
		[FieldOffset(Offset = "0x48")]
		private List<MulTouchData> _00A8_00BC_00BEªd_007B;

		[Token(Token = "0x4001D38")]
		[FieldOffset(Offset = "0x50")]
		private string ynµ_008By_008E;

		[Token(Token = "0x4001D39")]
		[FieldOffset(Offset = "0x58")]
		private OnTouchHandle _0091_005E_0089_007C_009DG;

		[Token(Token = "0x4001D3A")]
		[FieldOffset(Offset = "0x60")]
		private OnTouchHandle N_0097p_00AF_0097V;

		[Token(Token = "0x4001D3B")]
		[FieldOffset(Offset = "0x68")]
		private OnTouchHandle º_007F_00B4_008E_009BH;

		[Token(Token = "0x4001D3C")]
		[FieldOffset(Offset = "0x70")]
		private OnTouchHandle _007F_008D_0084xpQ;

		[Token(Token = "0x4001D3D")]
		[FieldOffset(Offset = "0x78")]
		private OnTouchHandle _0089_00B9_009B_00AEtº;

		[Token(Token = "0x4001D3E")]
		[FieldOffset(Offset = "0x80")]
		private OnTouchDebugHandle q_00B7_0081y_007C_0083;

		[Token(Token = "0x4001D3F")]
		[FieldOffset(Offset = "0x88")]
		private OnMulTouchHandle _00B8_0087es_00A6_00AD;

		[Token(Token = "0x4001D40")]
		[FieldOffset(Offset = "0x90")]
		private OnMulTouchHandle _009AD_00B4_0086_00A0_0084;

		[Token(Token = "0x4001D41")]
		[FieldOffset(Offset = "0x98")]
		private OnMulTouchHandle Z_0081_00BBut_00A1;

		[Token(Token = "0x4001D42")]
		[FieldOffset(Offset = "0xA0")]
		private OnMulTouchEndHandle _0092_0082_0090_00A1aZ;

		[Token(Token = "0x4001D43")]
		[FieldOffset(Offset = "0xA8")]
		private OnScaleHandle G_009E_009C_00AFmi;

		[Token(Token = "0x4001D44")]
		[FieldOffset(Offset = "0xB0")]
		private OnKeyHandle b_005BmÂ_0087_00A5;

		[Token(Token = "0x4001D45")]
		[FieldOffset(Offset = "0xB8")]
		private OnKeyHoldHandle wsESF_0082;

		[Token(Token = "0x4001D46")]
		[FieldOffset(Offset = "0xC0")]
		private OnKeyHandle _007C_00B0_00BC_00B2xu;

		[Token(Token = "0x4001D47")]
		[FieldOffset(Offset = "0xC8")]
		private float h_00B9_00B8_005E_00BDY;

		[Token(Token = "0x4001D48")]
		[FieldOffset(Offset = "0xCC")]
		private float W_00A1FGT_008E;

		[Token(Token = "0x4001D49")]
		[FieldOffset(Offset = "0xD0")]
		private float _0086_00B1P_00A2I_00A0;

		[Token(Token = "0x4001D4A")]
		[FieldOffset(Offset = "0xD4")]
		private float _00B9B_009ANFp;

		[Token(Token = "0x4001D4B")]
		[FieldOffset(Offset = "0xD8")]
		private List<KeyCode> _00B8_0098y_0083_00BFª;

		[Token(Token = "0x17001176")]
		public static InputManager Instance
		{
			[Token(Token = "0x6006286")]
			[Address(RVA = "0x72030A0", Offset = "0x71FF0A0", VA = "0x72030A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001177")]
		public float MouseX
		{
			[Token(Token = "0x600628D")]
			[Address(RVA = "0x7206778", Offset = "0x7202778", VA = "0x7206778")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17001178")]
		public float MouseY
		{
			[Token(Token = "0x6006232")]
			[Address(RVA = "0x7203D04", Offset = "0x71FFD04", VA = "0x7203D04")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17001179")]
		public int MulTouchLen
		{
			[Token(Token = "0x6006275")]
			[Address(RVA = "0x72060C4", Offset = "0x72020C4", VA = "0x72060C4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6006222")]
		[Address(RVA = "0x7202FC0", Offset = "0x71FEFC0", VA = "0x7202FC0")]
		private void _00A9_00A8ª_0086Z_008F(OnTouchHandle A_0085_007D_0092_00BDr)
		{
		}

		[Token(Token = "0x6006223")]
		[Address(RVA = "0x7203040", Offset = "0x71FF040", VA = "0x7203040")]
		public static void RemoveMulTouchHoldListener(OnMulTouchHandle A_0085_007D_0092_00BDr)
		{
		}

		[Token(Token = "0x6006224")]
		[Address(RVA = "0x7203330", Offset = "0x71FF330", VA = "0x7203330")]
		private void k_0088ºi_008Dª(OnTouchHandle A_0085_007D_0092_00BDr)
		{
		}

		[Token(Token = "0x6006225")]
		[Address(RVA = "0x72033B0", Offset = "0x71FF3B0", VA = "0x72033B0")]
		private void h_00AE_009B_00B6Àb(OnMulTouchHandle A_0085_007D_0092_00BDr)
		{
		}

		[Token(Token = "0x6006226")]
		[Address(RVA = "0x7203430", Offset = "0x71FF430", VA = "0x7203430")]
		private void w_007F_008C_0082_0080p()
		{
		}

		[SpecialName]
		[Token(Token = "0x6006227")]
		[Address(RVA = "0x7203458", Offset = "0x71FF458", VA = "0x7203458")]
		public float _0096QoiJZ()
		{
			return default;
		}

		[Token(Token = "0x6006228")]
		[Address(RVA = "0x7203460", Offset = "0x71FF460", VA = "0x7203460")]
		private void N_008F_00B3_005Dy_008E(OnKeyHandle A_0085_007D_0092_00BDr)
		{
		}

		[Token(Token = "0x6006229")]
		[Address(RVA = "0x72034E0", Offset = "0x71FF4E0", VA = "0x72034E0")]
		public static void FOd_007E_007Fª(OnKeyHandle A_0085_007D_0092_00BDr)
		{
		}

		[Token(Token = "0x600622A")]
		[Address(RVA = "0x72037E4", Offset = "0x71FF7E4", VA = "0x72037E4")]
		public static void AddMulTouchHoldListener(OnMulTouchHandle A_0085_007D_0092_00BDr)
		{
		}

		[Token(Token = "0x600622B")]
		[Address(RVA = "0x72038C4", Offset = "0x71FF8C4", VA = "0x72038C4")]
		public static void AddScaleListener(OnScaleHandle A_0085_007D_0092_00BDr)
		{
		}

		[Token(Token = "0x600622C")]
		[Address(RVA = "0x72039A4", Offset = "0x71FF9A4", VA = "0x72039A4")]
		private void _00A3_0085_00B0_009B_009C_007F()
		{
		}

		[Token(Token = "0x600622D")]
		[Address(RVA = "0x72039C4", Offset = "0x71FF9C4", VA = "0x72039C4")]
		private void _0092a_00A7_008FD_008C(OnMulTouchHandle A_0085_007D_0092_00BDr)
		{
		}

		[Token(Token = "0x600622E")]
		[Address(RVA = "0x7203A44", Offset = "0x71FFA44", VA = "0x7203A44")]
		private void oµ_00BDU_009C_0099(OnTouchHandle A_0085_007D_0092_00BDr)
		{
		}

		[Token(Token = "0x600622F")]
		[Address(RVA = "0x7203AC4", Offset = "0x71FFAC4", VA = "0x7203AC4")]
		public static void AddClickListener(OnTouchHandle A_0085_007D_0092_00BDr)
		{
		}

		[Token(Token = "0x6006230")]
		[Address(RVA = "0x7203BA4", Offset = "0x71FFBA4", VA = "0x7203BA4")]
		public static void RemoveKeyHoldListener(OnKeyHoldHandle A_0085_007D_0092_00BDr)
		{
		}

		[Token(Token = "0x6006231")]
		[Address(RVA = "0x7203C84", Offset = "0x71FFC84", VA = "0x7203C84")]
		private void _0099as_00B8_0093_00B4(OnMulTouchHandle A_0085_007D_0092_00BDr)
		{
		}

		[Token(Token = "0x6006233")]
		[Address(RVA = "0x7203D0C", Offset = "0x71FFD0C", VA = "0x7203D0C")]
		private void j_0083Wd_00AE_008F()
		{
		}

		[Token(Token = "0x6006234")]
		[Address(RVA = "0x7203D78", Offset = "0x71FFD78", VA = "0x7203D78")]
		public static void Â_008D_005Eº_0089_005E(OnTouchHandle A_0085_007D_0092_00BDr)
		{
		}

		[Token(Token = "0x6006235")]
		[Address(RVA = "0x7203E58", Offset = "0x71FFE58", VA = "0x7203E58")]
		private void Update()
		{
		}

		[Token(Token = "0x6006236")]
		[Address(RVA = "0x7203F10", Offset = "0x71FFF10", VA = "0x7203F10")]
		private void tiG_0099s_007B()
		{
		}

		[Token(Token = "0x6006237")]
		[Address(RVA = "0x7203F38", Offset = "0x71FFF38", VA = "0x7203F38")]
		public static void _008ASÁnN_009E(OnMulTouchHandle A_0085_007D_0092_00BDr)
		{
		}

		[Token(Token = "0x6006238")]
		[Address(RVA = "0x7203764", Offset = "0x71FF764", VA = "0x7203764")]
		private void _009Fnz_009F_00A3_00B9(OnKeyHandle A_0085_007D_0092_00BDr)
		{
		}

		[Token(Token = "0x6006239")]
		[Address(RVA = "0x7203F98", Offset = "0x71FFF98", VA = "0x7203F98")]
		private void _00B0RrF_0092_00BF()
		{
		}

		[Token(Token = "0x600623A")]
		[Address(RVA = "0x7203FB8", Offset = "0x71FFFB8", VA = "0x7203FB8")]
		public static void RemoveTouchHoldListener(OnTouchHandle A_0085_007D_0092_00BDr)
		{
		}

		[Token(Token = "0x600623B")]
		[Address(RVA = "0x7204098", Offset = "0x7200098", VA = "0x7204098")]
		private void Qµd_0091P_00BF()
		{
		}

		[Token(Token = "0x600623C")]
		[Address(RVA = "0x7203E5C", Offset = "0x71FFE5C", VA = "0x7203E5C")]
		public void CheckTouch()
		{
		}

		[Token(Token = "0x600623D")]
		[Address(RVA = "0x7203B24", Offset = "0x71FFB24", VA = "0x7203B24")]
		private void _00A2R_00ADY_007ER(OnTouchHandle A_0085_007D_0092_00BDr)
		{
		}

		[Token(Token = "0x600623E")]
		[Address(RVA = "0x72049A4", Offset = "0x72009A4", VA = "0x72049A4")]
		private void _0083_0096_00A0_007D_00B9µ(OnKeyHandle A_0085_007D_0092_00BDr)
		{
		}

		[Token(Token = "0x600623F")]
		[Address(RVA = "0x7204A24", Offset = "0x7200A24", VA = "0x7204A24")]
		private void _0085_00A4_007BD_0099_005E(OnTouchDebugHandle A_0085_007D_0092_00BDr)
		{
		}

		[Token(Token = "0x6006240")]
		[Address(RVA = "0x7204AA4", Offset = "0x7200AA4", VA = "0x7204AA4")]
		private void j_00A4_00B7Â_0092_00B7(OnMulTouchHandle A_0085_007D_0092_00BDr)
		{
		}

		[Token(Token = "0x6006241")]
		[Address(RVA = "0x7204B24", Offset = "0x7200B24", VA = "0x7204B24")]
		private void _0087_008BB_0083_00BE_00B1(OnKeyHandle A_0085_007D_0092_00BDr)
		{
		}

		[Token(Token = "0x6006242")]
		[Address(RVA = "0x7204BA4", Offset = "0x7200BA4", VA = "0x7204BA4")]
		public static void AddTouchHoldListener(OnTouchHandle A_0085_007D_0092_00BDr)
		{
		}

		[Token(Token = "0x6006243")]
		[Address(RVA = "0x72032B0", Offset = "0x71FF2B0", VA = "0x72032B0")]
		private void lv_007D_00B2_008Df(OnMulTouchHandle A_0085_007D_0092_00BDr)
		{
		}

		[Token(Token = "0x6006244")]
		[Address(RVA = "0x7204C04", Offset = "0x7200C04", VA = "0x7204C04")]
		private void nj_00ACÂ_0087_00A7(OnTouchHandle A_0085_007D_0092_00BDr)
		{
		}

		[Token(Token = "0x6006245")]
		[Address(RVA = "0x7204C84", Offset = "0x7200C84", VA = "0x7204C84")]
		public static void RemoveKeyDownListener(OnKeyHandle A_0085_007D_0092_00BDr)
		{
		}

		[Token(Token = "0x6006246")]
		[Address(RVA = "0x7204CE4", Offset = "0x7200CE4", VA = "0x7204CE4")]
		public static void QFP_008Fº_008D(OnKeyHandle A_0085_007D_0092_00BDr)
		{
		}

		[Token(Token = "0x6006247")]
		[Address(RVA = "0x7204D44", Offset = "0x7200D44", VA = "0x7204D44")]
		private void Âk_0090WmQ(OnScaleHandle A_0085_007D_0092_00BDr)
		{
		}

		[Token(Token = "0x6006248")]
		[Address(RVA = "0x7204DC4", Offset = "0x7200DC4", VA = "0x7204DC4")]
		private void _0060zTNyw()
		{
		}

		[Token(Token = "0x6006249")]
		[Address(RVA = "0x7204DE4", Offset = "0x7200DE4", VA = "0x7204DE4")]
		private void w_0091f_00BFzP(OnScaleHandle A_0085_007D_0092_00BDr)
		{
		}

		[Token(Token = "0x600624A")]
		[Address(RVA = "0x7204E64", Offset = "0x7200E64", VA = "0x7204E64")]
		private void LHO_0089_0090_007B(OnTouchHandle A_0085_007D_0092_00BDr)
		{
		}

		[Token(Token = "0x600624B")]
		[Address(RVA = "0x7204EE4", Offset = "0x7200EE4", VA = "0x7204EE4")]
		public static void AddMulTouchMoveListener(OnMulTouchHandle A_0085_007D_0092_00BDr)
		{
		}

		[Token(Token = "0x600624C")]
		[Address(RVA = "0x7203DD8", Offset = "0x71FFDD8", VA = "0x7203DD8")]
		private void _00AC_00B1_0092_0088G_00A0(OnTouchHandle A_0085_007D_0092_00BDr)
		{
		}

		[Token(Token = "0x600624D")]
		[Address(RVA = "0x7204FC4", Offset = "0x7200FC4", VA = "0x7204FC4")]
		public static void AddKeyHoldListener(OnKeyHoldHandle A_0085_007D_0092_00BDr)
		{
		}

		[Token(Token = "0x600624E")]
		[Address(RVA = "0x72050A4", Offset = "0x72010A4", VA = "0x72050A4")]
		public static void _0081_00A0_00A0_009B_009E_00B9(OnMulTouchHandle A_0085_007D_0092_00BDr)
		{
		}

		[Token(Token = "0x600624F")]
		[Address(RVA = "0x7205104", Offset = "0x7201104", VA = "0x7205104")]
		private void _007FiI_00AF_0090c(OnTouchHandle A_0085_007D_0092_00BDr)
		{
		}

		[Token(Token = "0x6006250")]
		[Address(RVA = "0x7205230", Offset = "0x7201230", VA = "0x7205230")]
		private void Pi_007F_00A5_00B2_0098()
		{
		}

		[Token(Token = "0x6006251")]
		[Address(RVA = "0x7205250", Offset = "0x7201250", VA = "0x7205250")]
		public static void RemoveMulTouchMoveListener(OnMulTouchHandle A_0085_007D_0092_00BDr)
		{
		}

		[Token(Token = "0x6006252")]
		[Address(RVA = "0x7205330", Offset = "0x7201330", VA = "0x7205330")]
		private void r_00A3_0083º_00AD_00B9()
		{
		}

		[Token(Token = "0x6006253")]
		[Address(RVA = "0x7205334", Offset = "0x7201334", VA = "0x7205334")]
		public static void jO_009A_0082_00ACQ(OnKeyHandle A_0085_007D_0092_00BDr)
		{
		}

		[Token(Token = "0x6006254")]
		[Address(RVA = "0x7205394", Offset = "0x7201394", VA = "0x7205394")]
		private void _00BF_00B4_00BFUU_0093()
		{
		}

		[Token(Token = "0x6006255")]
		[Address(RVA = "0x72052B0", Offset = "0x72012B0", VA = "0x72052B0")]
		private void Q_00A4y_009D_00BC_00A8(OnMulTouchHandle A_0085_007D_0092_00BDr)
		{
		}

		[Token(Token = "0x6006256")]
		[Address(RVA = "0x72053B4", Offset = "0x72013B4", VA = "0x72053B4")]
		private void WÁªN_00B3o(OnTouchHandle A_0085_007D_0092_00BDr)
		{
		}

		[Token(Token = "0x6006257")]
		[Address(RVA = "0x7205434", Offset = "0x7201434", VA = "0x7205434")]
		public static void µKa_00BF_00A6t(OnTouchHandle A_0085_007D_0092_00BDr)
		{
		}

		[Token(Token = "0x6006258")]
		[Address(RVA = "0x7205494", Offset = "0x7201494", VA = "0x7205494")]
		private void _00BD_0085A_008DB_00B3()
		{
		}

		[Token(Token = "0x6006259")]
		[Address(RVA = "0x7203924", Offset = "0x71FF924", VA = "0x7203924")]
		private void _00A8_0095qjeT(OnScaleHandle A_0085_007D_0092_00BDr)
		{
		}

		[Token(Token = "0x600625A")]
		[Address(RVA = "0x72054B4", Offset = "0x72014B4", VA = "0x72054B4")]
		public static void _00B4f_00B7Á_00B7_00AB(OnTouchHandle A_0085_007D_0092_00BDr)
		{
		}

		[Token(Token = "0x600625B")]
		[Address(RVA = "0x7205594", Offset = "0x7201594", VA = "0x7205594")]
		public static void RemoveScaleListener(OnScaleHandle A_0085_007D_0092_00BDr)
		{
		}

		[Token(Token = "0x600625C")]
		[Address(RVA = "0x72055F4", Offset = "0x72015F4", VA = "0x72055F4")]
		private void F_007E_009Es_00B4_0094()
		{
		}

		[Token(Token = "0x600625E")]
		[Address(RVA = "0x7205668", Offset = "0x7201668", VA = "0x7205668")]
		public static void RemoveKeyUpListener(OnKeyHandle A_0085_007D_0092_00BDr)
		{
		}

		[Token(Token = "0x600625F")]
		[Address(RVA = "0x7204F44", Offset = "0x7200F44", VA = "0x7204F44")]
		private void _00B7PC_00B4QJ(OnMulTouchHandle A_0085_007D_0092_00BDr)
		{
		}

		[SpecialName]
		[Token(Token = "0x6006260")]
		[Address(RVA = "0x7203540", Offset = "0x71FF540", VA = "0x7203540")]
		public static InputManager _00BF_00A0_00AFwF_007D()
		{
			return null;
		}

		[Token(Token = "0x6006261")]
		[Address(RVA = "0x7205748", Offset = "0x7201748", VA = "0x7205748")]
		public static void AddMulTouchBeginListener(OnMulTouchHandle A_0085_007D_0092_00BDr)
		{
		}

		[Token(Token = "0x6006262")]
		[Address(RVA = "0x72057A8", Offset = "0x72017A8", VA = "0x72057A8")]
		public static void RemoveMulTouchEndListener(OnMulTouchEndHandle A_0085_007D_0092_00BDr)
		{
		}

		[Token(Token = "0x6006263")]
		[Address(RVA = "0x7205808", Offset = "0x7201808", VA = "0x7205808")]
		private void _00B1_00AD_00ACV_008Fi(OnMulTouchEndHandle A_0085_007D_0092_00BDr)
		{
		}

		[Token(Token = "0x6006264")]
		[Address(RVA = "0x7205888", Offset = "0x7201888", VA = "0x7205888")]
		private void Start()
		{
		}

		[Token(Token = "0x6006265")]
		[Address(RVA = "0x7203C04", Offset = "0x71FFC04", VA = "0x7203C04")]
		private void _007B_00B6_0099_0091_0080º(OnKeyHoldHandle A_0085_007D_0092_00BDr)
		{
		}

		[Token(Token = "0x6006266")]
		[Address(RVA = "0x7204104", Offset = "0x7200104", VA = "0x7204104")]
		public void GetTouchInput()
		{
		}

		[Token(Token = "0x6006267")]
		[Address(RVA = "0x7205950", Offset = "0x7201950", VA = "0x7205950")]
		private void l_0060x_009Ek_0090(OnMulTouchHandle A_0085_007D_0092_00BDr)
		{
		}

		[Token(Token = "0x6006268")]
		[Address(RVA = "0x72059D0", Offset = "0x72019D0", VA = "0x72059D0")]
		public static void d_009C_00B7A_00A4_0080(OnKeyHoldHandle A_0085_007D_0092_00BDr)
		{
		}

		[Token(Token = "0x6006269")]
		[Address(RVA = "0x72058EC", Offset = "0x72018EC", VA = "0x72058EC")]
		private void wU_007F_007F_0093Á()
		{
		}

		[Token(Token = "0x600626A")]
		[Address(RVA = "0x7205C54", Offset = "0x7201C54", VA = "0x7205C54")]
		public static void q_00B8e_00AD_00A6_008F(OnKeyHandle A_0085_007D_0092_00BDr)
		{
		}

		[Token(Token = "0x600626B")]
		[Address(RVA = "0x7205CB4", Offset = "0x7201CB4", VA = "0x7205CB4")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600626C")]
		[Address(RVA = "0x7205514", Offset = "0x7201514", VA = "0x7205514")]
		private void _0083l_008A_008C_00ADs(OnTouchHandle A_0085_007D_0092_00BDr)
		{
		}

		[Token(Token = "0x600626D")]
		[Address(RVA = "0x7205ED4", Offset = "0x7201ED4", VA = "0x7205ED4")]
		public static void RemoveTouchBeginListener(OnTouchHandle A_0085_007D_0092_00BDr)
		{
		}

		[Token(Token = "0x600626E")]
		[Address(RVA = "0x720590C", Offset = "0x720190C", VA = "0x720590C")]
		private void _008DQ_005B_008Cy_00A3()
		{
		}

		[Token(Token = "0x600626F")]
		[Address(RVA = "0x7205F34", Offset = "0x7201F34", VA = "0x7205F34")]
		private void oª_008Fk_008Dd(OnKeyHoldHandle A_0085_007D_0092_00BDr)
		{
		}

		[Token(Token = "0x6006270")]
		[Address(RVA = "0x7205FB4", Offset = "0x7201FB4", VA = "0x7205FB4")]
		public InputManager()
		{
		}

		[Token(Token = "0x6006271")]
		[Address(RVA = "0x720475C", Offset = "0x720075C", VA = "0x720475C")]
		private void Ocu_00A3yµ()
		{
		}

		[Token(Token = "0x6006272")]
		[Address(RVA = "0x7206004", Offset = "0x7202004", VA = "0x7206004")]
		public static void M_009A_009EK_00AB_008F(OnKeyHandle A_0085_007D_0092_00BDr)
		{
		}

		[Token(Token = "0x6006273")]
		[Address(RVA = "0x72056C8", Offset = "0x72016C8", VA = "0x72056C8")]
		private void S_00BBDr_007E_00B2(OnKeyHandle A_0085_007D_0092_00BDr)
		{
		}

		[Token(Token = "0x6006274")]
		[Address(RVA = "0x7206064", Offset = "0x7202064", VA = "0x7206064")]
		public static void RemoveTouchMoveListener(OnTouchHandle A_0085_007D_0092_00BDr)
		{
		}

		[Token(Token = "0x6006276")]
		[Address(RVA = "0x72060CC", Offset = "0x72020CC", VA = "0x72060CC")]
		private void _00AE_0092_00B6fD_00A0(OnTouchHandle A_0085_007D_0092_00BDr)
		{
		}

		[Token(Token = "0x6006277")]
		[Address(RVA = "0x720614C", Offset = "0x720214C", VA = "0x720614C")]
		public static void RemoveTouchDebugListener(OnTouchDebugHandle A_0085_007D_0092_00BDr)
		{
		}

		[Token(Token = "0x6006278")]
		[Address(RVA = "0x720622C", Offset = "0x720222C", VA = "0x720622C")]
		private void _00A7_00A5_00B1B_00B6v(OnMulTouchHandle A_0085_007D_0092_00BDr)
		{
		}

		[Token(Token = "0x6006279")]
		[Address(RVA = "0x72062AC", Offset = "0x72022AC", VA = "0x72062AC")]
		public static void RemoveTouchEndListener(OnTouchHandle A_0085_007D_0092_00BDr)
		{
		}

		[Token(Token = "0x600627A")]
		[Address(RVA = "0x720630C", Offset = "0x720230C", VA = "0x720630C")]
		public static void AddKeyDownListener(OnKeyHandle A_0085_007D_0092_00BDr)
		{
		}

		[Token(Token = "0x600627B")]
		[Address(RVA = "0x720636C", Offset = "0x720236C", VA = "0x720636C")]
		public static void l_00A6_00AB_0097_009B_0094(OnTouchHandle A_0085_007D_0092_00BDr)
		{
		}

		[Token(Token = "0x600627C")]
		[Address(RVA = "0x720588C", Offset = "0x720188C", VA = "0x720588C")]
		private void X_0080_00A9f_009C_007C()
		{
		}

		[Token(Token = "0x600627D")]
		[Address(RVA = "0x72063CC", Offset = "0x72023CC", VA = "0x72063CC")]
		public static void AddMulTouchEndListener(OnMulTouchEndHandle A_0085_007D_0092_00BDr)
		{
		}

		[Token(Token = "0x600627E")]
		[Address(RVA = "0x72058AC", Offset = "0x72018AC", VA = "0x72058AC")]
		private void G_00A7_005EI_00A6_0085()
		{
		}

		[Token(Token = "0x600627F")]
		[Address(RVA = "0x72064AC", Offset = "0x72024AC", VA = "0x72064AC")]
		public static void _005E_00A5_0081_0091Km(OnTouchHandle A_0085_007D_0092_00BDr)
		{
		}

		[Token(Token = "0x6006280")]
		[Address(RVA = "0x7205CB8", Offset = "0x7201CB8", VA = "0x7205CB8")]
		private void y_00B3_008Ff_007B_009C()
		{
		}

		[Token(Token = "0x6006281")]
		[Address(RVA = "0x720650C", Offset = "0x720250C", VA = "0x720650C")]
		public static void RemoveMulTouchBeginListener(OnMulTouchHandle A_0085_007D_0092_00BDr)
		{
		}

		[Token(Token = "0x6006282")]
		[Address(RVA = "0x720642C", Offset = "0x720242C", VA = "0x720642C")]
		private void _00BFkfÀc_007C(OnMulTouchEndHandle A_0085_007D_0092_00BDr)
		{
		}

		[Token(Token = "0x6006283")]
		[Address(RVA = "0x720656C", Offset = "0x720256C", VA = "0x720656C")]
		private void OUk_00A6_00B0Y()
		{
		}

		[Token(Token = "0x6006284")]
		[Address(RVA = "0x7206594", Offset = "0x7202594", VA = "0x7206594")]
		public void Shutdown()
		{
		}

		[Token(Token = "0x6006285")]
		[Address(RVA = "0x72065B8", Offset = "0x72025B8", VA = "0x72065B8")]
		private void W_00A7c_00A7_005DQ(OnTouchDebugHandle A_0085_007D_0092_00BDr)
		{
		}

		[Token(Token = "0x6006287")]
		[Address(RVA = "0x7206638", Offset = "0x7202638", VA = "0x7206638")]
		public static void RemoveClickListener(OnTouchHandle A_0085_007D_0092_00BDr)
		{
		}

		[Token(Token = "0x6006288")]
		[Address(RVA = "0x7203844", Offset = "0x71FF844", VA = "0x7203844")]
		private void _0088LªJni(OnMulTouchHandle A_0085_007D_0092_00BDr)
		{
		}

		[Token(Token = "0x6006289")]
		[Address(RVA = "0x7206698", Offset = "0x7202698", VA = "0x7206698")]
		private void m_00BFNu_00AD_00B0(OnKeyHandle A_0085_007D_0092_00BDr)
		{
		}

		[Token(Token = "0x600628A")]
		[Address(RVA = "0x7206718", Offset = "0x7202718", VA = "0x7206718")]
		public static void a_0092_007B_007Ce_00BE(OnTouchDebugHandle A_0085_007D_0092_00BDr)
		{
		}

		[Token(Token = "0x600628B")]
		[Address(RVA = "0x7204018", Offset = "0x7200018", VA = "0x7204018")]
		private void _0082_005B_008Be_007C_0080(OnTouchHandle A_0085_007D_0092_00BDr)
		{
		}

		[Token(Token = "0x600628C")]
		[Address(RVA = "0x72061AC", Offset = "0x72021AC", VA = "0x72061AC")]
		private void y_00BE_007B_0085V_0088(OnTouchDebugHandle A_0085_007D_0092_00BDr)
		{
		}

		[Token(Token = "0x600628E")]
		[Address(RVA = "0x7206780", Offset = "0x7202780", VA = "0x7206780")]
		public static void _00A6_00BD_00A0_00A4_008D_0080(OnTouchHandle A_0085_007D_0092_00BDr)
		{
		}

		[Token(Token = "0x600628F")]
		[Address(RVA = "0x7205024", Offset = "0x7201024", VA = "0x7205024")]
		private void _00BE_0081_00B3_009Dµ_009D(OnKeyHoldHandle A_0085_007D_0092_00BDr)
		{
		}

		[Token(Token = "0x6006290")]
		[Address(RVA = "0x72058CC", Offset = "0x72018CC", VA = "0x72058CC")]
		private void Â_00A9_008CCr_0085()
		{
		}

		[Token(Token = "0x6006291")]
		[Address(RVA = "0x72067E0", Offset = "0x72027E0", VA = "0x72067E0")]
		public static void AddTouchBeginListener(OnTouchHandle A_0085_007D_0092_00BDr)
		{
		}

		[Token(Token = "0x6006292")]
		[Address(RVA = "0x7205934", Offset = "0x7201934", VA = "0x7205934")]
		private void asa_008CW_009F()
		{
		}

		[Token(Token = "0x6006293")]
		[Address(RVA = "0x7206840", Offset = "0x7202840", VA = "0x7206840")]
		public static void AddKeyUpListener(OnKeyHandle A_0085_007D_0092_00BDr)
		{
		}

		[Token(Token = "0x6006294")]
		[Address(RVA = "0x72068A0", Offset = "0x72028A0", VA = "0x72068A0")]
		public static void Y_0092z_005E_0080D(OnTouchHandle A_0085_007D_0092_00BDr)
		{
		}

		[Token(Token = "0x6006295")]
		[Address(RVA = "0x7206900", Offset = "0x7202900", VA = "0x7206900")]
		public static void AddTouchMoveListener(OnTouchHandle A_0085_007D_0092_00BDr)
		{
		}

		[Token(Token = "0x6006296")]
		[Address(RVA = "0x7206960", Offset = "0x7202960", VA = "0x7206960")]
		public static void AddTouchEndListener(OnTouchHandle A_0085_007D_0092_00BDr)
		{
		}

		[SpecialName]
		[Token(Token = "0x6006297")]
		[Address(RVA = "0x7205A30", Offset = "0x7201A30", VA = "0x7205A30")]
		public static InputManager _005D_0081_009F_009D_00A6L()
		{
			return null;
		}

		[Token(Token = "0x6006298")]
		[Address(RVA = "0x72069C0", Offset = "0x72029C0", VA = "0x72069C0")]
		public static void AddTouchDebugListener(OnTouchDebugHandle A_0085_007D_0092_00BDr)
		{
		}
	}
}
