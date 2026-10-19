using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Collections;

namespace andywiecko.BurstTriangulator
{
	[Token(Token = "0x200000D")]
	public class InputData<T2> where T2 : unmanaged
	{
		[Token(Token = "0x17000016")]
		public NativeArray<T2> Positions
		{
			[Token(Token = "0x6000032")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x6000033")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000017")]
		public NativeArray<int> ConstraintEdges
		{
			[Token(Token = "0x6000034")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x6000035")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000018")]
		public NativeArray<ConstraintType> ConstraintEdgeTypes
		{
			[Token(Token = "0x6000036")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x6000037")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000019")]
		public NativeArray<T2> HoleSeeds
		{
			[Token(Token = "0x6000038")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x6000039")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x600003A")]
		public InputData()
		{
		}
	}
}
