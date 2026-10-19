using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;
using YooAsset;

namespace GameFramework
{
	[Token(Token = "0x2000310")]
	public class AudioFadeAction : AudioActionBase
	{
		[Token(Token = "0x2000311")]
		private sealed class H_00BD_0060N_00AC_00B3
		{
			[Token(Token = "0x40018E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioSource audio;

			[Token(Token = "0x40018E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Action onFadeEnd;

			[Token(Token = "0x40018E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool isHigh;

			[Token(Token = "0x40018E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public AudioFadeAction _003C_003E4__this;

			[Token(Token = "0x6005433")]
			[Address(RVA = "0x7140BBC", Offset = "0x713CBBC", VA = "0x7140BBC")]
			public H_00BD_0060N_00AC_00B3()
			{
			}

			[Token(Token = "0x6005434")]
			[Address(RVA = "0x7143098", Offset = "0x713F098", VA = "0x7143098")]
			internal void _009Bu_007C_00B0_008Dz(int id)
			{
			}

			[Token(Token = "0x6005435")]
			[Address(RVA = "0x71431C4", Offset = "0x713F1C4", VA = "0x71431C4")]
			internal void _0088N_005DtYn(int id, int time)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000312")]
		private struct _00A2ÁhSBb : IAsyncStateMachine
		{
			[Token(Token = "0x40018EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40018EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<AudioSource> _003C_003Et__builder;

			[Token(Token = "0x40018EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AudioData audioConfig;

			[Token(Token = "0x40018ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public AudioFadeAction _003C_003E4__this;

			[Token(Token = "0x40018EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int _003Cstart_time_003E5__2;

			[Token(Token = "0x40018EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private AudioMode _003Catype_003E5__3;

			[Token(Token = "0x40018F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private string _003Cname_003E5__4;

			[Token(Token = "0x40018F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private TaskAwaiter<AssetOperationHandle> _003C_003Eu__1;

			[Token(Token = "0x40018F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private TaskAwaiter<AudioClip> _003C_003Eu__2;

			[Token(Token = "0x6005436")]
			[Address(RVA = "0x7143294", Offset = "0x713F294", VA = "0x7143294", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6005437")]
			[Address(RVA = "0x71438D4", Offset = "0x713F8D4", VA = "0x71438D4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40018DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float U_00A0_009C_00A9_009E_0090;

		[Token(Token = "0x40018DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int sJºcRi;

		[Token(Token = "0x40018E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float ºk_009El_008Fe;

		[Token(Token = "0x40018E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private bool _008EK_0092_00B3_00BB_00BF;

		[Token(Token = "0x40018E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float XsJ_00B6k_008A;

		[Token(Token = "0x40018E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float Q_00ADp_0082_00B8p;

		[Token(Token = "0x40018E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int ºM_00A7n_00A6n;

		[Token(Token = "0x40018E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private AssetOperationHandle _0086_005B_0093_0080Q_005D;

		[Token(Token = "0x600540B")]
		[Address(RVA = "0x7140568", Offset = "0x713C568", VA = "0x7140568")]
		private void zl_00A2_0086B_0085()
		{
		}

		[Token(Token = "0x600540C")]
		[Address(RVA = "0x7140620", Offset = "0x713C620", VA = "0x7140620", Slot = "8")]
		protected override void OnStop()
		{
		}

		[Token(Token = "0x600540D")]
		[Address(RVA = "0x7140924", Offset = "0x713C924", VA = "0x7140924")]
		private void _009CX_00A5_00A2C_0092()
		{
		}

		[Token(Token = "0x600540E")]
		[Address(RVA = "0x71409D8", Offset = "0x713C9D8", VA = "0x71409D8")]
		private void f_00B0_0086_0081_0091_0089(AudioSource G_0096Q_00A6h_0092, bool _0087Rª_00A7_0093_00A7, [Optional] Action WÁ_00B4_0088_00B0_0082)
		{
		}

		[Token(Token = "0x600540F")]
		[Address(RVA = "0x7140BC4", Offset = "0x713CBC4", VA = "0x7140BC4")]
		public AudioFadeAction(GameObject _00B7_00A8z_00A2X_00BE, int _009DH_0084µ_009C_00B0, Action<int> wj_00AD_00A1_009A_0095, Action<int> Vt_009Aªr_00AF) : base(_00B7_00A8z_00A2X_00BE, _009DH_0084µ_009C_00B0, wj_00AD_00A1_009A_0095, Vt_009Aªr_00AF)
		{
			throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED AudioFadeAction..ctor RVA=0x7140BC4 Token=0x0600540F; original base constructor arguments recovered; remaining original constructor body pending.");
		}

		[Token(Token = "0x6005410")]
		[Address(RVA = "0x7140BD0", Offset = "0x713CBD0", VA = "0x7140BD0")]
		private void _0089_0093_009B_00BB_00B4k()
		{
		}

		[Token(Token = "0x6005411")]
		[Address(RVA = "0x7140C88", Offset = "0x713CC88", VA = "0x7140C88")]
		private void _00BDqA_0098ig(AudioSource G_0096Q_00A6h_0092, bool _0087Rª_00A7_0093_00A7, [Optional] Action WÁ_00B4_0088_00B0_0082)
		{
		}

		[Token(Token = "0x6005412")]
		[Address(RVA = "0x7140E6C", Offset = "0x713CE6C", VA = "0x7140E6C")]
		private void da_009D_00A2_009D_005E(AudioSource G_0096Q_00A6h_0092, bool _0087Rª_00A7_0093_00A7, [Optional] Action WÁ_00B4_0088_00B0_0082)
		{
		}

		[Token(Token = "0x6005413")]
		[Address(RVA = "0x7141050", Offset = "0x713D050", VA = "0x7141050")]
		private void bKK_00AC_009CZ()
		{
		}

		[Token(Token = "0x6005414")]
		[Address(RVA = "0x7141104", Offset = "0x713D104", VA = "0x7141104")]
		private void _0082I_0082_0082_00A1m()
		{
		}

		[Token(Token = "0x6005415")]
		[Address(RVA = "0x71411B8", Offset = "0x713D1B8", VA = "0x71411B8", Slot = "5")]
		protected override void OnAwake()
		{
		}

		[Token(Token = "0x6005416")]
		[Address(RVA = "0x71411BC", Offset = "0x713D1BC", VA = "0x71411BC")]
		[CompilerGenerated]
		private void K_0087u_00B9oP()
		{
		}

		[Token(Token = "0x6005417")]
		[Address(RVA = "0x7141270", Offset = "0x713D270", VA = "0x7141270")]
		private void _007EXHNbq(AudioSource G_0096Q_00A6h_0092, bool _0087Rª_00A7_0093_00A7, [Optional] Action WÁ_00B4_0088_00B0_0082)
		{
		}

		[Token(Token = "0x6005418")]
		[Address(RVA = "0x7141454", Offset = "0x713D454", VA = "0x7141454")]
		private void _0092Kt_0089y_00B8(AudioSource G_0096Q_00A6h_0092, bool _0087Rª_00A7_0093_00A7, [Optional] Action WÁ_00B4_0088_00B0_0082)
		{
		}

		[Token(Token = "0x6005419")]
		[Address(RVA = "0x7141638", Offset = "0x713D638", VA = "0x7141638")]
		private void gf_00BB_0098_00A5_0088(AudioSource G_0096Q_00A6h_0092, bool _0087Rª_00A7_0093_00A7, [Optional] Action WÁ_00B4_0088_00B0_0082)
		{
		}

		[Token(Token = "0x600541A")]
		[Address(RVA = "0x714181C", Offset = "0x713D81C", VA = "0x714181C", Slot = "6")]
		[AsyncStateMachine(typeof(_00A2ÁhSBb))]
		protected override Task<AudioSource> OnPlay(AudioData _0093q_005D_00A3_0082_009A)
		{
			return null;
		}

		[Token(Token = "0x600541B")]
		[Address(RVA = "0x7141908", Offset = "0x713D908", VA = "0x7141908")]
		private void _008DG_0094_0093h_007F()
		{
		}

		[Token(Token = "0x600541C")]
		[Address(RVA = "0x71419C0", Offset = "0x713D9C0", VA = "0x71419C0", Slot = "9")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600541D")]
		[Address(RVA = "0x7141ACC", Offset = "0x713DACC", VA = "0x7141ACC")]
		private void K_0085_00AD_009F_00B7M()
		{
		}

		[Token(Token = "0x600541E")]
		[Address(RVA = "0x7141B80", Offset = "0x713DB80", VA = "0x7141B80")]
		private void _0099gJm_0095x()
		{
		}

		[Token(Token = "0x600541F")]
		[Address(RVA = "0x7141C34", Offset = "0x713DC34", VA = "0x7141C34")]
		private void _0087h_005B_00BB_00B7_009C(AudioSource G_0096Q_00A6h_0092, bool _0087Rª_00A7_0093_00A7, [Optional] Action WÁ_00B4_0088_00B0_0082)
		{
		}

		[Token(Token = "0x6005420")]
		[Address(RVA = "0x7141E18", Offset = "0x713DE18", VA = "0x7141E18")]
		private void _0080_00A8_00AD_00A5_00AF_0097(AudioSource G_0096Q_00A6h_0092, bool _0087Rª_00A7_0093_00A7, [Optional] Action WÁ_00B4_0088_00B0_0082)
		{
		}

		[Token(Token = "0x6005421")]
		[Address(RVA = "0x7141FFC", Offset = "0x713DFFC", VA = "0x7141FFC")]
		private void gK_009EmYg()
		{
		}

		[Token(Token = "0x6005422")]
		[Address(RVA = "0x71420B0", Offset = "0x713E0B0", VA = "0x71420B0")]
		private void _007F_00B6_00A1µ_0094u()
		{
		}

		[Token(Token = "0x6005423")]
		[Address(RVA = "0x7142168", Offset = "0x713E168", VA = "0x7142168")]
		private void _0096_00BBBd_0084T(AudioSource G_0096Q_00A6h_0092, bool _0087Rª_00A7_0093_00A7, [Optional] Action WÁ_00B4_0088_00B0_0082)
		{
		}

		[Token(Token = "0x6005424")]
		[Address(RVA = "0x714234C", Offset = "0x713E34C", VA = "0x714234C")]
		private void _00B1XÁ_00B9D_00AE()
		{
		}

		[Token(Token = "0x6005425")]
		[Address(RVA = "0x7142404", Offset = "0x713E404", VA = "0x7142404")]
		private void _0086g_00AF_00A4O_0083()
		{
		}

		[Token(Token = "0x6005426")]
		[Address(RVA = "0x71424BC", Offset = "0x713E4BC", VA = "0x71424BC")]
		private void _005EeXcZ_007E(AudioSource G_0096Q_00A6h_0092, bool _0087Rª_00A7_0093_00A7, [Optional] Action WÁ_00B4_0088_00B0_0082)
		{
		}

		[Token(Token = "0x6005427")]
		[Address(RVA = "0x71426A0", Offset = "0x713E6A0", VA = "0x71426A0")]
		private void _00B7_0085rÂ_0096C()
		{
		}

		[Token(Token = "0x6005428")]
		[Address(RVA = "0x7142754", Offset = "0x713E754", VA = "0x7142754")]
		private void Z_008Exs_005D_00B3(AudioSource G_0096Q_00A6h_0092, bool _0087Rª_00A7_0093_00A7, [Optional] Action WÁ_00B4_0088_00B0_0082)
		{
		}

		[Token(Token = "0x6005429")]
		[Address(RVA = "0x7142938", Offset = "0x713E938", VA = "0x7142938")]
		private void E_0084fM_0089I(AudioSource G_0096Q_00A6h_0092, bool _0087Rª_00A7_0093_00A7, [Optional] Action WÁ_00B4_0088_00B0_0082)
		{
		}

		[Token(Token = "0x600542A")]
		[Address(RVA = "0x7142B1C", Offset = "0x713EB1C", VA = "0x7142B1C", Slot = "7")]
		protected override void OnPause(bool lE_005E_00B4_0097E)
		{
		}

		[Token(Token = "0x600542B")]
		[Address(RVA = "0x7140740", Offset = "0x713C740", VA = "0x7140740")]
		private void _0080_00A2N_00A5J_00A4(AudioSource G_0096Q_00A6h_0092, bool _0087Rª_00A7_0093_00A7, [Optional] Action WÁ_00B4_0088_00B0_0082)
		{
		}

		[Token(Token = "0x600542C")]
		[Address(RVA = "0x7142B20", Offset = "0x713EB20", VA = "0x7142B20")]
		private void _00B6_008E_0082_007C_0088h()
		{
		}

		[Token(Token = "0x600542D")]
		[Address(RVA = "0x7142BD8", Offset = "0x713EBD8", VA = "0x7142BD8")]
		private void _00B1_0094ke_00BB_00BE()
		{
		}

		[Token(Token = "0x600542E")]
		[Address(RVA = "0x7142C90", Offset = "0x713EC90", VA = "0x7142C90")]
		private void _0086_00B3µ_00ADo_00A9()
		{
		}

		[Token(Token = "0x600542F")]
		[Address(RVA = "0x7142D48", Offset = "0x713ED48", VA = "0x7142D48")]
		private void _005D_009E_007F_008BX_0097()
		{
		}

		[Token(Token = "0x6005430")]
		[Address(RVA = "0x7142E00", Offset = "0x713EE00", VA = "0x7142E00")]
		private void _00B9_009F_00B1G_00A5P(AudioSource G_0096Q_00A6h_0092, bool _0087Rª_00A7_0093_00A7, [Optional] Action WÁ_00B4_0088_00B0_0082)
		{
		}

		[Token(Token = "0x6005431")]
		[Address(RVA = "0x7142FE4", Offset = "0x713EFE4", VA = "0x7142FE4", Slot = "4")]
		protected override void RefreshAudioVolume(VoiceType B_008A_0095h_005D_00AC, float _00A7KOk_008Df)
		{
		}

		[Token(Token = "0x6005432")]
		[Address(RVA = "0x7143000", Offset = "0x713F000", VA = "0x7143000", Slot = "10")]
		protected override void OnDispose()
		{
		}
	}
}
