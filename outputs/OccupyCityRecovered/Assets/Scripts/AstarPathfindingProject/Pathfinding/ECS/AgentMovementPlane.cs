using System;
using Il2CppDummyDll;
using Pathfinding.Util;
using Unity.Entities;
using Unity.Mathematics;

namespace Pathfinding.ECS
{
	[Serializable]
	[Token(Token = "0x20002E4")]
	public struct AgentMovementPlane : IComponentData, IQueryTypeParameter
	{
		[Token(Token = "0x4000D76")]
		[FieldOffset(Offset = "0x0")]
		public NativeMovementPlane value;

		[Token(Token = "0x6001288")]
		[Address(RVA = "0x44B1C98", Offset = "0x44ADC98", VA = "0x44B1C98")]
		public AgentMovementPlane(quaternion rotation)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED AgentMovementPlane..ctor RVA=0x44B1C98 Token=0x6001288");
}

		[Token(Token = "0x6001289")]
		[Address(RVA = "0x44B1CC8", Offset = "0x44ADCC8", VA = "0x44B1CC8")]
		public AgentMovementPlane(NativeMovementPlane plane)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED AgentMovementPlane..ctor RVA=0x44B1CC8 Token=0x6001289");
}
	}
}
