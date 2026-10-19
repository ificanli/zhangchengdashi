using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace StylizedWater
{
	[Token(Token = "0x2000007")]
	public class CausticsPass : ScriptableRenderPass
	{
		[Token(Token = "0x4000025")]
		private const string profilerTag = "Caustics Pass";

		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0xE0")]
		public Material causticsMaterial;

		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x0")]
		private static Mesh mesh;

		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0xE8")]
		private float waterLevel;

		[Token(Token = "0x4000029")]
		private const float BIAS = 0.1f;

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x78F5004", Offset = "0x78F1004", VA = "0x78F5004")]
		public CausticsPass(float waterLevel)
		{
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x78F53D8", Offset = "0x78F13D8", VA = "0x78F53D8", Slot = "9")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x78F5864", Offset = "0x78F1864", VA = "0x78F5864")]
		private static Mesh GenerateQuad(float size)
		{
			return null;
		}
	}
}
