using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	[Token(Token = "0x2000DAE")]
	public class CoroutineManager : MonoBehaviour
	{
		[Token(Token = "0x4006055")]
		[FieldOffset(Offset = "0x0")]
		private static CoroutineManager mInstance;

		[Token(Token = "0x17000E79")]
		private static CoroutineManager pInstance
		{
			[Token(Token = "0x60054E8")]
			[Address(RVA = "0x432A33C", Offset = "0x432633C", VA = "0x432A33C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60054E9")]
		[Address(RVA = "0x432A498", Offset = "0x4326498", VA = "0x432A498")]
		private void Awake()
		{
		}

		[Token(Token = "0x60054EA")]
		[Address(RVA = "0x4323DB0", Offset = "0x431FDB0", VA = "0x4323DB0")]
		public static Coroutine Start(IEnumerator coroutine)
		{
			return null;
		}

		[Token(Token = "0x60054EB")]
		[Address(RVA = "0x432A540", Offset = "0x4326540", VA = "0x432A540")]
		public CoroutineManager()
		{
		}
	}
}
