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
	[Token(Token = "0x20006BF")]
	public class ArenaProgressPanel : ArenaProgressPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20006C0")]
		[CompilerGenerated]
		private struct _003COnButtonExtendBtnBackClicked_003Ed__15 : IAsyncStateMachine
		{
			[Token(Token = "0x4003615")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003616")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003617")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ArenaProgressPanel _003C_003E4__this;

			[Token(Token = "0x6002409")]
			[Address(RVA = "0x3F53F4C", Offset = "0x3F4FF4C", VA = "0x3F53F4C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600240A")]
			[Address(RVA = "0x3F54120", Offset = "0x3F50120", VA = "0x3F54120", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20006C1")]
		[CompilerGenerated]
		private struct _003CScrollToItem_003Ed__10 : IAsyncStateMachine
		{
			[Token(Token = "0x4003618")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003619")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400361A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float offset;

			[Token(Token = "0x400361B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ArenaProgressPanel _003C_003E4__this;

			[Token(Token = "0x400361C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int index;

			[Token(Token = "0x400361D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float duration;

			[Token(Token = "0x400361E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600240B")]
			[Address(RVA = "0x3F5412C", Offset = "0x3F5012C", VA = "0x3F5412C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600240C")]
			[Address(RVA = "0x3F547D0", Offset = "0x3F507D0", VA = "0x3F547D0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20006C2")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__6 : IAsyncStateMachine
		{
			[Token(Token = "0x400361F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003620")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003621")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ArenaProgressPanel _003C_003E4__this;

			[Token(Token = "0x4003622")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x600240D")]
			[Address(RVA = "0x3F547DC", Offset = "0x3F507DC", VA = "0x3F547DC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600240E")]
			[Address(RVA = "0x3F54AD0", Offset = "0x3F50AD0", VA = "0x3F54AD0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003610")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool hadInitLoopView;

		[Token(Token = "0x4003611")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private string preName;

		[Token(Token = "0x4003612")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private List<UserArenaData> arenaDataList;

		[Token(Token = "0x4003613")]
		private const int arenaProgressLineHeight = 1704;

		[Token(Token = "0x4003614")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private bool updateEd;

		[Token(Token = "0x60023FB")]
		[Address(RVA = "0x3F52F1C", Offset = "0x3F4EF1C", VA = "0x3F52F1C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60023FC")]
		[Address(RVA = "0x3F53120", Offset = "0x3F4F120", VA = "0x3F53120", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__6))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60023FD")]
		[Address(RVA = "0x3F531B4", Offset = "0x3F4F1B4", VA = "0x3F531B4", Slot = "9")]
		public override void UpdateInfo(params object[] args)
		{
		}

		[Token(Token = "0x60023FE")]
		[Address(RVA = "0x3F533F8", Offset = "0x3F4F3F8", VA = "0x3F533F8")]
		private int GetScrollIndex()
		{
			return default;
		}

		[Token(Token = "0x60023FF")]
		[Address(RVA = "0x3F534AC", Offset = "0x3F4F4AC", VA = "0x3F534AC")]
		private float GetScrollOffset()
		{
			return default;
		}

		[Token(Token = "0x6002400")]
		[Address(RVA = "0x3F535F0", Offset = "0x3F4F5F0", VA = "0x3F535F0")]
		[AsyncStateMachine(typeof(_003CScrollToItem_003Ed__10))]
		private UniTask ScrollToItem(int index, float offset, float duration)
		{
			return default;
		}

		[Token(Token = "0x6002401")]
		[Address(RVA = "0x3F53388", Offset = "0x3F4F388", VA = "0x3F53388")]
		private void ScrollRefreshState(object o)
		{
		}

		[Token(Token = "0x6002402")]
		[Address(RVA = "0x3F5376C", Offset = "0x3F4F76C", VA = "0x3F5376C")]
		private LoopListViewItem2 OnGetItemByIndex(LoopListView2 listView, int index)
		{
			return null;
		}

		[Token(Token = "0x6002403")]
		[Address(RVA = "0x3F53A24", Offset = "0x3F4FA24", VA = "0x3F53A24")]
		public void SetScrollToBotPosition()
		{
		}

		[Token(Token = "0x6002404")]
		[Address(RVA = "0x3F53C98", Offset = "0x3F4FC98", VA = "0x3F53C98", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6002405")]
		[Address(RVA = "0x3F53DA8", Offset = "0x3F4FDA8", VA = "0x3F53DA8", Slot = "13")]
		[AsyncStateMachine(typeof(_003COnButtonExtendBtnBackClicked_003Ed__15))]
		protected override void OnButtonExtendBtnBackClicked()
		{
		}

		[Token(Token = "0x6002406")]
		[Address(RVA = "0x3F53E34", Offset = "0x3F4FE34", VA = "0x3F53E34")]
		public ArenaProgressPanel()
		{
		}
	}
}
