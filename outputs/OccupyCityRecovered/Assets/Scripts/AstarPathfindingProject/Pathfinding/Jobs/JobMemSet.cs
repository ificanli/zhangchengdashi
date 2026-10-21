using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;

namespace Pathfinding.Jobs
{
	[Token(Token = "0x2000179")]
	[BurstCompile]
	public struct JobMemSet<T> : IJob where T : struct
	{
		[Token(Token = "0x4000786")]
		[FieldOffset(Offset = "0x0")]
		[WriteOnly]
		public NativeArray<T> data;

		[Token(Token = "0x4000787")]
		[FieldOffset(Offset = "0x0")]
		public T value;

		[Token(Token = "0x6000B9D")]
		public void Execute()
		{
 unsafe {
  void* pointer=Unity.Collections.LowLevel.Unsafe.NativeArrayUnsafeUtility.GetUnsafePtr(data);
  int length=data.Length;
  if (length<0) throw new System.ArgumentOutOfRangeException();
  if (pointer==null && length!=0) throw new System.ArgumentNullException();
  T element=value;
  if (length!=0) {
   int size=Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>();
   if ((uint)length>int.MaxValue/size) throw new System.ArgumentException("Span is too large to fill");
   Unity.Collections.LowLevel.Unsafe.UnsafeUtility.MemCpyReplicate(pointer,Unity.Collections.LowLevel.Unsafe.UnsafeUtility.AddressOf(ref element),size,length);
  }
 }
}
	}
}
