using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using DataModule;
using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x200031F")]
	public class ChieftainRoleBehaviour : OrcsBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000320")]
		[CompilerGenerated]
		private struct _003CAtkCallBack_003Ed__4 : IAsyncStateMachine
		{
			[Token(Token = "0x4002382")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002383")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002384")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ChieftainRoleBehaviour _003C_003E4__this;

			[Token(Token = "0x4002385")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int attackNum;

			[Token(Token = "0x4002386")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000E2E")]
			[Address(RVA = "0x3D6B8B0", Offset = "0x3D678B0", VA = "0x3D6B8B0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000E2F")]
			[Address(RVA = "0x3D6C04C", Offset = "0x3D6804C", VA = "0x3D6C04C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000321")]
		[CompilerGenerated]
		private struct _003CChieftainSkill_003Ed__3 : IAsyncStateMachine
		{
			[Token(Token = "0x4002387")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002388")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002389")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ChieftainRoleBehaviour _003C_003E4__this;

			[Token(Token = "0x400238A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000E30")]
			[Address(RVA = "0x3D6C058", Offset = "0x3D68058", VA = "0x3D6C058", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000E31")]
			[Address(RVA = "0x3D6C578", Offset = "0x3D68578", VA = "0x3D6C578", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4002381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
		private readonly List<RoleBehaviour> skillEnemyRole;

		[Token(Token = "0x6000E28")]
		[Address(RVA = "0x3D6B2E4", Offset = "0x3D672E4", VA = "0x3D6B2E4", Slot = "20")]
		public override void Init(GlobalRoleInfo info, bool isEnemy, int cardLevel, RareLevel rareLevel, [Optional] string relativeCardID, CardFettersType fettersType = CardFettersType.Null, AtkWayType atkWayType = AtkWayType.Null)
		{
		}

		[Token(Token = "0x6000E29")]
		[Address(RVA = "0x3D6B644", Offset = "0x3D67644", VA = "0x3D6B644", Slot = "31")]
		protected override void EmitSkill()
		{
		}

		[Token(Token = "0x6000E2A")]
		[Address(RVA = "0x3D6B660", Offset = "0x3D67660", VA = "0x3D6B660")]
		[AsyncStateMachine(typeof(_003CChieftainSkill_003Ed__3))]
		private void ChieftainSkill()
		{
		}

		[Token(Token = "0x6000E2B")]
		[Address(RVA = "0x3D6B6EC", Offset = "0x3D676EC", VA = "0x3D6B6EC", Slot = "30")]
		[AsyncStateMachine(typeof(_003CAtkCallBack_003Ed__4))]
		protected override void AtkCallBack(int attackNum)
		{
		}

		[Token(Token = "0x6000E2C")]
		[Address(RVA = "0x3D6B78C", Offset = "0x3D6778C", VA = "0x3D6B78C")]
		public ChieftainRoleBehaviour()
		{
		}
	}
}
