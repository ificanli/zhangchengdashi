using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using GameModule;
using Il2CppDummyDll;
using UIFramework;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000668")]
	public class WorldCupActivityPanel : UIPanel
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000669")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__13 : IAsyncStateMachine
		{
			[Token(Token = "0x4003407")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003408")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003409")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public WorldCupActivityPanel _003C_003E4__this;

			[Token(Token = "0x400340A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x400340B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int _003CopenTarget_003E5__2;

			[Token(Token = "0x400340C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60021E8")]
			[Address(RVA = "0x3F2D8CC", Offset = "0x3F298CC", VA = "0x3F2D8CC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60021E9")]
			[Address(RVA = "0x3F2DF74", Offset = "0x3F29F74", VA = "0x3F2DF74", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40033FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private WorldCupActivityPanelView _view;

		[Token(Token = "0x40033FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private WorldCupShootFlow _shootFlow;

		[Token(Token = "0x40033FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private WorldCupActivitySubPanelBinder subPanelBinder;

		[Token(Token = "0x4003400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private WorldCupMultiplierController _multiplierController;

		[Token(Token = "0x4003401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool _panelLogicBound;

		[Token(Token = "0x4003402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool _listeningEvents;

		[Token(Token = "0x4003403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool _buttonsBound;

		[Token(Token = "0x4003404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float _refreshTimer;

		[Token(Token = "0x4003405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private string _enterWay;

		[Token(Token = "0x4003406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool _hidMetaSwitchPanel;

		[Token(Token = "0x170001DC")]
		private bool IsNavigationBusy
		{
			[Token(Token = "0x60021D9")]
			[Address(RVA = "0x3F2D420", Offset = "0x3F29420", VA = "0x3F2D420")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60021BE")]
		[Address(RVA = "0x3F2BB64", Offset = "0x3F27B64", VA = "0x3F2BB64", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60021BF")]
		[Address(RVA = "0x3F2BB90", Offset = "0x3F27B90", VA = "0x3F2BB90")]
		private void EnsurePanelComponents()
		{
		}

		[Token(Token = "0x60021C0")]
		[Address(RVA = "0x3F2BC84", Offset = "0x3F27C84", VA = "0x3F2BC84")]
		private void BindPanelLogic()
		{
		}

		[Token(Token = "0x60021C1")]
		[Address(RVA = "0x3F2C278", Offset = "0x3F28278", VA = "0x3F2C278", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__13))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60021C2")]
		[Address(RVA = "0x3F2C310", Offset = "0x3F28310", VA = "0x3F2C310", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x60021C3")]
		[Address(RVA = "0x3F2C70C", Offset = "0x3F2870C", VA = "0x3F2C70C")]
		public void RefreshUi(WorldCupPanelRefreshScope scope)
		{
		}

		[Token(Token = "0x60021C4")]
		[Address(RVA = "0x3F2CA08", Offset = "0x3F28A08", VA = "0x3F2CA08", Slot = "9")]
		public override void UpdateInfo(params object[] args)
		{
		}

		[Token(Token = "0x60021C5")]
		[Address(RVA = "0x3F2CA44", Offset = "0x3F28A44", VA = "0x3F2CA44")]
		private void UpdateEnterWay(params object[] args)
		{
		}

		[Token(Token = "0x60021C6")]
		[Address(RVA = "0x3F2CB00", Offset = "0x3F28B00", VA = "0x3F2CB00")]
		private static int GetOpenTarget(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60021C7")]
		[Address(RVA = "0x3F2CBA0", Offset = "0x3F28BA0", VA = "0x3F2CBA0")]
		private void OpenSubPageByTarget(int openTarget)
		{
		}

		[Token(Token = "0x60021C8")]
		[Address(RVA = "0x3F2CC28", Offset = "0x3F28C28", VA = "0x3F2CC28")]
		private void HideMetaSwitchPanelIfNeeded()
		{
		}

		[Token(Token = "0x60021C9")]
		[Address(RVA = "0x3F2C658", Offset = "0x3F28658", VA = "0x3F2C658")]
		private void RestoreMetaSwitchPanelIfNeeded()
		{
		}

		[Token(Token = "0x60021CA")]
		[Address(RVA = "0x3F2CCF4", Offset = "0x3F28CF4", VA = "0x3F2CCF4")]
		private void Update()
		{
		}

		[Token(Token = "0x60021CB")]
		[Address(RVA = "0x3F2BF0C", Offset = "0x3F27F0C", VA = "0x3F2BF0C")]
		private void BindButtons()
		{
		}

		[Token(Token = "0x60021CC")]
		[Address(RVA = "0x3F2CFB8", Offset = "0x3F28FB8", VA = "0x3F2CFB8")]
		private void RegisterEvents()
		{
		}

		[Token(Token = "0x60021CD")]
		[Address(RVA = "0x3F2C50C", Offset = "0x3F2850C", VA = "0x3F2C50C")]
		private void UnregisterEvents()
		{
		}

		[Token(Token = "0x60021CE")]
		[Address(RVA = "0x3F2D100", Offset = "0x3F29100", VA = "0x3F2D100")]
		private void OnResourcesUpdated(object unused)
		{
		}

		[Token(Token = "0x60021CF")]
		[Address(RVA = "0x3F2D108", Offset = "0x3F29108", VA = "0x3F2D108")]
		private void OnWorldCupActivityRefresh(object arg)
		{
		}

		[Token(Token = "0x60021D0")]
		[Address(RVA = "0x3F2C7DC", Offset = "0x3F287DC", VA = "0x3F2C7DC")]
		private void RefreshCountdown()
		{
		}

		[Token(Token = "0x60021D1")]
		[Address(RVA = "0x3F2C8B0", Offset = "0x3F288B0", VA = "0x3F2C8B0")]
		private void RefreshPhaseLockState()
		{
		}

		[Token(Token = "0x60021D2")]
		[Address(RVA = "0x3F2CD44", Offset = "0x3F28D44", VA = "0x3F2CD44")]
		private void TryCloseWhenActivityExpired()
		{
		}

		[Token(Token = "0x60021D3")]
		[Address(RVA = "0x3F2D218", Offset = "0x3F29218", VA = "0x3F2D218")]
		private void OnClickShop()
		{
		}

		[Token(Token = "0x60021D4")]
		[Address(RVA = "0x3F2D21C", Offset = "0x3F2921C", VA = "0x3F2D21C")]
		private void OnClickDailyTask()
		{
		}

		[Token(Token = "0x60021D5")]
		[Address(RVA = "0x3F2D2EC", Offset = "0x3F292EC", VA = "0x3F2D2EC")]
		private void OnClickDailyGift()
		{
		}

		[Token(Token = "0x60021D6")]
		[Address(RVA = "0x3F2D2F0", Offset = "0x3F292F0", VA = "0x3F2D2F0")]
		private void OnClickRules()
		{
		}

		[Token(Token = "0x60021D7")]
		[Address(RVA = "0x3F2D328", Offset = "0x3F29328", VA = "0x3F2D328")]
		private void OnClickBack()
		{
		}

		[Token(Token = "0x60021D8")]
		[Address(RVA = "0x3F2D250", Offset = "0x3F29250", VA = "0x3F2D250")]
		private bool ToastActivityEndedIfNotPlay()
		{
			return default;
		}

		[Token(Token = "0x60021DA")]
		[Address(RVA = "0x3F2D4D8", Offset = "0x3F294D8", VA = "0x3F2D4D8")]
		private bool TryBlockNavigation()
		{
			return default;
		}

		[Token(Token = "0x60021DB")]
		[Address(RVA = "0x3F2D538", Offset = "0x3F29538", VA = "0x3F2D538")]
		public static bool TryBlockResourceBarNavigation()
		{
			return default;
		}

		[Token(Token = "0x60021DC")]
		[Address(RVA = "0x3F2CBEC", Offset = "0x3F28BEC", VA = "0x3F2CBEC")]
		public void OpenDailyGiftPage()
		{
		}

		[Token(Token = "0x60021DD")]
		[Address(RVA = "0x3F2CBBC", Offset = "0x3F28BBC", VA = "0x3F2CBBC")]
		public void OpenPointShopPage()
		{
		}

		[Token(Token = "0x60021DE")]
		[Address(RVA = "0x3F2CE54", Offset = "0x3F28E54", VA = "0x3F2CE54")]
		private static void BindClick(Button button, UnityAction action)
		{
		}

		[Token(Token = "0x60021DF")]
		[Address(RVA = "0x3F2D178", Offset = "0x3F29178", VA = "0x3F2D178")]
		private static void SetButtonInteractable(Button button, bool interactable)
		{
		}

		[Token(Token = "0x60021E0")]
		[Address(RVA = "0x3F2D674", Offset = "0x3F29674", VA = "0x3F2D674")]
		private static void ResetButtonVisualState(Button button)
		{
		}

		[Token(Token = "0x60021E1")]
		[Address(RVA = "0x3F2D774", Offset = "0x3F29774", VA = "0x3F2D774")]
		public WorldCupActivityPanel()
		{
		}
	}
}
