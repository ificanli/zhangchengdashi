using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using Spine.Unity;
using UIFramework;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000835")]
	public class ExpressionViewUsingItemComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000836")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__24 : IAsyncStateMachine
		{
			[Token(Token = "0x4003E80")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003E81")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003E82")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ExpressionViewUsingItemComponents _003C_003E4__this;

			[Token(Token = "0x4003E83")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6002DF4")]
			[Address(RVA = "0x4015358", Offset = "0x4011358", VA = "0x4015358", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002DF5")]
			[Address(RVA = "0x40155D0", Offset = "0x40115D0", VA = "0x40155D0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003E7E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Button _buttonUsingItemButton;

		[Token(Token = "0x4003E7F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private SkeletonGraphic _skeletonGraphicSpine;

		[Token(Token = "0x17000530")]
		public Button ButtonUsingItemButton
		{
			[Token(Token = "0x6002DEB")]
			[Address(RVA = "0x401509C", Offset = "0x401109C", VA = "0x401509C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000531")]
		public SkeletonGraphic SkeletonGraphicSpine
		{
			[Token(Token = "0x6002DEC")]
			[Address(RVA = "0x40148FC", Offset = "0x40108FC", VA = "0x40148FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002DED")]
		[Address(RVA = "0x4015164", Offset = "0x4011164", VA = "0x4015164")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6002DEE")]
		[Address(RVA = "0x4014750", Offset = "0x4010750", VA = "0x4014750", Slot = "12")]
		protected virtual void OnButtonUsingItemButtonClicked()
		{
		}

		[Token(Token = "0x6002DEF")]
		[Address(RVA = "0x40151EC", Offset = "0x40111EC", VA = "0x40151EC", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6002DF0")]
		[Address(RVA = "0x4015208", Offset = "0x4011208", VA = "0x4015208", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__24))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6002DF1")]
		[Address(RVA = "0x401529C", Offset = "0x401129C", VA = "0x401529C", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6002DF2")]
		[Address(RVA = "0x40149CC", Offset = "0x40109CC", VA = "0x40149CC")]
		public ExpressionViewUsingItemComponents()
		{
		}
	}
}
