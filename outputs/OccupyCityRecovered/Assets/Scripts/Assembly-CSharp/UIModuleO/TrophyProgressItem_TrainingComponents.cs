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
	[Token(Token = "0x2000BC4")]
	public class TrophyProgressItem_TrainingComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000BC5")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__243 : IAsyncStateMachine
		{
			[Token(Token = "0x40055A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40055A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40055A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public TrophyProgressItem_TrainingComponents _003C_003E4__this;

			[Token(Token = "0x40055A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x60048AC")]
			[Address(RVA = "0x423C588", Offset = "0x4238588", VA = "0x423C588", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60048AD")]
			[Address(RVA = "0x423C800", Offset = "0x4238800", VA = "0x423C800", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400559B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TextMeshProUGUI _textMeshProUGUITrophyRequire;

		[Token(Token = "0x400559C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private ButtonExtend _buttonExtendBtnClaimCompleteReward;

		[Token(Token = "0x400559D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private RewardItemUI _rewardItemUIRewardItemUI;

		[Token(Token = "0x400559E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Image _imageImgDuiHao;

		[Token(Token = "0x400559F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private RectTransform _rectTransformProgressBarRoot;

		[Token(Token = "0x40055A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private RectTransform _rectTransformProgressOwn;

		[Token(Token = "0x40055A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private RectTransform _rectTransformProgressOwnBubble;

		[Token(Token = "0x40055A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private TextMeshProUGUI _textMeshProUGUIProgressOwnBubbleText;

		[Token(Token = "0x17000C9E")]
		public TextMeshProUGUI TextMeshProUGUITrophyRequire
		{
			[Token(Token = "0x600489D")]
			[Address(RVA = "0x423B5F0", Offset = "0x42375F0", VA = "0x423B5F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C9F")]
		public ButtonExtend ButtonExtendBtnClaimCompleteReward
		{
			[Token(Token = "0x600489E")]
			[Address(RVA = "0x423C2CC", Offset = "0x42382CC", VA = "0x423C2CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CA0")]
		public RewardItemUI RewardItemUIRewardItemUI
		{
			[Token(Token = "0x600489F")]
			[Address(RVA = "0x423BB38", Offset = "0x4237B38", VA = "0x423BB38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CA1")]
		public Image ImageImgDuiHao
		{
			[Token(Token = "0x60048A0")]
			[Address(RVA = "0x423BF20", Offset = "0x4237F20", VA = "0x423BF20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CA2")]
		public RectTransform RectTransformProgressBarRoot
		{
			[Token(Token = "0x60048A1")]
			[Address(RVA = "0x423BC00", Offset = "0x4237C00", VA = "0x423BC00")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CA3")]
		public RectTransform RectTransformProgressOwn
		{
			[Token(Token = "0x60048A2")]
			[Address(RVA = "0x423BCC8", Offset = "0x4237CC8", VA = "0x423BCC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CA4")]
		public RectTransform RectTransformProgressOwnBubble
		{
			[Token(Token = "0x60048A3")]
			[Address(RVA = "0x423BD90", Offset = "0x4237D90", VA = "0x423BD90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CA5")]
		public TextMeshProUGUI TextMeshProUGUIProgressOwnBubbleText
		{
			[Token(Token = "0x60048A4")]
			[Address(RVA = "0x423BE58", Offset = "0x4237E58", VA = "0x423BE58")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60048A5")]
		[Address(RVA = "0x423C394", Offset = "0x4238394", VA = "0x423C394")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x60048A6")]
		[Address(RVA = "0x423C000", Offset = "0x4238000", VA = "0x423C000", Slot = "12")]
		protected virtual void OnButtonExtendBtnClaimCompleteRewardClicked()
		{
		}

		[Token(Token = "0x60048A7")]
		[Address(RVA = "0x423C41C", Offset = "0x423841C", VA = "0x423C41C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60048A8")]
		[Address(RVA = "0x423C438", Offset = "0x4238438", VA = "0x423C438", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__243))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60048A9")]
		[Address(RVA = "0x423C4CC", Offset = "0x42384CC", VA = "0x423C4CC", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x60048AA")]
		[Address(RVA = "0x423C2C4", Offset = "0x42382C4", VA = "0x423C2C4")]
		public TrophyProgressItem_TrainingComponents()
		{
		}
	}
}
