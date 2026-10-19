using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using Il2CppDummyDll;
using Spine.Unity;
using StrConstants;
using SuperScrollView;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000823")]
	public class ExpressionView : ExpressionViewComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000828")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__23 : IAsyncStateMachine
		{
			[Token(Token = "0x4003E38")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003E39")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003E3A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ExpressionView _003C_003E4__this;

			[Token(Token = "0x4003E3B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x4003E3C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002DA5")]
			[Address(RVA = "0x4010DB8", Offset = "0x400CDB8", VA = "0x4010DB8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002DA6")]
			[Address(RVA = "0x40111C8", Offset = "0x400D1C8", VA = "0x40111C8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000829")]
		[CompilerGenerated]
		private struct _003CShowReplace_003Ed__29 : IAsyncStateMachine
		{
			[Token(Token = "0x4003E3D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003E3E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003E3F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ExpressionView _003C_003E4__this;

			[Token(Token = "0x4003E40")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public GlobalExpression expression;

			[Token(Token = "0x4003E41")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask<SkeletonDataAsset>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002DA7")]
			[Address(RVA = "0x40111D4", Offset = "0x400D1D4", VA = "0x40111D4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002DA8")]
			[Address(RVA = "0x4011650", Offset = "0x400D650", VA = "0x4011650", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003E1D")]
		private const string ItemName = "ExpressionViewLoopItem";

		[Token(Token = "0x4003E1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Toggle ToggleExpression;

		[Token(Token = "0x4003E1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Toggle ToggleBubble;

		[Token(Token = "0x4003E20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private RectTransform BubbleUsing;

		[Token(Token = "0x4003E21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private RectTransform BubbleTitleBg;

		[Token(Token = "0x4003E22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private List<BubbleViewUsingItem> BubbleUsingItems;

		[Token(Token = "0x4003E23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private BubbleViewLoopItem BubbleLoopItemTemp;

		[Token(Token = "0x4003E24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private List<GlobalExpression> _allExpressionInfos;

		[Token(Token = "0x4003E25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private List<GlobalExpression> _availableExpressionInfos;

		[Token(Token = "0x4003E26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private List<ExpressionViewUsingItem> _usingItems;

		[Token(Token = "0x4003E27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private readonly List<BubbleViewLoopItem> _bubbleLoopItems;

		[Token(Token = "0x4003E28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private List<BubbleTextConstants.BubbleTextInfo> _allBubbleInfos;

		[Token(Token = "0x4003E29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private List<BubbleTextConstants.BubbleTextInfo> _availableBubbleInfos;

		[Token(Token = "0x4003E2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private bool _hasInitLoopView;

		[Token(Token = "0x4003E2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF1")]
		private bool _showBubbleTab;

		[Token(Token = "0x4003E2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF2")]
		[HideInInspector]
		public bool _isSelectExpression;

		[Token(Token = "0x4003E2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[HideInInspector]
		public string _isSelectExpressionId;

		[Token(Token = "0x4003E2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private string _selectBubbleId;

		[Token(Token = "0x1700051F")]
		public bool IsSelectBubble
		{
			[Token(Token = "0x6002D71")]
			[Address(RVA = "0x400E168", Offset = "0x400A168", VA = "0x400E168")]
			[CompilerGenerated]
			get;
			[Token(Token = "0x6002D72")]
			[Address(RVA = "0x400E170", Offset = "0x400A170", VA = "0x400E170")]
			[CompilerGenerated]
			private set;
		}

		[Token(Token = "0x6002D73")]
		[Address(RVA = "0x400E17C", Offset = "0x400A17C", VA = "0x400E17C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6002D74")]
		[Address(RVA = "0x400E9FC", Offset = "0x400A9FC", VA = "0x400E9FC", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__23))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6002D75")]
		[Address(RVA = "0x400EA98", Offset = "0x400AA98", VA = "0x400EA98", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6002D76")]
		[Address(RVA = "0x400EBC4", Offset = "0x400ABC4", VA = "0x400EBC4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6002D77")]
		[Address(RVA = "0x400ED44", Offset = "0x400AD44", VA = "0x400ED44")]
		public void RefreshView()
		{
		}

		[Token(Token = "0x6002D78")]
		[Address(RVA = "0x400EDD4", Offset = "0x400ADD4", VA = "0x400EDD4")]
		public void SelectLoopsListItem(string infoId)
		{
		}

		[Token(Token = "0x6002D79")]
		[Address(RVA = "0x400EECC", Offset = "0x400AECC", VA = "0x400EECC")]
		public void DeselectLoopsListItem([Optional] string clickedItemId)
		{
		}

		[Token(Token = "0x6002D7A")]
		[Address(RVA = "0x400EF34", Offset = "0x400AF34", VA = "0x400EF34")]
		[AsyncStateMachine(typeof(_003CShowReplace_003Ed__29))]
		public void ShowReplace(GlobalExpression expression)
		{
		}

		[Token(Token = "0x6002D7B")]
		[Address(RVA = "0x400EFD0", Offset = "0x400AFD0", VA = "0x400EFD0")]
		public void SelectExpression(int replaceIndex)
		{
		}

		[Token(Token = "0x6002D7C")]
		[Address(RVA = "0x400DB50", Offset = "0x4009B50", VA = "0x400DB50")]
		public void StartBubbleEquip(BubbleTextConstants.BubbleTextInfo bubbleInfo)
		{
		}

		[Token(Token = "0x6002D7D")]
		[Address(RVA = "0x400DAF4", Offset = "0x4009AF4", VA = "0x400DAF4")]
		public bool IsBubbleEquipSelected(string bubbleId)
		{
			return default;
		}

		[Token(Token = "0x6002D7E")]
		[Address(RVA = "0x400E03C", Offset = "0x400A03C", VA = "0x400E03C")]
		public void SelectBubble(int replaceIndex)
		{
		}

		[Token(Token = "0x6002D7F")]
		[Address(RVA = "0x400E7DC", Offset = "0x400A7DC", VA = "0x400E7DC")]
		private void BindTabToggles()
		{
		}

		[Token(Token = "0x6002D80")]
		[Address(RVA = "0x400F21C", Offset = "0x400B21C", VA = "0x400F21C")]
		private void OnExpressionTabChanged(bool isOn)
		{
		}

		[Token(Token = "0x6002D81")]
		[Address(RVA = "0x400F26C", Offset = "0x400B26C", VA = "0x400F26C")]
		private void OnBubbleTabChanged(bool isOn)
		{
		}

		[Token(Token = "0x6002D82")]
		[Address(RVA = "0x400F22C", Offset = "0x400B22C", VA = "0x400F22C")]
		private void SetTab(bool showBubbleTab)
		{
		}

		[Token(Token = "0x6002D83")]
		[Address(RVA = "0x400ED94", Offset = "0x400AD94", VA = "0x400ED94")]
		private void RefreshExpressionView()
		{
		}

		[Token(Token = "0x6002D84")]
		[Address(RVA = "0x400F3FC", Offset = "0x400B3FC", VA = "0x400F3FC")]
		private void ResetReplaceState()
		{
		}

		[Token(Token = "0x6002D85")]
		[Address(RVA = "0x400F498", Offset = "0x400B498", VA = "0x400F498")]
		private void LoadAndFilterExpressions()
		{
		}

		[Token(Token = "0x6002D86")]
		[Address(RVA = "0x400F9D4", Offset = "0x400B9D4", VA = "0x400F9D4")]
		private void FilterAvailableExpressions()
		{
		}

		[Token(Token = "0x6002D87")]
		[Address(RVA = "0x400F554", Offset = "0x400B554", VA = "0x400F554")]
		private void UpdateLoopGridView()
		{
		}

		[Token(Token = "0x6002D88")]
		[Address(RVA = "0x400F65C", Offset = "0x400B65C", VA = "0x400F65C")]
		private void RefreshUsingExpressions()
		{
		}

		[Token(Token = "0x6002D89")]
		[Address(RVA = "0x400EE50", Offset = "0x400AE50", VA = "0x400EE50")]
		private void TryRefreshDeselectedItem(string deselectedId, string clickedItemId)
		{
		}

		[Token(Token = "0x6002D8A")]
		[Address(RVA = "0x400ED54", Offset = "0x400AD54", VA = "0x400ED54")]
		private void RefreshBubbleView()
		{
		}

		[Token(Token = "0x6002D8B")]
		[Address(RVA = "0x400FE30", Offset = "0x400BE30", VA = "0x400FE30")]
		private void ResetBubbleEquipState()
		{
		}

		[Token(Token = "0x6002D8C")]
		[Address(RVA = "0x400EAB0", Offset = "0x400AAB0", VA = "0x400EAB0")]
		private void StopBubbleEquipState()
		{
		}

		[Token(Token = "0x6002D8D")]
		[Address(RVA = "0x400F0D4", Offset = "0x400B0D4", VA = "0x400F0D4")]
		private void PlayBubbleUsingEquipShake()
		{
		}

		[Token(Token = "0x6002D8E")]
		[Address(RVA = "0x40103E4", Offset = "0x400C3E4", VA = "0x40103E4")]
		private void StopBubbleUsingEquipShake()
		{
		}

		[Token(Token = "0x6002D8F")]
		[Address(RVA = "0x400FECC", Offset = "0x400BECC", VA = "0x400FECC")]
		private void LoadAndFilterBubbles()
		{
		}

		[Token(Token = "0x6002D90")]
		[Address(RVA = "0x40100A4", Offset = "0x400C0A4", VA = "0x40100A4")]
		private void RefreshBubbleUsingItems()
		{
		}

		[Token(Token = "0x6002D91")]
		[Address(RVA = "0x4010220", Offset = "0x400C220", VA = "0x4010220")]
		private void RefreshBubbleLoopItems()
		{
		}

		[Token(Token = "0x6002D92")]
		[Address(RVA = "0x400F178", Offset = "0x400B178", VA = "0x400F178")]
		private void RefreshBubbleLoopItemSelectStates()
		{
		}

		[Token(Token = "0x6002D93")]
		[Address(RVA = "0x4010490", Offset = "0x400C490", VA = "0x4010490")]
		private void EnsureBubbleLoopItemCount(int itemCount)
		{
		}

		[Token(Token = "0x6002D94")]
		[Address(RVA = "0x400F27C", Offset = "0x400B27C", VA = "0x400F27C")]
		private void SetExpressionRootActive(bool active)
		{
		}

		[Token(Token = "0x6002D95")]
		[Address(RVA = "0x400F310", Offset = "0x400B310", VA = "0x400F310")]
		private void SetBubbleRootActive(bool active)
		{
		}

		[Token(Token = "0x6002D96")]
		[Address(RVA = "0x400FD2C", Offset = "0x400BD2C", VA = "0x400FD2C")]
		private int GetItemIndexByExpressionId(string expressionId)
		{
			return default;
		}

		[Token(Token = "0x6002D97")]
		[Address(RVA = "0x401074C", Offset = "0x400C74C", VA = "0x401074C")]
		private LoopGridViewItem OnGetItem(LoopGridView loopGridView, int index, int row, int column)
		{
			return null;
		}

		[Token(Token = "0x6002D98")]
		[Address(RVA = "0x401093C", Offset = "0x400C93C", VA = "0x401093C")]
		private static void SetSpineToLastFrame(SkeletonGraphic skeletonGraphic)
		{
		}

		[Token(Token = "0x6002D99")]
		[Address(RVA = "0x4010A40", Offset = "0x400CA40", VA = "0x4010A40")]
		public ExpressionView()
		{
		}
	}
}
