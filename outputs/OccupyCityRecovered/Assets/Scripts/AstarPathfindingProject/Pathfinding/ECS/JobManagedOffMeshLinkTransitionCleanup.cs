using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Burst.Intrinsics;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;

namespace Pathfinding.ECS
{
	[Token(Token = "0x200033C")]
	public partial struct JobManagedOffMeshLinkTransitionCleanup : IJobEntity, IJobChunk
	{

		[Token(Token = "0x600147A")]
		[Address(RVA = "0x44C2FFC", Offset = "0x44BEFFC", VA = "0x44C2FFC")]
		public void Execute(ManagedAgentOffMeshLinkTraversal managedLinkInfo)
		{
		}

		[Token(Token = "0x6001493")]
		[Address(RVA = "0x44C3458", Offset = "0x44BF458", VA = "0x44C3458", Slot = "4")]
void IJobChunk.Execute(in ArchetypeChunk chunk, int unfilteredChunkIndex, bool useEnabledMask, in v128 chunkEnabledMask)
		{
		}
	}
}
