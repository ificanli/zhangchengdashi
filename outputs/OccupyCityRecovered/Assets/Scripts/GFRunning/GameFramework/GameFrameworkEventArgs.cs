using System;
using Il2CppDummyDll;

namespace GameFramework
{
	[Token(Token = "0x2000332")]
	public abstract class GameFrameworkEventArgs : EventArgs
	{
		[Token(Token = "0x60055ED")]
		[Address(RVA = "0x715BF04", Offset = "0x7157F04", VA = "0x715BF04")]
		public GameFrameworkEventArgs()
		{
		}

		[Token(Token = "0x60055EE")]
		public abstract void Clear();
	}
}
