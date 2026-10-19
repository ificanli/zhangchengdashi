using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x20002F6")]
	public class YggdSeedProp : PropBase
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002F7")]
		[CompilerGenerated]
		private struct _003CUse_003Ed__4 : IAsyncStateMachine
		{
			[Token(Token = "0x40022D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40022D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40022D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public YggdSeedProp _003C_003E4__this;

			[Token(Token = "0x40022D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool isEnemy;

			[Token(Token = "0x40022D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public Vector3? releasePos;

			[Token(Token = "0x40022D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private GameObject _003Ceff_003E5__2;

			[Token(Token = "0x40022DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x40022DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private UniTask.Awaiter _003C_003Eu__2;

			[Token(Token = "0x6000D3A")]
			[Address(RVA = "0x3D57900", Offset = "0x3D53900", VA = "0x3D57900", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000D3B")]
			[Address(RVA = "0x3D58760", Offset = "0x3D54760", VA = "0x3D58760", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40022D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private GameObject obj;

		[Token(Token = "0x40022D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private GameObject effObj;

		[Token(Token = "0x6000D36")]
		[Address(RVA = "0x3D57724", Offset = "0x3D53724", VA = "0x3D57724")]
		public YggdSeedProp(string id)
		{
		}

		[Token(Token = "0x6000D37")]
		[Address(RVA = "0x3D5772C", Offset = "0x3D5372C", VA = "0x3D5772C", Slot = "4")]
		public override void Use(bool isEnemy, List<RoleBehaviour> target)
		{
		}

		[Token(Token = "0x6000D38")]
		[Address(RVA = "0x3D57744", Offset = "0x3D53744", VA = "0x3D57744", Slot = "5")]
		[AsyncStateMachine(typeof(_003CUse_003Ed__4))]
		public override void Use(bool isEnemy, List<RoleBehaviour> target, Vector3? releasePos)
		{
		}

		[Token(Token = "0x6000D39")]
		[Address(RVA = "0x3D57808", Offset = "0x3D53808", VA = "0x3D57808", Slot = "6")]
		protected override void GameEnd(object o)
		{
		}
	}
}
