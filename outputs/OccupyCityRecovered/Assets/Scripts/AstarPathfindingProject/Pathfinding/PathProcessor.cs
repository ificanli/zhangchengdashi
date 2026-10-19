using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Il2CppDummyDll;
using Pathfinding.Sync;
using Unity.Profiling;

namespace Pathfinding
{
	[Token(Token = "0x20000BF")]
	public class PathProcessor
	{
		[Token(Token = "0x20000C0")]
		public struct GraphUpdateLock : IDisposable
		{
			[Token(Token = "0x4000410")]
			[FieldOffset(Offset = "0x0")]
			private PathProcessor pathProcessor;

			[Token(Token = "0x4000411")]
			[FieldOffset(Offset = "0x8")]
			private int id;

			[Token(Token = "0x17000145")]
			public bool Held
			{
				[Token(Token = "0x600066A")]
				[Address(RVA = "0x451B634", Offset = "0x4517634", VA = "0x451B634")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x6000669")]
			[Address(RVA = "0x451A8D0", Offset = "0x45168D0", VA = "0x451A8D0")]
			public GraphUpdateLock(PathProcessor pathProcessor, bool block)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED PathProcessor.GraphUpdateLock..ctor RVA=0x451A8D0 Token=0x6000669");
}

			[Token(Token = "0x600066B")]
			[Address(RVA = "0x451B6A0", Offset = "0x45176A0", VA = "0x451B6A0")]
			public void Release()
			{
			}

			[Token(Token = "0x600066C")]
			[Address(RVA = "0x451B6C0", Offset = "0x45176C0", VA = "0x451B6C0", Slot = "4")]
void System.IDisposable.Dispose()
			{
			}
		}

		[Token(Token = "0x20000C2")]
		[CompilerGenerated]
		private sealed class _003CCalculatePaths_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000415")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000416")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000417")]
			[FieldOffset(Offset = "0x20")]
			public PathProcessor _003C_003E4__this;

			[Token(Token = "0x4000418")]
			[FieldOffset(Offset = "0x28")]
			public PathHandler pathHandler;

			[Token(Token = "0x4000419")]
			[FieldOffset(Offset = "0x30")]
			private long _003CmaxTicks_003E5__2;

			[Token(Token = "0x400041A")]
			[FieldOffset(Offset = "0x38")]
			private long _003CtargetTick_003E5__3;

			[Token(Token = "0x400041B")]
			[FieldOffset(Offset = "0x40")]
			private Path _003Cp_003E5__4;

			[Token(Token = "0x400041C")]
			[FieldOffset(Offset = "0x48")]
			private bool _003CblockedBefore_003E5__5;

			[Token(Token = "0x400041D")]
			[FieldOffset(Offset = "0x50")]
			private IPathInternals _003Cip_003E5__6;

			[Token(Token = "0x400041E")]
			[FieldOffset(Offset = "0x58")]
			private long _003CtotalTicks_003E5__7;

			[Token(Token = "0x400041F")]
			[FieldOffset(Offset = "0x60")]
			private Path.SearchContext _003CsearchContext_003E5__8;

			[Token(Token = "0x17000146")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000672")]
				[Address(RVA = "0x451BEB4", Offset = "0x4517EB4", VA = "0x451BEB4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000147")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000674")]
				[Address(RVA = "0x451BEF4", Offset = "0x4517EF4", VA = "0x451BEF4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x600066F")]
			[Address(RVA = "0x451B558", Offset = "0x4517558", VA = "0x451B558")]
			[DebuggerHidden]
			public _003CCalculatePaths_003Ed__36(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000670")]
			[Address(RVA = "0x451B6E4", Offset = "0x45176E4", VA = "0x451B6E4", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000671")]
			[Address(RVA = "0x451B6E8", Offset = "0x45176E8", VA = "0x451B6E8", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6000672")]
			[Address(RVA = "0x451BEB4", Offset = "0x4517EB4", VA = "0x451BEB4", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000673")]
			[Address(RVA = "0x451BEBC", Offset = "0x4517EBC", VA = "0x451BEBC", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000674")]
			[Address(RVA = "0x451BEF4", Offset = "0x4517EF4", VA = "0x451BEF4", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4000401")]
		[FieldOffset(Offset = "0x10")]
		[CompilerGenerated]
		private Action<Path> m_OnPathPreSearch;

		[Token(Token = "0x4000402")]
		[FieldOffset(Offset = "0x18")]
		[CompilerGenerated]
		private Action<PathHandler, Path> m_OnPathPostSearch;

		[Token(Token = "0x4000403")]
		[FieldOffset(Offset = "0x20")]
		[CompilerGenerated]
		private Action m_OnQueueUnblocked;

		[Token(Token = "0x4000404")]
		[FieldOffset(Offset = "0x28")]
		internal BlockableChannel<Path> queue;

		[Token(Token = "0x4000405")]
		[FieldOffset(Offset = "0x30")]
		private readonly AstarPath astar;

		[Token(Token = "0x4000406")]
		[FieldOffset(Offset = "0x38")]
		private readonly PathReturnQueue returnQueue;

		[Token(Token = "0x4000407")]
		[FieldOffset(Offset = "0x40")]
		private PathHandler[] pathHandlers;

		[Token(Token = "0x4000408")]
		[FieldOffset(Offset = "0x48")]
		private Thread[] threads;

		[Token(Token = "0x4000409")]
		[FieldOffset(Offset = "0x50")]
		private bool multithreaded;

		[Token(Token = "0x400040A")]
		[FieldOffset(Offset = "0x58")]
		private IEnumerator threadCoroutine;

		[Token(Token = "0x400040B")]
		[FieldOffset(Offset = "0x60")]
		private BlockableChannel<Path>.Receiver coroutineReceiver;

		[Token(Token = "0x400040C")]
		[FieldOffset(Offset = "0x68")]
		private readonly List<int> locks;

		[Token(Token = "0x400040D")]
		[FieldOffset(Offset = "0x70")]
		private int nextLockID;

		[Token(Token = "0x400040E")]
		[FieldOffset(Offset = "0x0")]
		private static readonly ProfilerMarker MarkerCalculatePath;

		[Token(Token = "0x400040F")]
		[FieldOffset(Offset = "0x8")]
		private static readonly ProfilerMarker MarkerPreparePath;

		[Token(Token = "0x17000143")]
		public int NumThreads
		{
			[Token(Token = "0x600065B")]
			[Address(RVA = "0x4519D60", Offset = "0x4515D60", VA = "0x4519D60")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000144")]
		public bool IsUsingMultithreading
		{
			[Token(Token = "0x600065C")]
			[Address(RVA = "0x4519D7C", Offset = "0x4515D7C", VA = "0x4519D7C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x14000002")]
		public event Action<Path> OnPathPreSearch
		{
			[Token(Token = "0x6000655")]
			[Address(RVA = "0x4519968", Offset = "0x4515968", VA = "0x4519968")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000656")]
			[Address(RVA = "0x4519A18", Offset = "0x4515A18", VA = "0x4519A18")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000003")]
		public event Action<PathHandler, Path> OnPathPostSearch
		{
			[Token(Token = "0x6000657")]
			[Address(RVA = "0x4519AC8", Offset = "0x4515AC8", VA = "0x4519AC8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000658")]
			[Address(RVA = "0x4519B78", Offset = "0x4515B78", VA = "0x4519B78")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000004")]
		public event Action OnQueueUnblocked
		{
			[Token(Token = "0x6000659")]
			[Address(RVA = "0x4519C28", Offset = "0x4515C28", VA = "0x4519C28")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600065A")]
			[Address(RVA = "0x4519CC4", Offset = "0x4515CC4", VA = "0x4519CC4")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0x4519D84", Offset = "0x4515D84", VA = "0x4519D84")]
		internal PathProcessor(AstarPath astar, PathReturnQueue returnQueue, int processors, bool multithreaded)
		{
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0x4519E8C", Offset = "0x4515E8C", VA = "0x4519E8C")]
		public void SetThreadCount(int processors, bool multithreaded)
		{
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0x451A098", Offset = "0x4516098", VA = "0x451A098")]
		private void StartThreads()
		{
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0x451A46C", Offset = "0x451646C", VA = "0x451A46C")]
		private int Lock(bool block)
		{
			return default;
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0x451A79C", Offset = "0x451679C", VA = "0x451A79C")]
		private void Unlock(int id)
		{
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0x451A8A8", Offset = "0x45168A8", VA = "0x451A8A8")]
		public GraphUpdateLock PausePathfinding(bool block)
		{
			return default;
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0x451A594", Offset = "0x4516594", VA = "0x451A594")]
		public void TickNonMultithreaded()
		{
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0x451A900", Offset = "0x4516900", VA = "0x451A900")]
		public void StopThreads()
		{
		}

		[Token(Token = "0x6000665")]
		[Address(RVA = "0x451AB08", Offset = "0x4516B08", VA = "0x451AB08")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0x451AB0C", Offset = "0x4516B0C", VA = "0x451AB0C")]
		private void CalculatePathsThreaded(PathHandler pathHandler, BlockableChannel<Path>.Receiver receiver)
		{
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0x451A400", Offset = "0x4516400", VA = "0x451A400")]
		[IteratorStateMachine(typeof(_003CCalculatePaths_003Ed__36))]
		private IEnumerator CalculatePaths(PathHandler pathHandler)
		{
			return null;
		}
	}
}
