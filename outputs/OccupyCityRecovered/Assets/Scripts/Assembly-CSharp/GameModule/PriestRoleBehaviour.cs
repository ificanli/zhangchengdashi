using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x2000355")]
	public class PriestRoleBehaviour : OrcsBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000356")]
		[CompilerGenerated]
		private struct _003CPriestSkill_003Ed__1 : IAsyncStateMachine
		{
			[Token(Token = "0x400248C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400248D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400248E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public PriestRoleBehaviour _003C_003E4__this;

			[Token(Token = "0x400248F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000EDF")]
			[Address(RVA = "0x3D7B2A8", Offset = "0x3D772A8", VA = "0x3D7B2A8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000EE0")]
			[Address(RVA = "0x3D7B6D4", Offset = "0x3D776D4", VA = "0x3D7B6D4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x6000EDB")]
		[Address(RVA = "0x3D7AEA0", Offset = "0x3D76EA0", VA = "0x3D7AEA0", Slot = "31")]
		protected override void EmitSkill()
		{
		}

		[Token(Token = "0x6000EDC")]
		[Address(RVA = "0x3D7AEA4", Offset = "0x3D76EA4", VA = "0x3D7AEA4")]
		[AsyncStateMachine(typeof(_003CPriestSkill_003Ed__1))]
		private void PriestSkill()
		{
		}

		[Token(Token = "0x6000EDD")]
		[Address(RVA = "0x3D7AF30", Offset = "0x3D76F30", VA = "0x3D7AF30", Slot = "30")]
		protected override void AtkCallBack(int attackNum)
		{
		}

		[Token(Token = "0x6000EDE")]
		[Address(RVA = "0x3D7B2A0", Offset = "0x3D772A0", VA = "0x3D7B2A0")]
		public PriestRoleBehaviour()
		{
		}
	}
}
