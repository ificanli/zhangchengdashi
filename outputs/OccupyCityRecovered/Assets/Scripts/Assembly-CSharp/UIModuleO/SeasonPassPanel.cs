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
using UnityEngine;

namespace UIModuleO
{
	[Token(Token = "0x2000AF5")]
	public class SeasonPassPanel : SeasonPassPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000AF7")]
		[CompilerGenerated]
		private struct _003CLoadSeasonPassBackground_003Ed__11 : IAsyncStateMachine
		{
			[Token(Token = "0x400505C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400505D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400505E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public SeasonPassPanel _003C_003E4__this;

			[Token(Token = "0x400505F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private string _003CiconPath_003E5__2;

			[Token(Token = "0x4005060")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600425E")]
			[Address(RVA = "0x41CD83C", Offset = "0x41C983C", VA = "0x41CD83C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600425F")]
			[Address(RVA = "0x41CDE40", Offset = "0x41C9E40", VA = "0x41CDE40", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000AF8")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__12 : IAsyncStateMachine
		{
			[Token(Token = "0x4005061")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005062")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005063")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public SeasonPassPanel _003C_003E4__this;

			[Token(Token = "0x4005064")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6004260")]
			[Address(RVA = "0x41CDE4C", Offset = "0x41C9E4C", VA = "0x41CDE4C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004261")]
			[Address(RVA = "0x41CE2BC", Offset = "0x41CA2BC", VA = "0x41CE2BC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000AF9")]
		[CompilerGenerated]
		private struct _003CUpdateInfo_003Ed__15 : IAsyncStateMachine
		{
			[Token(Token = "0x4005065")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005066")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005067")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public SeasonPassPanel _003C_003E4__this;

			[Token(Token = "0x4005068")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public object[] args;

			[Token(Token = "0x4005069")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6004262")]
			[Address(RVA = "0x41CE2C8", Offset = "0x41CA2C8", VA = "0x41CE2C8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004263")]
			[Address(RVA = "0x41CF7E0", Offset = "0x41CB7E0", VA = "0x41CF7E0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400504E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private FundData fundData;

		[Token(Token = "0x400504F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Dictionary<int, FundManager.FundLevelData> _levelDataDict;

		[Token(Token = "0x4005050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private List<FundManager.FundLevelData> allFundLevelData;

		[Token(Token = "0x4005051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private bool hadInitLoopView;

		[Token(Token = "0x4005052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private string preName;

		[Token(Token = "0x4005053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private string spaceUpName;

		[Token(Token = "0x4005054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private string spaceDownName;

		[Token(Token = "0x4005055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private string _placement;

		[Token(Token = "0x4005056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private int lastShowMaxLevelRewardLevel;

		[Token(Token = "0x4005057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		private int currentShowMaxLevelRewardLevel;

		[Token(Token = "0x4005058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private float updateInter;

		[Token(Token = "0x6004248")]
		[Address(RVA = "0x41CB9EC", Offset = "0x41C79EC", VA = "0x41CB9EC", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6004249")]
		[Address(RVA = "0x41CBA2C", Offset = "0x41C7A2C", VA = "0x41CBA2C")]
		[AsyncStateMachine(typeof(_003CLoadSeasonPassBackground_003Ed__11))]
		private void LoadSeasonPassBackground()
		{
		}

		[Token(Token = "0x600424A")]
		[Address(RVA = "0x41CBABC", Offset = "0x41C7ABC", VA = "0x41CBABC", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__12))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x600424B")]
		[Address(RVA = "0x41CBB50", Offset = "0x41C7B50", VA = "0x41CBB50")]
		private void Update()
		{
		}

		[Token(Token = "0x600424C")]
		[Address(RVA = "0x41CBCE4", Offset = "0x41C7CE4", VA = "0x41CBCE4", Slot = "9")]
		[AsyncStateMachine(typeof(_003CUpdateInfo_003Ed__15))]
		public override void UpdateInfo(params object[] args)
		{
		}

		[Token(Token = "0x600424D")]
		[Address(RVA = "0x41CBD80", Offset = "0x41C7D80", VA = "0x41CBD80")]
		private void UpdateMaxPreviewReward()
		{
		}

		[Token(Token = "0x600424E")]
		[Address(RVA = "0x41CCBB8", Offset = "0x41C8BB8", VA = "0x41CCBB8")]
		private void OnScrollValueChanged(Vector2 scrollPosition)
		{
		}

		[Token(Token = "0x600424F")]
		[Address(RVA = "0x41CCBBC", Offset = "0x41C8BBC", VA = "0x41CCBBC")]
		private LoopListViewItem2 OnGetItemByIndex(LoopListView2 listView, int index)
		{
			return null;
		}

		[Token(Token = "0x6004250")]
		[Address(RVA = "0x41CC5E8", Offset = "0x41C85E8", VA = "0x41CC5E8")]
		public bool IsItemVisible(int itemIndex)
		{
			return default;
		}

		[Token(Token = "0x6004251")]
		[Address(RVA = "0x41CCDC4", Offset = "0x41C8DC4", VA = "0x41CCDC4", Slot = "17")]
		protected override void OnButtonExtendCloseBtnClicked()
		{
		}

		[Token(Token = "0x6004252")]
		[Address(RVA = "0x41CCE50", Offset = "0x41C8E50", VA = "0x41CCE50", Slot = "16")]
		protected override void OnButtonExtendMaxLevelRewardPreviewBtnClicked()
		{
		}

		[Token(Token = "0x6004253")]
		[Address(RVA = "0x41CCEF8", Offset = "0x41C8EF8", VA = "0x41CCEF8", Slot = "14")]
		protected override void OnButtonExtendReturnTopBtnClicked()
		{
		}

		[Token(Token = "0x6004254")]
		[Address(RVA = "0x41CCFA8", Offset = "0x41C8FA8", VA = "0x41CCFA8", Slot = "15")]
		protected override void OnButtonExtendSeasonPassIntroduceBtnClicked()
		{
		}

		[Token(Token = "0x6004255")]
		[Address(RVA = "0x41CD5A0", Offset = "0x41C95A0", VA = "0x41CD5A0")]
		public SeasonPassPanel()
		{
		}
	}
}
