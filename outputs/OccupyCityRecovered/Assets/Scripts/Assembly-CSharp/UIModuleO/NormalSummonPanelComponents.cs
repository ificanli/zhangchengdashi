using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using SDKModule;
using Spine.Unity;
using TMPro;
using UIFramework;
using UIModuleO.UIAnim;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000A75")]
	public class NormalSummonPanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A76")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__467 : IAsyncStateMachine
		{
			[Token(Token = "0x4004D4F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004D50")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004D51")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public NormalSummonPanelComponents _003C_003E4__this;

			[Token(Token = "0x4004D52")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6003EF1")]
			[Address(RVA = "0x41751F0", Offset = "0x41711F0", VA = "0x41751F0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003EF2")]
			[Address(RVA = "0x4175468", Offset = "0x4171468", VA = "0x4175468", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004D34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private SkeletonGraphic _skeletonGraphicMagicCircleSkeletonGraphic;

		[Token(Token = "0x4004D35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Image _imageSummonProgress;

		[Token(Token = "0x4004D36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TextMeshProUGUI _textMeshProUGUITxtSummonDes;

		[Token(Token = "0x4004D37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private TextMeshProUGUI _textMeshProUGUITxtSummonLevel;

		[Token(Token = "0x4004D38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private ButtonExtend _buttonExtendBtnSummonDes;

		[Token(Token = "0x4004D39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private TextMeshProUGUI _textMeshProUGUITxtSummonExp;

		[Token(Token = "0x4004D3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private TextMeshProUGUI _textMeshProUGUINormalSummonTimesLimit;

		[Token(Token = "0x4004D3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private RectTransform _rectTransformBtnAdSummon;

		[Token(Token = "0x4004D3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private AdButtonExtend _adButtonExtendBtnAdSummon;

		[Token(Token = "0x4004D3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private RectTransform _rectTransformTxtSummonAd;

		[Token(Token = "0x4004D3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private TextMeshProUGUI _textMeshProUGUITxtSummonAd;

		[Token(Token = "0x4004D3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private RectTransform _rectTransformImgSummonAd;

		[Token(Token = "0x4004D40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private TextMeshProUGUI _textMeshProUGUITxtTimeLeft;

		[Token(Token = "0x4004D41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private TextMeshProUGUI _textMeshProUGUITxtSummonTenAd;

		[Token(Token = "0x4004D42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private RectTransform _rectTransformBtnGemSummonNormal;

		[Token(Token = "0x4004D43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private ButtonExtend _buttonExtendBtnGemSummonNormal;

		[Token(Token = "0x4004D44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private TextMeshProUGUI _textMeshProUGUITxtSummonNormal;

		[Token(Token = "0x4004D45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private TextMeshProUGUI _textMeshProUGUITxtGemSummonNormal;

		[Token(Token = "0x4004D46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private RectTransform _rectTransformSwitchSummonCountNormal;

		[Token(Token = "0x4004D47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Toggle _toggleSwitchSummonCountNormal;

		[Token(Token = "0x4004D48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private TextMeshProUGUI _textMeshProUGUISwitchSummonCountNormalText;

		[Token(Token = "0x4004D49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private ButtonExtend _buttonExtendBtnGemSummon;

		[Token(Token = "0x4004D4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private TextMeshProUGUI _textMeshProUGUITxtSummonTenGem;

		[Token(Token = "0x4004D4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private TextMeshProUGUI _textMeshProUGUITxtGemSummon;

		[Token(Token = "0x4004D4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private RectTransform _rectTransformSwitchSummonCount;

		[Token(Token = "0x4004D4D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Toggle _toggleSwitchSummonCount;

		[Token(Token = "0x4004D4E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private TextMeshProUGUI _textMeshProUGUISwitchSummonCountText;

		[Token(Token = "0x17000986")]
		public SkeletonGraphic SkeletonGraphicMagicCircleSkeletonGraphic
		{
			[Token(Token = "0x6003ECA")]
			[Address(RVA = "0x41739D0", Offset = "0x416F9D0", VA = "0x41739D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000987")]
		public Image ImageSummonProgress
		{
			[Token(Token = "0x6003ECB")]
			[Address(RVA = "0x41723D0", Offset = "0x416E3D0", VA = "0x41723D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000988")]
		public TextMeshProUGUI TextMeshProUGUITxtSummonDes
		{
			[Token(Token = "0x6003ECC")]
			[Address(RVA = "0x4171418", Offset = "0x416D418", VA = "0x4171418")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000989")]
		public TextMeshProUGUI TextMeshProUGUITxtSummonLevel
		{
			[Token(Token = "0x6003ECD")]
			[Address(RVA = "0x4172308", Offset = "0x416E308", VA = "0x4172308")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700098A")]
		public ButtonExtend ButtonExtendBtnSummonDes
		{
			[Token(Token = "0x6003ECE")]
			[Address(RVA = "0x417492C", Offset = "0x417092C", VA = "0x417492C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700098B")]
		public TextMeshProUGUI TextMeshProUGUITxtSummonExp
		{
			[Token(Token = "0x6003ECF")]
			[Address(RVA = "0x4172498", Offset = "0x416E498", VA = "0x4172498")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700098C")]
		public TextMeshProUGUI TextMeshProUGUINormalSummonTimesLimit
		{
			[Token(Token = "0x6003ED0")]
			[Address(RVA = "0x4172DA8", Offset = "0x416EDA8", VA = "0x4172DA8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700098D")]
		public RectTransform RectTransformBtnAdSummon
		{
			[Token(Token = "0x6003ED1")]
			[Address(RVA = "0x4172E70", Offset = "0x416EE70", VA = "0x4172E70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700098E")]
		public AdButtonExtend AdButtonExtendBtnAdSummon
		{
			[Token(Token = "0x6003ED2")]
			[Address(RVA = "0x41706C8", Offset = "0x416C6C8", VA = "0x41706C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700098F")]
		public RectTransform RectTransformTxtSummonAd
		{
			[Token(Token = "0x6003ED3")]
			[Address(RVA = "0x41711C0", Offset = "0x416D1C0", VA = "0x41711C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000990")]
		public TextMeshProUGUI TextMeshProUGUITxtSummonAd
		{
			[Token(Token = "0x6003ED4")]
			[Address(RVA = "0x4171288", Offset = "0x416D288", VA = "0x4171288")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000991")]
		public RectTransform RectTransformImgSummonAd
		{
			[Token(Token = "0x6003ED5")]
			[Address(RVA = "0x41710F8", Offset = "0x416D0F8", VA = "0x41710F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000992")]
		public TextMeshProUGUI TextMeshProUGUITxtTimeLeft
		{
			[Token(Token = "0x6003ED6")]
			[Address(RVA = "0x4172668", Offset = "0x416E668", VA = "0x4172668")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000993")]
		public TextMeshProUGUI TextMeshProUGUITxtSummonTenAd
		{
			[Token(Token = "0x6003ED7")]
			[Address(RVA = "0x4171350", Offset = "0x416D350", VA = "0x4171350")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000994")]
		public RectTransform RectTransformBtnGemSummonNormal
		{
			[Token(Token = "0x6003ED8")]
			[Address(RVA = "0x4172F38", Offset = "0x416EF38", VA = "0x4172F38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000995")]
		public ButtonExtend ButtonExtendBtnGemSummonNormal
		{
			[Token(Token = "0x6003ED9")]
			[Address(RVA = "0x41749F4", Offset = "0x41709F4", VA = "0x41749F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000996")]
		public TextMeshProUGUI TextMeshProUGUITxtSummonNormal
		{
			[Token(Token = "0x6003EDA")]
			[Address(RVA = "0x4171800", Offset = "0x416D800", VA = "0x4171800")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000997")]
		public TextMeshProUGUI TextMeshProUGUITxtGemSummonNormal
		{
			[Token(Token = "0x6003EDB")]
			[Address(RVA = "0x4172C10", Offset = "0x416EC10", VA = "0x4172C10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000998")]
		public RectTransform RectTransformSwitchSummonCountNormal
		{
			[Token(Token = "0x6003EDC")]
			[Address(RVA = "0x4171670", Offset = "0x416D670", VA = "0x4171670")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000999")]
		public Toggle ToggleSwitchSummonCountNormal
		{
			[Token(Token = "0x6003EDD")]
			[Address(RVA = "0x4171A58", Offset = "0x416DA58", VA = "0x4171A58")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700099A")]
		public TextMeshProUGUI TextMeshProUGUISwitchSummonCountNormalText
		{
			[Token(Token = "0x6003EDE")]
			[Address(RVA = "0x41714E0", Offset = "0x416D4E0", VA = "0x41714E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700099B")]
		public ButtonExtend ButtonExtendBtnGemSummon
		{
			[Token(Token = "0x6003EDF")]
			[Address(RVA = "0x4174ABC", Offset = "0x4170ABC", VA = "0x4174ABC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700099C")]
		public TextMeshProUGUI TextMeshProUGUITxtSummonTenGem
		{
			[Token(Token = "0x6003EE0")]
			[Address(RVA = "0x41718C8", Offset = "0x416D8C8", VA = "0x41718C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700099D")]
		public TextMeshProUGUI TextMeshProUGUITxtGemSummon
		{
			[Token(Token = "0x6003EE1")]
			[Address(RVA = "0x4172CD8", Offset = "0x416ECD8", VA = "0x4172CD8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700099E")]
		public RectTransform RectTransformSwitchSummonCount
		{
			[Token(Token = "0x6003EE2")]
			[Address(RVA = "0x4171738", Offset = "0x416D738", VA = "0x4171738")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700099F")]
		public Toggle ToggleSwitchSummonCount
		{
			[Token(Token = "0x6003EE3")]
			[Address(RVA = "0x4171990", Offset = "0x416D990", VA = "0x4171990")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009A0")]
		public TextMeshProUGUI TextMeshProUGUISwitchSummonCountText
		{
			[Token(Token = "0x6003EE4")]
			[Address(RVA = "0x41715A8", Offset = "0x416D5A8", VA = "0x41715A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003EE5")]
		[Address(RVA = "0x4174B84", Offset = "0x4170B84", VA = "0x4174B84")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6003EE6")]
		[Address(RVA = "0x4174D98", Offset = "0x4170D98", VA = "0x4174D98", Slot = "12")]
		protected virtual void OnButtonExtendBtnSummonDesClicked()
		{
		}

		[Token(Token = "0x6003EE7")]
		[Address(RVA = "0x4174E04", Offset = "0x4170E04", VA = "0x4174E04", Slot = "13")]
		protected virtual void OnAdButtonExtendBtnAdSummonClicked()
		{
		}

		[Token(Token = "0x6003EE8")]
		[Address(RVA = "0x4174E70", Offset = "0x4170E70", VA = "0x4174E70", Slot = "14")]
		protected virtual void OnButtonExtendBtnGemSummonNormalClicked()
		{
		}

		[Token(Token = "0x6003EE9")]
		[Address(RVA = "0x4174EDC", Offset = "0x4170EDC", VA = "0x4174EDC", Slot = "15")]
		protected virtual void OnToggleSwitchSummonCountNormalValueChanged(bool arg)
		{
		}

		[Token(Token = "0x6003EEA")]
		[Address(RVA = "0x4174F88", Offset = "0x4170F88", VA = "0x4174F88", Slot = "16")]
		protected virtual void OnButtonExtendBtnGemSummonClicked()
		{
		}

		[Token(Token = "0x6003EEB")]
		[Address(RVA = "0x4174FF4", Offset = "0x4170FF4", VA = "0x4174FF4", Slot = "17")]
		protected virtual void OnToggleSwitchSummonCountValueChanged(bool arg)
		{
		}

		[Token(Token = "0x6003EEC")]
		[Address(RVA = "0x41706AC", Offset = "0x416C6AC", VA = "0x41706AC", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6003EED")]
		[Address(RVA = "0x41750A0", Offset = "0x41710A0", VA = "0x41750A0", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__467))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6003EEE")]
		[Address(RVA = "0x4175134", Offset = "0x4171134", VA = "0x4175134", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6003EEF")]
		[Address(RVA = "0x4173634", Offset = "0x416F634", VA = "0x4173634")]
		public NormalSummonPanelComponents()
		{
		}
	}
}
