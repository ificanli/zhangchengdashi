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
	[Token(Token = "0x2000BD6")]
	public class UnLockArenaTipPanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000BD7")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__318 : IAsyncStateMachine
		{
			[Token(Token = "0x40055FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40055FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40055FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UnLockArenaTipPanelComponents _003C_003E4__this;

			[Token(Token = "0x4005600")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x600492A")]
			[Address(RVA = "0x4244FE4", Offset = "0x4240FE4", VA = "0x4244FE4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600492B")]
			[Address(RVA = "0x424525C", Offset = "0x424125C", VA = "0x424525C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40055E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Image _imageBG;

		[Token(Token = "0x40055E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RectTransform _rectTransformImgEff;

		[Token(Token = "0x40055E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private RectTransform _rectTransformImgArenaIcon;

		[Token(Token = "0x40055E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Image _imageImgArenaIcon;

		[Token(Token = "0x40055E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private TextMeshProUGUI _textMeshProUGUITxtArena;

		[Token(Token = "0x40055E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private RectTransform _rectTransformTxtArenaComplete;

		[Token(Token = "0x40055E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private TextMeshProUGUI _textMeshProUGUITxtArenaComplete;

		[Token(Token = "0x40055EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private RectTransform _rectTransformImgCoinRewardBg;

		[Token(Token = "0x40055EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private TextMeshProUGUI _textMeshProUGUITxtCoinNum;

		[Token(Token = "0x40055EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Image _imageImgCoinDuiHao;

		[Token(Token = "0x40055ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private RectTransform _rectTransformImgGemRewardBg;

		[Token(Token = "0x40055EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private TextMeshProUGUI _textMeshProUGUITxtGemNum;

		[Token(Token = "0x40055EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Image _imageImgGemDuiHao;

		[Token(Token = "0x40055F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Image _imageImgBoxIcon;

		[Token(Token = "0x40055F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Image _imageImgBoxDuiHao;

		[Token(Token = "0x40055F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private RectTransform _rectTransformTxtUnLockOrRewardBg;

		[Token(Token = "0x40055F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private TextMeshProUGUI _textMeshProUGUITxtUnLockOrRewardBg;

		[Token(Token = "0x40055F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private RectTransform _rectTransformImgRewardRoot;

		[Token(Token = "0x40055F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Image _imageImgRewardRoot;

		[Token(Token = "0x40055F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private ButtonExtend _buttonExtendBtnRewardOne;

		[Token(Token = "0x40055F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private ButtonExtend _buttonExtendBtnRewardTwo;

		[Token(Token = "0x40055F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private ButtonExtend _buttonExtendBtnRewardThere;

		[Token(Token = "0x40055F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private TextMeshProUGUI _textMeshProUGUITxtArtifact;

		[Token(Token = "0x40055FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private RectTransform _rectTransformBtnClaim;

		[Token(Token = "0x40055FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private ButtonExtend _buttonExtendBtnClaim;

		[Token(Token = "0x40055FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private TextMeshProUGUI _textMeshProUGUITxtClaim;

		[Token(Token = "0x17000CAC")]
		public Image ImageBG
		{
			[Token(Token = "0x6004906")]
			[Address(RVA = "0x4243BB8", Offset = "0x423FBB8", VA = "0x4243BB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CAD")]
		public RectTransform RectTransformImgEff
		{
			[Token(Token = "0x6004907")]
			[Address(RVA = "0x424477C", Offset = "0x424077C", VA = "0x424477C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CAE")]
		public RectTransform RectTransformImgArenaIcon
		{
			[Token(Token = "0x6004908")]
			[Address(RVA = "0x4243C80", Offset = "0x423FC80", VA = "0x4243C80")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CAF")]
		public Image ImageImgArenaIcon
		{
			[Token(Token = "0x6004909")]
			[Address(RVA = "0x42445E0", Offset = "0x42405E0", VA = "0x42445E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CB0")]
		public TextMeshProUGUI TextMeshProUGUITxtArena
		{
			[Token(Token = "0x600490A")]
			[Address(RVA = "0x4243708", Offset = "0x423F708", VA = "0x4243708")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CB1")]
		public RectTransform RectTransformTxtArenaComplete
		{
			[Token(Token = "0x600490B")]
			[Address(RVA = "0x4243D48", Offset = "0x423FD48", VA = "0x4243D48")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CB2")]
		public TextMeshProUGUI TextMeshProUGUITxtArenaComplete
		{
			[Token(Token = "0x600490C")]
			[Address(RVA = "0x42437D0", Offset = "0x423F7D0", VA = "0x42437D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CB3")]
		public RectTransform RectTransformImgCoinRewardBg
		{
			[Token(Token = "0x600490D")]
			[Address(RVA = "0x4244844", Offset = "0x4240844", VA = "0x4244844")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CB4")]
		public TextMeshProUGUI TextMeshProUGUITxtCoinNum
		{
			[Token(Token = "0x600490E")]
			[Address(RVA = "0x4243A28", Offset = "0x423FA28", VA = "0x4243A28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CB5")]
		public Image ImageImgCoinDuiHao
		{
			[Token(Token = "0x600490F")]
			[Address(RVA = "0x4244068", Offset = "0x4240068", VA = "0x4244068")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CB6")]
		public RectTransform RectTransformImgGemRewardBg
		{
			[Token(Token = "0x6004910")]
			[Address(RVA = "0x424490C", Offset = "0x424090C", VA = "0x424490C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CB7")]
		public TextMeshProUGUI TextMeshProUGUITxtGemNum
		{
			[Token(Token = "0x6004911")]
			[Address(RVA = "0x4243AF0", Offset = "0x423FAF0", VA = "0x4243AF0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CB8")]
		public Image ImageImgGemDuiHao
		{
			[Token(Token = "0x6004912")]
			[Address(RVA = "0x4243FA0", Offset = "0x423FFA0", VA = "0x4243FA0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CB9")]
		public Image ImageImgBoxIcon
		{
			[Token(Token = "0x6004913")]
			[Address(RVA = "0x42446A8", Offset = "0x42406A8", VA = "0x42446A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CBA")]
		public Image ImageImgBoxDuiHao
		{
			[Token(Token = "0x6004914")]
			[Address(RVA = "0x4244130", Offset = "0x4240130", VA = "0x4244130")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CBB")]
		public RectTransform RectTransformTxtUnLockOrRewardBg
		{
			[Token(Token = "0x6004915")]
			[Address(RVA = "0x4243E10", Offset = "0x423FE10", VA = "0x4243E10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CBC")]
		public TextMeshProUGUI TextMeshProUGUITxtUnLockOrRewardBg
		{
			[Token(Token = "0x6004916")]
			[Address(RVA = "0x42441F8", Offset = "0x42401F8", VA = "0x42441F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CBD")]
		public RectTransform RectTransformImgRewardRoot
		{
			[Token(Token = "0x6004917")]
			[Address(RVA = "0x42449D4", Offset = "0x42409D4", VA = "0x42449D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CBE")]
		public Image ImageImgRewardRoot
		{
			[Token(Token = "0x6004918")]
			[Address(RVA = "0x42442C0", Offset = "0x42402C0", VA = "0x42442C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CBF")]
		public ButtonExtend ButtonExtendBtnRewardOne
		{
			[Token(Token = "0x6004919")]
			[Address(RVA = "0x4244388", Offset = "0x4240388", VA = "0x4244388")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CC0")]
		public ButtonExtend ButtonExtendBtnRewardTwo
		{
			[Token(Token = "0x600491A")]
			[Address(RVA = "0x4244450", Offset = "0x4240450", VA = "0x4244450")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CC1")]
		public ButtonExtend ButtonExtendBtnRewardThere
		{
			[Token(Token = "0x600491B")]
			[Address(RVA = "0x4244518", Offset = "0x4240518", VA = "0x4244518")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CC2")]
		public TextMeshProUGUI TextMeshProUGUITxtArtifact
		{
			[Token(Token = "0x600491C")]
			[Address(RVA = "0x4243960", Offset = "0x423F960", VA = "0x4243960")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CC3")]
		public RectTransform RectTransformBtnClaim
		{
			[Token(Token = "0x600491D")]
			[Address(RVA = "0x4243ED8", Offset = "0x423FED8", VA = "0x4243ED8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CC4")]
		public ButtonExtend ButtonExtendBtnClaim
		{
			[Token(Token = "0x600491E")]
			[Address(RVA = "0x4244A9C", Offset = "0x4240A9C", VA = "0x4244A9C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CC5")]
		public TextMeshProUGUI TextMeshProUGUITxtClaim
		{
			[Token(Token = "0x600491F")]
			[Address(RVA = "0x4243898", Offset = "0x423F898", VA = "0x4243898")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004920")]
		[Address(RVA = "0x4244B64", Offset = "0x4240B64", VA = "0x4244B64")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6004921")]
		[Address(RVA = "0x4244CC0", Offset = "0x4240CC0", VA = "0x4244CC0", Slot = "12")]
		protected virtual void OnButtonExtendBtnRewardOneClicked()
		{
		}

		[Token(Token = "0x6004922")]
		[Address(RVA = "0x4244D2C", Offset = "0x4240D2C", VA = "0x4244D2C", Slot = "13")]
		protected virtual void OnButtonExtendBtnRewardTwoClicked()
		{
		}

		[Token(Token = "0x6004923")]
		[Address(RVA = "0x4244D98", Offset = "0x4240D98", VA = "0x4244D98", Slot = "14")]
		protected virtual void OnButtonExtendBtnRewardThereClicked()
		{
		}

		[Token(Token = "0x6004924")]
		[Address(RVA = "0x4244E04", Offset = "0x4240E04", VA = "0x4244E04", Slot = "15")]
		protected virtual void OnButtonExtendBtnClaimClicked()
		{
		}

		[Token(Token = "0x6004925")]
		[Address(RVA = "0x4244E70", Offset = "0x4240E70", VA = "0x4244E70", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6004926")]
		[Address(RVA = "0x4244E8C", Offset = "0x4240E8C", VA = "0x4244E8C", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__318))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6004927")]
		[Address(RVA = "0x4244F20", Offset = "0x4240F20", VA = "0x4244F20", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6004928")]
		[Address(RVA = "0x4244FD4", Offset = "0x4240FD4", VA = "0x4244FD4")]
		public UnLockArenaTipPanelComponents()
		{
		}
	}
}
