using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x20002BB")]
	public class ChargeHornProp : PropBase
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002BC")]
		[CompilerGenerated]
		private struct _003CStartPeriodicTask_003Ed__7 : IAsyncStateMachine
		{
			[Token(Token = "0x40021CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40021CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40021CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ChargeHornProp _003C_003E4__this;

			[Token(Token = "0x40021D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public CancellationToken token;

			[Token(Token = "0x40021D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000C72")]
			[Address(RVA = "0x3D3CE48", Offset = "0x3D38E48", VA = "0x3D3CE48", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000C73")]
			[Address(RVA = "0x3D3D294", Offset = "0x3D39294", VA = "0x3D3D294", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002BD")]
		[CompilerGenerated]
		private struct _003CUse_003Ed__4 : IAsyncStateMachine
		{
			[Token(Token = "0x40021D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40021D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40021D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ChargeHornProp _003C_003E4__this;

			[Token(Token = "0x40021D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool isEnemy;

			[Token(Token = "0x40021D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public List<RoleBehaviour> target;

			[Token(Token = "0x40021D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000C74")]
			[Address(RVA = "0x3D3D2A0", Offset = "0x3D392A0", VA = "0x3D3D2A0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000C75")]
			[Address(RVA = "0x3D3E0AC", Offset = "0x3D3A0AC", VA = "0x3D3E0AC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40021CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<RoleBehaviour> nowHornRole;

		[Token(Token = "0x40021CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<int> nowHornAllRoleID;

		[Token(Token = "0x40021CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private CancellationTokenSource cts;

		[Token(Token = "0x6000C69")]
		[Address(RVA = "0x3D3C364", Offset = "0x3D38364", VA = "0x3D3C364")]
		public ChargeHornProp(string id)
		{
		}

		[Token(Token = "0x6000C6A")]
		[Address(RVA = "0x3D3C430", Offset = "0x3D38430", VA = "0x3D3C430", Slot = "4")]
		[AsyncStateMachine(typeof(_003CUse_003Ed__4))]
		public override void Use(bool isEnemy, List<RoleBehaviour> target)
		{
		}

		[Token(Token = "0x6000C6B")]
		[Address(RVA = "0x3D3C4DC", Offset = "0x3D384DC", VA = "0x3D3C4DC")]
		private void RemoveThisRecord()
		{
		}

		[Token(Token = "0x6000C6C")]
		[Address(RVA = "0x3D3C548", Offset = "0x3D38548", VA = "0x3D3C548", Slot = "6")]
		protected override void GameEnd(object o)
		{
		}

		[Token(Token = "0x6000C6D")]
		[Address(RVA = "0x3D3C8B8", Offset = "0x3D388B8", VA = "0x3D3C8B8")]
		[AsyncStateMachine(typeof(_003CStartPeriodicTask_003Ed__7))]
		private void StartPeriodicTask(CancellationToken token)
		{
		}

		[Token(Token = "0x6000C6E")]
		[Address(RVA = "0x3D3C954", Offset = "0x3D38954", VA = "0x3D3C954")]
		private void HasEnemyRoleCreat(object o)
		{
		}

		[Token(Token = "0x6000C6F")]
		[Address(RVA = "0x3D3CC68", Offset = "0x3D38C68", VA = "0x3D3CC68")]
		private void HasPlayerRoleCreat(object o)
		{
		}

		[Token(Token = "0x6000C70")]
		[Address(RVA = "0x3D3C958", Offset = "0x3D38958", VA = "0x3D3C958")]
		private void TempRecordHorn(object o)
		{
		}

		[Token(Token = "0x6000C71")]
		[Address(RVA = "0x3D3CC6C", Offset = "0x3D38C6C", VA = "0x3D3CC6C")]
		private void HasRoleDead(object o)
		{
		}
	}
}
