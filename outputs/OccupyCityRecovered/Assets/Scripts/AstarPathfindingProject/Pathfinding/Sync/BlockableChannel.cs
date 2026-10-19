using System.Runtime.CompilerServices;
using System.Threading;
using Il2CppDummyDll;
using Pathfinding.Collections;

namespace Pathfinding.Sync
{
	[Token(Token = "0x2000237")]
	internal class BlockableChannel<T> where T : class
	{
		[Token(Token = "0x2000238")]
		public enum PopState
		{
			[Token(Token = "0x4000AA3")]
			Ok = 0,
			[Token(Token = "0x4000AA4")]
			Wait = 1,
			[Token(Token = "0x4000AA5")]
			Closed = 2
		}

		[Token(Token = "0x2000239")]
		public struct Receiver
		{
			[Token(Token = "0x4000AA6")]
			[FieldOffset(Offset = "0x0")]
			private BlockableChannel<T> channel;

			[Token(Token = "0x6000E31")]
			public Receiver(BlockableChannel<T> channel)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED BlockableChannel.Receiver..ctor RVA= Token=0x6000E31");
}

			[Token(Token = "0x6000E32")]
			public void Close()
			{
			}

			[Token(Token = "0x6000E33")]
			public PopState Receive(out T item)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED BlockableChannel.Receiver.Receive RVA= Token=0x6000E33");
}

			[Token(Token = "0x6000E34")]
			public PopState ReceiveNoBlock(bool blockedBefore, out T item)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED BlockableChannel.Receiver.ReceiveNoBlock RVA= Token=0x6000E34");
}
		}

		[Token(Token = "0x4000A9B")]
		[FieldOffset(Offset = "0x0")]
		private readonly object lockObj;

		[Token(Token = "0x4000A9C")]
		[FieldOffset(Offset = "0x0")]
		private CircularBuffer<T> queue;

		[Token(Token = "0x4000A9E")]
		[FieldOffset(Offset = "0x0")]
		private int waitingReceivers;

		[Token(Token = "0x4000A9F")]
		[FieldOffset(Offset = "0x0")]
		private ManualResetEvent starving;

		[Token(Token = "0x4000AA0")]
		[FieldOffset(Offset = "0x0")]
		private bool blocked;

		[Token(Token = "0x17000222")]
		public int numReceivers
		{
			[Token(Token = "0x6000E21")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x6000E22")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000223")]
		public bool isClosed
		{
			[Token(Token = "0x6000E23")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x6000E24")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000224")]
		public bool isEmpty
		{
			[Token(Token = "0x6000E25")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000225")]
		public bool allReceiversBlocked
		{
			[Token(Token = "0x6000E26")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000226")]
		public bool isBlocked
		{
			[Token(Token = "0x6000E27")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000E28")]
			set
			{
			}
		}

		[Token(Token = "0x17000227")]
		private bool isStarving
		{
			[Token(Token = "0x6000E2A")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000E2B")]
			set
			{
			}
		}

		[Token(Token = "0x6000E29")]
		public void Close()
		{
		}

		[Token(Token = "0x6000E2C")]
		public void Reopen()
		{
		}

		[Token(Token = "0x6000E2D")]
		public Receiver AddReceiver()
		{
			return default;
		}

		[Token(Token = "0x6000E2E")]
		public void PushFront(T path)
		{
		}

		[Token(Token = "0x6000E2F")]
		public void Push(T path)
		{
		}

		[Token(Token = "0x6000E30")]
		public BlockableChannel()
		{
		}
	}
}
