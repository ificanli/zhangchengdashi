using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using UIModuleO;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x200023E")]
	public abstract class EntityBase : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200023F")]
		[CompilerGenerated]
		private struct _003CFindTarget_003Ed__8 : IAsyncStateMachine
		{
			[Token(Token = "0x4001E34")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001E35")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001E36")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public EntityBase _003C_003E4__this;

			[Token(Token = "0x60009A5")]
			[Address(RVA = "0x4294A58", Offset = "0x4290A58", VA = "0x4294A58", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60009A6")]
			[Address(RVA = "0x4294C30", Offset = "0x4290C30", VA = "0x4294C30", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4001E2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool isEnemy;

		[Token(Token = "0x4001E30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool isDead;

		[Token(Token = "0x4001E31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public HpBarUI hpBarUI;

		[Token(Token = "0x4001E32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float frontWoundTime;

		[Token(Token = "0x4001E33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		protected bool findTargeting;

		[Token(Token = "0x60009A0")]
		public abstract void Wound(int damage, string id, [Optional][DefaultParameterValue(false)] bool isBuild, [Optional] EntityBase target, [Optional][DefaultParameterValue(false)] bool isLandRole, [Optional][DefaultParameterValue((AtkWayType)0)] AtkWayType atkWayType, [Optional][DefaultParameterValue((CardFettersType)4)] CardFettersType fetterType, [Optional] Object linkAttackObj);

		[Token(Token = "0x60009A1")]
		[Address(RVA = "0x4294838", Offset = "0x4290838", VA = "0x4294838")]
		protected void RemoveHpUI()
		{
		}

		[Token(Token = "0x60009A2")]
		[Address(RVA = "0x4294930", Offset = "0x4290930", VA = "0x4294930", Slot = "5")]
		public virtual void MyUpdate()
		{
		}

		[Token(Token = "0x60009A3")]
		[Address(RVA = "0x42949CC", Offset = "0x42909CC", VA = "0x42949CC", Slot = "6")]
		[AsyncStateMachine(typeof(_003CFindTarget_003Ed__8))]
		protected virtual UniTask FindTarget(float range)
		{
			return default;
		}

		[Token(Token = "0x60009A4")]
		[Address(RVA = "0x4294A50", Offset = "0x4290A50", VA = "0x4294A50")]
		protected EntityBase()
		{
		}
	}
}
