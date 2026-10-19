using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x20002F3")]
	public class WarHornProp : PropBase
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002F4")]
		[CompilerGenerated]
		private struct _003CUse_003Ed__3 : IAsyncStateMachine
		{
			[Token(Token = "0x40022C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40022C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40022CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public WarHornProp _003C_003E4__this;

			[Token(Token = "0x40022CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool isEnemy;

			[Token(Token = "0x40022CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public List<RoleBehaviour> target;

			[Token(Token = "0x40022CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000D2E")]
			[Address(RVA = "0x3D55DC0", Offset = "0x3D51DC0", VA = "0x3D55DC0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000D2F")]
			[Address(RVA = "0x3D56950", Offset = "0x3D52950", VA = "0x3D56950", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40022C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<RoleBehaviour> nowHornRole;

		[Token(Token = "0x40022C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<int> nowHornAllRoleID;

		[Token(Token = "0x6000D26")]
		[Address(RVA = "0x3D55414", Offset = "0x3D51414", VA = "0x3D55414")]
		public WarHornProp(string id)
		{
		}

		[Token(Token = "0x6000D27")]
		[Address(RVA = "0x3D554E0", Offset = "0x3D514E0", VA = "0x3D554E0", Slot = "4")]
		[AsyncStateMachine(typeof(_003CUse_003Ed__3))]
		public override void Use(bool isEnemy, List<RoleBehaviour> target)
		{
		}

		[Token(Token = "0x6000D28")]
		[Address(RVA = "0x3D5558C", Offset = "0x3D5158C", VA = "0x3D5558C")]
		private void RemoveThisRecord()
		{
		}

		[Token(Token = "0x6000D29")]
		[Address(RVA = "0x3D555F4", Offset = "0x3D515F4", VA = "0x3D555F4")]
		private void HasEnemyRoleCreat(object o)
		{
		}

		[Token(Token = "0x6000D2A")]
		[Address(RVA = "0x3D55870", Offset = "0x3D51870", VA = "0x3D55870")]
		private void HasPlayerRoleCreat(object o)
		{
		}

		[Token(Token = "0x6000D2B")]
		[Address(RVA = "0x3D555F8", Offset = "0x3D515F8", VA = "0x3D555F8")]
		private void TempRecordHorn(object o)
		{
		}

		[Token(Token = "0x6000D2C")]
		[Address(RVA = "0x3D55874", Offset = "0x3D51874", VA = "0x3D55874", Slot = "6")]
		protected override void GameEnd(object o)
		{
		}

		[Token(Token = "0x6000D2D")]
		[Address(RVA = "0x3D55BDC", Offset = "0x3D51BDC", VA = "0x3D55BDC")]
		private void HasRoleDead(object o)
		{
		}
	}
}
