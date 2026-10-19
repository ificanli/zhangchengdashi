using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using SuperScrollView;
using UIFramework;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x200081F")]
	public class BackpackViewComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000820")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__39 : IAsyncStateMachine
		{
			[Token(Token = "0x4003E0A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003E0B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003E0C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BackpackViewComponents _003C_003E4__this;

			[Token(Token = "0x4003E0D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6002D5F")]
			[Address(RVA = "0x400D2D8", Offset = "0x40092D8", VA = "0x400D2D8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002D60")]
			[Address(RVA = "0x400D550", Offset = "0x4009550", VA = "0x400D550", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003E08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ScrollRect _scrollRectBackPackScrollView;

		[Token(Token = "0x4003E09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private LoopGridView _loopGridViewBackPackScrollView;

		[Token(Token = "0x1700051D")]
		public ScrollRect ScrollRectBackPackScrollView
		{
			[Token(Token = "0x6002D56")]
			[Address(RVA = "0x400CA88", Offset = "0x4008A88", VA = "0x400CA88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700051E")]
		public LoopGridView LoopGridViewBackPackScrollView
		{
			[Token(Token = "0x6002D57")]
			[Address(RVA = "0x400C9C0", Offset = "0x40089C0", VA = "0x400C9C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002D58")]
		[Address(RVA = "0x400D180", Offset = "0x4009180", VA = "0x400D180")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6002D59")]
		[Address(RVA = "0x400D21C", Offset = "0x400921C", VA = "0x400D21C", Slot = "12")]
		protected virtual void OnScrollRectBackPackScrollViewValueChanged(Vector2 arg)
		{
		}

		[Token(Token = "0x6002D5A")]
		[Address(RVA = "0x400C6A0", Offset = "0x40086A0", VA = "0x400C6A0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6002D5B")]
		[Address(RVA = "0x400CCD0", Offset = "0x4008CD0", VA = "0x400CCD0", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__39))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6002D5C")]
		[Address(RVA = "0x400C75C", Offset = "0x400875C", VA = "0x400C75C", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6002D5D")]
		[Address(RVA = "0x400CCC4", Offset = "0x4008CC4", VA = "0x400CCC4")]
		public BackpackViewComponents()
		{
		}
	}
}
