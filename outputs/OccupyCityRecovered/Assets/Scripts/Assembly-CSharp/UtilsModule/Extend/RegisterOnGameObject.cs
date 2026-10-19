using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UtilsModule.Extend
{
	[Token(Token = "0x2000209")]
	public class RegisterOnGameObject : MonoBehaviour
	{
		[Token(Token = "0x4001CF4")]
		[FieldOffset(Offset = "0x20")]
		public Action onDestroy;

		[Token(Token = "0x6000873")]
		[Address(RVA = "0x419071C", Offset = "0x418C71C", VA = "0x419071C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000874")]
		[Address(RVA = "0x4190798", Offset = "0x418C798", VA = "0x4190798")]
		public RegisterOnGameObject()
		{
		}
	}
}
