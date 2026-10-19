using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace UIModuleO
{
	[Token(Token = "0x2000677")]
	internal static class WorldCupSubPanelLoader
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000678")]
		[CompilerGenerated]
		private struct _003CEnsureAsync_003Ed__0<TView> : IAsyncStateMachine where TView : MonoBehaviour
		{
			[Token(Token = "0x4003464")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003465")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public AsyncUniTaskMethodBuilder<TView> _003C_003Et__builder;

			[Token(Token = "0x4003466")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public WorldCupSubPanelSlot<TView> slot;

			[Token(Token = "0x4003467")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Transform parent;

			[Token(Token = "0x4003468")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string assetPath;

			[Token(Token = "0x4003469")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string loadFailLog;

			[Token(Token = "0x400346A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string instanceName;

			[Token(Token = "0x400346B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Func<GameObject, TView> resolveView;

			[Token(Token = "0x400346C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__1;

			[Token(Token = "0x400346D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__2;

			[Token(Token = "0x6002235")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002236")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000679")]
		[CompilerGenerated]
		private struct _003CHideAsync_003Ed__1 : IAsyncStateMachine
		{
			[Token(Token = "0x400346E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400346F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003470")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ScaleTweenPanelViewBase panel;

			[Token(Token = "0x4003471")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002237")]
			[Address(RVA = "0x3F32184", Offset = "0x3F2E184", VA = "0x3F32184", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002238")]
			[Address(RVA = "0x3F325D8", Offset = "0x3F2E5D8", VA = "0x3F325D8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x6002232")]
		[AsyncStateMachine(typeof(_003CEnsureAsync_003Ed__0<>))]
		internal static UniTask<TView> EnsureAsync<TView>(WorldCupSubPanelSlot<TView> slot, Transform parent, string assetPath, string instanceName, string loadFailLog, Func<GameObject, TView> resolveView) where TView : MonoBehaviour
		{
			return default;
		}

		[Token(Token = "0x6002233")]
		[Address(RVA = "0x3F2ED60", Offset = "0x3F2AD60", VA = "0x3F2ED60")]
		[AsyncStateMachine(typeof(_003CHideAsync_003Ed__1))]
		internal static UniTask HideAsync(ScaleTweenPanelViewBase panel)
		{
			return default;
		}

		[Token(Token = "0x6002234")]
		[Address(RVA = "0x3F2ECB4", Offset = "0x3F2ACB4", VA = "0x3F2ECB4")]
		internal static void SetRedDotActive(GameObject redDot, bool visible)
		{
		}
	}
}
