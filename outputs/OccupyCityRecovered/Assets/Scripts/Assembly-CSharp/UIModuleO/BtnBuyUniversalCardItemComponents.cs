using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using Spine.Unity;
using TMPro;
using UIFramework;
using UIModuleO.UIAnim;

namespace UIModuleO
{
	[Token(Token = "0x2000757")]
	public class BtnBuyUniversalCardItemComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000758")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__57 : IAsyncStateMachine
		{
			[Token(Token = "0x400399D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400399E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400399F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BtnBuyUniversalCardItemComponents _003C_003E4__this;

			[Token(Token = "0x40039A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6002835")]
			[Address(RVA = "0x3FAF614", Offset = "0x3FAB614", VA = "0x3FAF614", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002836")]
			[Address(RVA = "0x3FAF88C", Offset = "0x3FAB88C", VA = "0x3FAF88C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003998")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ButtonExtend _buttonExtendBtnBuyUniversalCardItem;

		[Token(Token = "0x4003999")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private SkeletonGraphic _skeletonGraphicCardSpine;

		[Token(Token = "0x400399A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TextMeshProUGUI _textMeshProUGUINumberText;

		[Token(Token = "0x400399B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private TextMeshProUGUI _textMeshProUGUIAvailableText;

		[Token(Token = "0x400399C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private TextMeshProUGUI _textMeshProUGUIPriceText;

		[Token(Token = "0x17000395")]
		public ButtonExtend ButtonExtendBtnBuyUniversalCardItem
		{
			[Token(Token = "0x6002829")]
			[Address(RVA = "0x3FAF37C", Offset = "0x3FAB37C", VA = "0x3FAF37C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000396")]
		public SkeletonGraphic SkeletonGraphicCardSpine
		{
			[Token(Token = "0x600282A")]
			[Address(RVA = "0x3FAF2A8", Offset = "0x3FAB2A8", VA = "0x3FAF2A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000397")]
		public TextMeshProUGUI TextMeshProUGUINumberText
		{
			[Token(Token = "0x600282B")]
			[Address(RVA = "0x3FAF1E0", Offset = "0x3FAB1E0", VA = "0x3FAF1E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000398")]
		public TextMeshProUGUI TextMeshProUGUIAvailableText
		{
			[Token(Token = "0x600282C")]
			[Address(RVA = "0x3FAE45C", Offset = "0x3FAA45C", VA = "0x3FAE45C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000399")]
		public TextMeshProUGUI TextMeshProUGUIPriceText
		{
			[Token(Token = "0x600282D")]
			[Address(RVA = "0x3FAF118", Offset = "0x3FAB118", VA = "0x3FAF118")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600282E")]
		[Address(RVA = "0x3FAF420", Offset = "0x3FAB420", VA = "0x3FAF420")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x600282F")]
		[Address(RVA = "0x3FAE778", Offset = "0x3FAA778", VA = "0x3FAE778", Slot = "12")]
		protected virtual void OnButtonExtendBtnBuyUniversalCardItemClicked()
		{
		}

		[Token(Token = "0x6002830")]
		[Address(RVA = "0x3FAF4A8", Offset = "0x3FAB4A8", VA = "0x3FAF4A8", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6002831")]
		[Address(RVA = "0x3FAF4C4", Offset = "0x3FAB4C4", VA = "0x3FAF4C4", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__57))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6002832")]
		[Address(RVA = "0x3FAF558", Offset = "0x3FAB558", VA = "0x3FAF558", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6002833")]
		[Address(RVA = "0x3FAE7EC", Offset = "0x3FAA7EC", VA = "0x3FAE7EC")]
		public BtnBuyUniversalCardItemComponents()
		{
		}
	}
}
