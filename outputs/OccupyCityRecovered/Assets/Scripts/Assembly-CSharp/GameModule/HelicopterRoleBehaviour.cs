using System.Collections.Generic;
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
	[Token(Token = "0x2000337")]
	public class HelicopterRoleBehaviour : MachineBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000338")]
		[CompilerGenerated]
		private struct _003CHelicopterSkill_003Ed__8 : IAsyncStateMachine
		{
			[Token(Token = "0x40023E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40023E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40023E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public HelicopterRoleBehaviour _003C_003E4__this;

			[Token(Token = "0x40023E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float _003CskillTime_003E5__2;

			[Token(Token = "0x40023EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float _003CatkOffset_003E5__3;

			[Token(Token = "0x40023EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float _003CpTime_003E5__4;

			[Token(Token = "0x40023EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000E7C")]
			[Address(RVA = "0x3D71E7C", Offset = "0x3D6DE7C", VA = "0x3D71E7C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000E7D")]
			[Address(RVA = "0x3D726D8", Offset = "0x3D6E6D8", VA = "0x3D726D8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000339")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__5 : IAsyncStateMachine
		{
			[Token(Token = "0x40023ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40023EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40023EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public HelicopterRoleBehaviour _003C_003E4__this;

			[Token(Token = "0x40023F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public GlobalRoleInfo info;

			[Token(Token = "0x40023F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool isEnemy;

			[Token(Token = "0x40023F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public int cardLevel;

			[Token(Token = "0x40023F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public RareLevel rareLevel;

			[Token(Token = "0x40023F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public string relativeCardID;

			[Token(Token = "0x40023F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public CardFettersType fettersType;

			[Token(Token = "0x40023F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public AtkWayType atkWayType;

			[Token(Token = "0x40023F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000E7E")]
			[Address(RVA = "0x3D726E4", Offset = "0x3D6E6E4", VA = "0x3D726E4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000E7F")]
			[Address(RVA = "0x3D72A4C", Offset = "0x3D6EA4C", VA = "0x3D72A4C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200033A")]
		[CompilerGenerated]
		private struct _003CLoadSkillBulletResAsync_003Ed__6 : IAsyncStateMachine
		{
			[Token(Token = "0x40023F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40023F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40023FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool isEnemySide;

			[Token(Token = "0x40023FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public HelicopterRoleBehaviour _003C_003E4__this;

			[Token(Token = "0x40023FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000E80")]
			[Address(RVA = "0x3D72A58", Offset = "0x3D6EA58", VA = "0x3D72A58", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000E81")]
			[Address(RVA = "0x3D7300C", Offset = "0x3D6F00C", VA = "0x3D7300C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40023E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
		private bool helicopterSkilling;

		[Token(Token = "0x40023E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
		private GameObject skillBulletRes;

		[Token(Token = "0x40023E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
		private UniTask _skillBulletResLoadTask;

		[Token(Token = "0x40023E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x300")]
		private bool _skillBulletResLoaded;

		[Token(Token = "0x40023E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x308")]
		private readonly List<RoleBehaviour> skillTargets;

		[Token(Token = "0x6000E75")]
		[Address(RVA = "0x3D71AE4", Offset = "0x3D6DAE4", VA = "0x3D71AE4", Slot = "20")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__5))]
		public override void Init(GlobalRoleInfo info, bool isEnemy, int cardLevel, RareLevel rareLevel, [Optional] string relativeCardID, CardFettersType fettersType = CardFettersType.Null, AtkWayType atkWayType = AtkWayType.Null)
		{
		}

		[Token(Token = "0x6000E76")]
		[Address(RVA = "0x3D71BC8", Offset = "0x3D6DBC8", VA = "0x3D71BC8")]
		[AsyncStateMachine(typeof(_003CLoadSkillBulletResAsync_003Ed__6))]
		private UniTask LoadSkillBulletResAsync(bool isEnemySide)
		{
			return default;
		}

		[Token(Token = "0x6000E77")]
		[Address(RVA = "0x3D71C68", Offset = "0x3D6DC68", VA = "0x3D71C68", Slot = "31")]
		protected override void EmitSkill()
		{
		}

		[Token(Token = "0x6000E78")]
		[Address(RVA = "0x3D71C84", Offset = "0x3D6DC84", VA = "0x3D71C84")]
		[AsyncStateMachine(typeof(_003CHelicopterSkill_003Ed__8))]
		private void HelicopterSkill()
		{
		}

		[Token(Token = "0x6000E79")]
		[Address(RVA = "0x3D71D10", Offset = "0x3D6DD10", VA = "0x3D71D10", Slot = "30")]
		protected override void AtkCallBack(int attackNum)
		{
		}

		[Token(Token = "0x6000E7A")]
		[Address(RVA = "0x3D71DC0", Offset = "0x3D6DDC0", VA = "0x3D71DC0")]
		public HelicopterRoleBehaviour()
		{
		}
	}
}
