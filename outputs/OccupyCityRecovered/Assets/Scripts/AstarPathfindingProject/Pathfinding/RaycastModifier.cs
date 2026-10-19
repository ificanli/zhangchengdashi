using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	[Serializable]
	[Token(Token = "0x2000123")]
	[HelpURL("https://arongranberg.com/astar/documentation/stable/raycastmodifier.html")]
	[RequireComponent(typeof(Seeker))]
	[AddComponentMenu("Pathfinding/Modifiers/Raycast Modifier")]
	public class RaycastModifier : MonoModifier
	{
		[Token(Token = "0x2000124")]
		public enum Quality
		{
			[Token(Token = "0x4000637")]
			Low = 0,
			[Token(Token = "0x4000638")]
			Medium = 1,
			[Token(Token = "0x4000639")]
			High = 2,
			[Token(Token = "0x400063A")]
			Highest = 3
		}

		[Token(Token = "0x400062A")]
		[FieldOffset(Offset = "0x30")]
		public bool useRaycasting;

		[Token(Token = "0x400062B")]
		[FieldOffset(Offset = "0x34")]
		public LayerMask mask;

		[Token(Token = "0x400062C")]
		[FieldOffset(Offset = "0x38")]
		[Tooltip("Checks around the line between two points, not just the exact line.\nMake sure the ground is either too far below or is not inside the mask since otherwise the raycast might always hit the ground.")]
		public bool thickRaycast;

		[Token(Token = "0x400062D")]
		[FieldOffset(Offset = "0x3C")]
		[Tooltip("Distance from the ray which will be checked for colliders")]
		public float thickRaycastRadius;

		[Token(Token = "0x400062E")]
		[FieldOffset(Offset = "0x40")]
		[Tooltip("Check for intersections with 2D colliders instead of 3D colliders.")]
		public bool use2DPhysics;

		[Token(Token = "0x400062F")]
		[FieldOffset(Offset = "0x44")]
		[Tooltip("Offset from the original positions to perform the raycast.\nCan be useful to avoid the raycast intersecting the ground or similar things you do not want to it intersect")]
		public Vector3 raycastOffset;

		[Token(Token = "0x4000630")]
		[FieldOffset(Offset = "0x50")]
		[Tooltip("Use raycasting on the graphs. Only currently works with GridGraph and NavmeshGraph and RecastGraph. This is a pro version feature.")]
		public bool useGraphRaycasting;

		[Token(Token = "0x4000631")]
		[FieldOffset(Offset = "0x54")]
		[Tooltip("When using the high quality mode the script will try harder to find a shorter path. This is significantly slower than the greedy low quality approach.")]
		public Quality quality;

		[Token(Token = "0x4000632")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int[] iterationsByQuality;

		[Token(Token = "0x4000633")]
		[FieldOffset(Offset = "0x8")]
		private static List<Vector3> buffer;

		[Token(Token = "0x4000634")]
		[FieldOffset(Offset = "0x10")]
		private static float[] DPCosts;

		[Token(Token = "0x4000635")]
		[FieldOffset(Offset = "0x18")]
		private static int[] DPParents;

		[Token(Token = "0x170001C6")]
		public override int Order
		{
			[Token(Token = "0x60009BC")]
			[Address(RVA = "0x4555734", Offset = "0x4551734", VA = "0x4555734", Slot = "20")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60009BD")]
		[Address(RVA = "0x455573C", Offset = "0x455173C", VA = "0x455573C", Slot = "22")]
		public override void Apply(Path p)
		{
		}

		[Token(Token = "0x60009BE")]
		[Address(RVA = "0x45563A8", Offset = "0x45523A8", VA = "0x45563A8")]
		private List<Vector3> ApplyGreedy(Path p, List<Vector3> points, ref TraversalConstraint traversalConstraint)
		{
			return null;
		}

		[Token(Token = "0x60009BF")]
		[Address(RVA = "0x45568D8", Offset = "0x45528D8", VA = "0x45568D8")]
		private List<Vector3> ApplyDP(Path p, List<Vector3> points, ref TraversalConstraint traversalConstraint)
		{
			return null;
		}

		[Token(Token = "0x60009C0")]
		[Address(RVA = "0x4555AFC", Offset = "0x4551AFC", VA = "0x4555AFC")]
		protected bool ValidateLine(GraphNode n1, GraphNode n2, Vector3 v1, Vector3 v2, ref TraversalConstraint traversalConstraint)
		{
			return default;
		}

		[Token(Token = "0x60009C1")]
		[Address(RVA = "0x4557078", Offset = "0x4553078", VA = "0x4557078")]
		public RaycastModifier()
		{
		}
	}
}
