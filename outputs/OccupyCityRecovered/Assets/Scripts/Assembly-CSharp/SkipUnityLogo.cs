using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Scripting;

[Token(Token = "0x20000C0")]
[Preserve]
public class SkipUnityLogo
{
	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private struct _003CAsyncSkip_003Ed__1 : IAsyncStateMachine
	{
		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TaskAwaiter _003C_003Eu__1;

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x3E3A11C", Offset = "0x3E3611C", VA = "0x3E3A11C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x3E3A318", Offset = "0x3E36318", VA = "0x3E3A318", Slot = "5")]
		[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x6000409")]
	[Address(RVA = "0x3E39FB8", Offset = "0x3E35FB8", VA = "0x3E39FB8")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
	private static void BeforeSplashScreen()
	{
	}

	[Token(Token = "0x600040A")]
	[Address(RVA = "0x3E3A058", Offset = "0x3E36058", VA = "0x3E3A058")]
	[AsyncStateMachine(typeof(_003CAsyncSkip_003Ed__1))]
	private static Task AsyncSkip()
	{
		return null;
	}

	[Token(Token = "0x600040B")]
	[Address(RVA = "0x3E3A114", Offset = "0x3E36114", VA = "0x3E3A114")]
	public SkipUnityLogo()
	{
	}
}
