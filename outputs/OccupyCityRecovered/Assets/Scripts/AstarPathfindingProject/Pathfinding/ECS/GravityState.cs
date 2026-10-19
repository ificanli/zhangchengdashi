using Il2CppDummyDll;
using Unity.Entities;

namespace Pathfinding.ECS
{
	[Token(Token = "0x20002F2")]
	public struct GravityState : IComponentData, IQueryTypeParameter, IEnableableComponent
	{
		[Token(Token = "0x4000D99")]
		[FieldOffset(Offset = "0x0")]
		public float verticalVelocity;
	}
}
