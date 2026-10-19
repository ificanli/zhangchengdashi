using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000A49")]
	public class MysteryAdventureRulesPanelView : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A4C")]
		[CompilerGenerated]
		private struct _003CEnsureReadyAsync_003Ed__34 : IAsyncStateMachine
		{
			[Token(Token = "0x4004C3E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004C3F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004C40")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MysteryAdventureRulesPanelView _003C_003E4__this;

			[Token(Token = "0x4004C41")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask<MysteryAdventureRulesUiSprites>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003DAB")]
			[Address(RVA = "0x415F6EC", Offset = "0x415B6EC", VA = "0x415F6EC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003DAC")]
			[Address(RVA = "0x415FBB8", Offset = "0x415BBB8", VA = "0x415FBB8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004C23")]
		private const int BuildingBannerIndex = 7;

		[Token(Token = "0x4004C24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Color InactiveTabTextColor;

		[Token(Token = "0x4004C25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Button _closeButton;

		[Token(Token = "0x4004C26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextMeshProUGUI _panelTitleText;

		[Token(Token = "0x4004C27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Button _rulesTabButton;

		[Token(Token = "0x4004C28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Button _buildingTabButton;

		[Token(Token = "0x4004C29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _rulesTabImage;

		[Token(Token = "0x4004C2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _buildingTabImage;

		[Token(Token = "0x4004C2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Button _prevPageButton;

		[Token(Token = "0x4004C2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Button _nextPageButton;

		[Token(Token = "0x4004C2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private RectTransform _pageDotRoot;

		[Token(Token = "0x4004C2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private MysteryAdventureRulesItemView[] _items;

		[Token(Token = "0x4004C2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Header("建筑说明图标顺序")]
		[Tooltip("第 1 项对应 buildIndex=1，第 2 项对应 buildIndex=2。调整数组元素顺序或替换路径即可更换展示图标。")]
		[SerializeField]
		private string[] _buildingIconPaths;

		[Token(Token = "0x4004C30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private readonly List<Toggle> _pageToggles;

		[Token(Token = "0x4004C31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private readonly MysteryAdventureRulesEntry[] _pageBuffer;

		[Token(Token = "0x4004C32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Action _onClose;

		[Token(Token = "0x4004C33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private MysteryAdventureRulesUiSprites _sprites;

		[Token(Token = "0x4004C34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool _showBuildingTab;

		[Token(Token = "0x4004C35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private int _currentPage;

		[Token(Token = "0x4004C36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private bool _pageTogglesBound;

		[Token(Token = "0x4004C37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		private bool _updatingPageToggles;

		[Token(Token = "0x4004C38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private IReadOnlyList<MysteryAdventureRulesEntry> _ruleEntries;

		[Token(Token = "0x4004C39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private IReadOnlyList<MysteryAdventureRulesEntry> _buildingEntries;

		[Token(Token = "0x1700094A")]
		public Button CloseButton
		{
			[Token(Token = "0x6003D7B")]
			[Address(RVA = "0x415DA28", Offset = "0x4159A28", VA = "0x415DA28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700094B")]
		public Button RulesTabButton
		{
			[Token(Token = "0x6003D7C")]
			[Address(RVA = "0x415DA30", Offset = "0x4159A30", VA = "0x415DA30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700094C")]
		public Button BuildingTabButton
		{
			[Token(Token = "0x6003D7D")]
			[Address(RVA = "0x415DA38", Offset = "0x4159A38", VA = "0x415DA38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700094D")]
		public Button PrevPageButton
		{
			[Token(Token = "0x6003D7E")]
			[Address(RVA = "0x415DA40", Offset = "0x4159A40", VA = "0x415DA40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700094E")]
		public Button NextPageButton
		{
			[Token(Token = "0x6003D7F")]
			[Address(RVA = "0x415DA48", Offset = "0x4159A48", VA = "0x415DA48")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700094F")]
		public IReadOnlyList<string> BuildingIconPaths
		{
			[Token(Token = "0x6003D82")]
			[Address(RVA = "0x415E5F0", Offset = "0x415A5F0", VA = "0x415E5F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003D80")]
		[Address(RVA = "0x415DA50", Offset = "0x4159A50", VA = "0x415DA50")]
		public void Initialize(Action onClose)
		{
		}

		[Token(Token = "0x6003D81")]
		[Address(RVA = "0x415E560", Offset = "0x415A560", VA = "0x415E560")]
		[AsyncStateMachine(typeof(_003CEnsureReadyAsync_003Ed__34))]
		public UniTask EnsureReadyAsync()
		{
			return default;
		}

		[Token(Token = "0x6003D83")]
		[Address(RVA = "0x415E5F4", Offset = "0x415A5F4", VA = "0x415E5F4")]
		private string[] GetBuildingIconPaths()
		{
			return null;
		}

		[Token(Token = "0x6003D84")]
		[Address(RVA = "0x415E660", Offset = "0x415A660", VA = "0x415E660")]
		public void ShowTab(bool showBuildingTab, int pageIndex = 0)
		{
		}

		[Token(Token = "0x6003D85")]
		[Address(RVA = "0x415E69C", Offset = "0x415A69C", VA = "0x415E69C")]
		public void SetPage(int pageIndex)
		{
		}

		[Token(Token = "0x6003D86")]
		[Address(RVA = "0x415E6A8", Offset = "0x415A6A8", VA = "0x415E6A8")]
		public void GoPrevPage()
		{
		}

		[Token(Token = "0x6003D87")]
		[Address(RVA = "0x415E6C0", Offset = "0x415A6C0", VA = "0x415E6C0")]
		public void GoNextPage()
		{
		}

		[Token(Token = "0x6003D88")]
		[Address(RVA = "0x415E674", Offset = "0x415A674", VA = "0x415E674")]
		public void Refresh()
		{
		}

		[Token(Token = "0x6003D89")]
		[Address(RVA = "0x415E11C", Offset = "0x415A11C", VA = "0x415E11C")]
		private void SetAllItemsVisible(bool visible)
		{
		}

		[Token(Token = "0x6003D8A")]
		[Address(RVA = "0x415E9C8", Offset = "0x415A9C8", VA = "0x415E9C8")]
		private void ApplyContent()
		{
		}

		[Token(Token = "0x6003D8B")]
		[Address(RVA = "0x415E710", Offset = "0x415A710", VA = "0x415E710")]
		private int GetPageCount()
		{
			return default;
		}

		[Token(Token = "0x6003D8C")]
		[Address(RVA = "0x415E72C", Offset = "0x415A72C", VA = "0x415E72C")]
		private void ApplyTabVisual()
		{
		}

		[Token(Token = "0x6003D8D")]
		[Address(RVA = "0x415ECA4", Offset = "0x415ACA4", VA = "0x415ECA4")]
		private void ApplyTabState(Image tabImage, Button tabButton, bool active)
		{
		}

		[Token(Token = "0x6003D8E")]
		[Address(RVA = "0x415E7F4", Offset = "0x415A7F4", VA = "0x415E7F4")]
		private void ApplyPaginationVisual()
		{
		}

		[Token(Token = "0x6003D8F")]
		[Address(RVA = "0x415EE98", Offset = "0x415AE98", VA = "0x415EE98")]
		private void EnsurePageToggles()
		{
		}

		[Token(Token = "0x6003D90")]
		[Address(RVA = "0x415F194", Offset = "0x415B194", VA = "0x415F194")]
		private void OnPageToggleChanged(int pageIndex, bool isOn)
		{
		}

		[Token(Token = "0x6003D91")]
		[Address(RVA = "0x415F1BC", Offset = "0x415B1BC", VA = "0x415F1BC")]
		private void ApplyStaticSprites()
		{
		}

		[Token(Token = "0x6003D92")]
		[Address(RVA = "0x415F298", Offset = "0x415B298", VA = "0x415F298")]
		private static void ApplyImageSprite(Image image, Sprite sprite, bool sliced)
		{
		}

		[Token(Token = "0x6003D93")]
		[Address(RVA = "0x415E1AC", Offset = "0x415A1AC", VA = "0x415E1AC")]
		private void BindCloseButton()
		{
		}

		[Token(Token = "0x6003D94")]
		[Address(RVA = "0x415E29C", Offset = "0x415A29C", VA = "0x415E29C")]
		private void BindPanelButtons()
		{
		}

		[Token(Token = "0x6003D95")]
		[Address(RVA = "0x415DA94", Offset = "0x4159A94", VA = "0x415DA94")]
		private void ResolveReferences()
		{
		}

		[Token(Token = "0x6003D96")]
		[Address(RVA = "0x415F39C", Offset = "0x415B39C", VA = "0x415F39C")]
		private static bool HasNullItem(MysteryAdventureRulesItemView[] items)
		{
			return default;
		}

		[Token(Token = "0x6003D97")]
		[Address(RVA = "0x415F460", Offset = "0x415B460", VA = "0x415F460")]
		internal void BindCloseButtonRef(Button button)
		{
		}

		[Token(Token = "0x6003D98")]
		[Address(RVA = "0x415F468", Offset = "0x415B468", VA = "0x415F468")]
		internal void BindPanelTitleTextRef(TextMeshProUGUI text)
		{
		}

		[Token(Token = "0x6003D99")]
		[Address(RVA = "0x415F470", Offset = "0x415B470", VA = "0x415F470")]
		internal void BindRulesTabButtonRef(Button button)
		{
		}

		[Token(Token = "0x6003D9A")]
		[Address(RVA = "0x415F478", Offset = "0x415B478", VA = "0x415F478")]
		internal void BindBuildingTabButtonRef(Button button)
		{
		}

		[Token(Token = "0x6003D9B")]
		[Address(RVA = "0x415F480", Offset = "0x415B480", VA = "0x415F480")]
		internal void BindRulesTabImageRef(Image image)
		{
		}

		[Token(Token = "0x6003D9C")]
		[Address(RVA = "0x415F488", Offset = "0x415B488", VA = "0x415F488")]
		internal void BindBuildingTabImageRef(Image image)
		{
		}

		[Token(Token = "0x6003D9D")]
		[Address(RVA = "0x415F490", Offset = "0x415B490", VA = "0x415F490")]
		internal void BindPrevPageButtonRef(Button button)
		{
		}

		[Token(Token = "0x6003D9E")]
		[Address(RVA = "0x415F498", Offset = "0x415B498", VA = "0x415F498")]
		internal void BindNextPageButtonRef(Button button)
		{
		}

		[Token(Token = "0x6003D9F")]
		[Address(RVA = "0x415F4A0", Offset = "0x415B4A0", VA = "0x415F4A0")]
		internal void BindPageDotRootRef(RectTransform root)
		{
		}

		[Token(Token = "0x6003DA0")]
		[Address(RVA = "0x415F4A8", Offset = "0x415B4A8", VA = "0x415F4A8")]
		internal void BindItemsRef(MysteryAdventureRulesItemView[] items)
		{
		}

		[Token(Token = "0x6003DA1")]
		[Address(RVA = "0x415F4B0", Offset = "0x415B4B0", VA = "0x415F4B0")]
		public MysteryAdventureRulesPanelView()
		{
		}
	}
}
