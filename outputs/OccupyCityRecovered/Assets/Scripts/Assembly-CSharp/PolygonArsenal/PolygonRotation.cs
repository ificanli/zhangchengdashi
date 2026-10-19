using Il2CppDummyDll;
using UnityEngine;

namespace PolygonArsenal
{
	[Token(Token = "0x2000CB1")]
	public class PolygonRotation : MonoBehaviour
	{
		[Token(Token = "0x2000CB2")]
		public enum spaceEnum
		{
			[Token(Token = "0x4005B22")]
			Local = 0,
			[Token(Token = "0x4005B23")]
			World = 1
		}

		[Token(Token = "0x4005B1F")]
		[FieldOffset(Offset = "0x20")]
		[Header("Rotate axises by degrees per second")]
		public Vector3 rotateVector;

		[Token(Token = "0x4005B20")]
		[FieldOffset(Offset = "0x2C")]
		public spaceEnum rotateSpace;

		[Token(Token = "0x6004FBD")]
		[Address(RVA = "0x42B9D34", Offset = "0x42B5D34", VA = "0x42B9D34")]
		private void Start()
		{
		}

		[Token(Token = "0x6004FBE")]
		[Address(RVA = "0x42B9D38", Offset = "0x42B5D38", VA = "0x42B9D38")]
		private void Update()
		{
		}

		[Token(Token = "0x6004FBF")]
		[Address(RVA = "0x42B9E04", Offset = "0x42B5E04", VA = "0x42B9E04")]
		public PolygonRotation()
		{
		}
	}
}
