using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using UIFramework;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000B0A")]
	public class SetHumanNumberPanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000B0B")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__193 : IAsyncStateMachine
		{
			[Token(Token = "0x40050C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40050C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40050C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public SetHumanNumberPanelComponents _003C_003E4__this;

			[Token(Token = "0x40050C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x60042DE")]
			[Address(RVA = "0x41D418C", Offset = "0x41D018C", VA = "0x41D418C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60042DF")]
			[Address(RVA = "0x41D4404", Offset = "0x41D0404", VA = "0x41D4404", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40050BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Button _buttonOk;

		[Token(Token = "0x40050C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Button _buttonBtnShowCardDeck;

		[Token(Token = "0x17000ACA")]
		public Button ButtonOk
		{
			[Token(Token = "0x60042D4")]
			[Address(RVA = "0x41D3CE4", Offset = "0x41CFCE4", VA = "0x41D3CE4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000ACB")]
		public Button ButtonBtnShowCardDeck
		{
			[Token(Token = "0x60042D5")]
			[Address(RVA = "0x41D3DAC", Offset = "0x41CFDAC", VA = "0x41D3DAC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60042D6")]
		[Address(RVA = "0x41D3E74", Offset = "0x41CFE74", VA = "0x41D3E74")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x60042D7")]
		[Address(RVA = "0x41D3F48", Offset = "0x41CFF48", VA = "0x41D3F48", Slot = "12")]
		protected virtual void OnButtonOkClicked()
		{
		}

		[Token(Token = "0x60042D8")]
		[Address(RVA = "0x41D3FB4", Offset = "0x41CFFB4", VA = "0x41D3FB4", Slot = "13")]
		protected virtual void OnButtonBtnShowCardDeckClicked()
		{
		}

		[Token(Token = "0x60042D9")]
		[Address(RVA = "0x41D4020", Offset = "0x41D0020", VA = "0x41D4020", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60042DA")]
		[Address(RVA = "0x41D403C", Offset = "0x41D003C", VA = "0x41D403C", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__193))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60042DB")]
		[Address(RVA = "0x41D40D0", Offset = "0x41D00D0", VA = "0x41D40D0", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x60042DC")]
		[Address(RVA = "0x41D3CDC", Offset = "0x41CFCDC", VA = "0x41D3CDC")]
		public SetHumanNumberPanelComponents()
		{
		}
	}
}
