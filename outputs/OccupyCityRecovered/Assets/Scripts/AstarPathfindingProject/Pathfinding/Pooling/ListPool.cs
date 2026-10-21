using System.Collections.Generic;
using Il2CppDummyDll;

namespace Pathfinding.Pooling
{
	[Token(Token = "0x2000255")]
	public static class ListPool<T>
	{
		[Token(Token = "0x4000AFB")]
		[FieldOffset(Offset = "0x0")]
		private static readonly List<List<T>> pool = new List<List<T>>();

		[Token(Token = "0x4000AFC")]
		[FieldOffset(Offset = "0x0")]
		private static readonly List<List<T>> largePool = new List<List<T>>();

		[Token(Token = "0x4000AFD")]
		[FieldOffset(Offset = "0x0")]
		private static readonly HashSet<List<T>> inPool = new HashSet<List<T>>();

		[Token(Token = "0x4000AFE")]
		private const int MaxCapacitySearchLength = 8;

		[Token(Token = "0x4000AFF")]
		private const int LargeThreshold = 5000;

		[Token(Token = "0x4000B00")]
		private const int MaxLargePoolSize = 8;

		[Token(Token = "0x6000EBA")]
		public static List<T> Claim()
		{
 lock (pool) {
  if (pool.Count==0) return new List<T>();
  var result=pool[pool.Count-1];
  pool.RemoveAt(pool.Count-1);
  inPool.Remove(result);
  return result;
 }
}

		[Token(Token = "0x6000EBB")]
		private static int FindCandidate(List<List<T>> pool, int capacity)
		{
 List<T> best=null; int result=-1; int maximum=unchecked(capacity*16);
 for (int i=0;i<8 && i<pool.Count;i++) {
  int index=unchecked(pool.Count-1-i);
  var candidate=pool[index];
  if (best==null || candidate.Capacity>best.Capacity) {
   if (candidate.Capacity<maximum) {
    if (candidate.Capacity>=capacity) return index;
    result=index; best=candidate;
   }
  }
 }
 return result;
}

		[Token(Token = "0x6000EBC")]
		public static List<T> Claim(int capacity)
		{
 lock (pool) {
  var selected=pool;
  int index=FindCandidate(pool,capacity);
  if (capacity>5000) {
   int largeIndex=FindCandidate(largePool,capacity);
   if (largeIndex!=-1) { selected=largePool; index=largeIndex; }
  }
  if (index==-1) return new List<T>(capacity);
  var result=selected[index];
  inPool.Remove(result);
  selected[index]=selected[selected.Count-1];
  selected.RemoveAt(selected.Count-1);
  return result;
 }
}

		[Token(Token = "0x6000EBD")]
		public static void Warmup(int count, int size)
		{
		}

		[Token(Token = "0x6000EBE")]
		public static void Release(ref List<T> list)
		{ Release(list); list=null; }

		[Token(Token = "0x6000EBF")]
		public static void Release(List<T> list)
		{
 list.ClearFast();
 lock (pool) {
  if (list.Capacity>5000) { largePool.Add(list); if (largePool.Count>8) largePool.RemoveAt(0); }
  else pool.Add(list);
 }
}

		[Token(Token = "0x6000EC0")]
		public static void Clear()
		{ lock (pool) pool.Clear(); }

		[Token(Token = "0x6000EC1")]
		public static int GetSize()
		{ return pool.Count; }
	}
}
