using Il2CppDummyDll;
using Pathfinding.Jobs;
using Unity.Burst;
using Unity.Collections;
using Unity.Mathematics;

namespace Pathfinding.RVO
{
	[Token(Token = "0x20002B2")]
	[BurstCompile(FloatMode = FloatMode.Fast)]
	public struct JobHardCollisions<MovementPlaneWrapper> : IJobParallelForBatched where MovementPlaneWrapper : struct, IMovementPlaneWrapper
	{
		[Token(Token = "0x4000C48")]
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		public SimulatorBurst.AgentData agentData;

		[Token(Token = "0x4000C49")]
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		public NativeArray<int> neighbours;

		[Token(Token = "0x4000C4A")]
		[FieldOffset(Offset = "0x0")]
		[WriteOnly]
		public NativeArray<float2> collisionVelocityOffsets;

		[Token(Token = "0x4000C4B")]
		[FieldOffset(Offset = "0x0")]
		public float deltaTime;

		[Token(Token = "0x4000C4C")]
		[FieldOffset(Offset = "0x0")]
		public bool enabled;

		[Token(Token = "0x4000C4D")]
		private const float CollisionStrength = 0.8f;

		[Token(Token = "0x1700027A")]
		public bool allowBoundsChecks
		{
			[Token(Token = "0x6001102")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6001103")]
		public void Execute(int startIndex, int count)
		{
            if (!enabled)
            {
                for (int agent = startIndex; agent < startIndex + count; agent++) collisionVelocityOffsets[agent] = float2.zero;
                return;
            }
            for (int agent = startIndex; agent < startIndex + count; agent++)
            {
                if (!agentData.version[agent].Valid || agentData.locked[agent])
                {
                    collisionVelocityOffsets[agent] = float2.zero;
                    continue;
                }
                NativeSlice<int> adjacent = neighbours.Slice(agent * 50, 50);
                float radius = agentData.radius[agent];
                float3 position = agentData.position[agent];
                float2 accumulated = float2.zero;
                float totalWeight = 0f;
                MovementPlaneWrapper plane = default;
                plane.Set(agentData.movementPlane[agent]);
                for (int i = 0; i < adjacent.Length; i++)
                {
                    int other = adjacent[i];
                    if (other == -1) break;
                    float2 delta = plane.ToPlane(position - agentData.position[other]);
                    float distanceSq = math.lengthsq(delta);
                    float combinedRadius = radius + agentData.radius[other];
                    if (!(distanceSq < combinedRadius * combinedRadius)) continue;
                    if (!(distanceSq <= 9.99999993922529e-09f))
                    {
                        float distance = math.sqrt(distanceSq);
                        float penetration = combinedRadius - distance;
                        accumulated += ((delta * (1f / distance)) * penetration) * penetration;
                        totalWeight += penetration;
                    }
                    else
                    {
                        float seed = (float)agent * 0.521353006362915f + (float)i * 0.7531769871711731f;
                        float fraction = seed - math.floor(seed);
                        float angle = fraction * 3.1415927410125732f;
                        angle = angle + angle;
                        float sine = (float)System.Math.Sin((double)angle);
                        float cosine = (float)System.Math.Cos((double)angle);
                        totalWeight += 100f;
                        accumulated += ((new float2(cosine, sine) * 100f) * radius) * 0.01f;
                    }
                }
                collisionVelocityOffsets[agent] = (accumulated * (1f / (totalWeight + 0.0001f))) * (0.4000000059604645f / deltaTime);
            }
        }
	}
}
