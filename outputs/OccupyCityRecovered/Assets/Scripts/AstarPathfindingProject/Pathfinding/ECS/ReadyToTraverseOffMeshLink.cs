using System;
using Il2CppDummyDll;
using Unity.Entities;

namespace Pathfinding.ECS
{
	[Serializable]
	[Token(Token = "0x2000303")]
	public struct ReadyToTraverseOffMeshLink : IComponentData, IQueryTypeParameter, IEnableableComponent
	{
	}
}
