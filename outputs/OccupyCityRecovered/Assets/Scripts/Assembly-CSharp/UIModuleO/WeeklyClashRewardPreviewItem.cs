using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using Il2CppDummyDll;

namespace UIModuleO
{
	[Token(Token = "0x2000C22")]
	public class WeeklyClashRewardPreviewItem : WeeklyClashRewardPreviewItemComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000C23")]
		[CompilerGenerated]
		private struct _003CSetRankText_003Ed__4 : IAsyncStateMachine
		{
			[Token(Token = "0x400577E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400577F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005780")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public WeeklyClashRewardPreviewItem _003C_003E4__this;

			[Token(Token = "0x4005781")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string path;

			[Token(Token = "0x4005782")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private SeasonRankingRewardConfig _003CtempConfig_003E5__2;

			[Token(Token = "0x4005783")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask<UnityEngine.Sprite[]>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6004B25")]
			[Address(RVA = "0x426526C", Offset = "0x426126C", VA = "0x426526C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004B26")]
			[Address(RVA = "0x4265680", Offset = "0x4261680", VA = "0x4265680", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000C24")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__2 : IAsyncStateMachine
		{
			[Token(Token = "0x4005784")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005785")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005786")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public WeeklyClashRewardPreviewItem _003C_003E4__this;

			[Token(Token = "0x4005787")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6004B27")]
			[Address(RVA = "0x426568C", Offset = "0x426168C", VA = "0x426568C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004B28")]
			[Address(RVA = "0x4265B00", Offset = "0x4261B00", VA = "0x4265B00", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400577C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private SeasonRankingRewardConfig rankingRewardConfig;

		[Token(Token = "0x400577D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool showSeason;

		[Token(Token = "0x6004B20")]
		[Address(RVA = "0x4264C98", Offset = "0x4260C98", VA = "0x4264C98", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__2))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6004B21")]
		[Address(RVA = "0x4264D2C", Offset = "0x4260D2C", VA = "0x4264D2C")]
		private void UpdateRank()
		{
		}

		[Token(Token = "0x6004B22")]
		[Address(RVA = "0x4265124", Offset = "0x4261124", VA = "0x4265124")]
		[AsyncStateMachine(typeof(_003CSetRankText_003Ed__4))]
		private void SetRankText(string path)
		{
		}

		[Token(Token = "0x6004B23")]
		[Address(RVA = "0x42651C4", Offset = "0x42611C4", VA = "0x42651C4")]
		public WeeklyClashRewardPreviewItem()
		{
		}
	}
}
