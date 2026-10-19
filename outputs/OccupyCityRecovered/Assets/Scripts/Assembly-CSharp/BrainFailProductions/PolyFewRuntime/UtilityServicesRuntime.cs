using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using BrainFailProductions.PolyFew.AsImpL;
using Il2CppDummyDll;
using UnityEngine;

namespace BrainFailProductions.PolyFewRuntime
{
	[Token(Token = "0x2000D3E")]
	public class UtilityServicesRuntime : MonoBehaviour
	{
		[Token(Token = "0x2000D3F")]
		public class OBJExporterImporter
		{
			[StructLayout((LayoutKind)3)]
			[Token(Token = "0x2000D41")]
			[CompilerGenerated]
			private struct _003CExportMeshToOBJ_003Ed__15 : IAsyncStateMachine
			{
				[Token(Token = "0x4005E9A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public int _003C_003E1__state;

				[Token(Token = "0x4005E9B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public AsyncTaskMethodBuilder _003C_003Et__builder;

				[Token(Token = "0x4005E9C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public OBJExporterImporter _003C_003E4__this;

				[Token(Token = "0x4005E9D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				public Mesh mesh;

				[Token(Token = "0x4005E9E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				public string exportPath;

				[Token(Token = "0x4005E9F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
				private string _003CobjectName_003E5__2;

				[Token(Token = "0x4005EA0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
				private StringBuilder _003Csb_003E5__3;

				[Token(Token = "0x4005EA1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
				private int _003ClastIndex_003E5__4;

				[Token(Token = "0x4005EA2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
				private int _003CfaceOrder_003E5__5;

				[Token(Token = "0x4005EA3")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
				private Vector3[] _003C_003E7__wrap5;

				[Token(Token = "0x4005EA4")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
				private int _003C_003E7__wrap6;

				[Token(Token = "0x4005EA5")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
				private Vector3 _003Cvx_003E5__8;

				[Token(Token = "0x4005EA6")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
				private TaskAwaiter _003C_003Eu__1;

				[Token(Token = "0x4005EA7")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
				private Vector2[] _003C_003E7__wrap8;

				[Token(Token = "0x4005EA8")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
				private Vector2 _003Cv_003E5__10;

				[Token(Token = "0x4005EA9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
				private int[] _003Ctris_003E5__11;

				[Token(Token = "0x4005EAA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
				private int _003Ct_003E5__12;

				[Token(Token = "0x6005229")]
				[Address(RVA = "0x42F67C4", Offset = "0x42F27C4", VA = "0x42F67C4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
				{
				}

				[Token(Token = "0x600522A")]
				[Address(RVA = "0x42F76D0", Offset = "0x42F36D0", VA = "0x42F76D0", Slot = "5")]
				[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Token(Token = "0x2000D42")]
			[CompilerGenerated]
			private struct _003CImportFromLocalFileSystem_003Ed__20 : IAsyncStateMachine
			{
				[Token(Token = "0x4005EAB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public int _003C_003E1__state;

				[Token(Token = "0x4005EAC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public AsyncTaskMethodBuilder _003C_003Et__builder;

				[Token(Token = "0x4005EAD")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public string objPath;

				[Token(Token = "0x4005EAE")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				public string texturesFolderPath;

				[Token(Token = "0x4005EAF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				public string materialsFolderPath;

				[Token(Token = "0x4005EB0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
				public PolyfewRuntime.OBJImportOptions importOptions;

				[Token(Token = "0x4005EB1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
				public Action<GameObject> Callback;

				[Token(Token = "0x4005EB2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
				private GameObject _003CobjectToPopulate_003E5__2;

				[Token(Token = "0x4005EB3")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
				private ObjectImporter _003CobjImporter_003E5__3;

				[Token(Token = "0x4005EB4")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
				private TaskAwaiter<GameObject> _003C_003Eu__1;

				[Token(Token = "0x600522B")]
				[Address(RVA = "0x42F7738", Offset = "0x42F3738", VA = "0x42F7738", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
				{
				}

				[Token(Token = "0x600522C")]
				[Address(RVA = "0x42F8208", Offset = "0x42F4208", VA = "0x42F8208", Slot = "5")]
				[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Token(Token = "0x2000D43")]
			[CompilerGenerated]
			private struct _003CImportFromNetwork_003Ed__21 : IAsyncStateMachine
			{
				[Token(Token = "0x4005EB5")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public int _003C_003E1__state;

				[Token(Token = "0x4005EB6")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public AsyncVoidMethodBuilder _003C_003Et__builder;

				[Token(Token = "0x4005EB7")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				public string objURL;

				[Token(Token = "0x4005EB8")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				public string diffuseTexURL;

				[Token(Token = "0x4005EB9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
				public string materialURL;

				[Token(Token = "0x4005EBA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
				public PolyfewRuntime.ReferencedNumeric<float> downloadProgress;

				[Token(Token = "0x4005EBB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
				public PolyfewRuntime.OBJImportOptions importOptions;

				[Token(Token = "0x4005EBC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
				public string objName;

				[Token(Token = "0x4005EBD")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
				public string bumpTexURL;

				[Token(Token = "0x4005EBE")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
				public string specularTexURL;

				[Token(Token = "0x4005EBF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
				public string opacityTexURL;

				[Token(Token = "0x4005EC0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
				public Action<GameObject> OnSuccess;

				[Token(Token = "0x4005EC1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
				public Action<Exception> OnError;

				[Token(Token = "0x4005EC2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
				private GameObject _003CobjectToPopulate_003E5__2;

				[Token(Token = "0x4005EC3")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
				private ObjectImporter _003CobjImporter_003E5__3;

				[Token(Token = "0x4005EC4")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
				private TaskAwaiter<GameObject> _003C_003Eu__1;

				[Token(Token = "0x600522D")]
				[Address(RVA = "0x42F8270", Offset = "0x42F4270", VA = "0x42F8270", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
				{
				}

				[Token(Token = "0x600522E")]
				[Address(RVA = "0x42F87B4", Offset = "0x42F47B4", VA = "0x42F87B4", Slot = "5")]
				[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Token(Token = "0x2000D44")]
			[CompilerGenerated]
			private struct _003CImportFromNetworkWebGL_003Ed__22 : IAsyncStateMachine
			{
				[Token(Token = "0x4005EC5")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public int _003C_003E1__state;

				[Token(Token = "0x4005EC6")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public AsyncVoidMethodBuilder _003C_003Et__builder;

				[Token(Token = "0x4005EC7")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				public Action<GameObject> OnSuccess;

				[Token(Token = "0x4005EC8")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				public Action<Exception> OnError;

				[Token(Token = "0x4005EC9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
				public string objURL;

				[Token(Token = "0x4005ECA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
				public string diffuseTexURL;

				[Token(Token = "0x4005ECB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
				public string materialURL;

				[Token(Token = "0x4005ECC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
				public PolyfewRuntime.ReferencedNumeric<float> downloadProgress;

				[Token(Token = "0x4005ECD")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
				public PolyfewRuntime.OBJImportOptions importOptions;

				[Token(Token = "0x4005ECE")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
				public string objName;

				[Token(Token = "0x4005ECF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
				public string bumpTexURL;

				[Token(Token = "0x4005ED0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
				public string specularTexURL;

				[Token(Token = "0x4005ED1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
				public string opacityTexURL;

				[Token(Token = "0x600522F")]
				[Address(RVA = "0x42F87C0", Offset = "0x42F47C0", VA = "0x42F87C0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
				{
				}

				[Token(Token = "0x6005230")]
				[Address(RVA = "0x42F8C6C", Offset = "0x42F4C6C", VA = "0x42F8C6C", Slot = "5")]
				[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Token(Token = "0x4005E8D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private bool applyPosition;

			[Token(Token = "0x4005E8E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
			private bool applyRotation;

			[Token(Token = "0x4005E8F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
			private bool applyScale;

			[Token(Token = "0x4005E90")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x13")]
			private bool generateMaterials;

			[Token(Token = "0x4005E91")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private bool exportTextures;

			[Token(Token = "0x4005E92")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private string exportPath;

			[Token(Token = "0x4005E93")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private MeshFilter meshFilter;

			[Token(Token = "0x4005E94")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Mesh meshToExport;

			[Token(Token = "0x4005E95")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private MeshRenderer meshRenderer;

			[Token(Token = "0x6005218")]
			[Address(RVA = "0x42F3124", Offset = "0x42EF124", VA = "0x42F3124")]
			public OBJExporterImporter()
			{
			}

			[Token(Token = "0x6005219")]
			[Address(RVA = "0x42F547C", Offset = "0x42F147C", VA = "0x42F547C")]
			private void InitializeExporter(GameObject toExport, string exportPath, PolyfewRuntime.OBJExportOptions exportOptions)
			{
			}

			[Token(Token = "0x600521A")]
			[Address(RVA = "0x42F57F4", Offset = "0x42F17F4", VA = "0x42F57F4")]
			private void InitializeExporter(Mesh toExport, string exportPath)
			{
			}

			[Token(Token = "0x600521B")]
			[Address(RVA = "0x42F59AC", Offset = "0x42F19AC", VA = "0x42F59AC")]
			private Vector3 RotateAroundPoint(Vector3 point, Vector3 pivot, Quaternion angle)
			{
				return default;
			}

			[Token(Token = "0x600521C")]
			[Address(RVA = "0x42F5A08", Offset = "0x42F1A08", VA = "0x42F5A08")]
			private Vector3 MultiplyVec3s(Vector3 v1, Vector3 v2)
			{
				return default;
			}

			[Token(Token = "0x600521D")]
			[Address(RVA = "0x42F3138", Offset = "0x42EF138", VA = "0x42F3138")]
			public void ExportGameObjectToOBJ(GameObject toExport, string exportPath, [Optional] PolyfewRuntime.OBJExportOptions exportOptions, [Optional] Action OnSuccess)
			{
			}

			[Token(Token = "0x600521E")]
			[Address(RVA = "0x42F60A4", Offset = "0x42F20A4", VA = "0x42F60A4")]
			[AsyncStateMachine(typeof(_003CExportMeshToOBJ_003Ed__15))]
			public Task ExportMeshToOBJ(Mesh mesh, string exportPath)
			{
				return null;
			}

			[Token(Token = "0x600521F")]
			[Address(RVA = "0x42F6184", Offset = "0x42F2184", VA = "0x42F6184")]
			private string TryExportTexture(string propertyName, Material m, string exportPath)
			{
				return null;
			}

			[Token(Token = "0x6005220")]
			[Address(RVA = "0x42F628C", Offset = "0x42F228C", VA = "0x42F628C")]
			private string ExportTexture(Texture2D t, string exportPath)
			{
				return null;
			}

			[Token(Token = "0x6005221")]
			[Address(RVA = "0x42F5FD8", Offset = "0x42F1FD8", VA = "0x42F5FD8")]
			private string ConstructOBJString(int index)
			{
				return null;
			}

			[Token(Token = "0x6005222")]
			[Address(RVA = "0x42F5A18", Offset = "0x42F1A18", VA = "0x42F5A18")]
			private string MaterialToString(Material m)
			{
				return null;
			}

			[Token(Token = "0x6005223")]
			[Address(RVA = "0x42F4388", Offset = "0x42F0388", VA = "0x42F4388")]
			[AsyncStateMachine(typeof(_003CImportFromLocalFileSystem_003Ed__20))]
			public Task ImportFromLocalFileSystem(string objPath, string texturesFolderPath, string materialsFolderPath, Action<GameObject> Callback, [Optional] PolyfewRuntime.OBJImportOptions importOptions)
			{
				return null;
			}

			[Token(Token = "0x6005224")]
			[Address(RVA = "0x42F47D4", Offset = "0x42F07D4", VA = "0x42F47D4")]
			[AsyncStateMachine(typeof(_003CImportFromNetwork_003Ed__21))]
			public void ImportFromNetwork(string objURL, string objName, string diffuseTexURL, string bumpTexURL, string specularTexURL, string opacityTexURL, string materialURL, PolyfewRuntime.ReferencedNumeric<float> downloadProgress, Action<GameObject> OnSuccess, Action<Exception> OnError, [Optional] PolyfewRuntime.OBJImportOptions importOptions)
			{
			}

			[Token(Token = "0x6005225")]
			[Address(RVA = "0x42F65C0", Offset = "0x42F25C0", VA = "0x42F65C0")]
			[AsyncStateMachine(typeof(_003CImportFromNetworkWebGL_003Ed__22))]
			public void ImportFromNetworkWebGL(string objURL, string objName, string diffuseTexURL, string bumpTexURL, string specularTexURL, string opacityTexURL, string materialURL, PolyfewRuntime.ReferencedNumeric<float> downloadProgress, Action<GameObject> OnSuccess, Action<Exception> OnError, [Optional] PolyfewRuntime.OBJImportOptions importOptions)
			{
			}
		}

		[Token(Token = "0x6005210")]
		[Address(RVA = "0x42F48CC", Offset = "0x42F08CC", VA = "0x42F48CC")]
		public static Texture2D DuplicateTexture(Texture2D source)
		{
			return null;
		}

		[Token(Token = "0x6005211")]
		[Address(RVA = "0x42F4A70", Offset = "0x42F0A70", VA = "0x42F4A70")]
		public static Renderer[] GetChildRenderersForCombining(GameObject forObject, bool skipInactiveChildObjects)
		{
			return null;
		}

		[Token(Token = "0x6005212")]
		[Address(RVA = "0x42F4E94", Offset = "0x42F0E94", VA = "0x42F4E94")]
		public static MeshRenderer CreateStaticLevelRenderer(string name, Transform parentTransform, Transform originalTransform, Mesh mesh, Material[] materials)
		{
			return null;
		}

		[Token(Token = "0x6005213")]
		[Address(RVA = "0x42F5258", Offset = "0x42F1258", VA = "0x42F5258")]
		public static SkinnedMeshRenderer CreateSkinnedLevelRenderer(string name, Transform parentTransform, Transform originalTransform, Mesh mesh, Material[] materials, Transform rootBone, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6005214")]
		[Address(RVA = "0x42F4C6C", Offset = "0x42F0C6C", VA = "0x42F4C6C")]
		private static void CollectChildRenderersForCombining(Transform transform, List<Renderer> resultRenderers, bool skipInactiveChildObjects)
		{
		}

		[Token(Token = "0x6005215")]
		[Address(RVA = "0x42F5170", Offset = "0x42F1170", VA = "0x42F5170")]
		private static void ParentAndResetTransform(Transform transform, Transform parentTransform)
		{
		}

		[Token(Token = "0x6005216")]
		[Address(RVA = "0x42F50EC", Offset = "0x42F10EC", VA = "0x42F50EC")]
		public static void ParentAndOffsetTransform(Transform transform, Transform parentTransform, Transform originalTransform)
		{
		}

		[Token(Token = "0x6005217")]
		[Address(RVA = "0x42F5474", Offset = "0x42F1474", VA = "0x42F5474")]
		public UtilityServicesRuntime()
		{
		}
	}
}
