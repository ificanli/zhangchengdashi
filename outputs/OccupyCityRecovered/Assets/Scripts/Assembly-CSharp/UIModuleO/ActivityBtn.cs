using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using Spine.Unity;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000697")]
	public class ActivityBtn : ActivityBtnComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000698")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__3 : IAsyncStateMachine
		{
			[Token(Token = "0x4003516")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003517")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003518")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ActivityBtn _003C_003E4__this;

			[Token(Token = "0x4003519")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x60022EB")]
			[Address(RVA = "0x3F3F9E0", Offset = "0x3F3B9E0", VA = "0x3F3F9E0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60022EC")]
			[Address(RVA = "0x3F3FBC0", Offset = "0x3F3BBC0", VA = "0x3F3FBC0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000699")]
		[CompilerGenerated]
		private struct _003CUpdateIcon_003Ed__5 : IAsyncStateMachine
		{
			[Token(Token = "0x400351A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400351B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400351C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ActivityBtn _003C_003E4__this;

			[Token(Token = "0x400351D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string path;

			[Token(Token = "0x400351E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Image _003C_003E7__wrap1;

			[Token(Token = "0x400351F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask<UnityEngine.Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60022ED")]
			[Address(RVA = "0x3F3FBCC", Offset = "0x3F3BBCC", VA = "0x3F3FBCC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60022EE")]
			[Address(RVA = "0x3F400D8", Offset = "0x3F3C0D8", VA = "0x3F400D8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200069A")]
		[CompilerGenerated]
		private struct _003CUpdateSpine_003Ed__6 : IAsyncStateMachine
		{
			[Token(Token = "0x4003520")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003521")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003522")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ActivityBtn _003C_003E4__this;

			[Token(Token = "0x4003523")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string path;

			[Token(Token = "0x4003524")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private SkeletonGraphic _003C_003E7__wrap1;

			[Token(Token = "0x4003525")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask<SkeletonDataAsset>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60022EF")]
			[Address(RVA = "0x3F400E4", Offset = "0x3F3C0E4", VA = "0x3F400E4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60022F0")]
			[Address(RVA = "0x3F40478", Offset = "0x3F3C478", VA = "0x3F40478", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x170001EB")]
		public bool ShowCutDowning
		{
			[Token(Token = "0x60022E1")]
			[Address(RVA = "0x3F3F2D4", Offset = "0x3F3B2D4", VA = "0x3F3F2D4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60022E2")]
		[Address(RVA = "0x3F3F3C4", Offset = "0x3F3B3C4", VA = "0x3F3F3C4", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60022E3")]
		[Address(RVA = "0x3F3F410", Offset = "0x3F3B410", VA = "0x3F3F410", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__3))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60022E4")]
		[Address(RVA = "0x3F3F4A4", Offset = "0x3F3B4A4", VA = "0x3F3F4A4")]
		public void UpdateName(string getLocalization)
		{
		}

		[Token(Token = "0x60022E5")]
		[Address(RVA = "0x3F3F6B4", Offset = "0x3F3B6B4", VA = "0x3F3F6B4")]
		[AsyncStateMachine(typeof(_003CUpdateIcon_003Ed__5))]
		public void UpdateIcon(string path)
		{
		}

		[Token(Token = "0x60022E6")]
		[Address(RVA = "0x3F3F754", Offset = "0x3F3B754", VA = "0x3F3F754")]
		[AsyncStateMachine(typeof(_003CUpdateSpine_003Ed__6))]
		public void UpdateSpine(string path)
		{
		}

		[Token(Token = "0x60022E7")]
		[Address(RVA = "0x3F3F7F4", Offset = "0x3F3B7F4", VA = "0x3F3F7F4")]
		public void UpdateCutDown(string timeStr)
		{
		}

		[Token(Token = "0x60022E8")]
		[Address(RVA = "0x3F3F3E8", Offset = "0x3F3B3E8", VA = "0x3F3F3E8")]
		public void HideCutDown()
		{
		}

		[Token(Token = "0x60022E9")]
		[Address(RVA = "0x3F3F938", Offset = "0x3F3B938", VA = "0x3F3F938")]
		public ActivityBtn()
		{
		}
	}
}
