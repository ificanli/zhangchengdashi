using Il2CppDummyDll;
using UnityEngine;

namespace FishFlock.Utils
{
	[Token(Token = "0x2000DE1")]
	public class MinMaxAttribute : PropertyAttribute
	{
		[Token(Token = "0x4006153")]
		[FieldOffset(Offset = "0x10")]
		public float Min;

		[Token(Token = "0x4006154")]
		[FieldOffset(Offset = "0x14")]
		public float Max;

		[Token(Token = "0x6005618")]
		[Address(RVA = "0x433A414", Offset = "0x4336414", VA = "0x433A414")]
		public MinMaxAttribute(float min, float max)
		{
		}
	}
}
