using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CommonGameModule.AnnouncementModule;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x20006A8")]
	public class AnnouncementPanel : AnnouncementPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20006A9")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__10 : IAsyncStateMachine
		{
			[Token(Token = "0x400355C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400355D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400355E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public AnnouncementPanel _003C_003E4__this;

			[Token(Token = "0x400355F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6002342")]
			[Address(RVA = "0x3F43950", Offset = "0x3F3F950", VA = "0x3F43950", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002343")]
			[Address(RVA = "0x3F43B40", Offset = "0x3F3FB40", VA = "0x3F43B40", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public GameObject noticePrefab;

		[Token(Token = "0x4003557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Button ButtonClose;

		[Token(Token = "0x4003558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public RectTransform NoticeContent;

		[Token(Token = "0x4003559")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public TextMeshProUGUI TextTitle;

		[Token(Token = "0x400355A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public TextMeshProUGUI TextContent;

		[Token(Token = "0x400355B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public ToggleGroup NoticeToggleGroup;

		[Token(Token = "0x600233A")]
		[Address(RVA = "0x3F43000", Offset = "0x3F3F000", VA = "0x3F43000", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600233B")]
		[Address(RVA = "0x3F43190", Offset = "0x3F3F190", VA = "0x3F43190")]
		private void RefreshUI()
		{
		}

		[Token(Token = "0x600233C")]
		[Address(RVA = "0x3F43714", Offset = "0x3F3F714", VA = "0x3F43714")]
		private void RefreshNotice(NoticeDO notice)
		{
		}

		[Token(Token = "0x600233D")]
		[Address(RVA = "0x3F43784", Offset = "0x3F3F784", VA = "0x3F43784")]
		private void OnNoticeItemClicked(NoticeDO notice)
		{
		}

		[Token(Token = "0x600233E")]
		[Address(RVA = "0x3F43788", Offset = "0x3F3F788", VA = "0x3F43788", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__10))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x600233F")]
		[Address(RVA = "0x3F4381C", Offset = "0x3F3F81C", VA = "0x3F4381C", Slot = "12")]
		protected override void OnButtonMaskClicked()
		{
		}

		[Token(Token = "0x6002340")]
		[Address(RVA = "0x3F438A8", Offset = "0x3F3F8A8", VA = "0x3F438A8")]
		public AnnouncementPanel()
		{
		}
	}
}
