using System;
using Il2CppDummyDll;
using Pathfinding.RVO;
using Unity.Entities;
using UnityEngine;

namespace Pathfinding.ECS.RVO
{
	[Serializable]
	[Token(Token = "0x20003B2")]
	public struct RVOAgent : IComponentData, IQueryTypeParameter
	{
		[Token(Token = "0x4000F9A")]
		[FieldOffset(Offset = "0x0")]
		[Tooltip("How far into the future to look for collisions with other agents (in seconds)")]
		public float agentTimeHorizon;

		[Token(Token = "0x4000F9B")]
		[FieldOffset(Offset = "0x4")]
		[Tooltip("How far into the future to look for collisions with obstacles (in seconds)")]
		public float obstacleTimeHorizon;

		[Token(Token = "0x4000F9C")]
		[FieldOffset(Offset = "0x8")]
		[Tooltip("Max number of other agents to take into account.\nA smaller value can reduce CPU load, a higher value can lead to better local avoidance quality.")]
		public int maxNeighbours;

		[Token(Token = "0x4000F9D")]
		[FieldOffset(Offset = "0xC")]
		public RVOLayer layer;

		[Token(Token = "0x4000F9E")]
		[FieldOffset(Offset = "0x10")]
		[EnumFlag]
		public RVOLayer collidesWith;

		[Token(Token = "0x4000F9F")]
		[FieldOffset(Offset = "0x14")]
		[Range(0f, 1f)]
		[Tooltip("How strongly other agents will avoid this agent")]
		public float priority;

		[NonSerialized]
		[Token(Token = "0x4000FA0")]
		[FieldOffset(Offset = "0x18")]
		public float priorityMultiplier;

		[NonSerialized]
		[Token(Token = "0x4000FA1")]
		[FieldOffset(Offset = "0x1C")]
		public float flowFollowingStrength;

		[Token(Token = "0x4000FA2")]
		[FieldOffset(Offset = "0x20")]
		public AgentDebugFlags debug;

		[Token(Token = "0x4000FA3")]
		[FieldOffset(Offset = "0x21")]
		[Tooltip("A locked unit cannot move. Other units will still avoid it. But avoidance quality is not the best")]
		public bool locked;

		[Token(Token = "0x4000FA4")]
		[FieldOffset(Offset = "0x0")]
		public static readonly RVOAgent Default;
	}
}
