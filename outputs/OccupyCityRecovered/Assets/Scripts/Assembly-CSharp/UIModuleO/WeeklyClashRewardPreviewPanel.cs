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
	[Token(Token = "0x2000C27")]
	public class WeeklyClashRewardPreviewPanel : WeeklyClashRewardPreviewPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000C28")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__10 : IAsyncStateMachine
		{
			[Token(Token = "0x4005799")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400579A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400579B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public WeeklyClashRewardPreviewPanel _003C_003E4__this;

			[Token(Token = "0x400579C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x400579D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6004B44")]
			[Address(RVA = "0x4266FF4", Offset = "0x4262FF4", VA = "0x4266FF4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004B45")]
			[Address(RVA = "0x4267984", Offset = "0x4263984", VA = "0x4267984", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4005790")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private List<SeasonRankingRewardConfig> globalInfoSeasonRewardConfigs;

		[Token(Token = "0x4005791")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool showSeason;

		[Token(Token = "0x4005792")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x99")]
		private bool hadInitLoopView;

		[Token(Token = "0x4005793")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private string preName;

		[Token(Token = "0x4005794")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private string spaceUpName;

		[Token(Token = "0x4005795")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private string spaceDownName;

		[Token(Token = "0x4005796")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private int itemCount;

		[Token(Token = "0x4005797")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private bool isWeeklyLoading;

		[Token(Token = "0x4005798")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBD")]
		private bool isSeasonLoading;

		[Token(Token = "0x6004B36")]
		[Address(RVA = "0x4266080", Offset = "0x4262080", VA = "0x4266080")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6004B37")]
		[Address(RVA = "0x4266084", Offset = "0x4262084", VA = "0x4266084", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__10))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6004B38")]
		[Address(RVA = "0x4266120", Offset = "0x4262120", VA = "0x4266120")]
		private LoopListViewItem2 OnGetItemByIndex(LoopListView2 listView, int index)
		{
			return null;
		}

		[Token(Token = "0x6004B39")]
		[Address(RVA = "0x4266350", Offset = "0x4262350", VA = "0x4266350")]
		private void UpdateSelfRewardPreviewItem()
		{
		}

		[Token(Token = "0x6004B3A")]
		[Address(RVA = "0x4266654", Offset = "0x4262654", VA = "0x4266654")]
		private void UpdateAllItem()
		{
		}

		[Token(Token = "0x6004B3B")]
		[Address(RVA = "0x4266744", Offset = "0x4262744", VA = "0x4266744", Slot = "17")]
		protected override void OnToggleSeasonToggleValueChanged(bool arg)
		{
		}

		[Token(Token = "0x6004B3C")]
		[Address(RVA = "0x4266814", Offset = "0x4262814", VA = "0x4266814", Slot = "16")]
		protected override void OnToggleWeeklyToggleValueChanged(bool arg)
		{
		}

		[Token(Token = "0x6004B3D")]
		[Address(RVA = "0x42668E0", Offset = "0x42628E0", VA = "0x42668E0", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6004B3E")]
		[Address(RVA = "0x4266B10", Offset = "0x4262B10", VA = "0x4266B10", Slot = "12")]
		protected override void OnButtonExtendBGClicked()
		{
		}

		[Token(Token = "0x6004B3F")]
		[Address(RVA = "0x4266B9C", Offset = "0x4262B9C", VA = "0x4266B9C", Slot = "13")]
		protected override void OnButtonExtendCloseBtnClicked()
		{
		}

		[Token(Token = "0x6004B40")]
		[Address(RVA = "0x4266C28", Offset = "0x4262C28", VA = "0x4266C28")]
		public WeeklyClashRewardPreviewPanel()
		{
		}
	}
}
