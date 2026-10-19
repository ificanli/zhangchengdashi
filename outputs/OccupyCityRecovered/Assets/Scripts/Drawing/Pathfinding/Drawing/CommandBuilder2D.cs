using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;

namespace Pathfinding.Drawing
{
	[Token(Token = "0x2000027")]
	public struct CommandBuilder2D
	{
		[Token(Token = "0x400007A")]
		[FieldOffset(Offset = "0x0")]
		private CommandBuilder draw;

		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x18")]
		private bool xy;

		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x0")]
		private static readonly float3 XY_UP;

		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0xC")]
		private static readonly float3 XZ_UP;

		[Token(Token = "0x400007E")]
		[FieldOffset(Offset = "0x18")]
		private static readonly quaternion XY_TO_XZ_ROTATION;

		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0x28")]
		private static readonly quaternion XZ_TO_XZ_ROTATION;

		[Token(Token = "0x4000080")]
		[FieldOffset(Offset = "0x38")]
		private static readonly float4x4 XZ_TO_XY_MATRIX;

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x46C6ECC", Offset = "0x46C2ECC", VA = "0x46C6ECC")]
		public CommandBuilder2D(CommandBuilder draw, bool xy)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED CommandBuilder2D..ctor RVA=0x46C6ECC Token=0x60000F1");
}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x46D79A4", Offset = "0x46D39A4", VA = "0x46D79A4")]
		public void Line(float2 a, float2 b)
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x46D7A90", Offset = "0x46D3A90", VA = "0x46D7A90")]
		public void Line(float2 a, float2 b, Color color)
		{
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x46D7BC4", Offset = "0x46D3BC4", VA = "0x46D7BC4")]
		public void Line(float3 a, float3 b)
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x46D7C60", Offset = "0x46D3C60", VA = "0x46D7C60")]
		public void Circle(float2 center, float radius, float startAngle = 0f, float endAngle = (float)Math.PI * 2f)
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x46D7D04", Offset = "0x46D3D04", VA = "0x46D7D04")]
		public void Circle(float3 center, float radius, float startAngle = 0f, float endAngle = (float)Math.PI * 2f)
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x46D7E60", Offset = "0x46D3E60", VA = "0x46D7E60")]
		public void SolidCircle(float2 center, float radius, float startAngle = 0f, float endAngle = (float)Math.PI * 2f)
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x46D7F04", Offset = "0x46D3F04", VA = "0x46D7F04")]
		public void SolidCircle(float3 center, float radius, float startAngle = 0f, float endAngle = (float)Math.PI * 2f)
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x46D8080", Offset = "0x46D4080", VA = "0x46D8080")]
		public void WirePill(float2 a, float2 b, float radius)
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x46D8164", Offset = "0x46D4164", VA = "0x46D8164")]
		public void WirePill(float2 position, float2 direction, float length, float radius)
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x46D84F4", Offset = "0x46D44F4", VA = "0x46D84F4")]
		[BurstDiscard]
		public void Polyline(List<Vector2> points, bool cycle = false)
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x46D8714", Offset = "0x46D4714", VA = "0x46D8714")]
		[BurstDiscard]
		public void Polyline(Vector2[] points, bool cycle = false)
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x46D888C", Offset = "0x46D488C", VA = "0x46D888C")]
		[BurstDiscard]
		public void Polyline(float2[] points, bool cycle = false)
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x46D8A04", Offset = "0x46D4A04", VA = "0x46D8A04")]
		public void Polyline(NativeArray<float2> points, bool cycle = false)
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x46D8B24", Offset = "0x46D4B24", VA = "0x46D8B24")]
		public void Cross(float2 position, float size = 1f)
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x46D8BC8", Offset = "0x46D4BC8", VA = "0x46D8BC8")]
		public void WireRectangle(float3 center, float2 size)
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x46CEDE8", Offset = "0x46CADE8", VA = "0x46CEDE8")]
		public void WireRectangle(Rect rect)
		{
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x46CF438", Offset = "0x46CB438", VA = "0x46CF438")]
		public void SolidRectangle(Rect rect)
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x46D8CF8", Offset = "0x46D4CF8", VA = "0x46D8CF8")]
		public void WireGrid(float2 center, int2 cells, float2 totalSize)
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x46D8E34", Offset = "0x46D4E34", VA = "0x46D8E34")]
		public void WireGrid(float3 center, int2 cells, float2 totalSize)
		{
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x46D8F6C", Offset = "0x46D4F6C", VA = "0x46D8F6C")]
		[BurstDiscard]
		public CommandBuilder.ScopeMatrix WithMatrix(Matrix4x4 matrix)
		{
			return default;
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x46D9014", Offset = "0x46D5014", VA = "0x46D9014")]
		[BurstDiscard]
		public CommandBuilder.ScopeMatrix WithMatrix(float3x3 matrix)
		{
			return default;
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x46D90BC", Offset = "0x46D50BC", VA = "0x46D90BC")]
		[BurstDiscard]
		public CommandBuilder.ScopeColor WithColor(Color color)
		{
			return default;
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x46D916C", Offset = "0x46D516C", VA = "0x46D916C")]
		[BurstDiscard]
		public CommandBuilder.ScopeLineWidth WithLineWidth(float pixels, bool automaticJoins = true)
		{
			return default;
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x46D9204", Offset = "0x46D5204", VA = "0x46D9204")]
		public void PushMatrix(Matrix4x4 matrix)
		{
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x46D9294", Offset = "0x46D5294", VA = "0x46D9294")]
		public void PushMatrix(float4x4 matrix)
		{
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x46D9324", Offset = "0x46D5324", VA = "0x46D9324")]
		public void PopMatrix()
		{
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x46D9378", Offset = "0x46D5378", VA = "0x46D9378")]
		public void Line(Vector3 a, Vector3 b)
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x46D867C", Offset = "0x46D467C", VA = "0x46D867C")]
		public void Line(Vector2 a, Vector2 b)
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x46D9414", Offset = "0x46D5414", VA = "0x46D9414")]
		public void Line(Vector3 a, Vector3 b, Color color)
		{
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x46D9510", Offset = "0x46D5510", VA = "0x46D9510")]
		public void Line(Vector2 a, Vector2 b, Color color)
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x46D95DC", Offset = "0x46D55DC", VA = "0x46D95DC")]
		public void Ray(float3 origin, float3 direction)
		{
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x46D9678", Offset = "0x46D5678", VA = "0x46D9678")]
		public void Ray(float2 origin, float2 direction)
		{
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x46D9710", Offset = "0x46D5710", VA = "0x46D9710")]
		public void Ray(Ray ray, float length)
		{
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x46D97B0", Offset = "0x46D57B0", VA = "0x46D97B0")]
		public void Arc(float3 center, float3 start, float3 end)
		{
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x46D98AC", Offset = "0x46D58AC", VA = "0x46D98AC")]
		public void Arc(float2 center, float2 start, float2 end)
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x46D9970", Offset = "0x46D5970", VA = "0x46D9970")]
		[BurstDiscard]
		public void Polyline(List<Vector3> points, bool cycle = false)
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x46D99DC", Offset = "0x46D59DC", VA = "0x46D99DC")]
		[BurstDiscard]
		public void Polyline(Vector3[] points, bool cycle = false)
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x46D9A48", Offset = "0x46D5A48", VA = "0x46D9A48")]
		[BurstDiscard]
		public void Polyline(float3[] points, bool cycle = false)
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x46D9AB4", Offset = "0x46D5AB4", VA = "0x46D9AB4")]
		public void Polyline(NativeArray<float3> points, bool cycle = false)
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x46D9B30", Offset = "0x46D5B30", VA = "0x46D9B30")]
		public void Cross(float3 position, float size = 1f)
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x46D9BB4", Offset = "0x46D5BB4", VA = "0x46D9BB4")]
		public void Bezier(float3 p0, float3 p1, float3 p2, float3 p3)
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x46D9CC0", Offset = "0x46D5CC0", VA = "0x46D9CC0")]
		public void Bezier(float2 p0, float2 p1, float2 p2, float2 p3)
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x46D9DA4", Offset = "0x46D5DA4", VA = "0x46D9DA4")]
		public void Arrow(float3 from, float3 to)
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x46D9FB4", Offset = "0x46D5FB4", VA = "0x46D9FB4")]
		public void Arrow(float2 from, float2 to)
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x46DA04C", Offset = "0x46D604C", VA = "0x46DA04C")]
		public void Arrow(float3 from, float3 to, float3 up, float headSize)
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x46DA150", Offset = "0x46D6150", VA = "0x46DA150")]
		public void Arrow(float2 from, float2 to, float2 up, float headSize)
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x46D9EB0", Offset = "0x46D5EB0", VA = "0x46D9EB0")]
		public void ArrowRelativeSizeHead(float3 from, float3 to, float3 up, float headFraction)
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x46DA224", Offset = "0x46D6224", VA = "0x46DA224")]
		public void ArrowRelativeSizeHead(float2 from, float2 to, float2 up, float headFraction)
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x46DA2F8", Offset = "0x46D62F8", VA = "0x46DA2F8")]
		public void ArrowheadArc(float3 origin, float3 direction, float offset, float width = 60f)
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x46DA758", Offset = "0x46D6758", VA = "0x46DA758")]
		public void ArrowheadArc(float2 origin, float2 direction, float offset, float width = 60f)
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x46DA808", Offset = "0x46D6808", VA = "0x46DA808")]
		public void WireRectangle(float3 center, quaternion rotation, float2 size)
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x46DA90C", Offset = "0x46D690C", VA = "0x46DA90C")]
		public void WireRectangle(float2 center, quaternion rotation, float2 size)
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x46DA9D8", Offset = "0x46D69D8", VA = "0x46DA9D8")]
		public void Ray(float3 origin, float3 direction, Color color)
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x46DAAD4", Offset = "0x46D6AD4", VA = "0x46DAAD4")]
		public void Ray(float2 origin, float2 direction, Color color)
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x46DABA0", Offset = "0x46D6BA0", VA = "0x46DABA0")]
		public void Ray(Ray ray, float length, Color color)
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x46DAC70", Offset = "0x46D6C70", VA = "0x46DAC70")]
		public void Arc(float3 center, float3 start, float3 end, Color color)
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x46DAD94", Offset = "0x46D6D94", VA = "0x46DAD94")]
		public void Arc(float2 center, float2 start, float2 end, Color color)
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x46DAE88", Offset = "0x46D6E88", VA = "0x46DAE88")]
		[BurstDiscard]
		public void Polyline(List<Vector3> points, bool cycle, Color color)
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x46DAF24", Offset = "0x46D6F24", VA = "0x46DAF24")]
		[BurstDiscard]
		public void Polyline(List<Vector3> points, Color color)
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x46DAFBC", Offset = "0x46D6FBC", VA = "0x46DAFBC")]
		[BurstDiscard]
		public void Polyline(Vector3[] points, bool cycle, Color color)
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x46DB058", Offset = "0x46D7058", VA = "0x46DB058")]
		[BurstDiscard]
		public void Polyline(Vector3[] points, Color color)
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x46DB0F0", Offset = "0x46D70F0", VA = "0x46DB0F0")]
		[BurstDiscard]
		public void Polyline(float3[] points, bool cycle, Color color)
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x46DB18C", Offset = "0x46D718C", VA = "0x46DB18C")]
		[BurstDiscard]
		public void Polyline(float3[] points, Color color)
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x46DB224", Offset = "0x46D7224", VA = "0x46DB224")]
		public void Polyline(NativeArray<float3> points, bool cycle, Color color)
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x46DB2D0", Offset = "0x46D72D0", VA = "0x46DB2D0")]
		public void Polyline(NativeArray<float3> points, Color color)
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x46DB370", Offset = "0x46D7370", VA = "0x46DB370")]
		public void Cross(float3 position, float size, Color color)
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x46DB424", Offset = "0x46D7424", VA = "0x46DB424")]
		public void Cross(float3 position, Color color)
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x46DB4D4", Offset = "0x46D74D4", VA = "0x46DB4D4")]
		public void Bezier(float3 p0, float3 p1, float3 p2, float3 p3, Color color)
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x46DB5F8", Offset = "0x46D75F8", VA = "0x46DB5F8")]
		public void Bezier(float2 p0, float2 p1, float2 p2, float2 p3, Color color)
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x46DB710", Offset = "0x46D7710", VA = "0x46DB710")]
		public void Arrow(float3 from, float3 to, Color color)
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x46DB948", Offset = "0x46D7948", VA = "0x46DB948")]
		public void Arrow(float2 from, float2 to, Color color)
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x46DBA14", Offset = "0x46D7A14", VA = "0x46DBA14")]
		public void Arrow(float3 from, float3 to, float3 up, float headSize, Color color)
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x46DBB40", Offset = "0x46D7B40", VA = "0x46DBB40")]
		public void Arrow(float2 from, float2 to, float2 up, float headSize, Color color)
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x46DB81C", Offset = "0x46D781C", VA = "0x46DB81C")]
		public void ArrowRelativeSizeHead(float3 from, float3 to, float3 up, float headFraction, Color color)
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x46DBC48", Offset = "0x46D7C48", VA = "0x46DBC48")]
		public void ArrowRelativeSizeHead(float2 from, float2 to, float2 up, float headFraction, Color color)
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x46DBD50", Offset = "0x46D7D50", VA = "0x46DBD50")]
		public void ArrowheadArc(float3 origin, float3 direction, float offset, float width, Color color)
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x46DC1FC", Offset = "0x46D81FC", VA = "0x46DC1FC")]
		public void ArrowheadArc(float3 origin, float3 direction, float offset, Color color)
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x46DC310", Offset = "0x46D8310", VA = "0x46DC310")]
		public void ArrowheadArc(float2 origin, float2 direction, float offset, float width, Color color)
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x46DC3F8", Offset = "0x46D83F8", VA = "0x46DC3F8")]
		public void ArrowheadArc(float2 origin, float2 direction, float offset, Color color)
		{
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x46DC4EC", Offset = "0x46D84EC", VA = "0x46DC4EC")]
		public void WireRectangle(float3 center, quaternion rotation, float2 size, Color color)
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x46DC610", Offset = "0x46D8610", VA = "0x46DC610")]
		public void WireRectangle(float2 center, quaternion rotation, float2 size, Color color)
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x46DC724", Offset = "0x46D8724", VA = "0x46DC724")]
		public void Line(float3 a, float3 b, Color color)
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x46DC820", Offset = "0x46D8820", VA = "0x46DC820")]
		public void Circle(float2 center, float radius, float startAngle, float endAngle, Color color)
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x46DCA88", Offset = "0x46D8A88", VA = "0x46DCA88")]
		public void Circle(float2 center, float radius, Color color)
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x46DC8FC", Offset = "0x46D88FC", VA = "0x46DC8FC")]
		public void Circle(float3 center, float radius, float startAngle, float endAngle, Color color)
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x46DCB44", Offset = "0x46D8B44", VA = "0x46DCB44")]
		public void Circle(float3 center, float radius, Color color)
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x46DCC08", Offset = "0x46D8C08", VA = "0x46DCC08")]
		public void WirePill(float2 a, float2 b, float radius, Color color)
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x46DCD04", Offset = "0x46D8D04", VA = "0x46DCD04")]
		public void WirePill(float2 position, float2 direction, float length, float radius, Color color)
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x46DD0B0", Offset = "0x46D90B0", VA = "0x46DD0B0")]
		[BurstDiscard]
		public void Polyline(List<Vector2> points, bool cycle, Color color)
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x46DD280", Offset = "0x46D9280", VA = "0x46DD280")]
		[BurstDiscard]
		public void Polyline(List<Vector2> points, Color color)
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x46DD318", Offset = "0x46D9318", VA = "0x46DD318")]
		[BurstDiscard]
		public void Polyline(Vector2[] points, bool cycle, Color color)
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x46DD4D4", Offset = "0x46D94D4", VA = "0x46DD4D4")]
		[BurstDiscard]
		public void Polyline(Vector2[] points, Color color)
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x46DD56C", Offset = "0x46D956C", VA = "0x46DD56C")]
		[BurstDiscard]
		public void Polyline(float2[] points, bool cycle, Color color)
		{
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x46DD728", Offset = "0x46D9728", VA = "0x46DD728")]
		[BurstDiscard]
		public void Polyline(float2[] points, Color color)
		{
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x46DD7C0", Offset = "0x46D97C0", VA = "0x46DD7C0")]
		public void Polyline(NativeArray<float2> points, bool cycle, Color color)
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x46DD924", Offset = "0x46D9924", VA = "0x46DD924")]
		public void Polyline(NativeArray<float2> points, Color color)
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x46DD9C4", Offset = "0x46D99C4", VA = "0x46DD9C4")]
		public void Cross(float2 position, float size, Color color)
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x46DDACC", Offset = "0x46D9ACC", VA = "0x46DDACC")]
		public void Cross(float2 position, Color color)
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x46DDB6C", Offset = "0x46D9B6C", VA = "0x46DDB6C")]
		public void WireRectangle(float3 center, float2 size, Color color)
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x46D5C68", Offset = "0x46D1C68", VA = "0x46D5C68")]
		public void WireRectangle(Rect rect, Color color)
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x46DDCA8", Offset = "0x46D9CA8", VA = "0x46DDCA8")]
		public void WireGrid(float2 center, int2 cells, float2 totalSize, Color color)
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x46DDE00", Offset = "0x46D9E00", VA = "0x46DDE00")]
		public void WireGrid(float3 center, int2 cells, float2 totalSize, Color color)
		{
		}
	}
}
