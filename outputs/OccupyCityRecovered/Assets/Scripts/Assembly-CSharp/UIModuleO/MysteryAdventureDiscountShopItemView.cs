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
	[Token(Token = "0x20009D4")]
	public class MysteryAdventureDiscountShopItemView : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20009D5")]
		[CompilerGenerated]
		private struct _003CRefreshPriceIconAsync_003Ed__18 : IAsyncStateMachine
		{
			[Token(Token = "0x4004944")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004945")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004946")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public MysteryAdventureDiscountShopItemView _003C_003E4__this;

			[Token(Token = "0x4004947")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public SaleShopConfig config;

			[Token(Token = "0x4004948")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int _003CrequestId_003E5__2;

			[Token(Token = "0x4004949")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003AA6")]
			[Address(RVA = "0x4119AA4", Offset = "0x4115AA4", VA = "0x4119AA4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003AA7")]
			[Address(RVA = "0x411A00C", Offset = "0x411600C", VA = "0x411A00C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004939")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _backgroundImage;

		[Token(Token = "0x400493A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextMeshProUGUI _saleTagText;

		[Token(Token = "0x400493B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TextMeshProUGUI _titleText;

		[Token(Token = "0x400493C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RewardItemUI _rewardItemUi;

		[Token(Token = "0x400493D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TextMeshProUGUI _priceText;

		[Token(Token = "0x400493E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _priceIcon;

		[Token(Token = "0x400493F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Button _buyButton;

		[Token(Token = "0x4004940")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _soldOutRoot;

		[Token(Token = "0x4004941")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private SaleShopConfig _config;

		[Token(Token = "0x4004942")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Action<SaleShopConfig> _onBuy;

		[Token(Token = "0x4004943")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int _priceIconRequestId;

		[Token(Token = "0x6003A99")]
		[Address(RVA = "0x4118A44", Offset = "0x4114A44", VA = "0x4118A44")]
		private void Awake()
		{
		}

		[Token(Token = "0x6003A9A")]
		[Address(RVA = "0x4118EA0", Offset = "0x4114EA0", VA = "0x4118EA0")]
		public void Bind(SaleShopConfig config, bool purchased, Action<SaleShopConfig> onBuy)
		{
		}

		[Token(Token = "0x6003A9B")]
		[Address(RVA = "0x4118F60", Offset = "0x4114F60", VA = "0x4118F60")]
		private void RefreshSaleTag(SaleShopConfig config)
		{
		}

		[Token(Token = "0x6003A9C")]
		[Address(RVA = "0x4119198", Offset = "0x4115198", VA = "0x4119198")]
		private void RefreshTitle(SaleShopConfig config)
		{
		}

		[Token(Token = "0x6003A9D")]
		[Address(RVA = "0x4119468", Offset = "0x4115468", VA = "0x4119468")]
		private void RefreshReward(SaleShopConfig config)
		{
		}

		[Token(Token = "0x6003A9E")]
		[Address(RVA = "0x411998C", Offset = "0x411598C", VA = "0x411998C")]
		private static void ConfigureDiscountShopRewardItemUi(RewardItemUI rewardItemUi)
		{
		}

		[Token(Token = "0x6003A9F")]
		[Address(RVA = "0x41196C0", Offset = "0x41156C0", VA = "0x41196C0")]
		private void RefreshPrice(SaleShopConfig config)
		{
		}

		[Token(Token = "0x6003AA0")]
		[Address(RVA = "0x4119774", Offset = "0x4115774", VA = "0x4119774")]
		[AsyncStateMachine(typeof(_003CRefreshPriceIconAsync_003Ed__18))]
		private UniTaskVoid RefreshPriceIconAsync(SaleShopConfig config)
		{
			return default;
		}

		[Token(Token = "0x6003AA1")]
		[Address(RVA = "0x41199BC", Offset = "0x41159BC", VA = "0x41199BC")]
		private static string GetBuyCurrencySpritePath(int buyItem)
		{
			return null;
		}

		[Token(Token = "0x6003AA2")]
		[Address(RVA = "0x41197F8", Offset = "0x41157F8", VA = "0x41197F8")]
		private void RefreshButtonState(bool purchased)
		{
		}

		[Token(Token = "0x6003AA3")]
		[Address(RVA = "0x4119A7C", Offset = "0x4115A7C", VA = "0x4119A7C")]
		private void OnBuyClicked()
		{
		}

		[Token(Token = "0x6003AA4")]
		[Address(RVA = "0x4118A48", Offset = "0x4114A48", VA = "0x4118A48")]
		private void ResolveReferences()
		{
		}

		[Token(Token = "0x6003AA5")]
		[Address(RVA = "0x4119A9C", Offset = "0x4115A9C", VA = "0x4119A9C")]
		public MysteryAdventureDiscountShopItemView()
		{
		}
	}
}
