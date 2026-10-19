using Il2CppDummyDll;

namespace Pathfinding.PID
{
	[Token(Token = "0x2000261")]
	public static class AnglePIDController
	{
		[Token(Token = "0x4000B36")]
		private const float DampingRatio = 1f;

		[Token(Token = "0x6000EED")]
		[Address(RVA = "0x448AD5C", Offset = "0x4486D5C", VA = "0x448AD5C")]
		public static float ApproximateTurningRadius(float followingStrength)
		{
			return default;
		}

		[Token(Token = "0x6000EEE")]
		[Address(RVA = "0x4486F64", Offset = "0x4482F64", VA = "0x4486F64")]
		public static float RotationSpeedToFollowingStrength(float speed, float maxRotationSpeed)
		{
			return default;
		}

		[Token(Token = "0x6000EEF")]
		[Address(RVA = "0x448ADCC", Offset = "0x4486DCC", VA = "0x448ADCC")]
		public static float FollowingStrengthToRotationSpeed(float followingStrength)
		{
			return default;
		}

		[Token(Token = "0x6000EF0")]
		[Address(RVA = "0x448A69C", Offset = "0x448669C", VA = "0x448A69C")]
		public static AnglePIDControlOutput2D Control(ref PIDMovement settings, float followingStrength, float angle, float curveAngle, float curveCurvature, float curveDistanceSigned, float speed, float remainingDistance, float minRotationSpeed, bool isStationary, float dt)
		{
			return default;
		}
	}
}
