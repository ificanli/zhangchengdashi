using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using ljzs_lt;

namespace UIModuleO
{
	[Token(Token = "0x200065B")]
	public class WorldCupDailyGiftItemView : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200065C")]
		[CompilerGenerated]
		private struct _003CEnsureCardSpritesAndRefresh_003Ed__30 : IAsyncStateMachine
		{
			[Token(Token = "0x40033B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40033B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40033B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public WorldCupDailyGiftItemView _003C_003E4__this;

			[Token(Token = "0x40033B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int showType;

			[Token(Token = "0x40033B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002179")]
			[Address(RVA = "0x3F26D50", Offset = "0x3F22D50", VA = "0x3F26D50", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600217A")]
			[Address(RVA = "0x3F27048", Offset = "0x3F23048", VA = "0x3F27048", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200065D")]
		[CompilerGenerated]
		private struct _003CEnsureCardSpritesAsync_003Ed__27 : IAsyncStateMachine
		{
			[Token(Token = "0x40033BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40033BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40033BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__1;

			[Token(Token = "0x40033BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask<(Sprite, Sprite)>.Awaiter _003C_003Eu__2;

			[Token(Token = "0x600217B")]
			[Address(RVA = "0x3F27054", Offset = "0x3F23054", VA = "0x3F27054", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600217C")]
			[Address(RVA = "0x3F27768", Offset = "0x3F23768", VA = "0x3F27768", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200065E")]
		[CompilerGenerated]
		private struct _003CLoadCardSprite_003Ed__28 : IAsyncStateMachine
		{
			[Token(Token = "0x40033BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40033BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<Sprite> _003C_003Et__builder;

			[Token(Token = "0x40033C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string path;

			[Token(Token = "0x40033C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600217D")]
			[Address(RVA = "0x3F27774", Offset = "0x3F23774", VA = "0x3F27774", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600217E")]
			[Address(RVA = "0x3F27C48", Offset = "0x3F23C48", VA = "0x3F27C48", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400339D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _backgroundImage;

		[Token(Token = "0x400339E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextMeshProUGUI _saleTagText;

		[Token(Token = "0x400339F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TextMeshProUGUI _titleText;

		[Token(Token = "0x40033A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TextMeshProUGUI _limitText;

		[Token(Token = "0x40033A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _rewardRoot1;

		[Token(Token = "0x40033A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RectTransform _rewardRoot2;

		[Token(Token = "0x40033A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RectTransform _rewardRoot3;

		[Token(Token = "0x40033A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private RewardItemUI _rewardItem1;

		[Token(Token = "0x40033A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private RewardItemUI _rewardItem2;

		[Token(Token = "0x40033A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private RewardItemUI _rewardItem3;

		[Token(Token = "0x40033A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Button _freeButton;

		[Token(Token = "0x40033A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private TextMeshProUGUI _freeButtonText;

		[Token(Token = "0x40033A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private HWIAPButton _iapButton;

		[Token(Token = "0x40033AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _soldOutRoot;

		[Token(Token = "0x40033AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private TextMeshProUGUI _soldOutText;

		[Token(Token = "0x40033AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _saleTagRoot;

		[Token(Token = "0x40033AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private GameObject _rewardItemPrefab;

		[Token(Token = "0x40033AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private WorldCupdailyPriceConfig _config;

		[Token(Token = "0x40033AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Action<WorldCupdailyPriceConfig> _onFreeClaim;

		[Token(Token = "0x40033B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Func<bool> _tryBlockPurchase;

		[Token(Token = "0x40033B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Button _iapClickBlockerButton;

		[Token(Token = "0x40033B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Sprite _normalCardSprite;

		[Token(Token = "0x40033B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Sprite _premiumCardSprite;

		[Token(Token = "0x40033B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static bool _cardSpritesLoading;

		[Token(Token = "0x6002168")]
		[Address(RVA = "0x3F257D4", Offset = "0x3F217D4", VA = "0x3F257D4")]
		public void SetRewardItemPrefab(GameObject rewardItemPrefab)
		{
		}

		[Token(Token = "0x6002169")]
		[Address(RVA = "0x3F257DC", Offset = "0x3F217DC", VA = "0x3F257DC")]
		public void Bind(WorldCupdailyPriceConfig config, int boughtCount, Action<WorldCupdailyPriceConfig> onFreeClaim, [Optional] Func<bool> tryBlockPurchase)
		{
		}

		[Token(Token = "0x600216A")]
		[Address(RVA = "0x3F25A98", Offset = "0x3F21A98", VA = "0x3F25A98")]
		private void RefreshSaleTag(WorldCupdailyPriceConfig config)
		{
		}

		[Token(Token = "0x600216B")]
		[Address(RVA = "0x3F2619C", Offset = "0x3F2219C", VA = "0x3F2619C")]
		[AsyncStateMachine(typeof(_003CEnsureCardSpritesAsync_003Ed__27))]
		public static UniTask EnsureCardSpritesAsync()
		{
			return default;
		}

		[Token(Token = "0x600216C")]
		[Address(RVA = "0x3F26220", Offset = "0x3F22220", VA = "0x3F26220")]
		[AsyncStateMachine(typeof(_003CLoadCardSprite_003Ed__28))]
		private static UniTask<Sprite> LoadCardSprite(string path)
		{
			return default;
		}

		[Token(Token = "0x600216D")]
		[Address(RVA = "0x3F25C6C", Offset = "0x3F21C6C", VA = "0x3F25C6C")]
		private void RefreshCardBackground(int showType)
		{
		}

		[Token(Token = "0x600216E")]
		[Address(RVA = "0x3F262F4", Offset = "0x3F222F4", VA = "0x3F262F4")]
		[AsyncStateMachine(typeof(_003CEnsureCardSpritesAndRefresh_003Ed__30))]
		private UniTaskVoid EnsureCardSpritesAndRefresh(int showType)
		{
			return default;
		}

		[Token(Token = "0x600216F")]
		[Address(RVA = "0x3F25DBC", Offset = "0x3F21DBC", VA = "0x3F25DBC")]
		private void RefreshRewards(WorldCupdailyPriceConfig config)
		{
		}

		[Token(Token = "0x6002170")]
		[Address(RVA = "0x3F2637C", Offset = "0x3F2237C", VA = "0x3F2637C")]
		private void SetReward(RectTransform rewardRoot, RewardItemUI rewardItem, int itemType, int itemId, int count)
		{
		}

		[Token(Token = "0x6002171")]
		[Address(RVA = "0x3F26620", Offset = "0x3F22620", VA = "0x3F26620")]
		private RewardItemUI EnsureRewardItem(RectTransform rewardRoot, RewardItemUI rewardItem)
		{
			return null;
		}

		[Token(Token = "0x6002172")]
		[Address(RVA = "0x3F267C8", Offset = "0x3F227C8", VA = "0x3F267C8")]
		private static void Stretch(RectTransform rect, Vector2 offsetMin, Vector2 offsetMax)
		{
		}

		[Token(Token = "0x6002173")]
		[Address(RVA = "0x3F259EC", Offset = "0x3F219EC", VA = "0x3F259EC")]
		private static string ResolveGiftTitle(WorldCupdailyPriceConfig config)
		{
			return null;
		}

		[Token(Token = "0x6002174")]
		[Address(RVA = "0x3F25E5C", Offset = "0x3F21E5C", VA = "0x3F25E5C")]
		private void RefreshButtons(WorldCupdailyPriceConfig config, int remain)
		{
		}

		[Token(Token = "0x6002175")]
		[Address(RVA = "0x3F268A4", Offset = "0x3F228A4", VA = "0x3F268A4")]
		private void EnsureIapClickBlocker()
		{
		}

		[Token(Token = "0x6002176")]
		[Address(RVA = "0x3F26CE8", Offset = "0x3F22CE8", VA = "0x3F26CE8")]
		private void OnIapClickBlockerClicked()
		{
		}

		[Token(Token = "0x6002177")]
		[Address(RVA = "0x3F26D28", Offset = "0x3F22D28", VA = "0x3F26D28")]
		private void OnFreeButtonClicked()
		{
		}

		[Token(Token = "0x6002178")]
		[Address(RVA = "0x3F26D48", Offset = "0x3F22D48", VA = "0x3F26D48")]
		public WorldCupDailyGiftItemView()
		{
		}
	}
}
