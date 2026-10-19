using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using DataModule;
using Il2CppDummyDll;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x200035D")]
	public class RangerRoleBehaviour : TerranBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200035E")]
		[CompilerGenerated]
		private struct _003CAtkCallBack_003Ed__4 : IAsyncStateMachine
		{
			[Token(Token = "0x40024B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40024B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40024B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public RangerRoleBehaviour _003C_003E4__this;

			[Token(Token = "0x40024B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int attackNum;

			[Token(Token = "0x40024B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000EF8")]
			[Address(RVA = "0x3D7D0C0", Offset = "0x3D790C0", VA = "0x3D7D0C0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000EF9")]
			[Address(RVA = "0x3D7D690", Offset = "0x3D79690", VA = "0x3D7D690", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200035F")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__1 : IAsyncStateMachine
		{
			[Token(Token = "0x40024B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40024B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40024B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public RangerRoleBehaviour _003C_003E4__this;

			[Token(Token = "0x40024B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public GlobalRoleInfo info;

			[Token(Token = "0x40024BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool isEnemy;

			[Token(Token = "0x40024BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public int cardLevel;

			[Token(Token = "0x40024BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public RareLevel rareLevel;

			[Token(Token = "0x40024BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public string relativeCardID;

			[Token(Token = "0x40024BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public CardFettersType fettersType;

			[Token(Token = "0x40024BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public AtkWayType atkWayType;

			[Token(Token = "0x40024C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000EFA")]
			[Address(RVA = "0x3D7D69C", Offset = "0x3D7969C", VA = "0x3D7D69C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000EFB")]
			[Address(RVA = "0x3D7D9B4", Offset = "0x3D799B4", VA = "0x3D7D9B4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000360")]
		[CompilerGenerated]
		private struct _003CRangerSkill_003Ed__3 : IAsyncStateMachine
		{
			[Token(Token = "0x40024C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40024C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40024C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public RangerRoleBehaviour _003C_003E4__this;

			[Token(Token = "0x40024C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private List<float>.Enumerator _003C_003E7__wrap1;

			[Token(Token = "0x40024C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000EFC")]
			[Address(RVA = "0x3D7D9C0", Offset = "0x3D799C0", VA = "0x3D7D9C0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000EFD")]
			[Address(RVA = "0x3D7E148", Offset = "0x3D7A148", VA = "0x3D7E148", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40024B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
		private GameObject bulletProRes;

		[Token(Token = "0x6000EF1")]
		[Address(RVA = "0x3D7CE88", Offset = "0x3D78E88", VA = "0x3D7CE88", Slot = "20")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__1))]
		public override void Init(GlobalRoleInfo info, bool isEnemy, int cardLevel, RareLevel rareLevel, [Optional] string relativeCardID, CardFettersType fettersType = CardFettersType.Null, AtkWayType atkWayType = AtkWayType.Null)
		{
		}

		[Token(Token = "0x6000EF2")]
		[Address(RVA = "0x3D7CF6C", Offset = "0x3D78F6C", VA = "0x3D7CF6C", Slot = "31")]
		protected override void EmitSkill()
		{
		}

		[Token(Token = "0x6000EF3")]
		[Address(RVA = "0x3D7CF70", Offset = "0x3D78F70", VA = "0x3D7CF70")]
		[AsyncStateMachine(typeof(_003CRangerSkill_003Ed__3))]
		private void RangerSkill()
		{
		}

		[Token(Token = "0x6000EF4")]
		[Address(RVA = "0x3D7D004", Offset = "0x3D79004", VA = "0x3D7D004", Slot = "30")]
		[AsyncStateMachine(typeof(_003CAtkCallBack_003Ed__4))]
		protected override void AtkCallBack(int attackNum)
		{
		}

		[Token(Token = "0x6000EF5")]
		[Address(RVA = "0x3D7D0A4", Offset = "0x3D790A4", VA = "0x3D7D0A4")]
		public RangerRoleBehaviour()
		{
		}
	}
}
