using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;

namespace QuickTutor
{
	[Token(Token = "0x2000C9C")]
	public class Singleton<T> where T : new()
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000C9E")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__4 : IAsyncStateMachine
		{
			[Token(Token = "0x4005A98")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005A99")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x6004F2A")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004F2B")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4005A96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Lazy<T> instance;

		[Token(Token = "0x17000E1E")]
		public static T Instance
		{
			[Token(Token = "0x6004F24")]
			get
			{
				return (T)null;
			}
		}

		[Token(Token = "0x6004F23")]
		protected Singleton()
		{
		}

		[Token(Token = "0x6004F25")]
		[AsyncStateMachine(typeof(Singleton<>._003CInit_003Ed__4))]
		public virtual UniTask Init(params object[] args)
		{
			return default;
		}
	}
}
