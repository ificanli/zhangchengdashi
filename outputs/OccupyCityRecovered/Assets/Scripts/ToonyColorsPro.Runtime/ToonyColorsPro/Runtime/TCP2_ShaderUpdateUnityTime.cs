using Il2CppDummyDll;
using UnityEngine;

namespace ToonyColorsPro.Runtime
{
	[Token(Token = "0x2000009")]
	public class TCP2_ShaderUpdateUnityTime : MonoBehaviour
	{
		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int UnityTime;

		[Token(Token = "0x4000046")]
		[FieldOffset(Offset = "0x4")]
		private static readonly int CustomTime;

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x7D63E70", Offset = "0x7D5FE70", VA = "0x7D63E70")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x7D63F48", Offset = "0x7D5FF48", VA = "0x7D63F48")]
		public TCP2_ShaderUpdateUnityTime()
		{
		}
	}
}
