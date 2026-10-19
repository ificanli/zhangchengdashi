using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000B3D")]
	public class CongratulationsGetGiftPackPanel : CongratulationsGetGiftPackPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000B40")]
		[CompilerGenerated]
		private struct _003CAwake_003Ed__3 : IAsyncStateMachine
		{
			[Token(Token = "0x40051F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40051F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40051F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public CongratulationsGetGiftPackPanel _003C_003E4__this;

			[Token(Token = "0x40051F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60044A1")]
			[Address(RVA = "0x41F0B00", Offset = "0x41ECB00", VA = "0x41F0B00", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60044A2")]
			[Address(RVA = "0x41F0E0C", Offset = "0x41ECE0C", VA = "0x41F0E0C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000B41")]
		[CompilerGenerated]
		private struct _003CRefreshResourceDisplay_003Ed__7 : IAsyncStateMachine
		{
			[Token(Token = "0x40051FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40051FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40051FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string[] rewardConfig;

			[Token(Token = "0x40051FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CongratulationsGetGiftPackPanel _003C_003E4__this;

			[Token(Token = "0x40051FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private List<(string id, int num)> _003CresList_003E5__2;

			[Token(Token = "0x40051FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60044A3")]
			[Address(RVA = "0x41F0E18", Offset = "0x41ECE18", VA = "0x41F0E18", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60044A4")]
			[Address(RVA = "0x41F1C60", Offset = "0x41EDC60", VA = "0x41F1C60", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000B42")]
		[CompilerGenerated]
		private struct _003CRewardFlyCollectAnimation_003Ed__11 : IAsyncStateMachine
		{
			[Token(Token = "0x4005200")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005201")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005202")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public CongratulationsGetGiftPackPanel _003C_003E4__this;

			[Token(Token = "0x4005203")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60044A5")]
			[Address(RVA = "0x41F1C6C", Offset = "0x41EDC6C", VA = "0x41F1C6C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60044A6")]
			[Address(RVA = "0x41F2640", Offset = "0x41EE640", VA = "0x41F2640", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000B43")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__4 : IAsyncStateMachine
		{
			[Token(Token = "0x4005204")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005205")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005206")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public CongratulationsGetGiftPackPanel _003C_003E4__this;

			[Token(Token = "0x4005207")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x4005208")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60044A7")]
			[Address(RVA = "0x41F264C", Offset = "0x41EE64C", VA = "0x41F264C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60044A8")]
			[Address(RVA = "0x41F3538", Offset = "0x41EF538", VA = "0x41F3538", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000B44")]
		[CompilerGenerated]
		private struct _003CUpdateOneResourceSlot_003Ed__9 : IAsyncStateMachine
		{
			[Token(Token = "0x4005209")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400520A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400520B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int index;

			[Token(Token = "0x400520C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public List<(string id, int num)> resList;

			[Token(Token = "0x400520D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Image slotImage;

			[Token(Token = "0x400520E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public TextMeshProUGUI nameText;

			[Token(Token = "0x400520F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public TextMeshProUGUI numText;

			[Token(Token = "0x4005210")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private int _003CresNum_003E5__2;

			[Token(Token = "0x4005211")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private GlobalAssetInfo _003Cconfig_003E5__3;

			[Token(Token = "0x4005212")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private Image _003C_003E7__wrap3;

			[Token(Token = "0x4005213")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60044A9")]
			[Address(RVA = "0x41F3544", Offset = "0x41EF544", VA = "0x41F3544", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60044AA")]
			[Address(RVA = "0x41F4258", Offset = "0x41F0258", VA = "0x41F4258", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40051F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private GlobalShopInfo _info;

		[Token(Token = "0x40051F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private List<GameObject> allCard;

		[Token(Token = "0x40051F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private GameObject res;

		[Token(Token = "0x600448E")]
		[Address(RVA = "0x41EF268", Offset = "0x41EB268", VA = "0x41EF268", Slot = "4")]
		[AsyncStateMachine(typeof(_003CAwake_003Ed__3))]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600448F")]
		[Address(RVA = "0x41EF2F8", Offset = "0x41EB2F8", VA = "0x41EF2F8", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__4))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6004490")]
		[Address(RVA = "0x41EF394", Offset = "0x41EB394", VA = "0x41EF394")]
		private bool InstantiateUI(string[] rewardConfig, bool decreaseOne = false, bool cardOne = false, bool cardTwo = false, bool cardThere = false, bool isArtifact = false)
		{
			return default;
		}

		[Token(Token = "0x6004491")]
		[Address(RVA = "0x41EFABC", Offset = "0x41EBABC", VA = "0x41EFABC")]
		private string[] MergeRewardConfigForDisplay(string[] rewardConfig)
		{
			return null;
		}

		[Token(Token = "0x6004492")]
		[Address(RVA = "0x41F0050", Offset = "0x41EC050", VA = "0x41F0050")]
		[AsyncStateMachine(typeof(_003CRefreshResourceDisplay_003Ed__7))]
		private UniTask RefreshResourceDisplay(string[] rewardConfig)
		{
			return default;
		}

		[Token(Token = "0x6004493")]
		[Address(RVA = "0x41F00E8", Offset = "0x41EC0E8", VA = "0x41F00E8")]
		private bool TryParseRewardSegment(string seg, out string prefix, out string id, out int num)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED CongratulationsGetGiftPackPanel.TryParseRewardSegment RVA=0x41F00E8 Token=0x6004493");
}

		[Token(Token = "0x6004494")]
		[Address(RVA = "0x41F0260", Offset = "0x41EC260", VA = "0x41F0260")]
		[AsyncStateMachine(typeof(_003CUpdateOneResourceSlot_003Ed__9))]
		private UniTask UpdateOneResourceSlot(Image slotImage, TextMeshProUGUI nameText, TextMeshProUGUI numText, List<(string id, int num)> resList, int index)
		{
			return default;
		}

		[Token(Token = "0x6004495")]
		[Address(RVA = "0x41F031C", Offset = "0x41EC31C", VA = "0x41F031C", Slot = "13")]
		protected override void OnButtonExtendBtnCloseClicked()
		{
		}

		[Token(Token = "0x6004496")]
		[Address(RVA = "0x41F03A8", Offset = "0x41EC3A8", VA = "0x41F03A8")]
		[AsyncStateMachine(typeof(_003CRewardFlyCollectAnimation_003Ed__11))]
		private UniTask RewardFlyCollectAnimation()
		{
			return default;
		}

		[Token(Token = "0x6004497")]
		[Address(RVA = "0x41F0434", Offset = "0x41EC434", VA = "0x41F0434", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6004498")]
		[Address(RVA = "0x41F0624", Offset = "0x41EC624", VA = "0x41F0624", Slot = "12")]
		protected override void OnButtonBGClicked()
		{
		}

		[Token(Token = "0x6004499")]
		[Address(RVA = "0x41F06B0", Offset = "0x41EC6B0", VA = "0x41F06B0")]
		public CongratulationsGetGiftPackPanel()
		{
		}
	}
}
