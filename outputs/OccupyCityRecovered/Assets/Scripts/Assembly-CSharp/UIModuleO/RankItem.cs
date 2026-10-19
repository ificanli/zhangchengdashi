using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using DataModule;
using Il2CppDummyDll;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000AC3")]
	public class RankItem : RankItemComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000AC4")]
		[CompilerGenerated]
		private struct _003CInitInfo_003Ed__0 : IAsyncStateMachine
		{
			[Token(Token = "0x4004F2B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004F2C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004F2D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public RankItemData info;

			[Token(Token = "0x4004F2E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int i;

			[Token(Token = "0x4004F2F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public RankItem _003C_003E4__this;

			[Token(Token = "0x4004F30")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Image _003C_003E7__wrap1;

			[Token(Token = "0x4004F31")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UniTask<UnityEngine.Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6004113")]
			[Address(RVA = "0x41B5330", Offset = "0x41B1330", VA = "0x41B5330", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004114")]
			[Address(RVA = "0x41B62D8", Offset = "0x41B22D8", VA = "0x41B62D8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x6004111")]
		[Address(RVA = "0x41B493C", Offset = "0x41B093C", VA = "0x41B493C")]
		[AsyncStateMachine(typeof(_003CInitInfo_003Ed__0))]
		public void InitInfo(RankItemData info, int i)
		{
		}

		[Token(Token = "0x6004112")]
		[Address(RVA = "0x41B5320", Offset = "0x41B1320", VA = "0x41B5320")]
		public RankItem()
		{
		}
	}
}
