using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x20002CA")]
	public class GodSlayerProp : PropBase
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002CB")]
		[CompilerGenerated]
		private struct _003CUse_003Ed__2 : IAsyncStateMachine
		{
			[Token(Token = "0x4002213")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002214")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002215")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public GodSlayerProp _003C_003E4__this;

			[Token(Token = "0x4002216")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool isEnemy;

			[Token(Token = "0x4002217")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public List<RoleBehaviour> target;

			[Token(Token = "0x4002218")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask<UnityEngine.GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000CA2")]
			[Address(RVA = "0x3D44878", Offset = "0x3D40878", VA = "0x3D44878", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000CA3")]
			[Address(RVA = "0x3D457A4", Offset = "0x3D417A4", VA = "0x3D457A4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4002212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<RoleBehaviour> allGoldRoleList;

		[Token(Token = "0x6000CA0")]
		[Address(RVA = "0x3D44744", Offset = "0x3D40744", VA = "0x3D44744")]
		public GodSlayerProp(string id)
		{
		}

		[Token(Token = "0x6000CA1")]
		[Address(RVA = "0x3D447C8", Offset = "0x3D407C8", VA = "0x3D447C8", Slot = "4")]
		[AsyncStateMachine(typeof(_003CUse_003Ed__2))]
		public override void Use(bool isEnemy, List<RoleBehaviour> target)
		{
		}
	}
}
