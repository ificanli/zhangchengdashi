using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;

namespace UIModuleO
{
	[Token(Token = "0x2000A68")]
	public class NoInternetPanel : NoInternetPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A69")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__4 : IAsyncStateMachine
		{
			[Token(Token = "0x4004CEB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004CEC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004CED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public NoInternetPanel _003C_003E4__this;

			[Token(Token = "0x4004CEE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6003E8E")]
			[Address(RVA = "0x416FEE0", Offset = "0x416BEE0", VA = "0x416FEE0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003E8F")]
			[Address(RVA = "0x41702E0", Offset = "0x416C2E0", VA = "0x41702E0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004CE7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float stayTime;

		[Token(Token = "0x4004CE8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private bool panelIsShow;

		[Token(Token = "0x4004CE9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x75")]
		private bool uiIsShow;

		[Token(Token = "0x4004CEA")]
		private const float PingTime = 1f;

		[Token(Token = "0x6003E88")]
		[Address(RVA = "0x416F664", Offset = "0x416B664", VA = "0x416F664", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__4))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6003E89")]
		[Address(RVA = "0x416F6F8", Offset = "0x416B6F8", VA = "0x416F6F8")]
		private void UISetActive(bool active)
		{
		}

		[Token(Token = "0x6003E8A")]
		[Address(RVA = "0x416FBCC", Offset = "0x416BBCC", VA = "0x416FBCC", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6003E8B")]
		[Address(RVA = "0x416FC98", Offset = "0x416BC98", VA = "0x416FC98")]
		private void Update()
		{
		}

		[Token(Token = "0x6003E8C")]
		[Address(RVA = "0x416FE38", Offset = "0x416BE38", VA = "0x416FE38")]
		public NoInternetPanel()
		{
		}
	}
}
