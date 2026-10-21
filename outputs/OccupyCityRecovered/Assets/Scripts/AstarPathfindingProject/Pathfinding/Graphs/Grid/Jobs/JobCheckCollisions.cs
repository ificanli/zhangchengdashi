using Il2CppDummyDll;
using Pathfinding.Jobs;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

namespace Pathfinding.Graphs.Grid.Jobs
{
	[Token(Token = "0x2000226")]
	internal struct JobCheckCollisions : IJobTimeSliced, IJob
	{
		[Token(Token = "0x4000A30")]
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		public NativeArray<Vector3> nodePositions;

		[Token(Token = "0x4000A31")]
		[FieldOffset(Offset = "0x10")]
		public NativeArray<bool> collisionResult;

		[Token(Token = "0x4000A32")]
		[FieldOffset(Offset = "0x20")]
		public GraphCollision collision;

		[Token(Token = "0x4000A33")]
		[FieldOffset(Offset = "0x28")]
		private int startIndex;

		[Token(Token = "0x6000E08")]
		[Address(RVA = "0x447B394", Offset = "0x4477394", VA = "0x447B394", Slot = "5")]
		public void Execute()
		{ Execute(TimeSlice.Infinite); }

		[Token(Token = "0x6000E09")]
		[Address(RVA = "0x447B3F4", Offset = "0x44773F4", VA = "0x447B3F4", Slot = "4")]
		public bool Execute(TimeSlice timeSlice)
		{
 for (int i=startIndex;i<nodePositions.Length;i++) {
  if (collisionResult[i]) collisionResult[i]=collision.Check(nodePositions[i]);
  if ((i & 127)==0 && timeSlice.expired) { startIndex=unchecked(i+1); return false; }
 }
 return true;
}
	}
}
