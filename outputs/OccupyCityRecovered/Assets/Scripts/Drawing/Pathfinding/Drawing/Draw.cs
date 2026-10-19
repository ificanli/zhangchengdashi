using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;

namespace Pathfinding.Drawing
{
	[Token(Token = "0x2000028")]
	public static class Draw
	{
		[Token(Token = "0x4000081")]
		[FieldOffset(Offset = "0x0")]
		internal static CommandBuilder builder;

		[Token(Token = "0x4000082")]
		[FieldOffset(Offset = "0x18")]
		internal static CommandBuilder ingame_builder;

		[Token(Token = "0x17000005")]
		public unsafe static ref CommandBuilder ingame
		{
			[Token(Token = "0x6000159")]
			[Address(RVA = "0x46DE08C", Offset = "0x46DA08C", VA = "0x46DE08C")]
			get
			{
				return ref *(CommandBuilder*)null;
			}
		}

		[Token(Token = "0x17000006")]
		public unsafe static ref CommandBuilder editor
		{
			[Token(Token = "0x600015A")]
			[Address(RVA = "0x46DE100", Offset = "0x46DA100", VA = "0x46DE100")]
			get
			{
				return ref *(CommandBuilder*)null;
			}
		}

		[Token(Token = "0x17000007")]
		public static CommandBuilder2D xy
		{
			[Token(Token = "0x600015B")]
			[Address(RVA = "0x46DE170", Offset = "0x46DA170", VA = "0x46DE170")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000008")]
		public static CommandBuilder2D xz
		{
			[Token(Token = "0x600015C")]
			[Address(RVA = "0x46DE1F8", Offset = "0x46DA1F8", VA = "0x46DE1F8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x46DE27C", Offset = "0x46DA27C", VA = "0x46DE27C")]
		[BurstDiscard]
		public static CommandBuilder.ScopeEmpty WithMatrix(Matrix4x4 matrix)
		{
			return default;
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x46DE284", Offset = "0x46DA284", VA = "0x46DE284")]
		[BurstDiscard]
		public static CommandBuilder.ScopeEmpty WithMatrix(float3x3 matrix)
		{
			return default;
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x46DE28C", Offset = "0x46DA28C", VA = "0x46DE28C")]
		[BurstDiscard]
		public static CommandBuilder.ScopeEmpty WithColor(Color color)
		{
			return default;
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x46DE294", Offset = "0x46DA294", VA = "0x46DE294")]
		[BurstDiscard]
		public static CommandBuilder.ScopeEmpty WithLineWidth(float pixels, bool automaticJoins = true)
		{
			return default;
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x46DE29C", Offset = "0x46DA29C", VA = "0x46DE29C")]
		[BurstDiscard]
		public static void PushMatrix(Matrix4x4 matrix)
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x46DE2A0", Offset = "0x46DA2A0", VA = "0x46DE2A0")]
		[BurstDiscard]
		public static void PushMatrix(float4x4 matrix)
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x46DE2A4", Offset = "0x46DA2A4", VA = "0x46DE2A4")]
		[BurstDiscard]
		public static void PopMatrix()
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x46DE2A8", Offset = "0x46DA2A8", VA = "0x46DE2A8")]
		[BurstDiscard]
		public static void Line(float3 a, float3 b)
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x46DE2AC", Offset = "0x46DA2AC", VA = "0x46DE2AC")]
		[BurstDiscard]
		public static void Line(Vector3 a, Vector3 b)
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x46DE2B0", Offset = "0x46DA2B0", VA = "0x46DE2B0")]
		[BurstDiscard]
		public static void Line(Vector3 a, Vector3 b, Color color)
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x46DE2B4", Offset = "0x46DA2B4", VA = "0x46DE2B4")]
		[BurstDiscard]
		public static void Ray(float3 origin, float3 direction)
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x46DE2B8", Offset = "0x46DA2B8", VA = "0x46DE2B8")]
		[BurstDiscard]
		public static void Ray(Ray ray, float length)
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x46DE2BC", Offset = "0x46DA2BC", VA = "0x46DE2BC")]
		[BurstDiscard]
		public static void Arc(float3 center, float3 start, float3 end)
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x46DE2C0", Offset = "0x46DA2C0", VA = "0x46DE2C0")]
		[Obsolete("Use Draw.xz.Circle instead")]
		[BurstDiscard]
		public static void CircleXZ(float3 center, float radius, float startAngle = 0f, float endAngle = (float)Math.PI * 2f)
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x46DE2C4", Offset = "0x46DA2C4", VA = "0x46DE2C4")]
		[BurstDiscard]
		public static void Circle(float3 center, float3 normal, float radius)
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x46DE2C8", Offset = "0x46DA2C8", VA = "0x46DE2C8")]
		[BurstDiscard]
		public static void WireCylinder(float3 bottom, float3 top, float radius)
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x46DE2CC", Offset = "0x46DA2CC", VA = "0x46DE2CC")]
		[BurstDiscard]
		public static void WireCylinder(float3 position, float3 up, float height, float radius)
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x46DE2D0", Offset = "0x46DA2D0", VA = "0x46DE2D0")]
		[BurstDiscard]
		public static void WireCapsule(float3 start, float3 end, float radius)
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x46DE2D4", Offset = "0x46DA2D4", VA = "0x46DE2D4")]
		[BurstDiscard]
		public static void WireCapsule(float3 position, float3 direction, float length, float radius)
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x46DE2D8", Offset = "0x46DA2D8", VA = "0x46DE2D8")]
		[BurstDiscard]
		public static void WireSphere(float3 position, float radius)
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x46DE2DC", Offset = "0x46DA2DC", VA = "0x46DE2DC")]
		[BurstDiscard]
		public static void Polyline(List<Vector3> points, bool cycle = false)
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x46DE2E0", Offset = "0x46DA2E0", VA = "0x46DE2E0")]
		[BurstDiscard]
		public static void Polyline(Vector3[] points, bool cycle = false)
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x46DE2E4", Offset = "0x46DA2E4", VA = "0x46DE2E4")]
		[BurstDiscard]
		public static void Polyline(float3[] points, bool cycle = false)
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x46DE2E8", Offset = "0x46DA2E8", VA = "0x46DE2E8")]
		[BurstDiscard]
		public static void Polyline(NativeArray<float3> points, bool cycle = false)
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x46DE2EC", Offset = "0x46DA2EC", VA = "0x46DE2EC")]
		[BurstDiscard]
		public static void WireBox(float3 center, float3 size)
		{
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x46DE2F0", Offset = "0x46DA2F0", VA = "0x46DE2F0")]
		[BurstDiscard]
		public static void WireBox(float3 center, quaternion rotation, float3 size)
		{
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x46DE2F4", Offset = "0x46DA2F4", VA = "0x46DE2F4")]
		[BurstDiscard]
		public static void WireBox(Bounds bounds)
		{
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x46DE2F8", Offset = "0x46DA2F8", VA = "0x46DE2F8")]
		[BurstDiscard]
		public static void WireMesh(Mesh mesh)
		{
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x46DE2FC", Offset = "0x46DA2FC", VA = "0x46DE2FC")]
		[BurstDiscard]
		public static void WireMesh(NativeArray<float3> vertices, NativeArray<int> triangles)
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x46DE300", Offset = "0x46DA300", VA = "0x46DE300")]
		[BurstDiscard]
		public static void Cross(float3 position, float size = 1f)
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x46DE304", Offset = "0x46DA304", VA = "0x46DE304")]
		[Obsolete("Use Draw.xz.Cross instead")]
		[BurstDiscard]
		public static void CrossXZ(float3 position, float size = 1f)
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x46DE308", Offset = "0x46DA308", VA = "0x46DE308")]
		[Obsolete("Use Draw.xy.Cross instead")]
		[BurstDiscard]
		public static void CrossXY(float3 position, float size = 1f)
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x46DE30C", Offset = "0x46DA30C", VA = "0x46DE30C")]
		[BurstDiscard]
		public static void Bezier(float3 p0, float3 p1, float3 p2, float3 p3)
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x46DE310", Offset = "0x46DA310", VA = "0x46DE310")]
		[BurstDiscard]
		public static void Arrow(float3 from, float3 to)
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x46DE314", Offset = "0x46DA314", VA = "0x46DE314")]
		[BurstDiscard]
		public static void Arrow(float3 from, float3 to, float3 up, float headSize)
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x46DE318", Offset = "0x46DA318", VA = "0x46DE318")]
		[BurstDiscard]
		public static void ArrowRelativeSizeHead(float3 from, float3 to, float3 up, float headFraction)
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x46DE31C", Offset = "0x46DA31C", VA = "0x46DE31C")]
		[BurstDiscard]
		public static void ArrowheadArc(float3 origin, float3 direction, float offset, float width = 60f)
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x46DE320", Offset = "0x46DA320", VA = "0x46DE320")]
		[BurstDiscard]
		public static void WireGrid(float3 center, quaternion rotation, int2 cells, float2 totalSize)
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x46DE324", Offset = "0x46DA324", VA = "0x46DE324")]
		[BurstDiscard]
		public static void WireRectangle(float3 center, quaternion rotation, float2 size)
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x46DE328", Offset = "0x46DA328", VA = "0x46DE328")]
		[BurstDiscard]
		[Obsolete("Use Draw.xy.WireRectangle instead")]
		public static void WireRectangle(Rect rect)
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x46DE32C", Offset = "0x46DA32C", VA = "0x46DE32C")]
		[BurstDiscard]
		public static void WirePlane(float3 center, float3 normal, float2 size)
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x46DE330", Offset = "0x46DA330", VA = "0x46DE330")]
		[BurstDiscard]
		public static void WirePlane(float3 center, quaternion rotation, float2 size)
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x46DE334", Offset = "0x46DA334", VA = "0x46DE334")]
		[BurstDiscard]
		public static void SolidBox(float3 center, float3 size)
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x46DE338", Offset = "0x46DA338", VA = "0x46DE338")]
		[BurstDiscard]
		public static void SolidBox(Bounds bounds)
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x46DE33C", Offset = "0x46DA33C", VA = "0x46DE33C")]
		[BurstDiscard]
		public static void SolidBox(float3 center, quaternion rotation, float3 size)
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x46DE340", Offset = "0x46DA340", VA = "0x46DE340")]
		[BurstDiscard]
		public static void Line(float3 a, float3 b, Color color)
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x46DE344", Offset = "0x46DA344", VA = "0x46DE344")]
		[BurstDiscard]
		public static void Ray(float3 origin, float3 direction, Color color)
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x46DE348", Offset = "0x46DA348", VA = "0x46DE348")]
		[BurstDiscard]
		public static void Ray(Ray ray, float length, Color color)
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x46DE34C", Offset = "0x46DA34C", VA = "0x46DE34C")]
		[BurstDiscard]
		public static void Arc(float3 center, float3 start, float3 end, Color color)
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x46DE350", Offset = "0x46DA350", VA = "0x46DE350")]
		[BurstDiscard]
		[Obsolete("Use Draw.xz.Circle instead")]
		public static void CircleXZ(float3 center, float radius, float startAngle, float endAngle, Color color)
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x46DE354", Offset = "0x46DA354", VA = "0x46DE354")]
		[BurstDiscard]
		[Obsolete("Use Draw.xz.Circle instead")]
		public static void CircleXZ(float3 center, float radius, Color color)
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x46DE358", Offset = "0x46DA358", VA = "0x46DE358")]
		[BurstDiscard]
		public static void Circle(float3 center, float3 normal, float radius, Color color)
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x46DE35C", Offset = "0x46DA35C", VA = "0x46DE35C")]
		[BurstDiscard]
		public static void WireCylinder(float3 bottom, float3 top, float radius, Color color)
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x46DE360", Offset = "0x46DA360", VA = "0x46DE360")]
		[BurstDiscard]
		public static void WireCylinder(float3 position, float3 up, float height, float radius, Color color)
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x46DE364", Offset = "0x46DA364", VA = "0x46DE364")]
		[BurstDiscard]
		public static void WireCapsule(float3 start, float3 end, float radius, Color color)
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x46DE368", Offset = "0x46DA368", VA = "0x46DE368")]
		[BurstDiscard]
		public static void WireCapsule(float3 position, float3 direction, float length, float radius, Color color)
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x46DE36C", Offset = "0x46DA36C", VA = "0x46DE36C")]
		[BurstDiscard]
		public static void WireSphere(float3 position, float radius, Color color)
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x46DE370", Offset = "0x46DA370", VA = "0x46DE370")]
		[BurstDiscard]
		public static void Polyline(List<Vector3> points, bool cycle, Color color)
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x46DE374", Offset = "0x46DA374", VA = "0x46DE374")]
		[BurstDiscard]
		public static void Polyline(List<Vector3> points, Color color)
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x46DE378", Offset = "0x46DA378", VA = "0x46DE378")]
		[BurstDiscard]
		public static void Polyline(Vector3[] points, bool cycle, Color color)
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x46DE37C", Offset = "0x46DA37C", VA = "0x46DE37C")]
		[BurstDiscard]
		public static void Polyline(Vector3[] points, Color color)
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x46DE380", Offset = "0x46DA380", VA = "0x46DE380")]
		[BurstDiscard]
		public static void Polyline(float3[] points, bool cycle, Color color)
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x46DE384", Offset = "0x46DA384", VA = "0x46DE384")]
		[BurstDiscard]
		public static void Polyline(float3[] points, Color color)
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x46DE388", Offset = "0x46DA388", VA = "0x46DE388")]
		[BurstDiscard]
		public static void Polyline(NativeArray<float3> points, bool cycle, Color color)
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x46DE38C", Offset = "0x46DA38C", VA = "0x46DE38C")]
		[BurstDiscard]
		public static void Polyline(NativeArray<float3> points, Color color)
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x46DE390", Offset = "0x46DA390", VA = "0x46DE390")]
		[BurstDiscard]
		public static void WireBox(float3 center, float3 size, Color color)
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x46DE394", Offset = "0x46DA394", VA = "0x46DE394")]
		[BurstDiscard]
		public static void WireBox(float3 center, quaternion rotation, float3 size, Color color)
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x46DE398", Offset = "0x46DA398", VA = "0x46DE398")]
		[BurstDiscard]
		public static void WireBox(Bounds bounds, Color color)
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x46DE39C", Offset = "0x46DA39C", VA = "0x46DE39C")]
		[BurstDiscard]
		public static void WireMesh(Mesh mesh, Color color)
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x46DE3A0", Offset = "0x46DA3A0", VA = "0x46DE3A0")]
		[BurstDiscard]
		public static void WireMesh(NativeArray<float3> vertices, NativeArray<int> triangles, Color color)
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x46DE3A4", Offset = "0x46DA3A4", VA = "0x46DE3A4")]
		[BurstDiscard]
		public static void Cross(float3 position, float size, Color color)
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x46DE3A8", Offset = "0x46DA3A8", VA = "0x46DE3A8")]
		[BurstDiscard]
		public static void Cross(float3 position, Color color)
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x46DE3AC", Offset = "0x46DA3AC", VA = "0x46DE3AC")]
		[BurstDiscard]
		[Obsolete("Use Draw.xz.Cross instead")]
		public static void CrossXZ(float3 position, float size, Color color)
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x46DE3B0", Offset = "0x46DA3B0", VA = "0x46DE3B0")]
		[BurstDiscard]
		[Obsolete("Use Draw.xz.Cross instead")]
		public static void CrossXZ(float3 position, Color color)
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x46DE3B4", Offset = "0x46DA3B4", VA = "0x46DE3B4")]
		[BurstDiscard]
		[Obsolete("Use Draw.xy.Cross instead")]
		public static void CrossXY(float3 position, float size, Color color)
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x46DE3B8", Offset = "0x46DA3B8", VA = "0x46DE3B8")]
		[BurstDiscard]
		[Obsolete("Use Draw.xy.Cross instead")]
		public static void CrossXY(float3 position, Color color)
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x46DE3BC", Offset = "0x46DA3BC", VA = "0x46DE3BC")]
		[BurstDiscard]
		public static void Bezier(float3 p0, float3 p1, float3 p2, float3 p3, Color color)
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x46DE3C0", Offset = "0x46DA3C0", VA = "0x46DE3C0")]
		[BurstDiscard]
		public static void Arrow(float3 from, float3 to, Color color)
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x46DE3C4", Offset = "0x46DA3C4", VA = "0x46DE3C4")]
		[BurstDiscard]
		public static void Arrow(float3 from, float3 to, float3 up, float headSize, Color color)
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x46DE3C8", Offset = "0x46DA3C8", VA = "0x46DE3C8")]
		[BurstDiscard]
		public static void ArrowRelativeSizeHead(float3 from, float3 to, float3 up, float headFraction, Color color)
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x46DE3CC", Offset = "0x46DA3CC", VA = "0x46DE3CC")]
		[BurstDiscard]
		public static void ArrowheadArc(float3 origin, float3 direction, float offset, float width, Color color)
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x46DE3D0", Offset = "0x46DA3D0", VA = "0x46DE3D0")]
		[BurstDiscard]
		public static void ArrowheadArc(float3 origin, float3 direction, float offset, Color color)
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x46DE3D4", Offset = "0x46DA3D4", VA = "0x46DE3D4")]
		[BurstDiscard]
		public static void WireGrid(float3 center, quaternion rotation, int2 cells, float2 totalSize, Color color)
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x46DE3D8", Offset = "0x46DA3D8", VA = "0x46DE3D8")]
		[BurstDiscard]
		public static void WireRectangle(float3 center, quaternion rotation, float2 size, Color color)
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x46DE3DC", Offset = "0x46DA3DC", VA = "0x46DE3DC")]
		[BurstDiscard]
		[Obsolete("Use Draw.xy.WireRectangle instead")]
		public static void WireRectangle(Rect rect, Color color)
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x46DE3E0", Offset = "0x46DA3E0", VA = "0x46DE3E0")]
		[BurstDiscard]
		public static void WirePlane(float3 center, float3 normal, float2 size, Color color)
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x46DE3E4", Offset = "0x46DA3E4", VA = "0x46DE3E4")]
		[BurstDiscard]
		public static void WirePlane(float3 center, quaternion rotation, float2 size, Color color)
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x46DE3E8", Offset = "0x46DA3E8", VA = "0x46DE3E8")]
		[BurstDiscard]
		public static void SolidBox(float3 center, float3 size, Color color)
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x46DE3EC", Offset = "0x46DA3EC", VA = "0x46DE3EC")]
		[BurstDiscard]
		public static void SolidBox(Bounds bounds, Color color)
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x46DE3F0", Offset = "0x46DA3F0", VA = "0x46DE3F0")]
		[BurstDiscard]
		public static void SolidBox(float3 center, quaternion rotation, float3 size, Color color)
		{
		}
	}
}
