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
	[Token(Token = "0x2000315")]
	public class AudioLoopFadeAction : AudioActionBase
	{
		[Token(Token = "0x2000316")]
		private sealed class nzz_00B0_008C_0086
		{
			[Token(Token = "0x4001907")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioSource audio;

			[Token(Token = "0x4001908")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Action onFadeEnd;

			[Token(Token = "0x4001909")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool isHigh;

			[Token(Token = "0x400190A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public AudioLoopFadeAction _003C_003E4__this;

			[Token(Token = "0x600546C")]
			[Address(RVA = "0x71449D8", Offset = "0x71409D8", VA = "0x71449D8")]
			public nzz_00B0_008C_0086()
			{
			}

			[Token(Token = "0x600546D")]
			[Address(RVA = "0x7146124", Offset = "0x7142124", VA = "0x7146124")]
			internal void _009Bu_007C_00B0_008Dz(int id)
			{
			}

			[Token(Token = "0x600546E")]
			[Address(RVA = "0x7146250", Offset = "0x7142250", VA = "0x7146250")]
			internal void _0088N_005DtYn(int id, int time)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000317")]
		private struct pZ_00A8_009CA_0086 : IAsyncStateMachine
		{
			[Token(Token = "0x400190B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400190C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<AudioSource> _003C_003Et__builder;

			[Token(Token = "0x400190D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AudioData audioConfig;

			[Token(Token = "0x400190E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public AudioLoopFadeAction _003C_003E4__this;

			[Token(Token = "0x400190F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int _003Cstart_time_003E5__2;

			[Token(Token = "0x4001910")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private AudioMode _003Catype_003E5__3;

			[Token(Token = "0x4001911")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private string _003Cname_003E5__4;

			[Token(Token = "0x4001912")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private TaskAwaiter<AssetOperationHandle> _003C_003Eu__1;

			[Token(Token = "0x4001913")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private TaskAwaiter<AudioClip> _003C_003Eu__2;

			[Token(Token = "0x600546F")]
			[Address(RVA = "0x7146320", Offset = "0x7142320", VA = "0x7146320", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6005470")]
			[Address(RVA = "0x7146960", Offset = "0x7142960", VA = "0x7146960", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40018FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float U_00A0_009C_00A9_009E_0090;

		[Token(Token = "0x4001900")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int sJºcRi;

		[Token(Token = "0x4001901")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float ºk_009El_008Fe;

		[Token(Token = "0x4001902")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private bool _008EK_0092_00B3_00BB_00BF;

		[Token(Token = "0x4001903")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float XsJ_00B6k_008A;

		[Token(Token = "0x4001904")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float Q_00ADp_0082_00B8p;

		[Token(Token = "0x4001905")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int ºM_00A7n_00A6n;

		[Token(Token = "0x4001906")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private AssetOperationHandle _0086_005B_0093_0080Q_005D;

		[Token(Token = "0x6005441")]
		[Address(RVA = "0x714417C", Offset = "0x714017C", VA = "0x714417C")]
		private void _008Al_009FMxB()
		{
		}

		[Token(Token = "0x6005442")]
		[Address(RVA = "0x7144378", Offset = "0x7140378", VA = "0x7144378")]
		private void _0082I_0082_0082_00A1m()
		{
		}

		[Token(Token = "0x6005443")]
		[Address(RVA = "0x7144430", Offset = "0x7140430", VA = "0x7144430")]
		private void _00B1_0094ke_00BB_00BE()
		{
		}

		[Token(Token = "0x6005444")]
		[Address(RVA = "0x71444E8", Offset = "0x71404E8", VA = "0x71444E8")]
		private void Ol_00A3_009B_005Bh()
		{
		}

		[Token(Token = "0x6005445")]
		[Address(RVA = "0x714475C", Offset = "0x714075C", VA = "0x714475C", Slot = "10")]
		protected override void OnDispose()
		{
		}

		[Token(Token = "0x6005446")]
		[Address(RVA = "0x71447F4", Offset = "0x71407F4", VA = "0x71447F4")]
		private void _009F_0090ª_008FÀ_0083(AudioSource G_0096Q_00A6h_0092, bool _0087Rª_00A7_0093_00A7, [Optional] Action WÁ_00B4_0088_00B0_0082)
		{
		}

		[Token(Token = "0x6005447")]
		[Address(RVA = "0x71449E0", Offset = "0x71409E0", VA = "0x71449E0")]
		private void _00B6Á_00BF_008E_0085_0095(AudioSource G_0096Q_00A6h_0092, bool _0087Rª_00A7_0093_00A7, [Optional] Action WÁ_00B4_0088_00B0_0082)
		{
		}

		[Token(Token = "0x6005448")]
		[Address(RVA = "0x7144BC4", Offset = "0x7140BC4", VA = "0x7144BC4")]
		private void bKK_00AC_009CZ()
		{
		}

		[Token(Token = "0x6005449")]
		[Address(RVA = "0x7144C7C", Offset = "0x7140C7C", VA = "0x7144C7C")]
		private void _009AHu_00B9B_00B6()
		{
		}

		[Token(Token = "0x600544A")]
		[Address(RVA = "0x7144D08", Offset = "0x7140D08", VA = "0x7144D08")]
		private void _008B_0097_005EkmI()
		{
		}

		[Token(Token = "0x600544B")]
		[Address(RVA = "0x7144F7C", Offset = "0x7140F7C", VA = "0x7144F7C", Slot = "8")]
		protected override void OnStop()
		{
		}

		[Token(Token = "0x600544C")]
		[Address(RVA = "0x714509C", Offset = "0x714109C", VA = "0x714509C")]
		private void I_0083Â_00A4_0094s()
		{
		}

		[Token(Token = "0x600544D")]
		[Address(RVA = "0x7145150", Offset = "0x7141150", VA = "0x7145150")]
		public AudioLoopFadeAction(GameObject _00B7_00A8z_00A2X_00BE, int _009DH_0084µ_009C_00B0, Action<int> wj_00AD_00A1_009A_0095, Action<int> Vt_009Aªr_00AF) : base(_00B7_00A8z_00A2X_00BE, _009DH_0084µ_009C_00B0, wj_00AD_00A1_009A_0095, Vt_009Aªr_00AF)
		{
			throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED AudioLoopFadeAction..ctor RVA=0x7145150 Token=0x0600544D; original base constructor arguments recovered; remaining original constructor body pending.");
		}

		[Token(Token = "0x600544E")]
		[Address(RVA = "0x714515C", Offset = "0x714115C", VA = "0x714515C")]
		private void _00B2q_008ATT_00B8()
		{
		}

		[Token(Token = "0x600544F")]
		[Address(RVA = "0x7145358", Offset = "0x7141358", VA = "0x7145358")]
		private void kUWµg_0089()
		{
		}

		[Token(Token = "0x6005450")]
		[Address(RVA = "0x71453E8", Offset = "0x71413E8", VA = "0x71453E8", Slot = "7")]
		protected override void OnPause(bool lE_005E_00B4_0097E)
		{
		}

		[Token(Token = "0x6005451")]
		[Address(RVA = "0x71453EC", Offset = "0x71413EC", VA = "0x71453EC")]
		private void gTO_00A5y_0082()
		{
		}

		[Token(Token = "0x6005452")]
		[Address(RVA = "0x7145400", Offset = "0x7141400", VA = "0x7145400")]
		private void _007DD_00BF_00B8_00A6º()
		{
		}

		[Token(Token = "0x6005453")]
		[Address(RVA = "0x7144194", Offset = "0x7140194", VA = "0x7144194")]
		private void EOÀ_00ADy_00BD(AudioSource G_0096Q_00A6h_0092, bool _0087Rª_00A7_0093_00A7, [Optional] Action WÁ_00B4_0088_00B0_0082)
		{
		}

		[Token(Token = "0x6005454")]
		[Address(RVA = "0x7145418", Offset = "0x7141418", VA = "0x7145418")]
		private void µXMsPA()
		{
		}

		[Token(Token = "0x6005455")]
		[Address(RVA = "0x71454A8", Offset = "0x71414A8", VA = "0x71454A8")]
		private void K_0085_00AD_009F_00B7M()
		{
		}

		[Token(Token = "0x6005456")]
		[Address(RVA = "0x7145560", Offset = "0x7141560", VA = "0x7145560", Slot = "4")]
		protected override void RefreshAudioVolume(VoiceType B_008A_0095h_005D_00AC, float _00A7KOk_008Df)
		{
		}

		[Token(Token = "0x6005457")]
		[Address(RVA = "0x714557C", Offset = "0x714157C", VA = "0x714557C")]
		[CompilerGenerated]
		private void _008Dj_0097Sn_00B0()
		{
		}

		[Token(Token = "0x6005458")]
		[Address(RVA = "0x7144578", Offset = "0x7140578", VA = "0x7144578")]
		private void Z_008Exs_005D_00B3(AudioSource G_0096Q_00A6h_0092, bool _0087Rª_00A7_0093_00A7, [Optional] Action WÁ_00B4_0088_00B0_0082)
		{
		}

		[Token(Token = "0x6005459")]
		[Address(RVA = "0x7145590", Offset = "0x7141590", VA = "0x7145590")]
		private void h_009E_00BD_009Eo_0092()
		{
		}

		[Token(Token = "0x600545A")]
		[Address(RVA = "0x7145800", Offset = "0x7141800", VA = "0x7145800")]
		private void UHªAeo()
		{
		}

		[Token(Token = "0x600545B")]
		[Address(RVA = "0x71458B8", Offset = "0x71418B8", VA = "0x71458B8")]
		private void vvU_005Euo()
		{
		}

		[Token(Token = "0x600545C")]
		[Address(RVA = "0x7145944", Offset = "0x7141944", VA = "0x7145944")]
		private void mnÁv_0089_008F(AudioSource G_0096Q_00A6h_0092, bool _0087Rª_00A7_0093_00A7, [Optional] Action WÁ_00B4_0088_00B0_0082)
		{
		}

		[Token(Token = "0x600545D")]
		[Address(RVA = "0x7145B28", Offset = "0x7141B28", VA = "0x7145B28")]
		private void _009Ei_005EBW_0060()
		{
		}

		[Token(Token = "0x600545E")]
		[Address(RVA = "0x7144D98", Offset = "0x7140D98", VA = "0x7144D98")]
		private void _0080_00A2N_00A5J_00A4(AudioSource G_0096Q_00A6h_0092, bool _0087Rª_00A7_0093_00A7, [Optional] Action WÁ_00B4_0088_00B0_0082)
		{
		}

		[Token(Token = "0x600545F")]
		[Address(RVA = "0x7145174", Offset = "0x7141174", VA = "0x7145174")]
		private void gf_00BB_0098_00A5_0088(AudioSource G_0096Q_00A6h_0092, bool _0087Rª_00A7_0093_00A7, [Optional] Action WÁ_00B4_0088_00B0_0082)
		{
		}

		[Token(Token = "0x6005460")]
		[Address(RVA = "0x7145BB4", Offset = "0x7141BB4", VA = "0x7145BB4", Slot = "9")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6005461")]
		[Address(RVA = "0x7145CB8", Offset = "0x7141CB8", VA = "0x7145CB8")]
		private void L_00BFªe_005Dq()
		{
		}

		[Token(Token = "0x6005462")]
		[Address(RVA = "0x7145CCC", Offset = "0x7141CCC", VA = "0x7145CCC", Slot = "6")]
		[AsyncStateMachine(typeof(pZ_00A8_009CA_0086))]
		protected override Task<AudioSource> OnPlay(AudioData _0093q_005D_00A3_0082_009A)
		{
			return null;
		}

		[Token(Token = "0x6005463")]
		[Address(RVA = "0x7145DB8", Offset = "0x7141DB8", VA = "0x7145DB8")]
		private void _0090_00B8_008C_009E_0097w()
		{
		}

		[Token(Token = "0x6005464")]
		[Address(RVA = "0x7145DCC", Offset = "0x7141DCC", VA = "0x7145DCC", Slot = "5")]
		protected override void OnAwake()
		{
		}

		[Token(Token = "0x6005465")]
		[Address(RVA = "0x7145DD0", Offset = "0x7141DD0", VA = "0x7145DD0")]
		private void H_00AF_00ACP_0096L()
		{
		}

		[Token(Token = "0x6005466")]
		[Address(RVA = "0x7145E60", Offset = "0x7141E60", VA = "0x7145E60")]
		private void r_005E_00B9eF_00A7()
		{
		}

		[Token(Token = "0x6005467")]
		[Address(RVA = "0x7145E78", Offset = "0x7141E78", VA = "0x7145E78")]
		private void _0098_007E_009Emº_009B()
		{
		}

		[Token(Token = "0x6005468")]
		[Address(RVA = "0x7145F2C", Offset = "0x7141F2C", VA = "0x7145F2C")]
		private void _008F_00A6X_00BB_00BCT()
		{
		}

		[Token(Token = "0x6005469")]
		[Address(RVA = "0x7145FBC", Offset = "0x7141FBC", VA = "0x7145FBC")]
		[CompilerGenerated]
		private void K_0087u_00B9oP()
		{
		}

		[Token(Token = "0x600546A")]
		[Address(RVA = "0x7146070", Offset = "0x7142070", VA = "0x7146070")]
		private void ZQ_0060À_0097p()
		{
		}

		[Token(Token = "0x600546B")]
		[Address(RVA = "0x714561C", Offset = "0x714161C", VA = "0x714561C")]
		private void da_009D_00A2_009D_005E(AudioSource G_0096Q_00A6h_0092, bool _0087Rª_00A7_0093_00A7, [Optional] Action WÁ_00B4_0088_00B0_0082)
		{
		}
	}
}
