using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using Spine.Unity;
using TMPro;
using UIFramework;
using UIModuleO.UIAnim;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x20008BE")]
	public class GamePanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20008BF")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__1498 : IAsyncStateMachine
		{
			[Token(Token = "0x400424D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400424E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400424F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GamePanelComponents _003C_003E4__this;

			[Token(Token = "0x4004250")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6003207")]
			[Address(RVA = "0x4069464", Offset = "0x4065464", VA = "0x4069464", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003208")]
			[Address(RVA = "0x40696DC", Offset = "0x40656DC", VA = "0x40696DC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40041FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RectTransform _rectTransformGamePanel;

		[Token(Token = "0x40041FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Image _imageBG;

		[Token(Token = "0x40041FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private RectTransform _rectTransformSelectLighting;

		[Token(Token = "0x40041FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Image _imageSelectLighting;

		[Token(Token = "0x40041FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private RectTransform _rectTransformImgWordPlayerBg;

		[Token(Token = "0x40041FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private CanvasGroup _canvasGroupImgWordPlayerBg;

		[Token(Token = "0x4004200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private TextMeshProUGUI _textMeshProUGUITxtWordPlayer;

		[Token(Token = "0x4004201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private RectTransform _rectTransformImgWordEnemyBg;

		[Token(Token = "0x4004202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private CanvasGroup _canvasGroupImgWordEnemyBg;

		[Token(Token = "0x4004203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private TextMeshProUGUI _textMeshProUGUITxtWordEnemy;

		[Token(Token = "0x4004204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private RectTransform _rectTransformImgEmojPlayerBg;

		[Token(Token = "0x4004205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private SkeletonGraphic _skeletonGraphicEmojPlayerSpine;

		[Token(Token = "0x4004206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private RectTransform _rectTransformImgEmojEnemyBg;

		[Token(Token = "0x4004207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private SkeletonGraphic _skeletonGraphicEmojEnemySpine;

		[Token(Token = "0x4004208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private TextMeshProUGUI _textMeshProUGUITxtCoinNum;

		[Token(Token = "0x4004209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Image _imageImgSkillBG;

		[Token(Token = "0x400420A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private SkillItem _skillItemSkillItem;

		[Token(Token = "0x400420B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private ButtonExtend _buttonExtendSkillItem;

		[Token(Token = "0x400420C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private SkillItem _skillItemSkillItem_Enemy;

		[Token(Token = "0x400420D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private ButtonExtend _buttonExtendSkillItem_Enemy;

		[Token(Token = "0x400420E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private ButtonExtend _buttonExtendBtnSendEmojis;

		[Token(Token = "0x400420F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private RectTransform _rectTransformImgEmojisBg;

		[Token(Token = "0x4004210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private ButtonExtend _buttonExtendBtnWordBg1;

		[Token(Token = "0x4004211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private TextMeshProUGUI _textMeshProUGUITxtWord1;

		[Token(Token = "0x4004212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private ButtonExtend _buttonExtendBtnWordBg2;

		[Token(Token = "0x4004213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private TextMeshProUGUI _textMeshProUGUITxtWord2;

		[Token(Token = "0x4004214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private ButtonExtend _buttonExtendBtnWordBg3;

		[Token(Token = "0x4004215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private TextMeshProUGUI _textMeshProUGUITxtWord3;

		[Token(Token = "0x4004216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private ButtonExtend _buttonExtendBtnWordBg4;

		[Token(Token = "0x4004217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private TextMeshProUGUI _textMeshProUGUITxtWord4;

		[Token(Token = "0x4004218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private ButtonExtend _buttonExtendBtnEmojisThink;

		[Token(Token = "0x4004219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private SkeletonGraphic _skeletonGraphicBtnSpinethink;

		[Token(Token = "0x400421A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private ButtonExtend _buttonExtendBtnEmojisLaugh;

		[Token(Token = "0x400421B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private SkeletonGraphic _skeletonGraphicBtnSpinelaugh;

		[Token(Token = "0x400421C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private ButtonExtend _buttonExtendBtnEmojisCry;

		[Token(Token = "0x400421D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private SkeletonGraphic _skeletonGraphicBtnSpinecry;

		[Token(Token = "0x400421E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private ButtonExtend _buttonExtendBtnEmojisAngry;

		[Token(Token = "0x400421F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private SkeletonGraphic _skeletonGraphicBtnSpineangry;

		[Token(Token = "0x4004220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private Image _imageBtnBanEmojis;

		[Token(Token = "0x4004221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private ButtonExtend _buttonExtendBtnBanEmojis;

		[Token(Token = "0x4004222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private SkeletonGraphic _skeletonGraphicSkeletonGraphicLaba_Player;

		[Token(Token = "0x4004223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private SkeletonGraphic _skeletonGraphicSkeletonGraphicLaba_Enemy;

		[Token(Token = "0x4004224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private AvatarItem _avatarItemPlayerAvatarItem;

		[Token(Token = "0x4004225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private TextMeshProUGUI _textMeshProUGUITxtNameLeft;

		[Token(Token = "0x4004226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private TextMeshProUGUI _textMeshProUGUITxtTrophyDesLeft;

		[Token(Token = "0x4004227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private TextMeshProUGUI _textMeshProUGUITxtLeftNum;

		[Token(Token = "0x4004228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private TextMeshProUGUI _textMeshProUGUITxtLeftWoodNum;

		[Token(Token = "0x4004229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private TextMeshProUGUI _textMeshProUGUITxtLeftSoliderNum;

		[Token(Token = "0x400422A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private Image _imageImgPlayerBlessBg;

		[Token(Token = "0x400422B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private ButtonExtend _buttonExtendImgPlayerBlessBg;

		[Token(Token = "0x400422C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private Image _imageImagePlayerBlessIcon;

		[Token(Token = "0x400422D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private RectTransform _rectTransformImgPlayerBlessDesBg;

		[Token(Token = "0x400422E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private TextMeshProUGUI _textMeshProUGUITxtPlayerBlessDes;

		[Token(Token = "0x400422F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private RectTransform _rectTransformBtnGuide;

		[Token(Token = "0x4004230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private Image _imageBtnGuide;

		[Token(Token = "0x4004231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private ButtonExtend _buttonExtendBtnGuide;

		[Token(Token = "0x4004232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private ButtonExtend _buttonExtendRightBG;

		[Token(Token = "0x4004233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private AvatarItem _avatarItemEnemyAvatarItem;

		[Token(Token = "0x4004234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private TextMeshProUGUI _textMeshProUGUITxtNameRight;

		[Token(Token = "0x4004235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private TextMeshProUGUI _textMeshProUGUITxtTrophyDesRight;

		[Token(Token = "0x4004236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private TextMeshProUGUI _textMeshProUGUITxtRightNum;

		[Token(Token = "0x4004237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private TextMeshProUGUI _textMeshProUGUITxtRightWoodNum;

		[Token(Token = "0x4004238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		private TextMeshProUGUI _textMeshProUGUITxtRightSoliderNum;

		[Token(Token = "0x4004239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		private Image _imageImgEnemyBlessBg;

		[Token(Token = "0x400423A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		private ButtonExtend _buttonExtendImgEnemyBlessBg;

		[Token(Token = "0x400423B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		private Image _imageImageEnemyBlessIcon;

		[Token(Token = "0x400423C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		private RectTransform _rectTransformImgEnemyBlessDesBg;

		[Token(Token = "0x400423D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		private TextMeshProUGUI _textMeshProUGUITxtEnemyBlessDes;

		[Token(Token = "0x400423E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		private Image _imageImgEnemyPropIcon;

		[Token(Token = "0x400423F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		private RectTransform _rectTransformImgTimeBG;

		[Token(Token = "0x4004240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		private TextMeshProUGUI _textMeshProUGUITxtTime;

		[Token(Token = "0x4004241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		private TextMeshProUGUI _textMeshProUGUITxtTimeLeft;

		[Token(Token = "0x4004242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
		private RectTransform _rectTransformImgPropEmojiRightRoot;

		[Token(Token = "0x4004243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		private RectTransform _rectTransformImgPropEmojiLeftRoot;

		[Token(Token = "0x4004244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		private RectTransform _rectTransformCheat_ImgEnemyInfoBg;

		[Token(Token = "0x4004245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		private TextMeshProUGUI _textMeshProUGUICheat_TxtEnemyLevel;

		[Token(Token = "0x4004246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
		private TextMeshProUGUI _textMeshProUGUICheat_TxtAiType;

		[Token(Token = "0x4004247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
		private TextMeshProUGUI _textMeshProUGUICheat_TxtCardInfoDes1;

		[Token(Token = "0x4004248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
		private TextMeshProUGUI _textMeshProUGUICheat_TxtPropInfo;

		[Token(Token = "0x4004249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
		private TextMeshProUGUI _textMeshProUGUICheat_TxtMainCityLevel;

		[Token(Token = "0x400424A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
		private TextMeshProUGUI _textMeshProUGUICheat_TxtMainCityInfoNumber;

		[Token(Token = "0x400424B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
		private ButtonExtend _buttonExtendCheat_BtnClose;

		[Token(Token = "0x400424C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
		private RectTransform _rectTransformArrowindicator;

		[Token(Token = "0x1700061F")]
		public RectTransform RectTransformGamePanel
		{
			[Token(Token = "0x600319D")]
			[Address(RVA = "0x4065E78", Offset = "0x4061E78", VA = "0x4065E78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000620")]
		public Image ImageBG
		{
			[Token(Token = "0x600319E")]
			[Address(RVA = "0x4065F1C", Offset = "0x4061F1C", VA = "0x4065F1C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000621")]
		public RectTransform RectTransformSelectLighting
		{
			[Token(Token = "0x600319F")]
			[Address(RVA = "0x4065FE4", Offset = "0x4061FE4", VA = "0x4065FE4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000622")]
		public Image ImageSelectLighting
		{
			[Token(Token = "0x60031A0")]
			[Address(RVA = "0x40660AC", Offset = "0x40620AC", VA = "0x40660AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000623")]
		public RectTransform RectTransformImgWordPlayerBg
		{
			[Token(Token = "0x60031A1")]
			[Address(RVA = "0x4066174", Offset = "0x4062174", VA = "0x4066174")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000624")]
		public CanvasGroup CanvasGroupImgWordPlayerBg
		{
			[Token(Token = "0x60031A2")]
			[Address(RVA = "0x406623C", Offset = "0x406223C", VA = "0x406623C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000625")]
		public TextMeshProUGUI TextMeshProUGUITxtWordPlayer
		{
			[Token(Token = "0x60031A3")]
			[Address(RVA = "0x4066304", Offset = "0x4062304", VA = "0x4066304")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000626")]
		public RectTransform RectTransformImgWordEnemyBg
		{
			[Token(Token = "0x60031A4")]
			[Address(RVA = "0x40663CC", Offset = "0x40623CC", VA = "0x40663CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000627")]
		public CanvasGroup CanvasGroupImgWordEnemyBg
		{
			[Token(Token = "0x60031A5")]
			[Address(RVA = "0x4066494", Offset = "0x4062494", VA = "0x4066494")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000628")]
		public TextMeshProUGUI TextMeshProUGUITxtWordEnemy
		{
			[Token(Token = "0x60031A6")]
			[Address(RVA = "0x406655C", Offset = "0x406255C", VA = "0x406655C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000629")]
		public RectTransform RectTransformImgEmojPlayerBg
		{
			[Token(Token = "0x60031A7")]
			[Address(RVA = "0x4064FB8", Offset = "0x4060FB8", VA = "0x4064FB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700062A")]
		public SkeletonGraphic SkeletonGraphicEmojPlayerSpine
		{
			[Token(Token = "0x60031A8")]
			[Address(RVA = "0x40657F4", Offset = "0x40617F4", VA = "0x40657F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700062B")]
		public RectTransform RectTransformImgEmojEnemyBg
		{
			[Token(Token = "0x60031A9")]
			[Address(RVA = "0x4066624", Offset = "0x4062624", VA = "0x4066624")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700062C")]
		public SkeletonGraphic SkeletonGraphicEmojEnemySpine
		{
			[Token(Token = "0x60031AA")]
			[Address(RVA = "0x40658BC", Offset = "0x40618BC", VA = "0x40658BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700062D")]
		public TextMeshProUGUI TextMeshProUGUITxtCoinNum
		{
			[Token(Token = "0x60031AB")]
			[Address(RVA = "0x40666EC", Offset = "0x40626EC", VA = "0x40666EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700062E")]
		public Image ImageImgSkillBG
		{
			[Token(Token = "0x60031AC")]
			[Address(RVA = "0x406403C", Offset = "0x406003C", VA = "0x406403C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700062F")]
		public SkillItem SkillItemSkillItem
		{
			[Token(Token = "0x60031AD")]
			[Address(RVA = "0x4064104", Offset = "0x4060104", VA = "0x4064104")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000630")]
		public ButtonExtend ButtonExtendSkillItem
		{
			[Token(Token = "0x60031AE")]
			[Address(RVA = "0x40667B4", Offset = "0x40627B4", VA = "0x40667B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000631")]
		public SkillItem SkillItemSkillItem_Enemy
		{
			[Token(Token = "0x60031AF")]
			[Address(RVA = "0x406426C", Offset = "0x406026C", VA = "0x406426C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000632")]
		public ButtonExtend ButtonExtendSkillItem_Enemy
		{
			[Token(Token = "0x60031B0")]
			[Address(RVA = "0x406687C", Offset = "0x406287C", VA = "0x406687C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000633")]
		public ButtonExtend ButtonExtendBtnSendEmojis
		{
			[Token(Token = "0x60031B1")]
			[Address(RVA = "0x4066944", Offset = "0x4062944", VA = "0x4066944")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000634")]
		public RectTransform RectTransformImgEmojisBg
		{
			[Token(Token = "0x60031B2")]
			[Address(RVA = "0x4066A0C", Offset = "0x4062A0C", VA = "0x4066A0C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000635")]
		public ButtonExtend ButtonExtendBtnWordBg1
		{
			[Token(Token = "0x60031B3")]
			[Address(RVA = "0x4066AD4", Offset = "0x4062AD4", VA = "0x4066AD4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000636")]
		public TextMeshProUGUI TextMeshProUGUITxtWord1
		{
			[Token(Token = "0x60031B4")]
			[Address(RVA = "0x406354C", Offset = "0x405F54C", VA = "0x406354C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000637")]
		public ButtonExtend ButtonExtendBtnWordBg2
		{
			[Token(Token = "0x60031B5")]
			[Address(RVA = "0x4066B9C", Offset = "0x4062B9C", VA = "0x4066B9C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000638")]
		public TextMeshProUGUI TextMeshProUGUITxtWord2
		{
			[Token(Token = "0x60031B6")]
			[Address(RVA = "0x4063614", Offset = "0x405F614", VA = "0x4063614")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000639")]
		public ButtonExtend ButtonExtendBtnWordBg3
		{
			[Token(Token = "0x60031B7")]
			[Address(RVA = "0x4066C64", Offset = "0x4062C64", VA = "0x4066C64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700063A")]
		public TextMeshProUGUI TextMeshProUGUITxtWord3
		{
			[Token(Token = "0x60031B8")]
			[Address(RVA = "0x40636DC", Offset = "0x405F6DC", VA = "0x40636DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700063B")]
		public ButtonExtend ButtonExtendBtnWordBg4
		{
			[Token(Token = "0x60031B9")]
			[Address(RVA = "0x4066D2C", Offset = "0x4062D2C", VA = "0x4066D2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700063C")]
		public TextMeshProUGUI TextMeshProUGUITxtWord4
		{
			[Token(Token = "0x60031BA")]
			[Address(RVA = "0x40637A4", Offset = "0x405F7A4", VA = "0x40637A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700063D")]
		public ButtonExtend ButtonExtendBtnEmojisThink
		{
			[Token(Token = "0x60031BB")]
			[Address(RVA = "0x4066DF4", Offset = "0x4062DF4", VA = "0x4066DF4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700063E")]
		public SkeletonGraphic SkeletonGraphicBtnSpinethink
		{
			[Token(Token = "0x60031BC")]
			[Address(RVA = "0x4060E30", Offset = "0x405CE30", VA = "0x4060E30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700063F")]
		public ButtonExtend ButtonExtendBtnEmojisLaugh
		{
			[Token(Token = "0x60031BD")]
			[Address(RVA = "0x4066EBC", Offset = "0x4062EBC", VA = "0x4066EBC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000640")]
		public SkeletonGraphic SkeletonGraphicBtnSpinelaugh
		{
			[Token(Token = "0x60031BE")]
			[Address(RVA = "0x4060EF8", Offset = "0x405CEF8", VA = "0x4060EF8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000641")]
		public ButtonExtend ButtonExtendBtnEmojisCry
		{
			[Token(Token = "0x60031BF")]
			[Address(RVA = "0x4066F84", Offset = "0x4062F84", VA = "0x4066F84")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000642")]
		public SkeletonGraphic SkeletonGraphicBtnSpinecry
		{
			[Token(Token = "0x60031C0")]
			[Address(RVA = "0x4060FC0", Offset = "0x405CFC0", VA = "0x4060FC0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000643")]
		public ButtonExtend ButtonExtendBtnEmojisAngry
		{
			[Token(Token = "0x60031C1")]
			[Address(RVA = "0x406704C", Offset = "0x406304C", VA = "0x406704C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000644")]
		public SkeletonGraphic SkeletonGraphicBtnSpineangry
		{
			[Token(Token = "0x60031C2")]
			[Address(RVA = "0x4061088", Offset = "0x405D088", VA = "0x4061088")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000645")]
		public Image ImageBtnBanEmojis
		{
			[Token(Token = "0x60031C3")]
			[Address(RVA = "0x4061718", Offset = "0x405D718", VA = "0x4061718")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000646")]
		public ButtonExtend ButtonExtendBtnBanEmojis
		{
			[Token(Token = "0x60031C4")]
			[Address(RVA = "0x4067114", Offset = "0x4063114", VA = "0x4067114")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000647")]
		public SkeletonGraphic SkeletonGraphicSkeletonGraphicLaba_Player
		{
			[Token(Token = "0x60031C5")]
			[Address(RVA = "0x40671DC", Offset = "0x40631DC", VA = "0x40671DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000648")]
		public SkeletonGraphic SkeletonGraphicSkeletonGraphicLaba_Enemy
		{
			[Token(Token = "0x60031C6")]
			[Address(RVA = "0x40672A4", Offset = "0x40632A4", VA = "0x40672A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000649")]
		public AvatarItem AvatarItemPlayerAvatarItem
		{
			[Token(Token = "0x60031C7")]
			[Address(RVA = "0x4063F74", Offset = "0x405FF74", VA = "0x4063F74")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700064A")]
		public TextMeshProUGUI TextMeshProUGUITxtNameLeft
		{
			[Token(Token = "0x60031C8")]
			[Address(RVA = "0x40633BC", Offset = "0x405F3BC", VA = "0x40633BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700064B")]
		public TextMeshProUGUI TextMeshProUGUITxtTrophyDesLeft
		{
			[Token(Token = "0x60031C9")]
			[Address(RVA = "0x4063484", Offset = "0x405F484", VA = "0x4063484")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700064C")]
		public TextMeshProUGUI TextMeshProUGUITxtLeftNum
		{
			[Token(Token = "0x60031CA")]
			[Address(RVA = "0x406309C", Offset = "0x405F09C", VA = "0x406309C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700064D")]
		public TextMeshProUGUI TextMeshProUGUITxtLeftWoodNum
		{
			[Token(Token = "0x60031CB")]
			[Address(RVA = "0x406322C", Offset = "0x405F22C", VA = "0x406322C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700064E")]
		public TextMeshProUGUI TextMeshProUGUITxtLeftSoliderNum
		{
			[Token(Token = "0x60031CC")]
			[Address(RVA = "0x40639FC", Offset = "0x405F9FC", VA = "0x40639FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700064F")]
		public Image ImageImgPlayerBlessBg
		{
			[Token(Token = "0x60031CD")]
			[Address(RVA = "0x406736C", Offset = "0x406336C", VA = "0x406736C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000650")]
		public ButtonExtend ButtonExtendImgPlayerBlessBg
		{
			[Token(Token = "0x60031CE")]
			[Address(RVA = "0x4067434", Offset = "0x4063434", VA = "0x4067434")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000651")]
		public Image ImageImagePlayerBlessIcon
		{
			[Token(Token = "0x60031CF")]
			[Address(RVA = "0x40674FC", Offset = "0x40634FC", VA = "0x40674FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000652")]
		public RectTransform RectTransformImgPlayerBlessDesBg
		{
			[Token(Token = "0x60031D0")]
			[Address(RVA = "0x40675C4", Offset = "0x40635C4", VA = "0x40675C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000653")]
		public TextMeshProUGUI TextMeshProUGUITxtPlayerBlessDes
		{
			[Token(Token = "0x60031D1")]
			[Address(RVA = "0x406768C", Offset = "0x406368C", VA = "0x406768C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000654")]
		public RectTransform RectTransformBtnGuide
		{
			[Token(Token = "0x60031D2")]
			[Address(RVA = "0x4063B8C", Offset = "0x405FB8C", VA = "0x4063B8C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000655")]
		public Image ImageBtnGuide
		{
			[Token(Token = "0x60031D3")]
			[Address(RVA = "0x4063C54", Offset = "0x405FC54", VA = "0x4063C54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000656")]
		public ButtonExtend ButtonExtendBtnGuide
		{
			[Token(Token = "0x60031D4")]
			[Address(RVA = "0x4067754", Offset = "0x4063754", VA = "0x4067754")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000657")]
		public ButtonExtend ButtonExtendRightBG
		{
			[Token(Token = "0x60031D5")]
			[Address(RVA = "0x406781C", Offset = "0x406381C", VA = "0x406781C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000658")]
		public AvatarItem AvatarItemEnemyAvatarItem
		{
			[Token(Token = "0x60031D6")]
			[Address(RVA = "0x4063EAC", Offset = "0x405FEAC", VA = "0x4063EAC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000659")]
		public TextMeshProUGUI TextMeshProUGUITxtNameRight
		{
			[Token(Token = "0x60031D7")]
			[Address(RVA = "0x4063D1C", Offset = "0x405FD1C", VA = "0x4063D1C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700065A")]
		public TextMeshProUGUI TextMeshProUGUITxtTrophyDesRight
		{
			[Token(Token = "0x60031D8")]
			[Address(RVA = "0x4063DE4", Offset = "0x405FDE4", VA = "0x4063DE4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700065B")]
		public TextMeshProUGUI TextMeshProUGUITxtRightNum
		{
			[Token(Token = "0x60031D9")]
			[Address(RVA = "0x4063164", Offset = "0x405F164", VA = "0x4063164")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700065C")]
		public TextMeshProUGUI TextMeshProUGUITxtRightWoodNum
		{
			[Token(Token = "0x60031DA")]
			[Address(RVA = "0x40632F4", Offset = "0x405F2F4", VA = "0x40632F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700065D")]
		public TextMeshProUGUI TextMeshProUGUITxtRightSoliderNum
		{
			[Token(Token = "0x60031DB")]
			[Address(RVA = "0x4063AC4", Offset = "0x405FAC4", VA = "0x4063AC4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700065E")]
		public Image ImageImgEnemyBlessBg
		{
			[Token(Token = "0x60031DC")]
			[Address(RVA = "0x40678E4", Offset = "0x40638E4", VA = "0x40678E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700065F")]
		public ButtonExtend ButtonExtendImgEnemyBlessBg
		{
			[Token(Token = "0x60031DD")]
			[Address(RVA = "0x40679AC", Offset = "0x40639AC", VA = "0x40679AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000660")]
		public Image ImageImageEnemyBlessIcon
		{
			[Token(Token = "0x60031DE")]
			[Address(RVA = "0x4067A74", Offset = "0x4063A74", VA = "0x4067A74")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000661")]
		public RectTransform RectTransformImgEnemyBlessDesBg
		{
			[Token(Token = "0x60031DF")]
			[Address(RVA = "0x4067B3C", Offset = "0x4063B3C", VA = "0x4067B3C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000662")]
		public TextMeshProUGUI TextMeshProUGUITxtEnemyBlessDes
		{
			[Token(Token = "0x60031E0")]
			[Address(RVA = "0x4067C04", Offset = "0x4063C04", VA = "0x4067C04")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000663")]
		public Image ImageImgEnemyPropIcon
		{
			[Token(Token = "0x60031E1")]
			[Address(RVA = "0x4063934", Offset = "0x405F934", VA = "0x4063934")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000664")]
		public RectTransform RectTransformImgTimeBG
		{
			[Token(Token = "0x60031E2")]
			[Address(RVA = "0x4067CCC", Offset = "0x4063CCC", VA = "0x4067CCC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000665")]
		public TextMeshProUGUI TextMeshProUGUITxtTime
		{
			[Token(Token = "0x60031E3")]
			[Address(RVA = "0x4067D94", Offset = "0x4063D94", VA = "0x4067D94")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000666")]
		public TextMeshProUGUI TextMeshProUGUITxtTimeLeft
		{
			[Token(Token = "0x60031E4")]
			[Address(RVA = "0x406386C", Offset = "0x405F86C", VA = "0x406386C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000667")]
		public RectTransform RectTransformImgPropEmojiRightRoot
		{
			[Token(Token = "0x60031E5")]
			[Address(RVA = "0x4067E5C", Offset = "0x4063E5C", VA = "0x4067E5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000668")]
		public RectTransform RectTransformImgPropEmojiLeftRoot
		{
			[Token(Token = "0x60031E6")]
			[Address(RVA = "0x4067F24", Offset = "0x4063F24", VA = "0x4067F24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000669")]
		public RectTransform RectTransformCheat_ImgEnemyInfoBg
		{
			[Token(Token = "0x60031E7")]
			[Address(RVA = "0x4067FEC", Offset = "0x4063FEC", VA = "0x4067FEC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700066A")]
		public TextMeshProUGUI TextMeshProUGUICheat_TxtEnemyLevel
		{
			[Token(Token = "0x60031E8")]
			[Address(RVA = "0x40680B4", Offset = "0x40640B4", VA = "0x40680B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700066B")]
		public TextMeshProUGUI TextMeshProUGUICheat_TxtAiType
		{
			[Token(Token = "0x60031E9")]
			[Address(RVA = "0x406817C", Offset = "0x406417C", VA = "0x406817C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700066C")]
		public TextMeshProUGUI TextMeshProUGUICheat_TxtCardInfoDes1
		{
			[Token(Token = "0x60031EA")]
			[Address(RVA = "0x4068244", Offset = "0x4064244", VA = "0x4068244")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700066D")]
		public TextMeshProUGUI TextMeshProUGUICheat_TxtPropInfo
		{
			[Token(Token = "0x60031EB")]
			[Address(RVA = "0x406830C", Offset = "0x406430C", VA = "0x406830C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700066E")]
		public TextMeshProUGUI TextMeshProUGUICheat_TxtMainCityLevel
		{
			[Token(Token = "0x60031EC")]
			[Address(RVA = "0x40683D4", Offset = "0x40643D4", VA = "0x40683D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700066F")]
		public TextMeshProUGUI TextMeshProUGUICheat_TxtMainCityInfoNumber
		{
			[Token(Token = "0x60031ED")]
			[Address(RVA = "0x406849C", Offset = "0x406449C", VA = "0x406849C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000670")]
		public ButtonExtend ButtonExtendCheat_BtnClose
		{
			[Token(Token = "0x60031EE")]
			[Address(RVA = "0x4068564", Offset = "0x4064564", VA = "0x4068564")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000671")]
		public RectTransform RectTransformArrowindicator
		{
			[Token(Token = "0x60031EF")]
			[Address(RVA = "0x406862C", Offset = "0x406462C", VA = "0x406862C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60031F0")]
		[Address(RVA = "0x40686F4", Offset = "0x40646F4", VA = "0x40686F4")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x60031F1")]
		[Address(RVA = "0x4068BC4", Offset = "0x4064BC4", VA = "0x4068BC4", Slot = "12")]
		protected virtual void OnButtonExtendSkillItemClicked()
		{
		}

		[Token(Token = "0x60031F2")]
		[Address(RVA = "0x4068C30", Offset = "0x4064C30", VA = "0x4068C30", Slot = "13")]
		protected virtual void OnEnemyClicked()
		{
		}

		[Token(Token = "0x60031F3")]
		[Address(RVA = "0x4068C9C", Offset = "0x4064C9C", VA = "0x4068C9C", Slot = "14")]
		protected virtual void OnButtonExtendBtnSendEmojisClicked()
		{
		}

		[Token(Token = "0x60031F4")]
		[Address(RVA = "0x4068D08", Offset = "0x4064D08", VA = "0x4068D08", Slot = "15")]
		protected virtual void OnButtonExtendBtnWordBg1Clicked()
		{
		}

		[Token(Token = "0x60031F5")]
		[Address(RVA = "0x4068D74", Offset = "0x4064D74", VA = "0x4068D74", Slot = "16")]
		protected virtual void OnButtonExtendBtnWordBg2Clicked()
		{
		}

		[Token(Token = "0x60031F6")]
		[Address(RVA = "0x4068DE0", Offset = "0x4064DE0", VA = "0x4068DE0", Slot = "17")]
		protected virtual void OnButtonExtendBtnWordBg3Clicked()
		{
		}

		[Token(Token = "0x60031F7")]
		[Address(RVA = "0x4068E4C", Offset = "0x4064E4C", VA = "0x4068E4C", Slot = "18")]
		protected virtual void OnButtonExtendBtnWordBg4Clicked()
		{
		}

		[Token(Token = "0x60031F8")]
		[Address(RVA = "0x4068EB8", Offset = "0x4064EB8", VA = "0x4068EB8", Slot = "19")]
		protected virtual void OnButtonExtendBtnEmojisThinkClicked()
		{
		}

		[Token(Token = "0x60031F9")]
		[Address(RVA = "0x4068F24", Offset = "0x4064F24", VA = "0x4068F24", Slot = "20")]
		protected virtual void OnButtonExtendBtnEmojisLaughClicked()
		{
		}

		[Token(Token = "0x60031FA")]
		[Address(RVA = "0x4068F90", Offset = "0x4064F90", VA = "0x4068F90", Slot = "21")]
		protected virtual void OnButtonExtendBtnEmojisCryClicked()
		{
		}

		[Token(Token = "0x60031FB")]
		[Address(RVA = "0x4068FFC", Offset = "0x4064FFC", VA = "0x4068FFC", Slot = "22")]
		protected virtual void OnButtonExtendBtnEmojisAngryClicked()
		{
		}

		[Token(Token = "0x60031FC")]
		[Address(RVA = "0x4069068", Offset = "0x4065068", VA = "0x4069068", Slot = "23")]
		protected virtual void OnButtonExtendBtnBanEmojisClicked()
		{
		}

		[Token(Token = "0x60031FD")]
		[Address(RVA = "0x40690D4", Offset = "0x40650D4", VA = "0x40690D4", Slot = "24")]
		protected virtual void OnButtonExtendImgPlayerBlessBgClicked()
		{
		}

		[Token(Token = "0x60031FE")]
		[Address(RVA = "0x4069140", Offset = "0x4065140", VA = "0x4069140", Slot = "25")]
		protected virtual void OnButtonExtendBtnGuideClicked()
		{
		}

		[Token(Token = "0x60031FF")]
		[Address(RVA = "0x40691AC", Offset = "0x40651AC", VA = "0x40691AC", Slot = "26")]
		protected virtual void OnButtonExtendRightBGClicked()
		{
		}

		[Token(Token = "0x6003200")]
		[Address(RVA = "0x4069218", Offset = "0x4065218", VA = "0x4069218", Slot = "27")]
		protected virtual void OnButtonExtendImgEnemyBlessBgClicked()
		{
		}

		[Token(Token = "0x6003201")]
		[Address(RVA = "0x4069284", Offset = "0x4065284", VA = "0x4069284", Slot = "28")]
		protected virtual void OnBtnCloseClicked()
		{
		}

		[Token(Token = "0x6003202")]
		[Address(RVA = "0x40692F0", Offset = "0x40652F0", VA = "0x40692F0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6003203")]
		[Address(RVA = "0x406930C", Offset = "0x406530C", VA = "0x406930C", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__1498))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6003204")]
		[Address(RVA = "0x40693A0", Offset = "0x40653A0", VA = "0x40693A0", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6003205")]
		[Address(RVA = "0x4069454", Offset = "0x4065454", VA = "0x4069454")]
		public GamePanelComponents()
		{
		}
	}
}
