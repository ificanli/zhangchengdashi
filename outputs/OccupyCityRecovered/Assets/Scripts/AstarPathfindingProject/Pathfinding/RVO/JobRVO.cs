using System.Collections.Generic;
using Il2CppDummyDll;
using Pathfinding.Collections;
using Pathfinding.Drawing;
using Pathfinding.Jobs;
using Unity.Burst;
using Unity.Collections;
using Unity.Mathematics;
using Unity.Profiling;
using UnityEngine;

namespace Pathfinding.RVO
{
	[Token(Token = "0x20002B6")]
	[BurstCompile(CompileSynchronously = true, FloatMode = FloatMode.Default)]
	public struct JobRVO<MovementPlaneWrapper> : IJobParallelForBatched where MovementPlaneWrapper : struct, IMovementPlaneWrapper
	{
		[Token(Token = "0x20002B7")]
		private struct SortByKey : IComparer<int>
		{
			[Token(Token = "0x4000C66")]
			[FieldOffset(Offset = "0x0")]
			public UnsafeSpan<float> keys;

			[Token(Token = "0x6001122")]
			public int Compare(int x, int y)
			{
            return keys[x].CompareTo(keys[y]);
        }
		}

		[Token(Token = "0x20002B8")]
		private struct ORCALine
		{
			[Token(Token = "0x4000C67")]
			[FieldOffset(Offset = "0x0")]
			public float2 point;

			[Token(Token = "0x4000C68")]
			[FieldOffset(Offset = "0x0")]
			public float2 direction;

			[Token(Token = "0x6001123")]
			public void DrawAsHalfPlane(CommandBuilder draw, float halfPlaneLength, float halfPlaneWidth, Color color)
			{
			}

			[Token(Token = "0x6001124")]
			public ORCALine(float2 position, float2 relativePosition, float2 velocity, float2 otherVelocity, float combinedRadius, float timeStep, float invTimeHorizon)
			{
            float distanceSq = math.lengthsq(relativePosition);
            float radiusSq = combinedRadius * combinedRadius;
            float2 correction;
            float2 baseVelocity;
            if (distanceSq <= radiusSq)
            {
                float inverseTimeStep = 1f / timeStep;
                float distance = math.sqrt(distanceSq);
                float2 normal = distance > 1.17549435e-38f ? relativePosition / distance : float2.zero;
                float penetration = (distance - combinedRadius) - 0.001f;
                correction = ((penetration * normal) * 0.3f) * inverseTimeStep;
                direction = math.normalizesafe(new float2(correction.y, -correction.x));
                baseVelocity = velocity + (otherVelocity - velocity) * 0.5f;
            }
            else
            {
                float2 relativeVelocity = velocity - otherVelocity;
                float2 w = relativeVelocity - relativePosition * invTimeHorizon;
                float projection = math.dot(relativePosition, w);
                float inflatedRadius = combinedRadius * 1.001f;
                float wLengthSq = math.lengthsq(w);
                if (projection >= 0f || projection * projection <= radiusSq * wLengthSq)
                {
                    float leg = math.sqrt(distanceSq - radiusSq);
                    if (det(relativePosition, w) <= 0f)
                    {
                        direction = new float2(inflatedRadius * -relativePosition.y - relativePosition.x * leg,
                            relativePosition.x * inflatedRadius - relativePosition.y * leg) / distanceSq;
                    }
                    else
                    {
                        direction = new float2(relativePosition.x * leg - relativePosition.y * inflatedRadius,
                            relativePosition.x * inflatedRadius + relativePosition.y * leg) / distanceSq;
                    }
                    float along = math.dot(relativeVelocity, direction);
                    correction = direction * along - relativeVelocity;
                }
                else
                {
                    float length = math.sqrt(wLengthSq);
                    float2 normal = w / length;
                    float amount = inflatedRadius * invTimeHorizon - length;
                    correction = normal * amount;
                    direction = new float2(normal.y, -normal.x);
                }
                baseVelocity = velocity;
            }
            point = baseVelocity + correction * 0.5f;
        }
		}

		[Token(Token = "0x20002B9")]
		private struct LinearProgram2Output
		{
			[Token(Token = "0x4000C69")]
			[FieldOffset(Offset = "0x0")]
			public float2 velocity;

			[Token(Token = "0x4000C6A")]
			[FieldOffset(Offset = "0x0")]
			public int firstFailedLineIndex;
		}

		[Token(Token = "0x4000C5B")]
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		public SimulatorBurst.AgentData agentData;

		[Token(Token = "0x4000C5C")]
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		public SimulatorBurst.TemporaryAgentData temporaryAgentData;

		[Token(Token = "0x4000C5D")]
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		public NavmeshEdges.NavmeshBorderData navmeshEdgeData;

		[Token(Token = "0x4000C5E")]
		[FieldOffset(Offset = "0x0")]
		[WriteOnly]
		public SimulatorBurst.AgentOutputData output;

		[Token(Token = "0x4000C5F")]
		[FieldOffset(Offset = "0x0")]
		public float deltaTime;

		[Token(Token = "0x4000C60")]
		[FieldOffset(Offset = "0x0")]
		public float symmetryBreakingBias;

		[Token(Token = "0x4000C61")]
		[FieldOffset(Offset = "0x0")]
		public float priorityMultiplier;

		[Token(Token = "0x4000C62")]
		[FieldOffset(Offset = "0x0")]
		public bool useNavmeshAsObstacle;

		[Token(Token = "0x4000C63")]
		private const int MaxObstacleCount = 50;

		[Token(Token = "0x4000C64")]
		[FieldOffset(Offset = "0x0")]
		private static readonly ProfilerMarker MarkerConvertObstacles1 = new ProfilerMarker("RVOConvertObstacles1");

		[Token(Token = "0x4000C65")]
		[FieldOffset(Offset = "0x0")]
		private static readonly ProfilerMarker MarkerConvertObstacles2 = new ProfilerMarker("RVOConvertObstacles2");

		[Token(Token = "0x1700027C")]
		public bool allowBoundsChecks
		{
			[Token(Token = "0x6001109")]
			get
			{ return true; }
		}

		[Token(Token = "0x600110A")]
		public void Execute(int startIndex, int batchSize)
		{
            ExecuteORCA(startIndex, batchSize);
        }

		[Token(Token = "0x600110B")]
		private static void InsertionSort<T, U>(UnsafeSpan<T> data, U comparer) where T : unmanaged where U : IComparer<T>
		{
            for (int i = 1; i < data.Length; i++)
            {
                T value = data[i];
                int j = i;
                while (j > 0 && comparer.Compare(data[j - 1], value) > 0)
                {
                    data[j] = data[j - 1];
                    j--;
                }
                data[j] = value;
            }
        }

		[Token(Token = "0x600110C")]
		private void GenerateObstacleVOs(int agentIndex, NativeList<int> adjacentObstacleIdsScratch, NativeArray<int2> adjacentObstacleVerticesScratch, NativeArray<float> segmentDistancesScratch, NativeArray<int> sortedVerticesScratch, NativeArray<ORCALine> orcaLines, NativeArray<int> orcaLineToAgent, [NoAlias] ref int numLines, [NoAlias] in MovementPlaneWrapper movementPlane, float2 optimalVelocity)
		{
            if (!useNavmeshAsObstacle) return;
            MovementPlaneWrapper plane = movementPlane;
            float2 position = plane.ToPlane(agentData.position[agentIndex], out float elevation);
            float radius = agentData.radius[agentIndex];
            float height = agentData.height[agentIndex];
            float obstacleHorizon = agentData.obstacleTimeHorizon[agentIndex];
            Unity.Burst.CompilerServices.Aliasing.ExpectNotAliased(agentData.collisionNormal, agentData.position);
            int hierarchicalNode = agentData.hierarchicalNodeIndex[agentIndex];
            if (hierarchicalNode == -1) return;
            float inverseHorizon = 1f / obstacleHorizon;
            float margin = radius * 0.01f;
            float reach = (radius + margin) + obstacleHorizon * agentData.maxSpeed[agentIndex];
            float diameter = reach + reach;
            float3 extents = new float3(diameter, height + height, diameter) * 0.5f;
            float candidateDistanceSq = math.lengthsq(extents);
            adjacentObstacleIdsScratch.Clear();
            Bounds localBounds = default;
            localBounds.center = new Vector3(position.x, elevation, position.y);
            localBounds.extents = extents;
            Bounds worldBounds = plane.ToWorld(localBounds);
            navmeshEdgeData.GetObstaclesInRange(hierarchicalNode, worldBounds, adjacentObstacleIdsScratch);
            float3 worldMin = worldBounds.min;
            float3 worldMax = worldBounds.max;
            float searchDistanceSq = diameter * (diameter * 0.25f);
            float marginOverHorizon = margin * inverseHorizon;
            float marginSq = margin * margin;
            for (int obstacleIndex = 0; obstacleIndex < adjacentObstacleIdsScratch.Length; obstacleIndex++)
            {
                UnmanagedObstacle obstacle = navmeshEdgeData.obstacleData.obstacles[adjacentObstacleIdsScratch[obstacleIndex]];
                UnsafeSpan<float3> vertices = navmeshEdgeData.obstacleData.obstacleVertices.GetSpan(obstacle.verticesAllocation);
                UnsafeSpan<ObstacleVertexGroup> groups = navmeshEdgeData.obstacleData.obstacleVertexGroups.GetSpan(obstacle.groupsAllocation);
                int vertexOffset = 0;
                int sortedCount = 0;
                for (int groupIndex = 0; groupIndex < groups.Length; groupIndex++)
                {
                    ObstacleVertexGroup group = groups[groupIndex];
                    int end = vertexOffset + group.vertexCount;
                    if (math.all((group.boundsMn <= worldMax) & (group.boundsMx >= worldMin)))
                    {
                        if (end - 1 >= adjacentObstacleVerticesScratch.Length) break;
                        for (int i = vertexOffset; i < end; i++) adjacentObstacleVerticesScratch[i] = new int2(i - 1, i + 1);
                        int2 first = adjacentObstacleVerticesScratch[vertexOffset];
                        first.x = group.type == ObstacleType.Loop ? end - 1 : vertexOffset;
                        adjacentObstacleVerticesScratch[vertexOffset] = first;
                        int2 last = adjacentObstacleVerticesScratch[end - 1];
                        last.y = group.type == ObstacleType.Loop ? vertexOffset : end - 1;
                        adjacentObstacleVerticesScratch[end - 1] = last;
                        for (int i = vertexOffset; i < end; i++)
                        {
                            float2 a = plane.ToPlane(vertices[i]) - position;
                            float2 b = plane.ToPlane(vertices[adjacentObstacleVerticesScratch[i].y]) - position;
                            float2 edge = b - a;
                            float t = ClosestPointOnSegment(a, edge / math.lengthsq(edge), float2.zero, 0f, 1f);
                            float distanceSq = math.lengthsq(a + edge * t);
                            segmentDistancesScratch[i] = distanceSq;
                            if (sortedCount < sortedVerticesScratch.Length && distanceSq <= candidateDistanceSq) sortedVerticesScratch[sortedCount++] = i;
                        }
                    }
                    vertexOffset = end;
                }
                InsertionSort(sortedVerticesScratch.AsUnsafeSpan().Slice(0, sortedCount), new SortByKey { keys = segmentDistancesScratch.AsUnsafeSpan().Slice(0, vertexOffset) });
                for (int candidateIndex = 0; candidateIndex < sortedCount; candidateIndex++)
                {
                    if (numLines > 49) break;
                    int vertex = sortedVerticesScratch[candidateIndex];
                    if (segmentDistancesScratch[vertex] > searchDistanceSq) break;
                    int previous = adjacentObstacleVerticesScratch[vertex].x;
                    int next = adjacentObstacleVerticesScratch[vertex].y;
                    if (next == vertex) continue;
                    int afterNext = adjacentObstacleVerticesScratch[next].y;
                    float2 previousPoint = plane.ToPlane(vertices[previous]);
                    float2 startPoint = plane.ToPlane(vertices[vertex], out float startElevation);
                    float2 endPoint = plane.ToPlane(vertices[next], out float endElevation);
                    float2 nextPoint = plane.ToPlane(vertices[afterNext]);
                    float upper = endElevation;
                    if (float.IsNaN(upper) || !(startElevation <= upper)) upper = startElevation;
                    if (height + upper < elevation) continue;
                    float lower = endElevation;
                    if (float.IsNaN(lower) || startElevation < lower) lower = startElevation;
                    if (lower > height + elevation) continue;
                    float2 a = startPoint - position;
                    float2 b = endPoint - position;
                    float2 previousRelative = previousPoint - position;
                    float2 nextRelative = nextPoint - position;
                    float2 edge = b - a;
                    float edgeLength = math.length(edge);
                    if (edgeLength < 0.0001f) continue;
                    float2 edgeDirection = edge * (1f / edgeLength);
                    if (!(det(edgeDirection, -a) <= margin)) continue;
                    bool covered = false;
                    for (int i = 0; i < numLines; i++)
                    {
                        ORCALine line = orcaLines[i];
                        if (det(a * inverseHorizon - line.point, line.direction) - marginOverHorizon >= -0.0001f && det(b * inverseHorizon - line.point, line.direction) - marginOverHorizon >= -0.0001f)
                        {
                            covered = true;
                            break;
                        }
                    }
                    if (covered) continue;
                    float projection = math.dot(edgeDirection, -a);
                    float clampedProjection = projection;
                    if (float.IsNaN(clampedProjection) || clampedProjection > edgeLength) clampedProjection = edgeLength;
                    if (float.IsNaN(clampedProjection) || clampedProjection < 0f) clampedProjection = 0f;
                    float2 projected = a + edgeDirection * projection;
                    float closestDistanceSq = math.lengthsq(a + edgeDirection * clampedProjection);
                    bool startConvex = leftOrColinear(a - previousRelative, edgeDirection);
                    bool endConvex = leftOrColinear(edgeDirection, nextRelative - b);
                    if (closestDistanceSq < marginSq)
                    {
                        if (projection >= 0f)
                        {
                            if (edgeLength < projection)
                            {
                                if (!endConvex || !leftOrColinear(b, nextRelative - b)) continue;
                                orcaLineToAgent[numLines] = -1;
                                orcaLines[numLines++] = new ORCALine { point = b * -0.1f, direction = math.normalizesafe(rot90(b)) };
                            }
                            else
                            {
                                orcaLineToAgent[numLines] = -1;
                                orcaLines[numLines++] = new ORCALine { point = projected * -0.1f, direction = -edgeDirection };
                            }
                        }
                        else if (startConvex)
                        {
                            orcaLineToAgent[numLines] = -1;
                            orcaLines[numLines++] = new ORCALine { point = a * -0.1f, direction = math.normalizesafe(rot90(a)) };
                        }
                        continue;
                    }
                    float2 leftLeg;
                    float2 rightLeg;
                    bool foreignLeft = false;
                    bool foreignRight = false;
                    if (math.lengthsq(projected) <= marginSq && (projection < 0f || projection > 1f))
                    {
                        if (projection >= 0f)
                        {
                            if (!endConvex) continue;
                            previousRelative = a;
                            a = b;
                        }
                        else
                        {
                            if (!startConvex) continue;
                            nextRelative = b;
                            b = a;
                        }
                        startConvex = true;
                        endConvex = true;
                        float lengthSq = math.lengthsq(b);
                        float leg = math.sqrt(lengthSq - marginSq);
                        leftLeg = new float2(b.x * leg - margin * b.y, margin * b.x + b.y * leg) / lengthSq;
                        rightLeg = new float2(b.x * leg + margin * b.y, b.y * leg - margin * b.x) / lengthSq;
                    }
                    else
                    {
                        if (startConvex)
                        {
                            float lengthSq = math.lengthsq(a);
                            float leg = math.sqrt(lengthSq - marginSq);
                            leftLeg = new float2(a.x * leg - margin * a.y, margin * a.x + a.y * leg) / lengthSq;
                        }
                        else leftLeg = -edgeDirection;
                        if (endConvex)
                        {
                            float lengthSq = math.lengthsq(b);
                            float leg = math.sqrt(lengthSq - marginSq);
                            rightLeg = new float2(margin * b.y + b.x * leg, b.y * leg - margin * b.x) / lengthSq;
                        }
                        else rightLeg = edgeDirection;
                    }
                    if (startConvex && left(leftLeg, previousRelative - a))
                    {
                        leftLeg = previousRelative - a;
                        foreignLeft = true;
                    }
                    if (endConvex && right(rightLeg, nextRelative - b))
                    {
                        rightLeg = nextRelative - b;
                        foreignRight = true;
                    }
                    float2 leftCutoff = a * inverseHorizon;
                    float2 rightCutoff = b * inverseHorizon;
                    float2 cutoffVector = rightCutoff - leftCutoff;
                    float cutoffLengthSq = math.lengthsq(cutoffVector);
                    float2 fromLeft = optimalVelocity - leftCutoff;
                    float t = cutoffLengthSq > 0.00001f ? math.dot(fromLeft, cutoffVector) / cutoffLengthSq : 0.5f;
                    float tLeft = math.dot(leftLeg, fromLeft);
                    float tRight = math.dot(optimalVelocity - rightCutoff, rightLeg);
                    if ((tLeft < 0f && t < 0f) || (tRight < 0f && ((cutoffLengthSq <= 0.00001f && tLeft < 0f) || t > 1f)))
                    {
                        float2 cutoff = t <= 0.5f ? leftCutoff : rightCutoff;
                        float2 normal = math.normalizesafe(optimalVelocity - cutoff);
                        orcaLineToAgent[numLines] = -1;
                        orcaLines[numLines++] = new ORCALine { point = cutoff + marginOverHorizon * normal, direction = new float2(normal.y, -normal.x) };
                        continue;
                    }
                    float cutoffDistanceSq = !(cutoffLengthSq < 0.0001f) && t <= 1f && t >= 0f ? math.lengthsq(optimalVelocity - (leftCutoff + cutoffVector * t)) : float.PositiveInfinity;
                    float leftDistanceSq = tLeft >= 0f ? math.lengthsq(optimalVelocity - (leftCutoff + leftLeg * tLeft)) : float.PositiveInfinity;
                    float rightDistanceSq = tRight >= 0f ? math.lengthsq(optimalVelocity - (rightCutoff + rightLeg * tRight)) : float.PositiveInfinity;
                    int selected = 0;
                    float distance = cutoffDistanceSq;
                    if (leftDistanceSq < cutoffDistanceSq) { selected = 1; distance = leftDistanceSq; }
                    if (rightDistanceSq < distance) selected = 2;
                    if (selected == 1)
                    {
                        if (!foreignLeft)
                        {
                            orcaLineToAgent[numLines] = -1;
                            orcaLines[numLines++] = new ORCALine { point = leftCutoff + marginOverHorizon * rot90(leftLeg), direction = leftLeg };
                        }
                    }
                    else if (selected == 2)
                    {
                        if (!foreignRight)
                        {
                            orcaLineToAgent[numLines] = -1;
                            orcaLines[numLines++] = new ORCALine { point = rightCutoff - marginOverHorizon * rot90(rightLeg), direction = -rightLeg };
                        }
                    }
                    else
                    {
                        orcaLineToAgent[numLines] = -1;
                        orcaLines[numLines++] = new ORCALine { point = leftCutoff - marginOverHorizon * rot90(edgeDirection), direction = -edgeDirection };
                    }
                }
            }
        }

		[Token(Token = "0x600110D")]
		public void ExecuteORCA(int startIndex, int batchSize)
		{
            var lines = new NativeArray<ORCALine>(100, Allocator.Temp, NativeArrayOptions.UninitializedMemory);
            var scratchLines = new NativeArray<ORCALine>(100, Allocator.Temp, NativeArrayOptions.UninitializedMemory);
            var segmentDistances = new NativeArray<float>(256, Allocator.Temp, NativeArrayOptions.UninitializedMemory);
            var sortedVertices = new NativeArray<int>(256, Allocator.Temp, NativeArrayOptions.UninitializedMemory);
            var adjacentVertices = new NativeArray<int2>(1024, Allocator.Temp, NativeArrayOptions.UninitializedMemory);
            var lineToAgent = new NativeArray<int>(100, Allocator.Temp, NativeArrayOptions.UninitializedMemory);
            var adjacentIds = new NativeList<int>(16, Allocator.Temp);
            MovementPlaneWrapper plane = default;
            for (int agent = startIndex; agent < startIndex + batchSize; agent++)
            {
                if (!agentData.version[agent].Valid) continue;
                if (agentData.manuallyControlled[agent])
                {
                    output.speed[agent] = agentData.desiredSpeed[agent];
                    output.targetPoint[agent] = agentData.targetPoint[agent];
                    output.blockedByAgents[agent * 7] = -1;
                    continue;
                }
                float3 position = agentData.position[agent];
                if (agentData.locked[agent])
                {
                    output.speed[agent] = 0f;
                    output.targetPoint[agent] = position;
                    output.blockedByAgents[agent * 7] = -1;
                    continue;
                }
                plane = default;
                plane.Set(agentData.movementPlane[agent]);
                float2 currentVelocity = plane.ToPlane(temporaryAgentData.currentVelocity[agent]);
                int numLines = 0;
                GenerateObstacleVOs(agent, adjacentIds, adjacentVertices, segmentDistances, sortedVertices, lines, lineToAgent, ref numLines, in plane, currentVelocity);
                int fixedLines = numLines;
                NativeSlice<int> neighbours = temporaryAgentData.neighbours.Slice(agent * 50, 50);
                float horizon = agentData.agentTimeHorizon[agent];
                float priority = agentData.priority[agent];
                float2 positionInPlane = plane.ToPlane(position);
                float radius = agentData.radius[agent];
                float3 endOfPath = agentData.endOfPath[agent];
                float distanceToEndSq = math.all(math.isfinite(endOfPath)) ? math.lengthsq(endOfPath - position) : float.PositiveInfinity;
                for (int i = 0; i < neighbours.Length; i++)
                {
                    int other = neighbours[i];
                    if (other == -1) break;
                    float2 relativePosition = plane.ToPlane(agentData.position[other] - position);
                    float combinedRadius = radius + agentData.radius[other];
                    float responsibility = 1f;
                    if (!agentData.locked[other] && !agentData.manuallyControlled[other])
                    {
                        float otherPriority = agentData.priority[other] * priorityMultiplier;
                        responsibility = 0.5f;
                        if (priority > 0.00001f || otherPriority > 0.00001f) responsibility = otherPriority / (priority + otherPriority);
                    }
                    float blend = responsibility + responsibility - 1f;
                    if (float.IsNaN(blend) || blend > 1f) blend = 1f;
                    if (float.IsNaN(blend) || blend < 0f) blend = 0f;
                    float3 otherCurrent = temporaryAgentData.currentVelocity[other];
                    float3 otherDesired = temporaryAgentData.desiredVelocity[other];
                    float2 otherVelocity = plane.ToPlane(otherCurrent + (otherDesired - otherCurrent) * blend);
                    float otherFlow = agentData.flowFollowingStrength[other];
                    if (otherFlow > 0f)
                    {
                        float2 direction = math.normalizesafe(relativePosition);
                        float toward = math.dot(direction, otherVelocity);
                        if (float.IsNaN(toward) || toward > 0f) toward = 0f;
                        float amount = toward * (otherFlow * agentData.flowFollowingStrength[agent]);
                        otherVelocity -= direction * amount;
                    }
                    float clearance = math.length(relativePosition) - combinedRadius;
                    if (float.IsNaN(clearance) || clearance < 0f) clearance = 0f;
                    if (clearance * clearance <= distanceToEndSq || !agentData.locked[other])
                    {
                        float speedSum = agentData.desiredSpeed[agent] + agentData.desiredSpeed[other];
                        if (float.IsNaN(speedSum) || combinedRadius > speedSum) speedSum = combinedRadius;
                        float time = clearance / speedSum;
                        float shrink = ((1f / horizon) * time - 0.5f) + ((1f / horizon) * time - 0.5f);
                        if (float.IsNaN(shrink) || shrink > 1f) shrink = 1f;
                        if (float.IsNaN(shrink) || shrink < 0f) shrink = 0f;
                        float horizonScale = math.sqrt(time + time);
                        if (float.IsNaN(horizonScale) || horizonScale > 1f) horizonScale = 1f;
                        if (float.IsNaN(horizonScale)) horizonScale = 0f;
                        float scaledHorizon = horizon * horizonScale;
                        if (float.IsNaN(scaledHorizon) || horizon * 0.1f > scaledHorizon) scaledHorizon = horizon * 0.1f;
                        lines[numLines] = new ORCALine(positionInPlane, relativePosition, currentVelocity, otherVelocity, combinedRadius * (1f - shrink), 0.1f, 1f / scaledHorizon);
                        lineToAgent[numLines++] = other;
                    }
                }
                float2 collisionNormal = math.normalizesafe(plane.ToPlane(agentData.collisionNormal[agent]));
                if (math.any(collisionNormal != float2.zero))
                {
                    lines[numLines] = new ORCALine { point = float2.zero, direction = new float2(collisionNormal.y, -collisionNormal.x) };
                    lineToAgent[numLines++] = -1;
                }
                float2 desiredVelocity = plane.ToPlane(temporaryAgentData.desiredVelocity[agent]);
                float2 targetInVelocitySpace = temporaryAgentData.desiredTargetPointInVelocitySpace[agent];
                UnsafeSpan<ORCALine> lineSpan = lines.AsUnsafeSpan();
                bool biased = BiasDesiredVelocity(lineSpan.Slice(fixedLines, numLines - fixedLines), ref desiredVelocity, ref targetInVelocitySpace, symmetryBreakingBias * (1f - agentData.flowFollowingStrength[agent]));
                float2 collisionOffset = temporaryAgentData.collisionVelocityOffsets[agent];
                if (!biased && !(DistanceInsideVOs(lineSpan.Slice(0, numLines), desiredVelocity) > 0f) && math.all(math.abs(collisionOffset) < 0.001f))
                {
                    output.targetPoint[agent] = position + plane.ToWorld(targetInVelocitySpace, 0f);
                    output.speed[agent] = agentData.desiredSpeed[agent];
                    output.blockedByAgents[agent * 7] = -1;
                    output.forwardClearance[agent] = float.PositiveInfinity;
                    continue;
                }
                float maxSpeed = agentData.maxSpeed[agent];
                float2 angles = agentData.allowedVelocityDeviationAngles[agent];
                LinearProgram2Output result;
                if (math.all(angles == float2.zero)) result = LinearProgram2D(lines, numLines, maxSpeed, desiredVelocity, false);
                else
                {
                    math.sincos(angles, out float2 sine, out float2 cosine);
                    float2 start0 = new float2(desiredVelocity.x * cosine.x - desiredVelocity.y * sine.x, cosine.x * desiredVelocity.y + desiredVelocity.x * sine.x);
                    float2 start1 = new float2(desiredVelocity.x * cosine.y - desiredVelocity.y * sine.y, cosine.y * desiredVelocity.y + desiredVelocity.x * sine.y);
                    float2 diff0 = desiredVelocity - start0;
                    float2 diff1 = desiredVelocity - start1;
                    float length0 = math.length(diff0);
                    float length1 = math.length(diff1);
                    float2 direction0 = length0 > 1.17549435e-38f ? diff0 * (1f / length0) : float2.zero;
                    float2 direction1 = length1 > 1.17549435e-38f ? diff1 * (1f / length1) : float2.zero;
                    LinearProgram2Output result0 = LinearProgram2DSegment(lines, numLines, maxSpeed, start0, direction0, 0f, length0, 1f);
                    LinearProgram2Output result1 = LinearProgram2DSegment(lines, numLines, maxSpeed, start1, direction1, 0f, length1, 1f);
                    result = result1;
                    if (result0.firstFailedLineIndex < result1.firstFailedLineIndex || (result0.firstFailedLineIndex == result1.firstFailedLineIndex && math.lengthsq(result0.velocity - desiredVelocity) < math.lengthsq(result1.velocity - desiredVelocity))) result = result0;
                }
                float2 velocity = result.velocity;
                if (result.firstFailedLineIndex < numLines) LinearProgram3D(lines, numLines, fixedLines, result.firstFailedLineIndex, maxSpeed, ref velocity, scratchLines);
                int blocked = 0;
                for (int i = 0; i < numLines && blocked < 7; i++)
                {
                    ORCALine line = lines[i];
                    if (lineToAgent[i] != -1 && det(line.direction, line.point - velocity) >= -0.001f) output.blockedByAgents[agent * 7 + blocked++] = lineToAgent[i];
                }
                if (blocked < 7) output.blockedByAgents[agent * 7 + blocked] = -1;
                if (math.any(collisionOffset != float2.zero)) velocity = LinearProgram2D(lines, fixedLines, maxSpeed, velocity + collisionOffset, false).velocity;
                output.targetPoint[agent] = position + plane.ToWorld(velocity, 0f);
                float speed = math.length(velocity);
                if (speed >= maxSpeed && !float.IsNaN(maxSpeed)) speed = maxSpeed;
                output.speed[agent] = speed;
                float2 targetDirection = math.normalizesafe(plane.ToPlane(agentData.targetPoint[agent] - position));
                output.forwardClearance[agent] = CalculateForwardClearance(neighbours, plane, position, radius, targetDirection);
            }
        }

		[Token(Token = "0x600110E")]
		private float CalculateForwardClearance(NativeSlice<int> neighbours, MovementPlaneWrapper movementPlane, float3 position, float radius, float2 targetDir)
		{
            float clearance = float.PositiveInfinity;
            for (int i = 0; i < neighbours.Length; i++)
            {
                int other = neighbours[i];
                if (other == -1) break;
                float otherRadius = agentData.radius[other];
                float2 relativePosition = movementPlane.ToPlane(agentData.position[other] - position);
                float lengthSq = math.lengthsq(relativePosition);
                float distance = math.sqrt(lengthSq);
                float alignment = math.dot(targetDir, math.normalizesafe(relativePosition));
                if (alignment < 0f) continue;
                float combinedRadius = otherRadius + radius;
                float along = distance * alignment;
                float discriminant = combinedRadius * combinedRadius - (lengthSq - along * along);
                if (discriminant < 0f) continue;
                float candidate = along - math.sqrt(discriminant);
                if (!float.IsNaN(candidate) && !(clearance < candidate)) clearance = candidate;
            }
            return clearance;
        }

		[Token(Token = "0x600110F")]
		private static bool leftOrColinear(float2 vector1, float2 vector2)
		{
            return det(vector1, vector2) >= 0f;
        }

		[Token(Token = "0x6001110")]
		private static bool left(float2 vector1, float2 vector2)
		{
            return det(vector1, vector2) > 0f;
        }

		[Token(Token = "0x6001111")]
		private static bool rightOrColinear(float2 vector1, float2 vector2)
		{
            return det(vector1, vector2) <= 0f;
        }

		[Token(Token = "0x6001112")]
		private static bool right(float2 vector1, float2 vector2)
		{
            return det(vector1, vector2) < 0f;
        }

		[Token(Token = "0x6001113")]
		private static float det(float2 vector1, float2 vector2)
		{
            return vector1.x * vector2.y - vector1.y * vector2.x;
        }

		[Token(Token = "0x6001114")]
		private static float2 rot90(float2 v)
		{
            return new float2(-v.y, v.x);
        }

		[Token(Token = "0x6001115")]
		private static float DistanceInsideVOs(UnsafeSpan<ORCALine> lines, float2 velocity)
		{
            float distance = 0f;
            for (int i = 0; i < lines.Length; i++)
            {
                ORCALine line = lines[i];
                float candidate = det(line.direction, line.point - velocity);
                if (!float.IsNaN(candidate) && !(distance > candidate)) distance = candidate;
            }
            return distance;
        }

		[Token(Token = "0x6001116")]
		private static bool BiasDesiredVelocity(UnsafeSpan<ORCALine> lines, ref float2 desiredVelocity, ref float2 targetPointInVelocitySpace, float maxBiasRadians)
		{
            float distance = DistanceInsideVOs(lines, desiredVelocity);
            if (distance == 0f) return false;
            float speed = math.length(desiredVelocity);
            if (!(speed < 0.001f))
            {
                float bias = distance / speed;
                if (float.IsNaN(bias) || bias > maxBiasRadians) bias = maxBiasRadians;
                float2 velocity = desiredVelocity;
                desiredVelocity = new float2(velocity.x + bias * velocity.y, velocity.y - bias * velocity.x);
                float2 target = targetPointInVelocitySpace;
                targetPointInVelocitySpace = new float2(target.x + bias * target.y, target.y - bias * target.x);
            }
            return true;
        }

		[Token(Token = "0x6001117")]
		private static bool ClipLine(ORCALine line, ORCALine clipper, ref float tLeft, ref float tRight)
		{
            float denominator = det(line.direction, clipper.direction);
            float absoluteDenominator = math.abs(denominator);
            if (!(absoluteDenominator < 0.0001f))
            {
                float t = det(clipper.direction, line.point - clipper.point) / denominator;
                if (denominator >= 0f)
                {
                    if (!float.IsNaN(t) && !(tRight < t)) tRight = t;
                }
                else
                {
                    if (!float.IsNaN(t) && !(tLeft > t)) tLeft = t;
                }
            }
            return !(absoluteDenominator < 0.0001f);
        }

		[Token(Token = "0x6001118")]
		private static bool ClipBoundary(NativeArray<ORCALine> lines, int lineIndex, float radius, out float tLeft, out float tRight)
		{
            ORCALine line = lines[lineIndex];
            if (!VectorMath.LineCircleIntersectionFactors(line.point, line.direction, radius, out tLeft, out tRight)) return false;
            for (int i = 0; i < lineIndex; i++)
            {
                ORCALine clipper = lines[i];
                float denominator = det(line.direction, clipper.direction);
                float numerator = det(clipper.direction, line.point - clipper.point);
                if (math.abs(denominator) < 0.0001f)
                {
                    if (numerator < 0f) return false;
                    continue;
                }
                float t = numerator / denominator;
                if (denominator >= 0f)
                {
                    if (!float.IsNaN(t) && !(tRight < t)) tRight = t;
                }
                else
                {
                    if (!float.IsNaN(t) && !(tLeft > t)) tLeft = t;
                }
                if (tLeft > tRight) return false;
            }
            return true;
        }

		[Token(Token = "0x6001119")]
		private static bool LinearProgram1D(NativeArray<ORCALine> lines, int lineIndex, float radius, float2 optimalVelocity, bool directionOpt, ref float2 result)
		{
            if (!ClipBoundary(lines, lineIndex, radius, out float tLeft, out float tRight)) return false;
            ORCALine line = lines[lineIndex];
            float t;
            if (directionOpt) t = math.dot(optimalVelocity, line.direction) <= 0f ? tLeft : tRight;
            else
            {
                t = math.dot(optimalVelocity - line.point, line.direction);
                if (float.IsNaN(t) || tRight < t) t = tRight;
                if (float.IsNaN(t) || t < tLeft) t = tLeft;
            }
            result = line.point + line.direction * t;
            return true;
        }

		[Token(Token = "0x600111A")]
		private static LinearProgram2Output LinearProgram2D(NativeArray<ORCALine> lines, int numLines, float radius, float2 optimalVelocity, bool directionOpt)
		{
            float2 velocity;
            if (directionOpt) velocity = optimalVelocity * radius;
            else
            {
                float lengthSq = math.lengthsq(optimalVelocity);
                velocity = lengthSq > radius * radius ? (optimalVelocity * (1f / math.sqrt(lengthSq))) * radius : optimalVelocity;
            }
            for (int i = 0; i < numLines; i++)
            {
                ORCALine line = lines[i];
                if (det(line.direction, line.point - velocity) > 0f)
                {
                    float2 previous = velocity;
                    if (!LinearProgram1D(lines, i, radius, optimalVelocity, directionOpt, ref velocity))
                        return new LinearProgram2Output { velocity = previous, firstFailedLineIndex = i };
                }
            }
            return new LinearProgram2Output { velocity = velocity, firstFailedLineIndex = numLines };
        }

		[Token(Token = "0x600111B")]
		private static float ClosestPointOnSegment(float2 a, float2 dir, float2 p, float t0, float t1)
		{
            float t = math.dot(dir, p - a);
            if (float.IsNaN(t) || t > t1) t = t1;
            if (float.IsNaN(t) || t < t0) t = t0;
            return t;
        }

		[Token(Token = "0x600111C")]
		private static float2 ClosestSegmentSegmentPointNonIntersecting(ORCALine a, ORCALine b, float ta1, float ta2, float tb1, float tb2)
		{
            float2 bStart = b.point + b.direction * tb1;
            float2 bEnd = b.point + b.direction * tb2;
            float tA0 = ClosestPointOnSegment(a.point, a.direction, bStart, ta1, ta2);
            float tA1 = ClosestPointOnSegment(a.point, a.direction, bEnd, ta1, ta2);
            float2 aStart = a.point + a.direction * ta1;
            float2 aEnd = a.point + a.direction * ta2;
            float tB0 = ClosestPointOnSegment(b.point, b.direction, aStart, tb1, tb2);
            float tB1 = ClosestPointOnSegment(b.point, b.direction, aEnd, tb1, tb2);
            float2 result = a.point + a.direction * tA0;
            float distance = math.lengthsq(result - bStart);
            float2 candidate = a.point + a.direction * tA1;
            float candidateDistance = math.lengthsq(candidate - bEnd);
            if (candidateDistance < distance) { result = candidate; distance = candidateDistance; }
            candidateDistance = math.lengthsq((b.point + b.direction * tB0) - aStart);
            if (candidateDistance < distance) { result = aStart; distance = candidateDistance; }
            candidateDistance = math.lengthsq((b.point + b.direction * tB1) - aEnd);
            if (candidateDistance < distance) result = aEnd;
            return result;
        }

		[Token(Token = "0x600111D")]
		private static LinearProgram2Output LinearProgram2DCollapsedSegment(NativeArray<ORCALine> lines, int numLines, int startLine, float radius, float2 currentResult, float2 optimalVelocityStart, float2 optimalVelocityDir, float optimalTLeft, float optimalTRight)
		{
            float2 velocity = currentResult;
            for (int i = startLine; i < numLines; i++)
            {
                ORCALine line = lines[i];
                if (det(line.direction, line.point - velocity) <= 0f) continue;
                if (!ClipBoundary(lines, i, radius, out float tLeft, out float tRight))
                    return new LinearProgram2Output { velocity = velocity, firstFailedLineIndex = i };
                ORCALine optimal = new ORCALine { point = optimalVelocityStart, direction = optimalVelocityDir };
                velocity = ClosestSegmentSegmentPointNonIntersecting(line, optimal, tLeft, tRight, optimalTLeft, optimalTRight);
            }
            return new LinearProgram2Output { velocity = velocity, firstFailedLineIndex = numLines };
        }

		[Token(Token = "0x600111E")]
		private static LinearProgram2Output LinearProgram2DSegment(NativeArray<ORCALine> lines, int numLines, float radius, float2 optimalVelocityStart, float2 optimalVelocityDir, float optimalTLeft, float optimalTRight, float optimalT)
		{
            bool intersectsCircle = VectorMath.LineCircleIntersectionFactors(optimalVelocityStart, optimalVelocityDir, radius, out float circleLeft, out float circleRight);
            float tLeft = circleLeft > optimalTLeft || float.IsNaN(optimalTLeft) ? circleLeft : optimalTLeft;
            float tRight = circleRight < optimalTRight || float.IsNaN(optimalTRight) ? circleRight : optimalTRight;
            if (!intersectsCircle || tLeft > tRight)
            {
                float t = optimalVelocityDir.y * -optimalVelocityStart.y - optimalVelocityStart.x * optimalVelocityDir.x;
                if (float.IsNaN(t) || t > optimalTRight) t = optimalTRight;
                if (float.IsNaN(t) || t < optimalTLeft) t = optimalTLeft;
                float2 velocity = math.normalizesafe(optimalVelocityStart + optimalVelocityDir * t) * radius;
                return LinearProgram2DCollapsedSegment(lines, numLines, 0, radius, velocity, optimalVelocityStart, optimalVelocityDir, optimalTLeft, optimalTRight);
            }
            float2 start = optimalVelocityStart;
            float2 direction = optimalVelocityDir;
            int failed = numLines;
            for (int i = 0; i < numLines; i++)
            {
                ORCALine line = lines[i];
                float leftViolation = det(line.direction, line.point - (start + direction * tLeft));
                float rightViolation = det(line.direction, line.point - (start + direction * tRight));
                if (leftViolation <= 0f && rightViolation <= 0f) continue;
                if (!ClipBoundary(lines, i, radius, out float boundaryLeft, out float boundaryRight))
                {
                    failed = i;
                    break;
                }
                if (leftViolation <= 0f || rightViolation <= 0f)
                {
                    ORCALine optimalLine = new ORCALine { point = start, direction = direction };
                    ClipLine(optimalLine, line, ref tLeft, ref tRight);
                }
                else
                {
                    float denominator = det(line.direction, direction);
                    ORCALine optimalLine = new ORCALine { point = start, direction = direction };
                    if (math.abs(denominator) >= 0.001f)
                    {
                        float2 velocity = ClosestSegmentSegmentPointNonIntersecting(line, optimalLine, boundaryLeft, boundaryRight, optimalTLeft, optimalTRight);
                        return LinearProgram2DCollapsedSegment(lines, numLines, i + 1, radius, velocity, start, direction, optimalTLeft, optimalTRight);
                    }
                    float newLeft = ClosestPointOnSegment(line.point, line.direction, start + direction * tLeft, boundaryLeft, boundaryRight);
                    float newRight = ClosestPointOnSegment(line.point, line.direction, start + direction * tRight, boundaryLeft, boundaryRight);
                    optimalT = ClosestPointOnSegment(line.point, line.direction, start + direction * optimalT, boundaryLeft, boundaryRight);
                    start = line.point;
                    direction = line.direction;
                    tLeft = newLeft;
                    tRight = newRight;
                }
            }
            float selected = tRight;
            if (tRight >= optimalT && !float.IsNaN(optimalT)) selected = optimalT;
            if (float.IsNaN(selected) || selected < tLeft) selected = tLeft;
            return new LinearProgram2Output { velocity = start + direction * selected, firstFailedLineIndex = failed };
        }

		[Token(Token = "0x600111F")]
		private static void LinearProgram3D(NativeArray<ORCALine> lines, int numLines, int numFixedLines, int beginLine, float radius, ref float2 result, NativeArray<ORCALine> scratchBuffer)
		{
            NativeArray<ORCALine>.Copy(lines, scratchBuffer, numFixedLines);
            float distance = 0f;
            for (int i = beginLine; i < numLines; i++)
            {
                ORCALine line = lines[i];
                if (det(line.direction, line.point - result) <= distance) continue;
                int projectedCount = numFixedLines;
                for (int j = numFixedLines; j < i; j++)
                {
                    ORCALine previous = lines[j];
                    float denominator = det(line.direction, previous.direction);
                    float2 point;
                    if (math.abs(denominator) < 0.001f)
                    {
                        if (math.dot(line.direction, previous.direction) > 0f) continue;
                        point = (line.point + previous.point) * 0.5f;
                    }
                    else point = line.point + line.direction * (det(previous.direction, line.point - previous.point) / denominator);
                    float2 direction = math.normalize(previous.direction - line.direction);
                    scratchBuffer[projectedCount++] = new ORCALine { point = point, direction = direction };
                }
                LinearProgram2Output projected = LinearProgram2D(scratchBuffer, projectedCount, radius, new float2(-line.direction.y, line.direction.x), true);
                if (projected.firstFailedLineIndex >= projectedCount) result = projected.velocity;
                distance = det(line.direction, line.point - result);
            }
        }

		[Token(Token = "0x6001120")]
		private static void DrawVO(CommandBuilder draw, float2 circleCenter, float radius, float2 origin, Color color)
		{
		}
	}
}
