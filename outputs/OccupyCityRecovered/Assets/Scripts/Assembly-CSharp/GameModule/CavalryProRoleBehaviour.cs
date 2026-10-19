using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace GameModule
{
	[Token(Token = "0x200031B")]
	public class CavalryProRoleBehaviour : TerranBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200031C")]
		[CompilerGenerated]
		private struct _003CCavalrySkill_003Ed__6 : IAsyncStateMachine
		{
			[Token(Token = "0x4002373")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002374")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002375")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public CavalryProRoleBehaviour _003C_003E4__this;

			[Token(Token = "0x4002376")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000E17")]
			[Address(RVA = "0x3D69B18", Offset = "0x3D65B18", VA = "0x3D69B18", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000E18")]
			[Address(RVA = "0x3D6A084", Offset = "0x3D66084", VA = "0x3D6A084", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400236F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
		[FormerlySerializedAs("_cavalrySkilling")]
		public bool CavalrySkilling;

		[Token(Token = "0x4002370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D1")]
		private bool _cavalrySprintIng;

		[Token(Token = "0x4002371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
		private GameObject _rr;

		[Token(Token = "0x4002372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
		private bool _isToPos;

		[Token(Token = "0x6000E0E")]
		[Address(RVA = "0x3D69200", Offset = "0x3D65200", VA = "0x3D69200", Slot = "31")]
		protected override void EmitSkill()
		{
		}

		[Token(Token = "0x6000E0F")]
		[Address(RVA = "0x3D692A8", Offset = "0x3D652A8", VA = "0x3D692A8", Slot = "5")]
		public override void MyUpdate()
		{
		}

		[Token(Token = "0x6000E10")]
		[Address(RVA = "0x3D6921C", Offset = "0x3D6521C", VA = "0x3D6921C")]
		[AsyncStateMachine(typeof(_003CCavalrySkill_003Ed__6))]
		private void CavalrySkill()
		{
		}

		[Token(Token = "0x6000E11")]
		[Address(RVA = "0x3D692C4", Offset = "0x3D652C4", VA = "0x3D692C4")]
		private void CavalrySkillAtk()
		{
		}

		[Token(Token = "0x6000E12")]
		[Address(RVA = "0x3D694D0", Offset = "0x3D654D0", VA = "0x3D694D0", Slot = "30")]
		protected override void AtkCallBack(int attackNum)
		{
		}

		[Token(Token = "0x6000E13")]
		[Address(RVA = "0x3D694E4", Offset = "0x3D654E4", VA = "0x3D694E4", Slot = "29")]
		protected override void Atk(int attackNum)
		{
		}

		[Token(Token = "0x6000E14")]
		[Address(RVA = "0x3D69900", Offset = "0x3D65900", VA = "0x3D69900", Slot = "28")]
		protected override void UpdateArchitectureTarget(object o)
		{
		}

		[Token(Token = "0x6000E15")]
		[Address(RVA = "0x3D69914", Offset = "0x3D65914", VA = "0x3D69914", Slot = "32")]
		protected override void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000E16")]
		[Address(RVA = "0x3D69B08", Offset = "0x3D65B08", VA = "0x3D69B08")]
		public CavalryProRoleBehaviour()
		{
		}
	}
}
