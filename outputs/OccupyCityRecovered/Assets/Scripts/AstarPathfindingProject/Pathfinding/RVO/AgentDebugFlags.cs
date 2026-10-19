using System;
using Il2CppDummyDll;

namespace Pathfinding.RVO
{
	[Token(Token = "0x20002BE")]
	[Flags]
	public enum AgentDebugFlags : byte
	{
		[Token(Token = "0x4000C6D")]
		Nothing = 0,
		[Token(Token = "0x4000C6E")]
		ObstacleVelocityObstacles = 1,
		[Token(Token = "0x4000C6F")]
		AgentVelocityObstacles = 2,
		[Token(Token = "0x4000C70")]
		ReachedState = 4,
		[Token(Token = "0x4000C71")]
		DesiredVelocity = 8,
		[Token(Token = "0x4000C72")]
		ChosenVelocity = 0x10,
		[Token(Token = "0x4000C73")]
		Obstacles = 0x20,
		[Token(Token = "0x4000C74")]
		ForwardClearance = 0x40,
		[Token(Token = "0x4000C75")]
		[Obsolete("Renamed to ObstacleVelocityObstacles")]
		ObstacleVOs = ObstacleVelocityObstacles,
		[Token(Token = "0x4000C76")]
		[Obsolete("Renamed to AgentVelocityObstacles")]
		AgentVOs = AgentVelocityObstacles
	}
}
