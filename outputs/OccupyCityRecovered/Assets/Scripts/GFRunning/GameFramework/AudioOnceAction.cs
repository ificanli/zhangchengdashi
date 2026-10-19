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
	[Token(Token = "0x2000318")]
	public class AudioOnceAction : AudioActionBase
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000319")]
		private struct M_00B1J_0099_00A8v : IAsyncStateMachine
		{
			[Token(Token = "0x400191B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400191C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<AudioSource> _003C_003Et__builder;

			[Token(Token = "0x400191D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AudioData audioConfig;

			[Token(Token = "0x400191E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public AudioOnceAction _003C_003E4__this;

			[Token(Token = "0x400191F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private string _003Cpath_003E5__2;

			[Token(Token = "0x4001920")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int _003Cstart_time_003E5__3;

			[Token(Token = "0x4001921")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private AudioMode _003Catype_003E5__4;

			[Token(Token = "0x4001922")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private string _003Cname_003E5__5;

			[Token(Token = "0x4001923")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private string _003CfilePath_003E5__6;

			[Token(Token = "0x4001924")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private float _003ConceVolume_003E5__7;

			[Token(Token = "0x4001925")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private bool _003CtryUseAndroidSdk_003E5__8;

			[Token(Token = "0x4001926")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private TaskAwaiter<AssetOperationHandle> _003C_003Eu__1;

			[Token(Token = "0x4001927")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private TaskAwaiter<AudioClip> _003C_003Eu__2;

			[Token(Token = "0x6005479")]
			[Address(RVA = "0x7146D70", Offset = "0x7142D70", VA = "0x7146D70", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600547A")]
			[Address(RVA = "0x7147B4C", Offset = "0x7143B4C", VA = "0x7147B4C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4001914")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float XsJ_00B6k_008A;

		[Token(Token = "0x4001915")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float Q_00ADp_0082_00B8p;

		[Token(Token = "0x4001916")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool _00A3YLHD_0083;

		[Token(Token = "0x4001917")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int _00AEººLV_0092;

		[Token(Token = "0x4001918")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float ns_00B7_00B3µx;

		[Token(Token = "0x4001919")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float _008D_008FZAp_00B3;

		[Token(Token = "0x400191A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private AssetOperationHandle _0086_005B_0093_0080Q_005D;

		[Token(Token = "0x6005471")]
		[Address(RVA = "0x71469DC", Offset = "0x71429DC", VA = "0x71469DC", Slot = "6")]
		[AsyncStateMachine(typeof(M_00B1J_0099_00A8v))]
		protected override Task<AudioSource> OnPlay(AudioData _0093q_005D_00A3_0082_009A)
		{
			return null;
		}

		[Token(Token = "0x6005472")]
		[Address(RVA = "0x7146ACC", Offset = "0x7142ACC", VA = "0x7146ACC", Slot = "5")]
		protected override void OnAwake()
		{
		}

		[Token(Token = "0x6005473")]
		[Address(RVA = "0x7146AD0", Offset = "0x7142AD0", VA = "0x7146AD0", Slot = "9")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6005474")]
		[Address(RVA = "0x7146BB8", Offset = "0x7142BB8", VA = "0x7146BB8", Slot = "7")]
		protected override void OnPause(bool lE_005E_00B4_0097E)
		{
		}

		[Token(Token = "0x6005475")]
		[Address(RVA = "0x7146BC4", Offset = "0x7142BC4", VA = "0x7146BC4", Slot = "8")]
		protected override void OnStop()
		{
		}

		[Token(Token = "0x6005476")]
		[Address(RVA = "0x7146CB0", Offset = "0x7142CB0", VA = "0x7146CB0", Slot = "10")]
		protected override void OnDispose()
		{
		}

		[Token(Token = "0x6005477")]
		[Address(RVA = "0x7146CD0", Offset = "0x7142CD0", VA = "0x7146CD0")]
		public AudioOnceAction(GameObject _00B7_00A8z_00A2X_00BE, int _009DH_0084µ_009C_00B0, Action<int> wj_00AD_00A1_009A_0095, Action<int> Vt_009Aªr_00AF) : base(_00B7_00A8z_00A2X_00BE, _009DH_0084µ_009C_00B0, wj_00AD_00A1_009A_0095, Vt_009Aªr_00AF)
		{
			throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED AudioOnceAction..ctor RVA=0x7146CD0 Token=0x06005477; original base constructor arguments recovered; remaining original constructor body pending.");
		}

		[Token(Token = "0x6005478")]
		[Address(RVA = "0x7146CDC", Offset = "0x7142CDC", VA = "0x7146CDC", Slot = "4")]
		protected override void RefreshAudioVolume(VoiceType B_008A_0095h_005D_00AC, float _00A7KOk_008Df)
		{
		}
	}
}
