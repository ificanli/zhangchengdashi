using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using Il2CppDummyDll;
using TimeModuleO;
using UnityEngine;

namespace UIModuleO
{
	[Token(Token = "0x2000A87")]
	public class OpenBoxPanel : OpenBoxPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A88")]
		[CompilerGenerated]
		private struct _003CLoadSpineAsset_003Ed__14 : IAsyncStateMachine
		{
			[Token(Token = "0x4004DC5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004DC6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004DC7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public OpenBoxPanel _003C_003E4__this;

			[Token(Token = "0x4004DC8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask<Spine.Unity.SkeletonDataAsset>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003F7C")]
			[Address(RVA = "0x417EEF8", Offset = "0x417AEF8", VA = "0x417EEF8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003F7D")]
			[Address(RVA = "0x417F488", Offset = "0x417B488", VA = "0x417F488", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A89")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__9 : IAsyncStateMachine
		{
			[Token(Token = "0x4004DC9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004DCA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004DCB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public OpenBoxPanel _003C_003E4__this;

			[Token(Token = "0x4004DCC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x4004DCD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003F7E")]
			[Address(RVA = "0x41991B4", Offset = "0x41951B4", VA = "0x41991B4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003F7F")]
			[Address(RVA = "0x419B09C", Offset = "0x419709C", VA = "0x419B09C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004DBB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private UserBoxData _data;

		[Token(Token = "0x4004DBC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private TimeManager.Timer _timer;

		[Token(Token = "0x4004DBD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private List<GameObject> chestCardItemList;

		[Token(Token = "0x4004DBE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private string _defaultAdButtonText;

		[Token(Token = "0x4004DBF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private float _defaultAdTextPosX;

		[Token(Token = "0x4004DC0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		private bool _hasHandledUnlockComplete;

		[Token(Token = "0x4004DC1")]
		private const float UnlockUpdateInterval = 1f;

		[Token(Token = "0x4004DC2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private float _nextUnlockUpdateTime;

		[Token(Token = "0x4004DC3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x194")]
		private int minutes;

		[Token(Token = "0x4004DC4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private int requireKey;

		[Token(Token = "0x6003F62")]
		[Address(RVA = "0x417D8C0", Offset = "0x41798C0", VA = "0x417D8C0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6003F63")]
		[Address(RVA = "0x417D9D0", Offset = "0x41799D0", VA = "0x417D9D0", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__9))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6003F64")]
		[Address(RVA = "0x417DA78", Offset = "0x4179A78", VA = "0x417DA78")]
		private void UpdateBoxRewardPreviewUI()
		{
		}

		[Token(Token = "0x6003F65")]
		[Address(RVA = "0x417DC70", Offset = "0x4179C70", VA = "0x417DC70")]
		private void RefreshCrystalRewardUI(int crystalCount)
		{
		}

		[Token(Token = "0x6003F66")]
		[Address(RVA = "0x417DE54", Offset = "0x4179E54", VA = "0x417DE54")]
		[AsyncStateMachine(typeof(_003CLoadSpineAsset_003Ed__14))]
		private UniTask LoadSpineAsset()
		{
			return default;
		}

		[Token(Token = "0x6003F67")]
		[Address(RVA = "0x417DEE4", Offset = "0x4179EE4", VA = "0x417DEE4")]
		private void UpdateRequireKeyAndUI()
		{
		}

		[Token(Token = "0x6003F68")]
		[Address(RVA = "0x417E100", Offset = "0x417A100", VA = "0x417E100")]
		private void RefreshUnlockTimer()
		{
		}

		[Token(Token = "0x6003F69")]
		[Address(RVA = "0x417E194", Offset = "0x417A194", VA = "0x417E194")]
		private bool IsCurrentBoxInSlot()
		{
			return default;
		}

		[Token(Token = "0x6003F6A")]
		[Address(RVA = "0x417E234", Offset = "0x417A234", VA = "0x417E234")]
		private bool ShouldCloseForInvalidState(out bool needSave)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED OpenBoxPanel.ShouldCloseForInvalidState RVA=0x417E234 Token=0x6003F6A");
}

		[Token(Token = "0x6003F6B")]
		[Address(RVA = "0x417E29C", Offset = "0x417A29C", VA = "0x417E29C")]
		private bool IsUnlockTimerFinished()
		{
			return default;
		}

		[Token(Token = "0x6003F6C")]
		[Address(RVA = "0x417E320", Offset = "0x417A320", VA = "0x417E320")]
		private void MarkHandledAndHide()
		{
		}

		[Token(Token = "0x6003F6D")]
		[Address(RVA = "0x417E334", Offset = "0x417A334", VA = "0x417E334")]
		private void ApplyUnlockCompleteState()
		{
		}

		[Token(Token = "0x6003F6E")]
		[Address(RVA = "0x417E474", Offset = "0x417A474", VA = "0x417E474")]
		private bool CheckIsUnLockEd()
		{
			return default;
		}

		[Token(Token = "0x6003F6F")]
		[Address(RVA = "0x417E4F4", Offset = "0x417A4F4", VA = "0x417E4F4")]
		private void Update()
		{
		}

		[Token(Token = "0x6003F70")]
		[Address(RVA = "0x417E790", Offset = "0x417A790", VA = "0x417E790")]
		private void AdCallBack()
		{
		}

		[Token(Token = "0x6003F71")]
		[Address(RVA = "0x417E40C", Offset = "0x417A40C", VA = "0x417E40C")]
		private void SaveBoxData()
		{
		}

		[Token(Token = "0x6003F72")]
		[Address(RVA = "0x417EA74", Offset = "0x417AA74", VA = "0x417EA74")]
		private bool HasOtherBoxUnlockIng()
		{
			return default;
		}

		[Token(Token = "0x6003F73")]
		[Address(RVA = "0x417E898", Offset = "0x417A898", VA = "0x417E898")]
		private void RefreshAdButtonFreeState()
		{
		}

		[Token(Token = "0x6003F74")]
		[Address(RVA = "0x417EAC4", Offset = "0x417AAC4", VA = "0x417EAC4", Slot = "16")]
		protected override void OnButtonExtendBtnUnLockClicked()
		{
		}

		[Token(Token = "0x6003F75")]
		[Address(RVA = "0x417EB68", Offset = "0x417AB68", VA = "0x417EB68", Slot = "13")]
		protected override void OnButtonExtendBtnCloseClicked()
		{
		}

		[Token(Token = "0x6003F76")]
		[Address(RVA = "0x417EB8C", Offset = "0x417AB8C", VA = "0x417EB8C", Slot = "14")]
		protected override void OnButtonExtendBtnFeeDiamondToUnLockClicked()
		{
		}

		[Token(Token = "0x6003F77")]
		[Address(RVA = "0x417EDBC", Offset = "0x417ADBC", VA = "0x417EDBC", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6003F78")]
		[Address(RVA = "0x417EEC4", Offset = "0x417AEC4", VA = "0x417EEC4", Slot = "12")]
		protected override void OnButtonBgClicked()
		{
		}

		[Token(Token = "0x6003F79")]
		[Address(RVA = "0x417E584", Offset = "0x417A584", VA = "0x417E584")]
		private void UpdateBtnState()
		{
		}

		[Token(Token = "0x6003F7A")]
		[Address(RVA = "0x417EEE8", Offset = "0x417AEE8", VA = "0x417EEE8")]
		public OpenBoxPanel()
		{
		}
	}
}
