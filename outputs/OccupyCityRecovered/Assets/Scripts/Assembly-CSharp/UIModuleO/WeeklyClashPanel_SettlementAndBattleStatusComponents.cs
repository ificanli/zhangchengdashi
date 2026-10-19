using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using UIFramework;
using UIModuleO.UIAnim;

namespace UIModuleO
{
	[Token(Token = "0x2000C1A")]
	public class WeeklyClashPanel_SettlementAndBattleStatusComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000C1B")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__60 : IAsyncStateMachine
		{
			[Token(Token = "0x4005752")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005753")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005754")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public WeeklyClashPanel_SettlementAndBattleStatusComponents _003C_003E4__this;

			[Token(Token = "0x4005755")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6004AF7")]
			[Address(RVA = "0x42623CC", Offset = "0x425E3CC", VA = "0x42623CC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004AF8")]
			[Address(RVA = "0x4262644", Offset = "0x425E644", VA = "0x4262644", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4005751")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ButtonExtend _buttonExtendBattleTitleBtn;

		[Token(Token = "0x17000D35")]
		public ButtonExtend ButtonExtendBattleTitleBtn
		{
			[Token(Token = "0x6004AEF")]
			[Address(RVA = "0x42621A4", Offset = "0x425E1A4", VA = "0x42621A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004AF0")]
		[Address(RVA = "0x426226C", Offset = "0x425E26C", VA = "0x426226C")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6004AF1")]
		[Address(RVA = "0x4261E3C", Offset = "0x425DE3C", VA = "0x4261E3C", Slot = "12")]
		protected virtual void OnButtonExtendBattleTitleBtnClicked()
		{
		}

		[Token(Token = "0x6004AF2")]
		[Address(RVA = "0x42622F4", Offset = "0x425E2F4", VA = "0x42622F4", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6004AF3")]
		[Address(RVA = "0x4261EBC", Offset = "0x425DEBC", VA = "0x4261EBC", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__60))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6004AF4")]
		[Address(RVA = "0x4262310", Offset = "0x425E310", VA = "0x4262310", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6004AF5")]
		[Address(RVA = "0x4261EB0", Offset = "0x425DEB0", VA = "0x4261EB0")]
		public WeeklyClashPanel_SettlementAndBattleStatusComponents()
		{
		}
	}
}
