using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

namespace GPUInstancer
{
	[Token(Token = "0x2000067")]
	public class GPUInstancerHiZOcclusionGenerator : MonoBehaviour
	{
		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool debuggerEnabled;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool debuggerGUIOnTop;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Range(0f, 0.1f)]
		public float debuggerOverlay;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Range(0f, 16f)]
		public int debuggerMipLevel;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Header("For info only, don't change:")]
		public RenderTexture hiZDepthTexture;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Texture unityDepthTexture;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector4 hiZTextureSize;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Camera _mainCamera;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool _isInvalid;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int _hiZMipLevels;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private RenderTexture[] _hiZMipLevelTextures;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool _isDepthTex2DArray;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool _isVulkanCached;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		private static bool _isVulkanCachedInitialized;

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private RawImage _hiZDebugDepthTextureGUIImage;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private GameObject _hiZOcclusionDebuggerGUI;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private bool _loggedURPWarning;

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x73FCB68", Offset = "0x73F8B68", VA = "0x73FCB68")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x73FCC10", Offset = "0x73F8C10", VA = "0x73FCC10")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x73FCDB4", Offset = "0x73F8DB4", VA = "0x73FCDB4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x73FD104", Offset = "0x73F9104", VA = "0x73FD104")]
		public void Initialize([Optional] Camera occlusionCamera)
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x73FD8D4", Offset = "0x73F98D4", VA = "0x73FD8D4")]
		public bool IsHiZDepthUpdated()
		{
			return default;
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x73FD940", Offset = "0x73F9940", VA = "0x73FD940")]
		private void OnEndCameraRenderingSRP(ScriptableRenderContext context, Camera camera)
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x73FD948", Offset = "0x73F9948", VA = "0x73FD948")]
		private void OnEndCameraRendering(Camera camera)
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x73FDD38", Offset = "0x73F9D38", VA = "0x73FDD38")]
		private void UpdateTextureWithComputeShader(int offset, int textureArrayIndex = 0)
		{
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x73FDEC8", Offset = "0x73F9EC8", VA = "0x73FDEC8")]
		private Vector4 GetScreenSize()
		{
			return default;
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x73FD2D8", Offset = "0x73F92D8", VA = "0x73FD2D8")]
		private bool CreateHiZDepthTexture()
		{
			return default;
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x73FE110", Offset = "0x73FA110", VA = "0x73FE110")]
		private void SafeDestroyRT(RenderTexture rt)
		{
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x73FDD00", Offset = "0x73F9D00", VA = "0x73FDD00")]
		private void HandleScreenSizeChange()
		{
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x73FE21C", Offset = "0x73FA21C", VA = "0x73FE21C")]
		public GPUInstancerHiZOcclusionGenerator()
		{
		}
	}
}
