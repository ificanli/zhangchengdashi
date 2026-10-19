using System.Collections.Generic;
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
	[Token(Token = "0x2000352")]
	public class PandaHeroRoleBehaviour : OrcsBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000353")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__3 : IAsyncStateMachine
		{
			[Token(Token = "0x4002478")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002479")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400247A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public PandaHeroRoleBehaviour _003C_003E4__this;

			[Token(Token = "0x400247B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public GlobalRoleInfo info;

			[Token(Token = "0x400247C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool isEnemy;

			[Token(Token = "0x400247D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public int cardLevel;

			[Token(Token = "0x400247E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public RareLevel rareLevel;

			[Token(Token = "0x400247F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public string relativeCardID;

			[Token(Token = "0x4002480")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public CardFettersType fettersType;

			[Token(Token = "0x4002481")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public AtkWayType atkWayType;

			[Token(Token = "0x4002482")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000ED7")]
			[Address(RVA = "0x3D798B4", Offset = "0x3D758B4", VA = "0x3D798B4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000ED8")]
			[Address(RVA = "0x3D79CFC", Offset = "0x3D75CFC", VA = "0x3D79CFC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000354")]
		[CompilerGenerated]
		private struct _003CPandaSkill_003Ed__5 : IAsyncStateMachine
		{
			[Token(Token = "0x4002483")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002484")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002485")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public PandaHeroRoleBehaviour _003C_003E4__this;

			[Token(Token = "0x4002486")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private RoleBehaviour _003CskillTarget_003E5__2;

			[Token(Token = "0x4002487")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Tween _003CmoveTween_003E5__3;

			[Token(Token = "0x4002488")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private object _003C_003E7__wrap3;

			[Token(Token = "0x4002489")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private int _003C_003E7__wrap4;

			[Token(Token = "0x400248A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x400248B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private TaskAwaiter _003C_003Eu__2;

			[Token(Token = "0x6000ED9")]
			[Address(RVA = "0x3D79D08", Offset = "0x3D75D08", VA = "0x3D79D08", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000EDA")]
			[Address(RVA = "0x3D7AE94", Offset = "0x3D76E94", VA = "0x3D7AE94", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4002475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
		private GameObject res;

		[Token(Token = "0x4002476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x300")]
		private GameObject eff;

		[Token(Token = "0x4002477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x308")]
		private readonly List<RoleBehaviour> skillEnemyRole;

		[Token(Token = "0x6000ECE")]
		[Address(RVA = "0x3D791E0", Offset = "0x3D751E0", VA = "0x3D791E0", Slot = "20")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__3))]
		public override void Init(GlobalRoleInfo info, bool isEnemy, int cardLevel, RareLevel rareLevel, [Optional] string relativeCardID, CardFettersType fettersType = CardFettersType.Null, AtkWayType atkWayType = AtkWayType.Null)
		{
		}

		[Token(Token = "0x6000ECF")]
		[Address(RVA = "0x3D792C4", Offset = "0x3D752C4", VA = "0x3D792C4", Slot = "31")]
		protected override void EmitSkill()
		{
		}

		[Token(Token = "0x6000ED0")]
		[Address(RVA = "0x3D792CC", Offset = "0x3D752CC", VA = "0x3D792CC")]
		[AsyncStateMachine(typeof(_003CPandaSkill_003Ed__5))]
		private void PandaSkill()
		{
		}

		[Token(Token = "0x6000ED1")]
		[Address(RVA = "0x3D79360", Offset = "0x3D75360", VA = "0x3D79360")]
		private void RefundPandaSkillCooldown()
		{
		}

		[Token(Token = "0x6000ED2")]
		[Address(RVA = "0x3D79390", Offset = "0x3D75390", VA = "0x3D79390")]
		private bool TryResolvePandaSkillTarget(out RoleBehaviour skillTarget, out string failReason)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED PandaHeroRoleBehaviour.TryResolvePandaSkillTarget RVA=0x3D79390 Token=0x6000ED2");
}

		[Token(Token = "0x6000ED3")]
		[Address(RVA = "0x3D79520", Offset = "0x3D75520", VA = "0x3D79520")]
		private bool IsValidPandaSkillTarget(RoleBehaviour target)
		{
			return default;
		}

		[Token(Token = "0x6000ED4")]
		[Address(RVA = "0x3D795B8", Offset = "0x3D755B8", VA = "0x3D795B8")]
		private string GetEntityDebugText(EntityBase entity)
		{
			return null;
		}

		[Token(Token = "0x6000ED5")]
		[Address(RVA = "0x3D79828", Offset = "0x3D75828", VA = "0x3D79828")]
		public PandaHeroRoleBehaviour()
		{
		}
	}
}
