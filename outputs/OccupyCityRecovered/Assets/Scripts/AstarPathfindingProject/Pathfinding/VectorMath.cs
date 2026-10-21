using Il2CppDummyDll;
using Unity.Mathematics;
using UnityEngine;

namespace Pathfinding
{
	[Token(Token = "0x2000050")]
	public static class VectorMath
	{
		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x4463700", Offset = "0x445F700", VA = "0x4463700")]
		public static Vector2 ComplexMultiply(Vector2 a, Vector2 b)
		{
			return default;
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x446371C", Offset = "0x445F71C", VA = "0x446371C")]
		public static float2 ComplexMultiply(float2 a, float2 b)
		{
			return default;
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x4463738", Offset = "0x445F738", VA = "0x4463738")]
		public static float2 ComplexMultiplyConjugate(float2 a, float2 b)
		{
			return default;
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x4463754", Offset = "0x445F754", VA = "0x4463754")]
		public static Vector2 ComplexMultiplyConjugate(Vector2 a, Vector2 b)
		{
			return default;
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x4463770", Offset = "0x445F770", VA = "0x4463770")]
		public static Vector3 ClosestPointOnLine(Vector3 lineStart, Vector3 lineEnd, Vector3 point)
		{
			return default;
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x44638B0", Offset = "0x445F8B0", VA = "0x44638B0")]
		public static float3 ClosestPointOnLine(float3 lineStart, float3 lineEnd, float3 point)
		{
 float factor=ClosestPointOnLineFactor(lineStart,lineEnd,point);
 return lineStart+(lineEnd-lineStart)*factor;
}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x4463994", Offset = "0x445F994", VA = "0x4463994")]
		public static float ClosestPointOnLineFactor(Vector3 lineStart, Vector3 lineEnd, Vector3 point)
		{
			return default;
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x4463930", Offset = "0x445F930", VA = "0x4463930")]
		public static float ClosestPointOnLineFactor(float3 lineStart, float3 lineEnd, float3 point)
		{
 var direction=lineEnd-lineStart;
 float length=direction.z*direction.z+(direction.x*direction.x+direction.y*direction.y);
 var offset=point-lineStart;
 float result=(direction.z*offset.z+(direction.x*offset.x+direction.y*offset.y))/length;
 return length>0.000001f ? result : 0f;
}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x44639FC", Offset = "0x445F9FC", VA = "0x44639FC")]
		public static float ClosestPointOnLineFactor(Int3 lineStart, Int3 lineEnd, Int3 point)
		{
			return default;
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x4463A9C", Offset = "0x445FA9C", VA = "0x4463A9C")]
		public static float ClosestPointOnLineFactor(Vector2Int lineStart, Vector2Int lineEnd, Vector2Int point)
		{
			return default;
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x4463AE4", Offset = "0x445FAE4", VA = "0x4463AE4")]
		public static Vector3 ClosestPointOnSegment(Vector3 lineStart, Vector3 lineEnd, Vector3 point)
		{
			return default;
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x4463B74", Offset = "0x445FB74", VA = "0x4463B74")]
		public static Vector3 ClosestPointOnSegmentXZ(Vector3 lineStart, Vector3 lineEnd, Vector3 point)
		{
			return default;
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x4463D04", Offset = "0x445FD04", VA = "0x4463D04")]
		public static float SqrDistancePointSegmentApproximate(int x, int z, int px, int pz, int qx, int qz)
		{
			return default;
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x4463DA0", Offset = "0x445FDA0", VA = "0x4463DA0")]
		public static float SqrDistancePointSegmentApproximate(Int3 a, Int3 b, Int3 p)
		{
			return default;
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x4463E3C", Offset = "0x445FE3C", VA = "0x4463E3C")]
		public static float SqrDistancePointSegment(Vector3 a, Vector3 b, Vector3 p)
		{
			return default;
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x4463E94", Offset = "0x445FE94", VA = "0x4463E94")]
		public static float SqrDistanceSegmentSegment(Vector3 s1, Vector3 e1, Vector3 s2, Vector3 e2)
		{
			return default;
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x4464190", Offset = "0x4460190", VA = "0x4464190")]
		public static float Determinant(float2 c1, float2 c2)
		{
			return default;
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x44641A0", Offset = "0x44601A0", VA = "0x44641A0")]
		public static float SqrDistanceXZ(Vector3 a, Vector3 b)
		{
			return default;
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x44641B8", Offset = "0x44601B8", VA = "0x44641B8")]
		public static long SignedTriangleAreaTimes2(int2 a, int2 b, int2 c)
		{
			return default;
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x44641EC", Offset = "0x44601EC", VA = "0x44641EC")]
		public static long SignedTriangleAreaTimes2XZ(Int3 a, Int3 b, Int3 c)
		{
			return default;
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x445B5F4", Offset = "0x44575F4", VA = "0x445B5F4")]
		public static float SignedTriangleAreaTimes2XZ(Vector3 a, Vector3 b, Vector3 c)
		{
			return default;
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x4464208", Offset = "0x4460208", VA = "0x4464208")]
		public static bool RightXZ(Vector3 a, Vector3 b, Vector3 p)
		{
			return default;
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x4464240", Offset = "0x4460240", VA = "0x4464240")]
		public static bool RightXZ(Int3 a, Int3 b, Int3 p)
		{
			return default;
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x4464264", Offset = "0x4460264", VA = "0x4464264")]
		public static bool Right(int2 a, int2 b, int2 p)
		{
			return default;
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x446429C", Offset = "0x446029C", VA = "0x446429C")]
		public static Side SideXZ(Int3 a, Int3 b, Int3 p)
		{
			return default;
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x44642D0", Offset = "0x44602D0", VA = "0x44642D0")]
		public static bool RightOrColinear(Vector2 a, Vector2 b, Vector2 p)
		{
			return default;
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x44642F8", Offset = "0x44602F8", VA = "0x44642F8")]
		public static bool RightOrColinear(Vector2Int a, Vector2Int b, Vector2Int p)
		{
			return default;
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x445B5C4", Offset = "0x44575C4", VA = "0x445B5C4")]
		public static bool RightOrColinearXZ(Vector3 a, Vector3 b, Vector3 p)
		{
			return default;
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x4464330", Offset = "0x4460330", VA = "0x4464330")]
		public static bool RightOrColinearXZ(Int3 a, Int3 b, Int3 p)
		{
			return default;
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x4464354", Offset = "0x4460354", VA = "0x4464354")]
		public static bool IsClockwiseMarginXZ(Vector3 a, Vector3 b, Vector3 c)
		{
			return default;
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x446438C", Offset = "0x446038C", VA = "0x446438C")]
		public static bool IsClockwiseXZ(Vector3 a, Vector3 b, Vector3 c)
		{
			return default;
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x44643BC", Offset = "0x44603BC", VA = "0x44643BC")]
		public static bool IsClockwiseXZ(Int3 a, Int3 b, Int3 c)
		{
			return default;
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x44643E0", Offset = "0x44603E0", VA = "0x44643E0")]
		public static bool IsClockwise(int2 a, int2 b, int2 c)
		{
			return default;
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x4464418", Offset = "0x4460418", VA = "0x4464418")]
		public static bool IsClockwiseOrColinearXZ(Int3 a, Int3 b, Int3 c)
		{
			return default;
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x446443C", Offset = "0x446043C", VA = "0x446443C")]
		public static bool IsClockwiseOrColinear(Vector2Int a, Vector2Int b, Vector2Int c)
		{
			return default;
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x4464474", Offset = "0x4460474", VA = "0x4464474")]
		public static bool IsColinear(Vector3 a, Vector3 b, Vector3 c)
		{
			return default;
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x4464580", Offset = "0x4460580", VA = "0x4464580")]
		public static bool IsColinear(Vector2 a, Vector2 b, Vector2 c)
		{
			return default;
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x44645C4", Offset = "0x44605C4", VA = "0x44645C4")]
		public static bool IsColinear(int2 a, int2 b, int2 c)
		{
			return default;
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x44645FC", Offset = "0x44605FC", VA = "0x44645FC")]
		public static bool IsColinearXZ(Int3 a, Int3 b, Int3 c)
		{
			return default;
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x445B578", Offset = "0x4457578", VA = "0x445B578")]
		public static bool IsColinearXZ(Vector3 a, Vector3 b, Vector3 c)
		{
			return default;
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x4464620", Offset = "0x4460620", VA = "0x4464620")]
		public static bool IsColinearAlmostXZ(Int3 a, Int3 b, Int3 c)
		{
			return default;
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x4464644", Offset = "0x4460644", VA = "0x4464644")]
		public static bool SegmentsIntersect(Vector2Int start1, Vector2Int end1, Vector2Int start2, Vector2Int end2)
		{
			return default;
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x4464704", Offset = "0x4460704", VA = "0x4464704")]
		public static bool SegmentsIntersectXZ(Int3 start1, Int3 end1, Int3 start2, Int3 end2)
		{
			return default;
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x446478C", Offset = "0x446078C", VA = "0x446478C")]
		public static bool SegmentsIntersectXZ(Vector3 start1, Vector3 end1, Vector3 start2, Vector3 end2)
		{
			return default;
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x4464818", Offset = "0x4460818", VA = "0x4464818")]
		public static float2 CapsuleLineIntersectionFactors(float2 capsuleStart, float2 capsuleDir, float capsuleLength, float2 lineStart, float2 lineDir, float radius)
		{
			return default;
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x4464BF4", Offset = "0x4460BF4", VA = "0x4464BF4")]
		public static bool LineLineIntersectionFactor(float2 start1, float2 dir1, float2 start2, float2 dir2, out float t)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED VectorMath.LineLineIntersectionFactor RVA=0x4464BF4 Token=0x600032C");
}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x4464C44", Offset = "0x4460C44", VA = "0x4464C44")]
		public static bool LineLineIntersectionFactors(float2 start1, float2 dir1, float2 start2, float2 dir2, out float factor1, out float factor2)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED VectorMath.LineLineIntersectionFactors RVA=0x4464C44 Token=0x600032D");
}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x4464CAC", Offset = "0x4460CAC", VA = "0x4464CAC")]
		public static Vector3 LineDirIntersectionPointXZ(Vector3 start1, Vector3 dir1, Vector3 start2, Vector3 dir2)
		{
			return default;
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x4464D04", Offset = "0x4460D04", VA = "0x4464D04")]
		public static Vector3 LineDirIntersectionPointXZ(Vector3 start1, Vector3 dir1, Vector3 start2, Vector3 dir2, out bool intersects)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED VectorMath.LineDirIntersectionPointXZ RVA=0x4464D04 Token=0x600032F");
}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x4464D6C", Offset = "0x4460D6C", VA = "0x4464D6C")]
		public static bool RaySegmentIntersectXZ(Int3 start1, Int3 end1, Int3 start2, Int3 end2)
		{
			return default;
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x4464DE8", Offset = "0x4460DE8", VA = "0x4464DE8")]
		public static bool LineIntersectionFactorXZ(Int3 start1, Int3 end1, Int3 start2, Int3 end2, out float factor1, out float factor2)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED VectorMath.LineIntersectionFactorXZ RVA=0x4464DE8 Token=0x6000331");
}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x4464E60", Offset = "0x4460E60", VA = "0x4464E60")]
		public static bool LineIntersectionFactorXZ(Vector3 start1, Vector3 end1, Vector3 start2, Vector3 end2, out float factor1, out float factor2)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED VectorMath.LineIntersectionFactorXZ RVA=0x4464E60 Token=0x6000332");
}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x4464EF8", Offset = "0x4460EF8", VA = "0x4464EF8")]
		public static float LineRayIntersectionFactorXZ(Int3 start1, Int3 end1, Int3 start2, Int3 end2)
		{
			return default;
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x4464F64", Offset = "0x4460F64", VA = "0x4464F64")]
		public static float LineIntersectionFactorXZ(Vector3 start1, Vector3 end1, Vector3 start2, Vector3 end2)
		{
			return default;
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x4464FBC", Offset = "0x4460FBC", VA = "0x4464FBC")]
		public static Vector3 LineIntersectionPointXZ(Vector3 start1, Vector3 end1, Vector3 start2, Vector3 end2)
		{
			return default;
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x4464FF8", Offset = "0x4460FF8", VA = "0x4464FF8")]
		public static Vector3 LineIntersectionPointXZ(Vector3 start1, Vector3 end1, Vector3 start2, Vector3 end2, out bool intersects)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED VectorMath.LineIntersectionPointXZ RVA=0x4464FF8 Token=0x6000336");
}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x4465074", Offset = "0x4461074", VA = "0x4465074")]
		public static Vector2 LineIntersectionPoint(Vector2 start1, Vector2 end1, Vector2 start2, Vector2 end2)
		{
			return default;
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x4465088", Offset = "0x4461088", VA = "0x4465088")]
		public static Vector2 LineIntersectionPoint(Vector2 start1, Vector2 end1, Vector2 start2, Vector2 end2, out bool intersects)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED VectorMath.LineIntersectionPoint RVA=0x4465088 Token=0x6000338");
}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x44650E8", Offset = "0x44610E8", VA = "0x44650E8")]
		public static Vector3 SegmentIntersectionPointXZ(Vector3 start1, Vector3 end1, Vector3 start2, Vector3 end2, out bool intersects)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED VectorMath.SegmentIntersectionPointXZ RVA=0x44650E8 Token=0x6000339");
}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x446519C", Offset = "0x446119C", VA = "0x446519C")]
		public static bool SegmentIntersectsBounds(Bounds bounds, Vector3 a, Vector3 b)
		{
			return default;
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x4464B34", Offset = "0x4460B34", VA = "0x4464B34")]
		public static bool LineCircleIntersectionFactors(float2 point, float2 direction, float radius, out float t1, out float t2)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED VectorMath.LineCircleIntersectionFactors RVA=0x4464B34 Token=0x600033B");
}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x44653EC", Offset = "0x44613EC", VA = "0x44653EC")]
		public static bool SegmentCircleIntersectionFactors(float2 point1, float2 point2, float radiusSq, out float t1, out float t2)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED VectorMath.SegmentCircleIntersectionFactors RVA=0x44653EC Token=0x600033C");
}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x4465520", Offset = "0x4461520", VA = "0x4465520")]
		public static float LineCircleIntersectionFactor(Vector3 circleCenter, Vector3 linePoint1, Vector3 linePoint2, float radius)
		{
			return default;
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x44656E0", Offset = "0x44616E0", VA = "0x44656E0")]
		public static bool ReversesFaceOrientations(Matrix4x4 matrix)
		{
			return default;
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x4465600", Offset = "0x4461600", VA = "0x4465600")]
		public static Vector3 Normalize(Vector3 v, out float magnitude)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED VectorMath.Normalize RVA=0x4465600 Token=0x600033F");
}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x44657A4", Offset = "0x44617A4", VA = "0x44657A4")]
		public static Vector2 Normalize(Vector2 v, out float magnitude)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED VectorMath.Normalize RVA=0x44657A4 Token=0x6000340");
}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x4465868", Offset = "0x4461868", VA = "0x4465868")]
		public static Vector3 ClampMagnitudeXZ(Vector3 v, float maxMagnitude)
		{
			return default;
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x445AEA8", Offset = "0x4456EA8", VA = "0x445AEA8")]
		public static float MagnitudeXZ(Vector3 v)
		{
			return default;
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x446589C", Offset = "0x446189C", VA = "0x446589C")]
		public static float QuaternionAngle(quaternion rot)
		{
			return default;
		}
	}
}
