using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Il2CppDummyDll;

namespace FishFlock
{
	[Token(Token = "0x2000DDF")]
	public class ThreadProcess
	{
		[Token(Token = "0x4006150")]
		[FieldOffset(Offset = "0x10")]
		private bool running;

		[Token(Token = "0x4006151")]
		[FieldOffset(Offset = "0x18")]
		private Action callback;

		[Token(Token = "0x17000EA5")]
		public AutoResetEvent AutoEvt
		{
			[Token(Token = "0x600560F")]
			[Address(RVA = "0x433A384", Offset = "0x4336384", VA = "0x433A384")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005610")]
			[Address(RVA = "0x433A38C", Offset = "0x433638C", VA = "0x433A38C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6005611")]
		[Address(RVA = "0x433A230", Offset = "0x4336230", VA = "0x433A230")]
		internal ThreadProcess(Action _callback)
		{
		}

		[Token(Token = "0x6005612")]
		[Address(RVA = "0x433A394", Offset = "0x4336394", VA = "0x433A394")]
		private void DoRun()
		{
		}

		[Token(Token = "0x6005613")]
		[Address(RVA = "0x433A228", Offset = "0x4336228", VA = "0x433A228")]
		public void Stop()
		{
		}
	}
}
