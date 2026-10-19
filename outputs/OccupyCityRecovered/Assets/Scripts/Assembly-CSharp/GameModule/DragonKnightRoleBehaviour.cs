using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using DataModule;
using Il2CppDummyDll;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x2000327")]
	public class DragonKnightRoleBehaviour : TerranBehaviour
	{
		[Token(Token = "0x2000329")]
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass4_0
		{
			[Token(Token = "0x40023AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public DragonKnightRoleBehaviour _003C_003E4__this;

			[Token(Token = "0x40023AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Quaternion qu;

			[Token(Token = "0x40023AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public TweenCallback _003C_003E9__2;

			[Token(Token = "0x6000E4F")]
			[Address(RVA = "0x3D6E3A8", Offset = "0x3D6A3A8", VA = "0x3D6E3A8")]
			public _003C_003Ec__DisplayClass4_0()
			{
			}

			[Token(Token = "0x6000E50")]
			[Address(RVA = "0x3D6E3B0", Offset = "0x3D6A3B0", VA = "0x3D6E3B0")]
			internal void _003CDragonKnightSkill_003Eb__1()
			{
			}

			[Token(Token = "0x6000E51")]
			[Address(RVA = "0x3D6E4D8", Offset = "0x3D6A4D8", VA = "0x3D6E4D8")]
			internal void _003CDragonKnightSkill_003Eb__2()
			{
			}

			[Token(Token = "0x6000E52")]
			[Address(RVA = "0x3D6E580", Offset = "0x3D6A580", VA = "0x3D6E580")]
			internal void _003CDragonKnightSkill_003Eb__3()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200032A")]
		[CompilerGenerated]
		private struct _003CAtkCallBack_003Ed__5 : IAsyncStateMachine
		{
			[Token(Token = "0x40023AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40023AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40023AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public DragonKnightRoleBehaviour _003C_003E4__this;

			[Token(Token = "0x40023B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int attackNum;

			[Token(Token = "0x40023B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000E53")]
			[Address(RVA = "0x3D6E5D0", Offset = "0x3D6A5D0", VA = "0x3D6E5D0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000E54")]
			[Address(RVA = "0x3D6EDD0", Offset = "0x3D6ADD0", VA = "0x3D6EDD0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200032B")]
		[CompilerGenerated]
		private struct _003CDragonKnightSkill_003Ed__4 : IAsyncStateMachine
		{
			[Token(Token = "0x40023B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40023B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40023B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public DragonKnightRoleBehaviour _003C_003E4__this;

			[Token(Token = "0x40023B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private _003C_003Ec__DisplayClass4_0 _003C_003E8__1;

			[Token(Token = "0x40023B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000E55")]
			[Address(RVA = "0x3D6EDDC", Offset = "0x3D6ADDC", VA = "0x3D6EDDC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000E56")]
			[Address(RVA = "0x3D6F738", Offset = "0x3D6B738", VA = "0x3D6F738", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200032C")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__2 : IAsyncStateMachine
		{
			[Token(Token = "0x40023B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40023B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40023B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public DragonKnightRoleBehaviour _003C_003E4__this;

			[Token(Token = "0x40023BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public GlobalRoleInfo info;

			[Token(Token = "0x40023BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool isEnemy;

			[Token(Token = "0x40023BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public int cardLevel;

			[Token(Token = "0x40023BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public RareLevel rareLevel;

			[Token(Token = "0x40023BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public string relativeCardID;

			[Token(Token = "0x40023BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public CardFettersType fettersType;

			[Token(Token = "0x40023C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public AtkWayType atkWayType;

			[Token(Token = "0x40023C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000E57")]
			[Address(RVA = "0x3D6F744", Offset = "0x3D6B744", VA = "0x3D6F744", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000E58")]
			[Address(RVA = "0x3D6FA5C", Offset = "0x3D6BA5C", VA = "0x3D6FA5C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40023A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
		private GameObject bulletProRes;

		[Token(Token = "0x40023A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
		private Vector3 beginPos;

		[Token(Token = "0x6000E44")]
		[Address(RVA = "0x3D6E0EC", Offset = "0x3D6A0EC", VA = "0x3D6E0EC", Slot = "20")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__2))]
		public override void Init(GlobalRoleInfo info, bool isEnemy, int cardLevel, RareLevel rareLevel, [Optional] string relativeCardID, CardFettersType fettersType = CardFettersType.Null, AtkWayType atkWayType = AtkWayType.Null)
		{
		}

		[Token(Token = "0x6000E45")]
		[Address(RVA = "0x3D6E1D0", Offset = "0x3D6A1D0", VA = "0x3D6E1D0", Slot = "31")]
		protected override void EmitSkill()
		{
		}

		[Token(Token = "0x6000E46")]
		[Address(RVA = "0x3D6E1EC", Offset = "0x3D6A1EC", VA = "0x3D6E1EC")]
		[AsyncStateMachine(typeof(_003CDragonKnightSkill_003Ed__4))]
		private void DragonKnightSkill()
		{
		}

		[Token(Token = "0x6000E47")]
		[Address(RVA = "0x3D6E27C", Offset = "0x3D6A27C", VA = "0x3D6E27C", Slot = "30")]
		[AsyncStateMachine(typeof(_003CAtkCallBack_003Ed__5))]
		protected override void AtkCallBack(int attackNum)
		{
		}

		[Token(Token = "0x6000E48")]
		[Address(RVA = "0x3D6E31C", Offset = "0x3D6A31C", VA = "0x3D6E31C")]
		public DragonKnightRoleBehaviour()
		{
		}
	}
}
