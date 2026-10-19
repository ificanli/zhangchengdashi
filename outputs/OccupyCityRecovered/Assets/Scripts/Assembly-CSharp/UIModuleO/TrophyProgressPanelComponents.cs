using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using SuperScrollView;
using UIFramework;
using UIModuleO.UIAnim;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000BC9")]
	public class TrophyProgressPanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000BCA")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__79 : IAsyncStateMachine
		{
			[Token(Token = "0x40055B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40055B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40055B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public TrophyProgressPanelComponents _003C_003E4__this;

			[Token(Token = "0x40055B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x60048CF")]
			[Address(RVA = "0x423E198", Offset = "0x423A198", VA = "0x423E198", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60048D0")]
			[Address(RVA = "0x423E410", Offset = "0x423A410", VA = "0x423E410", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40055B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ScrollRect _scrollRectLoopScrollView;

		[Token(Token = "0x40055B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private LoopListView2 _loopListView2LoopScrollView;

		[Token(Token = "0x40055B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private ButtonExtend _buttonExtendBtnBack;

		[Token(Token = "0x17000CA6")]
		public ScrollRect ScrollRectLoopScrollView
		{
			[Token(Token = "0x60048C4")]
			[Address(RVA = "0x423DE58", Offset = "0x4239E58", VA = "0x423DE58")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CA7")]
		public LoopListView2 LoopListView2LoopScrollView
		{
			[Token(Token = "0x60048C5")]
			[Address(RVA = "0x423CCDC", Offset = "0x4238CDC", VA = "0x423CCDC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CA8")]
		public ButtonExtend ButtonExtendBtnBack
		{
			[Token(Token = "0x60048C6")]
			[Address(RVA = "0x423DF20", Offset = "0x4239F20", VA = "0x423DF20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60048C7")]
		[Address(RVA = "0x423DFE8", Offset = "0x4239FE8", VA = "0x423DFE8")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x60048C8")]
		[Address(RVA = "0x423E0DC", Offset = "0x423A0DC", VA = "0x423E0DC", Slot = "12")]
		protected virtual void OnScrollRectLoopScrollViewValueChanged(Vector2 arg)
		{
		}

		[Token(Token = "0x60048C9")]
		[Address(RVA = "0x423D9AC", Offset = "0x42399AC", VA = "0x423D9AC", Slot = "13")]
		protected virtual void OnButtonExtendBtnBackClicked()
		{
		}

		[Token(Token = "0x60048CA")]
		[Address(RVA = "0x423C8E8", Offset = "0x42388E8", VA = "0x423C8E8", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60048CB")]
		[Address(RVA = "0x423DAF4", Offset = "0x4239AF4", VA = "0x423DAF4", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__79))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60048CC")]
		[Address(RVA = "0x423D8D8", Offset = "0x42398D8", VA = "0x423D8D8", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x60048CD")]
		[Address(RVA = "0x423DAE8", Offset = "0x4239AE8", VA = "0x423DAE8")]
		public TrophyProgressPanelComponents()
		{
		}
	}
}
