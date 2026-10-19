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
	[Token(Token = "0x2000AED")]
	public class RewardPanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000AEE")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__818 : IAsyncStateMachine
		{
			[Token(Token = "0x400502F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005030")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005031")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public RewardPanelComponents _003C_003E4__this;

			[Token(Token = "0x4005032")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6004226")]
			[Address(RVA = "0x41C9980", Offset = "0x41C5980", VA = "0x41C9980", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004227")]
			[Address(RVA = "0x41C9BF8", Offset = "0x41C5BF8", VA = "0x41C9BF8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400501A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RectTransform _rectTransformRewardContent;

		[Token(Token = "0x400501B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private ScrollRect _scrollRectRewardContent;

		[Token(Token = "0x400501C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private RectTransform _rectTransformItemsGroup;

		[Token(Token = "0x400501D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Image _imageBanner;

		[Token(Token = "0x400501E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private RectTransform _rectTransformRewardSingle;

		[Token(Token = "0x400501F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private RectTransform _rectTransformCard;

		[Token(Token = "0x4005020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private RewardItemUI _rewardItemUIRewardItemUI_Card;

		[Token(Token = "0x4005021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private ButtonExtend _buttonExtendShowDes;

		[Token(Token = "0x4005022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private RectTransform _rectTransformCardNameText;

		[Token(Token = "0x4005023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private TextMeshProUGUI _textMeshProUGUICardNameText;

		[Token(Token = "0x4005024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private RectTransform _rectTransformCardRareLevelText;

		[Token(Token = "0x4005025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private TextMeshProUGUI _textMeshProUGUICardRareLevelText;

		[Token(Token = "0x4005026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private RectTransform _rectTransformResource;

		[Token(Token = "0x4005027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private RewardItemUI _rewardItemUIRewardItemUI_Resource;

		[Token(Token = "0x4005028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private ButtonExtend _buttonExtendShowDes1;

		[Token(Token = "0x4005029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private TextMeshProUGUI _textMeshProUGUIResourceNameText;

		[Token(Token = "0x400502A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private RectTransform _rectTransformBattleBanner;

		[Token(Token = "0x400502B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private RewardItemUI _rewardItemUIRewardItemUI_BattleBanner;

		[Token(Token = "0x400502C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private ButtonExtend _buttonExtendShowDes2;

		[Token(Token = "0x400502D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private ButtonExtend _buttonExtendBGBtn;

		[Token(Token = "0x400502E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private ButtonExtend _buttonExtendConfirmBtn;

		[Token(Token = "0x17000A80")]
		public RectTransform RectTransformRewardContent
		{
			[Token(Token = "0x6004205")]
			[Address(RVA = "0x41C5EB8", Offset = "0x41C1EB8", VA = "0x41C5EB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A81")]
		public ScrollRect ScrollRectRewardContent
		{
			[Token(Token = "0x6004206")]
			[Address(RVA = "0x41C76FC", Offset = "0x41C36FC", VA = "0x41C76FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A82")]
		public RectTransform RectTransformItemsGroup
		{
			[Token(Token = "0x6004207")]
			[Address(RVA = "0x41C6818", Offset = "0x41C2818", VA = "0x41C6818")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A83")]
		public Image ImageBanner
		{
			[Token(Token = "0x6004208")]
			[Address(RVA = "0x41C68E0", Offset = "0x41C28E0", VA = "0x41C68E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A84")]
		public RectTransform RectTransformRewardSingle
		{
			[Token(Token = "0x6004209")]
			[Address(RVA = "0x41C5DF0", Offset = "0x41C1DF0", VA = "0x41C5DF0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A85")]
		public RectTransform RectTransformCard
		{
			[Token(Token = "0x600420A")]
			[Address(RVA = "0x41C5F80", Offset = "0x41C1F80", VA = "0x41C5F80")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A86")]
		public RewardItemUI RewardItemUIRewardItemUI_Card
		{
			[Token(Token = "0x600420B")]
			[Address(RVA = "0x41C6368", Offset = "0x41C2368", VA = "0x41C6368")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A87")]
		public ButtonExtend ButtonExtendShowDes
		{
			[Token(Token = "0x600420C")]
			[Address(RVA = "0x41C8108", Offset = "0x41C4108", VA = "0x41C8108")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A88")]
		public RectTransform RectTransformCardNameText
		{
			[Token(Token = "0x600420D")]
			[Address(RVA = "0x41C64F8", Offset = "0x41C24F8", VA = "0x41C64F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A89")]
		public TextMeshProUGUI TextMeshProUGUICardNameText
		{
			[Token(Token = "0x600420E")]
			[Address(RVA = "0x41C6430", Offset = "0x41C2430", VA = "0x41C6430")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A8A")]
		public RectTransform RectTransformCardRareLevelText
		{
			[Token(Token = "0x600420F")]
			[Address(RVA = "0x41C6688", Offset = "0x41C2688", VA = "0x41C6688")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A8B")]
		public TextMeshProUGUI TextMeshProUGUICardRareLevelText
		{
			[Token(Token = "0x6004210")]
			[Address(RVA = "0x41C65C0", Offset = "0x41C25C0", VA = "0x41C65C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A8C")]
		public RectTransform RectTransformResource
		{
			[Token(Token = "0x6004211")]
			[Address(RVA = "0x41C6048", Offset = "0x41C2048", VA = "0x41C6048")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A8D")]
		public RewardItemUI RewardItemUIRewardItemUI_Resource
		{
			[Token(Token = "0x6004212")]
			[Address(RVA = "0x41C62A0", Offset = "0x41C22A0", VA = "0x41C62A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A8E")]
		public ButtonExtend ButtonExtendShowDes1
		{
			[Token(Token = "0x6004213")]
			[Address(RVA = "0x41C81D0", Offset = "0x41C41D0", VA = "0x41C81D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A8F")]
		public TextMeshProUGUI TextMeshProUGUIResourceNameText
		{
			[Token(Token = "0x6004214")]
			[Address(RVA = "0x41C61D8", Offset = "0x41C21D8", VA = "0x41C61D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A90")]
		public RectTransform RectTransformBattleBanner
		{
			[Token(Token = "0x6004215")]
			[Address(RVA = "0x41C6110", Offset = "0x41C2110", VA = "0x41C6110")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A91")]
		public RewardItemUI RewardItemUIRewardItemUI_BattleBanner
		{
			[Token(Token = "0x6004216")]
			[Address(RVA = "0x41C6750", Offset = "0x41C2750", VA = "0x41C6750")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A92")]
		public ButtonExtend ButtonExtendShowDes2
		{
			[Token(Token = "0x6004217")]
			[Address(RVA = "0x41C8298", Offset = "0x41C4298", VA = "0x41C8298")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A93")]
		public ButtonExtend ButtonExtendBGBtn
		{
			[Token(Token = "0x6004218")]
			[Address(RVA = "0x41C8360", Offset = "0x41C4360", VA = "0x41C8360")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A94")]
		public ButtonExtend ButtonExtendConfirmBtn
		{
			[Token(Token = "0x6004219")]
			[Address(RVA = "0x41C8428", Offset = "0x41C4428", VA = "0x41C8428")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600421A")]
		[Address(RVA = "0x41C84F0", Offset = "0x41C44F0", VA = "0x41C84F0")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x600421B")]
		[Address(RVA = "0x41C86FC", Offset = "0x41C46FC", VA = "0x41C86FC", Slot = "12")]
		protected virtual void OnScrollRectRewardContentValueChanged(Vector2 arg)
		{
		}

		[Token(Token = "0x600421C")]
		[Address(RVA = "0x41C87B0", Offset = "0x41C47B0", VA = "0x41C87B0", Slot = "13")]
		protected virtual void OnButtonExtendShowDesClicked()
		{
		}

		[Token(Token = "0x600421D")]
		[Address(RVA = "0x41C881C", Offset = "0x41C481C", VA = "0x41C881C", Slot = "14")]
		protected virtual void OnButtonExtendShowDes1Clicked()
		{
		}

		[Token(Token = "0x600421E")]
		[Address(RVA = "0x41C8888", Offset = "0x41C4888", VA = "0x41C8888", Slot = "15")]
		protected virtual void OnButtonExtendShowDes2Clicked()
		{
		}

		[Token(Token = "0x600421F")]
		[Address(RVA = "0x41C4938", Offset = "0x41C0938", VA = "0x41C4938", Slot = "16")]
		protected virtual void OnButtonExtendBGBtnClicked()
		{
		}

		[Token(Token = "0x6004220")]
		[Address(RVA = "0x41C88F4", Offset = "0x41C48F4", VA = "0x41C88F4", Slot = "17")]
		protected virtual void OnButtonExtendConfirmBtnClicked()
		{
		}

		[Token(Token = "0x6004221")]
		[Address(RVA = "0x41C8960", Offset = "0x41C4960", VA = "0x41C8960", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6004222")]
		[Address(RVA = "0x41C6A30", Offset = "0x41C2A30", VA = "0x41C6A30", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__818))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6004223")]
		[Address(RVA = "0x41C4A30", Offset = "0x41C0A30", VA = "0x41C4A30", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6004224")]
		[Address(RVA = "0x41C6A24", Offset = "0x41C2A24", VA = "0x41C6A24")]
		public RewardPanelComponents()
		{
		}
	}
}
