using Il2CppDummyDll;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;

namespace andywiecko.BurstTriangulator.LowLevel.Unsafe
{
	[Token(Token = "0x200001A")]
	public static class Extensions
	{
		[Token(Token = "0x600006F")]
		[Address(RVA = "0x3CF3FC0", Offset = "0x3CEFFC0", VA = "0x3CF3FC0")]
		public static void Triangulate(this UnsafeTriangulator @this, InputData<double2> input, OutputData<double2> output, Args args, Allocator allocator)
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x3CF40C8", Offset = "0x3CF00C8", VA = "0x3CF40C8")]
		public static void PlantHoleSeeds(this UnsafeTriangulator @this, InputData<double2> input, OutputData<double2> output, Args args, Allocator allocator)
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x3CF41D0", Offset = "0x3CF01D0", VA = "0x3CF41D0")]
		public static void RefineMesh(this UnsafeTriangulator @this, OutputData<double2> output, Allocator allocator, double areaThreshold = 1.0, double angleThreshold = 0.0872664626, bool constrainBoundary = false)
		{
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x3CF42A0", Offset = "0x3CF02A0", VA = "0x3CF42A0")]
		public static void Triangulate(this UnsafeTriangulator<float2> @this, InputData<float2> input, OutputData<float2> output, Args args, Allocator allocator)
		{
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x3CF43A8", Offset = "0x3CF03A8", VA = "0x3CF43A8")]
		public static void PlantHoleSeeds(this UnsafeTriangulator<float2> @this, InputData<float2> input, OutputData<float2> output, Args args, Allocator allocator)
		{
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x3CF44B0", Offset = "0x3CF04B0", VA = "0x3CF44B0")]
		public static void RefineMesh(this UnsafeTriangulator<float2> @this, OutputData<float2> output, Allocator allocator, float areaThreshold = 1f, float angleThreshold = 0.08726646f, bool constrainBoundary = false)
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x3CF4580", Offset = "0x3CF0580", VA = "0x3CF4580")]
		public static void Triangulate(this UnsafeTriangulator<Vector2> @this, InputData<Vector2> input, OutputData<Vector2> output, Args args, Allocator allocator)
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x3CF46D0", Offset = "0x3CF06D0", VA = "0x3CF46D0")]
		public static void PlantHoleSeeds(this UnsafeTriangulator<Vector2> @this, InputData<Vector2> input, OutputData<Vector2> output, Args args, Allocator allocator)
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x3CF4820", Offset = "0x3CF0820", VA = "0x3CF4820")]
		public static void RefineMesh(this UnsafeTriangulator<Vector2> @this, OutputData<Vector2> output, Allocator allocator, float areaThreshold = 1f, float angleThreshold = 0.08726646f, bool constrainBoundary = false)
		{
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x3CF4918", Offset = "0x3CF0918", VA = "0x3CF4918")]
		public static void Triangulate(this UnsafeTriangulator<double2> @this, InputData<double2> input, OutputData<double2> output, Args args, Allocator allocator)
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x3CF4A20", Offset = "0x3CF0A20", VA = "0x3CF4A20")]
		public static void PlantHoleSeeds(this UnsafeTriangulator<double2> @this, InputData<double2> input, OutputData<double2> output, Args args, Allocator allocator)
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x3CF4B28", Offset = "0x3CF0B28", VA = "0x3CF4B28")]
		public static void RefineMesh(this UnsafeTriangulator<double2> @this, OutputData<double2> output, Allocator allocator, double areaThreshold = 1.0, double angleThreshold = 0.0872664626, bool constrainBoundary = false)
		{
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x3CF4BF8", Offset = "0x3CF0BF8", VA = "0x3CF4BF8")]
		public static void Triangulate(this UnsafeTriangulator<int2> @this, InputData<int2> input, OutputData<int2> output, Args args, Allocator allocator)
		{
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x3CF4D00", Offset = "0x3CF0D00", VA = "0x3CF4D00")]
		public static void PlantHoleSeeds(this UnsafeTriangulator<int2> @this, InputData<int2> input, OutputData<int2> output, Args args, Allocator allocator)
		{
		}
	}
}
