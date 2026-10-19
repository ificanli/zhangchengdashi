using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UIFramework;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x200090B")]
	public class GoldCardWeeklyStageRewardRootComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200090C")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__74 : IAsyncStateMachine
		{
			[Token(Token = "0x400441B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400441C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400441D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GoldCardWeeklyStageRewardRootComponents _003C_003E4__this;

			[Token(Token = "0x400441E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x600342C")]
			[Address(RVA = "0x40A5844", Offset = "0x40A1844", VA = "0x40A5844", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600342D")]
			[Address(RVA = "0x40A5ABC", Offset = "0x40A1ABC", VA = "0x40A5ABC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RectTransform _rectTransformGoldCardWeeklyStageRewardRoot;

		[Token(Token = "0x4004417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TextMeshProUGUI _textMeshProUGUITxtStageNum;

		[Token(Token = "0x4004418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private RectTransform _rectTransformRewardItemUI;

		[Token(Token = "0x4004419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Image _imageImgDuiHaoStage;

		[Token(Token = "0x400441A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Image _imageRedDot_UI;

		[Token(Token = "0x1700071F")]
		public RectTransform RectTransformGoldCardWeeklyStageRewardRoot
		{
			[Token(Token = "0x6003421")]
			[Address(RVA = "0x40A4B70", Offset = "0x40A0B70", VA = "0x40A4B70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000720")]
		public TextMeshProUGUI TextMeshProUGUITxtStageNum
		{
			[Token(Token = "0x6003422")]
			[Address(RVA = "0x40A5140", Offset = "0x40A1140", VA = "0x40A5140")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000721")]
		public RectTransform RectTransformRewardItemUI
		{
			[Token(Token = "0x6003423")]
			[Address(RVA = "0x40A5398", Offset = "0x40A1398", VA = "0x40A5398")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000722")]
		public Image ImageImgDuiHaoStage
		{
			[Token(Token = "0x6003424")]
			[Address(RVA = "0x40A5208", Offset = "0x40A1208", VA = "0x40A5208")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000723")]
		public Image ImageRedDot_UI
		{
			[Token(Token = "0x6003425")]
			[Address(RVA = "0x40A52D0", Offset = "0x40A12D0", VA = "0x40A52D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003426")]
		[Address(RVA = "0x40A5784", Offset = "0x40A1784", VA = "0x40A5784")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6003427")]
		[Address(RVA = "0x40A4B68", Offset = "0x40A0B68", VA = "0x40A4B68", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6003428")]
		[Address(RVA = "0x40A5504", Offset = "0x40A1504", VA = "0x40A5504", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__74))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6003429")]
		[Address(RVA = "0x40A5788", Offset = "0x40A1788", VA = "0x40A5788", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x600342A")]
		[Address(RVA = "0x40A54F8", Offset = "0x40A14F8", VA = "0x40A54F8")]
		public GoldCardWeeklyStageRewardRootComponents()
		{
		}
	}
}
