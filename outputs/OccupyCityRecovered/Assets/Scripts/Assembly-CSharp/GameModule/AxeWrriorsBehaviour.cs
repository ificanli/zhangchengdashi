using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x2000316")]
	public class AxeWrriorsBehaviour : OrcsBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000317")]
		[CompilerGenerated]
		private struct _003CAxeWarriorsSkill_003Ed__1 : IAsyncStateMachine
		{
			[Token(Token = "0x4002366")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002367")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002368")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public AxeWrriorsBehaviour _003C_003E4__this;

			[Token(Token = "0x4002369")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Collider[] _003CallObj_003E5__2;

			[Token(Token = "0x400236A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x400236B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private int _003Ci_003E5__3;

			[Token(Token = "0x400236C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__2;

			[Token(Token = "0x6000E04")]
			[Address(RVA = "0x3D68320", Offset = "0x3D64320", VA = "0x3D68320", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000E05")]
			[Address(RVA = "0x3D68C24", Offset = "0x3D64C24", VA = "0x3D68C24", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x6000E01")]
		[Address(RVA = "0x3D68264", Offset = "0x3D64264", VA = "0x3D68264", Slot = "31")]
		protected override void EmitSkill()
		{
		}

		[Token(Token = "0x6000E02")]
		[Address(RVA = "0x3D68280", Offset = "0x3D64280", VA = "0x3D68280")]
		[AsyncStateMachine(typeof(_003CAxeWarriorsSkill_003Ed__1))]
		private void AxeWarriorsSkill()
		{
		}

		[Token(Token = "0x6000E03")]
		[Address(RVA = "0x3D68310", Offset = "0x3D64310", VA = "0x3D68310")]
		public AxeWrriorsBehaviour()
		{
		}
	}
}
