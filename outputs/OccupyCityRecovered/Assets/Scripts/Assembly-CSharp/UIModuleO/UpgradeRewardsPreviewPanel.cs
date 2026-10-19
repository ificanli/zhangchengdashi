using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using SuperScrollView;

namespace UIModuleO
{
	[Token(Token = "0x2000BE5")]
	public class UpgradeRewardsPreviewPanel : UpgradeRewardsPreviewPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000BE6")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__5 : IAsyncStateMachine
		{
			[Token(Token = "0x400564C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400564D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400564E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UpgradeRewardsPreviewPanel _003C_003E4__this;

			[Token(Token = "0x400564F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x600498B")]
			[Address(RVA = "0x424AB3C", Offset = "0x4246B3C", VA = "0x424AB3C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600498C")]
			[Address(RVA = "0x424B284", Offset = "0x4247284", VA = "0x424B284", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000BE7")]
		[CompilerGenerated]
		private struct _003CSmoothScroll_003Ed__7 : IAsyncStateMachine
		{
			[Token(Token = "0x4005650")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005651")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005652")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public UpgradeRewardsPreviewPanel _003C_003E4__this;

			[Token(Token = "0x4005653")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600498D")]
			[Address(RVA = "0x424B290", Offset = "0x4247290", VA = "0x424B290", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600498E")]
			[Address(RVA = "0x424B5F8", Offset = "0x42475F8", VA = "0x424B5F8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000BE8")]
		[CompilerGenerated]
		private struct _003CUpgradAnimeCallBack_003Ed__8 : IAsyncStateMachine
		{
			[Token(Token = "0x4005654")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005655")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005656")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public UpgradeRewardsPreviewPanel _003C_003E4__this;

			[Token(Token = "0x4005657")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600498F")]
			[Address(RVA = "0x424B604", Offset = "0x4247604", VA = "0x424B604", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004990")]
			[Address(RVA = "0x424B960", Offset = "0x4247960", VA = "0x424B960", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4005648")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int listCount;

		[Token(Token = "0x4005649")]
		private const string LoopListItemName = "UpgradeRewardsItem";

		[Token(Token = "0x400564A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private bool isInitList;

		[Token(Token = "0x400564B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
		public bool isUpgrad;

		[Token(Token = "0x600497F")]
		[Address(RVA = "0x424A23C", Offset = "0x424623C", VA = "0x424A23C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6004980")]
		[Address(RVA = "0x424A414", Offset = "0x4246414", VA = "0x424A414", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__5))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6004981")]
		[Address(RVA = "0x424A4A8", Offset = "0x42464A8", VA = "0x424A4A8", Slot = "8")]
		protected override void OnOpenAnimationComplete()
		{
		}

		[Token(Token = "0x6004982")]
		[Address(RVA = "0x424A4B0", Offset = "0x42464B0", VA = "0x424A4B0")]
		[AsyncStateMachine(typeof(_003CSmoothScroll_003Ed__7))]
		private void SmoothScroll()
		{
		}

		[Token(Token = "0x6004983")]
		[Address(RVA = "0x424A53C", Offset = "0x424653C", VA = "0x424A53C")]
		[AsyncStateMachine(typeof(_003CUpgradAnimeCallBack_003Ed__8))]
		public void UpgradAnimeCallBack()
		{
		}

		[Token(Token = "0x6004984")]
		[Address(RVA = "0x424A5C8", Offset = "0x42465C8", VA = "0x424A5C8")]
		private LoopListViewItem2 OnGetItemByIndex(LoopListView2 listView, int index)
		{
			return null;
		}

		[Token(Token = "0x6004985")]
		[Address(RVA = "0x424A774", Offset = "0x4246774", VA = "0x424A774")]
		public void RefreshList(object o)
		{
		}

		[Token(Token = "0x6004986")]
		[Address(RVA = "0x424A858", Offset = "0x4246858", VA = "0x424A858", Slot = "13")]
		protected override void OnButtonExtendCloseClicked()
		{
		}

		[Token(Token = "0x6004987")]
		[Address(RVA = "0x424A8E4", Offset = "0x42468E4", VA = "0x424A8E4", Slot = "12")]
		protected override void OnButtonBackgroundClicked()
		{
		}

		[Token(Token = "0x6004988")]
		[Address(RVA = "0x424A970", Offset = "0x4246970", VA = "0x424A970", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6004989")]
		[Address(RVA = "0x424AA94", Offset = "0x4246A94", VA = "0x424AA94")]
		public UpgradeRewardsPreviewPanel()
		{
		}
	}
}
