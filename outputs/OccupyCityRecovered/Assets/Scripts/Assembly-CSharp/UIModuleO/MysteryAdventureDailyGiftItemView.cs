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
	[Token(Token = "0x20009BF")]
	public class MysteryAdventureDailyGiftItemView : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20009C1")]
		[CompilerGenerated]
		private struct _003CApplySsrFrameOverrideAsync_003Ed__37 : IAsyncStateMachine
		{
			[Token(Token = "0x40048C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40048C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40048C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RewardItemUI rewardItem;

			[Token(Token = "0x40048C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Sprite _003Csprite_003E5__2;

			[Token(Token = "0x40048C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003A13")]
			[Address(RVA = "0x410DF38", Offset = "0x4109F38", VA = "0x410DF38", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003A14")]
			[Address(RVA = "0x410E750", Offset = "0x410A750", VA = "0x410E750", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20009C2")]
		[CompilerGenerated]
		private struct _003CEnsureCardSpritesAndRefresh_003Ed__34 : IAsyncStateMachine
		{
			[Token(Token = "0x40048CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40048CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40048CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public MysteryAdventureDailyGiftItemView _003C_003E4__this;

			[Token(Token = "0x40048CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int showType;

			[Token(Token = "0x40048CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003A15")]
			[Address(RVA = "0x410E75C", Offset = "0x410A75C", VA = "0x410E75C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003A16")]
			[Address(RVA = "0x410EA54", Offset = "0x410AA54", VA = "0x410EA54", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20009C3")]
		[CompilerGenerated]
		private struct _003CEnsureCardSpritesAsync_003Ed__30 : IAsyncStateMachine
		{
			[Token(Token = "0x40048CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40048D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40048D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__1;

			[Token(Token = "0x40048D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask<(Sprite, Sprite)>.Awaiter _003C_003Eu__2;

			[Token(Token = "0x6003A17")]
			[Address(RVA = "0x410EA60", Offset = "0x410AA60", VA = "0x410EA60", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003A18")]
			[Address(RVA = "0x410F0D0", Offset = "0x410B0D0", VA = "0x410F0D0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20009C4")]
		[CompilerGenerated]
		private struct _003CLoadCardSprite_003Ed__31 : IAsyncStateMachine
		{
			[Token(Token = "0x40048D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40048D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<Sprite> _003C_003Et__builder;

			[Token(Token = "0x40048D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string path;

			[Token(Token = "0x40048D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003A19")]
			[Address(RVA = "0x410F0DC", Offset = "0x410B0DC", VA = "0x410F0DC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003A1A")]
			[Address(RVA = "0x410F5B0", Offset = "0x410B5B0", VA = "0x410F5B0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40048AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _backgroundImage;

		[Token(Token = "0x40048AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextMeshProUGUI _saleTagText;

		[Token(Token = "0x40048AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TextMeshProUGUI _titleText;

		[Token(Token = "0x40048AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TextMeshProUGUI _limitText;

		[Token(Token = "0x40048B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _rewardRoot1;

		[Token(Token = "0x40048B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RectTransform _rewardRoot2;

		[Token(Token = "0x40048B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RectTransform _rewardRoot3;

		[Token(Token = "0x40048B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Button _freeButton;

		[Token(Token = "0x40048B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private TextMeshProUGUI _freeButtonText;

		[Token(Token = "0x40048B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private HWIAPButton _iapButton;

		[Token(Token = "0x40048B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _soldOutRoot;

		[Token(Token = "0x40048B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private TextMeshProUGUI _soldOutText;

		[Token(Token = "0x40048B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private RewardItemUI _rewardItem1;

		[Token(Token = "0x40048B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private RewardItemUI _rewardItem2;

		[Token(Token = "0x40048BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private RewardItemUI _rewardItem3;

		[Token(Token = "0x40048BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private GameObject _rewardItemPrefab;

		[Token(Token = "0x40048BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private DailyPriceConfig _config;

		[Token(Token = "0x40048BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Action<DailyPriceConfig> _onFreeClaim;

		[Token(Token = "0x40048BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Func<bool> _tryBlockPurchase;

		[Token(Token = "0x40048BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Button _iapClickBlockerButton;

		[Token(Token = "0x40048C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Sprite _normalCardSprite;

		[Token(Token = "0x40048C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Sprite _premiumCardSprite;

		[Token(Token = "0x40048C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static bool _cardSpritesLoading;

		[Token(Token = "0x60039F9")]
		[Address(RVA = "0x410C15C", Offset = "0x410815C", VA = "0x410C15C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60039FA")]
		[Address(RVA = "0x410C5AC", Offset = "0x41085AC", VA = "0x410C5AC")]
		public void SetRewardItemPrefab(GameObject rewardItemPrefab)
		{
		}

		[Token(Token = "0x60039FB")]
		[Address(RVA = "0x410C5B4", Offset = "0x41085B4", VA = "0x410C5B4")]
		public void Bind(DailyPriceConfig config, int boughtCount, Action<DailyPriceConfig> onFreeClaim, [Optional] Func<bool> tryBlockPurchase)
		{
		}

		[Token(Token = "0x60039FC")]
		[Address(RVA = "0x410C17C", Offset = "0x410817C", VA = "0x410C17C")]
		private void ResolveRewardRoots()
		{
		}

		[Token(Token = "0x60039FD")]
		[Address(RVA = "0x410C34C", Offset = "0x410834C", VA = "0x410C34C")]
		private void ResolveSaleTagReferences()
		{
		}

		[Token(Token = "0x60039FE")]
		[Address(RVA = "0x410C484", Offset = "0x4108484", VA = "0x410C484")]
		private void ResolveSoldOutReferences()
		{
		}

		[Token(Token = "0x60039FF")]
		[Address(RVA = "0x410C8AC", Offset = "0x41088AC", VA = "0x410C8AC")]
		private void RefreshSaleTag(DailyPriceConfig config)
		{
		}

		[Token(Token = "0x6003A00")]
		[Address(RVA = "0x410D00C", Offset = "0x410900C", VA = "0x410D00C")]
		[AsyncStateMachine(typeof(_003CEnsureCardSpritesAsync_003Ed__30))]
		public static UniTask EnsureCardSpritesAsync()
		{
			return default;
		}

		[Token(Token = "0x6003A01")]
		[Address(RVA = "0x410D090", Offset = "0x4109090", VA = "0x410D090")]
		[AsyncStateMachine(typeof(_003CLoadCardSprite_003Ed__31))]
		private static UniTask<Sprite> LoadCardSprite(string path)
		{
			return default;
		}

		[Token(Token = "0x6003A02")]
		[Address(RVA = "0x410D164", Offset = "0x4109164", VA = "0x410D164")]
		private Image GetBackgroundImage()
		{
			return null;
		}

		[Token(Token = "0x6003A03")]
		[Address(RVA = "0x410CAE4", Offset = "0x4108AE4", VA = "0x410CAE4")]
		private void RefreshCardBackground(int showType)
		{
		}

		[Token(Token = "0x6003A04")]
		[Address(RVA = "0x410D1F8", Offset = "0x41091F8", VA = "0x410D1F8")]
		[AsyncStateMachine(typeof(_003CEnsureCardSpritesAndRefresh_003Ed__34))]
		private UniTaskVoid EnsureCardSpritesAndRefresh(int showType)
		{
			return default;
		}

		[Token(Token = "0x6003A05")]
		[Address(RVA = "0x410CC38", Offset = "0x4108C38", VA = "0x410CC38")]
		private void RefreshRewards(DailyPriceConfig config)
		{
		}

		[Token(Token = "0x6003A06")]
		[Address(RVA = "0x410D280", Offset = "0x4109280", VA = "0x410D280")]
		private void SetReward(RectTransform rewardRoot, ref RewardItemUI rewardItem, int itemType, int itemId, int count)
		{
		}

		[Token(Token = "0x6003A07")]
		[Address(RVA = "0x410D87C", Offset = "0x410987C", VA = "0x410D87C")]
		[AsyncStateMachine(typeof(_003CApplySsrFrameOverrideAsync_003Ed__37))]
		private static UniTaskVoid ApplySsrFrameOverrideAsync(RewardItemUI rewardItem)
		{
			return default;
		}

		[Token(Token = "0x6003A08")]
		[Address(RVA = "0x410D6AC", Offset = "0x41096AC", VA = "0x410D6AC")]
		private RewardItemUI EnsureRewardItem(RectTransform rewardRoot, RewardItemUI rewardItem)
		{
			return null;
		}

		[Token(Token = "0x6003A09")]
		[Address(RVA = "0x410D8F8", Offset = "0x41098F8", VA = "0x410D8F8")]
		private static void Stretch(RectTransform rect, Vector2 offsetMin, Vector2 offsetMax)
		{
		}

		[Token(Token = "0x6003A0A")]
		[Address(RVA = "0x410C800", Offset = "0x4108800", VA = "0x410C800")]
		private static string ResolveGiftTitle(DailyPriceConfig config)
		{
			return null;
		}

		[Token(Token = "0x6003A0B")]
		[Address(RVA = "0x410CCD4", Offset = "0x4108CD4", VA = "0x410CCD4")]
		private void RefreshButtons(DailyPriceConfig config, int remain)
		{
		}

		[Token(Token = "0x6003A0C")]
		[Address(RVA = "0x410D9D4", Offset = "0x41099D4", VA = "0x410D9D4")]
		private void EnsureIapClickBlocker()
		{
		}

		[Token(Token = "0x6003A0D")]
		[Address(RVA = "0x410DE18", Offset = "0x4109E18", VA = "0x410DE18")]
		private void OnIapClickBlockerClicked()
		{
		}

		[Token(Token = "0x6003A0E")]
		[Address(RVA = "0x410DE58", Offset = "0x4109E58", VA = "0x410DE58")]
		private void OnFreeButtonClicked()
		{
		}

		[Token(Token = "0x6003A0F")]
		[Address(RVA = "0x410DE78", Offset = "0x4109E78", VA = "0x410DE78")]
		public MysteryAdventureDailyGiftItemView()
		{
		}
	}
}
