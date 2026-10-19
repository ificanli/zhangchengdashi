using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x20002C7")]
	public class FrostStaffProp : PropBase
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002C8")]
		[CompilerGenerated]
		private struct _003CStartPeriodicTask_003Ed__9 : IAsyncStateMachine
		{
			[Token(Token = "0x4002206")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002207")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002208")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public FrostStaffProp _003C_003E4__this;

			[Token(Token = "0x4002209")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public CancellationToken token;

			[Token(Token = "0x400220A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000C9C")]
			[Address(RVA = "0x3D432A8", Offset = "0x3D3F2A8", VA = "0x3D432A8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000C9D")]
			[Address(RVA = "0x3D43900", Offset = "0x3D3F900", VA = "0x3D43900", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002C9")]
		[CompilerGenerated]
		private struct _003CUse_003Ed__7 : IAsyncStateMachine
		{
			[Token(Token = "0x400220B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400220C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400220D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public FrostStaffProp _003C_003E4__this;

			[Token(Token = "0x400220E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool isEnemy;

			[Token(Token = "0x400220F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public List<RoleBehaviour> target;

			[Token(Token = "0x4002210")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x4002211")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private UniTask.Awaiter _003C_003Eu__2;

			[Token(Token = "0x6000C9E")]
			[Address(RVA = "0x3D4390C", Offset = "0x3D3F90C", VA = "0x3D4390C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000C9F")]
			[Address(RVA = "0x3D44738", Offset = "0x3D40738", VA = "0x3D44738", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4002200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		private bool takeEffectIng;

		[Token(Token = "0x4002201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<RoleBehaviour> nowHornRole;

		[Token(Token = "0x4002202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly List<RoleBehaviour> nowHornRoleSnapshot;

		[Token(Token = "0x4002203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<int> nowHornAllRoleID;

		[Token(Token = "0x4002204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private CancellationTokenSource cts;

		[Token(Token = "0x4002205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private GameObject eff;

		[Token(Token = "0x6000C94")]
		[Address(RVA = "0x3D42854", Offset = "0x3D3E854", VA = "0x3D42854")]
		public FrostStaffProp(string id)
		{
		}

		[Token(Token = "0x6000C95")]
		[Address(RVA = "0x3D42938", Offset = "0x3D3E938", VA = "0x3D42938", Slot = "4")]
		[AsyncStateMachine(typeof(_003CUse_003Ed__7))]
		public override void Use(bool isEnemy, List<RoleBehaviour> target)
		{
		}

		[Token(Token = "0x6000C96")]
		[Address(RVA = "0x3D429E8", Offset = "0x3D3E9E8", VA = "0x3D429E8", Slot = "6")]
		protected override void GameEnd(object o)
		{
		}

		[Token(Token = "0x6000C97")]
		[Address(RVA = "0x3D42DC0", Offset = "0x3D3EDC0", VA = "0x3D42DC0")]
		[AsyncStateMachine(typeof(_003CStartPeriodicTask_003Ed__9))]
		private void StartPeriodicTask(CancellationToken token)
		{
		}

		[Token(Token = "0x6000C98")]
		[Address(RVA = "0x3D42E5C", Offset = "0x3D3EE5C", VA = "0x3D42E5C")]
		private void HasEnemyRoleCreat(object o)
		{
		}

		[Token(Token = "0x6000C99")]
		[Address(RVA = "0x3D430C4", Offset = "0x3D3F0C4", VA = "0x3D430C4")]
		private void HasPlayerRoleCreat(object o)
		{
		}

		[Token(Token = "0x6000C9A")]
		[Address(RVA = "0x3D42E60", Offset = "0x3D3EE60", VA = "0x3D42E60")]
		private void TempRecordHorn(object o)
		{
		}

		[Token(Token = "0x6000C9B")]
		[Address(RVA = "0x3D430C8", Offset = "0x3D3F0C8", VA = "0x3D430C8")]
		private void HasRoleDead(object o)
		{
		}
	}
}
