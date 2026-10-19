using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;

namespace UIModuleO
{
	[Token(Token = "0x2000C2B")]
	public class WeeklyClashRoleRankingItem : WeeklyClashRoleRankingItemComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000C2C")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__2 : IAsyncStateMachine
		{
			[Token(Token = "0x40057AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40057AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40057B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public WeeklyClashRoleRankingItem _003C_003E4__this;

			[Token(Token = "0x40057B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6004B61")]
			[Address(RVA = "0x4268430", Offset = "0x4264430", VA = "0x4268430", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004B62")]
			[Address(RVA = "0x4268B10", Offset = "0x4264B10", VA = "0x4268B10", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40057AC")]
		public const string PlayerNameColor = "#FFBA4E";

		[Token(Token = "0x40057AD")]
		public const string NonPlayerNameColor = "#FFFFFF";

		[Token(Token = "0x6004B5E")]
		[Address(RVA = "0x42682F4", Offset = "0x42642F4", VA = "0x42682F4", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__2))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6004B5F")]
		[Address(RVA = "0x4268388", Offset = "0x4264388", VA = "0x4268388")]
		public WeeklyClashRoleRankingItem()
		{
		}
	}
}
