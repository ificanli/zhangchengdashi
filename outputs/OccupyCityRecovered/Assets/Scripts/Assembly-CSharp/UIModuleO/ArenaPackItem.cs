using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using DataModule;
using Il2CppDummyDll;
using TimeModuleO;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x20006B0")]
	public class ArenaPackItem : ArenaPackItemComponents
	{
		[Token(Token = "0x20006B1")]
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass5_0
		{
			[Token(Token = "0x4003586")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ArenaPackageData data;

			[Token(Token = "0x4003587")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ArenaPackItem _003C_003E4__this;

			[Token(Token = "0x6002376")]
			[Address(RVA = "0x3F46454", Offset = "0x3F42454", VA = "0x3F46454")]
			public _003C_003Ec__DisplayClass5_0()
			{
			}

			[Token(Token = "0x6002377")]
			[Address(RVA = "0x3F4645C", Offset = "0x3F4245C", VA = "0x3F4645C")]
			internal bool _003CInit_003Eb__0(ShopArenaPackInfos info)
			{
				return default;
			}

			[Token(Token = "0x6002378")]
			[Address(RVA = "0x3F46484", Offset = "0x3F42484", VA = "0x3F46484")]
			internal bool _003CInit_003Eb__1(GlobalIAPInfo info)
			{
				return default;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20006B2")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__5 : IAsyncStateMachine
		{
			[Token(Token = "0x4003588")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003589")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400358A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ArenaPackageData data;

			[Token(Token = "0x400358B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public ArenaPackItem _003C_003E4__this;

			[Token(Token = "0x400358C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private _003C_003Ec__DisplayClass5_0 _003C_003E8__1;

			[Token(Token = "0x400358D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Image _003C_003E7__wrap1;

			[Token(Token = "0x400358E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UniTask<UnityEngine.Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002379")]
			[Address(RVA = "0x3F464B4", Offset = "0x3F424B4", VA = "0x3F464B4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600237A")]
			[Address(RVA = "0x3F47C90", Offset = "0x3F43C90", VA = "0x3F47C90", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float _elapsed;

		[Token(Token = "0x4003582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private ShopArenaPackInfos _config;

		[Token(Token = "0x4003583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private ArenaPackageData _data;

		[Token(Token = "0x4003584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private GlobalIAPInfo iapInfo;

		[Token(Token = "0x4003585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private TimeManager.Timer _timer;

		[Token(Token = "0x6002372")]
		[Address(RVA = "0x3F45FCC", Offset = "0x3F41FCC", VA = "0x3F45FCC")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__5))]
		public void Init(ArenaPackageData data)
		{
		}

		[Token(Token = "0x6002373")]
		[Address(RVA = "0x3F46068", Offset = "0x3F42068", VA = "0x3F46068")]
		private void Update()
		{
		}

		[Token(Token = "0x6002374")]
		[Address(RVA = "0x3F46250", Offset = "0x3F42250", VA = "0x3F46250", Slot = "12")]
		protected override void OnButtonExtendBackgroundClicked()
		{
		}

		[Token(Token = "0x6002375")]
		[Address(RVA = "0x3F4643C", Offset = "0x3F4243C", VA = "0x3F4643C")]
		public ArenaPackItem()
		{
		}
	}
}
