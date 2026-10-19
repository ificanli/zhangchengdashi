using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x20002B9")]
	public class BlessHornProp : PropBase
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002BA")]
		[CompilerGenerated]
		private struct _003CUse_003Ed__3 : IAsyncStateMachine
		{
			[Token(Token = "0x40021C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40021C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40021C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public BlessHornProp _003C_003E4__this;

			[Token(Token = "0x40021C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool isEnemy;

			[Token(Token = "0x40021C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public List<RoleBehaviour> target;

			[Token(Token = "0x40021C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000C67")]
			[Address(RVA = "0x3D3B7C8", Offset = "0x3D377C8", VA = "0x3D3B7C8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000C68")]
			[Address(RVA = "0x3D3C358", Offset = "0x3D38358", VA = "0x3D3C358", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40021C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<RoleBehaviour> nowHornRole;

		[Token(Token = "0x40021C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<int> nowHornAllRoleID;

		[Token(Token = "0x6000C5F")]
		[Address(RVA = "0x3D3AD38", Offset = "0x3D36D38", VA = "0x3D3AD38")]
		public BlessHornProp(string id)
		{
		}

		[Token(Token = "0x6000C60")]
		[Address(RVA = "0x3D3AE94", Offset = "0x3D36E94", VA = "0x3D3AE94", Slot = "4")]
		[AsyncStateMachine(typeof(_003CUse_003Ed__3))]
		public override void Use(bool isEnemy, List<RoleBehaviour> target)
		{
		}

		[Token(Token = "0x6000C61")]
		[Address(RVA = "0x3D3AF40", Offset = "0x3D36F40", VA = "0x3D3AF40")]
		private void RemoveThisRecord()
		{
		}

		[Token(Token = "0x6000C62")]
		[Address(RVA = "0x3D3AFAC", Offset = "0x3D36FAC", VA = "0x3D3AFAC")]
		private void HasEnemyRoleCreat(object o)
		{
		}

		[Token(Token = "0x6000C63")]
		[Address(RVA = "0x3D3B224", Offset = "0x3D37224", VA = "0x3D3B224")]
		private void HasPlayerRoleCreat(object o)
		{
		}

		[Token(Token = "0x6000C64")]
		[Address(RVA = "0x3D3AFB0", Offset = "0x3D36FB0", VA = "0x3D3AFB0")]
		private void TempRecordHorn(object o)
		{
		}

		[Token(Token = "0x6000C65")]
		[Address(RVA = "0x3D3B228", Offset = "0x3D37228", VA = "0x3D3B228", Slot = "6")]
		protected override void GameEnd(object o)
		{
		}

		[Token(Token = "0x6000C66")]
		[Address(RVA = "0x3D3B5E8", Offset = "0x3D375E8", VA = "0x3D3B5E8")]
		private void HasRoleDead(object o)
		{
		}
	}
}
