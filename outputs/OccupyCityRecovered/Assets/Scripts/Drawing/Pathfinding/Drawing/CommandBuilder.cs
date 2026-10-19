using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AOT;
using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;

namespace Pathfinding.Drawing
{
	[Token(Token = "0x200000B")]
	[BurstCompile]
	public struct CommandBuilder : IDisposable
	{
		[Token(Token = "0x200000C")]
		[Flags]
		internal enum Command
		{
			[Token(Token = "0x4000025")]
			PushColorInline = 0x100,
			[Token(Token = "0x4000026")]
			PushColor = 0,
			[Token(Token = "0x4000027")]
			PopColor = 1,
			[Token(Token = "0x4000028")]
			PushMatrix = 2,
			[Token(Token = "0x4000029")]
			PushSetMatrix = PopColor | PushMatrix,
			[Token(Token = "0x400002A")]
			PopMatrix = 4,
			[Token(Token = "0x400002B")]
			Line = PopColor | PopMatrix,
			[Token(Token = "0x400002C")]
			Circle = PushMatrix | PopMatrix,
			[Token(Token = "0x400002D")]
			CircleXZ = PushSetMatrix | PopMatrix,
			[Token(Token = "0x400002E")]
			Disc = 8,
			[Token(Token = "0x400002F")]
			DiscXZ = PopColor | Disc,
			[Token(Token = "0x4000030")]
			SphereOutline = PushMatrix | Disc,
			[Token(Token = "0x4000031")]
			Box = PushSetMatrix | Disc,
			[Token(Token = "0x4000032")]
			WirePlane = PopMatrix | Disc,
			[Token(Token = "0x4000033")]
			WireBox = Line | Disc,
			[Token(Token = "0x4000034")]
			SolidTriangle = Circle | Disc,
			[Token(Token = "0x4000035")]
			PushPersist = CircleXZ | Disc,
			[Token(Token = "0x4000036")]
			PopPersist = 0x10,
			[Token(Token = "0x4000037")]
			Text = PopColor | PopPersist,
			[Token(Token = "0x4000038")]
			Text3D = PushMatrix | PopPersist,
			[Token(Token = "0x4000039")]
			PushLineWidth = PushSetMatrix | PopPersist,
			[Token(Token = "0x400003A")]
			PopLineWidth = PopMatrix | PopPersist,
			[Token(Token = "0x400003B")]
			CaptureState = Line | PopPersist
		}

		[Token(Token = "0x200000D")]
		internal struct TriangleData
		{
			[Token(Token = "0x400003C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float3 a;

			[Token(Token = "0x400003D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float3 b;

			[Token(Token = "0x400003E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float3 c;
		}

		[Token(Token = "0x200000E")]
		internal struct LineData
		{
			[Token(Token = "0x400003F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float3 a;

			[Token(Token = "0x4000040")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float3 b;
		}

		[Token(Token = "0x200000F")]
		internal struct LineDataV3
		{
			[Token(Token = "0x4000041")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 a;

			[Token(Token = "0x4000042")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 b;
		}

		[Token(Token = "0x2000010")]
		internal struct CircleXZData
		{
			[Token(Token = "0x4000043")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float3 center;

			[Token(Token = "0x4000044")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float radius;

			[Token(Token = "0x4000045")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float startAngle;

			[Token(Token = "0x4000046")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float endAngle;
		}

		[Token(Token = "0x2000011")]
		internal struct CircleData
		{
			[Token(Token = "0x4000047")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float3 center;

			[Token(Token = "0x4000048")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float3 normal;

			[Token(Token = "0x4000049")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float radius;
		}

		[Token(Token = "0x2000012")]
		internal struct SphereData
		{
			[Token(Token = "0x400004A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float3 center;

			[Token(Token = "0x400004B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float radius;
		}

		[Token(Token = "0x2000013")]
		internal struct BoxData
		{
			[Token(Token = "0x400004C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float3 center;

			[Token(Token = "0x400004D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float3 size;
		}

		[Token(Token = "0x2000014")]
		internal struct PlaneData
		{
			[Token(Token = "0x400004E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float3 center;

			[Token(Token = "0x400004F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public quaternion rotation;

			[Token(Token = "0x4000050")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float2 size;
		}

		[Token(Token = "0x2000015")]
		internal struct PersistData
		{
			[Token(Token = "0x4000051")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float endTime;
		}

		[Token(Token = "0x2000016")]
		internal struct LineWidthData
		{
			[Token(Token = "0x4000052")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float pixels;

			[Token(Token = "0x4000053")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public bool automaticJoins;
		}

		[Token(Token = "0x2000017")]
		internal struct TextData
		{
			[Token(Token = "0x4000054")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float3 center;

			[Token(Token = "0x4000055")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public LabelAlignment alignment;

			[Token(Token = "0x4000056")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float sizeInPixels;

			[Token(Token = "0x4000057")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int numCharacters;
		}

		[Token(Token = "0x2000018")]
		internal struct TextData3D
		{
			[Token(Token = "0x4000058")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float3 center;

			[Token(Token = "0x4000059")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public quaternion rotation;

			[Token(Token = "0x400005A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public LabelAlignment alignment;

			[Token(Token = "0x400005B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float size;

			[Token(Token = "0x400005C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int numCharacters;
		}

		[Token(Token = "0x2000019")]
		public struct ScopeMatrix : IDisposable
		{
			[Token(Token = "0x400005D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal CommandBuilder builder;

			[Token(Token = "0x60000CC")]
			[Address(RVA = "0x46D65FC", Offset = "0x46D25FC", VA = "0x46D65FC", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Token(Token = "0x200001A")]
		public struct ScopeColor : IDisposable
		{
			[Token(Token = "0x400005E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal CommandBuilder builder;

			[Token(Token = "0x60000CD")]
			[Address(RVA = "0x46D6658", Offset = "0x46D2658", VA = "0x46D6658", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Token(Token = "0x200001B")]
		public struct ScopePersist : IDisposable
		{
			[Token(Token = "0x400005F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal CommandBuilder builder;

			[Token(Token = "0x60000CE")]
			[Address(RVA = "0x46D66B4", Offset = "0x46D26B4", VA = "0x46D66B4", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Token(Token = "0x200001C")]
		public struct ScopeEmpty : IDisposable
		{
			[Token(Token = "0x60000CF")]
			[Address(RVA = "0x46D6710", Offset = "0x46D2710", VA = "0x46D6710", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Token(Token = "0x200001D")]
		public struct ScopeLineWidth : IDisposable
		{
			[Token(Token = "0x4000060")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal CommandBuilder builder;

			[Token(Token = "0x60000D0")]
			[Address(RVA = "0x46D6714", Offset = "0x46D2714", VA = "0x46D6714", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Token(Token = "0x200001E")]
		public enum SymbolDecoration : byte
		{
			[Token(Token = "0x4000062")]
			None = 0,
			[Token(Token = "0x4000063")]
			ArrowHead = 1,
			[Token(Token = "0x4000064")]
			Circle = 2
		}

		[Token(Token = "0x200001F")]
		public struct PolylineWithSymbol
		{
			[Token(Token = "0x2000020")]
			private enum State : byte
			{
				[Token(Token = "0x4000070")]
				NotStarted = 0,
				[Token(Token = "0x4000071")]
				ConnectingSegment = 1,
				[Token(Token = "0x4000072")]
				PreSymbolPadding = 2,
				[Token(Token = "0x4000073")]
				Symbol = 3,
				[Token(Token = "0x4000074")]
				PostSymbolPadding = 4
			}

			[Token(Token = "0x4000065")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private float3 prev;

			[Token(Token = "0x4000066")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private float offset;

			[Token(Token = "0x4000067")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly float symbolSize;

			[Token(Token = "0x4000068")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private readonly float connectingSegmentLength;

			[Token(Token = "0x4000069")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly float symbolPadding;

			[Token(Token = "0x400006A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private readonly float symbolOffset;

			[Token(Token = "0x400006B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float3 up;

			[Token(Token = "0x400006C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private readonly SymbolDecoration symbol;

			[Token(Token = "0x400006D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
			private State state;

			[Token(Token = "0x400006E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2E")]
			private readonly bool reverseSymbols;

			[Token(Token = "0x60000D1")]
			[Address(RVA = "0x46CBAAC", Offset = "0x46C7AAC", VA = "0x46CBAAC")]
			public PolylineWithSymbol(SymbolDecoration symbol, float symbolSize, float symbolPadding, float symbolSpacing, bool reverseSymbols = false, float offset = 0f)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED CommandBuilder.PolylineWithSymbol..ctor RVA=0x46CBAAC Token=0x60000D1");
}

			[Token(Token = "0x60000D2")]
			[Address(RVA = "0x46CBCB8", Offset = "0x46C7CB8", VA = "0x46CBCB8")]
			public void MoveTo(ref CommandBuilder draw, float3 next)
			{
			}
		}

		[Token(Token = "0x2000021")]
		[BurstCompile]
		private class JobWireMesh
		{
			[Token(Token = "0x2000022")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate void JobWireMeshDelegate(ref Mesh.MeshData rawMeshData, ref CommandBuilder draw);

			[Token(Token = "0x2000023")]
			public unsafe delegate void WireMesh_000000D1_0024PostfixBurstDelegate(float3* verts, int* indices, int vertexCount, int indexCount, ref CommandBuilder draw);

			[Token(Token = "0x2000024")]
			internal static class WireMesh_000000D1_0024BurstDirectCall
			{
				[Token(Token = "0x4000076")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static IntPtr Pointer;

				[Token(Token = "0x4000077")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				private static IntPtr DeferredCompilation;

				[Token(Token = "0x60000E1")]
				[Address(RVA = "0x46D73DC", Offset = "0x46D33DC", VA = "0x46D73DC")]
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr P_0)
				{
				}

				[Token(Token = "0x60000E2")]
				[Address(RVA = "0x46D74F8", Offset = "0x46D34F8", VA = "0x46D74F8")]
				private static IntPtr GetFunctionPointer()
				{
					return default;
				}

				[Token(Token = "0x60000E3")]
				[Address(RVA = "0x46D7554", Offset = "0x46D3554", VA = "0x46D7554")]
				public static void Constructor()
				{
				}

				[Token(Token = "0x60000E4")]
				[Address(RVA = "0x46D65A0", Offset = "0x46D25A0", VA = "0x46D65A0")]
				public static void Initialize()
				{
				}

				[Token(Token = "0x60000E6")]
				[Address(RVA = "0x46D67D4", Offset = "0x46D27D4", VA = "0x46D67D4")]
				public unsafe static void Invoke(float3* verts, int* indices, int vertexCount, int indexCount, ref CommandBuilder draw)
				{
				}
			}

			[Token(Token = "0x2000025")]
			public delegate void Execute_000000D2_0024PostfixBurstDelegate(ref Mesh.MeshData rawMeshData, ref CommandBuilder draw);

			[Token(Token = "0x2000026")]
			internal static class Execute_000000D2_0024BurstDirectCall
			{
				[Token(Token = "0x4000078")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static IntPtr Pointer;

				[Token(Token = "0x4000079")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				private static IntPtr DeferredCompilation;

				[Token(Token = "0x60000EB")]
				[Address(RVA = "0x46D7780", Offset = "0x46D3780", VA = "0x46D7780")]
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr P_0)
				{
				}

				[Token(Token = "0x60000EC")]
				[Address(RVA = "0x46D789C", Offset = "0x46D389C", VA = "0x46D789C")]
				private static IntPtr GetFunctionPointer()
				{
					return default;
				}

				[Token(Token = "0x60000ED")]
				[Address(RVA = "0x46D78F8", Offset = "0x46D38F8", VA = "0x46D78F8")]
				public static void Constructor()
				{
				}

				[Token(Token = "0x60000EE")]
				[Address(RVA = "0x46D65F8", Offset = "0x46D25F8", VA = "0x46D65F8")]
				public static void Initialize()
				{
				}

				[Token(Token = "0x60000F0")]
				[Address(RVA = "0x46D68E4", Offset = "0x46D28E4", VA = "0x46D68E4")]
				public static void Invoke(ref Mesh.MeshData rawMeshData, ref CommandBuilder draw)
				{
				}
			}

			[Token(Token = "0x4000075")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly JobWireMeshDelegate JobWireMeshFunctionPointer;

			[Token(Token = "0x60000D3")]
			[Address(RVA = "0x46CC84C", Offset = "0x46C884C", VA = "0x46CC84C")]
			[BurstCompile]
			public unsafe static void WireMesh(float3* verts, int* indices, int vertexCount, int indexCount, ref CommandBuilder draw)
			{
			}

			[Token(Token = "0x60000D4")]
			[Address(RVA = "0x46D6770", Offset = "0x46D2770", VA = "0x46D6770")]
			[BurstCompile]
			[MonoPInvokeCallback(typeof(JobWireMeshDelegate))]
			private static void Execute(ref Mesh.MeshData rawMeshData, ref CommandBuilder draw)
			{
			}

			[Token(Token = "0x60000D5")]
			[Address(RVA = "0x46D69C4", Offset = "0x46D29C4", VA = "0x46D69C4")]
			public JobWireMesh()
			{
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x60000D7")]
			[Address(RVA = "0x46D6B6C", Offset = "0x46D2B6C", VA = "0x46D6B6C")]
			[BurstCompile]
			public unsafe static void WireMesh_0024BurstManaged(float3* verts, int* indices, int vertexCount, int indexCount, ref CommandBuilder draw)
			{
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x60000D8")]
			[Address(RVA = "0x46D6F1C", Offset = "0x46D2F1C", VA = "0x46D6F1C")]
			[BurstCompile]
			[MonoPInvokeCallback(typeof(JobWireMeshDelegate))]
			public static void Execute_0024BurstManaged(ref Mesh.MeshData rawMeshData, ref CommandBuilder draw)
			{
			}
		}

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[NativeDisableUnsafePtrRestriction]
		internal unsafe UnsafeAppendBuffer* buffer;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private GCHandle gizmos;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[NativeSetThreadIndex]
		private int threadIndex;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private DrawingData.BuilderData.BitPackedMeta uniqueID;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly float3 DEFAULT_UP;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal static readonly float4x4 XZtoXYPlaneMatrix;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		internal static readonly float4x4 XZtoYZPlaneMatrix;

		[Token(Token = "0x17000001")]
		internal int BufferSize
		{
			[Token(Token = "0x6000012")]
			[Address(RVA = "0x46C6E7C", Offset = "0x46C2E7C", VA = "0x46C6E7C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000013")]
			[Address(RVA = "0x46C6E98", Offset = "0x46C2E98", VA = "0x46C6E98")]
			set
			{
			}
		}

		[Token(Token = "0x17000002")]
		public CommandBuilder2D xy
		{
			[Token(Token = "0x6000014")]
			[Address(RVA = "0x46C6EB4", Offset = "0x46C2EB4", VA = "0x46C6EB4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000003")]
		public CommandBuilder2D xz
		{
			[Token(Token = "0x6000015")]
			[Address(RVA = "0x46C6EE8", Offset = "0x46C2EE8", VA = "0x46C6EE8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000004")]
		public Camera[] cameraTargets
		{
			[Token(Token = "0x6000016")]
			[Address(RVA = "0x46C6EFC", Offset = "0x46C2EFC", VA = "0x46C6EFC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000017")]
			[Address(RVA = "0x46C7014", Offset = "0x46C3014", VA = "0x46C7014")]
			set
			{
			}
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x46C6D1C", Offset = "0x46C2D1C", VA = "0x46C6D1C")]
		internal unsafe CommandBuilder(UnsafeAppendBuffer* buffer, GCHandle gizmos, int threadIndex, DrawingData.BuilderData.BitPackedMeta uniqueID)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED CommandBuilder..ctor RVA=0x46C6D1C Token=0x6000010");
}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x46C6D28", Offset = "0x46C2D28", VA = "0x46C6D28")]
		internal CommandBuilder(DrawingData gizmos, DrawingData.Hasher hasher, RedrawScope frameRedrawScope, RedrawScope customRedrawScope, bool isGizmos, bool isBuiltInCommandBuilder, int sceneModeVersion)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED CommandBuilder..ctor RVA=0x46C6D28 Token=0x6000011");
}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x46C716C", Offset = "0x46C316C", VA = "0x46C716C", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x46C74BC", Offset = "0x46C34BC", VA = "0x46C74BC")]
		public void DisposeAfter(JobHandle dependency, AllowedDelay allowedDelay = AllowedDelay.EndOfFrame)
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x46C7218", Offset = "0x46C3218", VA = "0x46C7218")]
		internal void DisposeInternal()
		{
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x46C7714", Offset = "0x46C3714", VA = "0x46C7714")]
		public void DiscardAndDispose()
		{
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x46C77C0", Offset = "0x46C37C0", VA = "0x46C77C0")]
		internal void DiscardAndDisposeInternal()
		{
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x46C79AC", Offset = "0x46C39AC", VA = "0x46C79AC")]
		public void Preallocate(int size)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x46C7A7C", Offset = "0x46C3A7C", VA = "0x46C7A7C")]
		private void Reserve(int additionalSpace)
		{
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x46C7B08", Offset = "0x46C3B08", VA = "0x46C7B08")]
		[BurstDiscard]
		private void AssertBufferExists()
		{
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x46C7C10", Offset = "0x46C3C10", VA = "0x46C7C10")]
		[BurstDiscard]
		private static void AssertNotRendering()
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000021")]
		internal void Reserve<A>() where A : struct
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000022")]
		internal void Reserve<A, B>() where A : struct where B : struct
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000023")]
		internal void Reserve<A, B, C>() where A : struct where B : struct where C : struct
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x46C7D28", Offset = "0x46C3D28", VA = "0x46C7D28")]
		internal static uint ConvertColor(Color color)
		{
			return default;
		}

		[Token(Token = "0x6000025")]
		internal void Add<T>(T value) where T : struct
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x46C7EDC", Offset = "0x46C3EDC", VA = "0x46C7EDC")]
		[BurstDiscard]
		public ScopeMatrix WithMatrix(Matrix4x4 matrix)
		{
			return default;
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x46C806C", Offset = "0x46C406C", VA = "0x46C806C")]
		[BurstDiscard]
		public ScopeMatrix WithMatrix(float3x3 matrix)
		{
			return default;
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x46C824C", Offset = "0x46C424C", VA = "0x46C824C")]
		[BurstDiscard]
		public ScopeColor WithColor(Color color)
		{
			return default;
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x46C83E4", Offset = "0x46C43E4", VA = "0x46C83E4")]
		[BurstDiscard]
		public ScopePersist WithDuration(float duration)
		{
			return default;
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x46C857C", Offset = "0x46C457C", VA = "0x46C857C")]
		[BurstDiscard]
		public ScopeLineWidth WithLineWidth(float pixels, bool automaticJoins = true)
		{
			return default;
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x46C8748", Offset = "0x46C4748", VA = "0x46C8748")]
		[BurstDiscard]
		public ScopeMatrix InLocalSpace(Transform transform)
		{
			return default;
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x46C8808", Offset = "0x46C4808", VA = "0x46C8808")]
		[BurstDiscard]
		public ScopeMatrix InScreenSpace(Camera camera)
		{
			return default;
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x46C7F80", Offset = "0x46C3F80", VA = "0x46C7F80")]
		public void PushMatrix(Matrix4x4 matrix)
		{
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x46C8160", Offset = "0x46C4160", VA = "0x46C8160")]
		public void PushMatrix(float4x4 matrix)
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x46C8A40", Offset = "0x46C4A40", VA = "0x46C8A40")]
		public void PushSetMatrix(Matrix4x4 matrix)
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x46C8B44", Offset = "0x46C4B44", VA = "0x46C8B44")]
		public void PushSetMatrix(float4x4 matrix)
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x46C8C30", Offset = "0x46C4C30", VA = "0x46C8C30")]
		public void PopMatrix()
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x46C82F0", Offset = "0x46C42F0", VA = "0x46C82F0")]
		public void PushColor(Color color)
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x46C8D08", Offset = "0x46C4D08", VA = "0x46C8D08")]
		public void PopColor()
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x46C8468", Offset = "0x46C4468", VA = "0x46C8468")]
		public void PushDuration(float duration)
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x46C8DE0", Offset = "0x46C4DE0", VA = "0x46C8DE0")]
		public void PopDuration()
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x46C8EB8", Offset = "0x46C4EB8", VA = "0x46C8EB8")]
		[Obsolete("Renamed to PushDuration for consistency")]
		public void PushPersist(float duration)
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x46C8F1C", Offset = "0x46C4F1C", VA = "0x46C8F1C")]
		[Obsolete("Renamed to PopDuration for consistency")]
		public void PopPersist()
		{
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x46C8608", Offset = "0x46C4608", VA = "0x46C8608")]
		public void PushLineWidth(float pixels, bool automaticJoins = true)
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x46C8F70", Offset = "0x46C4F70", VA = "0x46C8F70")]
		public void PopLineWidth()
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x46C9048", Offset = "0x46C5048", VA = "0x46C9048")]
		public void Line(float3 a, float3 b)
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x46C914C", Offset = "0x46C514C", VA = "0x46C914C")]
		public void Line(Vector3 a, Vector3 b)
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x46C922C", Offset = "0x46C522C", VA = "0x46C922C")]
		public void Line(Vector3 a, Vector3 b, Color color)
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x46C9324", Offset = "0x46C5324", VA = "0x46C9324")]
		public void Ray(float3 origin, float3 direction)
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x46C93C0", Offset = "0x46C53C0", VA = "0x46C93C0")]
		public void Ray(Ray ray, float length)
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x46C9474", Offset = "0x46C5474", VA = "0x46C9474")]
		public void Arc(float3 center, float3 start, float3 end)
		{
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x46C993C", Offset = "0x46C593C", VA = "0x46C993C")]
		[Obsolete("Use Draw.xz.Circle instead")]
		public void CircleXZ(float3 center, float radius, float startAngle = 0f, float endAngle = (float)Math.PI * 2f)
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x46C9838", Offset = "0x46C5838", VA = "0x46C9838")]
		internal void CircleXZInternal(float3 center, float radius, float startAngle = 0f, float endAngle = (float)Math.PI * 2f)
		{
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x46C99D8", Offset = "0x46C59D8", VA = "0x46C99D8")]
		internal void CircleXZInternal(float3 center, float radius, float startAngle, float endAngle, Color color)
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x46C9B2C", Offset = "0x46C5B2C", VA = "0x46C9B2C")]
		[Obsolete("Use Draw.xy.Circle instead")]
		public void CircleXY(float3 center, float radius, float startAngle = 0f, float endAngle = (float)Math.PI * 2f)
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x46C9C04", Offset = "0x46C5C04", VA = "0x46C9C04")]
		public void Circle(float3 center, float3 normal, float radius)
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x46C9D18", Offset = "0x46C5D18", VA = "0x46C9D18")]
		public void SolidArc(float3 center, float3 start, float3 end)
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x46CA18C", Offset = "0x46C618C", VA = "0x46CA18C")]
		[Obsolete("Use Draw.xz.SolidCircle instead")]
		public void SolidCircleXZ(float3 center, float radius, float startAngle = 0f, float endAngle = (float)Math.PI * 2f)
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x46CA088", Offset = "0x46C6088", VA = "0x46CA088")]
		internal void SolidCircleXZInternal(float3 center, float radius, float startAngle = 0f, float endAngle = (float)Math.PI * 2f)
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x46CA228", Offset = "0x46C6228", VA = "0x46CA228")]
		internal void SolidCircleXZInternal(float3 center, float radius, float startAngle, float endAngle, Color color)
		{
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x46CA37C", Offset = "0x46C637C", VA = "0x46CA37C")]
		[Obsolete("Use Draw.xy.SolidCircle instead")]
		public void SolidCircleXY(float3 center, float radius, float startAngle = 0f, float endAngle = (float)Math.PI * 2f)
		{
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x46CA454", Offset = "0x46C6454", VA = "0x46CA454")]
		public void SolidCircle(float3 center, float3 normal, float radius)
		{
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x46CA568", Offset = "0x46C6568", VA = "0x46CA568")]
		public void SphereOutline(float3 center, float radius)
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x46CA650", Offset = "0x46C6650", VA = "0x46CA650")]
		public void WireCylinder(float3 bottom, float3 top, float radius)
		{
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x46CA758", Offset = "0x46C6758", VA = "0x46CA758")]
		public void WireCylinder(float3 position, float3 up, float height, float radius)
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x46CAABC", Offset = "0x46C6ABC", VA = "0x46CAABC")]
		private static void OrthonormalBasis(float3 normal, out float3 basis1, out float3 basis2)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED CommandBuilder.OrthonormalBasis RVA=0x46CAABC Token=0x600004E");
}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x46CAC14", Offset = "0x46C6C14", VA = "0x46CAC14")]
		public void WireCapsule(float3 start, float3 end, float radius)
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x46CAE94", Offset = "0x46C6E94", VA = "0x46CAE94")]
		public void WireCapsule(float3 position, float3 direction, float length, float radius)
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x46CADA4", Offset = "0x46C6DA4", VA = "0x46CADA4")]
		public void WireSphere(float3 position, float radius)
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x46CB3B8", Offset = "0x46C73B8", VA = "0x46CB3B8")]
		[BurstDiscard]
		public void Polyline(List<Vector3> points, bool cycle = false)
		{
		}

		[Token(Token = "0x6000053")]
		public void Polyline<T>(T points, bool cycle = false) where T : IReadOnlyList<float3>
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x46CB56C", Offset = "0x46C756C", VA = "0x46CB56C")]
		[BurstDiscard]
		public void Polyline(Vector3[] points, bool cycle = false)
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x46CB714", Offset = "0x46C7714", VA = "0x46CB714")]
		[BurstDiscard]
		public void Polyline(float3[] points, bool cycle = false)
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x46CB8BC", Offset = "0x46C78BC", VA = "0x46CB8BC")]
		public void Polyline(NativeArray<float3> points, bool cycle = false)
		{
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x46CBA08", Offset = "0x46C7A08", VA = "0x46CBA08")]
		public void DashedLine(float3 a, float3 b, float dash, float gap)
		{
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x46CC1E4", Offset = "0x46C81E4", VA = "0x46CC1E4")]
		public void DashedPolyline(List<Vector3> points, float dash, float gap)
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x46CC2CC", Offset = "0x46C82CC", VA = "0x46CC2CC")]
		public void WireBox(float3 center, float3 size)
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x46CC3D0", Offset = "0x46C83D0", VA = "0x46CC3D0")]
		public void WireBox(float3 center, quaternion rotation, float3 size)
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x46CC564", Offset = "0x46C8564", VA = "0x46CC564")]
		public void WireBox(Bounds bounds)
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x46CC638", Offset = "0x46C8638", VA = "0x46CC638")]
		public void WireMesh(Mesh mesh)
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x46CC76C", Offset = "0x46C876C", VA = "0x46CC76C")]
		public void WireMesh(NativeArray<float3> vertices, NativeArray<int> triangles)
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x46CC8D0", Offset = "0x46C88D0", VA = "0x46CC8D0")]
		public void SolidMesh(Mesh mesh)
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x46CCAF0", Offset = "0x46C8AF0", VA = "0x46CCAF0")]
		private void SolidMeshInternal(Mesh mesh, bool temporary, Color color)
		{
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x46CC938", Offset = "0x46C8938", VA = "0x46CC938")]
		private void SolidMeshInternal(Mesh mesh, bool temporary)
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x46CCB9C", Offset = "0x46C8B9C", VA = "0x46CCB9C")]
		[BurstDiscard]
		public void SolidMesh(List<Vector3> vertices, List<int> triangles, List<Color> colors)
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x46CCEC4", Offset = "0x46C8EC4", VA = "0x46CCEC4")]
		[BurstDiscard]
		public void SolidMesh(Vector3[] vertices, int[] triangles, Color[] colors, int vertexCount, int indexCount)
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x46CD07C", Offset = "0x46C907C", VA = "0x46CD07C")]
		public void Cross(float3 position, float size = 1f)
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x46CD170", Offset = "0x46C9170", VA = "0x46CD170")]
		[Obsolete("Use Draw.xz.Cross instead")]
		public void CrossXZ(float3 position, float size = 1f)
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x46CD234", Offset = "0x46C9234", VA = "0x46CD234")]
		[Obsolete("Use Draw.xy.Cross instead")]
		public void CrossXY(float3 position, float size = 1f)
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x46CD2F8", Offset = "0x46C92F8", VA = "0x46CD2F8")]
		public static float3 EvaluateCubicBezier(float3 p0, float3 p1, float3 p2, float3 p3, float t)
		{
			return default;
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x46CD3C4", Offset = "0x46C93C4", VA = "0x46CD3C4")]
		public void Bezier(float3 p0, float3 p1, float3 p2, float3 p3)
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x46CD4F8", Offset = "0x46C94F8", VA = "0x46CD4F8")]
		public void CatmullRom(List<Vector3> points)
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x46CD8C0", Offset = "0x46C98C0", VA = "0x46CD8C0")]
		public void CatmullRom(float3 p0, float3 p1, float3 p2, float3 p3)
		{
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x46CDA0C", Offset = "0x46C9A0C", VA = "0x46CDA0C")]
		public void Arrow(float3 from, float3 to)
		{
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x46CDDE8", Offset = "0x46C9DE8", VA = "0x46CDDE8")]
		public void Arrow(float3 from, float3 to, float3 up, float headSize)
		{
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x46CDAD8", Offset = "0x46C9AD8", VA = "0x46CDAD8")]
		public void ArrowRelativeSizeHead(float3 from, float3 to, float3 up, float headFraction)
		{
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x46CDF5C", Offset = "0x46C9F5C", VA = "0x46CDF5C")]
		public void Arrowhead(float3 center, float3 direction, float radius)
		{
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x46CE02C", Offset = "0x46CA02C", VA = "0x46CE02C")]
		public void Arrowhead(float3 center, float3 direction, float3 up, float radius)
		{
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x46CE2D8", Offset = "0x46CA2D8", VA = "0x46CE2D8")]
		public void ArrowheadArc(float3 origin, float3 direction, float offset, float width = 60f)
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x46CE6BC", Offset = "0x46CA6BC", VA = "0x46CE6BC")]
		public void WireGrid(float3 center, quaternion rotation, int2 cells, float2 totalSize)
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x46CE900", Offset = "0x46CA900", VA = "0x46CE900")]
		public void WireTriangle(float3 a, float3 b, float3 c)
		{
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x46CE9FC", Offset = "0x46CA9FC", VA = "0x46CE9FC")]
		[Obsolete("Use Draw.xz.WireRectangle instead")]
		public void WireRectangleXZ(float3 center, float2 size)
		{
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x46CEAFC", Offset = "0x46CAAFC", VA = "0x46CEAFC")]
		public void WireRectangle(float3 center, quaternion rotation, float2 size)
		{
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x46CED20", Offset = "0x46CAD20", VA = "0x46CED20")]
		[Obsolete("Use Draw.xy.WireRectangle instead")]
		public void WireRectangle(Rect rect)
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x46CEEEC", Offset = "0x46CAEEC", VA = "0x46CEEEC")]
		public void WireTriangle(float3 center, quaternion rotation, float radius)
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x46CF200", Offset = "0x46CB200", VA = "0x46CF200")]
		public void WirePentagon(float3 center, quaternion rotation, float radius)
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x46CF2B8", Offset = "0x46CB2B8", VA = "0x46CF2B8")]
		public void WireHexagon(float3 center, quaternion rotation, float radius)
		{
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x46CEFA4", Offset = "0x46CAFA4", VA = "0x46CEFA4")]
		public void WirePolygon(float3 center, int vertices, quaternion rotation, float radius)
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x46CF370", Offset = "0x46CB370", VA = "0x46CF370")]
		[Obsolete("Use Draw.xy.SolidRectangle instead")]
		public void SolidRectangle(Rect rect)
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x46CF584", Offset = "0x46CB584", VA = "0x46CF584")]
		public void SolidPlane(float3 center, float3 normal, float2 size)
		{
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x46CF744", Offset = "0x46CB744", VA = "0x46CF744")]
		public void SolidPlane(float3 center, quaternion rotation, float2 size)
		{
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x46CF6DC", Offset = "0x46CB6DC", VA = "0x46CF6DC")]
		private static float3 calculateTangent(float3 normal)
		{
			return default;
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x46CF920", Offset = "0x46CB920", VA = "0x46CF920")]
		public void WirePlane(float3 center, float3 normal, float2 size)
		{
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x46CEC00", Offset = "0x46CAC00", VA = "0x46CEC00")]
		public void WirePlane(float3 center, quaternion rotation, float2 size)
		{
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x46CFA78", Offset = "0x46CBA78", VA = "0x46CFA78")]
		public void PlaneWithNormal(float3 center, float3 normal, float2 size)
		{
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x46CFBD0", Offset = "0x46CBBD0", VA = "0x46CFBD0")]
		public void PlaneWithNormal(float3 center, quaternion rotation, float2 size)
		{
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x46CFDD8", Offset = "0x46CBDD8", VA = "0x46CFDD8")]
		public void SolidTriangle(float3 a, float3 b, float3 c)
		{
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x46CFEF8", Offset = "0x46CBEF8", VA = "0x46CFEF8")]
		public void SolidBox(float3 center, float3 size)
		{
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x46CFFFC", Offset = "0x46CBFFC", VA = "0x46CFFFC")]
		public void SolidBox(Bounds bounds)
		{
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x46D00D0", Offset = "0x46CC0D0", VA = "0x46D00D0")]
		public void SolidBox(float3 center, quaternion rotation, float3 size)
		{
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x46D02B4", Offset = "0x46CC2B4", VA = "0x46D02B4")]
		public void Label3D(float3 position, quaternion rotation, string text, float size)
		{
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x46D03B0", Offset = "0x46CC3B0", VA = "0x46D03B0")]
		public void Label3D(float3 position, quaternion rotation, string text, float size, LabelAlignment alignment)
		{
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x46D06CC", Offset = "0x46CC6CC", VA = "0x46D06CC")]
		public void Label2D(float3 position, string text, float sizeInPixels = 14f)
		{
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x46D07B4", Offset = "0x46CC7B4", VA = "0x46D07B4")]
		public void Label2D(float3 position, string text, float sizeInPixels, LabelAlignment alignment)
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x46D0500", Offset = "0x46CC500", VA = "0x46D0500")]
		private void AddText(string text)
		{
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x46D08F4", Offset = "0x46CC8F4", VA = "0x46D08F4")]
		public void Label2D(float3 position, ref FixedString32Bytes text, float sizeInPixels = 14f)
		{
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x46D0AA8", Offset = "0x46CCAA8", VA = "0x46D0AA8")]
		public void Label2D(float3 position, ref FixedString64Bytes text, float sizeInPixels = 14f)
		{
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x46D0C5C", Offset = "0x46CCC5C", VA = "0x46D0C5C")]
		public void Label2D(float3 position, ref FixedString128Bytes text, float sizeInPixels = 14f)
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x46D0E10", Offset = "0x46CCE10", VA = "0x46D0E10")]
		public void Label2D(float3 position, ref FixedString512Bytes text, float sizeInPixels = 14f)
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x46D09DC", Offset = "0x46CC9DC", VA = "0x46D09DC")]
		public void Label2D(float3 position, ref FixedString32Bytes text, float sizeInPixels, LabelAlignment alignment)
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x46D0B90", Offset = "0x46CCB90", VA = "0x46D0B90")]
		public void Label2D(float3 position, ref FixedString64Bytes text, float sizeInPixels, LabelAlignment alignment)
		{
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x46D0D44", Offset = "0x46CCD44", VA = "0x46D0D44")]
		public void Label2D(float3 position, ref FixedString128Bytes text, float sizeInPixels, LabelAlignment alignment)
		{
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x46D0EF8", Offset = "0x46CCEF8", VA = "0x46D0EF8")]
		public void Label2D(float3 position, ref FixedString512Bytes text, float sizeInPixels, LabelAlignment alignment)
		{
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x46D0FC4", Offset = "0x46CCFC4", VA = "0x46D0FC4")]
		internal unsafe void Label2D(float3 position, byte* text, int byteCount, float sizeInPixels, LabelAlignment alignment)
		{
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x46D11E0", Offset = "0x46CD1E0", VA = "0x46D11E0")]
		public void Label3D(float3 position, quaternion rotation, ref FixedString32Bytes text, float size)
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x46D1410", Offset = "0x46CD410", VA = "0x46D1410")]
		public void Label3D(float3 position, quaternion rotation, ref FixedString64Bytes text, float size)
		{
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x46D1640", Offset = "0x46CD640", VA = "0x46D1640")]
		public void Label3D(float3 position, quaternion rotation, ref FixedString128Bytes text, float size)
		{
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x46D1870", Offset = "0x46CD870", VA = "0x46D1870")]
		public void Label3D(float3 position, quaternion rotation, ref FixedString512Bytes text, float size)
		{
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x46D12DC", Offset = "0x46CD2DC", VA = "0x46D12DC")]
		public void Label3D(float3 position, quaternion rotation, ref FixedString32Bytes text, float size, LabelAlignment alignment)
		{
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x46D150C", Offset = "0x46CD50C", VA = "0x46D150C")]
		public void Label3D(float3 position, quaternion rotation, ref FixedString64Bytes text, float size, LabelAlignment alignment)
		{
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x46D173C", Offset = "0x46CD73C", VA = "0x46D173C")]
		public void Label3D(float3 position, quaternion rotation, ref FixedString128Bytes text, float size, LabelAlignment alignment)
		{
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x46D196C", Offset = "0x46CD96C", VA = "0x46D196C")]
		public void Label3D(float3 position, quaternion rotation, ref FixedString512Bytes text, float size, LabelAlignment alignment)
		{
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x46D1AA0", Offset = "0x46CDAA0", VA = "0x46D1AA0")]
		internal unsafe void Label3D(float3 position, quaternion rotation, byte* text, int byteCount, float size, LabelAlignment alignment)
		{
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x46D1CCC", Offset = "0x46CDCCC", VA = "0x46D1CCC")]
		public void Line(float3 a, float3 b, Color color)
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x46D1E20", Offset = "0x46CDE20", VA = "0x46D1E20")]
		public void Ray(float3 origin, float3 direction, Color color)
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x46D1EEC", Offset = "0x46CDEEC", VA = "0x46D1EEC")]
		public void Ray(Ray ray, float length, Color color)
		{
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x46D1FEC", Offset = "0x46CDFEC", VA = "0x46D1FEC")]
		public void Arc(float3 center, float3 start, float3 end, Color color)
		{
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x46D2408", Offset = "0x46CE408", VA = "0x46D2408")]
		[Obsolete("Use Draw.xz.Circle instead")]
		public void CircleXZ(float3 center, float radius, float startAngle, float endAngle, Color color)
		{
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x46D24F4", Offset = "0x46CE4F4", VA = "0x46D24F4")]
		[Obsolete("Use Draw.xz.Circle instead")]
		public void CircleXZ(float3 center, float radius, Color color)
		{
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x46D25B8", Offset = "0x46CE5B8", VA = "0x46D25B8")]
		public void Circle(float3 center, float3 normal, float radius, Color color)
		{
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x46D2718", Offset = "0x46CE718", VA = "0x46D2718")]
		public void WireCylinder(float3 bottom, float3 top, float radius, Color color)
		{
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x46D2844", Offset = "0x46CE844", VA = "0x46D2844")]
		public void WireCylinder(float3 position, float3 up, float height, float radius, Color color)
		{
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x46D2BD8", Offset = "0x46CEBD8", VA = "0x46D2BD8")]
		public void WireCapsule(float3 start, float3 end, float radius, Color color)
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x46D2DAC", Offset = "0x46CEDAC", VA = "0x46D2DAC")]
		public void WireCapsule(float3 position, float3 direction, float length, float radius, Color color)
		{
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x46D3318", Offset = "0x46CF318", VA = "0x46D3318")]
		public void WireSphere(float3 position, float radius, Color color)
		{
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x46D3448", Offset = "0x46CF448", VA = "0x46D3448")]
		[BurstDiscard]
		public void Polyline(List<Vector3> points, bool cycle, Color color)
		{
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x46D362C", Offset = "0x46CF62C", VA = "0x46D362C")]
		[BurstDiscard]
		public void Polyline(List<Vector3> points, Color color)
		{
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x46D36C4", Offset = "0x46CF6C4", VA = "0x46D36C4")]
		[BurstDiscard]
		public void Polyline(Vector3[] points, bool cycle, Color color)
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x46D3898", Offset = "0x46CF898", VA = "0x46D3898")]
		[BurstDiscard]
		public void Polyline(Vector3[] points, Color color)
		{
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x46D3930", Offset = "0x46CF930", VA = "0x46D3930")]
		[BurstDiscard]
		public void Polyline(float3[] points, bool cycle, Color color)
		{
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x46D3B04", Offset = "0x46CFB04", VA = "0x46D3B04")]
		[BurstDiscard]
		public void Polyline(float3[] points, Color color)
		{
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x46D3B9C", Offset = "0x46CFB9C", VA = "0x46D3B9C")]
		public void Polyline(NativeArray<float3> points, bool cycle, Color color)
		{
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x46D3D14", Offset = "0x46CFD14", VA = "0x46D3D14")]
		public void Polyline(NativeArray<float3> points, Color color)
		{
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x46D3DB4", Offset = "0x46CFDB4", VA = "0x46D3DB4")]
		public void WireBox(float3 center, float3 size, Color color)
		{
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x46D3F08", Offset = "0x46CFF08", VA = "0x46D3F08")]
		public void WireBox(float3 center, quaternion rotation, float3 size, Color color)
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x46D40D4", Offset = "0x46D00D4", VA = "0x46D40D4")]
		public void WireBox(Bounds bounds, Color color)
		{
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x46D41D8", Offset = "0x46D01D8", VA = "0x46D41D8")]
		public void WireMesh(Mesh mesh, Color color)
		{
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x46D4370", Offset = "0x46D0370", VA = "0x46D4370")]
		public void WireMesh(NativeArray<float3> vertices, NativeArray<int> triangles, Color color)
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x46D44B4", Offset = "0x46D04B4", VA = "0x46D44B4")]
		public void Cross(float3 position, float size, Color color)
		{
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x46D45D8", Offset = "0x46D05D8", VA = "0x46D45D8")]
		public void Cross(float3 position, Color color)
		{
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x46D4688", Offset = "0x46D0688", VA = "0x46D4688")]
		[Obsolete("Use Draw.xz.Cross instead")]
		public void CrossXZ(float3 position, float size, Color color)
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x46D4784", Offset = "0x46D0784", VA = "0x46D4784")]
		[Obsolete("Use Draw.xz.Cross instead")]
		public void CrossXZ(float3 position, Color color)
		{
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x46D4834", Offset = "0x46D0834", VA = "0x46D4834")]
		[Obsolete("Use Draw.xy.Cross instead")]
		public void CrossXY(float3 position, float size, Color color)
		{
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x46D4930", Offset = "0x46D0930", VA = "0x46D4930")]
		[Obsolete("Use Draw.xy.Cross instead")]
		public void CrossXY(float3 position, Color color)
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x46D49E0", Offset = "0x46D09E0", VA = "0x46D49E0")]
		public void Bezier(float3 p0, float3 p1, float3 p2, float3 p3, Color color)
		{
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x46D4B58", Offset = "0x46D0B58", VA = "0x46D4B58")]
		public void Arrow(float3 from, float3 to, Color color)
		{
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x46D4FA4", Offset = "0x46D0FA4", VA = "0x46D4FA4")]
		public void Arrow(float3 from, float3 to, float3 up, float headSize, Color color)
		{
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x46D4C64", Offset = "0x46D0C64", VA = "0x46D4C64")]
		public void ArrowRelativeSizeHead(float3 from, float3 to, float3 up, float headFraction, Color color)
		{
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x46D5144", Offset = "0x46D1144", VA = "0x46D5144")]
		public void ArrowheadArc(float3 origin, float3 direction, float offset, float width, Color color)
		{
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x46D555C", Offset = "0x46D155C", VA = "0x46D555C")]
		public void ArrowheadArc(float3 origin, float3 direction, float offset, Color color)
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x46D5670", Offset = "0x46D1670", VA = "0x46D5670")]
		public void WireGrid(float3 center, quaternion rotation, int2 cells, float2 totalSize, Color color)
		{
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x46D58E0", Offset = "0x46D18E0", VA = "0x46D58E0")]
		public void WireRectangle(float3 center, quaternion rotation, float2 size, Color color)
		{
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x46D5B70", Offset = "0x46D1B70", VA = "0x46D5B70")]
		[Obsolete("Use Draw.xy.WireRectangle instead")]
		public void WireRectangle(Rect rect, Color color)
		{
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x46D5DC8", Offset = "0x46D1DC8", VA = "0x46D5DC8")]
		public void WirePlane(float3 center, float3 normal, float2 size, Color color)
		{
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x46D5A04", Offset = "0x46D1A04", VA = "0x46D5A04")]
		public void WirePlane(float3 center, quaternion rotation, float2 size, Color color)
		{
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x46D5F54", Offset = "0x46D1F54", VA = "0x46D5F54")]
		public void SolidBox(float3 center, float3 size, Color color)
		{
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x46D60A8", Offset = "0x46D20A8", VA = "0x46D60A8")]
		public void SolidBox(Bounds bounds, Color color)
		{
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x46D61AC", Offset = "0x46D21AC", VA = "0x46D61AC")]
		public void SolidBox(float3 center, quaternion rotation, float3 size, Color color)
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x46D654C", Offset = "0x46D254C", VA = "0x46D654C")]
		public static void Initialize_0024JobWireMesh_WireMesh_000000D1_0024BurstDirectCall()
		{
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x46D65A4", Offset = "0x46D25A4", VA = "0x46D65A4")]
		public static void Initialize_0024JobWireMesh_Execute_000000D2_0024BurstDirectCall()
		{
		}
	}
}
