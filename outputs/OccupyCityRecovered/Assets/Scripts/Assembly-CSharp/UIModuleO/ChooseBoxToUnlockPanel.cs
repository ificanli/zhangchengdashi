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
	[Token(Token = "0x20007E6")]
	public class ChooseBoxToUnlockPanel : ChooseBoxToUnlockPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20007E8")]
		[CompilerGenerated]
		private struct _003CCreateBoxItems_003Ed__6 : IAsyncStateMachine
		{
			[Token(Token = "0x4003CDE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003CDF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003CE0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ChooseBoxToUnlockPanel _003C_003E4__this;

			[Token(Token = "0x4003CE1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private List<BackpackData> _003CchestBoxData_003E5__2;

			[Token(Token = "0x4003CE2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002C13")]
			[Address(RVA = "0x3FF60A8", Offset = "0x3FF20A8", VA = "0x3FF60A8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002C14")]
			[Address(RVA = "0x3FF6BA4", Offset = "0x3FF2BA4", VA = "0x3FF6BA4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20007E9")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__5 : IAsyncStateMachine
		{
			[Token(Token = "0x4003CE3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003CE4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003CE5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ChooseBoxToUnlockPanel _003C_003E4__this;

			[Token(Token = "0x4003CE6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x4003CE7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002C15")]
			[Address(RVA = "0x3FF6BB0", Offset = "0x3FF2BB0", VA = "0x3FF6BB0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002C16")]
			[Address(RVA = "0x3FF78C4", Offset = "0x3FF38C4", VA = "0x3FF78C4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003CD7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private List<GameObject> _boxItemList;

		[Token(Token = "0x4003CD8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private int _selectedIndex;

		[Token(Token = "0x4003CD9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private GameObject itemPrefab;

		[Token(Token = "0x4003CDA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private List<ChooseBoxData> _chooseBoxDataList;

		[Token(Token = "0x4003CDB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private int _targetSlotIndex;

		[Token(Token = "0x6002C05")]
		[Address(RVA = "0x3FF49C4", Offset = "0x3FF09C4", VA = "0x3FF49C4", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__5))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6002C06")]
		[Address(RVA = "0x3FF4A60", Offset = "0x3FF0A60", VA = "0x3FF4A60")]
		[AsyncStateMachine(typeof(_003CCreateBoxItems_003Ed__6))]
		private UniTask CreateBoxItems()
		{
			return default;
		}

		[Token(Token = "0x6002C07")]
		[Address(RVA = "0x3FF4AEC", Offset = "0x3FF0AEC", VA = "0x3FF4AEC")]
		public void UpdateSelectionUI()
		{
		}

		[Token(Token = "0x6002C08")]
		[Address(RVA = "0x3FF3B6C", Offset = "0x3FEFB6C", VA = "0x3FF3B6C")]
		public void OnBoxItemClicked(int itemId)
		{
		}

		[Token(Token = "0x6002C09")]
		[Address(RVA = "0x3FF4C34", Offset = "0x3FF0C34", VA = "0x3FF4C34")]
		private void UpdateRewardUI()
		{
		}

		[Token(Token = "0x6002C0A")]
		[Address(RVA = "0x3FF5468", Offset = "0x3FF1468", VA = "0x3FF5468", Slot = "15")]
		protected override void OnButtonExtendBtnUnlockClicked()
		{
		}

		[Token(Token = "0x6002C0B")]
		[Address(RVA = "0x3FF5A68", Offset = "0x3FF1A68", VA = "0x3FF5A68")]
		private void ClearBoxItems()
		{
		}

		[Token(Token = "0x6002C0C")]
		[Address(RVA = "0x3FF5C34", Offset = "0x3FF1C34", VA = "0x3FF5C34", Slot = "13")]
		protected override void OnButtonExtendBtnCloseClicked()
		{
		}

		[Token(Token = "0x6002C0D")]
		[Address(RVA = "0x3FF5CC0", Offset = "0x3FF1CC0", VA = "0x3FF5CC0", Slot = "12")]
		protected override void OnButtonExtendBGClicked()
		{
		}

		[Token(Token = "0x6002C0E")]
		[Address(RVA = "0x3FF5D4C", Offset = "0x3FF1D4C", VA = "0x3FF5D4C", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6002C0F")]
		[Address(RVA = "0x3FF5E18", Offset = "0x3FF1E18", VA = "0x3FF5E18")]
		public ChooseBoxToUnlockPanel()
		{
		}
	}
}
