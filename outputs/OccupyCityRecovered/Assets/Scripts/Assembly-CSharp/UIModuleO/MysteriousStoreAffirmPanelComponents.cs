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
	[Token(Token = "0x20009AA")]
	public class MysteriousStoreAffirmPanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20009AB")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__314 : IAsyncStateMachine
		{
			[Token(Token = "0x4004842")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004843")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004844")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MysteriousStoreAffirmPanelComponents _003C_003E4__this;

			[Token(Token = "0x4004845")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6003982")]
			[Address(RVA = "0x4104EF4", Offset = "0x4100EF4", VA = "0x4104EF4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003983")]
			[Address(RVA = "0x410516C", Offset = "0x410116C", VA = "0x410516C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400483C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Button _buttonBG;

		[Token(Token = "0x400483D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RectTransform _rectTransformRoot;

		[Token(Token = "0x400483E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private RewardItemUI _rewardItemUIRewardItemUI;

		[Token(Token = "0x400483F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private ButtonExtend _buttonExtendBtnClose;

		[Token(Token = "0x4004840")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private ButtonExtend _buttonExtendBtnBuy;

		[Token(Token = "0x4004841")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private TextMeshProUGUI _textMeshProUGUITxtPriceNum;

		[Token(Token = "0x170008C4")]
		public Button ButtonBG
		{
			[Token(Token = "0x6003973")]
			[Address(RVA = "0x4104AC8", Offset = "0x4100AC8", VA = "0x4104AC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008C5")]
		public RectTransform RectTransformRoot
		{
			[Token(Token = "0x6003974")]
			[Address(RVA = "0x4103ECC", Offset = "0x40FFECC", VA = "0x4103ECC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008C6")]
		public RewardItemUI RewardItemUIRewardItemUI
		{
			[Token(Token = "0x6003975")]
			[Address(RVA = "0x410492C", Offset = "0x410092C", VA = "0x410492C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008C7")]
		public ButtonExtend ButtonExtendBtnClose
		{
			[Token(Token = "0x6003976")]
			[Address(RVA = "0x4104B90", Offset = "0x4100B90", VA = "0x4104B90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008C8")]
		public ButtonExtend ButtonExtendBtnBuy
		{
			[Token(Token = "0x6003977")]
			[Address(RVA = "0x4104C58", Offset = "0x4100C58", VA = "0x4104C58")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008C9")]
		public TextMeshProUGUI TextMeshProUGUITxtPriceNum
		{
			[Token(Token = "0x6003978")]
			[Address(RVA = "0x41049F4", Offset = "0x41009F4", VA = "0x41049F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003979")]
		[Address(RVA = "0x4104D20", Offset = "0x4100D20", VA = "0x4104D20")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x600397A")]
		[Address(RVA = "0x4104058", Offset = "0x4100058", VA = "0x4104058", Slot = "12")]
		protected virtual void OnButtonBGClicked()
		{
		}

		[Token(Token = "0x600397B")]
		[Address(RVA = "0x41040F4", Offset = "0x41000F4", VA = "0x41040F4", Slot = "13")]
		protected virtual void OnButtonExtendBtnCloseClicked()
		{
		}

		[Token(Token = "0x600397C")]
		[Address(RVA = "0x41043CC", Offset = "0x41003CC", VA = "0x41043CC", Slot = "14")]
		protected virtual void OnButtonExtendBtnBuyClicked()
		{
		}

		[Token(Token = "0x600397D")]
		[Address(RVA = "0x4103EB0", Offset = "0x40FFEB0", VA = "0x4103EB0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600397E")]
		[Address(RVA = "0x410444C", Offset = "0x410044C", VA = "0x410444C", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__314))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x600397F")]
		[Address(RVA = "0x4104E38", Offset = "0x4100E38", VA = "0x4104E38", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6003980")]
		[Address(RVA = "0x4104440", Offset = "0x4100440", VA = "0x4104440")]
		public MysteriousStoreAffirmPanelComponents()
		{
		}
	}
}
