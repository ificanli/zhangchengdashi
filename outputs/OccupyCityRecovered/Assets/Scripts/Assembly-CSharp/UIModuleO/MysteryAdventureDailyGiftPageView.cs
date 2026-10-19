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
	[Token(Token = "0x20009C5")]
	public class MysteryAdventureDailyGiftPageView : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20009C6")]
		[CompilerGenerated]
		private struct _003CEnsureReadyAndRebindAsync_003Ed__17 : IAsyncStateMachine
		{
			[Token(Token = "0x40048DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40048E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40048E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public MysteryAdventureDailyGiftPageView _003C_003E4__this;

			[Token(Token = "0x40048E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003A33")]
			[Address(RVA = "0x4110820", Offset = "0x410C820", VA = "0x4110820", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003A34")]
			[Address(RVA = "0x4110B24", Offset = "0x410CB24", VA = "0x4110B24", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20009C7")]
		[CompilerGenerated]
		private struct _003CEnsureReadyAsync_003Ed__14 : IAsyncStateMachine
		{
			[Token(Token = "0x40048E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40048E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40048E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MysteryAdventureDailyGiftPageView _003C_003E4__this;

			[Token(Token = "0x40048E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x40048E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__2;

			[Token(Token = "0x40048E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__3;

			[Token(Token = "0x6003A35")]
			[Address(RVA = "0x4110B30", Offset = "0x410CB30", VA = "0x4110B30", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003A36")]
			[Address(RVA = "0x4111420", Offset = "0x410D420", VA = "0x4111420", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20009C8")]
		[CompilerGenerated]
		private struct _003CRefreshAsync_003Ed__15 : IAsyncStateMachine
		{
			[Token(Token = "0x40048E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40048EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40048EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MysteryAdventureDailyGiftPageView _003C_003E4__this;

			[Token(Token = "0x40048EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003A37")]
			[Address(RVA = "0x411142C", Offset = "0x410D42C", VA = "0x411142C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003A38")]
			[Address(RVA = "0x4111848", Offset = "0x410D848", VA = "0x4111848", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40048D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _content;

		[Token(Token = "0x40048D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MysteryAdventureDailyGiftItemView _itemTemplate;

		[Token(Token = "0x40048D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TextMeshProUGUI _placeholderText;

		[Token(Token = "0x40048DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly List<MysteryAdventureDailyGiftItemView> _items;

		[Token(Token = "0x40048DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private GameObject _rewardItemPrefab;

		[Token(Token = "0x40048DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool _rewardPrefabLoading;

		[Token(Token = "0x40048DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Action<DailyPriceConfig> _onFreeClaim;

		[Token(Token = "0x40048DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Func<bool> _tryBlockPurchase;

		[Token(Token = "0x170008E3")]
		public RectTransform Content
		{
			[Token(Token = "0x6003A1B")]
			[Address(RVA = "0x410F608", Offset = "0x410B608", VA = "0x410F608")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008E4")]
		public MysteryAdventureDailyGiftItemView ItemTemplate
		{
			[Token(Token = "0x6003A1C")]
			[Address(RVA = "0x410F610", Offset = "0x410B610", VA = "0x410F610")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003A1D")]
		[Address(RVA = "0x410F618", Offset = "0x410B618", VA = "0x410F618")]
		private void Awake()
		{
		}

		[Token(Token = "0x6003A1E")]
		[Address(RVA = "0x410FAA8", Offset = "0x410BAA8", VA = "0x410FAA8")]
		public void Initialize(Action<DailyPriceConfig> onFreeClaim, [Optional] Func<bool> tryBlockPurchase)
		{
		}

		[Token(Token = "0x6003A1F")]
		[Address(RVA = "0x410FAB0", Offset = "0x410BAB0", VA = "0x410FAB0")]
		[AsyncStateMachine(typeof(_003CEnsureReadyAsync_003Ed__14))]
		public UniTask EnsureReadyAsync()
		{
			return default;
		}

		[Token(Token = "0x6003A20")]
		[Address(RVA = "0x410FB40", Offset = "0x410BB40", VA = "0x410FB40")]
		[AsyncStateMachine(typeof(_003CRefreshAsync_003Ed__15))]
		public UniTask RefreshAsync()
		{
			return default;
		}

		[Token(Token = "0x6003A21")]
		[Address(RVA = "0x410FBCC", Offset = "0x410BBCC", VA = "0x410FBCC")]
		public void Refresh()
		{
		}

		[Token(Token = "0x6003A22")]
		[Address(RVA = "0x410FE9C", Offset = "0x410BE9C", VA = "0x410FE9C")]
		[AsyncStateMachine(typeof(_003CEnsureReadyAndRebindAsync_003Ed__17))]
		private UniTaskVoid EnsureReadyAndRebindAsync()
		{
			return default;
		}

		[Token(Token = "0x6003A23")]
		[Address(RVA = "0x410FC04", Offset = "0x410BC04", VA = "0x410FC04")]
		private bool RefreshCore()
		{
			return default;
		}

		[Token(Token = "0x6003A24")]
		[Address(RVA = "0x4110104", Offset = "0x410C104", VA = "0x4110104")]
		private void EnsureItemCount(int count)
		{
		}

		[Token(Token = "0x6003A25")]
		[Address(RVA = "0x411027C", Offset = "0x410C27C", VA = "0x411027C")]
		private void BindItems(IReadOnlyList<DailyPriceConfig> configs)
		{
		}

		[Token(Token = "0x6003A26")]
		[Address(RVA = "0x41104D4", Offset = "0x410C4D4", VA = "0x41104D4")]
		private void RebindActiveItems()
		{
		}

		[Token(Token = "0x6003A27")]
		[Address(RVA = "0x4110450", Offset = "0x410C450", VA = "0x4110450")]
		private void BindItem(MysteryAdventureDailyGiftItemView item, DailyPriceConfig config)
		{
		}

		[Token(Token = "0x6003A28")]
		[Address(RVA = "0x410FFD4", Offset = "0x410BFD4", VA = "0x410FFD4")]
		private void HideRuntimeItems()
		{
		}

		[Token(Token = "0x6003A29")]
		[Address(RVA = "0x4110604", Offset = "0x410C604", VA = "0x4110604")]
		private void ApplyRewardItemPrefab()
		{
		}

		[Token(Token = "0x6003A2A")]
		[Address(RVA = "0x410F630", Offset = "0x410B630", VA = "0x410F630")]
		private void ResolveReferences()
		{
		}

		[Token(Token = "0x6003A2B")]
		[Address(RVA = "0x41106F4", Offset = "0x410C6F4", VA = "0x41106F4")]
		private static bool IsTemplateName(string objectName)
		{
			return default;
		}

		[Token(Token = "0x6003A2C")]
		[Address(RVA = "0x410F8E8", Offset = "0x410B8E8", VA = "0x410F8E8")]
		private void HideTemplateAndStaticItems()
		{
		}

		[Token(Token = "0x6003A2D")]
		[Address(RVA = "0x410FF14", Offset = "0x410BF14", VA = "0x410FF14")]
		private void ShowPlaceholder(string message)
		{
		}

		[Token(Token = "0x6003A2E")]
		[Address(RVA = "0x4110070", Offset = "0x410C070", VA = "0x4110070")]
		private void HidePlaceholder()
		{
		}

		[Token(Token = "0x6003A2F")]
		[Address(RVA = "0x411078C", Offset = "0x410C78C", VA = "0x411078C")]
		internal void BindContent(RectTransform content)
		{
		}

		[Token(Token = "0x6003A30")]
		[Address(RVA = "0x4110794", Offset = "0x410C794", VA = "0x4110794")]
		internal void BindItemTemplate(MysteryAdventureDailyGiftItemView template)
		{
		}

		[Token(Token = "0x6003A31")]
		[Address(RVA = "0x411079C", Offset = "0x410C79C", VA = "0x411079C")]
		internal void BindPlaceholderText(TextMeshProUGUI text)
		{
		}

		[Token(Token = "0x6003A32")]
		[Address(RVA = "0x41107A4", Offset = "0x410C7A4", VA = "0x41107A4")]
		public MysteryAdventureDailyGiftPageView()
		{
		}
	}
}
