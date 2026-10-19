using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AOT;
using Il2CppDummyDll;
using Pathfinding.Clipper2Lib;
using Pathfinding.Collections;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Mathematics;
using Unity.Profiling;
using UnityEngine;
using andywiecko.BurstTriangulator.LowLevel.Unsafe;

namespace Pathfinding.Graphs.Navmesh
{
	[Token(Token = "0x20001C4")]
	[BurstCompile]
	public static class TileHandler
	{
		[Token(Token = "0x20001C5")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate bool CutFunction(ref UnsafeSpan<Point64Wrapper> subject, ref UnsafeSpan<UnsafeSpan<Point64Wrapper>> contours, ref UnsafeSpan<UnsafeSpan<Point64Wrapper>> contoursDual, ref UnsafeList<Vector2Int> outputVertices, ref UnsafeList<int> outputVertexCountPerPolygon, int dual);

		[Token(Token = "0x20001C6")]
		private struct CutFunctionKey
		{
		}

		[Token(Token = "0x20001C7")]
		internal struct TileCuts
		{
			[Token(Token = "0x400088E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int contourStartIndex;

			[Token(Token = "0x400088F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int contourEndIndex;
		}

		[Token(Token = "0x20001C8")]
		internal struct ContourMeta
		{
			[Token(Token = "0x4000890")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool isDual;

			[Token(Token = "0x4000891")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool cutsAddedGeom;
		}

		[Token(Token = "0x20001C9")]
		internal struct CutCollection : IDisposable
		{
			[Token(Token = "0x4000892")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public UnsafeList<Point64Wrapper> contourVertices;

			[Token(Token = "0x4000893")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UnsafeList<NavmeshCut.ContourBurst> contours;

			[Token(Token = "0x4000894")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public UnsafeList<ContourMeta> contoursExtra;

			[Token(Token = "0x4000895")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public UnsafeList<TileCuts> tileCuts;

			[Token(Token = "0x4000896")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
			public bool cuttingRequired;

			[Token(Token = "0x6000CCF")]
			[Address(RVA = "0x459791C", Offset = "0x459391C", VA = "0x459791C", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Token(Token = "0x20001CA")]
		public struct Point64Wrapper
		{
			[Token(Token = "0x4000897")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public long x;

			[Token(Token = "0x4000898")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public long y;

			[Token(Token = "0x6000CD0")]
			[Address(RVA = "0x459A97C", Offset = "0x459697C", VA = "0x459A97C")]
			public Point64Wrapper(long x, long y)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED TileHandler.Point64Wrapper..ctor RVA=0x459A97C Token=0x6000CD0");
}
		}

		[Token(Token = "0x20001CB")]
		public delegate void ConvertVerticesAndSnapToTileBoundaries_00000BB5_0024PostfixBurstDelegate(ref UnsafeSpan<float2> contourVertices, out UnsafeList<Point64Wrapper> outputVertices, ref Vector2 tileSize);

		[Token(Token = "0x20001CC")]
		internal static class ConvertVerticesAndSnapToTileBoundaries_00000BB5_0024BurstDirectCall
		{
			[Token(Token = "0x4000899")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			[Token(Token = "0x400089A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;

			[Token(Token = "0x6000CD5")]
			[Address(RVA = "0x459F2CC", Offset = "0x459B2CC", VA = "0x459F2CC")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr P_0)
			{
			}

			[Token(Token = "0x6000CD6")]
			[Address(RVA = "0x459F3E8", Offset = "0x459B3E8", VA = "0x459F3E8")]
			private static IntPtr GetFunctionPointer()
			{
				return default;
			}

			[Token(Token = "0x6000CD7")]
			[Address(RVA = "0x459F444", Offset = "0x459B444", VA = "0x459F444")]
			public static void Constructor()
			{
			}

			[Token(Token = "0x6000CD8")]
			[Address(RVA = "0x459F4EC", Offset = "0x459B4EC", VA = "0x459F4EC")]
			public static void Initialize()
			{
			}

			[Token(Token = "0x6000CDA")]
			[Address(RVA = "0x4598BF4", Offset = "0x4594BF4", VA = "0x4598BF4")]
			public static void Invoke(ref UnsafeSpan<float2> contourVertices, out UnsafeList<Point64Wrapper> outputVertices, ref Vector2 tileSize)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED TileHandler.ConvertVerticesAndSnapToTileBoundaries_00000BB5_0024BurstDirectCall.Invoke RVA=0x4598BF4 Token=0x6000CDA");
}
		}

		[Token(Token = "0x20001CD")]
		internal delegate void CutTiles_00000BB6_0024PostfixBurstDelegate(ref UnsafeSpan<UnsafeList<UnsafeSpan<Int3>>> tileVertices, ref UnsafeSpan<UnsafeList<UnsafeSpan<int>>> tileTriangles, ref UnsafeSpan<UnsafeList<UnsafeSpan<int>>> tileTags, ref Vector2Int tileSize, ref CutCollection cutCollection, ref UnsafeSpan<TileMesh.TileMeshUnsafe> output, Allocator allocator);

		[Token(Token = "0x20001CE")]
		internal static class CutTiles_00000BB6_0024BurstDirectCall
		{
			[Token(Token = "0x400089B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			[Token(Token = "0x400089C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;

			[Token(Token = "0x6000CDF")]
			[Address(RVA = "0x459F74C", Offset = "0x459B74C", VA = "0x459F74C")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr P_0)
			{
			}

			[Token(Token = "0x6000CE0")]
			[Address(RVA = "0x459F868", Offset = "0x459B868", VA = "0x459F868")]
			private static IntPtr GetFunctionPointer()
			{
				return default;
			}

			[Token(Token = "0x6000CE1")]
			[Address(RVA = "0x459F8C4", Offset = "0x459B8C4", VA = "0x459F8C4")]
			public static void Constructor()
			{
			}

			[Token(Token = "0x6000CE2")]
			[Address(RVA = "0x459F96C", Offset = "0x459B96C", VA = "0x459F96C")]
			public static void Initialize()
			{
			}

			[Token(Token = "0x6000CE4")]
			[Address(RVA = "0x4598CE0", Offset = "0x4594CE0", VA = "0x4598CE0")]
			public static void Invoke(ref UnsafeSpan<UnsafeList<UnsafeSpan<Int3>>> tileVertices, ref UnsafeSpan<UnsafeList<UnsafeSpan<int>>> tileTriangles, ref UnsafeSpan<UnsafeList<UnsafeSpan<int>>> tileTags, ref Vector2Int tileSize, ref CutCollection cutCollection, ref UnsafeSpan<TileMesh.TileMeshUnsafe> output, Allocator allocator)
			{
			}
		}

		[Token(Token = "0x400087C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly ProfilerMarker MarkerTriangulate;

		[Token(Token = "0x400087D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly ProfilerMarker MarkerClipping;

		[Token(Token = "0x400087E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly ProfilerMarker MarkerPrepare;

		[Token(Token = "0x400087F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly ProfilerMarker MarkerAllocate;

		[Token(Token = "0x4000880")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static readonly ProfilerMarker MarkerCore;

		[Token(Token = "0x4000881")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static readonly ProfilerMarker MarkerCompress;

		[Token(Token = "0x4000882")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static readonly ProfilerMarker MarkerRemoveDegenerateTriangles;

		[Token(Token = "0x4000883")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static readonly ProfilerMarker MarkerRefine;

		[Token(Token = "0x4000884")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static readonly ProfilerMarker MarkerEdgeSnapping;

		[Token(Token = "0x4000885")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static readonly ProfilerMarker MarkerRemoveDegenerateLines;

		[Token(Token = "0x4000886")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static readonly ProfilerMarker MarkerClipHorizontal;

		[Token(Token = "0x4000887")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static readonly ProfilerMarker MarkerCopyClippingResult;

		[Token(Token = "0x4000888")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static readonly ProfilerMarker CopyTriangulationToOutputMarker;

		[Token(Token = "0x4000889")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static readonly SharedStatic<IntPtr> CutFunctionPtr;

		[Token(Token = "0x400088A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static CutFunction DelegateGCRoot;

		[Token(Token = "0x400088B")]
		private const int EdgeSnappingMaxDistance = 1;

		[Token(Token = "0x400088C")]
		private const int Scale = 16;

		[Token(Token = "0x400088D")]
		public const int TileSnappingMaxDistance = 20;

		[Token(Token = "0x6000CB1")]
		[Address(RVA = "0x4596D0C", Offset = "0x4592D0C", VA = "0x4596D0C")]
		internal static CutCollection CollectCuts(GridLookup<NavmeshClipper> cuts, List<Vector2Int> tileCoordinates, float characterRadius, TileLayout tileLayout, ref UnsafeSpan<UnsafeList<UnsafeSpan<Int3>>> tileVertices, ref UnsafeSpan<UnsafeList<UnsafeSpan<int>>> tileTriangles, ref UnsafeSpan<UnsafeList<UnsafeSpan<int>>> tileTags)
		{
			return default;
		}

		[Token(Token = "0x6000CB2")]
		[Address(RVA = "0x4598B88", Offset = "0x4594B88", VA = "0x4598B88")]
		[BurstCompile]
		private static void ConvertVerticesAndSnapToTileBoundaries(ref UnsafeSpan<float2> contourVertices, out UnsafeList<Point64Wrapper> outputVertices, ref Vector2 tileSize)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED TileHandler.ConvertVerticesAndSnapToTileBoundaries RVA=0x4598B88 Token=0x6000CB2");
}

		[Token(Token = "0x6000CB3")]
		[Address(RVA = "0x4598644", Offset = "0x4594644", VA = "0x4598644")]
		[BurstCompile]
		internal static void CutTiles(ref UnsafeSpan<UnsafeList<UnsafeSpan<Int3>>> tileVertices, ref UnsafeSpan<UnsafeList<UnsafeSpan<int>>> tileTriangles, ref UnsafeSpan<UnsafeList<UnsafeSpan<int>>> tileTags, ref Vector2Int tileSize, ref CutCollection cutCollection, ref UnsafeSpan<TileMesh.TileMeshUnsafe> output, Allocator allocator)
		{
		}

		[Token(Token = "0x6000CB4")]
		[Address(RVA = "0x4598E14", Offset = "0x4594E14", VA = "0x4598E14")]
		private static void ScaleUpCoordinates(UnsafeSpan<long> coords)
		{
		}

		[Token(Token = "0x6000CB5")]
		[Address(RVA = "0x4598E90", Offset = "0x4594E90", VA = "0x4598E90")]
		private static void ScaleDownCoordinates(UnsafeSpan<int> coords)
		{
		}

		[Token(Token = "0x6000CB6")]
		[Address(RVA = "0x4598F18", Offset = "0x4594F18", VA = "0x4598F18")]
		private static void RemoveDegenerateSegments(ref UnsafeSpan<int2> polygon)
		{
		}

		[Token(Token = "0x6000CB7")]
		[Address(RVA = "0x45990B8", Offset = "0x45950B8", VA = "0x45990B8")]
		private static void CollectCutsTouchingBounds(UnsafeSpan<IntBounds> cutBounds, NativeList<int> outputCutIndices, IntBounds bounds)
		{
		}

		[Token(Token = "0x6000CB8")]
		[Address(RVA = "0x45991E4", Offset = "0x45951E4", VA = "0x45991E4")]
		private static IntBounds TriangleBounds(Int3 a, Int3 b, Int3 c)
		{
			return default;
		}

		[Token(Token = "0x6000CB9")]
		[Address(RVA = "0x459927C", Offset = "0x459527C", VA = "0x459927C")]
		private static TileMesh.TileMeshUnsafe CompressAndRefineTile(NativeList<Int3> tileOutputVertices, NativeList<int> tileOutputTriangles, NativeList<int> tileOutputTags, Allocator allocator)
		{
			return default;
		}

		[Token(Token = "0x6000CBA")]
		[Address(RVA = "0x459A0A4", Offset = "0x45960A4", VA = "0x459A0A4")]
		private static void CopyTriangulationToOutput(ref OutputData<int2> triangulatorOutput, NativeList<Int3> tileOutputVertices, NativeList<int> tileOutputTriangles, NativeList<int> tileOutputTags, int tag, Int3 a, Int3 b, Int3 c)
		{
		}

		[Token(Token = "0x6000CBB")]
		[Address(RVA = "0x459A41C", Offset = "0x459641C", VA = "0x459A41C")]
		private static void SnapEdges(ref NativeArray<Point64Wrapper> triBuffer, ref int vertexCount, UnsafeSpan<UnsafeSpan<Point64Wrapper>> contours, Vector2Int tileSize)
		{
		}

		[Token(Token = "0x6000CBC")]
		[Address(RVA = "0x459A984", Offset = "0x4596984", VA = "0x459A984")]
		private static NativeArray<IntBounds> CalculateCutBounds(ref CutCollection cutCollection, ref UnsafeList<Point64Wrapper> contourVerticesP64)
		{
			return default;
		}

		[Token(Token = "0x6000CBD")]
		[Address(RVA = "0x459ABB8", Offset = "0x4596BB8", VA = "0x459ABB8")]
		private static void AddContours(Clipper64 clipper, ref UnsafeSpan<UnsafeSpan<Point64Wrapper>> contours)
		{
		}

		[Token(Token = "0x6000CBE")]
		[Address(RVA = "0x459ACDC", Offset = "0x4596CDC", VA = "0x459ACDC")]
		private static void CopyClipperOutput(List<List<Point64>> closedSolutions, ref UnsafeList<Vector2Int> outputVertices, ref UnsafeList<int> outputVertexCountPerPolygon)
		{
		}

		[Token(Token = "0x6000CBF")]
		[Address(RVA = "0x4598754", Offset = "0x4594754", VA = "0x4598754")]
		[MonoPInvokeCallback(typeof(CutFunction))]
		private static bool CutPolygon(ref UnsafeSpan<Point64Wrapper> subject, ref UnsafeSpan<UnsafeSpan<Point64Wrapper>> contours, ref UnsafeSpan<UnsafeSpan<Point64Wrapper>> contoursDual, ref UnsafeList<Vector2Int> outputVertices, ref UnsafeList<int> outputVertexCountPerPolygon, int mode)
		{
			return default;
		}

		[Token(Token = "0x6000CC0")]
		[Address(RVA = "0x45979D4", Offset = "0x45939D4", VA = "0x45979D4")]
		internal static void InitDelegates()
		{
		}

		[Token(Token = "0x6000CC1")]
		[Address(RVA = "0x459AF40", Offset = "0x4596F40", VA = "0x459AF40")]
		private static int ClipAgainstRectangle(UnsafeSpan<Int3> clipIn, UnsafeSpan<Int3> clipTmp, Vector2Int size)
		{
			return default;
		}

		[Token(Token = "0x6000CC2")]
		[Address(RVA = "0x459B388", Offset = "0x4597388", VA = "0x459B388")]
		private static bool ClipAgainstHalfPlane(UnsafeSpan<Point64Wrapper> clipIn, NativeList<Point64Wrapper> clipOut, Point64Wrapper a, Point64Wrapper b)
		{
			return default;
		}

		[Token(Token = "0x6000CC3")]
		[Address(RVA = "0x459B8D4", Offset = "0x45978D4", VA = "0x459B8D4")]
		private static void ClipAgainstHorizontalHalfPlane(ref UnsafeSpan<Point64Wrapper> contourVertices, NativeList<Point64Wrapper> scratchVertices, int h, Int3 a, Int3 b, Int3 c, bool preserveBelow)
		{
		}

		[Token(Token = "0x6000CC4")]
		[Address(RVA = "0x459954C", Offset = "0x459554C", VA = "0x459954C")]
		private static int DelaunayRefinement(UnsafeSpan<Int3> verts, UnsafeSpan<int> tris, UnsafeSpan<int> tags, bool delaunay, bool colinear)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000CC9")]
		[Address(RVA = "0x459C6B8", Offset = "0x45986B8", VA = "0x459C6B8")]
		[BurstCompile]
		public static void ConvertVerticesAndSnapToTileBoundaries_0024BurstManaged(ref UnsafeSpan<float2> contourVertices, out UnsafeList<Point64Wrapper> outputVertices, ref Vector2 tileSize)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED TileHandler.ConvertVerticesAndSnapToTileBoundaries_0024BurstManaged RVA=0x459C6B8 Token=0x6000CC9");
}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000CCA")]
		[Address(RVA = "0x459CBC8", Offset = "0x4598BC8", VA = "0x459CBC8")]
		[BurstCompile]
		internal static void CutTiles_0024BurstManaged(ref UnsafeSpan<UnsafeList<UnsafeSpan<Int3>>> tileVertices, ref UnsafeSpan<UnsafeList<UnsafeSpan<int>>> tileTriangles, ref UnsafeSpan<UnsafeList<UnsafeSpan<int>>> tileTags, ref Vector2Int tileSize, ref CutCollection cutCollection, ref UnsafeSpan<TileMesh.TileMeshUnsafe> output, Allocator allocator)
		{
		}
	}
}
