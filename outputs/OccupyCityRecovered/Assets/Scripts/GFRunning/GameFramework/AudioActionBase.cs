using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;

namespace GameFramework
{
	[Token(Token = "0x200030E")]
	public abstract class AudioActionBase
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200030F")]
		private struct PsJKJr : IAsyncStateMachine
		{
			[Token(Token = "0x40018DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40018DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40018DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public AudioActionBase _003C_003E4__this;

			[Token(Token = "0x40018DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private TaskAwaiter<AudioSource> _003C_003Eu__1;

			[Token(Token = "0x6005409")]
			[Address(RVA = "0x71402A8", Offset = "0x713C2A8", VA = "0x71402A8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600540A")]
			[Address(RVA = "0x714055C", Offset = "0x713C55C", VA = "0x714055C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40018D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected int s_UpdateId;

		[Token(Token = "0x40018D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		protected int s_AudioId;

		[Token(Token = "0x40018D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected int s_AudioGuid;

		[Token(Token = "0x40018D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		protected float s_Vol;

		[Token(Token = "0x40018D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected VoiceType s_VoiceType;

		[Token(Token = "0x40018D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected GameObject s_AudioRoot;

		[Token(Token = "0x40018D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AudioData _0093q_005D_00A3_0082_009A;

		[Token(Token = "0x40018D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected AudioSource s_audioSource;

		[Token(Token = "0x40018D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected Action<int> s_StartCall;

		[Token(Token = "0x40018D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected Action<int> s_EndCall;

		[Token(Token = "0x170010BE")]
		public VoiceType S_VoiceType
		{
			[Token(Token = "0x60053EE")]
			[Address(RVA = "0x713FA04", Offset = "0x713BA04", VA = "0x713FA04")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60053EF")]
		[Address(RVA = "0x713FA0C", Offset = "0x713BA0C", VA = "0x713FA0C")]
		protected AudioActionBase(GameObject _00B7_00A8z_00A2X_00BE, int _009DH_0084µ_009C_00B0, Action<int> wj_00AD_00A1_009A_0095, Action<int> Vt_009Aªr_00AF)
		{
		}

		[Token(Token = "0x60053F0")]
		[Address(RVA = "0x713FA70", Offset = "0x713BA70", VA = "0x713FA70")]
		private void _0080r_00B3y_0083J()
		{
		}

		[Token(Token = "0x60053F1")]
		[Address(RVA = "0x713FB0C", Offset = "0x713BB0C", VA = "0x713FB0C")]
		private void h_009By_0097_0060_0094()
		{
		}

		[Token(Token = "0x60053F2")]
		[Address(RVA = "0x713FBAC", Offset = "0x713BBAC", VA = "0x713FBAC")]
		private void _00A8ºg_00B2OH()
		{
		}

		[Token(Token = "0x60053F3")]
		[Address(RVA = "0x713FC44", Offset = "0x713BC44", VA = "0x713FC44")]
		private void O_008A_007B_00A6_0086_00B1(params object[] Tª_0096ºb_0083)
		{
		}

		[Token(Token = "0x60053F4")]
		[Address(RVA = "0x713FD34", Offset = "0x713BD34", VA = "0x713FD34")]
		protected void OnStartCall()
		{
		}

		[Token(Token = "0x60053F5")]
		[Address(RVA = "0x713FD54", Offset = "0x713BD54", VA = "0x713FD54")]
		protected void OnEndCall()
		{
		}

		[Token(Token = "0x60053F6")]
		[Address(RVA = "0x713FD74", Offset = "0x713BD74", VA = "0x713FD74")]
		protected float GetSettingVolume()
		{
			return default;
		}

		[Token(Token = "0x60053F7")]
		[Address(RVA = "0x713FE14", Offset = "0x713BE14", VA = "0x713FE14")]
		private AudioData _00B2_0083_005Bj_00B8Â(int _0086Lji_00A7_00B7)
		{
			return null;
		}

		[Token(Token = "0x60053F8")]
		[Address(RVA = "0x713FF14", Offset = "0x713BF14", VA = "0x713FF14")]
		private void _007EZ_00A7_008E_0095U()
		{
		}

		[Token(Token = "0x60053F9")]
		[Address(RVA = "0x713FF20", Offset = "0x713BF20", VA = "0x713FF20")]
		[AsyncStateMachine(typeof(PsJKJr))]
		public void Play()
		{
		}

		[Token(Token = "0x60053FA")]
		[Address(RVA = "0x713FFB0", Offset = "0x713BFB0", VA = "0x713FFB0")]
		public void Pause(bool lE_005E_00B4_0097E)
		{
		}

		[Token(Token = "0x60053FB")]
		[Address(RVA = "0x7140064", Offset = "0x713C064", VA = "0x7140064")]
		public bool IsPlaying()
		{
			return default;
		}

		[Token(Token = "0x60053FC")]
		[Address(RVA = "0x71400EC", Offset = "0x713C0EC", VA = "0x71400EC")]
		public void Mute(bool Sl_00BC_007F_0095_00BE)
		{
		}

		[Token(Token = "0x60053FD")]
		[Address(RVA = "0x7140184", Offset = "0x713C184", VA = "0x7140184")]
		public void Stop()
		{
		}

		[Token(Token = "0x60053FE")]
		[Address(RVA = "0x7140190", Offset = "0x713C190", VA = "0x7140190")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60053FF")]
		[Address(RVA = "0x71401E4", Offset = "0x713C1E4", VA = "0x71401E4")]
		internal int ª_0092_007F_0081µQ()
		{
			return default;
		}

		[Token(Token = "0x6005400")]
		[Address(RVA = "0x71401EC", Offset = "0x713C1EC", VA = "0x71401EC")]
		public int GetAudioGuid()
		{
			return default;
		}

		[Token(Token = "0x6005401")]
		[Address(RVA = "0x71401F4", Offset = "0x713C1F4", VA = "0x71401F4")]
		public AudioSource GetAudioSource()
		{
			return null;
		}

		[Token(Token = "0x6005402")]
		[Address(RVA = "0x71401FC", Offset = "0x713C1FC", VA = "0x71401FC", Slot = "4")]
		protected virtual void RefreshAudioVolume(VoiceType B_008A_0095h_005D_00AC, float _00A7KOk_008Df)
		{
		}

		[Token(Token = "0x6005403")]
		protected abstract void OnAwake();

		[Token(Token = "0x6005404")]
		protected abstract Task<AudioSource> OnPlay(AudioData _0093q_005D_00A3_0082_009A);

		[Token(Token = "0x6005405")]
		protected abstract void OnPause(bool lE_005E_00B4_0097E);

		[Token(Token = "0x6005406")]
		protected abstract void OnStop();

		[Token(Token = "0x6005407")]
		protected abstract void OnUpdate();

		[Token(Token = "0x6005408")]
		protected abstract void OnDispose();
	}
}
