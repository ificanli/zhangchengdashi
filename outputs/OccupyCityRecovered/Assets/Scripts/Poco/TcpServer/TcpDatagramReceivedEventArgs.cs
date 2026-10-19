using System;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace TcpServer
{
	[Token(Token = "0x2000021")]
	public class TcpDatagramReceivedEventArgs<T> : EventArgs
	{
		[Token(Token = "0x1700001B")]
		public TcpClientState Client
		{
			[Token(Token = "0x60000CA")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000CB")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public TcpClient TcpClient
		{
			[Token(Token = "0x60000CC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000CD")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700001D")]
		public T Datagram
		{
			[Token(Token = "0x60000CE")]
			[CompilerGenerated]
			get
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED TcpDatagramReceivedEventArgs.Datagram.get RVA= Token=0x60000CE");
}
			[Token(Token = "0x60000CF")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60000C9")]
		public TcpDatagramReceivedEventArgs(TcpClientState tcpClientState, T datagram)
		{
		}
	}
}
