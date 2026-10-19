using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using DataModule;
using Il2CppDummyDll;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x2000323")]
	public class DemonLordRoleBehaviour : UndeadBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000324")]
		[CompilerGenerated]
		private struct _003CDemonLordSkill_003Ed__4 : IAsyncStateMachine
		{
			[Token(Token = "0x4002393")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002394")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002395")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public DemonLordRoleBehaviour _003C_003E4__this;

			[Token(Token = "0x4002396")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000E3E")]
			[Address(RVA = "0x3D6D0C4", Offset = "0x3D690C4", VA = "0x3D6D0C4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000E3F")]
			[Address(RVA = "0x3D6D544", Offset = "0x3D69544", VA = "0x3D6D544", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000325")]
		[CompilerGenerated]
		private struct _003CDemonLordSkillLogic_003Ed__6 : IAsyncStateMachine
		{
			[Token(Token = "0x4002397")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002398")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002399")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public DemonLordRoleBehaviour _003C_003E4__this;

			[Token(Token = "0x400239A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000E40")]
			[Address(RVA = "0x3D6D550", Offset = "0x3D69550", VA = "0x3D6D550", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000E41")]
			[Address(RVA = "0x3D6DC68", Offset = "0x3D69C68", VA = "0x3D6DC68", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000326")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__2 : IAsyncStateMachine
		{
			[Token(Token = "0x400239B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400239C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400239D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public DemonLordRoleBehaviour _003C_003E4__this;

			[Token(Token = "0x400239E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public GlobalRoleInfo info;

			[Token(Token = "0x400239F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool isEnemy;

			[Token(Token = "0x40023A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public int cardLevel;

			[Token(Token = "0x40023A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public RareLevel rareLevel;

			[Token(Token = "0x40023A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public string relativeCardID;

			[Token(Token = "0x40023A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public CardFettersType fettersType;

			[Token(Token = "0x40023A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public AtkWayType atkWayType;

			[Token(Token = "0x40023A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000E42")]
			[Address(RVA = "0x3D6DC74", Offset = "0x3D69C74", VA = "0x3D6DC74", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000E43")]
			[Address(RVA = "0x3D6E0E0", Offset = "0x3D6A0E0", VA = "0x3D6E0E0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4002391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D1")]
		public bool EmitHellFireIng;

		[Token(Token = "0x4002392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
		private GameObject res;

		[Token(Token = "0x6000E37")]
		[Address(RVA = "0x3D6CE5C", Offset = "0x3D68E5C", VA = "0x3D6CE5C", Slot = "20")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__2))]
		public override void Init(GlobalRoleInfo info, bool isEnemy, int cardLevel, RareLevel rareLevel, [Optional] string relativeCardID, CardFettersType fettersType = CardFettersType.Null, AtkWayType atkWayType = AtkWayType.Null)
		{
		}

		[Token(Token = "0x6000E38")]
		[Address(RVA = "0x3D6CF40", Offset = "0x3D68F40", VA = "0x3D6CF40", Slot = "31")]
		protected override void EmitSkill()
		{
		}

		[Token(Token = "0x6000E39")]
		[Address(RVA = "0x3D6CF5C", Offset = "0x3D68F5C", VA = "0x3D6CF5C")]
		[AsyncStateMachine(typeof(_003CDemonLordSkill_003Ed__4))]
		private void DemonLordSkill()
		{
		}

		[Token(Token = "0x6000E3A")]
		[Address(RVA = "0x3D6CFE8", Offset = "0x3D68FE8", VA = "0x3D6CFE8", Slot = "30")]
		protected override void AtkCallBack(int attackNum)
		{
		}

		[Token(Token = "0x6000E3B")]
		[Address(RVA = "0x3D6D024", Offset = "0x3D69024", VA = "0x3D6D024")]
		[AsyncStateMachine(typeof(_003CDemonLordSkillLogic_003Ed__6))]
		private void DemonLordSkillLogic()
		{
		}

		[Token(Token = "0x6000E3C")]
		[Address(RVA = "0x3D6D0B0", Offset = "0x3D690B0", VA = "0x3D6D0B0")]
		public DemonLordRoleBehaviour()
		{
		}
	}
}
