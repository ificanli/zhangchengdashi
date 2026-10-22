using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Pathfinding.Collections;
using Pathfinding.Drawing;
using Pathfinding.ECS.RVO;
using Pathfinding.Sync;
using Pathfinding.Util;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;

namespace Pathfinding.RVO
{
	[Token(Token = "0x20002C6")]
	public class SimulatorBurst
	{
		[Token(Token = "0x20002C7")]
		public struct AgentNeighbourLookup
		{
			[Token(Token = "0x4000CBC")]
			[FieldOffset(Offset = "0x0")]
			[ReadOnly]
			[NativeDisableParallelForRestriction]
			private NativeArray<int> neighbours;

			[Token(Token = "0x6001181")]
			[Address(RVA = "0x449C89C", Offset = "0x449889C", VA = "0x449C89C")]
			public AgentNeighbourLookup(NativeArray<int> neighbours)
			{
            this.neighbours = neighbours;
        }

			[Token(Token = "0x6001182")]
			[Address(RVA = "0x449C8A4", Offset = "0x44988A4", VA = "0x449C8A4")]
			public UnsafeSpan<int> GetNeighbours(int agentIndex)
			{
                int offset = agentIndex * 50;
                int count = 0;
                while (neighbours[offset + count] != -1) count++;
                return neighbours.AsUnsafeSpan().Slice(offset, count);
            }
		}

		[Token(Token = "0x20002C8")]
		private struct Agent : IAgent
		{
			[Token(Token = "0x4000CBD")]
			[FieldOffset(Offset = "0x0")]
			public SimulatorBurst simulator;

			[Token(Token = "0x4000CBE")]
			[FieldOffset(Offset = "0x8")]
			public AgentIndex agentIndex;

			[Token(Token = "0x1700029F")]
			public int AgentIndex
			{
				[Token(Token = "0x6001183")]
				[Address(RVA = "0x449CA0C", Offset = "0x4498A0C", VA = "0x449CA0C", Slot = "4")]
				get
				{ return agentIndex.Index; }
			}

			[Token(Token = "0x170002A0")]
			public Vector3 Position
			{
				[Token(Token = "0x6001184")]
				[Address(RVA = "0x449CA18", Offset = "0x4498A18", VA = "0x449CA18", Slot = "5")]
				get
				{ return (Vector3)simulator.simulationData.position[agentIndex.Index]; }
				[Token(Token = "0x6001185")]
				[Address(RVA = "0x449CA54", Offset = "0x4498A54", VA = "0x449CA54", Slot = "6")]
				set
				{ simulator.simulationData.position[agentIndex.Index] = (float3)value; }
			}

			[Token(Token = "0x170002A1")]
			public bool Locked
			{
				[Token(Token = "0x6001186")]
				[Address(RVA = "0x449CACC", Offset = "0x4498ACC", VA = "0x449CACC", Slot = "13")]
				get
				{ return simulator.simulationData.locked[agentIndex.Index]; }
				[Token(Token = "0x6001187")]
				[Address(RVA = "0x449CAF8", Offset = "0x4498AF8", VA = "0x449CAF8", Slot = "14")]
				set
				{ simulator.simulationData.locked[agentIndex.Index] = value; }
			}

			[Token(Token = "0x170002A2")]
			public float Radius
			{
				[Token(Token = "0x6001188")]
				[Address(RVA = "0x449CB30", Offset = "0x4498B30", VA = "0x449CB30", Slot = "15")]
				get
				{ return simulator.simulationData.radius[agentIndex.Index]; }
				[Token(Token = "0x6001189")]
				[Address(RVA = "0x449CB5C", Offset = "0x4498B5C", VA = "0x449CB5C", Slot = "16")]
				set
				{ simulator.simulationData.radius[agentIndex.Index] = value; }
			}

			[Token(Token = "0x170002A3")]
			public float Height
			{
				[Token(Token = "0x600118A")]
				[Address(RVA = "0x449CB94", Offset = "0x4498B94", VA = "0x449CB94", Slot = "17")]
				get
				{ return simulator.simulationData.height[agentIndex.Index]; }
				[Token(Token = "0x600118B")]
				[Address(RVA = "0x449CBC0", Offset = "0x4498BC0", VA = "0x449CBC0", Slot = "18")]
				set
				{ simulator.simulationData.height[agentIndex.Index] = value; }
			}

			[Token(Token = "0x170002A4")]
			public float AgentTimeHorizon
			{
				[Token(Token = "0x600118C")]
				[Address(RVA = "0x449CBF8", Offset = "0x4498BF8", VA = "0x449CBF8", Slot = "19")]
				get
				{ return simulator.simulationData.agentTimeHorizon[agentIndex.Index]; }
				[Token(Token = "0x600118D")]
				[Address(RVA = "0x449CC24", Offset = "0x4498C24", VA = "0x449CC24", Slot = "20")]
				set
				{ simulator.simulationData.agentTimeHorizon[agentIndex.Index] = value; }
			}

			[Token(Token = "0x170002A5")]
			public float ObstacleTimeHorizon
			{
				[Token(Token = "0x600118E")]
				[Address(RVA = "0x449CC5C", Offset = "0x4498C5C", VA = "0x449CC5C", Slot = "21")]
				get
				{ return simulator.simulationData.obstacleTimeHorizon[agentIndex.Index]; }
				[Token(Token = "0x600118F")]
				[Address(RVA = "0x449CC88", Offset = "0x4498C88", VA = "0x449CC88", Slot = "22")]
				set
				{ simulator.simulationData.obstacleTimeHorizon[agentIndex.Index] = value; }
			}

			[Token(Token = "0x170002A6")]
			public int MaxNeighbours
			{
				[Token(Token = "0x6001190")]
				[Address(RVA = "0x449CCC0", Offset = "0x4498CC0", VA = "0x449CCC0", Slot = "23")]
				get
				{ return simulator.simulationData.maxNeighbours[agentIndex.Index]; }
				[Token(Token = "0x6001191")]
				[Address(RVA = "0x449CCEC", Offset = "0x4498CEC", VA = "0x449CCEC", Slot = "24")]
				set
				{ simulator.simulationData.maxNeighbours[agentIndex.Index] = value; }
			}

			[Token(Token = "0x170002A7")]
			public RVOLayer Layer
			{
				[Token(Token = "0x6001192")]
				[Address(RVA = "0x449CD24", Offset = "0x4498D24", VA = "0x449CD24", Slot = "26")]
				get
				{ return simulator.simulationData.layer[agentIndex.Index]; }
				[Token(Token = "0x6001193")]
				[Address(RVA = "0x449CD50", Offset = "0x4498D50", VA = "0x449CD50", Slot = "27")]
				set
				{ simulator.simulationData.layer[agentIndex.Index] = value; }
			}

			[Token(Token = "0x170002A8")]
			public RVOLayer CollidesWith
			{
				[Token(Token = "0x6001194")]
				[Address(RVA = "0x449CD88", Offset = "0x4498D88", VA = "0x449CD88", Slot = "28")]
				get
				{ return simulator.simulationData.collidesWith[agentIndex.Index]; }
				[Token(Token = "0x6001195")]
				[Address(RVA = "0x449CDB4", Offset = "0x4498DB4", VA = "0x449CDB4", Slot = "29")]
				set
				{ simulator.simulationData.collidesWith[agentIndex.Index] = value; }
			}

			[Token(Token = "0x170002A9")]
			public float FlowFollowingStrength
			{
				[Token(Token = "0x6001196")]
				[Address(RVA = "0x449CDEC", Offset = "0x4498DEC", VA = "0x449CDEC", Slot = "30")]
				get
				{ return simulator.simulationData.flowFollowingStrength[agentIndex.Index]; }
				[Token(Token = "0x6001197")]
				[Address(RVA = "0x449CE18", Offset = "0x4498E18", VA = "0x449CE18", Slot = "31")]
				set
				{ simulator.simulationData.flowFollowingStrength[agentIndex.Index] = value; }
			}

			[Token(Token = "0x170002AA")]
			public AgentDebugFlags DebugFlags
			{
				[Token(Token = "0x6001198")]
				[Address(RVA = "0x449CE50", Offset = "0x4498E50", VA = "0x449CE50", Slot = "32")]
				get
				{ return simulator.simulationData.debugFlags[agentIndex.Index]; }
				[Token(Token = "0x6001199")]
				[Address(RVA = "0x449CE7C", Offset = "0x4498E7C", VA = "0x449CE7C", Slot = "33")]
				set
				{ simulator.simulationData.debugFlags[agentIndex.Index] = value; }
			}

			[Token(Token = "0x170002AB")]
			public float Priority
			{
				[Token(Token = "0x600119A")]
				[Address(RVA = "0x449CEB4", Offset = "0x4498EB4", VA = "0x449CEB4", Slot = "34")]
				get
				{ return simulator.simulationData.priority[agentIndex.Index]; }
				[Token(Token = "0x600119B")]
				[Address(RVA = "0x449CEE0", Offset = "0x4498EE0", VA = "0x449CEE0", Slot = "35")]
				set
				{ simulator.simulationData.priority[agentIndex.Index] = value; }
			}

			[Token(Token = "0x170002AC")]
			public int HierarchicalNodeIndex
			{
				[Token(Token = "0x600119C")]
				[Address(RVA = "0x449CF18", Offset = "0x4498F18", VA = "0x449CF18", Slot = "36")]
				get
				{ return simulator.simulationData.hierarchicalNodeIndex[agentIndex.Index]; }
				[Token(Token = "0x600119D")]
				[Address(RVA = "0x449CF44", Offset = "0x4498F44", VA = "0x449CF44", Slot = "37")]
				set
				{ simulator.simulationData.hierarchicalNodeIndex[agentIndex.Index] = value; }
			}

			[Token(Token = "0x170002AD")]
			public SimpleMovementPlane MovementPlane
			{
				[Token(Token = "0x600119E")]
				[Address(RVA = "0x449CF7C", Offset = "0x4498F7C", VA = "0x449CF7C", Slot = "11")]
				get
				{ return new SimpleMovementPlane((Quaternion)simulator.simulationData.movementPlane[agentIndex.Index].rotation); }
				[Token(Token = "0x600119F")]
				[Address(RVA = "0x449CFD4", Offset = "0x4498FD4", VA = "0x449CFD4", Slot = "12")]
				set
				{ simulator.simulationData.movementPlane[agentIndex.Index] = new NativeMovementPlane(value); }
			}

			[Token(Token = "0x170002AE")]
			public Action PreCalculationCallback
			{
				[Token(Token = "0x60011A0")]
				[Address(RVA = "0x449D03C", Offset = "0x449903C", VA = "0x449D03C", Slot = "38")]
				set
				{ simulator.agentPreCalculationCallbacks[agentIndex.Index] = value; }
			}

			[Token(Token = "0x170002AF")]
			public Action DestroyedCallback
			{
				[Token(Token = "0x60011A1")]
				[Address(RVA = "0x449D08C", Offset = "0x449908C", VA = "0x449D08C", Slot = "39")]
				set
				{ simulator.agentDestroyCallbacks[agentIndex.Index] = value; }
			}

			[Token(Token = "0x170002B0")]
			public Vector3 CalculatedTargetPoint
			{
				[Token(Token = "0x60011A2")]
				[Address(RVA = "0x449D0DC", Offset = "0x44990DC", VA = "0x449D0DC", Slot = "7")]
				get
				{ simulator.BlockUntilSimulationStepDone(); return (Vector3)simulator.outputData.targetPoint[agentIndex.Index]; }
			}

			[Token(Token = "0x170002B1")]
			public float CalculatedSpeed
			{
				[Token(Token = "0x60011A3")]
				[Address(RVA = "0x449D134", Offset = "0x4499134", VA = "0x449D134", Slot = "9")]
				get
				{ simulator.BlockUntilSimulationStepDone(); return simulator.outputData.speed[agentIndex.Index]; }
			}

			[Token(Token = "0x170002B2")]
			public ReachedEndOfPath CalculatedEffectivelyReachedDestination
			{
				[Token(Token = "0x60011A4")]
				[Address(RVA = "0x449D178", Offset = "0x4499178", VA = "0x449D178", Slot = "42")]
				get
				{ simulator.BlockUntilSimulationStepDone(); return simulator.outputData.effectivelyReachedDestination[agentIndex.Index]; }
			}

			[Token(Token = "0x170002B3")]
			public int NeighbourCount
			{
				[Token(Token = "0x60011A5")]
				[Address(RVA = "0x449D1BC", Offset = "0x44991BC", VA = "0x449D1BC", Slot = "25")]
				get
				{ simulator.BlockUntilSimulationStepDone(); return simulator.outputData.numNeighbours[agentIndex.Index]; }
			}

			[Token(Token = "0x170002B4")]
			public bool AvoidingAnyAgents
			{
				[Token(Token = "0x60011A6")]
				[Address(RVA = "0x449D200", Offset = "0x4499200", VA = "0x449D200", Slot = "8")]
				get
				{ simulator.BlockUntilSimulationStepDone(); return simulator.outputData.blockedByAgents[agentIndex.Index * 7] != -1; }
			}

			[Token(Token = "0x60011A7")]
			[Address(RVA = "0x449D254", Offset = "0x4499254", VA = "0x449D254", Slot = "43")]
			public void SetObstacleQuery(GraphNode sourceNode)
			{
            HierarchicalNodeIndex = sourceNode == null || sourceNode.Destroyed || !sourceNode.Walkable ? -1 : sourceNode.HierarchicalNodeIndex;
        }

			[Token(Token = "0x60011A8")]
			[Address(RVA = "0x449D2BC", Offset = "0x44992BC", VA = "0x449D2BC", Slot = "10")]
			public void SetTarget(Vector3 targetPoint, float desiredSpeed, float maxSpeed, Vector3 endOfPath)
			{
            simulator.simulationData.SetTarget(agentIndex.Index, (float3)targetPoint, desiredSpeed, maxSpeed, (float3)endOfPath);
        }

			[Token(Token = "0x60011A9")]
			[Address(RVA = "0x449D390", Offset = "0x4499390", VA = "0x449D390", Slot = "40")]
			public void SetCollisionNormal(Vector3 normal)
			{
            simulator.simulationData.collisionNormal[agentIndex.Index] = (float3)normal;
        }

			[Token(Token = "0x60011AA")]
			[Address(RVA = "0x449D408", Offset = "0x4499408", VA = "0x449D408", Slot = "41")]
			public void ForceSetVelocity(Vector3 velocity)
			{
            int targetIndex = agentIndex.Index;
            simulator.simulationData.targetPoint[targetIndex] = simulator.simulationData.position[agentIndex.Index] + (float3)velocity * 1000f;
            simulator.simulationData.desiredSpeed[agentIndex.Index] = math.length((float3)velocity);
            simulator.simulationData.allowedVelocityDeviationAngles[agentIndex.Index] = float2.zero;
            simulator.simulationData.manuallyControlled[agentIndex.Index] = true;
        }
		}

		[Token(Token = "0x20002C9")]
		public struct ObstacleData
		{
			[Token(Token = "0x4000CBF")]
			[FieldOffset(Offset = "0x0")]
			public SlabAllocator<ObstacleVertexGroup> obstacleVertexGroups;

			[Token(Token = "0x4000CC0")]
			[FieldOffset(Offset = "0x8")]
			public SlabAllocator<float3> obstacleVertices;

			[Token(Token = "0x4000CC1")]
			[FieldOffset(Offset = "0x10")]
			public NativeList<UnmanagedObstacle> obstacles;

			[Token(Token = "0x60011AB")]
			[Address(RVA = "0x449F044", Offset = "0x449B044", VA = "0x449F044")]
			public void Init(Allocator allocator)
			{
 if (!obstacles.IsCreated) obstacles = new NativeList<UnmanagedObstacle>(0, allocator);
 if (!obstacleVertexGroups.IsCreated) obstacleVertexGroups = new SlabAllocator<ObstacleVertexGroup>(4, allocator);
 if (!obstacleVertices.IsCreated) obstacleVertices = new SlabAllocator<float3>(16, allocator);
}

			[Token(Token = "0x60011AC")]
			[Address(RVA = "0x449F19C", Offset = "0x449B19C", VA = "0x449F19C")]
			public void Dispose()
			{
 if (obstacleVertexGroups.IsCreated) {
  obstacleVertexGroups.Dispose();
  obstacleVertices.Dispose();
  obstacles.Dispose();
 }
}
		}

		[Token(Token = "0x20002CA")]
		public struct AgentData
		{
			[Token(Token = "0x4000CC2")]
			[FieldOffset(Offset = "0x0")]
			public NativeArray<AgentIndex> version;

			[Token(Token = "0x4000CC3")]
			[FieldOffset(Offset = "0x10")]
			public NativeArray<float> radius;

			[Token(Token = "0x4000CC4")]
			[FieldOffset(Offset = "0x20")]
			public NativeArray<float> height;

			[Token(Token = "0x4000CC5")]
			[FieldOffset(Offset = "0x30")]
			public NativeArray<float> desiredSpeed;

			[Token(Token = "0x4000CC6")]
			[FieldOffset(Offset = "0x40")]
			public NativeArray<float> maxSpeed;

			[Token(Token = "0x4000CC7")]
			[FieldOffset(Offset = "0x50")]
			public NativeArray<float> agentTimeHorizon;

			[Token(Token = "0x4000CC8")]
			[FieldOffset(Offset = "0x60")]
			public NativeArray<float> obstacleTimeHorizon;

			[Token(Token = "0x4000CC9")]
			[FieldOffset(Offset = "0x70")]
			public NativeArray<bool> locked;

			[Token(Token = "0x4000CCA")]
			[FieldOffset(Offset = "0x80")]
			public NativeArray<int> maxNeighbours;

			[Token(Token = "0x4000CCB")]
			[FieldOffset(Offset = "0x90")]
			public NativeArray<RVOLayer> layer;

			[Token(Token = "0x4000CCC")]
			[FieldOffset(Offset = "0xA0")]
			public NativeArray<RVOLayer> collidesWith;

			[Token(Token = "0x4000CCD")]
			[FieldOffset(Offset = "0xB0")]
			public NativeArray<float> flowFollowingStrength;

			[Token(Token = "0x4000CCE")]
			[FieldOffset(Offset = "0xC0")]
			public NativeArray<float3> position;

			[Token(Token = "0x4000CCF")]
			[FieldOffset(Offset = "0xD0")]
			public NativeArray<float3> collisionNormal;

			[Token(Token = "0x4000CD0")]
			[FieldOffset(Offset = "0xE0")]
			public NativeArray<bool> manuallyControlled;

			[Token(Token = "0x4000CD1")]
			[FieldOffset(Offset = "0xF0")]
			public NativeArray<float> priority;

			[Token(Token = "0x4000CD2")]
			[FieldOffset(Offset = "0x100")]
			public NativeArray<AgentDebugFlags> debugFlags;

			[Token(Token = "0x4000CD3")]
			[FieldOffset(Offset = "0x110")]
			public NativeArray<float3> targetPoint;

			[Token(Token = "0x4000CD4")]
			[FieldOffset(Offset = "0x120")]
			public NativeArray<float2> allowedVelocityDeviationAngles;

			[Token(Token = "0x4000CD5")]
			[FieldOffset(Offset = "0x130")]
			public NativeArray<NativeMovementPlane> movementPlane;

			[Token(Token = "0x4000CD6")]
			[FieldOffset(Offset = "0x140")]
			public NativeArray<float3> endOfPath;

			[Token(Token = "0x4000CD7")]
			[FieldOffset(Offset = "0x150")]
			public NativeArray<int> agentObstacleMapping;

			[Token(Token = "0x4000CD8")]
			[FieldOffset(Offset = "0x160")]
			public NativeArray<int> hierarchicalNodeIndex;

			[Token(Token = "0x60011AD")]
			[Address(RVA = "0x449F254", Offset = "0x449B254", VA = "0x449F254")]
			public void Realloc(int size, Allocator allocator)
			{
                Memory.Realloc(ref version, size, allocator, NativeArrayOptions.UninitializedMemory);
                Memory.Realloc(ref radius, size, allocator, NativeArrayOptions.UninitializedMemory);
                Memory.Realloc(ref height, size, allocator, NativeArrayOptions.UninitializedMemory);
                Memory.Realloc(ref desiredSpeed, size, allocator, NativeArrayOptions.UninitializedMemory);
                Memory.Realloc(ref maxSpeed, size, allocator, NativeArrayOptions.UninitializedMemory);
                Memory.Realloc(ref agentTimeHorizon, size, allocator, NativeArrayOptions.UninitializedMemory);
                Memory.Realloc(ref obstacleTimeHorizon, size, allocator, NativeArrayOptions.UninitializedMemory);
                Memory.Realloc(ref locked, size, allocator, NativeArrayOptions.UninitializedMemory);
                Memory.Realloc(ref maxNeighbours, size, allocator, NativeArrayOptions.UninitializedMemory);
                Memory.Realloc(ref layer, size, allocator, NativeArrayOptions.UninitializedMemory);
                Memory.Realloc(ref collidesWith, size, allocator, NativeArrayOptions.UninitializedMemory);
                Memory.Realloc(ref flowFollowingStrength, size, allocator, NativeArrayOptions.UninitializedMemory);
                Memory.Realloc(ref position, size, allocator, NativeArrayOptions.UninitializedMemory);
                Memory.Realloc(ref collisionNormal, size, allocator, NativeArrayOptions.UninitializedMemory);
                Memory.Realloc(ref manuallyControlled, size, allocator, NativeArrayOptions.UninitializedMemory);
                Memory.Realloc(ref priority, size, allocator, NativeArrayOptions.UninitializedMemory);
                Memory.Realloc(ref debugFlags, size, allocator, NativeArrayOptions.UninitializedMemory);
                Memory.Realloc(ref targetPoint, size, allocator, NativeArrayOptions.UninitializedMemory);
                Memory.Realloc(ref movementPlane, size, allocator, NativeArrayOptions.UninitializedMemory);
                Memory.Realloc(ref allowedVelocityDeviationAngles, size, allocator, NativeArrayOptions.UninitializedMemory);
                Memory.Realloc(ref endOfPath, size, allocator, NativeArrayOptions.UninitializedMemory);
                Memory.Realloc(ref agentObstacleMapping, size, allocator, NativeArrayOptions.UninitializedMemory);
                Memory.Realloc(ref hierarchicalNodeIndex, size, allocator, NativeArrayOptions.UninitializedMemory);
            }

			[Token(Token = "0x60011AE")]
			[Address(RVA = "0x449F580", Offset = "0x449B580", VA = "0x449F580")]
			public void SetTarget(int agentIndex, float3 targetPoint, float desiredSpeed, float maxSpeed, float3 endOfPath)
			{
            maxSpeed = math.max(maxSpeed, 0f);
            if (float.IsNaN(desiredSpeed) || desiredSpeed > maxSpeed) desiredSpeed = maxSpeed;
            this.targetPoint[agentIndex] = targetPoint;
            if (float.IsNaN(desiredSpeed) || desiredSpeed < 0f) desiredSpeed = 0f;
            this.desiredSpeed[agentIndex] = desiredSpeed;
            this.maxSpeed[agentIndex] = maxSpeed;
            this.endOfPath[agentIndex] = endOfPath;
        }

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x60011AF")]
			[Address(RVA = "0x449F5F0", Offset = "0x449B5F0", VA = "0x449F5F0")]
			public bool HasDebugFlag(int agentIndex, AgentDebugFlags flag)
			{
            return (debugFlags[agentIndex] & flag) != 0;
        }

			[Token(Token = "0x60011B0")]
			[Address(RVA = "0x449F608", Offset = "0x449B608", VA = "0x449F608")]
			public void Dispose()
			{
                version.Dispose();
                radius.Dispose();
                height.Dispose();
                desiredSpeed.Dispose();
                maxSpeed.Dispose();
                agentTimeHorizon.Dispose();
                obstacleTimeHorizon.Dispose();
                locked.Dispose();
                maxNeighbours.Dispose();
                layer.Dispose();
                collidesWith.Dispose();
                flowFollowingStrength.Dispose();
                position.Dispose();
                collisionNormal.Dispose();
                manuallyControlled.Dispose();
                priority.Dispose();
                debugFlags.Dispose();
                targetPoint.Dispose();
                movementPlane.Dispose();
                allowedVelocityDeviationAngles.Dispose();
                endOfPath.Dispose();
                agentObstacleMapping.Dispose();
                hierarchicalNodeIndex.Dispose();
            }
		}

		[Token(Token = "0x20002CB")]
		public struct AgentOutputData
		{
			[Token(Token = "0x4000CD9")]
			[FieldOffset(Offset = "0x0")]
			public NativeArray<float3> targetPoint;

			[Token(Token = "0x4000CDA")]
			[FieldOffset(Offset = "0x10")]
			public NativeArray<float> speed;

			[Token(Token = "0x4000CDB")]
			[FieldOffset(Offset = "0x20")]
			public NativeArray<int> numNeighbours;

			[Token(Token = "0x4000CDC")]
			[FieldOffset(Offset = "0x30")]
			[NativeDisableParallelForRestriction]
			public NativeArray<int> blockedByAgents;

			[Token(Token = "0x4000CDD")]
			[FieldOffset(Offset = "0x40")]
			public NativeArray<ReachedEndOfPath> effectivelyReachedDestination;

			[Token(Token = "0x4000CDE")]
			[FieldOffset(Offset = "0x50")]
			public NativeArray<float> forwardClearance;

			[Token(Token = "0x60011B1")]
			[Address(RVA = "0x449F818", Offset = "0x449B818", VA = "0x449F818")]
			public void Realloc(int size, Allocator allocator)
			{
                Memory.Realloc(ref targetPoint, size, allocator, NativeArrayOptions.UninitializedMemory);
                Memory.Realloc(ref speed, size, allocator, NativeArrayOptions.UninitializedMemory);
                Memory.Realloc(ref numNeighbours, size, allocator, NativeArrayOptions.UninitializedMemory);
                Memory.Realloc(ref blockedByAgents, size * 7, allocator, NativeArrayOptions.UninitializedMemory);
                Memory.Realloc(ref effectivelyReachedDestination, size, allocator, NativeArrayOptions.UninitializedMemory);
                Memory.Realloc(ref forwardClearance, size, allocator, NativeArrayOptions.UninitializedMemory);
            }

			[Token(Token = "0x60011B2")]
			[Address(RVA = "0x449F944", Offset = "0x449B944", VA = "0x449F944")]
			public void Move(int fromIndex, int toIndex)
			{
			}

			[Token(Token = "0x60011B3")]
			[Address(RVA = "0x449F9D8", Offset = "0x449B9D8", VA = "0x449F9D8")]
			public void Dispose()
			{
                targetPoint.Dispose();
                speed.Dispose();
                numNeighbours.Dispose();
                blockedByAgents.Dispose();
                effectivelyReachedDestination.Dispose();
                forwardClearance.Dispose();
            }
		}

		[Token(Token = "0x20002CC")]
		public struct HorizonAgentData
		{
			[Token(Token = "0x4000CDF")]
			[FieldOffset(Offset = "0x0")]
			public NativeArray<int> horizonSide;

			[Token(Token = "0x4000CE0")]
			[FieldOffset(Offset = "0x10")]
			public NativeArray<float> horizonMinAngle;

			[Token(Token = "0x4000CE1")]
			[FieldOffset(Offset = "0x20")]
			public NativeArray<float> horizonMaxAngle;

			[Token(Token = "0x60011B4")]
			[Address(RVA = "0x449FAA8", Offset = "0x449BAA8", VA = "0x449FAA8")]
			public void Realloc(int size, Allocator allocator)
			{
                Memory.Realloc(ref horizonSide, size, allocator, NativeArrayOptions.UninitializedMemory);
                Memory.Realloc(ref horizonMinAngle, size, allocator, NativeArrayOptions.UninitializedMemory);
                Memory.Realloc(ref horizonMaxAngle, size, allocator, NativeArrayOptions.UninitializedMemory);
            }

			[Token(Token = "0x60011B5")]
			[Address(RVA = "0x449FB58", Offset = "0x449BB58", VA = "0x449FB58")]
			public void Move(int fromIndex, int toIndex)
			{
			}

			[Token(Token = "0x60011B6")]
			[Address(RVA = "0x449FB68", Offset = "0x449BB68", VA = "0x449FB68")]
			public void Dispose()
			{
                horizonSide.Dispose();
                horizonMinAngle.Dispose();
                horizonMaxAngle.Dispose();
            }
		}

		[Token(Token = "0x20002CD")]
		public struct TemporaryAgentData
		{
			[Token(Token = "0x4000CE2")]
			[FieldOffset(Offset = "0x0")]
			public NativeArray<float2> desiredTargetPointInVelocitySpace;

			[Token(Token = "0x4000CE3")]
			[FieldOffset(Offset = "0x10")]
			public NativeArray<float3> desiredVelocity;

			[Token(Token = "0x4000CE4")]
			[FieldOffset(Offset = "0x20")]
			public NativeArray<float3> currentVelocity;

			[Token(Token = "0x4000CE5")]
			[FieldOffset(Offset = "0x30")]
			public NativeArray<float2> collisionVelocityOffsets;

			[Token(Token = "0x4000CE6")]
			[FieldOffset(Offset = "0x40")]
			public NativeArray<int> neighbours;

			[Token(Token = "0x60011B7")]
			[Address(RVA = "0x449FBE4", Offset = "0x449BBE4", VA = "0x449FBE4")]
			public void Realloc(int size, Allocator allocator)
			{
                Memory.Realloc(ref desiredTargetPointInVelocitySpace, size, allocator, NativeArrayOptions.UninitializedMemory);
                Memory.Realloc(ref desiredVelocity, size, allocator, NativeArrayOptions.UninitializedMemory);
                Memory.Realloc(ref currentVelocity, size, allocator, NativeArrayOptions.UninitializedMemory);
                Memory.Realloc(ref collisionVelocityOffsets, size, allocator, NativeArrayOptions.UninitializedMemory);
                Memory.Realloc(ref neighbours, size * 50, allocator, NativeArrayOptions.UninitializedMemory);
            }

			[Token(Token = "0x60011B8")]
			[Address(RVA = "0x449FCDC", Offset = "0x449BCDC", VA = "0x449FCDC")]
			public void Dispose()
			{
                desiredTargetPointInVelocitySpace.Dispose();
                desiredVelocity.Dispose();
                currentVelocity.Dispose();
                collisionVelocityOffsets.Dispose();
                neighbours.Dispose();
            }
		}

		[Token(Token = "0x4000CA8")]
		[FieldOffset(Offset = "0x10")]
		private float desiredDeltaTime;

		[Token(Token = "0x4000CA9")]
		[FieldOffset(Offset = "0x14")]
		private int numAgents;

		[Token(Token = "0x4000CAA")]
		[FieldOffset(Offset = "0x18")]
		private RedrawScope debugDrawingScope;

		[Token(Token = "0x4000CAB")]
		[FieldOffset(Offset = "0x28")]
		public RVOQuadtreeBurst quadtree;

		[Token(Token = "0x4000CAC")]
		[FieldOffset(Offset = "0xC0")]
		public bool drawQuadtree;

		[Token(Token = "0x4000CAD")]
		[FieldOffset(Offset = "0xC8")]
		private Action[] agentPreCalculationCallbacks;

		[Token(Token = "0x4000CAE")]
		[FieldOffset(Offset = "0xD0")]
		private Action[] agentDestroyCallbacks;

		[Token(Token = "0x4000CAF")]
		[FieldOffset(Offset = "0xD8")]
		private Stack<int> freeAgentIndices;

		[Token(Token = "0x4000CB0")]
		[FieldOffset(Offset = "0xE0")]
		private TemporaryAgentData temporaryAgentData;

		[Token(Token = "0x4000CB1")]
		[FieldOffset(Offset = "0x130")]
		private HorizonAgentData horizonAgentData;

		[Token(Token = "0x4000CB2")]
		[FieldOffset(Offset = "0x160")]
		public AgentData simulationData;

		[Token(Token = "0x4000CB3")]
		[FieldOffset(Offset = "0x2D0")]
		public AgentOutputData outputData;

		[Token(Token = "0x4000CB4")]
		public const int MaxNeighbourCount = 50;

		[Token(Token = "0x4000CB5")]
		public const int MaxBlockingAgentCount = 7;

		[Token(Token = "0x4000CB6")]
		public const int MaxObstacleVertices = 256;

		[field: Token(Token = "0x4000CB7")]
		[field: FieldOffset(Offset = "0x330")]
		[Token(Token = "0x17000298")]
		public float SymmetryBreakingBias
		{
			[Token(Token = "0x6001168")]
			[Address(RVA = "0x449B8AC", Offset = "0x44978AC", VA = "0x449B8AC")]
			get;
			[Token(Token = "0x6001169")]
			[Address(RVA = "0x449B8B4", Offset = "0x44978B4", VA = "0x449B8B4")]
			set;
		}

		[field: Token(Token = "0x4000CB8")]
		[field: FieldOffset(Offset = "0x334")]
		[Token(Token = "0x17000299")]
		public bool HardCollisions
		{
			[Token(Token = "0x600116A")]
			[Address(RVA = "0x449B8BC", Offset = "0x44978BC", VA = "0x449B8BC")]
			get;
			[Token(Token = "0x600116B")]
			[Address(RVA = "0x449B8C4", Offset = "0x44978C4", VA = "0x449B8C4")]
			set;
		}

		[field: Token(Token = "0x4000CB9")]
		[field: FieldOffset(Offset = "0x335")]
		[Token(Token = "0x1700029A")]
		public bool UseNavmeshAsObstacle
		{
			[Token(Token = "0x600116C")]
			[Address(RVA = "0x449B8D0", Offset = "0x44978D0", VA = "0x449B8D0")]
			get;
			[Token(Token = "0x600116D")]
			[Address(RVA = "0x449B8D8", Offset = "0x44978D8", VA = "0x449B8D8")]
			set;
		}

		[Token(Token = "0x4000CBA")]
		[FieldOffset(Offset = "0x338")]
		public readonly MovementPlane movementPlane;

		[Token(Token = "0x4000CBB")]
		[FieldOffset(Offset = "0x340")]
		private RWLock rwLock;

		[Token(Token = "0x17000297")]
		public float DesiredDeltaTime
		{
			[Token(Token = "0x6001166")]
			[Address(RVA = "0x449B834", Offset = "0x4497834", VA = "0x449B834")]
			get
			{ return desiredDeltaTime; }
			[Token(Token = "0x6001167")]
			[Address(RVA = "0x449B83C", Offset = "0x449783C", VA = "0x449B83C")]
			set
			{ desiredDeltaTime = Math.Max(value, 0f); }
		}







		[Token(Token = "0x1700029B")]
		public Rect AgentBounds
		{
			[Token(Token = "0x600116E")]
			[Address(RVA = "0x449B8E4", Offset = "0x44978E4", VA = "0x449B8E4")]
			get
			{
            rwLock.ReadSync().Unlock(); return quadtree.bounds;
        }
		}

		[Token(Token = "0x1700029C")]
		public int AgentCount
		{
			[Token(Token = "0x600116F")]
			[Address(RVA = "0x449B964", Offset = "0x4497964", VA = "0x449B964")]
			get
			{ return numAgents; }
		}

		[Token(Token = "0x1700029D")]
		public MovementPlane MovementPlane
		{
			[Token(Token = "0x6001170")]
			[Address(RVA = "0x449B96C", Offset = "0x449796C", VA = "0x449B96C")]
			get
			{ return movementPlane; }
		}

		[Token(Token = "0x1700029E")]
		public bool anyAgentsInSimulation
		{
			[Token(Token = "0x6001176")]
			[Address(RVA = "0x449BE10", Offset = "0x4497E10", VA = "0x449BE10")]
			get
			{ return numAgents > freeAgentIndices.Count; }
		}

		[Token(Token = "0x6001165")]
		[Address(RVA = "0x449B828", Offset = "0x4497828", VA = "0x449B828")]
		public AgentNeighbourLookup GetAgentNeighbourLookup()
		{
            return new AgentNeighbourLookup(temporaryAgentData.neighbours);
        }

		[Token(Token = "0x6001171")]
		[Address(RVA = "0x449B974", Offset = "0x4497974", VA = "0x449B974")]
		public void BlockUntilSimulationStepDone()
		{ rwLock.WriteSync().Unlock(); }

		[Token(Token = "0x6001172")]
		[Address(RVA = "0x449B9A4", Offset = "0x44979A4", VA = "0x449B9A4")]
		public SimulatorBurst(MovementPlane movementPlane)
		{
            desiredDeltaTime = 0.05f;
            agentPreCalculationCallbacks = new Action[0];
            agentDestroyCallbacks = new Action[0];
            freeAgentIndices = new Stack<int>();
            rwLock = new RWLock();
            DesiredDeltaTime = 1f;
            this.movementPlane = movementPlane;
            AllocateAgentSpace();
            quadtree.BuildJob(simulationData.position, simulationData.version, simulationData.desiredSpeed, simulationData.radius, 0, movementPlane).Run();
        }

		[Token(Token = "0x6001173")]
		[Address(RVA = "0x449BCC4", Offset = "0x4497CC4", VA = "0x449BCC4")]
		public void ClearAgents()
		{
            BlockUntilSimulationStepDone();
            for (int i = 0; i < agentDestroyCallbacks.Length; i++) agentDestroyCallbacks[i]?.Invoke();
            numAgents = 0;
        }

		[Token(Token = "0x6001174")]
		[Address(RVA = "0x449BD44", Offset = "0x4497D44", VA = "0x449BD44")]
		public void OnDestroy()
		{
            debugDrawingScope.Dispose();
            BlockUntilSimulationStepDone();
            ClearAgents();
            simulationData.Dispose();
            temporaryAgentData.Dispose();
            outputData.Dispose();
            quadtree.Dispose();
            horizonAgentData.Dispose();
        }

		[Token(Token = "0x6001175")]
		[Address(RVA = "0x449BB7C", Offset = "0x4497B7C", VA = "0x449BB7C")]
		private void AllocateAgentSpace()
		{
            int capacity = agentPreCalculationCallbacks.Length;
            if (capacity == 0 || numAgents > capacity)
            {
                int size = Math.Max(Math.Max(numAgents, capacity * 2), 64);
                int oldSize = simulationData.version.Length;
                simulationData.Realloc(size, Allocator.Persistent);
                temporaryAgentData.Realloc(size, Allocator.Persistent);
                outputData.Realloc(size, Allocator.Persistent);
                horizonAgentData.Realloc(size, Allocator.Persistent);
                Memory.Realloc(ref agentPreCalculationCallbacks, size);
                Memory.Realloc(ref agentDestroyCallbacks, size);
                for (int i = oldSize; i < size; i++) simulationData.version[i] = new AgentIndex(0, i);
            }
        }

		[Token(Token = "0x6001177")]
		[Address(RVA = "0x449BE64", Offset = "0x4497E64", VA = "0x449BE64")]
		public IAgent AddAgent(Vector3 position)
		{
            return new Agent { simulator = this, agentIndex = AddAgentBurst((float3)position) };
        }

		[Token(Token = "0x6001178")]
		[Address(RVA = "0x449BEFC", Offset = "0x4497EFC", VA = "0x449BEFC")]
		public AgentIndex AddAgentBurst(float3 position)
		{
            BlockUntilSimulationStepDone();
            int index;
            if (freeAgentIndices.Count < 1)
            {
                index = numAgents++;
                AllocateAgentSpace();
            }
            else index = freeAgentIndices.Pop();
            AgentIndex result = simulationData.version[index].WithIncrementedVersion();
            simulationData.version[index] = result;
            simulationData.radius[index] = 5f;
            simulationData.height[index] = 5f;
            simulationData.desiredSpeed[index] = 0f;
            simulationData.maxSpeed[index] = 1f;
            simulationData.agentTimeHorizon[index] = 2f;
            simulationData.obstacleTimeHorizon[index] = 2f;
            simulationData.locked[index] = false;
            simulationData.maxNeighbours[index] = 10;
            simulationData.layer[index] = (RVOLayer)1;
            simulationData.collidesWith[index] = (RVOLayer)(-1);
            simulationData.flowFollowingStrength[index] = 0f;
            simulationData.position[index] = position;
            simulationData.collisionNormal[index] = UnityEngine.Vector3.zero;
            simulationData.manuallyControlled[index] = false;
            simulationData.priority[index] = 0.5f;
            simulationData.debugFlags[index] = 0;
            simulationData.targetPoint[index] = position;
            simulationData.movementPlane[index] = new NativeMovementPlane((quaternion)(movementPlane == MovementPlane.XY ? SimpleMovementPlane.XYPlane.rotation : SimpleMovementPlane.XZPlane.rotation));
            simulationData.allowedVelocityDeviationAngles[index] = UnityEngine.Vector2.zero;
            simulationData.endOfPath[index] = new float3(float.PositiveInfinity);
            simulationData.agentObstacleMapping[index] = -1;
            simulationData.hierarchicalNodeIndex[index] = -1;
            outputData.speed[index] = 0f;
            outputData.numNeighbours[index] = 0;
            outputData.targetPoint[index] = position;
            outputData.blockedByAgents[index * 7] = -1;
            outputData.effectivelyReachedDestination[index] = 0;
            temporaryAgentData.neighbours[index * 50] = -1;
            horizonAgentData.horizonSide[index] = 0;
            agentPreCalculationCallbacks[index] = null;
            agentDestroyCallbacks[index] = null;
            return result;
        }

		[Token(Token = "0x6001179")]
		[Address(RVA = "0x449C250", Offset = "0x4498250", VA = "0x449C250")]
		[Obsolete("Use AddAgent(Vector3) instead", true)]
		public IAgent AddAgent(IAgent agent)
		{
			return null;
		}

		[Token(Token = "0x600117A")]
		[Address(RVA = "0x449C258", Offset = "0x4498258", VA = "0x449C258")]
		public void RemoveAgent(IAgent agent)
		{
            if (agent == null) throw new ArgumentNullException("agent");
            Agent wrapper = (Agent)agent;
            RemoveAgent(wrapper.agentIndex, false);
        }

		[Token(Token = "0x600117B")]
		[Address(RVA = "0x449C318", Offset = "0x4498318", VA = "0x449C318")]
		public void RemoveAgent(AgentIndex agent, bool okIfMissing = false)
		{
            BlockUntilSimulationStepDone();
            if (agent.TryGetIndex(ref simulationData, out int index))
            {
                simulationData.version[index] = simulationData.version[index].WithIncrementedVersion().WithDeleted();
                agentPreCalculationCallbacks[index] = null;
                try
                {
                    agentDestroyCallbacks[index]?.Invoke();
                }
                catch (Exception exception)
                {
                    Debug.LogException(exception);
                }
                agentDestroyCallbacks[index] = null;
                freeAgentIndices.Push(index);
            }
            else if (!okIfMissing) throw new InvalidOperationException("Trying to remove agent which does not exist");
        }

		[Token(Token = "0x600117C")]
		[Address(RVA = "0x449C540", Offset = "0x4498540", VA = "0x449C540")]
		private void PreCalculation(JobHandle dependency)
		{
            bool synchronized = false;
            for (int i = 0; i < numAgents; i++)
            {
                Action callback = agentPreCalculationCallbacks[i];
                if (callback != null)
                {
                    if (!synchronized)
                    {
                        dependency.Complete();
                        rwLock.ReadSync().Unlock();
                    }
                    callback();
                    synchronized = true;
                }
            }
        }

		[Token(Token = "0x600117D")]
		[Address(RVA = "0x449C5F8", Offset = "0x44985F8", VA = "0x449C5F8")]
		public JobHandle Update(JobHandle dependency, float dt, bool drawGizmos, Allocator allocator)
		{
            if (movementPlane == MovementPlane.XZ) return UpdateInternal<XZMovementPlane>(dependency, dt, drawGizmos, allocator);
            if (movementPlane == MovementPlane.XY) return UpdateInternal<XYMovementPlane>(dependency, dt, drawGizmos, allocator);
            return UpdateInternal<ArbitraryMovementPlane>(dependency, dt, drawGizmos, allocator);
        }

		[Token(Token = "0x600117E")]
		[Address(RVA = "0x449C81C", Offset = "0x449881C", VA = "0x449C81C")]
		public RWLock.ReadLockAsync LockSimulationDataReadOnly()
		{
			return rwLock.Read();
		}

		[Token(Token = "0x600117F")]
		[Address(RVA = "0x449C85C", Offset = "0x449885C", VA = "0x449C85C")]
		public RWLock.WriteLockAsync LockSimulationDataReadWrite()
		{
			return rwLock.Write();
		}

		[Token(Token = "0x6001180")]
		private JobHandle UpdateInternal<T>(JobHandle dependency, float deltaTime, bool drawGizmos, Allocator allocator) where T : struct, IMovementPlaneWrapper
		{
            if (!anyAgentsInSimulation) return dependency;
            PreCalculation(dependency);
            float dt = math.max(deltaTime, 0.0005f);
            RWLock.WriteLockAsync writeLock = rwLock.Write();
            JobHandle inputDependency = JobHandle.CombineDependencies(dependency, writeLock.dependency);
            JobHandle build = quadtree.BuildJob(simulationData.position, simulationData.version, outputData.speed, simulationData.radius, numAgents, movementPlane).Schedule(inputDependency);
            JobHandle preprocess = new JobRVOPreprocess<T> {
                agentData = simulationData, previousOutput = outputData, temporaryAgentData = temporaryAgentData,
                startIndex = 0, endIndex = numAgents
            }.Schedule(inputDependency);
            int batchSize = Math.Max(numAgents / 64, 8);
            JobHandle neighbours = Pathfinding.Jobs.JobParallelForBatchedExtensions.ScheduleBatch(new JobRVOCalculateNeighbours<T> {
                agentData = simulationData, quadtree = quadtree, outNeighbours = temporaryAgentData.neighbours, output = outputData
            }, numAgents, batchSize, JobHandle.CombineDependencies(preprocess, build));
            JobHandle.ScheduleBatchedJobs();
            JobHandle neighbourDependency = JobHandle.CombineDependencies(preprocess, neighbours);
            JobHandle horizon1 = Pathfinding.Jobs.JobParallelForBatchedExtensions.ScheduleBatch(new JobHorizonAvoidancePhase1<T> {
                agentData = simulationData, desiredTargetPointInVelocitySpace = temporaryAgentData.desiredTargetPointInVelocitySpace,
                neighbours = temporaryAgentData.neighbours, horizonAgentData = horizonAgentData
            }, numAgents, batchSize, neighbourDependency);
            JobHandle horizon2 = Pathfinding.Jobs.JobParallelForBatchedExtensions.ScheduleBatch(new JobHorizonAvoidancePhase2<T> {
                neighbours = temporaryAgentData.neighbours, versions = simulationData.version,
                desiredVelocity = temporaryAgentData.desiredVelocity, desiredTargetPointInVelocitySpace = temporaryAgentData.desiredTargetPointInVelocitySpace,
                movementPlane = simulationData.movementPlane, horizonAgentData = horizonAgentData
            }, numAgents, batchSize, horizon1);
            JobHandle hardCollisionsJob = Pathfinding.Jobs.JobParallelForBatchedExtensions.ScheduleBatch(new JobHardCollisions<T> {
                agentData = simulationData, neighbours = temporaryAgentData.neighbours,
                collisionVelocityOffsets = temporaryAgentData.collisionVelocityOffsets, deltaTime = dt, enabled = HardCollisions
            }, numAgents, batchSize, neighbourDependency);
            bool hasAstar = AstarPath.active != null;
            RWLock.CombinedReadLockAsync navmeshLock = default;
            NavmeshEdges.NavmeshBorderData borders = hasAstar
                ? AstarPath.active.GetNavmeshBorderData(out navmeshLock)
                : NavmeshEdges.NavmeshBorderData.CreateEmpty(allocator);
            JobHandle calculation = Pathfinding.Jobs.JobParallelForBatchedExtensions.ScheduleBatch(new JobRVO<T> {
                agentData = simulationData, temporaryAgentData = temporaryAgentData, navmeshEdgeData = borders, output = outputData,
                deltaTime = dt, symmetryBreakingBias = math.max(SymmetryBreakingBias, 0f), priorityMultiplier = 1f,
                useNavmeshAsObstacle = UseNavmeshAsObstacle
            }, numAgents, batchSize, JobHandle.CombineDependencies(horizon2, hardCollisionsJob, navmeshLock.dependency));
            if (hasAstar) navmeshLock.UnlockAfter(calculation);
            else borders.DisposeEmpty(calculation);
            JobHandle destination = new JobDestinationReached<T> {
                agentData = simulationData, temporaryAgentData = temporaryAgentData, output = outputData, numAgents = numAgents
            }.Schedule(calculation);
            JobHandle resetCollisionNormal = Pathfinding.Jobs.NativeArrayExtensions.MemSet(simulationData.collisionNormal, float3.zero).Schedule(destination);
            JobHandle resetControlled = Pathfinding.Jobs.NativeArrayExtensions.MemSet(simulationData.manuallyControlled, false).Schedule(destination);
            JobHandle resetHierarchicalNode = Pathfinding.Jobs.NativeArrayExtensions.MemSet(simulationData.hierarchicalNodeIndex, -1).Schedule(destination);
            JobHandle result = JobHandle.CombineDependencies(JobHandle.CombineDependencies(destination, resetCollisionNormal, resetControlled), resetHierarchicalNode);
            writeLock.UnlockAfter(result);
            return result;
        }
	}
}
