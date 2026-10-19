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
	[Token(Token = "0x20007AB")]
	public class FetterShowCardItemComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20007AC")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__59 : IAsyncStateMachine
		{
			[Token(Token = "0x4003B71")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003B72")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003B73")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public FetterShowCardItemComponents _003C_003E4__this;

			[Token(Token = "0x4003B74")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6002A5C")]
			[Address(RVA = "0x3FD5890", Offset = "0x3FD1890", VA = "0x3FD5890", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002A5D")]
			[Address(RVA = "0x3FD5B08", Offset = "0x3FD1B08", VA = "0x3FD5B08", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003B6D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Image _imageFetterShowCardItem;

		[Token(Token = "0x4003B6E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Image _imageImgType;

		[Token(Token = "0x4003B6F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Image _imageImgIcon;

		[Token(Token = "0x4003B70")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private TextMeshProUGUI _textMeshProUGUITxtNotHave;

		[Token(Token = "0x17000438")]
		public Image ImageFetterShowCardItem
		{
			[Token(Token = "0x6002A52")]
			[Address(RVA = "0x3FD55BC", Offset = "0x3FD15BC", VA = "0x3FD55BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000439")]
		public Image ImageImgType
		{
			[Token(Token = "0x6002A53")]
			[Address(RVA = "0x3FD54F4", Offset = "0x3FD14F4", VA = "0x3FD54F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700043A")]
		public Image ImageImgIcon
		{
			[Token(Token = "0x6002A54")]
			[Address(RVA = "0x3FD542C", Offset = "0x3FD142C", VA = "0x3FD542C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700043B")]
		public TextMeshProUGUI TextMeshProUGUITxtNotHave
		{
			[Token(Token = "0x6002A55")]
			[Address(RVA = "0x3FD5660", Offset = "0x3FD1660", VA = "0x3FD5660")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002A56")]
		[Address(RVA = "0x3FD5734", Offset = "0x3FD1734", VA = "0x3FD5734")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6002A57")]
		[Address(RVA = "0x3FD5738", Offset = "0x3FD1738", VA = "0x3FD5738", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6002A58")]
		[Address(RVA = "0x3FD5740", Offset = "0x3FD1740", VA = "0x3FD5740", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__59))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6002A59")]
		[Address(RVA = "0x3FD57D4", Offset = "0x3FD17D4", VA = "0x3FD57D4", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6002A5A")]
		[Address(RVA = "0x3FD413C", Offset = "0x3FD013C", VA = "0x3FD413C")]
		public FetterShowCardItemComponents()
		{
		}
	}
}
