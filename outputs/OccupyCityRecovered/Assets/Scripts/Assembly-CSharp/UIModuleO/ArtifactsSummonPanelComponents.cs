using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using UIFramework;
using UIModuleO.UIAnim;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x20006D9")]
	public class ArtifactsSummonPanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20006DA")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__317 : IAsyncStateMachine
		{
			[Token(Token = "0x40036CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40036CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40036CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ArtifactsSummonPanelComponents _003C_003E4__this;

			[Token(Token = "0x40036CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x60024E0")]
			[Address(RVA = "0x3F61D60", Offset = "0x3F5DD60", VA = "0x3F61D60", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60024E1")]
			[Address(RVA = "0x3F61FD8", Offset = "0x3F5DFD8", VA = "0x3F61FD8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40036C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private NormalSummonPanel _normalSummonPanelNormalSummonPanel;

		[Token(Token = "0x40036C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private SpecialSummonPanel _specialSummonPanelSpecialSummonPanel;

		[Token(Token = "0x40036C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private ButtonExtend _buttonExtendCloseBtn;

		[Token(Token = "0x40036C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Toggle _toggleNormalSummonTog;

		[Token(Token = "0x40036C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Toggle _toggleSpecialSummonTog;

		[Token(Token = "0x40036CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Image _imageSummonMask;

		[Token(Token = "0x1700028D")]
		public NormalSummonPanel NormalSummonPanelNormalSummonPanel
		{
			[Token(Token = "0x60024D1")]
			[Address(RVA = "0x3F61294", Offset = "0x3F5D294", VA = "0x3F61294")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700028E")]
		public SpecialSummonPanel SpecialSummonPanelSpecialSummonPanel
		{
			[Token(Token = "0x60024D2")]
			[Address(RVA = "0x3F6135C", Offset = "0x3F5D35C", VA = "0x3F6135C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700028F")]
		public ButtonExtend ButtonExtendCloseBtn
		{
			[Token(Token = "0x60024D3")]
			[Address(RVA = "0x3F61970", Offset = "0x3F5D970", VA = "0x3F61970")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000290")]
		public Toggle ToggleNormalSummonTog
		{
			[Token(Token = "0x60024D4")]
			[Address(RVA = "0x3F617D4", Offset = "0x3F5D7D4", VA = "0x3F617D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000291")]
		public Toggle ToggleSpecialSummonTog
		{
			[Token(Token = "0x60024D5")]
			[Address(RVA = "0x3F6189C", Offset = "0x3F5D89C", VA = "0x3F6189C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000292")]
		public Image ImageSummonMask
		{
			[Token(Token = "0x60024D6")]
			[Address(RVA = "0x3F60E78", Offset = "0x3F5CE78", VA = "0x3F60E78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60024D7")]
		[Address(RVA = "0x3F61A38", Offset = "0x3F5DA38", VA = "0x3F61A38")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x60024D8")]
		[Address(RVA = "0x3F61B78", Offset = "0x3F5DB78", VA = "0x3F61B78", Slot = "12")]
		protected virtual void OnButtonExtendCloseBtnClicked()
		{
		}

		[Token(Token = "0x60024D9")]
		[Address(RVA = "0x3F61BE4", Offset = "0x3F5DBE4", VA = "0x3F61BE4", Slot = "13")]
		protected virtual void OnToggleNormalSummonTogValueChanged(bool arg)
		{
		}

		[Token(Token = "0x60024DA")]
		[Address(RVA = "0x3F61C90", Offset = "0x3F5DC90", VA = "0x3F61C90", Slot = "14")]
		protected virtual void OnToggleSpecialSummonTogValueChanged(bool arg)
		{
		}

		[Token(Token = "0x60024DB")]
		[Address(RVA = "0x3F61D3C", Offset = "0x3F5DD3C", VA = "0x3F61D3C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60024DC")]
		[Address(RVA = "0x3F61438", Offset = "0x3F5D438", VA = "0x3F61438", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__317))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60024DD")]
		[Address(RVA = "0x3F6113C", Offset = "0x3F5D13C", VA = "0x3F6113C", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x60024DE")]
		[Address(RVA = "0x3F6142C", Offset = "0x3F5D42C", VA = "0x3F6142C")]
		public ArtifactsSummonPanelComponents()
		{
		}
	}
}
