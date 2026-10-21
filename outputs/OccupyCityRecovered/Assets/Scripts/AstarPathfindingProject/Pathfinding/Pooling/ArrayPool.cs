using System.Collections.Generic;
using Il2CppDummyDll;

namespace Pathfinding.Pooling
{
	[Token(Token = "0x2000253")]
	public static class ArrayPool<T>
	{
		[Token(Token = "0x4000AF7")]
		private const int MaximumExactArrayLength = 256;

		[Token(Token = "0x4000AF8")]
		[FieldOffset(Offset = "0x0")]
		private static readonly bool containsReferenceTypes;

		[Token(Token = "0x4000AF9")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Stack<T[]>[] pool;

		[Token(Token = "0x4000AFA")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Stack<T[]>[] exactPool;

		[Token(Token = "0x6000EB4")]
		static ArrayPool()
		{
 pool=new Stack<T[]>[31];exactPool=new Stack<T[]>[257];
 var type=typeof(T);containsReferenceTypes=type.IsClass||type.IsInterface||type.IsArray;
 if (!containsReferenceTypes) foreach (var field in type.GetFields(System.Reflection.BindingFlags.Instance|System.Reflection.BindingFlags.Public|System.Reflection.BindingFlags.NonPublic)) {
  var fieldType=field.FieldType;
  if (fieldType.IsClass||fieldType.IsInterface||fieldType.IsArray) { containsReferenceTypes=true;break; }
 }
}

		[Token(Token = "0x6000EB5")]
		public static T[] Claim(int minimumLength)
		{
 if (minimumLength<1) return ClaimWithExactLength(0);
 int exponent=0,size=1;
 while (exponent<=30 && size<minimumLength) { exponent++;size=unchecked(1<<exponent); }
 if (exponent==31) throw new System.ArgumentException("Too high minimum length");
 lock (pool) {
  if (pool[exponent]==null) pool[exponent]=new Stack<T[]>();
  if (pool[exponent].Count>0) return pool[exponent].Pop();
 }
 return new T[size];
}

		[Token(Token = "0x6000EB6")]
		public static T[] ClaimWithExactLength(int length)
		{
 if (length!=0) {
  if ((length&unchecked(length-1))==0) return Claim(length);
  if (length>256) return new T[length];
 }
 lock (pool) { var stack=exactPool[length];if (stack!=null && stack.Count>0) return stack.Pop(); }
 return new T[length];
}

		[Token(Token = "0x6000EB7")]
		public static void Release(ref T[] array, bool allowNonPowerOfTwo = false)
		{
 if (array==null) return;
 if (array.GetType()!=typeof(T[])) throw new System.ArgumentException("Expected array type "+typeof(T[]).Name+" but found "+array.GetType().Name+"\nAre you using the correct generic class?\n");
 int length=array.Length;
 bool exact=length==0 || (length&unchecked(length-1))!=0;
 if (length!=0 && exact && !allowNonPowerOfTwo) throw new System.ArgumentException("Length is not a power of 2");
 if (containsReferenceTypes) System.Array.Clear(array,0,array.Length);
 lock (pool) {
  if (exact) { if (length<=256) { if (exactPool[length]==null) exactPool[length]=new Stack<T[]>();exactPool[length].Push(array); } }
  else { int exponent=0;while ((1<<exponent)<length) exponent++;if (pool[exponent]==null) pool[exponent]=new Stack<T[]>();pool[exponent].Push(array); }
 }
 array=null;
}
	}
}
