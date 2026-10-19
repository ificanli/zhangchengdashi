using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x20002EF")]
	public class TelescopeProp : PropBase
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002F0")]
		[CompilerGenerated]
		private struct _003CUse_003Ed__3 : IAsyncStateMachine
		{
			[Token(Token = "0x40022B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40022BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40022BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public TelescopeProp _003C_003E4__this;

			[Token(Token = "0x40022BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool isEnemy;

			[Token(Token = "0x40022BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public List<RoleBehaviour> target;

			[Token(Token = "0x40022BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000D20")]
			[Address(RVA = "0x3D53BC4", Offset = "0x3D4FBC4", VA = "0x3D53BC4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000D21")]
			[Address(RVA = "0x3D547C8", Offset = "0x3D507C8", VA = "0x3D547C8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40022B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly List<RoleBehaviour> _nowRangeRoles;

		[Token(Token = "0x40022B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly List<int> _nowRangeAllRoleIds;

		[Token(Token = "0x6000D18")]
		[Address(RVA = "0x3D531D0", Offset = "0x3D4F1D0", VA = "0x3D531D0")]
		public TelescopeProp(string id)
		{
		}

		[Token(Token = "0x6000D19")]
		[Address(RVA = "0x3D5329C", Offset = "0x3D4F29C", VA = "0x3D5329C", Slot = "4")]
		[AsyncStateMachine(typeof(_003CUse_003Ed__3))]
		public override void Use(bool isEnemy, List<RoleBehaviour> target)
		{
		}

		[Token(Token = "0x6000D1A")]
		[Address(RVA = "0x3D53348", Offset = "0x3D4F348", VA = "0x3D53348")]
		private void RemoveThisRecord()
		{
		}

		[Token(Token = "0x6000D1B")]
		[Address(RVA = "0x3D533B0", Offset = "0x3D4F3B0", VA = "0x3D533B0")]
		private void HasEnemyRoleCreat(object o)
		{
		}

		[Token(Token = "0x6000D1C")]
		[Address(RVA = "0x3D53634", Offset = "0x3D4F634", VA = "0x3D53634")]
		private void HasPlayerRoleCreat(object o)
		{
		}

		[Token(Token = "0x6000D1D")]
		[Address(RVA = "0x3D533B4", Offset = "0x3D4F3B4", VA = "0x3D533B4")]
		private void TempRecordRange(object o)
		{
		}

		[Token(Token = "0x6000D1E")]
		[Address(RVA = "0x3D53638", Offset = "0x3D4F638", VA = "0x3D53638", Slot = "6")]
		protected override void GameEnd(object o)
		{
		}

		[Token(Token = "0x6000D1F")]
		[Address(RVA = "0x3D539E0", Offset = "0x3D4F9E0", VA = "0x3D539E0")]
		private void HasRoleDead(object o)
		{
		}
	}
}
