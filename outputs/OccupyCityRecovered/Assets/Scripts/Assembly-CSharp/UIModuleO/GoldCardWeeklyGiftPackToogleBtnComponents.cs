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
	[Token(Token = "0x2000907")]
	public class GoldCardWeeklyGiftPackToogleBtnComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000908")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__45 : IAsyncStateMachine
		{
			[Token(Token = "0x400440C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400440D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400440E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GoldCardWeeklyGiftPackToogleBtnComponents _003C_003E4__this;

			[Token(Token = "0x400440F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6003417")]
			[Address(RVA = "0x40A487C", Offset = "0x40A087C", VA = "0x40A487C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003418")]
			[Address(RVA = "0x40A4AF4", Offset = "0x40A0AF4", VA = "0x40A4AF4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400440A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Toggle _toggleGoldCardWeeklyGiftPackToogleBtn;

		[Token(Token = "0x400440B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TextMeshProUGUI _textMeshProUGUIPriceText;

		[Token(Token = "0x1700071D")]
		public Toggle ToggleGoldCardWeeklyGiftPackToogleBtn
		{
			[Token(Token = "0x600340E")]
			[Address(RVA = "0x40A45B8", Offset = "0x40A05B8", VA = "0x40A45B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700071E")]
		public TextMeshProUGUI TextMeshProUGUIPriceText
		{
			[Token(Token = "0x600340F")]
			[Address(RVA = "0x40A425C", Offset = "0x40A025C", VA = "0x40A425C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003410")]
		[Address(RVA = "0x40A465C", Offset = "0x40A065C", VA = "0x40A465C")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6003411")]
		[Address(RVA = "0x40A46F8", Offset = "0x40A06F8", VA = "0x40A46F8", Slot = "12")]
		protected virtual void OnToggleGoldCardWeeklyGiftPackToogleBtnValueChanged(bool arg)
		{
		}

		[Token(Token = "0x6003412")]
		[Address(RVA = "0x40A47A4", Offset = "0x40A07A4", VA = "0x40A47A4", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6003413")]
		[Address(RVA = "0x40A4338", Offset = "0x40A0338", VA = "0x40A4338", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__45))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6003414")]
		[Address(RVA = "0x40A47C0", Offset = "0x40A07C0", VA = "0x40A47C0", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6003415")]
		[Address(RVA = "0x40A432C", Offset = "0x40A032C", VA = "0x40A432C")]
		public GoldCardWeeklyGiftPackToogleBtnComponents()
		{
		}
	}
}
