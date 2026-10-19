using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x2000388")]
	public class SkeletonWarriorBehaviour : UndeadBehaviour
	{
		[Token(Token = "0x2000389")]
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass4_0
		{
			[Token(Token = "0x40025EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<RoleBehaviour> allTar;

			[Token(Token = "0x40025F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public SkeletonWarriorBehaviour _003C_003E4__this;

			[Token(Token = "0x6000FFF")]
			[Address(RVA = "0x3D9AC6C", Offset = "0x3D96C6C", VA = "0x3D9AC6C")]
			public _003C_003Ec__DisplayClass4_0()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200038B")]
		[CompilerGenerated]
		private struct _003CInitSkill_003Ed__1 : IAsyncStateMachine
		{
			[Token(Token = "0x40025F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40025F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40025F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public SkeletonWarriorBehaviour _003C_003E4__this;

			[Token(Token = "0x40025F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6001002")]
			[Address(RVA = "0x3D9AD9C", Offset = "0x3D96D9C", VA = "0x3D9AD9C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001003")]
			[Address(RVA = "0x3D9B0AC", Offset = "0x3D970AC", VA = "0x3D9B0AC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200038C")]
		[CompilerGenerated]
		private struct _003CSkeletonWarriorSkill_003Ed__4 : IAsyncStateMachine
		{
			[Token(Token = "0x40025F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40025F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40025F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public SkeletonWarriorBehaviour _003C_003E4__this;

			[Token(Token = "0x40025FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private _003C_003Ec__DisplayClass4_0 _003C_003E8__1;

			[Token(Token = "0x40025FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x40025FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private int _003Ci_003E5__2;

			[Token(Token = "0x6001004")]
			[Address(RVA = "0x3D9B0B8", Offset = "0x3D970B8", VA = "0x3D9B0B8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001005")]
			[Address(RVA = "0x3D9BF84", Offset = "0x3D97F84", VA = "0x3D9BF84", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40025ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
		private GameObject effRes;

		[Token(Token = "0x40025EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
		private GameObject effObj;

		[Token(Token = "0x6000FF7")]
		[Address(RVA = "0x3D9AA00", Offset = "0x3D96A00", VA = "0x3D9AA00", Slot = "22")]
		[AsyncStateMachine(typeof(_003CInitSkill_003Ed__1))]
		protected override void InitSkill()
		{
		}

		[Token(Token = "0x6000FF8")]
		[Address(RVA = "0x3D9AA90", Offset = "0x3D96A90", VA = "0x3D9AA90", Slot = "31")]
		protected override void EmitSkill()
		{
		}

		[Token(Token = "0x6000FF9")]
		[Address(RVA = "0x3D9AAAC", Offset = "0x3D96AAC", VA = "0x3D9AAAC")]
		[AsyncStateMachine(typeof(_003CSkeletonWarriorSkill_003Ed__4))]
		private void SkeletonWarriorSkill()
		{
		}

		[Token(Token = "0x6000FFA")]
		[Address(RVA = "0x3D9AB3C", Offset = "0x3D96B3C", VA = "0x3D9AB3C")]
		private float Calculate(float input)
		{
			return default;
		}

		[Token(Token = "0x6000FFB")]
		[Address(RVA = "0x3D9ABBC", Offset = "0x3D96BBC", VA = "0x3D9ABBC", Slot = "39")]
		protected override void OnRecycle()
		{
		}

		[Token(Token = "0x6000FFC")]
		[Address(RVA = "0x3D9AC3C", Offset = "0x3D96C3C", VA = "0x3D9AC3C", Slot = "4")]
		public override void Wound(int damage, string id, [Optional][DefaultParameterValue(false)] bool isBuild, [Optional] EntityBase target, [Optional][DefaultParameterValue(false)] bool isLandRole, [Optional][DefaultParameterValue((AtkWayType)0)] AtkWayType atkWayType, [Optional][DefaultParameterValue((CardFettersType)4)] CardFettersType fetterType, [Optional] Object linkAttackObj)
		{
		}

		[Token(Token = "0x6000FFD")]
		[Address(RVA = "0x3D9AC5C", Offset = "0x3D96C5C", VA = "0x3D9AC5C")]
		public SkeletonWarriorBehaviour()
		{
		}
	}
}
