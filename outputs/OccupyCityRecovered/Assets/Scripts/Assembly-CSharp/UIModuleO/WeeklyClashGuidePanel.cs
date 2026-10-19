using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;

namespace UIModuleO
{
	[Token(Token = "0x2000C05")]
	public class WeeklyClashGuidePanel : WeeklyClashGuidePanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000C06")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__0 : IAsyncStateMachine
		{
			[Token(Token = "0x40056FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40056FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40056FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public WeeklyClashGuidePanel _003C_003E4__this;

			[Token(Token = "0x40056FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6004A7A")]
			[Address(RVA = "0x425C6C8", Offset = "0x42586C8", VA = "0x425C6C8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004A7B")]
			[Address(RVA = "0x425C938", Offset = "0x4258938", VA = "0x425C938", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x6004A75")]
		[Address(RVA = "0x425BCCC", Offset = "0x4257CCC", VA = "0x425BCCC", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__0))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6004A76")]
		[Address(RVA = "0x425BD60", Offset = "0x4257D60", VA = "0x425BD60", Slot = "9")]
		public override void UpdateInfo(params object[] args)
		{
		}

		[Token(Token = "0x6004A77")]
		[Address(RVA = "0x425C594", Offset = "0x4258594", VA = "0x425C594", Slot = "12")]
		protected override void OnButtonExtendBGClicked()
		{
		}

		[Token(Token = "0x6004A78")]
		[Address(RVA = "0x425C620", Offset = "0x4258620", VA = "0x425C620")]
		public WeeklyClashGuidePanel()
		{
		}
	}
}
