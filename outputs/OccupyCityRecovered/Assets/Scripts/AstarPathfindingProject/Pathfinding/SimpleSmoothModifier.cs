using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	[Serializable]
	[Token(Token = "0x2000125")]
	[HelpURL("https://arongranberg.com/astar/documentation/stable/simplesmoothmodifier.html")]
	[AddComponentMenu("Pathfinding/Modifiers/Simple Smooth Modifier")]
	[RequireComponent(typeof(Seeker))]
	public class SimpleSmoothModifier : MonoModifier
	{
		[Token(Token = "0x2000126")]
		public enum SmoothType
		{
			[Token(Token = "0x4000645")]
			Simple = 0,
			[Token(Token = "0x4000646")]
			Bezier = 1,
			[Token(Token = "0x4000647")]
			OffsetSimple = 2,
			[Token(Token = "0x4000648")]
			CurvedNonuniform = 3
		}

		[Token(Token = "0x400063B")]
		[FieldOffset(Offset = "0x30")]
		public SmoothType smoothType;

		[Token(Token = "0x400063C")]
		[FieldOffset(Offset = "0x34")]
		[Tooltip("The number of times to subdivide (divide in half) the path segments. [0...inf] (recommended [1...10])")]
		public int subdivisions = 2;

		[Token(Token = "0x400063D")]
		[FieldOffset(Offset = "0x38")]
		[Tooltip("Number of times to apply smoothing")]
		public int iterations = 2;

		[Token(Token = "0x400063E")]
		[FieldOffset(Offset = "0x3C")]
		[Tooltip("Determines how much smoothing to apply in each smooth iteration. 0.5 usually produces the nicest looking curves")]
		[Range(0f, 1f)]
		public float strength = 0.5f;

		[Token(Token = "0x400063F")]
		[FieldOffset(Offset = "0x40")]
		[Tooltip("Toggle to divide all lines in equal length segments")]
		public bool uniformLength = true;

		[Token(Token = "0x4000640")]
		[FieldOffset(Offset = "0x44")]
		[Tooltip("The length of each segment in the smoothed path. A high value yields rough paths and low value yields very smooth paths, but is slower")]
		public float maxSegmentLength = 2f;

		[Token(Token = "0x4000641")]
		[FieldOffset(Offset = "0x48")]
		[Tooltip("Length factor of the bezier curves' tangents")]
		public float bezierTangentLength = 0.4f;

		[Token(Token = "0x4000642")]
		[FieldOffset(Offset = "0x4C")]
		[Tooltip("Offset to apply in each smoothing iteration when using Offset Simple")]
		public float offset = 0.2f;

		[Token(Token = "0x4000643")]
		[FieldOffset(Offset = "0x50")]
		[Tooltip("How much to smooth the path. A higher value will give a smoother path, but might take the character far off the optimal path.")]
		public float factor = 0.1f;

		[Token(Token = "0x170001C7")]
		public override int Order
		{
			[Token(Token = "0x60009C3")]
			[Address(RVA = "0x455721C", Offset = "0x455321C", VA = "0x455721C", Slot = "20")]
			get
			{ return 50; }
		}

		[Token(Token = "0x60009C4")]
		[Address(RVA = "0x4557224", Offset = "0x4553224", VA = "0x4557224", Slot = "22")]
		public override void Apply(Path p)
		{
            if (p.vectorPath == null)
            {
                UnityEngine.Debug.LogWarning("Can't process NULL path (has another modifier logged an error?)");
                return;
            }
            List<Vector3> smoothed = null;
            switch (smoothType)
            {
                case SmoothType.Simple: smoothed = SmoothSimple(p.vectorPath); break;
                case SmoothType.Bezier: smoothed = SmoothBezier(p.vectorPath); break;
                case SmoothType.OffsetSimple: smoothed = SmoothOffsetSimple(p.vectorPath); break;
                case SmoothType.CurvedNonuniform: smoothed = CurvedNonuniform(p.vectorPath); break;
            }
            if (!ReferenceEquals(smoothed, p.vectorPath))
            {
                Pathfinding.Pooling.ListPool<Vector3>.Release(ref p.vectorPath);
                p.vectorPath = smoothed;
            }
        }

		[Token(Token = "0x60009C5")]
		[Address(RVA = "0x4558580", Offset = "0x4554580", VA = "0x4558580")]
		public List<Vector3> CurvedNonuniform(List<Vector3> path)
		{
            if (maxSegmentLength <= 0f)
            {
                Debug.LogWarning("Max Segment Length is <= 0 which would cause DivByZero-exception or other nasty errors (avoid this)");
                return path;
            }
            int capacity = 0;
            for (int i = 0; i < unchecked(path.Count - 1); i = unchecked(i + 1))
            {
                Vector3 a = path[i];
                Vector3 b = path[unchecked(i + 1)];
                float dx = a.x - b.x, dy = a.y - b.y, dz = a.z - b.z;
                float length = (float)System.Math.Sqrt(dz * dz + (dx * dx + dy * dy));
                if (length >= 0f)
                {
                    float step = maxSegmentLength;
                    float distance = 0f;
                    do
                    {
                        distance += step;
                        capacity = unchecked(capacity + 1);
                    } while (distance <= length);
                }
            }
            List<Vector3> result = Pathfinding.Pooling.ListPool<Vector3>.Claim(capacity);
            Vector3 firstNext = path[1];
            Vector3 first = path[0];
            float ix = firstNext.x - first.x, iy = firstNext.y - first.y, iz = firstNext.z - first.z;
            float initialLength = (float)System.Math.Sqrt(iz * iz + (ix * ix + iy * iy));
            Vector3 previousTangent = initialLength > 1e-5f ? new Vector3(ix / initialLength, iy / initialLength, iz / initialLength) : Vector3.zero;
            for (int i = 0; i < unchecked(path.Count - 1); i = unchecked(i + 1))
            {
                Vector3 a = path[i];
                Vector3 b = path[unchecked(i + 1)];
                Vector3 nextTangent;
                if (i < unchecked(path.Count - 2))
                {
                    Vector3 after = path[unchecked(i + 2)];
                    Vector3 next = path[unchecked(i + 1)];
                    float nx = after.x - next.x, ny = after.y - next.y, nz = after.z - next.z;
                    float nl = (float)System.Math.Sqrt(nz * nz + (nx * nx + ny * ny));
                    Vector3 following = nl > 1e-5f ? new Vector3(nx / nl, ny / nl, nz / nl) : Vector3.zero;
                    Vector3 startAgain = path[i];
                    Vector3 endAgain = path[unchecked(i + 1)];
                    float rx = startAgain.x - endAgain.x, ry = startAgain.y - endAgain.y, rz = startAgain.z - endAgain.z;
                    float rl = (float)System.Math.Sqrt(rz * rz + (rx * rx + ry * ry));
                    Vector3 backward = rl > 1e-5f ? new Vector3(rx / rl, ry / rl, rz / rl) : Vector3.zero;
                    float tx = following.x - backward.x, ty = following.y - backward.y, tz = following.z - backward.z;
                    float tl = (float)System.Math.Sqrt(tz * tz + (tx * tx + ty * ty));
                    nextTangent = tl > 1e-5f ? new Vector3(tx / tl, ty / tl, tz / tl) : Vector3.zero;
                }
                else
                {
                    Vector3 endAgain = path[unchecked(i + 1)];
                    Vector3 startAgain = path[i];
                    float tx = endAgain.x - startAgain.x, ty = endAgain.y - startAgain.y, tz = endAgain.z - startAgain.z;
                    float tl = (float)System.Math.Sqrt(tz * tz + (tx * tx + ty * ty));
                    nextTangent = tl > 1e-5f ? new Vector3(tx / tl, ty / tl, tz / tl) : Vector3.zero;
                }
                float dx = a.x - b.x, dy = a.y - b.y, dz = a.z - b.z;
                float curveFactor = factor;
                float length = (float)System.Math.Sqrt(dz * dz + (dx * dx + dy * dy));
                Vector3 p0 = path[i];
                Vector3 p1 = path[unchecked(i + 1)];
                if (length >= 0f)
                {
                    float inverseLength = 1f / length;
                    Vector3 tangent1 = new Vector3((previousTangent.x * length) * curveFactor, (previousTangent.y * length) * curveFactor, (previousTangent.z * length) * curveFactor);
                    Vector3 tangent2 = new Vector3((length * nextTangent.x) * curveFactor, (length * nextTangent.y) * curveFactor, (length * nextTangent.z) * curveFactor);
                    float distance = 0f;
                    do
                    {
                        result.Add(GetPointOnCubic(p0, p1, tangent1, tangent2, inverseLength * distance));
                        distance += maxSegmentLength;
                    } while (distance <= length);
                }
                previousTangent = nextTangent;
            }
            int lastResultIndex = unchecked(result.Count - 1);
            result[lastResultIndex] = path[unchecked(path.Count - 1)];
            return result;
        }

		[Token(Token = "0x60009C6")]
		[Address(RVA = "0x4558E6C", Offset = "0x4554E6C", VA = "0x4558E6C")]
		public static Vector3 GetPointOnCubic(Vector3 a, Vector3 b, Vector3 tan1, Vector3 tan2, float t)
		{
            // Original ARM64 Hermite polynomial; t is deliberately not clamped.
            float t2 = t * t;
            float t3 = t2 * t;
            float threeT2 = t2 * 3f;
            float twoT2 = t2 + t2;
            float twoT3 = t3 + t3;
            float bWeight = threeT2 - twoT3;
            float aWeight = (twoT3 - threeT2) + 1f;
            float tangent1Weight = (t3 - twoT2) + t;
            float tangent2Weight = t3 - t2;
            return new Vector3(
                tan2.x * tangent2Weight + (tan1.x * tangent1Weight + (b.x * bWeight + a.x * aWeight)),
                tan2.y * tangent2Weight + (tan1.y * tangent1Weight + (b.y * bWeight + a.y * aWeight)),
                tan2.z * tangent2Weight + (tan1.z * tangent1Weight + (b.z * bWeight + a.z * aWeight)));
        }

		[Token(Token = "0x60009C7")]
		[Address(RVA = "0x4557D58", Offset = "0x4553D58", VA = "0x4557D58")]
		public List<Vector3> SmoothOffsetSimple(List<Vector3> path)
		{
            int count = path.Count;
            if (count < 3 || iterations < 1) return path;
            if (iterations >= 13)
            {
                Debug.LogWarning("A very high iteration count was passed, won't let this one through");
                return path;
            }
            int capacity = unchecked((int)(float)System.Math.Pow(2.0, iterations) * (count - 2) + 2);
            List<Vector3> current = Pathfinding.Pooling.ListPool<Vector3>.Claim(capacity);
            List<Vector3> spare = Pathfinding.Pooling.ListPool<Vector3>.Claim(capacity);
            for (int i = 0; i < capacity; i = unchecked(i + 1))
            {
                current.Add(Vector3.zero);
                spare.Add(Vector3.zero);
            }
            for (int i = 0; i < path.Count; i = unchecked(i + 1)) current[i] = path[i];
            for (int pass = 0; pass < iterations; pass = unchecked(pass + 1))
            {
                int segments = unchecked((int)(float)System.Math.Pow(2.0, pass) * (path.Count - 2) + 1);
                for (int j = 0; j < segments; j = unchecked(j + 1))
                {
                    Vector3 a = current[j];
                    Vector3 b = current[unchecked(j + 1)];
                    Vector3 up = Vector3.up;
                    float dx = b.x - a.x;
                    float dy = b.y - a.y;
                    float dz = b.z - a.z;
                    float nx = dy * up.z - dz * up.y;
                    float ny = dz * up.x - dx * up.z;
                    float nz = dx * up.y - dy * up.x;
                    float length = (float)System.Math.Sqrt(nz * nz + (nx * nx + ny * ny));
                    Vector3 normal = length > 1e-5f ? new Vector3(nx / length, ny / length, nz / length) : Vector3.zero;
                    bool previousNeedsOffset = false;
                    bool previousRight = false;
                    if (j != 0 && !VectorMath.IsColinearXZ(a, b, current[unchecked(j - 1)]))
                    {
                        previousRight = VectorMath.RightOrColinearXZ(a, b, current[unchecked(j - 1)]);
                        previousNeedsOffset = true;
                    }
                    bool nextColinear = VectorMath.IsColinearXZ(a, b, current[unchecked(j + 2)]);
                    bool nextRight = false;
                    if (!nextColinear) nextRight = VectorMath.RightOrColinearXZ(a, b, current[unchecked(j + 2)]);
                    if (!previousNeedsOffset) spare[unchecked(j * 2)] = a;
                    else
                    {
                        float amount = offset;
                        Vector3 shift = previousRight ? new Vector3(normal.x * amount, normal.y * amount, normal.z * amount) : new Vector3(amount * -normal.x, amount * -normal.y, amount * -normal.z);
                        spare[unchecked(j * 2)] = new Vector3(a.x + shift.x, a.y + shift.y, a.z + shift.z);
                    }
                    if (nextColinear) spare[unchecked(j * 2 + 1)] = b;
                    else
                    {
                        float amount = offset;
                        Vector3 shift = nextRight ? new Vector3(normal.x * amount, normal.y * amount, normal.z * amount) : new Vector3(amount * -normal.x, amount * -normal.y, amount * -normal.z);
                        spare[unchecked(j * 2 + 1)] = new Vector3(b.x + shift.x, b.y + shift.y, b.z + shift.z);
                    }
                }
                int lastIndex = unchecked((int)(float)System.Math.Pow(2.0, unchecked(pass + 1)) * (path.Count - 2) + 1);
                spare[lastIndex] = current[segments];
                List<Vector3> old = current;
                current = spare;
                spare = old;
            }
            Pathfinding.Pooling.ListPool<Vector3>.Release(ref spare);
            return current;
        }

		[Token(Token = "0x60009C8")]
		[Address(RVA = "0x4557360", Offset = "0x4553360", VA = "0x4557360")]
		public List<Vector3> SmoothSimple(List<Vector3> path)
		{
            int inputCount = path.Count;
            if (inputCount < 2) return path;
            List<Vector3> result;
            if (uniformLength)
            {
                maxSegmentLength = maxSegmentLength > 0.005f ? maxSegmentLength : 0.005f;
                float total = 0f;
                for (int i = 0; i < unchecked(path.Count - 1); i = unchecked(i + 1))
                {
                    Vector3 a = path[i];
                    Vector3 b = path[unchecked(i + 1)];
                    float dx = a.x - b.x;
                    float dy = a.y - b.y;
                    float dz = a.z - b.z;
                    total += (float)System.Math.Sqrt(dz * dz + (dx * dx + dy * dy));
                }
                float ratio = total / maxSegmentLength;
                float floor = (float)System.Math.Floor(ratio);
                int whole;
                if (float.IsNaN(ratio)) whole = 0;
                else if (ratio >= 2147483648f) whole = int.MaxValue;
                else if (ratio <= -2147483648f) whole = int.MinValue;
                else whole = (int)floor;
                int capacity = float.IsPositiveInfinity(floor) ? unchecked(int.MinValue + 2) : unchecked(whole + 2);
                result = Pathfinding.Pooling.ListPool<Vector3>.Claim(capacity);
                float distance = 0f;
                for (int i = 0; i < unchecked(path.Count - 1); i = unchecked(i + 1))
                {
                    Vector3 start = path[i];
                    Vector3 end = path[unchecked(i + 1)];
                    float dx = start.x - end.x;
                    float dy = start.y - end.y;
                    float dz = start.z - end.z;
                    float length = (float)System.Math.Sqrt(dz * dz + (dx * dx + dy * dy));
                    while (distance < length)
                    {
                        float t = distance / length;
                        if (t > 1f) t = 1f;
                        if (t < 0f) t = 0f;
                        result.Add(new Vector3(
                            start.x + (end.x - start.x) * t,
                            start.y + (end.y - start.y) * t,
                            start.z + (end.z - start.z) * t));
                        distance += maxSegmentLength;
                    }
                    distance -= length;
                }
                result.Add(path[unchecked(path.Count - 1)]);
            }
            else
            {
                int level = subdivisions;
                if (level < 0) level = 0;
                subdivisions = level;
                if (level > 10)
                {
                    Debug.LogWarning("Very large number of subdivisions. Cowardly refusing to subdivide every segment into more than " + (1 << level) + " subsegments");
                    subdivisions = 10;
                    level = 10;
                    inputCount = path.Count;
                }
                int segments = 1 << level;
                result = Pathfinding.Pooling.ListPool<Vector3>.Claim(unchecked(((inputCount - 1) << level) + 1));
                Polygon.Subdivide(path, result, segments);
            }
            if (!(strength > 0f) || iterations < 1) return result;
            for (int pass = 0; pass < iterations; pass = unchecked(pass + 1))
            {
                Vector3 previous = result[0];
                for (int i = 1; i < unchecked(result.Count - 1); i = unchecked(i + 1))
                {
                    Vector3 current = result[i];
                    Vector3 next = result[unchecked(i + 1)];
                    float t = strength;
                    if (t > 1f) t = 1f;
                    if (t < 0f) t = 0f;
                    result[i] = new Vector3(
                        current.x + ((previous.x + next.x) * 0.5f - current.x) * t,
                        current.y + ((previous.y + next.y) * 0.5f - current.y) * t,
                        current.z + ((previous.z + next.z) * 0.5f - current.z) * t);
                    previous = current;
                }
            }
            return result;
        }

		[Token(Token = "0x60009C9")]
		[Address(RVA = "0x45579CC", Offset = "0x45539CC", VA = "0x45579CC")]
		public List<Vector3> SmoothBezier(List<Vector3> path)
		{
            if (subdivisions < 0) subdivisions = 0;
            var result = Pathfinding.Pooling.ListPool<Vector3>.Claim();
            int samples = 1 << subdivisions;
            float denominator = (float)samples;
            for (int i = 0; i < unchecked(path.Count - 1); i = unchecked(i + 1))
            {
                Vector3 next = path[unchecked(i + 1)];
                Vector3 previous = path[i == 0 ? 0 : unchecked(i - 1)];
                int lastSegment = unchecked(path.Count - 2);
                Vector3 current = path[i];
                Vector3 after = path[i == lastSegment ? unchecked(i + 1) : unchecked(i + 2)];
                float tangent = bezierTangentLength;
                Vector3 p0 = path[i];
                Vector3 p3 = path[unchecked(i + 1)];
                Vector3 p1 = new Vector3(
                    p0.x + (next.x - previous.x) * tangent,
                    p0.y + (next.y - previous.y) * tangent,
                    p0.z + (next.z - previous.z) * tangent);
                Vector3 p2 = new Vector3(
                    p3.x + (current.x - after.x) * tangent,
                    p3.y + (current.y - after.y) * tangent,
                    p3.z + (current.z - after.z) * tangent);
                for (int j = 0; j < samples; j = unchecked(j + 1))
                    result.Add(AstarSplines.CubicBezier(p0, p1, p2, p3, (float)j / denominator));
            }
            result.Add(path[unchecked(path.Count - 1)]);
            return result;
        }

		[Token(Token = "0x60009CA")]
		[Address(RVA = "0x4558F0C", Offset = "0x4554F0C", VA = "0x4558F0C")]
		public SimpleSmoothModifier()
		{
		}
	}
}
