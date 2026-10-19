using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding.Util
{
	[Token(Token = "0x200028C")]
	public static class MovementUtilities
	{
		[Token(Token = "0x6001025")]
		[Address(RVA = "0x4490200", Offset = "0x448C200", VA = "0x4490200")]
		public static float FilterRotationDirection(ref Vector2 state, ref Vector2 state2, Vector2 deltaPosition, float threshold, float deltaTime, bool avoidingOtherAgents)
		{
			return default;
		}

		[Token(Token = "0x6001026")]
		[Address(RVA = "0x4490338", Offset = "0x448C338", VA = "0x4490338")]
		public static Vector2 ClampVelocity(Vector2 velocity, float maxSpeed, float speedLimitFactor, bool slowWhenNotFacingTarget, bool preventMovingBackwards, Vector2 forward)
		{
			return default;
		}

		[Token(Token = "0x6001027")]
		[Address(RVA = "0x4490508", Offset = "0x448C508", VA = "0x4490508")]
		public static Vector2 CalculateAccelerationToReachPoint(Vector2 deltaPosition, Vector2 targetVelocity, Vector2 currentVelocity, float forwardsAcceleration, float rotationSpeed, float maxSpeed, Vector2 forwardsVector)
		{
			return default;
		}
	}
}
