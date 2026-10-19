using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using DataModule;
using Il2CppDummyDll;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x20007A9")]
	public class FetterShowCardItem : FetterShowCardItemComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20007AA")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__1 : IAsyncStateMachine
		{
			[Token(Token = "0x4003B64")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003B65")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003B66")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public FetterShowCardItem _003C_003E4__this;

			[Token(Token = "0x4003B67")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string id;

			[Token(Token = "0x4003B68")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UserHeroCardData _003Cinfo_003E5__2;

			[Token(Token = "0x4003B69")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private bool _003CisEquip_003E5__3;

			[Token(Token = "0x4003B6A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
			private bool _003CisUnlock_003E5__4;

			[Token(Token = "0x4003B6B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Image _003C_003E7__wrap4;

			[Token(Token = "0x4003B6C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private UniTask<UnityEngine.Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002A50")]
			[Address(RVA = "0x3FD4144", Offset = "0x3FD0144", VA = "0x3FD4144", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002A51")]
			[Address(RVA = "0x3FD5728", Offset = "0x3FD1728", VA = "0x3FD5728", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003B63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private string cardId;

		[Token(Token = "0x6002A4E")]
		[Address(RVA = "0x3FD4094", Offset = "0x3FD0094", VA = "0x3FD4094")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__1))]
		public void Init(string id)
		{
		}

		[Token(Token = "0x6002A4F")]
		[Address(RVA = "0x3FD4134", Offset = "0x3FD0134", VA = "0x3FD4134")]
		public FetterShowCardItem()
		{
		}
	}
}
