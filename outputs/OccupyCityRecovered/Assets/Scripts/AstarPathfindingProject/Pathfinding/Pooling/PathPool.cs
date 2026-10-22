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
		private static readonly Dictionary<Type, Stack<Path>> pool = new Dictionary<Type, Stack<Path>>();

		[Token(Token = "0x4000B04")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Dictionary<Type, int> totalCreated = new Dictionary<Type, int>();

		[Token(Token = "0x6000ECB")]
		[Address(RVA = "0x44866DC", Offset = "0x44826DC", VA = "0x44866DC")]
		public static void Pool(Path path)
		{
 var internals = (IPathInternals)path;
 if (internals.Pooled) throw new ArgumentException("The path is already pooled.");
 internals.Pooled = true;
 internals.OnEnterPool();
 var type = path.GetType();
 lock (pool) {
  if (!pool.TryGetValue(type, out var paths)) {
   paths = new Stack<Path>();
   pool.Add(type, paths);
  }
  paths.Push(path);
 }
}

		[Token(Token = "0x6000ECC")]
		[Address(RVA = "0x4486A84", Offset = "0x4482A84", VA = "0x4486A84")]
		public static int GetTotalCreated(Type type)
		{
 return totalCreated.TryGetValue(type, out var count) ? count : 0;
}

		[Token(Token = "0x6000ECD")]
		[Address(RVA = "0x4486B24", Offset = "0x4482B24", VA = "0x4486B24")]
		public static int GetSize(Type type)
		{
 return pool.TryGetValue(type, out var paths) ? paths.Count : 0;
}

		[Token(Token = "0x6000ECE")]
		public static T GetPath<T>() where T : Path, new()
		{
 T result;
 lock (pool) {
  var type = typeof(T);
  if (pool.TryGetValue(type, out var paths) && paths.Count > 0) {
   result = paths.Pop() as T;
  } else {
   result = new T();
   if (!totalCreated.ContainsKey(type)) totalCreated[type] = 0;
   totalCreated[type] = unchecked(totalCreated[type] + 1);
  }
 }
 var internals = (IPathInternals)result;
 internals.Pooled = false;
 internals.Reset();
 return result;
}
	}
}
