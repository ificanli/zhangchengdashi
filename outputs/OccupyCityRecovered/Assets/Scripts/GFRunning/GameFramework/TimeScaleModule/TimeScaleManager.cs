using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace GameFramework.TimeScaleModule
{
	[Token(Token = "0x200044A")]
	public class TimeScaleManager : GFMonoSingleton<TimeScaleManager>
	{
		[Token(Token = "0x4001E00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Header("Default Values")]
		[Tooltip("The reference time scale, to which the system will go back to after all time is changed")]
		public float NormalTimeScale;

		[Token(Token = "0x4001E01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Header("Impacted Values")]
		[Tooltip("whether or not to update Time.timeScale when changing time scale")]
		public bool UpdateTimescale;

		[Token(Token = "0x4001E02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		[Tooltip("whether or not to update Time.fixedDeltaTime when changing time scale")]
		public bool UpdateFixedDeltaTime;

		[Token(Token = "0x4001E03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
		[Tooltip("whether or not to update Time.maximumDeltaTime when changing time scale")]
		public bool UpdateMaximumDeltaTime;

		[Token(Token = "0x4001E04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("Debug")]
		[Tooltip("the current, real time, time scale")]
		[SerializeField]
		private float CurrentTimeScale;

		[Token(Token = "0x4001E05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		[Tooltip("the time scale the system is lerping towards")]
		private float TargetTimeScale;

		[Token(Token = "0x4001E06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool TestButton;

		[Token(Token = "0x4001E07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected Stack<TimeScaleProperties> _timeScaleProperties;

		[Token(Token = "0x4001E08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected TimeScaleProperties _currentProperty;

		[Token(Token = "0x4001E09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected TimeScaleProperties _resetProperty;

		[Token(Token = "0x4001E0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		protected float _initialFixedDeltaTime;

		[Token(Token = "0x4001E0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		protected float _initialMaximumDeltaTime;

		[Token(Token = "0x4001E0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		protected float _startedAt;

		[Token(Token = "0x4001E0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		protected bool _lerpingBackToNormal;

		[Token(Token = "0x4001E0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		protected float _timeScaleLastTime;

		[Token(Token = "0x6006986")]
		[Address(RVA = "0x7275C9C", Offset = "0x7271C9C", VA = "0x7275C9C", Slot = "31")]
		protected virtual void SetTimeScale(float qidVU_00AB)
		{
		}

		[Token(Token = "0x6006987")]
		[Address(RVA = "0x7275D10", Offset = "0x7271D10", VA = "0x7275D10", Slot = "32")]
		protected virtual void ResetTimeScale()
		{
		}

		[Token(Token = "0x6006988")]
		[Address(RVA = "0x7275D24", Offset = "0x7271D24", VA = "0x7275D24", Slot = "33")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6006989")]
		[Address(RVA = "0x7275D34", Offset = "0x7271D34", VA = "0x7275D34", Slot = "34")]
		protected virtual void ApplyTimeScale(float _005B_00BEµ_00B7_0098g)
		{
		}

		[Token(Token = "0x600698A")]
		[Address(RVA = "0x7275DB8", Offset = "0x7271DB8", VA = "0x7275DB8", Slot = "35")]
		public virtual void _00BEL_00AB_008FAt(float w_005EG_00B7Z_0084)
		{
		}

		[Token(Token = "0x600698B")]
		[Address(RVA = "0x7275DF8", Offset = "0x7271DF8", VA = "0x7275DF8", Slot = "36")]
		public virtual void m_0081db_009A_008B()
		{
		}

		[Token(Token = "0x600698C")]
		[Address(RVA = "0x7275E40", Offset = "0x7271E40", VA = "0x7275E40", Slot = "37")]
		protected virtual void m_00A3_00A4zJI(float _005B_00BEµ_00B7_0098g)
		{
		}

		[Token(Token = "0x600698D")]
		[Address(RVA = "0x7275ECC", Offset = "0x7271ECC", VA = "0x7275ECC", Slot = "38")]
		protected virtual void P_00BD_009AM_009AI()
		{
		}

		[Token(Token = "0x600698E")]
		[Address(RVA = "0x7276018", Offset = "0x7272018", VA = "0x7276018", Slot = "39")]
		protected virtual void _00A0_008E_0085_00A3Á_00AC(float _005B_00BEµ_00B7_0098g)
		{
		}

		[Token(Token = "0x600698F")]
		[Address(RVA = "0x72760A4", Offset = "0x72720A4", VA = "0x72760A4", Slot = "40")]
		protected virtual void OnTimeScaleEvent(MMTimeScaleMethods _008F_00A5Y_009CL_0088, float J_007CdN_009B_00A3, float µ_008BkB_00B4q, bool E_00A0_00BD_00AD_005Dk, float pg_00BDk_00BC_005D, bool o_009E_007E_00B0_00A7_0060, [Optional][DefaultParameterValue((MMTimeScaleLerpModes)0)] MMTimeScaleLerpModes _0089_0085R_00A2dL, [Optional] AnimationCurve Lgj_009E_0083_0098, [Optional][DefaultParameterValue(0.2f)] float _008DªÁ_00A8_00AB_007B, [Optional][DefaultParameterValue(false)] bool _0085U_005Du_00AFX, [Optional] AnimationCurve r_00A1_00A2_009F_005Ea, float _00BEQ_00AFÀg_00B4 = 0.2f)
		{
		}

		[Token(Token = "0x6006990")]
		[Address(RVA = "0x7276184", Offset = "0x7272184", VA = "0x7276184", Slot = "41")]
		public virtual void _0060_00AE_0060g_0089_00A0()
		{
		}

		[Token(Token = "0x6006991")]
		[Address(RVA = "0x72761CC", Offset = "0x72721CC", VA = "0x72761CC", Slot = "42")]
		public virtual void W_0087_0093eb_0090(float µ_008BkB_00B4q)
		{
		}

		[Token(Token = "0x6006992")]
		[Address(RVA = "0x72761D0", Offset = "0x72721D0", VA = "0x72761D0", Slot = "43")]
		public virtual void Á_0087SIfZ(float w_005EG_00B7Z_0084)
		{
		}

		[Token(Token = "0x6006993")]
		[Address(RVA = "0x7276210", Offset = "0x7272210", VA = "0x7276210", Slot = "44")]
		protected virtual void Initialization()
		{
		}

		[Token(Token = "0x6006994")]
		[Address(RVA = "0x7276254", Offset = "0x7272254", VA = "0x7276254")]
		private float _005ER_00B2_00A0M_008B(float µª_009Ey_00BB_00AE, float _00ACv_009Dk_00B3ª, float _008FS_00BB_0085Y_00B6, float Q_00ADE_0099_008A_00A6, float g_00ACq_00B7_0085_00B1)
		{
			return default;
		}

		[Token(Token = "0x6006995")]
		[Address(RVA = "0x7276270", Offset = "0x7272270", VA = "0x7276270", Slot = "45")]
		protected virtual void qhL_0089_00B3_008D()
		{
		}

		[Token(Token = "0x6006996")]
		[Address(RVA = "0x7276284", Offset = "0x7272284", VA = "0x7276284", Slot = "46")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6006997")]
		[Address(RVA = "0x7276574", Offset = "0x7272574", VA = "0x7276574", Slot = "47")]
		protected virtual void _0090_007DO_0096ym()
		{
		}

		[Token(Token = "0x6006998")]
		[Address(RVA = "0x7276584", Offset = "0x7272584", VA = "0x7276584", Slot = "48")]
		protected virtual void T_0099_0081vªU(float qidVU_00AB)
		{
		}

		[Token(Token = "0x6006999")]
		[Address(RVA = "0x72765F8", Offset = "0x72725F8", VA = "0x72765F8", Slot = "49")]
		public virtual void g_00A8_00BFUKµ()
		{
		}

		[Token(Token = "0x600699A")]
		[Address(RVA = "0x7276640", Offset = "0x7272640", VA = "0x7276640", Slot = "50")]
		protected virtual void _0088_0092j_0099_0060B(float qidVU_00AB)
		{
		}

		[Token(Token = "0x600699B")]
		[Address(RVA = "0x72766B4", Offset = "0x72726B4", VA = "0x72766B4", Slot = "51")]
		public virtual void _00BB_009D_00B3_00A7_007FJ(float µ_008BkB_00B4q)
		{
		}

		[Token(Token = "0x600699C")]
		[Address(RVA = "0x72766B8", Offset = "0x72726B8", VA = "0x72766B8", Slot = "52")]
		protected virtual void Unfreeze()
		{
		}

		[Token(Token = "0x600699D")]
		[Address(RVA = "0x7276808", Offset = "0x7272808", VA = "0x7276808")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600699E")]
		[Address(RVA = "0x72768A8", Offset = "0x72728A8", VA = "0x72768A8")]
		protected new void _0090k_00A1_008A_00BD_007F()
		{
		}

		[Token(Token = "0x600699F")]
		[Address(RVA = "0x72768B8", Offset = "0x72728B8", VA = "0x72768B8", Slot = "53")]
		protected virtual void _00B2G_00B7AE_00AE(float _005B_00BEµ_00B7_0098g)
		{
		}

		[Token(Token = "0x60069A0")]
		[Address(RVA = "0x7276944", Offset = "0x7272944", VA = "0x7276944", Slot = "54")]
		public virtual void SetTimeScaleTo(float w_005EG_00B7Z_0084)
		{
		}

		[Token(Token = "0x60069A1")]
		[Address(RVA = "0x7276978", Offset = "0x7272978", VA = "0x7276978", Slot = "55")]
		protected virtual void r_00A9_007B_00AC_00B1c(float _005B_00BEµ_00B7_0098g)
		{
		}

		[Token(Token = "0x60069A2")]
		[Address(RVA = "0x7276A04", Offset = "0x7272A04", VA = "0x7276A04")]
		protected new void Awake()
		{
		}

		[Token(Token = "0x60069A3")]
		[Address(RVA = "0x7276A14", Offset = "0x7272A14", VA = "0x7276A14", Slot = "56")]
		protected virtual void SetTimeScale(TimeScaleProperties Zº_0060uªj)
		{
		}

		[Token(Token = "0x60069A4")]
		[Address(RVA = "0x7276AE8", Offset = "0x7272AE8", VA = "0x7276AE8", Slot = "57")]
		protected virtual void _00AF_00ABQWh_0060()
		{
		}

		[Token(Token = "0x60069A5")]
		[Address(RVA = "0x7276C38", Offset = "0x7272C38", VA = "0x7276C38", Slot = "58")]
		protected virtual void CO_00A5_0081u_0093(float qidVU_00AB)
		{
		}

		[Token(Token = "0x60069A6")]
		[Address(RVA = "0x7276CAC", Offset = "0x7272CAC", VA = "0x7276CAC", Slot = "59")]
		public virtual void SetFreezeFrame(float µ_008BkB_00B4q)
		{
		}

		[Token(Token = "0x60069A7")]
		[Address(RVA = "0x7276CB0", Offset = "0x7272CB0", VA = "0x7276CB0")]
		private void sPMT_0082K()
		{
		}

		[Token(Token = "0x60069A8")]
		[Address(RVA = "0x7276D50", Offset = "0x7272D50", VA = "0x7276D50")]
		protected static void ÁN_00BD_0080_0090_0096()
		{
		}

		[Token(Token = "0x60069A9")]
		[Address(RVA = "0x7276D98", Offset = "0x7272D98", VA = "0x7276D98", Slot = "60")]
		public virtual void _008De_008A_0088ªc()
		{
		}

		[Token(Token = "0x60069AA")]
		[Address(RVA = "0x7276E0C", Offset = "0x7272E0C", VA = "0x7276E0C", Slot = "61")]
		protected virtual void _0093_008CjwAk()
		{
		}

		[Token(Token = "0x60069AB")]
		[Address(RVA = "0x7276E50", Offset = "0x7272E50", VA = "0x7276E50", Slot = "62")]
		public virtual void ResetTimeScaleToNormalTime()
		{
		}

		[Token(Token = "0x60069AC")]
		[Address(RVA = "0x7276E88", Offset = "0x7272E88", VA = "0x7276E88", Slot = "63")]
		public virtual void _0093_00ADy_0094J_0084(float µ_008BkB_00B4q)
		{
		}

		[Token(Token = "0x60069AD")]
		[Address(RVA = "0x7276E8C", Offset = "0x7272E8C", VA = "0x7276E8C", Slot = "64")]
		public virtual void _00B1M_00A3_008DG_00BC()
		{
		}

		[Token(Token = "0x60069AE")]
		[Address(RVA = "0x7276ED4", Offset = "0x7272ED4", VA = "0x7276ED4", Slot = "65")]
		protected virtual void _00B3_009Cº_008F_0089º()
		{
		}

		[Token(Token = "0x60069AF")]
		[Address(RVA = "0x7276F18", Offset = "0x7272F18", VA = "0x7276F18")]
		private float u_00A8_00B6_009CfU(float µª_009Ey_00BB_00AE, float _00ACv_009Dk_00B3ª, float _008FS_00BB_0085Y_00B6, float Q_00ADE_0099_008A_00A6, float g_00ACq_00B7_0085_00B1)
		{
			return default;
		}

		[Token(Token = "0x60069B0")]
		[Address(RVA = "0x7276F34", Offset = "0x7272F34", VA = "0x7276F34", Slot = "66")]
		protected virtual void _00A8_00A9_00A3_008A_00B6j(float _005B_00BEµ_00B7_0098g)
		{
		}

		[Token(Token = "0x60069B1")]
		[Address(RVA = "0x7276FC0", Offset = "0x7272FC0", VA = "0x7276FC0", Slot = "67")]
		protected virtual void J_0094_005Dr_00B3_00A4()
		{
		}

		[Token(Token = "0x60069B2")]
		[Address(RVA = "0x7277004", Offset = "0x7273004", VA = "0x7277004", Slot = "68")]
		protected virtual void _00BF_0060_005D_00AE_0060_00A6()
		{
		}

		[Token(Token = "0x60069B3")]
		[Address(RVA = "0x7277324", Offset = "0x7273324", VA = "0x7277324")]
		public TimeScaleManager()
		{
		}

		[Token(Token = "0x60069B4")]
		[Address(RVA = "0x7277394", Offset = "0x7273394", VA = "0x7277394", Slot = "69")]
		protected virtual void u_005BgU_0090_0095(TimeScaleProperties Zº_0060uªj)
		{
		}

		[Token(Token = "0x60069B5")]
		[Address(RVA = "0x7277464", Offset = "0x7273464", VA = "0x7277464", Slot = "70")]
		public virtual void PreInitialization()
		{
		}

		[Token(Token = "0x60069B6")]
		[Address(RVA = "0x72774D8", Offset = "0x72734D8", VA = "0x72774D8")]
		private void _00A2x_00BD_0095fE()
		{
		}

		[Token(Token = "0x60069B7")]
		[Address(RVA = "0x7277578", Offset = "0x7273578", VA = "0x7277578", Slot = "71")]
		protected virtual void OnMMFreezeFrameEvent(float µ_008BkB_00B4q)
		{
		}

		[Token(Token = "0x60069B8")]
		[Address(RVA = "0x72775C4", Offset = "0x72735C4", VA = "0x72775C4")]
		private void W_0097_007D_0090_0082_007D()
		{
		}

		[Token(Token = "0x60069B9")]
		[Address(RVA = "0x7277664", Offset = "0x7273664", VA = "0x7277664")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		protected static void InitializeStatics()
		{
		}

		[Token(Token = "0x60069BA")]
		[Address(RVA = "0x72776AC", Offset = "0x72736AC", VA = "0x72776AC", Slot = "72")]
		protected virtual void _007Fh_00A7_009EÀ_007E(MMTimeScaleMethods _008F_00A5Y_009CL_0088, float J_007CdN_009B_00A3, float µ_008BkB_00B4q, bool E_00A0_00BD_00AD_005Dk, float pg_00BDk_00BC_005D, bool o_009E_007E_00B0_00A7_0060, [Optional][DefaultParameterValue((MMTimeScaleLerpModes)0)] MMTimeScaleLerpModes _0089_0085R_00A2dL, [Optional] AnimationCurve Lgj_009E_0083_0098, [Optional][DefaultParameterValue(0.2f)] float _008DªÁ_00A8_00AB_007B, [Optional][DefaultParameterValue(false)] bool _0085U_005Du_00AFX, [Optional] AnimationCurve r_00A1_00A2_009F_005Ea, float _00BEQ_00AFÀg_00B4 = 0.2f)
		{
		}

		[Token(Token = "0x60069BB")]
		[Address(RVA = "0x727778C", Offset = "0x727378C", VA = "0x727778C")]
		private float _00BEP_0080v_00AF_0090(float µª_009Ey_00BB_00AE, float _00ACv_009Dk_00B3ª, float _008FS_00BB_0085Y_00B6, float Q_00ADE_0099_008A_00A6, float g_00ACq_00B7_0085_00B1)
		{
			return default;
		}

		[Token(Token = "0x60069BC")]
		[Address(RVA = "0x72777A8", Offset = "0x72737A8", VA = "0x72777A8", Slot = "73")]
		protected virtual void _00A0x_0098ª_00AEÁ()
		{
		}

		[Token(Token = "0x60069BD")]
		[Address(RVA = "0x72777B8", Offset = "0x72737B8", VA = "0x72777B8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60069BE")]
		[Address(RVA = "0x7277858", Offset = "0x7273858", VA = "0x7277858", Slot = "74")]
		protected virtual void _0099_0081_00B1_009C_00BF_0083(MMTimeScaleMethods _008F_00A5Y_009CL_0088, float J_007CdN_009B_00A3, float µ_008BkB_00B4q, bool E_00A0_00BD_00AD_005Dk, float pg_00BDk_00BC_005D, bool o_009E_007E_00B0_00A7_0060, [Optional][DefaultParameterValue((MMTimeScaleLerpModes)0)] MMTimeScaleLerpModes _0089_0085R_00A2dL, [Optional] AnimationCurve Lgj_009E_0083_0098, [Optional][DefaultParameterValue(0.2f)] float _008DªÁ_00A8_00AB_007B, [Optional][DefaultParameterValue(false)] bool _0085U_005Du_00AFX, [Optional] AnimationCurve r_00A1_00A2_009F_005Ea, float _00BEQ_00AFÀg_00B4 = 0.2f)
		{
		}

		[Token(Token = "0x60069BF")]
		[Address(RVA = "0x7277938", Offset = "0x7273938", VA = "0x7277938", Slot = "75")]
		protected virtual void W_005Dv_0092_00BFJ()
		{
		}
	}
}
