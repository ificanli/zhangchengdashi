using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using UIFramework;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x20006AA")]
	public class AnnouncementPanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20006AB")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__116 : IAsyncStateMachine
		{
			[Token(Token = "0x4003561")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003562")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003563")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public AnnouncementPanelComponents _003C_003E4__this;

			[Token(Token = "0x4003564")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x600234E")]
			[Address(RVA = "0x3F43D34", Offset = "0x3F3FD34", VA = "0x3F43D34", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600234F")]
			[Address(RVA = "0x3F43FAC", Offset = "0x3F3FFAC", VA = "0x3F43FAC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ScrollRect _scrollRectContentArea;

		[Token(Token = "0x170001FF")]
		public ScrollRect ScrollRectContentArea
		{
			[Token(Token = "0x6002344")]
			[Address(RVA = "0x3F430C8", Offset = "0x3F3F0C8", VA = "0x3F430C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002345")]
		[Address(RVA = "0x3F43B4C", Offset = "0x3F3FB4C", VA = "0x3F43B4C")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6002346")]
		[Address(RVA = "0x3F4383C", Offset = "0x3F3F83C", VA = "0x3F4383C", Slot = "12")]
		protected virtual void OnButtonMaskClicked()
		{
		}

		[Token(Token = "0x6002347")]
		[Address(RVA = "0x3F43B50", Offset = "0x3F3FB50", VA = "0x3F43B50", Slot = "13")]
		protected virtual void OnScrollRectContentAreaValueChanged(Vector2 arg)
		{
		}

		[Token(Token = "0x6002348")]
		[Address(RVA = "0x3F43C04", Offset = "0x3F3FC04", VA = "0x3F43C04", Slot = "14")]
		protected virtual void OnButtonButtonClicked()
		{
		}

		[Token(Token = "0x6002349")]
		[Address(RVA = "0x3F43C70", Offset = "0x3F3FC70", VA = "0x3F43C70", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600234A")]
		[Address(RVA = "0x3F438BC", Offset = "0x3F3F8BC", VA = "0x3F438BC", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__116))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x600234B")]
		[Address(RVA = "0x3F43C78", Offset = "0x3F3FC78", VA = "0x3F43C78", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x600234C")]
		[Address(RVA = "0x3F438B0", Offset = "0x3F3F8B0", VA = "0x3F438B0")]
		public AnnouncementPanelComponents()
		{
		}
	}
}
