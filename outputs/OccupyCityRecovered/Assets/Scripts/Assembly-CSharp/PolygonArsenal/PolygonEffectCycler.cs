using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace PolygonArsenal
{
	[Token(Token = "0x2000CA6")]
	public class PolygonEffectCycler : MonoBehaviour
	{
		[Token(Token = "0x4005ACA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<GameObject> listOfEffects;

		[Token(Token = "0x4005ACB")]
		[FieldOffset(Offset = "0x28")]
		[Header("Loop length in seconds")]
		[SerializeField]
		private float loopTimeLength;

		[Token(Token = "0x4005ACC")]
		[FieldOffset(Offset = "0x2C")]
		private float timeOfLastInstantiate;

		[Token(Token = "0x4005ACD")]
		[FieldOffset(Offset = "0x30")]
		private GameObject instantiatedEffect;

		[Token(Token = "0x4005ACE")]
		[FieldOffset(Offset = "0x38")]
		private int effectIndex;

		[Token(Token = "0x6004F53")]
		[Address(RVA = "0x42B4C94", Offset = "0x42B0C94", VA = "0x42B4C94")]
		private void Start()
		{
		}

		[Token(Token = "0x6004F54")]
		[Address(RVA = "0x42B4DE0", Offset = "0x42B0DE0", VA = "0x42B4DE0")]
		private void Update()
		{
		}

		[Token(Token = "0x6004F55")]
		[Address(RVA = "0x42B4F5C", Offset = "0x42B0F5C", VA = "0x42B4F5C")]
		public PolygonEffectCycler()
		{
		}
	}
}
