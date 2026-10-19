using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using Spine.Unity;
using TMPro;
using UIFramework;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000903")]
	public class GoldCardAnimationPanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000904")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__224 : IAsyncStateMachine
		{
			[Token(Token = "0x4004402")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004403")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004404")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GoldCardAnimationPanelComponents _003C_003E4__this;

			[Token(Token = "0x4004405")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6003406")]
			[Address(RVA = "0x40A3E78", Offset = "0x409FE78", VA = "0x40A3E78", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003407")]
			[Address(RVA = "0x40A40F0", Offset = "0x40A00F0", VA = "0x40A40F0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40043EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RectTransform _rectTransformPlayerOpenGoldCardSpineEff;

		[Token(Token = "0x40043EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private SkeletonGraphic _skeletonGraphicSkeletonGraphic_PlayerGoldCard_Blue;

		[Token(Token = "0x40043EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private RectTransform _rectTransformSpine_ImgPlayerCardIcon;

		[Token(Token = "0x40043ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Image _imageSpine_ImgPlayerCardIcon;

		[Token(Token = "0x40043EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private SkeletonGraphic _skeletonGraphicSkeletonGraphic_PlayerGoldCard_Yellow;

		[Token(Token = "0x40043EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private RectTransform _rectTransformSpine_TxtPlayerGoldCardName;

		[Token(Token = "0x40043F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private TextMeshProUGUI _textMeshProUGUISpine_TxtPlayerGoldCardName;

		[Token(Token = "0x40043F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private RectTransform _rectTransformSpine_TxtPlayerLegendaryArrive;

		[Token(Token = "0x40043F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private TextMeshProUGUI _textMeshProUGUISpine_TxtPlayerLegendaryArrive;

		[Token(Token = "0x40043F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private RectTransform _rectTransformSpine_TxtPlayerProbabilityNum;

		[Token(Token = "0x40043F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private TextMeshProUGUI _textMeshProUGUISpine_TxtPlayerProbabilityNum;

		[Token(Token = "0x40043F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private TextMeshProUGUI _textMeshProUGUISpine_TxtPlayerProbability;

		[Token(Token = "0x40043F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private RectTransform _rectTransformEnemyOpenGoldCardSpineEff;

		[Token(Token = "0x40043F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private SkeletonGraphic _skeletonGraphicSkeletonGraphic_EnemyGoldCard_Red;

		[Token(Token = "0x40043F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private RectTransform _rectTransformSpine_ImgEnemyCardIcon;

		[Token(Token = "0x40043F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Image _imageSpine_ImgEnemyCardIcon;

		[Token(Token = "0x40043FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private SkeletonGraphic _skeletonGraphicSkeletonGraphic_EnemyGoldCard_Yellow;

		[Token(Token = "0x40043FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private RectTransform _rectTransformSpine_TxtEnemyGoldCardName;

		[Token(Token = "0x40043FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private TextMeshProUGUI _textMeshProUGUISpine_TxtEnemyGoldCardName;

		[Token(Token = "0x40043FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private RectTransform _rectTransformSpine_TxtEnemyLegendaryArrive;

		[Token(Token = "0x40043FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private TextMeshProUGUI _textMeshProUGUISpine_TxtEnemyLegendaryArrive;

		[Token(Token = "0x40043FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private RectTransform _rectTransformSpine_TxtEnemyProbability;

		[Token(Token = "0x4004400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private TextMeshProUGUI _textMeshProUGUISpine_TxtEnemyProbability;

		[Token(Token = "0x4004401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private TextMeshProUGUI _textMeshProUGUISpine_TxtEnemyProbabilityNum;

		[Token(Token = "0x17000705")]
		public RectTransform RectTransformPlayerOpenGoldCardSpineEff
		{
			[Token(Token = "0x60033E8")]
			[Address(RVA = "0x40A15B4", Offset = "0x409D5B4", VA = "0x40A15B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000706")]
		public SkeletonGraphic SkeletonGraphicSkeletonGraphic_PlayerGoldCard_Blue
		{
			[Token(Token = "0x60033E9")]
			[Address(RVA = "0x40A3CD0", Offset = "0x409FCD0", VA = "0x40A3CD0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000707")]
		public RectTransform RectTransformSpine_ImgPlayerCardIcon
		{
			[Token(Token = "0x60033EA")]
			[Address(RVA = "0x40A2234", Offset = "0x409E234", VA = "0x40A2234")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000708")]
		public Image ImageSpine_ImgPlayerCardIcon
		{
			[Token(Token = "0x60033EB")]
			[Address(RVA = "0x40A3A78", Offset = "0x409FA78", VA = "0x40A3A78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000709")]
		public SkeletonGraphic SkeletonGraphicSkeletonGraphic_PlayerGoldCard_Yellow
		{
			[Token(Token = "0x60033EC")]
			[Address(RVA = "0x40A3D98", Offset = "0x409FD98", VA = "0x40A3D98")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700070A")]
		public RectTransform RectTransformSpine_TxtPlayerGoldCardName
		{
			[Token(Token = "0x60033ED")]
			[Address(RVA = "0x40A1CBC", Offset = "0x409DCBC", VA = "0x40A1CBC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700070B")]
		public TextMeshProUGUI TextMeshProUGUISpine_TxtPlayerGoldCardName
		{
			[Token(Token = "0x60033EE")]
			[Address(RVA = "0x40A1D84", Offset = "0x409DD84", VA = "0x40A1D84")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700070C")]
		public RectTransform RectTransformSpine_TxtPlayerLegendaryArrive
		{
			[Token(Token = "0x60033EF")]
			[Address(RVA = "0x40A1E4C", Offset = "0x409DE4C", VA = "0x40A1E4C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700070D")]
		public TextMeshProUGUI TextMeshProUGUISpine_TxtPlayerLegendaryArrive
		{
			[Token(Token = "0x60033F0")]
			[Address(RVA = "0x40A1F14", Offset = "0x409DF14", VA = "0x40A1F14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700070E")]
		public RectTransform RectTransformSpine_TxtPlayerProbabilityNum
		{
			[Token(Token = "0x60033F1")]
			[Address(RVA = "0x40A1FDC", Offset = "0x409DFDC", VA = "0x40A1FDC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700070F")]
		public TextMeshProUGUI TextMeshProUGUISpine_TxtPlayerProbabilityNum
		{
			[Token(Token = "0x60033F2")]
			[Address(RVA = "0x40A20A4", Offset = "0x409E0A4", VA = "0x40A20A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000710")]
		public TextMeshProUGUI TextMeshProUGUISpine_TxtPlayerProbability
		{
			[Token(Token = "0x60033F3")]
			[Address(RVA = "0x40A216C", Offset = "0x409E16C", VA = "0x40A216C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000711")]
		public RectTransform RectTransformEnemyOpenGoldCardSpineEff
		{
			[Token(Token = "0x60033F4")]
			[Address(RVA = "0x40A14EC", Offset = "0x409D4EC", VA = "0x40A14EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000712")]
		public SkeletonGraphic SkeletonGraphicSkeletonGraphic_EnemyGoldCard_Red
		{
			[Token(Token = "0x60033F5")]
			[Address(RVA = "0x40A3B40", Offset = "0x409FB40", VA = "0x40A3B40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000713")]
		public RectTransform RectTransformSpine_ImgEnemyCardIcon
		{
			[Token(Token = "0x60033F6")]
			[Address(RVA = "0x40A1BF4", Offset = "0x409DBF4", VA = "0x40A1BF4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000714")]
		public Image ImageSpine_ImgEnemyCardIcon
		{
			[Token(Token = "0x60033F7")]
			[Address(RVA = "0x40A39B0", Offset = "0x409F9B0", VA = "0x40A39B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000715")]
		public SkeletonGraphic SkeletonGraphicSkeletonGraphic_EnemyGoldCard_Yellow
		{
			[Token(Token = "0x60033F8")]
			[Address(RVA = "0x40A3C08", Offset = "0x409FC08", VA = "0x40A3C08")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000716")]
		public RectTransform RectTransformSpine_TxtEnemyGoldCardName
		{
			[Token(Token = "0x60033F9")]
			[Address(RVA = "0x40A167C", Offset = "0x409D67C", VA = "0x40A167C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000717")]
		public TextMeshProUGUI TextMeshProUGUISpine_TxtEnemyGoldCardName
		{
			[Token(Token = "0x60033FA")]
			[Address(RVA = "0x40A1744", Offset = "0x409D744", VA = "0x40A1744")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000718")]
		public RectTransform RectTransformSpine_TxtEnemyLegendaryArrive
		{
			[Token(Token = "0x60033FB")]
			[Address(RVA = "0x40A180C", Offset = "0x409D80C", VA = "0x40A180C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000719")]
		public TextMeshProUGUI TextMeshProUGUISpine_TxtEnemyLegendaryArrive
		{
			[Token(Token = "0x60033FC")]
			[Address(RVA = "0x40A18D4", Offset = "0x409D8D4", VA = "0x40A18D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700071A")]
		public RectTransform RectTransformSpine_TxtEnemyProbability
		{
			[Token(Token = "0x60033FD")]
			[Address(RVA = "0x40A199C", Offset = "0x409D99C", VA = "0x40A199C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700071B")]
		public TextMeshProUGUI TextMeshProUGUISpine_TxtEnemyProbability
		{
			[Token(Token = "0x60033FE")]
			[Address(RVA = "0x40A1A64", Offset = "0x409DA64", VA = "0x40A1A64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700071C")]
		public TextMeshProUGUI TextMeshProUGUISpine_TxtEnemyProbabilityNum
		{
			[Token(Token = "0x60033FF")]
			[Address(RVA = "0x40A1B2C", Offset = "0x409DB2C", VA = "0x40A1B2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003400")]
		[Address(RVA = "0x40A3E6C", Offset = "0x409FE6C", VA = "0x40A3E6C")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6003401")]
		[Address(RVA = "0x40A0B14", Offset = "0x409CB14", VA = "0x40A0B14", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6003402")]
		[Address(RVA = "0x40A2310", Offset = "0x409E310", VA = "0x40A2310", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__224))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6003403")]
		[Address(RVA = "0x40A1438", Offset = "0x409D438", VA = "0x40A1438", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6003404")]
		[Address(RVA = "0x40A2304", Offset = "0x409E304", VA = "0x40A2304")]
		public GoldCardAnimationPanelComponents()
		{
		}
	}
}
