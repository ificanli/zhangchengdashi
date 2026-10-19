using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine.Networking;

namespace ToolModule
{
	[Token(Token = "0x200019E")]
	public class JsonLoadTool
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200019F")]
		[CompilerGenerated]
		private struct _003CLoadFromStreaming_003Ed__0 : IAsyncStateMachine
		{
			[Token(Token = "0x4001AC2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001AC3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

			[Token(Token = "0x4001AC4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string jsonPath;

			[Token(Token = "0x4001AC5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UnityWebRequest _003Crequest_003E5__2;

			[Token(Token = "0x4001AC6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UnityWebRequestAsyncOperation _003Cres_003E5__3;

			[Token(Token = "0x4001AC7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private TaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x60006A1")]
			[Address(RVA = "0x3F813AC", Offset = "0x3F7D3AC", VA = "0x3F813AC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60006A2")]
			[Address(RVA = "0x3F818D4", Offset = "0x3F7D8D4", VA = "0x3F818D4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x600069F")]
		[Address(RVA = "0x3F812C0", Offset = "0x3F7D2C0", VA = "0x3F812C0")]
		[AsyncStateMachine(typeof(_003CLoadFromStreaming_003Ed__0))]
		public static Task<string> LoadFromStreaming(string jsonPath)
		{
			return null;
		}

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0x3F813A4", Offset = "0x3F7D3A4", VA = "0x3F813A4")]
		public JsonLoadTool()
		{
		}
	}
}
