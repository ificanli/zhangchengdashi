using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	[Token(Token = "0x2000139")]
	public class FleePath : RandomPath
	{
		[Token(Token = "0x6000A29")]
		[Address(RVA = "0x4561934", Offset = "0x455D934", VA = "0x4561934")]
		public FleePath()
		{
		}

		[Token(Token = "0x6000A2A")]
		[Address(RVA = "0x456193C", Offset = "0x455D93C", VA = "0x456193C")]
		public static FleePath Construct(Vector3 start, Vector3 avoid, int searchLength, [Optional] OnPathDelegate callback)
		{
			return null;
		}

		[Token(Token = "0x6000A2B")]
		[Address(RVA = "0x4561A18", Offset = "0x455DA18", VA = "0x4561A18")]
		protected void Setup(Vector3 start, Vector3 avoid, int searchLength, OnPathDelegate callback)
		{
		}
	}
}
