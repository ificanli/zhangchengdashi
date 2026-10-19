using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace ToolModule
{
	[Token(Token = "0x20001A9")]
	public class TimeToolMono : MonoBehaviour
	{
		[Token(Token = "0x4001AD7")]
		[FieldOffset(Offset = "0x0")]
		private static TimeToolMono _instance;

		[Token(Token = "0x17000099")]
		public static TimeToolMono Inst
		{
			[Token(Token = "0x60006D1")]
			[Address(RVA = "0x3F82BE8", Offset = "0x3F7EBE8", VA = "0x3F82BE8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x3F8315C", Offset = "0x3F7F15C", VA = "0x3F8315C")]
		public Coroutine StartRoutine(IEnumerator routine)
		{
			return null;
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x3F83164", Offset = "0x3F7F164", VA = "0x3F83164")]
		public void StopRoutine(Coroutine routine)
		{
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x3F8316C", Offset = "0x3F7F16C", VA = "0x3F8316C")]
		public TimeToolMono()
		{
		}
	}
}
