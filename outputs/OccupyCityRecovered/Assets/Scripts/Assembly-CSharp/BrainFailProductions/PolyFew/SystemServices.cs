using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Networking;

namespace BrainFailProductions.PolyFew
{
	[Token(Token = "0x2000CC7")]
	public static class SystemServices
	{
		[Serializable]
		[Token(Token = "0x2000CC8")]
		public struct RegexPatterns
		{
			[Token(Token = "0x4005B97")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string netError;

			[Token(Token = "0x4005B98")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string nullOrEmpty;

			[Token(Token = "0x4005B99")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string generalError;

			[Token(Token = "0x4005B9A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string apiMistmatch;

			[Token(Token = "0x4005B9B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string parametersMismatch;

			[Token(Token = "0x4005B9C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string nothing;
		}

		[Token(Token = "0x2000CC9")]
		public struct MessagePatternPair
		{
			[Token(Token = "0x17000E2F")]
			public string patternAppended
			{
				[Token(Token = "0x6005024")]
				[Address(RVA = "0x42BF184", Offset = "0x42BB184", VA = "0x42BF184")]
				[CompilerGenerated]
				readonly get
				{
					return null;
				}
				[Token(Token = "0x6005023")]
				[Address(RVA = "0x42BF17C", Offset = "0x42BB17C", VA = "0x42BF17C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000E30")]
			public string parsedMessage
			{
				[Token(Token = "0x6005026")]
				[Address(RVA = "0x42BF194", Offset = "0x42BB194", VA = "0x42BF194")]
				[CompilerGenerated]
				readonly get
				{
					return null;
				}
				[Token(Token = "0x6005025")]
				[Address(RVA = "0x42BF18C", Offset = "0x42BB18C", VA = "0x42BF18C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6005027")]
			[Address(RVA = "0x42BEC88", Offset = "0x42BAC88", VA = "0x42BEC88")]
			public MessagePatternPair(string patternAppended, string parsedMessage)
			{
			}
		}

		[Token(Token = "0x2000CCA")]
		public class HTTPMethod
		{
			[Token(Token = "0x2000CCB")]
			public enum HTTPMethods
			{
				[Token(Token = "0x4005BA1")]
				POST = 0,
				[Token(Token = "0x4005BA2")]
				GET = 1
			}

			[Token(Token = "0x4005B9F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public readonly string methodName;

			[Token(Token = "0x6005028")]
			[Address(RVA = "0x42BE884", Offset = "0x42BA884", VA = "0x42BE884")]
			public HTTPMethod(HTTPMethods method)
			{
			}
		}

		[Token(Token = "0x2000CCC")]
		public enum ImageFormat
		{
			[Token(Token = "0x4005BA4")]
			PNG = 0,
			[Token(Token = "0x4005BA5")]
			JPG = 1,
			[Token(Token = "0x4005BA6")]
			EXR = 2
		}

		[Token(Token = "0x2000CCF")]
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass7_0
		{
			[Token(Token = "0x4005BA9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public HttpWebRequest request;

			[Token(Token = "0x4005BAA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public byte[] postData;

			[Token(Token = "0x4005BAB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public HttpWebResponse httpResponse;

			[Token(Token = "0x600502D")]
			[Address(RVA = "0x42BF2CC", Offset = "0x42BB2CC", VA = "0x42BF2CC")]
			public _003C_003Ec__DisplayClass7_0()
			{
			}

			[Token(Token = "0x600502E")]
			[Address(RVA = "0x42BF2D4", Offset = "0x42BB2D4", VA = "0x42BF2D4")]
			internal void _003CSendHTTPRequestAsync_003Eb__0()
			{
			}

			[Token(Token = "0x600502F")]
			[Address(RVA = "0x42BF478", Offset = "0x42BB478", VA = "0x42BF478")]
			internal void _003CSendHTTPRequestAsync_003Eb__1()
			{
			}
		}

		[Token(Token = "0x2000CD0")]
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass9_0
		{
			[Token(Token = "0x4005BAC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public HttpWebResponse httpResponse;

			[Token(Token = "0x4005BAD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public HttpWebRequest request;

			[Token(Token = "0x6005030")]
			[Address(RVA = "0x42BF530", Offset = "0x42BB530", VA = "0x42BF530")]
			public _003C_003Ec__DisplayClass9_0()
			{
			}

			[Token(Token = "0x6005031")]
			[Address(RVA = "0x42BF538", Offset = "0x42BB538", VA = "0x42BF538")]
			internal void _003CAsyncResourceDownload_003Eb__0()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000CD1")]
		[CompilerGenerated]
		private struct _003CAsyncReachabilityCheck_003Ed__10 : IAsyncStateMachine
		{
			[Token(Token = "0x4005BAE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005BAF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005BB0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Action<bool> callback;

			[Token(Token = "0x4005BB1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string testUrl;

			[Token(Token = "0x4005BB2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private TaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x6005032")]
			[Address(RVA = "0x42BF5F0", Offset = "0x42BB5F0", VA = "0x42BF5F0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6005033")]
			[Address(RVA = "0x42BF89C", Offset = "0x42BB89C", VA = "0x42BF89C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000CD2")]
		[CompilerGenerated]
		private struct _003CAsyncResourceDownload_003Ed__9 : IAsyncStateMachine
		{
			[Token(Token = "0x4005BB3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005BB4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005BB5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private _003C_003Ec__DisplayClass9_0 _003C_003E8__1;

			[Token(Token = "0x4005BB6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string resourceUrl;

			[Token(Token = "0x4005BB7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action<byte[], string, HttpStatusCode?> callback;

			[Token(Token = "0x4005BB8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public int? timeout;

			[Token(Token = "0x4005BB9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private TaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x6005034")]
			[Address(RVA = "0x42BF904", Offset = "0x42BB904", VA = "0x42BF904", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6005035")]
			[Address(RVA = "0x42C066C", Offset = "0x42BC66C", VA = "0x42C066C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000CD3")]
		[CompilerGenerated]
		private struct _003CRunDelayedCommand_003Ed__17 : IAsyncStateMachine
		{
			[Token(Token = "0x4005BBA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005BBB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005BBC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float secs;

			[Token(Token = "0x4005BBD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action command;

			[Token(Token = "0x4005BBE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private TaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x6005036")]
			[Address(RVA = "0x42C06D4", Offset = "0x42BC6D4", VA = "0x42C06D4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6005037")]
			[Address(RVA = "0x42C090C", Offset = "0x42BC90C", VA = "0x42C090C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000CD4")]
		[CompilerGenerated]
		private struct _003CSendHTTPRequestAsync_003Ed__7 : IAsyncStateMachine
		{
			[Token(Token = "0x4005BBF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005BC0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005BC1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public byte[] postData;

			[Token(Token = "0x4005BC2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private _003C_003Ec__DisplayClass7_0 _003C_003E8__1;

			[Token(Token = "0x4005BC3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string baseUrl;

			[Token(Token = "0x4005BC4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Action<string, HttpStatusCode?> callback;

			[Token(Token = "0x4005BC5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public int? timeout;

			[Token(Token = "0x4005BC6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public HTTPMethod requestMethod;

			[Token(Token = "0x4005BC7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Dictionary<string, string> header;

			[Token(Token = "0x4005BC8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Dictionary<string, string> requestParameters;

			[Token(Token = "0x4005BC9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private TaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x4005BCA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private byte[] _003CparamsData_003E5__2;

			[Token(Token = "0x4005BCB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private TaskAwaiter<Stream> _003C_003Eu__2;

			[Token(Token = "0x4005BCC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private TaskAwaiter<string> _003C_003Eu__3;

			[Token(Token = "0x6005038")]
			[Address(RVA = "0x42C0974", Offset = "0x42BC974", VA = "0x42C0974", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6005039")]
			[Address(RVA = "0x42C1D5C", Offset = "0x42BDD5C", VA = "0x42C1D5C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x2000CD5")]
		[CompilerGenerated]
		private sealed class _003CUnityAsyncGETRequest_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4005BCD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4005BCE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4005BCF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string encodedUrl;

			[Token(Token = "0x4005BD0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int? timeout;

			[Token(Token = "0x4005BD1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Dictionary<string, string> headers;

			[Token(Token = "0x4005BD2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Action<string, long> callback;

			[Token(Token = "0x4005BD3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UnityWebRequest _003CwebRequest_003E5__2;

			[Token(Token = "0x17000E31")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600503D")]
				[Address(RVA = "0x42C21A4", Offset = "0x42BE1A4", VA = "0x42C21A4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000E32")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600503F")]
				[Address(RVA = "0x42C21E4", Offset = "0x42BE1E4", VA = "0x42C21E4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x600503A")]
			[Address(RVA = "0x42BCD6C", Offset = "0x42B8D6C", VA = "0x42BCD6C")]
			[DebuggerHidden]
			public _003CUnityAsyncGETRequest_003Ed__3(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600503B")]
			[Address(RVA = "0x42C1DC4", Offset = "0x42BDDC4", VA = "0x42C1DC4", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600503C")]
			[Address(RVA = "0x42C1DC8", Offset = "0x42BDDC8", VA = "0x42C1DC8", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x600503D")]
			[Address(RVA = "0x42C21A4", Offset = "0x42BE1A4", VA = "0x42C21A4", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600503E")]
			[Address(RVA = "0x42C21AC", Offset = "0x42BE1AC", VA = "0x42C21AC", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x600503F")]
			[Address(RVA = "0x42C21E4", Offset = "0x42BE1E4", VA = "0x42C21E4", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x2000CD6")]
		[CompilerGenerated]
		private sealed class _003CUnityAsyncPOSTRequest_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4005BD4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4005BD5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4005BD6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string baseUrl;

			[Token(Token = "0x4005BD7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int? timeout;

			[Token(Token = "0x4005BD8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public byte[] data;

			[Token(Token = "0x4005BD9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Dictionary<string, string> headers;

			[Token(Token = "0x4005BDA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Action<string, long> callback;

			[Token(Token = "0x4005BDB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UnityWebRequest _003CwebRequest_003E5__2;

			[Token(Token = "0x17000E33")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6005043")]
				[Address(RVA = "0x42C2650", Offset = "0x42BE650", VA = "0x42C2650", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000E34")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6005045")]
				[Address(RVA = "0x42C2690", Offset = "0x42BE690", VA = "0x42C2690", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6005040")]
			[Address(RVA = "0x42BD5A4", Offset = "0x42B95A4", VA = "0x42BD5A4")]
			[DebuggerHidden]
			public _003CUnityAsyncPOSTRequest_003Ed__6(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6005041")]
			[Address(RVA = "0x42C21EC", Offset = "0x42BE1EC", VA = "0x42C21EC", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6005042")]
			[Address(RVA = "0x42C21F0", Offset = "0x42BE1F0", VA = "0x42C21F0", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6005043")]
			[Address(RVA = "0x42C2650", Offset = "0x42BE650", VA = "0x42C2650", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6005044")]
			[Address(RVA = "0x42C2658", Offset = "0x42BE658", VA = "0x42C2658", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6005045")]
			[Address(RVA = "0x42C2690", Offset = "0x42BE690", VA = "0x42C2690", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000CD7")]
		[CompilerGenerated]
		private struct _003CWriteBytesAsync_003Ed__20 : IAsyncStateMachine
		{
			[Token(Token = "0x4005BDC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005BDD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005BDE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string fullPath;

			[Token(Token = "0x4005BDF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public byte[] data;

			[Token(Token = "0x4005BE0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action<string> callback;

			[Token(Token = "0x4005BE1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private FileStream _003CfileStream_003E5__2;

			[Token(Token = "0x4005BE2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private TaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x6005046")]
			[Address(RVA = "0x42C28B4", Offset = "0x42BE8B4", VA = "0x42C28B4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6005047")]
			[Address(RVA = "0x42C2DA8", Offset = "0x42BEDA8", VA = "0x42C2DA8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000CD8")]
		[CompilerGenerated]
		private struct _003CWriteTextureAsync_003Ed__19 : IAsyncStateMachine
		{
			[Token(Token = "0x4005BE3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005BE4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005BE5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ImageFormat format;

			[Token(Token = "0x4005BE6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Texture2D texture;

			[Token(Token = "0x4005BE7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string fileName;

			[Token(Token = "0x4005BE8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string path;

			[Token(Token = "0x4005BE9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Action<string> callback;

			[Token(Token = "0x4005BEA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private byte[] _003Cdata_003E5__2;

			[Token(Token = "0x4005BEB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private FileStream _003CfileStream_003E5__3;

			[Token(Token = "0x4005BEC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private TaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x6005048")]
			[Address(RVA = "0x42C2E10", Offset = "0x42BEE10", VA = "0x42C2E10", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6005049")]
			[Address(RVA = "0x42C3578", Offset = "0x42BF578", VA = "0x42C3578", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4005B96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static RegexPatterns regexPatterns;

		[Token(Token = "0x6005012")]
		[Address(RVA = "0x42BCBE8", Offset = "0x42B8BE8", VA = "0x42BCBE8")]
		private static void SetPatterns()
		{
		}

		[Token(Token = "0x6005013")]
		[Address(RVA = "0x42BCCEC", Offset = "0x42B8CEC", VA = "0x42BCCEC")]
		[IteratorStateMachine(typeof(_003CUnityAsyncGETRequest_003Ed__3))]
		public static IEnumerator UnityAsyncGETRequest(string encodedUrl, Action<string, long> callback, [Optional] int? timeout, [Optional] Dictionary<string, string> headers)
		{
			return null;
		}

		[Token(Token = "0x6005014")]
		[Address(RVA = "0x42BCD94", Offset = "0x42B8D94", VA = "0x42BCD94")]
		public static void UnityBlockingGETRequest(string encodedUrl, Action<string, long> callback, [Optional] int? timeout, [Optional] Dictionary<string, string> headers)
		{
		}

		[Token(Token = "0x6005015")]
		[Address(RVA = "0x42BD114", Offset = "0x42B9114", VA = "0x42BD114")]
		public static void UnityBlockingPOSTRequest(string baseUrl, Action<string, long> callback, byte[] data, [Optional] int? timeout, [Optional] Dictionary<string, string> headers)
		{
		}

		[Token(Token = "0x6005016")]
		[Address(RVA = "0x42BD51C", Offset = "0x42B951C", VA = "0x42BD51C")]
		[IteratorStateMachine(typeof(_003CUnityAsyncPOSTRequest_003Ed__6))]
		public static IEnumerator UnityAsyncPOSTRequest(string baseUrl, Action<string, long> callback, byte[] data, [Optional] int? timeout, [Optional] Dictionary<string, string> headers)
		{
			return null;
		}

		[Token(Token = "0x6005017")]
		[Address(RVA = "0x42BD5CC", Offset = "0x42B95CC", VA = "0x42BD5CC")]
		[AsyncStateMachine(typeof(_003CSendHTTPRequestAsync_003Ed__7))]
		public static Task SendHTTPRequestAsync(string baseUrl, HTTPMethod requestMethod, Action<string, HttpStatusCode?> callback, Dictionary<string, string> requestParameters, byte[] postData, string contentType, [Optional] int? timeout, [Optional] Dictionary<string, string> header)
		{
			return null;
		}

		[Token(Token = "0x6005018")]
		[Address(RVA = "0x42BD6D0", Offset = "0x42B96D0", VA = "0x42BD6D0")]
		public static void SendHTTPRequestBlocking(string baseUrl, HTTPMethod requestMethod, Action<string, HttpStatusCode?> callback, Dictionary<string, string> requestParameters, byte[] postData, string contentType, [Optional] int? timeout, [Optional] Dictionary<string, string> header)
		{
		}

		[Token(Token = "0x6005019")]
		[Address(RVA = "0x42BE5AC", Offset = "0x42BA5AC", VA = "0x42BE5AC")]
		[AsyncStateMachine(typeof(_003CAsyncResourceDownload_003Ed__9))]
		public static Task AsyncResourceDownload(string resourceUrl, Action<byte[], string, HttpStatusCode?> callback, [Optional] int? timeout)
		{
			return null;
		}

		[Token(Token = "0x600501A")]
		[Address(RVA = "0x42BE688", Offset = "0x42BA688", VA = "0x42BE688")]
		[AsyncStateMachine(typeof(_003CAsyncReachabilityCheck_003Ed__10))]
		public static Task AsyncReachabilityCheck(string testUrl, Action<bool> callback)
		{
			return null;
		}

		[Token(Token = "0x600501B")]
		[Address(RVA = "0x42BE75C", Offset = "0x42BA75C", VA = "0x42BE75C")]
		public static void BlockingReachabilityCheck(string url, Action<bool> callback)
		{
		}

		[Token(Token = "0x600501C")]
		[Address(RVA = "0x42BE980", Offset = "0x42BA980", VA = "0x42BE980")]
		public static MessagePatternPair ParseResponseMessage(string message)
		{
			return default;
		}

		[Token(Token = "0x600501D")]
		[Address(RVA = "0x42BEC90", Offset = "0x42BAC90", VA = "0x42BEC90")]
		public static bool IsSuccessStatusCode(long statusCode)
		{
			return default;
		}

		[Token(Token = "0x600501E")]
		[Address(RVA = "0x42BE304", Offset = "0x42BA304", VA = "0x42BE304")]
		public static string GetQueryStringFromKeyValues(Dictionary<string, string> parameters)
		{
			return null;
		}

		[Token(Token = "0x600501F")]
		[Address(RVA = "0x42BECA0", Offset = "0x42BACA0", VA = "0x42BECA0")]
		[AsyncStateMachine(typeof(_003CRunDelayedCommand_003Ed__17))]
		public static Task RunDelayedCommand(float secs, Action command)
		{
			return null;
		}

		[Token(Token = "0x6005020")]
		[Address(RVA = "0x42BED78", Offset = "0x42BAD78", VA = "0x42BED78")]
		public static byte[] ReadAllBytes(Stream source)
		{
			return null;
		}

		[Token(Token = "0x6005021")]
		[Address(RVA = "0x42BEFB4", Offset = "0x42BAFB4", VA = "0x42BEFB4")]
		[AsyncStateMachine(typeof(_003CWriteTextureAsync_003Ed__19))]
		public static Task WriteTextureAsync(Texture2D texture, ImageFormat format, string fileName, string path, Action<string> callback)
		{
			return null;
		}

		[Token(Token = "0x6005022")]
		[Address(RVA = "0x42BF0A4", Offset = "0x42BB0A4", VA = "0x42BF0A4")]
		[AsyncStateMachine(typeof(_003CWriteBytesAsync_003Ed__20))]
		public static Task WriteBytesAsync(byte[] data, string fullPath, Action<string> callback)
		{
			return null;
		}
	}
}
