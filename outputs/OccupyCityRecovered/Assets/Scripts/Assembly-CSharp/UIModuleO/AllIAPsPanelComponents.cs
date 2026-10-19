using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using UIFramework;
using UIModuleO.UIAnim;
using UnityEngine;

namespace UIModuleO
{
	[Token(Token = "0x20006A6")]
	public class AllIAPsPanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20006A7")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__133 : IAsyncStateMachine
		{
			[Token(Token = "0x4003552")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003553")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003554")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public AllIAPsPanelComponents _003C_003E4__this;

			[Token(Token = "0x4003555")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6002338")]
			[Address(RVA = "0x3F42D7C", Offset = "0x3F3ED7C", VA = "0x3F42D7C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002339")]
			[Address(RVA = "0x3F42FF4", Offset = "0x3F3EFF4", VA = "0x3F42FF4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400354E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ButtonExtend _buttonExtendBG;

		[Token(Token = "0x400354F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RectTransform _rectTransformContent;

		[Token(Token = "0x4003550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IAPItem _iAPItemIAPItem;

		[Token(Token = "0x4003551")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private ButtonExtend _buttonExtendGetBtn;

		[Token(Token = "0x170001FB")]
		public ButtonExtend ButtonExtendBG
		{
			[Token(Token = "0x600232C")]
			[Address(RVA = "0x3F4295C", Offset = "0x3F3E95C", VA = "0x3F4295C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001FC")]
		public RectTransform RectTransformContent
		{
			[Token(Token = "0x600232D")]
			[Address(RVA = "0x3F4269C", Offset = "0x3F3E69C", VA = "0x3F4269C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001FD")]
		public IAPItem IAPItemIAPItem
		{
			[Token(Token = "0x600232E")]
			[Address(RVA = "0x3F425D4", Offset = "0x3F3E5D4", VA = "0x3F425D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001FE")]
		public ButtonExtend ButtonExtendGetBtn
		{
			[Token(Token = "0x600232F")]
			[Address(RVA = "0x3F42A24", Offset = "0x3F3EA24", VA = "0x3F42A24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002330")]
		[Address(RVA = "0x3F42AEC", Offset = "0x3F3EAEC", VA = "0x3F42AEC")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6002331")]
		[Address(RVA = "0x3F42784", Offset = "0x3F3E784", VA = "0x3F42784", Slot = "12")]
		protected virtual void OnButtonExtendBGClicked()
		{
		}

		[Token(Token = "0x6002332")]
		[Address(RVA = "0x3F42BC0", Offset = "0x3F3EBC0", VA = "0x3F42BC0", Slot = "13")]
		protected virtual void OnButtonExtendGetBtnClicked()
		{
		}

		[Token(Token = "0x6002333")]
		[Address(RVA = "0x3F425B8", Offset = "0x3F3E5B8", VA = "0x3F425B8", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6002334")]
		[Address(RVA = "0x3F42C2C", Offset = "0x3F3EC2C", VA = "0x3F42C2C", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__133))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6002335")]
		[Address(RVA = "0x3F42CC0", Offset = "0x3F3ECC0", VA = "0x3F42CC0", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6002336")]
		[Address(RVA = "0x3F42954", Offset = "0x3F3E954", VA = "0x3F42954")]
		public AllIAPsPanelComponents()
		{
		}
	}
}
