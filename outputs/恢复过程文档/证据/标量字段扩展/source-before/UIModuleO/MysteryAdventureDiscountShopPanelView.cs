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
using ljzs_lt;

namespace UIModuleO
{
	[Token(Token = "0x20009D6")]
	public class MysteryAdventureDiscountShopPanelView : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20009D9")]
		[CompilerGenerated]
		private struct _003CEnsureRewardItemPrefabAsync_003Ed__28 : IAsyncStateMachine
		{
			[Token(Token = "0x400495B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400495C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400495D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MysteryAdventureDiscountShopPanelView _003C_003E4__this;

			[Token(Token = "0x400495E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Transform _003CrewardRoot_003E5__2;

			[Token(Token = "0x400495F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003AC7")]
			[Address(RVA = "0x411B340", Offset = "0x4117340", VA = "0x411B340", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003AC8")]
			[Address(RVA = "0x411BAA8", Offset = "0x4117AA8", VA = "0x411BAA8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20009DA")]
		[CompilerGenerated]
		private struct _003CHideAsync_003Ed__34 : IAsyncStateMachine
		{
			[Token(Token = "0x4004960")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004961")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004962")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MysteryAdventureDiscountShopPanelView _003C_003E4__this;

			[Token(Token = "0x4004963")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003AC9")]
			[Address(RVA = "0x411BAB4", Offset = "0x4117AB4", VA = "0x411BAB4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003ACA")]
			[Address(RVA = "0x411C124", Offset = "0x4118124", VA = "0x411C124", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20009DB")]
		[CompilerGenerated]
		private struct _003CShowAsync_003Ed__33 : IAsyncStateMachine
		{
			[Token(Token = "0x4004964")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004965")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004966")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MysteryAdventureDiscountShopPanelView _003C_003E4__this;

			[Token(Token = "0x4004967")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003ACB")]
			[Address(RVA = "0x411C130", Offset = "0x4118130", VA = "0x411C130", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003ACC")]
			[Address(RVA = "0x411C890", Offset = "0x4118890", VA = "0x411C890", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400494A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Button _closeButton;

		[Token(Token = "0x400494B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _contentRoot;

		[Token(Token = "0x400494C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TextMeshProUGUI _titleText;

		[Token(Token = "0x400494D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _itemGrid;

		[Token(Token = "0x400494E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private MysteryAdventureDiscountShopItemView _itemTemplate;

		[Token(Token = "0x400494F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _footerRoot;

		[Token(Token = "0x4004950")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TextMeshProUGUI _remainCountText;

		[Token(Token = "0x4004951")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Button _refreshButton;

		[Token(Token = "0x4004952")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private readonly List<MysteryAdventureDiscountShopItemView> _items;

		[Token(Token = "0x4004953")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Action _onClose;

		[Token(Token = "0x4004954")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Action<SaleShopConfig> _onBuy;

		[Token(Token = "0x4004955")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Action _onRefresh;

		[Token(Token = "0x4004956")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private bool _isPlayTween;

		[Token(Token = "0x170008F4")]
		public Button CloseButton
		{
			[Token(Token = "0x6003AA8")]
			[Address(RVA = "0x411A018", Offset = "0x4116018", VA = "0x411A018")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008F5")]
		public RectTransform ContentRoot
		{
			[Token(Token = "0x6003AA9")]
			[Address(RVA = "0x411A020", Offset = "0x4116020", VA = "0x411A020")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008F6")]
		public bool IsPlayTween
		{
			[Token(Token = "0x6003AAA")]
			[Address(RVA = "0x411A028", Offset = "0x4116028", VA = "0x411A028")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170008F7")]
		public TextMeshProUGUI TitleText
		{
			[Token(Token = "0x6003AAB")]
			[Address(RVA = "0x411A030", Offset = "0x4116030", VA = "0x411A030")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008F8")]
		public RectTransform ItemGrid
		{
			[Token(Token = "0x6003AAC")]
			[Address(RVA = "0x411A038", Offset = "0x4116038", VA = "0x411A038")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008F9")]
		public MysteryAdventureDiscountShopItemView ItemTemplate
		{
			[Token(Token = "0x6003AAD")]
			[Address(RVA = "0x411A040", Offset = "0x4116040", VA = "0x411A040")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003AAE")]
		[Address(RVA = "0x411A048", Offset = "0x4116048", VA = "0x411A048")]
		public void Initialize(Action onClose, Action<SaleShopConfig> onBuy, Action onRefresh)
		{
		}

		[Token(Token = "0x6003AAF")]
		[Address(RVA = "0x411A814", Offset = "0x4116814", VA = "0x411A814")]
		public void Refresh()
		{
		}

		[Token(Token = "0x6003AB0")]
		[Address(RVA = "0x411AD18", Offset = "0x4116D18", VA = "0x411AD18")]
		private void RefreshFooterUi()
		{
		}

		[Token(Token = "0x6003AB1")]
		[Address(RVA = "0x411AF38", Offset = "0x4116F38", VA = "0x411AF38")]
		[AsyncStateMachine(typeof(_003CEnsureRewardItemPrefabAsync_003Ed__28))]
		public UniTask EnsureRewardItemPrefabAsync()
		{
			return default;
		}

		[Token(Token = "0x6003AB2")]
		[Address(RVA = "0x411A634", Offset = "0x4116634", VA = "0x411A634")]
		private void BindCloseButton()
		{
		}

		[Token(Token = "0x6003AB3")]
		[Address(RVA = "0x411A724", Offset = "0x4116724", VA = "0x411A724")]
		private void BindRefreshButton()
		{
		}

		[Token(Token = "0x6003AB4")]
		[Address(RVA = "0x411AFC4", Offset = "0x4116FC4", VA = "0x411AFC4")]
		private void OnCloseButtonClicked()
		{
		}

		[Token(Token = "0x6003AB5")]
		[Address(RVA = "0x411AFE8", Offset = "0x4116FE8", VA = "0x411AFE8")]
		private void OnRefreshButtonClicked()
		{
		}

		[Token(Token = "0x6003AB6")]
		[Address(RVA = "0x411B00C", Offset = "0x411700C", VA = "0x411B00C")]
		[AsyncStateMachine(typeof(_003CShowAsync_003Ed__33))]
		public UniTask ShowAsync()
		{
			return default;
		}

		[Token(Token = "0x6003AB7")]
		[Address(RVA = "0x411B098", Offset = "0x4117098", VA = "0x411B098")]
		[AsyncStateMachine(typeof(_003CHideAsync_003Ed__34))]
		public UniTask HideAsync()
		{
			return default;
		}

		[Token(Token = "0x6003AB8")]
		[Address(RVA = "0x411A070", Offset = "0x4116070", VA = "0x411A070")]
		private void ResolveReferences()
		{
		}

		[Token(Token = "0x6003AB9")]
		[Address(RVA = "0x411B124", Offset = "0x4117124", VA = "0x411B124")]
		private static void Stretch(RectTransform rect, Vector2 offsetMin, Vector2 offsetMax)
		{
		}

		[Token(Token = "0x6003ABA")]
		[Address(RVA = "0x411B200", Offset = "0x4117200", VA = "0x411B200")]
		internal void BindContentRootRef(RectTransform contentRoot)
		{
		}

		[Token(Token = "0x6003ABB")]
		[Address(RVA = "0x411B208", Offset = "0x4117208", VA = "0x411B208")]
		internal void BindCloseButtonRef(Button button)
		{
		}

		[Token(Token = "0x6003ABC")]
		[Address(RVA = "0x411B210", Offset = "0x4117210", VA = "0x411B210")]
		internal void BindTitleTextRef(TextMeshProUGUI text)
		{
		}

		[Token(Token = "0x6003ABD")]
		[Address(RVA = "0x411B218", Offset = "0x4117218", VA = "0x411B218")]
		internal void BindItemGridRef(RectTransform grid)
		{
		}

		[Token(Token = "0x6003ABE")]
		[Address(RVA = "0x411B220", Offset = "0x4117220", VA = "0x411B220")]
		internal void BindItemTemplateRef(MysteryAdventureDiscountShopItemView template)
		{
		}

		[Token(Token = "0x6003ABF")]
		[Address(RVA = "0x411B228", Offset = "0x4117228", VA = "0x411B228")]
		internal void BindFooterRootRef(GameObject footerRoot)
		{
		}

		[Token(Token = "0x6003AC0")]
		[Address(RVA = "0x411B230", Offset = "0x4117230", VA = "0x411B230")]
		internal void BindRemainCountTextRef(TextMeshProUGUI text)
		{
		}

		[Token(Token = "0x6003AC1")]
		[Address(RVA = "0x411B238", Offset = "0x4117238", VA = "0x411B238")]
		internal void BindRefreshButtonRef(Button button)
		{
		}

		[Token(Token = "0x6003AC2")]
		[Address(RVA = "0x411B240", Offset = "0x4117240", VA = "0x411B240")]
		public MysteryAdventureDiscountShopPanelView()
		{
		}
	}
}
