using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x200038D")]
	public class SniperRoleBehaviour : TerranBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200038E")]
		[CompilerGenerated]
		private struct _003CInitSkill_003Ed__3 : IAsyncStateMachine
		{
			[Token(Token = "0x40025FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002600")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002601")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public SniperRoleBehaviour _003C_003E4__this;

			[Token(Token = "0x4002602")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600100D")]
			[Address(RVA = "0x3D9C2D0", Offset = "0x3D982D0", VA = "0x3D9C2D0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600100E")]
			[Address(RVA = "0x3D9C5E0", Offset = "0x3D985E0", VA = "0x3D9C5E0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40025FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
		private bool emitSkiing;

		[Token(Token = "0x40025FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
		private GameObject bulletPro;

		[Token(Token = "0x6001006")]
		[Address(RVA = "0x3D9BF90", Offset = "0x3D97F90", VA = "0x3D9BF90", Slot = "31")]
		protected override void EmitSkill()
		{
		}

		[Token(Token = "0x6001007")]
		[Address(RVA = "0x3D9C104", Offset = "0x3D98104", VA = "0x3D9C104", Slot = "22")]
		[AsyncStateMachine(typeof(_003CInitSkill_003Ed__3))]
		protected override void InitSkill()
		{
		}

		[Token(Token = "0x6001008")]
		[Address(RVA = "0x3D9BFAC", Offset = "0x3D97FAC", VA = "0x3D9BFAC")]
		private void SniperSkill()
		{
		}

		[Token(Token = "0x6001009")]
		[Address(RVA = "0x3D9C194", Offset = "0x3D98194", VA = "0x3D9C194", Slot = "30")]
		protected override void AtkCallBack(int attackNum)
		{
		}

		[Token(Token = "0x600100A")]
		[Address(RVA = "0x3D9C2AC", Offset = "0x3D982AC", VA = "0x3D9C2AC", Slot = "35")]
		protected override void RemoteAtkCallBackLogic(int attack, [Optional] GameObject bulletRes)
		{
		}

		[Token(Token = "0x600100B")]
		[Address(RVA = "0x3D9C2C0", Offset = "0x3D982C0", VA = "0x3D9C2C0")]
		public SniperRoleBehaviour()
		{
		}
	}
}
