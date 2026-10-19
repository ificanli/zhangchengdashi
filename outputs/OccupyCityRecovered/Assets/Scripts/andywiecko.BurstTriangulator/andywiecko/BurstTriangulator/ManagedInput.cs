using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace andywiecko.BurstTriangulator
{
	[Token(Token = "0x200000E")]
	[Obsolete("Use AsNativeArray(out Handle) instead! You can learn more in the project manual.")]
	public class ManagedInput<T2> where T2 : unmanaged
	{
		[Token(Token = "0x1700001A")]
		public T2[] Positions
		{
			[Token(Token = "0x600003B")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600003C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public int[] ConstraintEdges
		{
			[Token(Token = "0x600003D")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600003E")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public T2[] HoleSeeds
		{
			[Token(Token = "0x600003F")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000040")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000041")]
		public static implicit operator InputData<T2>(ManagedInput<T2> input)
		{
			return null;
		}

		[Token(Token = "0x6000042")]
		public ManagedInput()
		{
		}
	}
}
