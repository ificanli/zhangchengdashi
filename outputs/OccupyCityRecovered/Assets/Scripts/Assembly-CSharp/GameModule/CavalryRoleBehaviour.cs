using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x200031D")]
	public class CavalryRoleBehaviour : TerranBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200031E")]
		[CompilerGenerated]
		private struct _003CInitSkill_003Ed__6 : IAsyncStateMachine
		{
			[Token(Token = "0x400237D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400237E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400237F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public CavalryRoleBehaviour _003C_003E4__this;

			[Token(Token = "0x4002380")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000E26")]
			[Address(RVA = "0x3D6AE00", Offset = "0x3D66E00", VA = "0x3D6AE00", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000E27")]
			[Address(RVA = "0x3D6B2D8", Offset = "0x3D672D8", VA = "0x3D6B2D8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4002377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
		private GameObject sprintTar;

		[Token(Token = "0x4002378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
		private GameObject eff;

		[Token(Token = "0x4002379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
		private GameObject effRes;

		[Token(Token = "0x400237A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
		private GameObject effHeadRes;

		[Token(Token = "0x400237B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
		private GameObject effHead;

		[Token(Token = "0x400237C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
		private EntityBase target;

		[Token(Token = "0x6000E19")]
		[Address(RVA = "0x3D6A090", Offset = "0x3D66090", VA = "0x3D6A090", Slot = "22")]
		[AsyncStateMachine(typeof(_003CInitSkill_003Ed__6))]
		protected override void InitSkill()
		{
		}

		[Token(Token = "0x6000E1A")]
		[Address(RVA = "0x3D6A120", Offset = "0x3D66120", VA = "0x3D6A120", Slot = "31")]
		protected override void EmitSkill()
		{
		}

		[Token(Token = "0x6000E1B")]
		[Address(RVA = "0x3D6A72C", Offset = "0x3D6672C", VA = "0x3D6A72C", Slot = "28")]
		protected override void UpdateArchitectureTarget(object o)
		{
		}

		[Token(Token = "0x6000E1C")]
		[Address(RVA = "0x3D6A13C", Offset = "0x3D6613C", VA = "0x3D6A13C")]
		private void CavalrySkill()
		{
		}

		[Token(Token = "0x6000E1D")]
		[Address(RVA = "0x3D6A9FC", Offset = "0x3D669FC", VA = "0x3D6A9FC", Slot = "39")]
		protected override void OnRecycle()
		{
		}

		[Token(Token = "0x6000E1E")]
		[Address(RVA = "0x3D6AA88", Offset = "0x3D66A88", VA = "0x3D6AA88", Slot = "5")]
		public override void MyUpdate()
		{
		}

		[Token(Token = "0x6000E1F")]
		[Address(RVA = "0x3D6AA90", Offset = "0x3D66A90", VA = "0x3D6AA90", Slot = "30")]
		protected override void AtkCallBack(int attackNum)
		{
		}

		[Token(Token = "0x6000E20")]
		[Address(RVA = "0x3D6AAA4", Offset = "0x3D66AA4", VA = "0x3D6AAA4", Slot = "29")]
		protected override void Atk(int attackNum)
		{
		}

		[Token(Token = "0x6000E21")]
		[Address(RVA = "0x3D6A740", Offset = "0x3D66740", VA = "0x3D6A740")]
		private Vector3 ClampPositionToMapBounds(Vector3 targetPos)
		{
			return default;
		}

		[Token(Token = "0x6000E22")]
		[Address(RVA = "0x3D6AAB8", Offset = "0x3D66AB8", VA = "0x3D6AAB8", Slot = "32")]
		protected override void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000E23")]
		[Address(RVA = "0x3D6ACAC", Offset = "0x3D66CAC", VA = "0x3D6ACAC")]
		public CavalryRoleBehaviour()
		{
		}
	}
}
