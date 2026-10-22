using Il2CppDummyDll;
using Pathfinding.ECS.RVO;
using Pathfinding.Jobs;
using Pathfinding.Util;
using Unity.Burst;
using Unity.Collections;
using Unity.Mathematics;

namespace Pathfinding.RVO
{
	[Token(Token = "0x20002B1")]
	[BurstCompile(FloatMode = FloatMode.Fast)]
	public struct JobHorizonAvoidancePhase2<MovementPlaneWrapper> : IJobParallelForBatched where MovementPlaneWrapper : struct, IMovementPlaneWrapper
	{
		[Token(Token = "0x4000C42")]
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		public NativeArray<int> neighbours;

		[Token(Token = "0x4000C43")]
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		public NativeArray<AgentIndex> versions;

		[Token(Token = "0x4000C44")]
		[FieldOffset(Offset = "0x0")]
		public NativeArray<float3> desiredVelocity;

		[Token(Token = "0x4000C45")]
		[FieldOffset(Offset = "0x0")]
		public NativeArray<float2> desiredTargetPointInVelocitySpace;

		[Token(Token = "0x4000C46")]
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		public NativeArray<NativeMovementPlane> movementPlane;

		[Token(Token = "0x4000C47")]
		[FieldOffset(Offset = "0x0")]
		public SimulatorBurst.HorizonAgentData horizonAgentData;

		[Token(Token = "0x17000279")]
		public bool allowBoundsChecks
		{
			[Token(Token = "0x6001100")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6001101")]
		public void Execute(int startIndex, int count)
		{
            for (int agent = startIndex; agent < startIndex + count; agent++)
            {
                if (!versions[agent].Valid) continue;
                int side = horizonAgentData.horizonSide[agent];
                if (side == 0) continue;
                if (side == 2)
                {
                    NativeSlice<int> adjacent = neighbours.Slice(agent * 50, 50);
                    float sum = 0f;
                    for (int i = 0; i < adjacent.Length; i++)
                    {
                        int neighbour = adjacent[i];
                        if (neighbour == -1) break;
                        sum -= horizonAgentData.horizonMinAngle[neighbour] + horizonAgentData.horizonMaxAngle[neighbour];
                    }
                    sum -= horizonAgentData.horizonMinAngle[agent] + horizonAgentData.horizonMaxAngle[agent];
                    side = sum < 0f ? -1 : 1;
                    horizonAgentData.horizonSide[agent] = side;
                }
                float angle = side < 0 ? horizonAgentData.horizonMinAngle[agent] : horizonAgentData.horizonMaxAngle[agent];
                float sine = (float)System.Math.Sin((double)angle);
                float cosine = (float)System.Math.Cos((double)angle);
                MovementPlaneWrapper plane = default;
                plane.Set(movementPlane[agent]);
                float speed = math.length(desiredVelocity[agent]);
                desiredVelocity[agent] = plane.ToWorld(new float2(speed * cosine, speed * sine), 0f);
                float targetLength = math.length(desiredTargetPointInVelocitySpace[agent]);
                desiredTargetPointInVelocitySpace[agent] = new float2(targetLength * cosine, targetLength * sine);
            }
        }
	}
}
