using System;
using Il2CppDummyDll;

namespace Pathfinding.Util
{
	[Token(Token = "0x200028F")]
	public interface IGraphSnapshot : IDisposable
	{
		[Token(Token = "0x600102A")]
		void Restore(IGraphUpdateContext ctx);
	}
}
