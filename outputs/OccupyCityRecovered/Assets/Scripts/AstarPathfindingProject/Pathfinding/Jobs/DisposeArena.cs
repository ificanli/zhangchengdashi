using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Pathfinding.Collections;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace Pathfinding.Jobs
{
	[Token(Token = "0x2000188")]
	public class DisposeArena
	{
		[Token(Token = "0x400079F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<NativeArray<byte>> buffer;

		[Token(Token = "0x40007A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private List<NativeList<byte>> buffer2;

		[Token(Token = "0x40007A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<NativeQueue<byte>> buffer3;

		[Token(Token = "0x40007A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<(IntPtr, AllocatorManager.AllocatorHandle, int, int)> ptrBuffer;

		[Token(Token = "0x40007A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<(IntPtr, Allocator)> ptrBufferTracked;

		[Token(Token = "0x40007A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<GCHandle> gcHandles;

		[Token(Token = "0x6000BB3")]
		public void Add<T>(NativeArray<T> data) where T : struct
		{
 if (buffer==null) buffer=Pathfinding.Pooling.ListPool<NativeArray<byte>>.Claim();
 buffer.Add(UnsafeUtility.As<NativeArray<T>,NativeArray<byte>>(ref data));
}

		[Token(Token = "0x6000BB4")]
		public void Add<T>(NativeList<T> data) where T : unmanaged
		{
		}

		[Token(Token = "0x6000BB5")]
		public void Add<T>(NativeQueue<T> data) where T : unmanaged
		{
		}

		[Token(Token = "0x6000BB6")]
		public void Add<T>(UnsafeList<T> data) where T : unmanaged
		{
		}

		[Token(Token = "0x6000BB7")]
		public void Add<T>(UnsafeSpan<T> data) where T : unmanaged
		{
		}

		[Token(Token = "0x6000BB8")]
		public void Remove<T>(NativeArray<T> data) where T : struct
		{
 if (buffer!=null) {
  unsafe {
   void* pointer=NativeArrayUnsafeUtility.GetUnsafeBufferPointerWithoutChecks(data);
   for (int i=0;i<buffer.Count;i++) if (NativeArrayUnsafeUtility.GetUnsafeBufferPointerWithoutChecks(buffer[i])==pointer) { buffer.RemoveAtSwapBack(i); return; }
  }
 }
}

		[Token(Token = "0x6000BB9")]
		public void Add<T>(T data) where T : IArenaDisposable
		{
		}

		[Token(Token = "0x6000BBA")]
		[Address(RVA = "0x4581E78", Offset = "0x457DE78", VA = "0x4581E78")]
		public void Add(GCHandle handle)
		{ if (gcHandles==null) gcHandles=Pathfinding.Pooling.ListPool<GCHandle>.Claim(); gcHandles.Add(handle); }

		[Token(Token = "0x6000BBB")]
		[Address(RVA = "0x4581F64", Offset = "0x457DF64", VA = "0x4581F64")]
		public void DisposeAll()
		{
 if (buffer!=null) { for (int i=0;i<buffer.Count;i++) buffer[i].Dispose(); Pathfinding.Pooling.ListPool<NativeArray<byte>>.Release(ref buffer); }
 if (buffer2!=null) { for (int i=0;i<buffer2.Count;i++) buffer2[i].Dispose(); Pathfinding.Pooling.ListPool<NativeList<byte>>.Release(ref buffer2); }
 if (buffer3!=null) { for (int i=0;i<buffer3.Count;i++) buffer3[i].Dispose(); Pathfinding.Pooling.ListPool<NativeQueue<byte>>.Release(ref buffer3); }
 if (gcHandles!=null) { for (int i=0;i<gcHandles.Count;i++) gcHandles[i].Free(); Pathfinding.Pooling.ListPool<GCHandle>.Release(ref gcHandles); }
 unsafe {
  if (ptrBuffer!=null) { for (int i=0;i<ptrBuffer.Count;i++) AllocatorManager.Free(ptrBuffer[i].Item2,(void*)ptrBuffer[i].Item1,ptrBuffer[i].Item3,ptrBuffer[i].Item4,1); Pathfinding.Pooling.ListPool<(IntPtr,AllocatorManager.AllocatorHandle,int,int)>.Release(ref ptrBuffer); }
  if (ptrBufferTracked!=null) { for (int i=0;i<ptrBufferTracked.Count;i++) UnsafeUtility.FreeTracked((void*)ptrBufferTracked[i].Item1,ptrBufferTracked[i].Item2); Pathfinding.Pooling.ListPool<(IntPtr,Allocator)>.Release(ref ptrBufferTracked); }
 }
}

		[Token(Token = "0x6000BBC")]
		[Address(RVA = "0x45824CC", Offset = "0x457E4CC", VA = "0x45824CC")]
		public DisposeArena()
		{}
	}
}
