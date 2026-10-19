using Il2CppDummyDll;
using Unity.Jobs.LowLevel.Unsafe;

namespace Pathfinding.Jobs
{
	[Token(Token = "0x2000182")]
	[JobProducerType(typeof(JobParallelForBatchedExtensions.ParallelForBatchJobStruct<>))]
	public interface IJobParallelForBatched
	{
		[Token(Token = "0x170001F1")]
		bool allowBoundsChecks
		{
			[Token(Token = "0x6000BA7")]
			get;
		}

		[Token(Token = "0x6000BA8")]
		void Execute(int startIndex, int count);
	}
}
