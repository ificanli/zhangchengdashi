using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;

namespace UIModuleO
{
	[Token(Token = "0x2000905")]
	public class GoldCardWeeklyGiftPackToogleBtn : GoldCardWeeklyGiftPackToogleBtnComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000906")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__0 : IAsyncStateMachine
		{
			[Token(Token = "0x4004406")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004407")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004408")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GoldCardWeeklyGiftPackToogleBtn _003C_003E4__this;

			[Token(Token = "0x4004409")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x600340C")]
			[Address(RVA = "0x40A43CC", Offset = "0x40A03CC", VA = "0x40A43CC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600340D")]
			[Address(RVA = "0x40A45AC", Offset = "0x40A05AC", VA = "0x40A45AC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x6003408")]
		[Address(RVA = "0x40A40FC", Offset = "0x40A00FC", VA = "0x40A40FC", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__0))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6003409")]
		[Address(RVA = "0x40A4190", Offset = "0x40A0190", VA = "0x40A4190", Slot = "9")]
		public override void UpdateInfo(params object[] args)
		{
		}

		[Token(Token = "0x600340A")]
		[Address(RVA = "0x40A4324", Offset = "0x40A0324", VA = "0x40A4324")]
		public GoldCardWeeklyGiftPackToogleBtn()
		{
		}
	}
}
