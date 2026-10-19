using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Unity.Jobs;
using Unity.Jobs.LowLevel.Unsafe;

namespace Pathfinding.Jobs
{
	[Token(Token = "0x2000183")]
	internal static class JobParallelForBatchedExtensions
	{
		[Token(Token = "0x2000184")]
		internal struct ParallelForBatchJobStruct<T> where T : struct, IJobParallelForBatched
		{
			[Token(Token = "0x2000185")]
			public delegate void ExecuteJobFunction(ref T data, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex);

			[Token(Token = "0x400079E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static IntPtr jobReflectionData;

			[Token(Token = "0x6000BAB")]
			public static IntPtr Initialize()
			{
				return default;
			}

			[Token(Token = "0x6000BAC")]
			public static void Execute(ref T jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex)
			{
			}
		}

		[Token(Token = "0x6000BA9")]
		public static JobHandle ScheduleBatch<T>(this T jobData, int arrayLength, int minIndicesPerJobCount, [Optional] JobHandle dependsOn) where T : struct, IJobParallelForBatched
		{
			return default;
		}

		[Token(Token = "0x6000BAA")]
		public static void RunBatch<T>(this T jobData, int arrayLength) where T : struct, IJobParallelForBatched
		{
		}
	}
}
