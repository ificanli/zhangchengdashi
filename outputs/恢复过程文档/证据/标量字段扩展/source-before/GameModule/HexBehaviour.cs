using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using Il2CppDummyDll;
using Pathfinding;
using QuickTutor;
using TMPro;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x2000295")]
	public class HexBehaviour : MonoBehaviour, ITutorialClick
	{
		[Token(Token = "0x2000298")]
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass132_0
		{
			[Token(Token = "0x40020D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public HexBehaviour _003C_003E4__this;

			[Token(Token = "0x40020D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GameObject _rolePrefabRes;

			[Token(Token = "0x40020D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public List<Vector3> allPos;

			[Token(Token = "0x40020D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public GlobalRoleInfo _roleInfo;

			[Token(Token = "0x40020D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int CardLevel;

			[Token(Token = "0x40020D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string path2;

			[Token(Token = "0x6000BB6")]
			[Address(RVA = "0x442BEFC", Offset = "0x4427EFC", VA = "0x442BEFC")]
			public _003C_003Ec__DisplayClass132_0()
			{
			}

			[Token(Token = "0x6000BB7")]
			[Address(RVA = "0x442BF04", Offset = "0x4427F04", VA = "0x442BF04")]
			internal bool _003CCreatSoldierPile_003Eb__0(GlobalRoleInfo x)
			{
				return default;
			}
		}

		[Token(Token = "0x2000299")]
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass132_1
		{
			[Token(Token = "0x40020D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int index;

			[Token(Token = "0x40020D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public _003C_003Ec__DisplayClass132_0 CS_0024_003C_003E8__locals1;

			[Token(Token = "0x6000BB8")]
			[Address(RVA = "0x442BF34", Offset = "0x4427F34", VA = "0x442BF34")]
			public _003C_003Ec__DisplayClass132_1()
			{
			}

			[Token(Token = "0x6000BB9")]
			[Address(RVA = "0x442BF3C", Offset = "0x4427F3C", VA = "0x442BF3C")]
			internal void _003CCreatSoldierPile_003Eb__1()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200029A")]
		[CompilerGenerated]
		private struct _003CArchitectureDeadCallBack_003Ed__133 : IAsyncStateMachine
		{
			[Token(Token = "0x40020D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40020D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40020DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public HexBehaviour _003C_003E4__this;

			[Token(Token = "0x40020DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000BBA")]
			[Address(RVA = "0x442C34C", Offset = "0x442834C", VA = "0x442C34C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000BBB")]
			[Address(RVA = "0x442D1F4", Offset = "0x44291F4", VA = "0x442D1F4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200029B")]
		[CompilerGenerated]
		private struct _003CCreatMainTower_003Ed__120 : IAsyncStateMachine
		{
			[Token(Token = "0x40020DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40020DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40020DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public HexBehaviour _003C_003E4__this;

			[Token(Token = "0x40020DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000BBC")]
			[Address(RVA = "0x442D200", Offset = "0x4429200", VA = "0x442D200", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000BBD")]
			[Address(RVA = "0x442E0B8", Offset = "0x442A0B8", VA = "0x442E0B8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200029C")]
		[CompilerGenerated]
		private struct _003CCreatShowUIObj_003Ed__137 : IAsyncStateMachine
		{
			[Token(Token = "0x40020E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40020E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40020E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public HexBehaviour _003C_003E4__this;

			[Token(Token = "0x40020E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000BBE")]
			[Address(RVA = "0x442E0C4", Offset = "0x442A0C4", VA = "0x442E0C4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000BBF")]
			[Address(RVA = "0x442E3AC", Offset = "0x442A3AC", VA = "0x442E3AC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200029D")]
		[CompilerGenerated]
		private struct _003CCreatShowUIObjInternalAsync_003Ed__138 : IAsyncStateMachine
		{
			[Token(Token = "0x40020E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40020E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40020E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public HexBehaviour _003C_003E4__this;

			[Token(Token = "0x40020E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000BC0")]
			[Address(RVA = "0x442E3B8", Offset = "0x442A3B8", VA = "0x442E3B8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000BC1")]
			[Address(RVA = "0x442F270", Offset = "0x442B270", VA = "0x442F270", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200029E")]
		[CompilerGenerated]
		private struct _003CCreatSoldierPile_003Ed__132 : IAsyncStateMachine
		{
			[Token(Token = "0x40020E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40020E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40020EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public HexBehaviour _003C_003E4__this;

			[Token(Token = "0x40020EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private _003C_003Ec__DisplayClass132_0 _003C_003E8__1;

			[Token(Token = "0x40020EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private _003C_003Ec__DisplayClass132_1 _003C_003E8__2;

			[Token(Token = "0x40020ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private int _003Cnum_003E5__2;

			[Token(Token = "0x40020EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private string _003Cpath_003E5__3;

			[Token(Token = "0x40020EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private GameObject _003CeffectRes_003E5__4;

			[Token(Token = "0x40020F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x40020F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private int _003Ci_003E5__5;

			[Token(Token = "0x40020F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__2;

			[Token(Token = "0x6000BC2")]
			[Address(RVA = "0x442F27C", Offset = "0x442B27C", VA = "0x442F27C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000BC3")]
			[Address(RVA = "0x44300E4", Offset = "0x442C0E4", VA = "0x44300E4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200029F")]
		[CompilerGenerated]
		private struct _003CCreatUIObj_003Ed__135 : IAsyncStateMachine
		{
			[Token(Token = "0x40020F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40020F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40020F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public HexBehaviour _003C_003E4__this;

			[Token(Token = "0x40020F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000BC4")]
			[Address(RVA = "0x44300F0", Offset = "0x442C0F0", VA = "0x44300F0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000BC5")]
			[Address(RVA = "0x44303D8", Offset = "0x442C3D8", VA = "0x44303D8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002A0")]
		[CompilerGenerated]
		private struct _003CCreatUIObjInternalAsync_003Ed__136 : IAsyncStateMachine
		{
			[Token(Token = "0x40020F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40020F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40020F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public HexBehaviour _003C_003E4__this;

			[Token(Token = "0x40020FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000BC6")]
			[Address(RVA = "0x44303E4", Offset = "0x442C3E4", VA = "0x44303E4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000BC7")]
			[Address(RVA = "0x4430F40", Offset = "0x442CF40", VA = "0x4430F40", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002A1")]
		[CompilerGenerated]
		private struct _003CEncroachmentEnemy_003Ed__169 : IAsyncStateMachine
		{
			[Token(Token = "0x40020FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40020FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40020FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public HexBehaviour _003C_003E4__this;

			[Token(Token = "0x40020FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000BC8")]
			[Address(RVA = "0x4430F4C", Offset = "0x442CF4C", VA = "0x4430F4C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000BC9")]
			[Address(RVA = "0x4432144", Offset = "0x442E144", VA = "0x4432144", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002A2")]
		[CompilerGenerated]
		private struct _003CEncroachmentPlayer_003Ed__173 : IAsyncStateMachine
		{
			[Token(Token = "0x40020FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002100")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002101")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public HexBehaviour _003C_003E4__this;

			[Token(Token = "0x4002102")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000BCA")]
			[Address(RVA = "0x4432150", Offset = "0x442E150", VA = "0x4432150", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000BCB")]
			[Address(RVA = "0x443302C", Offset = "0x442F02C", VA = "0x443302C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002A3")]
		[CompilerGenerated]
		private struct _003CFlushDirtyHexUIAsync_003Ed__126 : IAsyncStateMachine
		{
			[Token(Token = "0x4002103")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002104")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002105")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000BCC")]
			[Address(RVA = "0x4433038", Offset = "0x442F038", VA = "0x4433038", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000BCD")]
			[Address(RVA = "0x4433924", Offset = "0x442F924", VA = "0x4433924", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002A4")]
		[CompilerGenerated]
		private struct _003CHandleOnComplete_003Ed__131 : IAsyncStateMachine
		{
			[Token(Token = "0x4002106")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002107")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002108")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public HexBehaviour _003C_003E4__this;

			[Token(Token = "0x4002109")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x400210A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__2;

			[Token(Token = "0x6000BCE")]
			[Address(RVA = "0x4433930", Offset = "0x442F930", VA = "0x4433930", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000BCF")]
			[Address(RVA = "0x44353F0", Offset = "0x44313F0", VA = "0x44353F0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002A5")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__89 : IAsyncStateMachine
		{
			[Token(Token = "0x400210B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400210C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400210D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public HexBehaviour _003C_003E4__this;

			[Token(Token = "0x400210E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string key;

			[Token(Token = "0x400210F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool isEnemyHex;

			[Token(Token = "0x4002110")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Quality _quality;

			[Token(Token = "0x4002111")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public bool setOneStar;

			[Token(Token = "0x4002112")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
			public bool setSoldier;

			[Token(Token = "0x4002113")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x42")]
			public bool setUnchart;

			[Token(Token = "0x4002114")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x43")]
			public bool isNoGoldCard;

			[Token(Token = "0x4002115")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public bool setDefense;

			[Token(Token = "0x4002116")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x45")]
			public bool setGoldMine;

			[Token(Token = "0x4002117")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x46")]
			private bool _003CapplySubGameQuestionMark_003E5__2;

			[Token(Token = "0x4002118")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000BD0")]
			[Address(RVA = "0x44353FC", Offset = "0x44313FC", VA = "0x44353FC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000BD1")]
			[Address(RVA = "0x44371E8", Offset = "0x44331E8", VA = "0x44371E8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002A6")]
		[CompilerGenerated]
		private struct _003CInitFixed_003Ed__90 : IAsyncStateMachine
		{
			[Token(Token = "0x4002119")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400211A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400211B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public HexBehaviour _003C_003E4__this;

			[Token(Token = "0x400211C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string key;

			[Token(Token = "0x400211D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool isEnemyHex;

			[Token(Token = "0x400211E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Quality _quality;

			[Token(Token = "0x400211F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public HexType hexType;

			[Token(Token = "0x4002120")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public string endTriggerEventId;

			[Token(Token = "0x4002121")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public string fixedCardId;

			[Token(Token = "0x4002122")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000BD2")]
			[Address(RVA = "0x44371F4", Offset = "0x44331F4", VA = "0x44371F4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000BD3")]
			[Address(RVA = "0x44389F0", Offset = "0x44349F0", VA = "0x44389F0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002A7")]
		[CompilerGenerated]
		private struct _003CLegendaryTileV1ApplyUiSequenceAsync_003Ed__86 : IAsyncStateMachine
		{
			[Token(Token = "0x4002123")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002124")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002125")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public HexBehaviour _003C_003E4__this;

			[Token(Token = "0x4002126")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x4002127")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__2;

			[Token(Token = "0x6000BD4")]
			[Address(RVA = "0x44389FC", Offset = "0x44349FC", VA = "0x44389FC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000BD5")]
			[Address(RVA = "0x44391A8", Offset = "0x44351A8", VA = "0x44391A8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002A8")]
		[CompilerGenerated]
		private struct _003CLoadArchitectureRes_003Ed__99 : IAsyncStateMachine
		{
			[Token(Token = "0x4002128")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002129")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400212A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public HexBehaviour _003C_003E4__this;

			[Token(Token = "0x400212B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private string _003CplayerPath_003E5__2;

			[Token(Token = "0x400212C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000BD6")]
			[Address(RVA = "0x44391B4", Offset = "0x44351B4", VA = "0x44391B4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000BD7")]
			[Address(RVA = "0x4439DE4", Offset = "0x4435DE4", VA = "0x4439DE4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002A9")]
		[CompilerGenerated]
		private struct _003CLoadShowIconRes_003Ed__101 : IAsyncStateMachine
		{
			[Token(Token = "0x400212D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400212E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400212F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public HexBehaviour _003C_003E4__this;

			[Token(Token = "0x4002130")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000BD8")]
			[Address(RVA = "0x4439DF0", Offset = "0x4435DF0", VA = "0x4439DF0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000BD9")]
			[Address(RVA = "0x443A8AC", Offset = "0x44368AC", VA = "0x443A8AC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002AA")]
		[CompilerGenerated]
		private struct _003CSetSpecialHex_003Ed__96 : IAsyncStateMachine
		{
			[Token(Token = "0x4002131")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002132")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002133")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public HexBehaviour _003C_003E4__this;

			[Token(Token = "0x4002134")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string key;

			[Token(Token = "0x4002135")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool isEnemy;

			[Token(Token = "0x4002136")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public SpecialHexType type;

			[Token(Token = "0x4002137")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private CouncilBoxType _003CboxType_003E5__2;

			[Token(Token = "0x4002138")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000BDA")]
			[Address(RVA = "0x443A8B8", Offset = "0x44368B8", VA = "0x443A8B8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000BDB")]
			[Address(RVA = "0x443C3D4", Offset = "0x44383D4", VA = "0x443C3D4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002AB")]
		[CompilerGenerated]
		private struct _003CSetToEnemy_003Ed__141 : IAsyncStateMachine
		{
			[Token(Token = "0x4002139")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400213A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400213B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public HexBehaviour _003C_003E4__this;

			[Token(Token = "0x400213C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000BDC")]
			[Address(RVA = "0x443C3E0", Offset = "0x44383E0", VA = "0x443C3E0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000BDD")]
			[Address(RVA = "0x443C858", Offset = "0x4438858", VA = "0x443C858", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002AC")]
		[CompilerGenerated]
		private struct _003CSetToPlayer_003Ed__142 : IAsyncStateMachine
		{
			[Token(Token = "0x400213D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400213E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400213F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public HexBehaviour _003C_003E4__this;

			[Token(Token = "0x4002140")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000BDE")]
			[Address(RVA = "0x443C864", Offset = "0x4438864", VA = "0x443C864", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000BDF")]
			[Address(RVA = "0x443CCDC", Offset = "0x4438CDC", VA = "0x443CCDC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002AD")]
		[CompilerGenerated]
		private struct _003CSpecialHexLogic_003Ed__140 : IAsyncStateMachine
		{
			[Token(Token = "0x4002141")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002142")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002143")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public HexBehaviour _003C_003E4__this;

			[Token(Token = "0x4002144")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000BE0")]
			[Address(RVA = "0x443CCE8", Offset = "0x4438CE8", VA = "0x443CCE8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000BE1")]
			[Address(RVA = "0x443E4CC", Offset = "0x443A4CC", VA = "0x443E4CC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002AE")]
		[CompilerGenerated]
		private struct _003CTryApplyLegendaryTileHexGoldSurface_003Ed__87 : IAsyncStateMachine
		{
			[Token(Token = "0x4002145")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002146")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002147")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public HexBehaviour _003C_003E4__this;

			[Token(Token = "0x4002148")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000BE2")]
			[Address(RVA = "0x443E4D8", Offset = "0x443A4D8", VA = "0x443E4D8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000BE3")]
			[Address(RVA = "0x443EAA4", Offset = "0x443AAA4", VA = "0x443EAA4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002AF")]
		[CompilerGenerated]
		private struct _003CUpdateHexItemUI_003Ed__146 : IAsyncStateMachine
		{
			[Token(Token = "0x4002149")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400214A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400214B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public HexBehaviour _003C_003E4__this;

			[Token(Token = "0x6000BE4")]
			[Address(RVA = "0x443EAB0", Offset = "0x443AAB0", VA = "0x443EAB0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000BE5")]
			[Address(RVA = "0x443F41C", Offset = "0x443B41C", VA = "0x443F41C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002B0")]
		[CompilerGenerated]
		private struct _003CUpdateHexState_003Ed__143 : IAsyncStateMachine
		{
			[Token(Token = "0x400214C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400214D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400214E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public HexBehaviour _003C_003E4__this;

			[Token(Token = "0x400214F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public HexBehaviour neighbor;

			[Token(Token = "0x4002150")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000BE6")]
			[Address(RVA = "0x443F428", Offset = "0x443B428", VA = "0x443F428", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000BE7")]
			[Address(RVA = "0x443F980", Offset = "0x443B980", VA = "0x443F980", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[NonSerialized]
		[Token(Token = "0x400207A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HexManager.HexCoord HexCoord;

		[Token(Token = "0x400207B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int coordQ;

		[Token(Token = "0x400207C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int coordR;

		[Token(Token = "0x400207D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private HashSet<int> _characterIds;

		[Token(Token = "0x400207E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly HashSet<HexBehaviour> DirtyCoinColorHexes;

		[Token(Token = "0x400207F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly HashSet<HexBehaviour> DirtyHexItemUIHexes;

		[Token(Token = "0x4002080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly List<HexBehaviour> DirtyCoinColorBuffer;

		[Token(Token = "0x4002081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly List<HexBehaviour> DirtyHexItemUIBuffer;

		[Token(Token = "0x4002082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static bool _dirtyHexUIFlushScheduled;

		[Token(Token = "0x4002083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private static int _dirtyCoinNum;

		[Token(Token = "0x4002085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string key;

		[Token(Token = "0x4002086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public HexManager.HexCoord hexCoord;

		[Token(Token = "0x4002087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool canOpen;

		[Token(Token = "0x4002088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool trainingLocked;

		[Token(Token = "0x4002089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public string trainingEndTriggerEventId;

		[Token(Token = "0x400208A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool LegendaryTileGuaranteed;

		[Token(Token = "0x400208B")]
		private const string LegendaryLandHexGlobalInfoId = "1005";

		[Token(Token = "0x400208C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool _isInitFixed;

		[Token(Token = "0x400208D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public HexBehaviour leftUpHexBehaviour;

		[Token(Token = "0x400208E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public HexBehaviour rightUpHexBehaviour;

		[Token(Token = "0x400208F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public HexBehaviour upHexBehaviour;

		[Token(Token = "0x4002090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public HexBehaviour downHexBehaviour;

		[Token(Token = "0x4002091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public HexBehaviour leftDownHexBehaviour;

		[Token(Token = "0x4002092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public HexBehaviour rightDownHexBehaviour;

		[Token(Token = "0x4002093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Quality quality;

		[Token(Token = "0x4002094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public int price;

		[Token(Token = "0x4002095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public bool isEnemyHex;

		[Token(Token = "0x4002096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		public bool isOpened;

		[Token(Token = "0x4002097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private GameObject _obj;

		[Token(Token = "0x4002098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private GlobalArchitectureInfo _info;

		[Token(Token = "0x4002099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private GameObject _res;

		[Token(Token = "0x400209A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private GameObject _enemyRes;

		[Token(Token = "0x400209B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private GameObject _playerRes;

		[Token(Token = "0x400209C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private string _id;

		[Token(Token = "0x400209D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public bool shouldHasWall;

		[Token(Token = "0x400209E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD9")]
		public bool hasArchitecture;

		[Token(Token = "0x400209F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private GameObject _uiRes;

		[Token(Token = "0x40020A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private GameObject _showIconUIRes;

		[Token(Token = "0x40020A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private GameObject _uiObj;

		[Token(Token = "0x40020A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private GameObject _showIconUIObj;

		[Token(Token = "0x40020A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private GameObject _legendaryGridEffectObj;

		[Token(Token = "0x40020A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private GameObject _enemyHexUIRes;

		[Token(Token = "0x40020A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private GameObject _enemyHexUIObj;

		[Token(Token = "0x40020A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private GameObject _stoneWallRes;

		[Token(Token = "0x40020A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private GameObject _mainTowerRes;

		[Token(Token = "0x40020A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public GameObject leftUpWall;

		[Token(Token = "0x40020A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public GameObject rightUpWall;

		[Token(Token = "0x40020AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public GameObject upWall;

		[Token(Token = "0x40020AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public GameObject leftDownWall;

		[Token(Token = "0x40020AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public GameObject rightDownWall;

		[Token(Token = "0x40020AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public GameObject downWall;

		[Token(Token = "0x40020AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private StoneWallBehaviour leftUpWallBe;

		[Token(Token = "0x40020AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private StoneWallBehaviour rightUpWallBe;

		[Token(Token = "0x40020B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private StoneWallBehaviour upWallBe;

		[Token(Token = "0x40020B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private StoneWallBehaviour leftDownWallBe;

		[Token(Token = "0x40020B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private StoneWallBehaviour rightDownWallBe;

		[Token(Token = "0x40020B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private StoneWallBehaviour downWallBe;

		[Token(Token = "0x40020B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		public bool isDestroy;

		[Token(Token = "0x40020B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		public TextMeshPro tmpUI;

		[Token(Token = "0x40020B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private GraphUpdateScene _graphUpdateScene;

		[Token(Token = "0x40020B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		public RareLevel rareLevel;

		[Token(Token = "0x40020B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
		public bool isBridge;

		[Token(Token = "0x40020B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A5")]
		private bool _isDoOpenHexAni;

		[Token(Token = "0x40020BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		public HexType hexBuildType;

		[Token(Token = "0x40020BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
		public HexType hexUIType;

		[Token(Token = "0x40020BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private SpecialHexType _specialHexType;

		[Token(Token = "0x40020BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
		public bool isSpecialHex;

		[Token(Token = "0x40020BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private Vector3[] graphPoints;

		[Token(Token = "0x40020BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private GameObject resBoxObj;

		[Token(Token = "0x40020C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private GameObject[] soilderObj;

		[Token(Token = "0x40020C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private bool UserLablePlayerResetEd;

		[Token(Token = "0x40020C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D1")]
		private bool UserLableEnemyResetEd;

		[Token(Token = "0x40020C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D2")]
		private bool leftUpWallIsDead;

		[Token(Token = "0x40020C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D3")]
		private bool upWallIsDead;

		[Token(Token = "0x40020C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
		private bool rightUpWallIsDead;

		[Token(Token = "0x40020C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D5")]
		private bool leftDownWallIsDead;

		[Token(Token = "0x40020C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D6")]
		private bool downWallIsDead;

		[Token(Token = "0x40020C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D7")]
		private bool rightDownWallIsDead;

		[Token(Token = "0x40020C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private readonly List<RoleBehaviour> _roleEnemyList;

		[Token(Token = "0x40020CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private readonly List<RoleBehaviour> _rolePlayerList;

		[Token(Token = "0x170000D2")]
		public int Priority
		{
			[Token(Token = "0x6000B44")]
			[Address(RVA = "0x4420A90", Offset = "0x441CA90", VA = "0x4420A90")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x6000B45")]
			[Address(RVA = "0x4420A98", Offset = "0x441CA98", VA = "0x4420A98")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000D3")]
		public string ArchitectureInfoId
		{
			[Token(Token = "0x6000B47")]
			[Address(RVA = "0x4420AB0", Offset = "0x441CAB0", VA = "0x4420AB0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D4")]
		public GameObject UIObj
		{
			[Token(Token = "0x6000B48")]
			[Address(RVA = "0x4420AC8", Offset = "0x441CAC8", VA = "0x4420AC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D5")]
		private bool IsNullHex
		{
			[Token(Token = "0x6000B8B")]
			[Address(RVA = "0x442761C", Offset = "0x442361C", VA = "0x442761C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000B46")]
		[Address(RVA = "0x4420AA0", Offset = "0x441CAA0", VA = "0x4420AA0")]
		public void InitializeHexCoord(HexManager.HexCoord coord)
		{
		}

		[Token(Token = "0x6000B49")]
		[Address(RVA = "0x4420AD0", Offset = "0x441CAD0", VA = "0x4420AD0")]
		private bool ShouldSkipGraphUpdateScene()
		{
			return default;
		}

		[Token(Token = "0x6000B4A")]
		[Address(RVA = "0x4420AD8", Offset = "0x441CAD8", VA = "0x4420AD8")]
		private void CacheGraphUpdateScene()
		{
		}

		[Token(Token = "0x6000B4B")]
		[Address(RVA = "0x4420BC4", Offset = "0x441CBC4", VA = "0x4420BC4")]
		private void InitGraphUpdateScene()
		{
		}

		[Token(Token = "0x6000B4C")]
		[Address(RVA = "0x4420C88", Offset = "0x441CC88", VA = "0x4420C88")]
		private void Start()
		{
		}

		[Token(Token = "0x6000B4D")]
		[Address(RVA = "0x442108C", Offset = "0x441D08C", VA = "0x442108C")]
		public void SetBridge(bool isBridge = false)
		{
		}

		[Token(Token = "0x6000B4E")]
		[Address(RVA = "0x4421098", Offset = "0x441D098", VA = "0x4421098")]
		private GlobalHexInfo GetLandPriceHexGlobalInfo()
		{
			return null;
		}

		[Token(Token = "0x6000B4F")]
		[Address(RVA = "0x4421294", Offset = "0x441D294", VA = "0x4421294")]
		private int GetLandPriceInt(GlobalHexInfo landCfg)
		{
			return default;
		}

		[Token(Token = "0x6000B50")]
		[Address(RVA = "0x4421310", Offset = "0x441D310", VA = "0x4421310")]
		public void ApplyLegendaryTileV1()
		{
		}

		[Token(Token = "0x6000B51")]
		[Address(RVA = "0x44216D4", Offset = "0x441D6D4", VA = "0x44216D4")]
		private void RefreshLegendaryTileCardForCurrentCamp()
		{
		}

		[Token(Token = "0x6000B52")]
		[Address(RVA = "0x442165C", Offset = "0x441D65C", VA = "0x442165C")]
		[AsyncStateMachine(typeof(_003CLegendaryTileV1ApplyUiSequenceAsync_003Ed__86))]
		private UniTaskVoid LegendaryTileV1ApplyUiSequenceAsync()
		{
			return default;
		}

		[Token(Token = "0x6000B53")]
		[Address(RVA = "0x4421928", Offset = "0x441D928", VA = "0x4421928")]
		[AsyncStateMachine(typeof(_003CTryApplyLegendaryTileHexGoldSurface_003Ed__87))]
		private void TryApplyLegendaryTileHexGoldSurface()
		{
		}

		[Token(Token = "0x6000B54")]
		[Address(RVA = "0x44219B8", Offset = "0x441D9B8", VA = "0x44219B8")]
		private void SyncLegendaryGridEffectWithPriceUi()
		{
		}

		[Token(Token = "0x6000B55")]
		[Address(RVA = "0x4415734", Offset = "0x4411734", VA = "0x4415734")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__89))]
		public void Init(string key, bool isEnemyHex, Quality _quality, bool setGoldMine = false, bool isNoGoldCard = false, bool setOneStar = false, bool setUnchart = false, bool setDefense = false, bool setSoldier = false)
		{
		}

		[Token(Token = "0x6000B56")]
		[Address(RVA = "0x4415CF4", Offset = "0x4411CF4", VA = "0x4415CF4")]
		[AsyncStateMachine(typeof(_003CInitFixed_003Ed__90))]
		public void InitFixed(string key, bool isEnemyHex, Quality _quality, HexType hexType, string fixedCardId, [Optional] string endTriggerEventId)
		{
		}

		[Token(Token = "0x6000B57")]
		[Address(RVA = "0x4421B14", Offset = "0x441DB14", VA = "0x4421B14")]
		private void ApplySubGameQuestionMarkInitState()
		{
		}

		[Token(Token = "0x6000B58")]
		[Address(RVA = "0x4422670", Offset = "0x441E670", VA = "0x4422670")]
		private void SetHexSoldierPile(bool SetOneStar, bool SetSoldier)
		{
		}

		[Token(Token = "0x6000B59")]
		[Address(RVA = "0x44214D8", Offset = "0x441D4D8", VA = "0x44214D8")]
		private void RecordHexType()
		{
		}

		[Token(Token = "0x6000B5A")]
		[Address(RVA = "0x441567C", Offset = "0x441167C", VA = "0x441567C")]
		[AsyncStateMachine(typeof(_003CSetSpecialHex_003Ed__96))]
		public void SetSpecialHex(string key, bool isEnemy, SpecialHexType type)
		{
		}

		[Token(Token = "0x6000B5B")]
		[Address(RVA = "0x4415844", Offset = "0x4411844", VA = "0x4415844")]
		public void ChangeSnowMat()
		{
		}

		[Token(Token = "0x6000B5C")]
		[Address(RVA = "0x4421B5C", Offset = "0x441DB5C", VA = "0x4421B5C")]
		private void RandomHexRare(bool isInit, bool UserLablePlayerReset = false, bool UserLableEnemyReset = false)
		{
		}

		[Token(Token = "0x6000B5D")]
		[Address(RVA = "0x4421898", Offset = "0x441D898", VA = "0x4421898")]
		[AsyncStateMachine(typeof(_003CLoadArchitectureRes_003Ed__99))]
		private void LoadArchitectureRes()
		{
		}

		[Token(Token = "0x6000B5E")]
		[Address(RVA = "0x4422004", Offset = "0x441E004", VA = "0x4422004")]
		private void RandomArchitectureInfoAndCardID(bool isInit, [Optional] HexMirrorInfo info)
		{
		}

		[Token(Token = "0x6000B5F")]
		[Address(RVA = "0x4422908", Offset = "0x441E908", VA = "0x4422908")]
		[AsyncStateMachine(typeof(_003CLoadShowIconRes_003Ed__101))]
		private void LoadShowIconRes()
		{
		}

		[Token(Token = "0x6000B60")]
		[Address(RVA = "0x4422998", Offset = "0x441E998", VA = "0x4422998")]
		private void LableTestPlayerRefeshHex(object o)
		{
		}

		[Token(Token = "0x6000B61")]
		[Address(RVA = "0x4423050", Offset = "0x441F050", VA = "0x4423050")]
		private void LableSystemEnemyRefreshHex(object o)
		{
		}

		[Token(Token = "0x6000B62")]
		[Address(RVA = "0x44233B4", Offset = "0x441F3B4", VA = "0x44233B4")]
		public bool Wound(int num, string id, bool isBuild, Transform target, AtkWayType atkWayType)
		{
			return default;
		}

		[Token(Token = "0x6000B63")]
		[Address(RVA = "0x4424050", Offset = "0x4420050", VA = "0x4424050")]
		private void UpdateAllWallState(object o)
		{
		}

		[Token(Token = "0x6000B64")]
		[Address(RVA = "0x4423624", Offset = "0x441F624", VA = "0x4423624")]
		private StoneWallBehaviour GetTargetWallNearPos(Vector3 target)
		{
			return null;
		}

		[Token(Token = "0x6000B65")]
		[Address(RVA = "0x4424420", Offset = "0x4420420", VA = "0x4424420")]
		private void CheckGraphUpdateScene(object o)
		{
		}

		[Token(Token = "0x6000B66")]
		[Address(RVA = "0x44244FC", Offset = "0x44204FC", VA = "0x44244FC")]
		private void CheckCanOpen(object o)
		{
		}

		[Token(Token = "0x6000B67")]
		[Address(RVA = "0x4424614", Offset = "0x4420614", VA = "0x4424614")]
		private void HexOpen()
		{
		}

		[Token(Token = "0x6000B68")]
		[Address(RVA = "0x442462C", Offset = "0x442062C", VA = "0x442462C")]
		public void RefreshTrainingLock()
		{
		}

		[Token(Token = "0x6000B69")]
		[Address(RVA = "0x4424568", Offset = "0x4420568", VA = "0x4424568")]
		private bool IsTrainingHexLocked()
		{
			return default;
		}

		[Token(Token = "0x6000B6A")]
		[Address(RVA = "0x44246D0", Offset = "0x44206D0", VA = "0x44246D0")]
		[AsyncStateMachine(typeof(_003CCreatMainTower_003Ed__120))]
		private void CreatMainTower(object o)
		{
		}

		[Token(Token = "0x6000B6B")]
		[Address(RVA = "0x4424760", Offset = "0x4420760", VA = "0x4424760")]
		private void UpdateCoinColorEvent(object o)
		{
		}

		[Token(Token = "0x6000B6C")]
		[Address(RVA = "0x4424898", Offset = "0x4420898", VA = "0x4424898")]
		private void UpdateHexItemUIEvent(object o)
		{
		}

		[Token(Token = "0x6000B6D")]
		[Address(RVA = "0x4424804", Offset = "0x4420804", VA = "0x4424804")]
		private void MarkCoinColorDirty(int coinNum)
		{
		}

		[Token(Token = "0x6000B6E")]
		[Address(RVA = "0x44248DC", Offset = "0x44208DC", VA = "0x44248DC")]
		private void MarkHexItemUIDirty()
		{
		}

		[Token(Token = "0x6000B6F")]
		[Address(RVA = "0x4424960", Offset = "0x4420960", VA = "0x4424960")]
		private static void ScheduleDirtyHexUIFlush()
		{
		}

		[Token(Token = "0x6000B70")]
		[Address(RVA = "0x44249EC", Offset = "0x44209EC", VA = "0x44249EC")]
		[AsyncStateMachine(typeof(_003CFlushDirtyHexUIAsync_003Ed__126))]
		private static UniTaskVoid FlushDirtyHexUIAsync()
		{
			return default;
		}

		[Token(Token = "0x6000B71")]
		[Address(RVA = "0x4424A58", Offset = "0x4420A58", VA = "0x4424A58")]
		private void RemoveFromDirtyHexUIBatches()
		{
		}

		[Token(Token = "0x6000B72")]
		[Address(RVA = "0x4424AF4", Offset = "0x4420AF4", VA = "0x4424AF4")]
		public void UpdateCoinColor(int coinNum)
		{
		}

		[Token(Token = "0x6000B73")]
		[Address(RVA = "0x4424C0C", Offset = "0x4420C0C", VA = "0x4424C0C")]
		public void TextDoAni()
		{
		}

		[Token(Token = "0x6000B74")]
		[Address(RVA = "0x4424D5C", Offset = "0x4420D5C", VA = "0x4424D5C")]
		public void OpenHex(bool isEnemy, bool isHard = false)
		{
		}

		[Token(Token = "0x6000B75")]
		[Address(RVA = "0x4425210", Offset = "0x4421210", VA = "0x4425210")]
		[AsyncStateMachine(typeof(_003CHandleOnComplete_003Ed__131))]
		private void HandleOnComplete()
		{
		}

		[Token(Token = "0x6000B76")]
		[Address(RVA = "0x44252A0", Offset = "0x44212A0", VA = "0x44252A0")]
		[AsyncStateMachine(typeof(_003CCreatSoldierPile_003Ed__132))]
		private void CreatSoldierPile()
		{
		}

		[Token(Token = "0x6000B77")]
		[Address(RVA = "0x4425338", Offset = "0x4421338", VA = "0x4425338")]
		[AsyncStateMachine(typeof(_003CArchitectureDeadCallBack_003Ed__133))]
		private void ArchitectureDeadCallBack()
		{
		}

		[Token(Token = "0x6000B78")]
		[Address(RVA = "0x44253C8", Offset = "0x44213C8", VA = "0x44253C8")]
		public void UIHide()
		{
		}

		[Token(Token = "0x6000B79")]
		[Address(RVA = "0x4422CA8", Offset = "0x441ECA8", VA = "0x4422CA8")]
		[AsyncStateMachine(typeof(_003CCreatUIObj_003Ed__135))]
		private void CreatUIObj()
		{
		}

		[Token(Token = "0x6000B7A")]
		[Address(RVA = "0x4425614", Offset = "0x4421614", VA = "0x4425614")]
		[AsyncStateMachine(typeof(_003CCreatUIObjInternalAsync_003Ed__136))]
		private UniTask CreatUIObjInternalAsync()
		{
			return default;
		}

		[Token(Token = "0x6000B7B")]
		[Address(RVA = "0x4422D34", Offset = "0x441ED34", VA = "0x4422D34")]
		[AsyncStateMachine(typeof(_003CCreatShowUIObj_003Ed__137))]
		private void CreatShowUIObj()
		{
		}

		[Token(Token = "0x6000B7C")]
		[Address(RVA = "0x44256B0", Offset = "0x44216B0", VA = "0x44256B0")]
		[AsyncStateMachine(typeof(_003CCreatShowUIObjInternalAsync_003Ed__138))]
		private UniTask CreatShowUIObjInternalAsync()
		{
			return default;
		}

		[Token(Token = "0x6000B7D")]
		[Address(RVA = "0x442574C", Offset = "0x442174C", VA = "0x442574C")]
		private void BeGetSpecialHex(object o)
		{
		}

		[Token(Token = "0x6000B7E")]
		[Address(RVA = "0x4425A18", Offset = "0x4421A18", VA = "0x4425A18")]
		[AsyncStateMachine(typeof(_003CSpecialHexLogic_003Ed__140))]
		private void SpecialHexLogic()
		{
		}

		[Token(Token = "0x6000B7F")]
		[Address(RVA = "0x4425AA8", Offset = "0x4421AA8", VA = "0x4425AA8")]
		[ContextMenu("SetToEnemy")]
		[AsyncStateMachine(typeof(_003CSetToEnemy_003Ed__141))]
		private void SetToEnemy()
		{
		}

		[Token(Token = "0x6000B80")]
		[Address(RVA = "0x4425B38", Offset = "0x4421B38", VA = "0x4425B38")]
		[AsyncStateMachine(typeof(_003CSetToPlayer_003Ed__142))]
		[ContextMenu("SetToPlayer")]
		private void SetToPlayer()
		{
		}

		[Token(Token = "0x6000B81")]
		[Address(RVA = "0x442597C", Offset = "0x442197C", VA = "0x442597C")]
		[AsyncStateMachine(typeof(_003CUpdateHexState_003Ed__143))]
		private void UpdateHexState(HexBehaviour neighbor)
		{
		}

		[Token(Token = "0x6000B82")]
		[Address(RVA = "0x4425BC8", Offset = "0x4421BC8", VA = "0x4425BC8")]
		private void UpdateMaterial(bool isEnemy)
		{
		}

		[Token(Token = "0x6000B83")]
		[Address(RVA = "0x4425DB8", Offset = "0x4421DB8", VA = "0x4425DB8")]
		private void UpdateSpecialHexState()
		{
		}

		[Token(Token = "0x6000B84")]
		[Address(RVA = "0x4424644", Offset = "0x4420644", VA = "0x4424644")]
		[AsyncStateMachine(typeof(_003CUpdateHexItemUI_003Ed__146))]
		private void UpdateHexItemUI(object o)
		{
		}

		[Token(Token = "0x6000B85")]
		[Address(RVA = "0x4425DD8", Offset = "0x4421DD8", VA = "0x4425DD8")]
		private void CreatWallJudge(object o)
		{
		}

		[Token(Token = "0x6000B86")]
		[Address(RVA = "0x4426924", Offset = "0x4422924", VA = "0x4426924")]
		private void DestroyWall(GameObject wall, bool isReally = false)
		{
		}

		[Token(Token = "0x6000B87")]
		[Address(RVA = "0x4426AA4", Offset = "0x4422AA4", VA = "0x4426AA4")]
		private void CreatWall(ref GameObject wall, WallType wallType)
		{
		}

		[Token(Token = "0x6000B88")]
		[Address(RVA = "0x4424294", Offset = "0x4420294", VA = "0x4424294")]
		private Vector3 CalcWallPos(WallType type)
		{
			return default;
		}

		[Token(Token = "0x6000B89")]
		[Address(RVA = "0x44269E4", Offset = "0x44229E4", VA = "0x44269E4")]
		private bool NullHexDesWallJudge(HexBehaviour hex)
		{
			return default;
		}

		[Token(Token = "0x6000B8A")]
		[Address(RVA = "0x44274BC", Offset = "0x44234BC", VA = "0x44274BC")]
		private bool NoNullHexCreatWallJudge(HexBehaviour hex)
		{
			return default;
		}

		[Token(Token = "0x6000B8C")]
		[Address(RVA = "0x442763C", Offset = "0x442363C", VA = "0x442763C")]
		private void HexOpenAndHexDestroyCheckNullHexShouldCreatWall(object o)
		{
		}

		[Token(Token = "0x6000B8D")]
		[Address(RVA = "0x44268A8", Offset = "0x44228A8", VA = "0x44268A8")]
		private bool CheckNullHexShouldCreatWall()
		{
			return default;
		}

		[Token(Token = "0x6000B8E")]
		[Address(RVA = "0x442767C", Offset = "0x442367C", VA = "0x442767C")]
		private bool RecursiveCheck(HexBehaviour hexagon, List<HexBehaviour> hexs)
		{
			return default;
		}

		[Token(Token = "0x6000B8F")]
		[Address(RVA = "0x4427C50", Offset = "0x4423C50", VA = "0x4427C50")]
		public bool HasActiveWallInDirection(int neighborOffset)
		{
			return default;
		}

		[Token(Token = "0x6000B90")]
		[Address(RVA = "0x4427E28", Offset = "0x4423E28", VA = "0x4427E28")]
		public bool GetActiveWallIsEnemyInDirection(int neighborOffset)
		{
			return default;
		}

		[Token(Token = "0x6000B91")]
		[Address(RVA = "0x4422DC0", Offset = "0x441EDC0", VA = "0x4422DC0")]
		public bool NearHasOpen()
		{
			return default;
		}

		[Token(Token = "0x6000B92")]
		[Address(RVA = "0x4427128", Offset = "0x4423128", VA = "0x4427128")]
		private bool NearHasArchitecture()
		{
			return default;
		}

		[Token(Token = "0x6000B93")]
		[Address(RVA = "0x4427A4C", Offset = "0x4423A4C", VA = "0x4427A4C")]
		private bool NearHasHasArchitectureReally()
		{
			return default;
		}

		[Token(Token = "0x6000B94")]
		[Address(RVA = "0x4427F00", Offset = "0x4423F00", VA = "0x4427F00")]
		public bool IsCombo()
		{
			return default;
		}

		[Token(Token = "0x6000B95")]
		[Address(RVA = "0x4428134", Offset = "0x4424134", VA = "0x4428134")]
		public int GetRoleCountByCamp(bool isEnemyRole)
		{
			return default;
		}

		[Token(Token = "0x6000B96")]
		[Address(RVA = "0x442818C", Offset = "0x442418C", VA = "0x442818C")]
		public RoleBehaviour GetRoleByCamp(bool isEnemyRole, int index)
		{
			return null;
		}

		[Token(Token = "0x6000B97")]
		[Address(RVA = "0x4428230", Offset = "0x4424230", VA = "0x4428230")]
		public void MyUpdate()
		{
		}

		[Token(Token = "0x6000B98")]
		[Address(RVA = "0x4428468", Offset = "0x4424468", VA = "0x4428468")]
		[AsyncStateMachine(typeof(_003CEncroachmentEnemy_003Ed__169))]
		private void EncroachmentEnemy()
		{
		}

		[Token(Token = "0x6000B99")]
		[Address(RVA = "0x44284F8", Offset = "0x44244F8", VA = "0x44284F8")]
		private void SetLayerRecursively(Transform objTransform, string layerName)
		{
		}

		[Token(Token = "0x6000B9A")]
		[Address(RVA = "0x442887C", Offset = "0x442487C", VA = "0x442887C")]
		private void ChangeWallLayer(bool toEnemyWall)
		{
		}

		[Token(Token = "0x6000B9B")]
		[Address(RVA = "0x4428B30", Offset = "0x4424B30", VA = "0x4428B30")]
		private void ChangeWallIsEnemy(bool isEnemy)
		{
		}

		[Token(Token = "0x6000B9C")]
		[Address(RVA = "0x4428CD0", Offset = "0x4424CD0", VA = "0x4428CD0")]
		[AsyncStateMachine(typeof(_003CEncroachmentPlayer_003Ed__173))]
		private void EncroachmentPlayer()
		{
		}

		[Token(Token = "0x6000B9D")]
		[Address(RVA = "0x4428D60", Offset = "0x4424D60", VA = "0x4428D60")]
		private int GetInflationBasePrice()
		{
			return default;
		}

		[Token(Token = "0x6000B9E")]
		[Address(RVA = "0x4428EDC", Offset = "0x4424EDC", VA = "0x4428EDC")]
		public void RefreshSubGameInflationPrice()
		{
		}

		[Token(Token = "0x6000B9F")]
		[Address(RVA = "0x4428FD4", Offset = "0x4424FD4", VA = "0x4428FD4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000BA0")]
		[Address(RVA = "0x44298EC", Offset = "0x44258EC", VA = "0x44298EC")]
		private void DetermineHexCamp()
		{
		}

		[Token(Token = "0x6000BA1")]
		[Address(RVA = "0x44299B0", Offset = "0x44259B0", VA = "0x44299B0")]
		public void AddRole(int instanceId, bool player, RoleBehaviour roleBehaviour)
		{
		}

		[Token(Token = "0x6000BA2")]
		[Address(RVA = "0x4429AE8", Offset = "0x4425AE8", VA = "0x4429AE8")]
		public void RemoveRole(int instanceId, bool player, RoleBehaviour roleBehaviour)
		{
		}

		[Token(Token = "0x6000BA3")]
		[Address(RVA = "0x4429B8C", Offset = "0x4425B8C", VA = "0x4429B8C")]
		public void RefreshRoleCamp(int instanceId, bool player, RoleBehaviour roleBehaviour)
		{
		}

		[Token(Token = "0x6000BA4")]
		[Address(RVA = "0x4429D00", Offset = "0x4425D00", VA = "0x4429D00")]
		public HexBehaviour[] GetNeighborsArray()
		{
			return null;
		}

		[Token(Token = "0x6000BA5")]
		[Address(RVA = "0x4429E70", Offset = "0x4425E70", VA = "0x4429E70")]
		public void HideRole()
		{
		}

		[Token(Token = "0x6000BA6")]
		[Address(RVA = "0x4429EE4", Offset = "0x4425EE4", VA = "0x4429EE4")]
		public void RefreshSubGamePriceDisplay()
		{
		}

		[Token(Token = "0x6000BA7")]
		[Address(RVA = "0x4429F84", Offset = "0x4425F84", VA = "0x4429F84", Slot = "4")]
		public void OnTutorialClick()
		{
		}

		[Token(Token = "0x6000BA8")]
		[Address(RVA = "0x4429F90", Offset = "0x4425F90", VA = "0x4429F90")]
		public HexBehaviour()
		{
		}
	}
}
