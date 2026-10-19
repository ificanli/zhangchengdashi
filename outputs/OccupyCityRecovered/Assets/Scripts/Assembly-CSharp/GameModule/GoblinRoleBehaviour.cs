using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x2000334")]
	public class GoblinRoleBehaviour : OrcsBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000335")]
		[CompilerGenerated]
		private struct _003COnDeadSkill_003Ed__1 : IAsyncStateMachine
		{
			[Token(Token = "0x40023DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40023DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40023DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public GoblinRoleBehaviour _003C_003E4__this;

			[Token(Token = "0x40023E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000E70")]
			[Address(RVA = "0x3D7132C", Offset = "0x3D6D32C", VA = "0x3D7132C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000E71")]
			[Address(RVA = "0x3D7181C", Offset = "0x3D6D81C", VA = "0x3D7181C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40023DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
		private GameObject bombRes;

		[Token(Token = "0x6000E6D")]
		[Address(RVA = "0x3D7128C", Offset = "0x3D6D28C", VA = "0x3D7128C", Slot = "37")]
		[AsyncStateMachine(typeof(_003COnDeadSkill_003Ed__1))]
		protected override void OnDeadSkill()
		{
		}

		[Token(Token = "0x6000E6E")]
		[Address(RVA = "0x3D7131C", Offset = "0x3D6D31C", VA = "0x3D7131C")]
		public GoblinRoleBehaviour()
		{
		}
	}
}
