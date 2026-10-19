using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine.Networking;

namespace ToolModule.Web
{
	[Token(Token = "0x20001BE")]
	public class WebTool
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20001BF")]
		[CompilerGenerated]
		private struct _003CSendRequest_003Ed__4 : IAsyncStateMachine
		{
			[Token(Token = "0x4001B30")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001B31")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<WebResponse> _003C_003Et__builder;

			[Token(Token = "0x4001B32")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string url;

			[Token(Token = "0x4001B33")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TaskAwaiter<WebResponse> _003C_003Eu__1;

			[Token(Token = "0x6000733")]
			[Address(RVA = "0x407E944", Offset = "0x407A944", VA = "0x407E944", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000734")]
			[Address(RVA = "0x407EB88", Offset = "0x407AB88", VA = "0x407EB88", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20001C0")]
		[CompilerGenerated]
		private struct _003CSendRequest_003Ed__5 : IAsyncStateMachine
		{
			[Token(Token = "0x4001B34")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001B35")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<WebResponse> _003C_003Et__builder;

			[Token(Token = "0x4001B36")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public UnityWebRequest request;

			[Token(Token = "0x4001B37")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UnityWebRequestAsyncOperation _003CasyncOp_003E5__2;

			[Token(Token = "0x4001B38")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private TaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x6000735")]
			[Address(RVA = "0x407EC04", Offset = "0x407AC04", VA = "0x407EC04", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000736")]
			[Address(RVA = "0x407EF80", Offset = "0x407AF80", VA = "0x407EF80", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x600072C")]
		public static T JsonToObject<T>(string json)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED WebTool.JsonToObject RVA= Token=0x600072C");
}

		[Token(Token = "0x600072D")]
		public static T[] JsonToArray<T>(string json)
		{
			return null;
		}

		[Token(Token = "0x600072E")]
		[Address(RVA = "0x407E71C", Offset = "0x407A71C", VA = "0x407E71C")]
		public static string ToJson(object data)
		{
			return null;
		}

		[Token(Token = "0x600072F")]
		[Address(RVA = "0x407E724", Offset = "0x407A724", VA = "0x407E724")]
		public static int Parse(string int_str, int default_val = 0)
		{
			return default;
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0x407E758", Offset = "0x407A758", VA = "0x407E758")]
		[AsyncStateMachine(typeof(_003CSendRequest_003Ed__4))]
		public static Task<WebResponse> SendRequest(string url)
		{
			return null;
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0x407E848", Offset = "0x407A848", VA = "0x407E848")]
		[AsyncStateMachine(typeof(_003CSendRequest_003Ed__5))]
		public static Task<WebResponse> SendRequest(UnityWebRequest request)
		{
			return null;
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0x407E93C", Offset = "0x407A93C", VA = "0x407E93C")]
		public WebTool()
		{
		}
	}
}
