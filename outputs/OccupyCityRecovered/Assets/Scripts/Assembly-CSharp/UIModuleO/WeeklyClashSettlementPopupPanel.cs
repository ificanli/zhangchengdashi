using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;

namespace UIModuleO
{
	[Token(Token = "0x2000C2F")]
	public class WeeklyClashSettlementPopupPanel : WeeklyClashSettlementPopupPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000C31")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__2 : IAsyncStateMachine
		{
			[Token(Token = "0x40057BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40057BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40057BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public WeeklyClashSettlementPopupPanel _003C_003E4__this;

			[Token(Token = "0x40057C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6004B78")]
			[Address(RVA = "0x426AFAC", Offset = "0x4266FAC", VA = "0x426AFAC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004B79")]
			[Address(RVA = "0x426BCA4", Offset = "0x4267CA4", VA = "0x426BCA4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40057B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private bool isWeeklyClash;

		[Token(Token = "0x40057BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private int playerRank;

		[Token(Token = "0x6004B6E")]
		[Address(RVA = "0x4268E68", Offset = "0x4264E68", VA = "0x4268E68", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__2))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6004B6F")]
		[Address(RVA = "0x4268EFC", Offset = "0x4264EFC", VA = "0x4268EFC")]
		public void Update()
		{
		}

		[Token(Token = "0x6004B70")]
		[Address(RVA = "0x4268F00", Offset = "0x4264F00", VA = "0x4268F00")]
		private void ShowAnimation()
		{
		}

		[Token(Token = "0x6004B71")]
		[Address(RVA = "0x426AB80", Offset = "0x4266B80", VA = "0x426AB80", Slot = "14")]
		protected override void OnButtonExtendClaimBtnClicked()
		{
		}

		[Token(Token = "0x6004B72")]
		[Address(RVA = "0x426AC6C", Offset = "0x4266C6C", VA = "0x426AC6C", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6004B73")]
		[Address(RVA = "0x426AE50", Offset = "0x4266E50", VA = "0x426AE50")]
		public WeeklyClashSettlementPopupPanel()
		{
		}
	}
}
