using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x20008D7")]
	public class GetNewCardPanel : GetNewCardPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20008D8")]
		[CompilerGenerated]
		private struct _003CAwake_003Ed__3 : IAsyncStateMachine
		{
			[Token(Token = "0x40042FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40042FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40042FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public GetNewCardPanel _003C_003E4__this;

			[Token(Token = "0x60032D8")]
			[Address(RVA = "0x40766E0", Offset = "0x40726E0", VA = "0x40766E0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60032D9")]
			[Address(RVA = "0x40767AC", Offset = "0x40727AC", VA = "0x40767AC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20008D9")]
		[CompilerGenerated]
		private struct _003COnButtonBGClicked_003Ed__10 : IAsyncStateMachine
		{
			[Token(Token = "0x40042FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004300")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004301")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public GetNewCardPanel _003C_003E4__this;

			[Token(Token = "0x60032DA")]
			[Address(RVA = "0x40767B8", Offset = "0x40727B8", VA = "0x40767B8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60032DB")]
			[Address(RVA = "0x40769E8", Offset = "0x40729E8", VA = "0x40769E8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20008DA")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__8 : IAsyncStateMachine
		{
			[Token(Token = "0x4004302")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004303")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004304")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GetNewCardPanel _003C_003E4__this;

			[Token(Token = "0x4004305")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x4004306")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UserHeroCardData _003Cdata_003E5__2;

			[Token(Token = "0x4004307")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private GlobalHeroCardInfo _003Cinfo_003E5__3;

			[Token(Token = "0x4004308")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Image _003C_003E7__wrap3;

			[Token(Token = "0x4004309")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x400430A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__2;

			[Token(Token = "0x400430B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private UniTask.Awaiter _003C_003Eu__3;

			[Token(Token = "0x60032DC")]
			[Address(RVA = "0x40769F4", Offset = "0x40729F4", VA = "0x40769F4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60032DD")]
			[Address(RVA = "0x4079EDC", Offset = "0x4075EDC", VA = "0x4079EDC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40042F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool _canHide;

		[Token(Token = "0x40042F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private GameObject _res;

		[Token(Token = "0x40042F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private readonly List<GameObject> _objList;

		[Token(Token = "0x40042F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private GameObject green;

		[Token(Token = "0x40042F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private GameObject blue;

		[Token(Token = "0x40042FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private GameObject violet;

		[Token(Token = "0x40042FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private GameObject gold;

		[Token(Token = "0x60032CD")]
		[Address(RVA = "0x407626C", Offset = "0x407226C", VA = "0x407626C", Slot = "4")]
		[AsyncStateMachine(typeof(_003CAwake_003Ed__3))]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60032CE")]
		[Address(RVA = "0x40762F8", Offset = "0x40722F8", VA = "0x40762F8", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__8))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60032CF")]
		[Address(RVA = "0x4076398", Offset = "0x4072398", VA = "0x4076398", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x60032D0")]
		[Address(RVA = "0x40763B4", Offset = "0x40723B4", VA = "0x40763B4", Slot = "12")]
		[AsyncStateMachine(typeof(_003COnButtonBGClicked_003Ed__10))]
		protected override void OnButtonBGClicked()
		{
		}

		[Token(Token = "0x60032D1")]
		[Address(RVA = "0x4076440", Offset = "0x4072440", VA = "0x4076440")]
		public GetNewCardPanel()
		{
		}
	}
}
