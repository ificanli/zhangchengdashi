using Il2CppDummyDll;
using Pathfinding.Drawing;
using Pathfinding.ECS.RVO;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;

namespace Pathfinding.RVO
{
	[Token(Token = "0x20002D2")]
	public struct RVOQuadtreeBurst
	{
		[Token(Token = "0x20002D3")]
		[BurstCompile(CompileSynchronously = true, FloatMode = FloatMode.Fast)]
		public struct JobBuild : IJob
		{
			[Token(Token = "0x4000D00")]
			[FieldOffset(Offset = "0x0")]
			public NativeArray<int> agents;

			[Token(Token = "0x4000D01")]
			[FieldOffset(Offset = "0x10")]
			[ReadOnly]
			public NativeArray<float3> agentPositions;

			[Token(Token = "0x4000D02")]
			[FieldOffset(Offset = "0x20")]
			[ReadOnly]
			public NativeArray<AgentIndex> agentVersions;

			[Token(Token = "0x4000D03")]
			[FieldOffset(Offset = "0x30")]
			[ReadOnly]
			public NativeArray<float> agentSpeeds;

			[Token(Token = "0x4000D04")]
			[FieldOffset(Offset = "0x40")]
			[ReadOnly]
			public NativeArray<float> agentRadii;

			[Token(Token = "0x4000D05")]
			[FieldOffset(Offset = "0x50")]
			[WriteOnly]
			public NativeArray<float3> outBoundingBox;

			[Token(Token = "0x4000D06")]
			[FieldOffset(Offset = "0x60")]
			[WriteOnly]
			public NativeArray<int> outAgentCount;

			[Token(Token = "0x4000D07")]
			[FieldOffset(Offset = "0x70")]
			public NativeArray<int> outChildPointers;

			[Token(Token = "0x4000D08")]
			[FieldOffset(Offset = "0x80")]
			public NativeArray<float> outMaxSpeeds;

			[Token(Token = "0x4000D09")]
			[FieldOffset(Offset = "0x90")]
			public NativeArray<float> outMaxRadius;

			[Token(Token = "0x4000D0A")]
			[FieldOffset(Offset = "0xA0")]
			public NativeArray<float> outArea;

			[Token(Token = "0x4000D0B")]
			[FieldOffset(Offset = "0xB0")]
			[WriteOnly]
			public NativeArray<float3> outAgentPositions;

			[Token(Token = "0x4000D0C")]
			[FieldOffset(Offset = "0xC0")]
			[WriteOnly]
			public NativeArray<float> outAgentRadii;

			[Token(Token = "0x4000D0D")]
			[FieldOffset(Offset = "0xD0")]
			public int numAgents;

			[Token(Token = "0x4000D0E")]
			[FieldOffset(Offset = "0xD4")]
			public MovementPlane movementPlane;

			[Token(Token = "0x60011D4")]
			[Address(RVA = "0x44A3BD0", Offset = "0x449FBD0", VA = "0x44A3BD0")]
			private static int Partition(NativeSlice<int> indices, int startIndex, int endIndex, NativeSlice<float> coordinates, float splitPoint)
			{
                while (startIndex < endIndex)
                {
                    if (coordinates[indices[startIndex]] <= splitPoint) startIndex++;
                    else
                    {
                        endIndex--;
                        int temporary = indices[startIndex];
                        indices[startIndex] = indices[endIndex];
                        indices[endIndex] = temporary;
                    }
                }
                return endIndex;
            }

			[Token(Token = "0x60011D5")]
			[Address(RVA = "0x44A3CFC", Offset = "0x449FCFC", VA = "0x44A3CFC")]
			private void BuildNode(float3 boundsMin, float3 boundsMax, int depth, int agentsStart, int agentsEnd, int nodeOffset, ref int firstFreeChild)
			{
                if (depth > 9 || agentsEnd - agentsStart < 17)
                {
                    outChildPointers[nodeOffset] = agentsStart | (agentsEnd << 15) | LeafNodeBit;
                    return;
                }
                NativeSlice<int> indices = new NativeSlice<int>(agents);
                NativeSlice<float> xs = new NativeSlice<float3>(agentPositions).SliceWithStride<float>(0);
                float middleX = (boundsMin.x + boundsMax.x) * 0.5f;
                if (movementPlane == MovementPlane.Arbitrary)
                {
                    NativeSlice<float> ys = new NativeSlice<float3>(agentPositions).SliceWithStride<float>(4);
                    NativeSlice<float> zs = new NativeSlice<float3>(agentPositions).SliceWithStride<float>(8);
                    float middleY = (boundsMin.y + boundsMax.y) * 0.5f;
                    float middleZ = (boundsMin.z + boundsMax.z) * 0.5f;
                    int splitX = Partition(indices, agentsStart, agentsEnd, xs, middleX);
                    int splitY0 = Partition(indices, agentsStart, splitX, ys, middleY);
                    int splitY1 = Partition(indices, splitX, agentsEnd, ys, middleY);
                    int splitZ0 = Partition(indices, agentsStart, splitY0, zs, middleZ);
                    int splitZ1 = Partition(indices, splitY0, splitX, zs, middleZ);
                    int splitZ2 = Partition(indices, splitX, splitY1, zs, middleZ);
                    int splitZ3 = Partition(indices, splitY1, agentsEnd, zs, middleZ);
                    int children = firstFreeChild;
                    outChildPointers[nodeOffset] = children;
                    firstFreeChild += 8;
                    BuildNode(new float3(boundsMin.x, boundsMin.y, boundsMin.z), new float3(middleX, middleY, middleZ), depth + 1, agentsStart, splitZ0, children + 0, ref firstFreeChild);
                    BuildNode(new float3(boundsMin.x, boundsMin.y, middleZ), new float3(middleX, middleY, boundsMax.z), depth + 1, splitZ0, splitY0, children + 1, ref firstFreeChild);
                    BuildNode(new float3(boundsMin.x, middleY, boundsMin.z), new float3(middleX, boundsMax.y, middleZ), depth + 1, splitY0, splitZ1, children + 2, ref firstFreeChild);
                    BuildNode(new float3(boundsMin.x, middleY, middleZ), new float3(middleX, boundsMax.y, boundsMax.z), depth + 1, splitZ1, splitX, children + 3, ref firstFreeChild);
                    BuildNode(new float3(middleX, boundsMin.y, boundsMin.z), new float3(boundsMax.x, middleY, middleZ), depth + 1, splitX, splitZ2, children + 4, ref firstFreeChild);
                    BuildNode(new float3(middleX, boundsMin.y, middleZ), new float3(boundsMax.x, middleY, boundsMax.z), depth + 1, splitZ2, splitY1, children + 5, ref firstFreeChild);
                    BuildNode(new float3(middleX, middleY, boundsMin.z), new float3(boundsMax.x, boundsMax.y, middleZ), depth + 1, splitY1, splitZ3, children + 6, ref firstFreeChild);
                    BuildNode(new float3(middleX, middleY, middleZ), new float3(boundsMax.x, boundsMax.y, boundsMax.z), depth + 1, splitZ3, agentsEnd, children + 7, ref firstFreeChild);
                }
                else if (movementPlane == MovementPlane.XY)
                {
                    NativeSlice<float> ys = new NativeSlice<float3>(agentPositions).SliceWithStride<float>(4);
                    float middleY = (boundsMin.y + boundsMax.y) * 0.5f;
                    int splitX = Partition(indices, agentsStart, agentsEnd, xs, middleX);
                    int splitY0 = Partition(indices, agentsStart, splitX, ys, middleY);
                    int splitY1 = Partition(indices, splitX, agentsEnd, ys, middleY);
                    int children = firstFreeChild;
                    outChildPointers[nodeOffset] = children;
                    firstFreeChild += 4;
                    BuildNode(new float3(boundsMin.x, boundsMin.y, boundsMin.z), new float3(middleX, middleY, boundsMax.z), depth + 1, agentsStart, splitY0, children + 0, ref firstFreeChild);
                    BuildNode(new float3(boundsMin.x, middleY, boundsMin.z), new float3(middleX, boundsMax.y, boundsMax.z), depth + 1, splitY0, splitX, children + 1, ref firstFreeChild);
                    BuildNode(new float3(middleX, boundsMin.y, boundsMin.z), new float3(boundsMax.x, middleY, boundsMax.z), depth + 1, splitX, splitY1, children + 2, ref firstFreeChild);
                    BuildNode(new float3(middleX, middleY, boundsMin.z), new float3(boundsMax.x, boundsMax.y, boundsMax.z), depth + 1, splitY1, agentsEnd, children + 3, ref firstFreeChild);
                }
                else
                {
                    NativeSlice<float> zs = new NativeSlice<float3>(agentPositions).SliceWithStride<float>(8);
                    float middleZ = (boundsMin.z + boundsMax.z) * 0.5f;
                    int splitX = Partition(indices, agentsStart, agentsEnd, xs, middleX);
                    int splitZ0 = Partition(indices, agentsStart, splitX, zs, middleZ);
                    int splitZ1 = Partition(indices, splitX, agentsEnd, zs, middleZ);
                    int children = firstFreeChild;
                    outChildPointers[nodeOffset] = children;
                    firstFreeChild += 4;
                    BuildNode(new float3(boundsMin.x, boundsMin.y, boundsMin.z), new float3(middleX, boundsMax.y, middleZ), depth + 1, agentsStart, splitZ0, children + 0, ref firstFreeChild);
                    BuildNode(new float3(boundsMin.x, boundsMin.y, middleZ), new float3(middleX, boundsMax.y, boundsMax.z), depth + 1, splitZ0, splitX, children + 1, ref firstFreeChild);
                    BuildNode(new float3(middleX, boundsMin.y, boundsMin.z), new float3(boundsMax.x, boundsMax.y, middleZ), depth + 1, splitX, splitZ1, children + 2, ref firstFreeChild);
                    BuildNode(new float3(middleX, boundsMin.y, middleZ), new float3(boundsMax.x, boundsMax.y, boundsMax.z), depth + 1, splitZ1, agentsEnd, children + 3, ref firstFreeChild);
                }
            }

			[Token(Token = "0x60011D6")]
			[Address(RVA = "0x44A45C4", Offset = "0x44A05C4", VA = "0x44A45C4")]
			private void CalculateSpeeds(int nodeCount)
			{
                for (int node = nodeCount - 1; node >= 0; node--)
                {
                    int children = outChildPointers[node];
                    if ((children & LeafNodeBit) != 0)
                    {
                        int start = children & BitPackingMask;
                        int end = (children >> BitPackingShift) & BitPackingMask;
                        float maxSpeed = 0f;
                        for (int i = start; i < end; i++)
                        {
                            float speed = agentSpeeds[agents[i]];
                            if (!float.IsNaN(speed) && !(maxSpeed > speed)) maxSpeed = speed;
                        }
                        outMaxSpeeds[node] = maxSpeed;
                        float maxRadius = 0f;
                        for (int i = start; i < end; i++)
                        {
                            float radius = agentRadii[agents[i]];
                            if (!float.IsNaN(radius) && !(maxRadius > radius)) maxRadius = radius;
                        }
                        outMaxRadius[node] = maxRadius;
                        float area = 0f;
                        for (int i = start; i < end; i++)
                        {
                            float radius = agentRadii[agents[i]];
                            area += radius * radius;
                        }
                        outArea[node] = area;
                    }
                    else if (movementPlane == MovementPlane.Arbitrary)
                    {
                        float maxSpeed = 0f;
                        float maxRadius = 0f;
                        float area = 0f;
                        for (int i = 0; i < 8; i++)
                        {
                            float speed = outMaxSpeeds[children + i];
                            if (!float.IsNaN(speed) && !(maxSpeed > speed)) maxSpeed = speed;
                            if (!float.IsNaN(speed) && !(maxRadius > speed)) maxRadius = speed;
                            area += outArea[children + i];
                        }
                        outMaxSpeeds[node] = maxSpeed;
                        outMaxRadius[node] = maxRadius;
                        outArea[node] = area;
                    }
                    else
                    {
                        float a = outMaxSpeeds[children], b = outMaxSpeeds[children + 1];
                        float c = outMaxSpeeds[children + 2], d = outMaxSpeeds[children + 3];
                        float first = float.IsNaN(b) || a > b ? a : b;
                        float second = float.IsNaN(d) || c > d ? c : d;
                        outMaxSpeeds[node] = float.IsNaN(second) || first > second ? first : second;
                        a = outMaxRadius[children]; b = outMaxRadius[children + 1];
                        c = outMaxRadius[children + 2]; d = outMaxRadius[children + 3];
                        first = float.IsNaN(b) || a > b ? a : b;
                        second = float.IsNaN(d) || c > d ? c : d;
                        outMaxRadius[node] = float.IsNaN(second) || first > second ? first : second;
                        outArea[node] = ((outArea[children] + outArea[children + 1]) + outArea[children + 2]) + outArea[children + 3];
                    }
                }
            }

			[Token(Token = "0x60011D7")]
			[Address(RVA = "0x44A483C", Offset = "0x44A083C", VA = "0x44A483C", Slot = "4")]
			public void Execute()
			{
            if (numAgents > 0)
            {
                float3 minimum = new float3(float.PositiveInfinity);
                float3 maximum = new float3(float.NegativeInfinity);
                int count = 0;
                for (int i = 0; i < numAgents; i++)
                {
                    if (!agentVersions[i].Valid) continue;
                    agents[count++] = i;
                    float3 p = agentPositions[i];
                    if (!float.IsNaN(p.x) && minimum.x >= p.x) minimum.x = p.x;
                    if (!float.IsNaN(p.y) && minimum.y >= p.y) minimum.y = p.y;
                    if (!float.IsNaN(p.z) && minimum.z >= p.z) minimum.z = p.z;
                    if (!float.IsNaN(p.x) && maximum.x <= p.x) maximum.x = p.x;
                    if (!float.IsNaN(p.y) && maximum.y <= p.y) maximum.y = p.y;
                    if (!float.IsNaN(p.z) && maximum.z <= p.z) maximum.z = p.z;
                }
                outAgentCount[0] = count;
                if (count != 0)
                {
                    outBoundingBox[0] = minimum;
                    outBoundingBox[1] = maximum;
                    int firstFreeChild = 1;
                    BuildNode(minimum, maximum, 0, 0, count, 0, ref firstFreeChild);
                    CalculateSpeeds(firstFreeChild);
                    NativeArray<float3>.Copy(agentPositions, outAgentPositions, numAgents);
                    NativeArray<float>.Copy(agentRadii, outAgentRadii, numAgents);
                    return;
                }
            }
            else outAgentCount[0] = 0;
            outBoundingBox[1] = float3.zero;
            outBoundingBox[0] = float3.zero;
        }
		}

		[Token(Token = "0x20002D4")]
		public struct QuadtreeQuery
		{
			[Token(Token = "0x4000D0F")]
			[FieldOffset(Offset = "0x0")]
			public float3 position;

			[Token(Token = "0x4000D10")]
			[FieldOffset(Offset = "0xC")]
			public float speed;

			[Token(Token = "0x4000D11")]
			[FieldOffset(Offset = "0x10")]
			public float timeHorizon;

			[Token(Token = "0x4000D12")]
			[FieldOffset(Offset = "0x14")]
			public float agentRadius;

			[Token(Token = "0x4000D13")]
			[FieldOffset(Offset = "0x18")]
			public int outputStartIndex;

			[Token(Token = "0x4000D14")]
			[FieldOffset(Offset = "0x1C")]
			public int maxCount;

			[Token(Token = "0x4000D15")]
			[FieldOffset(Offset = "0x20")]
			public RVOLayer layerMask;

			[Token(Token = "0x4000D16")]
			[FieldOffset(Offset = "0x28")]
			public NativeArray<RVOLayer> layers;

			[Token(Token = "0x4000D17")]
			[FieldOffset(Offset = "0x38")]
			public NativeArray<int> result;

			[Token(Token = "0x4000D18")]
			[FieldOffset(Offset = "0x48")]
			public NativeArray<float> resultDistances;
		}

		[Token(Token = "0x20002D5")]
		[BurstCompile]
		public struct DebugDrawJob : IJob
		{
			[Token(Token = "0x4000D19")]
			[FieldOffset(Offset = "0x0")]
			public CommandBuilder draw;

			[Token(Token = "0x4000D1A")]
			[FieldOffset(Offset = "0x18")]
			[ReadOnly]
			public RVOQuadtreeBurst quadtree;

			[Token(Token = "0x60011D8")]
			[Address(RVA = "0x44A4AE4", Offset = "0x44A0AE4", VA = "0x44A4AE4", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Token(Token = "0x4000CEE")]
		private const int LeafSize = 16;

		[Token(Token = "0x4000CEF")]
		private const int MaxDepth = 10;

		[Token(Token = "0x4000CF0")]
		[FieldOffset(Offset = "0x0")]
		private NativeArray<int> agents;

		[Token(Token = "0x4000CF1")]
		[FieldOffset(Offset = "0x10")]
		private NativeArray<int> childPointers;

		[Token(Token = "0x4000CF2")]
		[FieldOffset(Offset = "0x20")]
		private NativeArray<float3> boundingBoxBuffer;

		[Token(Token = "0x4000CF3")]
		[FieldOffset(Offset = "0x30")]
		private NativeArray<int> agentCountBuffer;

		[Token(Token = "0x4000CF4")]
		[FieldOffset(Offset = "0x40")]
		private NativeArray<float3> agentPositions;

		[Token(Token = "0x4000CF5")]
		[FieldOffset(Offset = "0x50")]
		private NativeArray<float> agentRadii;

		[Token(Token = "0x4000CF6")]
		[FieldOffset(Offset = "0x60")]
		private NativeArray<float> maxSpeeds;

		[Token(Token = "0x4000CF7")]
		[FieldOffset(Offset = "0x70")]
		private NativeArray<float> maxRadius;

		[Token(Token = "0x4000CF8")]
		[FieldOffset(Offset = "0x80")]
		private NativeArray<float> nodeAreas;

		[Token(Token = "0x4000CF9")]
		[FieldOffset(Offset = "0x90")]
		private MovementPlane movementPlane;

		[Token(Token = "0x4000CFA")]
		private const int LeafNodeBit = 1073741824;

		[Token(Token = "0x4000CFB")]
		private const int BitPackingShift = 15;

		[Token(Token = "0x4000CFC")]
		private const int BitPackingMask = 32767;

		[Token(Token = "0x4000CFD")]
		private const int MaxAgents = 32767;

		[Token(Token = "0x4000CFE")]
		[FieldOffset(Offset = "0x0")]
		private static readonly byte[] ChildLookup;

		[Token(Token = "0x4000CFF")]
		private const float DistanceInfinity = 1E+30f;

		[Token(Token = "0x170002B5")]
		public Rect bounds
		{
			[Token(Token = "0x60011C9")]
			[Address(RVA = "0x44A18E0", Offset = "0x449D8E0", VA = "0x44A18E0")]
			get
			{
            if (!boundingBoxBuffer.IsCreated) return new Rect(0f, 0f, 0f, 0f);
            float3 minimum = boundingBoxBuffer[0];
            float3 maximum = boundingBoxBuffer[1];
            return new Rect(minimum.x, minimum.y, maximum.x - minimum.x, maximum.y - minimum.y);
        }
		}

		[Token(Token = "0x60011C8")]
		[Address(RVA = "0x44A1820", Offset = "0x449D820", VA = "0x44A1820")]
		static RVOQuadtreeBurst()
		{
            ChildLookup = new byte[256];
            for (int mask = 0; mask < 256; mask++)
            {
                for (int bit = 0; bit < 8; bit++)
                {
                    if (((mask >> bit) & 1) != 0)
                    {
                        ChildLookup[mask] = (byte)bit;
                        break;
                    }
                }
            }
        }

		[Token(Token = "0x60011CA")]
		[Address(RVA = "0x44A1944", Offset = "0x449D944", VA = "0x44A1944")]
		private static int InnerNodeCountUpperBound(int numAgents, MovementPlane movementPlane)
		{
            return unchecked(numAgents * (movementPlane == MovementPlane.Arbitrary ? 80 : 40) + 15) / 16;
        }

		[Token(Token = "0x60011CB")]
		[Address(RVA = "0x44A1970", Offset = "0x449D970", VA = "0x44A1970")]
		public void Dispose()
		{
            agents.Dispose();
            childPointers.Dispose();
            boundingBoxBuffer.Dispose();
            agentCountBuffer.Dispose();
            maxSpeeds.Dispose();
            maxRadius.Dispose();
            nodeAreas.Dispose();
            agentPositions.Dispose();
            agentRadii.Dispose();
        }

		[Token(Token = "0x60011CC")]
		[Address(RVA = "0x44A1A48", Offset = "0x449DA48", VA = "0x44A1A48")]
		private void Reserve(int minSize)
		{
            if (!boundingBoxBuffer.IsCreated)
            {
                boundingBoxBuffer = new NativeArray<float3>(4, Allocator.Persistent, NativeArrayOptions.ClearMemory);
                agentCountBuffer = new NativeArray<int>(1, Allocator.Persistent, NativeArrayOptions.ClearMemory);
            }
            int size = unchecked(minSize - 1);
            size |= size >> 1;
            size |= size >> 2;
            size |= size >> 4;
            size |= size >> 8;
            size |= size >> 16;
            size = unchecked(size + 1);
            Pathfinding.Util.Memory.Realloc(ref agents, size, Allocator.Persistent, NativeArrayOptions.ClearMemory);
            Pathfinding.Util.Memory.Realloc(ref agentPositions, size, Allocator.Persistent, NativeArrayOptions.ClearMemory);
            Pathfinding.Util.Memory.Realloc(ref agentRadii, size, Allocator.Persistent, NativeArrayOptions.ClearMemory);
            Pathfinding.Util.Memory.Realloc(ref childPointers, InnerNodeCountUpperBound(size, movementPlane), Allocator.Persistent, NativeArrayOptions.ClearMemory);
            Pathfinding.Util.Memory.Realloc(ref maxSpeeds, childPointers.Length, Allocator.Persistent, NativeArrayOptions.ClearMemory);
            Pathfinding.Util.Memory.Realloc(ref nodeAreas, childPointers.Length, Allocator.Persistent, NativeArrayOptions.ClearMemory);
            Pathfinding.Util.Memory.Realloc(ref maxRadius, childPointers.Length, Allocator.Persistent, NativeArrayOptions.ClearMemory);
        }

		[Token(Token = "0x60011CD")]
		[Address(RVA = "0x44A1C64", Offset = "0x449DC64", VA = "0x44A1C64")]
		public JobBuild BuildJob(NativeArray<float3> agentPositions, NativeArray<AgentIndex> agentVersions, NativeArray<float> agentSpeeds, NativeArray<float> agentRadii, int numAgents, MovementPlane movementPlane)
		{
            if (numAgents >= MaxAgents) throw new System.Exception("Too many agents. Cannot have more than " + MaxAgents.ToString());
            Reserve(numAgents);
            this.movementPlane = movementPlane;
            return new JobBuild {
                agents = agents, agentPositions = agentPositions, agentVersions = agentVersions,
                agentSpeeds = agentSpeeds, agentRadii = agentRadii,
                outBoundingBox = boundingBoxBuffer, outAgentCount = agentCountBuffer, outChildPointers = childPointers,
                outMaxSpeeds = maxSpeeds, outMaxRadius = maxRadius, outArea = nodeAreas,
                outAgentPositions = this.agentPositions, outAgentRadii = this.agentRadii,
                numAgents = numAgents, movementPlane = movementPlane
            };
        }

		[Token(Token = "0x60011CE")]
		[Address(RVA = "0x44A1DD8", Offset = "0x449DDD8", VA = "0x44A1DD8")]
		public int QueryKNearest(QuadtreeQuery query)
		{
            if (!agents.IsCreated) return 0;
            float maxRadius = DistanceInfinity;
            for (int i = 0; i < query.maxCount; i++) query.result[query.outputStartIndex + i] = -1;
            for (int i = 0; i < query.maxCount; i++) query.resultDistances[i] = DistanceInfinity;
            QueryRec(ref query, 0, boundingBoxBuffer[0], boundingBoxBuffer[1], ref maxRadius);
            int count = 0;
            while (count < query.maxCount && query.resultDistances[count] < DistanceInfinity) count++;
            return count;
        }

		[Token(Token = "0x60011CF")]
		[Address(RVA = "0x44A1F44", Offset = "0x449DF44", VA = "0x44A1F44")]
		private void QueryRec(ref QuadtreeQuery query, int treeNodeIndex, float3 nodeMin, float3 nodeMax, ref float maxRadius)
		{
            float3 position = query.position;
            float agentRadius = query.agentRadius;
            float reach = (maxSpeeds[treeNodeIndex] + query.speed) * query.timeHorizon;
            if (!float.IsNaN(agentRadius) && reach <= agentRadius) reach = agentRadius;
            reach = agentRadius + reach;
            float limit = reach < maxRadius || float.IsNaN(maxRadius) ? reach : maxRadius;
            int children = childPointers[treeNodeIndex];
            if ((children & LeafNodeBit) != 0)
            {
                int end = (children >> BitPackingShift) & BitPackingMask;
                for (int i = children & BitPackingMask; i < end; i++)
                {
                    int agent = agents[i];
                    float distance = math.lengthsq(position - agentPositions[agent]);
                    if (!(distance < limit * limit) || (query.layerMask & query.layers[agent]) == 0 || query.maxCount < 1) continue;
                    int insertion = 0;
                    while (insertion < query.maxCount && distance >= query.resultDistances[insertion]) insertion++;
                    if (insertion == query.maxCount) continue;
                    for (int j = query.maxCount - 1; j > insertion; j--)
                    {
                        query.result[query.outputStartIndex + j] = query.result[query.outputStartIndex + j - 1];
                        query.resultDistances[j] = query.resultDistances[j - 1];
                    }
                    query.result[query.outputStartIndex + insertion] = agent;
                    query.resultDistances[insertion] = distance;
                    if (insertion == query.maxCount - 1)
                    {
                        float nextRadius = math.sqrt(distance);
                        if (maxRadius < nextRadius || float.IsNaN(nextRadius)) nextRadius = maxRadius;
                        maxRadius = nextRadius;
                        if (!float.IsNaN(nextRadius) && !(limit < nextRadius)) limit = nextRadius;
                    }
                }
                return;
            }
            float3 middle = (nodeMin + nodeMax) * 0.5f;
            if (movementPlane == MovementPlane.XY)
            {
                int closest = (position.y >= middle.y ? 1 : 0) | (position.x >= middle.x ? 2 : 0);
                float3 closestMin = new float3(position.x >= middle.x ? middle.x : nodeMin.x, position.y >= middle.y ? middle.y : nodeMin.y, nodeMin.z);
                float3 closestMax = new float3(position.x >= middle.x ? nodeMax.x : middle.x, position.y >= middle.y ? nodeMax.y : middle.y, middle.z);
                QueryRec(ref query, children + closest, closestMin, closestMax, ref maxRadius);
                float radius = maxRadius;
                if (float.IsNaN(radius) || limit < radius) radius = limit;
                bool lowX = position.x - radius < middle.x;
                bool highX = position.x + radius > middle.x;
                bool lowY = position.y - radius < middle.y;
                bool highY = position.y + radius > middle.y;
                int mask = ((lowX && lowY ? 1 : 0) | (lowX && highY ? 2 : 0) | (highX && lowY ? 4 : 0) | (highX && highY ? 8 : 0)) & ~(1 << closest);
                while (mask != 0)
                {
                    int child = ChildLookup[mask];
                    float3 minimum = new float3((child & 2) != 0 ? middle.x : nodeMin.x, (child & 1) != 0 ? middle.y : nodeMin.y, nodeMin.z);
                    float3 maximum = new float3((child & 2) != 0 ? nodeMax.x : middle.x, (child & 1) != 0 ? nodeMax.y : middle.y, middle.z);
                    QueryRec(ref query, children + child, minimum, maximum, ref maxRadius);
                    mask &= ~(1 << child);
                }
            }
            else if (movementPlane != MovementPlane.Arbitrary)
            {
                int closest = (position.z >= middle.z ? 1 : 0) | (position.x >= middle.x ? 2 : 0);
                float3 closestMin = new float3(position.x >= middle.x ? middle.x : nodeMin.x, nodeMin.y, position.z >= middle.z ? middle.z : nodeMin.z);
                float3 closestMax = new float3(position.x >= middle.x ? nodeMax.x : middle.x, middle.y, position.z >= middle.z ? nodeMax.z : middle.z);
                QueryRec(ref query, children + closest, closestMin, closestMax, ref maxRadius);
                float radius = maxRadius;
                if (float.IsNaN(radius) || limit < radius) radius = limit;
                bool lowX = position.x - radius < middle.x;
                bool highX = position.x + radius > middle.x;
                bool lowZ = position.z - radius < middle.z;
                bool highZ = position.z + radius > middle.z;
                int mask = ((lowX && lowZ ? 1 : 0) | (lowX && highZ ? 2 : 0) | (highX && lowZ ? 4 : 0) | (highX && highZ ? 8 : 0)) & ~(1 << closest);
                while (mask != 0)
                {
                    int child = ChildLookup[mask];
                    float3 minimum = new float3((child & 2) != 0 ? middle.x : nodeMin.x, nodeMin.y, (child & 1) != 0 ? middle.z : nodeMin.z);
                    float3 maximum = new float3((child & 2) != 0 ? nodeMax.x : middle.x, middle.y, (child & 1) != 0 ? nodeMax.z : middle.z);
                    QueryRec(ref query, children + child, minimum, maximum, ref maxRadius);
                    mask &= ~(1 << child);
                }
            }
            else
            {
                int closest = (position.x >= middle.x ? 4 : 0) | (position.y >= middle.y ? 2 : 0) | (position.z >= middle.z ? 1 : 0);
                float3 closestMin = new float3(position.x >= middle.x ? middle.x : nodeMin.x, position.y >= middle.y ? middle.y : nodeMin.y, position.z < middle.z ? nodeMin.z : middle.z);
                float3 closestMax = new float3(position.x >= middle.x ? nodeMax.x : middle.x, position.y >= middle.y ? nodeMax.y : middle.y, position.z < middle.z ? middle.z : nodeMax.z);
                QueryRec(ref query, children + closest, closestMin, closestMax, ref maxRadius);
                float radius = maxRadius;
                if (float.IsNaN(radius) || limit < radius) radius = limit;
                int mask = (position.x - radius < middle.x ? 255 : 240)
                    & (position.x + radius > middle.x ? 255 : 15)
                    & (position.y - radius < middle.y ? 255 : 204)
                    & (position.y + radius <= middle.y ? 51 : 255)
                    & (position.z - radius < middle.z ? 255 : 170)
                    & (position.z + radius > middle.z ? 255 : 85)
                    & ~(1 << closest);
                while (mask != 0)
                {
                    int child = ChildLookup[mask];
                    float3 minimum = new float3((child & 4) != 0 ? middle.x : nodeMin.x, (child & 2) != 0 ? middle.y : nodeMin.y, (child & 1) != 0 ? middle.z : nodeMin.z);
                    float3 maximum = new float3((child & 4) != 0 ? nodeMax.x : middle.x, (child & 2) != 0 ? nodeMax.y : middle.y, (child & 1) != 0 ? nodeMax.z : middle.z);
                    QueryRec(ref query, children + child, minimum, maximum, ref maxRadius);
                    mask &= ~(1 << child);
                }
            }
        }

		[Token(Token = "0x60011D0")]
		[Address(RVA = "0x44A2754", Offset = "0x449E754", VA = "0x44A2754")]
		public float QueryArea(float3 position, float radius)
		{
            if (!agents.IsCreated || agentCountBuffer[0] == 0) return 0f;
            return QueryAreaRec(0, position, radius, boundingBoxBuffer[0], boundingBoxBuffer[1]) * 3.1415927410125732f;
        }

		[Token(Token = "0x60011D1")]
		[Address(RVA = "0x44A284C", Offset = "0x449E84C", VA = "0x44A284C")]
		private float QueryAreaRec(int treeNodeIndex, float3 p, float radius, float3 nodeMin, float3 nodeMax)
		{
            float3 middle = (nodeMin + nodeMax) * 0.5f;
            float3 extents = nodeMax - middle;
            float nodeRadius = math.length(extents);
            float agentRadius = maxRadius[treeNodeIndex];
            float distanceSq = math.lengthsq(middle - p);
            float insideRadius = radius - (nodeRadius + agentRadius);
            if (insideRadius > 0f && distanceSq < insideRadius * insideRadius) return nodeAreas[treeNodeIndex];
            float outsideRadius = (nodeRadius + agentRadius) + radius;
            if (distanceSq > outsideRadius * outsideRadius) return 0f;
            int children = childPointers[treeNodeIndex];
            float area = 0f;
            if ((children & LeafNodeBit) != 0)
            {
                int end = (children >> BitPackingShift) & BitPackingMask;
                for (int i = children & BitPackingMask; i < end; i++)
                {
                    int agent = agents[i];
                    float r = agentRadii[agent];
                    float d = math.lengthsq(p - agentPositions[agent]);
                    if (d < (r + radius) * (r + radius))
                    {
                        float difference = radius - r;
                        float fraction = 1f;
                        if (d >= difference * difference) fraction = 1f - (math.sqrt(d) - difference) / (r + r);
                        area += (r * r) * fraction;
                    }
                }
                return area;
            }
            float reach = agentRadius + radius;
            bool3 low = p - reach < middle;
            bool3 high = p + reach > middle;
            if (movementPlane == MovementPlane.Arbitrary)
            {
                if (low.x && low.y && low.z) area += QueryAreaRec(children + 0, p, radius, new float3(nodeMin.x, nodeMin.y, nodeMin.z), new float3(middle.x, middle.y, middle.z));
                if (low.x && low.y && high.z) area += QueryAreaRec(children + 1, p, radius, new float3(nodeMin.x, nodeMin.y, middle.z), new float3(middle.x, middle.y, nodeMax.z));
                if (low.x && high.y && low.z) area += QueryAreaRec(children + 2, p, radius, new float3(nodeMin.x, middle.y, nodeMin.z), new float3(middle.x, nodeMax.y, middle.z));
                if (low.x && high.y && high.z) area += QueryAreaRec(children + 3, p, radius, new float3(nodeMin.x, middle.y, middle.z), new float3(middle.x, nodeMax.y, nodeMax.z));
                if (high.x && low.y && low.z) area += QueryAreaRec(children + 4, p, radius, new float3(middle.x, nodeMin.y, nodeMin.z), new float3(nodeMax.x, middle.y, middle.z));
                if (high.x && low.y && high.z) area += QueryAreaRec(children + 5, p, radius, new float3(middle.x, nodeMin.y, middle.z), new float3(nodeMax.x, middle.y, nodeMax.z));
                if (high.x && high.y && low.z) area += QueryAreaRec(children + 6, p, radius, new float3(middle.x, middle.y, nodeMin.z), new float3(nodeMax.x, nodeMax.y, middle.z));
                if (high.x && high.y && high.z) area += QueryAreaRec(children + 7, p, radius, new float3(middle.x, middle.y, middle.z), new float3(nodeMax.x, nodeMax.y, nodeMax.z));
            }
            else if (movementPlane == MovementPlane.XY)
            {
                if (low.x && low.y) area += QueryAreaRec(children + 0, p, radius, new float3(nodeMin.x, nodeMin.y, nodeMin.z), new float3(middle.x, middle.y, nodeMax.z));
                if (low.x && high.y) area += QueryAreaRec(children + 1, p, radius, new float3(nodeMin.x, middle.y, nodeMin.z), new float3(middle.x, nodeMax.y, nodeMax.z));
                if (high.x && low.y) area += QueryAreaRec(children + 2, p, radius, new float3(middle.x, nodeMin.y, nodeMin.z), new float3(nodeMax.x, middle.y, nodeMax.z));
                if (high.x && high.y) area += QueryAreaRec(children + 3, p, radius, new float3(middle.x, middle.y, nodeMin.z), new float3(nodeMax.x, nodeMax.y, nodeMax.z));
            }
            else
            {
                if (low.x && low.z) area += QueryAreaRec(children + 0, p, radius, new float3(nodeMin.x, nodeMin.y, nodeMin.z), new float3(middle.x, nodeMax.y, middle.z));
                if (low.x && high.z) area += QueryAreaRec(children + 1, p, radius, new float3(nodeMin.x, nodeMin.y, middle.z), new float3(middle.x, nodeMax.y, nodeMax.z));
                if (high.x && low.z) area += QueryAreaRec(children + 2, p, radius, new float3(middle.x, nodeMin.y, nodeMin.z), new float3(nodeMax.x, nodeMax.y, middle.z));
                if (high.x && high.z) area += QueryAreaRec(children + 3, p, radius, new float3(middle.x, nodeMin.y, middle.z), new float3(nodeMax.x, nodeMax.y, nodeMax.z));
            }
            return area;
        }

		[Token(Token = "0x60011D2")]
		[Address(RVA = "0x44A33B4", Offset = "0x449F3B4", VA = "0x44A33B4")]
		public void DebugDraw(CommandBuilder draw)
		{
		}

		[Token(Token = "0x60011D3")]
		[Address(RVA = "0x44A3574", Offset = "0x449F574", VA = "0x44A3574")]
		private void DebugDraw(int nodeIndex, float3 nodeMin, float3 nodeMax, CommandBuilder draw)
		{
		}
	}
}
