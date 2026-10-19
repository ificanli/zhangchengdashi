using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x200026D")]
	public class BombBehaviour : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200026E")]
		[CompilerGenerated]
		private struct _003CBomb_003Ed__11 : IAsyncStateMachine
		{
			[Token(Token = "0x4001F3F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001F40")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001F41")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public BombBehaviour _003C_003E4__this;

			[Token(Token = "0x4001F42")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000A99")]
			[Address(RVA = "0x4389B10", Offset = "0x4385B10", VA = "0x4389B10", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000A9A")]
			[Address(RVA = "0x438A220", Offset = "0x4386220", VA = "0x438A220", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4001F35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int damage;

		[Token(Token = "0x4001F36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string roleId;

		[Token(Token = "0x4001F37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool isBuild;

		[Token(Token = "0x4001F38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private EntityBase source;

		[Token(Token = "0x4001F39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool isLandRole;

		[Token(Token = "0x4001F3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private AtkWayType atkWayType;

		[Token(Token = "0x4001F3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private CardFettersType fetterType;

		[Token(Token = "0x4001F3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float delayTime;

		[Token(Token = "0x4001F3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool isEnemy;

		[Token(Token = "0x4001F3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private readonly List<RoleBehaviour> targets;

		[Token(Token = "0x6000A94")]
		[Address(RVA = "0x43896B4", Offset = "0x43856B4", VA = "0x43896B4")]
		public void Init(bool isEnemy, int damage, string roleId, bool isBuild, EntityBase source, bool isLandRole, AtkWayType atkWayType, CardFettersType fetterType, float delayTime)
		{
		}

		[Token(Token = "0x6000A95")]
		[Address(RVA = "0x4389840", Offset = "0x4385840", VA = "0x4389840")]
		[AsyncStateMachine(typeof(_003CBomb_003Ed__11))]
		private void Bomb()
		{
		}

		[Token(Token = "0x6000A96")]
		[Address(RVA = "0x43898CC", Offset = "0x43858CC", VA = "0x43898CC")]
		private void GameEnd(object o)
		{
		}

		[Token(Token = "0x6000A97")]
		[Address(RVA = "0x4389938", Offset = "0x4385938", VA = "0x4389938")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000A98")]
		[Address(RVA = "0x4389A90", Offset = "0x4385A90", VA = "0x4389A90")]
		public BombBehaviour()
		{
		}
	}
}
