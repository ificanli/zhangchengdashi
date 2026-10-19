using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine.Networking;

namespace ToolModule.Web
{
	[Token(Token = "0x20001B7")]
	public class WebApiClient
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20001B8")]
		[CompilerGenerated]
		private struct _003CSendGetRequest_003Ed__6 : IAsyncStateMachine
		{
			[Token(Token = "0x4001B0C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001B0D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<WebResponse> _003C_003Et__builder;

			[Token(Token = "0x4001B0E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public WebApiClient _003C_003E4__this;

			[Token(Token = "0x4001B0F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string url;

			[Token(Token = "0x4001B10")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private TaskAwaiter<WebResponse> _003C_003Eu__1;

			[Token(Token = "0x6000706")]
			[Address(RVA = "0x407C544", Offset = "0x4078544", VA = "0x407C544", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000707")]
			[Address(RVA = "0x407C7C0", Offset = "0x40787C0", VA = "0x407C7C0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20001B9")]
		[CompilerGenerated]
		private struct _003CSendPostRequest_003Ed__7 : IAsyncStateMachine
		{
			[Token(Token = "0x4001B11")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001B12")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<WebResponse> _003C_003Et__builder;

			[Token(Token = "0x4001B13")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public WebApiClient _003C_003E4__this;

			[Token(Token = "0x4001B14")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string url;

			[Token(Token = "0x4001B15")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string json_data;

			[Token(Token = "0x4001B16")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private TaskAwaiter<WebResponse> _003C_003Eu__1;

			[Token(Token = "0x6000708")]
			[Address(RVA = "0x407C83C", Offset = "0x407883C", VA = "0x407C83C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000709")]
			[Address(RVA = "0x407CAA0", Offset = "0x4078AA0", VA = "0x407CAA0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20001BA")]
		[CompilerGenerated]
		private struct _003CSendRequest_003Ed__8 : IAsyncStateMachine
		{
			[Token(Token = "0x4001B17")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001B18")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<WebResponse> _003C_003Et__builder;

			[Token(Token = "0x4001B19")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string url;

			[Token(Token = "0x4001B1A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string method;

			[Token(Token = "0x4001B1B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string json_data;

			[Token(Token = "0x4001B1C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public WebApiClient _003C_003E4__this;

			[Token(Token = "0x4001B1D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private TaskAwaiter<WebResponse> _003C_003Eu__1;

			[Token(Token = "0x600070A")]
			[Address(RVA = "0x407CB1C", Offset = "0x4078B1C", VA = "0x407CB1C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600070B")]
			[Address(RVA = "0x407CF64", Offset = "0x4078F64", VA = "0x407CF64", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20001BB")]
		[CompilerGenerated]
		private struct _003CSendRequest_003Ed__9 : IAsyncStateMachine
		{
			[Token(Token = "0x4001B1E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001B1F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<WebResponse> _003C_003Et__builder;

			[Token(Token = "0x4001B20")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public UnityWebRequest request;

			[Token(Token = "0x4001B21")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public WebApiClient _003C_003E4__this;

			[Token(Token = "0x4001B22")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int _003Cwait_003E5__2;

			[Token(Token = "0x4001B23")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private int _003Cwait_max_003E5__3;

			[Token(Token = "0x4001B24")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UnityWebRequestAsyncOperation _003Casync_oper_003E5__4;

			[Token(Token = "0x4001B25")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private TaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x600070C")]
			[Address(RVA = "0x407CFE0", Offset = "0x4078FE0", VA = "0x407CFE0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600070D")]
			[Address(RVA = "0x407D46C", Offset = "0x407946C", VA = "0x407D46C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4001B08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static WebApiClient _instance;

		[Token(Token = "0x4001B09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string access_token;

		[Token(Token = "0x4001B0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int sending;

		[Token(Token = "0x4001B0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string last_error;

		[Token(Token = "0x1700009B")]
		public static WebApiClient Instance
		{
			[Token(Token = "0x60006FF")]
			[Address(RVA = "0x407BFF0", Offset = "0x4077FF0", VA = "0x407BFF0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0x407C0B8", Offset = "0x40780B8", VA = "0x407C0B8")]
		[AsyncStateMachine(typeof(_003CSendGetRequest_003Ed__6))]
		public Task<WebResponse> SendGetRequest(string url)
		{
			return null;
		}

		[Token(Token = "0x6000701")]
		[Address(RVA = "0x407C1B4", Offset = "0x40781B4", VA = "0x407C1B4")]
		[AsyncStateMachine(typeof(_003CSendPostRequest_003Ed__7))]
		public Task<WebResponse> SendPostRequest(string url, string json_data)
		{
			return null;
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0x407C2B8", Offset = "0x40782B8", VA = "0x407C2B8")]
		[AsyncStateMachine(typeof(_003CSendRequest_003Ed__8))]
		public Task<WebResponse> SendRequest(string url, string method, string json_data = "")
		{
			return null;
		}

		[Token(Token = "0x6000703")]
		[Address(RVA = "0x407C3C8", Offset = "0x40783C8", VA = "0x407C3C8")]
		[AsyncStateMachine(typeof(_003CSendRequest_003Ed__9))]
		private Task<WebResponse> SendRequest(UnityWebRequest request)
		{
			return null;
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0x407C4C4", Offset = "0x40784C4", VA = "0x407C4C4")]
		private string GetError(WebResponse res)
		{
			return null;
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0x407C064", Offset = "0x4078064", VA = "0x407C064")]
		public WebApiClient()
		{
		}
	}
}
