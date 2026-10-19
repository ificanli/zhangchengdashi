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
using ljzs_lt;

namespace UIModuleO
{
	[Token(Token = "0x200065F")]
	public class WorldCupDailyGiftPageView : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000660")]
		[CompilerGenerated]
		private struct _003CEnsureReadyAndRebindAsync_003Ed__12 : IAsyncStateMachine
		{
			[Token(Token = "0x40033CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40033CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40033CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public WorldCupDailyGiftPageView _003C_003E4__this;

			[Token(Token = "0x40033CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600218F")]
			[Address(RVA = "0x3F28AA0", Offset = "0x3F24AA0", VA = "0x3F28AA0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002190")]
			[Address(RVA = "0x3F28DA4", Offset = "0x3F24DA4", VA = "0x3F28DA4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000661")]
		[CompilerGenerated]
		private struct _003CEnsureReadyAsync_003Ed__10 : IAsyncStateMachine
		{
			[Token(Token = "0x40033CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40033CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40033D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public WorldCupDailyGiftPageView _003C_003E4__this;

			[Token(Token = "0x40033D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x40033D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__2;

			[Token(Token = "0x40033D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__3;

			[Token(Token = "0x6002191")]
			[Address(RVA = "0x3F28DB0", Offset = "0x3F24DB0", VA = "0x3F28DB0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002192")]
			[Address(RVA = "0x3F296A0", Offset = "0x3F256A0", VA = "0x3F296A0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40033C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _content;

		[Token(Token = "0x40033C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private WorldCupDailyGiftItemView _itemTemplate;

		[Token(Token = "0x40033C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TextMeshProUGUI _placeholderText;

		[Token(Token = "0x40033C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly List<WorldCupDailyGiftItemView> _items;

		[Token(Token = "0x40033C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private GameObject _rewardItemPrefab;

		[Token(Token = "0x40033C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool _rewardPrefabLoading;

		[Token(Token = "0x40033C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Action<WorldCupdailyPriceConfig> _onFreeClaim;

		[Token(Token = "0x40033C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Func<bool> _tryBlockPurchase;

		[Token(Token = "0x600217F")]
		[Address(RVA = "0x3F27CA0", Offset = "0x3F23CA0", VA = "0x3F27CA0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6002180")]
		[Address(RVA = "0x3F27E64", Offset = "0x3F23E64", VA = "0x3F27E64")]
		public void Initialize(Action<WorldCupdailyPriceConfig> onFreeClaim, [Optional] Func<bool> tryBlockPurchase)
		{
		}

		[Token(Token = "0x6002181")]
		[Address(RVA = "0x3F27E6C", Offset = "0x3F23E6C", VA = "0x3F27E6C")]
		[AsyncStateMachine(typeof(_003CEnsureReadyAsync_003Ed__10))]
		public UniTask EnsureReadyAsync()
		{
			return default;
		}

		[Token(Token = "0x6002182")]
		[Address(RVA = "0x3F27EFC", Offset = "0x3F23EFC", VA = "0x3F27EFC")]
		public void Refresh()
		{
		}

		[Token(Token = "0x6002183")]
		[Address(RVA = "0x3F281C4", Offset = "0x3F241C4", VA = "0x3F281C4")]
		[AsyncStateMachine(typeof(_003CEnsureReadyAndRebindAsync_003Ed__12))]
		private UniTaskVoid EnsureReadyAndRebindAsync()
		{
			return default;
		}

		[Token(Token = "0x6002184")]
		[Address(RVA = "0x3F27F34", Offset = "0x3F23F34", VA = "0x3F27F34")]
		private bool RefreshCore()
		{
			return default;
		}

		[Token(Token = "0x6002185")]
		[Address(RVA = "0x3F2842C", Offset = "0x3F2442C", VA = "0x3F2842C")]
		private void EnsureItemCount(int count)
		{
		}

		[Token(Token = "0x6002186")]
		[Address(RVA = "0x3F285A4", Offset = "0x3F245A4", VA = "0x3F285A4")]
		private void BindItems(IReadOnlyList<WorldCupdailyPriceConfig> configs)
		{
		}

		[Token(Token = "0x6002187")]
		[Address(RVA = "0x3F28804", Offset = "0x3F24804", VA = "0x3F28804")]
		private void RebindActiveItems()
		{
		}

		[Token(Token = "0x6002188")]
		[Address(RVA = "0x3F28778", Offset = "0x3F24778", VA = "0x3F28778")]
		private void BindItem(WorldCupDailyGiftItemView item, WorldCupdailyPriceConfig config)
		{
		}

		[Token(Token = "0x6002189")]
		[Address(RVA = "0x3F282FC", Offset = "0x3F242FC", VA = "0x3F282FC")]
		private void HideRuntimeItems()
		{
		}

		[Token(Token = "0x600218A")]
		[Address(RVA = "0x3F28934", Offset = "0x3F24934", VA = "0x3F28934")]
		private void ApplyRewardItemPrefab()
		{
		}

		[Token(Token = "0x600218B")]
		[Address(RVA = "0x3F27CA4", Offset = "0x3F23CA4", VA = "0x3F27CA4")]
		private void HideTemplateAndStaticItems()
		{
		}

		[Token(Token = "0x600218C")]
		[Address(RVA = "0x3F2823C", Offset = "0x3F2423C", VA = "0x3F2823C")]
		private void ShowPlaceholder(string message)
		{
		}

		[Token(Token = "0x600218D")]
		[Address(RVA = "0x3F28398", Offset = "0x3F24398", VA = "0x3F28398")]
		private void HidePlaceholder()
		{
		}

		[Token(Token = "0x600218E")]
		[Address(RVA = "0x3F28A24", Offset = "0x3F24A24", VA = "0x3F28A24")]
		public WorldCupDailyGiftPageView()
		{
		}
	}
}
