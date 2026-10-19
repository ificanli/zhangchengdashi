using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x20002C3")]
	public class DeathBellProp : PropBase
	{
		[Token(Token = "0x20002C4")]
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass10_0
		{
			[Token(Token = "0x40021EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public DeathBellProp _003C_003E4__this;

			[Token(Token = "0x40021EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GameObject rolePrefabRes;

			[Token(Token = "0x40021F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool capturedIsEnemy;

			[Token(Token = "0x40021F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public int capturedCardLevel;

			[Token(Token = "0x6000C8E")]
			[Address(RVA = "0x3D40634", Offset = "0x3D3C634", VA = "0x3D40634")]
			public _003C_003Ec__DisplayClass10_0()
			{
			}

			[Token(Token = "0x6000C8F")]
			[Address(RVA = "0x3D4063C", Offset = "0x3D3C63C", VA = "0x3D4063C")]
			internal void _003CUse_003Eb__0(object deadObj)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002C5")]
		[CompilerGenerated]
		private struct _003CStartPeriodicTask_003Ed__12 : IAsyncStateMachine
		{
			[Token(Token = "0x40021F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40021F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40021F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public DeathBellProp _003C_003E4__this;

			[Token(Token = "0x40021F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int runId;

			[Token(Token = "0x40021F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000C90")]
			[Address(RVA = "0x3D40AA4", Offset = "0x3D3CAA4", VA = "0x3D40AA4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000C91")]
			[Address(RVA = "0x3D410B0", Offset = "0x3D3D0B0", VA = "0x3D410B0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002C6")]
		[CompilerGenerated]
		private struct _003CUse_003Ed__10 : IAsyncStateMachine
		{
			[Token(Token = "0x40021F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40021F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40021F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public DeathBellProp _003C_003E4__this;

			[Token(Token = "0x40021FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool isEnemy;

			[Token(Token = "0x40021FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private _003C_003Ec__DisplayClass10_0 _003C_003E8__1;

			[Token(Token = "0x40021FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public List<RoleBehaviour> target;

			[Token(Token = "0x40021FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private int _003CcardLevel_003E5__2;

			[Token(Token = "0x40021FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x40021FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private UniTask.Awaiter _003C_003Eu__2;

			[Token(Token = "0x6000C92")]
			[Address(RVA = "0x3D410BC", Offset = "0x3D3D0BC", VA = "0x3D410BC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000C93")]
			[Address(RVA = "0x3D42848", Offset = "0x3D3E848", VA = "0x3D42848", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40021E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		private bool takeEffectIng;

		[Token(Token = "0x40021E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<RoleBehaviour> nowHornRole;

		[Token(Token = "0x40021E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly List<RoleBehaviour> nowHornRoleSnapshot;

		[Token(Token = "0x40021E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<int> nowHornAllRoleID;

		[Token(Token = "0x40021EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int _periodicRunId;

		[Token(Token = "0x40021EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int obb;

		[Token(Token = "0x40021EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private GameObject obj;

		[Token(Token = "0x40021ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Action<object> _bGroupDeathCallback;

		[Token(Token = "0x6000C85")]
		[Address(RVA = "0x3D3FE10", Offset = "0x3D3BE10", VA = "0x3D3FE10")]
		public DeathBellProp(string id)
		{
		}

		[Token(Token = "0x6000C86")]
		[Address(RVA = "0x3D3FEF4", Offset = "0x3D3BEF4", VA = "0x3D3FEF4", Slot = "4")]
		public override void Use(bool isEnemy, List<RoleBehaviour> target)
		{
		}

		[Token(Token = "0x6000C87")]
		[Address(RVA = "0x3D3FF0C", Offset = "0x3D3BF0C", VA = "0x3D3FF0C", Slot = "5")]
		[AsyncStateMachine(typeof(_003CUse_003Ed__10))]
		public override void Use(bool isEnemy, List<RoleBehaviour> target, Vector3? releasePos)
		{
		}

		[Token(Token = "0x6000C88")]
		[Address(RVA = "0x3D3FFC0", Offset = "0x3D3BFC0", VA = "0x3D3FFC0", Slot = "6")]
		protected override void GameEnd(object o)
		{
		}

		[Token(Token = "0x6000C89")]
		[Address(RVA = "0x3D40284", Offset = "0x3D3C284", VA = "0x3D40284")]
		[AsyncStateMachine(typeof(_003CStartPeriodicTask_003Ed__12))]
		private void StartPeriodicTask(int runId)
		{
		}

		[Token(Token = "0x6000C8A")]
		[Address(RVA = "0x3D40324", Offset = "0x3D3C324", VA = "0x3D40324")]
		private void HasEnemyRoleCreat(object o)
		{
		}

		[Token(Token = "0x6000C8B")]
		[Address(RVA = "0x3D404EC", Offset = "0x3D3C4EC", VA = "0x3D404EC")]
		private void HasPlayerRoleCreat(object o)
		{
		}

		[Token(Token = "0x6000C8C")]
		[Address(RVA = "0x3D40328", Offset = "0x3D3C328", VA = "0x3D40328")]
		private void TempRecordHorn(object o)
		{
		}

		[Token(Token = "0x6000C8D")]
		[Address(RVA = "0x3D404F0", Offset = "0x3D3C4F0", VA = "0x3D404F0")]
		private void HasRoleDead(object o)
		{
		}
	}
}
