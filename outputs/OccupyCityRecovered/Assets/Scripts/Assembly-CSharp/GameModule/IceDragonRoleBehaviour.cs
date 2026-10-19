using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using DataModule;
using Il2CppDummyDll;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x200033B")]
	public class IceDragonRoleBehaviour : UndeadBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200033C")]
		[CompilerGenerated]
		private struct _003CIceDragonSkill_003Ed__3 : IAsyncStateMachine
		{
			[Token(Token = "0x40023FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40023FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002400")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public IceDragonRoleBehaviour _003C_003E4__this;

			[Token(Token = "0x4002401")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000E88")]
			[Address(RVA = "0x3D73418", Offset = "0x3D6F418", VA = "0x3D73418", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000E89")]
			[Address(RVA = "0x3D737AC", Offset = "0x3D6F7AC", VA = "0x3D737AC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200033D")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__1 : IAsyncStateMachine
		{
			[Token(Token = "0x4002402")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002403")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002404")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public IceDragonRoleBehaviour _003C_003E4__this;

			[Token(Token = "0x4002405")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public GlobalRoleInfo info;

			[Token(Token = "0x4002406")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool isEnemy;

			[Token(Token = "0x4002407")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public int cardLevel;

			[Token(Token = "0x4002408")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public RareLevel rareLevel;

			[Token(Token = "0x4002409")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public string relativeCardID;

			[Token(Token = "0x400240A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public CardFettersType fettersType;

			[Token(Token = "0x400240B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public AtkWayType atkWayType;

			[Token(Token = "0x400240C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000E8A")]
			[Address(RVA = "0x3D737B8", Offset = "0x3D6F7B8", VA = "0x3D737B8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000E8B")]
			[Address(RVA = "0x3D73C90", Offset = "0x3D6FC90", VA = "0x3D73C90", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40023FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
		private GameObject SkillBulletRes;

		[Token(Token = "0x6000E82")]
		[Address(RVA = "0x3D73018", Offset = "0x3D6F018", VA = "0x3D73018", Slot = "20")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__1))]
		public override void Init(GlobalRoleInfo info, bool isEnemy, int cardLevel, RareLevel rareLevel, [Optional] string relativeCardID, CardFettersType fettersType = CardFettersType.Null, AtkWayType atkWayType = AtkWayType.Null)
		{
		}

		[Token(Token = "0x6000E83")]
		[Address(RVA = "0x3D730FC", Offset = "0x3D6F0FC", VA = "0x3D730FC", Slot = "31")]
		protected override void EmitSkill()
		{
		}

		[Token(Token = "0x6000E84")]
		[Address(RVA = "0x3D73118", Offset = "0x3D6F118", VA = "0x3D73118")]
		[AsyncStateMachine(typeof(_003CIceDragonSkill_003Ed__3))]
		private void IceDragonSkill()
		{
		}

		[Token(Token = "0x6000E85")]
		[Address(RVA = "0x3D731A4", Offset = "0x3D6F1A4", VA = "0x3D731A4", Slot = "30")]
		protected override void AtkCallBack(int attackNum)
		{
		}

		[Token(Token = "0x6000E86")]
		[Address(RVA = "0x3D73404", Offset = "0x3D6F404", VA = "0x3D73404")]
		public IceDragonRoleBehaviour()
		{
		}
	}
}
