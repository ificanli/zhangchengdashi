using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using UIFramework;
using UIModuleO.UIAnim;

namespace UIModuleO
{
	[Token(Token = "0x2000720")]
	public class BoxPanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000721")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__613 : IAsyncStateMachine
		{
			[Token(Token = "0x400387C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400387D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400387E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BoxPanelComponents _003C_003E4__this;

			[Token(Token = "0x400387F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x60026E8")]
			[Address(RVA = "0x3F9A338", Offset = "0x3F96338", VA = "0x3F9A338", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60026E9")]
			[Address(RVA = "0x3F9A5B0", Offset = "0x3F965B0", VA = "0x3F9A5B0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003873")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ButtonExtend _buttonExtendBg;

		[Token(Token = "0x4003874")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private ChestSlotsView _chestSlotsViewChestSlotsView;

		[Token(Token = "0x4003875")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private ButtonExtend _buttonExtendBtnClose;

		[Token(Token = "0x4003876")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private ButtonExtend _buttonExtendImgBoxBg1;

		[Token(Token = "0x4003877")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private ButtonExtend _buttonExtendImgBoxBg2;

		[Token(Token = "0x4003878")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private ButtonExtend _buttonExtendImgBoxBg3;

		[Token(Token = "0x4003879")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private ButtonExtend _buttonExtendBtnBuyBoxSlot3;

		[Token(Token = "0x400387A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private ButtonExtend _buttonExtendImgBoxBg4;

		[Token(Token = "0x400387B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private ButtonExtend _buttonExtendBtnBuyBoxSlot4;

		[Token(Token = "0x17000329")]
		public ButtonExtend ButtonExtendBg
		{
			[Token(Token = "0x60026D1")]
			[Address(RVA = "0x3F99748", Offset = "0x3F95748", VA = "0x3F99748")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700032A")]
		public ChestSlotsView ChestSlotsViewChestSlotsView
		{
			[Token(Token = "0x60026D2")]
			[Address(RVA = "0x3F99674", Offset = "0x3F95674", VA = "0x3F99674")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700032B")]
		public ButtonExtend ButtonExtendBtnClose
		{
			[Token(Token = "0x60026D3")]
			[Address(RVA = "0x3F99810", Offset = "0x3F95810", VA = "0x3F99810")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700032C")]
		public ButtonExtend ButtonExtendImgBoxBg1
		{
			[Token(Token = "0x60026D4")]
			[Address(RVA = "0x3F998D8", Offset = "0x3F958D8", VA = "0x3F998D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700032D")]
		public ButtonExtend ButtonExtendImgBoxBg2
		{
			[Token(Token = "0x60026D5")]
			[Address(RVA = "0x3F999A0", Offset = "0x3F959A0", VA = "0x3F999A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700032E")]
		public ButtonExtend ButtonExtendImgBoxBg3
		{
			[Token(Token = "0x60026D6")]
			[Address(RVA = "0x3F99A68", Offset = "0x3F95A68", VA = "0x3F99A68")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700032F")]
		public ButtonExtend ButtonExtendBtnBuyBoxSlot3
		{
			[Token(Token = "0x60026D7")]
			[Address(RVA = "0x3F99B30", Offset = "0x3F95B30", VA = "0x3F99B30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000330")]
		public ButtonExtend ButtonExtendImgBoxBg4
		{
			[Token(Token = "0x60026D8")]
			[Address(RVA = "0x3F99BF8", Offset = "0x3F95BF8", VA = "0x3F99BF8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000331")]
		public ButtonExtend ButtonExtendBtnBuyBoxSlot4
		{
			[Token(Token = "0x60026D9")]
			[Address(RVA = "0x3F99CC0", Offset = "0x3F95CC0", VA = "0x3F99CC0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60026DA")]
		[Address(RVA = "0x3F99D88", Offset = "0x3F95D88", VA = "0x3F99D88")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x60026DB")]
		[Address(RVA = "0x3F990F0", Offset = "0x3F950F0", VA = "0x3F990F0", Slot = "12")]
		protected virtual void OnButtonExtendBgClicked()
		{
		}

		[Token(Token = "0x60026DC")]
		[Address(RVA = "0x3F99064", Offset = "0x3F95064", VA = "0x3F99064", Slot = "13")]
		protected virtual void OnButtonExtendBtnCloseClicked()
		{
		}

		[Token(Token = "0x60026DD")]
		[Address(RVA = "0x3F99FF4", Offset = "0x3F95FF4", VA = "0x3F99FF4", Slot = "14")]
		protected virtual void OnButtonExtendImgBoxBg1Clicked()
		{
		}

		[Token(Token = "0x60026DE")]
		[Address(RVA = "0x3F9A060", Offset = "0x3F96060", VA = "0x3F9A060", Slot = "15")]
		protected virtual void OnButtonExtendImgBoxBg2Clicked()
		{
		}

		[Token(Token = "0x60026DF")]
		[Address(RVA = "0x3F9A0CC", Offset = "0x3F960CC", VA = "0x3F9A0CC", Slot = "16")]
		protected virtual void OnButtonExtendImgBoxBg3Clicked()
		{
		}

		[Token(Token = "0x60026E0")]
		[Address(RVA = "0x3F9A138", Offset = "0x3F96138", VA = "0x3F9A138", Slot = "17")]
		protected virtual void OnButtonExtendBtnBuyBoxSlot3Clicked()
		{
		}

		[Token(Token = "0x60026E1")]
		[Address(RVA = "0x3F9A1A4", Offset = "0x3F961A4", VA = "0x3F9A1A4", Slot = "18")]
		protected virtual void OnButtonExtendImgBoxBg4Clicked()
		{
		}

		[Token(Token = "0x60026E2")]
		[Address(RVA = "0x3F9A210", Offset = "0x3F96210", VA = "0x3F9A210", Slot = "19")]
		protected virtual void OnButtonExtendBtnBuyBoxSlot4Clicked()
		{
		}

		[Token(Token = "0x60026E3")]
		[Address(RVA = "0x3F98F8C", Offset = "0x3F94F8C", VA = "0x3F98F8C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60026E4")]
		[Address(RVA = "0x3F99170", Offset = "0x3F95170", VA = "0x3F99170", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__613))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60026E5")]
		[Address(RVA = "0x3F9A27C", Offset = "0x3F9627C", VA = "0x3F9A27C", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x60026E6")]
		[Address(RVA = "0x3F99164", Offset = "0x3F95164", VA = "0x3F99164")]
		public BoxPanelComponents()
		{
		}
	}
}
