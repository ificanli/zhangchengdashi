using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using GameModule;
using Il2CppDummyDll;

namespace UIModuleO
{
	[Token(Token = "0x2000C09")]
	public class WeeklyClashPanel : WeeklyClashPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000C0A")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__2 : IAsyncStateMachine
		{
			[Token(Token = "0x400570C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400570D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400570E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public WeeklyClashPanel _003C_003E4__this;

			[Token(Token = "0x400570F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6004A95")]
			[Address(RVA = "0x425E318", Offset = "0x425A318", VA = "0x425E318", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004A96")]
			[Address(RVA = "0x425E92C", Offset = "0x425A92C", VA = "0x425E92C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400570B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private SeasonManager.WeeklyClashStatus weeklyClashStatus;

		[Token(Token = "0x6004A8C")]
		[Address(RVA = "0x425CDF0", Offset = "0x4258DF0", VA = "0x425CDF0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6004A8D")]
		[Address(RVA = "0x425CEE8", Offset = "0x4258EE8", VA = "0x425CEE8", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__2))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6004A8E")]
		[Address(RVA = "0x425CF7C", Offset = "0x4258F7C", VA = "0x425CF7C")]
		private void SetStatus(SeasonManager.WeeklyClashStatus status)
		{
		}

		[Token(Token = "0x6004A8F")]
		[Address(RVA = "0x425DC14", Offset = "0x4259C14", VA = "0x425DC14")]
		private void Update()
		{
		}

		[Token(Token = "0x6004A90")]
		[Address(RVA = "0x425E070", Offset = "0x425A070", VA = "0x425E070", Slot = "13")]
		protected override void OnButtonExtendCloseBtnClicked()
		{
		}

		[Token(Token = "0x6004A91")]
		[Address(RVA = "0x425E0FC", Offset = "0x425A0FC", VA = "0x425E0FC", Slot = "14")]
		protected override void OnButtonExtendRewardPreviewBtnClicked()
		{
		}

		[Token(Token = "0x6004A92")]
		[Address(RVA = "0x425E240", Offset = "0x425A240", VA = "0x425E240")]
		public WeeklyClashPanel()
		{
		}
	}
}
