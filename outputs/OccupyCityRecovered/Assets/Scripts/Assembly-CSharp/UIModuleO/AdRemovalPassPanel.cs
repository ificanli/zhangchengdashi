using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using Il2CppDummyDll;
using UnityEngine;

namespace UIModuleO
{
	[Token(Token = "0x200069D")]
	public class AdRemovalPassPanel : AdRemovalPassPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200069E")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__5 : IAsyncStateMachine
		{
			[Token(Token = "0x4003534")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003535")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003536")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public AdRemovalPassPanel _003C_003E4__this;

			[Token(Token = "0x4003537")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6002306")]
			[Address(RVA = "0x3F40C48", Offset = "0x3F3CC48", VA = "0x3F40C48", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002307")]
			[Address(RVA = "0x3F415CC", Offset = "0x3F3D5CC", VA = "0x3F415CC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private GlobalShopInfo info;

		[Token(Token = "0x4003531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private GameObject res1;

		[Token(Token = "0x4003532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private GameObject res2;

		[Token(Token = "0x4003533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private GameObject res3;

		[Token(Token = "0x60022FF")]
		[Address(RVA = "0x3F407C8", Offset = "0x3F3C7C8", VA = "0x3F407C8", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6002300")]
		[Address(RVA = "0x3F408E0", Offset = "0x3F3C8E0", VA = "0x3F408E0", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__5))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6002301")]
		[Address(RVA = "0x3F40974", Offset = "0x3F3C974", VA = "0x3F40974", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6002302")]
		[Address(RVA = "0x3F40A84", Offset = "0x3F3CA84", VA = "0x3F40A84", Slot = "14")]
		protected override void OnButtonExtendBtnCloseClicked()
		{
		}

		[Token(Token = "0x6002303")]
		[Address(RVA = "0x3F40B10", Offset = "0x3F3CB10", VA = "0x3F40B10")]
		public AdRemovalPassPanel()
		{
		}
	}
}
