using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using ToolModule;

namespace SDKModule
{
	[Token(Token = "0x2000176")]
	public class GameCenterManager : ManagerBase<GameCenterManager>
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000178")]
		[CompilerGenerated]
		private struct _003CAllowGameCenter_003Ed__7 : IAsyncStateMachine
		{
			[Token(Token = "0x4001A56")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001A57")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001A58")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GameCenterManager _003C_003E4__this;

			[Token(Token = "0x4001A59")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60005F5")]
			[Address(RVA = "0x3F73D0C", Offset = "0x3F6FD0C", VA = "0x3F73D0C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60005F6")]
			[Address(RVA = "0x3F74028", Offset = "0x3F70028", VA = "0x3F74028", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000179")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__6 : IAsyncStateMachine
		{
			[Token(Token = "0x4001A5A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001A5B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001A5C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GameCenterManager _003C_003E4__this;

			[Token(Token = "0x60005F7")]
			[Address(RVA = "0x3F74034", Offset = "0x3F70034", VA = "0x3F74034", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60005F8")]
			[Address(RVA = "0x3F74304", Offset = "0x3F70304", VA = "0x3F74304", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4001A50")]
		private const int AuthenticationDelayMilliseconds = 1000;

		[Token(Token = "0x4001A51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool _isAuthenticated;

		[Token(Token = "0x4001A52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		private bool _isGameCenterAllowed;

		[Token(Token = "0x4001A53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		private bool _isAuthenticating;

		[Token(Token = "0x17000090")]
		public bool IsAuthenticated
		{
			[Token(Token = "0x60005EB")]
			[Address(RVA = "0x3F73B40", Offset = "0x3F6FB40", VA = "0x3F73B40")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x3F73B48", Offset = "0x3F6FB48", VA = "0x3F73B48", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__6))]
		public override UniTask Init()
		{
			return default;
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x3F73BCC", Offset = "0x3F6FBCC", VA = "0x3F73BCC")]
		[AsyncStateMachine(typeof(_003CAllowGameCenter_003Ed__7))]
		public UniTaskVoid AllowGameCenter()
		{
			return default;
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x3F73C44", Offset = "0x3F6FC44", VA = "0x3F73C44")]
		public void Authenticate()
		{
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x3F73C48", Offset = "0x3F6FC48", VA = "0x3F73C48")]
		public void ReportScore(long score)
		{
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x3F73C4C", Offset = "0x3F6FC4C", VA = "0x3F73C4C")]
		public GameCenterManager()
		{
		}
	}
}
