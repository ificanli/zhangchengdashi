using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Pathfinding.Clipper2Lib
{
	[Token(Token = "0x2000038")]
	internal class GCArena<T> where T : class, IDisposable, new()
	{
		[Token(Token = "0x40000C8")]
		[FieldOffset(Offset = "0x0")]
		private List<T> arena;

		[Token(Token = "0x40000C9")]
		[FieldOffset(Offset = "0x0")]
		private int index;

		[Token(Token = "0x60001DF")]
		public void Reclaim()
		{
		}

		[Token(Token = "0x60001E0")]
		public T Get()
		{
			return null;
		}

		[Token(Token = "0x60001E1")]
		public GCArena()
		{
		}
	}
}
