using Il2CppDummyDll;
using UnityEngine;

namespace AllIn1VfxToolkit
{
	[Token(Token = "0x2000009")]
	public class All1VfxRandomTimeSeed : MonoBehaviour
	{
		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float minSeedValue;

		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float maxSeedValue;

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x3CEBF64", Offset = "0x3CE7F64", VA = "0x3CEBF64")]
		private void Start()
		{
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x3CEC01C", Offset = "0x3CE801C", VA = "0x3CEC01C")]
		public All1VfxRandomTimeSeed()
		{
		}
	}
}
