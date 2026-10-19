using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UIFramework;
using UIModuleO.UIAnim;
using UnityEngine;

namespace UIModuleO
{
	[Token(Token = "0x20006E4")]
	public class ArtifactTraitReforgeIntroPanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20006E5")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__331 : IAsyncStateMachine
		{
			[Token(Token = "0x4003717")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003718")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003719")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ArtifactTraitReforgeIntroPanelComponents _003C_003E4__this;

			[Token(Token = "0x400371A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6002540")]
			[Address(RVA = "0x3F68464", Offset = "0x3F64464", VA = "0x3F68464", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002541")]
			[Address(RVA = "0x3F686DC", Offset = "0x3F646DC", VA = "0x3F686DC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003705")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ButtonExtend _buttonExtendBackground;

		[Token(Token = "0x4003706")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RectTransform _rectTransformContents;

		[Token(Token = "0x4003707")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private ButtonExtend _buttonExtendCloseBtn;

		[Token(Token = "0x4003708")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private TextMeshProUGUI _textMeshProUGUITitle1;

		[Token(Token = "0x4003709")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private TextMeshProUGUI _textMeshProUGUI1;

		[Token(Token = "0x400370A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private TextMeshProUGUI _textMeshProUGUI2;

		[Token(Token = "0x400370B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private TextMeshProUGUI _textMeshProUGUI3;

		[Token(Token = "0x400370C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private TextMeshProUGUI _textMeshProUGUI4;

		[Token(Token = "0x400370D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private TextMeshProUGUI _textMeshProUGUITitle2;

		[Token(Token = "0x400370E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private TextMeshProUGUI _textMeshProUGUI11;

		[Token(Token = "0x400370F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private TextMeshProUGUI _textMeshProUGUI21;

		[Token(Token = "0x4003710")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private TextMeshProUGUI _textMeshProUGUI31;

		[Token(Token = "0x4003711")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private TextMeshProUGUI _textMeshProUGUI41;

		[Token(Token = "0x4003712")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private TextMeshProUGUI _textMeshProUGUITitle3;

		[Token(Token = "0x4003713")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private TextMeshProUGUI _textMeshProUGUI12;

		[Token(Token = "0x4003714")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private TextMeshProUGUI _textMeshProUGUI22;

		[Token(Token = "0x4003715")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private TextMeshProUGUI _textMeshProUGUI32;

		[Token(Token = "0x4003716")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private TextMeshProUGUI _textMeshProUGUI42;

		[Token(Token = "0x170002A4")]
		public ButtonExtend ButtonExtendBackground
		{
			[Token(Token = "0x6002526")]
			[Address(RVA = "0x3F681F8", Offset = "0x3F641F8", VA = "0x3F681F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002A5")]
		public RectTransform RectTransformContents
		{
			[Token(Token = "0x6002527")]
			[Address(RVA = "0x3F66034", Offset = "0x3F62034", VA = "0x3F66034")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002A6")]
		public ButtonExtend ButtonExtendCloseBtn
		{
			[Token(Token = "0x6002528")]
			[Address(RVA = "0x3F682C0", Offset = "0x3F642C0", VA = "0x3F682C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002A7")]
		public TextMeshProUGUI TextMeshProUGUITitle1
		{
			[Token(Token = "0x6002529")]
			[Address(RVA = "0x3F66F0C", Offset = "0x3F62F0C", VA = "0x3F66F0C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002A8")]
		public TextMeshProUGUI TextMeshProUGUI1
		{
			[Token(Token = "0x600252A")]
			[Address(RVA = "0x3F66FD4", Offset = "0x3F62FD4", VA = "0x3F66FD4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002A9")]
		public TextMeshProUGUI TextMeshProUGUI2
		{
			[Token(Token = "0x600252B")]
			[Address(RVA = "0x3F6709C", Offset = "0x3F6309C", VA = "0x3F6709C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002AA")]
		public TextMeshProUGUI TextMeshProUGUI3
		{
			[Token(Token = "0x600252C")]
			[Address(RVA = "0x3F67164", Offset = "0x3F63164", VA = "0x3F67164")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002AB")]
		public TextMeshProUGUI TextMeshProUGUI4
		{
			[Token(Token = "0x600252D")]
			[Address(RVA = "0x3F6722C", Offset = "0x3F6322C", VA = "0x3F6722C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002AC")]
		public TextMeshProUGUI TextMeshProUGUITitle2
		{
			[Token(Token = "0x600252E")]
			[Address(RVA = "0x3F672F4", Offset = "0x3F632F4", VA = "0x3F672F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002AD")]
		public TextMeshProUGUI TextMeshProUGUI11
		{
			[Token(Token = "0x600252F")]
			[Address(RVA = "0x3F673BC", Offset = "0x3F633BC", VA = "0x3F673BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002AE")]
		public TextMeshProUGUI TextMeshProUGUI21
		{
			[Token(Token = "0x6002530")]
			[Address(RVA = "0x3F67484", Offset = "0x3F63484", VA = "0x3F67484")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002AF")]
		public TextMeshProUGUI TextMeshProUGUI31
		{
			[Token(Token = "0x6002531")]
			[Address(RVA = "0x3F6754C", Offset = "0x3F6354C", VA = "0x3F6754C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002B0")]
		public TextMeshProUGUI TextMeshProUGUI41
		{
			[Token(Token = "0x6002532")]
			[Address(RVA = "0x3F67614", Offset = "0x3F63614", VA = "0x3F67614")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002B1")]
		public TextMeshProUGUI TextMeshProUGUITitle3
		{
			[Token(Token = "0x6002533")]
			[Address(RVA = "0x3F676DC", Offset = "0x3F636DC", VA = "0x3F676DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002B2")]
		public TextMeshProUGUI TextMeshProUGUI12
		{
			[Token(Token = "0x6002534")]
			[Address(RVA = "0x3F677A4", Offset = "0x3F637A4", VA = "0x3F677A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002B3")]
		public TextMeshProUGUI TextMeshProUGUI22
		{
			[Token(Token = "0x6002535")]
			[Address(RVA = "0x3F6786C", Offset = "0x3F6386C", VA = "0x3F6786C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002B4")]
		public TextMeshProUGUI TextMeshProUGUI32
		{
			[Token(Token = "0x6002536")]
			[Address(RVA = "0x3F67934", Offset = "0x3F63934", VA = "0x3F67934")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002B5")]
		public TextMeshProUGUI TextMeshProUGUI42
		{
			[Token(Token = "0x6002537")]
			[Address(RVA = "0x3F679FC", Offset = "0x3F639FC", VA = "0x3F679FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002538")]
		[Address(RVA = "0x3F68388", Offset = "0x3F64388", VA = "0x3F68388")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6002539")]
		[Address(RVA = "0x3F67C34", Offset = "0x3F63C34", VA = "0x3F67C34", Slot = "12")]
		protected virtual void OnButtonExtendBackgroundClicked()
		{
		}

		[Token(Token = "0x600253A")]
		[Address(RVA = "0x3F67BA8", Offset = "0x3F63BA8", VA = "0x3F67BA8", Slot = "13")]
		protected virtual void OnButtonExtendCloseBtnClicked()
		{
		}

		[Token(Token = "0x600253B")]
		[Address(RVA = "0x3F66018", Offset = "0x3F62018", VA = "0x3F66018", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600253C")]
		[Address(RVA = "0x3F67D48", Offset = "0x3F63D48", VA = "0x3F67D48", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__331))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x600253D")]
		[Address(RVA = "0x3F67AD4", Offset = "0x3F63AD4", VA = "0x3F67AD4", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x600253E")]
		[Address(RVA = "0x3F67CA8", Offset = "0x3F63CA8", VA = "0x3F67CA8")]
		public ArtifactTraitReforgeIntroPanelComponents()
		{
		}
	}
}
