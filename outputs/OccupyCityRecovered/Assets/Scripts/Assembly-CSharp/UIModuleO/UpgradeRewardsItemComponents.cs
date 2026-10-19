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
	[Token(Token = "0x2000BE3")]
	public class UpgradeRewardsItemComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000BE4")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__225 : IAsyncStateMachine
		{
			[Token(Token = "0x4005644")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005645")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005646")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UpgradeRewardsItemComponents _003C_003E4__this;

			[Token(Token = "0x4005647")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x600497D")]
			[Address(RVA = "0x4249FB8", Offset = "0x4245FB8", VA = "0x4249FB8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600497E")]
			[Address(RVA = "0x424A230", Offset = "0x4246230", VA = "0x424A230", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4005637")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Image _imageLevelBg;

		[Token(Token = "0x4005638")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TextMeshProUGUI _textMeshProUGUILevel;

		[Token(Token = "0x4005639")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private RectTransform _rectTransformUnlock;

		[Token(Token = "0x400563A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private RectTransform _rectTransformLock;

		[Token(Token = "0x400563B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Image _imageLockIcon;

		[Token(Token = "0x400563C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private TextMeshProUGUI _textMeshProUGUIRewardName;

		[Token(Token = "0x400563D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private ButtonExtend _buttonExtendReward;

		[Token(Token = "0x400563E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private SkeletonGraphic _skeletonGraphicRewardSpine;

		[Token(Token = "0x400563F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private RectTransform _rectTransformRewardIcon;

		[Token(Token = "0x4005640")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Image _imageRewardIcon;

		[Token(Token = "0x4005641")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private RectTransform _rectTransformRedDot_UI;

		[Token(Token = "0x4005642")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private RectTransform _rectTransformCardHint;

		[Token(Token = "0x4005643")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Image _imageIsGet;

		[Token(Token = "0x17000CCB")]
		public Image ImageLevelBg
		{
			[Token(Token = "0x6004969")]
			[Address(RVA = "0x424803C", Offset = "0x424403C", VA = "0x424803C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CCC")]
		public TextMeshProUGUI TextMeshProUGUILevel
		{
			[Token(Token = "0x600496A")]
			[Address(RVA = "0x4247DE4", Offset = "0x4243DE4", VA = "0x4247DE4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CCD")]
		public RectTransform RectTransformUnlock
		{
			[Token(Token = "0x600496B")]
			[Address(RVA = "0x42477DC", Offset = "0x42437DC", VA = "0x42477DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CCE")]
		public RectTransform RectTransformLock
		{
			[Token(Token = "0x600496C")]
			[Address(RVA = "0x42478A4", Offset = "0x42438A4", VA = "0x42478A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CCF")]
		public Image ImageLockIcon
		{
			[Token(Token = "0x600496D")]
			[Address(RVA = "0x4247F74", Offset = "0x4243F74", VA = "0x4247F74")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CD0")]
		public TextMeshProUGUI TextMeshProUGUIRewardName
		{
			[Token(Token = "0x600496E")]
			[Address(RVA = "0x4247EAC", Offset = "0x4243EAC", VA = "0x4247EAC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CD1")]
		public ButtonExtend ButtonExtendReward
		{
			[Token(Token = "0x600496F")]
			[Address(RVA = "0x4249CFC", Offset = "0x4245CFC", VA = "0x4249CFC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CD2")]
		public SkeletonGraphic SkeletonGraphicRewardSpine
		{
			[Token(Token = "0x6004970")]
			[Address(RVA = "0x4247BC4", Offset = "0x4243BC4", VA = "0x4247BC4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CD3")]
		public RectTransform RectTransformRewardIcon
		{
			[Token(Token = "0x6004971")]
			[Address(RVA = "0x4247714", Offset = "0x4243714", VA = "0x4247714")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CD4")]
		public Image ImageRewardIcon
		{
			[Token(Token = "0x6004972")]
			[Address(RVA = "0x4247AFC", Offset = "0x4243AFC", VA = "0x4247AFC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CD5")]
		public RectTransform RectTransformRedDot_UI
		{
			[Token(Token = "0x6004973")]
			[Address(RVA = "0x424764C", Offset = "0x424364C", VA = "0x424764C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CD6")]
		public RectTransform RectTransformCardHint
		{
			[Token(Token = "0x6004974")]
			[Address(RVA = "0x4247A34", Offset = "0x4243A34", VA = "0x4247A34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CD7")]
		public Image ImageIsGet
		{
			[Token(Token = "0x6004975")]
			[Address(RVA = "0x424796C", Offset = "0x424396C", VA = "0x424796C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004976")]
		[Address(RVA = "0x4249DC4", Offset = "0x4245DC4", VA = "0x4249DC4")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6004977")]
		[Address(RVA = "0x4248258", Offset = "0x4244258", VA = "0x4248258", Slot = "12")]
		protected virtual void OnButtonExtendRewardClicked()
		{
		}

		[Token(Token = "0x6004978")]
		[Address(RVA = "0x4249E4C", Offset = "0x4245E4C", VA = "0x4249E4C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6004979")]
		[Address(RVA = "0x4249E68", Offset = "0x4245E68", VA = "0x4249E68", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__225))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x600497A")]
		[Address(RVA = "0x4249EFC", Offset = "0x4245EFC", VA = "0x4249EFC", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x600497B")]
		[Address(RVA = "0x4248634", Offset = "0x4244634", VA = "0x4248634")]
		public UpgradeRewardsItemComponents()
		{
		}
	}
}
