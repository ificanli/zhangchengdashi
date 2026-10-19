using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x20002D2")]
	public class HealToItemProp : PropBase
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002D3")]
		[CompilerGenerated]
		private struct _003CUse_003Ed__3 : IAsyncStateMachine
		{
			[Token(Token = "0x4002241")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002242")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002243")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public HealToItemProp _003C_003E4__this;

			[Token(Token = "0x4002244")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool isEnemy;

			[Token(Token = "0x4002245")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public Vector3? releasePos;

			[Token(Token = "0x4002246")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x4002247")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private UniTask.Awaiter _003C_003Eu__2;

			[Token(Token = "0x6000CC6")]
			[Address(RVA = "0x3D47710", Offset = "0x3D43710", VA = "0x3D47710", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000CC7")]
			[Address(RVA = "0x3D483A4", Offset = "0x3D443A4", VA = "0x3D483A4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4002240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private GameObject obj;

		[Token(Token = "0x6000CC2")]
		[Address(RVA = "0x3D47580", Offset = "0x3D43580", VA = "0x3D47580")]
		public HealToItemProp(string id)
		{
		}

		[Token(Token = "0x6000CC3")]
		[Address(RVA = "0x3D47588", Offset = "0x3D43588", VA = "0x3D47588", Slot = "4")]
		public override void Use(bool isEnemy, List<RoleBehaviour> target)
		{
		}

		[Token(Token = "0x6000CC4")]
		[Address(RVA = "0x3D475A0", Offset = "0x3D435A0", VA = "0x3D475A0", Slot = "5")]
		[AsyncStateMachine(typeof(_003CUse_003Ed__3))]
		public override void Use(bool isEnemy, List<RoleBehaviour> target, Vector3? releasePos)
		{
		}

		[Token(Token = "0x6000CC5")]
		[Address(RVA = "0x3D47660", Offset = "0x3D43660", VA = "0x3D47660", Slot = "6")]
		protected override void GameEnd(object o)
		{
		}
	}
}
