using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;

namespace UIModuleO
{
	[Token(Token = "0x2000C17")]
	public class WeeklyClashPanel_SettlementAndBattleStatus : WeeklyClashPanel_SettlementAndBattleStatusComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000C19")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__0 : IAsyncStateMachine
		{
			[Token(Token = "0x400574D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400574E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400574F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public WeeklyClashPanel_SettlementAndBattleStatus _003C_003E4__this;

			[Token(Token = "0x4005750")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6004AED")]
			[Address(RVA = "0x4261FB8", Offset = "0x425DFB8", VA = "0x4261FB8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004AEE")]
			[Address(RVA = "0x4262198", Offset = "0x425E198", VA = "0x4262198", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x6004AE6")]
		[Address(RVA = "0x4261A74", Offset = "0x425DA74", VA = "0x4261A74", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__0))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6004AE7")]
		[Address(RVA = "0x4261B08", Offset = "0x425DB08", VA = "0x4261B08", Slot = "12")]
		protected override void OnButtonExtendBattleTitleBtnClicked()
		{
		}

		[Token(Token = "0x6004AE8")]
		[Address(RVA = "0x4261EA8", Offset = "0x425DEA8", VA = "0x4261EA8")]
		public WeeklyClashPanel_SettlementAndBattleStatus()
		{
		}
	}
}
