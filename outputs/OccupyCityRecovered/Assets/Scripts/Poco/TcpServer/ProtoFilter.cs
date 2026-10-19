using System.Collections.Generic;
using Il2CppDummyDll;

namespace TcpServer
{
	[Token(Token = "0x2000022")]
	public interface ProtoFilter
	{
		[Token(Token = "0x60000D0")]
		void input(byte[] data);

		[Token(Token = "0x60000D1")]
		List<string> swap_msgs();
	}
}
