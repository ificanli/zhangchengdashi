using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using Il2CppDummyDll;
using SuperScrollView;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000BF9")]
	public class WeeklyCardActivityPanel : WeeklyCardActivityPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000BFB")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__14 : IAsyncStateMachine
		{
			[Token(Token = "0x40056BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40056BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40056BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public WeeklyCardActivityPanel _003C_003E4__this;

			[Token(Token = "0x40056BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x40056BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6004A2B")]
			[Address(RVA = "0x4255B2C", Offset = "0x4251B2C", VA = "0x4255B2C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004A2C")]
			[Address(RVA = "0x425615C", Offset = "0x425215C", VA = "0x425615C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000BFC")]
		[CompilerGenerated]
		private struct _003CUpdateInfo_003Ed__16 : IAsyncStateMachine
		{
			[Token(Token = "0x40056BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40056C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40056C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public WeeklyCardActivityPanel _003C_003E4__this;

			[Token(Token = "0x40056C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public object[] args;

			[Token(Token = "0x40056C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Image _003C_003E7__wrap1;

			[Token(Token = "0x40056C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6004A2D")]
			[Address(RVA = "0x4256168", Offset = "0x4252168", VA = "0x4256168", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004A2E")]
			[Address(RVA = "0x42582B0", Offset = "0x42542B0", VA = "0x42582B0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40056AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float[] progressStage;

		[Token(Token = "0x40056AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private UserWeeklyActivityData data;

		[Token(Token = "0x40056AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private List<GlobalWeeklyCardDailyTaskInfo> infos;

		[Token(Token = "0x40056AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private GoldCardWeeklyStageRewardRoot[] goldCardWeeklyStageRewardRoot;

		[Token(Token = "0x40056B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private string preName;

		[Token(Token = "0x40056B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private string spaceName;

		[Token(Token = "0x40056B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private bool hadInitLoopView;

		[Token(Token = "0x40056B3")]
		private const float BtnAnimeDuration = 0.3f;

		[Token(Token = "0x40056B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Vector3 BtnOriginalScale;

		[Token(Token = "0x40056B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x101")]
		private bool isBtnAnimating;

		[Token(Token = "0x40056B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private string _giftPackPlacementFromEntry;

		[Token(Token = "0x6004A17")]
		[Address(RVA = "0x4254350", Offset = "0x4250350", VA = "0x4254350", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6004A18")]
		[Address(RVA = "0x425453C", Offset = "0x425053C", VA = "0x425453C")]
		private void OnGiftPackPanelToggle(object isOpen)
		{
		}

		[Token(Token = "0x6004A19")]
		[Address(RVA = "0x4254824", Offset = "0x4250824", VA = "0x4254824")]
		private void Update()
		{
		}

		[Token(Token = "0x6004A1A")]
		[Address(RVA = "0x4254CD8", Offset = "0x4250CD8", VA = "0x4254CD8", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__14))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6004A1B")]
		[Address(RVA = "0x4254D74", Offset = "0x4250D74", VA = "0x4254D74")]
		private void ReportWeeklyCardEntryEvent()
		{
		}

		[Token(Token = "0x6004A1C")]
		[Address(RVA = "0x4254E10", Offset = "0x4250E10", VA = "0x4254E10", Slot = "9")]
		[AsyncStateMachine(typeof(_003CUpdateInfo_003Ed__16))]
		public override void UpdateInfo(params object[] args)
		{
		}

		[Token(Token = "0x6004A1D")]
		[Address(RVA = "0x4254EB0", Offset = "0x4250EB0", VA = "0x4254EB0")]
		private LoopListViewItem2 OnGetItemByIndex(LoopListView2 listView, int index)
		{
			return null;
		}

		[Token(Token = "0x6004A1E")]
		[Address(RVA = "0x4255088", Offset = "0x4251088", VA = "0x4255088", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6004A1F")]
		[Address(RVA = "0x42554E8", Offset = "0x42514E8", VA = "0x42554E8", Slot = "15")]
		protected override void OnButtonExtendBtnBackClicked()
		{
		}

		[Token(Token = "0x6004A20")]
		[Address(RVA = "0x4255574", Offset = "0x4251574", VA = "0x4255574", Slot = "12")]
		protected override void OnButtonExtendBtnCardGiftPackClicked()
		{
		}

		[Token(Token = "0x6004A21")]
		[Address(RVA = "0x4255654", Offset = "0x4251654", VA = "0x4255654", Slot = "13")]
		protected override void OnButtonExtendBtnClaimStageRewardClicked()
		{
		}

		[Token(Token = "0x6004A22")]
		[Address(RVA = "0x4255714", Offset = "0x4251714", VA = "0x4255714")]
		private void UpdateClaimStageRewardButtonVisibility()
		{
		}

		[Token(Token = "0x6004A23")]
		[Address(RVA = "0x42558AC", Offset = "0x42518AC", VA = "0x42558AC")]
		public WeeklyCardActivityPanel()
		{
		}
	}
}
