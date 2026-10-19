using System.Collections.Generic;
using Il2CppDummyDll;

namespace Poco
{
	[Token(Token = "0x2000015")]
	public interface IDumper
	{
		[Token(Token = "0x6000044")]
		AbstractNode getRoot();

		[Token(Token = "0x6000045")]
		Dictionary<string, object> dumpHierarchy();

		[Token(Token = "0x6000046")]
		Dictionary<string, object> dumpHierarchy(bool onlyVisibleNode);

		[Token(Token = "0x6000047")]
		List<float> getPortSize();
	}
}
