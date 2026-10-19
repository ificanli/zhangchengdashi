using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using Il2CppDummyDll;

namespace TcpServer
{
	[Token(Token = "0x2000024")]
	public class AsyncTcpServer : IDisposable
	{
		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x10")]
		private TcpListener _listener;

		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x18")]
		private ConcurrentDictionary<string, TcpClientState> _clients;

		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x20")]
		private bool _disposed;

		[Token(Token = "0x400005A")]
		[FieldOffset(Offset = "0x40")]
		[CompilerGenerated]
		private EventHandler<TcpDatagramReceivedEventArgs<byte[]>> m_DatagramReceived;

		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0x48")]
		[CompilerGenerated]
		private EventHandler<TcpDatagramReceivedEventArgs<string>> m_PlaintextReceived;

		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0x50")]
		[CompilerGenerated]
		private EventHandler<TcpClientConnectedEventArgs> m_ClientConnected;

		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0x58")]
		[CompilerGenerated]
		private EventHandler<TcpClientDisconnectedEventArgs> m_ClientDisconnected;

		[Token(Token = "0x1700001E")]
		public bool IsRunning
		{
			[Token(Token = "0x60000DB")]
			[Address(RVA = "0x7882A40", Offset = "0x787EA40", VA = "0x7882A40")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x60000DC")]
			[Address(RVA = "0x7882A48", Offset = "0x787EA48", VA = "0x7882A48")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700001F")]
		public IPAddress Address
		{
			[Token(Token = "0x60000DD")]
			[Address(RVA = "0x7882A54", Offset = "0x787EA54", VA = "0x7882A54")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000DE")]
			[Address(RVA = "0x7882A5C", Offset = "0x787EA5C", VA = "0x7882A5C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000020")]
		public int Port
		{
			[Token(Token = "0x60000DF")]
			[Address(RVA = "0x7882A64", Offset = "0x787EA64", VA = "0x7882A64")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x60000E0")]
			[Address(RVA = "0x7882A6C", Offset = "0x787EA6C", VA = "0x7882A6C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000021")]
		public Encoding Encoding
		{
			[Token(Token = "0x60000E1")]
			[Address(RVA = "0x7882A74", Offset = "0x787EA74", VA = "0x7882A74")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000E2")]
			[Address(RVA = "0x7882A7C", Offset = "0x787EA7C", VA = "0x7882A7C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x14000001")]
		public event EventHandler<TcpDatagramReceivedEventArgs<byte[]>> DatagramReceived
		{
			[Token(Token = "0x60000EA")]
			[Address(RVA = "0x7879614", Offset = "0x7875614", VA = "0x7879614")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000EB")]
			[Address(RVA = "0x78836A4", Offset = "0x787F6A4", VA = "0x78836A4")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000002")]
		public event EventHandler<TcpDatagramReceivedEventArgs<string>> PlaintextReceived
		{
			[Token(Token = "0x60000EC")]
			[Address(RVA = "0x7883754", Offset = "0x787F754", VA = "0x7883754")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000ED")]
			[Address(RVA = "0x7883804", Offset = "0x787F804", VA = "0x7883804")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000003")]
		public event EventHandler<TcpClientConnectedEventArgs> ClientConnected
		{
			[Token(Token = "0x60000F0")]
			[Address(RVA = "0x78794B4", Offset = "0x78754B4", VA = "0x78794B4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000F1")]
			[Address(RVA = "0x78839A0", Offset = "0x787F9A0", VA = "0x78839A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000004")]
		public event EventHandler<TcpClientDisconnectedEventArgs> ClientDisconnected
		{
			[Token(Token = "0x60000F2")]
			[Address(RVA = "0x7879564", Offset = "0x7875564", VA = "0x7879564")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000F3")]
			[Address(RVA = "0x7883A50", Offset = "0x787FA50", VA = "0x7883A50")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x7879444", Offset = "0x7875444", VA = "0x7879444")]
		public AsyncTcpServer(int listenPort)
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x7882A20", Offset = "0x787EA20", VA = "0x7882A20")]
		public AsyncTcpServer(IPEndPoint localEP)
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x7882940", Offset = "0x787E940", VA = "0x7882940")]
		public AsyncTcpServer(IPAddress localIPAddress, int listenPort)
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x78796C4", Offset = "0x78756C4", VA = "0x78796C4")]
		public AsyncTcpServer Start()
		{
			return null;
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x7882A84", Offset = "0x787EA84", VA = "0x7882A84")]
		public AsyncTcpServer Start(int backlog)
		{
			return null;
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x7879FE4", Offset = "0x7875FE4", VA = "0x7879FE4")]
		public AsyncTcpServer Stop()
		{
			return null;
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x7882AC8", Offset = "0x787EAC8", VA = "0x7882AC8")]
		private void ContinueAcceptTcpClient(TcpListener tcpListener)
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x7882C24", Offset = "0x787EC24", VA = "0x7882C24")]
		private void HandleTcpClientAccepted(IAsyncResult ar)
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x7883128", Offset = "0x787F128", VA = "0x7883128")]
		private void HandleDatagramReceived(IAsyncResult ar)
		{
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x7882FB4", Offset = "0x787EFB4", VA = "0x7882FB4")]
		private void ContinueReadBuffer(TcpClientState internalClient, NetworkStream networkStream)
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x78835F8", Offset = "0x787F5F8", VA = "0x78835F8")]
		private void RaiseDatagramReceived(TcpClientState sender, byte[] datagram)
		{
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x78838B4", Offset = "0x787F8B4", VA = "0x78838B4")]
		private void RaisePlaintextReceived(TcpClientState sender, byte[] datagram)
		{
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x7882F28", Offset = "0x787EF28", VA = "0x7882F28")]
		private void RaiseClientConnected(TcpClient tcpClient)
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x788356C", Offset = "0x787F56C", VA = "0x788356C")]
		private void RaiseClientDisconnected(TcpClient tcpClient)
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x7883B00", Offset = "0x787FB00", VA = "0x7883B00")]
		private void GuardRunning()
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x787B620", Offset = "0x7877620", VA = "0x787B620")]
		public void Send(TcpClient tcpClient, byte[] datagram)
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x7883B5C", Offset = "0x787FB5C", VA = "0x7883B5C")]
		public void Send(TcpClient tcpClient, string datagram)
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x7883BA8", Offset = "0x787FBA8", VA = "0x7883BA8")]
		public void SendToAll(byte[] datagram)
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x7883EC0", Offset = "0x787FEC0", VA = "0x7883EC0")]
		public void SendToAll(string datagram)
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x7883F08", Offset = "0x787FF08", VA = "0x7883F08")]
		private void HandleDatagramWritten(IAsyncResult ar)
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x78840FC", Offset = "0x78800FC", VA = "0x78840FC")]
		public void SyncSend(TcpClient tcpClient, byte[] datagram)
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x7884280", Offset = "0x7880280", VA = "0x7884280")]
		public void SyncSend(TcpClient tcpClient, string datagram)
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x78842CC", Offset = "0x78802CC", VA = "0x78842CC")]
		public void SyncSendToAll(byte[] datagram)
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x78845E4", Offset = "0x78805E4", VA = "0x78845E4")]
		public void SyncSendToAll(string datagram)
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x788462C", Offset = "0x788062C", VA = "0x788462C", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x7884698", Offset = "0x7880698", VA = "0x7884698", Slot = "5")]
		protected virtual void Dispose(bool disposing)
		{
		}
	}
}
