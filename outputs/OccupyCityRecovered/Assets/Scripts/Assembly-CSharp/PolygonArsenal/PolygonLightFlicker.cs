using Il2CppDummyDll;
using UnityEngine;

namespace PolygonArsenal
{
	[Token(Token = "0x2000CB0")]
	public class PolygonLightFlicker : MonoBehaviour
	{
		[Token(Token = "0x4005B19")]
		[FieldOffset(Offset = "0x20")]
		public string waveFunction;

		[Token(Token = "0x4005B1A")]
		[FieldOffset(Offset = "0x28")]
		public float startValue;

		[Token(Token = "0x4005B1B")]
		[FieldOffset(Offset = "0x2C")]
		public float amplitude;

		[Token(Token = "0x4005B1C")]
		[FieldOffset(Offset = "0x30")]
		public float phase;

		[Token(Token = "0x4005B1D")]
		[FieldOffset(Offset = "0x34")]
		public float frequency;

		[Token(Token = "0x4005B1E")]
		[FieldOffset(Offset = "0x38")]
		private Color originalColor;

		[Token(Token = "0x6004FB9")]
		[Address(RVA = "0x42B99E0", Offset = "0x42B59E0", VA = "0x42B99E0")]
		private void Start()
		{
		}

		[Token(Token = "0x6004FBA")]
		[Address(RVA = "0x42B9A44", Offset = "0x42B5A44", VA = "0x42B9A44")]
		private void Update()
		{
		}

		[Token(Token = "0x6004FBB")]
		[Address(RVA = "0x42B9B04", Offset = "0x42B5B04", VA = "0x42B9B04")]
		private float EvalWave()
		{
			return default;
		}

		[Token(Token = "0x6004FBC")]
		[Address(RVA = "0x42B9CD4", Offset = "0x42B5CD4", VA = "0x42B9CD4")]
		public PolygonLightFlicker()
		{
		}
	}
}
