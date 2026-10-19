using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using ToolModule;

namespace GameModule
{
	[Token(Token = "0x2000447")]
	public class GoldCardAnimationPanelManager : ManagerBase<GoldCardAnimationPanelManager>
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000448")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__2 : IAsyncStateMachine
		{
			[Token(Token = "0x4002A24")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002A25")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002A26")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GoldCardAnimationPanelManager _003C_003E4__this;

			[Token(Token = "0x60014BF")]
			[Address(RVA = "0x3E061CC", Offset = "0x3E021CC", VA = "0x3E061CC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60014C0")]
			[Address(RVA = "0x3E06524", Offset = "0x3E02524", VA = "0x3E06524", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4002A22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Queue<GoldCardAniConfig> _configs;

		[Token(Token = "0x4002A23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool isPanelAniIng;

		[Token(Token = "0x60014B9")]
		[Address(RVA = "0x3E05DF4", Offset = "0x3E01DF4", VA = "0x3E05DF4", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__2))]
		public override UniTask Init()
		{
			return default;
		}

		[Token(Token = "0x60014BA")]
		[Address(RVA = "0x3E05E78", Offset = "0x3E01E78", VA = "0x3E05E78")]
		private void Update()
		{
		}

		[Token(Token = "0x60014BB")]
		[Address(RVA = "0x3E06060", Offset = "0x3E02060", VA = "0x3E06060")]
		public void AddQuene(GoldCardAniConfig config)
		{
		}

		[Token(Token = "0x60014BC")]
		[Address(RVA = "0x3E060B8", Offset = "0x3E020B8", VA = "0x3E060B8")]
		private void GoldCardPanelBoolChange(object o)
		{
		}

		[Token(Token = "0x60014BD")]
		[Address(RVA = "0x3E06130", Offset = "0x3E02130", VA = "0x3E06130")]
		private void OnGameOver(object o)
		{
		}

		[Token(Token = "0x60014BE")]
		[Address(RVA = "0x3E06184", Offset = "0x3E02184", VA = "0x3E06184")]
		public GoldCardAnimationPanelManager()
		{
		}
	}
}
