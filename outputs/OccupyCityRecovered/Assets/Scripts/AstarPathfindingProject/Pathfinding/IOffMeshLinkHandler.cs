using Il2CppDummyDll;
using Pathfinding.ECS;

namespace Pathfinding
{
	[Token(Token = "0x2000085")]
	public interface IOffMeshLinkHandler
	{
		[Token(Token = "0x170000EE")]
		string name
		{
			[Token(Token = "0x600048B")]
			[Address(RVA = "0x4506204", Offset = "0x4502204", VA = "0x4506204", Slot = "0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600048C")]
		IOffMeshLinkStateMachine GetOffMeshLinkStateMachine(AgentOffMeshLinkTraversalContext context);
	}
}
