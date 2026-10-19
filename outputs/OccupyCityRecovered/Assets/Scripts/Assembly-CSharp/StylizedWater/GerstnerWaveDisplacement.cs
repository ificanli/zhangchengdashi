using Il2CppDummyDll;
using UnityEngine;

namespace StylizedWater
{
	[Token(Token = "0x2000F03")]
	public static class GerstnerWaveDisplacement
	{
		[Token(Token = "0x6005A5B")]
		[Address(RVA = "0x4391F50", Offset = "0x438DF50", VA = "0x4391F50")]
		private static Vector3 GerstnerWave(Vector3 position, float steepness, float wavelength, float speed, float direction)
		{
			return default;
		}

		[Token(Token = "0x6005A5C")]
		[Address(RVA = "0x43920AC", Offset = "0x438E0AC", VA = "0x43920AC")]
		public static Vector3 GetWaveDisplacement(Vector3 position, float steepness, float wavelength, float speed, float[] directions)
		{
			return default;
		}
	}
}
