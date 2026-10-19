using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UIFramework;
using UIModuleO.UIAnim;
using UnityEngine;

namespace UIModuleO
{
	[Token(Token = "0x20008C2")]
	public class HexDescribesPanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20008C3")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__1040 : IAsyncStateMachine
		{
			[Token(Token = "0x4004277")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004278")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004279")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public HexDescribesPanelComponents _003C_003E4__this;

			[Token(Token = "0x400427A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x600323E")]
			[Address(RVA = "0x406C91C", Offset = "0x406891C", VA = "0x406C91C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600323F")]
			[Address(RVA = "0x406CB94", Offset = "0x4068B94", VA = "0x406CB94", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RectTransform _rectTransformBG;

		[Token(Token = "0x4004257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private ButtonExtend _buttonExtendBG;

		[Token(Token = "0x4004258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private RectTransform _rectTransformRoot;

		[Token(Token = "0x4004259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private CanvasGroup _canvasGroupRoot;

		[Token(Token = "0x400425A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private TextMeshProUGUI _textMeshProUGUITxtTitle;

		[Token(Token = "0x400425B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private TextMeshProUGUI _textMeshProUGUITxtGoldMineDes;

		[Token(Token = "0x400425C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private TextMeshProUGUI _textMeshProUGUITxtDefDes;

		[Token(Token = "0x400425D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private TextMeshProUGUI _textMeshProUGUITxtUnknownDes;

		[Token(Token = "0x400425E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private TextMeshProUGUI _textMeshProUGUITxtNothingDes;

		[Token(Token = "0x400425F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private TextMeshProUGUI _textMeshProUGUITxtEpicDes1;

		[Token(Token = "0x4004260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private TextMeshProUGUI _textMeshProUGUITxtGoldDes1;

		[Token(Token = "0x4004261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private TextMeshProUGUI _textMeshProUGUITxtCommonDes3;

		[Token(Token = "0x4004262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private TextMeshProUGUI _textMeshProUGUITxtBarDes1;

		[Token(Token = "0x4004263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private TextMeshProUGUI _textMeshProUGUITxtCommonDes1;

		[Token(Token = "0x4004264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private TextMeshProUGUI _textMeshProUGUITxtRareDes1;

		[Token(Token = "0x4004265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private TextMeshProUGUI _textMeshProUGUITxtEpicDes2;

		[Token(Token = "0x4004266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private TextMeshProUGUI _textMeshProUGUITxtGoldDes2;

		[Token(Token = "0x4004267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private TextMeshProUGUI _textMeshProUGUITxtBarDes2;

		[Token(Token = "0x4004268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private RectTransform _rectTransformTxtCommonDes2;

		[Token(Token = "0x4004269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private TextMeshProUGUI _textMeshProUGUITxtCommonDes2;

		[Token(Token = "0x400426A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private TextMeshProUGUI _textMeshProUGUITxtOdds8;

		[Token(Token = "0x400426B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private RectTransform _rectTransformTxtRareDes2;

		[Token(Token = "0x400426C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private TextMeshProUGUI _textMeshProUGUITxtRareDes2;

		[Token(Token = "0x400426D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private TextMeshProUGUI _textMeshProUGUITxtOdds9;

		[Token(Token = "0x400426E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private RectTransform _rectTransformTxtEpicDes3;

		[Token(Token = "0x400426F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private TextMeshProUGUI _textMeshProUGUITxtEpicDes3;

		[Token(Token = "0x4004270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private RectTransform _rectTransformTxtGoldDes3;

		[Token(Token = "0x4004271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private TextMeshProUGUI _textMeshProUGUITxtGoldDes3;

		[Token(Token = "0x4004272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private TextMeshProUGUI _textMeshProUGUITxtBarDes3;

		[Token(Token = "0x4004273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private TextMeshProUGUI _textMeshProUGUITxtEpicDes4;

		[Token(Token = "0x4004274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private TextMeshProUGUI _textMeshProUGUITxtGoldDes4;

		[Token(Token = "0x4004275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private ButtonExtend _buttonExtendBtnCheat;

		[Token(Token = "0x4004276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private ButtonExtend _buttonExtendBtnClose;

		[Token(Token = "0x17000672")]
		public RectTransform RectTransformBG
		{
			[Token(Token = "0x6003214")]
			[Address(RVA = "0x406AFB8", Offset = "0x4066FB8", VA = "0x406AFB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000673")]
		public ButtonExtend ButtonExtendBG
		{
			[Token(Token = "0x6003215")]
			[Address(RVA = "0x406C5A4", Offset = "0x40685A4", VA = "0x406C5A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000674")]
		public RectTransform RectTransformRoot
		{
			[Token(Token = "0x6003216")]
			[Address(RVA = "0x40698B8", Offset = "0x40658B8", VA = "0x40698B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000675")]
		public CanvasGroup CanvasGroupRoot
		{
			[Token(Token = "0x6003217")]
			[Address(RVA = "0x406AEF0", Offset = "0x4066EF0", VA = "0x406AEF0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000676")]
		public TextMeshProUGUI TextMeshProUGUITxtTitle
		{
			[Token(Token = "0x6003218")]
			[Address(RVA = "0x406B080", Offset = "0x4067080", VA = "0x406B080")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000677")]
		public TextMeshProUGUI TextMeshProUGUITxtGoldMineDes
		{
			[Token(Token = "0x6003219")]
			[Address(RVA = "0x406B148", Offset = "0x4067148", VA = "0x406B148")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000678")]
		public TextMeshProUGUI TextMeshProUGUITxtDefDes
		{
			[Token(Token = "0x600321A")]
			[Address(RVA = "0x406B210", Offset = "0x4067210", VA = "0x406B210")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000679")]
		public TextMeshProUGUI TextMeshProUGUITxtUnknownDes
		{
			[Token(Token = "0x600321B")]
			[Address(RVA = "0x406B2D8", Offset = "0x40672D8", VA = "0x406B2D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700067A")]
		public TextMeshProUGUI TextMeshProUGUITxtNothingDes
		{
			[Token(Token = "0x600321C")]
			[Address(RVA = "0x406B5F8", Offset = "0x40675F8", VA = "0x406B5F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700067B")]
		public TextMeshProUGUI TextMeshProUGUITxtEpicDes1
		{
			[Token(Token = "0x600321D")]
			[Address(RVA = "0x406B6C0", Offset = "0x40676C0", VA = "0x406B6C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700067C")]
		public TextMeshProUGUI TextMeshProUGUITxtGoldDes1
		{
			[Token(Token = "0x600321E")]
			[Address(RVA = "0x406BDC8", Offset = "0x4067DC8", VA = "0x406BDC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700067D")]
		public TextMeshProUGUI TextMeshProUGUITxtCommonDes3
		{
			[Token(Token = "0x600321F")]
			[Address(RVA = "0x406BB70", Offset = "0x4067B70", VA = "0x406BB70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700067E")]
		public TextMeshProUGUI TextMeshProUGUITxtBarDes1
		{
			[Token(Token = "0x6003220")]
			[Address(RVA = "0x406B3A0", Offset = "0x40673A0", VA = "0x406B3A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700067F")]
		public TextMeshProUGUI TextMeshProUGUITxtCommonDes1
		{
			[Token(Token = "0x6003221")]
			[Address(RVA = "0x406B9E0", Offset = "0x40679E0", VA = "0x406B9E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000680")]
		public TextMeshProUGUI TextMeshProUGUITxtRareDes1
		{
			[Token(Token = "0x6003222")]
			[Address(RVA = "0x406BC38", Offset = "0x4067C38", VA = "0x406BC38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000681")]
		public TextMeshProUGUI TextMeshProUGUITxtEpicDes2
		{
			[Token(Token = "0x6003223")]
			[Address(RVA = "0x406B788", Offset = "0x4067788", VA = "0x406B788")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000682")]
		public TextMeshProUGUI TextMeshProUGUITxtGoldDes2
		{
			[Token(Token = "0x6003224")]
			[Address(RVA = "0x406BE90", Offset = "0x4067E90", VA = "0x406BE90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000683")]
		public TextMeshProUGUI TextMeshProUGUITxtBarDes2
		{
			[Token(Token = "0x6003225")]
			[Address(RVA = "0x406B468", Offset = "0x4067468", VA = "0x406B468")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000684")]
		public RectTransform RectTransformTxtCommonDes2
		{
			[Token(Token = "0x6003226")]
			[Address(RVA = "0x406C0E8", Offset = "0x40680E8", VA = "0x406C0E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000685")]
		public TextMeshProUGUI TextMeshProUGUITxtCommonDes2
		{
			[Token(Token = "0x6003227")]
			[Address(RVA = "0x406BAA8", Offset = "0x4067AA8", VA = "0x406BAA8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000686")]
		public TextMeshProUGUI TextMeshProUGUITxtOdds8
		{
			[Token(Token = "0x6003228")]
			[Address(RVA = "0x406C4D0", Offset = "0x40684D0", VA = "0x406C4D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000687")]
		public RectTransform RectTransformTxtRareDes2
		{
			[Token(Token = "0x6003229")]
			[Address(RVA = "0x406C1B0", Offset = "0x40681B0", VA = "0x406C1B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000688")]
		public TextMeshProUGUI TextMeshProUGUITxtRareDes2
		{
			[Token(Token = "0x600322A")]
			[Address(RVA = "0x406BD00", Offset = "0x4067D00", VA = "0x406BD00")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000689")]
		public TextMeshProUGUI TextMeshProUGUITxtOdds9
		{
			[Token(Token = "0x600322B")]
			[Address(RVA = "0x406C408", Offset = "0x4068408", VA = "0x406C408")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700068A")]
		public RectTransform RectTransformTxtEpicDes3
		{
			[Token(Token = "0x600322C")]
			[Address(RVA = "0x406C278", Offset = "0x4068278", VA = "0x406C278")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700068B")]
		public TextMeshProUGUI TextMeshProUGUITxtEpicDes3
		{
			[Token(Token = "0x600322D")]
			[Address(RVA = "0x406B850", Offset = "0x4067850", VA = "0x406B850")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700068C")]
		public RectTransform RectTransformTxtGoldDes3
		{
			[Token(Token = "0x600322E")]
			[Address(RVA = "0x406C340", Offset = "0x4068340", VA = "0x406C340")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700068D")]
		public TextMeshProUGUI TextMeshProUGUITxtGoldDes3
		{
			[Token(Token = "0x600322F")]
			[Address(RVA = "0x406BF58", Offset = "0x4067F58", VA = "0x406BF58")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700068E")]
		public TextMeshProUGUI TextMeshProUGUITxtBarDes3
		{
			[Token(Token = "0x6003230")]
			[Address(RVA = "0x406B530", Offset = "0x4067530", VA = "0x406B530")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700068F")]
		public TextMeshProUGUI TextMeshProUGUITxtEpicDes4
		{
			[Token(Token = "0x6003231")]
			[Address(RVA = "0x406B918", Offset = "0x4067918", VA = "0x406B918")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000690")]
		public TextMeshProUGUI TextMeshProUGUITxtGoldDes4
		{
			[Token(Token = "0x6003232")]
			[Address(RVA = "0x406C020", Offset = "0x4068020", VA = "0x406C020")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000691")]
		public ButtonExtend ButtonExtendBtnCheat
		{
			[Token(Token = "0x6003233")]
			[Address(RVA = "0x406C66C", Offset = "0x406866C", VA = "0x406C66C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000692")]
		public ButtonExtend ButtonExtendBtnClose
		{
			[Token(Token = "0x6003234")]
			[Address(RVA = "0x406C734", Offset = "0x4068734", VA = "0x406C734")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003235")]
		[Address(RVA = "0x406C7FC", Offset = "0x40687FC", VA = "0x406C7FC")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6003236")]
		[Address(RVA = "0x4069B70", Offset = "0x4065B70", VA = "0x4069B70", Slot = "12")]
		protected virtual void OnButtonExtendBGClicked()
		{
		}

		[Token(Token = "0x6003237")]
		[Address(RVA = "0x4069AE4", Offset = "0x4065AE4", VA = "0x4069AE4", Slot = "13")]
		protected virtual void OnButtonExtendBtnCheatClicked()
		{
		}

		[Token(Token = "0x6003238")]
		[Address(RVA = "0x40699A0", Offset = "0x40659A0", VA = "0x40699A0", Slot = "14")]
		protected virtual void OnButtonExtendBtnCloseClicked()
		{
		}

		[Token(Token = "0x6003239")]
		[Address(RVA = "0x4069704", Offset = "0x4065704", VA = "0x4069704", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600323A")]
		[Address(RVA = "0x4069C6C", Offset = "0x4065C6C", VA = "0x4069C6C", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__1040))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x600323B")]
		[Address(RVA = "0x4069D78", Offset = "0x4065D78", VA = "0x4069D78", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x600323C")]
		[Address(RVA = "0x4069C60", Offset = "0x4065C60", VA = "0x4069C60")]
		public HexDescribesPanelComponents()
		{
		}
	}
}
