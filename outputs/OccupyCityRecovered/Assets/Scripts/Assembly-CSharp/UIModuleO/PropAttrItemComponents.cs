using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UIFramework;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x200080C")]
	public class PropAttrItemComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200080D")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__50 : IAsyncStateMachine
		{
			[Token(Token = "0x4003DB4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003DB5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003DB6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public PropAttrItemComponents _003C_003E4__this;

			[Token(Token = "0x4003DB7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6002CEF")]
			[Address(RVA = "0x4005BC8", Offset = "0x4001BC8", VA = "0x4005BC8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002CF0")]
			[Address(RVA = "0x4005E40", Offset = "0x4001E40", VA = "0x4005E40", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003DB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Image _imageIcon;

		[Token(Token = "0x4003DB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TextMeshProUGUI _textMeshProUGUIAttrTypeText;

		[Token(Token = "0x4003DB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TextMeshProUGUI _textMeshProUGUIAttrValue;

		[Token(Token = "0x17000502")]
		public Image ImageIcon
		{
			[Token(Token = "0x6002CE6")]
			[Address(RVA = "0x4005998", Offset = "0x4001998", VA = "0x4005998")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000503")]
		public TextMeshProUGUI TextMeshProUGUIAttrTypeText
		{
			[Token(Token = "0x6002CE7")]
			[Address(RVA = "0x40058D0", Offset = "0x40018D0", VA = "0x40058D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000504")]
		public TextMeshProUGUI TextMeshProUGUIAttrValue
		{
			[Token(Token = "0x6002CE8")]
			[Address(RVA = "0x400536C", Offset = "0x400136C", VA = "0x400536C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002CE9")]
		[Address(RVA = "0x4005A6C", Offset = "0x4001A6C", VA = "0x4005A6C")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6002CEA")]
		[Address(RVA = "0x4005A70", Offset = "0x4001A70", VA = "0x4005A70", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6002CEB")]
		[Address(RVA = "0x4005A78", Offset = "0x4001A78", VA = "0x4005A78", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__50))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6002CEC")]
		[Address(RVA = "0x4005B0C", Offset = "0x4001B0C", VA = "0x4005B0C", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6002CED")]
		[Address(RVA = "0x400543C", Offset = "0x400143C", VA = "0x400543C")]
		public PropAttrItemComponents()
		{
		}
	}
}
