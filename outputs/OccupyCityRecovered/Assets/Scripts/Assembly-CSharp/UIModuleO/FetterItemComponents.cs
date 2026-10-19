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
	[Token(Token = "0x20007A7")]
	public class FetterItemComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20007A8")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__26 : IAsyncStateMachine
		{
			[Token(Token = "0x4003B5F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003B60")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003B61")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public FetterItemComponents _003C_003E4__this;

			[Token(Token = "0x4003B62")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6002A4C")]
			[Address(RVA = "0x3FD3E10", Offset = "0x3FCFE10", VA = "0x3FD3E10", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002A4D")]
			[Address(RVA = "0x3FD4088", Offset = "0x3FD0088", VA = "0x3FD4088", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003B5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Image _imageFetterItem;

		[Token(Token = "0x4003B5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TextMeshProUGUI _textMeshProUGUITxtCount;

		[Token(Token = "0x17000436")]
		public Image ImageFetterItem
		{
			[Token(Token = "0x6002A44")]
			[Address(RVA = "0x3FD2FE0", Offset = "0x3FCEFE0", VA = "0x3FD2FE0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000437")]
		public TextMeshProUGUI TextMeshProUGUITxtCount
		{
			[Token(Token = "0x6002A45")]
			[Address(RVA = "0x3FD3084", Offset = "0x3FCF084", VA = "0x3FD3084")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002A46")]
		[Address(RVA = "0x3FD3CB4", Offset = "0x3FCFCB4", VA = "0x3FD3CB4")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6002A47")]
		[Address(RVA = "0x3FD3CB8", Offset = "0x3FCFCB8", VA = "0x3FD3CB8", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6002A48")]
		[Address(RVA = "0x3FD3CC0", Offset = "0x3FCFCC0", VA = "0x3FD3CC0", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__26))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6002A49")]
		[Address(RVA = "0x3FD3D54", Offset = "0x3FCFD54", VA = "0x3FD3D54", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6002A4A")]
		[Address(RVA = "0x3FD2938", Offset = "0x3FCE938", VA = "0x3FD2938")]
		public FetterItemComponents()
		{
		}
	}
}
