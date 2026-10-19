using Il2CppDummyDll;
using Pathfinding.Serialization;

namespace Pathfinding
{
	[Token(Token = "0x2000074")]
	[JsonOptIn]
	public class GraphEditorBase
	{
		[Token(Token = "0x400029E")]
		[FieldOffset(Offset = "0x10")]
		public NavGraph target;

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x44FDEC0", Offset = "0x44F9EC0", VA = "0x44FDEC0")]
		public GraphEditorBase()
		{
		}
	}
}
