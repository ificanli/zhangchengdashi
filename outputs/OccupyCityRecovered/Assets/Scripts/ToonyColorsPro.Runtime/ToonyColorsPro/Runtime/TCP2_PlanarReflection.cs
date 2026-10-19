using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace ToonyColorsPro.Runtime
{
	[Token(Token = "0x2000007")]
	[ExecuteInEditMode]
	public class TCP2_PlanarReflection : MonoBehaviour
	{
		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x20")]
		public int textureSize;

		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x24")]
		public RenderTextureFormat renderTextureFormat;

		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x28")]
		public LayerMask reflectLayers;

		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x2C")]
		public float clipPlaneOffset;

		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x30")]
		[Space]
		public bool useCustomBackgroundColor;

		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x34")]
		public Color backgroundColor;

		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x44")]
		[Space]
		public bool applyBlur;

		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x48")]
		[Range(1f, 4f)]
		public int blurIterations;

		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x4C")]
		[Range(0.01f, 10f)]
		public float blurDistance;

		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0x50")]
		private Camera reflectionCamera;

		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0x58")]
		private RenderTexture reflectionRenderTexture;

		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0x60")]
		private Shader blurShader;

		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x68")]
		private Material blurMaterial;

		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x70")]
		private CommandBuffer commandBufferBlur;

		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x78")]
		private Shader reflectionDepthShader;

		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0x80")]
		private RenderTexture reflectionDepthRenderTexture;

		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x88")]
		private bool isURP;

		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0x0")]
		private static bool s_InsideRendering;

		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0x4")]
		private static readonly int _SamplingDistance;

		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0x8")]
		private static readonly int _PlanarReflectionTempRT;

		[Token(Token = "0x400003F")]
		[FieldOffset(Offset = "0xC")]
		private static readonly int _ReflectionTex;

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x7D61D94", Offset = "0x7D5DD94", VA = "0x7D61D94")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x7D62504", Offset = "0x7D5E504", VA = "0x7D62504")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x7D62718", Offset = "0x7D5E718", VA = "0x7D62718")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x7D61DAC", Offset = "0x7D5DDAC", VA = "0x7D61DAC")]
		private void UpdateRenderTexture()
		{
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x7D629F4", Offset = "0x7D5E9F4", VA = "0x7D629F4")]
		private void AssignRenderTextureToMaterials()
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x7D62950", Offset = "0x7D5E950", VA = "0x7D62950")]
		private void ClearRenderTexture()
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x7D61F3C", Offset = "0x7D5DF3C", VA = "0x7D61F3C")]
		private void UpdateCommandBuffer()
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x7D62888", Offset = "0x7D5E888", VA = "0x7D62888")]
		private void ClearCommandBuffer()
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x7D62B04", Offset = "0x7D5EB04", VA = "0x7D62B04")]
		private void BeginCameraRendering(Camera cam)
		{
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x7D62B10", Offset = "0x7D5EB10", VA = "0x7D62B10")]
		private void BeginCameraRendering(ScriptableRenderContext context, Camera cam)
		{
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x7D62D1C", Offset = "0x7D5ED1C", VA = "0x7D62D1C")]
		private void RenderPlanarReflection(ScriptableRenderContext context, Camera worldCamera)
		{
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x7D63244", Offset = "0x7D5F244", VA = "0x7D63244")]
		private static Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign, float clipPlaneOffset)
		{
			return default;
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x7D631AC", Offset = "0x7D5F1AC", VA = "0x7D631AC")]
		private static void CalculateReflectionMatrix(ref Matrix4x4 reflectionMat, Vector4 plane)
		{
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x7D633E4", Offset = "0x7D5F3E4", VA = "0x7D633E4")]
		public TCP2_PlanarReflection()
		{
		}
	}
}
