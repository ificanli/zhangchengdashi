using Il2CppDummyDll;
using Pathfinding.Graphs.Grid;
using Unity.Collections;

namespace Pathfinding.Jobs
{
	[Token(Token = "0x200017D")]
	public struct JobAND : GridIterationUtilities.ISliceAction
	{
		[Token(Token = "0x400078E")]
		[FieldOffset(Offset = "0x0")]
		public NativeArray<bool> result;

		[Token(Token = "0x400078F")]
		[FieldOffset(Offset = "0x10")]
		[ReadOnly]
		public NativeArray<bool> data;

		[Token(Token = "0x6000BA1")]
		[Address(RVA = "0x4581960", Offset = "0x457D960", VA = "0x4581960", Slot = "4")]
		public void Execute(uint outerIdx, uint innerIdx)
		{ result[(int)outerIdx] &= data[(int)outerIdx]; }
	}
}
