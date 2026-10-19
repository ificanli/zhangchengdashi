using System;
using Il2CppDummyDll;
using Unity.Entities;
using Unity.Mathematics;

namespace Pathfinding.ECS
{
	[Token(Token = "0x20002E8")]
	public struct AgentOffMeshLinkTraversal : IComponentData, IQueryTypeParameter
	{
		[Token(Token = "0x4000D78")]
		[FieldOffset(Offset = "0x0")]
		public float3 relativeStart;

		[Token(Token = "0x4000D79")]
		[FieldOffset(Offset = "0xC")]
		public float3 relativeEnd;

		[Token(Token = "0x4000D7A")]
		[FieldOffset(Offset = "0x18")]
		public bool isReverse;

		[Token(Token = "0x170002FF")]
		[Obsolete("Use relativeStart instead")]
		public float3 firstPosition
		{
			[Token(Token = "0x600128A")]
			[Address(RVA = "0x44B1CD4", Offset = "0x44ADCD4", VA = "0x44B1CD4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000300")]
		[Obsolete("Use relativeEnd instead")]
		public float3 secondPosition
		{
			[Token(Token = "0x600128B")]
			[Address(RVA = "0x44B1CE0", Offset = "0x44ADCE0", VA = "0x44B1CE0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600128C")]
		[Address(RVA = "0x44B1CEC", Offset = "0x44ADCEC", VA = "0x44B1CEC")]
		public AgentOffMeshLinkTraversal(OffMeshLinks.OffMeshLinkTracer linkInfo)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED AgentOffMeshLinkTraversal..ctor RVA=0x44B1CEC Token=0x600128C");
}
	}
}
