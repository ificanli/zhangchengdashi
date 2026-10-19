using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x20002B4")]
	internal sealed class WebGLLocalAvoidanceSimulator
	{
		[Token(Token = "0x4002176")]
		private const int DefaultMaxNeighbours = 8;

		[Token(Token = "0x4002177")]
		private const int CrowdedMaxNeighbours = 4;

		[Token(Token = "0x4002178")]
		private const int CrowdedAgentThreshold = 60;

		[Token(Token = "0x4002179")]
		private const int LocalCrowdNeighbourThreshold = 2;

		[Token(Token = "0x400217A")]
		private const int MinAvoidanceSampleFrameGap = 3;

		[Token(Token = "0x400217B")]
		private const float DefaultCellSize = 1.8f;

		[Token(Token = "0x400217C")]
		private const float DesiredRadiusScale = 0.72f;

		[Token(Token = "0x400217D")]
		private const float HardRadiusScale = 0.48f;

		[Token(Token = "0x400217E")]
		private const float NeighbourDistanceScale = 2.4f;

		[Token(Token = "0x400217F")]
		private const float AvoidanceWeight = 0.72f;

		[Token(Token = "0x4002180")]
		private const float SeparationOnlyWeight = 0.55f;

		[Token(Token = "0x4002181")]
		private const float MaxAvoidanceSpeedScale = 0.8f;

		[Token(Token = "0x4002182")]
		private const float MaxSeparationOnlySpeedScale = 0.38f;

		[Token(Token = "0x4002183")]
		private const float MaxDirectionDeviationRadians = 0.85f;

		[Token(Token = "0x4002184")]
		private const float VelocitySmoothRate = 13f;

		[Token(Token = "0x4002185")]
		private const float AvoidanceUpdateInterval = 0.2f;

		[Token(Token = "0x4002186")]
		[FieldOffset(Offset = "0x10")]
		private readonly Dictionary<int, List<int>> _grid;

		[Token(Token = "0x4002187")]
		[FieldOffset(Offset = "0x18")]
		private readonly List<int> _usedKeys;

		[Token(Token = "0x4002188")]
		[FieldOffset(Offset = "0x20")]
		private readonly List<int> _emptyList;

		[Token(Token = "0x4002189")]
		[FieldOffset(Offset = "0x28")]
		private float _cellSize;

		[Token(Token = "0x400218A")]
		[FieldOffset(Offset = "0x2C")]
		private float _avoidanceTimer;

		[Token(Token = "0x400218B")]
		[FieldOffset(Offset = "0x30")]
		private bool _hasAvoidanceSample;

		[Token(Token = "0x400218C")]
		[FieldOffset(Offset = "0x34")]
		private int _stepFrame;

		[Token(Token = "0x400218D")]
		[FieldOffset(Offset = "0x38")]
		private int _lastAvoidanceSampleFrame;

		[Token(Token = "0x400218E")]
		[FieldOffset(Offset = "0x3C")]
		private int _avoidancePhase;

		[Token(Token = "0x6000C27")]
		[Address(RVA = "0x3D35514", Offset = "0x3D31514", VA = "0x3D35514")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000C28")]
		[Address(RVA = "0x3D3567C", Offset = "0x3D3167C", VA = "0x3D3567C")]
		public void Step(List<WebGLNavigationAgent> agents, float deltaTime)
		{
		}

		[Token(Token = "0x6000C29")]
		[Address(RVA = "0x3D35A24", Offset = "0x3D31A24", VA = "0x3D35A24")]
		private bool ShouldSampleAvoidance(float deltaTime)
		{
			return default;
		}

		[Token(Token = "0x6000C2A")]
		[Address(RVA = "0x3D36328", Offset = "0x3D32328", VA = "0x3D36328")]
		private Vector3 CalculateAvoidance(List<WebGLNavigationAgent> agents, int agentListIndex, WebGLNavigationAgent agent, int maxNeighbours)
		{
			return default;
		}

		[Token(Token = "0x6000C2B")]
		[Address(RVA = "0x3D35A98", Offset = "0x3D31A98", VA = "0x3D35A98")]
		private int BuildGrid(List<WebGLNavigationAgent> agents)
		{
			return default;
		}

		[Token(Token = "0x6000C2C")]
		[Address(RVA = "0x3D35FF0", Offset = "0x3D31FF0", VA = "0x3D35FF0")]
		private bool HasLocalCrowd(List<WebGLNavigationAgent> agents, int agentListIndex, WebGLNavigationAgent agent, int neighbourThreshold)
		{
			return default;
		}

		[Token(Token = "0x6000C2D")]
		[Address(RVA = "0x3D36C00", Offset = "0x3D32C00", VA = "0x3D36C00")]
		private List<int> GetCell(int x, int z)
		{
			return null;
		}

		[Token(Token = "0x6000C2E")]
		[Address(RVA = "0x3D35F00", Offset = "0x3D31F00", VA = "0x3D35F00")]
		private static Vector3 SmoothVelocity(WebGLNavigationAgent agent, Vector3 targetVelocity, float deltaTime, float maxSpeed)
		{
			return default;
		}

		[Token(Token = "0x6000C2F")]
		[Address(RVA = "0x3D35588", Offset = "0x3D31588", VA = "0x3D35588")]
		private void ClearUsedCells()
		{
		}

		[Token(Token = "0x6000C30")]
		[Address(RVA = "0x3D36D24", Offset = "0x3D32D24", VA = "0x3D36D24")]
		private static int GetKey(int x, int z)
		{
			return default;
		}

		[Token(Token = "0x6000C31")]
		[Address(RVA = "0x3D369A4", Offset = "0x3D329A4", VA = "0x3D369A4")]
		private static Vector3 LimitDirectionDeviation(Vector3 velocity, Vector3 preferredVelocity, float maxSpeed)
		{
			return default;
		}

		[Token(Token = "0x6000C32")]
		[Address(RVA = "0x3D35EB4", Offset = "0x3D31EB4", VA = "0x3D35EB4")]
		private static Vector3 ClampVelocity(Vector3 velocity, float maxSpeed)
		{
			return default;
		}

		[Token(Token = "0x6000C33")]
		[Address(RVA = "0x3D36C9C", Offset = "0x3D32C9C", VA = "0x3D36C9C")]
		private static Vector3 GetStableSeparation(int a, int b)
		{
			return default;
		}

		[Token(Token = "0x6000C34")]
		[Address(RVA = "0x3D36CF4", Offset = "0x3D32CF4", VA = "0x3D36CF4")]
		private static Vector3 GetStableSideStep(int a, int b, Vector3 away)
		{
			return default;
		}

		[Token(Token = "0x6000C35")]
		[Address(RVA = "0x3D36D44", Offset = "0x3D32D44", VA = "0x3D36D44")]
		private static bool IsSameOrAdjacentHex(HexBehaviour a, HexBehaviour b)
		{
			return default;
		}

		[Token(Token = "0x6000C36")]
		[Address(RVA = "0x3D36EB8", Offset = "0x3D32EB8", VA = "0x3D36EB8")]
		public WebGLLocalAvoidanceSimulator()
		{
		}
	}
}
