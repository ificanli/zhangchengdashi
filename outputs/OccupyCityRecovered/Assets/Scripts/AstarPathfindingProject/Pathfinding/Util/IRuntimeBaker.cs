using Il2CppDummyDll;
using Unity.Entities;

namespace Pathfinding.Util
{
	[Token(Token = "0x200028D")]
	internal interface IRuntimeBaker
	{
		[Token(Token = "0x6001028")]
		void OnCreatedEntity(World world, Entity entity);
	}
}
