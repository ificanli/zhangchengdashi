using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	[Token(Token = "0x20000A6")]
	public interface IGraphUpdateContext
	{
		[Token(Token = "0x6000580")]
		void DirtyBounds(Bounds bounds);
	}
}
