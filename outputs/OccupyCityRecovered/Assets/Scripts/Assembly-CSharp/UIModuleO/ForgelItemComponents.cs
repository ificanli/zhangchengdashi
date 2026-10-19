using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UIFramework;
using UIModuleO.UIAnim;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000802")]
	public class ForgelItemComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000803")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__42 : IAsyncStateMachine
		{
			[Token(Token = "0x4003D83")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003D84")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003D85")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ForgelItemComponents _003C_003E4__this;

			[Token(Token = "0x4003D86")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6002CBB")]
			[Address(RVA = "0x40026E0", Offset = "0x3FFE6E0", VA = "0x40026E0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002CBC")]
			[Address(RVA = "0x4002958", Offset = "0x3FFE958", VA = "0x4002958", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003D80")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ButtonExtend _buttonExtendForgelItem;

		[Token(Token = "0x4003D81")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TextMeshProUGUI _textMeshProUGUIUnlockLevel;

		[Token(Token = "0x4003D82")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Image _imageForgelIcon;

		[Token(Token = "0x170004F4")]
		public ButtonExtend ButtonExtendForgelItem
		{
			[Token(Token = "0x6002CB1")]
			[Address(RVA = "0x4002448", Offset = "0x3FFE448", VA = "0x4002448")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004F5")]
		public TextMeshProUGUI TextMeshProUGUIUnlockLevel
		{
			[Token(Token = "0x6002CB2")]
			[Address(RVA = "0x4001E44", Offset = "0x3FFDE44", VA = "0x4001E44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004F6")]
		public Image ImageForgelIcon
		{
			[Token(Token = "0x6002CB3")]
			[Address(RVA = "0x4001F0C", Offset = "0x3FFDF0C", VA = "0x4001F0C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002CB4")]
		[Address(RVA = "0x40024EC", Offset = "0x3FFE4EC", VA = "0x40024EC")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6002CB5")]
		[Address(RVA = "0x4001740", Offset = "0x3FFD740", VA = "0x4001740", Slot = "12")]
		protected virtual void OnButtonExtendForgelItemClicked()
		{
		}

		[Token(Token = "0x6002CB6")]
		[Address(RVA = "0x4002574", Offset = "0x3FFE574", VA = "0x4002574", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6002CB7")]
		[Address(RVA = "0x4002590", Offset = "0x3FFE590", VA = "0x4002590", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__42))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6002CB8")]
		[Address(RVA = "0x4002624", Offset = "0x3FFE624", VA = "0x4002624", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6002CB9")]
		[Address(RVA = "0x4001734", Offset = "0x3FFD734", VA = "0x4001734")]
		public ForgelItemComponents()
		{
		}
	}
}
