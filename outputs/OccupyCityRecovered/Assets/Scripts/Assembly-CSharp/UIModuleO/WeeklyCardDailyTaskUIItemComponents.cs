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
	[Token(Token = "0x2000C03")]
	public class WeeklyCardDailyTaskUIItemComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000C04")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__202 : IAsyncStateMachine
		{
			[Token(Token = "0x40056F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40056F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40056FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public WeeklyCardDailyTaskUIItemComponents _003C_003E4__this;

			[Token(Token = "0x40056FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6004A73")]
			[Address(RVA = "0x425BA48", Offset = "0x4257A48", VA = "0x425BA48", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004A74")]
			[Address(RVA = "0x425BCC0", Offset = "0x4257CC0", VA = "0x425BCC0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40056E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Image _imageImgBg;

		[Token(Token = "0x40056EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TextMeshProUGUI _textMeshProUGUITxtActivityNum;

		[Token(Token = "0x40056EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Image _imageImgProgressBlue;

		[Token(Token = "0x40056EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Image _imageImgProgressGreen;

		[Token(Token = "0x40056ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private TextMeshProUGUI _textMeshProUGUITxtTaskDes;

		[Token(Token = "0x40056EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private TextMeshProUGUI _textMeshProUGUITxtActivityProgress;

		[Token(Token = "0x40056EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private RectTransform _rectTransformBtnClaim;

		[Token(Token = "0x40056F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private ButtonExtend _buttonExtendBtnClaim;

		[Token(Token = "0x40056F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private TextMeshProUGUI _textMeshProUGUITxtClaim;

		[Token(Token = "0x40056F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private ButtonExtend _buttonExtendBtnGoTo;

		[Token(Token = "0x40056F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private TextMeshProUGUI _textMeshProUGUITxtClaim1;

		[Token(Token = "0x40056F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private RectTransform _rectTransformRewardItemUI;

		[Token(Token = "0x40056F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private RewardItemUI _rewardItemUIRewardItemUI;

		[Token(Token = "0x40056F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Image _imageImgDuiHao;

		[Token(Token = "0x40056F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Image _imageRedDot_UI;

		[Token(Token = "0x17000D05")]
		public Image ImageImgBg
		{
			[Token(Token = "0x6004A5C")]
			[Address(RVA = "0x425AB70", Offset = "0x4256B70", VA = "0x425AB70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D06")]
		public TextMeshProUGUI TextMeshProUGUITxtActivityNum
		{
			[Token(Token = "0x6004A5D")]
			[Address(RVA = "0x425AC38", Offset = "0x4256C38", VA = "0x425AC38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D07")]
		public Image ImageImgProgressBlue
		{
			[Token(Token = "0x6004A5E")]
			[Address(RVA = "0x425AD00", Offset = "0x4256D00", VA = "0x425AD00")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D08")]
		public Image ImageImgProgressGreen
		{
			[Token(Token = "0x6004A5F")]
			[Address(RVA = "0x425ADC8", Offset = "0x4256DC8", VA = "0x425ADC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D09")]
		public TextMeshProUGUI TextMeshProUGUITxtTaskDes
		{
			[Token(Token = "0x6004A60")]
			[Address(RVA = "0x425AE90", Offset = "0x4256E90", VA = "0x425AE90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D0A")]
		public TextMeshProUGUI TextMeshProUGUITxtActivityProgress
		{
			[Token(Token = "0x6004A61")]
			[Address(RVA = "0x425AF58", Offset = "0x4256F58", VA = "0x425AF58")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D0B")]
		public RectTransform RectTransformBtnClaim
		{
			[Token(Token = "0x6004A62")]
			[Address(RVA = "0x425B020", Offset = "0x4257020", VA = "0x425B020")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D0C")]
		public ButtonExtend ButtonExtendBtnClaim
		{
			[Token(Token = "0x6004A63")]
			[Address(RVA = "0x425B0E8", Offset = "0x42570E8", VA = "0x425B0E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D0D")]
		public TextMeshProUGUI TextMeshProUGUITxtClaim
		{
			[Token(Token = "0x6004A64")]
			[Address(RVA = "0x425B1B0", Offset = "0x42571B0", VA = "0x425B1B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D0E")]
		public ButtonExtend ButtonExtendBtnGoTo
		{
			[Token(Token = "0x6004A65")]
			[Address(RVA = "0x425B278", Offset = "0x4257278", VA = "0x425B278")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D0F")]
		public TextMeshProUGUI TextMeshProUGUITxtClaim1
		{
			[Token(Token = "0x6004A66")]
			[Address(RVA = "0x425B340", Offset = "0x4257340", VA = "0x425B340")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D10")]
		public RectTransform RectTransformRewardItemUI
		{
			[Token(Token = "0x6004A67")]
			[Address(RVA = "0x425B408", Offset = "0x4257408", VA = "0x425B408")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D11")]
		public RewardItemUI RewardItemUIRewardItemUI
		{
			[Token(Token = "0x6004A68")]
			[Address(RVA = "0x425B4D0", Offset = "0x42574D0", VA = "0x425B4D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D12")]
		public Image ImageImgDuiHao
		{
			[Token(Token = "0x6004A69")]
			[Address(RVA = "0x425B598", Offset = "0x4257598", VA = "0x425B598")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D13")]
		public Image ImageRedDot_UI
		{
			[Token(Token = "0x6004A6A")]
			[Address(RVA = "0x425B660", Offset = "0x4257660", VA = "0x425B660")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004A6B")]
		[Address(RVA = "0x425B728", Offset = "0x4257728", VA = "0x425B728")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6004A6C")]
		[Address(RVA = "0x425B7FC", Offset = "0x42577FC", VA = "0x425B7FC", Slot = "12")]
		protected virtual void OnButtonExtendBtnClaimClicked()
		{
		}

		[Token(Token = "0x6004A6D")]
		[Address(RVA = "0x425B868", Offset = "0x4257868", VA = "0x425B868", Slot = "13")]
		protected virtual void OnButtonExtendBtnGoToClicked()
		{
		}

		[Token(Token = "0x6004A6E")]
		[Address(RVA = "0x425B8D4", Offset = "0x42578D4", VA = "0x425B8D4", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6004A6F")]
		[Address(RVA = "0x425B8F0", Offset = "0x42578F0", VA = "0x425B8F0", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__202))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6004A70")]
		[Address(RVA = "0x425B984", Offset = "0x4257984", VA = "0x425B984", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6004A71")]
		[Address(RVA = "0x425BA38", Offset = "0x4257A38", VA = "0x425BA38")]
		public WeeklyCardDailyTaskUIItemComponents()
		{
		}
	}
}
