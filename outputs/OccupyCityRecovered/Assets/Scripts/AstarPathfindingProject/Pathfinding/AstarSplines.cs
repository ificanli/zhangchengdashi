using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	[Token(Token = "0x200004F")]
	public static class AstarSplines
	{
		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x446344C", Offset = "0x445F44C", VA = "0x446344C")]
		public static Vector3 CatmullRom(Vector3 previous, Vector3 start, Vector3 end, Vector3 next, float elapsedTime)
		{
			return default;
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x4463504", Offset = "0x445F504", VA = "0x4463504")]
		public static Vector3 CubicBezier(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float t)
		{
			return default;
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x44635B0", Offset = "0x445F5B0", VA = "0x44635B0")]
		public static Vector3 CubicBezierDerivative(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float t)
		{
			return default;
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x4463660", Offset = "0x445F660", VA = "0x4463660")]
		public static Vector3 CubicBezierSecondDerivative(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float t)
		{
			return default;
		}
	}
}
