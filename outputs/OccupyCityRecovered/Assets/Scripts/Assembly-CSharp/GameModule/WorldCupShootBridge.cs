using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x200060B")]
	public class WorldCupShootBridge
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200060C")]
		[CompilerGenerated]
		private struct _003CEnsurePreloadedAsync_003Ed__5 : IAsyncStateMachine
		{
			[Token(Token = "0x4003249")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400324A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400324B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public WorldCupShootBridge _003C_003E4__this;

			[Token(Token = "0x400324C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600204F")]
			[Address(RVA = "0x3F0EB50", Offset = "0x3F0AB50", VA = "0x3F0EB50", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002050")]
			[Address(RVA = "0x3F0F1AC", Offset = "0x3F0B1AC", VA = "0x3F0F1AC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200060D")]
		[CompilerGenerated]
		private struct _003CShootOnceAsync_003Ed__8 : IAsyncStateMachine
		{
			[Token(Token = "0x400324D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400324E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<FootballShootResult> _003C_003Et__builder;

			[Token(Token = "0x400324F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public WorldCupShootBridge _003C_003E4__this;

			[Token(Token = "0x4003250")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask<FootballShootResult>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002051")]
			[Address(RVA = "0x3F0F1B8", Offset = "0x3F0B1B8", VA = "0x3F0F1B8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002052")]
			[Address(RVA = "0x3F0F6CC", Offset = "0x3F0B6CC", VA = "0x3F0F6CC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Vector3 StageInitialPosition;

		[Token(Token = "0x4003247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private WorldCupShootStageView _stageInstance;

		[Token(Token = "0x4003248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool _initialized;

		[Token(Token = "0x170001C2")]
		public bool IsInitialized
		{
			[Token(Token = "0x6002045")]
			[Address(RVA = "0x3F0E288", Offset = "0x3F0A288", VA = "0x3F0E288")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6002046")]
		[Address(RVA = "0x3F0E300", Offset = "0x3F0A300", VA = "0x3F0E300")]
		[AsyncStateMachine(typeof(_003CEnsurePreloadedAsync_003Ed__5))]
		public UniTask EnsurePreloadedAsync()
		{
			return default;
		}

		[Token(Token = "0x6002047")]
		[Address(RVA = "0x3F0E390", Offset = "0x3F0A390", VA = "0x3F0E390")]
		public void ShowGameplay()
		{
		}

		[Token(Token = "0x6002048")]
		[Address(RVA = "0x3F0E61C", Offset = "0x3F0A61C", VA = "0x3F0E61C")]
		public void HideGameplay()
		{
		}

		[Token(Token = "0x6002049")]
		[Address(RVA = "0x3F0E63C", Offset = "0x3F0A63C", VA = "0x3F0E63C")]
		[AsyncStateMachine(typeof(_003CShootOnceAsync_003Ed__8))]
		public UniTask<FootballShootResult> ShootOnceAsync()
		{
			return default;
		}

		[Token(Token = "0x600204A")]
		[Address(RVA = "0x3F0E710", Offset = "0x3F0A710", VA = "0x3F0E710")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600204B")]
		[Address(RVA = "0x3F0E62C", Offset = "0x3F0A62C", VA = "0x3F0E62C")]
		private void ApplyPreGameplayState()
		{
		}

		[Token(Token = "0x600204C")]
		[Address(RVA = "0x3F0E41C", Offset = "0x3F0A41C", VA = "0x3F0E41C")]
		private void ShowStageOnly()
		{
		}

		[Token(Token = "0x600204D")]
		[Address(RVA = "0x3F0EAC4", Offset = "0x3F0AAC4", VA = "0x3F0EAC4")]
		public WorldCupShootBridge()
		{
		}
	}
}
