using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using DataModule;
using Il2CppDummyDll;
using Spine.Unity;
using UnityEngine;

namespace UIModuleO
{
	[Token(Token = "0x20007D7")]
	public class ChestSlotsView : ChestSlotsViewComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20007D8")]
		[CompilerGenerated]
		private struct _003CGetBoxUpdateUI_003Ed__8 : IAsyncStateMachine
		{
			[Token(Token = "0x4003C73")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003C74")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003C75")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ChestSlotsView _003C_003E4__this;

			[Token(Token = "0x4003C76")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public object o;

			[Token(Token = "0x4003C77")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int _003CrefreshVersion_003E5__2;

			[Token(Token = "0x4003C78")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private List<UserBoxData> _003CuserBoxData_003E5__3;

			[Token(Token = "0x4003C79")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002B8C")]
			[Address(RVA = "0x3FEFF38", Offset = "0x3FEBF38", VA = "0x3FEFF38", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002B8D")]
			[Address(RVA = "0x3FF0B80", Offset = "0x3FECB80", VA = "0x3FF0B80", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003C71")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private List<GameObject> boxItem;

		[Token(Token = "0x4003C72")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private int _refreshVersion;

		[Token(Token = "0x6002B7A")]
		[Address(RVA = "0x3FEC854", Offset = "0x3FE8854", VA = "0x3FEC854")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6002B7B")]
		[Address(RVA = "0x3FECA54", Offset = "0x3FE8A54", VA = "0x3FECA54")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6002B7C")]
		[Address(RVA = "0x3FECC68", Offset = "0x3FE8C68", VA = "0x3FECC68")]
		public void ReleaseBoxItems()
		{
		}

		[Token(Token = "0x6002B7D")]
		[Address(RVA = "0x3FECDD4", Offset = "0x3FE8DD4", VA = "0x3FECDD4")]
		public void RefreshUI()
		{
		}

		[Token(Token = "0x6002B7E")]
		[Address(RVA = "0x3FECE78", Offset = "0x3FE8E78", VA = "0x3FECE78")]
		private void UpdateChestImproveUI()
		{
		}

		[Token(Token = "0x6002B7F")]
		[Address(RVA = "0x3FEE4AC", Offset = "0x3FEA4AC", VA = "0x3FEE4AC")]
		private void SetSpineBAnim(SkeletonGraphic spineGraphic, bool isUnlocked)
		{
		}

		[Token(Token = "0x6002B80")]
		[Address(RVA = "0x3FED3B0", Offset = "0x3FE93B0", VA = "0x3FED3B0")]
		[AsyncStateMachine(typeof(_003CGetBoxUpdateUI_003Ed__8))]
		private void GetBoxUpdateUI(object o)
		{
		}

		[Token(Token = "0x6002B81")]
		[Address(RVA = "0x3FECC78", Offset = "0x3FE8C78", VA = "0x3FECC78")]
		private void ClearBoxItems()
		{
		}

		[Token(Token = "0x6002B82")]
		[Address(RVA = "0x3FED754", Offset = "0x3FE9754", VA = "0x3FED754")]
		private void HasBoxIsUnLockOpen(object o)
		{
		}

		[Token(Token = "0x6002B83")]
		[Address(RVA = "0x3FEEE30", Offset = "0x3FEAE30", VA = "0x3FEEE30", Slot = "13")]
		protected override void OnButtonExtendImgBoxBg1Clicked()
		{
		}

		[Token(Token = "0x6002B84")]
		[Address(RVA = "0x3FEEFF8", Offset = "0x3FEAFF8", VA = "0x3FEEFF8", Slot = "14")]
		protected override void OnButtonExtendImgBoxBg2Clicked()
		{
		}

		[Token(Token = "0x6002B85")]
		[Address(RVA = "0x3FEF300", Offset = "0x3FEB300", VA = "0x3FEF300", Slot = "15")]
		protected override void OnButtonExtendImgBoxBg3Clicked()
		{
		}

		[Token(Token = "0x6002B86")]
		[Address(RVA = "0x3FEF548", Offset = "0x3FEB548", VA = "0x3FEF548", Slot = "17")]
		protected override void OnButtonExtendImgBoxBg4Clicked()
		{
		}

		[Token(Token = "0x6002B87")]
		[Address(RVA = "0x3FEF790", Offset = "0x3FEB790", VA = "0x3FEF790", Slot = "16")]
		protected override void OnButtonExtendBtnBuyBoxSlot3Clicked()
		{
		}

		[Token(Token = "0x6002B88")]
		[Address(RVA = "0x3FEF92C", Offset = "0x3FEB92C", VA = "0x3FEF92C", Slot = "18")]
		protected override void OnButtonExtendBtnBuyBoxSlot4Clicked()
		{
		}

		[Token(Token = "0x6002B89")]
		[Address(RVA = "0x3FED44C", Offset = "0x3FE944C", VA = "0x3FED44C")]
		private void UpdateSlotUnlockUI()
		{
		}

		[Token(Token = "0x6002B8A")]
		[Address(RVA = "0x3FEFEB0", Offset = "0x3FEBEB0", VA = "0x3FEFEB0")]
		private void UpdateBoxPanelUI(object o)
		{
		}

		[Token(Token = "0x6002B8B")]
		[Address(RVA = "0x3FEFEB4", Offset = "0x3FEBEB4", VA = "0x3FEFEB4")]
		public ChestSlotsView()
		{
		}
	}
}
