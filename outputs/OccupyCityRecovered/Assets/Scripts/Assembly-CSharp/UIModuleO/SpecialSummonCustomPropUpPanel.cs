using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;

namespace UIModuleO
{
	[Token(Token = "0x2000B79")]
	public class SpecialSummonCustomPropUpPanel : SpecialSummonCustomPropUpPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000B7A")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__8 : IAsyncStateMachine
		{
			[Token(Token = "0x40053A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40053AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40053AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public SpecialSummonCustomPropUpPanel _003C_003E4__this;

			[Token(Token = "0x40053AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x40053AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6004657")]
			[Address(RVA = "0x4214340", Offset = "0x4210340", VA = "0x4214340", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004658")]
			[Address(RVA = "0x4214850", Offset = "0x4210850", VA = "0x4214850", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40053A2")]
		private const string TipNoChangeNeeded = "请选择除当期神器以外的神器";

		[Token(Token = "0x40053A3")]
		private const string TipInvalidSelection = "请选择要替换的神器";

		[Token(Token = "0x40053A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private readonly List<SpecialSummonCustomPropItem> _items;

		[Token(Token = "0x40053A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private SpecialSummonPanel _summonPanel;

		[Token(Token = "0x40053A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private int _displayOrderId;

		[Token(Token = "0x40053A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private int _pendingOrderId;

		[Token(Token = "0x40053A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private bool _listBuilt;

		[Token(Token = "0x6004643")]
		[Address(RVA = "0x42130C4", Offset = "0x420F0C4", VA = "0x42130C4", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6004644")]
		[Address(RVA = "0x42135F8", Offset = "0x420F5F8", VA = "0x42135F8", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__8))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6004645")]
		[Address(RVA = "0x4213694", Offset = "0x420F694", VA = "0x4213694", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6004646")]
		[Address(RVA = "0x4213760", Offset = "0x420F760", VA = "0x4213760", Slot = "12")]
		protected override void OnButtonExtendBGClicked()
		{
		}

		[Token(Token = "0x6004647")]
		[Address(RVA = "0x421376C", Offset = "0x420F76C", VA = "0x421376C", Slot = "13")]
		protected override void OnButtonExtendCloseBtnClicked()
		{
		}

		[Token(Token = "0x6004648")]
		[Address(RVA = "0x4213778", Offset = "0x420F778", VA = "0x4213778", Slot = "14")]
		protected override void OnButtonExtendChangeBtnClicked()
		{
		}

		[Token(Token = "0x6004649")]
		[Address(RVA = "0x42139E4", Offset = "0x420F9E4", VA = "0x42139E4", Slot = "15")]
		protected override void OnButtonExtendMaskClicked()
		{
		}

		[Token(Token = "0x600464A")]
		[Address(RVA = "0x42139E8", Offset = "0x420F9E8", VA = "0x42139E8", Slot = "16")]
		protected override void OnButtonExtendCloseConfirmBtnClicked()
		{
		}

		[Token(Token = "0x600464B")]
		[Address(RVA = "0x42139EC", Offset = "0x420F9EC", VA = "0x42139EC", Slot = "18")]
		protected override void OnButtonExtendCancelbtnClicked()
		{
		}

		[Token(Token = "0x600464C")]
		[Address(RVA = "0x42139F0", Offset = "0x420F9F0", VA = "0x42139F0", Slot = "17")]
		protected override void OnButtonExtendConfirmBtnClicked()
		{
		}

		[Token(Token = "0x600464D")]
		[Address(RVA = "0x42131B0", Offset = "0x420F1B0", VA = "0x42131B0")]
		private void BuildItemListIfNeeded()
		{
		}

		[Token(Token = "0x600464E")]
		[Address(RVA = "0x4213E2C", Offset = "0x420FE2C", VA = "0x4213E2C")]
		private void OnItemSelected(int orderId)
		{
		}

		[Token(Token = "0x600464F")]
		[Address(RVA = "0x4213E74", Offset = "0x420FE74", VA = "0x4213E74")]
		private void RefreshAllItems(bool playSwitchAnim)
		{
		}

		[Token(Token = "0x6004650")]
		[Address(RVA = "0x4213F14", Offset = "0x420FF14", VA = "0x4213F14")]
		private void RefreshChangeBtnState()
		{
		}

		[Token(Token = "0x6004651")]
		[Address(RVA = "0x42138A8", Offset = "0x420F8A8", VA = "0x42138A8")]
		private void ShowConfirmPanel()
		{
		}

		[Token(Token = "0x6004652")]
		[Address(RVA = "0x421310C", Offset = "0x420F10C", VA = "0x421310C")]
		private void HideConfirmPanel()
		{
		}

		[Token(Token = "0x6004653")]
		[Address(RVA = "0x42139F4", Offset = "0x420F9F4", VA = "0x42139F4")]
		private void TryConfirmReplace()
		{
		}

		[Token(Token = "0x6004654")]
		[Address(RVA = "0x42137FC", Offset = "0x420F7FC", VA = "0x42137FC")]
		private static bool IsValidOrderId(int orderId)
		{
			return default;
		}

		[Token(Token = "0x6004655")]
		[Address(RVA = "0x4214224", Offset = "0x4210224", VA = "0x4214224")]
		public SpecialSummonCustomPropUpPanel()
		{
		}
	}
}
