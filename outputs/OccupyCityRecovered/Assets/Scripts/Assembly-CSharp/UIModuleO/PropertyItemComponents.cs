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
	[Token(Token = "0x20007B5")]
	public class PropertyItemComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20007B6")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__53 : IAsyncStateMachine
		{
			[Token(Token = "0x4003B9C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003B9D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003B9E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public PropertyItemComponents _003C_003E4__this;

			[Token(Token = "0x4003B9F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6002A96")]
			[Address(RVA = "0x3FDB8EC", Offset = "0x3FD78EC", VA = "0x3FDB8EC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002A97")]
			[Address(RVA = "0x3FDBB64", Offset = "0x3FD7B64", VA = "0x3FDBB64", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003B99")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Image _imageImgPropertyIcon;

		[Token(Token = "0x4003B9A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TextMeshProUGUI _textMeshProUGUITxtPropertyName;

		[Token(Token = "0x4003B9B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TextMeshProUGUI _textMeshProUGUITxtPropertyNum;

		[Token(Token = "0x17000446")]
		public Image ImageImgPropertyIcon
		{
			[Token(Token = "0x6002A8D")]
			[Address(RVA = "0x3FDADFC", Offset = "0x3FD6DFC", VA = "0x3FDADFC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000447")]
		public TextMeshProUGUI TextMeshProUGUITxtPropertyName
		{
			[Token(Token = "0x6002A8E")]
			[Address(RVA = "0x3FDAEC4", Offset = "0x3FD6EC4", VA = "0x3FDAEC4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000448")]
		public TextMeshProUGUI TextMeshProUGUITxtPropertyNum
		{
			[Token(Token = "0x6002A8F")]
			[Address(RVA = "0x3FDAF8C", Offset = "0x3FD6F8C", VA = "0x3FDAF8C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002A90")]
		[Address(RVA = "0x3FDB790", Offset = "0x3FD7790", VA = "0x3FDB790")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6002A91")]
		[Address(RVA = "0x3FDB794", Offset = "0x3FD7794", VA = "0x3FDB794", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6002A92")]
		[Address(RVA = "0x3FDB79C", Offset = "0x3FD779C", VA = "0x3FDB79C", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__53))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6002A93")]
		[Address(RVA = "0x3FDB830", Offset = "0x3FD7830", VA = "0x3FDB830", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6002A94")]
		[Address(RVA = "0x3FD7D54", Offset = "0x3FD3D54", VA = "0x3FD7D54")]
		public PropertyItemComponents()
		{
		}
	}
}
