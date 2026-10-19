using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace BrainFailProductions.PolyFew.UnityMeshSimplifier
{
	[Token(Token = "0x2000023")]
	public struct Vector3d : IEquatable<Vector3d>
	{
		[Token(Token = "0x40000F0")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Vector3d zero;

		[Token(Token = "0x40000F1")]
		public const double Epsilon = double.Epsilon;

		[Token(Token = "0x40000F2")]
		[FieldOffset(Offset = "0x0")]
		public double x;

		[Token(Token = "0x40000F3")]
		[FieldOffset(Offset = "0x8")]
		public double y;

		[Token(Token = "0x40000F4")]
		[FieldOffset(Offset = "0x10")]
		public double z;

		[Token(Token = "0x1700003F")]
		public double Magnitude
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x6000154")]
			[Address(RVA = "0x856D0E0", Offset = "0x85690E0", VA = "0x856D0E0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000040")]
		public double MagnitudeSqr
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x6000155")]
			[Address(RVA = "0x856D160", Offset = "0x8569160", VA = "0x856D160")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000041")]
		public Vector3d Normalized
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x6000156")]
			[Address(RVA = "0x856D180", Offset = "0x8569180", VA = "0x856D180")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000042")]
		public double this[int index]
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x6000157")]
			[Address(RVA = "0x856D1F8", Offset = "0x85691F8", VA = "0x856D1F8")]
			get
			{
				return default;
			}
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x6000158")]
			[Address(RVA = "0x856D270", Offset = "0x8569270", VA = "0x856D270")]
			set
			{
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000159")]
		[Address(RVA = "0x856D2E8", Offset = "0x85692E8", VA = "0x856D2E8")]
		public Vector3d(double value)
		{
			// Recovered from ARM64 RVA 0x856D2E8.
			x = value;
			y = value;
			z = value;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600015A")]
		[Address(RVA = "0x856D2F4", Offset = "0x85692F4", VA = "0x856D2F4")]
		public Vector3d(double x, double y, double z)
		{
			// Recovered from ARM64 RVA 0x856D2F4.
			this.x = x;
			this.y = y;
			this.z = z;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600015B")]
		[Address(RVA = "0x856D300", Offset = "0x8569300", VA = "0x856D300")]
		public Vector3d(Vector3 vector)
		{
			// RVA 0x856D300 explicitly widens three float32 components to float64.
			x = vector.x;
			y = vector.y;
			z = vector.z;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600015C")]
		[Address(RVA = "0x856D318", Offset = "0x8569318", VA = "0x856D318")]
		public static Vector3d operator +(Vector3d a, Vector3d b)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600015D")]
		[Address(RVA = "0x856D328", Offset = "0x8569328", VA = "0x856D328")]
		public static Vector3d operator -(Vector3d a, Vector3d b)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600015E")]
		[Address(RVA = "0x856D338", Offset = "0x8569338", VA = "0x856D338")]
		public static Vector3d operator *(Vector3d a, double d)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600015F")]
		[Address(RVA = "0x856D348", Offset = "0x8569348", VA = "0x856D348")]
		public static Vector3d operator *(double d, Vector3d a)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000160")]
		[Address(RVA = "0x856D35C", Offset = "0x856935C", VA = "0x856D35C")]
		public static Vector3d operator /(Vector3d a, double d)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000161")]
		[Address(RVA = "0x856D36C", Offset = "0x856936C", VA = "0x856D36C")]
		public static Vector3d operator -(Vector3d a)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000162")]
		[Address(RVA = "0x856D37C", Offset = "0x856937C", VA = "0x856D37C")]
		public static bool operator ==(Vector3d lhs, Vector3d rhs)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000163")]
		[Address(RVA = "0x856D428", Offset = "0x8569428", VA = "0x856D428")]
		public static bool operator !=(Vector3d lhs, Vector3d rhs)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000164")]
		[Address(RVA = "0x856D4D4", Offset = "0x85694D4", VA = "0x856D4D4")]
		public static implicit operator Vector3d(Vector3 v)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000165")]
		[Address(RVA = "0x856D4E4", Offset = "0x85694E4", VA = "0x856D4E4")]
		public static explicit operator Vector3(Vector3d v)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000166")]
		[Address(RVA = "0x856D4F4", Offset = "0x85694F4", VA = "0x856D4F4")]
		public void Set(double x, double y, double z)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000167")]
		[Address(RVA = "0x856D500", Offset = "0x8569500", VA = "0x856D500")]
		public void Scale(ref Vector3d scale)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000168")]
		[Address(RVA = "0x856D524", Offset = "0x8569524", VA = "0x856D524")]
		public void Normalize()
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000169")]
		[Address(RVA = "0x856D614", Offset = "0x8569614", VA = "0x856D614")]
		public void Clamp(double min, double max)
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x856D674", Offset = "0x8569674", VA = "0x856D674", Slot = "2")]
		public override int GetHashCode()
		{
			return default;
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x856D6DC", Offset = "0x85696DC", VA = "0x856D6DC", Slot = "0")]
		public override bool Equals(object other)
		{
			return default;
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x856D774", Offset = "0x8569774", VA = "0x856D774", Slot = "4")]
		public bool Equals(Vector3d other)
		{
			return default;
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x856D7A4", Offset = "0x85697A4", VA = "0x856D7A4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x856D868", Offset = "0x8569868", VA = "0x856D868")]
		public string ToString(string format)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600016F")]
		[Address(RVA = "0x856D904", Offset = "0x8569904", VA = "0x856D904")]
		public static double Dot(ref Vector3d lhs, ref Vector3d rhs)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000170")]
		[Address(RVA = "0x856D92C", Offset = "0x856992C", VA = "0x856D92C")]
		public static void Cross(ref Vector3d lhs, ref Vector3d rhs, out Vector3d result)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED Vector3d.Cross RVA=0x856D92C Token=0x6000170");
}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000171")]
		[Address(RVA = "0x856D96C", Offset = "0x856996C", VA = "0x856D96C")]
		public static double Angle(ref Vector3d from, ref Vector3d to)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000172")]
		[Address(RVA = "0x856DAE4", Offset = "0x8569AE4", VA = "0x856DAE4")]
		public static void Lerp(ref Vector3d a, ref Vector3d b, double t, out Vector3d result)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED Vector3d.Lerp RVA=0x856DAE4 Token=0x6000172");
}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000173")]
		[Address(RVA = "0x856DB18", Offset = "0x8569B18", VA = "0x856DB18")]
		public static void Scale(ref Vector3d a, ref Vector3d b, out Vector3d result)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED Vector3d.Scale RVA=0x856DB18 Token=0x6000173");
}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000174")]
		[Address(RVA = "0x856DB3C", Offset = "0x8569B3C", VA = "0x856DB3C")]
		public static void Normalize(ref Vector3d value, out Vector3d result)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED Vector3d.Normalize RVA=0x856DB3C Token=0x6000174");
}
	}
}
