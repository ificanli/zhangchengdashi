using System;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace TcpServer
{
	[Token(Token = "0x200001F")]
	public class TcpClientDisconnectedEventArgs : EventArgs
	{
		[Token(Token = "0x17000016")]
		public TcpClient TcpClient
		{
			[Token(Token = "0x60000BF")]
			[Address(RVA = "0x788252C", Offset = "0x787E52C", VA = "0x788252C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000C0")]
			[Address(RVA = "0x7882534", Offset = "0x787E534", VA = "0x7882534")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x7882474", Offset = "0x787E474", VA = "0x7882474")]
		public TcpClientDisconnectedEventArgs(TcpClient tcpClient)
		{
		}
	}
}
