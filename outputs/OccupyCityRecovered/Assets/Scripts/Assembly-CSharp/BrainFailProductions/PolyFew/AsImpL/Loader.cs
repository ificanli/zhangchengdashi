using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using BrainFailProductions.PolyFewRuntime;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Networking;

namespace BrainFailProductions.PolyFew.AsImpL
{
	[Token(Token = "0x2000CE5")]
	public abstract class Loader : MonoBehaviour
	{
		[Token(Token = "0x2000CE6")]
		protected struct BuildStats
		{
			[Token(Token = "0x4005C4F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float texturesTime;

			[Token(Token = "0x4005C50")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public float materialsTime;

			[Token(Token = "0x4005C51")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float objectsTime;
		}

		[Token(Token = "0x2000CE7")]
		protected struct Stats
		{
			[Token(Token = "0x4005C52")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float modelParseTime;

			[Token(Token = "0x4005C53")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public float materialsParseTime;

			[Token(Token = "0x4005C54")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float buildTime;

			[Token(Token = "0x4005C55")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public BuildStats buildStats;

			[Token(Token = "0x4005C56")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float totalTime;
		}

		[Token(Token = "0x2000CE8")]
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass52_0
		{
			[Token(Token = "0x4005C57")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool isWorking;

			[Token(Token = "0x4005C58")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public byte[] downloadedBytes;

			[Token(Token = "0x600509D")]
			[Address(RVA = "0x42CAFA8", Offset = "0x42C6FA8", VA = "0x42CAFA8")]
			public _003C_003Ec__DisplayClass52_0()
			{
			}

			[Token(Token = "0x600509E")]
			[Address(RVA = "0x42CAFB0", Offset = "0x42C6FB0", VA = "0x42CAFB0")]
			internal void _003CLoadMaterialTexture_003Eb__0(byte[] bytes)
			{
			}

			[Token(Token = "0x600509F")]
			[Address(RVA = "0x42CAFBC", Offset = "0x42C6FBC", VA = "0x42CAFBC")]
			internal void _003CLoadMaterialTexture_003Eb__1(string error)
			{
			}
		}

		[Token(Token = "0x2000CE9")]
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass53_0
		{
			[Token(Token = "0x4005C59")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool isWorking;

			[Token(Token = "0x4005C5A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Loader _003C_003E4__this;

			[Token(Token = "0x60050A0")]
			[Address(RVA = "0x42CB080", Offset = "0x42C7080", VA = "0x42CB080")]
			public _003C_003Ec__DisplayClass53_0()
			{
			}

			[Token(Token = "0x60050A1")]
			[Address(RVA = "0x42CB088", Offset = "0x42C7088", VA = "0x42CB088")]
			internal void _003CLoadMaterialTextureWebGL_003Eb__0(Texture2D texture)
			{
			}

			[Token(Token = "0x60050A2")]
			[Address(RVA = "0x42CB0A8", Offset = "0x42C70A8", VA = "0x42CB0A8")]
			internal void _003CLoadMaterialTextureWebGL_003Eb__1(string error)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000CEA")]
		[CompilerGenerated]
		private struct _003CBuild_003Ed__43 : IAsyncStateMachine
		{
			[Token(Token = "0x4005C5B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005C5C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005C5D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Loader _003C_003E4__this;

			[Token(Token = "0x4005C5E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string absolutePath;

			[Token(Token = "0x4005C5F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string texturesFolderPath;

			[Token(Token = "0x4005C60")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string objName;

			[Token(Token = "0x4005C61")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Transform parentTransform;

			[Token(Token = "0x4005C62")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float _003CprevTime_003E5__2;

			[Token(Token = "0x4005C63")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private string _003CbasePath_003E5__3;

			[Token(Token = "0x4005C64")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private int _003Ccount_003E5__4;

			[Token(Token = "0x4005C65")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private List<MaterialData>.Enumerator _003C_003E7__wrap4;

			[Token(Token = "0x4005C66")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private MaterialData _003Cmtl_003E5__6;

			[Token(Token = "0x4005C67")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private TaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x60050A3")]
			[Address(RVA = "0x42CB16C", Offset = "0x42C716C", VA = "0x42CB16C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60050A4")]
			[Address(RVA = "0x42CBE3C", Offset = "0x42C7E3C", VA = "0x42CBE3C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x2000CEB")]
		[CompilerGenerated]
		private sealed class _003CDownloadFile_003Ed__57 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4005C68")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4005C69")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4005C6A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PolyfewRuntime.ReferencedNumeric<float> downloadProgress;

			[Token(Token = "0x4005C6B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string url;

			[Token(Token = "0x4005C6C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action<string> OnError;

			[Token(Token = "0x4005C6D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Loader _003C_003E4__this;

			[Token(Token = "0x4005C6E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Action<byte[]> DownloadComplete;

			[Token(Token = "0x4005C6F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UnityWebRequest _003Cwebrequest_003E5__2;

			[Token(Token = "0x4005C70")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private float _003ColdProgress_003E5__3;

			[Token(Token = "0x4005C71")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Coroutine _003Cprogress_003E5__4;

			[Token(Token = "0x17000E3D")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60050A8")]
				[Address(RVA = "0x42CC1FC", Offset = "0x42C81FC", VA = "0x42CC1FC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000E3E")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60050AA")]
				[Address(RVA = "0x42CC23C", Offset = "0x42C823C", VA = "0x42CC23C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60050A5")]
			[Address(RVA = "0x42CAB64", Offset = "0x42C6B64", VA = "0x42CAB64")]
			[DebuggerHidden]
			public _003CDownloadFile_003Ed__57(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60050A6")]
			[Address(RVA = "0x42CBEA4", Offset = "0x42C7EA4", VA = "0x42CBEA4", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60050A7")]
			[Address(RVA = "0x42CBEA8", Offset = "0x42C7EA8", VA = "0x42CBEA8", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60050A8")]
			[Address(RVA = "0x42CC1FC", Offset = "0x42C81FC", VA = "0x42CC1FC", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60050A9")]
			[Address(RVA = "0x42CC204", Offset = "0x42C8204", VA = "0x42CC204", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60050AA")]
			[Address(RVA = "0x42CC23C", Offset = "0x42C823C", VA = "0x42CC23C", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x2000CEC")]
		[CompilerGenerated]
		private sealed class _003CDownloadFileWebGL_003Ed__59 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4005C72")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4005C73")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4005C74")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PolyfewRuntime.ReferencedNumeric<float> downloadProgress;

			[Token(Token = "0x4005C75")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string url;

			[Token(Token = "0x4005C76")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action<string> OnError;

			[Token(Token = "0x4005C77")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Loader _003C_003E4__this;

			[Token(Token = "0x4005C78")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Action<string> DownloadComplete;

			[Token(Token = "0x4005C79")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UnityWebRequest _003Cwebrequest_003E5__2;

			[Token(Token = "0x4005C7A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private float _003ColdProgress_003E5__3;

			[Token(Token = "0x4005C7B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Coroutine _003Cprogress_003E5__4;

			[Token(Token = "0x17000E3F")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60050AE")]
				[Address(RVA = "0x42CC608", Offset = "0x42C8608", VA = "0x42CC608", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000E40")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60050B0")]
				[Address(RVA = "0x42CC648", Offset = "0x42C8648", VA = "0x42CC648", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60050AB")]
			[Address(RVA = "0x42CACA8", Offset = "0x42C6CA8", VA = "0x42CACA8")]
			[DebuggerHidden]
			public _003CDownloadFileWebGL_003Ed__59(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60050AC")]
			[Address(RVA = "0x42CC244", Offset = "0x42C8244", VA = "0x42CC244", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60050AD")]
			[Address(RVA = "0x42CC248", Offset = "0x42C8248", VA = "0x42CC248", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60050AE")]
			[Address(RVA = "0x42CC608", Offset = "0x42C8608", VA = "0x42CC608", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60050AF")]
			[Address(RVA = "0x42CC610", Offset = "0x42C8610", VA = "0x42CC610", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60050B0")]
			[Address(RVA = "0x42CC648", Offset = "0x42C8648", VA = "0x42CC648", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x2000CED")]
		[CompilerGenerated]
		private sealed class _003CDownloadTexFileWebGL_003Ed__60 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4005C7C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4005C7D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4005C7E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PolyfewRuntime.ReferencedNumeric<float> downloadProgress;

			[Token(Token = "0x4005C7F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string url;

			[Token(Token = "0x4005C80")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action<string> OnError;

			[Token(Token = "0x4005C81")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Loader _003C_003E4__this;

			[Token(Token = "0x4005C82")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Action<Texture2D> DownloadComplete;

			[Token(Token = "0x4005C83")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UnityWebRequest _003Cwebrequest_003E5__2;

			[Token(Token = "0x4005C84")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private float _003ColdProgress_003E5__3;

			[Token(Token = "0x4005C85")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Coroutine _003Cprogress_003E5__4;

			[Token(Token = "0x17000E41")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60050B4")]
				[Address(RVA = "0x42CC9C4", Offset = "0x42C89C4", VA = "0x42CC9C4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000E42")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60050B6")]
				[Address(RVA = "0x42CCA04", Offset = "0x42C8A04", VA = "0x42CCA04", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60050B1")]
			[Address(RVA = "0x42CAD58", Offset = "0x42C6D58", VA = "0x42CAD58")]
			[DebuggerHidden]
			public _003CDownloadTexFileWebGL_003Ed__60(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60050B2")]
			[Address(RVA = "0x42CC650", Offset = "0x42C8650", VA = "0x42CC650", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60050B3")]
			[Address(RVA = "0x42CC654", Offset = "0x42C8654", VA = "0x42CC654", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60050B4")]
			[Address(RVA = "0x42CC9C4", Offset = "0x42C89C4", VA = "0x42CC9C4", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60050B5")]
			[Address(RVA = "0x42CC9CC", Offset = "0x42C89CC", VA = "0x42CC9CC", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60050B6")]
			[Address(RVA = "0x42CCA04", Offset = "0x42C8A04", VA = "0x42CCA04", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x2000CEE")]
		[CompilerGenerated]
		private sealed class _003CGetProgress_003Ed__58 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4005C86")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4005C87")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4005C88")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PolyfewRuntime.ReferencedNumeric<float> downloadProgress;

			[Token(Token = "0x4005C89")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public UnityWebRequest webrequest;

			[Token(Token = "0x4005C8A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float _003ColdProgress_003E5__2;

			[Token(Token = "0x17000E43")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60050BA")]
				[Address(RVA = "0x42CCBA8", Offset = "0x42C8BA8", VA = "0x42CCBA8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000E44")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60050BC")]
				[Address(RVA = "0x42CCBE8", Offset = "0x42C8BE8", VA = "0x42CCBE8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60050B7")]
			[Address(RVA = "0x42CABF8", Offset = "0x42C6BF8", VA = "0x42CABF8")]
			[DebuggerHidden]
			public _003CGetProgress_003Ed__58(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60050B8")]
			[Address(RVA = "0x42CCA0C", Offset = "0x42C8A0C", VA = "0x42CCA0C", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60050B9")]
			[Address(RVA = "0x42CCA10", Offset = "0x42C8A10", VA = "0x42CCA10", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60050BA")]
			[Address(RVA = "0x42CCBA8", Offset = "0x42C8BA8", VA = "0x42CCBA8", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60050BB")]
			[Address(RVA = "0x42CCBB0", Offset = "0x42C8BB0", VA = "0x42CCBB0", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60050BC")]
			[Address(RVA = "0x42CCBE8", Offset = "0x42C8BE8", VA = "0x42CCBE8", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000CEF")]
		[CompilerGenerated]
		private struct _003CLoad_003Ed__33 : IAsyncStateMachine
		{
			[Token(Token = "0x4005C8B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005C8C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<GameObject> _003C_003Et__builder;

			[Token(Token = "0x4005C8D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string objAbsolutePath;

			[Token(Token = "0x4005C8E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string objName;

			[Token(Token = "0x4005C8F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Loader _003C_003E4__this;

			[Token(Token = "0x4005C90")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string texturesFolderPath;

			[Token(Token = "0x4005C91")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string materialsFolderPath;

			[Token(Token = "0x4005C92")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Transform parentObj;

			[Token(Token = "0x4005C93")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private float _003ClastTime_003E5__2;

			[Token(Token = "0x4005C94")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private float _003CstartTime_003E5__3;

			[Token(Token = "0x4005C95")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private YieldAwaitable.YieldAwaiter _003C_003Eu__1;

			[Token(Token = "0x4005C96")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private TaskAwaiter _003C_003Eu__2;

			[Token(Token = "0x60050BD")]
			[Address(RVA = "0x42CCBF0", Offset = "0x42C8BF0", VA = "0x42CCBF0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60050BE")]
			[Address(RVA = "0x42CD4B8", Offset = "0x42C94B8", VA = "0x42CD4B8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000CF0")]
		[CompilerGenerated]
		private struct _003CLoadFromNetwork_003Ed__34 : IAsyncStateMachine
		{
			[Token(Token = "0x4005C97")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005C98")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<GameObject> _003C_003Et__builder;

			[Token(Token = "0x4005C99")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string objName;

			[Token(Token = "0x4005C9A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Loader _003C_003E4__this;

			[Token(Token = "0x4005C9B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string objURL;

			[Token(Token = "0x4005C9C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string materialURL;

			[Token(Token = "0x4005C9D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string diffuseTexURL;

			[Token(Token = "0x4005C9E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public string bumpTexURL;

			[Token(Token = "0x4005C9F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public string specularTexURL;

			[Token(Token = "0x4005CA0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public string opacityTexURL;

			[Token(Token = "0x4005CA1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private float _003ClastTime_003E5__2;

			[Token(Token = "0x4005CA2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			private float _003CstartTime_003E5__3;

			[Token(Token = "0x4005CA3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private YieldAwaitable.YieldAwaiter _003C_003Eu__1;

			[Token(Token = "0x4005CA4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private TaskAwaiter _003C_003Eu__2;

			[Token(Token = "0x60050BF")]
			[Address(RVA = "0x42CD534", Offset = "0x42C9534", VA = "0x42CD534", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60050C0")]
			[Address(RVA = "0x42CDF88", Offset = "0x42C9F88", VA = "0x42CDF88", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x2000CF1")]
		[CompilerGenerated]
		private sealed class _003CLoadFromNetworkWebGL_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4005CA5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4005CA6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4005CA7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string objName;

			[Token(Token = "0x4005CA8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Loader _003C_003E4__this;

			[Token(Token = "0x4005CA9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string objURL;

			[Token(Token = "0x4005CAA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Action<Exception> OnError;

			[Token(Token = "0x4005CAB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string materialURL;

			[Token(Token = "0x4005CAC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public string diffuseTexURL;

			[Token(Token = "0x4005CAD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public string bumpTexURL;

			[Token(Token = "0x4005CAE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public string specularTexURL;

			[Token(Token = "0x4005CAF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public string opacityTexURL;

			[Token(Token = "0x4005CB0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Action<GameObject> OnSuccess;

			[Token(Token = "0x4005CB1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private float _003ClastTime_003E5__2;

			[Token(Token = "0x4005CB2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private float _003CstartTime_003E5__3;

			[Token(Token = "0x17000E45")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60050C4")]
				[Address(RVA = "0x42CE574", Offset = "0x42CA574", VA = "0x42CE574", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000E46")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60050C6")]
				[Address(RVA = "0x42CE5B4", Offset = "0x42CA5B4", VA = "0x42CE5B4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60050C1")]
			[Address(RVA = "0x42C9CD0", Offset = "0x42C5CD0", VA = "0x42C9CD0")]
			[DebuggerHidden]
			public _003CLoadFromNetworkWebGL_003Ed__35(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60050C2")]
			[Address(RVA = "0x42CE004", Offset = "0x42CA004", VA = "0x42CE004", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60050C3")]
			[Address(RVA = "0x42CE008", Offset = "0x42CA008", VA = "0x42CE008", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60050C4")]
			[Address(RVA = "0x42CE574", Offset = "0x42CA574", VA = "0x42CE574", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60050C5")]
			[Address(RVA = "0x42CE57C", Offset = "0x42CA57C", VA = "0x42CE57C", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60050C6")]
			[Address(RVA = "0x42CE5B4", Offset = "0x42CA5B4", VA = "0x42CE5B4", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000CF2")]
		[CompilerGenerated]
		private struct _003CLoadMaterialTexture_003Ed__51 : IAsyncStateMachine
		{
			[Token(Token = "0x4005CB3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005CB4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005CB5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Loader _003C_003E4__this;

			[Token(Token = "0x4005CB6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string texturesFolderPath;

			[Token(Token = "0x4005CB7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string basePath;

			[Token(Token = "0x4005CB8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string path;

			[Token(Token = "0x4005CB9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private byte[] _003Cresult_003E5__2;

			[Token(Token = "0x4005CBA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private FileStream _003Cstream_003E5__3;

			[Token(Token = "0x4005CBB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private TaskAwaiter<int> _003C_003Eu__1;

			[Token(Token = "0x60050C7")]
			[Address(RVA = "0x42CE5BC", Offset = "0x42CA5BC", VA = "0x42CE5BC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60050C8")]
			[Address(RVA = "0x42CEC40", Offset = "0x42CAC40", VA = "0x42CEC40", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000CF3")]
		[CompilerGenerated]
		private struct _003CLoadMaterialTexture_003Ed__52 : IAsyncStateMachine
		{
			[Token(Token = "0x4005CBC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005CBD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005CBE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Loader _003C_003E4__this;

			[Token(Token = "0x4005CBF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string textureURL;

			[Token(Token = "0x4005CC0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private _003C_003Ec__DisplayClass52_0 _003C_003E8__1;

			[Token(Token = "0x4005CC1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private TaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x60050C9")]
			[Address(RVA = "0x42CECA8", Offset = "0x42CACA8", VA = "0x42CECA8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60050CA")]
			[Address(RVA = "0x42CF2F4", Offset = "0x42CB2F4", VA = "0x42CF2F4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x2000CF4")]
		[CompilerGenerated]
		private sealed class _003CLoadMaterialTextureWebGL_003Ed__53 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4005CC2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4005CC3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4005CC4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Loader _003C_003E4__this;

			[Token(Token = "0x4005CC5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string textureURL;

			[Token(Token = "0x4005CC6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private _003C_003Ec__DisplayClass53_0 _003C_003E8__1;

			[Token(Token = "0x17000E47")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60050CE")]
				[Address(RVA = "0x42CF7BC", Offset = "0x42CB7BC", VA = "0x42CF7BC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000E48")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60050D0")]
				[Address(RVA = "0x42CF7FC", Offset = "0x42CB7FC", VA = "0x42CF7FC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60050CB")]
			[Address(RVA = "0x42CA820", Offset = "0x42C6820", VA = "0x42CA820")]
			[DebuggerHidden]
			public _003CLoadMaterialTextureWebGL_003Ed__53(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60050CC")]
			[Address(RVA = "0x42CF35C", Offset = "0x42CB35C", VA = "0x42CF35C", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60050CD")]
			[Address(RVA = "0x42CF360", Offset = "0x42CB360", VA = "0x42CF360", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60050CE")]
			[Address(RVA = "0x42CF7BC", Offset = "0x42CB7BC", VA = "0x42CF7BC", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60050CF")]
			[Address(RVA = "0x42CF7C4", Offset = "0x42CB7C4", VA = "0x42CF7C4", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60050D0")]
			[Address(RVA = "0x42CF7FC", Offset = "0x42CB7FC", VA = "0x42CF7FC", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000CF5")]
		[CompilerGenerated]
		private struct _003CNetworkedBuild_003Ed__44 : IAsyncStateMachine
		{
			[Token(Token = "0x4005CC7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005CC8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005CC9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Loader _003C_003E4__this;

			[Token(Token = "0x4005CCA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string diffuseTexURL;

			[Token(Token = "0x4005CCB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string bumpTexURL;

			[Token(Token = "0x4005CCC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string specularTexURL;

			[Token(Token = "0x4005CCD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string opacityTexURL;

			[Token(Token = "0x4005CCE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public string objName;

			[Token(Token = "0x4005CCF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Transform parentTransform;

			[Token(Token = "0x4005CD0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public string objURL;

			[Token(Token = "0x4005CD1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private float _003CprevTime_003E5__2;

			[Token(Token = "0x4005CD2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private ObjectBuilder.ProgressInfo _003Cinfo_003E5__3;

			[Token(Token = "0x4005CD3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private float _003CobjInitPerc_003E5__4;

			[Token(Token = "0x4005CD4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private GameObject _003CnewObj_003E5__5;

			[Token(Token = "0x4005CD5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private float _003CinitProgress_003E5__6;

			[Token(Token = "0x4005CD6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private int _003Ccount_003E5__7;

			[Token(Token = "0x4005CD7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private List<MaterialData>.Enumerator _003C_003E7__wrap7;

			[Token(Token = "0x4005CD8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private MaterialData _003Cmtl_003E5__9;

			[Token(Token = "0x4005CD9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private TaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x60050D1")]
			[Address(RVA = "0x42CF804", Offset = "0x42CB804", VA = "0x42CF804", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60050D2")]
			[Address(RVA = "0x42D0BB0", Offset = "0x42CCBB0", VA = "0x42D0BB0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x2000CF6")]
		[CompilerGenerated]
		private sealed class _003CNetworkedBuildWebGL_003Ed__45 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4005CDA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4005CDB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4005CDC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Loader _003C_003E4__this;

			[Token(Token = "0x4005CDD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string diffuseTexURL;

			[Token(Token = "0x4005CDE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string bumpTexURL;

			[Token(Token = "0x4005CDF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string specularTexURL;

			[Token(Token = "0x4005CE0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string opacityTexURL;

			[Token(Token = "0x4005CE1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public string objName;

			[Token(Token = "0x4005CE2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Transform parentTransform;

			[Token(Token = "0x4005CE3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public string objURL;

			[Token(Token = "0x4005CE4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private float _003CprevTime_003E5__2;

			[Token(Token = "0x4005CE5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			private int _003Ccount_003E5__3;

			[Token(Token = "0x4005CE6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private List<MaterialData>.Enumerator _003C_003E7__wrap3;

			[Token(Token = "0x4005CE7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private MaterialData _003Cmtl_003E5__5;

			[Token(Token = "0x17000E49")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60050D7")]
				[Address(RVA = "0x42D186C", Offset = "0x42CD86C", VA = "0x42D186C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000E4A")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60050D9")]
				[Address(RVA = "0x42D18AC", Offset = "0x42CD8AC", VA = "0x42D18AC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60050D3")]
			[Address(RVA = "0x42C9FA4", Offset = "0x42C5FA4", VA = "0x42C9FA4")]
			[DebuggerHidden]
			public _003CNetworkedBuildWebGL_003Ed__45(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60050D4")]
			[Address(RVA = "0x42D0C18", Offset = "0x42CCC18", VA = "0x42D0C18", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60050D5")]
			[Address(RVA = "0x42D0C38", Offset = "0x42CCC38", VA = "0x42D0C38", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60050D6")]
			[Address(RVA = "0x42D181C", Offset = "0x42CD81C", VA = "0x42D181C")]
			private void _003C_003Em__Finally1()
			{
			}

			[Token(Token = "0x60050D7")]
			[Address(RVA = "0x42D186C", Offset = "0x42CD86C", VA = "0x42D186C", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60050D8")]
			[Address(RVA = "0x42D1874", Offset = "0x42CD874", VA = "0x42D1874", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60050D9")]
			[Address(RVA = "0x42D18AC", Offset = "0x42CD8AC", VA = "0x42D18AC", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4005C3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static LoadingProgress totalProgress;

		[Token(Token = "0x4005C3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ImportOptions buildOptions;

		[Token(Token = "0x4005C3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public PolyfewRuntime.ReferencedNumeric<float> individualProgress;

		[Token(Token = "0x4005C40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		protected static float LOAD_PHASE_PERC;

		[Token(Token = "0x4005C41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		protected static float TEXTURE_PHASE_PERC;

		[Token(Token = "0x4005C42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected static float MATERIAL_PHASE_PERC;

		[Token(Token = "0x4005C43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		protected static float BUILD_PHASE_PERC;

		[Token(Token = "0x4005C44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected static Dictionary<string, GameObject> loadedModels;

		[Token(Token = "0x4005C45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected static Dictionary<string, int> instanceCount;

		[Token(Token = "0x4005C46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected DataSet dataSet;

		[Token(Token = "0x4005C47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected ObjectBuilder objectBuilder;

		[Token(Token = "0x4005C48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected List<MaterialData> materialData;

		[Token(Token = "0x4005C49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected SingleLoadingProgress objLoadingProgress;

		[Token(Token = "0x4005C4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Stats loadStats;

		[Token(Token = "0x4005C4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Texture2D loadedTexture;

		[Token(Token = "0x4005C4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[CompilerGenerated]
		private Action<GameObject, string> m_ModelCreated;

		[Token(Token = "0x4005C4D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[CompilerGenerated]
		private Action<GameObject, string> m_ModelLoaded;

		[Token(Token = "0x4005C4E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[CompilerGenerated]
		private Action<string> m_ModelError;

		[Token(Token = "0x17000E3A")]
		public bool ConvertVertAxis
		{
			[Token(Token = "0x6005075")]
			[Address(RVA = "0x42C93C0", Offset = "0x42C53C0", VA = "0x42C93C0")]
			get
			{
				return default;
			}
			[Token(Token = "0x6005076")]
			[Address(RVA = "0x42C93E0", Offset = "0x42C53E0", VA = "0x42C93E0")]
			set
			{
			}
		}

		[Token(Token = "0x17000E3B")]
		public float Scaling
		{
			[Token(Token = "0x6005077")]
			[Address(RVA = "0x42C9450", Offset = "0x42C5450", VA = "0x42C9450")]
			get
			{
				return default;
			}
			[Token(Token = "0x6005078")]
			[Address(RVA = "0x42C9468", Offset = "0x42C5468", VA = "0x42C9468")]
			set
			{
			}
		}

		[Token(Token = "0x17000E3C")]
		protected abstract bool HasMaterialLibrary
		{
			[Token(Token = "0x6005079")]
			get;
		}

		[Token(Token = "0x1400000A")]
		public event Action<GameObject, string> ModelCreated
		{
			[Token(Token = "0x600507A")]
			[Address(RVA = "0x42C94DC", Offset = "0x42C54DC", VA = "0x42C94DC")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600507B")]
			[Address(RVA = "0x42C958C", Offset = "0x42C558C", VA = "0x42C958C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400000B")]
		public event Action<GameObject, string> ModelLoaded
		{
			[Token(Token = "0x600507C")]
			[Address(RVA = "0x42C963C", Offset = "0x42C563C", VA = "0x42C963C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600507D")]
			[Address(RVA = "0x42C96EC", Offset = "0x42C56EC", VA = "0x42C96EC")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400000C")]
		public event Action<string> ModelError
		{
			[Token(Token = "0x600507E")]
			[Address(RVA = "0x42C979C", Offset = "0x42C579C", VA = "0x42C979C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600507F")]
			[Address(RVA = "0x42C984C", Offset = "0x42C584C", VA = "0x42C984C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6005080")]
		[Address(RVA = "0x42C98FC", Offset = "0x42C58FC", VA = "0x42C98FC")]
		public static GameObject GetModelByPath(string absolutePath)
		{
			return null;
		}

		[Token(Token = "0x6005081")]
		[Address(RVA = "0x42C99D0", Offset = "0x42C59D0", VA = "0x42C99D0")]
		[AsyncStateMachine(typeof(_003CLoad_003Ed__33))]
		public Task<GameObject> Load(string objName, string objAbsolutePath, Transform parentObj, string texturesFolderPath = "", string materialsFolderPath = "")
		{
			return null;
		}

		[Token(Token = "0x6005082")]
		[Address(RVA = "0x42C9AE8", Offset = "0x42C5AE8", VA = "0x42C9AE8")]
		[AsyncStateMachine(typeof(_003CLoadFromNetwork_003Ed__34))]
		public Task<GameObject> LoadFromNetwork(string objURL, string diffuseTexURL, string bumpTexURL, string specularTexURL, string opacityTexURL, string materialURL, string objName)
		{
			return null;
		}

		[Token(Token = "0x6005083")]
		[Address(RVA = "0x42C9C18", Offset = "0x42C5C18", VA = "0x42C9C18")]
		[IteratorStateMachine(typeof(_003CLoadFromNetworkWebGL_003Ed__35))]
		public IEnumerator LoadFromNetworkWebGL(string objURL, string diffuseTexURL, string bumpTexURL, string specularTexURL, string opacityTexURL, string materialURL, string objName, Action<GameObject> OnSuccess, Action<Exception> OnError)
		{
			return null;
		}

		[Token(Token = "0x6005084")]
		public abstract string[] ParseTexturePaths(string absolutePath);

		[Token(Token = "0x6005085")]
		protected abstract Task LoadModelFile(string absolutePath, string texturesFolderPath = "", string materialsFolderPath = "");

		[Token(Token = "0x6005086")]
		protected abstract Task LoadModelFileNetworked(string objURL);

		[Token(Token = "0x6005087")]
		protected abstract IEnumerator LoadModelFileNetworkedWebGL(string objURL, Action<Exception> OnError);

		[Token(Token = "0x6005088")]
		protected abstract Task LoadMaterialLibrary(string absolutePath, string materialsFolderPath = "");

		[Token(Token = "0x6005089")]
		protected abstract Task LoadMaterialLibrary(string materialURL);

		[Token(Token = "0x600508A")]
		protected abstract IEnumerator LoadMaterialLibraryWebGL(string materialURL);

		[Token(Token = "0x600508B")]
		[Address(RVA = "0x42C9CF8", Offset = "0x42C5CF8", VA = "0x42C9CF8")]
		[AsyncStateMachine(typeof(_003CBuild_003Ed__43))]
		protected Task Build(string absolutePath, string objName, Transform parentTransform, string texturesFolderPath = "")
		{
			return null;
		}

		[Token(Token = "0x600508C")]
		[Address(RVA = "0x42C9DEC", Offset = "0x42C5DEC", VA = "0x42C9DEC")]
		[AsyncStateMachine(typeof(_003CNetworkedBuild_003Ed__44))]
		protected Task NetworkedBuild(Transform parentTransform, string objName, string objURL, string diffuseTexURL, string bumpTexURL, string specularTexURL, string opacityTexURL)
		{
			return null;
		}

		[Token(Token = "0x600508D")]
		[Address(RVA = "0x42C9EFC", Offset = "0x42C5EFC", VA = "0x42C9EFC")]
		[IteratorStateMachine(typeof(_003CNetworkedBuildWebGL_003Ed__45))]
		protected IEnumerator NetworkedBuildWebGL(Transform parentTransform, string objName, string objURL, string diffuseTexURL, string bumpTexURL, string specularTexURL, string opacityTexURL)
		{
			return null;
		}

		[Token(Token = "0x600508E")]
		[Address(RVA = "0x42C9FCC", Offset = "0x42C5FCC", VA = "0x42C9FCC")]
		protected string GetDirName(string absolutePath)
		{
			return null;
		}

		[Token(Token = "0x600508F")]
		[Address(RVA = "0x42CA0F4", Offset = "0x42C60F4", VA = "0x42CA0F4", Slot = "12")]
		protected virtual void OnLoaded(GameObject obj, string absolutePath)
		{
		}

		[Token(Token = "0x6005090")]
		[Address(RVA = "0x42CA3A8", Offset = "0x42C63A8", VA = "0x42CA3A8", Slot = "13")]
		protected virtual void OnCreated(GameObject obj, string absolutePath)
		{
		}

		[Token(Token = "0x6005091")]
		[Address(RVA = "0x42CA470", Offset = "0x42C6470", VA = "0x42CA470", Slot = "14")]
		protected virtual void OnLoadFailed(string absolutePath)
		{
		}

		[Token(Token = "0x6005092")]
		[Address(RVA = "0x42CA48C", Offset = "0x42C648C", VA = "0x42CA48C")]
		private string GetTextureUrl(string basePath, string texturePath)
		{
			return null;
		}

		[Token(Token = "0x6005093")]
		[Address(RVA = "0x42CA5F8", Offset = "0x42C65F8", VA = "0x42CA5F8")]
		[AsyncStateMachine(typeof(_003CLoadMaterialTexture_003Ed__51))]
		private Task LoadMaterialTexture(string basePath, string path, string texturesFolderPath = "")
		{
			return null;
		}

		[Token(Token = "0x6005094")]
		[Address(RVA = "0x42CA6E4", Offset = "0x42C66E4", VA = "0x42CA6E4")]
		[AsyncStateMachine(typeof(_003CLoadMaterialTexture_003Ed__52))]
		private Task LoadMaterialTexture(string textureURL)
		{
			return null;
		}

		[Token(Token = "0x6005095")]
		[Address(RVA = "0x42CA7B4", Offset = "0x42C67B4", VA = "0x42CA7B4")]
		[IteratorStateMachine(typeof(_003CLoadMaterialTextureWebGL_003Ed__53))]
		private IEnumerator LoadMaterialTextureWebGL(string textureURL)
		{
			return null;
		}

		[Token(Token = "0x6005096")]
		[Address(RVA = "0x42CA848", Offset = "0x42C6848", VA = "0x42CA848")]
		private Texture2D LoadTexture(UnityWebRequest loader)
		{
			return null;
		}

		[Token(Token = "0x6005097")]
		[Address(RVA = "0x42CAADC", Offset = "0x42C6ADC", VA = "0x42CAADC")]
		[IteratorStateMachine(typeof(_003CDownloadFile_003Ed__57))]
		public IEnumerator DownloadFile(string url, PolyfewRuntime.ReferencedNumeric<float> downloadProgress, Action<byte[]> DownloadComplete, Action<string> OnError)
		{
			return null;
		}

		[Token(Token = "0x6005098")]
		[Address(RVA = "0x42CAB8C", Offset = "0x42C6B8C", VA = "0x42CAB8C")]
		[IteratorStateMachine(typeof(_003CGetProgress_003Ed__58))]
		private IEnumerator GetProgress(UnityWebRequest webrequest, PolyfewRuntime.ReferencedNumeric<float> downloadProgress)
		{
			return null;
		}

		[Token(Token = "0x6005099")]
		[Address(RVA = "0x42CAC20", Offset = "0x42C6C20", VA = "0x42CAC20")]
		[IteratorStateMachine(typeof(_003CDownloadFileWebGL_003Ed__59))]
		public IEnumerator DownloadFileWebGL(string url, PolyfewRuntime.ReferencedNumeric<float> downloadProgress, Action<string> DownloadComplete, Action<string> OnError)
		{
			return null;
		}

		[Token(Token = "0x600509A")]
		[Address(RVA = "0x42CACD0", Offset = "0x42C6CD0", VA = "0x42CACD0")]
		[IteratorStateMachine(typeof(_003CDownloadTexFileWebGL_003Ed__60))]
		public IEnumerator DownloadTexFileWebGL(string url, PolyfewRuntime.ReferencedNumeric<float> downloadProgress, Action<Texture2D> DownloadComplete, Action<string> OnError)
		{
			return null;
		}

		[Token(Token = "0x600509B")]
		[Address(RVA = "0x42CAD80", Offset = "0x42C6D80", VA = "0x42CAD80")]
		protected Loader()
		{
		}
	}
}
