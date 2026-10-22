using Il2CppDummyDll;
using Pathfinding.Jobs;
using Unity.Burst;
using Unity.Collections;

namespace Pathfinding.RVO
{
	[Token(Token = "0x20002B3")]
	[BurstCompile(CompileSynchronously = false, FloatMode = FloatMode.Fast)]
	public struct JobRVOCalculateNeighbours<MovementPlaneWrapper> : IJobParallelForBatched where MovementPlaneWrapper : struct, IMovementPlaneWrapper
	{
		[Token(Token = "0x4000C4E")]
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		public SimulatorBurst.AgentData agentData;

		[Token(Token = "0x4000C4F")]
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		public RVOQuadtreeBurst quadtree;

		[Token(Token = "0x4000C50")]
		[FieldOffset(Offset = "0x0")]
		public NativeArray<int> outNeighbours;

		[Token(Token = "0x4000C51")]
		[FieldOffset(Offset = "0x0")]
		[WriteOnly]
		public SimulatorBurst.AgentOutputData output;

		[Token(Token = "0x1700027B")]
		public bool allowBoundsChecks
		{
			[Token(Token = "0x6001104")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6001105")]
		public void Execute(int startIndex, int count)
		{
            NativeArray<float> neighbourDistances = new NativeArray<float>(50, Allocator.Temp, NativeArrayOptions.UninitializedMemory);
            for (int i = startIndex; i < startIndex + count; i++)
            {
                if (agentData.version[i].Valid) CalculateNeighbours(i, outNeighbours, neighbourDistances);
            }
        }

		[Token(Token = "0x6001106")]
		private void CalculateNeighbours(int agentIndex, NativeArray<int> neighbours, NativeArray<float> neighbourDistances)
		{
            var query = new RVOQuadtreeBurst.QuadtreeQuery {
                position = agentData.position[agentIndex], speed = agentData.maxSpeed[agentIndex],
                timeHorizon = agentData.agentTimeHorizon[agentIndex], agentRadius = agentData.radius[agentIndex],
                outputStartIndex = 50 * agentIndex, maxCount = Unity.Mathematics.math.min(agentData.maxNeighbours[agentIndex], 50),
                layerMask = agentData.collidesWith[agentIndex], layers = agentData.layer,
                result = neighbours, resultDistances = neighbourDistances
            };
            int count = quadtree.QueryKNearest(query);
            output.numNeighbours[agentIndex] = count;
            MovementPlaneWrapper plane = default;
            plane.Set(agentData.movementPlane[agentIndex]);
            plane.ToPlane(agentData.position[agentIndex], out float elevation);
            int offset = 50 * agentIndex;
            for (int i = 0; i < count; i++)
            {
                int neighbour = neighbours[offset + i];
                if (neighbour == -1) throw new System.Exception("Invalid neighbour index");
                plane.ToPlane(agentData.position[neighbour], out float otherElevation);
                float upper = otherElevation + agentData.height[neighbour];
                float selfUpper = elevation + agentData.height[agentIndex];
                if (float.IsNaN(upper) || selfUpper < upper) upper = selfUpper;
                float lower = otherElevation;
                if (float.IsNaN(lower) || elevation > lower) lower = elevation;
                if (neighbour == agentIndex || upper < lower)
                {
                    count--;
                    neighbours[offset + i] = neighbours[offset + count];
                    i--;
                }
            }
            if (count < 50) neighbours[offset + count] = -1;
        }
	}
}
