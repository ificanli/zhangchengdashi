using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x20006F0")]
	public class AvatarItem : AvatarItemComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20006F1")]
		[CompilerGenerated]
		private struct _003CInitAvatarItem_003Ed__2 : IAsyncStateMachine
		{
			[Token(Token = "0x4003758")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003759")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400375A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public AvatarItem _003C_003E4__this;

			[Token(Token = "0x400375B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string roleId;

			[Token(Token = "0x400375C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool campIsRed;

			[Token(Token = "0x400375D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Image _003C_003E7__wrap1;

			[Token(Token = "0x400375E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600258E")]
			[Address(RVA = "0x3F8656C", Offset = "0x3F8256C", VA = "0x3F8656C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600258F")]
			[Address(RVA = "0x3F872B4", Offset = "0x3F832B4", VA = "0x3F872B4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20006F2")]
		[CompilerGenerated]
		private struct _003CInitAvatarItemByPath_003Ed__3 : IAsyncStateMachine
		{
			[Token(Token = "0x400375F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003760")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003761")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool campIsRed;

			[Token(Token = "0x4003762")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public AvatarItem _003C_003E4__this;

			[Token(Token = "0x4003763")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string path;

			[Token(Token = "0x4003764")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Image _003C_003E7__wrap1;

			[Token(Token = "0x4003765")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002590")]
			[Address(RVA = "0x3F872C0", Offset = "0x3F832C0", VA = "0x3F872C0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002591")]
			[Address(RVA = "0x3F87E00", Offset = "0x3F83E00", VA = "0x3F87E00", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003757")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private string roleId;

		[Token(Token = "0x6002589")]
		[Address(RVA = "0x3F86300", Offset = "0x3F82300", VA = "0x3F86300", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600258A")]
		[Address(RVA = "0x3F86310", Offset = "0x3F82310", VA = "0x3F86310")]
		[AsyncStateMachine(typeof(_003CInitAvatarItem_003Ed__2))]
		public void InitAvatarItem(string roleId, bool campIsRed = false)
		{
		}

		[Token(Token = "0x600258B")]
		[Address(RVA = "0x3F863B8", Offset = "0x3F823B8", VA = "0x3F863B8")]
		[AsyncStateMachine(typeof(_003CInitAvatarItemByPath_003Ed__3))]
		public void InitAvatarItemByPath(string path, bool campIsRed = false)
		{
		}

		[Token(Token = "0x600258C")]
		[Address(RVA = "0x3F86460", Offset = "0x3F82460", VA = "0x3F86460")]
		public void HideItem()
		{
		}

		[Token(Token = "0x600258D")]
		[Address(RVA = "0x3F8655C", Offset = "0x3F8255C", VA = "0x3F8655C")]
		public AvatarItem()
		{
		}
	}
}
