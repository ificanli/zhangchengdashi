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
	[Token(Token = "0x20008CF")]
	public class SkillItemComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20008D0")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__120 : IAsyncStateMachine
		{
			[Token(Token = "0x40042D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40042D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40042D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public SkillItemComponents _003C_003E4__this;

			[Token(Token = "0x40042D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x60032A3")]
			[Address(RVA = "0x4073D10", Offset = "0x406FD10", VA = "0x4073D10", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60032A4")]
			[Address(RVA = "0x4073F88", Offset = "0x406FF88", VA = "0x4073F88", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40042C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RectTransform _rectTransformSkillItem;

		[Token(Token = "0x40042C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private ButtonExtend _buttonExtendSkillItem;

		[Token(Token = "0x40042C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Image _imageImgIcon;

		[Token(Token = "0x40042C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Image _imageImgProgress;

		[Token(Token = "0x40042CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Image _imageImgCircleProgress;

		[Token(Token = "0x40042CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private RectTransform _rectTransformImgFrontBg;

		[Token(Token = "0x40042CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private RectTransform _rectTransformImgLock;

		[Token(Token = "0x40042CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Image _imageImgLock;

		[Token(Token = "0x40042CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Image _imageImgUseCountBg;

		[Token(Token = "0x40042CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private TextMeshProUGUI _textMeshProUGUITxtUseCount;

		[Token(Token = "0x40042D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private SkeletonGraphic _skeletonGraphicChargeSucceed;

		[Token(Token = "0x40042D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private SkeletonGraphic _skeletonGraphicExplode;

		[Token(Token = "0x17000699")]
		public RectTransform RectTransformSkillItem
		{
			[Token(Token = "0x6003290")]
			[Address(RVA = "0x4071544", Offset = "0x406D544", VA = "0x4071544")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700069A")]
		public ButtonExtend ButtonExtendSkillItem
		{
			[Token(Token = "0x6003291")]
			[Address(RVA = "0x4072B68", Offset = "0x406EB68", VA = "0x4072B68")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700069B")]
		public Image ImageImgIcon
		{
			[Token(Token = "0x6003292")]
			[Address(RVA = "0x4072AA0", Offset = "0x406EAA0", VA = "0x4072AA0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700069C")]
		public Image ImageImgProgress
		{
			[Token(Token = "0x6003293")]
			[Address(RVA = "0x406ECDC", Offset = "0x406ACDC", VA = "0x406ECDC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700069D")]
		public Image ImageImgCircleProgress
		{
			[Token(Token = "0x6003294")]
			[Address(RVA = "0x406EC14", Offset = "0x406AC14", VA = "0x406EC14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700069E")]
		public RectTransform RectTransformImgFrontBg
		{
			[Token(Token = "0x6003295")]
			[Address(RVA = "0x406E788", Offset = "0x406A788", VA = "0x406E788")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700069F")]
		public RectTransform RectTransformImgLock
		{
			[Token(Token = "0x6003296")]
			[Address(RVA = "0x406E6C0", Offset = "0x406A6C0", VA = "0x406E6C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006A0")]
		public Image ImageImgLock
		{
			[Token(Token = "0x6003297")]
			[Address(RVA = "0x406EB4C", Offset = "0x406AB4C", VA = "0x406EB4C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006A1")]
		public Image ImageImgUseCountBg
		{
			[Token(Token = "0x6003298")]
			[Address(RVA = "0x406EF94", Offset = "0x406AF94", VA = "0x406EF94")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006A2")]
		public TextMeshProUGUI TextMeshProUGUITxtUseCount
		{
			[Token(Token = "0x6003299")]
			[Address(RVA = "0x4070884", Offset = "0x406C884", VA = "0x4070884")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006A3")]
		public SkeletonGraphic SkeletonGraphicChargeSucceed
		{
			[Token(Token = "0x600329A")]
			[Address(RVA = "0x40717B8", Offset = "0x406D7B8", VA = "0x40717B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006A4")]
		public SkeletonGraphic SkeletonGraphicExplode
		{
			[Token(Token = "0x600329B")]
			[Address(RVA = "0x40716F0", Offset = "0x406D6F0", VA = "0x40716F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600329C")]
		[Address(RVA = "0x4073B1C", Offset = "0x406FB1C", VA = "0x4073B1C")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x600329D")]
		[Address(RVA = "0x40725C0", Offset = "0x406E5C0", VA = "0x40725C0", Slot = "12")]
		protected virtual void OnButtonExtendSkillItemClicked()
		{
		}

		[Token(Token = "0x600329E")]
		[Address(RVA = "0x4073BA4", Offset = "0x406FBA4", VA = "0x4073BA4", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600329F")]
		[Address(RVA = "0x4073BC0", Offset = "0x406FBC0", VA = "0x4073BC0", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__120))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60032A0")]
		[Address(RVA = "0x4073C54", Offset = "0x406FC54", VA = "0x4073C54", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x60032A1")]
		[Address(RVA = "0x40724DC", Offset = "0x406E4DC", VA = "0x40724DC")]
		public SkillItemComponents()
		{
		}
	}
}
