using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BrainFailProductions.PolyFew
{
	[Serializable]
	[Token(Token = "0x2000CC5")]
	public class ToleranceSphere : ScriptableObject
	{
		[Token(Token = "0x4005B8C")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 worldPosition;

		[Token(Token = "0x4005B8D")]
		[FieldOffset(Offset = "0x24")]
		public float diameter;

		[Token(Token = "0x4005B8E")]
		[FieldOffset(Offset = "0x28")]
		public Color color;

		[Token(Token = "0x4005B8F")]
		[FieldOffset(Offset = "0x38")]
		public float preservationStrength;

		[Token(Token = "0x4005B90")]
		[FieldOffset(Offset = "0x3C")]
		public bool isHidden;

		[Token(Token = "0x600500A")]
		[Address(RVA = "0x42BC840", Offset = "0x42B8840", VA = "0x42BC840")]
		public ToleranceSphere(Vector3 worldPosition, float diameter, Color color, float preservationStrength, bool isHidden = false)
		{
		}

		[Token(Token = "0x600500B")]
		[Address(RVA = "0x42BC8C4", Offset = "0x42B88C4", VA = "0x42BC8C4")]
		public void SetProperties(ToleranceSphereJson tSphereJson)
		{
		}

		[Token(Token = "0x600500C")]
		[Address(RVA = "0x42BC908", Offset = "0x42B8908", VA = "0x42BC908")]
		public void SetProperties(Vector3 worldPosition, float diameter, Color color, float preservationStrength, bool isHidden = false)
		{
		}
	}
}
