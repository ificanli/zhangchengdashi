using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000AC8")]
	public class RankPanel : RankPanelComponents, IPanelOnOnSecondClick
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000AC9")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__2 : IAsyncStateMachine
		{
			[Token(Token = "0x4004F3E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004F3F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004F40")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public RankPanel _003C_003E4__this;

			[Token(Token = "0x4004F41")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x4004F42")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int _003CbeginIndex_003E5__2;

			[Token(Token = "0x4004F43")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private int _003CendIndex_003E5__3;

			[Token(Token = "0x4004F44")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int _003CplayerIndex_003E5__4;

			[Token(Token = "0x4004F45")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Image _003C_003E7__wrap4;

			[Token(Token = "0x4004F46")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x4004F47")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__2;

			[Token(Token = "0x4004F48")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__3;

			[Token(Token = "0x600412F")]
			[Address(RVA = "0x41B6C40", Offset = "0x41B2C40", VA = "0x41B6C40", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004130")]
			[Address(RVA = "0x41B7DA4", Offset = "0x41B3DA4", VA = "0x41B7DA4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004F3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private readonly List<GameObject> _allRankItem;

		[Token(Token = "0x6004127")]
		[Address(RVA = "0x41B66C4", Offset = "0x41B26C4", VA = "0x41B66C4", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6004128")]
		[Address(RVA = "0x41B67C0", Offset = "0x41B27C0", VA = "0x41B67C0", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__2))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6004129")]
		[Address(RVA = "0x41B6864", Offset = "0x41B2864", VA = "0x41B6864", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x600412A")]
		[Address(RVA = "0x41B6704", Offset = "0x41B2704", VA = "0x41B6704", Slot = "13")]
		public void PanelOnOnSecondClickInit()
		{
		}

		[Token(Token = "0x600412B")]
		[Address(RVA = "0x41B6AB4", Offset = "0x41B2AB4", VA = "0x41B6AB4", Slot = "14")]
		public void OnSecondClick(object o)
		{
		}

		[Token(Token = "0x600412C")]
		[Address(RVA = "0x41B6948", Offset = "0x41B2948", VA = "0x41B6948", Slot = "15")]
		public void OnHide()
		{
		}

		[Token(Token = "0x600412D")]
		[Address(RVA = "0x41B6B24", Offset = "0x41B2B24", VA = "0x41B6B24")]
		public RankPanel()
		{
		}
	}
}
