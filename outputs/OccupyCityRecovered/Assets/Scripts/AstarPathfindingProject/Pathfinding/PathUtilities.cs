using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Pathfinding.Util;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;

namespace Pathfinding
{
	[Token(Token = "0x2000165")]
	public static class PathUtilities
	{
		[Token(Token = "0x2000166")]
		[BurstCompile(FloatMode = FloatMode.Fast)]
		private struct JobFormationPacked : IJob
		{
			[Token(Token = "0x2000167")]
			private struct DistanceComparer : IComparer<int>
			{
				[Token(Token = "0x4000751")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public NativeArray<float2> positions;

				[Token(Token = "0x6000B62")]
				[Address(RVA = "0x457F000", Offset = "0x457B000", VA = "0x457F000", Slot = "4")]
				public int Compare(int x, int y)
				{
					return default;
				}
			}

			[Token(Token = "0x400074D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public NativeArray<float3> positions;

			[Token(Token = "0x400074E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float3 destination;

			[Token(Token = "0x400074F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float agentRadius;

			[Token(Token = "0x4000750")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public NativeMovementPlane movementPlane;

			[Token(Token = "0x6000B60")]
			[Address(RVA = "0x457EAF0", Offset = "0x457AAF0", VA = "0x457EAF0")]
			public float CollisionTime(float2 pos1, float2 pos2, float2 v1, float2 v2, float r1, float r2)
			{
				return default;
			}

			[Token(Token = "0x6000B61")]
			[Address(RVA = "0x457ECBC", Offset = "0x457ACBC", VA = "0x457ECBC", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Token(Token = "0x2000168")]
		public enum FormationMode
		{
			[Token(Token = "0x4000753")]
			SinglePoint = 0,
			[Token(Token = "0x4000754")]
			Packed = 1
		}

		[Token(Token = "0x400074B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Queue<GraphNode> BFSQueue;

		[Token(Token = "0x400074C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Dictionary<GraphNode, int> BFSMap;

		[Token(Token = "0x6000B53")]
		[Address(RVA = "0x457C330", Offset = "0x4578330", VA = "0x457C330")]
		public static bool IsPathPossible(GraphNode node1, GraphNode node2)
		{
			return default;
		}

		[Token(Token = "0x6000B54")]
		[Address(RVA = "0x457C3A0", Offset = "0x45783A0", VA = "0x457C3A0")]
		public static bool IsPathPossible(List<GraphNode> nodes)
		{
			return default;
		}

		[Token(Token = "0x6000B55")]
		[Address(RVA = "0x457C494", Offset = "0x4578494", VA = "0x457C494")]
		public static bool IsPathPossible(List<GraphNode> nodes, int tagMask)
		{
			return default;
		}

		[Token(Token = "0x6000B56")]
		[Address(RVA = "0x457C618", Offset = "0x4578618", VA = "0x457C618")]
		public static List<GraphNode> GetReachableNodes(GraphNode seed, [Optional][DefaultParameterValue(-1)] int tagMask, [Optional] Func<GraphNode, bool> filter)
		{
			return null;
		}

		[Token(Token = "0x6000B57")]
		[Address(RVA = "0x457C880", Offset = "0x4578880", VA = "0x457C880")]
		public static List<GraphNode> BFS(GraphNode seed, int depth, [Optional][DefaultParameterValue(-1)] int tagMask, [Optional] Func<GraphNode, bool> filter)
		{
			return null;
		}

		[Token(Token = "0x6000B58")]
		[Address(RVA = "0x457CBBC", Offset = "0x4578BBC", VA = "0x457CBBC")]
		public static List<Vector3> GetSpiralPoints(int count, float clearance)
		{
			return null;
		}

		[Token(Token = "0x6000B59")]
		[Address(RVA = "0x457CEB8", Offset = "0x4578EB8", VA = "0x457CEB8")]
		private static Vector3 InvoluteOfCircle(float a, float t)
		{
			return default;
		}

		[Token(Token = "0x6000B5A")]
		[Address(RVA = "0x457CF04", Offset = "0x4578F04", VA = "0x457CF04")]
		public static void GetPointsAroundPointWorld(Vector3 p, IRaycastableGraph g, List<Vector3> previousPoints, float radius, float clearanceRadius)
		{
		}

		[Token(Token = "0x6000B5B")]
		[Address(RVA = "0x457D0BC", Offset = "0x45790BC", VA = "0x457D0BC")]
		public static void GetPointsAroundPoint(Vector3 center, IRaycastableGraph g, List<Vector3> previousPoints, float radius, float clearanceRadius)
		{
		}

		[Token(Token = "0x6000B5C")]
		[Address(RVA = "0x457D634", Offset = "0x4579634", VA = "0x457D634")]
		public static void FormationPacked(List<Vector3> currentPositions, Vector3 destination, float clearanceRadius, NativeMovementPlane movementPlane)
		{
		}

		[Token(Token = "0x6000B5D")]
		[Address(RVA = "0x457D850", Offset = "0x4579850", VA = "0x457D850")]
		public static List<Vector3> FormationDestinations(List<IAstarAI> group, Vector3 destination, FormationMode formationMode, float marginFactor = 0.1f)
		{
			return null;
		}

		[Token(Token = "0x6000B5E")]
		[Address(RVA = "0x457DDC8", Offset = "0x4579DC8", VA = "0x457DDC8")]
		public static void GetPointsAroundPointWorldFlexible(Vector3 center, Quaternion rotation, List<Vector3> positions)
		{
		}

		[Token(Token = "0x6000B5F")]
		[Address(RVA = "0x457E514", Offset = "0x457A514", VA = "0x457E514")]
		public static List<Vector3> GetPointsOnNodes(List<GraphNode> nodes, int count, float clearanceRadius = 0f)
		{
			return null;
		}
	}
}
