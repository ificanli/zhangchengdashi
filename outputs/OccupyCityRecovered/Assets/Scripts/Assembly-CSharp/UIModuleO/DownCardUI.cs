using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using GameModule;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000862")]
	public class DownCardUI : DownCardUIComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000865")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__4 : IAsyncStateMachine
		{
			[Token(Token = "0x4003F97")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003F98")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003F99")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public DownCardUI _003C_003E4__this;

			[Token(Token = "0x4003F9A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Vector2 position;

			[Token(Token = "0x4003F9B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public RareLevel rareLevel;

			[Token(Token = "0x4003F9C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string id;

			[Token(Token = "0x4003F9D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Image _003C_003E7__wrap1;

			[Token(Token = "0x4003F9E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002F2C")]
			[Address(RVA = "0x402BA5C", Offset = "0x4027A5C", VA = "0x402BA5C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002F2D")]
			[Address(RVA = "0x402CA6C", Offset = "0x4028A6C", VA = "0x402CA6C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000866")]
		[CompilerGenerated]
		private struct _003CUpdate_003Ed__5 : IAsyncStateMachine
		{
			[Token(Token = "0x4003F9F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003FA0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003FA1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public DownCardUI _003C_003E4__this;

			[Token(Token = "0x6002F2E")]
			[Address(RVA = "0x402CA78", Offset = "0x4028A78", VA = "0x402CA78", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002F2F")]
			[Address(RVA = "0x402CC18", Offset = "0x4028C18", VA = "0x402CC18", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003F8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private CanvasGroup _canvasGroup;

		[Token(Token = "0x4003F8D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float _alpha;

		[Token(Token = "0x4003F8E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private bool _canDisappear;

		[Token(Token = "0x6002F23")]
		[Address(RVA = "0x402B3B4", Offset = "0x40273B4", VA = "0x402B3B4", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6002F24")]
		[Address(RVA = "0x402B418", Offset = "0x4027418", VA = "0x402B418")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__4))]
		public void Init(RareLevel rareLevel, string id, Vector2 position)
		{
		}

		[Token(Token = "0x6002F25")]
		[Address(RVA = "0x402B4D8", Offset = "0x40274D8", VA = "0x402B4D8")]
		[AsyncStateMachine(typeof(_003CUpdate_003Ed__5))]
		private void Update()
		{
		}

		[Token(Token = "0x6002F26")]
		[Address(RVA = "0x402B564", Offset = "0x4027564", VA = "0x402B564")]
		public DownCardUI()
		{
		}
	}
}
