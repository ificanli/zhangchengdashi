using Beebyte.Obfuscator;
using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Mathematics;

namespace RVO2
{
	[Token(Token = "0x2000F06")]
	[Skip]
	[BurstCompile]
	public struct Agent
	{
		[Token(Token = "0x4006826")]
		[FieldOffset(Offset = "0x0")]
		internal FixedList512Bytes<DistanceAgent> agentNeighbors_;

		[Token(Token = "0x4006827")]
		[FieldOffset(Offset = "0x200")]
		internal FixedList512Bytes<DistanceObstacle> obstacleNeighbors_;

		[Token(Token = "0x4006828")]
		[FieldOffset(Offset = "0x400")]
		internal FixedList512Bytes<Line> orcaLines_;

		[Token(Token = "0x4006829")]
		[FieldOffset(Offset = "0x600")]
		internal float2 position_;

		[Token(Token = "0x400682A")]
		[FieldOffset(Offset = "0x608")]
		internal float2 prefVelocity_;

		[Token(Token = "0x400682B")]
		[FieldOffset(Offset = "0x610")]
		internal float2 velocity_;

		[Token(Token = "0x400682C")]
		[FieldOffset(Offset = "0x618")]
		internal int id_;

		[Token(Token = "0x400682D")]
		[FieldOffset(Offset = "0x61C")]
		internal int maxNeighbors_;

		[Token(Token = "0x400682E")]
		[FieldOffset(Offset = "0x620")]
		internal float maxSpeed_;

		[Token(Token = "0x400682F")]
		[FieldOffset(Offset = "0x624")]
		internal float neighborDist_;

		[Token(Token = "0x4006830")]
		[FieldOffset(Offset = "0x628")]
		internal float radius_;

		[Token(Token = "0x4006831")]
		[FieldOffset(Offset = "0x62C")]
		internal float timeHorizon_;

		[Token(Token = "0x4006832")]
		[FieldOffset(Offset = "0x630")]
		internal float timeHorizonObst_;

		[Token(Token = "0x4006833")]
		[FieldOffset(Offset = "0x634")]
		internal bool needDelete_;

		[Token(Token = "0x4006834")]
		[FieldOffset(Offset = "0x638")]
		internal float timeStep_;

		[Token(Token = "0x4006835")]
		[FieldOffset(Offset = "0x63C")]
		private float2 newVelocity_;

		[Token(Token = "0x4006836")]
		[FieldOffset(Offset = "0x648")]
		public unsafe KdTree* kdTree;

		[Token(Token = "0x6005A5F")]
		[Address(RVA = "0x4392270", Offset = "0x438E270", VA = "0x4392270")]
		internal void computeNeighbors()
		{
		}

		[Token(Token = "0x6005A60")]
		[Address(RVA = "0x43923AC", Offset = "0x438E3AC", VA = "0x43923AC")]
		internal void computeNewVelocity()
		{
		}

		[Token(Token = "0x6005A61")]
		[Address(RVA = "0x439374C", Offset = "0x438F74C", VA = "0x439374C")]
		internal unsafe void insertAgentNeighbor(Agent* agent, ref float rangeSq)
		{
		}

		[Token(Token = "0x6005A62")]
		[Address(RVA = "0x439395C", Offset = "0x438F95C", VA = "0x439395C")]
		internal unsafe void insertObstacleNeighbor(Obstacle* obstacle, float rangeSq)
		{
		}

		[Token(Token = "0x6005A63")]
		[Address(RVA = "0x4393B60", Offset = "0x438FB60", VA = "0x4393B60")]
		internal void update()
		{
		}

		[Token(Token = "0x6005A64")]
		[Address(RVA = "0x4393B88", Offset = "0x438FB88", VA = "0x4393B88")]
		private bool linearProgram1(ref FixedList512Bytes<Line> lines, int lineNo, float radius, float2 optVelocity, bool directionOpt, ref float2 result)
		{
			return default;
		}

		[Token(Token = "0x6005A65")]
		[Address(RVA = "0x43930C8", Offset = "0x438F0C8", VA = "0x43930C8")]
		private int linearProgram2(ref FixedList512Bytes<Line> lines, float radius, float2 optVelocity, bool directionOpt, ref float2 result)
		{
			return default;
		}

		[Token(Token = "0x6005A66")]
		[Address(RVA = "0x43932C0", Offset = "0x438F2C0", VA = "0x43932C0")]
		private void linearProgram3(ref FixedList512Bytes<Line> lines, int numObstLines, int beginLine, float radius, ref float2 result)
		{
		}
	}
}
