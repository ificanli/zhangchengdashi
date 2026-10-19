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
	[Token(Token = "0x20006E0")]
	public class ArtifactStarUpPanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20006E1")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__1268 : IAsyncStateMachine
		{
			[Token(Token = "0x40036FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40036FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40036FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ArtifactStarUpPanelComponents _003C_003E4__this;

			[Token(Token = "0x40036FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6002516")]
			[Address(RVA = "0x3F65D60", Offset = "0x3F61D60", VA = "0x3F65D60", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002517")]
			[Address(RVA = "0x3F65FD8", Offset = "0x3F61FD8", VA = "0x3F65FD8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40036EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ButtonExtend _buttonExtendBlackBG;

		[Token(Token = "0x40036EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RectTransform _rectTransformBG;

		[Token(Token = "0x40036EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private SkeletonGraphic _skeletonGraphicQualitySkeletonGraphic;

		[Token(Token = "0x40036ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private ButtonExtend _buttonExtendCloseBtn;

		[Token(Token = "0x40036EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Image _imageIcon;

		[Token(Token = "0x40036EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private TextMeshProUGUI _textMeshProUGUIArtifactName;

		[Token(Token = "0x40036F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private TextMeshProUGUI _textMeshProUGUILevel;

		[Token(Token = "0x40036F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private RectTransform _rectTransformAttrList;

		[Token(Token = "0x40036F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private PropDetailAttrItem _propDetailAttrItemPropDetailAttrItem;

		[Token(Token = "0x40036F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private TextMeshProUGUI _textMeshProUGUIOldSkillText;

		[Token(Token = "0x40036F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private TextMeshProUGUI _textMeshProUGUIStartLevel;

		[Token(Token = "0x40036F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private ArtifactStarLevelUI _artifactStarLevelUIArtifactStarLevelUI;

		[Token(Token = "0x40036F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Image _imageImgPropProgress;

		[Token(Token = "0x40036F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private TextMeshProUGUI _textMeshProUGUITxtPropProgress;

		[Token(Token = "0x40036F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private RectTransform _rectTransformStarUp;

		[Token(Token = "0x40036F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private ButtonExtend _buttonExtendStarUp;

		[Token(Token = "0x40036FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Image _imageUpIcon;

		[Token(Token = "0x17000293")]
		public ButtonExtend ButtonExtendBlackBG
		{
			[Token(Token = "0x60024FC")]
			[Address(RVA = "0x3F659E8", Offset = "0x3F619E8", VA = "0x3F659E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000294")]
		public RectTransform RectTransformBG
		{
			[Token(Token = "0x60024FD")]
			[Address(RVA = "0x3F62064", Offset = "0x3F5E064", VA = "0x3F62064")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000295")]
		public SkeletonGraphic SkeletonGraphicQualitySkeletonGraphic
		{
			[Token(Token = "0x60024FE")]
			[Address(RVA = "0x3F63F4C", Offset = "0x3F5FF4C", VA = "0x3F63F4C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000296")]
		public ButtonExtend ButtonExtendCloseBtn
		{
			[Token(Token = "0x60024FF")]
			[Address(RVA = "0x3F65AB0", Offset = "0x3F61AB0", VA = "0x3F65AB0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000297")]
		public Image ImageIcon
		{
			[Token(Token = "0x6002500")]
			[Address(RVA = "0x3F6212C", Offset = "0x3F5E12C", VA = "0x3F6212C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000298")]
		public TextMeshProUGUI TextMeshProUGUIArtifactName
		{
			[Token(Token = "0x6002501")]
			[Address(RVA = "0x3F64C90", Offset = "0x3F60C90", VA = "0x3F64C90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000299")]
		public TextMeshProUGUI TextMeshProUGUILevel
		{
			[Token(Token = "0x6002502")]
			[Address(RVA = "0x3F64D58", Offset = "0x3F60D58", VA = "0x3F64D58")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700029A")]
		public RectTransform RectTransformAttrList
		{
			[Token(Token = "0x6002503")]
			[Address(RVA = "0x3F630E4", Offset = "0x3F5F0E4", VA = "0x3F630E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700029B")]
		public PropDetailAttrItem PropDetailAttrItemPropDetailAttrItem
		{
			[Token(Token = "0x6002504")]
			[Address(RVA = "0x3F6301C", Offset = "0x3F5F01C", VA = "0x3F6301C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700029C")]
		public TextMeshProUGUI TextMeshProUGUIOldSkillText
		{
			[Token(Token = "0x6002505")]
			[Address(RVA = "0x3F64E20", Offset = "0x3F60E20", VA = "0x3F64E20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700029D")]
		public TextMeshProUGUI TextMeshProUGUIStartLevel
		{
			[Token(Token = "0x6002506")]
			[Address(RVA = "0x3F64EE8", Offset = "0x3F60EE8", VA = "0x3F64EE8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700029E")]
		public ArtifactStarLevelUI ArtifactStarLevelUIArtifactStarLevelUI
		{
			[Token(Token = "0x6002507")]
			[Address(RVA = "0x3F6392C", Offset = "0x3F5F92C", VA = "0x3F6392C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700029F")]
		public Image ImageImgPropProgress
		{
			[Token(Token = "0x6002508")]
			[Address(RVA = "0x3F65078", Offset = "0x3F61078", VA = "0x3F65078")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002A0")]
		public TextMeshProUGUI TextMeshProUGUITxtPropProgress
		{
			[Token(Token = "0x6002509")]
			[Address(RVA = "0x3F64FB0", Offset = "0x3F60FB0", VA = "0x3F64FB0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002A1")]
		public RectTransform RectTransformStarUp
		{
			[Token(Token = "0x600250A")]
			[Address(RVA = "0x3F65140", Offset = "0x3F61140", VA = "0x3F65140")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002A2")]
		public ButtonExtend ButtonExtendStarUp
		{
			[Token(Token = "0x600250B")]
			[Address(RVA = "0x3F65B78", Offset = "0x3F61B78", VA = "0x3F65B78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002A3")]
		public Image ImageUpIcon
		{
			[Token(Token = "0x600250C")]
			[Address(RVA = "0x3F65208", Offset = "0x3F61208", VA = "0x3F65208")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600250D")]
		[Address(RVA = "0x3F65C40", Offset = "0x3F61C40", VA = "0x3F65C40")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x600250E")]
		[Address(RVA = "0x3F6233C", Offset = "0x3F5E33C", VA = "0x3F6233C", Slot = "12")]
		protected virtual void OnButtonExtendBlackBGClicked()
		{
		}

		[Token(Token = "0x600250F")]
		[Address(RVA = "0x3F622B0", Offset = "0x3F5E2B0", VA = "0x3F622B0", Slot = "13")]
		protected virtual void OnButtonExtendCloseBtnClicked()
		{
		}

		[Token(Token = "0x6002510")]
		[Address(RVA = "0x3F632CC", Offset = "0x3F5F2CC", VA = "0x3F632CC", Slot = "14")]
		protected virtual void OnButtonExtendStarUpClicked()
		{
		}

		[Token(Token = "0x6002511")]
		[Address(RVA = "0x3F62048", Offset = "0x3F5E048", VA = "0x3F62048", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6002512")]
		[Address(RVA = "0x3F63234", Offset = "0x3F5F234", VA = "0x3F63234", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__1268))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6002513")]
		[Address(RVA = "0x3F625D8", Offset = "0x3F5E5D8", VA = "0x3F625D8", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6002514")]
		[Address(RVA = "0x3F63228", Offset = "0x3F5F228", VA = "0x3F63228")]
		public ArtifactStarUpPanelComponents()
		{
		}
	}
}
