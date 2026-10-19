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
	[Token(Token = "0x2000ABB")]
	public class SummonOddDesPanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000ABC")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__312 : IAsyncStateMachine
		{
			[Token(Token = "0x4004EF8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004EF9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004EFA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public SummonOddDesPanelComponents _003C_003E4__this;

			[Token(Token = "0x4004EFB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x60040EB")]
			[Address(RVA = "0x41B1104", Offset = "0x41AD104", VA = "0x41B1104", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60040EC")]
			[Address(RVA = "0x41B137C", Offset = "0x41AD37C", VA = "0x41B137C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004EE6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ButtonExtend _buttonExtendBg;

		[Token(Token = "0x4004EE7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RectTransform _rectTransformImgBg;

		[Token(Token = "0x4004EE8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TextMeshProUGUI _textMeshProUGUITxtTitle;

		[Token(Token = "0x4004EE9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private ButtonExtend _buttonExtendBtnRight;

		[Token(Token = "0x4004EEA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private ButtonExtend _buttonExtendBtnLeft;

		[Token(Token = "0x4004EEB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private TextMeshProUGUI _textMeshProUGUITxtLevelTitle;

		[Token(Token = "0x4004EEC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private TextMeshProUGUI _textMeshProUGUITxtLevelNum;

		[Token(Token = "0x4004EED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private TextMeshProUGUI _textMeshProUGUITxtCrystal;

		[Token(Token = "0x4004EEE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private TextMeshProUGUI _textMeshProUGUITxtCrystalOdd;

		[Token(Token = "0x4004EEF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private TextMeshProUGUI _textMeshProUGUITxtCommon;

		[Token(Token = "0x4004EF0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private TextMeshProUGUI _textMeshProUGUITxtCommonOdd;

		[Token(Token = "0x4004EF1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private TextMeshProUGUI _textMeshProUGUITxtRare;

		[Token(Token = "0x4004EF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private TextMeshProUGUI _textMeshProUGUITxtRareOdd;

		[Token(Token = "0x4004EF3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private TextMeshProUGUI _textMeshProUGUITxtEpic;

		[Token(Token = "0x4004EF4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private TextMeshProUGUI _textMeshProUGUITxtEpicOdd;

		[Token(Token = "0x4004EF5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private TextMeshProUGUI _textMeshProUGUITxtLegend;

		[Token(Token = "0x4004EF6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private TextMeshProUGUI _textMeshProUGUITxtLegendOdd;

		[Token(Token = "0x4004EF7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private ButtonExtend _buttonExtendBtnClose;

		[Token(Token = "0x17000A2B")]
		public ButtonExtend ButtonExtendBg
		{
			[Token(Token = "0x60040CF")]
			[Address(RVA = "0x41B052C", Offset = "0x41AC52C", VA = "0x41B052C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A2C")]
		public RectTransform RectTransformImgBg
		{
			[Token(Token = "0x60040D0")]
			[Address(RVA = "0x41AFFDC", Offset = "0x41ABFDC", VA = "0x41AFFDC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A2D")]
		public TextMeshProUGUI TextMeshProUGUITxtTitle
		{
			[Token(Token = "0x60040D1")]
			[Address(RVA = "0x41AFA2C", Offset = "0x41ABA2C", VA = "0x41AFA2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A2E")]
		public ButtonExtend ButtonExtendBtnRight
		{
			[Token(Token = "0x60040D2")]
			[Address(RVA = "0x41B05F4", Offset = "0x41AC5F4", VA = "0x41B05F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A2F")]
		public ButtonExtend ButtonExtendBtnLeft
		{
			[Token(Token = "0x60040D3")]
			[Address(RVA = "0x41B06BC", Offset = "0x41AC6BC", VA = "0x41B06BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A30")]
		public TextMeshProUGUI TextMeshProUGUITxtLevelTitle
		{
			[Token(Token = "0x60040D4")]
			[Address(RVA = "0x41AF4B4", Offset = "0x41AB4B4", VA = "0x41AF4B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A31")]
		public TextMeshProUGUI TextMeshProUGUITxtLevelNum
		{
			[Token(Token = "0x60040D5")]
			[Address(RVA = "0x41AF57C", Offset = "0x41AB57C", VA = "0x41AF57C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A32")]
		public TextMeshProUGUI TextMeshProUGUITxtCrystal
		{
			[Token(Token = "0x60040D6")]
			[Address(RVA = "0x41AFAF4", Offset = "0x41ABAF4", VA = "0x41AFAF4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A33")]
		public TextMeshProUGUI TextMeshProUGUITxtCrystalOdd
		{
			[Token(Token = "0x60040D7")]
			[Address(RVA = "0x41AF644", Offset = "0x41AB644", VA = "0x41AF644")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A34")]
		public TextMeshProUGUI TextMeshProUGUITxtCommon
		{
			[Token(Token = "0x60040D8")]
			[Address(RVA = "0x41AFBBC", Offset = "0x41ABBBC", VA = "0x41AFBBC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A35")]
		public TextMeshProUGUI TextMeshProUGUITxtCommonOdd
		{
			[Token(Token = "0x60040D9")]
			[Address(RVA = "0x41AF70C", Offset = "0x41AB70C", VA = "0x41AF70C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A36")]
		public TextMeshProUGUI TextMeshProUGUITxtRare
		{
			[Token(Token = "0x60040DA")]
			[Address(RVA = "0x41AFC84", Offset = "0x41ABC84", VA = "0x41AFC84")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A37")]
		public TextMeshProUGUI TextMeshProUGUITxtRareOdd
		{
			[Token(Token = "0x60040DB")]
			[Address(RVA = "0x41AF7D4", Offset = "0x41AB7D4", VA = "0x41AF7D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A38")]
		public TextMeshProUGUI TextMeshProUGUITxtEpic
		{
			[Token(Token = "0x60040DC")]
			[Address(RVA = "0x41AFD4C", Offset = "0x41ABD4C", VA = "0x41AFD4C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A39")]
		public TextMeshProUGUI TextMeshProUGUITxtEpicOdd
		{
			[Token(Token = "0x60040DD")]
			[Address(RVA = "0x41AF89C", Offset = "0x41AB89C", VA = "0x41AF89C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A3A")]
		public TextMeshProUGUI TextMeshProUGUITxtLegend
		{
			[Token(Token = "0x60040DE")]
			[Address(RVA = "0x41AFE14", Offset = "0x41ABE14", VA = "0x41AFE14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A3B")]
		public TextMeshProUGUI TextMeshProUGUITxtLegendOdd
		{
			[Token(Token = "0x60040DF")]
			[Address(RVA = "0x41AF964", Offset = "0x41AB964", VA = "0x41AF964")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A3C")]
		public ButtonExtend ButtonExtendBtnClose
		{
			[Token(Token = "0x60040E0")]
			[Address(RVA = "0x41B0784", Offset = "0x41AC784", VA = "0x41B0784")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60040E1")]
		[Address(RVA = "0x41B084C", Offset = "0x41AC84C", VA = "0x41B084C")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x60040E2")]
		[Address(RVA = "0x41B00C4", Offset = "0x41AC0C4", VA = "0x41B00C4", Slot = "12")]
		protected virtual void OnButtonExtendBgClicked()
		{
		}

		[Token(Token = "0x60040E3")]
		[Address(RVA = "0x41AF448", Offset = "0x41AB448", VA = "0x41AF448", Slot = "13")]
		protected virtual void OnButtonExtendBtnRightClicked()
		{
		}

		[Token(Token = "0x60040E4")]
		[Address(RVA = "0x41AED50", Offset = "0x41AAD50", VA = "0x41AED50", Slot = "14")]
		protected virtual void OnButtonExtendBtnLeftClicked()
		{
		}

		[Token(Token = "0x60040E5")]
		[Address(RVA = "0x41AECAC", Offset = "0x41AACAC", VA = "0x41AECAC", Slot = "15")]
		protected virtual void OnButtonExtendBtnCloseClicked()
		{
		}

		[Token(Token = "0x60040E6")]
		[Address(RVA = "0x41B09A8", Offset = "0x41AC9A8", VA = "0x41B09A8", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60040E7")]
		[Address(RVA = "0x41B0144", Offset = "0x41AC144", VA = "0x41B0144", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__312))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60040E8")]
		[Address(RVA = "0x41B01E8", Offset = "0x41AC1E8", VA = "0x41B01E8", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x60040E9")]
		[Address(RVA = "0x41B0138", Offset = "0x41AC138", VA = "0x41B0138")]
		public SummonOddDesPanelComponents()
		{
		}
	}
}
