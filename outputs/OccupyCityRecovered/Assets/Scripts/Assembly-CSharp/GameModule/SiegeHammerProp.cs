using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x20002E9")]
	public class SiegeHammerProp : PropBase
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002EA")]
		[CompilerGenerated]
		private struct _003CUse_003Ed__3 : IAsyncStateMachine
		{
			[Token(Token = "0x40022A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40022A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40022A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public SiegeHammerProp _003C_003E4__this;

			[Token(Token = "0x40022A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool isEnemy;

			[Token(Token = "0x40022A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public List<RoleBehaviour> target;

			[Token(Token = "0x40022A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000D08")]
			[Address(RVA = "0x3D50F5C", Offset = "0x3D4CF5C", VA = "0x3D50F5C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000D09")]
			[Address(RVA = "0x3D51B78", Offset = "0x3D4DB78", VA = "0x3D51B78", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40022A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<RoleBehaviour> nowHammerRole;

		[Token(Token = "0x40022A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<int> nowHammerAllRoleID;

		[Token(Token = "0x6000D00")]
		[Address(RVA = "0x3D50480", Offset = "0x3D4C480", VA = "0x3D50480")]
		public SiegeHammerProp(string id)
		{
		}

		[Token(Token = "0x6000D01")]
		[Address(RVA = "0x3D5054C", Offset = "0x3D4C54C", VA = "0x3D5054C", Slot = "4")]
		[AsyncStateMachine(typeof(_003CUse_003Ed__3))]
		public override void Use(bool isEnemy, List<RoleBehaviour> target)
		{
		}

		[Token(Token = "0x6000D02")]
		[Address(RVA = "0x3D505F8", Offset = "0x3D4C5F8", VA = "0x3D505F8")]
		private void RemoveThisRecord()
		{
		}

		[Token(Token = "0x6000D03")]
		[Address(RVA = "0x3D50780", Offset = "0x3D4C780", VA = "0x3D50780")]
		private void HasEnemyRoleCreat(object o)
		{
		}

		[Token(Token = "0x6000D04")]
		[Address(RVA = "0x3D50A04", Offset = "0x3D4CA04", VA = "0x3D50A04")]
		private void HasPlayerRoleCreat(object o)
		{
		}

		[Token(Token = "0x6000D05")]
		[Address(RVA = "0x3D50784", Offset = "0x3D4C784", VA = "0x3D50784")]
		private void TempRecordHammer(object o)
		{
		}

		[Token(Token = "0x6000D06")]
		[Address(RVA = "0x3D50A08", Offset = "0x3D4CA08", VA = "0x3D50A08", Slot = "6")]
		protected override void GameEnd(object o)
		{
		}

		[Token(Token = "0x6000D07")]
		[Address(RVA = "0x3D50D7C", Offset = "0x3D4CD7C", VA = "0x3D50D7C")]
		private void HasRoleDead(object o)
		{
		}
	}
}
