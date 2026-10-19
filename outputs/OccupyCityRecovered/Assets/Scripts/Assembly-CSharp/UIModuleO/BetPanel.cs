using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using Il2CppDummyDll;

namespace UIModuleO
{
	[Token(Token = "0x200071A")]
	public class BetPanel : BetPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200071B")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__5 : IAsyncStateMachine
		{
			[Token(Token = "0x4003859")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400385A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400385B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BetPanel _003C_003E4__this;

			[Token(Token = "0x400385C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x60026AD")]
			[Address(RVA = "0x3F97A84", Offset = "0x3F93A84", VA = "0x3F97A84", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60026AE")]
			[Address(RVA = "0x3F98734", Offset = "0x3F94734", VA = "0x3F98734", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003854")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private int betMaxLimit;

		[Token(Token = "0x4003855")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private int nowBetNum;

		[Token(Token = "0x4003856")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private int changeBetNum;

		[Token(Token = "0x4003857")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private bool isUserNum;

		[Token(Token = "0x4003858")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private UserArenaData _data;

		[Token(Token = "0x60026A1")]
		[Address(RVA = "0x3F96D20", Offset = "0x3F92D20", VA = "0x3F96D20", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__5))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60026A2")]
		[Address(RVA = "0x3F96DB4", Offset = "0x3F92DB4", VA = "0x3F96DB4", Slot = "15")]
		protected override void OnButtonExtendBtnStartClicked()
		{
		}

		[Token(Token = "0x60026A3")]
		[Address(RVA = "0x3F97100", Offset = "0x3F93100", VA = "0x3F97100", Slot = "13")]
		protected override void OnButtonExtendBtnReduceClicked()
		{
		}

		[Token(Token = "0x60026A4")]
		[Address(RVA = "0x3F972E0", Offset = "0x3F932E0", VA = "0x3F972E0", Slot = "14")]
		protected override void OnButtonExtendBtnBoostClicked()
		{
		}

		[Token(Token = "0x60026A5")]
		[Address(RVA = "0x3F97544", Offset = "0x3F93544", VA = "0x3F97544", Slot = "16")]
		protected override void OnButtonExtendBtnCloseClicked()
		{
		}

		[Token(Token = "0x60026A6")]
		[Address(RVA = "0x3F971A4", Offset = "0x3F931A4", VA = "0x3F971A4")]
		private void UpdateCoinNumUI()
		{
		}

		[Token(Token = "0x60026A7")]
		[Address(RVA = "0x3F97698", Offset = "0x3F93698", VA = "0x3F97698", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x60026A8")]
		[Address(RVA = "0x3F97860", Offset = "0x3F93860", VA = "0x3F97860")]
		private int CalculateHumanizedBet(int currentAmount)
		{
			return default;
		}

		[Token(Token = "0x60026A9")]
		[Address(RVA = "0x3F97884", Offset = "0x3F93884", VA = "0x3F97884", Slot = "12")]
		protected override void OnButtonExtendBGClicked()
		{
		}

		[Token(Token = "0x60026AA")]
		[Address(RVA = "0x3F97910", Offset = "0x3F93910", VA = "0x3F97910")]
		public BetPanel()
		{
		}
	}
}
