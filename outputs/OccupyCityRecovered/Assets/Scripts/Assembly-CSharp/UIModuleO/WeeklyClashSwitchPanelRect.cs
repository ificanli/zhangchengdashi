using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;

namespace UIModuleO
{
	[Token(Token = "0x2000C34")]
	public class WeeklyClashSwitchPanelRect : WeeklyClashSwitchPanelRectComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000C35")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__2 : IAsyncStateMachine
		{
			[Token(Token = "0x40057E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40057E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40057E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public WeeklyClashSwitchPanelRect _003C_003E4__this;

			[Token(Token = "0x40057E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6004BA3")]
			[Address(RVA = "0x426C69C", Offset = "0x426869C", VA = "0x426C69C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004BA4")]
			[Address(RVA = "0x426CA00", Offset = "0x4268A00", VA = "0x426CA00", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40057DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Action<int> onToggleChange;

		[Token(Token = "0x40057DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int currentIndex;

		[Token(Token = "0x6004B9E")]
		[Address(RVA = "0x426C348", Offset = "0x4268348", VA = "0x426C348", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__2))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6004B9F")]
		[Address(RVA = "0x426C3DC", Offset = "0x42683DC", VA = "0x426C3DC", Slot = "12")]
		protected override void OnToggleWeeklyToggleValueChanged(bool arg)
		{
		}

		[Token(Token = "0x6004BA0")]
		[Address(RVA = "0x426C4E0", Offset = "0x42684E0", VA = "0x426C4E0", Slot = "13")]
		protected override void OnToggleSeasonToggleValueChanged(bool arg)
		{
		}

		[Token(Token = "0x6004BA1")]
		[Address(RVA = "0x426C5EC", Offset = "0x42685EC", VA = "0x426C5EC")]
		public WeeklyClashSwitchPanelRect()
		{
		}
	}
}
