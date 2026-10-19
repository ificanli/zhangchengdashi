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

namespace UIModuleO
{
	[Token(Token = "0x2000B02")]
	public class SeasonPassRewardItem_LineComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000B03")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__523 : IAsyncStateMachine
		{
			[Token(Token = "0x40050AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40050AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40050AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public SeasonPassRewardItem_LineComponents _003C_003E4__this;

			[Token(Token = "0x40050AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x60042BE")]
			[Address(RVA = "0x41D2CBC", Offset = "0x41CECBC", VA = "0x41D2CBC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60042BF")]
			[Address(RVA = "0x41D2F34", Offset = "0x41CEF34", VA = "0x41D2F34", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40050A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private SeasonPassRewardItem _seasonPassRewardItemSeasonPassRewardItem1;

		[Token(Token = "0x40050A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private ButtonExtend _buttonExtendClaimBtn1;

		[Token(Token = "0x40050A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private SeasonPassRewardItem _seasonPassRewardItemSeasonPassRewardItem2;

		[Token(Token = "0x40050A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private ButtonExtend _buttonExtendClaimBtn11;

		[Token(Token = "0x40050A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private RectTransform _rectTransformLevel_Lock;

		[Token(Token = "0x40050A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private RectTransform _rectTransformLevel_Unlock;

		[Token(Token = "0x40050AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private TextMeshProUGUI _textMeshProUGUILevelText;

		[Token(Token = "0x40050AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private RectTransform _rectTransformCurrentLevelLine;

		[Token(Token = "0x17000ABF")]
		public SeasonPassRewardItem SeasonPassRewardItemSeasonPassRewardItem1
		{
			[Token(Token = "0x60042AE")]
			[Address(RVA = "0x41D270C", Offset = "0x41CE70C", VA = "0x41D270C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AC0")]
		public ButtonExtend ButtonExtendClaimBtn1
		{
			[Token(Token = "0x60042AF")]
			[Address(RVA = "0x41D28A8", Offset = "0x41CE8A8", VA = "0x41D28A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AC1")]
		public SeasonPassRewardItem SeasonPassRewardItemSeasonPassRewardItem2
		{
			[Token(Token = "0x60042B0")]
			[Address(RVA = "0x41D27D4", Offset = "0x41CE7D4", VA = "0x41D27D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AC2")]
		public ButtonExtend ButtonExtendClaimBtn11
		{
			[Token(Token = "0x60042B1")]
			[Address(RVA = "0x41D2970", Offset = "0x41CE970", VA = "0x41D2970")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AC3")]
		public RectTransform RectTransformLevel_Lock
		{
			[Token(Token = "0x60042B2")]
			[Address(RVA = "0x41D257C", Offset = "0x41CE57C", VA = "0x41D257C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AC4")]
		public RectTransform RectTransformLevel_Unlock
		{
			[Token(Token = "0x60042B3")]
			[Address(RVA = "0x41D2644", Offset = "0x41CE644", VA = "0x41D2644")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AC5")]
		public TextMeshProUGUI TextMeshProUGUILevelText
		{
			[Token(Token = "0x60042B4")]
			[Address(RVA = "0x41D23EC", Offset = "0x41CE3EC", VA = "0x41D23EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AC6")]
		public RectTransform RectTransformCurrentLevelLine
		{
			[Token(Token = "0x60042B5")]
			[Address(RVA = "0x41D24B4", Offset = "0x41CE4B4", VA = "0x41D24B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60042B6")]
		[Address(RVA = "0x41D2A38", Offset = "0x41CEA38", VA = "0x41D2A38")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x60042B7")]
		[Address(RVA = "0x41D2B0C", Offset = "0x41CEB0C", VA = "0x41D2B0C", Slot = "12")]
		protected virtual void OnButtonExtendClaimBtn1Clicked()
		{
		}

		[Token(Token = "0x60042B8")]
		[Address(RVA = "0x41D2B78", Offset = "0x41CEB78", VA = "0x41D2B78", Slot = "13")]
		protected virtual void OnButtonExtendClaimBtn11Clicked()
		{
		}

		[Token(Token = "0x60042B9")]
		[Address(RVA = "0x41D2BE4", Offset = "0x41CEBE4", VA = "0x41D2BE4", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60042BA")]
		[Address(RVA = "0x41D1AE0", Offset = "0x41CDAE0", VA = "0x41D1AE0", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__523))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60042BB")]
		[Address(RVA = "0x41D2C00", Offset = "0x41CEC00", VA = "0x41D2C00", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x60042BC")]
		[Address(RVA = "0x41D1AD4", Offset = "0x41CDAD4", VA = "0x41D1AD4")]
		public SeasonPassRewardItem_LineComponents()
		{
		}
	}
}
