using Il2CppDummyDll;
using Pathfinding.Jobs;
using Unity.Burst;
using Unity.Collections;
using Unity.Mathematics;

namespace Pathfinding.RVO
{
	[Token(Token = "0x20002B0")]
	[BurstCompile(FloatMode = FloatMode.Fast)]
	public struct JobHorizonAvoidancePhase1<MovementPlaneWrapper> : IJobParallelForBatched where MovementPlaneWrapper : struct, IMovementPlaneWrapper
	{
		[Token(Token = "0x4000C3E")]
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		public SimulatorBurst.AgentData agentData;

		[Token(Token = "0x4000C3F")]
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		public NativeArray<float2> desiredTargetPointInVelocitySpace;

		[Token(Token = "0x4000C40")]
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		public NativeArray<int> neighbours;

		[Token(Token = "0x4000C41")]
		[FieldOffset(Offset = "0x0")]
		public SimulatorBurst.HorizonAgentData horizonAgentData;

		[Token(Token = "0x17000278")]
		public bool allowBoundsChecks
		{
			[Token(Token = "0x60010FC")]
			get
			{ return true; }
		}

		[Token(Token = "0x60010FD")]
		private static void Sort<T>(NativeSlice<T> arr, NativeSlice<float> keys) where T : struct
		{
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (keys[i] <= keys[i + 1]) continue;
                    float key = keys[i];
                    T value = arr[i];
                    keys[i] = keys[i + 1];
                    keys[i + 1] = key;
                    arr[i] = arr[i + 1];
                    arr[i + 1] = value;
                    swapped = true;
                }
            }
            while (swapped);
        }

		[Token(Token = "0x60010FE")]
		public static float DeltaAngle(float current, float target)
		{
            float difference = target - current;
            float wrapped = difference + math.floor(difference / 6.2831854820251465f) * -6.2831854820251465f;
            wrapped = wrapped < 0f ? 0f : System.Math.Min(wrapped, 6.2831854820251465f);
            return wrapped > 3.1415927410125732f ? wrapped + -6.2831854820251465f : wrapped;
        }

		[Token(Token = "0x60010FF")]
		public void Execute(int startIndex, int count)
		{
            var angles = new NativeArray<float>(100, Allocator.Temp, NativeArrayOptions.ClearMemory);
            var events = new NativeArray<int>(100, Allocator.Temp, NativeArrayOptions.ClearMemory);
            for (int agent = startIndex; agent < startIndex + count; agent++)
            {
                if (!agentData.version[agent].Valid) continue;
                if (agentData.locked[agent] || agentData.manuallyControlled[agent])
                {
                    horizonAgentData.horizonSide[agent] = 0;
                    horizonAgentData.horizonMinAngle[agent] = 0f;
                    horizonAgentData.horizonMaxAngle[agent] = 0f;
                    continue;
                }
                float2 desiredTarget = desiredTargetPointInVelocitySpace[agent];
                float desiredAngle = (float)System.Math.Atan2((double)desiredTarget.y, (double)desiredTarget.x);
                float radius = agentData.radius[agent];
                float3 position = agentData.position[agent];
                MovementPlaneWrapper plane = default;
                plane.Set(agentData.movementPlane[agent]);
                float3 endOfPath = agentData.endOfPath[agent];
                float distanceToEndSq = math.all(math.isfinite(endOfPath)) ? math.lengthsq(endOfPath - position) : float.PositiveInfinity;
                NativeSlice<int> adjacent = neighbours.Slice(agent * 50, 50);
                int eventCount = 0;
                int crossing = 0;
                for (int i = 0; i < adjacent.Length; i++)
                {
                    int other = adjacent[i];
                    if (other == -1) break;
                    if (!agentData.locked[other] && !agentData.manuallyControlled[other]) continue;
                    float2 relative = plane.ToPlane(agentData.position[other] - position);
                    float distance = math.length(relative);
                    float combinedRadius = radius + agentData.radius[other];
                    float clearance = distance - combinedRadius;
                    if (!(clearance * clearance <= distanceToEndSq)) continue;
                    float angle = (float)System.Math.Atan2((double)relative.y, (double)relative.x);
                    float halfAngle = 1.539380431175232f;
                    if (clearance > 0f) halfAngle = (float)System.Math.Asin((double)(combinedRadius / distance)) + 0.01745329238474369f;
                    float relativeAngle = angle - desiredAngle;
                    float minimum = DeltaAngle(0f, relativeAngle - halfAngle);
                    float maximum = minimum + DeltaAngle(minimum, relativeAngle + halfAngle);
                    angles[eventCount] = minimum;
                    events[eventCount] = 1;
                    angles[eventCount + 1] = maximum;
                    events[eventCount + 1] = -1;
                    eventCount += 2;
                    if (minimum < 0f && maximum > 0f) crossing++;
                }
                if (crossing == 0)
                {
                    horizonAgentData.horizonSide[agent] = 0;
                    horizonAgentData.horizonMinAngle[agent] = 0f;
                    horizonAgentData.horizonMaxAngle[agent] = 0f;
                    continue;
                }
                Sort(events.Slice(0, eventCount), angles.Slice(0, eventCount));
                int firstPositive = 0;
                while (firstPositive < eventCount && !(angles[firstPositive] > 0f)) firstPositive++;
                int rightIndex = firstPositive;
                int rightCounter = crossing;
                while (rightIndex < eventCount)
                {
                    rightCounter += events[rightIndex];
                    if (rightCounter == 0) break;
                    rightIndex++;
                }
                float maximumAngle = rightIndex == eventCount ? 3.1415927410125732f : angles[rightIndex];
                int leftIndex = firstPositive - 1;
                int leftCounter = crossing;
                while (leftIndex >= 0)
                {
                    leftCounter -= events[leftIndex];
                    if (leftCounter == 0) break;
                    leftIndex--;
                }
                float minimumAngle = leftIndex < 0 ? -3.1415927410125732f : angles[leftIndex];
                if (horizonAgentData.horizonSide[agent] == 0) horizonAgentData.horizonSide[agent] = 2;
                horizonAgentData.horizonMinAngle[agent] = minimumAngle + desiredAngle;
                horizonAgentData.horizonMaxAngle[agent] = maximumAngle + desiredAngle;
            }
        }
	}
}
