using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Pathfinding.Serialization
{
	[Token(Token = "0x200024A")]
	public class GraphMeta
	{
		[Token(Token = "0x4000AE5")]
		[FieldOffset(Offset = "0x10")]
		public Version version;

		[Token(Token = "0x4000AE6")]
		[FieldOffset(Offset = "0x18")]
		public int graphs;

		[Token(Token = "0x4000AE7")]
		[FieldOffset(Offset = "0x20")]
		public List<string> guids;

		[Token(Token = "0x4000AE8")]
		[FieldOffset(Offset = "0x28")]
		public List<string> typeNames;

		[Token(Token = "0x6000E90")]
		[Address(RVA = "0x4480AD8", Offset = "0x447CAD8", VA = "0x4480AD8")]
		public Type GetGraphType(int index, Type[] availableGraphTypes)
		{
			return null;
		}

		[Token(Token = "0x6000E91")]
		[Address(RVA = "0x447E61C", Offset = "0x447A61C", VA = "0x447E61C")]
		public GraphMeta()
		{
		}
	}
}
