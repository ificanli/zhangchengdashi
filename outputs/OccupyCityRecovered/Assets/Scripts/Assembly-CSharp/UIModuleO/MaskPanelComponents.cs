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
	[Token(Token = "0x200098B")]
	public class MaskPanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200098C")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__47 : IAsyncStateMachine
		{
			[Token(Token = "0x4004776")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004777")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004778")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MaskPanelComponents _003C_003E4__this;

			[Token(Token = "0x4004779")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x600387C")]
			[Address(RVA = "0x40F5CE0", Offset = "0x40F1CE0", VA = "0x40F5CE0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600387D")]
			[Address(RVA = "0x40F5F58", Offset = "0x40F1F58", VA = "0x40F5F58", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004775")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RectTransform _rectTransformBlackBG;

		[Token(Token = "0x17000878")]
		public RectTransform RectTransformBlackBG
		{
			[Token(Token = "0x6003875")]
			[Address(RVA = "0x40F5970", Offset = "0x40F1970", VA = "0x40F5970")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003876")]
		[Address(RVA = "0x40F5CCC", Offset = "0x40F1CCC", VA = "0x40F5CCC")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6003877")]
		[Address(RVA = "0x40F5CD0", Offset = "0x40F1CD0", VA = "0x40F5CD0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6003878")]
		[Address(RVA = "0x40F5B68", Offset = "0x40F1B68", VA = "0x40F5B68", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__47))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6003879")]
		[Address(RVA = "0x40F5C00", Offset = "0x40F1C00", VA = "0x40F5C00", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x600387A")]
		[Address(RVA = "0x40F5CC4", Offset = "0x40F1CC4", VA = "0x40F5CC4")]
		public MaskPanelComponents()
		{
		}
	}
}
