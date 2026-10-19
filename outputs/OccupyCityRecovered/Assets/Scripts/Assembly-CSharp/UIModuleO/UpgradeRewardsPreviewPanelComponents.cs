using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using SuperScrollView;
using TMPro;
using UIFramework;
using UIModuleO.UIAnim;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000BE9")]
	public class UpgradeRewardsPreviewPanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000BEA")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__366 : IAsyncStateMachine
		{
			[Token(Token = "0x4005660")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005661")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005662")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UpgradeRewardsPreviewPanelComponents _003C_003E4__this;

			[Token(Token = "0x4005663")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x60049A3")]
			[Address(RVA = "0x424BF38", Offset = "0x4247F38", VA = "0x424BF38", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60049A4")]
			[Address(RVA = "0x424C1B0", Offset = "0x42481B0", VA = "0x424C1B0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4005658")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Button _buttonBackground;

		[Token(Token = "0x4005659")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RectTransform _rectTransformContents;

		[Token(Token = "0x400565A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TextMeshProUGUI _textMeshProUGUITitle;

		[Token(Token = "0x400565B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private ButtonExtend _buttonExtendClose;

		[Token(Token = "0x400565C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private TextMeshProUGUI _textMeshProUGUIHitn;

		[Token(Token = "0x400565D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private ScrollRect _scrollRectScrollView;

		[Token(Token = "0x400565E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private LoopListView2 _loopListView2ScrollView;

		[Token(Token = "0x400565F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private ButtonExtend _buttonExtendReward;

		[Token(Token = "0x17000CD8")]
		public Button ButtonBackground
		{
			[Token(Token = "0x6004991")]
			[Address(RVA = "0x424B96C", Offset = "0x424796C", VA = "0x424B96C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CD9")]
		public RectTransform RectTransformContents
		{
			[Token(Token = "0x6004992")]
			[Address(RVA = "0x424A34C", Offset = "0x424634C", VA = "0x424A34C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CDA")]
		public TextMeshProUGUI TextMeshProUGUITitle
		{
			[Token(Token = "0x6004993")]
			[Address(RVA = "0x424B0F4", Offset = "0x42470F4", VA = "0x424B0F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CDB")]
		public ButtonExtend ButtonExtendClose
		{
			[Token(Token = "0x6004994")]
			[Address(RVA = "0x424BA34", Offset = "0x4247A34", VA = "0x424BA34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CDC")]
		public TextMeshProUGUI TextMeshProUGUIHitn
		{
			[Token(Token = "0x6004995")]
			[Address(RVA = "0x424B1BC", Offset = "0x42471BC", VA = "0x424B1BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CDD")]
		public ScrollRect ScrollRectScrollView
		{
			[Token(Token = "0x6004996")]
			[Address(RVA = "0x424BAFC", Offset = "0x4247AFC", VA = "0x424BAFC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CDE")]
		public LoopListView2 LoopListView2ScrollView
		{
			[Token(Token = "0x6004997")]
			[Address(RVA = "0x424A790", Offset = "0x4246790", VA = "0x424A790")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CDF")]
		public ButtonExtend ButtonExtendReward
		{
			[Token(Token = "0x6004998")]
			[Address(RVA = "0x424BBC4", Offset = "0x4247BC4", VA = "0x424BBC4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004999")]
		[Address(RVA = "0x424BC8C", Offset = "0x4247C8C", VA = "0x424BC8C")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x600499A")]
		[Address(RVA = "0x424A904", Offset = "0x4246904", VA = "0x424A904", Slot = "12")]
		protected virtual void OnButtonBackgroundClicked()
		{
		}

		[Token(Token = "0x600499B")]
		[Address(RVA = "0x424A878", Offset = "0x4246878", VA = "0x424A878", Slot = "13")]
		protected virtual void OnButtonExtendCloseClicked()
		{
		}

		[Token(Token = "0x600499C")]
		[Address(RVA = "0x424BE10", Offset = "0x4247E10", VA = "0x424BE10", Slot = "14")]
		protected virtual void OnScrollRectScrollViewValueChanged(Vector2 arg)
		{
		}

		[Token(Token = "0x600499D")]
		[Address(RVA = "0x424BEC4", Offset = "0x4247EC4", VA = "0x424BEC4", Slot = "15")]
		protected virtual void OnButtonExtendRewardClicked()
		{
		}

		[Token(Token = "0x600499E")]
		[Address(RVA = "0x424A330", Offset = "0x4246330", VA = "0x424A330", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600499F")]
		[Address(RVA = "0x424AAA8", Offset = "0x4246AA8", VA = "0x424AAA8", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__366))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60049A0")]
		[Address(RVA = "0x424A9E0", Offset = "0x42469E0", VA = "0x424A9E0", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x60049A1")]
		[Address(RVA = "0x424AA9C", Offset = "0x4246A9C", VA = "0x424AA9C")]
		public UpgradeRewardsPreviewPanelComponents()
		{
		}
	}
}
