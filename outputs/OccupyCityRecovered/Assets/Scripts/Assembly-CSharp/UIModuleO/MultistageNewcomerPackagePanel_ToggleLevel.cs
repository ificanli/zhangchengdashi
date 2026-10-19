using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;

namespace UIModuleO
{
	[Token(Token = "0x200099C")]
	public class MultistageNewcomerPackagePanel_ToggleLevel : MultistageNewcomerPackagePanel_ToggleLevelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200099E")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__3 : IAsyncStateMachine
		{
			[Token(Token = "0x40047F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40047F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40047F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MultistageNewcomerPackagePanel_ToggleLevel _003C_003E4__this;

			[Token(Token = "0x40047F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6003912")]
			[Address(RVA = "0x40FF418", Offset = "0x40FB418", VA = "0x40FF418", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003913")]
			[Address(RVA = "0x40FF7B8", Offset = "0x40FB7B8", VA = "0x40FF7B8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40047F2")]
		private const string ColorNormal = "A8976A";

		[Token(Token = "0x40047F3")]
		private const string ColorSelected = "FFF0C1";

		[Token(Token = "0x40047F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string _price;

		[Token(Token = "0x600390C")]
		[Address(RVA = "0x40FF1E8", Offset = "0x40FB1E8", VA = "0x40FF1E8", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__3))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x600390D")]
		[Address(RVA = "0x40FC76C", Offset = "0x40F876C", VA = "0x40FC76C")]
		public void UpdatePriceColor(bool selected)
		{
		}

		[Token(Token = "0x600390E")]
		[Address(RVA = "0x40FF344", Offset = "0x40FB344", VA = "0x40FF344")]
		public MultistageNewcomerPackagePanel_ToggleLevel()
		{
		}
	}
}
