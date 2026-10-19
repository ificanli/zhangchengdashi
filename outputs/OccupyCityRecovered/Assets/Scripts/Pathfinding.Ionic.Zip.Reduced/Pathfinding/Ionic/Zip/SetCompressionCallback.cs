using Il2CppDummyDll;
using Pathfinding.Ionic.Zlib;

namespace Pathfinding.Ionic.Zip
{
	[Token(Token = "0x2000007")]
	public delegate CompressionLevel SetCompressionCallback(string localFileName, string fileNameInArchive);
}
