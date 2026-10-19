using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using UIFramework;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x20009DD")]
	public class MysteryAdventureFaceSlapPanel : UIPanel
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20009DE")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__4 : IAsyncStateMachine
		{
			[Token(Token = "0x400496F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004970")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004971")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MysteryAdventureFaceSlapPanel _003C_003E4__this;

			[Token(Token = "0x4004972")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x4004973")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003ADE")]
			[Address(RVA = "0x4120074", Offset = "0x411C074", VA = "0x4120074", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003ADF")]
			[Address(RVA = "0x4120544", Offset = "0x411C544", VA = "0x4120544", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400496C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private MysteryAdventureFaceSlapPanelView _view;

		[Token(Token = "0x400496D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Button _goButton;

		[Token(Token = "0x400496E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Button _maskButton;

		[Token(Token = "0x6003AD4")]
		[Address(RVA = "0x411F8F4", Offset = "0x411B8F4", VA = "0x411F8F4")]
		private new void Awake()
		{
		}

		[Token(Token = "0x6003AD5")]
		[Address(RVA = "0x411FE00", Offset = "0x411BE00", VA = "0x411FE00", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__4))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6003AD6")]
		[Address(RVA = "0x411FE9C", Offset = "0x411BE9C", VA = "0x411FE9C", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6003AD7")]
		[Address(RVA = "0x411F98C", Offset = "0x411B98C", VA = "0x411F98C")]
		private void CacheOptionalButtons()
		{
		}

		[Token(Token = "0x6003AD8")]
		[Address(RVA = "0x411FB48", Offset = "0x411BB48", VA = "0x411FB48")]
		private void BindButtonEvents()
		{
		}

		[Token(Token = "0x6003AD9")]
		[Address(RVA = "0x411FF04", Offset = "0x411BF04", VA = "0x411FF04")]
		private void OnGoButtonClicked()
		{
		}

		[Token(Token = "0x6003ADA")]
		[Address(RVA = "0x4120060", Offset = "0x411C060", VA = "0x4120060")]
		private void OnCloseButtonClicked()
		{
		}

		[Token(Token = "0x6003ADB")]
		[Address(RVA = "0x411FF88", Offset = "0x411BF88", VA = "0x411FF88")]
		private void CloseWithDismissPreference()
		{
		}

		[Token(Token = "0x6003ADC")]
		[Address(RVA = "0x4120064", Offset = "0x411C064", VA = "0x4120064")]
		public MysteryAdventureFaceSlapPanel()
		{
		}
	}
}
