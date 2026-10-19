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
	[Token(Token = "0x2000A8A")]
	public class OpenBoxPanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A8B")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__622 : IAsyncStateMachine
		{
			[Token(Token = "0x4004DF3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004DF4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004DF5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public OpenBoxPanelComponents _003C_003E4__this;

			[Token(Token = "0x4004DF6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6003FB0")]
			[Address(RVA = "0x419C640", Offset = "0x4198640", VA = "0x419C640", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003FB1")]
			[Address(RVA = "0x419C8B8", Offset = "0x41988B8", VA = "0x419C8B8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004DCE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Button _buttonBg;

		[Token(Token = "0x4004DCF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RectTransform _rectTransformRoot;

		[Token(Token = "0x4004DD0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TextMeshProUGUI _textMeshProUGUITxtBoxName;

		[Token(Token = "0x4004DD1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private ButtonExtend _buttonExtendBtnClose;

		[Token(Token = "0x4004DD2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private RectTransform _rectTransformBtnFeeDiamondToUnLock;

		[Token(Token = "0x4004DD3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private ButtonExtend _buttonExtendBtnFeeDiamondToUnLock;

		[Token(Token = "0x4004DD4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private TextMeshProUGUI _textMeshProUGUITxtDiamondOpen;

		[Token(Token = "0x4004DD5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private TextMeshProUGUI _textMeshProUGUITxtDiamondNum;

		[Token(Token = "0x4004DD6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private AdButtonExtend _adButtonExtendBtnAd;

		[Token(Token = "0x4004DD7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private RectTransform _rectTransformText;

		[Token(Token = "0x4004DD8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private TextMeshProUGUI _textMeshProUGUIText;

		[Token(Token = "0x4004DD9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Image _imageImgAd;

		[Token(Token = "0x4004DDA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private SkeletonGraphic _skeletonGraphicBox;

		[Token(Token = "0x4004DDB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private TextMeshProUGUI _textMeshProUGUITxtBoxDes1;

		[Token(Token = "0x4004DDC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private TextMeshProUGUI _textMeshProUGUITxtBoxDes2;

		[Token(Token = "0x4004DDD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private TextMeshProUGUI _textMeshProUGUITxtArena;

		[Token(Token = "0x4004DDE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private RectTransform _rectTransformLayout;

		[Token(Token = "0x4004DDF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private TextMeshProUGUI _textMeshProUGUITxtCoinNum;

		[Token(Token = "0x4004DE0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private TextMeshProUGUI _textMeshProUGUITxtCoinDes;

		[Token(Token = "0x4004DE1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private TextMeshProUGUI _textMeshProUGUITxtWoodNum;

		[Token(Token = "0x4004DE2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private TextMeshProUGUI _textMeshProUGUITxtWoodDes;

		[Token(Token = "0x4004DE3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private RectTransform _rectTransformImgCrystalRewardBg;

		[Token(Token = "0x4004DE4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private TextMeshProUGUI _textMeshProUGUITxtCrystalNum;

		[Token(Token = "0x4004DE5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private TextMeshProUGUI _textMeshProUGUITxtCrystalDes;

		[Token(Token = "0x4004DE6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private TextMeshProUGUI _textMeshProUGUITxtContains;

		[Token(Token = "0x4004DE7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private TextMeshProUGUI _textMeshProUGUITxtCommon;

		[Token(Token = "0x4004DE8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private TextMeshProUGUI _textMeshProUGUITxtCommonCount;

		[Token(Token = "0x4004DE9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private TextMeshProUGUI _textMeshProUGUITxtRare;

		[Token(Token = "0x4004DEA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private TextMeshProUGUI _textMeshProUGUITxtRareCount;

		[Token(Token = "0x4004DEB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private TextMeshProUGUI _textMeshProUGUITxtEpic;

		[Token(Token = "0x4004DEC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private TextMeshProUGUI _textMeshProUGUITxtEpicCount;

		[Token(Token = "0x4004DED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private TextMeshProUGUI _textMeshProUGUITxtGold;

		[Token(Token = "0x4004DEE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private TextMeshProUGUI _textMeshProUGUITxtGoldCount;

		[Token(Token = "0x4004DEF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private RectTransform _rectTransformBtnUnLock;

		[Token(Token = "0x4004DF0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private ButtonExtend _buttonExtendBtnUnLock;

		[Token(Token = "0x4004DF1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private TextMeshProUGUI _textMeshProUGUITxtUnLock;

		[Token(Token = "0x4004DF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private TextMeshProUGUI _textMeshProUGUITxtUnLockTime;

		[Token(Token = "0x170009BF")]
		public Button ButtonBg
		{
			[Token(Token = "0x6003F80")]
			[Address(RVA = "0x419B0A8", Offset = "0x41970A8", VA = "0x419B0A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009C0")]
		public RectTransform RectTransformRoot
		{
			[Token(Token = "0x6003F81")]
			[Address(RVA = "0x419B170", Offset = "0x4197170", VA = "0x419B170")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009C1")]
		public TextMeshProUGUI TextMeshProUGUITxtBoxName
		{
			[Token(Token = "0x6003F82")]
			[Address(RVA = "0x419A41C", Offset = "0x419641C", VA = "0x419A41C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009C2")]
		public ButtonExtend ButtonExtendBtnClose
		{
			[Token(Token = "0x6003F83")]
			[Address(RVA = "0x419B238", Offset = "0x4197238", VA = "0x419B238")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009C3")]
		public RectTransform RectTransformBtnFeeDiamondToUnLock
		{
			[Token(Token = "0x6003F84")]
			[Address(RVA = "0x419B300", Offset = "0x4197300", VA = "0x419B300")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009C4")]
		public ButtonExtend ButtonExtendBtnFeeDiamondToUnLock
		{
			[Token(Token = "0x6003F85")]
			[Address(RVA = "0x419B3C8", Offset = "0x41973C8", VA = "0x419B3C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009C5")]
		public TextMeshProUGUI TextMeshProUGUITxtDiamondOpen
		{
			[Token(Token = "0x6003F86")]
			[Address(RVA = "0x419A994", Offset = "0x4196994", VA = "0x419A994")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009C6")]
		public TextMeshProUGUI TextMeshProUGUITxtDiamondNum
		{
			[Token(Token = "0x6003F87")]
			[Address(RVA = "0x419A674", Offset = "0x4196674", VA = "0x419A674")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009C7")]
		public AdButtonExtend AdButtonExtendBtnAd
		{
			[Token(Token = "0x6003F88")]
			[Address(RVA = "0x419B490", Offset = "0x4197490", VA = "0x419B490")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009C8")]
		public RectTransform RectTransformText
		{
			[Token(Token = "0x6003F89")]
			[Address(RVA = "0x419B558", Offset = "0x4197558", VA = "0x419B558")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009C9")]
		public TextMeshProUGUI TextMeshProUGUIText
		{
			[Token(Token = "0x6003F8A")]
			[Address(RVA = "0x419B620", Offset = "0x4197620", VA = "0x419B620")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009CA")]
		public Image ImageImgAd
		{
			[Token(Token = "0x6003F8B")]
			[Address(RVA = "0x419B6E8", Offset = "0x41976E8", VA = "0x419B6E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009CB")]
		public SkeletonGraphic SkeletonGraphicBox
		{
			[Token(Token = "0x6003F8C")]
			[Address(RVA = "0x419B7B0", Offset = "0x41977B0", VA = "0x419B7B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009CC")]
		public TextMeshProUGUI TextMeshProUGUITxtBoxDes1
		{
			[Token(Token = "0x6003F8D")]
			[Address(RVA = "0x419A73C", Offset = "0x419673C", VA = "0x419A73C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009CD")]
		public TextMeshProUGUI TextMeshProUGUITxtBoxDes2
		{
			[Token(Token = "0x6003F8E")]
			[Address(RVA = "0x419A804", Offset = "0x4196804", VA = "0x419A804")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009CE")]
		public TextMeshProUGUI TextMeshProUGUITxtArena
		{
			[Token(Token = "0x6003F8F")]
			[Address(RVA = "0x419A4E4", Offset = "0x41964E4", VA = "0x419A4E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009CF")]
		public RectTransform RectTransformLayout
		{
			[Token(Token = "0x6003F90")]
			[Address(RVA = "0x419B878", Offset = "0x4197878", VA = "0x419B878")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009D0")]
		public TextMeshProUGUI TextMeshProUGUITxtCoinNum
		{
			[Token(Token = "0x6003F91")]
			[Address(RVA = "0x419B940", Offset = "0x4197940", VA = "0x419B940")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009D1")]
		public TextMeshProUGUI TextMeshProUGUITxtCoinDes
		{
			[Token(Token = "0x6003F92")]
			[Address(RVA = "0x419AE44", Offset = "0x4196E44", VA = "0x419AE44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009D2")]
		public TextMeshProUGUI TextMeshProUGUITxtWoodNum
		{
			[Token(Token = "0x6003F93")]
			[Address(RVA = "0x419BA08", Offset = "0x4197A08", VA = "0x419BA08")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009D3")]
		public TextMeshProUGUI TextMeshProUGUITxtWoodDes
		{
			[Token(Token = "0x6003F94")]
			[Address(RVA = "0x419AF0C", Offset = "0x4196F0C", VA = "0x419AF0C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009D4")]
		public RectTransform RectTransformImgCrystalRewardBg
		{
			[Token(Token = "0x6003F95")]
			[Address(RVA = "0x419BAD0", Offset = "0x4197AD0", VA = "0x419BAD0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009D5")]
		public TextMeshProUGUI TextMeshProUGUITxtCrystalNum
		{
			[Token(Token = "0x6003F96")]
			[Address(RVA = "0x419BB98", Offset = "0x4197B98", VA = "0x419BB98")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009D6")]
		public TextMeshProUGUI TextMeshProUGUITxtCrystalDes
		{
			[Token(Token = "0x6003F97")]
			[Address(RVA = "0x419AFD4", Offset = "0x4196FD4", VA = "0x419AFD4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009D7")]
		public TextMeshProUGUI TextMeshProUGUITxtContains
		{
			[Token(Token = "0x6003F98")]
			[Address(RVA = "0x419AA5C", Offset = "0x4196A5C", VA = "0x419AA5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009D8")]
		public TextMeshProUGUI TextMeshProUGUITxtCommon
		{
			[Token(Token = "0x6003F99")]
			[Address(RVA = "0x419AB24", Offset = "0x4196B24", VA = "0x419AB24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009D9")]
		public TextMeshProUGUI TextMeshProUGUITxtCommonCount
		{
			[Token(Token = "0x6003F9A")]
			[Address(RVA = "0x419BC60", Offset = "0x4197C60", VA = "0x419BC60")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009DA")]
		public TextMeshProUGUI TextMeshProUGUITxtRare
		{
			[Token(Token = "0x6003F9B")]
			[Address(RVA = "0x419ABEC", Offset = "0x4196BEC", VA = "0x419ABEC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009DB")]
		public TextMeshProUGUI TextMeshProUGUITxtRareCount
		{
			[Token(Token = "0x6003F9C")]
			[Address(RVA = "0x419BD28", Offset = "0x4197D28", VA = "0x419BD28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009DC")]
		public TextMeshProUGUI TextMeshProUGUITxtEpic
		{
			[Token(Token = "0x6003F9D")]
			[Address(RVA = "0x419ACB4", Offset = "0x4196CB4", VA = "0x419ACB4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009DD")]
		public TextMeshProUGUI TextMeshProUGUITxtEpicCount
		{
			[Token(Token = "0x6003F9E")]
			[Address(RVA = "0x419BDF0", Offset = "0x4197DF0", VA = "0x419BDF0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009DE")]
		public TextMeshProUGUI TextMeshProUGUITxtGold
		{
			[Token(Token = "0x6003F9F")]
			[Address(RVA = "0x419AD7C", Offset = "0x4196D7C", VA = "0x419AD7C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009DF")]
		public TextMeshProUGUI TextMeshProUGUITxtGoldCount
		{
			[Token(Token = "0x6003FA0")]
			[Address(RVA = "0x419BEB8", Offset = "0x4197EB8", VA = "0x419BEB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009E0")]
		public RectTransform RectTransformBtnUnLock
		{
			[Token(Token = "0x6003FA1")]
			[Address(RVA = "0x419BF80", Offset = "0x4197F80", VA = "0x419BF80")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009E1")]
		public ButtonExtend ButtonExtendBtnUnLock
		{
			[Token(Token = "0x6003FA2")]
			[Address(RVA = "0x419C048", Offset = "0x4198048", VA = "0x419C048")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009E2")]
		public TextMeshProUGUI TextMeshProUGUITxtUnLock
		{
			[Token(Token = "0x6003FA3")]
			[Address(RVA = "0x419A8CC", Offset = "0x41968CC", VA = "0x419A8CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009E3")]
		public TextMeshProUGUI TextMeshProUGUITxtUnLockTime
		{
			[Token(Token = "0x6003FA4")]
			[Address(RVA = "0x419A5AC", Offset = "0x41965AC", VA = "0x419A5AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003FA5")]
		[Address(RVA = "0x419C110", Offset = "0x4198110", VA = "0x419C110")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6003FA6")]
		[Address(RVA = "0x419C2B0", Offset = "0x41982B0", VA = "0x419C2B0", Slot = "12")]
		protected virtual void OnButtonBgClicked()
		{
		}

		[Token(Token = "0x6003FA7")]
		[Address(RVA = "0x419C31C", Offset = "0x419831C", VA = "0x419C31C", Slot = "13")]
		protected virtual void OnButtonExtendBtnCloseClicked()
		{
		}

		[Token(Token = "0x6003FA8")]
		[Address(RVA = "0x419C388", Offset = "0x4198388", VA = "0x419C388", Slot = "14")]
		protected virtual void OnButtonExtendBtnFeeDiamondToUnLockClicked()
		{
		}

		[Token(Token = "0x6003FA9")]
		[Address(RVA = "0x419C3F4", Offset = "0x41983F4", VA = "0x419C3F4", Slot = "15")]
		protected virtual void OnAdButtonExtendBtnAdClicked()
		{
		}

		[Token(Token = "0x6003FAA")]
		[Address(RVA = "0x419C460", Offset = "0x4198460", VA = "0x419C460", Slot = "16")]
		protected virtual void OnButtonExtendBtnUnLockClicked()
		{
		}

		[Token(Token = "0x6003FAB")]
		[Address(RVA = "0x419C4CC", Offset = "0x41984CC", VA = "0x419C4CC", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6003FAC")]
		[Address(RVA = "0x419C4E8", Offset = "0x41984E8", VA = "0x419C4E8", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__622))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6003FAD")]
		[Address(RVA = "0x419C57C", Offset = "0x419857C", VA = "0x419C57C", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6003FAE")]
		[Address(RVA = "0x419C630", Offset = "0x4198630", VA = "0x419C630")]
		public OpenBoxPanelComponents()
		{
		}
	}
}
