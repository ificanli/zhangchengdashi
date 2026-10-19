using Il2CppDummyDll;
using Unity.Entities;

namespace Pathfinding.ECS
{
	[Token(Token = "0x20002EE")]
	public struct AgentShouldRecalculatePath : IComponentData, IQueryTypeParameter, IEnableableComponent
	{
	}
}
