using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	[Serializable]
	[Token(Token = "0x2000125")]
	[HelpURL("https://arongranberg.com/astar/documentation/stable/simplesmoothmodifier.html")]
	[AddComponentMenu("Pathfinding/Modifiers/Simple Smooth Modifier")]
	[RequireComponent(typeof(Seeker))]
	public class SimpleSmoothModifier : MonoModifier
	{
		[Token(Token = "0x2000126")]
		public enum SmoothType
		{
			[Token(Token = "0x4000645")]
			Simple = 0,
			[Token(Token = "0x4000646")]
			Bezier = 1,
			[Token(Token = "0x4000647")]
			OffsetSimple = 2,
			[Token(Token = "0x4000648")]
			CurvedNonuniform = 3
		}

		[Token(Token = "0x400063B")]
		[FieldOffset(Offset = "0x30")]
		public SmoothType smoothType;

		[Token(Token = "0x400063C")]
		[FieldOffset(Offset = "0x34")]
		[Tooltip("The number of times to subdivide (divide in half) the path segments. [0...inf] (recommended [1...10])")]
		public int subdivisions;

		[Token(Token = "0x400063D")]
		[FieldOffset(Offset = "0x38")]
		[Tooltip("Number of times to apply smoothing")]
		public int iterations;

		[Token(Token = "0x400063E")]
		[FieldOffset(Offset = "0x3C")]
		[Tooltip("Determines how much smoothing to apply in each smooth iteration. 0.5 usually produces the nicest looking curves")]
		[Range(0f, 1f)]
		public float strength;

		[Token(Token = "0x400063F")]
		[FieldOffset(Offset = "0x40")]
		[Tooltip("Toggle to divide all lines in equal length segments")]
		public bool uniformLength;

		[Token(Token = "0x4000640")]
		[FieldOffset(Offset = "0x44")]
		[Tooltip("The length of each segment in the smoothed path. A high value yields rough paths and low value yields very smooth paths, but is slower")]
		public float maxSegmentLength;

		[Token(Token = "0x4000641")]
		[FieldOffset(Offset = "0x48")]
		[Tooltip("Length factor of the bezier curves' tangents")]
		public float bezierTangentLength;

		[Token(Token = "0x4000642")]
		[FieldOffset(Offset = "0x4C")]
		[Tooltip("Offset to apply in each smoothing iteration when using Offset Simple")]
		public float offset;

		[Token(Token = "0x4000643")]
		[FieldOffset(Offset = "0x50")]
		[Tooltip("How much to smooth the path. A higher value will give a smoother path, but might take the character far off the optimal path.")]
		public float factor;

		[Token(Token = "0x170001C7")]
		public override int Order
		{
			[Token(Token = "0x60009C3")]
			[Address(RVA = "0x455721C", Offset = "0x455321C", VA = "0x455721C", Slot = "20")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60009C4")]
		[Address(RVA = "0x4557224", Offset = "0x4553224", VA = "0x4557224", Slot = "22")]
		public override void Apply(Path p)
		{
		}

		[Token(Token = "0x60009C5")]
		[Address(RVA = "0x4558580", Offset = "0x4554580", VA = "0x4558580")]
		public List<Vector3> CurvedNonuniform(List<Vector3> path)
		{
			return null;
		}

		[Token(Token = "0x60009C6")]
		[Address(RVA = "0x4558E6C", Offset = "0x4554E6C", VA = "0x4558E6C")]
		public static Vector3 GetPointOnCubic(Vector3 a, Vector3 b, Vector3 tan1, Vector3 tan2, float t)
		{
			return default;
		}

		[Token(Token = "0x60009C7")]
		[Address(RVA = "0x4557D58", Offset = "0x4553D58", VA = "0x4557D58")]
		public List<Vector3> SmoothOffsetSimple(List<Vector3> path)
		{
			return null;
		}

		[Token(Token = "0x60009C8")]
		[Address(RVA = "0x4557360", Offset = "0x4553360", VA = "0x4557360")]
		public List<Vector3> SmoothSimple(List<Vector3> path)
		{
			return null;
		}

		[Token(Token = "0x60009C9")]
		[Address(RVA = "0x45579CC", Offset = "0x45539CC", VA = "0x45579CC")]
		public List<Vector3> SmoothBezier(List<Vector3> path)
		{
			return null;
		}

		[Token(Token = "0x60009CA")]
		[Address(RVA = "0x4558F0C", Offset = "0x4554F0C", VA = "0x4558F0C")]
		public SimpleSmoothModifier()
		{
		}
	}
}
