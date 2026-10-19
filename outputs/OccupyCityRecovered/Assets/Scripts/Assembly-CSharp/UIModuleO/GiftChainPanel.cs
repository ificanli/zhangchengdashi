using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DG.Tweening;
using DataModule;
using Il2CppDummyDll;
using SuperScrollView;
using TimeModuleO;

namespace UIModuleO
{
	[Token(Token = "0x20008EB")]
	public class GiftChainPanel : GiftChainPanelComponents
	{
		[Token(Token = "0x20008EF")]
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass16_0
		{
			[Token(Token = "0x4004392")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GiftChainPanel _003C_003E4__this;

			[Token(Token = "0x4004393")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GiftChainItem first;

			[Token(Token = "0x600337E")]
			[Address(RVA = "0x4099DA8", Offset = "0x4095DA8", VA = "0x4099DA8")]
			public _003C_003Ec__DisplayClass16_0()
			{
			}

			[Token(Token = "0x600337F")]
			[Address(RVA = "0x4099DB0", Offset = "0x4095DB0", VA = "0x4099DB0")]
			internal void _003CMovePanelToItemIndexComplete_003Eb__4()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20008F1")]
		[CompilerGenerated]
		private struct _003CMovePanelToItemIndexComplete_003Ed__16 : IAsyncStateMachine
		{
			[Token(Token = "0x4004395")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004396")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004397")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public GiftChainPanel _003C_003E4__this;

			[Token(Token = "0x4004398")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float duration;

			[Token(Token = "0x4004399")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private _003C_003Ec__DisplayClass16_0 _003C_003E8__1;

			[Token(Token = "0x400439A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003384")]
			[Address(RVA = "0x409A110", Offset = "0x4096110", VA = "0x409A110", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003385")]
			[Address(RVA = "0x409B244", Offset = "0x4097244", VA = "0x409B244", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20008F2")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__11 : IAsyncStateMachine
		{
			[Token(Token = "0x400439B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400439C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400439D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GiftChainPanel _003C_003E4__this;

			[Token(Token = "0x400439E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6003386")]
			[Address(RVA = "0x409B250", Offset = "0x4097250", VA = "0x409B250", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003387")]
			[Address(RVA = "0x409BDA8", Offset = "0x4097DA8", VA = "0x409BDA8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private List<GlobalGiftChainInfo> chainConfig;

		[Token(Token = "0x4004382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private LoopListView2 mLoopListView;

		[Token(Token = "0x4004383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private string preName;

		[Token(Token = "0x4004384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private string preName2;

		[Token(Token = "0x4004385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private string showChainKey;

		[Token(Token = "0x4004386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private string _placement;

		[Token(Token = "0x4004387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int buyId;

		[Token(Token = "0x4004388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private bool isSVInit;

		[Token(Token = "0x4004389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Sequence sq;

		[Token(Token = "0x400438A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private TimeManager.Timer showChainTimer;

		[Token(Token = "0x6003364")]
		[Address(RVA = "0x409825C", Offset = "0x409425C", VA = "0x409825C")]
		private void Start()
		{
		}

		[Token(Token = "0x6003365")]
		[Address(RVA = "0x4098398", Offset = "0x4094398", VA = "0x4098398", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__11))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6003366")]
		[Address(RVA = "0x409842C", Offset = "0x409442C", VA = "0x409842C")]
		public void Update()
		{
		}

		[Token(Token = "0x6003367")]
		[Address(RVA = "0x4098550", Offset = "0x4094550", VA = "0x4098550")]
		public LoopListViewItem2 OnInit(LoopListView2 view, int index)
		{
			return null;
		}

		[Token(Token = "0x6003368")]
		[Address(RVA = "0x409874C", Offset = "0x409474C", VA = "0x409874C")]
		public void GotoUnlockItemAndShowTip(object o)
		{
		}

		[Token(Token = "0x6003369")]
		[Address(RVA = "0x4098828", Offset = "0x4094828", VA = "0x4098828")]
		public void UnLockAnim(object o)
		{
		}

		[Token(Token = "0x600336A")]
		[Address(RVA = "0x4099234", Offset = "0x4095234", VA = "0x4099234")]
		[AsyncStateMachine(typeof(_003CMovePanelToItemIndexComplete_003Ed__16))]
		private void MovePanelToItemIndexComplete(float duration)
		{
		}

		[Token(Token = "0x600336B")]
		[Address(RVA = "0x40992DC", Offset = "0x40952DC", VA = "0x40992DC")]
		private void UpdateGiftChainActive(object o)
		{
		}

		[Token(Token = "0x600336C")]
		[Address(RVA = "0x40993B4", Offset = "0x40953B4", VA = "0x40993B4", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x600336D")]
		[Address(RVA = "0x4099644", Offset = "0x4095644", VA = "0x4099644", Slot = "16")]
		protected override void OnButtonExtendBtnCloseClicked()
		{
		}

		[Token(Token = "0x600336E")]
		[Address(RVA = "0x40996D0", Offset = "0x40956D0", VA = "0x40996D0", Slot = "12")]
		protected override void OnButtonExtendBtnCloseAllScreenClicked()
		{
		}

		[Token(Token = "0x600336F")]
		[Address(RVA = "0x409975C", Offset = "0x409575C", VA = "0x409975C")]
		public GiftChainPanel()
		{
		}
	}
}
