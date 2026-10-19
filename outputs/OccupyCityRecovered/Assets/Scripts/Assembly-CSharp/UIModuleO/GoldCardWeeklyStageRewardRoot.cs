using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;

namespace UIModuleO
{
	[Token(Token = "0x2000909")]
	public class GoldCardWeeklyStageRewardRoot : GoldCardWeeklyStageRewardRootComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200090A")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__3 : IAsyncStateMachine
		{
			[Token(Token = "0x4004412")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004413")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004414")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GoldCardWeeklyStageRewardRoot _003C_003E4__this;

			[Token(Token = "0x4004415")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x600341F")]
			[Address(RVA = "0x40A5598", Offset = "0x40A1598", VA = "0x40A5598", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003420")]
			[Address(RVA = "0x40A5778", Offset = "0x40A1778", VA = "0x40A5778", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private RewardItemUI[] rewardItemUI;

		[Token(Token = "0x4004411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Sequence sequence;

		[Token(Token = "0x6003419")]
		[Address(RVA = "0x40A4B00", Offset = "0x40A0B00", VA = "0x40A4B00", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600341A")]
		[Address(RVA = "0x40A4C14", Offset = "0x40A0C14", VA = "0x40A4C14", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__3))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x600341B")]
		[Address(RVA = "0x40A4CA8", Offset = "0x40A0CA8", VA = "0x40A4CA8", Slot = "9")]
		public override void UpdateInfo(params object[] args)
		{
		}

		[Token(Token = "0x600341C")]
		[Address(RVA = "0x40A5460", Offset = "0x40A1460", VA = "0x40A5460")]
		public void KillTween()
		{
		}

		[Token(Token = "0x600341D")]
		[Address(RVA = "0x40A54F0", Offset = "0x40A14F0", VA = "0x40A54F0")]
		public GoldCardWeeklyStageRewardRoot()
		{
		}
	}
}
