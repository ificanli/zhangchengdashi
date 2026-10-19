using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using GameModule;
using Il2CppDummyDll;
using UnityEngine;

namespace UIModuleO
{
	[Token(Token = "0x20006B5")]
	public class ArenaProgressItem_Line : ArenaProgressItem_LineComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20006B7")]
		[CompilerGenerated]
		private struct _003CClickAnimation_003Ed__28 : IAsyncStateMachine
		{
			[Token(Token = "0x40035B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40035B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40035B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ArenaProgressItem_Line _003C_003E4__this;

			[Token(Token = "0x40035B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public object o;

			[Token(Token = "0x40035B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60023A9")]
			[Address(RVA = "0x3F49A9C", Offset = "0x3F45A9C", VA = "0x3F49A9C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60023AA")]
			[Address(RVA = "0x3F4AA5C", Offset = "0x3F46A5C", VA = "0x3F4AA5C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20006B8")]
		[CompilerGenerated]
		private struct _003COnButtonExtendBtnClaimCompleteRewardClicked_003Ed__32 : IAsyncStateMachine
		{
			[Token(Token = "0x40035B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40035B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40035BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ArenaProgressItem_Line _003C_003E4__this;

			[Token(Token = "0x40035BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UserBoxData _003Cbox_003E5__2;

			[Token(Token = "0x40035BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private RewardConfig _003Ccofig_003E5__3;

			[Token(Token = "0x40035BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60023AB")]
			[Address(RVA = "0x3F4AA68", Offset = "0x3F46A68", VA = "0x3F4AA68", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60023AC")]
			[Address(RVA = "0x3F4BC94", Offset = "0x3F47C94", VA = "0x3F4BC94", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20006B9")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__24 : IAsyncStateMachine
		{
			[Token(Token = "0x40035BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40035BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40035C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ArenaProgressItem_Line _003C_003E4__this;

			[Token(Token = "0x40035C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x60023AD")]
			[Address(RVA = "0x3F4BCA0", Offset = "0x3F47CA0", VA = "0x3F4BCA0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60023AE")]
			[Address(RVA = "0x3F4C0B4", Offset = "0x3F480B4", VA = "0x3F4C0B4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20006BA")]
		[CompilerGenerated]
		private struct _003CUpdateInfo_003Ed__26 : IAsyncStateMachine
		{
			[Token(Token = "0x40035C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40035C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40035C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ArenaProgressItem_Line _003C_003E4__this;

			[Token(Token = "0x40035C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public object[] args;

			[Token(Token = "0x40035C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private GlobalArenaInfo _003CfrArInfo_003E5__2;

			[Token(Token = "0x40035C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private string _003CtempId_003E5__3;

			[Token(Token = "0x40035C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UniTask<Sprite[]>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60023AF")]
			[Address(RVA = "0x3F4C0C0", Offset = "0x3F480C0", VA = "0x3F4C0C0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60023B0")]
			[Address(RVA = "0x3F5106C", Offset = "0x3F4D06C", VA = "0x3F5106C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20006BB")]
		[CompilerGenerated]
		private struct _003CUpdateUI_003Ed__25 : IAsyncStateMachine
		{
			[Token(Token = "0x40035C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40035CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40035CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ArenaProgressItem_Line _003C_003E4__this;

			[Token(Token = "0x40035CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public object o;

			[Token(Token = "0x60023B1")]
			[Address(RVA = "0x3F51078", Offset = "0x3F4D078", VA = "0x3F51078", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60023B2")]
			[Address(RVA = "0x3F51254", Offset = "0x3F4D254", VA = "0x3F51254", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20006BC")]
		[CompilerGenerated]
		private struct _003CUpdateUIFollowAnimation_003Ed__27 : IAsyncStateMachine
		{
			[Token(Token = "0x40035CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40035CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40035CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ArenaProgressItem_Line _003C_003E4__this;

			[Token(Token = "0x40035D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int _003CarenaAddFrontTrophyNum_003E5__2;

			[Token(Token = "0x40035D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60023B3")]
			[Address(RVA = "0x3F51260", Offset = "0x3F4D260", VA = "0x3F51260", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60023B4")]
			[Address(RVA = "0x3F5254C", Offset = "0x3F4E54C", VA = "0x3F5254C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400359F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private GlobalArenaInfo arenaInfo;

		[Token(Token = "0x40035A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private GlobalDanInfo danInfo;

		[Token(Token = "0x40035A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private GlobalDanInfo nextDanInfo;

		[Token(Token = "0x40035A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private Vector2 bubbleBornPos;

		[Token(Token = "0x40035A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		private Vector2 arenaIconBornPos;

		[Token(Token = "0x40035A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		private Vector2 prefabSize;

		[Token(Token = "0x40035A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		private Vector2 imgLineProgressOriginalSize;

		[Token(Token = "0x40035A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		private Vector2 imgLineProgressOriginalPos;

		[Token(Token = "0x40035A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		private string progressRewardCofig;

		[Token(Token = "0x40035A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		private List<RewardItemUI> allRewardItemUI;

		[Token(Token = "0x40035A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		private bool refreshInfoEnd;

		[Token(Token = "0x40035AA")]
		private const int defaultArenaItemHeight = 1706;

		[Token(Token = "0x40035AB")]
		private const float imgUILongBgPosX = 0f;

		[Token(Token = "0x40035AC")]
		private const float imgUILongBgPosY = 1000.3f;

		[Token(Token = "0x40035AD")]
		private const float imgUILongBgWidth = 43.4f;

		[Token(Token = "0x40035AE")]
		private const float imgUILongBgHeight = 290.74f;

		[Token(Token = "0x40035AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		private string[] rewardCofigAll;

		[Token(Token = "0x17000218")]
		private bool isArenaOne
		{
			[Token(Token = "0x6002390")]
			[Address(RVA = "0x3F481DC", Offset = "0x3F441DC", VA = "0x3F481DC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000219")]
		private bool isArenaFour
		{
			[Token(Token = "0x6002391")]
			[Address(RVA = "0x3F48234", Offset = "0x3F44234", VA = "0x3F48234")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700021A")]
		private bool isArenaFourWithChestImprove
		{
			[Token(Token = "0x6002392")]
			[Address(RVA = "0x3F4828C", Offset = "0x3F4428C", VA = "0x3F4828C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6002393")]
		[Address(RVA = "0x3F48320", Offset = "0x3F44320", VA = "0x3F48320", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6002394")]
		[Address(RVA = "0x3F48948", Offset = "0x3F44948", VA = "0x3F48948", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__24))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6002395")]
		[Address(RVA = "0x3F489DC", Offset = "0x3F449DC", VA = "0x3F489DC")]
		[AsyncStateMachine(typeof(_003CUpdateUI_003Ed__25))]
		private void UpdateUI(object o)
		{
		}

		[Token(Token = "0x6002396")]
		[Address(RVA = "0x3F48A78", Offset = "0x3F44A78", VA = "0x3F48A78", Slot = "9")]
		[AsyncStateMachine(typeof(_003CUpdateInfo_003Ed__26))]
		public override void UpdateInfo(params object[] args)
		{
		}

		[Token(Token = "0x6002397")]
		[Address(RVA = "0x3F48B14", Offset = "0x3F44B14", VA = "0x3F48B14")]
		[AsyncStateMachine(typeof(_003CUpdateUIFollowAnimation_003Ed__27))]
		private void UpdateUIFollowAnimation()
		{
		}

		[Token(Token = "0x6002398")]
		[Address(RVA = "0x3F48BA4", Offset = "0x3F44BA4", VA = "0x3F48BA4")]
		[AsyncStateMachine(typeof(_003CClickAnimation_003Ed__28))]
		private void ClickAnimation(object o)
		{
		}

		[Token(Token = "0x6002399")]
		[Address(RVA = "0x3F48C40", Offset = "0x3F44C40", VA = "0x3F48C40", Slot = "13")]
		protected override void OnButtonExtendBtnRewardOneClicked()
		{
		}

		[Token(Token = "0x600239A")]
		[Address(RVA = "0x3F48F58", Offset = "0x3F44F58", VA = "0x3F48F58", Slot = "14")]
		protected override void OnButtonExtendBtnRewardTwoClicked()
		{
		}

		[Token(Token = "0x600239B")]
		[Address(RVA = "0x3F49274", Offset = "0x3F45274", VA = "0x3F49274", Slot = "15")]
		protected override void OnButtonExtendBtnRewardThereClicked()
		{
		}

		[Token(Token = "0x600239C")]
		[Address(RVA = "0x3F49590", Offset = "0x3F45590", VA = "0x3F49590", Slot = "12")]
		[AsyncStateMachine(typeof(_003COnButtonExtendBtnClaimCompleteRewardClicked_003Ed__32))]
		protected override void OnButtonExtendBtnClaimCompleteRewardClicked()
		{
		}

		[Token(Token = "0x600239D")]
		[Address(RVA = "0x3F49620", Offset = "0x3F45620", VA = "0x3F49620")]
		public ArenaProgressItem_Line()
		{
		}
	}
}
