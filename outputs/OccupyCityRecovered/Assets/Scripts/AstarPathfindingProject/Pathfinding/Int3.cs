using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Mathematics;
using Unity.Profiling;
using UnityEngine;

namespace Pathfinding
{
	[Token(Token = "0x2000061")]
	public struct Int3 : IEquatable<Int3>
	{
		[Token(Token = "0x4000219")]
		[FieldOffset(Offset = "0x0")]
		public int x;

		[Token(Token = "0x400021A")]
		[FieldOffset(Offset = "0x4")]
		public int y;

		[Token(Token = "0x400021B")]
		[FieldOffset(Offset = "0x8")]
		public int z;

		[Token(Token = "0x400021C")]
		public const int Precision = 1000;

		[Token(Token = "0x400021D")]
		public const float FloatPrecision = 1000f;

		[Token(Token = "0x400021E")]
		public const float PrecisionFactor = 0.001f;

		[Token(Token = "0x170000D3")]
		public static Int3 zero
		{
			[Token(Token = "0x60003B0")]
			[Address(RVA = "0x44F5250", Offset = "0x44F1250", VA = "0x44F5250")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000D4")]
		public int this[int i]
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x60003C0")]
			[Address(RVA = "0x44F5DD8", Offset = "0x44F1DD8", VA = "0x44F5DD8")]
			[IgnoredByDeepProfiler]
			get
			{
				return default;
			}
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x60003C1")]
			[Address(RVA = "0x44F5DF8", Offset = "0x44F1DF8", VA = "0x44F5DF8")]
			[IgnoredByDeepProfiler]
			set
			{
			}
		}

		[Token(Token = "0x170000D5")]
		public float magnitude
		{
			[Token(Token = "0x60003C8")]
			[Address(RVA = "0x44F6094", Offset = "0x44F2094", VA = "0x44F6094")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000D6")]
		public int costMagnitude
		{
			[Token(Token = "0x60003C9")]
			[Address(RVA = "0x44F6158", Offset = "0x44F2158", VA = "0x44F6158")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000D7")]
		public float sqrMagnitude
		{
			[Token(Token = "0x60003CA")]
			[Address(RVA = "0x44F6248", Offset = "0x44F2248", VA = "0x44F6248")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000D8")]
		public long sqrMagnitudeLong
		{
			[Token(Token = "0x60003CB")]
			[Address(RVA = "0x44F6278", Offset = "0x44F2278", VA = "0x44F6278")]
			get
			{
				return default;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x44F525C", Offset = "0x44F125C", VA = "0x44F525C")]
		public Int3(Vector3 position)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED Int3..ctor RVA=0x44F525C Token=0x60003B1");
}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x44F548C", Offset = "0x44F148C", VA = "0x44F548C")]
		public Int3(int _x, int _y, int _z)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED Int3..ctor RVA=0x44F548C Token=0x60003B2");
}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x44F5498", Offset = "0x44F1498", VA = "0x44F5498")]
		[IgnoredByDeepProfiler]
		public static bool operator ==(Int3 lhs, Int3 rhs)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x44F54C4", Offset = "0x44F14C4", VA = "0x44F54C4")]
		[IgnoredByDeepProfiler]
		public static bool operator !=(Int3 lhs, Int3 rhs)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x44F54F0", Offset = "0x44F14F0", VA = "0x44F54F0")]
		[IgnoredByDeepProfiler]
		public static explicit operator Int3(Vector3 ob)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x44F56FC", Offset = "0x44F16FC", VA = "0x44F56FC")]
		[IgnoredByDeepProfiler]
		public static explicit operator Vector3(Int3 ob)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x44F5724", Offset = "0x44F1724", VA = "0x44F5724")]
		[IgnoredByDeepProfiler]
		public static explicit operator float3(Int3 ob)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x44F574C", Offset = "0x44F174C", VA = "0x44F574C")]
		[IgnoredByDeepProfiler]
		public static explicit operator int3(Int3 ob)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x44F5754", Offset = "0x44F1754", VA = "0x44F5754")]
		[IgnoredByDeepProfiler]
		public static Int3 operator -(Int3 lhs, Int3 rhs)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x44F5770", Offset = "0x44F1770", VA = "0x44F5770")]
		[IgnoredByDeepProfiler]
		public static Int3 operator -(Int3 lhs)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x44F5784", Offset = "0x44F1784", VA = "0x44F5784")]
		[IgnoredByDeepProfiler]
		public static Int3 operator +(Int3 lhs, Int3 rhs)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x44F57A0", Offset = "0x44F17A0", VA = "0x44F57A0")]
		[IgnoredByDeepProfiler]
		public static Int3 operator *(Int3 lhs, int rhs)
		{
			return default;
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x44F57B8", Offset = "0x44F17B8", VA = "0x44F57B8")]
		public static Int3 operator *(Int3 lhs, float rhs)
		{
			return default;
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x44F59C4", Offset = "0x44F19C4", VA = "0x44F59C4")]
		public static Int3 operator *(Int3 lhs, double rhs)
		{
			return default;
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x44F5BCC", Offset = "0x44F1BCC", VA = "0x44F5BCC")]
		public static Int3 operator /(Int3 lhs, float rhs)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x44F5E18", Offset = "0x44F1E18", VA = "0x44F5E18")]
		public static Int3 Max(Int3 lhs, Int3 rhs)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x44F5ED4", Offset = "0x44F1ED4", VA = "0x44F5ED4")]
		public static Int3 Min(Int3 lhs, Int3 rhs)
		{
			return default;
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x44F5F90", Offset = "0x44F1F90", VA = "0x44F5F90")]
		public static float Angle(Int3 lhs, Int3 rhs)
		{
			return default;
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x44F607C", Offset = "0x44F207C", VA = "0x44F607C")]
		public static int Dot(Int3 lhs, Int3 rhs)
		{
			return default;
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x44F6124", Offset = "0x44F2124", VA = "0x44F6124")]
		public static long DotLong(Int3 lhs, Int3 rhs)
		{
			return default;
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x44F6140", Offset = "0x44F2140", VA = "0x44F6140")]
		public Int3 Normal2D()
		{
			return default;
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x44F6290", Offset = "0x44F2290", VA = "0x44F6290")]
		public static implicit operator string(Int3 obj)
		{
			return null;
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x44F62B4", Offset = "0x44F22B4", VA = "0x44F62B4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x44F63E8", Offset = "0x44F23E8", VA = "0x44F63E8", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default;
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x44F6480", Offset = "0x44F2480", VA = "0x44F6480", Slot = "4")]
		public bool Equals(Int3 other)
		{
			return default;
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x44F64B4", Offset = "0x44F24B4", VA = "0x44F64B4", Slot = "2")]
		public override int GetHashCode()
		{
			return default;
		}
	}
}
