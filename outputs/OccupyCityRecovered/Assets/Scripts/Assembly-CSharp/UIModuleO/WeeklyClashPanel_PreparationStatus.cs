using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;

namespace UIModuleO
{
	[Token(Token = "0x2000C12")]
	public class WeeklyClashPanel_PreparationStatus : WeeklyClashPanel_PreparationStatusComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000C14")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__0 : IAsyncStateMachine
		{
			[Token(Token = "0x4005740")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005741")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005742")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public WeeklyClashPanel_PreparationStatus _003C_003E4__this;

			[Token(Token = "0x4005743")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6004AD8")]
			[Address(RVA = "0x4260F84", Offset = "0x425CF84", VA = "0x4260F84", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004AD9")]
			[Address(RVA = "0x42615BC", Offset = "0x425D5BC", VA = "0x42615BC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x6004AD1")]
		[Address(RVA = "0x4260A40", Offset = "0x425CA40", VA = "0x4260A40", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__0))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6004AD2")]
		[Address(RVA = "0x4260AD4", Offset = "0x425CAD4", VA = "0x4260AD4", Slot = "12")]
		protected override void OnButtonExtendRequirementsBtnClicked()
		{
		}

		[Token(Token = "0x6004AD3")]
		[Address(RVA = "0x4260E74", Offset = "0x425CE74", VA = "0x4260E74")]
		public WeeklyClashPanel_PreparationStatus()
		{
		}
	}
}
