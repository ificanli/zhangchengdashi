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
	[Token(Token = "0x20006CB")]
	public class ArtifactDetailsPanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20006CC")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__701 : IAsyncStateMachine
		{
			[Token(Token = "0x400366B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400366C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400366D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ArtifactDetailsPanelComponents _003C_003E4__this;

			[Token(Token = "0x400366E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6002470")]
			[Address(RVA = "0x3F5B03C", Offset = "0x3F5703C", VA = "0x3F5B03C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002471")]
			[Address(RVA = "0x3F5B2B4", Offset = "0x3F572B4", VA = "0x3F5B2B4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400364A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Button _buttonBackground;

		[Token(Token = "0x400364B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RectTransform _rectTransformContent;

		[Token(Token = "0x400364C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private SkeletonGraphic _skeletonGraphicArtifactSkeletonGraphic;

		[Token(Token = "0x400364D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private ButtonExtend _buttonExtendClose;

		[Token(Token = "0x400364E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Image _imageArtifactIcon;

		[Token(Token = "0x400364F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private TextMeshProUGUI _textMeshProUGUIArtifactName;

		[Token(Token = "0x4003650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private TextMeshProUGUI _textMeshProUGUIArtifactLevel;

		[Token(Token = "0x4003651")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private TextMeshProUGUI _textMeshProUGUIPowerNum;

		[Token(Token = "0x4003652")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private RectTransform _rectTransformStarUpgrade;

		[Token(Token = "0x4003653")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private ButtonExtend _buttonExtendStarUpgrade;

		[Token(Token = "0x4003654")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private RectTransform _rectTransformStarUpgradeRedDot_UI;

		[Token(Token = "0x4003655")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private ArtifactStarLevelUI _artifactStarLevelUIArtifactStarLevelUI;

		[Token(Token = "0x4003656")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Image _imageProgress;

		[Token(Token = "0x4003657")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private TextMeshProUGUI _textMeshProUGUIProgressText;

		[Token(Token = "0x4003658")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private RectTransform _rectTransformAttrList;

		[Token(Token = "0x4003659")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private PropDetailAttrItem _propDetailAttrItemPropDetailAttrItem;

		[Token(Token = "0x400365A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private TextMeshProUGUI _textMeshProUGUIArtifactIntroduce;

		[Token(Token = "0x400365B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private ForgingDetailsItem _forgingDetailsItemForgingDetailsItem1;

		[Token(Token = "0x400365C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private ButtonExtend _buttonExtendRefresh;

		[Token(Token = "0x400365D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private ForgingDetailsItem _forgingDetailsItemForgingDetailsItem2;

		[Token(Token = "0x400365E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private ButtonExtend _buttonExtendRefresh1;

		[Token(Token = "0x400365F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private ForgingDetailsItem _forgingDetailsItemForgingDetailsItem3;

		[Token(Token = "0x4003660")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private ButtonExtend _buttonExtendRefresh2;

		[Token(Token = "0x4003661")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private RectTransform _rectTransformUpgrade;

		[Token(Token = "0x4003662")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private ButtonExtend _buttonExtendUpgrade;

		[Token(Token = "0x4003663")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private TextMeshProUGUI _textMeshProUGUIUpgradeText;

		[Token(Token = "0x4003664")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private TextMeshProUGUI _textMeshProUGUIConsumeText;

		[Token(Token = "0x4003665")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private RectTransform _rectTransformUpgradearrow;

		[Token(Token = "0x4003666")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private RectTransform _rectTransformEquip;

		[Token(Token = "0x4003667")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private ButtonExtend _buttonExtendEquip;

		[Token(Token = "0x4003668")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private TextMeshProUGUI _textMeshProUGUIEquipText;

		[Token(Token = "0x4003669")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private RectTransform _rectTransformGoGetBtn;

		[Token(Token = "0x400366A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private ButtonExtend _buttonExtendGoGetBtn;

		[Token(Token = "0x17000259")]
		public Button ButtonBackground
		{
			[Token(Token = "0x6002440")]
			[Address(RVA = "0x3F5A538", Offset = "0x3F56538", VA = "0x3F5A538")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700025A")]
		public RectTransform RectTransformContent
		{
			[Token(Token = "0x6002441")]
			[Address(RVA = "0x3F5505C", Offset = "0x3F5105C", VA = "0x3F5505C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700025B")]
		public SkeletonGraphic SkeletonGraphicArtifactSkeletonGraphic
		{
			[Token(Token = "0x6002442")]
			[Address(RVA = "0x3F58180", Offset = "0x3F54180", VA = "0x3F58180")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700025C")]
		public ButtonExtend ButtonExtendClose
		{
			[Token(Token = "0x6002443")]
			[Address(RVA = "0x3F5A600", Offset = "0x3F56600", VA = "0x3F5A600")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700025D")]
		public Image ImageArtifactIcon
		{
			[Token(Token = "0x6002444")]
			[Address(RVA = "0x3F55124", Offset = "0x3F51124", VA = "0x3F55124")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700025E")]
		public TextMeshProUGUI TextMeshProUGUIArtifactName
		{
			[Token(Token = "0x6002445")]
			[Address(RVA = "0x3F59D5C", Offset = "0x3F55D5C", VA = "0x3F59D5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700025F")]
		public TextMeshProUGUI TextMeshProUGUIArtifactLevel
		{
			[Token(Token = "0x6002446")]
			[Address(RVA = "0x3F59E24", Offset = "0x3F55E24", VA = "0x3F59E24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000260")]
		public TextMeshProUGUI TextMeshProUGUIPowerNum
		{
			[Token(Token = "0x6002447")]
			[Address(RVA = "0x3F56B9C", Offset = "0x3F52B9C", VA = "0x3F56B9C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000261")]
		public RectTransform RectTransformStarUpgrade
		{
			[Token(Token = "0x6002448")]
			[Address(RVA = "0x3F5A20C", Offset = "0x3F5620C", VA = "0x3F5A20C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000262")]
		public ButtonExtend ButtonExtendStarUpgrade
		{
			[Token(Token = "0x6002449")]
			[Address(RVA = "0x3F5A6C8", Offset = "0x3F566C8", VA = "0x3F5A6C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000263")]
		public RectTransform RectTransformStarUpgradeRedDot_UI
		{
			[Token(Token = "0x600244A")]
			[Address(RVA = "0x3F59FB4", Offset = "0x3F55FB4", VA = "0x3F59FB4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000264")]
		public ArtifactStarLevelUI ArtifactStarLevelUIArtifactStarLevelUI
		{
			[Token(Token = "0x600244B")]
			[Address(RVA = "0x3F59EEC", Offset = "0x3F55EEC", VA = "0x3F59EEC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000265")]
		public Image ImageProgress
		{
			[Token(Token = "0x600244C")]
			[Address(RVA = "0x3F55514", Offset = "0x3F51514", VA = "0x3F55514")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000266")]
		public TextMeshProUGUI TextMeshProUGUIProgressText
		{
			[Token(Token = "0x600244D")]
			[Address(RVA = "0x3F555DC", Offset = "0x3F515DC", VA = "0x3F555DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000267")]
		public RectTransform RectTransformAttrList
		{
			[Token(Token = "0x600244E")]
			[Address(RVA = "0x3F56A38", Offset = "0x3F52A38", VA = "0x3F56A38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000268")]
		public PropDetailAttrItem PropDetailAttrItemPropDetailAttrItem
		{
			[Token(Token = "0x600244F")]
			[Address(RVA = "0x3F56970", Offset = "0x3F52970", VA = "0x3F56970")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000269")]
		public TextMeshProUGUI TextMeshProUGUIArtifactIntroduce
		{
			[Token(Token = "0x6002450")]
			[Address(RVA = "0x3F59C94", Offset = "0x3F55C94", VA = "0x3F59C94")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700026A")]
		public ForgingDetailsItem ForgingDetailsItemForgingDetailsItem1
		{
			[Token(Token = "0x6002451")]
			[Address(RVA = "0x3F579D0", Offset = "0x3F539D0", VA = "0x3F579D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700026B")]
		public ButtonExtend ButtonExtendRefresh
		{
			[Token(Token = "0x6002452")]
			[Address(RVA = "0x3F5A790", Offset = "0x3F56790", VA = "0x3F5A790")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700026C")]
		public ForgingDetailsItem ForgingDetailsItemForgingDetailsItem2
		{
			[Token(Token = "0x6002453")]
			[Address(RVA = "0x3F57A98", Offset = "0x3F53A98", VA = "0x3F57A98")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700026D")]
		public ButtonExtend ButtonExtendRefresh1
		{
			[Token(Token = "0x6002454")]
			[Address(RVA = "0x3F5A858", Offset = "0x3F56858", VA = "0x3F5A858")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700026E")]
		public ForgingDetailsItem ForgingDetailsItemForgingDetailsItem3
		{
			[Token(Token = "0x6002455")]
			[Address(RVA = "0x3F57B60", Offset = "0x3F53B60", VA = "0x3F57B60")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700026F")]
		public ButtonExtend ButtonExtendRefresh2
		{
			[Token(Token = "0x6002456")]
			[Address(RVA = "0x3F5A920", Offset = "0x3F56920", VA = "0x3F5A920")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000270")]
		public RectTransform RectTransformUpgrade
		{
			[Token(Token = "0x6002457")]
			[Address(RVA = "0x3F5A2D4", Offset = "0x3F562D4", VA = "0x3F5A2D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000271")]
		public ButtonExtend ButtonExtendUpgrade
		{
			[Token(Token = "0x6002458")]
			[Address(RVA = "0x3F5A9E8", Offset = "0x3F569E8", VA = "0x3F5A9E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000272")]
		public TextMeshProUGUI TextMeshProUGUIUpgradeText
		{
			[Token(Token = "0x6002459")]
			[Address(RVA = "0x3F59B04", Offset = "0x3F55B04", VA = "0x3F59B04")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000273")]
		public TextMeshProUGUI TextMeshProUGUIConsumeText
		{
			[Token(Token = "0x600245A")]
			[Address(RVA = "0x3F5A39C", Offset = "0x3F5639C", VA = "0x3F5A39C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000274")]
		public RectTransform RectTransformUpgradearrow
		{
			[Token(Token = "0x600245B")]
			[Address(RVA = "0x3F5A464", Offset = "0x3F56464", VA = "0x3F5A464")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000275")]
		public RectTransform RectTransformEquip
		{
			[Token(Token = "0x600245C")]
			[Address(RVA = "0x3F5A144", Offset = "0x3F56144", VA = "0x3F5A144")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000276")]
		public ButtonExtend ButtonExtendEquip
		{
			[Token(Token = "0x600245D")]
			[Address(RVA = "0x3F5AAB0", Offset = "0x3F56AB0", VA = "0x3F5AAB0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000277")]
		public TextMeshProUGUI TextMeshProUGUIEquipText
		{
			[Token(Token = "0x600245E")]
			[Address(RVA = "0x3F59BCC", Offset = "0x3F55BCC", VA = "0x3F59BCC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000278")]
		public RectTransform RectTransformGoGetBtn
		{
			[Token(Token = "0x600245F")]
			[Address(RVA = "0x3F5A07C", Offset = "0x3F5607C", VA = "0x3F5A07C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000279")]
		public ButtonExtend ButtonExtendGoGetBtn
		{
			[Token(Token = "0x6002460")]
			[Address(RVA = "0x3F5AB78", Offset = "0x3F56B78", VA = "0x3F5AB78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002461")]
		[Address(RVA = "0x3F5AC40", Offset = "0x3F56C40", VA = "0x3F5AC40")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6002462")]
		[Address(RVA = "0x3F559FC", Offset = "0x3F519FC", VA = "0x3F559FC", Slot = "12")]
		protected virtual void OnButtonBackgroundClicked()
		{
		}

		[Token(Token = "0x6002463")]
		[Address(RVA = "0x3F55970", Offset = "0x3F51970", VA = "0x3F55970", Slot = "13")]
		protected virtual void OnButtonExtendCloseClicked()
		{
		}

		[Token(Token = "0x6002464")]
		[Address(RVA = "0x3F56D8C", Offset = "0x3F52D8C", VA = "0x3F56D8C", Slot = "14")]
		protected virtual void OnButtonExtendStarUpgradeClicked()
		{
		}

		[Token(Token = "0x6002465")]
		[Address(RVA = "0x3F5AEF0", Offset = "0x3F56EF0", VA = "0x3F5AEF0", Slot = "15")]
		protected virtual void OnButtonExtendRefreshClicked()
		{
		}

		[Token(Token = "0x6002466")]
		[Address(RVA = "0x3F5AF5C", Offset = "0x3F56F5C", VA = "0x3F5AF5C", Slot = "16")]
		protected virtual void OnButtonExtendRefresh1Clicked()
		{
		}

		[Token(Token = "0x6002467")]
		[Address(RVA = "0x3F5AFC8", Offset = "0x3F56FC8", VA = "0x3F5AFC8", Slot = "17")]
		protected virtual void OnButtonExtendRefresh2Clicked()
		{
		}

		[Token(Token = "0x6002468")]
		[Address(RVA = "0x3F55CE8", Offset = "0x3F51CE8", VA = "0x3F55CE8", Slot = "18")]
		protected virtual void OnButtonExtendUpgradeClicked()
		{
		}

		[Token(Token = "0x6002469")]
		[Address(RVA = "0x3F560E4", Offset = "0x3F520E4", VA = "0x3F560E4", Slot = "19")]
		protected virtual void OnButtonExtendEquipClicked()
		{
		}

		[Token(Token = "0x600246A")]
		[Address(RVA = "0x3F563DC", Offset = "0x3F523DC", VA = "0x3F563DC", Slot = "20")]
		protected virtual void OnButtonExtendGoGetBtnClicked()
		{
		}

		[Token(Token = "0x600246B")]
		[Address(RVA = "0x3F55040", Offset = "0x3F51040", VA = "0x3F55040", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600246C")]
		[Address(RVA = "0x3F56CF4", Offset = "0x3F52CF4", VA = "0x3F56CF4", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__701))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x600246D")]
		[Address(RVA = "0x3F562C0", Offset = "0x3F522C0", VA = "0x3F562C0", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x600246E")]
		[Address(RVA = "0x3F56CE8", Offset = "0x3F52CE8", VA = "0x3F56CE8")]
		public ArtifactDetailsPanelComponents()
		{
		}
	}
}
