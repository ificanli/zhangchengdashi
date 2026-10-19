using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using TMPro;
using UIFramework;
using UIModuleO.UIAnim;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x20006BD")]
	public class ArenaProgressItem_LineComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20006BE")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__777 : IAsyncStateMachine
		{
			[Token(Token = "0x400360C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400360D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400360E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ArenaProgressItem_LineComponents _003C_003E4__this;

			[Token(Token = "0x400360F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x60023F9")]
			[Address(RVA = "0x3F52C98", Offset = "0x3F4EC98", VA = "0x3F52C98", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60023FA")]
			[Address(RVA = "0x3F52F10", Offset = "0x3F4EF10", VA = "0x3F52F10", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40035D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RectTransform _rectTransformArenaProgressItem_Line;

		[Token(Token = "0x40035D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RectTransform _rectTransformImgIconRoot;

		[Token(Token = "0x40035D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private RectTransform _rectTransformImgArenaIcon;

		[Token(Token = "0x40035D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Image _imageImgArenaIcon;

		[Token(Token = "0x40035D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private TextMeshProUGUI _textMeshProUGUITxtArenaComplete;

		[Token(Token = "0x40035D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private ButtonExtend _buttonExtendBtnClaimCompleteReward;

		[Token(Token = "0x40035D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private RectTransform _rectTransformImgCoinRewardBg;

		[Token(Token = "0x40035D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private DOTweenAnimation _dOTweenAnimationImgCoinRewardBg;

		[Token(Token = "0x40035DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private TextMeshProUGUI _textMeshProUGUITxtCoinNum;

		[Token(Token = "0x40035DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Image _imageImgCoinDuiHao;

		[Token(Token = "0x40035DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Image _imageImgCoinLockIcon;

		[Token(Token = "0x40035DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Image _imageRedDot_UICoin;

		[Token(Token = "0x40035DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private RectTransform _rectTransformImgGemRewardBg;

		[Token(Token = "0x40035DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private DOTweenAnimation _dOTweenAnimationImgGemRewardBg;

		[Token(Token = "0x40035E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private TextMeshProUGUI _textMeshProUGUITxtGemNum;

		[Token(Token = "0x40035E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Image _imageImgGemDuiHao;

		[Token(Token = "0x40035E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Image _imageImgGemLockIcon;

		[Token(Token = "0x40035E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Image _imageRedDot_UIGem;

		[Token(Token = "0x40035E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private RectTransform _rectTransformImgBoxRewardBg;

		[Token(Token = "0x40035E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private DOTweenAnimation _dOTweenAnimationImgBoxRewardBg;

		[Token(Token = "0x40035E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Image _imageImgBoxIcon;

		[Token(Token = "0x40035E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Image _imageImgBoxDuiHao;

		[Token(Token = "0x40035E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Image _imageImgBoxLockIcon;

		[Token(Token = "0x40035E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Image _imageRedDot_UIBox;

		[Token(Token = "0x40035EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private TextMeshProUGUI _textMeshProUGUITxtArena;

		[Token(Token = "0x40035EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private RectTransform _rectTransformTxtUnLockOrRewardBg;

		[Token(Token = "0x40035EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private TextMeshProUGUI _textMeshProUGUITxtUnLockOrRewardBg;

		[Token(Token = "0x40035ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private RectTransform _rectTransformImgRewardRoot;

		[Token(Token = "0x40035EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Image _imageImgRewardRoot;

		[Token(Token = "0x40035EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private Image _imageImgSelectRewardBg;

		[Token(Token = "0x40035F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private TextMeshProUGUI _textMeshProUGUITxtChooseOne;

		[Token(Token = "0x40035F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private RectTransform _rectTransformBtnRewardOne;

		[Token(Token = "0x40035F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private ButtonExtend _buttonExtendBtnRewardOne;

		[Token(Token = "0x40035F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private DOTweenAnimation _dOTweenAnimationBtnRewardOne;

		[Token(Token = "0x40035F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Image _imageImgSelectReward1LockIcon;

		[Token(Token = "0x40035F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private RectTransform _rectTransformBtnRewardTwo;

		[Token(Token = "0x40035F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private ButtonExtend _buttonExtendBtnRewardTwo;

		[Token(Token = "0x40035F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private DOTweenAnimation _dOTweenAnimationBtnRewardTwo;

		[Token(Token = "0x40035F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private Image _imageImgSelectReward2LockIcon;

		[Token(Token = "0x40035F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private RectTransform _rectTransformBtnRewardThere;

		[Token(Token = "0x40035FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private ButtonExtend _buttonExtendBtnRewardThere;

		[Token(Token = "0x40035FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private DOTweenAnimation _dOTweenAnimationBtnRewardThere;

		[Token(Token = "0x40035FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private Image _imageImgSelectReward3LockIcon;

		[Token(Token = "0x40035FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private TextMeshProUGUI _textMeshProUGUITxtArtifact;

		[Token(Token = "0x40035FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private Image _imageImgLockBg;

		[Token(Token = "0x40035FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private TextMeshProUGUI _textMeshProUGUITxtUnLock;

		[Token(Token = "0x4003600")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private Image _imageImgDanIcon;

		[Token(Token = "0x4003601")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private TextMeshProUGUI _textMeshProUGUITxtDanName;

		[Token(Token = "0x4003602")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private TextMeshProUGUI _textMeshProUGUITxtTrophyRequireNum;

		[Token(Token = "0x4003603")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private Image _imageImgLineBgTwo;

		[Token(Token = "0x4003604")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private Image _imageImgLineArena1;

		[Token(Token = "0x4003605")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private RectTransform _rectTransformImgUILongBg;

		[Token(Token = "0x4003606")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private Image _imageImgUILongBg;

		[Token(Token = "0x4003607")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private RectTransform _rectTransformImgLineProgress;

		[Token(Token = "0x4003608")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private Image _imageImgLineProgress;

		[Token(Token = "0x4003609")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private RectTransform _rectTransformImgTrophyNumberBg;

		[Token(Token = "0x400360A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private Image _imageImgTrophyNumberBg;

		[Token(Token = "0x400360B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private TextMeshProUGUI _textMeshProUGUITxtTrophyNumber;

		[Token(Token = "0x1700021B")]
		public RectTransform RectTransformArenaProgressItem_Line
		{
			[Token(Token = "0x60023B5")]
			[Address(RVA = "0x3F48714", Offset = "0x3F44714", VA = "0x3F48714")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700021C")]
		public RectTransform RectTransformImgIconRoot
		{
			[Token(Token = "0x60023B6")]
			[Address(RVA = "0x3F4864C", Offset = "0x3F4464C", VA = "0x3F4864C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700021D")]
		public RectTransform RectTransformImgArenaIcon
		{
			[Token(Token = "0x60023B7")]
			[Address(RVA = "0x3F4A8CC", Offset = "0x3F468CC", VA = "0x3F4A8CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700021E")]
		public Image ImageImgArenaIcon
		{
			[Token(Token = "0x60023B8")]
			[Address(RVA = "0x3F50E14", Offset = "0x3F4CE14", VA = "0x3F50E14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700021F")]
		public TextMeshProUGUI TextMeshProUGUITxtArenaComplete
		{
			[Token(Token = "0x60023B9")]
			[Address(RVA = "0x3F4F1F4", Offset = "0x3F4B1F4", VA = "0x3F4F1F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000220")]
		public ButtonExtend ButtonExtendBtnClaimCompleteReward
		{
			[Token(Token = "0x60023BA")]
			[Address(RVA = "0x3F50D4C", Offset = "0x3F4CD4C", VA = "0x3F50D4C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000221")]
		public RectTransform RectTransformImgCoinRewardBg
		{
			[Token(Token = "0x60023BB")]
			[Address(RVA = "0x3F4BB04", Offset = "0x3F47B04", VA = "0x3F4BB04")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000222")]
		public DOTweenAnimation DOTweenAnimationImgCoinRewardBg
		{
			[Token(Token = "0x60023BC")]
			[Address(RVA = "0x3F5057C", Offset = "0x3F4C57C", VA = "0x3F5057C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000223")]
		public TextMeshProUGUI TextMeshProUGUITxtCoinNum
		{
			[Token(Token = "0x60023BD")]
			[Address(RVA = "0x3F4F6A4", Offset = "0x3F4B6A4", VA = "0x3F4F6A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000224")]
		public Image ImageImgCoinDuiHao
		{
			[Token(Token = "0x60023BE")]
			[Address(RVA = "0x3F5089C", Offset = "0x3F4C89C", VA = "0x3F5089C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000225")]
		public Image ImageImgCoinLockIcon
		{
			[Token(Token = "0x60023BF")]
			[Address(RVA = "0x3F5209C", Offset = "0x3F4E09C", VA = "0x3F5209C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000226")]
		public Image ImageRedDot_UICoin
		{
			[Token(Token = "0x60023C0")]
			[Address(RVA = "0x3F50AF4", Offset = "0x3F4CAF4", VA = "0x3F50AF4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000227")]
		public RectTransform RectTransformImgGemRewardBg
		{
			[Token(Token = "0x60023C1")]
			[Address(RVA = "0x3F4BBCC", Offset = "0x3F47BCC", VA = "0x3F4BBCC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000228")]
		public DOTweenAnimation DOTweenAnimationImgGemRewardBg
		{
			[Token(Token = "0x60023C2")]
			[Address(RVA = "0x3F50644", Offset = "0x3F4C644", VA = "0x3F50644")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000229")]
		public TextMeshProUGUI TextMeshProUGUITxtGemNum
		{
			[Token(Token = "0x60023C3")]
			[Address(RVA = "0x3F4F76C", Offset = "0x3F4B76C", VA = "0x3F4F76C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700022A")]
		public Image ImageImgGemDuiHao
		{
			[Token(Token = "0x60023C4")]
			[Address(RVA = "0x3F50964", Offset = "0x3F4C964", VA = "0x3F50964")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700022B")]
		public Image ImageImgGemLockIcon
		{
			[Token(Token = "0x60023C5")]
			[Address(RVA = "0x3F52164", Offset = "0x3F4E164", VA = "0x3F52164")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700022C")]
		public Image ImageRedDot_UIGem
		{
			[Token(Token = "0x60023C6")]
			[Address(RVA = "0x3F50BBC", Offset = "0x3F4CBBC", VA = "0x3F50BBC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700022D")]
		public RectTransform RectTransformImgBoxRewardBg
		{
			[Token(Token = "0x60023C7")]
			[Address(RVA = "0x3F507D4", Offset = "0x3F4C7D4", VA = "0x3F507D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700022E")]
		public DOTweenAnimation DOTweenAnimationImgBoxRewardBg
		{
			[Token(Token = "0x60023C8")]
			[Address(RVA = "0x3F5070C", Offset = "0x3F4C70C", VA = "0x3F5070C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700022F")]
		public Image ImageImgBoxIcon
		{
			[Token(Token = "0x60023C9")]
			[Address(RVA = "0x3F50FA4", Offset = "0x3F4CFA4", VA = "0x3F50FA4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000230")]
		public Image ImageImgBoxDuiHao
		{
			[Token(Token = "0x60023CA")]
			[Address(RVA = "0x3F50A2C", Offset = "0x3F4CA2C", VA = "0x3F50A2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000231")]
		public Image ImageImgBoxLockIcon
		{
			[Token(Token = "0x60023CB")]
			[Address(RVA = "0x3F5222C", Offset = "0x3F4E22C", VA = "0x3F5222C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000232")]
		public Image ImageRedDot_UIBox
		{
			[Token(Token = "0x60023CC")]
			[Address(RVA = "0x3F50C84", Offset = "0x3F4CC84", VA = "0x3F50C84")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000233")]
		public TextMeshProUGUI TextMeshProUGUITxtArena
		{
			[Token(Token = "0x60023CD")]
			[Address(RVA = "0x3F4F12C", Offset = "0x3F4B12C", VA = "0x3F4F12C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000234")]
		public RectTransform RectTransformTxtUnLockOrRewardBg
		{
			[Token(Token = "0x60023CE")]
			[Address(RVA = "0x3F4A804", Offset = "0x3F46804", VA = "0x3F4A804")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000235")]
		public TextMeshProUGUI TextMeshProUGUITxtUnLockOrRewardBg
		{
			[Token(Token = "0x60023CF")]
			[Address(RVA = "0x3F50004", Offset = "0x3F4C004", VA = "0x3F50004")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000236")]
		public RectTransform RectTransformImgRewardRoot
		{
			[Token(Token = "0x60023D0")]
			[Address(RVA = "0x3F48880", Offset = "0x3F44880", VA = "0x3F48880")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000237")]
		public Image ImageImgRewardRoot
		{
			[Token(Token = "0x60023D1")]
			[Address(RVA = "0x3F50194", Offset = "0x3F4C194", VA = "0x3F50194")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000238")]
		public Image ImageImgSelectRewardBg
		{
			[Token(Token = "0x60023D2")]
			[Address(RVA = "0x3F500CC", Offset = "0x3F4C0CC", VA = "0x3F500CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000239")]
		public TextMeshProUGUI TextMeshProUGUITxtChooseOne
		{
			[Token(Token = "0x60023D3")]
			[Address(RVA = "0x3F5025C", Offset = "0x3F4C25C", VA = "0x3F5025C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700023A")]
		public RectTransform RectTransformBtnRewardOne
		{
			[Token(Token = "0x60023D4")]
			[Address(RVA = "0x3F4F8FC", Offset = "0x3F4B8FC", VA = "0x3F4F8FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700023B")]
		public ButtonExtend ButtonExtendBtnRewardOne
		{
			[Token(Token = "0x60023D5")]
			[Address(RVA = "0x3F50324", Offset = "0x3F4C324", VA = "0x3F50324")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700023C")]
		public DOTweenAnimation DOTweenAnimationBtnRewardOne
		{
			[Token(Token = "0x60023D6")]
			[Address(RVA = "0x3F4F834", Offset = "0x3F4B834", VA = "0x3F4F834")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700023D")]
		public Image ImageImgSelectReward1LockIcon
		{
			[Token(Token = "0x60023D7")]
			[Address(RVA = "0x3F522F4", Offset = "0x3F4E2F4", VA = "0x3F522F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700023E")]
		public RectTransform RectTransformBtnRewardTwo
		{
			[Token(Token = "0x60023D8")]
			[Address(RVA = "0x3F4FA8C", Offset = "0x3F4BA8C", VA = "0x3F4FA8C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700023F")]
		public ButtonExtend ButtonExtendBtnRewardTwo
		{
			[Token(Token = "0x60023D9")]
			[Address(RVA = "0x3F503EC", Offset = "0x3F4C3EC", VA = "0x3F503EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000240")]
		public DOTweenAnimation DOTweenAnimationBtnRewardTwo
		{
			[Token(Token = "0x60023DA")]
			[Address(RVA = "0x3F4F9C4", Offset = "0x3F4B9C4", VA = "0x3F4F9C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000241")]
		public Image ImageImgSelectReward2LockIcon
		{
			[Token(Token = "0x60023DB")]
			[Address(RVA = "0x3F523BC", Offset = "0x3F4E3BC", VA = "0x3F523BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000242")]
		public RectTransform RectTransformBtnRewardThere
		{
			[Token(Token = "0x60023DC")]
			[Address(RVA = "0x3F4FC1C", Offset = "0x3F4BC1C", VA = "0x3F4FC1C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000243")]
		public ButtonExtend ButtonExtendBtnRewardThere
		{
			[Token(Token = "0x60023DD")]
			[Address(RVA = "0x3F504B4", Offset = "0x3F4C4B4", VA = "0x3F504B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000244")]
		public DOTweenAnimation DOTweenAnimationBtnRewardThere
		{
			[Token(Token = "0x60023DE")]
			[Address(RVA = "0x3F4FB54", Offset = "0x3F4BB54", VA = "0x3F4FB54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000245")]
		public Image ImageImgSelectReward3LockIcon
		{
			[Token(Token = "0x60023DF")]
			[Address(RVA = "0x3F52484", Offset = "0x3F4E484", VA = "0x3F52484")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000246")]
		public TextMeshProUGUI TextMeshProUGUITxtArtifact
		{
			[Token(Token = "0x60023E0")]
			[Address(RVA = "0x3F4F2BC", Offset = "0x3F4B2BC", VA = "0x3F4F2BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000247")]
		public Image ImageImgLockBg
		{
			[Token(Token = "0x60023E1")]
			[Address(RVA = "0x3F4FCE4", Offset = "0x3F4BCE4", VA = "0x3F4FCE4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000248")]
		public TextMeshProUGUI TextMeshProUGUITxtUnLock
		{
			[Token(Token = "0x60023E2")]
			[Address(RVA = "0x3F4F384", Offset = "0x3F4B384", VA = "0x3F4F384")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000249")]
		public Image ImageImgDanIcon
		{
			[Token(Token = "0x60023E3")]
			[Address(RVA = "0x3F50EDC", Offset = "0x3F4CEDC", VA = "0x3F50EDC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700024A")]
		public TextMeshProUGUI TextMeshProUGUITxtDanName
		{
			[Token(Token = "0x60023E4")]
			[Address(RVA = "0x3F4F44C", Offset = "0x3F4B44C", VA = "0x3F4F44C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700024B")]
		public TextMeshProUGUI TextMeshProUGUITxtTrophyRequireNum
		{
			[Token(Token = "0x60023E5")]
			[Address(RVA = "0x3F4F514", Offset = "0x3F4B514", VA = "0x3F4F514")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700024C")]
		public Image ImageImgLineBgTwo
		{
			[Token(Token = "0x60023E6")]
			[Address(RVA = "0x3F4FF3C", Offset = "0x3F4BF3C", VA = "0x3F4FF3C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700024D")]
		public Image ImageImgLineArena1
		{
			[Token(Token = "0x60023E7")]
			[Address(RVA = "0x3F4F064", Offset = "0x3F4B064", VA = "0x3F4F064")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700024E")]
		public RectTransform RectTransformImgUILongBg
		{
			[Token(Token = "0x60023E8")]
			[Address(RVA = "0x3F4FE74", Offset = "0x3F4BE74", VA = "0x3F4FE74")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700024F")]
		public Image ImageImgUILongBg
		{
			[Token(Token = "0x60023E9")]
			[Address(RVA = "0x3F4FDAC", Offset = "0x3F4BDAC", VA = "0x3F4FDAC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000250")]
		public RectTransform RectTransformImgLineProgress
		{
			[Token(Token = "0x60023EA")]
			[Address(RVA = "0x3F487B8", Offset = "0x3F447B8", VA = "0x3F487B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000251")]
		public Image ImageImgLineProgress
		{
			[Token(Token = "0x60023EB")]
			[Address(RVA = "0x3F4A994", Offset = "0x3F46994", VA = "0x3F4A994")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000252")]
		public RectTransform RectTransformImgTrophyNumberBg
		{
			[Token(Token = "0x60023EC")]
			[Address(RVA = "0x3F48584", Offset = "0x3F44584", VA = "0x3F48584")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000253")]
		public Image ImageImgTrophyNumberBg
		{
			[Token(Token = "0x60023ED")]
			[Address(RVA = "0x3F4F5DC", Offset = "0x3F4B5DC", VA = "0x3F4F5DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000254")]
		public TextMeshProUGUI TextMeshProUGUITxtTrophyNumber
		{
			[Token(Token = "0x60023EE")]
			[Address(RVA = "0x3F49730", Offset = "0x3F45730", VA = "0x3F49730")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60023EF")]
		[Address(RVA = "0x3F52558", Offset = "0x3F4E558", VA = "0x3F52558")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x60023F0")]
		[Address(RVA = "0x3F498D8", Offset = "0x3F458D8", VA = "0x3F498D8", Slot = "12")]
		protected virtual void OnButtonExtendBtnClaimCompleteRewardClicked()
		{
		}

		[Token(Token = "0x60023F1")]
		[Address(RVA = "0x3F48EEC", Offset = "0x3F44EEC", VA = "0x3F48EEC", Slot = "13")]
		protected virtual void OnButtonExtendBtnRewardOneClicked()
		{
		}

		[Token(Token = "0x60023F2")]
		[Address(RVA = "0x3F49208", Offset = "0x3F45208", VA = "0x3F49208", Slot = "14")]
		protected virtual void OnButtonExtendBtnRewardTwoClicked()
		{
		}

		[Token(Token = "0x60023F3")]
		[Address(RVA = "0x3F49524", Offset = "0x3F45524", VA = "0x3F49524", Slot = "15")]
		protected virtual void OnButtonExtendBtnRewardThereClicked()
		{
		}

		[Token(Token = "0x60023F4")]
		[Address(RVA = "0x3F48568", Offset = "0x3F44568", VA = "0x3F48568", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60023F5")]
		[Address(RVA = "0x3F49634", Offset = "0x3F45634", VA = "0x3F49634", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__777))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60023F6")]
		[Address(RVA = "0x3F526B4", Offset = "0x3F4E6B4", VA = "0x3F526B4", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x60023F7")]
		[Address(RVA = "0x3F49628", Offset = "0x3F45628", VA = "0x3F49628")]
		public ArenaProgressItem_LineComponents()
		{
		}
	}
}
