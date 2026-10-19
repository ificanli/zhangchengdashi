using Il2CppDummyDll;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	[Token(Token = "0x2000123")]
	public class MB3_Comment : MonoBehaviour
	{
		[Token(Token = "0x4000466")]
		[FieldOffset(Offset = "0x20")]
		[Multiline]
		public string comment;

		[Token(Token = "0x6000630")]
		[Address(RVA = "0x74B1300", Offset = "0x74AD300", VA = "0x74B1300")]
		public MB3_Comment()
		{
		}
	}
}
