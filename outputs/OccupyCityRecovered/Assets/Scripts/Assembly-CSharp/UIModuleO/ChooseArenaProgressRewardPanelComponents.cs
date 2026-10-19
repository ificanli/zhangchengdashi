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
	[Token(Token = "0x20007DF")]
	public class ChooseArenaProgressRewardPanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20007E0")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__667 : IAsyncStateMachine
		{
			[Token(Token = "0x4003CBF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003CC0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003CC1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ChooseArenaProgressRewardPanelComponents _003C_003E4__this;

			[Token(Token = "0x4003CC2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6002BEB")]
			[Address(RVA = "0x3FF3544", Offset = "0x3FEF544", VA = "0x3FF3544", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002BEC")]
			[Address(RVA = "0x3FF37BC", Offset = "0x3FEF7BC", VA = "0x3FF37BC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003CB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ButtonExtend _buttonExtendBG;

		[Token(Token = "0x4003CB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RectTransform _rectTransformImgBg;

		[Token(Token = "0x4003CB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TextMeshProUGUI _textMeshProUGUITxtChooseOne;

		[Token(Token = "0x4003CB7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private ButtonExtend _buttonExtendBTnConfirm;

		[Token(Token = "0x4003CB8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private TextMeshProUGUI _textMeshProUGUITxtConfirm;

		[Token(Token = "0x4003CB9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private ButtonExtend _buttonExtendBtnChooseOne;

		[Token(Token = "0x4003CBA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Image _imageImgChooseOneEff;

		[Token(Token = "0x4003CBB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private ButtonExtend _buttonExtendBtnChooseTwo;

		[Token(Token = "0x4003CBC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Image _imageImgChooseTwoEff;

		[Token(Token = "0x4003CBD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private ButtonExtend _buttonExtendBtnChooseThere;

		[Token(Token = "0x4003CBE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Image _imageImgChooseThereEff;

		[Token(Token = "0x170004B6")]
		public ButtonExtend ButtonExtendBG
		{
			[Token(Token = "0x6002BD5")]
			[Address(RVA = "0x3FF2F00", Offset = "0x3FEEF00", VA = "0x3FF2F00")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004B7")]
		public RectTransform RectTransformImgBg
		{
			[Token(Token = "0x6002BD6")]
			[Address(RVA = "0x3FF1510", Offset = "0x3FED510", VA = "0x3FF1510")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004B8")]
		public TextMeshProUGUI TextMeshProUGUITxtChooseOne
		{
			[Token(Token = "0x6002BD7")]
			[Address(RVA = "0x3FF1948", Offset = "0x3FED948", VA = "0x3FF1948")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004B9")]
		public ButtonExtend ButtonExtendBTnConfirm
		{
			[Token(Token = "0x6002BD8")]
			[Address(RVA = "0x3FF2FC8", Offset = "0x3FEEFC8", VA = "0x3FF2FC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004BA")]
		public TextMeshProUGUI TextMeshProUGUITxtConfirm
		{
			[Token(Token = "0x6002BD9")]
			[Address(RVA = "0x3FF1A10", Offset = "0x3FEDA10", VA = "0x3FF1A10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004BB")]
		public ButtonExtend ButtonExtendBtnChooseOne
		{
			[Token(Token = "0x6002BDA")]
			[Address(RVA = "0x3FF3090", Offset = "0x3FEF090", VA = "0x3FF3090")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004BC")]
		public Image ImageImgChooseOneEff
		{
			[Token(Token = "0x6002BDB")]
			[Address(RVA = "0x3FF1B68", Offset = "0x3FEDB68", VA = "0x3FF1B68")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004BD")]
		public ButtonExtend ButtonExtendBtnChooseTwo
		{
			[Token(Token = "0x6002BDC")]
			[Address(RVA = "0x3FF3158", Offset = "0x3FEF158", VA = "0x3FF3158")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004BE")]
		public Image ImageImgChooseTwoEff
		{
			[Token(Token = "0x6002BDD")]
			[Address(RVA = "0x3FF1C30", Offset = "0x3FEDC30", VA = "0x3FF1C30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004BF")]
		public ButtonExtend ButtonExtendBtnChooseThere
		{
			[Token(Token = "0x6002BDE")]
			[Address(RVA = "0x3FF3220", Offset = "0x3FEF220", VA = "0x3FF3220")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004C0")]
		public Image ImageImgChooseThereEff
		{
			[Token(Token = "0x6002BDF")]
			[Address(RVA = "0x3FF1CF8", Offset = "0x3FEDCF8", VA = "0x3FF1CF8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002BE0")]
		[Address(RVA = "0x3FF32E8", Offset = "0x3FEF2E8", VA = "0x3FF32E8")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6002BE1")]
		[Address(RVA = "0x3FF1DE0", Offset = "0x3FEDDE0", VA = "0x3FF1DE0", Slot = "12")]
		protected virtual void OnButtonExtendBGClicked()
		{
		}

		[Token(Token = "0x6002BE2")]
		[Address(RVA = "0x3FF212C", Offset = "0x3FEE12C", VA = "0x3FF212C", Slot = "13")]
		protected virtual void OnButtonExtendBTnConfirmClicked()
		{
		}

		[Token(Token = "0x6002BE3")]
		[Address(RVA = "0x3FF1E68", Offset = "0x3FEDE68", VA = "0x3FF1E68", Slot = "14")]
		protected virtual void OnButtonExtendBtnChooseOneClicked()
		{
		}

		[Token(Token = "0x6002BE4")]
		[Address(RVA = "0x3FF1EF4", Offset = "0x3FEDEF4", VA = "0x3FF1EF4", Slot = "15")]
		protected virtual void OnButtonExtendBtnChooseTwoClicked()
		{
		}

		[Token(Token = "0x6002BE5")]
		[Address(RVA = "0x3FF1F80", Offset = "0x3FEDF80", VA = "0x3FF1F80", Slot = "16")]
		protected virtual void OnButtonExtendBtnChooseThereClicked()
		{
		}

		[Token(Token = "0x6002BE6")]
		[Address(RVA = "0x3FF14F4", Offset = "0x3FED4F4", VA = "0x3FF14F4", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6002BE7")]
		[Address(RVA = "0x3FF2094", Offset = "0x3FEE094", VA = "0x3FF2094", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__667))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6002BE8")]
		[Address(RVA = "0x3FF3488", Offset = "0x3FEF488", VA = "0x3FF3488", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6002BE9")]
		[Address(RVA = "0x3FF2088", Offset = "0x3FEE088", VA = "0x3FF2088")]
		public ChooseArenaProgressRewardPanelComponents()
		{
		}
	}
}
