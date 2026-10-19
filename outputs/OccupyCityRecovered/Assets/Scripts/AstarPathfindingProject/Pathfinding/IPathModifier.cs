using Il2CppDummyDll;

namespace Pathfinding
{
	[Token(Token = "0x200011E")]
	public interface IPathModifier
	{
		[Token(Token = "0x170001C2")]
		int Order
		{
			[Token(Token = "0x60009A5")]
			get;
		}

		[Token(Token = "0x60009A6")]
		void Apply(Path path);

		[Token(Token = "0x60009A7")]
		void PreProcess(Path path);
	}
}
