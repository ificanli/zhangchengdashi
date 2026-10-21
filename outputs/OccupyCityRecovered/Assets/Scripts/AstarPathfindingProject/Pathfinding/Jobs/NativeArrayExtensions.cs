using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Pathfinding.Graphs.Grid;
using Unity.Collections;
using Unity.Mathematics;

namespace Pathfinding.Jobs
{
	[Token(Token = "0x2000177")]
	internal static class NativeArrayExtensions
	{
		[Token(Token = "0x6000B95")]
		public static JobMemSet<T> MemSet<T>(this NativeArray<T> self, T value) where T : struct
		{ return new JobMemSet<T> { data=self, value=value }; }

		[Token(Token = "0x6000B96")]
		[Address(RVA = "0x4581954", Offset = "0x457D954", VA = "0x4581954")]
		public static JobAND BitwiseAndWith(this NativeArray<bool> self, NativeArray<bool> other)
		{ return new JobAND { result = self, data = other }; }

		[Token(Token = "0x6000B97")]
		public static JobCopy<T> CopyToJob<T>(this NativeArray<T> from, NativeArray<T> to) where T : struct
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000B98")]
		public static SliceActionJob<T> WithSlice<T>(this T action, Slice3D slice) where T : struct, GridIterationUtilities.ISliceAction
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000B99")]
		public static IndexActionJob<T> WithLength<T>(this T action, int length) where T : struct, GridIterationUtilities.ISliceAction
		{ return new IndexActionJob<T> { action = action, length = length }; }

		[Token(Token = "0x6000B9A")]
		public static JobRotate3DArray<T> Rotate3D<T>(this NativeArray<T> arr, int3 size, int dx, int dz) where T : struct
		{
			return default;
		}
	}
}
