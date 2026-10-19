using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using Il2CppDummyDll;
using SuperScrollView;

namespace UIModuleO
{
	[Token(Token = "0x2000BC6")]
	public class TrophyProgressPanel : TrophyProgressPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000BC8")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__4 : IAsyncStateMachine
		{
			[Token(Token = "0x40055AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40055AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40055AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public TrophyProgressPanel _003C_003E4__this;

			[Token(Token = "0x40055AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x60048C2")]
			[Address(RVA = "0x423DC5C", Offset = "0x4239C5C", VA = "0x423DC5C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60048C3")]
			[Address(RVA = "0x423DE4C", Offset = "0x4239E4C", VA = "0x423DE4C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40055A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool _isListViewInit;

		[Token(Token = "0x40055A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private List<TrophyProgressRewardData> _rewardDataList;

		[Token(Token = "0x40055A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private List<TrophyProgressRewardData> _filteredRewardDataList;

		[Token(Token = "0x60048AE")]
		[Address(RVA = "0x423C80C", Offset = "0x423880C", VA = "0x423C80C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60048AF")]
		[Address(RVA = "0x423C904", Offset = "0x4238904", VA = "0x423C904", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__4))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60048B0")]
		[Address(RVA = "0x423C998", Offset = "0x4238998", VA = "0x423C998")]
		private void UpdateUI()
		{
		}

		[Token(Token = "0x60048B1")]
		[Address(RVA = "0x423CB10", Offset = "0x4238B10", VA = "0x423CB10")]
		private void FilterRewardDataList()
		{
		}

		[Token(Token = "0x60048B2")]
		[Address(RVA = "0x423CDA4", Offset = "0x4238DA4", VA = "0x423CDA4")]
		private void RefreshListViewSafe()
		{
		}

		[Token(Token = "0x60048B3")]
		[Address(RVA = "0x423CE1C", Offset = "0x4238E1C", VA = "0x423CE1C")]
		private void ScrollToCurrentProgress()
		{
		}

		[Token(Token = "0x60048B4")]
		[Address(RVA = "0x423CEB8", Offset = "0x4238EB8", VA = "0x423CEB8")]
		private int GetScrollIndex()
		{
			return default;
		}

		[Token(Token = "0x60048B5")]
		[Address(RVA = "0x423D12C", Offset = "0x423912C", VA = "0x423D12C")]
		private int GetFilteredIndex(int originalIndex)
		{
			return default;
		}

		[Token(Token = "0x60048B6")]
		[Address(RVA = "0x423D200", Offset = "0x4239200", VA = "0x423D200")]
		private void OnRewardClaimed(object o)
		{
		}

		[Token(Token = "0x60048B7")]
		[Address(RVA = "0x423D22C", Offset = "0x423922C", VA = "0x423D22C")]
		private LoopListViewItem2 OnGetItemByIndex(LoopListView2 listView, int index)
		{
			return null;
		}

		[Token(Token = "0x60048B8")]
		[Address(RVA = "0x423D42C", Offset = "0x423942C", VA = "0x423D42C")]
		private string GetItemPrefabNameByType(string nodeAwardType)
		{
			return null;
		}

		[Token(Token = "0x60048B9")]
		[Address(RVA = "0x423D5C8", Offset = "0x42395C8", VA = "0x423D5C8")]
		private void ShowItemByType(LoopListViewItem2 item, TrophyProgressRewardData rewardData, int index, string nodeAwardType)
		{
		}

		[Token(Token = "0x60048BA")]
		[Address(RVA = "0x423D8D4", Offset = "0x42398D4", VA = "0x423D8D4", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x60048BB")]
		[Address(RVA = "0x423D98C", Offset = "0x423998C", VA = "0x423D98C", Slot = "13")]
		protected override void OnButtonExtendBtnBackClicked()
		{
		}

		[Token(Token = "0x60048BC")]
		[Address(RVA = "0x423DA18", Offset = "0x4239A18", VA = "0x423DA18")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60048BD")]
		[Address(RVA = "0x423DAE0", Offset = "0x4239AE0", VA = "0x423DAE0")]
		public TrophyProgressPanel()
		{
		}
	}
}
