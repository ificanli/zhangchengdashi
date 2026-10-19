using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Burst;
using Unity.Burst.Intrinsics;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;

namespace Pathfinding.ECS
{
	[Token(Token = "0x200031A")]
	[BurstCompile]
	public partial struct JobClearTemporaryData : IJobEntity, IJobChunk
	{

		[Token(Token = "0x600134F")]
		[Address(RVA = "0x44B809C", Offset = "0x44B409C", VA = "0x44B809C")]
		public void Execute(ref MovementState movementState, ref MovementControl movementControl)
		{
		}

		[Token(Token = "0x6001368")]
		[Address(RVA = "0x44B8504", Offset = "0x44B4504", VA = "0x44B8504", Slot = "4")]
void IJobChunk.Execute(in ArchetypeChunk chunk, int unfilteredChunkIndex, bool useEnabledMask, in v128 chunkEnabledMask)
		{
		}
	}
}
