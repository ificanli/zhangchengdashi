using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

namespace andywiecko.BurstTriangulator
{
	[Token(Token = "0x2000011")]
	public class Triangulator : IDisposable
	{
		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Triangulator<double2> impl;

		[Token(Token = "0x17000022")]
		public TriangulationSettings Settings
		{
			[Token(Token = "0x600004B")]
			[Address(RVA = "0x3CF3198", Offset = "0x3CEF198", VA = "0x3CF3198")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000023")]
		public InputData<double2> Input
		{
			[Token(Token = "0x600004C")]
			[Address(RVA = "0x3CF31E0", Offset = "0x3CEF1E0", VA = "0x3CF31E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600004D")]
			[Address(RVA = "0x3CF3228", Offset = "0x3CEF228", VA = "0x3CF3228")]
			set
			{
			}
		}

		[Token(Token = "0x17000024")]
		public OutputData<double2> Output
		{
			[Token(Token = "0x600004E")]
			[Address(RVA = "0x3CF3274", Offset = "0x3CEF274", VA = "0x3CF3274")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x3CF32BC", Offset = "0x3CEF2BC", VA = "0x3CF32BC")]
		public Triangulator(int capacity, Allocator allocator)
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x3CF3354", Offset = "0x3CEF354", VA = "0x3CF3354")]
		public Triangulator(Allocator allocator)
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x3CF33DC", Offset = "0x3CEF3DC", VA = "0x3CF33DC", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x3CF342C", Offset = "0x3CEF42C", VA = "0x3CF342C")]
		public void Run()
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x3CF34D8", Offset = "0x3CEF4D8", VA = "0x3CF34D8")]
		public JobHandle Schedule([Optional] JobHandle dependencies)
		{
			return default;
		}
	}
	[Token(Token = "0x2000012")]
	public class Triangulator<T2> : IDisposable where T2 : unmanaged
	{
		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal NativeList<T2> outputPositions;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal NativeList<int> triangles;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal NativeList<int> halfedges;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal NativeList<HalfedgeState> constrainedHalfedges;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal NativeReference<Status> status;

		[Token(Token = "0x17000025")]
		public TriangulationSettings Settings
		{
			[Token(Token = "0x6000054")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000026")]
		public InputData<T2> Input
		{
			[Token(Token = "0x6000055")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000056")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000027")]
		public OutputData<T2> Output
		{
			[Token(Token = "0x6000057")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000058")]
		public Triangulator(int capacity, Allocator allocator)
		{
		}

		[Token(Token = "0x6000059")]
		public Triangulator(Allocator allocator)
		{
		}

		[Token(Token = "0x600005A")]
		public void Dispose()
		{
		}
	}
}
