using Il2CppDummyDll;
using Pathfinding.RVO;
using Unity.Collections;
using Unity.Entities;

namespace Pathfinding.ECS.RVO
{
	[Token(Token = "0x20003B1")]
	[WriteGroup(typeof(ResolvedMovement))]
	public readonly struct AgentIndex : ICleanupComponentData, IComponentData, IQueryTypeParameter
	{
		[Token(Token = "0x4000F95")]
		private const int DeletedBit = int.MinValue;

		[Token(Token = "0x4000F96")]
		private const int IndexMask = 16777215;

		[Token(Token = "0x4000F97")]
		private const int VersionOffset = 24;

		[Token(Token = "0x4000F98")]
		private const int VersionMask = 2130706432;

		[Token(Token = "0x4000F99")]
		[FieldOffset(Offset = "0x0")]
		private readonly int packedAgentIndex;

		[Token(Token = "0x1700032B")]
		internal int Index
		{
			[Token(Token = "0x6001790")]
			[Address(RVA = "0x44DF514", Offset = "0x44DB514", VA = "0x44DF514")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700032C")]
		private int Version
		{
			[Token(Token = "0x6001791")]
			[Address(RVA = "0x44DF520", Offset = "0x44DB520", VA = "0x44DF520")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700032D")]
		internal bool Valid
		{
			[Token(Token = "0x6001792")]
			[Address(RVA = "0x44DF52C", Offset = "0x44DB52C", VA = "0x44DF52C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6001793")]
		[Address(RVA = "0x44DF53C", Offset = "0x44DB53C", VA = "0x44DF53C")]
		internal AgentIndex(int packedAgentIndex)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED AgentIndex..ctor RVA=0x44DF53C Token=0x6001793");
}

		[Token(Token = "0x6001794")]
		[Address(RVA = "0x44DF544", Offset = "0x44DB544", VA = "0x44DF544")]
		internal AgentIndex(int version, int index)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED AgentIndex..ctor RVA=0x44DF544 Token=0x6001794");
}

		[Token(Token = "0x6001795")]
		[Address(RVA = "0x44DF554", Offset = "0x44DB554", VA = "0x44DF554")]
		internal AgentIndex WithIncrementedVersion()
		{
			return default;
		}

		[Token(Token = "0x6001796")]
		[Address(RVA = "0x44DF570", Offset = "0x44DB570", VA = "0x44DF570")]
		internal AgentIndex WithDeleted()
		{
			return default;
		}

		[Token(Token = "0x6001797")]
		[Address(RVA = "0x44DF57C", Offset = "0x44DB57C", VA = "0x44DF57C")]
		public bool Exists(ref SimulatorBurst.AgentData agentData)
		{
			return default;
		}

		[Token(Token = "0x6001798")]
		[Address(RVA = "0x44DF598", Offset = "0x44DB598", VA = "0x44DF598")]
		public bool TryGetIndex(ref SimulatorBurst.AgentData agentData, out int index)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED AgentIndex.TryGetIndex RVA=0x44DF598 Token=0x6001798");
}

		[Token(Token = "0x6001799")]
		[Address(RVA = "0x44DF59C", Offset = "0x44DB59C", VA = "0x44DF59C")]
		public bool TryGetIndex(ref NativeArray<AgentIndex> agentDataVersions, out int index)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED AgentIndex.TryGetIndex RVA=0x44DF59C Token=0x6001799");
}
	}
}
