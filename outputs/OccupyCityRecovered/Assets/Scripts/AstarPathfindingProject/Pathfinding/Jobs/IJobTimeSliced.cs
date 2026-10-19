using Il2CppDummyDll;
using Unity.Jobs;

namespace Pathfinding.Jobs
{
	[Token(Token = "0x2000194")]
	public interface IJobTimeSliced : IJob
	{
		[Token(Token = "0x6000BE2")]
		bool Execute(TimeSlice timeSlice);
	}
}
