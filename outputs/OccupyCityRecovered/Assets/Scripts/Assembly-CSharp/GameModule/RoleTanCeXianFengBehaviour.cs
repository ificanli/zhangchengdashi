using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using Il2CppDummyDll;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x200037C")]
	public class RoleTanCeXianFengBehaviour : MachineBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200037D")]
		[CompilerGenerated]
		private struct _003CTriggerScoutSkill_003Ed__6 : IAsyncStateMachine
		{
			[Token(Token = "0x40025B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40025B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40025BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RoleTanCeXianFengBehaviour _003C_003E4__this;

			[Token(Token = "0x40025BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private TaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x6000FD7")]
			[Address(RVA = "0x3D96954", Offset = "0x3D92954", VA = "0x3D96954", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000FD8")]
			[Address(RVA = "0x3D973EC", Offset = "0x3D933EC", VA = "0x3D973EC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40025B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
		private bool triggerSkill;

		[Token(Token = "0x40025B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E4")]
		private int skillThreshold;

		[Token(Token = "0x40025B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
		private bool skillingInProgress;

		[Token(Token = "0x6000FD1")]
		[Address(RVA = "0x3D966C4", Offset = "0x3D926C4", VA = "0x3D966C4", Slot = "20")]
		public override void Init(GlobalRoleInfo info, bool isEnemy, int cardLevel, RareLevel rareLevel, [Optional] string relativeCardID, CardFettersType fettersType = CardFettersType.Null, AtkWayType atkWayType = AtkWayType.Null)
		{
		}

		[Token(Token = "0x6000FD2")]
		[Address(RVA = "0x3D96818", Offset = "0x3D92818", VA = "0x3D96818", Slot = "4")]
		public override void Wound(int damage, string id, [Optional][DefaultParameterValue(false)] bool isBuild, [Optional] EntityBase target, [Optional][DefaultParameterValue(false)] bool isLandRole, [Optional][DefaultParameterValue((AtkWayType)0)] AtkWayType atkWayType, [Optional][DefaultParameterValue((CardFettersType)4)] CardFettersType fetterType, [Optional] Object linkAttackObj)
		{
		}

		[Token(Token = "0x6000FD3")]
		[Address(RVA = "0x3D966F4", Offset = "0x3D926F4", VA = "0x3D966F4")]
		private void RefreshSkillThreshold()
		{
		}

		[Token(Token = "0x6000FD4")]
		[Address(RVA = "0x3D968B4", Offset = "0x3D928B4", VA = "0x3D968B4")]
		[AsyncStateMachine(typeof(_003CTriggerScoutSkill_003Ed__6))]
		private UniTaskVoid TriggerScoutSkill()
		{
			return default;
		}

		[Token(Token = "0x6000FD5")]
		[Address(RVA = "0x3D96928", Offset = "0x3D92928", VA = "0x3D96928", Slot = "39")]
		protected override void OnRecycle()
		{
		}

		[Token(Token = "0x6000FD6")]
		[Address(RVA = "0x3D9694C", Offset = "0x3D9294C", VA = "0x3D9694C")]
		public RoleTanCeXianFengBehaviour()
		{
		}
	}
}
