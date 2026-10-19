using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Pathfinding.Drawing.Text;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;

namespace Pathfinding.Drawing
{
	[Token(Token = "0x2000050")]
	[BurstCompile(FloatMode = FloatMode.Default)]
	internal struct GeometryBuilderJob : IJob
	{
		[Token(Token = "0x2000051")]
		public struct Vertex
		{
			[Token(Token = "0x4000150")]
			[FieldOffset(Offset = "0x0")]
			public float3 position;

			[Token(Token = "0x4000151")]
			[FieldOffset(Offset = "0xC")]
			public float3 uv2;

			[Token(Token = "0x4000152")]
			[FieldOffset(Offset = "0x18")]
			public Color32 color;

			[Token(Token = "0x4000153")]
			[FieldOffset(Offset = "0x1C")]
			public float2 uv;
		}

		[Token(Token = "0x2000052")]
		public struct TextVertex
		{
			[Token(Token = "0x4000154")]
			[FieldOffset(Offset = "0x0")]
			public float3 position;

			[Token(Token = "0x4000155")]
			[FieldOffset(Offset = "0xC")]
			public Color32 color;

			[Token(Token = "0x4000156")]
			[FieldOffset(Offset = "0x10")]
			public float2 uv;
		}

		[Token(Token = "0x400013A")]
		[FieldOffset(Offset = "0x0")]
		[NativeDisableUnsafePtrRestriction]
		public unsafe DrawingData.ProcessedBuilderData.MeshBuffers* buffers;

		[Token(Token = "0x400013B")]
		[FieldOffset(Offset = "0x8")]
		[NativeDisableUnsafePtrRestriction]
		public unsafe SDFCharacter* characterInfo;

		[Token(Token = "0x400013C")]
		[FieldOffset(Offset = "0x10")]
		public int characterInfoLength;

		[Token(Token = "0x400013D")]
		[FieldOffset(Offset = "0x14")]
		public Color32 currentColor;

		[Token(Token = "0x400013E")]
		[FieldOffset(Offset = "0x18")]
		public float4x4 currentMatrix;

		[Token(Token = "0x400013F")]
		[FieldOffset(Offset = "0x58")]
		public CommandBuilder.LineWidthData currentLineWidthData;

		[Token(Token = "0x4000140")]
		[FieldOffset(Offset = "0x60")]
		public float lineWidthMultiplier;

		[Token(Token = "0x4000141")]
		[FieldOffset(Offset = "0x64")]
		private float3 minBounds;

		[Token(Token = "0x4000142")]
		[FieldOffset(Offset = "0x70")]
		private float3 maxBounds;

		[Token(Token = "0x4000143")]
		[FieldOffset(Offset = "0x7C")]
		public float3 cameraPosition;

		[Token(Token = "0x4000144")]
		[FieldOffset(Offset = "0x88")]
		public quaternion cameraRotation;

		[Token(Token = "0x4000145")]
		[FieldOffset(Offset = "0x98")]
		public float2 cameraDepthToPixelSize;

		[Token(Token = "0x4000146")]
		[FieldOffset(Offset = "0xA0")]
		public float maxPixelError;

		[Token(Token = "0x4000147")]
		[FieldOffset(Offset = "0xA4")]
		public bool cameraIsOrthographic;

		[Token(Token = "0x4000148")]
		[FieldOffset(Offset = "0xA8")]
		private float3 lastNormalizedLineDir;

		[Token(Token = "0x4000149")]
		[FieldOffset(Offset = "0xB4")]
		private float lastLineWidth;

		[Token(Token = "0x400014A")]
		public const float MaxCirclePixelError = 0.5f;

		[Token(Token = "0x400014B")]
		public const int VerticesPerCharacter = 4;

		[Token(Token = "0x400014C")]
		public const int TrianglesPerCharacter = 6;

		[Token(Token = "0x400014D")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly float4[] BoxVertices;

		[Token(Token = "0x400014E")]
		[FieldOffset(Offset = "0x8")]
		internal static readonly int[] BoxTriangles;

		[Token(Token = "0x400014F")]
		public const int MaxStackSize = 32;

		[Token(Token = "0x6000289")]
		private unsafe static void Add<T>(UnsafeAppendBuffer* buffer, T value) where T : struct
		{
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x46EA730", Offset = "0x46E6730", VA = "0x46EA730")]
		private unsafe static void Reserve(UnsafeAppendBuffer* buffer, int size)
		{
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x46EA76C", Offset = "0x46E676C", VA = "0x46EA76C")]
		internal static float3 PerspectiveDivide(float4 p)
		{
			return default;
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x46EA784", Offset = "0x46E6784", VA = "0x46EA784")]
		private unsafe void AddText(ushort* text, CommandBuilder.TextData textData, Color32 color)
		{
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x46EB25C", Offset = "0x46E725C", VA = "0x46EB25C")]
		private unsafe void AddText3D(ushort* text, CommandBuilder.TextData3D textData, Color32 color)
		{
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x46EA96C", Offset = "0x46E696C", VA = "0x46EA96C")]
		private unsafe void AddTextInternal(ushort* text, float3 pivot, float3 right, float3 up, LabelAlignment alignment, float size, bool sizeIsInPixels, int numCharacters, Color32 color)
		{
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x46EB45C", Offset = "0x46E745C", VA = "0x46EB45C")]
		private void AddLine(CommandBuilder.LineData line)
		{
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x46EBA70", Offset = "0x46E7A70", VA = "0x46EBA70")]
		internal static int CircleSteps(float3 center, float radius, float maxPixelError, ref float4x4 currentMatrix, float2 cameraDepthToPixelSize, float3 cameraPosition)
		{
			return default;
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x46EBDAC", Offset = "0x46E7DAC", VA = "0x46EBDAC")]
		private void AddCircle(CommandBuilder.CircleData circle)
		{
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x46ECD80", Offset = "0x46E8D80", VA = "0x46ECD80")]
		private void AddDisc(CommandBuilder.CircleData circle)
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x46ED3EC", Offset = "0x46E93EC", VA = "0x46ED3EC")]
		private void AddSphereOutline(CommandBuilder.SphereData circle)
		{
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x46EC0F8", Offset = "0x46E80F8", VA = "0x46EC0F8")]
		private void AddCircle(CommandBuilder.CircleXZData circle)
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x46ED894", Offset = "0x46E9894", VA = "0x46ED894")]
		private void AddDisc(CommandBuilder.CircleXZData circle)
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x46EDFB4", Offset = "0x46E9FB4", VA = "0x46EDFB4")]
		private void AddSolidTriangle(CommandBuilder.TriangleData triangle)
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x46EE59C", Offset = "0x46EA59C", VA = "0x46EE59C")]
		private void AddWireBox(CommandBuilder.BoxData box)
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x46EE77C", Offset = "0x46EA77C", VA = "0x46EE77C")]
		private void AddPlane(CommandBuilder.PlaneData plane)
		{
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x46EE994", Offset = "0x46EA994", VA = "0x46EE994")]
		private void AddBox(CommandBuilder.BoxData box)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600029A")]
		[Address(RVA = "0x46EEDA8", Offset = "0x46EADA8", VA = "0x46EEDA8")]
		public void Next(ref UnsafeAppendBuffer.Reader reader, ref NativeArray<float4x4> matrixStack, ref NativeArray<Color32> colorStack, ref NativeArray<CommandBuilder.LineWidthData> lineWidthStack, ref int matrixStackSize, ref int colorStackSize, ref int lineWidthStackSize)
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x46EF7DC", Offset = "0x46EB7DC", VA = "0x46EF7DC")]
		private void CreateTriangles()
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x46EF8CC", Offset = "0x46EB8CC", VA = "0x46EF8CC", Slot = "4")]
		public void Execute()
		{
		}
	}
}
