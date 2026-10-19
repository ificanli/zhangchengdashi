using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;

namespace Pathfinding.Drawing
{
	[Token(Token = "0x2000059")]
	[BurstCompile]
	internal struct PersistentFilterJob : IJob
	{
		[Token(Token = "0x400016B")]
		[FieldOffset(Offset = "0x0")]
		[NativeDisableUnsafePtrRestriction]
		public unsafe UnsafeAppendBuffer* buffer;

		[Token(Token = "0x400016C")]
		[FieldOffset(Offset = "0x8")]
		public float time;

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x46F0394", Offset = "0x46EC394", VA = "0x46F0394", Slot = "4")]
		public void Execute()
		{
		}
	}
}
