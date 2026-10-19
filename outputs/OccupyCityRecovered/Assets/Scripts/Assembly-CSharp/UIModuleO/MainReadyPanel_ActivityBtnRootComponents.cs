using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using UIFramework;
using UIModuleO.UIAnim;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000970")]
	public class MainReadyPanel_ActivityBtnRootComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000971")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__159 : IAsyncStateMachine
		{
			[Token(Token = "0x40046E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40046E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40046E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MainReadyPanel_ActivityBtnRootComponents _003C_003E4__this;

			[Token(Token = "0x40046E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x60037A1")]
			[Address(RVA = "0x40E69F0", Offset = "0x40E29F0", VA = "0x40E69F0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60037A2")]
			[Address(RVA = "0x40E6C68", Offset = "0x40E2C68", VA = "0x40E6C68", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40046DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RectTransform _rectTransformImgBg;

		[Token(Token = "0x40046DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Image _imageImgBg;

		[Token(Token = "0x40046DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private ButtonExtend _buttonExtendImgBg;

		[Token(Token = "0x40046DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private RectTransform _rectTransformContent;

		[Token(Token = "0x40046E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Image _imageWeeklyClashBtn;

		[Token(Token = "0x40046E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private ActivityBtn _activityBtnWeeklyClashBtn;

		[Token(Token = "0x40046E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private RectTransform _rectTransformIndicatorRoot;

		[Token(Token = "0x17000843")]
		public RectTransform RectTransformImgBg
		{
			[Token(Token = "0x6003793")]
			[Address(RVA = "0x40E5D28", Offset = "0x40E1D28", VA = "0x40E5D28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000844")]
		public Image ImageImgBg
		{
			[Token(Token = "0x6003794")]
			[Address(RVA = "0x40E3CB8", Offset = "0x40DFCB8", VA = "0x40E3CB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000845")]
		public ButtonExtend ButtonExtendImgBg
		{
			[Token(Token = "0x6003795")]
			[Address(RVA = "0x40E67E4", Offset = "0x40E27E4", VA = "0x40E67E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000846")]
		public RectTransform RectTransformContent
		{
			[Token(Token = "0x6003796")]
			[Address(RVA = "0x40E39D8", Offset = "0x40DF9D8", VA = "0x40E39D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000847")]
		public Image ImageWeeklyClashBtn
		{
			[Token(Token = "0x6003797")]
			[Address(RVA = "0x40E312C", Offset = "0x40DF12C", VA = "0x40E312C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000848")]
		public ActivityBtn ActivityBtnWeeklyClashBtn
		{
			[Token(Token = "0x6003798")]
			[Address(RVA = "0x40E31F4", Offset = "0x40DF1F4", VA = "0x40E31F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000849")]
		public RectTransform RectTransformIndicatorRoot
		{
			[Token(Token = "0x6003799")]
			[Address(RVA = "0x40E3D80", Offset = "0x40DFD80", VA = "0x40E3D80")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600379A")]
		[Address(RVA = "0x40E68AC", Offset = "0x40E28AC", VA = "0x40E68AC")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x600379B")]
		[Address(RVA = "0x40E4FB0", Offset = "0x40E0FB0", VA = "0x40E4FB0", Slot = "12")]
		protected virtual void OnButtonExtendImgBgClicked()
		{
		}

		[Token(Token = "0x600379C")]
		[Address(RVA = "0x40E5554", Offset = "0x40E1554", VA = "0x40E5554", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600379D")]
		[Address(RVA = "0x40E5574", Offset = "0x40E1574", VA = "0x40E5574", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__159))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x600379E")]
		[Address(RVA = "0x40E6934", Offset = "0x40E2934", VA = "0x40E6934", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x600379F")]
		[Address(RVA = "0x40E552C", Offset = "0x40E152C", VA = "0x40E552C")]
		public MainReadyPanel_ActivityBtnRootComponents()
		{
		}
	}
}
