using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;

namespace UIModuleO
{
	[Token(Token = "0x2000ADB")]
	public class RewardItemUIScrollView : RewardItemUIScrollViewComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000ADC")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__1 : IAsyncStateMachine
		{
			[Token(Token = "0x4004F96")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004F97")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004F98")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public RewardItemUIScrollView _003C_003E4__this;

			[Token(Token = "0x4004F99")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6004199")]
			[Address(RVA = "0x41BE32C", Offset = "0x41BA32C", VA = "0x41BE32C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600419A")]
			[Address(RVA = "0x41BE558", Offset = "0x41BA558", VA = "0x41BE558", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004F95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private readonly List<RewardItemUI> _rewardItemCache;

		[Token(Token = "0x6004195")]
		[Address(RVA = "0x41BDB68", Offset = "0x41B9B68", VA = "0x41BDB68", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__1))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6004196")]
		[Address(RVA = "0x41BDBFC", Offset = "0x41B9BFC", VA = "0x41BDBFC")]
		private void UpdateRewardItemUI(string rewardStringByRank)
		{
		}

		[Token(Token = "0x6004197")]
		[Address(RVA = "0x41BE210", Offset = "0x41BA210", VA = "0x41BE210")]
		public RewardItemUIScrollView()
		{
		}
	}
}
