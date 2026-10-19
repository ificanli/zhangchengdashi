using System;
using System.Collections.Generic;
using Beebyte.Obfuscator;
using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Mathematics;

namespace RVO2
{
	[Token(Token = "0x2000F15")]
	[BurstCompile]
	[Skip]
	public class Simulator
	{
		[Token(Token = "0x400685A")]
		[FieldOffset(Offset = "0x10")]
		internal NativeParallelHashMap<int, int> agentNo2indexDict_;

		[Token(Token = "0x400685B")]
		[FieldOffset(Offset = "0x20")]
		internal NativeParallelHashMap<int, int> index2agentNoDict_;

		[Token(Token = "0x400685C")]
		[FieldOffset(Offset = "0x30")]
		internal NativeList<Agent> agents_;

		[Token(Token = "0x400685D")]
		[FieldOffset(Offset = "0x38")]
		internal NativeList<Obstacle> obstacles_;

		[Token(Token = "0x400685E")]
		[FieldOffset(Offset = "0x40")]
		internal unsafe KdTree* kdTree_;

		[Token(Token = "0x400685F")]
		[FieldOffset(Offset = "0x48")]
		internal float timeStep_;

		[Token(Token = "0x4006860")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Simulator instance_;

		[Token(Token = "0x4006861")]
		[FieldOffset(Offset = "0x50")]
		private Agent defaultAgent_;

		[Token(Token = "0x4006862")]
		[FieldOffset(Offset = "0x6A0")]
		private int numWorkers_;

		[Token(Token = "0x4006863")]
		[FieldOffset(Offset = "0x6A4")]
		private int workerAgentCount_;

		[Token(Token = "0x4006864")]
		[FieldOffset(Offset = "0x6A8")]
		private float globalTime_;

		[Token(Token = "0x4006865")]
		[FieldOffset(Offset = "0x6B0")]
		private NativeList<IntPtr> agentsPtr_;

		[Token(Token = "0x4006866")]
		[FieldOffset(Offset = "0x6B8")]
		private NativeList<KdTree.AgentTreeNode> agentTree_;

		[Token(Token = "0x4006867")]
		[FieldOffset(Offset = "0x6C0")]
		private NativeList<KdTree.ObstacleTreeNode> treeNodeList;

		[Token(Token = "0x4006868")]
		[FieldOffset(Offset = "0x8")]
		private static int s_totalID;

		[Token(Token = "0x17000F42")]
		public static Simulator Instance
		{
			[Token(Token = "0x6005AA3")]
			[Address(RVA = "0x4396390", Offset = "0x4392390", VA = "0x4396390")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005AA4")]
		[Address(RVA = "0x43963E8", Offset = "0x43923E8", VA = "0x43963E8")]
		public void delAgent(int agentNo)
		{
		}

		[Token(Token = "0x6005AA5")]
		[Address(RVA = "0x439646C", Offset = "0x439246C", VA = "0x439646C")]
		public void ClearObstacles()
		{
		}

		[Token(Token = "0x6005AA6")]
		[Address(RVA = "0x43964D4", Offset = "0x43924D4", VA = "0x43964D4")]
		public void UpdateDeleteAgent()
		{
		}

		[Token(Token = "0x6005AA7")]
		[Address(RVA = "0x4396710", Offset = "0x4392710", VA = "0x4396710")]
		public int addAgent(float2 position)
		{
			return default;
		}

		[Token(Token = "0x6005AA8")]
		[Address(RVA = "0x43965EC", Offset = "0x43925EC", VA = "0x43965EC")]
		private void onDelAgent()
		{
		}

		[Token(Token = "0x6005AA9")]
		[Address(RVA = "0x4396834", Offset = "0x4392834", VA = "0x4396834")]
		private void onAddAgent()
		{
		}

		[Token(Token = "0x6005AAA")]
		[Address(RVA = "0x4396930", Offset = "0x4392930", VA = "0x4396930")]
		public int addAgent(float2 position, float neighborDist, int maxNeighbors, float timeHorizon, float timeHorizonObst, float radius, float maxSpeed, float2 velocity)
		{
			return default;
		}

		[Token(Token = "0x6005AAB")]
		[Address(RVA = "0x4396A94", Offset = "0x4392A94", VA = "0x4396A94")]
		public int addObstacle(IList<float2> vertices)
		{
			return default;
		}

		[Token(Token = "0x6005AAC")]
		[Address(RVA = "0x4397274", Offset = "0x4393274", VA = "0x4397274")]
		public void Init()
		{
		}

		[Token(Token = "0x6005AAD")]
		[Address(RVA = "0x4397594", Offset = "0x4393594", VA = "0x4397594")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6005AAE")]
		[Address(RVA = "0x4397770", Offset = "0x4393770", VA = "0x4397770")]
		[Skip]
		[BurstCompile]
		internal void CreateAgentTree()
		{
		}

		[Token(Token = "0x6005AAF")]
		[Address(RVA = "0x4397A70", Offset = "0x4393A70", VA = "0x4397A70")]
		[Skip]
		[BurstCompile]
		internal void buildObstacleTree()
		{
		}

		[Token(Token = "0x6005AB0")]
		[Address(RVA = "0x4397C40", Offset = "0x4393C40", VA = "0x4397C40")]
		[Skip]
		[BurstCompile]
		public float doStep()
		{
			return default;
		}

		[Token(Token = "0x6005AB1")]
		[Address(RVA = "0x4397E40", Offset = "0x4393E40", VA = "0x4397E40")]
		public int getAgentAgentNeighbor(int agentNo, int neighborNo)
		{
			return default;
		}

		[Token(Token = "0x6005AB2")]
		[Address(RVA = "0x4397F74", Offset = "0x4393F74", VA = "0x4397F74")]
		public int getAgentMaxNeighbors(int agentNo)
		{
			return default;
		}

		[Token(Token = "0x6005AB3")]
		[Address(RVA = "0x4398018", Offset = "0x4394018", VA = "0x4398018")]
		public float getAgentMaxSpeed(int agentNo)
		{
			return default;
		}

		[Token(Token = "0x6005AB4")]
		[Address(RVA = "0x43980BC", Offset = "0x43940BC", VA = "0x43980BC")]
		public float getAgentNeighborDist(int agentNo)
		{
			return default;
		}

		[Token(Token = "0x6005AB5")]
		[Address(RVA = "0x4398160", Offset = "0x4394160", VA = "0x4398160")]
		public int getAgentNumAgentNeighbors(int agentNo)
		{
			return default;
		}

		[Token(Token = "0x6005AB6")]
		[Address(RVA = "0x439822C", Offset = "0x439422C", VA = "0x439822C")]
		public int getAgentNumObstacleNeighbors(int agentNo)
		{
			return default;
		}

		[Token(Token = "0x6005AB7")]
		[Address(RVA = "0x43982F8", Offset = "0x43942F8", VA = "0x43982F8")]
		public int getAgentObstacleNeighbor(int agentNo, int neighborNo)
		{
			return default;
		}

		[Token(Token = "0x6005AB8")]
		[Address(RVA = "0x4398438", Offset = "0x4394438", VA = "0x4398438")]
		public FixedList512Bytes<Line> getAgentOrcaLines(int agentNo)
		{
			return default;
		}

		[Token(Token = "0x6005AB9")]
		[Address(RVA = "0x4398540", Offset = "0x4394540", VA = "0x4398540")]
		public float2 getAgentPosition(int agentNo)
		{
			return default;
		}

		[Token(Token = "0x6005ABA")]
		[Address(RVA = "0x43985E8", Offset = "0x43945E8", VA = "0x43985E8")]
		public float2 getAgentPrefVelocity(int agentNo)
		{
			return default;
		}

		[Token(Token = "0x6005ABB")]
		[Address(RVA = "0x4398690", Offset = "0x4394690", VA = "0x4398690")]
		public float getAgentRadius(int agentNo)
		{
			return default;
		}

		[Token(Token = "0x6005ABC")]
		[Address(RVA = "0x4398734", Offset = "0x4394734", VA = "0x4398734")]
		public float getAgentTimeHorizon(int agentNo)
		{
			return default;
		}

		[Token(Token = "0x6005ABD")]
		[Address(RVA = "0x43987D8", Offset = "0x43947D8", VA = "0x43987D8")]
		public float getAgentTimeHorizonObst(int agentNo)
		{
			return default;
		}

		[Token(Token = "0x6005ABE")]
		[Address(RVA = "0x439887C", Offset = "0x439487C", VA = "0x439887C")]
		public float2 getAgentVelocity(int agentNo)
		{
			return default;
		}

		[Token(Token = "0x6005ABF")]
		[Address(RVA = "0x4398924", Offset = "0x4394924", VA = "0x4398924")]
		public float getGlobalTime()
		{
			return default;
		}

		[Token(Token = "0x6005AC0")]
		[Address(RVA = "0x439892C", Offset = "0x439492C", VA = "0x439892C")]
		public int getNumAgents()
		{
			return default;
		}

		[Token(Token = "0x6005AC1")]
		[Address(RVA = "0x43989A0", Offset = "0x43949A0", VA = "0x43989A0")]
		public int getNumObstacleVertices()
		{
			return default;
		}

		[Token(Token = "0x6005AC2")]
		[Address(RVA = "0x4398A14", Offset = "0x4394A14", VA = "0x4398A14")]
		public int GetNumWorkers()
		{
			return default;
		}

		[Token(Token = "0x6005AC3")]
		[Address(RVA = "0x4398A1C", Offset = "0x4394A1C", VA = "0x4398A1C")]
		public float2 getObstacleVertex(int vertexNo)
		{
			return default;
		}

		[Token(Token = "0x6005AC4")]
		[Address(RVA = "0x4398A7C", Offset = "0x4394A7C", VA = "0x4398A7C")]
		public int getNextObstacleVertexNo(int vertexNo)
		{
			return default;
		}

		[Token(Token = "0x6005AC5")]
		[Address(RVA = "0x4398AE8", Offset = "0x4394AE8", VA = "0x4398AE8")]
		public int getPrevObstacleVertexNo(int vertexNo)
		{
			return default;
		}

		[Token(Token = "0x6005AC6")]
		[Address(RVA = "0x4398B54", Offset = "0x4394B54", VA = "0x4398B54")]
		public float getTimeStep()
		{
			return default;
		}

		[Token(Token = "0x6005AC7")]
		[Address(RVA = "0x43964D0", Offset = "0x43924D0", VA = "0x43964D0")]
		public void processObstacles()
		{
		}

		[Token(Token = "0x6005AC8")]
		[Address(RVA = "0x4398B5C", Offset = "0x4394B5C", VA = "0x4398B5C")]
		public bool queryVisibility(float2 point1, float2 point2, float radius)
		{
			return default;
		}

		[Token(Token = "0x6005AC9")]
		[Address(RVA = "0x4398B68", Offset = "0x4394B68", VA = "0x4398B68")]
		public int queryNearAgent(float2 point, float radius)
		{
			return default;
		}

		[Token(Token = "0x6005ACA")]
		[Address(RVA = "0x4398BE0", Offset = "0x4394BE0", VA = "0x4398BE0")]
		public void setAgentDefaults(float neighborDist, int maxNeighbors, float timeHorizon, float timeHorizonObst, float radius, float maxSpeed, float2 velocity)
		{
		}

		[Token(Token = "0x6005ACB")]
		[Address(RVA = "0x4398D10", Offset = "0x4394D10", VA = "0x4398D10")]
		public void setAgentMaxNeighbors(int agentNo, int maxNeighbors)
		{
		}

		[Token(Token = "0x6005ACC")]
		[Address(RVA = "0x4398D9C", Offset = "0x4394D9C", VA = "0x4398D9C")]
		public void setAgentMaxSpeed(int agentNo, float maxSpeed)
		{
		}

		[Token(Token = "0x6005ACD")]
		[Address(RVA = "0x4398E28", Offset = "0x4394E28", VA = "0x4398E28")]
		public void setAgentNeighborDist(int agentNo, float neighborDist)
		{
		}

		[Token(Token = "0x6005ACE")]
		[Address(RVA = "0x4398EB4", Offset = "0x4394EB4", VA = "0x4398EB4")]
		public void setAgentPosition(int agentNo, float2 position)
		{
		}

		[Token(Token = "0x6005ACF")]
		[Address(RVA = "0x4398F48", Offset = "0x4394F48", VA = "0x4398F48")]
		public void setAgentPrefVelocity(int agentNo, float2 prefVelocity)
		{
		}

		[Token(Token = "0x6005AD0")]
		[Address(RVA = "0x4398FDC", Offset = "0x4394FDC", VA = "0x4398FDC")]
		public void setAgentRadius(int agentNo, float radius)
		{
		}

		[Token(Token = "0x6005AD1")]
		[Address(RVA = "0x4399068", Offset = "0x4395068", VA = "0x4399068")]
		public void setAgentTimeHorizon(int agentNo, float timeHorizon)
		{
		}

		[Token(Token = "0x6005AD2")]
		[Address(RVA = "0x43990F4", Offset = "0x43950F4", VA = "0x43990F4")]
		public void setAgentTimeHorizonObst(int agentNo, float timeHorizonObst)
		{
		}

		[Token(Token = "0x6005AD3")]
		[Address(RVA = "0x4399180", Offset = "0x4395180", VA = "0x4399180")]
		public void setAgentVelocity(int agentNo, float2 velocity)
		{
		}

		[Token(Token = "0x6005AD4")]
		[Address(RVA = "0x4399214", Offset = "0x4395214", VA = "0x4399214")]
		public void setGlobalTime(float globalTime)
		{
		}

		[Token(Token = "0x6005AD5")]
		[Address(RVA = "0x4397558", Offset = "0x4393558", VA = "0x4397558")]
		public void SetNumWorkers(int numWorkers)
		{
		}

		[Token(Token = "0x6005AD6")]
		[Address(RVA = "0x439921C", Offset = "0x439521C", VA = "0x439921C")]
		public void setTimeStep(float timeStep)
		{
		}

		[Token(Token = "0x6005AD7")]
		[Address(RVA = "0x4399224", Offset = "0x4395224", VA = "0x4399224")]
		private Simulator()
		{
		}
	}
}
