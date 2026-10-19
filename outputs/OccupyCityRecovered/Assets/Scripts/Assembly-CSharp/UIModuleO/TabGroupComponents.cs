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
	[Token(Token = "0x2000B9D")]
	public class TabGroupComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000B9E")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__365 : IAsyncStateMachine
		{
			[Token(Token = "0x400545B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400545C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400545D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public TabGroupComponents _003C_003E4__this;

			[Token(Token = "0x400545E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6004735")]
			[Address(RVA = "0x421FDC8", Offset = "0x421BDC8", VA = "0x421FDC8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004736")]
			[Address(RVA = "0x4220040", Offset = "0x421C040", VA = "0x4220040", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4005458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ButtonExtend _buttonExtendBtnSales;

		[Token(Token = "0x4005459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private ButtonExtend _buttonExtendBtnPrimary;

		[Token(Token = "0x400545A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private ButtonExtend _buttonExtendBtnArena;

		[Token(Token = "0x17000C05")]
		public ButtonExtend ButtonExtendBtnSales
		{
			[Token(Token = "0x6004729")]
			[Address(RVA = "0x421F83C", Offset = "0x421B83C", VA = "0x421F83C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C06")]
		public ButtonExtend ButtonExtendBtnPrimary
		{
			[Token(Token = "0x600472A")]
			[Address(RVA = "0x421F904", Offset = "0x421B904", VA = "0x421F904")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C07")]
		public ButtonExtend ButtonExtendBtnArena
		{
			[Token(Token = "0x600472B")]
			[Address(RVA = "0x421F9CC", Offset = "0x421B9CC", VA = "0x421F9CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600472C")]
		[Address(RVA = "0x421FA94", Offset = "0x421BA94", VA = "0x421FA94")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x600472D")]
		[Address(RVA = "0x421FBAC", Offset = "0x421BBAC", VA = "0x421FBAC", Slot = "12")]
		protected virtual void OnButtonExtendBtnSalesClicked()
		{
		}

		[Token(Token = "0x600472E")]
		[Address(RVA = "0x421FC18", Offset = "0x421BC18", VA = "0x421FC18", Slot = "13")]
		protected virtual void OnButtonExtendBtnPrimaryClicked()
		{
		}

		[Token(Token = "0x600472F")]
		[Address(RVA = "0x421FC84", Offset = "0x421BC84", VA = "0x421FC84", Slot = "14")]
		protected virtual void OnButtonExtendBtnArenaClicked()
		{
		}

		[Token(Token = "0x6004730")]
		[Address(RVA = "0x421FCF0", Offset = "0x421BCF0", VA = "0x421FCF0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6004731")]
		[Address(RVA = "0x421F5BC", Offset = "0x421B5BC", VA = "0x421F5BC", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__365))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6004732")]
		[Address(RVA = "0x421FD0C", Offset = "0x421BD0C", VA = "0x421FD0C", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6004733")]
		[Address(RVA = "0x421F5B0", Offset = "0x421B5B0", VA = "0x421F5B0")]
		public TabGroupComponents()
		{
		}
	}
}
