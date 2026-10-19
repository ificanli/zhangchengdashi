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
	[Token(Token = "0x200077D")]
	public class BtnShowCardDeckComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200077E")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__93 : IAsyncStateMachine
		{
			[Token(Token = "0x4003A69")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003A6A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003A6B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BtnShowCardDeckComponents _003C_003E4__this;

			[Token(Token = "0x4003A6C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x600292A")]
			[Address(RVA = "0x3FBF598", Offset = "0x3FBB598", VA = "0x3FBF598", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600292B")]
			[Address(RVA = "0x3FBF810", Offset = "0x3FBB810", VA = "0x3FBF810", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003A65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ButtonExtend _buttonExtendBtnShowCardDeck;

		[Token(Token = "0x4003A66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Image _imageImgIcon;

		[Token(Token = "0x4003A67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TextMeshProUGUI _textMeshProUGUITxtCardDeck;

		[Token(Token = "0x4003A68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private TextMeshProUGUI _textMeshProUGUITxtBtnShowCardDeck;

		[Token(Token = "0x170003DD")]
		public ButtonExtend ButtonExtendBtnShowCardDeck
		{
			[Token(Token = "0x600291F")]
			[Address(RVA = "0x3FBF3B0", Offset = "0x3FBB3B0", VA = "0x3FBF3B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003DE")]
		public Image ImageImgIcon
		{
			[Token(Token = "0x6002920")]
			[Address(RVA = "0x3FBF2DC", Offset = "0x3FBB2DC", VA = "0x3FBF2DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003DF")]
		public TextMeshProUGUI TextMeshProUGUITxtCardDeck
		{
			[Token(Token = "0x6002921")]
			[Address(RVA = "0x3FBF214", Offset = "0x3FBB214", VA = "0x3FBF214")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003E0")]
		public TextMeshProUGUI TextMeshProUGUITxtBtnShowCardDeck
		{
			[Token(Token = "0x6002922")]
			[Address(RVA = "0x3FBEB60", Offset = "0x3FBAB60", VA = "0x3FBEB60")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002923")]
		[Address(RVA = "0x3FBF454", Offset = "0x3FBB454", VA = "0x3FBF454")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6002924")]
		[Address(RVA = "0x3FBE674", Offset = "0x3FBA674", VA = "0x3FBE674", Slot = "12")]
		protected virtual void OnButtonExtendBtnShowCardDeckClicked()
		{
		}

		[Token(Token = "0x6002925")]
		[Address(RVA = "0x3FBE424", Offset = "0x3FBA424", VA = "0x3FBE424", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6002926")]
		[Address(RVA = "0x3FBE794", Offset = "0x3FBA794", VA = "0x3FBE794", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__93))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6002927")]
		[Address(RVA = "0x3FBF4DC", Offset = "0x3FBB4DC", VA = "0x3FBF4DC", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6002928")]
		[Address(RVA = "0x3FBE788", Offset = "0x3FBA788", VA = "0x3FBE788")]
		public BtnShowCardDeckComponents()
		{
		}
	}
}
