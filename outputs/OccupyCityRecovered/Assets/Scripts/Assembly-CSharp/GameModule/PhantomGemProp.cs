using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x20002DF")]
	public class PhantomGemProp : PropBase
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002E0")]
		[CompilerGenerated]
		private struct _003CUse_003Ed__1 : IAsyncStateMachine
		{
			[Token(Token = "0x400227B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400227C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400227D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool isEnemy;

			[Token(Token = "0x400227E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public PhantomGemProp _003C_003E4__this;

			[Token(Token = "0x400227F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private List<RoleBehaviour> _003CallRoles_003E5__2;

			[Token(Token = "0x4002280")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private float _003CatkPct_003E5__3;

			[Token(Token = "0x4002281")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float _003ChpPct_003E5__4;

			[Token(Token = "0x4002282")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Dictionary<string, GameObject> _003CprefabCache_003E5__5;

			[Token(Token = "0x4002283")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private int _003Ci_003E5__6;

			[Token(Token = "0x4002284")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private RoleBehaviour _003Csrc_003E5__7;

			[Token(Token = "0x4002285")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private string _003CroleId_003E5__8;

			[Token(Token = "0x4002286")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000CE4")]
			[Address(RVA = "0x3D4D348", Offset = "0x3D49348", VA = "0x3D4D348", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000CE5")]
			[Address(RVA = "0x3D4E018", Offset = "0x3D4A018", VA = "0x3D4E018", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x6000CE2")]
		[Address(RVA = "0x3D4D298", Offset = "0x3D49298", VA = "0x3D4D298")]
		public PhantomGemProp(string id)
		{
		}

		[Token(Token = "0x6000CE3")]
		[Address(RVA = "0x3D4D2A0", Offset = "0x3D492A0", VA = "0x3D4D2A0", Slot = "4")]
		[AsyncStateMachine(typeof(_003CUse_003Ed__1))]
		public override void Use(bool isEnemy, List<RoleBehaviour> target)
		{
		}
	}
}
