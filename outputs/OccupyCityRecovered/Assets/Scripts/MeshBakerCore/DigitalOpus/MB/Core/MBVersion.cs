using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	[Token(Token = "0x2000042")]
	public class MBVersion
	{
		[Token(Token = "0x2000043")]
		public enum PipelineType
		{
			[Token(Token = "0x4000117")]
			Unsupported = 0,
			[Token(Token = "0x4000118")]
			Default = 1,
			[Token(Token = "0x4000119")]
			URP = 2,
			[Token(Token = "0x400011A")]
			HDRP = 3
		}

		[Token(Token = "0x2000044")]
		[CompilerGenerated]
		private sealed class _003CFindRuntimeMaterialsFromAddresses_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400011B")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400011C")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400011D")]
			[FieldOffset(Offset = "0x20")]
			public MB2_TextureBakeResults textureBakeResult;

			[Token(Token = "0x400011E")]
			[FieldOffset(Offset = "0x28")]
			public MB2_TextureBakeResults.CoroutineResult isComplete;

			[Token(Token = "0x1700002B")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600016E")]
				[Address(RVA = "0x744A24C", Offset = "0x744624C", VA = "0x744A24C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x1700002C")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000170")]
				[Address(RVA = "0x744A28C", Offset = "0x744628C", VA = "0x744A28C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x600016B")]
			[Address(RVA = "0x744A0EC", Offset = "0x74460EC", VA = "0x744A0EC")]
			[DebuggerHidden]
			public _003CFindRuntimeMaterialsFromAddresses_003Ed__38(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600016C")]
			[Address(RVA = "0x744A11C", Offset = "0x744611C", VA = "0x744A11C", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600016D")]
			[Address(RVA = "0x744A120", Offset = "0x7446120", VA = "0x744A120", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x600016E")]
			[Address(RVA = "0x744A24C", Offset = "0x744624C", VA = "0x744A24C", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600016F")]
			[Address(RVA = "0x744A254", Offset = "0x7446254", VA = "0x744A254", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000170")]
			[Address(RVA = "0x744A28C", Offset = "0x744628C", VA = "0x744A28C", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4000114")]
		public const string MB_USING_HDRP = "MB_USING_HDRP";

		[Token(Token = "0x4000115")]
		[FieldOffset(Offset = "0x0")]
		private static MBVersionInterface _MBVersion;

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x7448344", Offset = "0x7444344", VA = "0x7448344")]
		private static MBVersionInterface _CreateMBVersionConcrete()
		{
			return null;
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x74483F4", Offset = "0x74443F4", VA = "0x74483F4")]
		public static string version()
		{
			return null;
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x74484CC", Offset = "0x74444CC", VA = "0x74484CC")]
		public static bool Is_2018_3_OrNewer()
		{
			return default;
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x74485A8", Offset = "0x74445A8", VA = "0x74485A8")]
		public static bool Is_2017_1_OrNewer()
		{
			return default;
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x7448684", Offset = "0x7444684", VA = "0x7448684")]
		public static bool GetActive(GameObject go)
		{
			return default;
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x7448768", Offset = "0x7444768", VA = "0x7448768")]
		public static void SetActive(GameObject go, bool isActive)
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x744885C", Offset = "0x744485C", VA = "0x744885C")]
		public static void SetActiveRecursively(GameObject go, bool isActive)
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x7448950", Offset = "0x7444950", VA = "0x7448950")]
		public static UnityEngine.Object[] FindSceneObjectsOfType(Type t)
		{
			return null;
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x7448A34", Offset = "0x7444A34", VA = "0x7448A34")]
		public static bool IsRunningAndMeshNotReadWriteable(Mesh m)
		{
			return default;
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x7448B18", Offset = "0x7444B18", VA = "0x7448B18")]
		public static Vector2[] GetMeshChannel(int channel, Mesh m, MB2_LogLevel LOG_LEVEL)
		{
			return null;
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x7448C14", Offset = "0x7444C14", VA = "0x7448C14")]
		public static float GetScaleInLightmap(MeshRenderer r)
		{
			return default;
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x7448CF8", Offset = "0x7444CF8", VA = "0x7448CF8")]
		public static void MeshClear(Mesh m, bool t)
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x7448DEC", Offset = "0x7444DEC", VA = "0x7448DEC")]
		public static void MeshAssignUVChannel(int channel, Mesh m, Vector2[] uvs)
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x7448EE8", Offset = "0x7444EE8", VA = "0x7448EE8")]
		public static Vector4 GetLightmapTilingOffset(Renderer r)
		{
			return default;
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x7448FCC", Offset = "0x7444FCC", VA = "0x7448FCC")]
		public static Transform[] GetBones(Renderer r, bool isSkinnedMeshWithBones)
		{
			return null;
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x7439CB8", Offset = "0x7435CB8", VA = "0x7439CB8")]
		public static bool IsSwizzledNormalMapPlatform()
		{
			return default;
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x74490C0", Offset = "0x74450C0", VA = "0x74490C0")]
		public static bool IsMaterialKeywordValid(Material mat, string keyword)
		{
			return default;
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x74491B4", Offset = "0x74451B4", VA = "0x74491B4")]
		public static void OptimizeMesh(Mesh m)
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x7449298", Offset = "0x7445298", VA = "0x7449298")]
		public static int GetBlendShapeFrameCount(Mesh m, int shapeIndex)
		{
			return default;
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x744938C", Offset = "0x744538C", VA = "0x744938C")]
		public static float GetBlendShapeFrameWeight(Mesh m, int shapeIndex, int frameIndex)
		{
			return default;
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x7449488", Offset = "0x7445488", VA = "0x7449488")]
		public static void GetBlendShapeFrameVertices(Mesh m, int shapeIndex, int frameIndex, Vector3[] vs, Vector3[] ns, Vector3[] ts)
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x74495AC", Offset = "0x74455AC", VA = "0x74495AC")]
		public static void ClearBlendShapes(Mesh m)
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x7449690", Offset = "0x7445690", VA = "0x7449690")]
		public static void AddBlendShapeFrame(Mesh m, string nm, float wt, Vector3[] vs, Vector3[] ns, Vector3[] ts)
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x74497B4", Offset = "0x74457B4", VA = "0x74497B4")]
		public static int MaxMeshVertexCount()
		{
			return default;
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x7449890", Offset = "0x7445890", VA = "0x7449890")]
		public static void SetMeshIndexFormatAndClearMesh(Mesh m, int numVerts, bool vertices, bool justClearTriangles)
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x743B714", Offset = "0x7437714", VA = "0x743B714")]
		public static bool GraphicsUVStartsAtTop()
		{
			return default;
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x744999C", Offset = "0x744599C", VA = "0x744999C")]
		public static bool IsTexture_sRGBgammaCorrected(Texture2D tex, bool hint)
		{
			return default;
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x7449A90", Offset = "0x7445A90", VA = "0x7449A90")]
		public static bool IsTextureReadable(Texture2D tex)
		{
			return default;
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x7449B74", Offset = "0x7445B74", VA = "0x7449B74")]
		public static void CollectPropertyNames(List<ShaderTextureProperty> texPropertyNames, ShaderTextureProperty[] shaderTexPropertyNames, List<ShaderTextureProperty> _customShaderPropNames, Material resultMaterial, MB2_LogLevel LOG_LEVEL)
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x7449C88", Offset = "0x7445C88", VA = "0x7449C88")]
		internal static void DoSpecialRenderPipeline_TexturePackerFastSetup(GameObject cameraGameObject)
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x7449D6C", Offset = "0x7445D6C", VA = "0x7449D6C")]
		public static ColorSpace GetProjectColorSpace()
		{
			return default;
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x7449E48", Offset = "0x7445E48", VA = "0x7449E48")]
		public static PipelineType DetectPipeline()
		{
			return default;
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x7449F24", Offset = "0x7445F24", VA = "0x7449F24")]
		public static string UnescapeURL(string url)
		{
			return null;
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x744A008", Offset = "0x7446008", VA = "0x744A008")]
		public static bool IsAssetInProject(UnityEngine.Object target)
		{
			return default;
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x744290C", Offset = "0x743E90C", VA = "0x744290C")]
		public static bool IsUsingAddressables()
		{
			return default;
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x743DEE0", Offset = "0x7439EE0", VA = "0x743DEE0")]
		[IteratorStateMachine(typeof(_003CFindRuntimeMaterialsFromAddresses_003Ed__38))]
		internal static IEnumerator FindRuntimeMaterialsFromAddresses(MB2_TextureBakeResults textureBakeResult, MB2_TextureBakeResults.CoroutineResult isComplete)
		{
			return null;
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x744A114", Offset = "0x7446114", VA = "0x744A114")]
		public MBVersion()
		{
		}
	}
}
