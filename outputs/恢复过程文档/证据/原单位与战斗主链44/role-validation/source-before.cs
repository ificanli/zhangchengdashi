using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DG.Tweening;
using DataModule;
using Il2CppDummyDll;
using Pathfinding;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x2000368")]
	public class RoleBehaviour : EntityBase, IProp
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000369")]
		[CompilerGenerated]
		private struct _003CAddTempAttack_003Ed__272 : IAsyncStateMachine
		{
			[Token(Token = "0x400255C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400255D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400255E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public RoleBehaviour _003C_003E4__this;

			[Token(Token = "0x400255F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float num;

			[Token(Token = "0x4002560")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public bool haseff;

			[Token(Token = "0x4002561")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000FA5")]
			[Address(RVA = "0x3D8E5E8", Offset = "0x3D8A5E8", VA = "0x3D8E5E8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000FA6")]
			[Address(RVA = "0x3D8E9EC", Offset = "0x3D8A9EC", VA = "0x3D8E9EC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200036A")]
		[CompilerGenerated]
		private struct _003CAddTempMiss_003Ed__274 : IAsyncStateMachine
		{
			[Token(Token = "0x4002562")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002563")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002564")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public RoleBehaviour _003C_003E4__this;

			[Token(Token = "0x4002565")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float num;

			[Token(Token = "0x4002566")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000FA7")]
			[Address(RVA = "0x3D8E9F8", Offset = "0x3D8A9F8", VA = "0x3D8E9F8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000FA8")]
			[Address(RVA = "0x3D8EDD4", Offset = "0x3D8ADD4", VA = "0x3D8EDD4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200036B")]
		[CompilerGenerated]
		private struct _003CAddTempSpeed_003Ed__266 : IAsyncStateMachine
		{
			[Token(Token = "0x4002567")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002568")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002569")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public RoleBehaviour _003C_003E4__this;

			[Token(Token = "0x400256A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float num;

			[Token(Token = "0x400256B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000FA9")]
			[Address(RVA = "0x3D8EDE0", Offset = "0x3D8ADE0", VA = "0x3D8EDE0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000FAA")]
			[Address(RVA = "0x3D8F1FC", Offset = "0x3D8B1FC", VA = "0x3D8F1FC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200036C")]
		[CompilerGenerated]
		private struct _003CAtk_003Ed__198 : IAsyncStateMachine
		{
			[Token(Token = "0x400256C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400256D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400256E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public RoleBehaviour _003C_003E4__this;

			[Token(Token = "0x400256F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int attackNum;

			[Token(Token = "0x4002570")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private int _003Ci_003E5__2;

			[Token(Token = "0x4002571")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000FAB")]
			[Address(RVA = "0x3D8F208", Offset = "0x3D8B208", VA = "0x3D8F208", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000FAC")]
			[Address(RVA = "0x3D8F968", Offset = "0x3D8B968", VA = "0x3D8F968", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200036D")]
		[CompilerGenerated]
		private struct _003CAttackWallWithNormalLogic_003Ed__236 : IAsyncStateMachine
		{
			[Token(Token = "0x4002572")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002573")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002574")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RoleBehaviour _003C_003E4__this;

			[Token(Token = "0x4002575")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private int _003CattackNum_003E5__2;

			[Token(Token = "0x4002576")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private int _003Ci_003E5__3;

			[Token(Token = "0x4002577")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000FAD")]
			[Address(RVA = "0x3D8F974", Offset = "0x3D8B974", VA = "0x3D8F974", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000FAE")]
			[Address(RVA = "0x3D8FF00", Offset = "0x3D8BF00", VA = "0x3D8FF00", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200036E")]
		[CompilerGenerated]
		private struct _003CBreakWallAsync_003Ed__224 : IAsyncStateMachine
		{
			[Token(Token = "0x4002578")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002579")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400257A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RoleBehaviour _003C_003E4__this;

			[Token(Token = "0x400257B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000FAF")]
			[Address(RVA = "0x3D8FF0C", Offset = "0x3D8BF0C", VA = "0x3D8FF0C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000FB0")]
			[Address(RVA = "0x3D90314", Offset = "0x3D8C314", VA = "0x3D90314", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200036F")]
		[CompilerGenerated]
		private struct _003CCharm_003Ed__289 : IAsyncStateMachine
		{
			[Token(Token = "0x400257C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400257D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400257E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public RoleBehaviour _003C_003E4__this;

			[Token(Token = "0x400257F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool isCharm;

			[Token(Token = "0x4002580")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000FB1")]
			[Address(RVA = "0x3D90320", Offset = "0x3D8C320", VA = "0x3D90320", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000FB2")]
			[Address(RVA = "0x3D9086C", Offset = "0x3D8C86C", VA = "0x3D9086C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000370")]
		[CompilerGenerated]
		private struct _003CDead_003Ed__190 : IAsyncStateMachine
		{
			[Token(Token = "0x4002581")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002582")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002583")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public RoleBehaviour _003C_003E4__this;

			[Token(Token = "0x4002584")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public DeadType deadType;

			[Token(Token = "0x4002585")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000FB3")]
			[Address(RVA = "0x3D90878", Offset = "0x3D8C878", VA = "0x3D90878", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000FB4")]
			[Address(RVA = "0x3D914E4", Offset = "0x3D8D4E4", VA = "0x3D914E4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000371")]
		[CompilerGenerated]
		private struct _003CDizzy_003Ed__101 : IAsyncStateMachine
		{
			[Token(Token = "0x4002586")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002587")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002588")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public RoleBehaviour _003C_003E4__this;

			[Token(Token = "0x4002589")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float time;

			[Token(Token = "0x400258A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000FB5")]
			[Address(RVA = "0x3D914F0", Offset = "0x3D8D4F0", VA = "0x3D914F0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000FB6")]
			[Address(RVA = "0x3D91B48", Offset = "0x3D8DB48", VA = "0x3D91B48", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000372")]
		[CompilerGenerated]
		private struct _003CHellFireDeadCallBack_003Ed__195 : IAsyncStateMachine
		{
			[Token(Token = "0x400258B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400258C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400258D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public RoleBehaviour _003C_003E4__this;

			[Token(Token = "0x400258E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000FB7")]
			[Address(RVA = "0x3D91B54", Offset = "0x3D8DB54", VA = "0x3D91B54", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000FB8")]
			[Address(RVA = "0x3D9227C", Offset = "0x3D8E27C", VA = "0x3D9227C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000373")]
		[CompilerGenerated]
		private struct _003CInitAnimationAsync_003Ed__70 : IAsyncStateMachine
		{
			[Token(Token = "0x400258F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002590")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002591")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RoleBehaviour _003C_003E4__this;

			[Token(Token = "0x4002592")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000FB9")]
			[Address(RVA = "0x3D92288", Offset = "0x3D8E288", VA = "0x3D92288", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000FBA")]
			[Address(RVA = "0x3D924D0", Offset = "0x3D8E4D0", VA = "0x3D924D0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000374")]
		[CompilerGenerated]
		private struct _003CMeleeAtkCallBackLogic_003Ed__248 : IAsyncStateMachine
		{
			[Token(Token = "0x4002593")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002594")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002595")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int attack;

			[Token(Token = "0x4002596")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public RoleBehaviour _003C_003E4__this;

			[Token(Token = "0x4002597")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private string _003CtempId_003E5__2;

			[Token(Token = "0x4002598")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private int _003CattackNum_003E5__3;

			[Token(Token = "0x4002599")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000FBB")]
			[Address(RVA = "0x3D924DC", Offset = "0x3D8E4DC", VA = "0x3D924DC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000FBC")]
			[Address(RVA = "0x3D93190", Offset = "0x3D8F190", VA = "0x3D93190", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000375")]
		[CompilerGenerated]
		private struct _003CRemoteInitInfo_003Ed__247 : IAsyncStateMachine
		{
			[Token(Token = "0x400259A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400259B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400259C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public RoleBehaviour _003C_003E4__this;

			[Token(Token = "0x400259D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000FBD")]
			[Address(RVA = "0x3D9319C", Offset = "0x3D8F19C", VA = "0x3D9319C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000FBE")]
			[Address(RVA = "0x3D94F7C", Offset = "0x3D90F7C", VA = "0x3D94F7C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000376")]
		[CompilerGenerated]
		private struct _003CSetAnimation_003Ed__203 : IAsyncStateMachine
		{
			[Token(Token = "0x400259E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400259F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40025A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public RoleBehaviour _003C_003E4__this;

			[Token(Token = "0x40025A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public GPUInstanceAnimationBehaviour.AnimationName nextAnimationName;

			[Token(Token = "0x40025A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public bool force;

			[Token(Token = "0x40025A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public GPUInstanceAnimationBehaviour.AnimationName nextAnimationName2;

			[Token(Token = "0x40025A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000FBF")]
			[Address(RVA = "0x3D94F88", Offset = "0x3D90F88", VA = "0x3D94F88", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000FC0")]
			[Address(RVA = "0x3D9545C", Offset = "0x3D9145C", VA = "0x3D9545C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40024E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int _instanceID;

		[Token(Token = "0x40024E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool _isCountedInRoleLimit;

		[Token(Token = "0x40024E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public RolePropertyTemp PropertyTemp;

		[Token(Token = "0x40024E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected TargetType TargetType;

		[Token(Token = "0x40024E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected EntityBase ArchitectureBehaviour;

		[Token(Token = "0x40024E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected EntityBase _RoleBehaviour;

		[Token(Token = "0x40024E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected GlobalRoleInfo RoleInfo;

		[Token(Token = "0x40024E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public EntityBase TargetBehaviour;

		[Token(Token = "0x40024E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Transform _targetTrans;

		[Token(Token = "0x40024EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected AIDestinationSetter DestinationSetter;

		[Token(Token = "0x40024EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		protected FollowerEntity followerEntity;

		[Token(Token = "0x40024EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private GameObject _pathfindingTarget;

		[Token(Token = "0x40024ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float _bornFollowerRadius;

		[Token(Token = "0x40024EE")]
		private const float BASE_SCALE_FOR_RADIUS = 0.5f;

		[Token(Token = "0x40024EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		protected float FrontAtkTime;

		[Token(Token = "0x40024F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float _bornAtkRange;

		[Token(Token = "0x40024F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private float _tempRangePercent;

		[Token(Token = "0x40024F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float _tempBuildingDamagePercent;

		[Token(Token = "0x40024F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		protected int CardLevel;

		[Token(Token = "0x40024F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public GameObject BulletRes;

		[Token(Token = "0x40024F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		protected string RelativeCardID;

		[Token(Token = "0x40024F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private float _bornScaleX;

		[Token(Token = "0x40024F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public bool Skilling;

		[Token(Token = "0x40024F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		protected GameObject SkillTartget;

		[Token(Token = "0x40024F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public CardFettersType CardFettersType;

		[Token(Token = "0x40024FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public AtkWayType AtkWayType;

		[Token(Token = "0x40024FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		protected BulletBehaviour Bb;

		[Token(Token = "0x40024FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		protected GameObject IceBall;

		[Token(Token = "0x40024FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		protected bool isFreeze;

		[Token(Token = "0x40024FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		protected float freezeEndTime;

		[Token(Token = "0x40024FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		protected float aiPathRadius;

		[Token(Token = "0x4002500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		public float bornSpeed;

		[Token(Token = "0x4002501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public float BaseSpeed;

		[Token(Token = "0x4002502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		protected float bornMissObb;

		[Token(Token = "0x4002503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private MeshRenderer[] meshRenderer;

		[Token(Token = "0x4002504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private MaterialPropertyBlock propertyBlock;

		[Token(Token = "0x4002505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private SkinnedMeshRenderer[] skinnedMeshRenderer;

		[Token(Token = "0x4002506")]
		private const float NormalFindTargetInterval = 0.25f;

		[Token(Token = "0x4002507")]
		private const float FastFindTargetInterval = 0.15f;

		[Token(Token = "0x4002508")]
		private const int RetainRoleTargetHexDistanceSlack = 1;

		[Token(Token = "0x4002509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private float _nextFindTargetTime;

		[Token(Token = "0x400250A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private float _lastFindTargetRange;

		[Token(Token = "0x400250B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private RoleBehaviour _lastTrackedRoleTarget;

		[Token(Token = "0x400250C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private int _lastRoleTargetHexDistance;

		[Token(Token = "0x400250D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		protected float skillRequireCount;

		[Token(Token = "0x400250E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		protected float skillCompleteTime;

		[Token(Token = "0x400250F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		protected bool coolingComplete;

		[Token(Token = "0x4002510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12D")]
		protected bool firstSkill;

		[Token(Token = "0x4002511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		protected List<float> attackDamageDelay;

		[Token(Token = "0x4002512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public float SkillNumber;

		[Token(Token = "0x4002513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		protected GameEventType SkillType;

		[Token(Token = "0x4002514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public IAnimation gpuInstanceAnimationBehaviour;

		[Token(Token = "0x4002515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private bool hadInit;

		[Token(Token = "0x4002516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		protected float originalAttackAnimationSpeed;

		[Token(Token = "0x4002517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private bool defaultEnableLocalAvoidance;

		[Token(Token = "0x4002518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		public CardTalentTreeData TalentTreeData;

		[Token(Token = "0x4002519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		protected List<TalentBase> allTalent;

		[Token(Token = "0x400251A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		protected List<TalentBase> allTalent2;

		[Token(Token = "0x400251B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		protected EntityBase AttackObj;

		[Token(Token = "0x400251C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		public bool isClone;

		[Token(Token = "0x400251D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private List<RoleBehaviour> linkRoleList;

		[Token(Token = "0x400251E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private float linkNum;

		[Token(Token = "0x400251F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		public bool StealthIng;

		[Token(Token = "0x4002520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private float stealNum;

		[Token(Token = "0x4002521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x194")]
		private bool isDizzy;

		[Token(Token = "0x4002522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private float dizzyTime;

		[Token(Token = "0x4002523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private GameObject stunEffect;

		[Token(Token = "0x4002524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private Transform followerEntityCurrentTarget;

		[Token(Token = "0x4002525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private Transform followerEntityCurrentSourceTarget;

		[Token(Token = "0x4002526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private bool followerEntityCurrentCanMove;

		[Token(Token = "0x4002527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
		private float followerEntityCurrentSpeed;

		[Token(Token = "0x4002528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private float followerEntityCurrentRadius;

		[Token(Token = "0x4002529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
		private bool followerEntityNeedSearchPath;

		[Token(Token = "0x400252A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private float followerEntityLastSearchPathTime;

		[Token(Token = "0x400252B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
		private float _followerEntityLastTargetSyncTime;

		[Token(Token = "0x400252C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private bool followerEntityCurrentEnableLocalAvoidance;

		[Token(Token = "0x400252D")]
		private const float WEBGL_SEARCH_PATH_COOLDOWN = 0.4f;

		[Token(Token = "0x400252E")]
		private const float WEBGL_TARGET_SYNC_DISTANCE_THRESHOLD = 0.4f;

		[Token(Token = "0x400252F")]
		private const float WEBGL_TARGET_SYNC_TIME_THRESHOLD = 0.15f;

		[Token(Token = "0x4002530")]
		private const float DEFAULT_AUTO_REPATH_PERIOD = 1f;

		[Token(Token = "0x4002531")]
		private const float FOLLOWER_ENTITY_SCALE_SPEED_FACTOR = 0.8f;

		[Token(Token = "0x4002532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private GraphUpdateObject _currentOccupancyGUO;

		[Token(Token = "0x4002533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private bool _isPenaltyApplied;

		[Token(Token = "0x4002534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
		private Bounds _occupancyBounds;

		[Token(Token = "0x4002535")]
		private const int OCCUPANCY_PENALTY_VALUE = 999999999;

		[Token(Token = "0x4002536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private List<RoleBehaviour> targetList;

		[Token(Token = "0x4002537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private List<Vector3> allPos;

		[Token(Token = "0x4002538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private List<float> allPosLength;

		[Token(Token = "0x4002539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private readonly List<Vector3> _targetRemainingPathPoints;

		[Token(Token = "0x400253A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private StringBuilder _damageTextBuilder;

		[Token(Token = "0x400253B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		protected bool isSummonKuLou;

		[Token(Token = "0x400253C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x229")]
		protected bool isConvertSkeleton;

		[Token(Token = "0x400253D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22A")]
		private bool dontWound;

		[Token(Token = "0x400253E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22C")]
		private float _lastCheckHexPositionTime;

		[Token(Token = "0x400253F")]
		private const float CHECK_INTERVAL = 0.2f;

		[Token(Token = "0x4002540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		private Vector3 catapultsPos;

		[Token(Token = "0x4002541")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x23C")]
		private float lastChangeTime;

		[Token(Token = "0x4002542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		private bool waitToChangeAnimationing;

		[Token(Token = "0x4002543")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x241")]
		private bool attacking;

		[Token(Token = "0x4002544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x242")]
		private bool _isBreakingWall;

		[Token(Token = "0x4002545")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		private HexBehaviour _targetWallHex;

		[Token(Token = "0x4002546")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		private bool _isAttackingWall;

		[Token(Token = "0x4002547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		private StoneWallBehaviour _targetWall;

		[Token(Token = "0x4002548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		private HexBehaviour _targetWallHexForWall;

		[Token(Token = "0x4002549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		private float _attackWallStateEnterTime;

		[Token(Token = "0x400254A")]
		private const float AttackWallMaxDuration = 8f;

		[Token(Token = "0x400254B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x26C")]
		private Vector3 _lastWatchdogPos;

		[Token(Token = "0x400254C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		private float _lastWatchdogMoveTime;

		[Token(Token = "0x400254D")]
		private const float WatchdogStuckDuration = 2f;

		[Token(Token = "0x400254E")]
		private const float WatchdogMinMoveSqr = 0.01f;

		[Token(Token = "0x400254F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x27C")]
		public bool hadRecycle;

		[Token(Token = "0x4002550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x27D")]
		protected bool destroying;

		[Token(Token = "0x4002551")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
		protected HexBehaviour _currentHex;

		[Token(Token = "0x4002552")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		private bool addSpeedIng;

		[Token(Token = "0x4002553")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		private GameObject addSpeedEff;

		[Token(Token = "0x4002554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		public int bornAttack;

		[Token(Token = "0x4002555")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
		private GameObject addAttackEff;

		[Token(Token = "0x4002556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
		private GameObject addMissEff;

		[Token(Token = "0x4002557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
		private bool isShocking;

		[Token(Token = "0x4002558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
		private Tween shockTW;

		[Token(Token = "0x4002559")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
		private int bornMaxHp;

		[Token(Token = "0x400255A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C4")]
		private float bornAtkOffset;

		[Token(Token = "0x400255B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
		private GameObject charmEff;

		[Token(Token = "0x170000EA")]
		public bool IsLandRole
		{
			[Token(Token = "0x6000F08")]
			[Address(RVA = "0x3D7F778", Offset = "0x3D7B778", VA = "0x3D7F778")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000EB")]
		public bool HasSkill
		{
			[Token(Token = "0x6000F09")]
			[Address(RVA = "0x3D7F7D0", Offset = "0x3D7B7D0", VA = "0x3D7F7D0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000EC")]
		internal bool WebGLNavigationIsValid
		{
			[Token(Token = "0x6000F30")]
			[Address(RVA = "0x3D84470", Offset = "0x3D80470", VA = "0x3D84470")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000ED")]
		internal bool WebGLNavigationCanMove
		{
			[Token(Token = "0x6000F31")]
			[Address(RVA = "0x3D844BC", Offset = "0x3D804BC", VA = "0x3D844BC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000EE")]
		internal bool WebGLNavigationCanSoftSeparate
		{
			[Token(Token = "0x6000F32")]
			[Address(RVA = "0x3D84514", Offset = "0x3D80514", VA = "0x3D84514")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000EF")]
		internal Transform WebGLNavigationTarget
		{
			[Token(Token = "0x6000F33")]
			[Address(RVA = "0x3D845A0", Offset = "0x3D805A0", VA = "0x3D845A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F0")]
		internal TargetType WebGLNavigationTargetType
		{
			[Token(Token = "0x6000F34")]
			[Address(RVA = "0x3D84618", Offset = "0x3D80618", VA = "0x3D84618")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000F1")]
		internal float WebGLNavigationMoveSpeed
		{
			[Token(Token = "0x6000F35")]
			[Address(RVA = "0x3D84620", Offset = "0x3D80620", VA = "0x3D84620")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000F2")]
		internal float WebGLNavigationRadius
		{
			[Token(Token = "0x6000F36")]
			[Address(RVA = "0x3D84668", Offset = "0x3D80668", VA = "0x3D84668")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000F3")]
		internal float WebGLNavigationAttackRange
		{
			[Token(Token = "0x6000F37")]
			[Address(RVA = "0x3D84688", Offset = "0x3D80688", VA = "0x3D84688")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000F4")]
		internal bool WebGLNavigationEnableAvoidance
		{
			[Token(Token = "0x6000F38")]
			[Address(RVA = "0x3D846A0", Offset = "0x3D806A0", VA = "0x3D846A0")]
			get
			{
				return followerEntityCurrentEnableLocalAvoidance;
			}
		}

		[Token(Token = "0x170000F5")]
		internal bool IsAttacking
		{
			[Token(Token = "0x6000F67")]
			[Address(RVA = "0x3D88158", Offset = "0x3D84158", VA = "0x3D88158")]
			get
			{
				return attacking;
			}
		}

		[Token(Token = "0x170000F6")]
		internal bool IsAttackingWall
		{
			[Token(Token = "0x6000F68")]
			[Address(RVA = "0x3D88160", Offset = "0x3D84160", VA = "0x3D88160")]
			get
			{
				return _isAttackingWall;
			}
		}

		[Token(Token = "0x6000F0A")]
		[Address(RVA = "0x3D7F7E0", Offset = "0x3D7B7E0", VA = "0x3D7F7E0", Slot = "19")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000F0B")]
		[Address(RVA = "0x3D7FD58", Offset = "0x3D7BD58", VA = "0x3D7FD58")]
		private IAnimation ResolveAnimationBehaviour()
		{
			return null;
		}

		[Token(Token = "0x6000F0C")]
		[Address(RVA = "0x3D7FE44", Offset = "0x3D7BE44", VA = "0x3D7FE44")]
		public RoleAnimationDriverType GetAnimationDriverType()
		{
			return default;
		}

		[Token(Token = "0x6000F0D")]
		[Address(RVA = "0x3D7FED8", Offset = "0x3D7BED8", VA = "0x3D7FED8")]
		public bool IsGPUInstancerAnimationDriver()
		{
			return default;
		}

		[Token(Token = "0x6000F0E")]
		[Address(RVA = "0x3D7FEF0", Offset = "0x3D7BEF0", VA = "0x3D7FEF0")]
		public IAnimation GetAnimationBehaviour()
		{
			return null;
		}

		[Token(Token = "0x6000F0F")]
		[Address(RVA = "0x3D7FF14", Offset = "0x3D7BF14", VA = "0x3D7FF14", Slot = "20")]
		public virtual void Init(GlobalRoleInfo info, bool isEnemy, int cardLevel, RareLevel rareLevel, [Optional] string relativeCardID, CardFettersType fettersType = CardFettersType.Null, AtkWayType atkWayType = AtkWayType.Null)
		{
		}

		[Token(Token = "0x6000F10")]
		[Address(RVA = "0x3D816E8", Offset = "0x3D7D6E8", VA = "0x3D816E8")]
		[AsyncStateMachine(typeof(_003CInitAnimationAsync_003Ed__70))]
		private UniTaskVoid InitAnimationAsync()
		{
			return default;
		}

		[Token(Token = "0x6000F11")]
		[Address(RVA = "0x3D818CC", Offset = "0x3D7D8CC", VA = "0x3D818CC", Slot = "6")]
		protected override UniTask FindTarget(float range)
		{
			return default;
		}

		[Token(Token = "0x6000F12")]
		[Address(RVA = "0x3D81F00", Offset = "0x3D7DF00", VA = "0x3D81F00")]
		private bool ShouldSkipFindTarget(float range)
		{
			return default;
		}

		[Token(Token = "0x6000F13")]
		[Address(RVA = "0x3D821A0", Offset = "0x3D7E1A0", VA = "0x3D821A0")]
		private bool IsRoleTargetValidInRange(EntityBase target, float range)
		{
			return default;
		}

		[Token(Token = "0x6000F14")]
		[Address(RVA = "0x3D8237C", Offset = "0x3D7E37C", VA = "0x3D8237C")]
		private bool UpdateRoleTargetHexDistance(RoleBehaviour roleTarget)
		{
			return default;
		}

		[Token(Token = "0x6000F15")]
		[Address(RVA = "0x3D82110", Offset = "0x3D7E110", VA = "0x3D82110")]
		private void RecordCurrentRoleTargetDistance()
		{
		}

		[Token(Token = "0x6000F16")]
		[Address(RVA = "0x3D81228", Offset = "0x3D7D228", VA = "0x3D81228")]
		private void ClearRoleTargetTracking()
		{
		}

		[Token(Token = "0x6000F17")]
		[Address(RVA = "0x3D82340", Offset = "0x3D7E340", VA = "0x3D82340")]
		private float GetFindTargetInterval()
		{
			return default;
		}

		[Token(Token = "0x6000F18")]
		[Address(RVA = "0x3D825D8", Offset = "0x3D7E5D8", VA = "0x3D825D8")]
		public void SetSummonsNumber(float num)
		{
		}

		[Token(Token = "0x6000F19")]
		[Address(RVA = "0x3D7BE00", Offset = "0x3D77E00", VA = "0x3D7BE00")]
		public void IsClone()
		{
		}

		[Token(Token = "0x6000F1A")]
		[Address(RVA = "0x3D82628", Offset = "0x3D7E628", VA = "0x3D82628", Slot = "21")]
		protected virtual void InitTalent()
		{
		}

		[Token(Token = "0x6000F1B")]
		[Address(RVA = "0x3D82CEC", Offset = "0x3D7ECEC", VA = "0x3D82CEC", Slot = "22")]
		protected virtual void InitSkill()
		{
		}

		[Token(Token = "0x6000F1C")]
		[Address(RVA = "0x3D82FE8", Offset = "0x3D7EFE8", VA = "0x3D82FE8", Slot = "23")]
		protected virtual void OnHealthChangeTalentTrigger()
		{
		}

		[Token(Token = "0x6000F1D")]
		[Address(RVA = "0x3D831F4", Offset = "0x3D7F1F4", VA = "0x3D831F4")]
		protected (int, float) OnHurtTalentTrigger(int damage)
		{
			return default;
		}

		[Token(Token = "0x6000F1E")]
		[Address(RVA = "0x3D83404", Offset = "0x3D7F404", VA = "0x3D83404")]
		protected int OnAttackTalentTrigger(int atkNum)
		{
			return default;
		}

		[Token(Token = "0x6000F1F")]
		[Address(RVA = "0x3D8175C", Offset = "0x3D7D75C", VA = "0x3D8175C")]
		protected void OnInitTalentTrigger()
		{
		}

		[Token(Token = "0x6000F20")]
		[Address(RVA = "0x3D8363C", Offset = "0x3D7F63C", VA = "0x3D8363C")]
		protected void OnKillTalentTrigger()
		{
		}

		[Token(Token = "0x6000F21")]
		[Address(RVA = "0x3D83190", Offset = "0x3D7F190", VA = "0x3D83190")]
		public List<RoleBehaviour> GetNearOneMTeamMate()
		{
			return null;
		}

		[Token(Token = "0x6000F22")]
		[Address(RVA = "0x3D837AC", Offset = "0x3D7F7AC", VA = "0x3D837AC")]
		public void OnKillUnitCallBack()
		{
		}

		[Token(Token = "0x6000F23")]
		[Address(RVA = "0x3D837BC", Offset = "0x3D7F7BC", VA = "0x3D837BC")]
		public void LinkPact(RoleBehaviour role, float num)
		{
		}

		[Token(Token = "0x6000F24")]
		[Address(RVA = "0x3D8386C", Offset = "0x3D7F86C", VA = "0x3D8386C")]
		public void RemoveLinkPact(RoleBehaviour role)
		{
		}

		[Token(Token = "0x6000F25")]
		[Address(RVA = "0x3D838FC", Offset = "0x3D7F8FC", VA = "0x3D838FC")]
		public void StartStealth(float steaNum)
		{
		}

		[Token(Token = "0x6000F26")]
		[Address(RVA = "0x3D8390C", Offset = "0x3D7F90C", VA = "0x3D8390C")]
		public void StealthAddAtkAndEnd(ref int attackNum)
		{
		}

		[Token(Token = "0x6000F27")]
		[Address(RVA = "0x3D7B190", Offset = "0x3D77190", VA = "0x3D7B190")]
		public void PercentRestoreHp(float percent)
		{
		}

		[Token(Token = "0x6000F28")]
		[Address(RVA = "0x3D83A74", Offset = "0x3D7FA74", VA = "0x3D83A74")]
		[AsyncStateMachine(typeof(_003CDizzy_003Ed__101))]
		public void Dizzy(float time)
		{
		}

		[Token(Token = "0x6000F29")]
		[Address(RVA = "0x3D7E054", Offset = "0x3D7A054", VA = "0x3D7E054")]
		protected Vector3 GetXZDirection(Vector3 targetPosition)
		{
			return default;
		}

		[Token(Token = "0x6000F2A")]
		[Address(RVA = "0x3D83B14", Offset = "0x3D7FB14", VA = "0x3D83B14")]
		protected void RestoreAiAfterSkillRespectFreeze()
		{
		}

		[Token(Token = "0x6000F2B")]
		[Address(RVA = "0x3D83B54", Offset = "0x3D7FB54", VA = "0x3D83B54")]
		protected bool IsAiMovementBlockedByState()
		{
			return default;
		}

		[Token(Token = "0x6000F2C")]
		[Address(RVA = "0x3D84098", Offset = "0x3D80098", VA = "0x3D84098")]
		protected void RestoreAiAfterControlStateReleased()
		{
		}

		[Token(Token = "0x6000F2D")]
		[Address(RVA = "0x3D840E4", Offset = "0x3D800E4", VA = "0x3D840E4")]
		protected void ClearAiControlStates()
		{
		}

		[Token(Token = "0x6000F2E")]
		[Address(RVA = "0x3D83940", Offset = "0x3D7F940", VA = "0x3D83940")]
		private void AddHp(int num)
		{
		}

		[Token(Token = "0x6000F2F")]
		[Address(RVA = "0x3D7B1DC", Offset = "0x3D771DC", VA = "0x3D7B1DC")]
		public void AddForeverSpeed(float percent)
		{
		}

		[Token(Token = "0x6000F39")]
		[Address(RVA = "0x3D846A8", Offset = "0x3D806A8", VA = "0x3D846A8")]
		internal void WebGLNavigationApplyPosition(Vector3 position, bool refreshHex, [Optional] HexBehaviour resolvedHex)
		{
		}

		[Token(Token = "0x6000F3A")]
		[Address(RVA = "0x3D7FA30", Offset = "0x3D7BA30", VA = "0x3D7FA30")]
		private void SetPathfindingEnabled(bool enabled)
		{
		}

		[Token(Token = "0x6000F3B")]
		[Address(RVA = "0x3D7FA28", Offset = "0x3D7BA28", VA = "0x3D7FA28")]
		private static bool ShouldUseWebGLPathfindingTuning()
		{
			return default;
		}

		[Token(Token = "0x6000F3C")]
		[Address(RVA = "0x3D848E4", Offset = "0x3D808E4", VA = "0x3D848E4")]
		private void RequestSearchPathRefresh()
		{
		}

		[Token(Token = "0x6000F3D")]
		[Address(RVA = "0x3D848F0", Offset = "0x3D808F0", VA = "0x3D848F0")]
		private bool ShouldSyncPathfindingTargetPosition(bool sourceTargetChanged, Vector3 currentPosition, Vector3 targetPosition)
		{
			return default;
		}

		[Token(Token = "0x6000F3E")]
		[Address(RVA = "0x3D849C4", Offset = "0x3D809C4", VA = "0x3D849C4")]
		private void TryRefreshSearchPath()
		{
		}

		[Token(Token = "0x6000F3F")]
		[Address(RVA = "0x3D812CC", Offset = "0x3D7D2CC", VA = "0x3D812CC")]
		private static float GetAutoRepathPeriod(int roleCount)
		{
			return default;
		}

		[Token(Token = "0x6000F40")]
		[Address(RVA = "0x3D7FC94", Offset = "0x3D7BC94", VA = "0x3D7FC94")]
		private void ApplyDefaultLocalAvoidancePolicy(int roleCount)
		{
		}

		[Token(Token = "0x6000F41")]
		[Address(RVA = "0x3D81304", Offset = "0x3D7D304", VA = "0x3D81304")]
		public void SetAiTarget(Transform target)
		{
		}

		[Token(Token = "0x6000F42")]
		[Address(RVA = "0x3D84A94", Offset = "0x3D80A94", VA = "0x3D84A94")]
		public bool GetAiCanMove()
		{
			return default;
		}

		[Token(Token = "0x6000F43")]
		[Address(RVA = "0x3D7AB7C", Offset = "0x3D76B7C", VA = "0x3D7AB7C")]
		public void SetAiCanMove(bool can)
		{
		}

		[Token(Token = "0x6000F44")]
		[Address(RVA = "0x3D7AD0C", Offset = "0x3D76D0C", VA = "0x3D7AD0C")]
		protected void SyncPathfindingPosition(bool clearPath = true)
		{
		}

		[Token(Token = "0x6000F45")]
		[Address(RVA = "0x3D816B4", Offset = "0x3D7D6B4", VA = "0x3D816B4")]
		public float GetAiSPeed()
		{
			return default;
		}

		[Token(Token = "0x6000F46")]
		[Address(RVA = "0x3D84A9C", Offset = "0x3D80A9C", VA = "0x3D84A9C")]
		private float GetFollowerEntityMoveSpeed(float speed)
		{
			return default;
		}

		[Token(Token = "0x6000F47")]
		[Address(RVA = "0x3D84658", Offset = "0x3D80658", VA = "0x3D84658")]
		private float GetWebGLNavigationMoveSpeed(float speed)
		{
			return default;
		}

		[Token(Token = "0x6000F48")]
		[Address(RVA = "0x3D7EDA8", Offset = "0x3D7ADA8", VA = "0x3D7EDA8")]
		public void SetAiSPeed(float s, bool isReduceSpeed = false)
		{
		}

		[Token(Token = "0x6000F49")]
		[Address(RVA = "0x3D7F9E0", Offset = "0x3D7B9E0", VA = "0x3D7F9E0")]
		private float GetScaledRadius(float baseRadius)
		{
			return default;
		}

		[Token(Token = "0x6000F4A")]
		[Address(RVA = "0x3D84AC4", Offset = "0x3D80AC4", VA = "0x3D84AC4")]
		public float GetAiRadius()
		{
			return default;
		}

		[Token(Token = "0x6000F4B")]
		[Address(RVA = "0x3D84ACC", Offset = "0x3D80ACC", VA = "0x3D84ACC")]
		public void SetAiRadius(float s)
		{
		}

		[Token(Token = "0x6000F4C")]
		[Address(RVA = "0x3D84B60", Offset = "0x3D80B60", VA = "0x3D84B60")]
		public bool GetAiEnableLocalAvoidance()
		{
			return default;
		}

		[Token(Token = "0x6000F4D")]
		[Address(RVA = "0x3D83C30", Offset = "0x3D7FC30", VA = "0x3D83C30")]
		public void SetAiEnableLocalAvoidance(bool enable)
		{
		}

		[Token(Token = "0x6000F4E")]
		[Address(RVA = "0x3D84B68", Offset = "0x3D80B68", VA = "0x3D84B68")]
		private void ApplyOccupancyPenalty(bool enable)
		{
		}

		[Token(Token = "0x6000F4F")]
		[Address(RVA = "0x3D82F9C", Offset = "0x3D7EF9C", VA = "0x3D82F9C")]
		public void InitSkillInfo()
		{
		}

		[Token(Token = "0x6000F50")]
		[Address(RVA = "0x3D84EDC", Offset = "0x3D80EDC", VA = "0x3D84EDC")]
		private void SkillUpdate()
		{
		}

		[Token(Token = "0x6000F51")]
		[Address(RVA = "0x3D84FB4", Offset = "0x3D80FB4", VA = "0x3D84FB4")]
		private void CheckReleaseSkill()
		{
		}

		[Token(Token = "0x6000F52")]
		[Address(RVA = "0x3D8534C", Offset = "0x3D8134C", VA = "0x3D8534C")]
		private RoleBehaviour GetRoleTarget(float range)
		{
			return null;
		}

		[Token(Token = "0x6000F53")]
		[Address(RVA = "0x3D7BDF4", Offset = "0x3D77DF4", VA = "0x3D7BDF4")]
		public void SummonKulou()
		{
		}

		[Token(Token = "0x6000F54")]
		[Address(RVA = "0x3D85354", Offset = "0x3D81354", VA = "0x3D85354")]
		public void ConvertSkeleton()
		{
		}

		[Token(Token = "0x6000F55")]
		[Address(RVA = "0x3D85360", Offset = "0x3D81360", VA = "0x3D85360")]
		public void SetMaterial(Material material)
		{
		}

		[Token(Token = "0x6000F56")]
		[Address(RVA = "0x3D85364", Offset = "0x3D81364", VA = "0x3D85364")]
		public void SetDarkenColor(Color color)
		{
		}

		[Token(Token = "0x6000F57")]
		[Address(RVA = "0x3D85368", Offset = "0x3D81368", VA = "0x3D85368")]
		public void SetRvoControllerEnable(bool isTrue)
		{
		}

		[Token(Token = "0x6000F58")]
		[Address(RVA = "0x3D853A0", Offset = "0x3D813A0", VA = "0x3D853A0", Slot = "5")]
		public override void MyUpdate()
		{
		}

		[Token(Token = "0x6000F59")]
		[Address(RVA = "0x3D86A44", Offset = "0x3D82A44", VA = "0x3D86A44", Slot = "4")]
		public override void Wound(int damage, string id, [Optional][DefaultParameterValue(false)] bool isBuild, [Optional] EntityBase target, [Optional][DefaultParameterValue(false)] bool isLandRole, [Optional][DefaultParameterValue((AtkWayType)0)] AtkWayType atkWayType, [Optional][DefaultParameterValue((CardFettersType)4)] CardFettersType fetterType, [Optional] Object linkAttackObj)
		{
		}

		[Token(Token = "0x6000F5A")]
		[Address(RVA = "0x3D841C4", Offset = "0x3D801C4", VA = "0x3D841C4")]
		public void ShowDamageText(string damage, Color color)
		{
		}

		[Token(Token = "0x6000F5B")]
		[Address(RVA = "0x3D875F4", Offset = "0x3D835F4", VA = "0x3D875F4")]
		public void Freeze()
		{
		}

		[Token(Token = "0x6000F5C")]
		[Address(RVA = "0x3D876CC", Offset = "0x3D836CC", VA = "0x3D876CC", Slot = "24")]
		[AsyncStateMachine(typeof(_003CDead_003Ed__190))]
		protected virtual void Dead(DeadType deadType = DeadType.Common)
		{
		}

		[Token(Token = "0x6000F5D")]
		[Address(RVA = "0x3D8776C", Offset = "0x3D8376C", VA = "0x3D8776C", Slot = "25")]
		protected virtual void StartListeningEvent()
		{
		}

		[Token(Token = "0x6000F5E")]
		[Address(RVA = "0x3D87828", Offset = "0x3D83828", VA = "0x3D87828", Slot = "26")]
		protected virtual void StopListeningEvent()
		{
		}

		[Token(Token = "0x6000F5F")]
		[Address(RVA = "0x3D878E4", Offset = "0x3D838E4", VA = "0x3D878E4", Slot = "27")]
		protected virtual void DeadCallBack(DeadType deadType = DeadType.Common)
		{
		}

		[Token(Token = "0x6000F60")]
		[Address(RVA = "0x3D87450", Offset = "0x3D83450", VA = "0x3D87450")]
		private bool GetIsHellFireAtk(object link)
		{
			return default;
		}

		[Token(Token = "0x6000F61")]
		[Address(RVA = "0x3D87E38", Offset = "0x3D83E38", VA = "0x3D87E38")]
		[AsyncStateMachine(typeof(_003CHellFireDeadCallBack_003Ed__195))]
		private void HellFireDeadCallBack()
		{
		}

		[Token(Token = "0x6000F62")]
		[Address(RVA = "0x3D87EC8", Offset = "0x3D83EC8", VA = "0x3D87EC8", Slot = "28")]
		protected virtual void UpdateArchitectureTarget(object o)
		{
		}

		[Token(Token = "0x6000F63")]
		[Address(RVA = "0x3D87FB0", Offset = "0x3D83FB0", VA = "0x3D87FB0", Slot = "29")]
		[AsyncStateMachine(typeof(_003CAtk_003Ed__198))]
		protected virtual void Atk(int attackNum)
		{
		}

		[Token(Token = "0x6000F64")]
		[Address(RVA = "0x3D88050", Offset = "0x3D84050", VA = "0x3D88050", Slot = "30")]
		protected virtual void AtkCallBack(int attackNum)
		{
		}

		[Token(Token = "0x6000F65")]
		[Address(RVA = "0x3D7F628", Offset = "0x3D7B628", VA = "0x3D7F628")]
		public void SetAnimation(GPUInstanceAnimationBehaviour.AnimationName nextAnimationName, bool force = false)
		{
		}

		[Token(Token = "0x6000F66")]
		[Address(RVA = "0x3D7AC50", Offset = "0x3D76C50", VA = "0x3D7AC50")]
		[AsyncStateMachine(typeof(_003CSetAnimation_003Ed__203))]
		public void SetAnimation(GPUInstanceAnimationBehaviour.AnimationName nextAnimationName, GPUInstanceAnimationBehaviour.AnimationName nextAnimationName2, bool force = false)
		{
		}

		[Token(Token = "0x6000F69")]
		[Address(RVA = "0x3D88168", Offset = "0x3D84168", VA = "0x3D88168")]
		private void MarkMoveReturn(string reason)
		{
		}

		[Token(Token = "0x6000F6A")]
		[Address(RVA = "0x3D85A88", Offset = "0x3D81A88", VA = "0x3D85A88")]
		private void Move()
		{
		}

		[Token(Token = "0x6000F6B")]
		[Address(RVA = "0x3D890A4", Offset = "0x3D850A4", VA = "0x3D890A4")]
		private void CheckAndBreakWall()
		{
		}

		[Token(Token = "0x6000F6C")]
		[Address(RVA = "0x3D89338", Offset = "0x3D85338", VA = "0x3D89338")]
		private HexBehaviour FindFirstEnemyObstacleInPath(Vector2 startPos, Vector2 direction, float maxDistance)
		{
			return null;
		}

		[Token(Token = "0x6000F6D")]
		[Address(RVA = "0x3D89798", Offset = "0x3D85798", VA = "0x3D89798")]
		[AsyncStateMachine(typeof(_003CBreakWallAsync_003Ed__224))]
		private UniTaskVoid BreakWallAsync()
		{
			return default;
		}

		[Token(Token = "0x6000F6E")]
		[Address(RVA = "0x3D8816C", Offset = "0x3D8416C", VA = "0x3D8816C")]
		private void CheckAndAttackWall()
		{
		}

		[Token(Token = "0x6000F6F")]
		[Address(RVA = "0x3D89B7C", Offset = "0x3D85B7C", VA = "0x3D89B7C")]
		private StoneWallBehaviour FindFirstEnemyWallInPath(List<Vector3> pathPoints, Vector3 startPos, float maxDistance)
		{
			return null;
		}

		[Token(Token = "0x6000F70")]
		[Address(RVA = "0x3D8A930", Offset = "0x3D86930", VA = "0x3D8A930")]
		private bool IsNeighbor(HexBehaviour hex1, HexBehaviour hex2)
		{
			return default;
		}

		[Token(Token = "0x6000F71")]
		[Address(RVA = "0x3D8AAD0", Offset = "0x3D86AD0", VA = "0x3D8AAD0")]
		private List<HexBehaviour> FindIntermediateHexPath(HexBehaviour fromHex, HexBehaviour toHex)
		{
			return null;
		}

		[Token(Token = "0x6000F72")]
		[Address(RVA = "0x3D89810", Offset = "0x3D85810", VA = "0x3D89810")]
		private StoneWallBehaviour GetWallBetweenAdjacentHexes(HexBehaviour fromHex, HexBehaviour toHex)
		{
			return null;
		}

		[Token(Token = "0x6000F73")]
		[Address(RVA = "0x3D82018", Offset = "0x3D7E018", VA = "0x3D82018")]
		private bool TryGetAstarRemainingPath(List<Vector3> outPathPoints)
		{
			return default;
		}

		[Token(Token = "0x6000F74")]
		[Address(RVA = "0x3D89DA8", Offset = "0x3D85DA8", VA = "0x3D89DA8")]
		private List<HexBehaviour> GetHexesFromPathPoints(List<Vector3> pathPoints, Vector3 startPos)
		{
			return null;
		}

		[Token(Token = "0x6000F75")]
		[Address(RVA = "0x3D8B0BC", Offset = "0x3D870BC", VA = "0x3D8B0BC")]
		private bool IsPathClear(List<Vector3> pathPoints, Vector3 startPos)
		{
			return default;
		}

		[Token(Token = "0x6000F76")]
		[Address(RVA = "0x3D8B258", Offset = "0x3D87258", VA = "0x3D8B258")]
		private void CheckAndContinueAttackAdjacentWalls()
		{
		}

		[Token(Token = "0x6000F77")]
		[Address(RVA = "0x3D8B938", Offset = "0x3D87938", VA = "0x3D8B938")]
		private StoneWallBehaviour[] GetWallsFromHex(HexBehaviour hex)
		{
			return null;
		}

		[Token(Token = "0x6000F78")]
		[Address(RVA = "0x3D88B08", Offset = "0x3D84B08", VA = "0x3D88B08")]
		private void AttackWall()
		{
		}

		[Token(Token = "0x6000F79")]
		[Address(RVA = "0x3D8BBAC", Offset = "0x3D87BAC", VA = "0x3D8BBAC")]
		[AsyncStateMachine(typeof(_003CAttackWallWithNormalLogic_003Ed__236))]
		private UniTaskVoid AttackWallWithNormalLogic()
		{
			return default;
		}

		[Token(Token = "0x6000F7A")]
		[Address(RVA = "0x3D851C4", Offset = "0x3D811C4", VA = "0x3D851C4")]
		private void EnemyEmitSkill()
		{
		}

		[Token(Token = "0x6000F7B")]
		[Address(RVA = "0x3D85288", Offset = "0x3D81288", VA = "0x3D85288")]
		private void PlayerEmitSkill()
		{
		}

		[Token(Token = "0x6000F7C")]
		[Address(RVA = "0x3D792C8", Offset = "0x3D752C8", VA = "0x3D792C8", Slot = "31")]
		protected virtual void EmitSkill()
		{
		}

		[Token(Token = "0x6000F7D")]
		[Address(RVA = "0x3D8BC24", Offset = "0x3D87C24", VA = "0x3D8BC24", Slot = "32")]
		protected virtual void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000F7E")]
		[Address(RVA = "0x3D8BC28", Offset = "0x3D87C28", VA = "0x3D8BC28")]
		public void UIHide()
		{
		}

		[Token(Token = "0x6000F7F")]
		[Address(RVA = "0x3D8BD24", Offset = "0x3D87D24", VA = "0x3D8BD24")]
		public void ApplySubGameCurrentHpChange(int damage)
		{
		}

		[Token(Token = "0x6000F80")]
		[Address(RVA = "0x3D8BF30", Offset = "0x3D87F30", VA = "0x3D8BF30", Slot = "33")]
		protected virtual void UpdateHpBar()
		{
		}

		[Token(Token = "0x6000F81")]
		[Address(RVA = "0x3D8BC2C", Offset = "0x3D87C2C", VA = "0x3D8BC2C")]
		public void RemoveHPUI()
		{
		}

		[Token(Token = "0x6000F82")]
		[Address(RVA = "0x3D8C2AC", Offset = "0x3D882AC", VA = "0x3D8C2AC", Slot = "34")]
		protected virtual void Vampire()
		{
		}

		[Token(Token = "0x6000F83")]
		[Address(RVA = "0x3D8C404", Offset = "0x3D88404", VA = "0x3D8C404")]
		protected void MeleeInitInfo()
		{
		}

		[Token(Token = "0x6000F84")]
		[Address(RVA = "0x3D8C4B4", Offset = "0x3D884B4", VA = "0x3D8C4B4")]
		[AsyncStateMachine(typeof(_003CRemoteInitInfo_003Ed__247))]
		protected void RemoteInitInfo()
		{
		}

		[Token(Token = "0x6000F85")]
		[Address(RVA = "0x3D79130", Offset = "0x3D75130", VA = "0x3D79130")]
		[AsyncStateMachine(typeof(_003CMeleeAtkCallBackLogic_003Ed__248))]
		protected void MeleeAtkCallBackLogic(int attack)
		{
		}

		[Token(Token = "0x6000F86")]
		[Address(RVA = "0x3D8C544", Offset = "0x3D88544", VA = "0x3D8C544", Slot = "35")]
		protected virtual void RemoteAtkCallBackLogic(int attack, [Optional] GameObject bulletRes)
		{
		}

		[Token(Token = "0x6000F87")]
		[Address(RVA = "0x3D8CDCC", Offset = "0x3D88DCC", VA = "0x3D8CDCC", Slot = "36")]
		protected virtual void OnAttackSkill(int attackNum)
		{
		}

		[Token(Token = "0x6000F88")]
		[Address(RVA = "0x3D8CDD0", Offset = "0x3D88DD0", VA = "0x3D8CDD0", Slot = "37")]
		protected virtual void OnDeadSkill()
		{
		}

		[Token(Token = "0x6000F89")]
		[Address(RVA = "0x3D8CDD4", Offset = "0x3D88DD4", VA = "0x3D8CDD4", Slot = "38")]
		protected virtual void OnUpdateSkill()
		{
		}

		[Token(Token = "0x6000F8A")]
		[Address(RVA = "0x3D8CDD8", Offset = "0x3D88DD8", VA = "0x3D8CDD8")]
		public void RecycleOnBattleEnd()
		{
		}

		[Token(Token = "0x6000F8B")]
		[Address(RVA = "0x3D8CE8C", Offset = "0x3D88E8C", VA = "0x3D8CE8C", Slot = "39")]
		protected virtual void OnRecycle()
		{
		}

		[Token(Token = "0x6000F8C")]
		[Address(RVA = "0x3D8D488", Offset = "0x3D89488", VA = "0x3D8D488", Slot = "40")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000F8D")]
		[Address(RVA = "0x3D8D5A8", Offset = "0x3D895A8", VA = "0x3D8D5A8")]
		private void SyncCurrentHexCampRegistration(bool previousIsEnemy)
		{
		}

		[Token(Token = "0x6000F8E")]
		[Address(RVA = "0x3D847E4", Offset = "0x3D807E4", VA = "0x3D847E4")]
		private void UpdateHexPosition()
		{
		}

		[Token(Token = "0x6000F8F")]
		[Address(RVA = "0x3D847A0", Offset = "0x3D807A0", VA = "0x3D847A0")]
		private void UpdateHexPosition(HexBehaviour newHex)
		{
		}

		[Token(Token = "0x6000F90")]
		[Address(RVA = "0x3D8D738", Offset = "0x3D89738", VA = "0x3D8D738")]
		private void ApplyHexPosition(HexBehaviour newHex)
		{
		}

		[Token(Token = "0x6000F91")]
		[Address(RVA = "0x3D8D820", Offset = "0x3D89820", VA = "0x3D8D820")]
		private void AddEffHead(GameObject res, ref GameObject eff)
		{
		}

		[Token(Token = "0x6000F92")]
		[Address(RVA = "0x3D8DA1C", Offset = "0x3D89A1C", VA = "0x3D8DA1C", Slot = "7")]
		[AsyncStateMachine(typeof(_003CAddTempSpeed_003Ed__266))]
		public void AddTempSpeed(float num)
		{
		}

		[Token(Token = "0x6000F93")]
		[Address(RVA = "0x3D81238", Offset = "0x3D7D238", VA = "0x3D81238")]
		private void ClearDizzyState()
		{
		}

		[Token(Token = "0x6000F94")]
		[Address(RVA = "0x3D8D3F8", Offset = "0x3D893F8", VA = "0x3D8D3F8")]
		private void ClearFreezeState()
		{
		}

		[Token(Token = "0x6000F95")]
		[Address(RVA = "0x3D8DABC", Offset = "0x3D89ABC", VA = "0x3D8DABC", Slot = "8")]
		public void ReduceTempSpeed(float num)
		{
		}

		[Token(Token = "0x6000F96")]
		[Address(RVA = "0x3D8DB24", Offset = "0x3D89B24", VA = "0x3D8DB24", Slot = "9")]
		[AsyncStateMachine(typeof(_003CAddTempAttack_003Ed__272))]
		public void AddTempAttack(float num, bool haseff)
		{
		}

		[Token(Token = "0x6000F97")]
		[Address(RVA = "0x3D8DBD8", Offset = "0x3D89BD8", VA = "0x3D8DBD8", Slot = "10")]
		[AsyncStateMachine(typeof(_003CAddTempMiss_003Ed__274))]
		public void AddTempMiss(float num)
		{
		}

		[Token(Token = "0x6000F98")]
		[Address(RVA = "0x3D8DC78", Offset = "0x3D89C78", VA = "0x3D8DC78", Slot = "11")]
		public void Shock(int damage, Vector3 pos, float shockDis)
		{
		}

		[Token(Token = "0x6000F99")]
		[Address(RVA = "0x3D8DF28", Offset = "0x3D89F28", VA = "0x3D8DF28")]
		private float CalcShock(float num)
		{
			return default;
		}

		[Token(Token = "0x6000F9A")]
		[Address(RVA = "0x3D8DF38", Offset = "0x3D89F38", VA = "0x3D8DF38", Slot = "12")]
		public void AddImmediateHp(int num)
		{
		}

		[Token(Token = "0x6000F9B")]
		[Address(RVA = "0x3D8DF54", Offset = "0x3D89F54", VA = "0x3D8DF54", Slot = "13")]
		public void AddTempHp(float num)
		{
		}

		[Token(Token = "0x6000F9C")]
		[Address(RVA = "0x3D8DFD4", Offset = "0x3D89FD4", VA = "0x3D8DFD4", Slot = "14")]
		public void AddTempAtkOffset(float num)
		{
		}

		[Token(Token = "0x6000F9D")]
		[Address(RVA = "0x3D8E018", Offset = "0x3D8A018", VA = "0x3D8E018", Slot = "15")]
		public void AddTempRange(float num)
		{
		}

		[Token(Token = "0x6000F9E")]
		[Address(RVA = "0x3D8E074", Offset = "0x3D8A074", VA = "0x3D8E074", Slot = "16")]
		public void AddTempBuildingDamageMultiplier(float percent)
		{
		}

		[Token(Token = "0x6000F9F")]
		[Address(RVA = "0x3D8CC9C", Offset = "0x3D88C9C", VA = "0x3D8CC9C")]
		private int ApplyBuildingDamageMultiplierIfNeeded(int damage, EntityBase targetEntity)
		{
			return default;
		}

		[Token(Token = "0x6000FA0")]
		[Address(RVA = "0x3D8E08C", Offset = "0x3D8A08C", VA = "0x3D8E08C", Slot = "17")]
		public void ImmediateDead()
		{
		}

		[Token(Token = "0x6000FA1")]
		[Address(RVA = "0x3D8E140", Offset = "0x3D8A140", VA = "0x3D8E140", Slot = "18")]
		[AsyncStateMachine(typeof(_003CCharm_003Ed__289))]
		public void Charm(bool isCharm)
		{
		}

		[Token(Token = "0x6000FA2")]
		[Address(RVA = "0x3D8E1E4", Offset = "0x3D8A1E4", VA = "0x3D8E1E4")]
		public RoleBehaviour()
		{
		}
	}
}
