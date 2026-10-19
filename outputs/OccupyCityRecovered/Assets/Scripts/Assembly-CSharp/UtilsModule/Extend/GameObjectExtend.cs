using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UtilsModule.Extend
{
	[Token(Token = "0x2000208")]
	public static class GameObjectExtend
	{
		[Token(Token = "0x6000871")]
		[Address(RVA = "0x41905E4", Offset = "0x418C5E4", VA = "0x41905E4")]
		public static bool SetActiveLight(this GameObject gameObject, bool active)
		{
			return default;
		}

		[Token(Token = "0x6000872")]
		[Address(RVA = "0x419062C", Offset = "0x418C62C", VA = "0x419062C")]
		public static void OnDestroy(this GameObject gameObject, Action onDestroy)
		{
		}
	}
}
