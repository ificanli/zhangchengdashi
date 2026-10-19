using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using GameModule;
using Il2CppDummyDll;
using SuperScrollView;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000894")]
	public class FundPanel : FundPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000895")]
		[CompilerGenerated]
		private struct _003CSetBG_003Ed__23 : IAsyncStateMachine
		{
			[Token(Token = "0x400410C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400410D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400410E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public FundPanel _003C_003E4__this;

			[Token(Token = "0x400410F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Image _003C_003E7__wrap1;

			[Token(Token = "0x4004110")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask<UnityEngine.Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003082")]
			[Address(RVA = "0x4050274", Offset = "0x404C274", VA = "0x4050274", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003083")]
			[Address(RVA = "0x4050698", Offset = "0x404C698", VA = "0x4050698", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000896")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__21 : IAsyncStateMachine
		{
			[Token(Token = "0x4004111")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004112")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004113")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public FundPanel _003C_003E4__this;

			[Token(Token = "0x4004114")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6003084")]
			[Address(RVA = "0x40506A4", Offset = "0x404C6A4", VA = "0x40506A4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003085")]
			[Address(RVA = "0x4050AB8", Offset = "0x404CAB8", VA = "0x4050AB8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40040F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private bool hadInitLoopView;

		[Token(Token = "0x40040F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private string preName;

		[Token(Token = "0x40040FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private string spaceUpName;

		[Token(Token = "0x40040FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private string spaceDownName;

		[Token(Token = "0x40040FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private List<FundManager.FundLevelData> allFundLevelData;

		[Token(Token = "0x40040FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private FundData fundData;

		[Token(Token = "0x40040FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private List<SwitchFundBtn> allFundButton;

		[Token(Token = "0x40040FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private List<FundManager.FundType> allFundTypes;

		[Token(Token = "0x4004100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Dictionary<int, FundManager.FundLevelData> _levelDataDict;

		[Token(Token = "0x4004101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private string _placement;

		[Token(Token = "0x4004102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private List<HWIAPButton> totalItemCount2IAPButton;

		[Token(Token = "0x4004103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private List<HWIAPButton> totalItemCount3IAPButton;

		[Token(Token = "0x4004104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private int currentLevel;

		[Token(Token = "0x4004105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private int currentActivity;

		[Token(Token = "0x4004106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private FundManager.FundLevelData lastLevelData;

		[Token(Token = "0x4004107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private FundManager.FundLevelData nextLevelData;

		[Token(Token = "0x4004108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private int lastLevelNeedActivity;

		[Token(Token = "0x4004109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		private int nextLevelNeedActivity;

		[Token(Token = "0x400410A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private int currentLevelActivity;

		[Token(Token = "0x400410B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
		private float progressValue;

		[Token(Token = "0x6003078")]
		[Address(RVA = "0x404D240", Offset = "0x4049240", VA = "0x404D240", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6003079")]
		[Address(RVA = "0x404D4A0", Offset = "0x40494A0", VA = "0x404D4A0", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__21))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x600307A")]
		[Address(RVA = "0x404D534", Offset = "0x4049534", VA = "0x404D534", Slot = "9")]
		public override void UpdateInfo(params object[] args)
		{
		}

		[Token(Token = "0x600307B")]
		[Address(RVA = "0x404F8F8", Offset = "0x404B8F8", VA = "0x404F8F8")]
		[AsyncStateMachine(typeof(_003CSetBG_003Ed__23))]
		private void SetBG()
		{
		}

		[Token(Token = "0x600307C")]
		[Address(RVA = "0x404F2C0", Offset = "0x404B2C0", VA = "0x404F2C0")]
		private void SetFundBtn()
		{
		}

		[Token(Token = "0x600307D")]
		[Address(RVA = "0x404FC78", Offset = "0x404BC78", VA = "0x404FC78")]
		private LoopListViewItem2 OnGetItemByIndex(LoopListView2 listView, int index)
		{
			return null;
		}

		[Token(Token = "0x600307E")]
		[Address(RVA = "0x404FF88", Offset = "0x404BF88", VA = "0x404FF88", Slot = "12")]
		protected override void OnButtonExtendPanelBlackBGClicked()
		{
		}

		[Token(Token = "0x600307F")]
		[Address(RVA = "0x4050014", Offset = "0x404C014", VA = "0x4050014", Slot = "20")]
		protected override void OnButtonExtendCloseBtnClicked()
		{
		}

		[Token(Token = "0x6003080")]
		[Address(RVA = "0x40500A0", Offset = "0x404C0A0", VA = "0x40500A0")]
		public FundPanel()
		{
		}
	}
}
