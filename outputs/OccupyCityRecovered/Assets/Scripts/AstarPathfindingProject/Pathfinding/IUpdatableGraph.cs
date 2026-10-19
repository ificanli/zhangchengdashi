using System.Collections.Generic;
using Il2CppDummyDll;

namespace Pathfinding
{
	[Token(Token = "0x200002D")]
	public interface IUpdatableGraph
	{
		[Token(Token = "0x600025A")]
		IGraphUpdatePromise ScheduleGraphUpdates(List<GraphUpdateObject> graphUpdates);
	}
}
