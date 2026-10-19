using System;
using Il2CppDummyDll;
using Unity.Entities;
using Unity.Properties;

namespace Pathfinding.ECS
{
	[Serializable]
	[Token(Token = "0x20002F0")]
	[GeneratePropertyBag]
	public struct DestinationEntity : IComponentData, IQueryTypeParameter, IEnableableComponent
	{
		[Token(Token = "0x4000D95")]
		[FieldOffset(Offset = "0x0")]
		public Entity destination;

		[Token(Token = "0x4000D96")]
		[FieldOffset(Offset = "0x8")]
		public bool useRotation;
	}
}
