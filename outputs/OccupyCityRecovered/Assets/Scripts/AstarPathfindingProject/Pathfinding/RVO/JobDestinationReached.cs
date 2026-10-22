using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Profiling;

namespace Pathfinding.RVO
{
	[Token(Token = "0x20002B4")]
	[BurstCompile(CompileSynchronously = false, FloatMode = FloatMode.Fast)]
	public struct JobDestinationReached<MovementPlaneWrapper> : IJob where MovementPlaneWrapper : struct, IMovementPlaneWrapper
	{
		[Token(Token = "0x20002B5")]
		private struct TempAgentData
		{
			[Token(Token = "0x4000C59")]
			[FieldOffset(Offset = "0x0")]
			public bool blockedAndSlow;

			[Token(Token = "0x4000C5A")]
			[FieldOffset(Offset = "0x0")]
			public float distToEndSq;
		}

		[Token(Token = "0x4000C52")]
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		public SimulatorBurst.AgentData agentData;

		[Token(Token = "0x4000C53")]
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		public SimulatorBurst.TemporaryAgentData temporaryAgentData;

		[Token(Token = "0x4000C54")]
		[FieldOffset(Offset = "0x0")]
		public SimulatorBurst.AgentOutputData output;

		[Token(Token = "0x4000C55")]
		[FieldOffset(Offset = "0x0")]
		public int numAgents;

		[Token(Token = "0x4000C56")]
		[FieldOffset(Offset = "0x0")]
		private static readonly ProfilerMarker MarkerInvert = new ProfilerMarker("InvertArrows");

		[Token(Token = "0x4000C57")]
		[FieldOffset(Offset = "0x0")]
		private static readonly ProfilerMarker MarkerAlloc = new ProfilerMarker("Alloc");

		[Token(Token = "0x4000C58")]
		[FieldOffset(Offset = "0x0")]
		private static readonly ProfilerMarker MarkerFirstPass = new ProfilerMarker("FirstPass");

		[Token(Token = "0x6001107")]
		public void Execute()
		{
            for (int agent = 0; agent < numAgents; agent++) output.effectivelyReachedDestination[agent] = ReachedEndOfPath.NotReached;
            int capacity = agentData.position.Length;
            var reverse = new NativeArray<int>(7 * capacity, Allocator.Temp, NativeArrayOptions.UninitializedMemory);
            var reverseCount = new NativeArray<int>(capacity, Allocator.Temp, NativeArrayOptions.ClearMemory);
            var queue = new Pathfinding.Collections.NativeCircularBuffer<int>(16, Allocator.Temp);
            var queued = new NativeArray<bool>(numAgents, Allocator.Temp, NativeArrayOptions.ClearMemory);
            var temporary = new NativeArray<TempAgentData>(numAgents, Allocator.Temp, NativeArrayOptions.UninitializedMemory);
            for (int agent = 0; agent < numAgents; agent++)
            {
                if (!agentData.version[agent].Valid) continue;
                for (int i = 0; i < 7; i++)
                {
                    int blocker = output.blockedByAgents[agent * 7 + i];
                    if (blocker == -1) break;
                    int count = reverseCount[blocker];
                    if (count <= 6)
                    {
                        reverse[blocker * 7 + count] = agent;
                        reverseCount[blocker] = count + 1;
                    }
                }
            }
            for (int agent = 0; agent < numAgents; agent++)
            {
                if (!agentData.version[agent].Valid) continue;
                float3 position = agentData.position[agent];
                MovementPlaneWrapper plane = default;
                plane.Set(agentData.movementPlane[agent]);
                float3 endOfPath = agentData.endOfPath[agent];
                if (!(math.abs(endOfPath.x) < float.PositiveInfinity)) continue;
                float speed = output.speed[agent];
                float2 toEnd = plane.ToPlane(endOfPath - position, out float elevation);
                float distanceToEndSq = math.lengthsq(toEnd);
                float radius = agentData.radius[agent];
                float height = agentData.height[agent];
                bool reached = distanceToEndSq < (radius * radius) * 0.25f && elevation < height && elevation > height * -0.5f;
                float desiredVelocityThreshold = math.lengthsq(temporaryAgentData.desiredVelocity[agent]) * 0.25f;
                if (float.IsNaN(desiredVelocityThreshold) || desiredVelocityThreshold < 0.0001f) desiredVelocityThreshold = 0.0001f;
                bool blockedAndSlow = output.forwardClearance[agent] < radius * 0.5f && speed * speed < desiredVelocityThreshold;
                temporary[agent] = new TempAgentData { blockedAndSlow = blockedAndSlow, distToEndSq = distanceToEndSq };
                bool mutualBlocking = false;
                for (int i = 0; i < 7; i++)
                {
                    int blocker = output.blockedByAgents[agent * 7 + i];
                    if (blocker == -1) break;
                    float3 otherPosition = agentData.position[blocker];
                    float pairRadius = ((radius + math.length(plane.ToPlane(position - otherPosition))) + agentData.radius[blocker]) * 0.5f;
                    float2 fromPairCenter = plane.ToPlane(endOfPath - (position + otherPosition) * 0.5f);
                    if (math.lengthsq(fromPairCenter) < pairRadius * pairRadius)
                    {
                        for (int j = 0; j < 7; j++)
                        {
                            int candidate = reverse[agent * 7 + j];
                            if (candidate == -1) break;
                            if (candidate == blocker)
                            {
                                reached |= blockedAndSlow;
                                mutualBlocking = true;
                                break;
                            }
                        }
                    }
                }
                ReachedEndOfPath status = reached ? ReachedEndOfPath.Reached : mutualBlocking ? ReachedEndOfPath.ReachedSoon : ReachedEndOfPath.NotReached;
                if (status != output.effectivelyReachedDestination[agent])
                {
                    output.effectivelyReachedDestination[agent] = status;
                    if (reached)
                    {
                        queued[agent] = true;
                        for (int i = 0; i < reverseCount[agent]; i++)
                        {
                            int dependent = reverse[agent * 7 + i];
                            if (!queued[dependent]) queue.PushEnd(dependent);
                        }
                    }
                }
            }
            while (queue.Length > 0)
            {
                int agent = queue.PopStart();
                ReachedEndOfPath current = output.effectivelyReachedDestination[agent];
                if (current == ReachedEndOfPath.Reached) continue;
                queued[agent] = false;
                float3 endOfPath = agentData.endOfPath[agent];
                if (!(math.abs(endOfPath.x) < float.PositiveInfinity)) continue;
                float speed = output.speed[agent];
                float radius = agentData.radius[agent];
                TempAgentData data = temporary[agent];
                float affinityDistanceSq = data.distToEndSq * 0.25f;
                bool reached = false;
                bool soon = false;
                for (int i = 0; i < 7; i++)
                {
                    int blocker = output.blockedByAgents[agent * 7 + i];
                    if (blocker == -1) break;
                    if (output.effectivelyReachedDestination[blocker] != ReachedEndOfPath.Reached) continue;
                    float combinedRadius = radius + agentData.radius[blocker];
                    if (math.lengthsq(agentData.endOfPath[blocker] - endOfPath) <= affinityDistanceSq || math.lengthsq(endOfPath - agentData.position[blocker]) < combinedRadius * combinedRadius)
                    {
                        float minimumSpeed = output.speed[blocker];
                        if (float.IsNaN(minimumSpeed) || speed < minimumSpeed) minimumSpeed = speed;
                        soon |= minimumSpeed < 0.01f;
                        reached |= data.blockedAndSlow;
                    }
                }
                ReachedEndOfPath status = reached ? ReachedEndOfPath.Reached : soon ? ReachedEndOfPath.ReachedSoon : ReachedEndOfPath.NotReached;
                if ((int)status > (int)current)
                {
                    output.effectivelyReachedDestination[agent] = status;
                    if (status == ReachedEndOfPath.Reached)
                    {
                        queued[agent] = true;
                        for (int i = 0; i < reverseCount[agent]; i++)
                        {
                            int dependent = reverse[agent * 7 + i];
                            if (!queued[dependent]) queue.PushEnd(dependent);
                        }
                    }
                }
            }
        }
	}
}
