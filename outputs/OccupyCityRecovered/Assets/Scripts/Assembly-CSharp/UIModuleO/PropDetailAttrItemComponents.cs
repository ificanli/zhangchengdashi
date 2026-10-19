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
	[Token(Token = "0x2000A98")]
	public class PropDetailAttrItemComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A99")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__68 : IAsyncStateMachine
		{
			[Token(Token = "0x4004E2A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004E2B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004E2C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public PropDetailAttrItemComponents _003C_003E4__this;

			[Token(Token = "0x4004E2D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6003FF0")]
			[Address(RVA = "0x419F96C", Offset = "0x419B96C", VA = "0x419F96C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003FF1")]
			[Address(RVA = "0x419FBE4", Offset = "0x419BBE4", VA = "0x419FBE4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004E26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Image _imageIcon;

		[Token(Token = "0x4004E27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TextMeshProUGUI _textMeshProUGUIAttrTypeText;

		[Token(Token = "0x4004E28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TextMeshProUGUI _textMeshProUGUIAttrValue;

		[Token(Token = "0x4004E29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private TextMeshProUGUI _textMeshProUGUIAttrAddValue;

		[Token(Token = "0x170009EE")]
		public Image ImageIcon
		{
			[Token(Token = "0x6003FE6")]
			[Address(RVA = "0x419F5AC", Offset = "0x419B5AC", VA = "0x419F5AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009EF")]
		public TextMeshProUGUI TextMeshProUGUIAttrTypeText
		{
			[Token(Token = "0x6003FE7")]
			[Address(RVA = "0x419F4E4", Offset = "0x419B4E4", VA = "0x419F4E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009F0")]
		public TextMeshProUGUI TextMeshProUGUIAttrValue
		{
			[Token(Token = "0x6003FE8")]
			[Address(RVA = "0x419F674", Offset = "0x419B674", VA = "0x419F674")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009F1")]
		public TextMeshProUGUI TextMeshProUGUIAttrAddValue
		{
			[Token(Token = "0x6003FE9")]
			[Address(RVA = "0x419F73C", Offset = "0x419B73C", VA = "0x419F73C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003FEA")]
		[Address(RVA = "0x419F810", Offset = "0x419B810", VA = "0x419F810")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6003FEB")]
		[Address(RVA = "0x419F814", Offset = "0x419B814", VA = "0x419F814", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6003FEC")]
		[Address(RVA = "0x419F81C", Offset = "0x419B81C", VA = "0x419F81C", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__68))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6003FED")]
		[Address(RVA = "0x419F8B0", Offset = "0x419B8B0", VA = "0x419F8B0", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6003FEE")]
		[Address(RVA = "0x419EEEC", Offset = "0x419AEEC", VA = "0x419EEEC")]
		public PropDetailAttrItemComponents()
		{
		}
	}
}
