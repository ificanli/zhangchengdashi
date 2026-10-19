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
	[Token(Token = "0x2000357")]
	public class QueenRoleBehaviour : UndeadBehaviour
	{
		[Token(Token = "0x2000358")]
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass5_0
		{
			[Token(Token = "0x4002492")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public QueenRoleBehaviour _003C_003E4__this;

			[Token(Token = "0x4002493")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public List<Vector3> allPos;

			[Token(Token = "0x6000EE8")]
			[Address(RVA = "0x3D7B914", Offset = "0x3D77914", VA = "0x3D7B914")]
			public _003C_003Ec__DisplayClass5_0()
			{
			}
		}

		[Token(Token = "0x2000359")]
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass5_1
		{
			[Token(Token = "0x4002494")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int index;

			[Token(Token = "0x4002495")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public _003C_003Ec__DisplayClass5_0 CS_0024_003C_003E8__locals1;

			[Token(Token = "0x6000EE9")]
			[Address(RVA = "0x3D7B91C", Offset = "0x3D7791C", VA = "0x3D7B91C")]
			public _003C_003Ec__DisplayClass5_1()
			{
			}

			[Token(Token = "0x6000EEA")]
			[Address(RVA = "0x3D7B924", Offset = "0x3D77924", VA = "0x3D7B924")]
			internal void _003CAtkCallBack_003Eb__0()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200035A")]
		[CompilerGenerated]
		private struct _003CAtkCallBack_003Ed__5 : IAsyncStateMachine
		{
			[Token(Token = "0x4002496")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002497")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002498")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public QueenRoleBehaviour _003C_003E4__this;

			[Token(Token = "0x4002499")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private _003C_003Ec__DisplayClass5_0 _003C_003E8__1;

			[Token(Token = "0x400249A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private _003C_003Ec__DisplayClass5_1 _003C_003E8__2;

			[Token(Token = "0x400249B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public int attackNum;

			[Token(Token = "0x400249C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private int _003CsummonCount_003E5__2;

			[Token(Token = "0x400249D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private GameObject _003CeffectRes_003E5__3;

			[Token(Token = "0x400249E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x400249F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private int _003Ci_003E5__4;

			[Token(Token = "0x40024A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__2;

			[Token(Token = "0x6000EEB")]
			[Address(RVA = "0x3D7BE0C", Offset = "0x3D77E0C", VA = "0x3D7BE0C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000EEC")]
			[Address(RVA = "0x3D7C71C", Offset = "0x3D7871C", VA = "0x3D7C71C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200035B")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__2 : IAsyncStateMachine
		{
			[Token(Token = "0x40024A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40024A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40024A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public QueenRoleBehaviour _003C_003E4__this;

			[Token(Token = "0x40024A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public GlobalRoleInfo info;

			[Token(Token = "0x40024A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool isEnemy;

			[Token(Token = "0x40024A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public int cardLevel;

			[Token(Token = "0x40024A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public RareLevel rareLevel;

			[Token(Token = "0x40024A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public string relativeCardID;

			[Token(Token = "0x40024A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public CardFettersType fettersType;

			[Token(Token = "0x40024AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public AtkWayType atkWayType;

			[Token(Token = "0x40024AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000EED")]
			[Address(RVA = "0x3D7C728", Offset = "0x3D78728", VA = "0x3D7C728", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000EEE")]
			[Address(RVA = "0x3D7CAE0", Offset = "0x3D78AE0", VA = "0x3D7CAE0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200035C")]
		[CompilerGenerated]
		private struct _003CQueenSkill_003Ed__4 : IAsyncStateMachine
		{
			[Token(Token = "0x40024AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40024AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40024AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public QueenRoleBehaviour _003C_003E4__this;

			[Token(Token = "0x40024AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000EEF")]
			[Address(RVA = "0x3D7CAEC", Offset = "0x3D78AEC", VA = "0x3D7CAEC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000EF0")]
			[Address(RVA = "0x3D7CE7C", Offset = "0x3D78E7C", VA = "0x3D7CE7C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4002490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
		private GameObject rolePrefabRes;

		[Token(Token = "0x4002491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
		private bool _summonWhich;

		[Token(Token = "0x6000EE1")]
		[Address(RVA = "0x3D7B6E0", Offset = "0x3D776E0", VA = "0x3D7B6E0", Slot = "20")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__2))]
		public override void Init(GlobalRoleInfo info, bool isEnemy, int cardLevel, RareLevel rareLevel, [Optional] string relativeCardID, CardFettersType fettersType = CardFettersType.Null, AtkWayType atkWayType = AtkWayType.Null)
		{
		}

		[Token(Token = "0x6000EE2")]
		[Address(RVA = "0x3D7B7C4", Offset = "0x3D777C4", VA = "0x3D7B7C4", Slot = "31")]
		protected override void EmitSkill()
		{
		}

		[Token(Token = "0x6000EE3")]
		[Address(RVA = "0x3D7B7C8", Offset = "0x3D777C8", VA = "0x3D7B7C8")]
		[AsyncStateMachine(typeof(_003CQueenSkill_003Ed__4))]
		private void QueenSkill()
		{
		}

		[Token(Token = "0x6000EE4")]
		[Address(RVA = "0x3D7B854", Offset = "0x3D77854", VA = "0x3D7B854", Slot = "30")]
		[AsyncStateMachine(typeof(_003CAtkCallBack_003Ed__5))]
		protected override void AtkCallBack(int attackNum)
		{
		}

		[Token(Token = "0x6000EE5")]
		[Address(RVA = "0x3D7B8F8", Offset = "0x3D778F8", VA = "0x3D7B8F8")]
		public QueenRoleBehaviour()
		{
		}
	}
}
