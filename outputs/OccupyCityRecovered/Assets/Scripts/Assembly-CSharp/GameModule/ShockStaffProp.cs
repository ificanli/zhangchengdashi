using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x20002E7")]
	public class ShockStaffProp : PropBase
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002E8")]
		[CompilerGenerated]
		private struct _003CUse_003Ed__1 : IAsyncStateMachine
		{
			[Token(Token = "0x400229B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400229C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400229D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ShockStaffProp _003C_003E4__this;

			[Token(Token = "0x400229E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool isEnemy;

			[Token(Token = "0x400229F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask<UnityEngine.GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000CFE")]
			[Address(RVA = "0x3D4F8F0", Offset = "0x3D4B8F0", VA = "0x3D4F8F0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000CFF")]
			[Address(RVA = "0x3D50474", Offset = "0x3D4C474", VA = "0x3D50474", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x6000CFC")]
		[Address(RVA = "0x3D4F844", Offset = "0x3D4B844", VA = "0x3D4F844")]
		public ShockStaffProp(string id)
		{
		}

		[Token(Token = "0x6000CFD")]
		[Address(RVA = "0x3D4F84C", Offset = "0x3D4B84C", VA = "0x3D4F84C", Slot = "4")]
		[AsyncStateMachine(typeof(_003CUse_003Ed__1))]
		public override void Use(bool isEnemy, List<RoleBehaviour> target)
		{
		}
	}
}
