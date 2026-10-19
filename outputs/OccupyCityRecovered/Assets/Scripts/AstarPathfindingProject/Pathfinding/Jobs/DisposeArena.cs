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
		}

		[Token(Token = "0x6000BB9")]
		public void Add<T>(T data) where T : IArenaDisposable
		{
		}

		[Token(Token = "0x6000BBA")]
		[Address(RVA = "0x4581E78", Offset = "0x457DE78", VA = "0x4581E78")]
		public void Add(GCHandle handle)
		{
		}

		[Token(Token = "0x6000BBB")]
		[Address(RVA = "0x4581F64", Offset = "0x457DF64", VA = "0x4581F64")]
		public void DisposeAll()
		{
		}

		[Token(Token = "0x6000BBC")]
		[Address(RVA = "0x45824CC", Offset = "0x457E4CC", VA = "0x45824CC")]
		public DisposeArena()
		{
		}
	}
}
