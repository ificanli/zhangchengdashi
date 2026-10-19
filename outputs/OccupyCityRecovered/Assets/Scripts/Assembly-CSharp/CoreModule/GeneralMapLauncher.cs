using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;

namespace CoreModule
{
	[Token(Token = "0x2000215")]
	public class GeneralMapLauncher : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000216")]
		[CompilerGenerated]
		private struct _003CAwake_003Ed__0 : IAsyncStateMachine
		{
			[Token(Token = "0x4001D1F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001D20")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001D21")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60008A6")]
			[Address(RVA = "0x4195F34", Offset = "0x4191F34", VA = "0x4195F34", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60008A7")]
			[Address(RVA = "0x4196678", Offset = "0x4192678", VA = "0x4196678", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x60008A4")]
		[Address(RVA = "0x4195EA4", Offset = "0x4191EA4", VA = "0x4195EA4")]
		[AsyncStateMachine(typeof(_003CAwake_003Ed__0))]
		private void Awake()
		{
		}

		[Token(Token = "0x60008A5")]
		[Address(RVA = "0x4195F2C", Offset = "0x4191F2C", VA = "0x4195F2C")]
		public GeneralMapLauncher()
		{
		}
	}
}
