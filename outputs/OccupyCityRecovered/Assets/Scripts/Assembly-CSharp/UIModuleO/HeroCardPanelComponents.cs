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
	[Token(Token = "0x20007B0")]
	public class HeroCardPanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20007B1")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__177 : IAsyncStateMachine
		{
			[Token(Token = "0x4003B88")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003B89")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003B8A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public HeroCardPanelComponents _003C_003E4__this;

			[Token(Token = "0x4003B8B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6002A84")]
			[Address(RVA = "0x3FD7984", Offset = "0x3FD3984", VA = "0x3FD7984", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002A85")]
			[Address(RVA = "0x3FD7BFC", Offset = "0x3FD3BFC", VA = "0x3FD7BFC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003B7E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private HeroCardView _heroCardViewHeroCardView;

		[Token(Token = "0x4003B7F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private ArtifactView _artifactViewArtifactView;

		[Token(Token = "0x4003B80")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private AllNewArtifactView _allNewArtifactViewAllNewArtifactView;

		[Token(Token = "0x4003B81")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BackpackView _backpackViewBackpackView;

		[Token(Token = "0x4003B82")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private ExpressionView _expressionViewExpressionView;

		[Token(Token = "0x4003B83")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private TabButtonGroup _tabButtonGroupTabGroup;

		[Token(Token = "0x4003B84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private ButtonExtend _buttonExtendBtnUnit;

		[Token(Token = "0x4003B85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private ButtonExtend _buttonExtendBtnProp;

		[Token(Token = "0x4003B86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private ButtonExtend _buttonExtendBtnBackpack;

		[Token(Token = "0x4003B87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private ButtonExtend _buttonExtendBtnExpression;

		[Token(Token = "0x1700043C")]
		public HeroCardView HeroCardViewHeroCardView
		{
			[Token(Token = "0x6002A70")]
			[Address(RVA = "0x3FD617C", Offset = "0x3FD217C", VA = "0x3FD617C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700043D")]
		public ArtifactView ArtifactViewArtifactView
		{
			[Token(Token = "0x6002A71")]
			[Address(RVA = "0x3FD6244", Offset = "0x3FD2244", VA = "0x3FD6244")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700043E")]
		public AllNewArtifactView AllNewArtifactViewAllNewArtifactView
		{
			[Token(Token = "0x6002A72")]
			[Address(RVA = "0x3FD630C", Offset = "0x3FD230C", VA = "0x3FD630C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700043F")]
		public BackpackView BackpackViewBackpackView
		{
			[Token(Token = "0x6002A73")]
			[Address(RVA = "0x3FD63D4", Offset = "0x3FD23D4", VA = "0x3FD63D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000440")]
		public ExpressionView ExpressionViewExpressionView
		{
			[Token(Token = "0x6002A74")]
			[Address(RVA = "0x3FD649C", Offset = "0x3FD249C", VA = "0x3FD649C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000441")]
		public TabButtonGroup TabButtonGroupTabGroup
		{
			[Token(Token = "0x6002A75")]
			[Address(RVA = "0x3FD5D58", Offset = "0x3FD1D58", VA = "0x3FD5D58")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000442")]
		public ButtonExtend ButtonExtendBtnUnit
		{
			[Token(Token = "0x6002A76")]
			[Address(RVA = "0x3FD7418", Offset = "0x3FD3418", VA = "0x3FD7418")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000443")]
		public ButtonExtend ButtonExtendBtnProp
		{
			[Token(Token = "0x6002A77")]
			[Address(RVA = "0x3FD74E0", Offset = "0x3FD34E0", VA = "0x3FD74E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000444")]
		public ButtonExtend ButtonExtendBtnBackpack
		{
			[Token(Token = "0x6002A78")]
			[Address(RVA = "0x3FD75A8", Offset = "0x3FD35A8", VA = "0x3FD75A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000445")]
		public ButtonExtend ButtonExtendBtnExpression
		{
			[Token(Token = "0x6002A79")]
			[Address(RVA = "0x3FD5E20", Offset = "0x3FD1E20", VA = "0x3FD5E20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002A7A")]
		[Address(RVA = "0x3FD7670", Offset = "0x3FD3670", VA = "0x3FD7670")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6002A7B")]
		[Address(RVA = "0x3FD77CC", Offset = "0x3FD37CC", VA = "0x3FD77CC", Slot = "12")]
		protected virtual void OnButtonExtendBtnUnitClicked()
		{
		}

		[Token(Token = "0x6002A7C")]
		[Address(RVA = "0x3FD7838", Offset = "0x3FD3838", VA = "0x3FD7838", Slot = "13")]
		protected virtual void OnButtonExtendBtnPropClicked()
		{
		}

		[Token(Token = "0x6002A7D")]
		[Address(RVA = "0x3FD78A4", Offset = "0x3FD38A4", VA = "0x3FD78A4", Slot = "14")]
		protected virtual void OnButtonExtendBtnBackpackClicked()
		{
		}

		[Token(Token = "0x6002A7E")]
		[Address(RVA = "0x3FD7910", Offset = "0x3FD3910", VA = "0x3FD7910", Slot = "15")]
		protected virtual void OnButtonExtendBtnExpressionClicked()
		{
		}

		[Token(Token = "0x6002A7F")]
		[Address(RVA = "0x3FD5D3C", Offset = "0x3FD1D3C", VA = "0x3FD5D3C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6002A80")]
		[Address(RVA = "0x3FD7184", Offset = "0x3FD3184", VA = "0x3FD7184", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__177))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6002A81")]
		[Address(RVA = "0x3FD60C8", Offset = "0x3FD20C8", VA = "0x3FD60C8", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6002A82")]
		[Address(RVA = "0x3FD716C", Offset = "0x3FD316C", VA = "0x3FD716C")]
		public HeroCardPanelComponents()
		{
		}
	}
}
