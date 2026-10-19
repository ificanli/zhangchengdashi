using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UIFramework;
using UIModuleO.UIAnim;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x200081B")]
	public class BackpackItemComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200081C")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__237 : IAsyncStateMachine
		{
			[Token(Token = "0x4003DFC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003DFD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003DFE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BackpackItemComponents _003C_003E4__this;

			[Token(Token = "0x4003DFF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6002D4B")]
			[Address(RVA = "0x400C400", Offset = "0x4008400", VA = "0x400C400", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002D4C")]
			[Address(RVA = "0x400C678", Offset = "0x4008678", VA = "0x400C678", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003DF8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TextMeshProUGUI _textMeshProUGUITxtShowName;

		[Token(Token = "0x4003DF9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Image _imageNull;

		[Token(Token = "0x4003DFA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private RewardItemUI _rewardItemUIRewardItemUI;

		[Token(Token = "0x4003DFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private ButtonExtend _buttonExtendShowDes;

		[Token(Token = "0x17000519")]
		public TextMeshProUGUI TextMeshProUGUITxtShowName
		{
			[Token(Token = "0x6002D40")]
			[Address(RVA = "0x400C004", Offset = "0x4008004", VA = "0x400C004")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700051A")]
		public Image ImageNull
		{
			[Token(Token = "0x6002D41")]
			[Address(RVA = "0x400BF3C", Offset = "0x4007F3C", VA = "0x400BF3C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700051B")]
		public RewardItemUI RewardItemUIRewardItemUI
		{
			[Token(Token = "0x6002D42")]
			[Address(RVA = "0x400BE74", Offset = "0x4007E74", VA = "0x400BE74")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700051C")]
		public ButtonExtend ButtonExtendShowDes
		{
			[Token(Token = "0x6002D43")]
			[Address(RVA = "0x400C0D8", Offset = "0x40080D8", VA = "0x400C0D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002D44")]
		[Address(RVA = "0x400C1A0", Offset = "0x40081A0", VA = "0x400C1A0")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6002D45")]
		[Address(RVA = "0x400C228", Offset = "0x4008228", VA = "0x400C228", Slot = "12")]
		protected virtual void OnButtonExtendShowDesClicked()
		{
		}

		[Token(Token = "0x6002D46")]
		[Address(RVA = "0x400C294", Offset = "0x4008294", VA = "0x400C294", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6002D47")]
		[Address(RVA = "0x400C2B0", Offset = "0x40082B0", VA = "0x400C2B0", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__237))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6002D48")]
		[Address(RVA = "0x400C344", Offset = "0x4008344", VA = "0x400C344", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6002D49")]
		[Address(RVA = "0x400B860", Offset = "0x4007860", VA = "0x400B860")]
		public BackpackItemComponents()
		{
		}
	}
}
