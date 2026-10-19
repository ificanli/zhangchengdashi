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
	[Token(Token = "0x2000313")]
	public class AudioLoopAction : AudioActionBase
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000314")]
		private struct ºAQ_0083_00A8l : IAsyncStateMachine
		{
			[Token(Token = "0x40018F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40018F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<AudioSource> _003C_003Et__builder;

			[Token(Token = "0x40018F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AudioData audioConfig;

			[Token(Token = "0x40018F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public AudioLoopAction _003C_003E4__this;

			[Token(Token = "0x40018F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int _003Cstart_time_003E5__2;

			[Token(Token = "0x40018F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private AudioMode _003Catype_003E5__3;

			[Token(Token = "0x40018FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float _003Cvol_003E5__4;

			[Token(Token = "0x40018FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float _003Cvol_mul_003E5__5;

			[Token(Token = "0x40018FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private string _003Cname_003E5__6;

			[Token(Token = "0x40018FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private TaskAwaiter<AssetOperationHandle> _003C_003Eu__1;

			[Token(Token = "0x40018FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private TaskAwaiter<AudioClip> _003C_003Eu__2;

			[Token(Token = "0x600543F")]
			[Address(RVA = "0x7143B1C", Offset = "0x713FB1C", VA = "0x7143B1C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6005440")]
			[Address(RVA = "0x7144100", Offset = "0x7140100", VA = "0x7144100", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40018F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private AssetOperationHandle _0086_005B_0093_0080Q_005D;

		[Token(Token = "0x6005438")]
		[Address(RVA = "0x7143950", Offset = "0x713F950", VA = "0x7143950", Slot = "6")]
		[AsyncStateMachine(typeof(ºAQ_0083_00A8l))]
		protected override Task<AudioSource> OnPlay(AudioData _0093q_005D_00A3_0082_009A)
		{
			return null;
		}

		[Token(Token = "0x6005439")]
		[Address(RVA = "0x7143A40", Offset = "0x713FA40", VA = "0x7143A40", Slot = "8")]
		protected override void OnStop()
		{
		}

		[Token(Token = "0x600543A")]
		[Address(RVA = "0x7143AEC", Offset = "0x713FAEC", VA = "0x7143AEC")]
		public AudioLoopAction(GameObject _00B7_00A8z_00A2X_00BE, int _009DH_0084µ_009C_00B0, Action<int> wj_00AD_00A1_009A_0095, Action<int> Vt_009Aªr_00AF) : base(_00B7_00A8z_00A2X_00BE, _009DH_0084µ_009C_00B0, wj_00AD_00A1_009A_0095, Vt_009Aªr_00AF)
		{
		}

		[Token(Token = "0x600543B")]
		[Address(RVA = "0x7143AF0", Offset = "0x713FAF0", VA = "0x7143AF0", Slot = "5")]
		protected override void OnAwake()
		{
		}

		[Token(Token = "0x600543C")]
		[Address(RVA = "0x7143AF4", Offset = "0x713FAF4", VA = "0x7143AF4", Slot = "9")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600543D")]
		[Address(RVA = "0x7143AF8", Offset = "0x713FAF8", VA = "0x7143AF8", Slot = "10")]
		protected override void OnDispose()
		{
		}

		[Token(Token = "0x600543E")]
		[Address(RVA = "0x7143B18", Offset = "0x713FB18", VA = "0x7143B18", Slot = "7")]
		protected override void OnPause(bool lE_005E_00B4_0097E)
		{
		}
	}
}
