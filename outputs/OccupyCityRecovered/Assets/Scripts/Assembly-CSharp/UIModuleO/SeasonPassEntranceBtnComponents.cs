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
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000AF3")]
	public class SeasonPassEntranceBtnComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000AF4")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__225 : IAsyncStateMachine
		{
			[Token(Token = "0x400504A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400504B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400504C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public SeasonPassEntranceBtnComponents _003C_003E4__this;

			[Token(Token = "0x400504D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6004246")]
			[Address(RVA = "0x41CB768", Offset = "0x41C7768", VA = "0x41CB768", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004247")]
			[Address(RVA = "0x41CB9E0", Offset = "0x41C79E0", VA = "0x41CB9E0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4005043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ButtonExtend _buttonExtendSeasonPassEntranceBtn;

		[Token(Token = "0x4005044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Image _imageBG;

		[Token(Token = "0x4005045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private RectTransform _rectTransformProgressBG;

		[Token(Token = "0x4005046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private RectTransform _rectTransformProgressBar;

		[Token(Token = "0x4005047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private TextMeshProUGUI _textMeshProUGUIProgressText;

		[Token(Token = "0x4005048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private TextMeshProUGUI _textMeshProUGUICurrentLevelText;

		[Token(Token = "0x4005049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private SkeletonGraphic _skeletonGraphicIconSpine;

		[Token(Token = "0x17000A95")]
		public ButtonExtend ButtonExtendSeasonPassEntranceBtn
		{
			[Token(Token = "0x6004238")]
			[Address(RVA = "0x41CB580", Offset = "0x41C7580", VA = "0x41CB580")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A96")]
		public Image ImageBG
		{
			[Token(Token = "0x6004239")]
			[Address(RVA = "0x41CAD74", Offset = "0x41C6D74", VA = "0x41CAD74")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A97")]
		public RectTransform RectTransformProgressBG
		{
			[Token(Token = "0x600423A")]
			[Address(RVA = "0x41CA258", Offset = "0x41C6258", VA = "0x41CA258")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A98")]
		public RectTransform RectTransformProgressBar
		{
			[Token(Token = "0x600423B")]
			[Address(RVA = "0x41CA190", Offset = "0x41C6190", VA = "0x41CA190")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A99")]
		public TextMeshProUGUI TextMeshProUGUIProgressText
		{
			[Token(Token = "0x600423C")]
			[Address(RVA = "0x41CA3E8", Offset = "0x41C63E8", VA = "0x41CA3E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A9A")]
		public TextMeshProUGUI TextMeshProUGUICurrentLevelText
		{
			[Token(Token = "0x600423D")]
			[Address(RVA = "0x41CA320", Offset = "0x41C6320", VA = "0x41CA320")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A9B")]
		public SkeletonGraphic SkeletonGraphicIconSpine
		{
			[Token(Token = "0x600423E")]
			[Address(RVA = "0x41CB290", Offset = "0x41C7290", VA = "0x41CB290")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600423F")]
		[Address(RVA = "0x41CB624", Offset = "0x41C7624", VA = "0x41CB624")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6004240")]
		[Address(RVA = "0x41CA5B0", Offset = "0x41C65B0", VA = "0x41CA5B0", Slot = "12")]
		protected virtual void OnButtonExtendSeasonPassEntranceBtnClicked()
		{
		}

		[Token(Token = "0x6004241")]
		[Address(RVA = "0x41C9DC4", Offset = "0x41C5DC4", VA = "0x41C9DC4", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6004242")]
		[Address(RVA = "0x41CA890", Offset = "0x41C6890", VA = "0x41CA890", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__225))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6004243")]
		[Address(RVA = "0x41CB6AC", Offset = "0x41C76AC", VA = "0x41CB6AC", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6004244")]
		[Address(RVA = "0x41CA750", Offset = "0x41C6750", VA = "0x41CA750")]
		public SeasonPassEntranceBtnComponents()
		{
		}
	}
}
