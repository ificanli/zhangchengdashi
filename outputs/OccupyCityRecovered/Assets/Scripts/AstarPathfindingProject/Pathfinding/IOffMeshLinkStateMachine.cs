using System.Collections;
using Il2CppDummyDll;
using Pathfinding.ECS;

namespace Pathfinding
{
	[Token(Token = "0x2000086")]
	public interface IOffMeshLinkStateMachine
	{
		[Token(Token = "0x600048D")]
		[Address(RVA = "0x450620C", Offset = "0x450220C", VA = "0x450620C", Slot = "0")]
		IEnumerable OnTraverseOffMeshLink(AgentOffMeshLinkTraversalContext context)
		{
			return null;
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x4506218", Offset = "0x4502218", VA = "0x4506218", Slot = "1")]
		void OnFinishTraversingOffMeshLink(AgentOffMeshLinkTraversalContext context)
		{
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x450621C", Offset = "0x450221C", VA = "0x450621C", Slot = "2")]
		void OnAbortTraversingOffMeshLink()
		{
		}
	}
}
