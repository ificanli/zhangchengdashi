using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;

namespace UIModuleO
{
	[Token(Token = "0x2000AB9")]
	public class SummonOddDesPanel : SummonOddDesPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000ABA")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__1 : IAsyncStateMachine
		{
			[Token(Token = "0x4004EE2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004EE3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004EE4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public SummonOddDesPanel _003C_003E4__this;

			[Token(Token = "0x4004EE5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x60040CD")]
			[Address(RVA = "0x41B029C", Offset = "0x41AC29C", VA = "0x41B029C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60040CE")]
			[Address(RVA = "0x41B0520", Offset = "0x41AC520", VA = "0x41B0520", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004EE1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private int level;

		[Token(Token = "0x60040C3")]
		[Address(RVA = "0x41AEBF8", Offset = "0x41AABF8", VA = "0x41AEBF8", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__1))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60040C4")]
		[Address(RVA = "0x41AEC8C", Offset = "0x41AAC8C", VA = "0x41AEC8C", Slot = "15")]
		protected override void OnButtonExtendBtnCloseClicked()
		{
		}

		[Token(Token = "0x60040C5")]
		[Address(RVA = "0x41AED18", Offset = "0x41AAD18", VA = "0x41AED18", Slot = "14")]
		protected override void OnButtonExtendBtnLeftClicked()
		{
		}

		[Token(Token = "0x60040C6")]
		[Address(RVA = "0x41AF410", Offset = "0x41AB410", VA = "0x41AF410", Slot = "13")]
		protected override void OnButtonExtendBtnRightClicked()
		{
		}

		[Token(Token = "0x60040C7")]
		[Address(RVA = "0x41AEDBC", Offset = "0x41AADBC", VA = "0x41AEDBC")]
		private void UpdateUI()
		{
		}

		[Token(Token = "0x60040C8")]
		[Address(RVA = "0x41AFEDC", Offset = "0x41ABEDC", VA = "0x41AFEDC", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x60040C9")]
		[Address(RVA = "0x41B00A4", Offset = "0x41AC0A4", VA = "0x41B00A4", Slot = "12")]
		protected override void OnButtonExtendBgClicked()
		{
		}

		[Token(Token = "0x60040CA")]
		[Address(RVA = "0x41B0130", Offset = "0x41AC130", VA = "0x41B0130")]
		public SummonOddDesPanel()
		{
		}
	}
}
