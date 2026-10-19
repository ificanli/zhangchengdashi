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
	[Token(Token = "0x2000B8E")]
	public class SpecialSummonPanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000B8F")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__358 : IAsyncStateMachine
		{
			[Token(Token = "0x400542E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400542F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005430")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public SpecialSummonPanelComponents _003C_003E4__this;

			[Token(Token = "0x4005431")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x60046F8")]
			[Address(RVA = "0x421D4BC", Offset = "0x42194BC", VA = "0x421D4BC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60046F9")]
			[Address(RVA = "0x421D734", Offset = "0x4219734", VA = "0x421D734", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400541E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ButtonExtend _buttonExtendSpecialDesBtn;

		[Token(Token = "0x400541F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private SkeletonGraphic _skeletonGraphicSpecialMagicCircleSkeletonGraphic;

		[Token(Token = "0x4005420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private SkeletonGraphic _skeletonGraphicArtifactSkeletonGraphic;

		[Token(Token = "0x4005421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Image _imageArtifactIcon;

		[Token(Token = "0x4005422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private TextMeshProUGUI _textMeshProUGUIArtifactName;

		[Token(Token = "0x4005423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private RectTransform _rectTransformRefreshBtn;

		[Token(Token = "0x4005424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private ButtonExtend _buttonExtendRefreshBtn;

		[Token(Token = "0x4005425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private TextMeshProUGUI _textMeshProUGUISpecialRefreshTime;

		[Token(Token = "0x4005426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private TextMeshProUGUI _textMeshProUGUITenTips;

		[Token(Token = "0x4005427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private RectTransform _rectTransformSummonPack;

		[Token(Token = "0x4005428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private ButtonExtend _buttonExtendSummonPack;

		[Token(Token = "0x4005429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private AdButtonExtend _adButtonExtendSpecialSummonOne;

		[Token(Token = "0x400542A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private TextMeshProUGUI _textMeshProUGUISpecialSummonOneCost;

		[Token(Token = "0x400542B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private ButtonExtend _buttonExtendSpecialSummonTen;

		[Token(Token = "0x400542C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private TextMeshProUGUI _textMeshProUGUISpecialSummonTenCost;

		[Token(Token = "0x400542D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private TextMeshProUGUI _textMeshProUGUISpecialSummonTimesLimit;

		[Token(Token = "0x17000BEF")]
		public ButtonExtend ButtonExtendSpecialDesBtn
		{
			[Token(Token = "0x60046DD")]
			[Address(RVA = "0x421CBC8", Offset = "0x4218BC8", VA = "0x421CBC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BF0")]
		public SkeletonGraphic SkeletonGraphicSpecialMagicCircleSkeletonGraphic
		{
			[Token(Token = "0x60046DE")]
			[Address(RVA = "0x421ADC0", Offset = "0x4216DC0", VA = "0x421ADC0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BF1")]
		public SkeletonGraphic SkeletonGraphicArtifactSkeletonGraphic
		{
			[Token(Token = "0x60046DF")]
			[Address(RVA = "0x421BA98", Offset = "0x4217A98", VA = "0x421BA98")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BF2")]
		public Image ImageArtifactIcon
		{
			[Token(Token = "0x60046E0")]
			[Address(RVA = "0x4217CB8", Offset = "0x4213CB8", VA = "0x4217CB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BF3")]
		public TextMeshProUGUI TextMeshProUGUIArtifactName
		{
			[Token(Token = "0x60046E1")]
			[Address(RVA = "0x421C328", Offset = "0x4218328", VA = "0x421C328")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BF4")]
		public RectTransform RectTransformRefreshBtn
		{
			[Token(Token = "0x60046E2")]
			[Address(RVA = "0x4218190", Offset = "0x4214190", VA = "0x4218190")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BF5")]
		public ButtonExtend ButtonExtendRefreshBtn
		{
			[Token(Token = "0x60046E3")]
			[Address(RVA = "0x421CC90", Offset = "0x4218C90", VA = "0x421CC90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BF6")]
		public TextMeshProUGUI TextMeshProUGUISpecialRefreshTime
		{
			[Token(Token = "0x60046E4")]
			[Address(RVA = "0x421A530", Offset = "0x4216530", VA = "0x421A530")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BF7")]
		public TextMeshProUGUI TextMeshProUGUITenTips
		{
			[Token(Token = "0x60046E5")]
			[Address(RVA = "0x421A468", Offset = "0x4216468", VA = "0x421A468")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BF8")]
		public RectTransform RectTransformSummonPack
		{
			[Token(Token = "0x60046E6")]
			[Address(RVA = "0x42180C8", Offset = "0x42140C8", VA = "0x42180C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BF9")]
		public ButtonExtend ButtonExtendSummonPack
		{
			[Token(Token = "0x60046E7")]
			[Address(RVA = "0x421CD58", Offset = "0x4218D58", VA = "0x421CD58")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BFA")]
		public AdButtonExtend AdButtonExtendSpecialSummonOne
		{
			[Token(Token = "0x60046E8")]
			[Address(RVA = "0x421CE20", Offset = "0x4218E20", VA = "0x421CE20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BFB")]
		public TextMeshProUGUI TextMeshProUGUISpecialSummonOneCost
		{
			[Token(Token = "0x60046E9")]
			[Address(RVA = "0x421A210", Offset = "0x4216210", VA = "0x421A210")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BFC")]
		public ButtonExtend ButtonExtendSpecialSummonTen
		{
			[Token(Token = "0x60046EA")]
			[Address(RVA = "0x421CEE8", Offset = "0x4218EE8", VA = "0x421CEE8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BFD")]
		public TextMeshProUGUI TextMeshProUGUISpecialSummonTenCost
		{
			[Token(Token = "0x60046EB")]
			[Address(RVA = "0x421A2D8", Offset = "0x42162D8", VA = "0x421A2D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BFE")]
		public TextMeshProUGUI TextMeshProUGUISpecialSummonTimesLimit
		{
			[Token(Token = "0x60046EC")]
			[Address(RVA = "0x421A3A0", Offset = "0x42163A0", VA = "0x421A3A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60046ED")]
		[Address(RVA = "0x421CFB0", Offset = "0x4218FB0", VA = "0x421CFB0")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x60046EE")]
		[Address(RVA = "0x421D150", Offset = "0x4219150", VA = "0x421D150", Slot = "12")]
		protected virtual void OnButtonExtendSpecialDesBtnClicked()
		{
		}

		[Token(Token = "0x60046EF")]
		[Address(RVA = "0x421D1BC", Offset = "0x42191BC", VA = "0x421D1BC", Slot = "13")]
		protected virtual void OnButtonExtendRefreshBtnClicked()
		{
		}

		[Token(Token = "0x60046F0")]
		[Address(RVA = "0x421D228", Offset = "0x4219228", VA = "0x421D228", Slot = "14")]
		protected virtual void OnButtonExtendSummonPackClicked()
		{
		}

		[Token(Token = "0x60046F1")]
		[Address(RVA = "0x421D294", Offset = "0x4219294", VA = "0x421D294", Slot = "15")]
		protected virtual void OnAdButtonExtendSpecialSummonOneClicked()
		{
		}

		[Token(Token = "0x60046F2")]
		[Address(RVA = "0x421D300", Offset = "0x4219300", VA = "0x421D300", Slot = "16")]
		protected virtual void OnButtonExtendSpecialSummonTenClicked()
		{
		}

		[Token(Token = "0x60046F3")]
		[Address(RVA = "0x4217860", Offset = "0x4213860", VA = "0x4217860", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60046F4")]
		[Address(RVA = "0x421D36C", Offset = "0x421936C", VA = "0x421D36C", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__358))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60046F5")]
		[Address(RVA = "0x421D400", Offset = "0x4219400", VA = "0x421D400", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x60046F6")]
		[Address(RVA = "0x421ABA0", Offset = "0x4216BA0", VA = "0x421ABA0")]
		public SpecialSummonPanelComponents()
		{
		}
	}
}
