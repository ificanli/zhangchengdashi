using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding.Util
{
	[Token(Token = "0x2000294")]
	public static class UnityCompatibility
	{
		[Token(Token = "0x6001055")]
		public static T[] FindObjectsByTypeSorted<T>() where T : Object
		{
			return null;
		}

		[Token(Token = "0x6001056")]
		public static T[] FindObjectsByTypeUnsorted<T>() where T : Object
		{
			return null;
		}

		[Token(Token = "0x6001057")]
		public static T[] FindObjectsByTypeUnsortedWithInactive<T>() where T : Object
		{
			return null;
		}

		[Token(Token = "0x6001058")]
		public static T FindAnyObjectByType<T>() where T : Object
		{
			return null;
		}
	}
}
