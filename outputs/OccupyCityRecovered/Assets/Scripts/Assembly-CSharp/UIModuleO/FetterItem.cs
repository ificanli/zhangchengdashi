using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using GameModule;
using Il2CppDummyDll;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x20007A4")]
	public class FetterItem : FetterItemComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20007A5")]
		[CompilerGenerated]
		private struct _003CInitInfoAtkWayType_003Ed__1 : IAsyncStateMachine
		{
			[Token(Token = "0x4003B4D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003B4E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003B4F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool isEnemy;

			[Token(Token = "0x4003B50")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public FetterItem _003C_003E4__this;

			[Token(Token = "0x4003B51")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public AtkWayType type;

			[Token(Token = "0x4003B52")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public int count;

			[Token(Token = "0x4003B53")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Image _003C_003E7__wrap1;

			[Token(Token = "0x4003B54")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UniTask<UnityEngine.Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002A40")]
			[Address(RVA = "0x3FD2940", Offset = "0x3FCE940", VA = "0x3FD2940", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002A41")]
			[Address(RVA = "0x3FD314C", Offset = "0x3FCF14C", VA = "0x3FD314C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20007A6")]
		[CompilerGenerated]
		private struct _003CInitInfoFetter_003Ed__0 : IAsyncStateMachine
		{
			[Token(Token = "0x4003B55")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003B56")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003B57")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool isEnemy;

			[Token(Token = "0x4003B58")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public FetterItem _003C_003E4__this;

			[Token(Token = "0x4003B59")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public CardFettersType type;

			[Token(Token = "0x4003B5A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public int count;

			[Token(Token = "0x4003B5B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Image _003C_003E7__wrap1;

			[Token(Token = "0x4003B5C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UniTask<UnityEngine.Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002A42")]
			[Address(RVA = "0x3FD3158", Offset = "0x3FCF158", VA = "0x3FD3158", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002A43")]
			[Address(RVA = "0x3FD3CA8", Offset = "0x3FCFCA8", VA = "0x3FD3CA8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x6002A3D")]
		[Address(RVA = "0x3FD27C0", Offset = "0x3FCE7C0", VA = "0x3FD27C0")]
		[AsyncStateMachine(typeof(_003CInitInfoFetter_003Ed__0))]
		public void InitInfoFetter(CardFettersType type, int count, bool isEnemy)
		{
		}

		[Token(Token = "0x6002A3E")]
		[Address(RVA = "0x3FD2878", Offset = "0x3FCE878", VA = "0x3FD2878")]
		[AsyncStateMachine(typeof(_003CInitInfoAtkWayType_003Ed__1))]
		public void InitInfoAtkWayType(AtkWayType type, int count, bool isEnemy)
		{
		}

		[Token(Token = "0x6002A3F")]
		[Address(RVA = "0x3FD2930", Offset = "0x3FCE930", VA = "0x3FD2930")]
		public FetterItem()
		{
		}
	}
}
