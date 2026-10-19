using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace StylizedWater
{
	[Token(Token = "0x2000008")]
	[HelpURL("https://alexander-ameye.gitbook.io/stylized-water/")]
	[AddComponentMenu("Effects/Planar Reflections")]
	[DisallowMultipleComponent]
	[ExecuteAlways]
	public class PlanarReflections : MonoBehaviour
	{
		[Token(Token = "0x2000009")]
		private class PlanarReflectionSettingData
		{
			[Token(Token = "0x4000036")]
			[FieldOffset(Offset = "0x10")]
			private readonly bool fog;

			[Token(Token = "0x4000037")]
			[FieldOffset(Offset = "0x14")]
			private readonly int maximumLODLevel;

			[Token(Token = "0x4000038")]
			[FieldOffset(Offset = "0x18")]
			private readonly float lodBias;

			[Token(Token = "0x600001D")]
			[Address(RVA = "0x78F70C0", Offset = "0x78F30C0", VA = "0x78F70C0")]
			public PlanarReflectionSettingData()
			{
			}

			[Token(Token = "0x600001E")]
			[Address(RVA = "0x78F7100", Offset = "0x78F3100", VA = "0x78F7100")]
			public void Set()
			{
			}

			[Token(Token = "0x600001F")]
			[Address(RVA = "0x78F7144", Offset = "0x78F3144", VA = "0x78F7144")]
			public void Restore()
			{
			}
		}

		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x20")]
		[Range(0.01f, 1f)]
		public float renderScale;

		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x24")]
		public LayerMask reflectionLayer;

		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x28")]
		public bool reflectSkybox;

		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x30")]
		public GameObject reflectionTarget;

		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x38")]
		[Range(-2f, 3f)]
		public float reflectionPlaneOffset;

		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x0")]
		private static Camera _reflectionCamera;

		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x40")]
		private UniversalAdditionalCameraData cameraData;

		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x8")]
		private static RenderTexture _reflectionTexture;

		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x48")]
		private RenderTextureDescriptor previousDescriptor;

		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x7C")]
		private readonly int _planarReflectionTextureId;

		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0x10")]
		[CompilerGenerated]
		private static Action<ScriptableRenderContext, Camera> m_BeginPlanarReflections;

		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0x80")]
		public bool hideReflectionCamera;

		[Token(Token = "0x14000001")]
		public static event Action<ScriptableRenderContext, Camera> BeginPlanarReflections
		{
			[Token(Token = "0x600000B")]
			[Address(RVA = "0x78F59B8", Offset = "0x78F19B8", VA = "0x78F59B8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600000C")]
			[Address(RVA = "0x78F5A88", Offset = "0x78F1A88", VA = "0x78F5A88")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x78F5B58", Offset = "0x78F1B58", VA = "0x78F5B58")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x78F5C10", Offset = "0x78F1C10", VA = "0x78F5C10")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x78F5DC0", Offset = "0x78F1DC0", VA = "0x78F5DC0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x78F5CBC", Offset = "0x78F1CBC", VA = "0x78F5CBC")]
		private void CleanUp()
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x78F5E6C", Offset = "0x78F1E6C", VA = "0x78F5E6C")]
		private void SafeDestroyObject(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x78F5F08", Offset = "0x78F1F08", VA = "0x78F5F08")]
		private void UpdateReflectionCamera(Camera realCamera)
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x78F6768", Offset = "0x78F2768", VA = "0x78F6768")]
		private void UpdateCamera(Camera src, Camera dest)
		{
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x78F6478", Offset = "0x78F2478", VA = "0x78F6478")]
		private Camera InitializeReflectionCamera()
		{
			return null;
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x78F6938", Offset = "0x78F2938", VA = "0x78F6938")]
		private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
		{
			return default;
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x78F6AD0", Offset = "0x78F2AD0", VA = "0x78F6AD0")]
		private RenderTextureDescriptor GetDescriptor(Camera camera, float pipelineRenderScale)
		{
			return default;
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x78F6CA8", Offset = "0x78F2CA8", VA = "0x78F6CA8")]
		private void CreateReflectionTexture(Camera camera)
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x78F6EE4", Offset = "0x78F2EE4", VA = "0x78F6EE4")]
		private void DoPlanarReflections(ScriptableRenderContext context, Camera camera)
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x78F6898", Offset = "0x78F2898", VA = "0x78F6898")]
		public static void CalculateReflectionMatrix(ref Matrix4x4 reflectionMatrix, Vector4 plane)
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x78F6930", Offset = "0x78F2930", VA = "0x78F6930")]
		public static Vector3 ReflectPosition(Vector3 pos)
		{
			return default;
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x78F7180", Offset = "0x78F3180", VA = "0x78F7180")]
		public static bool Compare(Vector2 a, Vector2 b)
		{
			return default;
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x78F7198", Offset = "0x78F3198", VA = "0x78F7198")]
		public PlanarReflections()
		{
		}
	}
}
