using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UIFramework;
using UIModuleO.UIAnim;

namespace UIModuleO
{
	[Token(Token = "0x2000C15")]
	public class WeeklyClashPanel_PreparationStatusComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000C16")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__108 : IAsyncStateMachine
		{
			[Token(Token = "0x4005747")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005748")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005749")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public WeeklyClashPanel_PreparationStatusComponents _003C_003E4__this;

			[Token(Token = "0x400574A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6004AE4")]
			[Address(RVA = "0x42617F0", Offset = "0x425D7F0", VA = "0x42617F0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004AE5")]
			[Address(RVA = "0x4261A68", Offset = "0x425DA68", VA = "0x4261A68", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4005744")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TextMeshProUGUI _textMeshProUGUIRequirementsText;

		[Token(Token = "0x4005745")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TextMeshProUGUI _textMeshProUGUIRequirementsText2;

		[Token(Token = "0x4005746")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private ButtonExtend _buttonExtendRequirementsBtn;

		[Token(Token = "0x17000D32")]
		public TextMeshProUGUI TextMeshProUGUIRequirementsText
		{
			[Token(Token = "0x6004ADA")]
			[Address(RVA = "0x426142C", Offset = "0x425D42C", VA = "0x426142C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D33")]
		public TextMeshProUGUI TextMeshProUGUIRequirementsText2
		{
			[Token(Token = "0x6004ADB")]
			[Address(RVA = "0x42614F4", Offset = "0x425D4F4", VA = "0x42614F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D34")]
		public ButtonExtend ButtonExtendRequirementsBtn
		{
			[Token(Token = "0x6004ADC")]
			[Address(RVA = "0x42615C8", Offset = "0x425D5C8", VA = "0x42615C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004ADD")]
		[Address(RVA = "0x4261690", Offset = "0x425D690", VA = "0x4261690")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6004ADE")]
		[Address(RVA = "0x4260E08", Offset = "0x425CE08", VA = "0x4260E08", Slot = "12")]
		protected virtual void OnButtonExtendRequirementsBtnClicked()
		{
		}

		[Token(Token = "0x6004ADF")]
		[Address(RVA = "0x4261718", Offset = "0x425D718", VA = "0x4261718", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6004AE0")]
		[Address(RVA = "0x4260E88", Offset = "0x425CE88", VA = "0x4260E88", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__108))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6004AE1")]
		[Address(RVA = "0x4261734", Offset = "0x425D734", VA = "0x4261734", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6004AE2")]
		[Address(RVA = "0x4260E7C", Offset = "0x425CE7C", VA = "0x4260E7C")]
		public WeeklyClashPanel_PreparationStatusComponents()
		{
		}
	}
}
