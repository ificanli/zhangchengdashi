using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using Il2CppDummyDll;
using ToolModule;
using UIFramework;
using UIModuleO;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x20005E4")]
	public class UserResourcesManager : ManagerBase<UserResourcesManager>
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20005E6")]
		[CompilerGenerated]
		private struct _003CEnsureResourcesPanelReady_003Ed__49 : IAsyncStateMachine
		{
			[Token(Token = "0x4003191")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003192")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003193")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UserResourcesManager _003C_003E4__this;

			[Token(Token = "0x4003194")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6001F0A")]
			[Address(RVA = "0x3F01900", Offset = "0x3EFD900", VA = "0x3F01900", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001F0B")]
			[Address(RVA = "0x3F01D38", Offset = "0x3EFDD38", VA = "0x3F01D38", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20005E7")]
		[CompilerGenerated]
		private struct _003CGetPanel_003Ed__39 : IAsyncStateMachine
		{
			[Token(Token = "0x4003195")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003196")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003197")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UserResourcesManager _003C_003E4__this;

			[Token(Token = "0x4003198")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask<UIPanel>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6001F0C")]
			[Address(RVA = "0x3F01D44", Offset = "0x3EFDD44", VA = "0x3F01D44", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001F0D")]
			[Address(RVA = "0x3F02124", Offset = "0x3EFE124", VA = "0x3F02124", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20005E8")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__38 : IAsyncStateMachine
		{
			[Token(Token = "0x4003199")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400319A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400319B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UserResourcesManager _003C_003E4__this;

			[Token(Token = "0x6001F0E")]
			[Address(RVA = "0x3F02130", Offset = "0x3EFE130", VA = "0x3F02130", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001F0F")]
			[Address(RVA = "0x3F02638", Offset = "0x3EFE638", VA = "0x3F02638", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x20005E9")]
		[CompilerGenerated]
		private sealed class _003CRefreshResourceBarLayout_003Ed__47 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400319C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400319D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400319E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public UserResourcesManager _003C_003E4__this;

			[Token(Token = "0x170001A4")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6001F13")]
				[Address(RVA = "0x3F02720", Offset = "0x3EFE720", VA = "0x3F02720", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170001A5")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6001F15")]
				[Address(RVA = "0x3F02760", Offset = "0x3EFE760", VA = "0x3F02760", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6001F10")]
			[Address(RVA = "0x3F02644", Offset = "0x3EFE644", VA = "0x3F02644")]
			[DebuggerHidden]
			public _003CRefreshResourceBarLayout_003Ed__47(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6001F11")]
			[Address(RVA = "0x3F0266C", Offset = "0x3EFE66C", VA = "0x3F0266C", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6001F12")]
			[Address(RVA = "0x3F02670", Offset = "0x3EFE670", VA = "0x3F02670", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6001F13")]
			[Address(RVA = "0x3F02720", Offset = "0x3EFE720", VA = "0x3F02720", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6001F14")]
			[Address(RVA = "0x3F02728", Offset = "0x3EFE728", VA = "0x3F02728", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6001F15")]
			[Address(RVA = "0x3F02760", Offset = "0x3EFE760", VA = "0x3F02760", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20005EA")]
		[CompilerGenerated]
		private struct _003CShowUserResourcesPanel_003Ed__60 : IAsyncStateMachine
		{
			[Token(Token = "0x400319F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40031A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40031A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public UserResourcesManager _003C_003E4__this;

			[Token(Token = "0x40031A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6001F16")]
			[Address(RVA = "0x3F02768", Offset = "0x3EFE768", VA = "0x3F02768", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001F17")]
			[Address(RVA = "0x3F02C10", Offset = "0x3EFEC10", VA = "0x3F02C10", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400318B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly Dictionary<string, UserAssetData> _userResourcesDataDict;

		[Token(Token = "0x400318C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly Dictionary<string, Action<string>> _userResourceChangeActionDict;

		[Token(Token = "0x400318D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private UIPanel _userResourcesPanel;

		[Token(Token = "0x400318E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool UserResourcesPanelIsShow;

		[Token(Token = "0x400318F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Dictionary<string, GlobalAssetInfo> _globalAssetInfos;

		[Token(Token = "0x17000193")]
		public BigInteger Coin
		{
			[Token(Token = "0x6001EDA")]
			[Address(RVA = "0x3EFEBA8", Offset = "0x3EFABA8", VA = "0x3EFEBA8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000194")]
		public BigInteger Population
		{
			[Token(Token = "0x6001EDB")]
			[Address(RVA = "0x3EFEE7C", Offset = "0x3EFAE7C", VA = "0x3EFEE7C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000195")]
		public BigInteger AtkPower
		{
			[Token(Token = "0x6001EDC")]
			[Address(RVA = "0x3EFEED8", Offset = "0x3EFAED8", VA = "0x3EFEED8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000196")]
		public BigInteger Trophy
		{
			[Token(Token = "0x6001EDD")]
			[Address(RVA = "0x3EFEF34", Offset = "0x3EFAF34", VA = "0x3EFEF34")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000197")]
		public BigInteger OutSideCoin
		{
			[Token(Token = "0x6001EDE")]
			[Address(RVA = "0x3EFEF90", Offset = "0x3EFAF90", VA = "0x3EFEF90")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000198")]
		public BigInteger Diamond
		{
			[Token(Token = "0x6001EDF")]
			[Address(RVA = "0x3EF1C94", Offset = "0x3EEDC94", VA = "0x3EF1C94")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000199")]
		public BigInteger Exp
		{
			[Token(Token = "0x6001EE0")]
			[Address(RVA = "0x3EFEFEC", Offset = "0x3EFAFEC", VA = "0x3EFEFEC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700019A")]
		public BigInteger Wood
		{
			[Token(Token = "0x6001EE1")]
			[Address(RVA = "0x3EFF048", Offset = "0x3EFB048", VA = "0x3EFF048")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700019B")]
		public BigInteger Crystal
		{
			[Token(Token = "0x6001EE2")]
			[Address(RVA = "0x3EFF0A4", Offset = "0x3EFB0A4", VA = "0x3EFF0A4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700019C")]
		public BigInteger SummonExp
		{
			[Token(Token = "0x6001EE3")]
			[Address(RVA = "0x3EFF100", Offset = "0x3EFB100", VA = "0x3EFF100")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700019D")]
		public BigInteger AbilityStone
		{
			[Token(Token = "0x6001EE4")]
			[Address(RVA = "0x3EFF15C", Offset = "0x3EFB15C", VA = "0x3EFF15C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700019E")]
		public BigInteger UniversalCardR
		{
			[Token(Token = "0x6001EE5")]
			[Address(RVA = "0x3EFF1B8", Offset = "0x3EFB1B8", VA = "0x3EFF1B8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700019F")]
		public BigInteger UniversalCardSr
		{
			[Token(Token = "0x6001EE6")]
			[Address(RVA = "0x3EFF214", Offset = "0x3EFB214", VA = "0x3EFF214")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170001A0")]
		public BigInteger UniversalCardSsr
		{
			[Token(Token = "0x6001EE7")]
			[Address(RVA = "0x3EFF270", Offset = "0x3EFB270", VA = "0x3EFF270")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170001A1")]
		public BigInteger UniversalCardSssr
		{
			[Token(Token = "0x6001EE8")]
			[Address(RVA = "0x3EFF2CC", Offset = "0x3EFB2CC", VA = "0x3EFF2CC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170001A2")]
		public int ExpLevel
		{
			[Token(Token = "0x6001EE9")]
			[Address(RVA = "0x3EF95B4", Offset = "0x3EF55B4", VA = "0x3EF95B4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170001A3")]
		public int SummonLevel
		{
			[Token(Token = "0x6001EEA")]
			[Address(RVA = "0x3EFF464", Offset = "0x3EFB464", VA = "0x3EFF464")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6001EEB")]
		[Address(RVA = "0x3EFF614", Offset = "0x3EFB614", VA = "0x3EFF614", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__38))]
		public override UniTask Init()
		{
			return default;
		}

		[Token(Token = "0x6001EEC")]
		[Address(RVA = "0x3EFF6A4", Offset = "0x3EFB6A4", VA = "0x3EFF6A4")]
		[AsyncStateMachine(typeof(_003CGetPanel_003Ed__39))]
		private UniTask GetPanel()
		{
			return default;
		}

		[Token(Token = "0x6001EED")]
		[Address(RVA = "0x3EFF740", Offset = "0x3EFB740", VA = "0x3EFF740")]
		public void RefreshResourcesUI()
		{
		}

		[Token(Token = "0x6001EEE")]
		[Address(RVA = "0x3EFF84C", Offset = "0x3EFB84C", VA = "0x3EFF84C")]
		public string GetResourceDisplayText(string resourceId)
		{
			return null;
		}

		[Token(Token = "0x6001EEF")]
		[Address(RVA = "0x3EFFA14", Offset = "0x3EFBA14", VA = "0x3EFFA14")]
		public void SetBarVisibleResources(IEnumerable<string> resourceIds)
		{
		}

		[Token(Token = "0x6001EF0")]
		[Address(RVA = "0x3EFFAB8", Offset = "0x3EFBAB8", VA = "0x3EFFAB8")]
		public void ApplyDefaultBarVisibility(params string[] extraResourceIds)
		{
		}

		[Token(Token = "0x6001EF1")]
		[Address(RVA = "0x3EFFABC", Offset = "0x3EFBABC", VA = "0x3EFFABC")]
		public void ApplyDefaultBarVisibility(IEnumerable<string> extraResourceIds)
		{
		}

		[Token(Token = "0x6001EF2")]
		[Address(RVA = "0x3EFFFC8", Offset = "0x3EFBFC8", VA = "0x3EFFFC8")]
		public void ApplyWorldCupBarVisibility()
		{
		}

		[Token(Token = "0x6001EF3")]
		[Address(RVA = "0x3F000D0", Offset = "0x3EFC0D0", VA = "0x3F000D0")]
		public void RefreshResourceLayout()
		{
		}

		[Token(Token = "0x6001EF4")]
		[Address(RVA = "0x3F000F0", Offset = "0x3EFC0F0", VA = "0x3F000F0")]
		[IteratorStateMachine(typeof(_003CRefreshResourceBarLayout_003Ed__47))]
		private IEnumerator RefreshResourceBarLayout()
		{
			return null;
		}

		[Token(Token = "0x6001EF5")]
		[Address(RVA = "0x3EFF7D0", Offset = "0x3EFB7D0", VA = "0x3EFF7D0")]
		private UserResourcesPanel GetUserResourcesPanel()
		{
			return null;
		}

		[Token(Token = "0x6001EF6")]
		[Address(RVA = "0x3F00158", Offset = "0x3EFC158", VA = "0x3F00158")]
		[AsyncStateMachine(typeof(_003CEnsureResourcesPanelReady_003Ed__49))]
		public UniTask EnsureResourcesPanelReady()
		{
			return default;
		}

		[Token(Token = "0x6001EF7")]
		[Address(RVA = "0x3F001F0", Offset = "0x3EFC1F0", VA = "0x3F001F0")]
		public bool TryGetBarResourceIconRect(string resourceId, out RectTransform iconRect)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED UserResourcesManager.TryGetBarResourceIconRect RVA=0x3F001F0 Token=0x6001EF7");
}

		[Token(Token = "0x6001EF8")]
		[Address(RVA = "0x3EFEC04", Offset = "0x3EFAC04", VA = "0x3EFEC04")]
		private UserAssetData GetResourceData(string id)
		{
			return null;
		}

		[Token(Token = "0x6001EF9")]
		[Address(RVA = "0x3F002B8", Offset = "0x3EFC2B8", VA = "0x3F002B8")]
		public int GetResourceCount(string id)
		{
			return default;
		}

		[Token(Token = "0x6001EFA")]
		[Address(RVA = "0x3F00320", Offset = "0x3EFC320", VA = "0x3F00320")]
		private void ChangeGetd(string id, BigInteger count)
		{
		}

		[Token(Token = "0x6001EFB")]
		[Address(RVA = "0x3F00430", Offset = "0x3EFC430", VA = "0x3F00430")]
		private void ChangeUse(string id, BigInteger count)
		{
		}

		[Token(Token = "0x6001EFC")]
		[Address(RVA = "0x3F00540", Offset = "0x3EFC540", VA = "0x3F00540")]
		public void SetResourceCount(string id, BigInteger count)
		{
		}

		[Token(Token = "0x6001EFD")]
		[Address(RVA = "0x3EE7A28", Offset = "0x3EE3A28", VA = "0x3EE7A28")]
		public void AddResourceCount(string id, BigInteger count, bool isCheat = false, CurrencyTransactionSceneType type = CurrencyTransactionSceneType.shop_related, bool isIap = false, CurrencyType currencyUsedType = CurrencyType.gems)
		{
		}

		[Token(Token = "0x6001EFE")]
		[Address(RVA = "0x3EFF328", Offset = "0x3EFB328", VA = "0x3EFF328")]
		public int GetExpLEvel(int exp)
		{
			return default;
		}

		[Token(Token = "0x6001EFF")]
		[Address(RVA = "0x3EFF4D8", Offset = "0x3EFB4D8", VA = "0x3EFF4D8")]
		public int GetSummonLevel(int summonExp)
		{
			return default;
		}

		[Token(Token = "0x6001F00")]
		[Address(RVA = "0x3EF1CF0", Offset = "0x3EEDCF0", VA = "0x3EF1CF0")]
		public void LoseResourceCount(string id, BigInteger count, bool isCheat = false, CurrencyTransactionSceneType type = CurrencyTransactionSceneType.shop_related)
		{
		}

		[Token(Token = "0x6001F01")]
		[Address(RVA = "0x3F0078C", Offset = "0x3EFC78C", VA = "0x3F0078C")]
		[AsyncStateMachine(typeof(_003CShowUserResourcesPanel_003Ed__60))]
		public Task ShowUserResourcesPanel()
		{
			return null;
		}

		[Token(Token = "0x6001F02")]
		[Address(RVA = "0x3F00850", Offset = "0x3EFC850", VA = "0x3F00850")]
		public void HideUserResourcesPanel()
		{
		}

		[Token(Token = "0x6001F03")]
		[Address(RVA = "0x3F008D4", Offset = "0x3EFC8D4", VA = "0x3F008D4")]
		public void RegisterResourceChangeAction(string id, Action<string> action)
		{
		}

		[Token(Token = "0x6001F04")]
		[Address(RVA = "0x3F009D8", Offset = "0x3EFC9D8", VA = "0x3F009D8")]
		public void UnRegisterResourceChangeAction(string id, Action<string> action)
		{
		}

		[Token(Token = "0x6001F05")]
		[Address(RVA = "0x3F00AEC", Offset = "0x3EFCAEC", VA = "0x3F00AEC")]
		public int OneVideoGetCoinNumber(bool useMinValue)
		{
			return default;
		}

		[Token(Token = "0x6001F06")]
		[Address(RVA = "0x3F00BC8", Offset = "0x3EFCBC8", VA = "0x3F00BC8")]
		public GlobalAssetInfo GetGlobalAssetInfo(string assetId)
		{
			return null;
		}

		[Token(Token = "0x6001F07")]
		[Address(RVA = "0x3F00D58", Offset = "0x3EFCD58", VA = "0x3F00D58")]
		public UserResourcesManager()
		{
		}
	}
}
