using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using QuickTutor.Demo;

namespace GameModule
{
	[Token(Token = "0x20005A6")]
	public class GiftPackageManager : ManagerBase<GiftPackageManager>
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20005A7")]
		[CompilerGenerated]
		private struct _003CShowNextGift_003Ed__14 : IAsyncStateMachine
		{
			[Token(Token = "0x40030AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40030AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40030AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GiftPackageManager _003C_003E4__this;

			[Token(Token = "0x40030AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private (string panelName, Func<UniTask> showTask) _003Cgift_003E5__2;

			[Token(Token = "0x40030B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int _003Cpriority_003E5__3;

			[Token(Token = "0x40030B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private bool _003CisShowTaskTimeout_003E5__4;

			[Token(Token = "0x40030B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask<bool>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6001D77")]
			[Address(RVA = "0x3EDEBC0", Offset = "0x3EDABC0", VA = "0x3EDEBC0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001D78")]
			[Address(RVA = "0x3EDF48C", Offset = "0x3EDB48C", VA = "0x3EDF48C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20005A8")]
		[CompilerGenerated]
		private struct _003CTryShowNextGift_003Ed__13 : IAsyncStateMachine
		{
			[Token(Token = "0x40030B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40030B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40030B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GiftPackageManager _003C_003E4__this;

			[Token(Token = "0x40030B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6001D79")]
			[Address(RVA = "0x3EDF498", Offset = "0x3EDB498", VA = "0x3EDF498", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001D7A")]
			[Address(RVA = "0x3EDF7B4", Offset = "0x3EDB7B4", VA = "0x3EDF7B4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40030A7")]
		private const int GiftShowTaskTimeoutSeconds = 3;

		[Token(Token = "0x40030A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool initComplete;

		[Token(Token = "0x40030A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private SortedList<int, (string, Func<UniTask>)> giftQueue;

		[Token(Token = "0x40030AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool isShowingGift;

		[Token(Token = "0x40030AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool deferGiftDisplayCompleteAfterShowTask;

		[Token(Token = "0x1700017D")]
		public bool IsShowingGift
		{
			[Token(Token = "0x6001D6A")]
			[Address(RVA = "0x3EDE624", Offset = "0x3EDA624", VA = "0x3EDE624")]
			get
			{
				return isShowingGift;
			}
		}

		[Token(Token = "0x6001D6B")]
		[Address(RVA = "0x3EDE62C", Offset = "0x3EDA62C", VA = "0x3EDE62C")]
		public void DeferGiftDisplayCompleteAfterCurrentShowTask()
		{
		}

		[Token(Token = "0x6001D6C")]
		[Address(RVA = "0x3EDE638", Offset = "0x3EDA638", VA = "0x3EDE638", Slot = "4")]
		public override void Init()
		{
		}

		[Token(Token = "0x6001D6D")]
		[Address(RVA = "0x3EDE810", Offset = "0x3EDA810", VA = "0x3EDE810")]
		public void AddGiftPackage(string panelName, int priority, Func<UniTask> showTask)
		{
		}

		[Token(Token = "0x6001D6E")]
		[Address(RVA = "0x3EDDD28", Offset = "0x3ED9D28", VA = "0x3EDDD28")]
		public void AddGiftPackageNotPlay(string panelName, int priority, Func<UniTask> showTask)
		{
		}

		[Token(Token = "0x6001D6F")]
		[Address(RVA = "0x3EDE8E4", Offset = "0x3EDA8E4", VA = "0x3EDE8E4")]
		public void Play()
		{
		}

		[Token(Token = "0x6001D70")]
		[Address(RVA = "0x3EDE904", Offset = "0x3EDA904", VA = "0x3EDE904")]
		public void CleanQueue()
		{
		}

		[Token(Token = "0x6001D71")]
		[Address(RVA = "0x3EDE798", Offset = "0x3EDA798", VA = "0x3EDE798")]
		[AsyncStateMachine(typeof(_003CTryShowNextGift_003Ed__13))]
		private UniTaskVoid TryShowNextGift()
		{
			return default;
		}

		[Token(Token = "0x6001D72")]
		[Address(RVA = "0x3EDE954", Offset = "0x3EDA954", VA = "0x3EDE954")]
		[AsyncStateMachine(typeof(_003CShowNextGift_003Ed__14))]
		private UniTask ShowNextGift()
		{
			return default;
		}

		[Token(Token = "0x6001D73")]
		[Address(RVA = "0x3EDBCF4", Offset = "0x3ED7CF4", VA = "0x3EDBCF4")]
		public void GiftDisplayComplete()
		{
		}

		[Token(Token = "0x6001D74")]
		[Address(RVA = "0x3EDE9E4", Offset = "0x3EDA9E4", VA = "0x3EDE9E4")]
		public GiftPackageManager()
		{
		}
	}
}
