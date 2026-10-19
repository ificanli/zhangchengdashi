using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using BrainFailProductions.PolyFewRuntime;
using Il2CppDummyDll;
using UnityEngine;

namespace BrainFailProductions.PolyFew.AsImpL
{
	[Token(Token = "0x2000D0A")]
	public class ObjectImporter : MonoBehaviour
	{
		[Token(Token = "0x2000D0B")]
		private enum ImportPhase
		{
			[Token(Token = "0x4005D53")]
			Idle = 0,
			[Token(Token = "0x4005D54")]
			TextureImport = 1,
			[Token(Token = "0x4005D55")]
			ObjLoad = 2,
			[Token(Token = "0x4005D56")]
			AssetBuild = 3,
			[Token(Token = "0x4005D57")]
			Done = 4
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000D0C")]
		[CompilerGenerated]
		private struct _003CImportModelAsync_003Ed__31 : IAsyncStateMachine
		{
			[Token(Token = "0x4005D58")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005D59")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<GameObject> _003C_003Et__builder;

			[Token(Token = "0x4005D5A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ObjectImporter _003C_003E4__this;

			[Token(Token = "0x4005D5B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string filePath;

			[Token(Token = "0x4005D5C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public ImportOptions options;

			[Token(Token = "0x4005D5D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string objName;

			[Token(Token = "0x4005D5E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Transform parentObj;

			[Token(Token = "0x4005D5F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public string texturesFolderPath;

			[Token(Token = "0x4005D60")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public string materialsFolderPath;

			[Token(Token = "0x4005D61")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private TaskAwaiter<GameObject> _003C_003Eu__1;

			[Token(Token = "0x6005139")]
			[Address(RVA = "0x42D9E28", Offset = "0x42D5E28", VA = "0x42D9E28", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600513A")]
			[Address(RVA = "0x42DA334", Offset = "0x42D6334", VA = "0x42DA334", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000D0D")]
		[CompilerGenerated]
		private struct _003CImportModelFromNetwork_003Ed__32 : IAsyncStateMachine
		{
			[Token(Token = "0x4005D62")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005D63")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<GameObject> _003C_003Et__builder;

			[Token(Token = "0x4005D64")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ObjectImporter _003C_003E4__this;

			[Token(Token = "0x4005D65")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ImportOptions options;

			[Token(Token = "0x4005D66")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string objName;

			[Token(Token = "0x4005D67")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public PolyfewRuntime.ReferencedNumeric<float> downloadProgress;

			[Token(Token = "0x4005D68")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string objURL;

			[Token(Token = "0x4005D69")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public string diffuseTexURL;

			[Token(Token = "0x4005D6A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public string bumpTexURL;

			[Token(Token = "0x4005D6B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public string specularTexURL;

			[Token(Token = "0x4005D6C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public string opacityTexURL;

			[Token(Token = "0x4005D6D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public string materialURL;

			[Token(Token = "0x4005D6E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private TaskAwaiter<GameObject> _003C_003Eu__1;

			[Token(Token = "0x600513B")]
			[Address(RVA = "0x42DA3B0", Offset = "0x42D63B0", VA = "0x42DA3B0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600513C")]
			[Address(RVA = "0x42DA8BC", Offset = "0x42D68BC", VA = "0x42DA8BC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4005D42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static PolyfewRuntime.ReferencedNumeric<float> downloadProgress;

		[Token(Token = "0x4005D43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static int activeDownloads;

		[Token(Token = "0x4005D44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static float objDownloadProgress;

		[Token(Token = "0x4005D45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static float textureDownloadProgress;

		[Token(Token = "0x4005D46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private static float materialDownloadProgress;

		[Token(Token = "0x4005D47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static bool isException;

		[Token(Token = "0x4005D48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected int numTotalImports;

		[Token(Token = "0x4005D49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		protected bool allLoaded;

		[Token(Token = "0x4005D4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected ImportOptions buildOptions;

		[Token(Token = "0x4005D4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected List<Loader> loaderList;

		[Token(Token = "0x4005D4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ImportPhase importPhase;

		[Token(Token = "0x4005D4D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[CompilerGenerated]
		private Action m_ImportingStart;

		[Token(Token = "0x4005D4E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[CompilerGenerated]
		private Action m_ImportingComplete;

		[Token(Token = "0x4005D4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[CompilerGenerated]
		private Action<GameObject, string> m_CreatedModel;

		[Token(Token = "0x4005D50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[CompilerGenerated]
		private Action<GameObject, string> m_ImportedModel;

		[Token(Token = "0x4005D51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[CompilerGenerated]
		private Action<string> m_ImportError;

		[Token(Token = "0x17000E53")]
		public int NumImportRequests
		{
			[Token(Token = "0x600512E")]
			[Address(RVA = "0x42D94EC", Offset = "0x42D54EC", VA = "0x42D94EC")]
			get
			{
				return numTotalImports;
			}
		}

		[Token(Token = "0x1400000D")]
		public event Action ImportingStart
		{
			[Token(Token = "0x6005124")]
			[Address(RVA = "0x42D8E5C", Offset = "0x42D4E5C", VA = "0x42D8E5C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005125")]
			[Address(RVA = "0x42D8EF8", Offset = "0x42D4EF8", VA = "0x42D8EF8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400000E")]
		public event Action ImportingComplete
		{
			[Token(Token = "0x6005126")]
			[Address(RVA = "0x42D8F94", Offset = "0x42D4F94", VA = "0x42D8F94")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005127")]
			[Address(RVA = "0x42D9030", Offset = "0x42D5030", VA = "0x42D9030")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400000F")]
		public event Action<GameObject, string> CreatedModel
		{
			[Token(Token = "0x6005128")]
			[Address(RVA = "0x42D90CC", Offset = "0x42D50CC", VA = "0x42D90CC")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005129")]
			[Address(RVA = "0x42D917C", Offset = "0x42D517C", VA = "0x42D917C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000010")]
		public event Action<GameObject, string> ImportedModel
		{
			[Token(Token = "0x600512A")]
			[Address(RVA = "0x42D922C", Offset = "0x42D522C", VA = "0x42D922C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600512B")]
			[Address(RVA = "0x42D92DC", Offset = "0x42D52DC", VA = "0x42D92DC")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000011")]
		public event Action<string> ImportError
		{
			[Token(Token = "0x600512C")]
			[Address(RVA = "0x42D938C", Offset = "0x42D538C", VA = "0x42D938C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600512D")]
			[Address(RVA = "0x42D943C", Offset = "0x42D543C", VA = "0x42D943C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6005123")]
		[Address(RVA = "0x42D8D9C", Offset = "0x42D4D9C", VA = "0x42D8D9C")]
		public ObjectImporter()
		{
		}

		[Token(Token = "0x600512F")]
		[Address(RVA = "0x42D94F4", Offset = "0x42D54F4", VA = "0x42D94F4")]
		private Loader CreateLoader(string absolutePath, bool isNetwork = false)
		{
			return null;
		}

		[Token(Token = "0x6005130")]
		[Address(RVA = "0x42D8B64", Offset = "0x42D4B64", VA = "0x42D8B64")]
		[AsyncStateMachine(typeof(_003CImportModelAsync_003Ed__31))]
		public Task<GameObject> ImportModelAsync(string objName, string filePath, Transform parentObj, ImportOptions options, string texturesFolderPath = "", string materialsFolderPath = "")
		{
			return null;
		}

		[Token(Token = "0x6005131")]
		[Address(RVA = "0x42D97B4", Offset = "0x42D57B4", VA = "0x42D97B4")]
		[AsyncStateMachine(typeof(_003CImportModelFromNetwork_003Ed__32))]
		public Task<GameObject> ImportModelFromNetwork(string objURL, string objName, string diffuseTexURL, string bumpTexURL, string specularTexURL, string opacityTexURL, string materialURL, PolyfewRuntime.ReferencedNumeric<float> downloadProgress, ImportOptions options)
		{
			return null;
		}

		[Token(Token = "0x6005132")]
		[Address(RVA = "0x42D98F0", Offset = "0x42D58F0", VA = "0x42D98F0")]
		public void ImportModelFromNetworkWebGL(string objURL, string objName, string diffuseTexURL, string bumpTexURL, string specularTexURL, string opacityTexURL, string materialURL, PolyfewRuntime.ReferencedNumeric<float> downloadProgress, ImportOptions options, Action<GameObject> OnSuccess, Action<Exception> OnError)
		{
		}

		[Token(Token = "0x6005133")]
		[Address(RVA = "0x42D9B84", Offset = "0x42D5B84", VA = "0x42D9B84", Slot = "4")]
		public virtual void UpdateStatus()
		{
		}

		[Token(Token = "0x6005134")]
		[Address(RVA = "0x42D9DAC", Offset = "0x42D5DAC", VA = "0x42D9DAC", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6005135")]
		[Address(RVA = "0x42D9DB8", Offset = "0x42D5DB8", VA = "0x42D9DB8", Slot = "6")]
		protected virtual void OnImportingComplete()
		{
		}

		[Token(Token = "0x6005136")]
		[Address(RVA = "0x42D9DD4", Offset = "0x42D5DD4", VA = "0x42D9DD4", Slot = "7")]
		protected virtual void OnModelCreated(GameObject obj, string absolutePath)
		{
		}

		[Token(Token = "0x6005137")]
		[Address(RVA = "0x42D9DF0", Offset = "0x42D5DF0", VA = "0x42D9DF0", Slot = "8")]
		protected virtual void OnImported(GameObject obj, string absolutePath)
		{
		}

		[Token(Token = "0x6005138")]
		[Address(RVA = "0x42D9E0C", Offset = "0x42D5E0C", VA = "0x42D9E0C", Slot = "9")]
		protected virtual void OnImportError(string absolutePath)
		{
		}
	}
}
