using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

namespace Pathfinding.Jobs
{
	[Token(Token = "0x200017F")]
	[BurstCompile(FloatMode = FloatMode.Fast)]
	public struct JobClampHitToRay : IJob
	{
		[Token(Token = "0x4000794")]
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		public NativeArray<SpherecastCommand> commands;

		[Token(Token = "0x4000795")]
		[FieldOffset(Offset = "0x10")]
		public NativeArray<RaycastHit> hits;

		[Token(Token = "0x6000BA3")]
		[Address(RVA = "0x4581A78", Offset = "0x457DA78", VA = "0x4581A78", Slot = "4")]
		public void Execute()
		{
		}
	}
}
