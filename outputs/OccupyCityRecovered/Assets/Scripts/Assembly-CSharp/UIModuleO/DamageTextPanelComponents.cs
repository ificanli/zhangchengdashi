using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using UIFramework;
using UnityEngine;

namespace UIModuleO
{
	[Token(Token = "0x200085D")]
	public class DamageTextPanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200085E")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__44 : IAsyncStateMachine
		{
			[Token(Token = "0x4003F80")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003F81")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003F82")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public DamageTextPanelComponents _003C_003E4__this;

			[Token(Token = "0x4003F83")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6002F13")]
			[Address(RVA = "0x402A7E8", Offset = "0x40267E8", VA = "0x402A7E8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002F14")]
			[Address(RVA = "0x402AA60", Offset = "0x4026A60", VA = "0x402AA60", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003F7D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private CanvasRenderer _canvasRendererHpBG;

		[Token(Token = "0x4003F7E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private CanvasRenderer _canvasRendererHpText;

		[Token(Token = "0x4003F7F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private CanvasRenderer _canvasRendererDamageText;

		[Token(Token = "0x17000585")]
		public CanvasRenderer CanvasRendererHpBG
		{
			[Token(Token = "0x6002F0A")]
			[Address(RVA = "0x402A42C", Offset = "0x402642C", VA = "0x402A42C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000586")]
		public CanvasRenderer CanvasRendererHpText
		{
			[Token(Token = "0x6002F0B")]
			[Address(RVA = "0x402A4F4", Offset = "0x40264F4", VA = "0x402A4F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000587")]
		public CanvasRenderer CanvasRendererDamageText
		{
			[Token(Token = "0x6002F0C")]
			[Address(RVA = "0x402A5BC", Offset = "0x40265BC", VA = "0x402A5BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002F0D")]
		[Address(RVA = "0x402A684", Offset = "0x4026684", VA = "0x402A684")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6002F0E")]
		[Address(RVA = "0x402A688", Offset = "0x4026688", VA = "0x402A688", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6002F0F")]
		[Address(RVA = "0x402A690", Offset = "0x4026690", VA = "0x402A690", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__44))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6002F10")]
		[Address(RVA = "0x402A724", Offset = "0x4026724", VA = "0x402A724", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6002F11")]
		[Address(RVA = "0x402A7D8", Offset = "0x40267D8", VA = "0x402A7D8")]
		public DamageTextPanelComponents()
		{
		}
	}
}
