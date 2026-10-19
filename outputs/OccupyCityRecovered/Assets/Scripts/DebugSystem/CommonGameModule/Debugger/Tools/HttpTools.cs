using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace CommonGameModule.Debugger.Tools
{
	[Token(Token = "0x200002A")]
	public static class HttpTools
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200002B")]
		[CompilerGenerated]
		private struct _003CDownloadFileAsync_003Ed__3 : IAsyncStateMachine
		{
			[Token(Token = "0x400007F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4000080")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

			[Token(Token = "0x4000081")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string url;

			[Token(Token = "0x4000082")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string targetPath;

			[Token(Token = "0x4000083")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private HttpResponseMessage _003Cresponse_003E5__2;

			[Token(Token = "0x4000084")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Stream _003Cstream_003E5__3;

			[Token(Token = "0x4000085")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private FileStream _003Cfile_003E5__4;

			[Token(Token = "0x4000086")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x4000087")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter _003C_003Eu__2;

			[Token(Token = "0x4000088")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__3;

			[Token(Token = "0x60000B0")]
			[Address(RVA = "0x463B684", Offset = "0x4637684", VA = "0x463B684", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60000B1")]
			[Address(RVA = "0x463C388", Offset = "0x4638388", VA = "0x463C388", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly HttpClient _httpClient;

		[Token(Token = "0x1700001F")]
		public static HttpClient Client
		{
			[Token(Token = "0x60000AD")]
			[Address(RVA = "0x463B470", Offset = "0x4637470", VA = "0x463B470")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x463B4C8", Offset = "0x46374C8", VA = "0x463B4C8")]
		[AsyncStateMachine(typeof(_003CDownloadFileAsync_003Ed__3))]
		public static Task<bool> DownloadFileAsync(string url, string targetPath)
		{
			return null;
		}
	}
}
