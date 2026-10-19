using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Pathfinding.Pooling
{
	[Token(Token = "0x2000259")]
	public static class PathPool
	{
		[Token(Token = "0x4000B03")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<Type, Stack<Path>> pool;

		[Token(Token = "0x4000B04")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Dictionary<Type, int> totalCreated;

		[Token(Token = "0x6000ECB")]
		[Address(RVA = "0x44866DC", Offset = "0x44826DC", VA = "0x44866DC")]
		public static void Pool(Path path)
		{
		}

		[Token(Token = "0x6000ECC")]
		[Address(RVA = "0x4486A84", Offset = "0x4482A84", VA = "0x4486A84")]
		public static int GetTotalCreated(Type type)
		{
			return default;
		}

		[Token(Token = "0x6000ECD")]
		[Address(RVA = "0x4486B24", Offset = "0x4482B24", VA = "0x4486B24")]
		public static int GetSize(Type type)
		{
			return default;
		}

		[Token(Token = "0x6000ECE")]
		public static T GetPath<T>() where T : Path, new()
		{
			return null;
		}
	}
}
