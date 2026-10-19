using System;
using Il2CppDummyDll;
using Pathfinding.Util;
using UnityEngine;

namespace Pathfinding.RVO
{
	[Token(Token = "0x20002BF")]
	public interface IAgent
	{
		[Token(Token = "0x17000281")]
		int AgentIndex
		{
			[Token(Token = "0x600113D")]
			get;
		}

		[Token(Token = "0x17000282")]
		Vector3 Position
		{
			[Token(Token = "0x600113E")]
			get;
			[Token(Token = "0x600113F")]
			set;
		}

		[Token(Token = "0x17000283")]
		Vector3 CalculatedTargetPoint
		{
			[Token(Token = "0x6001140")]
			get;
		}

		[Token(Token = "0x17000284")]
		bool AvoidingAnyAgents
		{
			[Token(Token = "0x6001141")]
			get;
		}

		[Token(Token = "0x17000285")]
		float CalculatedSpeed
		{
			[Token(Token = "0x6001142")]
			get;
		}

		[Token(Token = "0x17000286")]
		SimpleMovementPlane MovementPlane
		{
			[Token(Token = "0x6001144")]
			get;
			[Token(Token = "0x6001145")]
			set;
		}

		[Token(Token = "0x17000287")]
		bool Locked
		{
			[Token(Token = "0x6001146")]
			get;
			[Token(Token = "0x6001147")]
			set;
		}

		[Token(Token = "0x17000288")]
		float Radius
		{
			[Token(Token = "0x6001148")]
			get;
			[Token(Token = "0x6001149")]
			set;
		}

		[Token(Token = "0x17000289")]
		float Height
		{
			[Token(Token = "0x600114A")]
			get;
			[Token(Token = "0x600114B")]
			set;
		}

		[Token(Token = "0x1700028A")]
		float AgentTimeHorizon
		{
			[Token(Token = "0x600114C")]
			get;
			[Token(Token = "0x600114D")]
			set;
		}

		[Token(Token = "0x1700028B")]
		float ObstacleTimeHorizon
		{
			[Token(Token = "0x600114E")]
			get;
			[Token(Token = "0x600114F")]
			set;
		}

		[Token(Token = "0x1700028C")]
		int MaxNeighbours
		{
			[Token(Token = "0x6001150")]
			get;
			[Token(Token = "0x6001151")]
			set;
		}

		[Token(Token = "0x1700028D")]
		int NeighbourCount
		{
			[Token(Token = "0x6001152")]
			get;
		}

		[Token(Token = "0x1700028E")]
		RVOLayer Layer
		{
			[Token(Token = "0x6001153")]
			get;
			[Token(Token = "0x6001154")]
			set;
		}

		[Token(Token = "0x1700028F")]
		RVOLayer CollidesWith
		{
			[Token(Token = "0x6001155")]
			get;
			[Token(Token = "0x6001156")]
			set;
		}

		[Token(Token = "0x17000290")]
		float FlowFollowingStrength
		{
			[Token(Token = "0x6001157")]
			get;
			[Token(Token = "0x6001158")]
			set;
		}

		[Token(Token = "0x17000291")]
		AgentDebugFlags DebugFlags
		{
			[Token(Token = "0x6001159")]
			get;
			[Token(Token = "0x600115A")]
			set;
		}

		[Token(Token = "0x17000292")]
		float Priority
		{
			[Token(Token = "0x600115B")]
			get;
			[Token(Token = "0x600115C")]
			set;
		}

		[Token(Token = "0x17000293")]
		int HierarchicalNodeIndex
		{
			[Token(Token = "0x600115D")]
			get;
			[Token(Token = "0x600115E")]
			set;
		}

		[Token(Token = "0x17000294")]
		Action PreCalculationCallback
		{
			[Token(Token = "0x600115F")]
			set;
		}

		[Token(Token = "0x17000295")]
		Action DestroyedCallback
		{
			[Token(Token = "0x6001160")]
			set;
		}

		[Token(Token = "0x17000296")]
		ReachedEndOfPath CalculatedEffectivelyReachedDestination
		{
			[Token(Token = "0x6001163")]
			get;
		}

		[Token(Token = "0x6001143")]
		void SetTarget(Vector3 targetPoint, float desiredSpeed, float maxSpeed, Vector3 endOfPath);

		[Token(Token = "0x6001161")]
		void SetCollisionNormal(Vector3 normal);

		[Token(Token = "0x6001162")]
		void ForceSetVelocity(Vector3 velocity);

		[Token(Token = "0x6001164")]
		void SetObstacleQuery(GraphNode sourceNode);
	}
}
