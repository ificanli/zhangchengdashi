using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding.Util
{
	[Token(Token = "0x2000291")]
	public class PathInterpolator
	{
		[Token(Token = "0x2000292")]
		public struct Cursor
		{
			[Token(Token = "0x4000BC2")]
			[FieldOffset(Offset = "0x0")]
			private PathInterpolator interpolator;

			[Token(Token = "0x4000BC3")]
			[FieldOffset(Offset = "0x8")]
			private int version;

			[Token(Token = "0x4000BC4")]
			[FieldOffset(Offset = "0xC")]
			private float currentDistance;

			[Token(Token = "0x4000BC5")]
			[FieldOffset(Offset = "0x10")]
			private float distanceToSegmentStart;

			[Token(Token = "0x4000BC6")]
			[FieldOffset(Offset = "0x14")]
			private float currentSegmentLength;

			[Token(Token = "0x17000262")]
			private int segmentIndex
			{
				[Token(Token = "0x6001033")]
				[Address(RVA = "0x44912FC", Offset = "0x448D2FC", VA = "0x44912FC")]
				[CompilerGenerated]
				readonly get
				{
					return default;
				}
				[Token(Token = "0x6001034")]
				[Address(RVA = "0x4491304", Offset = "0x448D304", VA = "0x4491304")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x17000263")]
			public int segmentCount
			{
				[Token(Token = "0x6001035")]
				[Address(RVA = "0x449130C", Offset = "0x448D30C", VA = "0x449130C")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000264")]
			public Vector3 endPoint
			{
				[Token(Token = "0x6001036")]
				[Address(RVA = "0x44913D4", Offset = "0x448D3D4", VA = "0x44913D4")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000265")]
			public float fractionAlongCurrentSegment
			{
				[Token(Token = "0x6001037")]
				[Address(RVA = "0x4491448", Offset = "0x448D448", VA = "0x4491448")]
				get
				{
					return default;
				}
				[Token(Token = "0x6001038")]
				[Address(RVA = "0x4491468", Offset = "0x448D468", VA = "0x4491468")]
				set
				{
				}
			}

			[Token(Token = "0x17000266")]
			public bool valid
			{
				[Token(Token = "0x600103A")]
				[Address(RVA = "0x4491490", Offset = "0x448D490", VA = "0x4491490")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000267")]
			public Vector3 tangent
			{
				[Token(Token = "0x600103B")]
				[Address(RVA = "0x44914B4", Offset = "0x448D4B4", VA = "0x44914B4")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000268")]
			public float remainingDistance
			{
				[Token(Token = "0x600103C")]
				[Address(RVA = "0x4491564", Offset = "0x448D564", VA = "0x4491564")]
				get
				{
					return default;
				}
				[Token(Token = "0x600103D")]
				[Address(RVA = "0x4491590", Offset = "0x448D590", VA = "0x4491590")]
				set
				{
				}
			}

			[Token(Token = "0x17000269")]
			public float distance
			{
				[Token(Token = "0x600103E")]
				[Address(RVA = "0x44915C8", Offset = "0x448D5C8", VA = "0x44915C8")]
				get
				{
					return default;
				}
				[Token(Token = "0x600103F")]
				[Address(RVA = "0x4490DE0", Offset = "0x448CDE0", VA = "0x4490DE0")]
				set
				{
				}
			}

			[Token(Token = "0x1700026A")]
			public Vector3 position
			{
				[Token(Token = "0x6001040")]
				[Address(RVA = "0x4491810", Offset = "0x448D810", VA = "0x4491810")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x1700026B")]
			public Vector3 curvatureDirection
			{
				[Token(Token = "0x6001044")]
				[Address(RVA = "0x4491C54", Offset = "0x448DC54", VA = "0x4491C54")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x6001039")]
			[Address(RVA = "0x4490C30", Offset = "0x448CC30", VA = "0x4490C30")]
			public static Cursor StartOfPath(PathInterpolator interpolator)
			{
				return default;
			}

			[Token(Token = "0x6001041")]
			[Address(RVA = "0x4491910", Offset = "0x448D910", VA = "0x4491910")]
			public void GetRemainingPath(List<Vector3> buffer)
			{
			}

			[Token(Token = "0x6001042")]
			[Address(RVA = "0x4491368", Offset = "0x448D368", VA = "0x4491368")]
			private void AssertValid()
			{
			}

			[Token(Token = "0x6001043")]
			[Address(RVA = "0x4491A88", Offset = "0x448DA88", VA = "0x4491A88")]
			public void GetTangents(out Vector3 t1, out Vector3 t2)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED PathInterpolator.Cursor.GetTangents RVA=0x4491A88 Token=0x6001043");
}

			[Token(Token = "0x6001045")]
			[Address(RVA = "0x4491D14", Offset = "0x448DD14", VA = "0x4491D14")]
			public void MoveToNextCorner()
			{
			}

			[Token(Token = "0x6001046")]
			[Address(RVA = "0x4491E9C", Offset = "0x448DE9C", VA = "0x4491E9C")]
			public bool MoveToClosestIntersectionWithLineSegment(Vector3 origin, Vector3 direction, Vector2 range)
			{
				return default;
			}

			[Token(Token = "0x6001047")]
			[Address(RVA = "0x4492144", Offset = "0x448E144", VA = "0x4492144")]
			private void MoveToSegment(int index, float fractionAlongSegment)
			{
			}

			[Token(Token = "0x6001048")]
			[Address(RVA = "0x4492254", Offset = "0x448E254", VA = "0x4492254")]
			public void MoveToClosestPoint(Vector3 point)
			{
			}

			[Token(Token = "0x6001049")]
			[Address(RVA = "0x4492450", Offset = "0x448E450", VA = "0x4492450")]
			public void MoveToLocallyClosestPoint(Vector3 point, bool allowForwards = true, bool allowBackwards = true)
			{
			}

			[Token(Token = "0x600104A")]
			public void MoveToCircleIntersection2D<T>(Vector3 circleCenter3D, float radius, T transform) where T : IMovementPlane
			{
			}

			[Token(Token = "0x600104B")]
			[Address(RVA = "0x4492810", Offset = "0x448E810", VA = "0x4492810")]
			private static float IntegrateSmoothingKernel(float a, float b, float smoothingDistance)
			{
				return default;
			}

			[Token(Token = "0x600104C")]
			[Address(RVA = "0x44928BC", Offset = "0x448E8BC", VA = "0x44928BC")]
			private static float IntegrateSmoothingKernel2(float a, float b, float smoothingDistance)
			{
				return default;
			}

			[Token(Token = "0x600104D")]
			[Address(RVA = "0x4492928", Offset = "0x448E928", VA = "0x4492928")]
			private static Vector3 IntegrateSmoothTangent(Vector3 p1, Vector3 p2, ref Vector3 tangent, ref float distance, float expectedRadius, float smoothingDistance)
			{
				return default;
			}

			[Token(Token = "0x600104E")]
			[Address(RVA = "0x4492CB4", Offset = "0x448ECB4", VA = "0x4492CB4")]
			public Vector3 EstimateSmoothTangent(Vector3 normalizedTangent, float smoothingDistance, float expectedRadius, Vector3 beforePathStartContribution, bool forward = true, bool backward = true)
			{
				return default;
			}

			[Token(Token = "0x600104F")]
			[Address(RVA = "0x4492FE0", Offset = "0x448EFE0", VA = "0x4492FE0")]
			public Vector3 EstimateSmoothCurvature(Vector3 tangent, float smoothingDistance, float expectedRadius)
			{
				return default;
			}

			[Token(Token = "0x6001050")]
			[Address(RVA = "0x4493A0C", Offset = "0x448FA0C", VA = "0x4493A0C")]
			public void MoveWithTurningSpeed(float time, float speed, float turningSpeed, ref Vector3 tangent)
			{
			}

			[Token(Token = "0x6001051")]
			[Address(RVA = "0x44915D0", Offset = "0x448D5D0", VA = "0x44915D0")]
			private void PrevSegment()
			{
			}

			[Token(Token = "0x6001052")]
			[Address(RVA = "0x44916EC", Offset = "0x448D6EC", VA = "0x44916EC")]
			private void NextSegment()
			{
			}
		}

		[Token(Token = "0x4000BBF")]
		[FieldOffset(Offset = "0x10")]
		private List<Vector3> path;

		[Token(Token = "0x4000BC0")]
		[FieldOffset(Offset = "0x18")]
		private int version;

		[Token(Token = "0x4000BC1")]
		[FieldOffset(Offset = "0x1C")]
		private float totalDistance;

		[Token(Token = "0x17000260")]
		public bool valid
		{
			[Token(Token = "0x600102E")]
			[Address(RVA = "0x4490BF8", Offset = "0x448CBF8", VA = "0x4490BF8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000261")]
		public Cursor start
		{
			[Token(Token = "0x600102F")]
			[Address(RVA = "0x4490C08", Offset = "0x448CC08", VA = "0x4490C08")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6001030")]
		[Address(RVA = "0x4490D98", Offset = "0x448CD98", VA = "0x4490D98")]
		public Cursor AtDistanceFromStart(float distance)
		{
			return default;
		}

		[Token(Token = "0x6001031")]
		[Address(RVA = "0x4490EBC", Offset = "0x448CEBC", VA = "0x4490EBC")]
		public void SetPath(List<Vector3> path)
		{
		}

		[Token(Token = "0x6001032")]
		[Address(RVA = "0x44912EC", Offset = "0x448D2EC", VA = "0x44912EC")]
		public PathInterpolator()
		{
		}
	}
}
