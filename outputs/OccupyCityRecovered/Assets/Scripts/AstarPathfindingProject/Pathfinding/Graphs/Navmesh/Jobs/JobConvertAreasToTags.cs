using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;

namespace Pathfinding.Graphs.Navmesh.Jobs
{
	[Token(Token = "0x20001FC")]
	[BurstCompile]
	public struct JobConvertAreasToTags : IJob
	{
		[Token(Token = "0x4000985")]
		[FieldOffset(Offset = "0x0")]
		public NativeList<int> areas;

		[Token(Token = "0x6000D84")]
		[Address(RVA = "0x4470B18", Offset = "0x446CB18", VA = "0x4470B18", Slot = "4")]
		public void Execute()
		{
		}
	}
}
