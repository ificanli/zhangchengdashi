using Il2CppDummyDll;
using Pathfinding.Pooling;

namespace Pathfinding
{
	[Token(Token = "0x2000020")]
	public abstract class RichPathPart : IAstarPooledObject
	{
		[Token(Token = "0x600020A")]
		public abstract void OnEnterPool();

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x44595E8", Offset = "0x44555E8", VA = "0x44595E8")]
		protected RichPathPart()
		{
		}
	}
}
