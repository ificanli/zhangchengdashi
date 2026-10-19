using System.Collections.Generic;
using Il2CppDummyDll;
using Pathfinding.Jobs;
using Unity.Jobs;
using Unity.Profiling;

namespace Pathfinding
{
	[Token(Token = "0x20000A7")]
	public class GraphUpdateProcessor
	{
		[Token(Token = "0x4000375")]
		[FieldOffset(Offset = "0x10")]
		private readonly AstarPath astar;

		[Token(Token = "0x4000376")]
		[FieldOffset(Offset = "0x18")]
		private bool anyGraphUpdateInProgress;

		[Token(Token = "0x4000377")]
		[FieldOffset(Offset = "0x20")]
		private readonly Queue<GraphUpdateObject> graphUpdateQueue;

		[Token(Token = "0x4000378")]
		[FieldOffset(Offset = "0x28")]
		private readonly List<(IGraphUpdatePromise, IEnumerator<JobHandle>)> pendingPromises;

		[Token(Token = "0x4000379")]
		[FieldOffset(Offset = "0x30")]
		private readonly List<GraphUpdateObject> pendingGraphUpdates;

		[Token(Token = "0x400037A")]
		[FieldOffset(Offset = "0x0")]
		private static readonly ProfilerMarker MarkerSleep;

		[Token(Token = "0x400037B")]
		[FieldOffset(Offset = "0x8")]
		private static readonly ProfilerMarker MarkerCalculate;

		[Token(Token = "0x400037C")]
		[FieldOffset(Offset = "0x10")]
		private static readonly ProfilerMarker MarkerApply;

		[Token(Token = "0x17000120")]
		public bool IsAnyGraphUpdateQueued
		{
			[Token(Token = "0x6000581")]
			[Address(RVA = "0x4510218", Offset = "0x450C218", VA = "0x4510218")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000121")]
		public bool IsAnyGraphUpdateInProgress
		{
			[Token(Token = "0x6000582")]
			[Address(RVA = "0x4510268", Offset = "0x450C268", VA = "0x4510268")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x4510270", Offset = "0x450C270", VA = "0x4510270")]
		public GraphUpdateProcessor(AstarPath astar)
		{
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x4510388", Offset = "0x450C388", VA = "0x4510388")]
		public AstarWorkItem GetWorkItem()
		{
			return default;
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x4510458", Offset = "0x450C458", VA = "0x4510458")]
		public void AddToQueue(GraphUpdateObject ob)
		{
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0x45104B0", Offset = "0x450C4B0", VA = "0x45104B0")]
		public void DiscardQueued()
		{
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0x4510530", Offset = "0x450C530", VA = "0x4510530")]
		private void QueueGraphUpdatesInternal(IWorkItemContext context)
		{
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0x4510EA8", Offset = "0x450CEA8", VA = "0x4510EA8")]
		private bool ProcessGraphUpdates(IWorkItemContext context, bool force)
		{
			return default;
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x4511138", Offset = "0x450D138", VA = "0x4511138")]
		public static int ProcessGraphUpdatePromises(List<(IGraphUpdatePromise, IEnumerator<JobHandle>)> promises, IGraphUpdateContext context, TimeSlice timeSlice)
		{
			return default;
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x45111D0", Offset = "0x450D1D0", VA = "0x45111D0")]
		public static int PrepareGraphUpdatePromises(List<(IGraphUpdatePromise, IEnumerator<JobHandle>)> promises, TimeSlice timeSlice)
		{
			return default;
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x4511604", Offset = "0x450D604", VA = "0x4511604")]
		public static void ApplyGraphUpdatePromises(List<(IGraphUpdatePromise, IEnumerator<JobHandle>)> promises, IGraphUpdateContext context)
		{
		}
	}
}
