using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using WG.CollectKit;

namespace UIModuleO
{
	[Token(Token = "0x2000845")]
	public class CollectTweenPanel : CollectTweenPanelComponents
	{
		[Token(Token = "0x2000846")]
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass3_0
		{
			[Token(Token = "0x4003F10")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string resId;

			[Token(Token = "0x6002E98")]
			[Address(RVA = "0x4022448", Offset = "0x401E448", VA = "0x4022448")]
			public _003C_003Ec__DisplayClass3_0()
			{
			}

			[Token(Token = "0x6002E99")]
			[Address(RVA = "0x4022450", Offset = "0x401E450", VA = "0x4022450")]
			internal void _003CShow_003Eb__0()
			{
			}

			[Token(Token = "0x6002E9A")]
			[Address(RVA = "0x40224C0", Offset = "0x401E4C0", VA = "0x40224C0")]
			internal void _003CShow_003Eb__1(int singleValue)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000847")]
		[CompilerGenerated]
		private struct _003CAwake_003Ed__2 : IAsyncStateMachine
		{
			[Token(Token = "0x4003F11")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003F12")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003F13")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public CollectTweenPanel _003C_003E4__this;

			[Token(Token = "0x4003F14")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002E9B")]
			[Address(RVA = "0x40225F0", Offset = "0x401E5F0", VA = "0x40225F0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002E9C")]
			[Address(RVA = "0x4022A34", Offset = "0x401EA34", VA = "0x4022A34", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000848")]
		[CompilerGenerated]
		private struct _003CSetTargetAsync_003Ed__4 : IAsyncStateMachine
		{
			[Token(Token = "0x4003F15")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003F16")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003F17")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public CollectTweenPanel _003C_003E4__this;

			[Token(Token = "0x4003F18")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002E9D")]
			[Address(RVA = "0x4022A40", Offset = "0x401EA40", VA = "0x4022A40", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002E9E")]
			[Address(RVA = "0x4023994", Offset = "0x401F994", VA = "0x4023994", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000849")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__3 : IAsyncStateMachine
		{
			[Token(Token = "0x4003F19")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003F1A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003F1B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public CollectTweenPanel _003C_003E4__this;

			[Token(Token = "0x4003F1C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x4003F1D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private _003C_003Ec__DisplayClass3_0 _003C_003E8__1;

			[Token(Token = "0x4003F1E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 _003CstartPosition_003E5__2;

			[Token(Token = "0x4003F1F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private int _003CcollectValue_003E5__3;

			[Token(Token = "0x4003F20")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002E9F")]
			[Address(RVA = "0x40239A0", Offset = "0x401F9A0", VA = "0x40239A0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002EA0")]
			[Address(RVA = "0x40241C4", Offset = "0x40201C4", VA = "0x40241C4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003F0E")]
		private const int DiceCollectFlyCount = 10;

		[Token(Token = "0x4003F0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Dictionary<string, CollectTweenContent> _collectTweenContents;

		[Token(Token = "0x6002E90")]
		[Address(RVA = "0x4021F3C", Offset = "0x401DF3C", VA = "0x4021F3C", Slot = "4")]
		[AsyncStateMachine(typeof(_003CAwake_003Ed__2))]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6002E91")]
		[Address(RVA = "0x4021FC8", Offset = "0x401DFC8", VA = "0x4021FC8", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__3))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6002E92")]
		[Address(RVA = "0x4022064", Offset = "0x401E064", VA = "0x4022064")]
		[AsyncStateMachine(typeof(_003CSetTargetAsync_003Ed__4))]
		private UniTask SetTargetAsync()
		{
			return default;
		}

		[Token(Token = "0x6002E93")]
		[Address(RVA = "0x40220F0", Offset = "0x401E0F0", VA = "0x40220F0")]
		private void BindBarResourceFlyTargets()
		{
		}

		[Token(Token = "0x6002E94")]
		[Address(RVA = "0x40222AC", Offset = "0x401E2AC", VA = "0x40222AC")]
		private static bool EnsureDiceCollectTweenConfigured(CollectTweenContent diceContent)
		{
			return default;
		}

		[Token(Token = "0x6002E95")]
		[Address(RVA = "0x4022390", Offset = "0x401E390", VA = "0x4022390")]
		public CollectTweenPanel()
		{
		}
	}
}
