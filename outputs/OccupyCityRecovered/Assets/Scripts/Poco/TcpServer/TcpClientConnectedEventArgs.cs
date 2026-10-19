using System;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace TcpServer
{
	[Token(Token = "0x200001E")]
	public class TcpClientConnectedEventArgs : EventArgs
	{
		[Token(Token = "0x17000015")]
		public TcpClient TcpClient
		{
			[Token(Token = "0x60000BC")]
			[Address(RVA = "0x7882464", Offset = "0x787E464", VA = "0x7882464")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000BD")]
			[Address(RVA = "0x788246C", Offset = "0x787E46C", VA = "0x788246C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x78823AC", Offset = "0x787E3AC", VA = "0x78823AC")]
		public TcpClientConnectedEventArgs(TcpClient tcpClient)
		{
		}
	}
}
