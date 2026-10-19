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
	[Token(Token = "0x2000666")]
	public class WorldCupFaceSlapPanel : UIPanel
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000667")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__5 : IAsyncStateMachine
		{
			[Token(Token = "0x40033F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40033F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40033FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public WorldCupFaceSlapPanel _003C_003E4__this;

			[Token(Token = "0x40033FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x40033FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60021BC")]
			[Address(RVA = "0x3F2B700", Offset = "0x3F27700", VA = "0x3F2B700", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60021BD")]
			[Address(RVA = "0x3F2BB58", Offset = "0x3F27B58", VA = "0x3F2BB58", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40033F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Button _closeButton;

		[Token(Token = "0x40033F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Toggle _dontShowToggle;

		[Token(Token = "0x40033F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Button _goButton;

		[Token(Token = "0x40033F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Button _maskButton;

		[Token(Token = "0x60021B3")]
		[Address(RVA = "0x3F2B210", Offset = "0x3F27210", VA = "0x3F2B210", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60021B4")]
		[Address(RVA = "0x3F2B4AC", Offset = "0x3F274AC", VA = "0x3F2B4AC", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__5))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60021B5")]
		[Address(RVA = "0x3F2B548", Offset = "0x3F27548", VA = "0x3F2B548", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x60021B6")]
		[Address(RVA = "0x3F2B214", Offset = "0x3F27214", VA = "0x3F2B214")]
		private void BindButtonEvents()
		{
		}

		[Token(Token = "0x60021B7")]
		[Address(RVA = "0x3F2B5B0", Offset = "0x3F275B0", VA = "0x3F2B5B0")]
		private void OnGoButtonClicked()
		{
		}

		[Token(Token = "0x60021B8")]
		[Address(RVA = "0x3F2B6EC", Offset = "0x3F276EC", VA = "0x3F2B6EC")]
		private void OnCloseButtonClicked()
		{
		}

		[Token(Token = "0x60021B9")]
		[Address(RVA = "0x3F2B62C", Offset = "0x3F2762C", VA = "0x3F2B62C")]
		private void CloseWithDismissPreference()
		{
		}

		[Token(Token = "0x60021BA")]
		[Address(RVA = "0x3F2B6F0", Offset = "0x3F276F0", VA = "0x3F2B6F0")]
		public WorldCupFaceSlapPanel()
		{
		}
	}
}
