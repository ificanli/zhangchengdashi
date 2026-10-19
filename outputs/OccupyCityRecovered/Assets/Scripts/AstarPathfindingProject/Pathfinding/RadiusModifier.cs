using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	[Token(Token = "0x2000121")]
	[HelpURL("https://arongranberg.com/astar/documentation/stable/radiusmodifier.html")]
	[AddComponentMenu("Pathfinding/Modifiers/Radius Offset Modifier")]
	public class RadiusModifier : MonoModifier
	{
		[Token(Token = "0x2000122")]
		[Flags]
		private enum TangentType
		{
			[Token(Token = "0x4000624")]
			OuterRight = 1,
			[Token(Token = "0x4000625")]
			InnerRightLeft = 2,
			[Token(Token = "0x4000626")]
			InnerLeftRight = 4,
			[Token(Token = "0x4000627")]
			OuterLeft = 8,
			[Token(Token = "0x4000628")]
			Outer = OuterRight | OuterLeft,
			[Token(Token = "0x4000629")]
			Inner = InnerRightLeft | InnerLeftRight
		}

		[Token(Token = "0x400061D")]
		[FieldOffset(Offset = "0x30")]
		public float radius;

		[Token(Token = "0x400061E")]
		[FieldOffset(Offset = "0x34")]
		public float detail;

		[Token(Token = "0x400061F")]
		[FieldOffset(Offset = "0x38")]
		private float[] radi;

		[Token(Token = "0x4000620")]
		[FieldOffset(Offset = "0x40")]
		private float[] a1;

		[Token(Token = "0x4000621")]
		[FieldOffset(Offset = "0x48")]
		private float[] a2;

		[Token(Token = "0x4000622")]
		[FieldOffset(Offset = "0x50")]
		private bool[] dir;

		[Token(Token = "0x170001C5")]
		public override int Order
		{
			[Token(Token = "0x60009B4")]
			[Address(RVA = "0x45545F8", Offset = "0x45505F8", VA = "0x45545F8", Slot = "20")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60009B5")]
		[Address(RVA = "0x4554600", Offset = "0x4550600", VA = "0x4554600")]
		private bool CalculateCircleInner(Vector3 p1, Vector3 p2, float r1, float r2, out float a, out float sigma)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED RadiusModifier.CalculateCircleInner RVA=0x4554600 Token=0x60009B5");
}

		[Token(Token = "0x60009B6")]
		[Address(RVA = "0x4554748", Offset = "0x4550748", VA = "0x4554748")]
		private bool CalculateCircleOuter(Vector3 p1, Vector3 p2, float r1, float r2, out float a, out float sigma)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED RadiusModifier.CalculateCircleOuter RVA=0x4554748 Token=0x60009B6");
}

		[Token(Token = "0x60009B7")]
		[Address(RVA = "0x45548A4", Offset = "0x45508A4", VA = "0x45548A4")]
		private TangentType CalculateTangentType(Vector3 p1, Vector3 p2, Vector3 p3, Vector3 p4)
		{
			return default;
		}

		[Token(Token = "0x60009B8")]
		[Address(RVA = "0x4554950", Offset = "0x4550950", VA = "0x4554950")]
		private TangentType CalculateTangentTypeSimple(Vector3 p1, Vector3 p2, Vector3 p3)
		{
			return default;
		}

		[Token(Token = "0x60009B9")]
		[Address(RVA = "0x4554994", Offset = "0x4550994", VA = "0x4554994", Slot = "22")]
		public override void Apply(Path p)
		{
		}

		[Token(Token = "0x60009BA")]
		[Address(RVA = "0x4554A30", Offset = "0x4550A30", VA = "0x4554A30")]
		public List<Vector3> Apply(List<Vector3> vs)
		{
			return null;
		}

		[Token(Token = "0x60009BB")]
		[Address(RVA = "0x4555684", Offset = "0x4551684", VA = "0x4555684")]
		public RadiusModifier()
		{
		}
	}
}
