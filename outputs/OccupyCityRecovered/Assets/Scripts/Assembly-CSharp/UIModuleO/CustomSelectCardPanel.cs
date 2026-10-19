using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using GameModule;
using Il2CppDummyDll;
using UnityEngine;

namespace UIModuleO
{
	[Token(Token = "0x2000850")]
	public class CustomSelectCardPanel : CustomSelectCardPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000851")]
		[CompilerGenerated]
		private struct _003CAwake_003Ed__3 : IAsyncStateMachine
		{
			[Token(Token = "0x4003F3B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003F3C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003F3D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public CustomSelectCardPanel _003C_003E4__this;

			[Token(Token = "0x4003F3E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002ECD")]
			[Address(RVA = "0x4025A80", Offset = "0x4021A80", VA = "0x4025A80", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002ECE")]
			[Address(RVA = "0x4025EF8", Offset = "0x4021EF8", VA = "0x4025EF8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000852")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__4 : IAsyncStateMachine
		{
			[Token(Token = "0x4003F3F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003F40")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003F41")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public CustomSelectCardPanel _003C_003E4__this;

			[Token(Token = "0x4003F42")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6002ECF")]
			[Address(RVA = "0x4025F04", Offset = "0x4021F04", VA = "0x4025F04", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002ED0")]
			[Address(RVA = "0x4026F94", Offset = "0x4022F94", VA = "0x4026F94", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003F38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private GameObject res;

		[Token(Token = "0x4003F39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private RareLevel nowCustomSelectCardType;

		[Token(Token = "0x4003F3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private List<GameObject> allCard;

		[Token(Token = "0x6002EC4")]
		[Address(RVA = "0x40253F0", Offset = "0x40213F0", VA = "0x40253F0", Slot = "4")]
		[AsyncStateMachine(typeof(_003CAwake_003Ed__3))]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6002EC5")]
		[Address(RVA = "0x4025480", Offset = "0x4021480", VA = "0x4025480", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__4))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6002EC6")]
		[Address(RVA = "0x4025514", Offset = "0x4021514", VA = "0x4025514", Slot = "12")]
		protected override void OnButtonExtendBGClicked()
		{
		}

		[Token(Token = "0x6002EC7")]
		[Address(RVA = "0x40255A0", Offset = "0x40215A0", VA = "0x40255A0")]
		private void HidePanel(object o)
		{
		}

		[Token(Token = "0x6002EC8")]
		[Address(RVA = "0x40255AC", Offset = "0x40215AC", VA = "0x40255AC", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6002EC9")]
		[Address(RVA = "0x4025774", Offset = "0x4021774", VA = "0x4025774")]
		public CustomSelectCardPanel()
		{
		}
	}
}
