using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UIFramework;
using UIModuleO.UIAnim;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000A66")]
	public class NewMainCityItemComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A67")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__343 : IAsyncStateMachine
		{
			[Token(Token = "0x4004CE3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004CE4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004CE5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public NewMainCityItemComponents _003C_003E4__this;

			[Token(Token = "0x4004CE6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6003E86")]
			[Address(RVA = "0x416F3E0", Offset = "0x416B3E0", VA = "0x416F3E0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003E87")]
			[Address(RVA = "0x416F658", Offset = "0x416B658", VA = "0x416F658", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004CD4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Image _imageImgProgressNew;

		[Token(Token = "0x4004CD5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Image _imageImgCurTitleIcon;

		[Token(Token = "0x4004CD6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TextMeshProUGUI _textMeshProUGUITxtCurTitleLvDes;

		[Token(Token = "0x4004CD7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private TextMeshProUGUI _textMeshProUGUITxtCurTitleDes;

		[Token(Token = "0x4004CD8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private TextMeshProUGUI _textMeshProUGUITxtLevelNewDes;

		[Token(Token = "0x4004CD9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private TextMeshProUGUI _textMeshProUGUITxtAtkDesNew;

		[Token(Token = "0x4004CDA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private TextMeshProUGUI _textMeshProUGUITxtAtkNumNew;

		[Token(Token = "0x4004CDB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private TextMeshProUGUI _textMeshProUGUITxtHpDesNew;

		[Token(Token = "0x4004CDC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private TextMeshProUGUI _textMeshProUGUITxtHpNumNew;

		[Token(Token = "0x4004CDD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private TextMeshProUGUI _textMeshProUGUITxtOutPutDesNew;

		[Token(Token = "0x4004CDE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private TextMeshProUGUI _textMeshProUGUITxtOutPutNumNew;

		[Token(Token = "0x4004CDF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private TextMeshProUGUI _textMeshProUGUITxtDesNew;

		[Token(Token = "0x4004CE0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private ButtonExtend _buttonExtendCityPass;

		[Token(Token = "0x4004CE1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private ButtonExtend _buttonExtendIdleInfos;

		[Token(Token = "0x4004CE2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private TextMeshProUGUI _textMeshProUGUIIdleTime;

		[Token(Token = "0x17000971")]
		public Image ImageImgProgressNew
		{
			[Token(Token = "0x6003E6F")]
			[Address(RVA = "0x416EF24", Offset = "0x416AF24", VA = "0x416EF24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000972")]
		public Image ImageImgCurTitleIcon
		{
			[Token(Token = "0x6003E70")]
			[Address(RVA = "0x416EFEC", Offset = "0x416AFEC", VA = "0x416EFEC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000973")]
		public TextMeshProUGUI TextMeshProUGUITxtCurTitleLvDes
		{
			[Token(Token = "0x6003E71")]
			[Address(RVA = "0x416EE5C", Offset = "0x416AE5C", VA = "0x416EE5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000974")]
		public TextMeshProUGUI TextMeshProUGUITxtCurTitleDes
		{
			[Token(Token = "0x6003E72")]
			[Address(RVA = "0x416ED94", Offset = "0x416AD94", VA = "0x416ED94")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000975")]
		public TextMeshProUGUI TextMeshProUGUITxtLevelNewDes
		{
			[Token(Token = "0x6003E73")]
			[Address(RVA = "0x416ECCC", Offset = "0x416ACCC", VA = "0x416ECCC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000976")]
		public TextMeshProUGUI TextMeshProUGUITxtAtkDesNew
		{
			[Token(Token = "0x6003E74")]
			[Address(RVA = "0x416D890", Offset = "0x4169890", VA = "0x416D890")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000977")]
		public TextMeshProUGUI TextMeshProUGUITxtAtkNumNew
		{
			[Token(Token = "0x6003E75")]
			[Address(RVA = "0x416D7C8", Offset = "0x41697C8", VA = "0x416D7C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000978")]
		public TextMeshProUGUI TextMeshProUGUITxtHpDesNew
		{
			[Token(Token = "0x6003E76")]
			[Address(RVA = "0x416DA20", Offset = "0x4169A20", VA = "0x416DA20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000979")]
		public TextMeshProUGUI TextMeshProUGUITxtHpNumNew
		{
			[Token(Token = "0x6003E77")]
			[Address(RVA = "0x416D958", Offset = "0x4169958", VA = "0x416D958")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700097A")]
		public TextMeshProUGUI TextMeshProUGUITxtOutPutDesNew
		{
			[Token(Token = "0x6003E78")]
			[Address(RVA = "0x416DBB0", Offset = "0x4169BB0", VA = "0x416DBB0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700097B")]
		public TextMeshProUGUI TextMeshProUGUITxtOutPutNumNew
		{
			[Token(Token = "0x6003E79")]
			[Address(RVA = "0x416DAE8", Offset = "0x4169AE8", VA = "0x416DAE8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700097C")]
		public TextMeshProUGUI TextMeshProUGUITxtDesNew
		{
			[Token(Token = "0x6003E7A")]
			[Address(RVA = "0x416CEC8", Offset = "0x4168EC8", VA = "0x416CEC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700097D")]
		public ButtonExtend ButtonExtendCityPass
		{
			[Token(Token = "0x6003E7B")]
			[Address(RVA = "0x416F0C0", Offset = "0x416B0C0", VA = "0x416F0C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700097E")]
		public ButtonExtend ButtonExtendIdleInfos
		{
			[Token(Token = "0x6003E7C")]
			[Address(RVA = "0x416F188", Offset = "0x416B188", VA = "0x416F188")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700097F")]
		public TextMeshProUGUI TextMeshProUGUIIdleTime
		{
			[Token(Token = "0x6003E7D")]
			[Address(RVA = "0x416DD00", Offset = "0x4169D00", VA = "0x416DD00")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003E7E")]
		[Address(RVA = "0x416F250", Offset = "0x416B250", VA = "0x416F250")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6003E7F")]
		[Address(RVA = "0x416DDCC", Offset = "0x4169DCC", VA = "0x416DDCC", Slot = "12")]
		protected virtual void OnButtonExtendCityPassClicked()
		{
		}

		[Token(Token = "0x6003E80")]
		[Address(RVA = "0x416DF10", Offset = "0x4169F10", VA = "0x416DF10", Slot = "13")]
		protected virtual void OnButtonExtendIdleInfosClicked()
		{
		}

		[Token(Token = "0x6003E81")]
		[Address(RVA = "0x416CCB8", Offset = "0x4168CB8", VA = "0x416CCB8", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6003E82")]
		[Address(RVA = "0x416DF90", Offset = "0x4169F90", VA = "0x416DF90", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__343))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6003E83")]
		[Address(RVA = "0x416F324", Offset = "0x416B324", VA = "0x416F324", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6003E84")]
		[Address(RVA = "0x416DF84", Offset = "0x4169F84", VA = "0x416DF84")]
		public NewMainCityItemComponents()
		{
		}
	}
}
