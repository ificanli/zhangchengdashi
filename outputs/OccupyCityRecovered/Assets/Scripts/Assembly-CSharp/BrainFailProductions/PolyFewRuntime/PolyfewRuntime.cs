using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using BrainFailProductions.PolyFew.AsImpL;
using BrainFailProductions.PolyFew.UnityMeshSimplifier;
using Il2CppDummyDll;
using UnityEngine;

namespace BrainFailProductions.PolyFewRuntime
{
	[Token(Token = "0x2000D24")]
	[AddComponentMenu("")]
	public class PolyfewRuntime : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000D25")]
		public class ObjectMeshPairs : Dictionary<GameObject, MeshRendererPair>
		{
			[Token(Token = "0x60051D0")]
			[Address(RVA = "0x42EFE14", Offset = "0x42EBE14", VA = "0x42EFE14")]
			public ObjectMeshPairs()
			{
			}
		}

		[Token(Token = "0x2000D26")]
		public enum MeshCombineTarget
		{
			[Token(Token = "0x4005DDF")]
			SkinnedAndStatic = 0,
			[Token(Token = "0x4005DE0")]
			StaticOnly = 1,
			[Token(Token = "0x4005DE1")]
			SkinnedOnly = 2
		}

		[Serializable]
		[Token(Token = "0x2000D27")]
		public class MeshRendererPair
		{
			[Token(Token = "0x4005DE2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool attachedToMeshFilter;

			[Token(Token = "0x4005DE3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Mesh mesh;

			[Token(Token = "0x60051D1")]
			[Address(RVA = "0x42EFE5C", Offset = "0x42EBE5C", VA = "0x42EFE5C")]
			public MeshRendererPair(bool attachedToMeshFilter, Mesh mesh)
			{
			}

			[Token(Token = "0x60051D2")]
			[Address(RVA = "0x42EFE8C", Offset = "0x42EBE8C", VA = "0x42EFE8C")]
			public void Destruct()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000D28")]
		public class CustomMeshActionStructure
		{
			[Token(Token = "0x4005DE4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public MeshRendererPair meshRendererPair;

			[Token(Token = "0x4005DE5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GameObject gameObject;

			[Token(Token = "0x4005DE6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Action action;

			[Token(Token = "0x60051D3")]
			[Address(RVA = "0x42EFF1C", Offset = "0x42EBF1C", VA = "0x42EFF1C")]
			public CustomMeshActionStructure(MeshRendererPair meshRendererPair, GameObject gameObject, Action action)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000D29")]
		public class SimplificationOptions
		{
			[Token(Token = "0x4005DE7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float simplificationStrength;

			[Token(Token = "0x4005DE8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public bool simplifyMeshLossless;

			[Token(Token = "0x4005DE9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			public bool enableSmartlinking;

			[Token(Token = "0x4005DEA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x16")]
			public bool recalculateNormals;

			[Token(Token = "0x4005DEB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x17")]
			public bool preserveUVSeamEdges;

			[Token(Token = "0x4005DEC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool preserveUVFoldoverEdges;

			[Token(Token = "0x4005DED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			public bool preserveBorderEdges;

			[Token(Token = "0x4005DEE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
			public bool regardPreservationSpheres;

			[Token(Token = "0x4005DEF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public List<PreservationSphere> preservationSpheres;

			[Token(Token = "0x4005DF0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool regardCurvature;

			[Token(Token = "0x4005DF1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public int maxIterations;

			[Token(Token = "0x4005DF2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float aggressiveness;

			[Token(Token = "0x4005DF3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public bool useEdgeSort;

			[Token(Token = "0x60051D4")]
			[Address(RVA = "0x42EFF58", Offset = "0x42EBF58", VA = "0x42EFF58")]
			public SimplificationOptions()
			{
			}

			[Token(Token = "0x60051D5")]
			[Address(RVA = "0x42EFFE8", Offset = "0x42EBFE8", VA = "0x42EFFE8")]
			public SimplificationOptions(float simplificationStrength, bool simplifyOptimal, bool enableSmartlink, bool recalculateNormals, bool preserveUVSeamEdges, bool preserveUVFoldoverEdges, bool preserveBorderEdges, bool regardToleranceSphere, List<PreservationSphere> preservationSpheres, bool regardCurvature, int maxIterations, float aggressiveness, bool useEdgeSort)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000D2A")]
		public class PreservationSphere
		{
			[Token(Token = "0x4005DF4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 worldPosition;

			[Token(Token = "0x4005DF5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float diameter;

			[Token(Token = "0x4005DF6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float preservationStrength;

			[Token(Token = "0x60051D6")]
			[Address(RVA = "0x42F0148", Offset = "0x42EC148", VA = "0x42F0148")]
			public PreservationSphere(Vector3 worldPosition, float diameter, float preservationStrength)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000D2B")]
		public class OBJImportOptions : ImportOptions
		{
			[Token(Token = "0x60051D7")]
			[Address(RVA = "0x42F01A0", Offset = "0x42EC1A0", VA = "0x42F01A0")]
			public OBJImportOptions()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000D2C")]
		public class OBJExportOptions
		{
			[Token(Token = "0x4005DF7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public readonly bool applyPosition;

			[Token(Token = "0x4005DF8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
			public readonly bool applyRotation;

			[Token(Token = "0x4005DF9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
			public readonly bool applyScale;

			[Token(Token = "0x4005DFA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x13")]
			public readonly bool generateMaterials;

			[Token(Token = "0x4005DFB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public readonly bool exportTextures;

			[Token(Token = "0x60051D8")]
			[Address(RVA = "0x42F01A8", Offset = "0x42EC1A8", VA = "0x42F01A8")]
			public OBJExportOptions(bool applyPosition, bool applyRotation, bool applyScale, bool generateMaterials, bool exportTextures)
			{
			}
		}

		[Token(Token = "0x2000D2D")]
		public class ReferencedNumeric<T> where T : struct, IComparable, IComparable<T>, IConvertible, IEquatable<T>, IFormattable
		{
			[Token(Token = "0x4005DFC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private T val;

			[Token(Token = "0x17000E5E")]
			public T Value
			{
				[Token(Token = "0x60051D9")]
				get
				{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED PolyfewRuntime.ReferencedNumeric.Value.get RVA= Token=0x60051D9");
}
				[Token(Token = "0x60051DA")]
				set
				{
				}
			}

			[Token(Token = "0x60051DB")]
			public ReferencedNumeric(T value)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000D2E")]
		public class MaterialProperties
		{
			[Token(Token = "0x4005DFD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public readonly int texArrIndex;

			[Token(Token = "0x4005DFE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public readonly int matIndex;

			[Token(Token = "0x4005DFF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public readonly string materialName;

			[Token(Token = "0x4005E00")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public readonly Material originalMaterial;

			[Token(Token = "0x4005E01")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Color albedoTint;

			[Token(Token = "0x4005E02")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Vector4 uvTileOffset;

			[Token(Token = "0x4005E03")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public float normalIntensity;

			[Token(Token = "0x4005E04")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float occlusionIntensity;

			[Token(Token = "0x4005E05")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public float smoothnessIntensity;

			[Token(Token = "0x4005E06")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float glossMapScale;

			[Token(Token = "0x4005E07")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float metalIntensity;

			[Token(Token = "0x4005E08")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Color emissionColor;

			[Token(Token = "0x4005E09")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Vector4 detailUVTileOffset;

			[Token(Token = "0x4005E0A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			public float alphaCutoff;

			[Token(Token = "0x4005E0B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			public Color specularColor;

			[Token(Token = "0x4005E0C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public float detailNormalScale;

			[Token(Token = "0x4005E0D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			public float heightIntensity;

			[Token(Token = "0x4005E0E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			public readonly float uvSec;

			[Token(Token = "0x60051DC")]
			[Address(RVA = "0x42F020C", Offset = "0x42EC20C", VA = "0x42F020C")]
			public MaterialProperties(int texArrIndex, int matIndex, string materialName, Material originalMaterial, Color albedoTint, Vector4 uvTileOffset, float normalIntensity, float occlusionIntensity, float smoothnessIntensity, float glossMapScale, float metalIntensity, Color emissionColor, Vector4 detailUVTileOffset, float alphaCutoff, Color specularColor, float detailNormalScale, float heightIntensity, float uvSec)
			{
			}

			[Token(Token = "0x60051DD")]
			[Address(RVA = "0x42F0398", Offset = "0x42EC398", VA = "0x42F0398")]
			public void BurnAttrToImg(ref Texture2D burnOn, int index, int textureArrayIndex)
			{
			}
		}

		[Token(Token = "0x2000D38")]
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass20_0
		{
			[Token(Token = "0x4005E64")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool isWorking;

			[Token(Token = "0x4005E65")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Action<GameObject> OnSuccess;

			[Token(Token = "0x6005203")]
			[Address(RVA = "0x42F2CDC", Offset = "0x42EECDC", VA = "0x42F2CDC")]
			public _003C_003Ec__DisplayClass20_0()
			{
			}

			[Token(Token = "0x6005204")]
			[Address(RVA = "0x42F2CE4", Offset = "0x42EECE4", VA = "0x42F2CE4")]
			internal void _003CImportOBJFromFileSystem_003Eb__0(GameObject importedObject)
			{
			}
		}

		[Token(Token = "0x2000D39")]
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass21_0
		{
			[Token(Token = "0x4005E66")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool isWorking;

			[Token(Token = "0x4005E67")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Action<GameObject> OnSuccess;

			[Token(Token = "0x4005E68")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Action<Exception> OnError;

			[Token(Token = "0x6005205")]
			[Address(RVA = "0x42F2D0C", Offset = "0x42EED0C", VA = "0x42F2D0C")]
			public _003C_003Ec__DisplayClass21_0()
			{
			}

			[Token(Token = "0x6005206")]
			[Address(RVA = "0x42F2D14", Offset = "0x42EED14", VA = "0x42F2D14")]
			internal void _003CImportOBJFromNetwork_003Eb__0(GameObject importedObject)
			{
			}

			[Token(Token = "0x6005207")]
			[Address(RVA = "0x42F2D3C", Offset = "0x42EED3C", VA = "0x42F2D3C")]
			internal void _003CImportOBJFromNetwork_003Eb__1(Exception ex)
			{
			}
		}

		[Token(Token = "0x2000D3A")]
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass22_0
		{
			[Token(Token = "0x4005E69")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool isWorking;

			[Token(Token = "0x4005E6A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Action OnSuccess;

			[Token(Token = "0x6005208")]
			[Address(RVA = "0x42F2D64", Offset = "0x42EED64", VA = "0x42F2D64")]
			public _003C_003Ec__DisplayClass22_0()
			{
			}

			[Token(Token = "0x6005209")]
			[Address(RVA = "0x42F2D6C", Offset = "0x42EED6C", VA = "0x42F2D6C")]
			internal void _003CExportGameObjectToOBJ_003Eb__0()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000D3B")]
		[CompilerGenerated]
		private struct _003CExportGameObjectToOBJ_003Ed__22 : IAsyncStateMachine
		{
			[Token(Token = "0x4005E6B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005E6C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005E6D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action OnSuccess;

			[Token(Token = "0x4005E6E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public GameObject toExport;

			[Token(Token = "0x4005E6F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string exportPath;

			[Token(Token = "0x4005E70")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public OBJExportOptions exportOptions;

			[Token(Token = "0x4005E71")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Action<Exception> OnError;

			[Token(Token = "0x4005E72")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private _003C_003Ec__DisplayClass22_0 _003C_003E8__1;

			[Token(Token = "0x4005E73")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private TaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x600520A")]
			[Address(RVA = "0x42F2D94", Offset = "0x42EED94", VA = "0x42F2D94", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600520B")]
			[Address(RVA = "0x42F3F70", Offset = "0x42EFF70", VA = "0x42F3F70", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000D3C")]
		[CompilerGenerated]
		private struct _003CImportOBJFromFileSystem_003Ed__20 : IAsyncStateMachine
		{
			[Token(Token = "0x4005E74")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005E75")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005E76")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action<GameObject> OnSuccess;

			[Token(Token = "0x4005E77")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string objAbsolutePath;

			[Token(Token = "0x4005E78")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string texturesFolderPath;

			[Token(Token = "0x4005E79")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string materialsFolderPath;

			[Token(Token = "0x4005E7A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public OBJImportOptions importOptions;

			[Token(Token = "0x4005E7B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private _003C_003Ec__DisplayClass20_0 _003C_003E8__1;

			[Token(Token = "0x4005E7C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Action<Exception> OnError;

			[Token(Token = "0x4005E7D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private TaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x600520C")]
			[Address(RVA = "0x42F3F7C", Offset = "0x42EFF7C", VA = "0x42F3F7C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600520D")]
			[Address(RVA = "0x42F4474", Offset = "0x42F0474", VA = "0x42F4474", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000D3D")]
		[CompilerGenerated]
		private struct _003CImportOBJFromNetwork_003Ed__21 : IAsyncStateMachine
		{
			[Token(Token = "0x4005E7E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005E7F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005E80")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action<GameObject> OnSuccess;

			[Token(Token = "0x4005E81")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action<Exception> OnError;

			[Token(Token = "0x4005E82")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string objURL;

			[Token(Token = "0x4005E83")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string objName;

			[Token(Token = "0x4005E84")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public string diffuseTexURL;

			[Token(Token = "0x4005E85")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public string bumpTexURL;

			[Token(Token = "0x4005E86")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public string specularTexURL;

			[Token(Token = "0x4005E87")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public string opacityTexURL;

			[Token(Token = "0x4005E88")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public string materialURL;

			[Token(Token = "0x4005E89")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public ReferencedNumeric<float> downloadProgress;

			[Token(Token = "0x4005E8A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public OBJImportOptions importOptions;

			[Token(Token = "0x4005E8B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private _003C_003Ec__DisplayClass21_0 _003C_003E8__1;

			[Token(Token = "0x4005E8C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private TaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x600520E")]
			[Address(RVA = "0x42F4480", Offset = "0x42F0480", VA = "0x42F4480", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600520F")]
			[Address(RVA = "0x42F48C0", Offset = "0x42F08C0", VA = "0x42F48C0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4005DDD")]
		private const int MAX_LOD_COUNT = 8;

		[Token(Token = "0x60051BB")]
		[Address(RVA = "0x42E8390", Offset = "0x42E4390", VA = "0x42E8390")]
		public static int SimplifyObjectDeep(GameObject toSimplify, SimplificationOptions simplificationOptions, Action<GameObject, MeshRendererPair> OnEachMeshSimplified)
		{
			return default;
		}

		[Token(Token = "0x60051BC")]
		[Address(RVA = "0x42EA59C", Offset = "0x42E659C", VA = "0x42EA59C")]
		public static ObjectMeshPairs SimplifyObjectDeep(GameObject toSimplify, SimplificationOptions simplificationOptions)
		{
			return null;
		}

		[Token(Token = "0x60051BD")]
		[Address(RVA = "0x42DDF34", Offset = "0x42D9F34", VA = "0x42DDF34")]
		public static int SimplifyObjectDeep(ObjectMeshPairs objectMeshPairs, SimplificationOptions simplificationOptions, Action<GameObject, MeshRendererPair> OnEachMeshSimplified)
		{
			return default;
		}

		[Token(Token = "0x60051BE")]
		[Address(RVA = "0x42EC010", Offset = "0x42E8010", VA = "0x42EC010")]
		public static List<Mesh> SimplifyMeshes(List<Mesh> meshesToSimplify, SimplificationOptions simplificationOptions, Action<Mesh> OnEachMeshSimplified)
		{
			return null;
		}

		[Token(Token = "0x60051BF")]
		[Address(RVA = "0x42DCFE0", Offset = "0x42D8FE0", VA = "0x42DCFE0")]
		public static ObjectMeshPairs GetObjectMeshPairs(GameObject forObject, bool includeInactive)
		{
			return null;
		}

		[Token(Token = "0x60051C0")]
		[Address(RVA = "0x42ECF50", Offset = "0x42E8F50", VA = "0x42ECF50")]
		public static void CombineMeshesInGameObject(GameObject forObject, bool skipInactiveRenderers, Action<string, string> OnError, MeshCombineTarget combineTarget = MeshCombineTarget.SkinnedAndStatic)
		{
		}

		[Token(Token = "0x60051C1")]
		[Address(RVA = "0x42EE1AC", Offset = "0x42EA1AC", VA = "0x42EE1AC")]
		public static GameObject CombineMeshesFromRenderers(Transform rootTransform, MeshRenderer[] originalMeshRenderers, SkinnedMeshRenderer[] originalSkinnedMeshRenderers, Action<string, string> OnError)
		{
			return null;
		}

		[Token(Token = "0x60051C2")]
		[Address(RVA = "0x42EE904", Offset = "0x42EA904", VA = "0x42EE904")]
		public static void ConvertSkinnedMeshesInGameObject(GameObject forObject, bool skipInactiveRenderers, Action<string, string> OnError)
		{
		}

		[Token(Token = "0x60051C3")]
		[Address(RVA = "0x42EF0DC", Offset = "0x42EB0DC", VA = "0x42EF0DC")]
		public static Tuple<SkinnedMeshRenderer, MeshRenderer, Mesh>[] ConvertSkinnedMeshesFromRenderers(SkinnedMeshRenderer[] renderersToConvert, Action<string, string> OnError)
		{
			return null;
		}

		[Token(Token = "0x60051C4")]
		[Address(RVA = "0x42DFF74", Offset = "0x42DBF74", VA = "0x42DFF74")]
		[AsyncStateMachine(typeof(_003CImportOBJFromFileSystem_003Ed__20))]
		public static void ImportOBJFromFileSystem(string objAbsolutePath, string texturesFolderPath, string materialsFolderPath, Action<GameObject> OnSuccess, Action<Exception> OnError, [Optional] OBJImportOptions importOptions)
		{
		}

		[Token(Token = "0x60051C5")]
		[Address(RVA = "0x42E034C", Offset = "0x42DC34C", VA = "0x42E034C")]
		[AsyncStateMachine(typeof(_003CImportOBJFromNetwork_003Ed__21))]
		public static void ImportOBJFromNetwork(string objURL, string objName, string diffuseTexURL, string bumpTexURL, string specularTexURL, string opacityTexURL, string materialURL, ReferencedNumeric<float> downloadProgress, Action<GameObject> OnSuccess, Action<Exception> OnError, [Optional] OBJImportOptions importOptions)
		{
		}

		[Token(Token = "0x60051C6")]
		[Address(RVA = "0x42E0710", Offset = "0x42DC710", VA = "0x42E0710")]
		[AsyncStateMachine(typeof(_003CExportGameObjectToOBJ_003Ed__22))]
		public static void ExportGameObjectToOBJ(GameObject toExport, string exportPath, Action OnSuccess, Action<Exception> OnError, [Optional] OBJExportOptions exportOptions)
		{
		}

		[Token(Token = "0x60051C7")]
		[Address(RVA = "0x42DD310", Offset = "0x42D9310", VA = "0x42DD310")]
		public static int CountTriangles(bool countDeep, GameObject forObject)
		{
			return default;
		}

		[Token(Token = "0x60051C8")]
		[Address(RVA = "0x42ECD5C", Offset = "0x42E8D5C", VA = "0x42ECD5C")]
		public static int CountTriangles(List<Mesh> toCount)
		{
			return default;
		}

		[Token(Token = "0x60051C9")]
		[Address(RVA = "0x42EF644", Offset = "0x42EB644", VA = "0x42EF644")]
		public static List<MaterialProperties> GetMaterialsProperties(GameObject forObject)
		{
			return null;
		}

		[Token(Token = "0x60051CA")]
		[Address(RVA = "0x42EFB40", Offset = "0x42EBB40", VA = "0x42EFB40")]
		public static void ChangeMaterialProperties(MaterialProperties changeTo, GameObject forObject)
		{
		}

		[Token(Token = "0x60051CB")]
		[Address(RVA = "0x42EA538", Offset = "0x42E6538", VA = "0x42EA538")]
		private static void SetParametersForSimplifier(SimplificationOptions simplificationOptions, MeshSimplifier meshSimplifier)
		{
		}

		[Token(Token = "0x60051CC")]
		[Address(RVA = "0x42E9FD4", Offset = "0x42E5FD4", VA = "0x42E9FD4")]
		private static bool AreAnyFeasibleMeshes(ObjectMeshPairs objectMeshPairs)
		{
			return default;
		}

		[Token(Token = "0x60051CD")]
		[Address(RVA = "0x42EFC20", Offset = "0x42EBC20", VA = "0x42EFC20")]
		private static void AssignReducedMesh(GameObject gameObject, Mesh originalMesh, Mesh reducedMesh, bool attachedToMeshfilter, bool assignBindposes)
		{
		}

		[Token(Token = "0x60051CE")]
		[Address(RVA = "0x42EA300", Offset = "0x42E6300", VA = "0x42EA300")]
		private static int CountTriangles(ObjectMeshPairs objectMeshPairs)
		{
			return default;
		}

		[Token(Token = "0x60051CF")]
		[Address(RVA = "0x42EFE0C", Offset = "0x42EBE0C", VA = "0x42EFE0C")]
		public PolyfewRuntime()
		{
		}
	}
}
