using Il2CppDummyDll;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	[Token(Token = "0x20000C0")]
	public class MB_BlendShape2CombinedMap : MonoBehaviour
	{
		[Token(Token = "0x40002DA")]
		[FieldOffset(Offset = "0x20")]
		public SerializableSourceBlendShape2Combined srcToCombinedMap;

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x748489C", Offset = "0x748089C", VA = "0x748489C")]
		public SerializableSourceBlendShape2Combined GetMap()
		{
			return null;
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x7484908", Offset = "0x7480908", VA = "0x7484908")]
		public MB_BlendShape2CombinedMap()
		{
		}
	}
}
