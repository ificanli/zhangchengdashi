using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using Il2CppDummyDll;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000BFF")]
	public class WeeklyCardDailyTaskUIItem : WeeklyCardDailyTaskUIItemComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000C00")]
		[CompilerGenerated]
		private struct _003COnButtonExtendBtnGoToClicked_003Ed__5 : IAsyncStateMachine
		{
			[Token(Token = "0x40056DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40056DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40056DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public WeeklyCardDailyTaskUIItem _003C_003E4__this;

			[Token(Token = "0x6004A56")]
			[Address(RVA = "0x4258C24", Offset = "0x4254C24", VA = "0x4258C24", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004A57")]
			[Address(RVA = "0x4258EBC", Offset = "0x4254EBC", VA = "0x4258EBC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000C01")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__1 : IAsyncStateMachine
		{
			[Token(Token = "0x40056DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40056E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40056E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public WeeklyCardDailyTaskUIItem _003C_003E4__this;

			[Token(Token = "0x40056E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6004A58")]
			[Address(RVA = "0x4258EC8", Offset = "0x4254EC8", VA = "0x4258EC8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004A59")]
			[Address(RVA = "0x42591B0", Offset = "0x42551B0", VA = "0x42591B0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000C02")]
		[CompilerGenerated]
		private struct _003CUpdateInfo_003Ed__2 : IAsyncStateMachine
		{
			[Token(Token = "0x40056E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40056E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40056E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public WeeklyCardDailyTaskUIItem _003C_003E4__this;

			[Token(Token = "0x40056E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public object[] args;

			[Token(Token = "0x40056E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Image _003C_003E7__wrap1;

			[Token(Token = "0x40056E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask<UnityEngine.Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6004A5A")]
			[Address(RVA = "0x42591BC", Offset = "0x42551BC", VA = "0x42591BC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004A5B")]
			[Address(RVA = "0x425A84C", Offset = "0x425684C", VA = "0x425A84C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40056DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private GlobalWeeklyCardDailyTaskInfo info;

		[Token(Token = "0x6004A4D")]
		[Address(RVA = "0x42589D8", Offset = "0x42549D8", VA = "0x42589D8", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__1))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6004A4E")]
		[Address(RVA = "0x4258A6C", Offset = "0x4254A6C", VA = "0x4258A6C", Slot = "9")]
		[AsyncStateMachine(typeof(_003CUpdateInfo_003Ed__2))]
		public override void UpdateInfo(params object[] args)
		{
		}

		[Token(Token = "0x6004A4F")]
		[Address(RVA = "0x4258B0C", Offset = "0x4254B0C", VA = "0x4258B0C", Slot = "12")]
		protected override void OnButtonExtendBtnClaimClicked()
		{
		}

		[Token(Token = "0x6004A50")]
		[Address(RVA = "0x4255458", Offset = "0x4251458", VA = "0x4255458")]
		public void KillTween()
		{
		}

		[Token(Token = "0x6004A51")]
		[Address(RVA = "0x4258B78", Offset = "0x4254B78", VA = "0x4258B78", Slot = "13")]
		[AsyncStateMachine(typeof(_003COnButtonExtendBtnGoToClicked_003Ed__5))]
		protected override void OnButtonExtendBtnGoToClicked()
		{
		}

		[Token(Token = "0x6004A52")]
		[Address(RVA = "0x4258C04", Offset = "0x4254C04", VA = "0x4258C04")]
		public WeeklyCardDailyTaskUIItem()
		{
		}
	}
}
