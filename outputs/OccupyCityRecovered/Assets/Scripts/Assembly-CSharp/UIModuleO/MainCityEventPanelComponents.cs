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
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000938")]
	public class MainCityEventPanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000939")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__820 : IAsyncStateMachine
		{
			[Token(Token = "0x400451C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400451D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400451E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MainCityEventPanelComponents _003C_003E4__this;

			[Token(Token = "0x400451F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6003580")]
			[Address(RVA = "0x40BA0DC", Offset = "0x40B60DC", VA = "0x40BA0DC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003581")]
			[Address(RVA = "0x40BA354", Offset = "0x40B6354", VA = "0x40BA354", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40044F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RectTransform _rectTransformCenter;

		[Token(Token = "0x40044F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RectTransform _rectTransformGrassPanel;

		[Token(Token = "0x40044F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TextMeshProUGUI _textMeshProUGUIGrassContentText;

		[Token(Token = "0x40044F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private TextMeshProUGUI _textMeshProUGUITips;

		[Token(Token = "0x40044F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private ButtonExtend _buttonExtendHpBuilding1;

		[Token(Token = "0x40044F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Image _imageHpBuilding1Icon;

		[Token(Token = "0x40044F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private TextMeshProUGUI _textMeshProUGUIHpBuilding1Des;

		[Token(Token = "0x40044FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private TextMeshProUGUI _textMeshProUGUIHpBuilding1Text;

		[Token(Token = "0x40044FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private ButtonExtend _buttonExtendHpBuilding2;

		[Token(Token = "0x40044FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Image _imageHpBuilding2Icon;

		[Token(Token = "0x40044FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private TextMeshProUGUI _textMeshProUGUIHpBuilding2Des;

		[Token(Token = "0x40044FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private TextMeshProUGUI _textMeshProUGUIHpBuilding2Text;

		[Token(Token = "0x40044FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private ButtonExtend _buttonExtendAtkBuilding1;

		[Token(Token = "0x4004500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Image _imageAtkBuilding1Icon;

		[Token(Token = "0x4004501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private TextMeshProUGUI _textMeshProUGUIAtkBuilding1Des;

		[Token(Token = "0x4004502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private TextMeshProUGUI _textMeshProUGUIAtkBuilding1Text;

		[Token(Token = "0x4004503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private ButtonExtend _buttonExtendAtkBuilding2;

		[Token(Token = "0x4004504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Image _imageAtkBuilding2Icon;

		[Token(Token = "0x4004505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private TextMeshProUGUI _textMeshProUGUIAtkBuilding2Des;

		[Token(Token = "0x4004506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private TextMeshProUGUI _textMeshProUGUIAtkBuilding2Text;

		[Token(Token = "0x4004507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private RectTransform _rectTransformEnemyPanel;

		[Token(Token = "0x4004508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private TextMeshProUGUI _textMeshProUGUIEnemyContentText;

		[Token(Token = "0x4004509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private ButtonExtend _buttonExtendEnemyInfo;

		[Token(Token = "0x400450A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private TextMeshProUGUI _textMeshProUGUIEnemyInfoTxt;

		[Token(Token = "0x400450B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private RectTransform _rectTransformFight;

		[Token(Token = "0x400450C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private ButtonExtend _buttonExtendFight;

		[Token(Token = "0x400450D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private TextMeshProUGUI _textMeshProUGUIFightTxt;

		[Token(Token = "0x400450E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private ButtonExtend _buttonExtendRun;

		[Token(Token = "0x400450F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private TextMeshProUGUI _textMeshProUGUIRunTxt;

		[Token(Token = "0x4004510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private TextMeshProUGUI _textMeshProUGUIRewardTxt;

		[Token(Token = "0x4004511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private TextMeshProUGUI _textMeshProUGUITxtCoinNum;

		[Token(Token = "0x4004512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private TextMeshProUGUI _textMeshProUGUITxtDiamondNum;

		[Token(Token = "0x4004513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private RectTransform _rectTransformEnemyWinPanel;

		[Token(Token = "0x4004514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private TextMeshProUGUI _textMeshProUGUIEnemyWinContentText;

		[Token(Token = "0x4004515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private RectTransform _rectTransformFamilyPanel;

		[Token(Token = "0x4004516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private TextMeshProUGUI _textMeshProUGUIFamilyContentText;

		[Token(Token = "0x4004517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private TextMeshProUGUI _textMeshProUGUIPopulationTip;

		[Token(Token = "0x4004518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private TextMeshProUGUI _textMeshProUGUIPopulation;

		[Token(Token = "0x4004519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private TextMeshProUGUI _textMeshProUGUIGoldTip;

		[Token(Token = "0x400451A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private ButtonExtend _buttonExtendSure;

		[Token(Token = "0x400451B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private TextMeshProUGUI _textMeshProUGUISureTxt;

		[Token(Token = "0x17000768")]
		public RectTransform RectTransformCenter
		{
			[Token(Token = "0x6003549")]
			[Address(RVA = "0x40B35F4", Offset = "0x40AF5F4", VA = "0x40B35F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000769")]
		public RectTransform RectTransformGrassPanel
		{
			[Token(Token = "0x600354A")]
			[Address(RVA = "0x40B9350", Offset = "0x40B5350", VA = "0x40B9350")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700076A")]
		public TextMeshProUGUI TextMeshProUGUIGrassContentText
		{
			[Token(Token = "0x600354B")]
			[Address(RVA = "0x40B6584", Offset = "0x40B2584", VA = "0x40B6584")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700076B")]
		public TextMeshProUGUI TextMeshProUGUITips
		{
			[Token(Token = "0x600354C")]
			[Address(RVA = "0x40B68A4", Offset = "0x40B28A4", VA = "0x40B68A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700076C")]
		public ButtonExtend ButtonExtendHpBuilding1
		{
			[Token(Token = "0x600354D")]
			[Address(RVA = "0x40B980C", Offset = "0x40B580C", VA = "0x40B980C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700076D")]
		public Image ImageHpBuilding1Icon
		{
			[Token(Token = "0x600354E")]
			[Address(RVA = "0x40B8480", Offset = "0x40B4480", VA = "0x40B8480")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700076E")]
		public TextMeshProUGUI TextMeshProUGUIHpBuilding1Des
		{
			[Token(Token = "0x600354F")]
			[Address(RVA = "0x40B7074", Offset = "0x40B3074", VA = "0x40B7074")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700076F")]
		public TextMeshProUGUI TextMeshProUGUIHpBuilding1Text
		{
			[Token(Token = "0x6003550")]
			[Address(RVA = "0x40B6EE4", Offset = "0x40B2EE4", VA = "0x40B6EE4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000770")]
		public ButtonExtend ButtonExtendHpBuilding2
		{
			[Token(Token = "0x6003551")]
			[Address(RVA = "0x40B98D4", Offset = "0x40B58D4", VA = "0x40B98D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000771")]
		public Image ImageHpBuilding2Icon
		{
			[Token(Token = "0x6003552")]
			[Address(RVA = "0x40B8548", Offset = "0x40B4548", VA = "0x40B8548")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000772")]
		public TextMeshProUGUI TextMeshProUGUIHpBuilding2Des
		{
			[Token(Token = "0x6003553")]
			[Address(RVA = "0x40B713C", Offset = "0x40B313C", VA = "0x40B713C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000773")]
		public TextMeshProUGUI TextMeshProUGUIHpBuilding2Text
		{
			[Token(Token = "0x6003554")]
			[Address(RVA = "0x40B6FAC", Offset = "0x40B2FAC", VA = "0x40B6FAC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000774")]
		public ButtonExtend ButtonExtendAtkBuilding1
		{
			[Token(Token = "0x6003555")]
			[Address(RVA = "0x40B999C", Offset = "0x40B599C", VA = "0x40B999C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000775")]
		public Image ImageAtkBuilding1Icon
		{
			[Token(Token = "0x6003556")]
			[Address(RVA = "0x40B8610", Offset = "0x40B4610", VA = "0x40B8610")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000776")]
		public TextMeshProUGUI TextMeshProUGUIAtkBuilding1Des
		{
			[Token(Token = "0x6003557")]
			[Address(RVA = "0x40B7394", Offset = "0x40B3394", VA = "0x40B7394")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000777")]
		public TextMeshProUGUI TextMeshProUGUIAtkBuilding1Text
		{
			[Token(Token = "0x6003558")]
			[Address(RVA = "0x40B7204", Offset = "0x40B3204", VA = "0x40B7204")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000778")]
		public ButtonExtend ButtonExtendAtkBuilding2
		{
			[Token(Token = "0x6003559")]
			[Address(RVA = "0x40B9A64", Offset = "0x40B5A64", VA = "0x40B9A64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000779")]
		public Image ImageAtkBuilding2Icon
		{
			[Token(Token = "0x600355A")]
			[Address(RVA = "0x40B86D8", Offset = "0x40B46D8", VA = "0x40B86D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700077A")]
		public TextMeshProUGUI TextMeshProUGUIAtkBuilding2Des
		{
			[Token(Token = "0x600355B")]
			[Address(RVA = "0x40B745C", Offset = "0x40B345C", VA = "0x40B745C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700077B")]
		public TextMeshProUGUI TextMeshProUGUIAtkBuilding2Text
		{
			[Token(Token = "0x600355C")]
			[Address(RVA = "0x40B72CC", Offset = "0x40B32CC", VA = "0x40B72CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700077C")]
		public RectTransform RectTransformEnemyPanel
		{
			[Token(Token = "0x600355D")]
			[Address(RVA = "0x40B94E0", Offset = "0x40B54E0", VA = "0x40B94E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700077D")]
		public TextMeshProUGUI TextMeshProUGUIEnemyContentText
		{
			[Token(Token = "0x600355E")]
			[Address(RVA = "0x40B664C", Offset = "0x40B264C", VA = "0x40B664C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700077E")]
		public ButtonExtend ButtonExtendEnemyInfo
		{
			[Token(Token = "0x600355F")]
			[Address(RVA = "0x40B9B2C", Offset = "0x40B5B2C", VA = "0x40B9B2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700077F")]
		public TextMeshProUGUI TextMeshProUGUIEnemyInfoTxt
		{
			[Token(Token = "0x6003560")]
			[Address(RVA = "0x40B696C", Offset = "0x40B296C", VA = "0x40B696C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000780")]
		public RectTransform RectTransformFight
		{
			[Token(Token = "0x6003561")]
			[Address(RVA = "0x40B4610", Offset = "0x40B0610", VA = "0x40B4610")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000781")]
		public ButtonExtend ButtonExtendFight
		{
			[Token(Token = "0x6003562")]
			[Address(RVA = "0x40B9BF4", Offset = "0x40B5BF4", VA = "0x40B9BF4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000782")]
		public TextMeshProUGUI TextMeshProUGUIFightTxt
		{
			[Token(Token = "0x6003563")]
			[Address(RVA = "0x40B6A34", Offset = "0x40B2A34", VA = "0x40B6A34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000783")]
		public ButtonExtend ButtonExtendRun
		{
			[Token(Token = "0x6003564")]
			[Address(RVA = "0x40B9CBC", Offset = "0x40B5CBC", VA = "0x40B9CBC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000784")]
		public TextMeshProUGUI TextMeshProUGUIRunTxt
		{
			[Token(Token = "0x6003565")]
			[Address(RVA = "0x40B6AFC", Offset = "0x40B2AFC", VA = "0x40B6AFC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000785")]
		public TextMeshProUGUI TextMeshProUGUIRewardTxt
		{
			[Token(Token = "0x6003566")]
			[Address(RVA = "0x40B6E1C", Offset = "0x40B2E1C", VA = "0x40B6E1C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000786")]
		public TextMeshProUGUI TextMeshProUGUITxtCoinNum
		{
			[Token(Token = "0x6003567")]
			[Address(RVA = "0x40B9670", Offset = "0x40B5670", VA = "0x40B9670")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000787")]
		public TextMeshProUGUI TextMeshProUGUITxtDiamondNum
		{
			[Token(Token = "0x6003568")]
			[Address(RVA = "0x40B9738", Offset = "0x40B5738", VA = "0x40B9738")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000788")]
		public RectTransform RectTransformEnemyWinPanel
		{
			[Token(Token = "0x6003569")]
			[Address(RVA = "0x40B95A8", Offset = "0x40B55A8", VA = "0x40B95A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000789")]
		public TextMeshProUGUI TextMeshProUGUIEnemyWinContentText
		{
			[Token(Token = "0x600356A")]
			[Address(RVA = "0x40B6714", Offset = "0x40B2714", VA = "0x40B6714")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700078A")]
		public RectTransform RectTransformFamilyPanel
		{
			[Token(Token = "0x600356B")]
			[Address(RVA = "0x40B9418", Offset = "0x40B5418", VA = "0x40B9418")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700078B")]
		public TextMeshProUGUI TextMeshProUGUIFamilyContentText
		{
			[Token(Token = "0x600356C")]
			[Address(RVA = "0x40B67DC", Offset = "0x40B27DC", VA = "0x40B67DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700078C")]
		public TextMeshProUGUI TextMeshProUGUIPopulationTip
		{
			[Token(Token = "0x600356D")]
			[Address(RVA = "0x40B6D54", Offset = "0x40B2D54", VA = "0x40B6D54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700078D")]
		public TextMeshProUGUI TextMeshProUGUIPopulation
		{
			[Token(Token = "0x600356E")]
			[Address(RVA = "0x40B7524", Offset = "0x40B3524", VA = "0x40B7524")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700078E")]
		public TextMeshProUGUI TextMeshProUGUIGoldTip
		{
			[Token(Token = "0x600356F")]
			[Address(RVA = "0x40B6C8C", Offset = "0x40B2C8C", VA = "0x40B6C8C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700078F")]
		public ButtonExtend ButtonExtendSure
		{
			[Token(Token = "0x6003570")]
			[Address(RVA = "0x40B9D84", Offset = "0x40B5D84", VA = "0x40B9D84")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000790")]
		public TextMeshProUGUI TextMeshProUGUISureTxt
		{
			[Token(Token = "0x6003571")]
			[Address(RVA = "0x40B6BC4", Offset = "0x40B2BC4", VA = "0x40B6BC4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003572")]
		[Address(RVA = "0x40B9E4C", Offset = "0x40B5E4C", VA = "0x40B9E4C")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6003573")]
		[Address(RVA = "0x40B3588", Offset = "0x40AF588", VA = "0x40B3588", Slot = "12")]
		protected virtual void OnButtonExtendHpBuilding1Clicked()
		{
		}

		[Token(Token = "0x6003574")]
		[Address(RVA = "0x40B38CC", Offset = "0x40AF8CC", VA = "0x40B38CC", Slot = "13")]
		protected virtual void OnButtonExtendHpBuilding2Clicked()
		{
		}

		[Token(Token = "0x6003575")]
		[Address(RVA = "0x40B3B48", Offset = "0x40AFB48", VA = "0x40B3B48", Slot = "14")]
		protected virtual void OnButtonExtendAtkBuilding1Clicked()
		{
		}

		[Token(Token = "0x6003576")]
		[Address(RVA = "0x40B3DC4", Offset = "0x40AFDC4", VA = "0x40B3DC4", Slot = "15")]
		protected virtual void OnButtonExtendAtkBuilding2Clicked()
		{
		}

		[Token(Token = "0x6003577")]
		[Address(RVA = "0x40B44C4", Offset = "0x40B04C4", VA = "0x40B44C4", Slot = "16")]
		protected virtual void OnButtonExtendEnemyInfoClicked()
		{
		}

		[Token(Token = "0x6003578")]
		[Address(RVA = "0x40B4254", Offset = "0x40B0254", VA = "0x40B4254", Slot = "17")]
		protected virtual void OnButtonExtendFightClicked()
		{
		}

		[Token(Token = "0x6003579")]
		[Address(RVA = "0x40B40E4", Offset = "0x40B00E4", VA = "0x40B40E4", Slot = "18")]
		protected virtual void OnButtonExtendRunClicked()
		{
		}

		[Token(Token = "0x600357A")]
		[Address(RVA = "0x40B3F34", Offset = "0x40AFF34", VA = "0x40B3F34", Slot = "19")]
		protected virtual void OnButtonExtendSureClicked()
		{
		}

		[Token(Token = "0x600357B")]
		[Address(RVA = "0x40BA0B8", Offset = "0x40B60B8", VA = "0x40BA0B8", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600357C")]
		[Address(RVA = "0x40B47B0", Offset = "0x40B07B0", VA = "0x40B47B0", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__820))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x600357D")]
		[Address(RVA = "0x40B46D8", Offset = "0x40B06D8", VA = "0x40B46D8", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x600357E")]
		[Address(RVA = "0x40B47A4", Offset = "0x40B07A4", VA = "0x40B47A4")]
		public MainCityEventPanelComponents()
		{
		}
	}
}
