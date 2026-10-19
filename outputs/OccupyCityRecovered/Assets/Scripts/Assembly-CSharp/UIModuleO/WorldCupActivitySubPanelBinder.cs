using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using ljzs_lt;

namespace UIModuleO
{
	[Token(Token = "0x200066B")]
	public class WorldCupActivitySubPanelBinder : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200066D")]
		[CompilerGenerated]
		private struct _003CEnsureDailyTaskPanelAsync_003Ed__21 : IAsyncStateMachine
		{
			[Token(Token = "0x4003434")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003435")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<bool> _003C_003Et__builder;

			[Token(Token = "0x4003436")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public WorldCupActivitySubPanelBinder _003C_003E4__this;

			[Token(Token = "0x4003437")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask<bool>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002215")]
			[Address(RVA = "0x3F2F6EC", Offset = "0x3F2B6EC", VA = "0x3F2F6EC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002216")]
			[Address(RVA = "0x3F2FC64", Offset = "0x3F2BC64", VA = "0x3F2FC64", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200066E")]
		[CompilerGenerated]
		private struct _003CEnsurePanelAsync_003Ed__24<TView> : IAsyncStateMachine where TView : MonoBehaviour
		{
			[Token(Token = "0x4003438")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003439")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public AsyncUniTaskMethodBuilder<bool> _003C_003Et__builder;

			[Token(Token = "0x400343A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public WorldCupSubPanelSlot<TView> slot;

			[Token(Token = "0x400343B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public WorldCupActivitySubPanelBinder _003C_003E4__this;

			[Token(Token = "0x400343C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string assetPath;

			[Token(Token = "0x400343D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string instanceName;

			[Token(Token = "0x400343E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string loadFailLog;

			[Token(Token = "0x400343F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Func<GameObject, TView> resolveView;

			[Token(Token = "0x4003440")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string missingViewLog;

			[Token(Token = "0x4003441")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<TView> assignView;

			[Token(Token = "0x4003442")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action ensureInitialized;

			[Token(Token = "0x4003443")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private UniTask<TView>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002217")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002218")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200066F")]
		[CompilerGenerated]
		private struct _003CEnsurePointShopPanelAsync_003Ed__22 : IAsyncStateMachine
		{
			[Token(Token = "0x4003444")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003445")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<bool> _003C_003Et__builder;

			[Token(Token = "0x4003446")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public WorldCupActivitySubPanelBinder _003C_003E4__this;

			[Token(Token = "0x4003447")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask<bool>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002219")]
			[Address(RVA = "0x3F2FCBC", Offset = "0x3F2BCBC", VA = "0x3F2FCBC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600221A")]
			[Address(RVA = "0x3F3024C", Offset = "0x3F2C24C", VA = "0x3F3024C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000670")]
		[CompilerGenerated]
		private struct _003CEnsureRulesPanelAsync_003Ed__23 : IAsyncStateMachine
		{
			[Token(Token = "0x4003448")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003449")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<bool> _003C_003Et__builder;

			[Token(Token = "0x400344A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public WorldCupActivitySubPanelBinder _003C_003E4__this;

			[Token(Token = "0x400344B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask<bool>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600221B")]
			[Address(RVA = "0x3F302A4", Offset = "0x3F2C2A4", VA = "0x3F302A4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600221C")]
			[Address(RVA = "0x3F30834", Offset = "0x3F2C834", VA = "0x3F30834", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000671")]
		[CompilerGenerated]
		private struct _003CShowDailyTaskPanelAsync_003Ed__18 : IAsyncStateMachine
		{
			[Token(Token = "0x400344C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400344D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400344E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public WorldCupActivitySubPanelBinder _003C_003E4__this;

			[Token(Token = "0x400344F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool showTaskPage;

			[Token(Token = "0x4003450")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask<bool>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x4003451")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask.Awaiter _003C_003Eu__2;

			[Token(Token = "0x600221D")]
			[Address(RVA = "0x3F3088C", Offset = "0x3F2C88C", VA = "0x3F3088C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600221E")]
			[Address(RVA = "0x3F30F20", Offset = "0x3F2CF20", VA = "0x3F30F20", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000672")]
		[CompilerGenerated]
		private struct _003CShowPointShopPanelAsync_003Ed__19 : IAsyncStateMachine
		{
			[Token(Token = "0x4003452")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003453")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003454")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public WorldCupActivitySubPanelBinder _003C_003E4__this;

			[Token(Token = "0x4003455")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask<bool>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x4003456")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__2;

			[Token(Token = "0x600221F")]
			[Address(RVA = "0x3F30F2C", Offset = "0x3F2CF2C", VA = "0x3F30F2C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002220")]
			[Address(RVA = "0x3F31598", Offset = "0x3F2D598", VA = "0x3F31598", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000673")]
		[CompilerGenerated]
		private struct _003CShowRulesPanelAsync_003Ed__20 : IAsyncStateMachine
		{
			[Token(Token = "0x4003457")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003458")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003459")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public WorldCupActivitySubPanelBinder _003C_003E4__this;

			[Token(Token = "0x400345A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask<bool>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x400345B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__2;

			[Token(Token = "0x6002221")]
			[Address(RVA = "0x3F315A4", Offset = "0x3F2D5A4", VA = "0x3F315A4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002222")]
			[Address(RVA = "0x3F31B60", Offset = "0x3F2DB60", VA = "0x3F31B60", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private WorldCupActivityPanelView _view;

		[Token(Token = "0x4003426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private WorldCupDailyTaskPanelView _dailyTaskPanelView;

		[Token(Token = "0x4003427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private WorldCupPointShopPanelView _pointShopPanelView;

		[Token(Token = "0x4003428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private WorldCupRulesPanelView _rulesPanelView;

		[Token(Token = "0x4003429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool _dailyPanelInitialized;

		[Token(Token = "0x400342A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		private bool _pointShopPanelInitialized;

		[Token(Token = "0x400342B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x42")]
		private bool _rulesPanelInitialized;

		[Token(Token = "0x400342C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly WorldCupSubPanelSlot<WorldCupDailyTaskPanelView> _dailyPanelSlot;

		[Token(Token = "0x400342D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private readonly WorldCupSubPanelSlot<WorldCupPointShopPanelView> _pointShopPanelSlot;

		[Token(Token = "0x400342E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private readonly WorldCupSubPanelSlot<WorldCupRulesPanelView> _rulesPanelSlot;

		[Token(Token = "0x400342F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Action _refreshPanel;

		[Token(Token = "0x60021EB")]
		[Address(RVA = "0x3F2C26C", Offset = "0x3F2826C", VA = "0x3F2C26C")]
		public void Initialize(WorldCupActivityPanelView view, Action refreshPanel)
		{
		}

		[Token(Token = "0x60021EC")]
		[Address(RVA = "0x3F2DF5C", Offset = "0x3F29F5C", VA = "0x3F2DF5C")]
		public void OnPanelShow()
		{
		}

		[Token(Token = "0x60021ED")]
		[Address(RVA = "0x3F2C94C", Offset = "0x3F2894C", VA = "0x3F2C94C")]
		public void RefreshDailyUi()
		{
		}

		[Token(Token = "0x60021EE")]
		[Address(RVA = "0x3F2C964", Offset = "0x3F28964", VA = "0x3F2C964")]
		public void RefreshPointShopUi()
		{
		}

		[Token(Token = "0x60021EF")]
		[Address(RVA = "0x3F2D2D4", Offset = "0x3F292D4", VA = "0x3F2D2D4")]
		public void ShowDailyTaskPanel(bool showTaskPage)
		{
		}

		[Token(Token = "0x60021F0")]
		[Address(RVA = "0x3F2D660", Offset = "0x3F29660", VA = "0x3F2D660")]
		public void ShowPointShopPanel()
		{
		}

		[Token(Token = "0x60021F1")]
		[Address(RVA = "0x3F2D314", Offset = "0x3F29314", VA = "0x3F2D314")]
		public void ShowRulesPanel()
		{
		}

		[Token(Token = "0x60021F2")]
		[Address(RVA = "0x3F2E1E0", Offset = "0x3F2A1E0", VA = "0x3F2E1E0")]
		[AsyncStateMachine(typeof(_003CShowDailyTaskPanelAsync_003Ed__18))]
		private UniTask ShowDailyTaskPanelAsync(bool showTaskPage)
		{
			return default;
		}

		[Token(Token = "0x60021F3")]
		[Address(RVA = "0x3F2E284", Offset = "0x3F2A284", VA = "0x3F2E284")]
		[AsyncStateMachine(typeof(_003CShowPointShopPanelAsync_003Ed__19))]
		private UniTask ShowPointShopPanelAsync()
		{
			return default;
		}

		[Token(Token = "0x60021F4")]
		[Address(RVA = "0x3F2E310", Offset = "0x3F2A310", VA = "0x3F2E310")]
		[AsyncStateMachine(typeof(_003CShowRulesPanelAsync_003Ed__20))]
		private UniTask ShowRulesPanelAsync()
		{
			return default;
		}

		[Token(Token = "0x60021F5")]
		[Address(RVA = "0x3F2E39C", Offset = "0x3F2A39C", VA = "0x3F2E39C")]
		[AsyncStateMachine(typeof(_003CEnsureDailyTaskPanelAsync_003Ed__21))]
		private UniTask<bool> EnsureDailyTaskPanelAsync()
		{
			return default;
		}

		[Token(Token = "0x60021F6")]
		[Address(RVA = "0x3F2E454", Offset = "0x3F2A454", VA = "0x3F2E454")]
		[AsyncStateMachine(typeof(_003CEnsurePointShopPanelAsync_003Ed__22))]
		private UniTask<bool> EnsurePointShopPanelAsync()
		{
			return default;
		}

		[Token(Token = "0x60021F7")]
		[Address(RVA = "0x3F2E50C", Offset = "0x3F2A50C", VA = "0x3F2E50C")]
		[AsyncStateMachine(typeof(_003CEnsureRulesPanelAsync_003Ed__23))]
		private UniTask<bool> EnsureRulesPanelAsync()
		{
			return default;
		}

		[Token(Token = "0x60021F8")]
		[AsyncStateMachine(typeof(_003CEnsurePanelAsync_003Ed__24<>))]
		private UniTask<bool> EnsurePanelAsync<TView>(WorldCupSubPanelSlot<TView> slot, string assetPath, string instanceName, string loadFailLog, Func<GameObject, TView> resolveView, Action<TView> assignView, Action ensureInitialized, [Optional] string missingViewLog) where TView : MonoBehaviour
		{
			return default;
		}

		[Token(Token = "0x60021F9")]
		[Address(RVA = "0x3F2E5C4", Offset = "0x3F2A5C4", VA = "0x3F2E5C4")]
		private void EnsureDailyTaskPanelInitialized()
		{
		}

		[Token(Token = "0x60021FA")]
		[Address(RVA = "0x3F2EAB0", Offset = "0x3F2AAB0", VA = "0x3F2EAB0")]
		private void EnsurePointShopPanelInitialized()
		{
		}

		[Token(Token = "0x60021FB")]
		[Address(RVA = "0x3F2EBD8", Offset = "0x3F2ABD8", VA = "0x3F2EBD8")]
		private void EnsureRulesPanelInitialized()
		{
		}

		[Token(Token = "0x60021FC")]
		[Address(RVA = "0x3F2DF88", Offset = "0x3F29F88", VA = "0x3F2DF88")]
		private void UpdateDailyTaskPanelUi()
		{
		}

		[Token(Token = "0x60021FD")]
		[Address(RVA = "0x3F2E0C0", Offset = "0x3F2A0C0", VA = "0x3F2E0C0")]
		private void RefreshSideEntryRedDots()
		{
		}

		[Token(Token = "0x60021FE")]
		[Address(RVA = "0x3F2E910", Offset = "0x3F2A910", VA = "0x3F2E910")]
		private void InitializeDailyTaskPanelPages()
		{
		}

		[Token(Token = "0x60021FF")]
		[Address(RVA = "0x3F2E64C", Offset = "0x3F2A64C", VA = "0x3F2E64C")]
		private void BindDailyTaskPanelButtons()
		{
		}

		[Token(Token = "0x6002200")]
		[Address(RVA = "0x3F2ED48", Offset = "0x3F2AD48", VA = "0x3F2ED48")]
		private void HideDailyTaskPanel()
		{
		}

		[Token(Token = "0x6002201")]
		[Address(RVA = "0x3F2EDEC", Offset = "0x3F2ADEC", VA = "0x3F2EDEC")]
		private void HidePointShopPanel()
		{
		}

		[Token(Token = "0x6002202")]
		[Address(RVA = "0x3F2EE04", Offset = "0x3F2AE04", VA = "0x3F2EE04")]
		private void HideRulesPanel()
		{
		}

		[Token(Token = "0x6002203")]
		[Address(RVA = "0x3F2EE1C", Offset = "0x3F2AE1C", VA = "0x3F2EE1C")]
		private void OnDailyTaskClaimClicked(WorldCupdailyTaskConfig config)
		{
		}

		[Token(Token = "0x6002204")]
		[Address(RVA = "0x3F2EF2C", Offset = "0x3F2AF2C", VA = "0x3F2EF2C")]
		private void OnDailyTaskGotoClicked(WorldCupdailyTaskConfig config)
		{
		}

		[Token(Token = "0x6002205")]
		[Address(RVA = "0x3F2F0C4", Offset = "0x3F2B0C4", VA = "0x3F2F0C4")]
		private void NavigateDailyTaskToMeta(string metaModuleId)
		{
		}

		[Token(Token = "0x6002206")]
		[Address(RVA = "0x3F2F1B0", Offset = "0x3F2B1B0", VA = "0x3F2F1B0")]
		private void OnDailyGiftFreeClaimClicked(WorldCupdailyPriceConfig config)
		{
		}

		[Token(Token = "0x6002207")]
		[Address(RVA = "0x3F2F280", Offset = "0x3F2B280", VA = "0x3F2F280")]
		private void OnPointShopBuyClicked(PointShopConfig config)
		{
		}

		[Token(Token = "0x6002208")]
		[Address(RVA = "0x3F2EEEC", Offset = "0x3F2AEEC", VA = "0x3F2EEEC")]
		private static bool TryShowError(bool success, string errorMessage)
		{
			return default;
		}

		[Token(Token = "0x6002209")]
		[Address(RVA = "0x3F2F040", Offset = "0x3F2B040", VA = "0x3F2F040")]
		private bool ToastActivityEnded()
		{
			return default;
		}

		[Token(Token = "0x600220A")]
		[Address(RVA = "0x3F2F34C", Offset = "0x3F2B34C", VA = "0x3F2F34C")]
		public WorldCupActivitySubPanelBinder()
		{
		}
	}
}
