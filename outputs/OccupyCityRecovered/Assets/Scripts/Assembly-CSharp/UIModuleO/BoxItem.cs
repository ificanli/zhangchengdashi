using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DG.Tweening;
using DataModule;
using Il2CppDummyDll;
using Spine.Unity;
using TimeModuleO;

namespace UIModuleO
{
	[Token(Token = "0x2000A77")]
	public class BoxItem : BoxItemComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A78")]
		[CompilerGenerated]
		private struct _003CHandleUnlockComplete_003Ed__28 : IAsyncStateMachine
		{
			[Token(Token = "0x4004D60")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004D61")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004D62")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public BoxItem _003C_003E4__this;

			[Token(Token = "0x4004D63")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UserBoxData _003Cdata_003E5__2;

			[Token(Token = "0x4004D64")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask<UnityEngine.Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003F0D")]
			[Address(RVA = "0x41778A4", Offset = "0x41738A4", VA = "0x41778A4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003F0E")]
			[Address(RVA = "0x4177E98", Offset = "0x4173E98", VA = "0x4177E98", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A79")]
		[CompilerGenerated]
		private struct _003CInItInfo_003Ed__9 : IAsyncStateMachine
		{
			[Token(Token = "0x4004D65")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004D66")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004D67")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public BoxItem _003C_003E4__this;

			[Token(Token = "0x4004D68")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public UserBoxData data;

			[Token(Token = "0x4004D69")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003F0F")]
			[Address(RVA = "0x4177EA4", Offset = "0x4173EA4", VA = "0x4177EA4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003F10")]
			[Address(RVA = "0x4178D94", Offset = "0x4174D94", VA = "0x4178D94", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A7A")]
		[CompilerGenerated]
		private struct _003CLoadSpineAsset_003Ed__10 : IAsyncStateMachine
		{
			[Token(Token = "0x4004D6A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004D6B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004D6C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BoxItem _003C_003E4__this;

			[Token(Token = "0x4004D6D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UserBoxData _003Cdata_003E5__2;

			[Token(Token = "0x4004D6E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int _003CloadVersion_003E5__3;

			[Token(Token = "0x4004D6F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private SkeletonGraphic _003CskeletonGraphic_003E5__4;

			[Token(Token = "0x4004D70")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask<SkeletonDataAsset>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003F11")]
			[Address(RVA = "0x4178DA0", Offset = "0x4174DA0", VA = "0x4178DA0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003F12")]
			[Address(RVA = "0x4179540", Offset = "0x4175540", VA = "0x4179540", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A7B")]
		[CompilerGenerated]
		private struct _003CUnLockIngUpdateUI_003Ed__17 : IAsyncStateMachine
		{
			[Token(Token = "0x4004D71")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004D72")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004D73")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public object o;

			[Token(Token = "0x4004D74")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public BoxItem _003C_003E4__this;

			[Token(Token = "0x4004D75")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UserBoxData _003CtargetData_003E5__2;

			[Token(Token = "0x4004D76")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask<UnityEngine.Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003F13")]
			[Address(RVA = "0x417954C", Offset = "0x417554C", VA = "0x417954C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003F14")]
			[Address(RVA = "0x4179E54", Offset = "0x4175E54", VA = "0x4179E54", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004D53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private UserBoxData _data;

		[Token(Token = "0x4004D54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private TimeManager.Timer _timer;

		[Token(Token = "0x4004D55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private int unLockTime;

		[Token(Token = "0x4004D56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private bool banClick;

		[Token(Token = "0x4004D57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x105")]
		private bool hasHandledUnlockComplete;

		[Token(Token = "0x4004D58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private string _defaultAdButtonText;

		[Token(Token = "0x4004D59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private float _defaultAdTextPosX;

		[Token(Token = "0x4004D5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private int _spineLoadVersion;

		[Token(Token = "0x4004D5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private bool _eventsRegistered;

		[Token(Token = "0x4004D5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Sequence sequence;

		[Token(Token = "0x4004D5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private int minutes;

		[Token(Token = "0x4004D5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private int requireKey;

		[Token(Token = "0x4004D5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private int second;

		[Token(Token = "0x6003EF3")]
		[Address(RVA = "0x4175474", Offset = "0x4171474", VA = "0x4175474")]
		[AsyncStateMachine(typeof(_003CInItInfo_003Ed__9))]
		public void InItInfo(UserBoxData data)
		{
		}

		[Token(Token = "0x6003EF4")]
		[Address(RVA = "0x4175510", Offset = "0x4171510", VA = "0x4175510")]
		[AsyncStateMachine(typeof(_003CLoadSpineAsset_003Ed__10))]
		private UniTask LoadSpineAsset()
		{
			return default;
		}

		[Token(Token = "0x6003EF5")]
		[Address(RVA = "0x41755A0", Offset = "0x41715A0", VA = "0x41755A0")]
		public void ReleaseSpineResources()
		{
		}

		[Token(Token = "0x6003EF6")]
		[Address(RVA = "0x417595C", Offset = "0x417195C", VA = "0x417595C")]
		private static void ClearSkeletonGraphic(SkeletonGraphic skeletonGraphic)
		{
		}

		[Token(Token = "0x6003EF7")]
		[Address(RVA = "0x4175AF4", Offset = "0x4171AF4", VA = "0x4175AF4")]
		private void RegisterEvents()
		{
		}

		[Token(Token = "0x6003EF8")]
		[Address(RVA = "0x4175604", Offset = "0x4171604", VA = "0x4175604")]
		private void UnregisterEvents()
		{
		}

		[Token(Token = "0x6003EF9")]
		[Address(RVA = "0x4175D80", Offset = "0x4171D80", VA = "0x4175D80")]
		private void BeginBanClick(object o)
		{
		}

		[Token(Token = "0x6003EFA")]
		[Address(RVA = "0x4175D8C", Offset = "0x4171D8C", VA = "0x4175D8C")]
		private void EndBanClick(object o)
		{
		}

		[Token(Token = "0x6003EFB")]
		[Address(RVA = "0x4175D94", Offset = "0x4171D94", VA = "0x4175D94")]
		[AsyncStateMachine(typeof(_003CUnLockIngUpdateUI_003Ed__17))]
		private void UnLockIngUpdateUI(object o)
		{
		}

		[Token(Token = "0x6003EFC")]
		[Address(RVA = "0x4175E34", Offset = "0x4171E34", VA = "0x4175E34")]
		private void UnLockEdUpdateUI()
		{
		}

		[Token(Token = "0x6003EFD")]
		[Address(RVA = "0x4176648", Offset = "0x4172648", VA = "0x4176648", Slot = "12")]
		protected override void OnButtonExtendBoxItemClicked()
		{
		}

		[Token(Token = "0x6003EFE")]
		[Address(RVA = "0x4176804", Offset = "0x4172804", VA = "0x4176804")]
		private void OpenBox(object o)
		{
		}

		[Token(Token = "0x6003EFF")]
		[Address(RVA = "0x41768CC", Offset = "0x41728CC", VA = "0x41768CC")]
		private void FinishOpenBoxFlow()
		{
		}

		[Token(Token = "0x6003F00")]
		[Address(RVA = "0x4176950", Offset = "0x4172950", VA = "0x4176950")]
		private void UpdateRequireKeyAndUI()
		{
		}

		[Token(Token = "0x6003F01")]
		[Address(RVA = "0x4176BC0", Offset = "0x4172BC0", VA = "0x4176BC0")]
		private void Update()
		{
		}

		[Token(Token = "0x6003F02")]
		[Address(RVA = "0x4176FFC", Offset = "0x4172FFC", VA = "0x4176FFC")]
		[AsyncStateMachine(typeof(_003CHandleUnlockComplete_003Ed__28))]
		private void HandleUnlockComplete()
		{
		}

		[Token(Token = "0x6003F03")]
		[Address(RVA = "0x417708C", Offset = "0x417308C", VA = "0x417708C")]
		private void AdCallBack()
		{
		}

		[Token(Token = "0x6003F04")]
		[Address(RVA = "0x4177354", Offset = "0x4173354", VA = "0x4177354")]
		private void RefreshUI(object o)
		{
		}

		[Token(Token = "0x6003F05")]
		[Address(RVA = "0x4177414", Offset = "0x4173414", VA = "0x4177414")]
		private void OnChestTutorialFreeGet(object o)
		{
		}

		[Token(Token = "0x6003F06")]
		[Address(RVA = "0x41772EC", Offset = "0x41732EC", VA = "0x41772EC")]
		private void SaveBoxData()
		{
		}

		[Token(Token = "0x6003F07")]
		[Address(RVA = "0x4177450", Offset = "0x4173450", VA = "0x4177450")]
		private bool IsCurrentBoxInFirstSlot()
		{
			return default;
		}

		[Token(Token = "0x6003F08")]
		[Address(RVA = "0x417712C", Offset = "0x417312C", VA = "0x417712C")]
		private void RefreshAdButtonFreeState()
		{
		}

		[Token(Token = "0x6003F09")]
		[Address(RVA = "0x4176DD0", Offset = "0x4172DD0", VA = "0x4176DD0")]
		private void CheckIsUnLockEd()
		{
		}

		[Token(Token = "0x6003F0A")]
		[Address(RVA = "0x417786C", Offset = "0x417386C", VA = "0x417786C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6003F0B")]
		[Address(RVA = "0x4177884", Offset = "0x4173884", VA = "0x4177884")]
		public BoxItem()
		{
		}
	}
}
