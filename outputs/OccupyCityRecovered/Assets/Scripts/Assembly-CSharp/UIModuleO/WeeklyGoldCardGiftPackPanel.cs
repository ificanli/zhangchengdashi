using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DG.Tweening;
using DataModule;
using Il2CppDummyDll;
using UnityEngine;

namespace UIModuleO
{
	[Token(Token = "0x2000C38")]
	public class WeeklyGoldCardGiftPackPanel : WeeklyGoldCardGiftPackPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000C3A")]
		[CompilerGenerated]
		private struct _003CPlayShowAnimation_003Ed__11 : IAsyncStateMachine
		{
			[Token(Token = "0x40057F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40057F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40057F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public WeeklyGoldCardGiftPackPanel _003C_003E4__this;

			[Token(Token = "0x40057F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6004BC7")]
			[Address(RVA = "0x426E7C8", Offset = "0x426A7C8", VA = "0x426E7C8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004BC8")]
			[Address(RVA = "0x426EE00", Offset = "0x426AE00", VA = "0x426EE00", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000C3B")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__10 : IAsyncStateMachine
		{
			[Token(Token = "0x40057F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40057FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40057FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public WeeklyGoldCardGiftPackPanel _003C_003E4__this;

			[Token(Token = "0x40057FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6004BC9")]
			[Address(RVA = "0x426EE0C", Offset = "0x426AE0C", VA = "0x426EE0C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004BCA")]
			[Address(RVA = "0x426F324", Offset = "0x426B324", VA = "0x426F324", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000C3C")]
		[CompilerGenerated]
		private struct _003CUpdateInfo_003Ed__13 : IAsyncStateMachine
		{
			[Token(Token = "0x40057FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40057FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40057FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public WeeklyGoldCardGiftPackPanel _003C_003E4__this;

			[Token(Token = "0x4005800")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public object[] args;

			[Token(Token = "0x4005801")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6004BCB")]
			[Address(RVA = "0x426F330", Offset = "0x426B330", VA = "0x426F330", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004BCC")]
			[Address(RVA = "0x427080C", Offset = "0x426C80C", VA = "0x427080C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40057EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private int index;

		[Token(Token = "0x40057EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private List<GoldCardWeeklyGiftPackData> data;

		[Token(Token = "0x40057EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private RewardItemUI[] rewardItemUis;

		[Token(Token = "0x40057ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private GoldCardWeeklyGiftPackToogleBtn[] goldCardWeeklyGiftPackToogleBtn;

		[Token(Token = "0x40057EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Vector2 originalContentPos;

		[Token(Token = "0x40057EF")]
		private const float AnimeDuration = 0.3f;

		[Token(Token = "0x40057F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private bool isAnimating;

		[Token(Token = "0x40057F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x119")]
		private bool showFromGameEnd;

		[Token(Token = "0x40057F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private string _placement;

		[Token(Token = "0x6004BB1")]
		[Address(RVA = "0x426CF18", Offset = "0x4268F18", VA = "0x426CF18", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6004BB2")]
		[Address(RVA = "0x426D2E0", Offset = "0x42692E0", VA = "0x426D2E0", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__10))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6004BB3")]
		[Address(RVA = "0x426D374", Offset = "0x4269374", VA = "0x426D374")]
		[AsyncStateMachine(typeof(_003CPlayShowAnimation_003Ed__11))]
		private void PlayShowAnimation()
		{
		}

		[Token(Token = "0x6004BB4")]
		[Address(RVA = "0x426D400", Offset = "0x4269400", VA = "0x426D400")]
		private Vector2 GetTargetLocalPosition()
		{
			return default;
		}

		[Token(Token = "0x6004BB5")]
		[Address(RVA = "0x426D618", Offset = "0x4269618", VA = "0x426D618", Slot = "9")]
		[AsyncStateMachine(typeof(_003CUpdateInfo_003Ed__13))]
		public override void UpdateInfo(params object[] args)
		{
		}

		[Token(Token = "0x6004BB6")]
		[Address(RVA = "0x426D6B4", Offset = "0x42696B4", VA = "0x426D6B4")]
		private void RefreshGoldCardWeeklyGiftPackPanel(object o)
		{
		}

		[Token(Token = "0x6004BB7")]
		[Address(RVA = "0x426D7A8", Offset = "0x42697A8", VA = "0x426D7A8")]
		private void SetCurrentPackageIndex(int tempIndex)
		{
		}

		[Token(Token = "0x6004BB8")]
		[Address(RVA = "0x426DA74", Offset = "0x4269A74", VA = "0x426DA74", Slot = "17")]
		protected override void OnToggleBtnChangeGiftToogle1ValueChanged(bool arg)
		{
		}

		[Token(Token = "0x6004BB9")]
		[Address(RVA = "0x426DBDC", Offset = "0x4269BDC", VA = "0x426DBDC", Slot = "18")]
		protected override void OnToggleBtnChangeGiftToogle2ValueChanged(bool arg)
		{
		}

		[Token(Token = "0x6004BBA")]
		[Address(RVA = "0x426DD48", Offset = "0x4269D48", VA = "0x426DD48", Slot = "19")]
		protected override void OnToggleBtnChangeGiftToogle3ValueChanged(bool arg)
		{
		}

		[Token(Token = "0x6004BBB")]
		[Address(RVA = "0x426DEB4", Offset = "0x4269EB4", VA = "0x426DEB4", Slot = "16")]
		protected override void OnButtonExtendBtnCloseClicked()
		{
		}

		[Token(Token = "0x6004BBC")]
		[Address(RVA = "0x426DF40", Offset = "0x4269F40", VA = "0x426DF40", Slot = "12")]
		protected override void OnButtonBgClicked()
		{
		}

		[Token(Token = "0x6004BBD")]
		[Address(RVA = "0x426DFCC", Offset = "0x4269FCC", VA = "0x426DFCC", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6004BBE")]
		[Address(RVA = "0x426E058", Offset = "0x426A058", VA = "0x426E058")]
		private void PlayHideAnimation(TweenCallback onComplete)
		{
		}

		[Token(Token = "0x6004BBF")]
		[Address(RVA = "0x426E330", Offset = "0x426A330", VA = "0x426E330")]
		private void ResetPanelState()
		{
		}

		[Token(Token = "0x6004BC0")]
		[Address(RVA = "0x426E578", Offset = "0x426A578", VA = "0x426E578")]
		public WeeklyGoldCardGiftPackPanel()
		{
		}
	}
}
