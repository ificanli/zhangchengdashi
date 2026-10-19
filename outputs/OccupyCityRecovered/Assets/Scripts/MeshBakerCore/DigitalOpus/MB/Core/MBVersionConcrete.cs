using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	[Token(Token = "0x2000124")]
	public class MBVersionConcrete : MBVersionInterface
	{
		[Token(Token = "0x2000126")]
		[CompilerGenerated]
		private sealed class _003CFindRuntimeMaterialsFromAddresses_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400046C")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400046D")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400046E")]
			[FieldOffset(Offset = "0x20")]
			public MB2_TextureBakeResults.CoroutineResult isComplete;

			[Token(Token = "0x170000DA")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600065D")]
				[Address(RVA = "0x74B2EB8", Offset = "0x74AEEB8", VA = "0x74B2EB8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170000DB")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600065F")]
				[Address(RVA = "0x74B2EF8", Offset = "0x74AEEF8", VA = "0x74B2EF8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x600065A")]
			[Address(RVA = "0x74B2C08", Offset = "0x74AEC08", VA = "0x74B2C08")]
			[DebuggerHidden]
			public _003CFindRuntimeMaterialsFromAddresses_003Ed__34(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600065B")]
			[Address(RVA = "0x74B2DB4", Offset = "0x74AEDB4", VA = "0x74B2DB4", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600065C")]
			[Address(RVA = "0x74B2DB8", Offset = "0x74AEDB8", VA = "0x74B2DB8", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x600065D")]
			[Address(RVA = "0x74B2EB8", Offset = "0x74AEEB8", VA = "0x74B2EB8", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600065E")]
			[Address(RVA = "0x74B2EC0", Offset = "0x74AEEC0", VA = "0x74B2EC0", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x600065F")]
			[Address(RVA = "0x74B2EF8", Offset = "0x74AEEF8", VA = "0x74B2EF8", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4000467")]
		[FieldOffset(Offset = "0x10")]
		private Vector2 _HALF_UV;

		[Token(Token = "0x6000631")]
		[Address(RVA = "0x74B1308", Offset = "0x74AD308", VA = "0x74B1308", Slot = "4")]
		public string version()
		{
			return null;
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0x74B1348", Offset = "0x74AD348", VA = "0x74B1348", Slot = "6")]
		public bool Is_2017_1_OrNewer()
		{
			return default;
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0x74B1350", Offset = "0x74AD350", VA = "0x74B1350", Slot = "5")]
		public bool Is_2018_3_OrNewer()
		{
			return default;
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0x74B1358", Offset = "0x74AD358", VA = "0x74B1358", Slot = "7")]
		public bool GetActive(GameObject go)
		{
			return default;
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0x74B1370", Offset = "0x74AD370", VA = "0x74B1370", Slot = "8")]
		public void SetActive(GameObject go, bool isActive)
		{
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0x74B1390", Offset = "0x74AD390", VA = "0x74B1390", Slot = "9")]
		public void SetActiveRecursively(GameObject go, bool isActive)
		{
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0x74B13B0", Offset = "0x74AD3B0", VA = "0x74B13B0", Slot = "10")]
		public UnityEngine.Object[] FindSceneObjectsOfType(Type t)
		{
			return null;
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0x74B1408", Offset = "0x74AD408", VA = "0x74B1408", Slot = "27")]
		public bool IsSwizzledNormalMapPlatform()
		{
			return default;
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0x74B1478", Offset = "0x74AD478", VA = "0x74B1478", Slot = "28")]
		public bool IsMaterialKeywordValid(Material mat, string keyword)
		{
			return default;
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0x74B14F0", Offset = "0x74AD4F0", VA = "0x74B14F0", Slot = "17")]
		public void OptimizeMesh(Mesh m)
		{
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0x74B14F4", Offset = "0x74AD4F4", VA = "0x74B14F4", Slot = "11")]
		public bool IsRunningAndMeshNotReadWriteable(Mesh m)
		{
			return default;
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0x74B1574", Offset = "0x74AD574", VA = "0x74B1574")]
		public Vector2[] GetMeshUV1s(Mesh m, MB2_LogLevel LOG_LEVEL)
		{
			return null;
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0x74B1808", Offset = "0x74AD808", VA = "0x74B1808", Slot = "12")]
		public Vector2[] GetMeshUVChannel(int channel, Mesh m, MB2_LogLevel LOG_LEVEL)
		{
			return null;
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0x74B1B88", Offset = "0x74ADB88", VA = "0x74B1B88", Slot = "13")]
		public void MeshClear(Mesh m, bool t)
		{
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0x74B1BA8", Offset = "0x74ADBA8", VA = "0x74B1BA8", Slot = "14")]
		public void MeshAssignUVChannel(int channel, Mesh m, Vector2[] uvs)
		{
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0x74B1D7C", Offset = "0x74ADD7C", VA = "0x74B1D7C", Slot = "15")]
		public Vector4 GetLightmapTilingOffset(Renderer r)
		{
			return default;
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0x74B1D94", Offset = "0x74ADD94", VA = "0x74B1D94", Slot = "16")]
		public Transform[] GetBones(Renderer r, bool isSkinnedMeshWithBones)
		{
			return null;
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0x74B1F58", Offset = "0x74ADF58", VA = "0x74B1F58", Slot = "18")]
		public int GetBlendShapeFrameCount(Mesh m, int shapeIndex)
		{
			return default;
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0x74B1F74", Offset = "0x74ADF74", VA = "0x74B1F74", Slot = "19")]
		public float GetBlendShapeFrameWeight(Mesh m, int shapeIndex, int frameIndex)
		{
			return default;
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0x74B1F94", Offset = "0x74ADF94", VA = "0x74B1F94", Slot = "20")]
		public void GetBlendShapeFrameVertices(Mesh m, int shapeIndex, int frameIndex, Vector3[] vs, Vector3[] ns, Vector3[] ts)
		{
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0x74B1FC0", Offset = "0x74ADFC0", VA = "0x74B1FC0", Slot = "21")]
		public void ClearBlendShapes(Mesh m)
		{
		}

		[Token(Token = "0x6000646")]
		[Address(RVA = "0x74B1FD8", Offset = "0x74ADFD8", VA = "0x74B1FD8", Slot = "22")]
		public void AddBlendShapeFrame(Mesh m, string nm, float wt, Vector3[] vs, Vector3[] ns, Vector3[] ts)
		{
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0x74B2000", Offset = "0x74AE000", VA = "0x74B2000", Slot = "23")]
		public int MaxMeshVertexCount()
		{
			return default;
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0x74B2008", Offset = "0x74AE008", VA = "0x74B2008", Slot = "24")]
		public void SetMeshIndexFormatAndClearMesh(Mesh m, int numVerts, bool vertices, bool justClearTriangles)
		{
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0x74B20C4", Offset = "0x74AE0C4", VA = "0x74B20C4", Slot = "25")]
		public bool GraphicsUVStartsAtTop()
		{
			return default;
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0x74B20CC", Offset = "0x74AE0CC", VA = "0x74B20CC", Slot = "29")]
		public bool IsTexture_sRGBgammaCorrected(Texture2D tex, bool hint)
		{
			return default;
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0x74B20E4", Offset = "0x74AE0E4", VA = "0x74B20E4", Slot = "26")]
		public bool IsTextureReadable(Texture2D tex)
		{
			return default;
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0x74B2108", Offset = "0x74AE108", VA = "0x74B2108", Slot = "36")]
		public float GetScaleInLightmap(MeshRenderer r)
		{
			return default;
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0x74B2110", Offset = "0x74AE110", VA = "0x74B2110", Slot = "30")]
		public bool CollectPropertyNames(List<ShaderTextureProperty> texPropertyNames, ShaderTextureProperty[] shaderTexPropertyNames, List<ShaderTextureProperty> _customShaderPropNames, Material resultMaterial, MB2_LogLevel LOG_LEVEL)
		{
			return default;
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0x74B29E8", Offset = "0x74AE9E8", VA = "0x74B29E8", Slot = "31")]
		public void DoSpecialRenderPipeline_TexturePackerFastSetup(GameObject cameraGameObject)
		{
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0x74B29EC", Offset = "0x74AE9EC", VA = "0x74B29EC", Slot = "32")]
		public ColorSpace GetProjectColorSpace()
		{
			return default;
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0x74B2880", Offset = "0x74AE880", VA = "0x74B2880", Slot = "33")]
		public MBVersion.PipelineType DetectPipeline()
		{
			return default;
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0x74B2B9C", Offset = "0x74AEB9C", VA = "0x74B2B9C", Slot = "34")]
		public string UnescapeURL(string url)
		{
			return null;
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0x74B2BA8", Offset = "0x74AEBA8", VA = "0x74B2BA8", Slot = "35")]
		[IteratorStateMachine(typeof(_003CFindRuntimeMaterialsFromAddresses_003Ed__34))]
		public IEnumerator FindRuntimeMaterialsFromAddresses(MB2_TextureBakeResults texBakeResult, MB2_TextureBakeResults.CoroutineResult isComplete)
		{
			return null;
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0x74B2C30", Offset = "0x74AEC30", VA = "0x74B2C30", Slot = "37")]
		public bool IsAssetInProject(UnityEngine.Object target)
		{
			return default;
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0x74B2C38", Offset = "0x74AEC38", VA = "0x74B2C38")]
		public MBVersionConcrete()
		{
		}
	}
}
