using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using Il2CppDummyDll;
using UnityEngine;
using ljzs_lt;

namespace UIModuleO
{
	[Token(Token = "0x20006E6")]
	public class ArtifactUseAnimPanel : ArtifactUseAnimPanelComponents
	{
		[Token(Token = "0x20006E7")]
		private sealed class PropAnimPlayData
		{
			[StructLayout((LayoutKind)3)]
			[Token(Token = "0x20006E8")]
			[CompilerGenerated]
			private struct _003CLoadIconResourceInternalAsync_003Ed__35 : IAsyncStateMachine
			{
				[Token(Token = "0x400372F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public int _003C_003E1__state;

				[Token(Token = "0x4003730")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public AsyncUniTaskMethodBuilder _003C_003Et__builder;

				[Token(Token = "0x4003731")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public CancellationToken cancellationToken;

				[Token(Token = "0x4003732")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public PropAnimPlayData _003C_003E4__this;

				[Token(Token = "0x4003733")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private UniTask<Sprite>.Awaiter _003C_003Eu__1;

				[Token(Token = "0x6002569")]
				[Address(RVA = "0x3F69E2C", Offset = "0x3F65E2C", VA = "0x3F69E2C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
				{
				}

				[Token(Token = "0x600256A")]
				[Address(RVA = "0x3F6A3C4", Offset = "0x3F663C4", VA = "0x3F6A3C4", Slot = "5")]
				[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Token(Token = "0x20006E9")]
			[CompilerGenerated]
			private struct _003CLoadNameResourceInternalAsync_003Ed__34 : IAsyncStateMachine
			{
				[Token(Token = "0x4003734")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public int _003C_003E1__state;

				[Token(Token = "0x4003735")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public AsyncUniTaskMethodBuilder _003C_003Et__builder;

				[Token(Token = "0x4003736")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public CancellationToken cancellationToken;

				[Token(Token = "0x4003737")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public PropAnimPlayData _003C_003E4__this;

				[Token(Token = "0x4003738")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private UniTask<Sprite>.Awaiter _003C_003Eu__1;

				[Token(Token = "0x600256B")]
				[Address(RVA = "0x3F6A3D0", Offset = "0x3F663D0", VA = "0x3F6A3D0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
				{
				}

				[Token(Token = "0x600256C")]
				[Address(RVA = "0x3F6A968", Offset = "0x3F66968", VA = "0x3F6A968", Slot = "5")]
				[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Token(Token = "0x20006EA")]
			[CompilerGenerated]
			private struct _003CLoadRareBgResourceInternalAsync_003Ed__33 : IAsyncStateMachine
			{
				[Token(Token = "0x4003739")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public int _003C_003E1__state;

				[Token(Token = "0x400373A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public AsyncUniTaskMethodBuilder _003C_003Et__builder;

				[Token(Token = "0x400373B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public CancellationToken cancellationToken;

				[Token(Token = "0x400373C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public PropAnimPlayData _003C_003E4__this;

				[Token(Token = "0x400373D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private string _003CassetPath_003E5__2;

				[Token(Token = "0x400373E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				private UniTask<Sprite>.Awaiter _003C_003Eu__1;

				[Token(Token = "0x600256D")]
				[Address(RVA = "0x3F6A974", Offset = "0x3F66974", VA = "0x3F6A974", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
				{
				}

				[Token(Token = "0x600256E")]
				[Address(RVA = "0x3F6AEC4", Offset = "0x3F66EC4", VA = "0x3F6AEC4", Slot = "5")]
				[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Token(Token = "0x20006EB")]
			[CompilerGenerated]
			private struct _003CLoadResourceAsync_003Ed__32 : IAsyncStateMachine
			{
				[Token(Token = "0x400373F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public int _003C_003E1__state;

				[Token(Token = "0x4003740")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

				[Token(Token = "0x4003741")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public CancellationToken cancellationToken;

				[Token(Token = "0x4003742")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public Func<CancellationToken, UniTask> loadInternal;

				[Token(Token = "0x4003743")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public PropAnimPlayData _003C_003E4__this;

				[Token(Token = "0x4003744")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private UniTask.Awaiter _003C_003Eu__1;

				[Token(Token = "0x600256F")]
				[Address(RVA = "0x3F6AED0", Offset = "0x3F66ED0", VA = "0x3F6AED0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
				{
				}

				[Token(Token = "0x6002570")]
				[Address(RVA = "0x3F6B2EC", Offset = "0x3F672EC", VA = "0x3F6B2EC", Slot = "5")]
				[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Token(Token = "0x4003722")]
			private const int ResourceCount = 3;

			[Token(Token = "0x4003723")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly object _syncRoot;

			[Token(Token = "0x4003724")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private CompareShenqiInfoConfig _compareShenqiInfo;

			[Token(Token = "0x4003725")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private GlobalPropInfo _globalPropInfo;

			[Token(Token = "0x4003726")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[CompilerGenerated]
			private Action<PropAnimPlayData, bool> m_OnLoadFinished;

			[Token(Token = "0x4003728")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private readonly int _propIDInt;

			[Token(Token = "0x400372C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private int _pendingLoadCount;

			[Token(Token = "0x400372D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			private bool _loadFailed;

			[Token(Token = "0x400372E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
			private bool _enqueued;

			[Token(Token = "0x170002B6")]
			public string PropID
			{
				[Token(Token = "0x6002557")]
				[Address(RVA = "0x3F698A0", Offset = "0x3F658A0", VA = "0x3F698A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170002B7")]
			public Sprite RareBgSprite
			{
				[Token(Token = "0x6002558")]
				[Address(RVA = "0x3F698A8", Offset = "0x3F658A8", VA = "0x3F698A8")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6002559")]
				[Address(RVA = "0x3F698B0", Offset = "0x3F658B0", VA = "0x3F698B0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170002B8")]
			public Sprite NameSprite
			{
				[Token(Token = "0x600255A")]
				[Address(RVA = "0x3F698B8", Offset = "0x3F658B8", VA = "0x3F698B8")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600255B")]
				[Address(RVA = "0x3F698C0", Offset = "0x3F658C0", VA = "0x3F698C0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170002B9")]
			public Sprite IconSprite
			{
				[Token(Token = "0x600255C")]
				[Address(RVA = "0x3F698C8", Offset = "0x3F658C8", VA = "0x3F698C8")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600255D")]
				[Address(RVA = "0x3F698D0", Offset = "0x3F658D0", VA = "0x3F698D0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170002BA")]
			public bool IsLoadSettled
			{
				[Token(Token = "0x600255E")]
				[Address(RVA = "0x3F693A0", Offset = "0x3F653A0", VA = "0x3F693A0")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x14000009")]
			public event Action<PropAnimPlayData, bool> OnLoadFinished
			{
				[Token(Token = "0x6002555")]
				[Address(RVA = "0x3F68AE4", Offset = "0x3F64AE4", VA = "0x3F68AE4")]
				[CompilerGenerated]
				add
				{
				}
				[Token(Token = "0x6002556")]
				[Address(RVA = "0x3F69140", Offset = "0x3F65140", VA = "0x3F69140")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Token(Token = "0x6002554")]
			[Address(RVA = "0x3F68A60", Offset = "0x3F64A60", VA = "0x3F68A60")]
			public PropAnimPlayData(string propID)
			{
			}

			[Token(Token = "0x600255F")]
			[Address(RVA = "0x3F68B94", Offset = "0x3F64B94", VA = "0x3F68B94")]
			public void StartLoad(CancellationToken cancellationToken)
			{
			}

			[Token(Token = "0x6002560")]
			[Address(RVA = "0x3F6947C", Offset = "0x3F6547C", VA = "0x3F6947C")]
			public bool TryMarkEnqueued()
			{
				return default;
			}

			[Token(Token = "0x6002561")]
			[Address(RVA = "0x3F698D8", Offset = "0x3F658D8", VA = "0x3F698D8")]
			private void NotifyAllResourcesFailed()
			{
			}

			[Token(Token = "0x6002562")]
			[Address(RVA = "0x3F69908", Offset = "0x3F65908", VA = "0x3F69908")]
			[AsyncStateMachine(typeof(_003CLoadResourceAsync_003Ed__32))]
			private UniTaskVoid LoadResourceAsync(Func<CancellationToken, UniTask> loadInternal, CancellationToken cancellationToken)
			{
				return default;
			}

			[Token(Token = "0x6002563")]
			[Address(RVA = "0x3F69B1C", Offset = "0x3F65B1C", VA = "0x3F69B1C")]
			[AsyncStateMachine(typeof(_003CLoadRareBgResourceInternalAsync_003Ed__33))]
			private UniTask LoadRareBgResourceInternalAsync(CancellationToken cancellationToken)
			{
				return default;
			}

			[Token(Token = "0x6002564")]
			[Address(RVA = "0x3F69BB8", Offset = "0x3F65BB8", VA = "0x3F69BB8")]
			[AsyncStateMachine(typeof(_003CLoadNameResourceInternalAsync_003Ed__34))]
			private UniTask LoadNameResourceInternalAsync(CancellationToken cancellationToken)
			{
				return default;
			}

			[Token(Token = "0x6002565")]
			[Address(RVA = "0x3F69C50", Offset = "0x3F65C50", VA = "0x3F69C50")]
			[AsyncStateMachine(typeof(_003CLoadIconResourceInternalAsync_003Ed__35))]
			private UniTask LoadIconResourceInternalAsync(CancellationToken cancellationToken)
			{
				return default;
			}

			[Token(Token = "0x6002566")]
			[Address(RVA = "0x3F69CE8", Offset = "0x3F65CE8", VA = "0x3F69CE8")]
			private static string GetRareBgSpriteName(int rare)
			{
				return null;
			}

			[Token(Token = "0x6002567")]
			[Address(RVA = "0x3F69D6C", Offset = "0x3F65D6C", VA = "0x3F69D6C")]
			private bool HasAllResources()
			{
				return default;
			}

			[Token(Token = "0x6002568")]
			[Address(RVA = "0x3F69998", Offset = "0x3F65998", VA = "0x3F69998")]
			private void NotifyResourceLoaded(bool success)
			{
			}
		}

		[Token(Token = "0x20006EC")]
		[CompilerGenerated]
		private sealed class _003CPlayEnterAnimCoroutine_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4003745")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4003746")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4003747")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ArtifactUseAnimPanel _003C_003E4__this;

			[Token(Token = "0x4003748")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int _003CstateHash_003E5__2;

			[Token(Token = "0x4003749")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float _003CwaitRestartTimeout_003E5__3;

			[Token(Token = "0x400374A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float _003CwaitRestartTime_003E5__4;

			[Token(Token = "0x400374B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float _003CcurTime_003E5__5;

			[Token(Token = "0x170002BB")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6002574")]
				[Address(RVA = "0x3F85B00", Offset = "0x3F81B00", VA = "0x3F85B00", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170002BC")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6002576")]
				[Address(RVA = "0x3F85B40", Offset = "0x3F81B40", VA = "0x3F85B40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6002571")]
			[Address(RVA = "0x3F857B0", Offset = "0x3F817B0", VA = "0x3F857B0")]
			[DebuggerHidden]
			public _003CPlayEnterAnimCoroutine_003Ed__20(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6002572")]
			[Address(RVA = "0x3F857D8", Offset = "0x3F817D8", VA = "0x3F857D8", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6002573")]
			[Address(RVA = "0x3F857DC", Offset = "0x3F817DC", VA = "0x3F857DC", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6002574")]
			[Address(RVA = "0x3F85B00", Offset = "0x3F81B00", VA = "0x3F85B00", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6002575")]
			[Address(RVA = "0x3F85B08", Offset = "0x3F81B08", VA = "0x3F85B08", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6002576")]
			[Address(RVA = "0x3F85B40", Offset = "0x3F81B40", VA = "0x3F85B40", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x20006ED")]
		[CompilerGenerated]
		private sealed class _003CProcessQueueCoroutine_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400374C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400374D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400374E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ArtifactUseAnimPanel _003C_003E4__this;

			[Token(Token = "0x170002BD")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600257A")]
				[Address(RVA = "0x3F85C78", Offset = "0x3F81C78", VA = "0x3F85C78", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170002BE")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600257C")]
				[Address(RVA = "0x3F85CB8", Offset = "0x3F81CB8", VA = "0x3F85CB8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6002577")]
			[Address(RVA = "0x3F85B48", Offset = "0x3F81B48", VA = "0x3F85B48")]
			[DebuggerHidden]
			public _003CProcessQueueCoroutine_003Ed__18(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6002578")]
			[Address(RVA = "0x3F85B70", Offset = "0x3F81B70", VA = "0x3F85B70", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6002579")]
			[Address(RVA = "0x3F85B74", Offset = "0x3F81B74", VA = "0x3F85B74", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x600257A")]
			[Address(RVA = "0x3F85C78", Offset = "0x3F81C78", VA = "0x3F85C78", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600257B")]
			[Address(RVA = "0x3F85C80", Offset = "0x3F81C80", VA = "0x3F85C80", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x600257C")]
			[Address(RVA = "0x3F85CB8", Offset = "0x3F81CB8", VA = "0x3F85CB8", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x400371B")]
		private const float EnterAnimTimeoutSeconds = 2f;

		[Token(Token = "0x400371C")]
		private const string RareBgSpriteRootPath = "Assets/_Res/Addressable/SpritesBundle/UIPanel/ArtifactUseAnimPanel/";

		[Token(Token = "0x400371D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private readonly Queue<PropAnimPlayData> _playQueue;

		[Token(Token = "0x400371E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private readonly HashSet<PropAnimPlayData> _loadingPlayDataSet;

		[Token(Token = "0x400371F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool _isProcessingQueue;

		[Token(Token = "0x4003720")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Coroutine _processQueueCoroutine;

		[Token(Token = "0x4003721")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private CancellationTokenSource _loadCts;

		[Token(Token = "0x6002542")]
		[Address(RVA = "0x3F686E8", Offset = "0x3F646E8", VA = "0x3F686E8", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6002543")]
		[Address(RVA = "0x3F687BC", Offset = "0x3F647BC", VA = "0x3F687BC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6002544")]
		[Address(RVA = "0x3F68884", Offset = "0x3F64884", VA = "0x3F68884")]
		private void OnGameEnd(object obj)
		{
		}

		[Token(Token = "0x6002545")]
		[Address(RVA = "0x3F68890", Offset = "0x3F64890", VA = "0x3F68890")]
		public void TryPlay(string propID)
		{
		}

		[Token(Token = "0x6002546")]
		[Address(RVA = "0x3F68E74", Offset = "0x3F64E74", VA = "0x3F68E74", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6002547")]
		[Address(RVA = "0x3F689E4", Offset = "0x3F649E4", VA = "0x3F689E4")]
		private void EnsureLoadCancellationTokenSource()
		{
		}

		[Token(Token = "0x6002548")]
		[Address(RVA = "0x3F68E94", Offset = "0x3F64E94", VA = "0x3F68E94")]
		private void CancelPendingLoads()
		{
		}

		[Token(Token = "0x6002549")]
		[Address(RVA = "0x3F691F0", Offset = "0x3F651F0", VA = "0x3F691F0")]
		private void HandlePlayDataLoadFinished(PropAnimPlayData playData, bool allResourcesLoaded)
		{
		}

		[Token(Token = "0x600254A")]
		[Address(RVA = "0x3F6925C", Offset = "0x3F6525C", VA = "0x3F6925C")]
		private void UnregisterLoadingPlayData(PropAnimPlayData playData)
		{
		}

		[Token(Token = "0x600254B")]
		[Address(RVA = "0x3F69310", Offset = "0x3F65310", VA = "0x3F69310")]
		private void TryEnqueuePlayData(PropAnimPlayData playData)
		{
		}

		[Token(Token = "0x600254C")]
		[Address(RVA = "0x3F69558", Offset = "0x3F65558", VA = "0x3F69558")]
		private void TryStartProcessQueue()
		{
		}

		[Token(Token = "0x600254D")]
		[Address(RVA = "0x3F6969C", Offset = "0x3F6569C", VA = "0x3F6969C")]
		[IteratorStateMachine(typeof(_003CProcessQueueCoroutine_003Ed__18))]
		private IEnumerator ProcessQueueCoroutine()
		{
			return null;
		}

		[Token(Token = "0x600254E")]
		[Address(RVA = "0x3F69704", Offset = "0x3F65704", VA = "0x3F69704")]
		private void ApplyPlayDataToUI(PropAnimPlayData playData)
		{
		}

		[Token(Token = "0x600254F")]
		[Address(RVA = "0x3F69774", Offset = "0x3F65774", VA = "0x3F69774")]
		[IteratorStateMachine(typeof(_003CPlayEnterAnimCoroutine_003Ed__20))]
		private IEnumerator PlayEnterAnimCoroutine()
		{
			return null;
		}

		[Token(Token = "0x6002550")]
		[Address(RVA = "0x3F690EC", Offset = "0x3F650EC", VA = "0x3F690EC")]
		private void HidePanelVisual()
		{
		}

		[Token(Token = "0x6002551")]
		[Address(RVA = "0x3F6907C", Offset = "0x3F6507C", VA = "0x3F6907C")]
		private void ClearQueueAndStopProcessing()
		{
		}

		[Token(Token = "0x6002552")]
		[Address(RVA = "0x3F69648", Offset = "0x3F65648", VA = "0x3F69648")]
		private int PlayAnim(string animName)
		{
			return default;
		}

		[Token(Token = "0x6002553")]
		[Address(RVA = "0x3F697DC", Offset = "0x3F657DC", VA = "0x3F697DC")]
		public ArtifactUseAnimPanel()
		{
		}
	}
}
