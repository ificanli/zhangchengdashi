using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	[Token(Token = "0x200013F")]
	[Obsolete("Use an ABPath with the ABPath.endingCondition field instead")]
	public class XPath : ABPath
	{
		[Token(Token = "0x6000A62")]
		[Address(RVA = "0x4564AD4", Offset = "0x4560AD4", VA = "0x4564AD4")]
		[Obsolete("Use ABPath.Construct instead")]
		public new static ABPath Construct(Vector3 start, Vector3 end, [Optional] OnPathDelegate callback)
		{
			return null;
		}

		[Token(Token = "0x6000A63")]
		[Address(RVA = "0x4564ADC", Offset = "0x4560ADC", VA = "0x4564ADC")]
		public XPath()
		{
		}
	}
}
