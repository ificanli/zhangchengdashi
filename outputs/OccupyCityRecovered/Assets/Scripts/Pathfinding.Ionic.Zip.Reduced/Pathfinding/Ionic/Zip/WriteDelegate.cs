using System.IO;
using Il2CppDummyDll;

namespace Pathfinding.Ionic.Zip
{
	[Token(Token = "0x2000004")]
	public delegate void WriteDelegate(string entryName, Stream stream);
}
