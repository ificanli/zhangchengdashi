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
	[Token(Token = "0x2000BFD")]
	public class WeeklyCardActivityPanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000BFE")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__480 : IAsyncStateMachine
		{
			[Token(Token = "0x40056D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40056D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40056D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public WeeklyCardActivityPanelComponents _003C_003E4__this;

			[Token(Token = "0x40056DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6004A4B")]
			[Address(RVA = "0x4258754", Offset = "0x4254754", VA = "0x4258754", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004A4C")]
			[Address(RVA = "0x42589CC", Offset = "0x42549CC", VA = "0x42589CC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40056C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RectTransform _rectTransformImgCardEffBg;

		[Token(Token = "0x40056C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Image _imageImgCardIcon;

		[Token(Token = "0x40056C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TextMeshProUGUI _textMeshProUGUITxtCardDes;

		[Token(Token = "0x40056C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private TextMeshProUGUI _textMeshProUGUITxtSummonDes;

		[Token(Token = "0x40056C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private TextMeshProUGUI _textMeshProUGUITxtAttackDes;

		[Token(Token = "0x40056CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private TextMeshProUGUI _textMeshProUGUITxtHPDes;

		[Token(Token = "0x40056CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private TextMeshProUGUI _textMeshProUGUITxtCardName;

		[Token(Token = "0x40056CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private TextMeshProUGUI _textMeshProUGUITxtMondayCutDown;

		[Token(Token = "0x40056CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private ButtonExtend _buttonExtendBtnCardGiftPack;

		[Token(Token = "0x40056CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private GiftBtn _giftBtnBtnCardGiftPack;

		[Token(Token = "0x40056CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private RectTransform _rectTransformImgProgress;

		[Token(Token = "0x40056D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Image _imageImgProgress;

		[Token(Token = "0x40056D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private ButtonExtend _buttonExtendBtnClaimStageReward;

		[Token(Token = "0x40056D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private TextMeshProUGUI _textMeshProUGUITxtAllActivityNum;

		[Token(Token = "0x40056D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private TextMeshProUGUI _textMeshProUGUITxtDailyTaskCutDown;

		[Token(Token = "0x40056D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private ScrollRect _scrollRectScrollView;

		[Token(Token = "0x40056D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private LoopListView2 _loopListView2ScrollView;

		[Token(Token = "0x40056D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private ButtonExtend _buttonExtendBtnBack;

		[Token(Token = "0x17000CF3")]
		public RectTransform RectTransformImgCardEffBg
		{
			[Token(Token = "0x6004A2F")]
			[Address(RVA = "0x4254C10", Offset = "0x4250C10", VA = "0x4254C10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CF4")]
		public Image ImageImgCardIcon
		{
			[Token(Token = "0x6004A30")]
			[Address(RVA = "0x42581E8", Offset = "0x42541E8", VA = "0x42581E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CF5")]
		public TextMeshProUGUI TextMeshProUGUITxtCardDes
		{
			[Token(Token = "0x6004A31")]
			[Address(RVA = "0x4257D38", Offset = "0x4253D38", VA = "0x4257D38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CF6")]
		public TextMeshProUGUI TextMeshProUGUITxtSummonDes
		{
			[Token(Token = "0x6004A32")]
			[Address(RVA = "0x4257EC8", Offset = "0x4253EC8", VA = "0x4257EC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CF7")]
		public TextMeshProUGUI TextMeshProUGUITxtAttackDes
		{
			[Token(Token = "0x6004A33")]
			[Address(RVA = "0x4257F90", Offset = "0x4253F90", VA = "0x4257F90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CF8")]
		public TextMeshProUGUI TextMeshProUGUITxtHPDes
		{
			[Token(Token = "0x6004A34")]
			[Address(RVA = "0x4258058", Offset = "0x4254058", VA = "0x4258058")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CF9")]
		public TextMeshProUGUI TextMeshProUGUITxtCardName
		{
			[Token(Token = "0x6004A35")]
			[Address(RVA = "0x4257E00", Offset = "0x4253E00", VA = "0x4257E00")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CFA")]
		public TextMeshProUGUI TextMeshProUGUITxtMondayCutDown
		{
			[Token(Token = "0x6004A36")]
			[Address(RVA = "0x4254A80", Offset = "0x4250A80", VA = "0x4254A80")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CFB")]
		public ButtonExtend ButtonExtendBtnCardGiftPack
		{
			[Token(Token = "0x6004A37")]
			[Address(RVA = "0x42582BC", Offset = "0x42542BC", VA = "0x42582BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CFC")]
		public GiftBtn GiftBtnBtnCardGiftPack
		{
			[Token(Token = "0x6004A38")]
			[Address(RVA = "0x425475C", Offset = "0x425075C", VA = "0x425475C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CFD")]
		public RectTransform RectTransformImgProgress
		{
			[Token(Token = "0x6004A39")]
			[Address(RVA = "0x4254474", Offset = "0x4250474", VA = "0x4254474")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CFE")]
		public Image ImageImgProgress
		{
			[Token(Token = "0x6004A3A")]
			[Address(RVA = "0x4258120", Offset = "0x4254120", VA = "0x4258120")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CFF")]
		public ButtonExtend ButtonExtendBtnClaimStageReward
		{
			[Token(Token = "0x6004A3B")]
			[Address(RVA = "0x42557E4", Offset = "0x42517E4", VA = "0x42557E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D00")]
		public TextMeshProUGUI TextMeshProUGUITxtAllActivityNum
		{
			[Token(Token = "0x6004A3C")]
			[Address(RVA = "0x4257C70", Offset = "0x4253C70", VA = "0x4257C70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D01")]
		public TextMeshProUGUI TextMeshProUGUITxtDailyTaskCutDown
		{
			[Token(Token = "0x6004A3D")]
			[Address(RVA = "0x4254B48", Offset = "0x4250B48", VA = "0x4254B48")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D02")]
		public ScrollRect ScrollRectScrollView
		{
			[Token(Token = "0x6004A3E")]
			[Address(RVA = "0x4258384", Offset = "0x4254384", VA = "0x4258384")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D03")]
		public LoopListView2 LoopListView2ScrollView
		{
			[Token(Token = "0x6004A3F")]
			[Address(RVA = "0x4255390", Offset = "0x4251390", VA = "0x4255390")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D04")]
		public ButtonExtend ButtonExtendBtnBack
		{
			[Token(Token = "0x6004A40")]
			[Address(RVA = "0x425844C", Offset = "0x425444C", VA = "0x425844C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004A41")]
		[Address(RVA = "0x4258514", Offset = "0x4254514", VA = "0x4258514")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6004A42")]
		[Address(RVA = "0x42555E8", Offset = "0x42515E8", VA = "0x42555E8", Slot = "12")]
		protected virtual void OnButtonExtendBtnCardGiftPackClicked()
		{
		}

		[Token(Token = "0x6004A43")]
		[Address(RVA = "0x42556A8", Offset = "0x42516A8", VA = "0x42556A8", Slot = "13")]
		protected virtual void OnButtonExtendBtnClaimStageRewardClicked()
		{
		}

		[Token(Token = "0x6004A44")]
		[Address(RVA = "0x4258698", Offset = "0x4254698", VA = "0x4258698", Slot = "14")]
		protected virtual void OnScrollRectScrollViewValueChanged(Vector2 arg)
		{
		}

		[Token(Token = "0x6004A45")]
		[Address(RVA = "0x4255508", Offset = "0x4251508", VA = "0x4255508", Slot = "15")]
		protected virtual void OnButtonExtendBtnBackClicked()
		{
		}

		[Token(Token = "0x6004A46")]
		[Address(RVA = "0x4254458", Offset = "0x4250458", VA = "0x4254458", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6004A47")]
		[Address(RVA = "0x42559F8", Offset = "0x42519F8", VA = "0x42559F8", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__480))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6004A48")]
		[Address(RVA = "0x42552DC", Offset = "0x42512DC", VA = "0x42552DC", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6004A49")]
		[Address(RVA = "0x4255988", Offset = "0x4251988", VA = "0x4255988")]
		public WeeklyCardActivityPanelComponents()
		{
		}
	}
}
