using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Networking;

namespace BrainFailProductions.PolyFew.AsImpL
{
	[Token(Token = "0x2000CF7")]
	public class LoaderObj : Loader
	{
		[Token(Token = "0x2000CF8")]
		private class BumpParamDef
		{
			[Token(Token = "0x4005CEA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string optionName;

			[Token(Token = "0x4005CEB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string valueType;

			[Token(Token = "0x4005CEC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int valueNumMin;

			[Token(Token = "0x4005CED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public int valueNumMax;

			[Token(Token = "0x60050ED")]
			[Address(RVA = "0x42D46D8", Offset = "0x42D06D8", VA = "0x42D46D8")]
			public BumpParamDef(string name, string type, int numMin, int numMax)
			{
			}
		}

		[Token(Token = "0x2000CF9")]
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass4_0
		{
			[Token(Token = "0x4005CEE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool isWorking;

			[Token(Token = "0x4005CEF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public byte[] downloadedBytes;

			[Token(Token = "0x4005CF0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Exception ex;

			[Token(Token = "0x60050EE")]
			[Address(RVA = "0x42D4718", Offset = "0x42D0718", VA = "0x42D4718")]
			public _003C_003Ec__DisplayClass4_0()
			{
			}

			[Token(Token = "0x60050EF")]
			[Address(RVA = "0x42D4720", Offset = "0x42D0720", VA = "0x42D4720")]
			internal void _003CLoadModelFileNetworked_003Eb__0(byte[] bytes)
			{
			}

			[Token(Token = "0x60050F0")]
			[Address(RVA = "0x42D472C", Offset = "0x42D072C", VA = "0x42D472C")]
			internal void _003CLoadModelFileNetworked_003Eb__1(string error)
			{
			}
		}

		[Token(Token = "0x2000CFA")]
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass5_0
		{
			[Token(Token = "0x4005CF1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool isWorking;

			[Token(Token = "0x4005CF2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public LoaderObj _003C_003E4__this;

			[Token(Token = "0x4005CF3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Exception ex;

			[Token(Token = "0x4005CF4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action<Exception> OnError;

			[Token(Token = "0x60050F1")]
			[Address(RVA = "0x42D47F4", Offset = "0x42D07F4", VA = "0x42D47F4")]
			public _003C_003Ec__DisplayClass5_0()
			{
			}

			[Token(Token = "0x60050F2")]
			[Address(RVA = "0x42D47FC", Offset = "0x42D07FC", VA = "0x42D47FC")]
			internal void _003CLoadModelFileNetworkedWebGL_003Eb__0(string text)
			{
			}

			[Token(Token = "0x60050F3")]
			[Address(RVA = "0x42D481C", Offset = "0x42D081C", VA = "0x42D481C")]
			internal void _003CLoadModelFileNetworkedWebGL_003Eb__1(string error)
			{
			}
		}

		[Token(Token = "0x2000CFB")]
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass7_0
		{
			[Token(Token = "0x4005CF5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool isWorking;

			[Token(Token = "0x4005CF6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public byte[] downloadedBytes;

			[Token(Token = "0x60050F4")]
			[Address(RVA = "0x42D4914", Offset = "0x42D0914", VA = "0x42D4914")]
			public _003C_003Ec__DisplayClass7_0()
			{
			}

			[Token(Token = "0x60050F5")]
			[Address(RVA = "0x42D491C", Offset = "0x42D091C", VA = "0x42D491C")]
			internal void _003CLoadMaterialLibrary_003Eb__0(byte[] bytes)
			{
			}

			[Token(Token = "0x60050F6")]
			[Address(RVA = "0x42D4928", Offset = "0x42D0928", VA = "0x42D4928")]
			internal void _003CLoadMaterialLibrary_003Eb__1(string error)
			{
			}
		}

		[Token(Token = "0x2000CFC")]
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass8_0
		{
			[Token(Token = "0x4005CF7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool isWorking;

			[Token(Token = "0x4005CF8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public LoaderObj _003C_003E4__this;

			[Token(Token = "0x60050F7")]
			[Address(RVA = "0x42D49EC", Offset = "0x42D09EC", VA = "0x42D49EC")]
			public _003C_003Ec__DisplayClass8_0()
			{
			}

			[Token(Token = "0x60050F8")]
			[Address(RVA = "0x42D49F4", Offset = "0x42D09F4", VA = "0x42D49F4")]
			internal void _003CLoadMaterialLibraryWebGL_003Eb__0(string text)
			{
			}

			[Token(Token = "0x60050F9")]
			[Address(RVA = "0x42D4A14", Offset = "0x42D0A14", VA = "0x42D4A14")]
			internal void _003CLoadMaterialLibraryWebGL_003Eb__1(string error)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000CFD")]
		[CompilerGenerated]
		private struct _003CLoadMaterialLibrary_003Ed__6 : IAsyncStateMachine
		{
			[Token(Token = "0x4005CF9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005CFA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005CFB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public LoaderObj _003C_003E4__this;

			[Token(Token = "0x4005CFC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string absolutePath;

			[Token(Token = "0x4005CFD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string materialsFolderPath;

			[Token(Token = "0x4005CFE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private StreamReader _003Csr_003E5__2;

			[Token(Token = "0x4005CFF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private TaskAwaiter<string> _003C_003Eu__1;

			[Token(Token = "0x60050FA")]
			[Address(RVA = "0x42D4AD8", Offset = "0x42D0AD8", VA = "0x42D4AD8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60050FB")]
			[Address(RVA = "0x42D5164", Offset = "0x42D1164", VA = "0x42D5164", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000CFE")]
		[CompilerGenerated]
		private struct _003CLoadMaterialLibrary_003Ed__7 : IAsyncStateMachine
		{
			[Token(Token = "0x4005D00")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005D01")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005D02")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public LoaderObj _003C_003E4__this;

			[Token(Token = "0x4005D03")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string materialURL;

			[Token(Token = "0x4005D04")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private _003C_003Ec__DisplayClass7_0 _003C_003E8__1;

			[Token(Token = "0x4005D05")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private TaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x4005D06")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private StreamReader _003Csr_003E5__2;

			[Token(Token = "0x4005D07")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private TaskAwaiter<string> _003C_003Eu__2;

			[Token(Token = "0x60050FC")]
			[Address(RVA = "0x42D51CC", Offset = "0x42D11CC", VA = "0x42D51CC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60050FD")]
			[Address(RVA = "0x42D5AE8", Offset = "0x42D1AE8", VA = "0x42D5AE8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x2000CFF")]
		[CompilerGenerated]
		private sealed class _003CLoadMaterialLibraryWebGL_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4005D08")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4005D09")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4005D0A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public LoaderObj _003C_003E4__this;

			[Token(Token = "0x4005D0B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string materialURL;

			[Token(Token = "0x4005D0C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private _003C_003Ec__DisplayClass8_0 _003C_003E8__1;

			[Token(Token = "0x17000E4C")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6005101")]
				[Address(RVA = "0x42D5E18", Offset = "0x42D1E18", VA = "0x42D5E18", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000E4D")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6005103")]
				[Address(RVA = "0x42D5E58", Offset = "0x42D1E58", VA = "0x42D5E58", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60050FE")]
			[Address(RVA = "0x42D5B50", Offset = "0x42D1B50", VA = "0x42D5B50")]
			[DebuggerHidden]
			public _003CLoadMaterialLibraryWebGL_003Ed__8(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60050FF")]
			[Address(RVA = "0x42D5B78", Offset = "0x42D1B78", VA = "0x42D5B78", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6005100")]
			[Address(RVA = "0x42D5B7C", Offset = "0x42D1B7C", VA = "0x42D5B7C", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6005101")]
			[Address(RVA = "0x42D5E18", Offset = "0x42D1E18", VA = "0x42D5E18", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6005102")]
			[Address(RVA = "0x42D5E20", Offset = "0x42D1E20", VA = "0x42D5E20", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6005103")]
			[Address(RVA = "0x42D5E58", Offset = "0x42D1E58", VA = "0x42D5E58", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000D00")]
		[CompilerGenerated]
		private struct _003CLoadModelFile_003Ed__3 : IAsyncStateMachine
		{
			[Token(Token = "0x4005D0D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005D0E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005D0F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string absolutePath;

			[Token(Token = "0x4005D10")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public LoaderObj _003C_003E4__this;

			[Token(Token = "0x4005D11")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private StreamReader _003Csr_003E5__2;

			[Token(Token = "0x4005D12")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private TaskAwaiter<string> _003C_003Eu__1;

			[Token(Token = "0x6005104")]
			[Address(RVA = "0x42D5E60", Offset = "0x42D1E60", VA = "0x42D5E60", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6005105")]
			[Address(RVA = "0x42D6384", Offset = "0x42D2384", VA = "0x42D6384", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000D01")]
		[CompilerGenerated]
		private struct _003CLoadModelFileNetworked_003Ed__4 : IAsyncStateMachine
		{
			[Token(Token = "0x4005D13")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005D14")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005D15")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public LoaderObj _003C_003E4__this;

			[Token(Token = "0x4005D16")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string objURL;

			[Token(Token = "0x4005D17")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private _003C_003Ec__DisplayClass4_0 _003C_003E8__1;

			[Token(Token = "0x4005D18")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private TaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x4005D19")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private StreamReader _003Csr_003E5__2;

			[Token(Token = "0x4005D1A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private TaskAwaiter<string> _003C_003Eu__2;

			[Token(Token = "0x6005106")]
			[Address(RVA = "0x42D63EC", Offset = "0x42D23EC", VA = "0x42D63EC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6005107")]
			[Address(RVA = "0x42D6E58", Offset = "0x42D2E58", VA = "0x42D6E58", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x2000D02")]
		[CompilerGenerated]
		private sealed class _003CLoadModelFileNetworkedWebGL_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4005D1B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4005D1C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4005D1D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public LoaderObj _003C_003E4__this;

			[Token(Token = "0x4005D1E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action<Exception> OnError;

			[Token(Token = "0x4005D1F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string objURL;

			[Token(Token = "0x4005D20")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private _003C_003Ec__DisplayClass5_0 _003C_003E8__1;

			[Token(Token = "0x17000E4E")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600510B")]
				[Address(RVA = "0x42D748C", Offset = "0x42D348C", VA = "0x42D748C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000E4F")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600510D")]
				[Address(RVA = "0x42D74CC", Offset = "0x42D34CC", VA = "0x42D74CC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6005108")]
			[Address(RVA = "0x42D6EC0", Offset = "0x42D2EC0", VA = "0x42D6EC0")]
			[DebuggerHidden]
			public _003CLoadModelFileNetworkedWebGL_003Ed__5(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6005109")]
			[Address(RVA = "0x42D6EE8", Offset = "0x42D2EE8", VA = "0x42D6EE8", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600510A")]
			[Address(RVA = "0x42D6EEC", Offset = "0x42D2EEC", VA = "0x42D6EEC", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x600510B")]
			[Address(RVA = "0x42D748C", Offset = "0x42D348C", VA = "0x42D748C", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600510C")]
			[Address(RVA = "0x42D7494", Offset = "0x42D3494", VA = "0x42D7494", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x600510D")]
			[Address(RVA = "0x42D74CC", Offset = "0x42D34CC", VA = "0x42D74CC", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x2000D03")]
		[CompilerGenerated]
		private sealed class _003CLoadOrDownloadText_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4005D21")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4005D22")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4005D23")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public LoaderObj _003C_003E4__this;

			[Token(Token = "0x4005D24")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string url;

			[Token(Token = "0x4005D25")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool notifyErrors;

			[Token(Token = "0x4005D26")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UnityWebRequest _003Cuwr_003E5__2;

			[Token(Token = "0x17000E50")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6005111")]
				[Address(RVA = "0x42D7634", Offset = "0x42D3634", VA = "0x42D7634", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000E51")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6005113")]
				[Address(RVA = "0x42D7674", Offset = "0x42D3674", VA = "0x42D7674", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x600510E")]
			[Address(RVA = "0x42D74D4", Offset = "0x42D34D4", VA = "0x42D74D4")]
			[DebuggerHidden]
			public _003CLoadOrDownloadText_003Ed__20(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600510F")]
			[Address(RVA = "0x42D74FC", Offset = "0x42D34FC", VA = "0x42D74FC", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6005110")]
			[Address(RVA = "0x42D7500", Offset = "0x42D3500", VA = "0x42D7500", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6005111")]
			[Address(RVA = "0x42D7634", Offset = "0x42D3634", VA = "0x42D7634", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6005112")]
			[Address(RVA = "0x42D763C", Offset = "0x42D363C", VA = "0x42D763C", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6005113")]
			[Address(RVA = "0x42D7674", Offset = "0x42D3674", VA = "0x42D7674", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4005CE8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private string mtlLib;

		[Token(Token = "0x4005CE9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private string loadedText;

		[Token(Token = "0x17000E4B")]
		protected override bool HasMaterialLibrary
		{
			[Token(Token = "0x60050E6")]
			[Address(RVA = "0x42D3BDC", Offset = "0x42CFBDC", VA = "0x42D3BDC", Slot = "4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60050DA")]
		[Address(RVA = "0x42D18B4", Offset = "0x42CD8B4", VA = "0x42D18B4", Slot = "5")]
		public override string[] ParseTexturePaths(string absolutePath)
		{
			return null;
		}

		[Token(Token = "0x60050DB")]
		[Address(RVA = "0x42D2B10", Offset = "0x42CEB10", VA = "0x42D2B10", Slot = "6")]
		[AsyncStateMachine(typeof(_003CLoadModelFile_003Ed__3))]
		protected override Task LoadModelFile(string absolutePath, string texturesFolderPath = "", string materialsFolderPath = "")
		{
			return null;
		}

		[Token(Token = "0x60050DC")]
		[Address(RVA = "0x42D2BE0", Offset = "0x42CEBE0", VA = "0x42D2BE0", Slot = "7")]
		[AsyncStateMachine(typeof(_003CLoadModelFileNetworked_003Ed__4))]
		protected override Task LoadModelFileNetworked(string objURL)
		{
			return null;
		}

		[Token(Token = "0x60050DD")]
		[Address(RVA = "0x42D2CB4", Offset = "0x42CECB4", VA = "0x42D2CB4", Slot = "8")]
		[IteratorStateMachine(typeof(_003CLoadModelFileNetworkedWebGL_003Ed__5))]
		protected override IEnumerator LoadModelFileNetworkedWebGL(string objURL, Action<Exception> OnError)
		{
			return null;
		}

		[Token(Token = "0x60050DE")]
		[Address(RVA = "0x42D2D30", Offset = "0x42CED30", VA = "0x42D2D30", Slot = "9")]
		[AsyncStateMachine(typeof(_003CLoadMaterialLibrary_003Ed__6))]
		protected override Task LoadMaterialLibrary(string absolutePath, string materialsFolderPath = "")
		{
			return null;
		}

		[Token(Token = "0x60050DF")]
		[Address(RVA = "0x42D2E08", Offset = "0x42CEE08", VA = "0x42D2E08", Slot = "10")]
		[AsyncStateMachine(typeof(_003CLoadMaterialLibrary_003Ed__7))]
		protected override Task LoadMaterialLibrary(string materialURL)
		{
			return null;
		}

		[Token(Token = "0x60050E0")]
		[Address(RVA = "0x42D2EDC", Offset = "0x42CEEDC", VA = "0x42D2EDC", Slot = "11")]
		[IteratorStateMachine(typeof(_003CLoadMaterialLibraryWebGL_003Ed__8))]
		protected override IEnumerator LoadMaterialLibraryWebGL(string materialURL)
		{
			return null;
		}

		[Token(Token = "0x60050E1")]
		[Address(RVA = "0x42D2F50", Offset = "0x42CEF50", VA = "0x42D2F50")]
		private void GetFaceIndicesByOneFaceLine(DataSet.FaceIndices[] faces, string[] p, bool isFaceIndexPlus)
		{
		}

		[Token(Token = "0x60050E2")]
		[Address(RVA = "0x42D32A8", Offset = "0x42CF2A8", VA = "0x42D32A8")]
		private Vector3 ConvertVec3(float x, float y, float z)
		{
			return default;
		}

		[Token(Token = "0x60050E3")]
		[Address(RVA = "0x42D32F8", Offset = "0x42CF2F8", VA = "0x42D32F8")]
		private float ParseFloat(string floatString)
		{
			return default;
		}

		[Token(Token = "0x60050E4")]
		[Address(RVA = "0x42D3374", Offset = "0x42CF374", VA = "0x42D3374")]
		protected void ParseGeometryData(string objDataText)
		{
		}

		[Token(Token = "0x60050E5")]
		[Address(RVA = "0x42D1D10", Offset = "0x42CDD10", VA = "0x42D1D10")]
		private string ParseMaterialLibName(string path)
		{
			return null;
		}

		[Token(Token = "0x60050E7")]
		[Address(RVA = "0x42D3BEC", Offset = "0x42CFBEC", VA = "0x42D3BEC")]
		private void ParseMaterialData(string data)
		{
		}

		[Token(Token = "0x60050E8")]
		[Address(RVA = "0x42D1E24", Offset = "0x42CDE24", VA = "0x42D1E24")]
		private void ParseMaterialData(string[] lines, List<MaterialData> mtlData)
		{
		}

		[Token(Token = "0x60050E9")]
		[Address(RVA = "0x42D3D50", Offset = "0x42CFD50", VA = "0x42D3D50")]
		private void ParseBumpParameters(string[] param, MaterialData mtlData)
		{
		}

		[Token(Token = "0x60050EA")]
		[Address(RVA = "0x42D3CD8", Offset = "0x42CFCD8", VA = "0x42D3CD8")]
		private Color StringsToColor(string[] p)
		{
			return default;
		}

		[Token(Token = "0x60050EB")]
		[Address(RVA = "0x42D4604", Offset = "0x42D0604", VA = "0x42D4604")]
		[IteratorStateMachine(typeof(_003CLoadOrDownloadText_003Ed__20))]
		private IEnumerator LoadOrDownloadText(string url, bool notifyErrors = true)
		{
			return null;
		}

		[Token(Token = "0x60050EC")]
		[Address(RVA = "0x42D4684", Offset = "0x42D0684", VA = "0x42D4684")]
		public LoaderObj()
		{
		}
	}
}
