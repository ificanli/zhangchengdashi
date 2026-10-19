using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using UIFramework;
using UnityEngine;

namespace ToolModule
{
	[Token(Token = "0x20001AE")]
	public class CollectTweenManager : ManagerBase<CollectTweenManager>
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20001B1")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__7 : IAsyncStateMachine
		{
			[Token(Token = "0x4001AEB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001AEC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001AED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public CollectTweenManager _003C_003E4__this;

			[Token(Token = "0x4001AEE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x4001AEF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<UIPanel>.Awaiter _003C_003Eu__2;

			[Token(Token = "0x4001AF0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__3;

			[Token(Token = "0x60006F2")]
			[Address(RVA = "0x407A958", Offset = "0x4076958", VA = "0x407A958", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60006F3")]
			[Address(RVA = "0x407B4C4", Offset = "0x40774C4", VA = "0x407B4C4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20001B2")]
		[CompilerGenerated]
		private struct _003CPlayInBattleWoodCollectTweenAsync_003Ed__16 : IAsyncStateMachine
		{
			[Token(Token = "0x4001AF1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001AF2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001AF3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CollectTweenManager _003C_003E4__this;

			[Token(Token = "0x4001AF4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool isEnemy;

			[Token(Token = "0x4001AF5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 coinWorldPosition;

			[Token(Token = "0x4001AF6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60006F4")]
			[Address(RVA = "0x407B4D0", Offset = "0x40774D0", VA = "0x407B4D0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60006F5")]
			[Address(RVA = "0x407B974", Offset = "0x4077974", VA = "0x407B974", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20001B3")]
		[CompilerGenerated]
		private struct _003CPrewarmBattleProducts_003Ed__8 : IAsyncStateMachine
		{
			[Token(Token = "0x4001AF7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001AF8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001AF9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public CollectTweenManager _003C_003E4__this;

			[Token(Token = "0x4001AFA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int count;

			[Token(Token = "0x4001AFB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action<string, int, double> onItemPrewarmed;

			[Token(Token = "0x4001AFC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private long _003CstartTicks_003E5__2;

			[Token(Token = "0x4001AFD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60006F6")]
			[Address(RVA = "0x407B980", Offset = "0x4077980", VA = "0x407B980", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60006F7")]
			[Address(RVA = "0x407BE9C", Offset = "0x4077E9C", VA = "0x407BE9C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4001AE0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private UIPanel _collectTweenPanel;

		[Token(Token = "0x4001AE1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private RectTransform _tempRect;

		[Token(Token = "0x4001AE2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private RectTransform _collectTweenPanelRect;

		[Token(Token = "0x4001AE3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool _initStarted;

		[Token(Token = "0x4001AE4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		private bool _isInitialized;

		[Token(Token = "0x4001AE5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
		private bool _hasSpawnListenerRegistered;

		[Token(Token = "0x4001AE6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public GameObject prefab;

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x3F83B40", Offset = "0x3F7FB40", VA = "0x3F83B40", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__7))]
		public override UniTask Init()
		{
			return default;
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x3F83BDC", Offset = "0x3F7FBDC", VA = "0x3F83BDC")]
		[AsyncStateMachine(typeof(_003CPrewarmBattleProducts_003Ed__8))]
		public UniTask PrewarmBattleProducts(int count, [Optional] Action<string, int, double> onItemPrewarmed)
		{
			return default;
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x3F83C90", Offset = "0x3F7FC90", VA = "0x3F83C90")]
		private static double GetElapsedMilliseconds(long startTicks)
		{
			return default;
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x3F83D10", Offset = "0x3F7FD10", VA = "0x3F83D10")]
		public void ShowCollectTween(string collectName, Vector3 startUIWorldPosition, int collectCount)
		{
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x3F83F3C", Offset = "0x3F7FF3C", VA = "0x3F83F3C")]
		public void ShowCollectTween(string collectName, Vector2 startUIAnchorPosition, int collectCount)
		{
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x3F841F8", Offset = "0x3F801F8", VA = "0x3F841F8")]
		public void ShowCollectTween3DWorldPos(string collectName, Vector3 start3DWorldPos, int collectCount, Action onComplete)
		{
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x3F843EC", Offset = "0x3F803EC", VA = "0x3F843EC")]
		public void SpawnCoins(object obj)
		{
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x3F83E9C", Offset = "0x3F7FE9C", VA = "0x3F83E9C")]
		private bool CanShowCollectTween()
		{
			return default;
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x3F840E4", Offset = "0x3F800E4", VA = "0x3F840E4")]
		private bool EnsureTempRect()
		{
			return default;
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x3F84A74", Offset = "0x3F80A74", VA = "0x3F84A74")]
		[AsyncStateMachine(typeof(_003CPlayInBattleWoodCollectTweenAsync_003Ed__16))]
		private UniTaskVoid PlayInBattleWoodCollectTweenAsync(bool isEnemy, Vector3 coinWorldPosition)
		{
			return default;
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x3F84B28", Offset = "0x3F80B28", VA = "0x3F84B28")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x3F84CA4", Offset = "0x3F80CA4", VA = "0x3F84CA4")]
		public CollectTweenManager()
		{
		}
	}
}
