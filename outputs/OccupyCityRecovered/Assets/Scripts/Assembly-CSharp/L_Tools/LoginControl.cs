using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CommonGameModule.Login;
using Il2CppDummyDll;

namespace L_Tools
{
	[Token(Token = "0x2000F89")]
	public class LoginControl : LoginProcedureBase
	{
		[Token(Token = "0x2000F8B")]
		[CompilerGenerated]
		private sealed class _003CCheckServerConnectionFinish_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4006AF6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4006AF7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4006AF8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public LoginControl _003C_003E4__this;

			[Token(Token = "0x4006AF9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int _003CcheckCount_003E5__2;

			[Token(Token = "0x17000F98")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6005D47")]
				[Address(RVA = "0x43B84D4", Offset = "0x43B44D4", VA = "0x43B84D4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000F99")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6005D49")]
				[Address(RVA = "0x43B8514", Offset = "0x43B4514", VA = "0x43B8514", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6005D44")]
			[Address(RVA = "0x43B7458", Offset = "0x43B3458", VA = "0x43B7458")]
			[DebuggerHidden]
			public _003CCheckServerConnectionFinish_003Ed__11(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6005D45")]
			[Address(RVA = "0x43B8288", Offset = "0x43B4288", VA = "0x43B8288", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6005D46")]
			[Address(RVA = "0x43B828C", Offset = "0x43B428C", VA = "0x43B828C", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6005D47")]
			[Address(RVA = "0x43B84D4", Offset = "0x43B44D4", VA = "0x43B84D4", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6005D48")]
			[Address(RVA = "0x43B84DC", Offset = "0x43B44DC", VA = "0x43B84DC", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6005D49")]
			[Address(RVA = "0x43B8514", Offset = "0x43B4514", VA = "0x43B8514", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000F8C")]
		[CompilerGenerated]
		private struct _003CSwitchLogin_003Ed__12 : IAsyncStateMachine
		{
			[Token(Token = "0x4006AFA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4006AFB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4006AFC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public LoginControl _003C_003E4__this;

			[Token(Token = "0x4006AFD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action<bool> loginCallBack;

			[Token(Token = "0x4006AFE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private object _003C_003Eu__1;

			[Token(Token = "0x6005D4A")]
			[Address(RVA = "0x43B851C", Offset = "0x43B451C", VA = "0x43B851C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6005D4B")]
			[Address(RVA = "0x43B8788", Offset = "0x43B4788", VA = "0x43B8788", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4006AEC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static LoginControl I;

		[Token(Token = "0x4006AED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool NeedCheckSyncOutTime;

		[Token(Token = "0x4006AEE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
		private bool canConnectServer;

		[Token(Token = "0x4006AEF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x72")]
		private bool ForceLogin;

		[Token(Token = "0x4006AF0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public LoginState Curloginstate;

		[Token(Token = "0x4006AF1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public string lastLoginUID;

		[Token(Token = "0x4006AF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Action<bool> loginCallBack;

		[Token(Token = "0x4006AF3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Action<int> OnLoginVaild;

		[Token(Token = "0x6005D2E")]
		[Address(RVA = "0x43B6E30", Offset = "0x43B2E30", VA = "0x43B6E30")]
		public LoginControl(Action<int> onLoginVaild)
		{
		}

		[Token(Token = "0x6005D2F")]
		[Address(RVA = "0x43B6F00", Offset = "0x43B2F00", VA = "0x43B6F00")]
		public void Init()
		{
		}

		[Token(Token = "0x6005D30")]
		[Address(RVA = "0x43B70EC", Offset = "0x43B30EC", VA = "0x43B70EC")]
		public void Login(Action<bool> loginCallBack, bool forceLogin = false)
		{
		}

		[Token(Token = "0x6005D31")]
		[Address(RVA = "0x43B73F8", Offset = "0x43B33F8", VA = "0x43B73F8")]
		[IteratorStateMachine(typeof(_003CCheckServerConnectionFinish_003Ed__11))]
		private IEnumerator CheckServerConnectionFinish()
		{
			return null;
		}

		[Token(Token = "0x6005D32")]
		[Address(RVA = "0x43B7480", Offset = "0x43B3480", VA = "0x43B7480")]
		[AsyncStateMachine(typeof(_003CSwitchLogin_003Ed__12))]
		public void SwitchLogin(Action<bool> loginCallBack)
		{
		}

		[Token(Token = "0x6005D33")]
		[Address(RVA = "0x43B7518", Offset = "0x43B3518", VA = "0x43B7518", Slot = "22")]
		public override void LoginSuccess()
		{
		}

		[Token(Token = "0x6005D34")]
		[Address(RVA = "0x43B7824", Offset = "0x43B3824", VA = "0x43B7824", Slot = "14")]
		public override void LoginFail(LoginFailCode loginFailCode, string message)
		{
		}

		[Token(Token = "0x6005D35")]
		[Address(RVA = "0x43B79BC", Offset = "0x43B39BC", VA = "0x43B79BC", Slot = "7")]
		public override void LoginInvalid(int ErrorCode)
		{
		}

		[Token(Token = "0x6005D36")]
		[Address(RVA = "0x43B7320", Offset = "0x43B3320", VA = "0x43B7320")]
		public void ClearLastLoginInfo()
		{
		}

		[Token(Token = "0x6005D37")]
		[Address(RVA = "0x43B75FC", Offset = "0x43B35FC", VA = "0x43B75FC")]
		public void OnFinishLogin(bool success)
		{
		}

		[Token(Token = "0x6005D38")]
		[Address(RVA = "0x43B7B3C", Offset = "0x43B3B3C", VA = "0x43B7B3C", Slot = "18")]
		public override void ShowBindConfirmTips()
		{
		}

		[Token(Token = "0x6005D39")]
		[Address(RVA = "0x43B7D14", Offset = "0x43B3D14", VA = "0x43B7D14", Slot = "19")]
		public override void ShowOldUserBindConfirmTips()
		{
		}

		[Token(Token = "0x6005D3A")]
		[Address(RVA = "0x43B7D1C", Offset = "0x43B3D1C", VA = "0x43B7D1C", Slot = "16")]
		public override void SuccessToConnectionServer()
		{
		}

		[Token(Token = "0x6005D3B")]
		[Address(RVA = "0x43B7DF8", Offset = "0x43B3DF8", VA = "0x43B7DF8")]
		public bool IsOffLine()
		{
			return default;
		}

		[Token(Token = "0x6005D3C")]
		[Address(RVA = "0x43B7E88", Offset = "0x43B3E88", VA = "0x43B7E88")]
		public void LoginOrSwitch()
		{
		}

		[Token(Token = "0x6005D3D")]
		[Address(RVA = "0x43B806C", Offset = "0x43B406C", VA = "0x43B806C")]
		public void TipNeedReLoad()
		{
		}

		[Token(Token = "0x6005D3E")]
		[Address(RVA = "0x43B814C", Offset = "0x43B414C", VA = "0x43B814C")]
		private void ReLoadToHome()
		{
		}
	}
}
