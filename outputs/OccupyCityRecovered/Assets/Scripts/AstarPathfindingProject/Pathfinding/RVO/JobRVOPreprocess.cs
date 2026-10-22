using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;

namespace Pathfinding.RVO
{
	[Token(Token = "0x20002AF")]
	[BurstCompile(CompileSynchronously = false, FloatMode = FloatMode.Fast)]
	public struct JobRVOPreprocess<MovementPlaneWrapper> : IJob where MovementPlaneWrapper : struct, IMovementPlaneWrapper
	{
		[Token(Token = "0x4000C39")]
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		public SimulatorBurst.AgentData agentData;

		[Token(Token = "0x4000C3A")]
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		public SimulatorBurst.AgentOutputData previousOutput;

		[Token(Token = "0x4000C3B")]
		[FieldOffset(Offset = "0x0")]
		[WriteOnly]
		public SimulatorBurst.TemporaryAgentData temporaryAgentData;

		[Token(Token = "0x4000C3C")]
		[FieldOffset(Offset = "0x0")]
		public int startIndex;

		[Token(Token = "0x4000C3D")]
		[FieldOffset(Offset = "0x0")]
		public int endIndex;

		[Token(Token = "0x60010FB")]
		public void Execute()
		{
            MovementPlaneWrapper plane = default;
            for (int i = startIndex; i < endIndex; i++)
            {
                if (!agentData.version[i].Valid) continue;
                if (agentData.locked[i] && !agentData.manuallyControlled[i])
                {
                    temporaryAgentData.desiredTargetPointInVelocitySpace[i] = Unity.Mathematics.float2.zero;
                    temporaryAgentData.desiredVelocity[i] = Unity.Mathematics.float3.zero;
                    temporaryAgentData.currentVelocity[i] = Unity.Mathematics.float3.zero;
                }
                else
                {
                    plane = default;
                    plane.Set(agentData.movementPlane[i]);
                    Unity.Mathematics.float2 target = plane.ToPlane(agentData.targetPoint[i] - agentData.position[i]);
                    temporaryAgentData.desiredTargetPointInVelocitySpace[i] = target;
                    Unity.Mathematics.float3 current = Unity.Mathematics.math.normalizesafe(previousOutput.targetPoint[i] - agentData.position[i]) * previousOutput.speed[i];
                    Unity.Mathematics.float2 direction = Unity.Mathematics.math.normalizesafe(target);
                    temporaryAgentData.desiredVelocity[i] = plane.ToWorld(direction * agentData.desiredSpeed[i], 0f);
                    Unity.Mathematics.float3 normal = Unity.Mathematics.math.normalizesafe(agentData.collisionNormal[i]);
                    float towardsNormal = Unity.Mathematics.math.dot(current, normal);
                    if (float.IsNaN(towardsNormal) || towardsNormal > 0f) towardsNormal = 0f;
                    temporaryAgentData.currentVelocity[i] = current - normal * towardsNormal;
                }
            }
        }
	}
}
