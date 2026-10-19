using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x20002F1")]
	public class ThornsGemProp : PropBase
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002F2")]
		[CompilerGenerated]
		private struct _003CUse_003Ed__3 : IAsyncStateMachine
		{
			[Token(Token = "0x40022C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40022C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40022C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ThornsGemProp _003C_003E4__this;

			[Token(Token = "0x40022C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool isEnemy;

			[Token(Token = "0x40022C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000D24")]
			[Address(RVA = "0x3D54944", Offset = "0x3D50944", VA = "0x3D54944", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000D25")]
			[Address(RVA = "0x3D55408", Offset = "0x3D51408", VA = "0x3D55408", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40022BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly List<ArchitectureBehaviour> _nowArchList;

		[Token(Token = "0x40022C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly List<StoneWallBehaviour> _nowWallList;

		[Token(Token = "0x6000D22")]
		[Address(RVA = "0x3D547D4", Offset = "0x3D507D4", VA = "0x3D547D4")]
		public ThornsGemProp(string id)
		{
		}

		[Token(Token = "0x6000D23")]
		[Address(RVA = "0x3D548A0", Offset = "0x3D508A0", VA = "0x3D548A0", Slot = "4")]
		[AsyncStateMachine(typeof(_003CUse_003Ed__3))]
		public override void Use(bool isEnemy, List<RoleBehaviour> target)
		{
		}
	}
}
