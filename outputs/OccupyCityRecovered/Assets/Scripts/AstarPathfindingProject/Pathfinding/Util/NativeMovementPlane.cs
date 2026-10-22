using Il2CppDummyDll;
using Unity.Mathematics;
using UnityEngine;

namespace Pathfinding.Util
{
	[Token(Token = "0x2000298")]
	public readonly struct NativeMovementPlane
	{
		[Token(Token = "0x4000BCD")]
		[FieldOffset(Offset = "0x0")]
		public readonly quaternion rotation;

		[Token(Token = "0x1700026D")]
		public float3 up
		{
			[Token(Token = "0x6001065")]
			[Address(RVA = "0x44941C8", Offset = "0x44901C8", VA = "0x44941C8")]
			get
			{
                float4 q = rotation.value;
                float x = q.x * q.y - q.w * q.z;
                float y = (0.5f - q.x * q.x) - q.z * q.z;
                float z = q.x * q.w + q.y * q.z;
                return new float3(x + x, y + y, z + z);
            }
		}

		[Token(Token = "0x6001066")]
		[Address(RVA = "0x449420C", Offset = "0x449020C", VA = "0x449420C")]
		public NativeMovementPlane(quaternion rotation)
		{
            float4 q = rotation.value;
            float lengthSquared = q.x * q.x + q.y * q.y;
            lengthSquared = q.z * q.z + lengthSquared;
            lengthSquared = q.w * q.w + lengthSquared;
            quaternion fallback = quaternion.identity;
            float inverseLength = 1f / math.sqrt(lengthSquared);
            this.rotation = lengthSquared > 1.17549435e-38f
                ? new quaternion(q.x * inverseLength, q.y * inverseLength, q.z * inverseLength, q.w * inverseLength)
                : fallback;
        }

		[Token(Token = "0x6001067")]
		[Address(RVA = "0x449422C", Offset = "0x449022C", VA = "0x449422C")]
		public NativeMovementPlane(SimpleMovementPlane plane)
		{
            quaternion input = (quaternion)plane.rotation;
            float4 q = input.value;
            float lengthSquared = q.x * q.x + q.y * q.y;
            lengthSquared = q.z * q.z + lengthSquared;
            lengthSquared = q.w * q.w + lengthSquared;
            quaternion fallback = quaternion.identity;
            float inverseLength = 1f / math.sqrt(lengthSquared);
            this.rotation = lengthSquared > 1.17549435e-38f
                ? new quaternion(q.x * inverseLength, q.y * inverseLength, q.z * inverseLength, q.w * inverseLength)
                : fallback;
        }

		[Token(Token = "0x6001068")]
		[Address(RVA = "0x449425C", Offset = "0x449025C", VA = "0x449425C")]
		public ToPlaneMatrix AsWorldToPlaneMatrix()
		{
			return default;
		}

		[Token(Token = "0x6001069")]
		[Address(RVA = "0x44942B8", Offset = "0x44902B8", VA = "0x44942B8")]
		public ToWorldMatrix AsPlaneToWorldMatrix()
		{
			return default;
		}

		[Token(Token = "0x600106A")]
		[Address(RVA = "0x4494308", Offset = "0x4490308", VA = "0x4494308")]
		public NativeMovementPlane MatchUpDirection(float3 up)
		{
            float4 q = rotation.value;
            float zero = 0f;
            float tx = q.y - q.z * zero;
            float ty = q.z * zero - q.x;
            float tz = q.x * zero - q.y * zero;
            tx += tx; ty += ty; tz += tz;
            float3 forward = new float3(
                (q.w * tx + zero) + (q.y * tz - q.z * ty),
                (q.w * ty + zero) + (q.z * tx - q.x * tz),
                (q.w * tz + 1f) + (q.x * ty - q.y * tx));
            float forwardLengthSquared = forward.x * forward.x + forward.y * forward.y;
            forwardLengthSquared = forward.z * forward.z + forwardLengthSquared;
            float inverseForwardLength = 1f / math.sqrt(forwardLengthSquared);
            forward = forwardLengthSquared > 1.17549435e-38f ? forward * inverseForwardLength : float3.zero;

            float upLengthSquared = up.x * up.x + up.y * up.y;
            upLengthSquared = up.z * up.z + upLengthSquared;
            float inverseUpLength = 1f / math.sqrt(upLengthSquared);
            float3 normalizedUp = upLengthSquared > 1.17549435e-38f ? up * inverseUpLength : float3.zero;
            float3 right = new float3(
                normalizedUp.y * forward.z - normalizedUp.z * forward.y,
                normalizedUp.z * forward.x - normalizedUp.x * forward.z,
                normalizedUp.x * forward.y - normalizedUp.y * forward.x);
            return new NativeMovementPlane(new quaternion(new float3x3(right, normalizedUp, forward)));
        }

		[Token(Token = "0x600106B")]
		[Address(RVA = "0x449452C", Offset = "0x449052C", VA = "0x449452C")]
		public float ProjectedLength(float3 v)
		{
            float2 projected = ToPlane(v);
            return math.sqrt(projected.x * projected.x + projected.y * projected.y);
        }

		[Token(Token = "0x600106C")]
		[Address(RVA = "0x4494594", Offset = "0x4490594", VA = "0x4494594")]
		public float2 ToPlane(float3 p)
		{
            float4 q = rotation.value;
            float tx = p.y * q.z - p.z * q.y;
            float ty = p.z * q.x - p.x * q.z;
            float tz = p.x * q.y - p.y * q.x;
            tx += tx; ty += ty; tz += tz;
            float x = (p.x + q.w * tx) + (q.z * ty - q.y * tz);
            float z = (p.z + q.w * tz) + (q.y * tx - q.x * ty);
            return new float2(x, z);
        }

		[Token(Token = "0x600106D")]
		[Address(RVA = "0x4494600", Offset = "0x4490600", VA = "0x4494600")]
		public float2 ToPlane(float3 p, out float elevation)
		{
            float4 q = rotation.value;
            float tx = p.y * q.z - p.z * q.y;
            float ty = p.z * q.x - p.x * q.z;
            float tz = p.x * q.y - p.y * q.x;
            tx += tx; ty += ty; tz += tz;
            float x = (p.x + q.w * tx) + (q.z * ty - q.y * tz);
            float y = (p.y + q.w * ty) + (q.x * tz - q.z * tx);
            float z = (p.z + q.w * tz) + (q.y * tx - q.x * ty);
            elevation = y;
            return new float2(x, z);
        }

		[Token(Token = "0x600106E")]
		[Address(RVA = "0x4494688", Offset = "0x4490688", VA = "0x4494688")]
		public float3 ToWorld(float2 p, float elevation = 0f)
		{
            float4 q = rotation.value;
            float tx = p.y * q.y - elevation * q.z;
            float ty = p.x * q.z - p.y * q.x;
            float tz = elevation * q.x - p.x * q.y;
            tx += tx; ty += ty; tz += tz;
            float x = (p.x + q.w * tx) + (q.y * tz - q.z * ty);
            float y = (q.w * ty + elevation) + (q.z * tx - q.x * tz);
            float z = (p.y + q.w * tz) + (q.x * ty - q.y * tx);
            return new float3(x, y, z);
        }

		[Token(Token = "0x600106F")]
		[Address(RVA = "0x449470C", Offset = "0x449070C", VA = "0x449470C")]
		public float ToPlane(quaternion rotation)
		{
            float4 p = this.rotation.value;
            float4 r = rotation.value;
            float y = (r.y * p.w + (r.x * -p.z - r.w * p.y)) + r.z * p.x;
            float w = (r.w * p.w - (r.y * -p.y - r.x * p.x)) + r.z * p.z;
            if (y < 0f) { y = -y; w = -w; }
            return -VectorMath.QuaternionAngle(math.normalizesafe(new quaternion(0f, y, 0f, w)));
        }

		[Token(Token = "0x6001070")]
		[Address(RVA = "0x4494794", Offset = "0x4490794", VA = "0x4494794")]
		public quaternion ToWorldRotation(float angle)
		{
            float4 q = rotation.value;
            float halfAngle = angle * -0.5f;
            double radians = halfAngle;
            float sine = (float)System.Math.Sin(radians);
            float cosine = (float)System.Math.Cos(radians);
            float zero = 0f;
            return new quaternion(
                ((q.x * cosine + q.y * zero) + q.w * zero) - q.z * sine,
                (q.w * sine + (q.y * cosine + q.z * zero)) - q.x * zero,
                (q.w * zero + (q.x * sine + q.z * cosine)) - q.y * zero,
                (q.w * cosine - (q.x * zero + q.y * sine)) - q.z * zero);
        }

		[Token(Token = "0x6001071")]
		[Address(RVA = "0x44948CC", Offset = "0x44908CC", VA = "0x44948CC")]
		public quaternion ToWorldRotationDelta(float deltaAngle)
		{
            float3 axis = ToWorld(float2.zero, 1f);
            float halfAngle = deltaAngle * -0.5f;
            double radians = halfAngle;
            float sine = (float)System.Math.Sin(radians);
            float cosine = (float)System.Math.Cos(radians);
            return new quaternion(axis.x * sine, axis.y * sine, axis.z * sine, cosine);
        }

		[Token(Token = "0x6001072")]
		[Address(RVA = "0x44949E8", Offset = "0x44909E8", VA = "0x44949E8")]
		public Bounds ToWorld(Bounds bounds)
		{
			return default;
		}
	}
}
