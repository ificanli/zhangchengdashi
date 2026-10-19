using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using GameModule;
using Il2CppDummyDll;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000A96")]
	public class PropDetailAttrItem : PropDetailAttrItemComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A97")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__1 : IAsyncStateMachine
		{
			[Token(Token = "0x4004E1C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004E1D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004E1E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public PropDetailAttrItem _003C_003E4__this;

			[Token(Token = "0x4004E1F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PropManager.PropAttrType type;

			[Token(Token = "0x4004E20")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public float curValue;

			[Token(Token = "0x4004E21")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool isPreview;

			[Token(Token = "0x4004E22")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			public bool isMax;

			[Token(Token = "0x4004E23")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float nextValue;

			[Token(Token = "0x4004E24")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Image _003C_003E7__wrap1;

			[Token(Token = "0x4004E25")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask<UnityEngine.Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003FE4")]
			[Address(RVA = "0x419EEF4", Offset = "0x419AEF4", VA = "0x419EEF4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003FE5")]
			[Address(RVA = "0x419F804", Offset = "0x419B804", VA = "0x419F804", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004E1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private PropManager.PropAttrType _type;

		[Token(Token = "0x6003FE2")]
		[Address(RVA = "0x419EE0C", Offset = "0x419AE0C", VA = "0x419EE0C")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__1))]
		public UniTask Init(PropManager.PropAttrType type, float curValue, float nextValue, bool isPreview, bool isMax)
		{
			return default;
		}

		[Token(Token = "0x6003FE3")]
		[Address(RVA = "0x419EEE4", Offset = "0x419AEE4", VA = "0x419EEE4")]
		public PropDetailAttrItem()
		{
		}
	}
}
