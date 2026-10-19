using System.Net.Sockets;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace TcpServer
{
	[Token(Token = "0x2000020")]
	public class TcpClientState
	{
		[Token(Token = "0x17000017")]
		public TcpClient TcpClient
		{
			[Token(Token = "0x60000C2")]
			[Address(RVA = "0x788260C", Offset = "0x787E60C", VA = "0x788260C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000C3")]
			[Address(RVA = "0x7882614", Offset = "0x787E614", VA = "0x7882614")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000018")]
		public byte[] Buffer
		{
			[Token(Token = "0x60000C4")]
			[Address(RVA = "0x788261C", Offset = "0x787E61C", VA = "0x788261C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000C5")]
			[Address(RVA = "0x7882624", Offset = "0x787E624", VA = "0x7882624")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000019")]
		public ProtoFilter Prot
		{
			[Token(Token = "0x60000C6")]
			[Address(RVA = "0x788262C", Offset = "0x787E62C", VA = "0x788262C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000C7")]
			[Address(RVA = "0x7882634", Offset = "0x787E634", VA = "0x7882634")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700001A")]
		public NetworkStream NetworkStream
		{
			[Token(Token = "0x60000C8")]
			[Address(RVA = "0x788263C", Offset = "0x787E63C", VA = "0x788263C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x788253C", Offset = "0x787E53C", VA = "0x788253C")]
		public TcpClientState(TcpClient tcpClient, byte[] buffer, ProtoFilter prot)
		{
		}
	}
}
