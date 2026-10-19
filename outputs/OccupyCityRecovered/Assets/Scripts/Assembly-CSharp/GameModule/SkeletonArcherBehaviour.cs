using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x2000381")]
	public class SkeletonArcherBehaviour : UndeadBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000382")]
		[CompilerGenerated]
		private struct _003CAtkCallBack_003Ed__3 : IAsyncStateMachine
		{
			[Token(Token = "0x40025D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40025D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40025D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public SkeletonArcherBehaviour _003C_003E4__this;

			[Token(Token = "0x40025D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int attackNum;

			[Token(Token = "0x40025D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private int _003Ci_003E5__2;

			[Token(Token = "0x40025D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000FE8")]
			[Address(RVA = "0x3D98A64", Offset = "0x3D94A64", VA = "0x3D98A64", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000FE9")]
			[Address(RVA = "0x3D98FD8", Offset = "0x3D94FD8", VA = "0x3D98FD8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000383")]
		[CompilerGenerated]
		private struct _003CSkeleArcherSkill_003Ed__2 : IAsyncStateMachine
		{
			[Token(Token = "0x40025D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40025D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40025D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public SkeletonArcherBehaviour _003C_003E4__this;

			[Token(Token = "0x40025D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private List<float>.Enumerator _003C_003E7__wrap1;

			[Token(Token = "0x40025DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000FEA")]
			[Address(RVA = "0x3D98FE4", Offset = "0x3D94FE4", VA = "0x3D98FE4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000FEB")]
			[Address(RVA = "0x3D9979C", Offset = "0x3D9579C", VA = "0x3D9979C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40025CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
		private EntityBase skillTarget;

		[Token(Token = "0x6000FE3")]
		[Address(RVA = "0x3D98834", Offset = "0x3D94834", VA = "0x3D98834", Slot = "31")]
		protected override void EmitSkill()
		{
		}

		[Token(Token = "0x6000FE4")]
		[Address(RVA = "0x3D98850", Offset = "0x3D94850", VA = "0x3D98850")]
		[AsyncStateMachine(typeof(_003CSkeleArcherSkill_003Ed__2))]
		private void SkeleArcherSkill()
		{
		}

		[Token(Token = "0x6000FE5")]
		[Address(RVA = "0x3D988E4", Offset = "0x3D948E4", VA = "0x3D988E4", Slot = "30")]
		[AsyncStateMachine(typeof(_003CAtkCallBack_003Ed__3))]
		protected override void AtkCallBack(int attackNum)
		{
		}

		[Token(Token = "0x6000FE6")]
		[Address(RVA = "0x3D98984", Offset = "0x3D94984", VA = "0x3D98984")]
		public SkeletonArcherBehaviour()
		{
		}
	}
}
