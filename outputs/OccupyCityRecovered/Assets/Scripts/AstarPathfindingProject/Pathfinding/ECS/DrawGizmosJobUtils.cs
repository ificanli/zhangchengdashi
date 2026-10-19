using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Pathfinding.Collections;
using Pathfinding.Drawing;
using Unity.Burst;
using Unity.Mathematics;

namespace Pathfinding.ECS
{
	[Token(Token = "0x2000322")]
	[BurstCompile]
	internal struct DrawGizmosJobUtils
	{
		[Token(Token = "0x2000323")]
		public delegate void DrawPath_00001249_0024PostfixBurstDelegate(ref CommandBuilder draw, ref UnsafeSpan<float3> vertices, ref AgentCylinderShape shape);

		[Token(Token = "0x2000324")]
		internal static class DrawPath_00001249_0024BurstDirectCall
		{
			[Token(Token = "0x4000E14")]
			[FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			[Token(Token = "0x4000E15")]
			[FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;

			[Token(Token = "0x60013A5")]
			[Address(RVA = "0x44BB01C", Offset = "0x44B701C", VA = "0x44BB01C")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr P_0)
			{
			}

			[Token(Token = "0x60013A6")]
			[Address(RVA = "0x44BB138", Offset = "0x44B7138", VA = "0x44BB138")]
			private static IntPtr GetFunctionPointer()
			{
				return default;
			}

			[Token(Token = "0x60013A7")]
			[Address(RVA = "0x44BB194", Offset = "0x44B7194", VA = "0x44BB194")]
			public static void Constructor()
			{
			}

			[Token(Token = "0x60013A8")]
			[Address(RVA = "0x44BB23C", Offset = "0x44B723C", VA = "0x44BB23C")]
			public static void Initialize()
			{
			}

			[Token(Token = "0x60013AA")]
			[Address(RVA = "0x44BAB7C", Offset = "0x44B6B7C", VA = "0x44BAB7C")]
			public static void Invoke(ref CommandBuilder draw, ref UnsafeSpan<float3> vertices, ref AgentCylinderShape shape)
			{
			}
		}

		[Token(Token = "0x600139F")]
		[Address(RVA = "0x44BAB10", Offset = "0x44B6B10", VA = "0x44BAB10")]
		[BurstCompile]
		internal static void DrawPath(ref CommandBuilder draw, ref UnsafeSpan<float3> vertices, ref AgentCylinderShape shape)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60013A0")]
		[Address(RVA = "0x44BAC44", Offset = "0x44B6C44", VA = "0x44BAC44")]
		[BurstCompile]
		public static void DrawPath_0024BurstManaged(ref CommandBuilder draw, ref UnsafeSpan<float3> vertices, ref AgentCylinderShape shape)
		{
		}
	}
}
