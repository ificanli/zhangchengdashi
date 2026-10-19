using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using Spine.Unity;
using SuperScrollView;
using TMPro;
using UIFramework;
using UIModuleO.UIAnim;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x20007F9")]
	public class AllNewArtifactViewComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20007FA")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__774 : IAsyncStateMachine
		{
			[Token(Token = "0x4003D5D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003D5E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003D5F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public AllNewArtifactViewComponents _003C_003E4__this;

			[Token(Token = "0x4003D60")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6002C95")]
			[Address(RVA = "0x4000250", Offset = "0x3FFC250", VA = "0x4000250", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002C96")]
			[Address(RVA = "0x40004C8", Offset = "0x3FFC4C8", VA = "0x40004C8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003D41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private SkeletonGraphic _skeletonGraphicArtifactIQualitySkeletonGraphic;

		[Token(Token = "0x4003D42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TextMeshProUGUI _textMeshProUGUIArtifactName;

		[Token(Token = "0x4003D43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Image _imageArtifactICon;

		[Token(Token = "0x4003D44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private ButtonExtend _buttonExtendArtifactICon;

		[Token(Token = "0x4003D45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private TextMeshProUGUI _textMeshProUGUIArtifactLevel;

		[Token(Token = "0x4003D46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private TextMeshProUGUI _textMeshProUGUIArtifactSkillDes;

		[Token(Token = "0x4003D47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private ButtonExtend _buttonExtendSummonBtn;

		[Token(Token = "0x4003D48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private RectTransform _rectTransformForgeList;

		[Token(Token = "0x4003D49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private ArtifactStarLevelUI _artifactStarLevelUIArtifactStarLevelUI;

		[Token(Token = "0x4003D4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private ButtonExtend _buttonExtendStarupgradeButton;

		[Token(Token = "0x4003D4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private RectTransform _rectTransformEquipRedDot;

		[Token(Token = "0x4003D4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private TextMeshProUGUI _textMeshProUGUIPowerNum;

		[Token(Token = "0x4003D4D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private TextMeshProUGUI _textMeshProUGUIAttrTypeText;

		[Token(Token = "0x4003D4E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private TextMeshProUGUI _textMeshProUGUIAttrValue;

		[Token(Token = "0x4003D4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private TextMeshProUGUI _textMeshProUGUIAttrTypeText1;

		[Token(Token = "0x4003D50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private TextMeshProUGUI _textMeshProUGUIAttrValue1;

		[Token(Token = "0x4003D51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private TextMeshProUGUI _textMeshProUGUIAttrTypeText2;

		[Token(Token = "0x4003D52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private TextMeshProUGUI _textMeshProUGUIAttrValue2;

		[Token(Token = "0x4003D53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private TextMeshProUGUI _textMeshProUGUIAttrTypeText3;

		[Token(Token = "0x4003D54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private TextMeshProUGUI _textMeshProUGUIAttrValue3;

		[Token(Token = "0x4003D55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private ButtonExtend _buttonExtendAllAttrBtn;

		[Token(Token = "0x4003D56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private ScrollRect _scrollRectScrollView;

		[Token(Token = "0x4003D57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private LoopGridView _loopGridViewScrollView;

		[Token(Token = "0x4003D58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private RectTransform _rectTransformAllAttrPanel;

		[Token(Token = "0x4003D59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Button _buttonAllAttrMask;

		[Token(Token = "0x4003D5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Button _buttonBtnCloseAllAttrPanel;

		[Token(Token = "0x4003D5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private RectTransform _rectTransformAllAttrGroup;

		[Token(Token = "0x4003D5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private PropAttrItem _propAttrItemPropAttrItem;

		[Token(Token = "0x170004D8")]
		public SkeletonGraphic SkeletonGraphicArtifactIQualitySkeletonGraphic
		{
			[Token(Token = "0x6002C6C")]
			[Address(RVA = "0x3FFE0E8", Offset = "0x3FFA0E8", VA = "0x3FFE0E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004D9")]
		public TextMeshProUGUI TextMeshProUGUIArtifactName
		{
			[Token(Token = "0x6002C6D")]
			[Address(RVA = "0x3FFCF04", Offset = "0x3FF8F04", VA = "0x3FFCF04")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004DA")]
		public Image ImageArtifactICon
		{
			[Token(Token = "0x6002C6E")]
			[Address(RVA = "0x3FF8FE8", Offset = "0x3FF4FE8", VA = "0x3FF8FE8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004DB")]
		public ButtonExtend ButtonExtendArtifactICon
		{
			[Token(Token = "0x6002C6F")]
			[Address(RVA = "0x3FFF0E4", Offset = "0x3FFB0E4", VA = "0x3FFF0E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004DC")]
		public TextMeshProUGUI TextMeshProUGUIArtifactLevel
		{
			[Token(Token = "0x6002C70")]
			[Address(RVA = "0x3FFD094", Offset = "0x3FF9094", VA = "0x3FFD094")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004DD")]
		public TextMeshProUGUI TextMeshProUGUIArtifactSkillDes
		{
			[Token(Token = "0x6002C71")]
			[Address(RVA = "0x3FFCFCC", Offset = "0x3FF8FCC", VA = "0x3FFCFCC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004DE")]
		public ButtonExtend ButtonExtendSummonBtn
		{
			[Token(Token = "0x6002C72")]
			[Address(RVA = "0x3FFF1AC", Offset = "0x3FFB1AC", VA = "0x3FFF1AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004DF")]
		public RectTransform RectTransformForgeList
		{
			[Token(Token = "0x6002C73")]
			[Address(RVA = "0x3FFDAC8", Offset = "0x3FF9AC8", VA = "0x3FFDAC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004E0")]
		public ArtifactStarLevelUI ArtifactStarLevelUIArtifactStarLevelUI
		{
			[Token(Token = "0x6002C74")]
			[Address(RVA = "0x3FF8810", Offset = "0x3FF4810", VA = "0x3FF8810")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004E1")]
		public ButtonExtend ButtonExtendStarupgradeButton
		{
			[Token(Token = "0x6002C75")]
			[Address(RVA = "0x3FFF274", Offset = "0x3FFB274", VA = "0x3FFF274")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004E2")]
		public RectTransform RectTransformEquipRedDot
		{
			[Token(Token = "0x6002C76")]
			[Address(RVA = "0x3FF88D8", Offset = "0x3FF48D8", VA = "0x3FF88D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004E3")]
		public TextMeshProUGUI TextMeshProUGUIPowerNum
		{
			[Token(Token = "0x6002C77")]
			[Address(RVA = "0x3FFC0A4", Offset = "0x3FF80A4", VA = "0x3FFC0A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004E4")]
		public TextMeshProUGUI TextMeshProUGUIAttrTypeText
		{
			[Token(Token = "0x6002C78")]
			[Address(RVA = "0x3FF9B78", Offset = "0x3FF5B78", VA = "0x3FF9B78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004E5")]
		public TextMeshProUGUI TextMeshProUGUIAttrValue
		{
			[Token(Token = "0x6002C79")]
			[Address(RVA = "0x3FF9E98", Offset = "0x3FF5E98", VA = "0x3FF9E98")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004E6")]
		public TextMeshProUGUI TextMeshProUGUIAttrTypeText1
		{
			[Token(Token = "0x6002C7A")]
			[Address(RVA = "0x3FF9C40", Offset = "0x3FF5C40", VA = "0x3FF9C40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004E7")]
		public TextMeshProUGUI TextMeshProUGUIAttrValue1
		{
			[Token(Token = "0x6002C7B")]
			[Address(RVA = "0x3FF9F60", Offset = "0x3FF5F60", VA = "0x3FF9F60")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004E8")]
		public TextMeshProUGUI TextMeshProUGUIAttrTypeText2
		{
			[Token(Token = "0x6002C7C")]
			[Address(RVA = "0x3FF9D08", Offset = "0x3FF5D08", VA = "0x3FF9D08")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004E9")]
		public TextMeshProUGUI TextMeshProUGUIAttrValue2
		{
			[Token(Token = "0x6002C7D")]
			[Address(RVA = "0x3FFA028", Offset = "0x3FF6028", VA = "0x3FFA028")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004EA")]
		public TextMeshProUGUI TextMeshProUGUIAttrTypeText3
		{
			[Token(Token = "0x6002C7E")]
			[Address(RVA = "0x3FF9DD0", Offset = "0x3FF5DD0", VA = "0x3FF9DD0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004EB")]
		public TextMeshProUGUI TextMeshProUGUIAttrValue3
		{
			[Token(Token = "0x6002C7F")]
			[Address(RVA = "0x3FFA0F0", Offset = "0x3FF60F0", VA = "0x3FFA0F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004EC")]
		public ButtonExtend ButtonExtendAllAttrBtn
		{
			[Token(Token = "0x6002C80")]
			[Address(RVA = "0x3FFF33C", Offset = "0x3FFB33C", VA = "0x3FFF33C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004ED")]
		public ScrollRect ScrollRectScrollView
		{
			[Token(Token = "0x6002C81")]
			[Address(RVA = "0x3FFB980", Offset = "0x3FF7980", VA = "0x3FFB980")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004EE")]
		public LoopGridView LoopGridViewScrollView
		{
			[Token(Token = "0x6002C82")]
			[Address(RVA = "0x3FFB8B8", Offset = "0x3FF78B8", VA = "0x3FFB8B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004EF")]
		public RectTransform RectTransformAllAttrPanel
		{
			[Token(Token = "0x6002C83")]
			[Address(RVA = "0x3FFA474", Offset = "0x3FF6474", VA = "0x3FFA474")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004F0")]
		public Button ButtonAllAttrMask
		{
			[Token(Token = "0x6002C84")]
			[Address(RVA = "0x3FFF404", Offset = "0x3FFB404", VA = "0x3FFF404")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004F1")]
		public Button ButtonBtnCloseAllAttrPanel
		{
			[Token(Token = "0x6002C85")]
			[Address(RVA = "0x3FFF4CC", Offset = "0x3FFB4CC", VA = "0x3FFF4CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004F2")]
		public RectTransform RectTransformAllAttrGroup
		{
			[Token(Token = "0x6002C86")]
			[Address(RVA = "0x3FFA280", Offset = "0x3FF6280", VA = "0x3FFA280")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004F3")]
		public PropAttrItem PropAttrItemPropAttrItem
		{
			[Token(Token = "0x6002C87")]
			[Address(RVA = "0x3FFA1B8", Offset = "0x3FF61B8", VA = "0x3FFA1B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002C88")]
		[Address(RVA = "0x3FFF594", Offset = "0x3FFB594", VA = "0x3FFF594")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6002C89")]
		[Address(RVA = "0x3FFA864", Offset = "0x3FF6864", VA = "0x3FFA864", Slot = "12")]
		protected virtual void OnButtonExtendArtifactIConClicked()
		{
		}

		[Token(Token = "0x6002C8A")]
		[Address(RVA = "0x3FF9190", Offset = "0x3FF5190", VA = "0x3FF9190", Slot = "13")]
		protected virtual void OnButtonExtendSummonBtnClicked()
		{
		}

		[Token(Token = "0x6002C8B")]
		[Address(RVA = "0x3FFA8D4", Offset = "0x3FF68D4", VA = "0x3FFA8D4", Slot = "14")]
		protected virtual void OnButtonExtendStarupgradeButtonClicked()
		{
		}

		[Token(Token = "0x6002C8C")]
		[Address(RVA = "0x3FFA408", Offset = "0x3FF6408", VA = "0x3FFA408", Slot = "15")]
		protected virtual void OnButtonExtendAllAttrBtnClicked()
		{
		}

		[Token(Token = "0x6002C8D")]
		[Address(RVA = "0x3FFF7E4", Offset = "0x3FFB7E4", VA = "0x3FFF7E4", Slot = "16")]
		protected virtual void OnScrollRectScrollViewValueChanged(Vector2 arg)
		{
		}

		[Token(Token = "0x6002C8E")]
		[Address(RVA = "0x3FFA574", Offset = "0x3FF6574", VA = "0x3FFA574", Slot = "17")]
		protected virtual void OnButtonAllAttrMaskClicked()
		{
		}

		[Token(Token = "0x6002C8F")]
		[Address(RVA = "0x3FFA618", Offset = "0x3FF6618", VA = "0x3FFA618", Slot = "18")]
		protected virtual void OnButtonBtnCloseAllAttrPanelClicked()
		{
		}

		[Token(Token = "0x6002C90")]
		[Address(RVA = "0x3FFA798", Offset = "0x3FF6798", VA = "0x3FFA798", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6002C91")]
		[Address(RVA = "0x3FFA7B8", Offset = "0x3FF67B8", VA = "0x3FFA7B8", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__774))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6002C92")]
		[Address(RVA = "0x3FF851C", Offset = "0x3FF451C", VA = "0x3FF851C", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6002C93")]
		[Address(RVA = "0x3FFA774", Offset = "0x3FF6774", VA = "0x3FFA774")]
		public AllNewArtifactViewComponents()
		{
		}
	}
}
