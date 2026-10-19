using Il2CppDummyDll;
using UnityEngine;

namespace ToonyColorsPro
{
	[Token(Token = "0x2000006")]
	public class TCP2_Demo_Interactive_Content : MonoBehaviour
	{
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x20")]
		public Transform pivot;

		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x28")]
		public Transform textBox;

		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x30")]
		[Space]
		[TextArea]
		public string Text;

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x7D64330", Offset = "0x7D60330", VA = "0x7D64330")]
		public TCP2_Demo_Interactive_Content()
		{
		}
	}
}
