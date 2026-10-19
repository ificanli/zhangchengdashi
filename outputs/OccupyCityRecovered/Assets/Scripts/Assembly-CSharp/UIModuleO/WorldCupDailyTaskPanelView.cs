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
	[Token(Token = "0x2000664")]
	public class WorldCupDailyTaskPanelView : ScaleTweenPanelViewBase
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000665")]
		[CompilerGenerated]
		private struct _003CShowAsync_003Ed__22 : IAsyncStateMachine
		{
			[Token(Token = "0x40033EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40033F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40033F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public WorldCupDailyTaskPanelView _003C_003E4__this;

			[Token(Token = "0x40033F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool showTaskPage;

			[Token(Token = "0x40033F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60021B1")]
			[Address(RVA = "0x3F2AE04", Offset = "0x3F26E04", VA = "0x3F2AE04", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60021B2")]
			[Address(RVA = "0x3F2B204", Offset = "0x3F27204", VA = "0x3F2B204", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40033E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Button _closeButton;

		[Token(Token = "0x40033E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Toggle _dailyTaskTabToggle;

		[Token(Token = "0x40033E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Toggle _dailyGiftTabToggle;

		[Token(Token = "0x40033EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TogglerHandler _dailyTaskTabToggler;

		[Token(Token = "0x40033EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private TogglerHandler _dailyGiftTabToggler;

		[Token(Token = "0x40033EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TextMeshProUGUI _refreshText;

		[Token(Token = "0x40033ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private WorldCupDailyTaskPageView _dailyTaskPage;

		[Token(Token = "0x40033EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private WorldCupDailyGiftPageView _dailyGiftPage;

		[Token(Token = "0x170001D5")]
		public Button CloseButton
		{
			[Token(Token = "0x60021A3")]
			[Address(RVA = "0x3F2A92C", Offset = "0x3F2692C", VA = "0x3F2A92C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001D6")]
		public Toggle DailyTaskTabToggle
		{
			[Token(Token = "0x60021A4")]
			[Address(RVA = "0x3F2A934", Offset = "0x3F26934", VA = "0x3F2A934")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001D7")]
		public Toggle DailyGiftTabToggle
		{
			[Token(Token = "0x60021A5")]
			[Address(RVA = "0x3F2A93C", Offset = "0x3F2693C", VA = "0x3F2A93C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001D8")]
		public TextMeshProUGUI RefreshText
		{
			[Token(Token = "0x60021A6")]
			[Address(RVA = "0x3F2A944", Offset = "0x3F26944", VA = "0x3F2A944")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001D9")]
		public WorldCupDailyTaskPageView DailyTaskPage
		{
			[Token(Token = "0x60021A7")]
			[Address(RVA = "0x3F2A94C", Offset = "0x3F2694C", VA = "0x3F2A94C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001DA")]
		public WorldCupDailyGiftPageView DailyGiftPage
		{
			[Token(Token = "0x60021A8")]
			[Address(RVA = "0x3F2A954", Offset = "0x3F26954", VA = "0x3F2A954")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001DB")]
		public bool IsGiftPageActive
		{
			[Token(Token = "0x60021A9")]
			[Address(RVA = "0x3F2A95C", Offset = "0x3F2695C", VA = "0x3F2A95C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60021AA")]
		[Address(RVA = "0x3F2A9F0", Offset = "0x3F269F0", VA = "0x3F2A9F0")]
		[AsyncStateMachine(typeof(_003CShowAsync_003Ed__22))]
		public UniTask ShowAsync(bool showTaskPage)
		{
			return default;
		}

		[Token(Token = "0x60021AB")]
		[Address(RVA = "0x3F2AA94", Offset = "0x3F26A94", VA = "0x3F2AA94")]
		public void ShowPage(bool showTaskPage)
		{
		}

		[Token(Token = "0x60021AC")]
		[Address(RVA = "0x3F2ABF0", Offset = "0x3F26BF0", VA = "0x3F2ABF0")]
		private static void HideInternalRedDots(Transform root)
		{
		}

		[Token(Token = "0x60021AD")]
		[Address(RVA = "0x3F2ABDC", Offset = "0x3F26BDC", VA = "0x3F2ABDC")]
		private void HideInternalRedDots()
		{
		}

		[Token(Token = "0x60021AE")]
		[Address(RVA = "0x3F2AD18", Offset = "0x3F26D18", VA = "0x3F2AD18")]
		public void UpdateRefreshCountdown(string countdown)
		{
		}

		[Token(Token = "0x60021AF")]
		[Address(RVA = "0x3F2ADF4", Offset = "0x3F26DF4", VA = "0x3F2ADF4")]
		public WorldCupDailyTaskPanelView()
		{
		}
	}
}
