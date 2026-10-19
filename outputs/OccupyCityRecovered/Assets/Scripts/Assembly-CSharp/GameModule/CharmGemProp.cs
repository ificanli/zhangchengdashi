using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x20002BE")]
	public class CharmGemProp : PropBase
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002C2")]
		[CompilerGenerated]
		private struct _003CUse_003Ed__5 : IAsyncStateMachine
		{
			[Token(Token = "0x40021DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40021E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40021E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public List<RoleBehaviour> target;

			[Token(Token = "0x40021E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public CharmGemProp _003C_003E4__this;

			[Token(Token = "0x40021E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Vector3? releasePos;

			[Token(Token = "0x40021E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public bool isEnemy;

			[Token(Token = "0x40021E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000C83")]
			[Address(RVA = "0x3D3EA1C", Offset = "0x3D3AA1C", VA = "0x3D3EA1C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000C84")]
			[Address(RVA = "0x3D3FE04", Offset = "0x3D3BE04", VA = "0x3D3FE04", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40021D8")]
		private const float CharmRange = 8f;

		[Token(Token = "0x40021D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly List<RoleBehaviour> _allCharmList;

		[Token(Token = "0x40021DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly List<int> _allCharmListId;

		[Token(Token = "0x6000C76")]
		[Address(RVA = "0x3D3E0B8", Offset = "0x3D3A0B8", VA = "0x3D3E0B8")]
		public CharmGemProp(string id)
		{
		}

		[Token(Token = "0x6000C77")]
		[Address(RVA = "0x3D3E184", Offset = "0x3D3A184", VA = "0x3D3E184", Slot = "4")]
		public override void Use(bool isEnemy, List<RoleBehaviour> target)
		{
		}

		[Token(Token = "0x6000C78")]
		[Address(RVA = "0x3D3E19C", Offset = "0x3D3A19C", VA = "0x3D3E19C", Slot = "5")]
		[AsyncStateMachine(typeof(_003CUse_003Ed__5))]
		public override void Use(bool isEnemy, List<RoleBehaviour> target, Vector3? releasePos)
		{
		}

		[Token(Token = "0x6000C79")]
		[Address(RVA = "0x3D3E258", Offset = "0x3D3A258", VA = "0x3D3E258", Slot = "6")]
		protected override void GameEnd(object o)
		{
		}

		[Token(Token = "0x6000C7A")]
		[Address(RVA = "0x3D3E4EC", Offset = "0x3D3A4EC", VA = "0x3D3E4EC")]
		private void HasRoleDead(object obj)
		{
		}

		[Token(Token = "0x6000C7B")]
		[Address(RVA = "0x3D3E644", Offset = "0x3D3A644", VA = "0x3D3E644")]
		private static int CountNearbySameSide(RoleBehaviour center, List<RoleBehaviour> allTargets)
		{
			return default;
		}
	}
}
