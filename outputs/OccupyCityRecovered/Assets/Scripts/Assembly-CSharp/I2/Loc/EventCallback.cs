using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	[Serializable]
	[Token(Token = "0x2000D5D")]
	public class EventCallback
	{
		[Token(Token = "0x4005F35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MonoBehaviour Target;

		[Token(Token = "0x4005F36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string MethodName;

		[Token(Token = "0x60052AE")]
		[Address(RVA = "0x4304000", Offset = "0x4300000", VA = "0x4304000")]
		public void Execute([Optional] UnityEngine.Object Sender)
		{
		}

		[Token(Token = "0x60052AF")]
		[Address(RVA = "0x43040A0", Offset = "0x43000A0", VA = "0x43040A0")]
		public bool HasCallback()
		{
			return default;
		}

		[Token(Token = "0x60052B0")]
		[Address(RVA = "0x4304124", Offset = "0x4300124", VA = "0x4304124")]
		public EventCallback()
		{
		}
	}
}
