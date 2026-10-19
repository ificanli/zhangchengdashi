using System.Collections.Generic;
using Il2CppDummyDll;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Rendering;

namespace Pathfinding.Drawing
{
	[Token(Token = "0x200004D")]
	internal static class GeometryBuilder
	{
		[Token(Token = "0x200004E")]
		public struct CameraInfo
		{
			[Token(Token = "0x4000134")]
			[FieldOffset(Offset = "0x0")]
			public float3 cameraPosition;

			[Token(Token = "0x4000135")]
			[FieldOffset(Offset = "0xC")]
			public quaternion cameraRotation;

			[Token(Token = "0x4000136")]
			[FieldOffset(Offset = "0x1C")]
			public float2 cameraDepthToPixelSize;

			[Token(Token = "0x4000137")]
			[FieldOffset(Offset = "0x24")]
			public bool cameraIsOrthographic;

			[Token(Token = "0x6000287")]
			[Address(RVA = "0x46E29EC", Offset = "0x46DE9EC", VA = "0x46E29EC")]
			public CameraInfo(Camera camera)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED GeometryBuilder.CameraInfo..ctor RVA=0x46E29EC Token=0x6000287");
}
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x46E2BAC", Offset = "0x46DEBAC", VA = "0x46E2BAC")]
		internal unsafe static JobHandle Build(DrawingData gizmos, DrawingData.ProcessedBuilderData.MeshBuffers* buffers, ref CameraInfo cameraInfo, JobHandle dependency)
		{
			return default;
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x46EA48C", Offset = "0x46E648C", VA = "0x46EA48C")]
		private static float2 CameraDepthToPixelSize(Camera camera)
		{
			return default;
		}

		[Token(Token = "0x6000284")]
		private static NativeArray<T> ConvertExistingDataToNativeArray<T>(UnsafeAppendBuffer data) where T : struct
		{
			return default;
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x46E30F8", Offset = "0x46DF0F8", VA = "0x46E30F8")]
		internal unsafe static void BuildMesh(DrawingData gizmos, List<DrawingData.MeshWithType> meshes, DrawingData.ProcessedBuilderData.MeshBuffers* inputBuffers)
		{
		}

		[Token(Token = "0x6000286")]
		private static Mesh AssignMeshData<VertexType>(DrawingData gizmos, Bounds bounds, UnsafeAppendBuffer vertices, UnsafeAppendBuffer triangles, VertexAttributeDescriptor[] layout) where VertexType : struct
		{
			return null;
		}
	}
}
