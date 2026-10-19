using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using UIFramework;

namespace UIModuleO
{
	[Token(Token = "0x2000713")]
	public class BattleStatusLeaderboardItemComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000714")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__119 : IAsyncStateMachine
		{
			[Token(Token = "0x4003846")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003847")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003848")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BattleStatusLeaderboardItemComponents _003C_003E4__this;

			[Token(Token = "0x4003849")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x600268F")]
			[Address(RVA = "0x3F96248", Offset = "0x3F92248", VA = "0x3F96248", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002690")]
			[Address(RVA = "0x3F964C0", Offset = "0x3F924C0", VA = "0x3F964C0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x6002689")]
		[Address(RVA = "0x3F960EC", Offset = "0x3F920EC", VA = "0x3F960EC")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x600268A")]
		[Address(RVA = "0x3F960F0", Offset = "0x3F920F0", VA = "0x3F960F0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600268B")]
		[Address(RVA = "0x3F960F8", Offset = "0x3F920F8", VA = "0x3F960F8", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__119))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x600268C")]
		[Address(RVA = "0x3F9618C", Offset = "0x3F9218C", VA = "0x3F9618C", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x600268D")]
		[Address(RVA = "0x3F960E4", Offset = "0x3F920E4", VA = "0x3F960E4")]
		public BattleStatusLeaderboardItemComponents()
		{
		}
	}
}
