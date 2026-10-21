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
 if (jobReflectionData==IntPtr.Zero) jobReflectionData=JobsUtility.CreateJobReflectionData(typeof(T),(ExecuteJobFunction)Execute);
 return jobReflectionData;
}

			[Token(Token = "0x6000BAC")]
			public static void Execute(ref T jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex)
			{
 while (JobsUtility.GetWorkStealingRange(ref ranges,jobIndex,out int begin,out int end)) {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
  // Editor SDK adapter: preserve the original job's bounds-check gate while using the SDK range safety API.
  if (jobData.allowBoundsChecks) unsafe { JobsUtility.PatchBufferMinMaxRanges(bufferRangePatchData,Unity.Collections.LowLevel.Unsafe.UnsafeUtility.AddressOf(ref jobData),begin,unchecked(end-begin)); }
#endif
  jobData.Execute(begin,unchecked(end-begin));
 }
}
		}

		[Token(Token = "0x6000BA9")]
		public static JobHandle ScheduleBatch<T>(this T jobData, int arrayLength, int minIndicesPerJobCount, [Optional] JobHandle dependsOn) where T : struct, IJobParallelForBatched
		{
 unsafe {
  var parameters=new JobsUtility.JobScheduleParameters(Unity.Collections.LowLevel.Unsafe.UnsafeUtility.AddressOf(ref jobData),ParallelForBatchJobStruct<T>.Initialize(),dependsOn,ScheduleMode.Parallel);
  return JobsUtility.ScheduleParallelFor(ref parameters,arrayLength,minIndicesPerJobCount);
 }
}

		[Token(Token = "0x6000BAA")]
		public static void RunBatch<T>(this T jobData, int arrayLength) where T : struct, IJobParallelForBatched
		{
 unsafe {
  var parameters=new JobsUtility.JobScheduleParameters(Unity.Collections.LowLevel.Unsafe.UnsafeUtility.AddressOf(ref jobData),ParallelForBatchJobStruct<T>.Initialize(),default,ScheduleMode.Run);
  JobsUtility.ScheduleParallelFor(ref parameters,arrayLength,arrayLength);
 }
}
	}
}
