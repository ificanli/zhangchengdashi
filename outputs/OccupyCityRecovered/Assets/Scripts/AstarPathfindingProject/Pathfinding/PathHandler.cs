using System.Runtime.CompilerServices;
using System.Text;
using Il2CppDummyDll;
using Pathfinding.Collections;
using Unity.Profiling;

namespace Pathfinding
{
	[Token(Token = "0x20000BE")]
	public class PathHandler
	{
		[Token(Token = "0x40003F7")]
		[FieldOffset(Offset = "0x10")]
		private ushort pathID;

		[Token(Token = "0x40003F8")]
		[FieldOffset(Offset = "0x14")]
		public readonly int threadID;

		[Token(Token = "0x40003F9")]
		[FieldOffset(Offset = "0x18")]
		public readonly int totalThreadCount;

		[Token(Token = "0x40003FA")]
		[FieldOffset(Offset = "0x20")]
		internal readonly GlobalNodeStorage nodeStorage;

		[Token(Token = "0x40003FD")]
		[FieldOffset(Offset = "0x30")]
		private UnsafeSpan<TemporaryNode> temporaryNodes;

		[Token(Token = "0x40003FE")]
		[FieldOffset(Offset = "0x40")]
		public UnsafeSpan<PathNode> pathNodes;

		[Token(Token = "0x40003FF")]
		[FieldOffset(Offset = "0x50")]
		public BinaryHeap heap;

		[Token(Token = "0x4000400")]
		[FieldOffset(Offset = "0x70")]
		public readonly StringBuilder DebugStringBuilder;

		[Token(Token = "0x17000140")]
		public int numTemporaryNodes
		{
			[Token(Token = "0x6000646")]
			[Address(RVA = "0x45194A0", Offset = "0x45154A0", VA = "0x45194A0")]
			[IgnoredByDeepProfiler]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x6000647")]
			[Address(RVA = "0x45194A8", Offset = "0x45154A8", VA = "0x45194A8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000141")]
		public uint temporaryNodeStartIndex
		{
			[Token(Token = "0x6000648")]
			[Address(RVA = "0x45194B0", Offset = "0x45154B0", VA = "0x45194B0")]
			[IgnoredByDeepProfiler]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x6000649")]
			[Address(RVA = "0x45194B8", Offset = "0x45154B8", VA = "0x45194B8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000142")]
		public ushort PathID
		{
			[Token(Token = "0x600064A")]
			[Address(RVA = "0x45194C0", Offset = "0x45154C0", VA = "0x45194C0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0x45194C8", Offset = "0x45154C8", VA = "0x45194C8")]
		internal PathHandler(GlobalNodeStorage nodeStorage, int threadID, int totalThreadCount)
		{
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0x45179A8", Offset = "0x45139A8", VA = "0x45179A8")]
		public void InitializeForPath(Path p)
		{
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0x4519640", Offset = "0x4515640", VA = "0x4519640")]
		public PathNode GetPathNode(GraphNode node, uint variant = 0u)
		{
			return default;
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0x45173D8", Offset = "0x45133D8", VA = "0x45173D8")]
		public bool IsTemporaryNode(uint pathNodeIndex)
		{
			return default;
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0x451970C", Offset = "0x451570C", VA = "0x451970C")]
		public uint AddTemporaryNode(TemporaryNode node)
		{
			return default;
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0x45174D8", Offset = "0x45134D8", VA = "0x45174D8")]
		public GraphNode GetNode(uint nodeIndex)
		{
			return null;
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0x45173E8", Offset = "0x45133E8", VA = "0x45173E8")]
		public unsafe ref TemporaryNode GetTemporaryNode(uint nodeIndex)
		{
			return ref *(TemporaryNode*)null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000652")]
		[Address(RVA = "0x4519904", Offset = "0x4515904", VA = "0x4519904")]
		public void LogVisitedNode(uint pathNodeIndex, uint h, uint g)
		{
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0x451957C", Offset = "0x451557C", VA = "0x451957C")]
		public void ClearPathIDs()
		{
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0x4519908", Offset = "0x4515908", VA = "0x4519908")]
		public void Dispose()
		{
		}
	}
}
