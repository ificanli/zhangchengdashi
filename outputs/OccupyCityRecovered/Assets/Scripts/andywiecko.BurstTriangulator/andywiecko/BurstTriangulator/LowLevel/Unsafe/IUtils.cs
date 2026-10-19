using Il2CppDummyDll;
using Unity.Mathematics;

namespace andywiecko.BurstTriangulator.LowLevel.Unsafe
{
	[Token(Token = "0x200002A")]
	internal interface IUtils<T, T2, TBig> where T : unmanaged where T2 : unmanaged where TBig : unmanaged
	{
		[Token(Token = "0x60000ED")]
		T Cast(TBig v);

		[Token(Token = "0x60000EE")]
		T2 CircumCenter(T2 a, T2 b, T2 c);

		[Token(Token = "0x60000EF")]
		T Const(float v);

		[Token(Token = "0x60000F0")]
		TBig EPSILON();

		[Token(Token = "0x60000F1")]
		bool InCircle(T2 a, T2 b, T2 c, T2 p);

		[Token(Token = "0x60000F2")]
		TBig MaxValue();

		[Token(Token = "0x60000F3")]
		T2 MaxValue2();

		[Token(Token = "0x60000F4")]
		T2 MinValue2();

		[Token(Token = "0x60000F5")]
		bool PointInsideTriangle(T2 p, T2 a, T2 b, T2 c);

		[Token(Token = "0x60000F6")]
		bool SupportsRefinement();

		[Token(Token = "0x60000F7")]
		T X(T2 v);

		[Token(Token = "0x60000F8")]
		T Y(T2 v);

		[Token(Token = "0x60000F9")]
		T Zero();

		[Token(Token = "0x60000FA")]
		TBig ZeroTBig();

		[Token(Token = "0x60000FB")]
		T abs(T v);

		[Token(Token = "0x60000FC")]
		TBig abs(TBig v);

		[Token(Token = "0x60000FD")]
		T alpha(T concentricShellReferenceRadius, T dSquare);

		[Token(Token = "0x60000FE")]
		bool anygreaterthan(T a, T b, T c, T v);

		[Token(Token = "0x60000FF")]
		T2 avg(T2 a, T2 b);

		[Token(Token = "0x6000100")]
		T cos(T v);

		[Token(Token = "0x6000101")]
		T diff(T a, T b);

		[Token(Token = "0x6000102")]
		TBig diff(TBig a, TBig b);

		[Token(Token = "0x6000103")]
		T2 diff(T2 a, T2 b);

		[Token(Token = "0x6000104")]
		TBig distancesq(T2 a, T2 b);

		[Token(Token = "0x6000105")]
		T dot(T2 a, T2 b);

		[Token(Token = "0x6000106")]
		bool2 eq(T2 v, T2 w);

		[Token(Token = "0x6000107")]
		bool2 ge(T2 a, T2 b);

		[Token(Token = "0x6000108")]
		bool greater(T a, T b);

		[Token(Token = "0x6000109")]
		bool greater(TBig a, TBig b);

		[Token(Token = "0x600010A")]
		int hashkey(T2 p, T2 c, int hashSize);

		[Token(Token = "0x600010B")]
		bool2 isfinite(T2 v);

		[Token(Token = "0x600010C")]
		bool le(T a, T b);

		[Token(Token = "0x600010D")]
		bool le(TBig a, TBig b);

		[Token(Token = "0x600010E")]
		bool2 le(T2 a, T2 b);

		[Token(Token = "0x600010F")]
		T2 lerp(T2 a, T2 b, T v);

		[Token(Token = "0x6000110")]
		bool less(TBig a, TBig b);

		[Token(Token = "0x6000111")]
		T2 max(T2 v, T2 w);

		[Token(Token = "0x6000112")]
		T2 min(T2 v, T2 w);

		[Token(Token = "0x6000113")]
		TBig mul(T a, T b);

		[Token(Token = "0x6000114")]
		T2 neg(T2 v);

		[Token(Token = "0x6000115")]
		T2 normalizesafe(T2 v);
	}
}
