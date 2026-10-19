using Il2CppDummyDll;
using Unity.Collections;

namespace andywiecko.BurstTriangulator.LowLevel.Unsafe
{
	[Token(Token = "0x2000026")]
	internal interface ITransform<TSelf, T, T2> where T : unmanaged where T2 : unmanaged
	{
		[Token(Token = "0x17000029")]
		T AreaScalingFactor
		{
			[Token(Token = "0x60000C6")]
			get;
		}

		[Token(Token = "0x1700002A")]
		TSelf Identity
		{
			[Token(Token = "0x60000C7")]
			get;
		}

		[Token(Token = "0x60000C8")]
		TSelf Inverse();

		[Token(Token = "0x60000C9")]
		T2 Transform(T2 point);

		[Token(Token = "0x60000CA")]
		TSelf CalculatePCATransformation(NativeArray<T2> positions);

		[Token(Token = "0x60000CB")]
		TSelf CalculateLocalTransformation(NativeArray<T2> positions);
	}
}
