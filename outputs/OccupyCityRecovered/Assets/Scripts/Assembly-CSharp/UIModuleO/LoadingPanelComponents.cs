using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using Spine.Unity;
using TMPro;
using UIFramework;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x200092B")]
	public class LoadingPanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200092C")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__101 : IAsyncStateMachine
		{
			[Token(Token = "0x40044B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40044B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40044B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public LoadingPanelComponents _003C_003E4__this;

			[Token(Token = "0x40044B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x60034FD")]
			[Address(RVA = "0x40AFB0C", Offset = "0x40ABB0C", VA = "0x40AFB0C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60034FE")]
			[Address(RVA = "0x40AFD84", Offset = "0x40ABD84", VA = "0x40AFD84", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40044AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Image _imageBG;

		[Token(Token = "0x40044AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private SkeletonGraphic _skeletonGraphicBGSpine;

		[Token(Token = "0x40044AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TextMeshProUGUI _textMeshProUGUILoadingText;

		[Token(Token = "0x40044B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Image _imageProgressImg;

		[Token(Token = "0x40044B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private TextMeshProUGUI _textMeshProUGUIProgressText;

		[Token(Token = "0x17000757")]
		public Image ImageBG
		{
			[Token(Token = "0x60034F2")]
			[Address(RVA = "0x40AF294", Offset = "0x40AB294", VA = "0x40AF294")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000758")]
		public SkeletonGraphic SkeletonGraphicBGSpine
		{
			[Token(Token = "0x60034F3")]
			[Address(RVA = "0x40AECF8", Offset = "0x40AACF8", VA = "0x40AECF8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000759")]
		public TextMeshProUGUI TextMeshProUGUILoadingText
		{
			[Token(Token = "0x60034F4")]
			[Address(RVA = "0x40AE084", Offset = "0x40AA084", VA = "0x40AE084")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700075A")]
		public Image ImageProgressImg
		{
			[Token(Token = "0x60034F5")]
			[Address(RVA = "0x40AE334", Offset = "0x40AA334", VA = "0x40AE334")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700075B")]
		public TextMeshProUGUI TextMeshProUGUIProgressText
		{
			[Token(Token = "0x60034F6")]
			[Address(RVA = "0x40AE3FC", Offset = "0x40AA3FC", VA = "0x40AE3FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60034F7")]
		[Address(RVA = "0x40AF9B8", Offset = "0x40AB9B8", VA = "0x40AF9B8")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x60034F8")]
		[Address(RVA = "0x40AE4E4", Offset = "0x40AA4E4", VA = "0x40AE4E4", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60034F9")]
		[Address(RVA = "0x40AF9BC", Offset = "0x40AB9BC", VA = "0x40AF9BC", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__101))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60034FA")]
		[Address(RVA = "0x40AFA50", Offset = "0x40ABA50", VA = "0x40AFA50", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x60034FB")]
		[Address(RVA = "0x40AE4D4", Offset = "0x40AA4D4", VA = "0x40AE4D4")]
		public LoadingPanelComponents()
		{
		}
	}
}
