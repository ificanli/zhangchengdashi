using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using ToolModule;
using UnityEngine;
using UnityEngine.Serialization;

namespace GameModule
{
	[Token(Token = "0x2000424")]
	public class BattleGameSceneManager : ManagerBase<BattleGameSceneManager>
	{
		[Token(Token = "0x2000425")]
		private struct RoleTargetFrameCacheKey : IEquatable<RoleTargetFrameCacheKey>
		{
			[Token(Token = "0x400298B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool sourceIsEnemy;

			[Token(Token = "0x400298C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int q;

			[Token(Token = "0x400298D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int r;

			[Token(Token = "0x400298E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public int rangeBucket;

			[Token(Token = "0x6001459")]
			[Address(RVA = "0x3DF9650", Offset = "0x3DF5650", VA = "0x3DF9650")]
			public RoleTargetFrameCacheKey(bool sourceIsEnemy, int q, int r, int rangeBucket)
			{
			}

			[Token(Token = "0x600145A")]
			[Address(RVA = "0x3DF9664", Offset = "0x3DF5664", VA = "0x3DF9664", Slot = "4")]
			public bool Equals(RoleTargetFrameCacheKey other)
			{
				return default;
			}

			[Token(Token = "0x600145B")]
			[Address(RVA = "0x3DF96AC", Offset = "0x3DF56AC", VA = "0x3DF96AC", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default;
			}

			[Token(Token = "0x600145C")]
			[Address(RVA = "0x3DF9758", Offset = "0x3DF5758", VA = "0x3DF9758", Slot = "2")]
			public override int GetHashCode()
			{
				return default;
			}
		}

		[Token(Token = "0x2000426")]
		private struct RoleTargetFrameCacheValue
		{
			[Token(Token = "0x400298F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public RoleBehaviour target;
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200042C")]
		[CompilerGenerated]
		private struct _003CEndGame_003Ed__223 : IAsyncStateMachine
		{
			[Token(Token = "0x40029A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40029A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40029A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public BattleGameSceneManager _003C_003E4__this;

			[Token(Token = "0x40029A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6001464")]
			[Address(RVA = "0x3DF9AB4", Offset = "0x3DF5AB4", VA = "0x3DF9AB4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001465")]
			[Address(RVA = "0x3DFA894", Offset = "0x3DF6894", VA = "0x3DFA894", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200042D")]
		[CompilerGenerated]
		private struct _003CGetRoleTarget_003Ed__175 : IAsyncStateMachine
		{
			[Token(Token = "0x40029A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40029A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<List<RoleBehaviour>> _003C_003Et__builder;

			[Token(Token = "0x40029A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform transform;

			[Token(Token = "0x40029A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool isEnemy;

			[Token(Token = "0x40029A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public BattleGameSceneManager _003C_003E4__this;

			[Token(Token = "0x40029AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public int roleNum;

			[Token(Token = "0x40029AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float range;

			[Token(Token = "0x40029AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6001466")]
			[Address(RVA = "0x3DFA8A0", Offset = "0x3DF68A0", VA = "0x3DFA8A0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001467")]
			[Address(RVA = "0x3DFB26C", Offset = "0x3DF726C", VA = "0x3DFB26C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200042E")]
		[CompilerGenerated]
		private struct _003CGetRoleTarget_003Ed__207 : IAsyncStateMachine
		{
			[Token(Token = "0x40029AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40029AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<List<GameObject>> _003C_003Et__builder;

			[Token(Token = "0x6001468")]
			[Address(RVA = "0x3DFB2C4", Offset = "0x3DF72C4", VA = "0x3DFB2C4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001469")]
			[Address(RVA = "0x3DFB4E8", Offset = "0x3DF74E8", VA = "0x3DFB4E8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200042F")]
		[CompilerGenerated]
		private struct _003CHideAllRole_003Ed__214 : IAsyncStateMachine
		{
			[Token(Token = "0x40029AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40029B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40029B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public BattleGameSceneManager _003C_003E4__this;

			[Token(Token = "0x40029B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int _003Cindex_003E5__2;

			[Token(Token = "0x40029B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600146A")]
			[Address(RVA = "0x3DFB540", Offset = "0x3DF7540", VA = "0x3DFB540", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600146B")]
			[Address(RVA = "0x3DFC2B8", Offset = "0x3DF82B8", VA = "0x3DFC2B8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000430")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__129 : IAsyncStateMachine
		{
			[Token(Token = "0x40029B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40029B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40029B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BattleGameSceneManager _003C_003E4__this;

			[Token(Token = "0x40029B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600146C")]
			[Address(RVA = "0x3DFC2C4", Offset = "0x3DF82C4", VA = "0x3DFC2C4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600146D")]
			[Address(RVA = "0x3DFCE0C", Offset = "0x3DF8E0C", VA = "0x3DFCE0C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000431")]
		[CompilerGenerated]
		private struct _003CLoadMapGround_003Ed__147 : IAsyncStateMachine
		{
			[Token(Token = "0x40029B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40029B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40029BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BattleGameSceneManager _003C_003E4__this;

			[Token(Token = "0x40029BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GameType gameType;

			[Token(Token = "0x40029BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600146E")]
			[Address(RVA = "0x3DFCE18", Offset = "0x3DF8E18", VA = "0x3DFCE18", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600146F")]
			[Address(RVA = "0x3DFD304", Offset = "0x3DF9304", VA = "0x3DFD304", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000432")]
		[CompilerGenerated]
		private struct _003CPrewarmBattleRuntimePools_003Ed__143 : IAsyncStateMachine
		{
			[Token(Token = "0x40029BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40029BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x6001470")]
			[Address(RVA = "0x3DFD310", Offset = "0x3DF9310", VA = "0x3DFD310", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001471")]
			[Address(RVA = "0x3DFD320", Offset = "0x3DF9320", VA = "0x3DFD320", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000433")]
		[CompilerGenerated]
		private struct _003CSettlementAnimation_003Ed__217 : IAsyncStateMachine
		{
			[Token(Token = "0x40029BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40029C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40029C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public BattleGameSceneManager _003C_003E4__this;

			[Token(Token = "0x40029C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool isVictory;

			[Token(Token = "0x40029C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private int _003CbeginIndex_003E5__2;

			[Token(Token = "0x40029C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6001472")]
			[Address(RVA = "0x3DFD32C", Offset = "0x3DF932C", VA = "0x3DFD32C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001473")]
			[Address(RVA = "0x3DFE480", Offset = "0x3DFA480", VA = "0x3DFE480", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000434")]
		[CompilerGenerated]
		private struct _003CStartGame_003Ed__142 : IAsyncStateMachine
		{
			[Token(Token = "0x40029C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40029C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40029C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public BattleGameSceneManager _003C_003E4__this;

			[Token(Token = "0x40029C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public GameType gameType;

			[Token(Token = "0x6001474")]
			[Address(RVA = "0x3DFE48C", Offset = "0x3DFA48C", VA = "0x3DFE48C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001475")]
			[Address(RVA = "0x3DFE8BC", Offset = "0x3DFA8BC", VA = "0x3DFE8BC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000435")]
		[CompilerGenerated]
		private struct _003CUpdateAllList_003Ed__155 : IAsyncStateMachine
		{
			[Token(Token = "0x40029C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40029CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40029CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BattleGameSceneManager _003C_003E4__this;

			[Token(Token = "0x40029CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6001476")]
			[Address(RVA = "0x3DFE8C8", Offset = "0x3DFA8C8", VA = "0x3DFE8C8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001477")]
			[Address(RVA = "0x3DFEDC8", Offset = "0x3DFADC8", VA = "0x3DFEDC8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000436")]
		[CompilerGenerated]
		private struct _003CUpdateArchitecture_003Ed__159 : IAsyncStateMachine
		{
			[Token(Token = "0x40029CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40029CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40029CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BattleGameSceneManager _003C_003E4__this;

			[Token(Token = "0x40029D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int _003CprocessedCount_003E5__2;

			[Token(Token = "0x40029D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private int _003Ci_003E5__3;

			[Token(Token = "0x40029D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6001478")]
			[Address(RVA = "0x3DFEDD4", Offset = "0x3DFADD4", VA = "0x3DFEDD4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001479")]
			[Address(RVA = "0x3DFF1FC", Offset = "0x3DFB1FC", VA = "0x3DFF1FC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000437")]
		[CompilerGenerated]
		private struct _003CUpdateEnemyRole_003Ed__156 : IAsyncStateMachine
		{
			[Token(Token = "0x40029D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40029D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40029D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BattleGameSceneManager _003C_003E4__this;

			[Token(Token = "0x40029D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int _003CprocessedCount_003E5__2;

			[Token(Token = "0x40029D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private int _003Ci_003E5__3;

			[Token(Token = "0x40029D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600147A")]
			[Address(RVA = "0x3DFF208", Offset = "0x3DFB208", VA = "0x3DFF208", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600147B")]
			[Address(RVA = "0x3DFF630", Offset = "0x3DFB630", VA = "0x3DFF630", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000438")]
		[CompilerGenerated]
		private struct _003CUpdateHexObj_003Ed__158 : IAsyncStateMachine
		{
			[Token(Token = "0x40029D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40029DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40029DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BattleGameSceneManager _003C_003E4__this;

			[Token(Token = "0x40029DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int _003CprocessedCount_003E5__2;

			[Token(Token = "0x40029DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private int _003Ci_003E5__3;

			[Token(Token = "0x40029DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600147C")]
			[Address(RVA = "0x3DFF63C", Offset = "0x3DFB63C", VA = "0x3DFF63C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600147D")]
			[Address(RVA = "0x3DFFA60", Offset = "0x3DFBA60", VA = "0x3DFFA60", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000439")]
		[CompilerGenerated]
		private struct _003CUpdatePlayerRole_003Ed__157 : IAsyncStateMachine
		{
			[Token(Token = "0x40029DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40029E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40029E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BattleGameSceneManager _003C_003E4__this;

			[Token(Token = "0x40029E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int _003CprocessedCount_003E5__2;

			[Token(Token = "0x40029E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private int _003Ci_003E5__3;

			[Token(Token = "0x40029E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600147E")]
			[Address(RVA = "0x3DFFA6C", Offset = "0x3DFBA6C", VA = "0x3DFFA6C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600147F")]
			[Address(RVA = "0x3DFFE94", Offset = "0x3DFBE94", VA = "0x3DFFE94", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4002929")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int _currentRoleInstanceID;

		[Token(Token = "0x400292A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GameObject _generateHexObjRoot;

		[Token(Token = "0x400292B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private GenerateHexBehaviour _generateHexBehaviour;

		[Token(Token = "0x400292C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly Vector3[] _spawnHexVertices;

		[Token(Token = "0x400292D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float _spawnHexVertexSize;

		[Token(Token = "0x400292E")]
		private const int RoleTargetHexSearchPadding = 2;

		[Token(Token = "0x400292F")]
		private const int RoleTargetMaxHexSearchRing = 10;

		[Token(Token = "0x4002930")]
		private const float RoleTargetMinHexStep = 0.5f;

		[Token(Token = "0x4002931")]
		private const float RoleTargetRangeCachePrecision = 100f;

		[Token(Token = "0x4002932")]
		private const int BattleBulletPrewarmCount = 10;

		[Token(Token = "0x4002933")]
		private const int BattleResourceProductPrewarmCount = 80;

		[Token(Token = "0x4002934")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private GameObject _destroyObjRoot;

		[Token(Token = "0x4002935")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private readonly Dictionary<RoleTargetFrameCacheKey, RoleTargetFrameCacheValue> _roleTargetFrameCache;

		[Token(Token = "0x4002936")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int _roleTargetFrameCacheFrame;

		[Token(Token = "0x4002937")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public List<GameObject> allPlayerStayOpenHexObj;

		[Token(Token = "0x4002938")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public List<GameObject> allEnemyStayOpenHexObj;

		[Token(Token = "0x4002939")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public List<HexBehaviour> allEnemyStayOpenHexObjBehaviours;

		[Token(Token = "0x400293A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public List<GameObject> allHexObj;

		[Token(Token = "0x400293B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public List<HexBehaviour> allHexObjBehaviour;

		[Token(Token = "0x400293C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public List<MeshRenderer> allHexObjMat;

		[Token(Token = "0x400293D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public List<GameObject> allPlayerHasOpenHexObj;

		[Token(Token = "0x400293E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public List<GameObject> allEnemyHasOpenHexObj;

		[Token(Token = "0x400293F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public List<GameObject> allPlayerArchitectureObj;

		[Token(Token = "0x4002940")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public List<GameObject> allEnemyArchitectureObj;

		[Token(Token = "0x4002941")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public List<GameObject> allPlayerRoleObj;

		[Token(Token = "0x4002942")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public List<GameObject> allEnemyRoleObj;

		[Token(Token = "0x4002943")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public List<RoleBehaviour> allEnemyRoleBehaviour;

		[Token(Token = "0x4002944")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public List<RoleBehaviour> allPlayerRoleBehaviour;

		[Token(Token = "0x4002945")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public List<RoleBehaviour> allRoleBehaviour;

		[Token(Token = "0x4002946")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public List<ArchitectureBehaviour> allArchitectureBehaviours;

		[Token(Token = "0x4002947")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public List<ArchitectureBehaviour> allPlayerArchitectureBehaviours;

		[Token(Token = "0x4002948")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public List<ArchitectureBehaviour> allEnemyArchitectureBehaviours;

		[Token(Token = "0x4002949")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private List<HellfireBehaviour> allHellfireBehaviours;

		[Token(Token = "0x400294A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private int _playerComboWallCount;

		[Token(Token = "0x400294B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		private int _enemyComboWallCount;

		[Token(Token = "0x400294C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private GameObject _waterPlane;

		[Token(Token = "0x400294D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private GameObject _groundPlane;

		[Token(Token = "0x400294E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private List<GameObject> needDestroyPoolPrefabOnEndGame;

		[Token(Token = "0x400294F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private GameObject _playerArchitectureRoot;

		[Token(Token = "0x4002950")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private GameObject _enemyArchitectureRoot;

		[Token(Token = "0x4002951")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private GameObject _playerRoleRoot;

		[Token(Token = "0x4002952")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private GameObject _enemyRoleRoot;

		[Token(Token = "0x4002953")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private GameObject _specialHexRoot;

		[Token(Token = "0x4002954")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private WebGLNavigationManager _webGLNavigationManager;

		[Token(Token = "0x4002955")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public Vector3 playerMainTowerPos;

		[Token(Token = "0x4002956")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		public string enemyMainTowerKey;

		[Token(Token = "0x4002957")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		public string playerMainTowerKey;

		[Token(Token = "0x4002958")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		public bool playerMainTowerIsDestroy;

		[Token(Token = "0x4002959")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x169")]
		public bool enemyMainTowerIsDestroy;

		[Token(Token = "0x400295A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		public string polygonMapId;

		[Token(Token = "0x400295B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private List<Vector3> specialHexPos;

		[Token(Token = "0x400295C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private readonly Dictionary<Tuple<int, int>, HexMirrorInfo> _mirrorMap;

		[Token(Token = "0x400295D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private readonly int ScaleFactor;

		[Token(Token = "0x400295E")]
		private const string EnableLegendaryTileOnlineParamKey = "EnableLegendaryTile";

		[Token(Token = "0x400295F")]
		private const string LegendaryLandHexGlobalInfoId = "1005";

		[Token(Token = "0x4002960")]
		private const int LegendaryTileV1DefaultPrice = 350;

		[Token(Token = "0x4002963")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private int nowMapMaxZ;

		[Token(Token = "0x4002964")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
		private int rotateNum;

		[Token(Token = "0x4002965")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private int sizeNum;

		[Token(Token = "0x4002966")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
		public int sceneGoldMineCanCreatCount;

		[Token(Token = "0x4002967")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		public int sceneGoldMineMirrorSideCount;

		[Token(Token = "0x4002968")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
		public int scenePLayerUseGoldMineCount;

		[Token(Token = "0x4002969")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		public int sceneEnemyUseGoldMineCount;

		[Token(Token = "0x400296A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
		public int playerRoleDebutCount;

		[Token(Token = "0x400296B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		[FormerlySerializedAs("playerOntStarRoleDebutCount")]
		[FormerlySerializedAs("playerOneStarRoleDebutCount")]
		public int playerOpenOneStarCount;

		[Token(Token = "0x400296C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
		[FormerlySerializedAs("playerTwoStarRoleDebutCount")]
		public int playerOpenTwoStarCount;

		[Token(Token = "0x400296D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		[FormerlySerializedAs("playerThereStarRoleDebutCount")]
		public int playerOpenThereStarCount;

		[Token(Token = "0x400296E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
		[FormerlySerializedAs("playerUnChartRoleDebutCount")]
		public int playerOpenUnChartCount;

		[Token(Token = "0x400296F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		public int playerOpenHexCount;

		[Token(Token = "0x4002970")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
		public MapType mapType;

		[Token(Token = "0x4002971")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		public bool isSeasonPVP_BTest;

		[Token(Token = "0x4002972")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		public GameObject seasonBTestDecorationObj;

		[Token(Token = "0x4002973")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		public int playerCanGetWoodNum;

		[Token(Token = "0x4002974")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1EC")]
		public int enemyCanGetWoodNum;

		[Token(Token = "0x4002975")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private GameObject _skillIndicator;

		[Token(Token = "0x4002976")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private SpriteRenderer _skillIndicatorRenderer;

		[Token(Token = "0x4002977")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Color SkillIndicatorValidColor;

		[Token(Token = "0x4002978")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly Color SkillIndicatorInvalidColor;

		[Token(Token = "0x4002979")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private int _playerRoleCount;

		[Token(Token = "0x400297A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
		private int _enemyRoleCount;

		[Token(Token = "0x400297B")]
		private const int MAX_ROLE_COUNT = 100;

		[Token(Token = "0x400297C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private int _playerReservedCount;

		[Token(Token = "0x400297D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
		private int _enemyReservedCount;

		[Token(Token = "0x400297E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private List<BarracksArchitectureBehaviour> _playerWaitingBarracks;

		[Token(Token = "0x400297F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private List<BarracksArchitectureBehaviour> _enemyWaitingBarracks;

		[Token(Token = "0x4002980")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private Dictionary<string, int> _playerLegendaryUnitCount;

		[Token(Token = "0x4002981")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private Dictionary<string, int> _enemyLegendaryUnitCount;

		[Token(Token = "0x4002982")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		private Dictionary<string, int> _playerLegendaryBarracksCount;

		[Token(Token = "0x4002983")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		private Dictionary<string, int> _enemyLegendaryBarracksCount;

		[Token(Token = "0x4002984")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		private float currentUpdateInterTime;

		[Token(Token = "0x4002985")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x244")]
		private float updateInterTime;

		[Token(Token = "0x4002986")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		private bool upgradeing;

		[Token(Token = "0x4002987")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24C")]
		private float currentUpdateInterTime_FindAllRoleNearestEnemy;

		[Token(Token = "0x4002988")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		private float updateInterTime_FindAllRoleNearesdEnemy;

		[Token(Token = "0x4002989")]
		private const int BATCH_SIZE = 50;

		[Token(Token = "0x400298A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		private DynamicTargetFinder dynamicTargetFinder;

		[Token(Token = "0x1700012F")]
		public bool IsNoneTutorGame
		{
			[Token(Token = "0x60013B8")]
			[Address(RVA = "0x3DEC72C", Offset = "0x3DE872C", VA = "0x3DEC72C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000130")]
		public HexBehaviour LegendaryTileV1LastPlayerHalfHex
		{
			[Token(Token = "0x60013BD")]
			[Address(RVA = "0x3DECBE8", Offset = "0x3DE8BE8", VA = "0x3DECBE8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60013BE")]
			[Address(RVA = "0x3DECBF0", Offset = "0x3DE8BF0", VA = "0x3DECBF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000131")]
		public HexBehaviour LegendaryTileV1LastEnemyHalfHex
		{
			[Token(Token = "0x60013BF")]
			[Address(RVA = "0x3DECBF8", Offset = "0x3DE8BF8", VA = "0x3DECBF8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60013C0")]
			[Address(RVA = "0x3DECC00", Offset = "0x3DE8C00", VA = "0x3DECC00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000132")]
		public int PlayerHasHex
		{
			[Token(Token = "0x60013C6")]
			[Address(RVA = "0x3DEA55C", Offset = "0x3DE655C", VA = "0x3DEA55C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000133")]
		public int EnemyHasHex
		{
			[Token(Token = "0x60013C7")]
			[Address(RVA = "0x3DEA5B4", Offset = "0x3DE65B4", VA = "0x3DEA5B4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000134")]
		public int PlayerRoleCount
		{
			[Token(Token = "0x60013C8")]
			[Address(RVA = "0x3DED8DC", Offset = "0x3DE98DC", VA = "0x3DED8DC")]
			get
			{
				return _playerRoleCount;
			}
		}

		[Token(Token = "0x17000135")]
		public int EnemyRoleCount
		{
			[Token(Token = "0x60013C9")]
			[Address(RVA = "0x3DED8E4", Offset = "0x3DE98E4", VA = "0x3DED8E4")]
			get
			{
				return _enemyRoleCount;
			}
		}

		[Token(Token = "0x17000136")]
		public int MaxRoleCount
		{
			[Token(Token = "0x60013CA")]
			[Address(RVA = "0x3DED8EC", Offset = "0x3DE98EC", VA = "0x3DED8EC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000137")]
		public int AllHexCount
		{
			[Token(Token = "0x60013D2")]
			[Address(RVA = "0x3DEDC0C", Offset = "0x3DE9C0C", VA = "0x3DEDC0C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60013B9")]
		[Address(RVA = "0x3DEC808", Offset = "0x3DE8808", VA = "0x3DEC808")]
		public static bool IsLegendaryTileV1EnabledThisBattle()
		{
			return default;
		}

		[Token(Token = "0x60013BA")]
		[Address(RVA = "0x3DECA5C", Offset = "0x3DE8A5C", VA = "0x3DECA5C")]
		public static int GetLegendaryTileV1Price()
		{
			return default;
		}

		[Token(Token = "0x60013BB")]
		[Address(RVA = "0x3DEC874", Offset = "0x3DE8874", VA = "0x3DEC874")]
		private static bool TryParseLegendaryTileV1OnlineParam(out bool isEnabled, out int onlinePrice)
		{
			return default;
		}

		[Token(Token = "0x60013BC")]
		[Address(RVA = "0x3DECAE8", Offset = "0x3DE8AE8", VA = "0x3DECAE8")]
		private static int GetLegendaryTileV1ConfigPriceFallback()
		{
			return default;
		}

		[Token(Token = "0x60013C1")]
		[Address(RVA = "0x3DECC08", Offset = "0x3DE8C08", VA = "0x3DECC08")]
		public void FinalizeLegendaryTiles()
		{
		}

		[Token(Token = "0x60013C2")]
		[Address(RVA = "0x3DED460", Offset = "0x3DE9460", VA = "0x3DED460")]
		private static bool LegendaryTileV1QualityTierOk(Quality q, int tierMin)
		{
			return default;
		}

		[Token(Token = "0x60013C3")]
		[Address(RVA = "0x3DED4AC", Offset = "0x3DE94AC", VA = "0x3DED4AC")]
		private static bool LegendaryTileV1HexPassesBaseFilters(HexBehaviour hex)
		{
			return default;
		}

		[Token(Token = "0x60013C4")]
		[Address(RVA = "0x3DED544", Offset = "0x3DE9544", VA = "0x3DED544")]
		private List<HexBehaviour> LegendaryTileV1BuildPool(bool enemyHalf, HexManager.HexCoord mainCoord, int minHexSteps, int qualityTierMin)
		{
			return null;
		}

		[Token(Token = "0x60013C5")]
		[Address(RVA = "0x3DECE6C", Offset = "0x3DE8E6C", VA = "0x3DECE6C")]
		private HexBehaviour LegendaryTileV1PickOneHalf(bool enemyHalf, HexManager.HexCoord mainCoord)
		{
			return null;
		}

		[Token(Token = "0x60013CB")]
		[Address(RVA = "0x3DED8F4", Offset = "0x3DE98F4", VA = "0x3DED8F4")]
		public bool CanSpawnRole(bool isEnemy)
		{
			return default;
		}

		[Token(Token = "0x60013CC")]
		[Address(RVA = "0x3DED9AC", Offset = "0x3DE99AC", VA = "0x3DED9AC")]
		public int GetAvailableSlots(bool isEnemy)
		{
			return default;
		}

		[Token(Token = "0x60013CD")]
		[Address(RVA = "0x3DEDA74", Offset = "0x3DE9A74", VA = "0x3DEDA74")]
		public void ReserveRoleSlot(bool isEnemy)
		{
		}

		[Token(Token = "0x60013CE")]
		[Address(RVA = "0x3DEDA80", Offset = "0x3DE9A80", VA = "0x3DEDA80")]
		public void ReserveRoleSlot(bool isEnemy, int count)
		{
		}

		[Token(Token = "0x60013CF")]
		[Address(RVA = "0x3DEDB30", Offset = "0x3DE9B30", VA = "0x3DEDB30")]
		public void ReleaseReservedSlot(bool isEnemy)
		{
		}

		[Token(Token = "0x60013D0")]
		[Address(RVA = "0x3DEDB3C", Offset = "0x3DE9B3C", VA = "0x3DEDB3C")]
		public void ReleaseReservedSlot(bool isEnemy, int count)
		{
		}

		[Token(Token = "0x60013D1")]
		[Address(RVA = "0x3DEDBF4", Offset = "0x3DE9BF4", VA = "0x3DEDBF4")]
		private int GetRareLevelValue(RareLevel rareLevel)
		{
			return default;
		}

		[Token(Token = "0x60013D3")]
		[Address(RVA = "0x3DEDC54", Offset = "0x3DE9C54", VA = "0x3DEDC54", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__129))]
		public override UniTask Init()
		{
			return default;
		}

		[Token(Token = "0x60013D4")]
		[Address(RVA = "0x3DEDCF0", Offset = "0x3DE9CF0", VA = "0x3DEDCF0")]
		private static bool ShouldUseWebGLNavigation()
		{
			return default;
		}

		[Token(Token = "0x60013D5")]
		[Address(RVA = "0x3DEDCF8", Offset = "0x3DE9CF8", VA = "0x3DEDCF8")]
		private void EnsureWebGLNavigationManager()
		{
		}

		[Token(Token = "0x60013D6")]
		[Address(RVA = "0x3DEDE50", Offset = "0x3DE9E50", VA = "0x3DEDE50")]
		private void ShutdownWebGLNavigationManager()
		{
		}

		[Token(Token = "0x60013D7")]
		[Address(RVA = "0x3DEDED4", Offset = "0x3DE9ED4", VA = "0x3DEDED4")]
		private void TickWebGLNavigation(float deltaTime)
		{
		}

		[Token(Token = "0x60013D8")]
		[Address(RVA = "0x3DEDF64", Offset = "0x3DE9F64", VA = "0x3DEDF64")]
		private void MarkWebGLNavigationDirty()
		{
		}

		[Token(Token = "0x60013D9")]
		[Address(RVA = "0x3DEDF68", Offset = "0x3DE9F68", VA = "0x3DEDF68")]
		private void MarkWebGLNavigationGraphDirty()
		{
		}

		[Token(Token = "0x60013DA")]
		[Address(RVA = "0x3DEDFE4", Offset = "0x3DE9FE4", VA = "0x3DEDFE4")]
		private void MarkWebGLNavigationAllFieldsDirty()
		{
		}

		[Token(Token = "0x60013DB")]
		[Address(RVA = "0x3DEE060", Offset = "0x3DEA060", VA = "0x3DEE060")]
		public void MarkWebGLNavigationTargetFieldDirty(bool targetIsEnemy)
		{
		}

		[Token(Token = "0x60013DC")]
		[Address(RVA = "0x3DEE0F0", Offset = "0x3DEA0F0", VA = "0x3DEE0F0")]
		public void ShowSkillIndicator(Vector3 worldPos, float radius = 3f, bool isValid = true)
		{
		}

		[Token(Token = "0x60013DD")]
		[Address(RVA = "0x3DEE40C", Offset = "0x3DEA40C", VA = "0x3DEE40C")]
		public void UpdateSkillIndicator(Vector3 worldPos, bool isValid = true)
		{
		}

		[Token(Token = "0x60013DE")]
		[Address(RVA = "0x3DEE53C", Offset = "0x3DEA53C", VA = "0x3DEE53C")]
		public void HideSkillIndicator()
		{
		}

		[Token(Token = "0x60013DF")]
		[Address(RVA = "0x3DEE298", Offset = "0x3DEA298", VA = "0x3DEE298")]
		private void ApplySkillIndicatorColor(bool isValid)
		{
		}

		[Token(Token = "0x60013E0")]
		[Address(RVA = "0x3DEE5D0", Offset = "0x3DEA5D0", VA = "0x3DEE5D0")]
		[AsyncStateMachine(typeof(_003CStartGame_003Ed__142))]
		public void StartGame(GameType gameType)
		{
		}

		[Token(Token = "0x60013E1")]
		[Address(RVA = "0x3DEE670", Offset = "0x3DEA670", VA = "0x3DEE670")]
		[AsyncStateMachine(typeof(_003CPrewarmBattleRuntimePools_003Ed__143))]
		private UniTaskVoid PrewarmBattleRuntimePools()
		{
			return default;
		}

		[Token(Token = "0x60013E2")]
		[Address(RVA = "0x3DEE6D8", Offset = "0x3DEA6D8", VA = "0x3DEE6D8")]
		private (Tuple<int, int>, bool) ParseKey(string key)
		{
			return default;
		}

		[Token(Token = "0x60013E3")]
		[Address(RVA = "0x3DEE96C", Offset = "0x3DEA96C", VA = "0x3DEE96C")]
		public HexMirrorInfo GetMirror(string key)
		{
			return null;
		}

		[Token(Token = "0x60013E4")]
		[Address(RVA = "0x3DEE9FC", Offset = "0x3DEA9FC", VA = "0x3DEE9FC")]
		public void AddToRecord(string key, Quality quality, RareLevel rareLevel, HexType hexType)
		{
		}

		[Token(Token = "0x60013E5")]
		[Address(RVA = "0x3DEEB04", Offset = "0x3DEAB04", VA = "0x3DEEB04")]
		[AsyncStateMachine(typeof(_003CLoadMapGround_003Ed__147))]
		public UniTask LoadMapGround(GameType gameType)
		{
			return default;
		}

		[Token(Token = "0x60013E6")]
		[Address(RVA = "0x3DEEBB0", Offset = "0x3DEABB0", VA = "0x3DEEBB0")]
		private void Update()
		{
		}

		[Token(Token = "0x60013E7")]
		[Address(RVA = "0x3DEECA0", Offset = "0x3DEACA0", VA = "0x3DEECA0")]
		[AsyncStateMachine(typeof(_003CUpdateAllList_003Ed__155))]
		private UniTask UpdateAllList()
		{
			return default;
		}

		[Token(Token = "0x60013E8")]
		[Address(RVA = "0x3DEED38", Offset = "0x3DEAD38", VA = "0x3DEED38")]
		[AsyncStateMachine(typeof(_003CUpdateEnemyRole_003Ed__156))]
		private UniTask UpdateEnemyRole()
		{
			return default;
		}

		[Token(Token = "0x60013E9")]
		[Address(RVA = "0x3DEEDD0", Offset = "0x3DEADD0", VA = "0x3DEEDD0")]
		[AsyncStateMachine(typeof(_003CUpdatePlayerRole_003Ed__157))]
		private UniTask UpdatePlayerRole()
		{
			return default;
		}

		[Token(Token = "0x60013EA")]
		[Address(RVA = "0x3DEEE68", Offset = "0x3DEAE68", VA = "0x3DEEE68")]
		[AsyncStateMachine(typeof(_003CUpdateHexObj_003Ed__158))]
		private UniTask UpdateHexObj()
		{
			return default;
		}

		[Token(Token = "0x60013EB")]
		[Address(RVA = "0x3DEEF00", Offset = "0x3DEAF00", VA = "0x3DEEF00")]
		[AsyncStateMachine(typeof(_003CUpdateArchitecture_003Ed__159))]
		private UniTask UpdateArchitecture()
		{
			return default;
		}

		[Token(Token = "0x60013EC")]
		[Address(RVA = "0x3DEEF98", Offset = "0x3DEAF98", VA = "0x3DEEF98")]
		public void GoldMineCountLimitRecordHexCreat()
		{
		}

		[Token(Token = "0x60013ED")]
		[Address(RVA = "0x3DEEFB8", Offset = "0x3DEAFB8", VA = "0x3DEEFB8")]
		public void RecordPlayerUseGoldMine()
		{
		}

		[Token(Token = "0x60013EE")]
		[Address(RVA = "0x3DEEFC8", Offset = "0x3DEAFC8", VA = "0x3DEEFC8")]
		public void RecordEnemyUseGoldMine()
		{
		}

		[Token(Token = "0x60013EF")]
		[Address(RVA = "0x3DEEFD8", Offset = "0x3DEAFD8", VA = "0x3DEEFD8")]
		public int GetGoldMinePrice(bool isEnemyHex)
		{
			return default;
		}

		[Token(Token = "0x60013F0")]
		[Address(RVA = "0x3DEF0EC", Offset = "0x3DEB0EC", VA = "0x3DEF0EC")]
		public void UpdateAllGoldMinePrices()
		{
		}

		[Token(Token = "0x60013F1")]
		[Address(RVA = "0x3DEF330", Offset = "0x3DEB330", VA = "0x3DEF330")]
		public void RecordPlayerOpenHexTypeCount(Quality quality)
		{
		}

		[Token(Token = "0x60013F2")]
		[Address(RVA = "0x3DEF394", Offset = "0x3DEB394", VA = "0x3DEF394")]
		public void RecordPlayerBarrackCreatRoleCount()
		{
		}

		[Token(Token = "0x60013F3")]
		[Address(RVA = "0x3DEF3A4", Offset = "0x3DEB3A4", VA = "0x3DEF3A4")]
		private void CreatBothMainTower(object o)
		{
		}

		[Token(Token = "0x60013F4")]
		[Address(RVA = "0x3DEF4CC", Offset = "0x3DEB4CC", VA = "0x3DEF4CC")]
		private void CheckComboWallCount(object o)
		{
		}

		[Token(Token = "0x60013F5")]
		[Address(RVA = "0x3DEF6D0", Offset = "0x3DEB6D0", VA = "0x3DEF6D0")]
		public void RecordNewMapSizeZ(int num)
		{
		}

		[Token(Token = "0x60013F6")]
		[Address(RVA = "0x3DEF6D8", Offset = "0x3DEB6D8", VA = "0x3DEF6D8")]
		public void RecordCameraAniNum(int rotate, int size)
		{
		}

		[Token(Token = "0x60013F7")]
		[Address(RVA = "0x3DEF6E4", Offset = "0x3DEB6E4", VA = "0x3DEF6E4")]
		public ArchitectureBehaviour GetArchitectureTarget(Vector3 pos, bool isEnemy)
		{
			return null;
		}

		[Token(Token = "0x60013F8")]
		[Address(RVA = "0x3DEF9FC", Offset = "0x3DEB9FC", VA = "0x3DEF9FC")]
		private bool TryGetWebGLArchitectureAtOrNearPosition(Vector3 pos, bool isEnemy, List<GameObject> targetList, out ArchitectureBehaviour architecture)
		{
			return default;
		}

		[Token(Token = "0x60013F9")]
		[Address(RVA = "0x3DEFE08", Offset = "0x3DEBE08", VA = "0x3DEFE08")]
		private static bool TryGetArchitectureOnHex(HexBehaviour hex, bool ownerIsEnemy, List<GameObject> targetList, out ArchitectureBehaviour architecture)
		{
			return default;
		}

		[Token(Token = "0x60013FA")]
		[Address(RVA = "0x3DF0050", Offset = "0x3DEC050", VA = "0x3DF0050")]
		public Transform GetMainTowerNearArchitecture(bool isEnemy)
		{
			return null;
		}

		[Token(Token = "0x60013FB")]
		[Address(RVA = "0x3DF0358", Offset = "0x3DEC358", VA = "0x3DF0358")]
		[AsyncStateMachine(typeof(_003CGetRoleTarget_003Ed__175))]
		public UniTask<List<RoleBehaviour>> GetRoleTarget(Transform transform, bool isEnemy, float range, int roleNum = 1)
		{
			return default;
		}

		[Token(Token = "0x60013FC")]
		[Address(RVA = "0x3DF0470", Offset = "0x3DEC470", VA = "0x3DF0470")]
		public List<RoleBehaviour> GetRoleTargetsSync(Transform transform, bool isEnemy, float range, int roleNum = 1)
		{
			return null;
		}

		[Token(Token = "0x60013FD")]
		[Address(RVA = "0x3DF0C7C", Offset = "0x3DECC7C", VA = "0x3DF0C7C")]
		public RoleBehaviour GetRoleTargetSync(Transform transform, bool isEnemy, float range)
		{
			return null;
		}

		[Token(Token = "0x60013FE")]
		[Address(RVA = "0x3DF0D3C", Offset = "0x3DECD3C", VA = "0x3DF0D3C")]
		public bool TryGetNearestRoleTarget(Transform sourceTransform, bool sourceIsEnemy, float range, out RoleBehaviour target)
		{
			return default;
		}

		[Token(Token = "0x60013FF")]
		[Address(RVA = "0x3DF06BC", Offset = "0x3DEC6BC", VA = "0x3DF06BC")]
		public bool TryGetNearestRoleTarget(Vector3 sourcePos, bool sourceIsEnemy, float range, out RoleBehaviour target)
		{
			return default;
		}

		[Token(Token = "0x6001400")]
		[Address(RVA = "0x3DF1584", Offset = "0x3DED584", VA = "0x3DF1584")]
		public int CollectRoleTargetsInRange(Transform sourceTransform, bool sourceIsEnemy, float range, List<RoleBehaviour> result)
		{
			return default;
		}

		[Token(Token = "0x6001401")]
		[Address(RVA = "0x3DF08A8", Offset = "0x3DEC8A8", VA = "0x3DF08A8")]
		public int CollectRoleTargetsInRange(Vector3 sourcePos, bool sourceIsEnemy, float range, List<RoleBehaviour> result)
		{
			return default;
		}

		[Token(Token = "0x6001402")]
		[Address(RVA = "0x3DF0E0C", Offset = "0x3DECE0C", VA = "0x3DF0E0C")]
		private List<RoleBehaviour> GetRoleTargetList(bool sourceIsEnemy)
		{
			return null;
		}

		[Token(Token = "0x6001403")]
		[Address(RVA = "0x3DF1BB4", Offset = "0x3DEDBB4", VA = "0x3DF1BB4")]
		public bool TryGetMostDenseEnemyRolePosition(bool isEnemy, Vector3 sourcePos, float clusterRadius, float searchRange, out Vector3 denseCenter)
		{
			return default;
		}

		[Token(Token = "0x6001404")]
		[Address(RVA = "0x3DF1F7C", Offset = "0x3DEDF7C", VA = "0x3DF1F7C")]
		public int DamageEnemyEntitiesInRadius(Vector3 center, float radius, bool attackerIsEnemy, int damage, string attackerId, EntityBase attacker, bool isLandRole, AtkWayType atkWayType, CardFettersType fetterType)
		{
			return default;
		}

		[Token(Token = "0x6001405")]
		[Address(RVA = "0x3DF2608", Offset = "0x3DEE608", VA = "0x3DF2608")]
		private void PrepareRoleTargetFrameCache()
		{
		}

		[Token(Token = "0x6001406")]
		[Address(RVA = "0x3DF2680", Offset = "0x3DEE680", VA = "0x3DF2680")]
		private bool TryGetRoleTargetFrameCacheKey(Vector3 sourcePos, bool sourceIsEnemy, float range, out RoleTargetFrameCacheKey key)
		{
			return default;
		}

		[Token(Token = "0x6001407")]
		[Address(RVA = "0x3DF0E24", Offset = "0x3DECE24", VA = "0x3DF0E24")]
		private bool TryGetCachedNearestRoleTarget(Vector3 sourcePos, bool sourceIsEnemy, float range, float sqrRange, out RoleBehaviour target)
		{
			return default;
		}

		[Token(Token = "0x6001408")]
		[Address(RVA = "0x3DF12FC", Offset = "0x3DED2FC", VA = "0x3DF12FC")]
		private void CacheNearestRoleTarget(Vector3 sourcePos, bool sourceIsEnemy, float range, RoleBehaviour target)
		{
		}

		[Token(Token = "0x6001409")]
		[Address(RVA = "0x3DF28DC", Offset = "0x3DEE8DC", VA = "0x3DF28DC")]
		private static bool IsRoleTargetValid(RoleBehaviour role)
		{
			return default;
		}

		[Token(Token = "0x600140A")]
		[Address(RVA = "0x3DF2828", Offset = "0x3DEE828", VA = "0x3DF2828")]
		private bool TryGetRoleTargetHexSearchRing(float range, out int searchRing)
		{
			return default;
		}

		[Token(Token = "0x600140B")]
		[Address(RVA = "0x3DF0FBC", Offset = "0x3DECFBC", VA = "0x3DF0FBC")]
		private bool TryGetNearestRoleTargetFromHexRing(Vector3 sourcePos, bool targetIsEnemy, float range, float sqrRange, out RoleBehaviour nearestRole, out bool searchedHexRing)
		{
			return default;
		}

		[Token(Token = "0x600140C")]
		[Address(RVA = "0x3DF1684", Offset = "0x3DED684", VA = "0x3DF1684")]
		private bool TryCollectRoleTargetsInRangeFromHexRing(Vector3 sourcePos, bool targetIsEnemy, float range, float sqrRange, List<RoleBehaviour> result, out bool searchedHexRing)
		{
			return default;
		}

		[Token(Token = "0x600140D")]
		[Address(RVA = "0x3DF13F8", Offset = "0x3DED3F8", VA = "0x3DF13F8")]
		private static bool TryGetNearestRoleTargetFromList(Vector3 sourcePos, List<RoleBehaviour> targetList, float sqrRange, out RoleBehaviour nearestRole)
		{
			return default;
		}

		[Token(Token = "0x600140E")]
		[Address(RVA = "0x3DF1A0C", Offset = "0x3DEDA0C", VA = "0x3DF1A0C")]
		private static int CollectRoleTargetsInRangeFromList(Vector3 sourcePos, List<RoleBehaviour> targetList, float sqrRange, List<RoleBehaviour> result)
		{
			return default;
		}

		[Token(Token = "0x600140F")]
		[Address(RVA = "0x3DF0A50", Offset = "0x3DECA50", VA = "0x3DF0A50")]
		private static void SortNearestRoleTargetsInPlace(Vector3 sourcePos, List<RoleBehaviour> result, int roleNum)
		{
		}

		[Token(Token = "0x6001410")]
		[Address(RVA = "0x3DF2A58", Offset = "0x3DEEA58", VA = "0x3DF2A58")]
		public List<EntityBase> GetRandomNumberRole(bool isEnemy, int num, bool onlyRole = false)
		{
			return null;
		}

		[Token(Token = "0x6001411")]
		[Address(RVA = "0x3DF3188", Offset = "0x3DEF188", VA = "0x3DF3188")]
		public EntityBase GetNearObj(bool isEnemy, Vector3 pos, [Optional][DefaultParameterValue(false)] bool isRole, [Optional][DefaultParameterValue(false)] bool isRandom, [Optional][DefaultParameterValue(-1f)] float range, [Optional] GameObject excludeObj)
		{
			return null;
		}

		[Token(Token = "0x6001412")]
		[Address(RVA = "0x3DF36D4", Offset = "0x3DEF6D4", VA = "0x3DF36D4")]
		public List<RoleBehaviour> GetNearRole(bool isEnemy, EntityBase role, float range = 1f, int roleNumber = -1)
		{
			return null;
		}

		[Token(Token = "0x6001413")]
		[Address(RVA = "0x3DF3DEC", Offset = "0x3DEFDEC", VA = "0x3DF3DEC")]
		private bool IsInnerHex(HexBehaviour hex)
		{
			return default;
		}

		[Token(Token = "0x6001414")]
		[Address(RVA = "0x3DF4010", Offset = "0x3DF0010", VA = "0x3DF4010")]
		private bool IsHexSurrounded(HexBehaviour hex)
		{
			return default;
		}

		[Token(Token = "0x6001415")]
		[Address(RVA = "0x3DF4234", Offset = "0x3DF0234", VA = "0x3DF4234")]
		public UniTask<List<Vector3>> GetRoleBornPos(Transform transform, bool isEnemy, int count = 1)
		{
			return default;
		}

		[Token(Token = "0x6001416")]
		[Address(RVA = "0x3DF43E4", Offset = "0x3DF03E4", VA = "0x3DF43E4")]
		private Vector3 GetRandomPositionOnHexEdge(Vector3 hexCenter)
		{
			return default;
		}

		[Token(Token = "0x6001417")]
		[Address(RVA = "0x3DF2964", Offset = "0x3DEE964", VA = "0x3DF2964")]
		private float GetSpawnHexSize()
		{
			return default;
		}

		[Token(Token = "0x6001418")]
		[Address(RVA = "0x3DF45F8", Offset = "0x3DF05F8", VA = "0x3DF45F8")]
		private void EnsureSpawnHexVertices(float hexSize)
		{
		}

		[Token(Token = "0x6001419")]
		[Address(RVA = "0x3DF4778", Offset = "0x3DF0778", VA = "0x3DF4778")]
		public bool CheckForBuilding(HexBehaviour aObject, bool isEnemy, int depth = 0)
		{
			return default;
		}

		[Token(Token = "0x600141A")]
		[Address(RVA = "0x3DF4890", Offset = "0x3DF0890", VA = "0x3DF4890")]
		[AsyncStateMachine(typeof(_003CGetRoleTarget_003Ed__207))]
		private UniTask<List<GameObject>> GetRoleTarget(Transform t, bool isEnemy, int range, int count)
		{
			return default;
		}

		[Token(Token = "0x600141B")]
		[Address(RVA = "0x3DF495C", Offset = "0x3DF095C", VA = "0x3DF495C")]
		public List<Vector3> GetHexTargetPosNoThisFoot(Vector3 pos, int num)
		{
			return null;
		}

		[Token(Token = "0x600141C")]
		[Address(RVA = "0x3DF4E34", Offset = "0x3DF0E34", VA = "0x3DF4E34")]
		public List<HexBehaviour> GetSpecialNearHex()
		{
			return null;
		}

		[Token(Token = "0x600141D")]
		[Address(RVA = "0x3DF5394", Offset = "0x3DF1394", VA = "0x3DF5394")]
		public HexBehaviour GetMainTowerForwardHex(bool isEnemy)
		{
			return null;
		}

		[Token(Token = "0x600141E")]
		[Address(RVA = "0x3DF5494", Offset = "0x3DF1494", VA = "0x3DF5494")]
		private HexBehaviour FindTopMostObject(HexBehaviour start, bool isEnemy)
		{
			return null;
		}

		[Token(Token = "0x600141F")]
		[Address(RVA = "0x3DF53C8", Offset = "0x3DF13C8", VA = "0x3DF53C8")]
		private HexBehaviour GetDesignatedKeyHex(string hexKey)
		{
			return null;
		}

		[Token(Token = "0x6001420")]
		[Address(RVA = "0x3DECD8C", Offset = "0x3DE8D8C", VA = "0x3DECD8C")]
		public HexManager.HexCoord? GetMainTowerHexCoord(bool isEnemy)
		{
			return null;
		}

		[Token(Token = "0x6001421")]
		[Address(RVA = "0x3DF556C", Offset = "0x3DF156C", VA = "0x3DF556C")]
		[AsyncStateMachine(typeof(_003CHideAllRole_003Ed__214))]
		private void HideAllRole()
		{
		}

		[Token(Token = "0x6001422")]
		[Address(RVA = "0x3DF55FC", Offset = "0x3DF15FC", VA = "0x3DF55FC")]
		private void DestroyAllROle()
		{
		}

		[Token(Token = "0x6001423")]
		[Address(RVA = "0x3DF56A8", Offset = "0x3DF16A8", VA = "0x3DF56A8")]
		private void DestroyRoleList(List<RoleBehaviour> roleList)
		{
		}

		[Token(Token = "0x6001424")]
		[Address(RVA = "0x3DEAFB0", Offset = "0x3DE6FB0", VA = "0x3DEAFB0")]
		[AsyncStateMachine(typeof(_003CSettlementAnimation_003Ed__217))]
		public void SettlementAnimation(bool isVictory)
		{
		}

		[Token(Token = "0x6001425")]
		[Address(RVA = "0x3DF5838", Offset = "0x3DF1838", VA = "0x3DF5838")]
		public bool IsLoneUnit(bool isEnemy, EntityBase units)
		{
			return default;
		}

		[Token(Token = "0x6001426")]
		[Address(RVA = "0x3DF5B50", Offset = "0x3DF1B50", VA = "0x3DF5B50")]
		public void RecordPlayerMainTowerKey(string key)
		{
		}

		[Token(Token = "0x6001427")]
		[Address(RVA = "0x3DF5B58", Offset = "0x3DF1B58", VA = "0x3DF5B58")]
		public void RecordEnemyMainTowerKey(string key)
		{
		}

		[Token(Token = "0x6001428")]
		[Address(RVA = "0x3DF5B60", Offset = "0x3DF1B60", VA = "0x3DF5B60")]
		public void RecoredSpecialHex(Vector3 pos)
		{
		}

		[Token(Token = "0x6001429")]
		[Address(RVA = "0x3DF5C34", Offset = "0x3DF1C34", VA = "0x3DF5C34")]
		public void RemoveSpecialHex(Vector3 pos)
		{
		}

		[Token(Token = "0x600142A")]
		[Address(RVA = "0x3DF5CAC", Offset = "0x3DF1CAC", VA = "0x3DF5CAC")]
		[AsyncStateMachine(typeof(_003CEndGame_003Ed__223))]
		public void EndGame()
		{
		}

		[Token(Token = "0x600142B")]
		[Address(RVA = "0x3DF5D3C", Offset = "0x3DF1D3C", VA = "0x3DF5D3C")]
		public void RecordPlayerOpenHexCount()
		{
		}

		[Token(Token = "0x600142C")]
		[Address(RVA = "0x3DF5D4C", Offset = "0x3DF1D4C", VA = "0x3DF5D4C")]
		public void AddPlayerStayHex(GameObject obj)
		{
		}

		[Token(Token = "0x600142D")]
		[Address(RVA = "0x3DF5DF0", Offset = "0x3DF1DF0", VA = "0x3DF5DF0")]
		public void AddEnemyStayHex(GameObject obj)
		{
		}

		[Token(Token = "0x600142E")]
		[Address(RVA = "0x3DF5F28", Offset = "0x3DF1F28", VA = "0x3DF5F28")]
		public void RemovePlayerStayHex(GameObject obj)
		{
		}

		[Token(Token = "0x600142F")]
		[Address(RVA = "0x3DF5F80", Offset = "0x3DF1F80", VA = "0x3DF5F80")]
		public void RemoveEnemyStayHex(GameObject obj)
		{
		}

		[Token(Token = "0x6001430")]
		[Address(RVA = "0x3DF6028", Offset = "0x3DF2028", VA = "0x3DF6028")]
		public void AddPlayerHasHex(GameObject obj)
		{
		}

		[Token(Token = "0x6001431")]
		[Address(RVA = "0x3DF60CC", Offset = "0x3DF20CC", VA = "0x3DF60CC")]
		public void AddEnemyHasHex(GameObject obj)
		{
		}

		[Token(Token = "0x6001432")]
		[Address(RVA = "0x3DF6170", Offset = "0x3DF2170", VA = "0x3DF6170")]
		public void RemovePlayerHasHex(GameObject obj)
		{
		}

		[Token(Token = "0x6001433")]
		[Address(RVA = "0x3DF61C8", Offset = "0x3DF21C8", VA = "0x3DF61C8")]
		public void RemoveEnemyHasHex(GameObject obj)
		{
		}

		[Token(Token = "0x6001434")]
		[Address(RVA = "0x3DF6220", Offset = "0x3DF2220", VA = "0x3DF6220")]
		public void AddPlayerArchitecture(GameObject obj)
		{
		}

		[Token(Token = "0x6001435")]
		[Address(RVA = "0x3DF6308", Offset = "0x3DF2308", VA = "0x3DF6308")]
		public void AddEnemyArchitecture(GameObject obj)
		{
		}

		[Token(Token = "0x6001436")]
		[Address(RVA = "0x3DF63F0", Offset = "0x3DF23F0", VA = "0x3DF63F0")]
		public void RemovePlayerArchitecture(GameObject obj)
		{
		}

		[Token(Token = "0x6001437")]
		[Address(RVA = "0x3DF6454", Offset = "0x3DF2454", VA = "0x3DF6454")]
		public void RemoveEnemyArchitecture(GameObject obj)
		{
		}

		[Token(Token = "0x6001438")]
		[Address(RVA = "0x3DF64B8", Offset = "0x3DF24B8", VA = "0x3DF64B8")]
		public void AddPlayerRole(GameObject obj, bool isFake = false, bool shouldCountInLimit = false)
		{
		}

		[Token(Token = "0x6001439")]
		[Address(RVA = "0x3DF69A0", Offset = "0x3DF29A0", VA = "0x3DF69A0")]
		public void AddEnemyRole(GameObject obj, bool isFake = false, bool shouldCountInLimit = false)
		{
		}

		[Token(Token = "0x600143A")]
		[Address(RVA = "0x3DF6E88", Offset = "0x3DF2E88", VA = "0x3DF6E88")]
		public void RemovePlayerRole(GameObject obj, bool triggerTrySpawn = true)
		{
		}

		[Token(Token = "0x600143B")]
		[Address(RVA = "0x3DF7B40", Offset = "0x3DF3B40", VA = "0x3DF7B40")]
		public void RemoveEnemyRole(GameObject obj, bool triggerTrySpawn = true)
		{
		}

		[Token(Token = "0x600143C")]
		[Address(RVA = "0x3DF7D78", Offset = "0x3DF3D78", VA = "0x3DF7D78")]
		public void RegisterWaitingBarracks(BarracksArchitectureBehaviour barracks, bool isEnemy)
		{
		}

		[Token(Token = "0x600143D")]
		[Address(RVA = "0x3DF7EB8", Offset = "0x3DF3EB8", VA = "0x3DF7EB8")]
		public void UnregisterWaitingBarracks(BarracksArchitectureBehaviour barracks, bool isEnemy)
		{
		}

		[Token(Token = "0x600143E")]
		[Address(RVA = "0x3DF70C0", Offset = "0x3DF30C0", VA = "0x3DF70C0")]
		private void TrySpawnFromWaitingBarracks(bool isEnemy)
		{
		}

		[Token(Token = "0x600143F")]
		[Address(RVA = "0x3DF8054", Offset = "0x3DF4054", VA = "0x3DF8054")]
		private void TrySpawnLegendaryFromWaitingBarracks(string roleID, bool isEnemy)
		{
		}

		[Token(Token = "0x6001440")]
		[Address(RVA = "0x3DF83D8", Offset = "0x3DF43D8", VA = "0x3DF83D8")]
		public void AddLegendaryBarracks(string roleID, bool isEnemy)
		{
		}

		[Token(Token = "0x6001441")]
		[Address(RVA = "0x3DF8508", Offset = "0x3DF4508", VA = "0x3DF8508")]
		public void RemoveLegendaryBarracks(string roleID, bool isEnemy)
		{
		}

		[Token(Token = "0x6001442")]
		[Address(RVA = "0x3DF866C", Offset = "0x3DF466C", VA = "0x3DF866C")]
		public void AddLegendaryUnit(string roleID, bool isEnemy)
		{
		}

		[Token(Token = "0x6001443")]
		[Address(RVA = "0x3DF879C", Offset = "0x3DF479C", VA = "0x3DF879C")]
		public void RemoveLegendaryUnit(string roleID, bool isEnemy)
		{
		}

		[Token(Token = "0x6001444")]
		[Address(RVA = "0x3DF8910", Offset = "0x3DF4910", VA = "0x3DF8910")]
		public int GetLegendaryUnitCount(string roleID, bool isEnemy)
		{
			return default;
		}

		[Token(Token = "0x6001445")]
		[Address(RVA = "0x3DF8A14", Offset = "0x3DF4A14", VA = "0x3DF8A14")]
		public int GetLegendaryBarracksCount(string roleID, bool isEnemy)
		{
			return default;
		}

		[Token(Token = "0x6001446")]
		[Address(RVA = "0x3DF7F8C", Offset = "0x3DF3F8C", VA = "0x3DF7F8C")]
		public bool CanSpawnLegendaryUnit(string roleID, bool isEnemy)
		{
			return default;
		}

		[Token(Token = "0x6001447")]
		[Address(RVA = "0x3DF8B18", Offset = "0x3DF4B18", VA = "0x3DF8B18")]
		public void CharmRecordChange()
		{
		}

		[Token(Token = "0x6001448")]
		[Address(RVA = "0x3DF8B1C", Offset = "0x3DF4B1C", VA = "0x3DF8B1C")]
		public void AddArchitectureBehaviour(ArchitectureBehaviour obj)
		{
		}

		[Token(Token = "0x6001449")]
		[Address(RVA = "0x3DF8C34", Offset = "0x3DF4C34", VA = "0x3DF8C34")]
		public void RemoveArchitectureBehaviour(ArchitectureBehaviour obj)
		{
		}

		[Token(Token = "0x600144A")]
		[Address(RVA = "0x3DF8CC0", Offset = "0x3DF4CC0", VA = "0x3DF8CC0")]
		public void AddHellfire(HellfireBehaviour hellfire)
		{
		}

		[Token(Token = "0x600144B")]
		[Address(RVA = "0x3DF8DD4", Offset = "0x3DF4DD4", VA = "0x3DF8DD4")]
		public void RemoveHellfire(HellfireBehaviour hellfire)
		{
		}

		[Token(Token = "0x600144C")]
		[Address(RVA = "0x3DF8EA8", Offset = "0x3DF4EA8", VA = "0x3DF8EA8")]
		public void AddHex(GameObject obj)
		{
		}

		[Token(Token = "0x600144D")]
		[Address(RVA = "0x3DF8F4C", Offset = "0x3DF4F4C", VA = "0x3DF8F4C")]
		public void RecordWaterPlane(GameObject obj)
		{
		}

		[Token(Token = "0x600144E")]
		[Address(RVA = "0x3DF8F54", Offset = "0x3DF4F54", VA = "0x3DF8F54")]
		public void RecordGroundPlane(GameObject obj)
		{
		}

		[Token(Token = "0x600144F")]
		[Address(RVA = "0x3DF8F5C", Offset = "0x3DF4F5C", VA = "0x3DF8F5C")]
		public void SetDestroyObjParent(GameObject obj)
		{
		}

		[Token(Token = "0x6001450")]
		[Address(RVA = "0x3DF8FAC", Offset = "0x3DF4FAC", VA = "0x3DF8FAC")]
		public void AddOneNeedDestroyPoolPrefabOnEndGame(GameObject prefab)
		{
		}

		[Token(Token = "0x6001451")]
		[Address(RVA = "0x3DF907C", Offset = "0x3DF507C", VA = "0x3DF907C")]
		public GameObject GetPlayerArchitectureRoot()
		{
			return null;
		}

		[Token(Token = "0x6001452")]
		[Address(RVA = "0x3DF9084", Offset = "0x3DF5084", VA = "0x3DF9084")]
		public GameObject GetEnemyArchitectureRoot()
		{
			return null;
		}

		[Token(Token = "0x6001453")]
		[Address(RVA = "0x3DF908C", Offset = "0x3DF508C", VA = "0x3DF908C")]
		public GameObject GetSpecialHexRoot()
		{
			return null;
		}

		[Token(Token = "0x6001454")]
		[Address(RVA = "0x3DF9094", Offset = "0x3DF5094", VA = "0x3DF9094")]
		public void HideSpecialHexRootImmediately()
		{
		}

		[Token(Token = "0x6001455")]
		[Address(RVA = "0x3DF911C", Offset = "0x3DF511C", VA = "0x3DF911C")]
		public void AddSpecialHexObject(GameObject obj)
		{
		}

		[Token(Token = "0x6001456")]
		[Address(RVA = "0x3DF9248", Offset = "0x3DF5248", VA = "0x3DF9248")]
		public BattleGameSceneManager()
		{
		}
	}
}
