using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace UIModuleO
{
	[Token(Token = "0x2000BF0")]
	public class UserResourcesPanel : UserResourcesPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000BF1")]
		[CompilerGenerated]
		private struct _003CJumpToResPos_003Ed__34 : IAsyncStateMachine
		{
			[Token(Token = "0x400568C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400568D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400568E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public object parm;

			[Token(Token = "0x400568F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<UIFramework.UIPanel>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60049EB")]
			[Address(RVA = "0x4252420", Offset = "0x424E420", VA = "0x4252420", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60049EC")]
			[Address(RVA = "0x42529EC", Offset = "0x424E9EC", VA = "0x42529EC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000BF2")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__13 : IAsyncStateMachine
		{
			[Token(Token = "0x4005690")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005691")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005692")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UserResourcesPanel _003C_003E4__this;

			[Token(Token = "0x4005693")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x4005694")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60049ED")]
			[Address(RVA = "0x42529F8", Offset = "0x424E9F8", VA = "0x42529F8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60049EE")]
			[Address(RVA = "0x4252E64", Offset = "0x424EE64", VA = "0x4252E64", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4005682")]
		private const string DiceResourceUiObjectName = "UserResourceUIDice";

		[Token(Token = "0x4005683")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private UserResourceUI _diceResourceUi;

		[Token(Token = "0x4005684")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool _diceUiConfigured;

		[Token(Token = "0x4005685")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		private bool updateDiceUI;

		[Token(Token = "0x4005686")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int _diceFlyDisplayCount;

		[Token(Token = "0x4005687")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private readonly Dictionary<string, UserResourceUI> _resourceById;

		[Token(Token = "0x4005688")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private readonly HashSet<string> _visibleResourceIds;

		[Token(Token = "0x4005689")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private readonly Dictionary<string, bool> _updateEnabledById;

		[Token(Token = "0x400568A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private string _betRewardNum;

		[Token(Token = "0x400568B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Coroutine _refreshLayoutCoroutine;

		[Token(Token = "0x60049C9")]
		[Address(RVA = "0x424F328", Offset = "0x424B328", VA = "0x424F328", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60049CA")]
		[Address(RVA = "0x424F354", Offset = "0x424B354", VA = "0x424F354")]
		private void BuildResourceRegistry()
		{
		}

		[Token(Token = "0x60049CB")]
		[Address(RVA = "0x424F640", Offset = "0x424B640", VA = "0x424F640")]
		private void RegisterEvents()
		{
		}

		[Token(Token = "0x60049CC")]
		[Address(RVA = "0x424FF24", Offset = "0x424BF24", VA = "0x424FF24", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__13))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60049CD")]
		[Address(RVA = "0x424FFC0", Offset = "0x424BFC0", VA = "0x424FFC0", Slot = "9")]
		public override void UpdateInfo(params object[] args)
		{
		}

		[Token(Token = "0x60049CE")]
		[Address(RVA = "0x4250050", Offset = "0x424C050", VA = "0x4250050")]
		public void SetVisibleResourceIds(IEnumerable<string> resourceIds)
		{
		}

		[Token(Token = "0x60049CF")]
		[Address(RVA = "0x4250680", Offset = "0x424C680", VA = "0x4250680")]
		public void SetResourceUpdateEnabled(string resourceId, bool enabled)
		{
		}

		[Token(Token = "0x60049D0")]
		[Address(RVA = "0x4250550", Offset = "0x424C550", VA = "0x4250550")]
		public void RefreshVisibleResources()
		{
		}

		[Token(Token = "0x60049D1")]
		[Address(RVA = "0x42508D4", Offset = "0x424C8D4", VA = "0x42508D4")]
		public bool TryGetResourceUI(string resourceId, out UserResourceUI ui)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED UserResourcesPanel.TryGetResourceUI RVA=0x42508D4 Token=0x60049D1");
}

		[Token(Token = "0x60049D2")]
		[Address(RVA = "0x425093C", Offset = "0x424C93C", VA = "0x425093C")]
		public bool TryGetIconRect(string resourceId, out RectTransform iconRect)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED UserResourcesPanel.TryGetIconRect RVA=0x425093C Token=0x60049D2");
}

		[Token(Token = "0x60049D3")]
		[Address(RVA = "0x4250738", Offset = "0x424C738", VA = "0x4250738")]
		private void RefreshResourceIfAllowed(string resourceId)
		{
		}

		[Token(Token = "0x60049D4")]
		[Address(RVA = "0x4250BF4", Offset = "0x424CBF4", VA = "0x4250BF4")]
		private static bool ShouldSkipAnimationRefresh(string resourceId)
		{
			return default;
		}

		[Token(Token = "0x60049D5")]
		[Address(RVA = "0x4250CAC", Offset = "0x424CCAC", VA = "0x4250CAC")]
		private void RewardSingleReached(object obj)
		{
		}

		[Token(Token = "0x60049D6")]
		[Address(RVA = "0x4251598", Offset = "0x424D598", VA = "0x4251598")]
		private void OnForceRefreshAll(object o)
		{
		}

		[Token(Token = "0x60049D7")]
		[Address(RVA = "0x42519F0", Offset = "0x424D9F0", VA = "0x42519F0")]
		private void OnUserResourceBarDoAni(object o)
		{
		}

		[Token(Token = "0x60049D8")]
		[Address(RVA = "0x4251BC4", Offset = "0x424DBC4", VA = "0x4251BC4")]
		private void OnLegacyCoinDoAni(object o)
		{
		}

		[Token(Token = "0x60049D9")]
		[Address(RVA = "0x4251C2C", Offset = "0x424DC2C", VA = "0x4251C2C")]
		private void OnLegacyDiamondDoAni(object o)
		{
		}

		[Token(Token = "0x60049DA")]
		[Address(RVA = "0x4251C94", Offset = "0x424DC94", VA = "0x4251C94")]
		private void OnLegacyWoodDoAni(object o)
		{
		}

		[Token(Token = "0x60049DB")]
		[Address(RVA = "0x4251A50", Offset = "0x424DA50", VA = "0x4251A50")]
		private void PlayResourceDoAni(string resourceId, string delta)
		{
		}

		[Token(Token = "0x60049DC")]
		[Address(RVA = "0x4251CFC", Offset = "0x424DCFC", VA = "0x4251CFC")]
		private void OnUserResourceBarNoUpdate(object o)
		{
		}

		[Token(Token = "0x60049DD")]
		[Address(RVA = "0x4251D78", Offset = "0x424DD78", VA = "0x4251D78")]
		private void OnLegacyNoUpdate(string resourceId, object o)
		{
		}

		[Token(Token = "0x60049DE")]
		[Address(RVA = "0x4251E00", Offset = "0x424DE00", VA = "0x4251E00")]
		private void BetRecordRewardNum(object o)
		{
		}

		[Token(Token = "0x60049DF")]
		[Address(RVA = "0x4251E30", Offset = "0x424DE30", VA = "0x4251E30")]
		private void DiceNoUpdateUI(object o)
		{
		}

		[Token(Token = "0x60049E0")]
		[Address(RVA = "0x4251EA8", Offset = "0x424DEA8", VA = "0x4251EA8")]
		private void OnDiceFlyPrepare(object o)
		{
		}

		[Token(Token = "0x60049E1")]
		[Address(RVA = "0x425201C", Offset = "0x424E01C", VA = "0x425201C")]
		[AsyncStateMachine(typeof(_003CJumpToResPos_003Ed__34))]
		private void JumpToResPos(object parm)
		{
		}

		[Token(Token = "0x60049E2")]
		[Address(RVA = "0x424FE84", Offset = "0x424BE84", VA = "0x424FE84")]
		private void ConfigureDiceResourceUi()
		{
		}

		[Token(Token = "0x60049E3")]
		[Address(RVA = "0x42509F0", Offset = "0x424C9F0", VA = "0x42509F0")]
		private void RefreshDiceResourceDisplay(UserResourceUI ui)
		{
		}

		[Token(Token = "0x60049E4")]
		[Address(RVA = "0x42520AC", Offset = "0x424E0AC", VA = "0x42520AC")]
		public UserResourcesPanel()
		{
		}
	}
}
