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
	[Token(Token = "0x20009CC")]
	public class MysteryAdventureDailyTaskPanelView : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20009CD")]
		[CompilerGenerated]
		private struct _003CEnsureTabSpritesAsync_003Ed__37 : IAsyncStateMachine
		{
			[Token(Token = "0x400490E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400490F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004910")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MysteryAdventureDailyTaskPanelView _003C_003E4__this;

			[Token(Token = "0x4004911")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__1;

			[Token(Token = "0x4004912")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask<(Sprite, Sprite)>.Awaiter _003C_003Eu__2;

			[Token(Token = "0x6003A75")]
			[Address(RVA = "0x41149F4", Offset = "0x41109F4", VA = "0x41149F4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003A76")]
			[Address(RVA = "0x411501C", Offset = "0x411101C", VA = "0x411501C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20009CE")]
		[CompilerGenerated]
		private struct _003CEnsureTabSpritesAsync_003Ed__38 : IAsyncStateMachine
		{
			[Token(Token = "0x4004913")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004914")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004915")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public MysteryAdventureDailyTaskPanelView _003C_003E4__this;

			[Token(Token = "0x4004916")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool showTaskPage;

			[Token(Token = "0x4004917")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003A77")]
			[Address(RVA = "0x4115028", Offset = "0x4111028", VA = "0x4115028", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003A78")]
			[Address(RVA = "0x4115330", Offset = "0x4111330", VA = "0x4115330", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20009CF")]
		[CompilerGenerated]
		private struct _003CLoadTabSprite_003Ed__39 : IAsyncStateMachine
		{
			[Token(Token = "0x4004918")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004919")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<Sprite> _003C_003Et__builder;

			[Token(Token = "0x400491A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string path;

			[Token(Token = "0x400491B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003A79")]
			[Address(RVA = "0x411533C", Offset = "0x411133C", VA = "0x411533C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003A7A")]
			[Address(RVA = "0x4115810", Offset = "0x4111810", VA = "0x4115810", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004902")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Button _closeButton;

		[Token(Token = "0x4004903")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextMeshProUGUI _panelTitleText;

		[Token(Token = "0x4004904")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Button _dailyTaskTabButton;

		[Token(Token = "0x4004905")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Button _dailyGiftTabButton;

		[Token(Token = "0x4004906")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _dailyTaskTabImage;

		[Token(Token = "0x4004907")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _dailyGiftTabImage;

		[Token(Token = "0x4004908")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TextMeshProUGUI _refreshText;

		[Token(Token = "0x4004909")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private MysteryAdventureDailyTaskPageView _dailyTaskPage;

		[Token(Token = "0x400490A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private MysteryAdventureDailyGiftPageView _dailyGiftPage;

		[Token(Token = "0x400490B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Sprite _tabActiveSprite;

		[Token(Token = "0x400490C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Sprite _tabInactiveSprite;

		[Token(Token = "0x400490D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private bool _tabSpritesLoading;

		[Token(Token = "0x170008E7")]
		public Button CloseButton
		{
			[Token(Token = "0x6003A58")]
			[Address(RVA = "0x4113FA0", Offset = "0x410FFA0", VA = "0x4113FA0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008E8")]
		public TextMeshProUGUI PanelTitleText
		{
			[Token(Token = "0x6003A59")]
			[Address(RVA = "0x4113FA8", Offset = "0x410FFA8", VA = "0x4113FA8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008E9")]
		public Button DailyTaskTabButton
		{
			[Token(Token = "0x6003A5A")]
			[Address(RVA = "0x4113FB0", Offset = "0x410FFB0", VA = "0x4113FB0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008EA")]
		public Button DailyGiftTabButton
		{
			[Token(Token = "0x6003A5B")]
			[Address(RVA = "0x4113FB8", Offset = "0x410FFB8", VA = "0x4113FB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008EB")]
		public Image DailyTaskTabImage
		{
			[Token(Token = "0x6003A5C")]
			[Address(RVA = "0x4113FC0", Offset = "0x410FFC0", VA = "0x4113FC0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008EC")]
		public Image DailyGiftTabImage
		{
			[Token(Token = "0x6003A5D")]
			[Address(RVA = "0x4113FC8", Offset = "0x410FFC8", VA = "0x4113FC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008ED")]
		public TextMeshProUGUI RefreshText
		{
			[Token(Token = "0x6003A5E")]
			[Address(RVA = "0x4113FD0", Offset = "0x410FFD0", VA = "0x4113FD0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008EE")]
		public MysteryAdventureDailyTaskPageView DailyTaskPage
		{
			[Token(Token = "0x6003A5F")]
			[Address(RVA = "0x4113FD8", Offset = "0x410FFD8", VA = "0x4113FD8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008EF")]
		public MysteryAdventureDailyGiftPageView DailyGiftPage
		{
			[Token(Token = "0x6003A60")]
			[Address(RVA = "0x4113FE0", Offset = "0x410FFE0", VA = "0x4113FE0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008F0")]
		public bool IsGiftPageActive
		{
			[Token(Token = "0x6003A61")]
			[Address(RVA = "0x4113FE8", Offset = "0x410FFE8", VA = "0x4113FE8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6003A62")]
		[Address(RVA = "0x411407C", Offset = "0x411007C", VA = "0x411407C")]
		public void ShowPage(bool showTaskPage)
		{
		}

		[Token(Token = "0x6003A63")]
		[Address(RVA = "0x41142C8", Offset = "0x41102C8", VA = "0x41142C8")]
		private static void HideInternalRedDots(Transform root)
		{
		}

		[Token(Token = "0x6003A64")]
		[Address(RVA = "0x4114178", Offset = "0x4110178", VA = "0x4114178")]
		private void HideInternalRedDots()
		{
		}

		[Token(Token = "0x6003A65")]
		[Address(RVA = "0x41143F0", Offset = "0x41103F0", VA = "0x41143F0")]
		public void UpdateRefreshCountdown(string countdown, bool isGiftPage)
		{
		}

		[Token(Token = "0x6003A66")]
		[Address(RVA = "0x411418C", Offset = "0x411018C", VA = "0x411418C")]
		public void ApplyTabVisual(bool showTaskPage)
		{
		}

		[Token(Token = "0x6003A67")]
		[Address(RVA = "0x4114840", Offset = "0x4110840", VA = "0x4114840")]
		[AsyncStateMachine(typeof(_003CEnsureTabSpritesAsync_003Ed__37))]
		public UniTask EnsureTabSpritesAsync()
		{
			return default;
		}

		[Token(Token = "0x6003A68")]
		[Address(RVA = "0x41147B4", Offset = "0x41107B4", VA = "0x41147B4")]
		[AsyncStateMachine(typeof(_003CEnsureTabSpritesAsync_003Ed__38))]
		private UniTaskVoid EnsureTabSpritesAsync(bool showTaskPage)
		{
			return default;
		}

		[Token(Token = "0x6003A69")]
		[Address(RVA = "0x41148D0", Offset = "0x41108D0", VA = "0x41148D0")]
		[AsyncStateMachine(typeof(_003CLoadTabSprite_003Ed__39))]
		private static UniTask<Sprite> LoadTabSprite(string path)
		{
			return default;
		}

		[Token(Token = "0x6003A6A")]
		[Address(RVA = "0x41144E4", Offset = "0x41104E4", VA = "0x41144E4")]
		private static void ApplyTabState(Image tabImage, Button tabButton, bool active, Sprite activeSprite, Sprite inactiveSprite)
		{
		}

		[Token(Token = "0x6003A6B")]
		[Address(RVA = "0x41149A4", Offset = "0x41109A4", VA = "0x41149A4")]
		internal void BindCloseButton(Button button)
		{
		}

		[Token(Token = "0x6003A6C")]
		[Address(RVA = "0x41149AC", Offset = "0x41109AC", VA = "0x41149AC")]
		internal void BindPanelTitleText(TextMeshProUGUI text)
		{
		}

		[Token(Token = "0x6003A6D")]
		[Address(RVA = "0x41149B4", Offset = "0x41109B4", VA = "0x41149B4")]
		internal void BindDailyTaskTabButton(Button button)
		{
		}

		[Token(Token = "0x6003A6E")]
		[Address(RVA = "0x41149BC", Offset = "0x41109BC", VA = "0x41149BC")]
		internal void BindDailyGiftTabButton(Button button)
		{
		}

		[Token(Token = "0x6003A6F")]
		[Address(RVA = "0x41149C4", Offset = "0x41109C4", VA = "0x41149C4")]
		internal void BindDailyTaskTabImage(Image image)
		{
		}

		[Token(Token = "0x6003A70")]
		[Address(RVA = "0x41149CC", Offset = "0x41109CC", VA = "0x41149CC")]
		internal void BindDailyGiftTabImage(Image image)
		{
		}

		[Token(Token = "0x6003A71")]
		[Address(RVA = "0x41149D4", Offset = "0x41109D4", VA = "0x41149D4")]
		internal void BindRefreshText(TextMeshProUGUI text)
		{
		}

		[Token(Token = "0x6003A72")]
		[Address(RVA = "0x41149DC", Offset = "0x41109DC", VA = "0x41149DC")]
		internal void BindDailyTaskPage(MysteryAdventureDailyTaskPageView page)
		{
		}

		[Token(Token = "0x6003A73")]
		[Address(RVA = "0x41149E4", Offset = "0x41109E4", VA = "0x41149E4")]
		internal void BindDailyGiftPage(MysteryAdventureDailyGiftPageView page)
		{
		}

		[Token(Token = "0x6003A74")]
		[Address(RVA = "0x41149EC", Offset = "0x41109EC", VA = "0x41149EC")]
		public MysteryAdventureDailyTaskPanelView()
		{
		}
	}
}
