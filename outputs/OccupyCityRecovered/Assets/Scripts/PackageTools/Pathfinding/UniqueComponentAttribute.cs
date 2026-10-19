using System;
using Il2CppDummyDll;

namespace Pathfinding
{
	[Token(Token = "0x2000005")]
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
	public class UniqueComponentAttribute : Attribute
	{
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x10")]
		public string tag;

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x7838008", Offset = "0x7834008", VA = "0x7838008")]
		public UniqueComponentAttribute()
		{
		}
	}
}
