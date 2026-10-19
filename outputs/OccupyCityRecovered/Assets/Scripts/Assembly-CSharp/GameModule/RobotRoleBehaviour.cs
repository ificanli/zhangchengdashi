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
	[Token(Token = "0x2000361")]
	public class RobotRoleBehaviour : MachineBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000362")]
		[CompilerGenerated]
		private struct _003CRobotSkill_003Ed__7 : IAsyncStateMachine
		{
			[Token(Token = "0x40024CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40024CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40024CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public RobotRoleBehaviour _003C_003E4__this;

			[Token(Token = "0x40024CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float _003CtempAtkOffset_003E5__2;

			[Token(Token = "0x40024CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000F04")]
			[Address(RVA = "0x3D7E494", Offset = "0x3D7A494", VA = "0x3D7E494", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000F05")]
			[Address(RVA = "0x3D7EF6C", Offset = "0x3D7AF6C", VA = "0x3D7EF6C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000363")]
		[CompilerGenerated]
		private struct _003CSkillSetAnimationSpeed_003Ed__8 : IAsyncStateMachine
		{
			[Token(Token = "0x40024D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40024D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40024D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public RobotRoleBehaviour _003C_003E4__this;

			[Token(Token = "0x40024D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool isSkill;

			[Token(Token = "0x40024D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000F06")]
			[Address(RVA = "0x3D7EF78", Offset = "0x3D7AF78", VA = "0x3D7EF78", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000F07")]
			[Address(RVA = "0x3D7F76C", Offset = "0x3D7B76C", VA = "0x3D7F76C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40024C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
		private bool robotSkilling;

		[Token(Token = "0x40024C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
		private GameObject zhengQi1;

		[Token(Token = "0x40024C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
		private GameObject zhengQi2;

		[Token(Token = "0x40024C9")]
		private const string ZQ1 = "mixamorig:Hips/SmokeDarkSoft1";

		[Token(Token = "0x40024CA")]
		private const string ZQ2 = "mixamorig:Hips/SmokeDarkSoft2";

		[Token(Token = "0x6000EFE")]
		[Address(RVA = "0x3D7E154", Offset = "0x3D7A154", VA = "0x3D7E154", Slot = "20")]
		public override void Init(GlobalRoleInfo info, bool isEnemy, int cardLevel, RareLevel rareLevel, [Optional] string relativeCardID, CardFettersType fettersType = CardFettersType.Null, AtkWayType atkWayType = AtkWayType.Null)
		{
		}

		[Token(Token = "0x6000EFF")]
		[Address(RVA = "0x3D7E35C", Offset = "0x3D7A35C", VA = "0x3D7E35C", Slot = "31")]
		protected override void EmitSkill()
		{
		}

		[Token(Token = "0x6000F00")]
		[Address(RVA = "0x3D7E360", Offset = "0x3D7A360", VA = "0x3D7E360")]
		[AsyncStateMachine(typeof(_003CRobotSkill_003Ed__7))]
		private void RobotSkill()
		{
		}

		[Token(Token = "0x6000F01")]
		[Address(RVA = "0x3D7E3F0", Offset = "0x3D7A3F0", VA = "0x3D7E3F0")]
		[AsyncStateMachine(typeof(_003CSkillSetAnimationSpeed_003Ed__8))]
		private UniTask SkillSetAnimationSpeed(bool isSkill)
		{
			return default;
		}

		[Token(Token = "0x6000F02")]
		[Address(RVA = "0x3D7E270", Offset = "0x3D7A270", VA = "0x3D7E270")]
		private void SetZhengQiActive(bool active)
		{
		}

		[Token(Token = "0x6000F03")]
		[Address(RVA = "0x3D7E48C", Offset = "0x3D7A48C", VA = "0x3D7E48C")]
		public RobotRoleBehaviour()
		{
		}
	}
}
