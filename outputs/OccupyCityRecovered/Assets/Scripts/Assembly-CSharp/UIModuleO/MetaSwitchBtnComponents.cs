using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using BadgeGraph;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using GameModule;
using Il2CppDummyDll;
using Spine.Unity;
using TMPro;
using UIFramework;
using UIModuleO.UIAnim;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x200098F")]
	public class MetaSwitchBtnComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000990")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__162 : IAsyncStateMachine
		{
			[Token(Token = "0x400479B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400479C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400479D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MetaSwitchBtnComponents _003C_003E4__this;

			[Token(Token = "0x400479E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x60038A7")]
			[Address(RVA = "0x40F86F8", Offset = "0x40F46F8", VA = "0x40F86F8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60038A8")]
			[Address(RVA = "0x40F8970", Offset = "0x40F4970", VA = "0x40F8970", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400478E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ButtonExtend _buttonExtendMetaSwitchBtn;

		[Token(Token = "0x400478F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BadgeButton _badgeButtonMetaSwitchBtn;

		[Token(Token = "0x4004790")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private FeatureUnlockEntity _featureUnlockEntityMetaSwitchBtn;

		[Token(Token = "0x4004791")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Image _imageImgBG;

		[Token(Token = "0x4004792")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private RectTransform _rectTransformL;

		[Token(Token = "0x4004793")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Image _imageL;

		[Token(Token = "0x4004794")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private RectTransform _rectTransformR;

		[Token(Token = "0x4004795")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Image _imageR;

		[Token(Token = "0x4004796")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private TextMeshProUGUI _textMeshProUGUIText;

		[Token(Token = "0x4004797")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private RectTransform _rectTransformIcon;

		[Token(Token = "0x4004798")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Image _imageIcon;

		[Token(Token = "0x4004799")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private SkeletonGraphic _skeletonGraphicSkeletonGraphicIcon;

		[Token(Token = "0x400479A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private RectTransform _rectTransformLock;

		[Token(Token = "0x1700087A")]
		public ButtonExtend ButtonExtendMetaSwitchBtn
		{
			[Token(Token = "0x6003893")]
			[Address(RVA = "0x40F847C", Offset = "0x40F447C", VA = "0x40F847C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700087B")]
		public BadgeButton BadgeButtonMetaSwitchBtn
		{
			[Token(Token = "0x6003894")]
			[Address(RVA = "0x40F6BD8", Offset = "0x40F2BD8", VA = "0x40F6BD8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700087C")]
		public FeatureUnlockEntity FeatureUnlockEntityMetaSwitchBtn
		{
			[Token(Token = "0x6003895")]
			[Address(RVA = "0x40F6C7C", Offset = "0x40F2C7C", VA = "0x40F6C7C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700087D")]
		public Image ImageImgBG
		{
			[Token(Token = "0x6003896")]
			[Address(RVA = "0x40F6D98", Offset = "0x40F2D98", VA = "0x40F6D98")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700087E")]
		public RectTransform RectTransformL
		{
			[Token(Token = "0x6003897")]
			[Address(RVA = "0x40F6F28", Offset = "0x40F2F28", VA = "0x40F6F28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700087F")]
		public Image ImageL
		{
			[Token(Token = "0x6003898")]
			[Address(RVA = "0x40F70B8", Offset = "0x40F30B8", VA = "0x40F70B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000880")]
		public RectTransform RectTransformR
		{
			[Token(Token = "0x6003899")]
			[Address(RVA = "0x40F6FF0", Offset = "0x40F2FF0", VA = "0x40F6FF0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000881")]
		public Image ImageR
		{
			[Token(Token = "0x600389A")]
			[Address(RVA = "0x40F7180", Offset = "0x40F3180", VA = "0x40F7180")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000882")]
		public TextMeshProUGUI TextMeshProUGUIText
		{
			[Token(Token = "0x600389B")]
			[Address(RVA = "0x40F63C4", Offset = "0x40F23C4", VA = "0x40F63C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000883")]
		public RectTransform RectTransformIcon
		{
			[Token(Token = "0x600389C")]
			[Address(RVA = "0x40F79CC", Offset = "0x40F39CC", VA = "0x40F79CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000884")]
		public Image ImageIcon
		{
			[Token(Token = "0x600389D")]
			[Address(RVA = "0x40F6E60", Offset = "0x40F2E60", VA = "0x40F6E60")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000885")]
		public SkeletonGraphic SkeletonGraphicSkeletonGraphicIcon
		{
			[Token(Token = "0x600389E")]
			[Address(RVA = "0x40F83A8", Offset = "0x40F43A8", VA = "0x40F83A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000886")]
		public RectTransform RectTransformLock
		{
			[Token(Token = "0x600389F")]
			[Address(RVA = "0x40F6638", Offset = "0x40F2638", VA = "0x40F6638")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60038A0")]
		[Address(RVA = "0x40F8520", Offset = "0x40F4520", VA = "0x40F8520")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x60038A1")]
		[Address(RVA = "0x40F7960", Offset = "0x40F3960", VA = "0x40F7960", Slot = "12")]
		protected virtual void OnButtonExtendMetaSwitchBtnClicked()
		{
		}

		[Token(Token = "0x60038A2")]
		[Address(RVA = "0x40F6280", Offset = "0x40F2280", VA = "0x40F6280", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60038A3")]
		[Address(RVA = "0x40F85A8", Offset = "0x40F45A8", VA = "0x40F85A8", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__162))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60038A4")]
		[Address(RVA = "0x40F863C", Offset = "0x40F463C", VA = "0x40F863C", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x60038A5")]
		[Address(RVA = "0x40F7F1C", Offset = "0x40F3F1C", VA = "0x40F7F1C")]
		public MetaSwitchBtnComponents()
		{
		}
	}
}
