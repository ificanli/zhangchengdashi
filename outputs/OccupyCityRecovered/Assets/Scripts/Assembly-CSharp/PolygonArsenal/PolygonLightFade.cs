using Il2CppDummyDll;
using UnityEngine;

namespace PolygonArsenal
{
	[Token(Token = "0x2000CAF")]
	public class PolygonLightFade : MonoBehaviour
	{
		[Token(Token = "0x4005B15")]
		[FieldOffset(Offset = "0x20")]
		[Header("Seconds to dim the light")]
		public float life;

		[Token(Token = "0x4005B16")]
		[FieldOffset(Offset = "0x24")]
		public bool killAfterLife;

		[Token(Token = "0x4005B17")]
		[FieldOffset(Offset = "0x28")]
		private Light li;

		[Token(Token = "0x4005B18")]
		[FieldOffset(Offset = "0x30")]
		private float initIntensity;

		[Token(Token = "0x6004FB6")]
		[Address(RVA = "0x42B9780", Offset = "0x42B5780", VA = "0x42B9780")]
		private void Start()
		{
		}

		[Token(Token = "0x6004FB7")]
		[Address(RVA = "0x42B9888", Offset = "0x42B5888", VA = "0x42B9888")]
		private void Update()
		{
		}

		[Token(Token = "0x6004FB8")]
		[Address(RVA = "0x42B99C4", Offset = "0x42B59C4", VA = "0x42B99C4")]
		public PolygonLightFade()
		{
		}
	}
}
