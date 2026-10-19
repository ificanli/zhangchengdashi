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
	[Token(Token = "0x2000BEE")]
	public class UpgradeTalentPanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000BEF")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__218 : IAsyncStateMachine
		{
			[Token(Token = "0x400567E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400567F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005680")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UpgradeTalentPanelComponents _003C_003E4__this;

			[Token(Token = "0x4005681")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x60049C7")]
			[Address(RVA = "0x424F0A4", Offset = "0x424B0A4", VA = "0x424F0A4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60049C8")]
			[Address(RVA = "0x424F31C", Offset = "0x424B31C", VA = "0x424F31C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4005671")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ButtonExtend _buttonExtendBg;

		[Token(Token = "0x4005672")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private ButtonExtend _buttonExtendBtnUpgradeTalentClose;

		[Token(Token = "0x4005673")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TextMeshProUGUI _textMeshProUGUITxtTalentDes1;

		[Token(Token = "0x4005674")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Image _imageImgArrowHead;

		[Token(Token = "0x4005675")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private TextMeshProUGUI _textMeshProUGUITxtTalentDes2;

		[Token(Token = "0x4005676")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private TextMeshProUGUI _textMeshProUGUITxtTalentDes;

		[Token(Token = "0x4005677")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private RectTransform _rectTransformImgTalentUpgradeIcon;

		[Token(Token = "0x4005678")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Image _imageImgTalentUpgradeIcon;

		[Token(Token = "0x4005679")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private TextMeshProUGUI _textMeshProUGUITxtTalentUpgradeName;

		[Token(Token = "0x400567A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private ButtonExtend _buttonExtendBtnUpgradeTalent;

		[Token(Token = "0x400567B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private TextMeshProUGUI _textMeshProUGUITxtUnLock;

		[Token(Token = "0x400567C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private TextMeshProUGUI _textMeshProUGUITxtUpgradeRequireTalentDotNum;

		[Token(Token = "0x400567D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private TextMeshProUGUI _textMeshProUGUITxtUnLockTip;

		[Token(Token = "0x17000CE0")]
		public ButtonExtend ButtonExtendBg
		{
			[Token(Token = "0x60049B1")]
			[Address(RVA = "0x424ED24", Offset = "0x424AD24", VA = "0x424ED24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CE1")]
		public ButtonExtend ButtonExtendBtnUpgradeTalentClose
		{
			[Token(Token = "0x60049B2")]
			[Address(RVA = "0x424EDEC", Offset = "0x424ADEC", VA = "0x424EDEC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CE2")]
		public TextMeshProUGUI TextMeshProUGUITxtTalentDes1
		{
			[Token(Token = "0x60049B3")]
			[Address(RVA = "0x424E6D8", Offset = "0x424A6D8", VA = "0x424E6D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CE3")]
		public Image ImageImgArrowHead
		{
			[Token(Token = "0x60049B4")]
			[Address(RVA = "0x424E548", Offset = "0x424A548", VA = "0x424E548")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CE4")]
		public TextMeshProUGUI TextMeshProUGUITxtTalentDes2
		{
			[Token(Token = "0x60049B5")]
			[Address(RVA = "0x424E7A0", Offset = "0x424A7A0", VA = "0x424E7A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CE5")]
		public TextMeshProUGUI TextMeshProUGUITxtTalentDes
		{
			[Token(Token = "0x60049B6")]
			[Address(RVA = "0x424E610", Offset = "0x424A610", VA = "0x424E610")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CE6")]
		public RectTransform RectTransformImgTalentUpgradeIcon
		{
			[Token(Token = "0x60049B7")]
			[Address(RVA = "0x424C990", Offset = "0x4248990", VA = "0x424C990")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CE7")]
		public Image ImageImgTalentUpgradeIcon
		{
			[Token(Token = "0x60049B8")]
			[Address(RVA = "0x424EC50", Offset = "0x424AC50", VA = "0x424EC50")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CE8")]
		public TextMeshProUGUI TextMeshProUGUITxtTalentUpgradeName
		{
			[Token(Token = "0x60049B9")]
			[Address(RVA = "0x424E868", Offset = "0x424A868", VA = "0x424E868")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CE9")]
		public ButtonExtend ButtonExtendBtnUpgradeTalent
		{
			[Token(Token = "0x60049BA")]
			[Address(RVA = "0x424E930", Offset = "0x424A930", VA = "0x424E930")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CEA")]
		public TextMeshProUGUI TextMeshProUGUITxtUnLock
		{
			[Token(Token = "0x60049BB")]
			[Address(RVA = "0x424EB88", Offset = "0x424AB88", VA = "0x424EB88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CEB")]
		public TextMeshProUGUI TextMeshProUGUITxtUpgradeRequireTalentDotNum
		{
			[Token(Token = "0x60049BC")]
			[Address(RVA = "0x424EAC0", Offset = "0x424AAC0", VA = "0x424EAC0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CEC")]
		public TextMeshProUGUI TextMeshProUGUITxtUnLockTip
		{
			[Token(Token = "0x60049BD")]
			[Address(RVA = "0x424E9F8", Offset = "0x424A9F8", VA = "0x424E9F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60049BE")]
		[Address(RVA = "0x424EEB4", Offset = "0x424AEB4", VA = "0x424EEB4")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x60049BF")]
		[Address(RVA = "0x424CB04", Offset = "0x4248B04", VA = "0x424CB04", Slot = "12")]
		protected virtual void OnButtonExtendBgClicked()
		{
		}

		[Token(Token = "0x60049C0")]
		[Address(RVA = "0x424CA78", Offset = "0x4248A78", VA = "0x424CA78", Slot = "13")]
		protected virtual void OnButtonExtendBtnUpgradeTalentCloseClicked()
		{
		}

		[Token(Token = "0x60049C1")]
		[Address(RVA = "0x424C924", Offset = "0x4248924", VA = "0x424C924", Slot = "14")]
		protected virtual void OnButtonExtendBtnUpgradeTalentClicked()
		{
		}

		[Token(Token = "0x60049C2")]
		[Address(RVA = "0x424EFCC", Offset = "0x424AFCC", VA = "0x424EFCC", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60049C3")]
		[Address(RVA = "0x424CB84", Offset = "0x4248B84", VA = "0x424CB84", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__218))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60049C4")]
		[Address(RVA = "0x424EFE8", Offset = "0x424AFE8", VA = "0x424EFE8", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x60049C5")]
		[Address(RVA = "0x424CB78", Offset = "0x4248B78", VA = "0x424CB78")]
		public UpgradeTalentPanelComponents()
		{
		}
	}
}
