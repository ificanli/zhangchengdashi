using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using QuickTutor;

namespace UIModuleO
{
	[Token(Token = "0x2000BCB")]
	public class TutorialPanel : BaseTutorialPanel
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000BCC")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__8 : IAsyncStateMachine
		{
			[Token(Token = "0x40055BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40055BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40055BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public TutorialPanel _003C_003E4__this;

			[Token(Token = "0x40055BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x40055BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60048DB")]
			[Address(RVA = "0x423E980", Offset = "0x423A980", VA = "0x423E980", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60048DC")]
			[Address(RVA = "0x423ED74", Offset = "0x423AD74", VA = "0x423ED74", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000BCD")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__9 : IAsyncStateMachine
		{
			[Token(Token = "0x40055C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40055C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40055C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public TutorialPanel _003C_003E4__this;

			[Token(Token = "0x40055C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x40055C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool shouldPlayAnimation;

			[Token(Token = "0x40055C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60048DD")]
			[Address(RVA = "0x423ED80", Offset = "0x423AD80", VA = "0x423ED80", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60048DE")]
			[Address(RVA = "0x423F408", Offset = "0x423B408", VA = "0x423F408", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40055B7")]
		private const float InputLockSecondsAfterIntro = 0.5f;

		[Token(Token = "0x40055B8")]
		private const float InputLockSecondsChainStep = 0.35f;

		[Token(Token = "0x40055B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private bool _isAutoOpeningNextId;

		[Token(Token = "0x40055BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Sequence _closeSeq;

		[Token(Token = "0x60048D1")]
		[Address(RVA = "0x423E41C", Offset = "0x423A41C", VA = "0x423E41C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60048D2")]
		[Address(RVA = "0x423E518", Offset = "0x423A518", VA = "0x423E518")]
		private void OnTutorialEnd(object obj)
		{
		}

		[Token(Token = "0x60048D3")]
		[Address(RVA = "0x423E524", Offset = "0x423A524", VA = "0x423E524", Slot = "17")]
		public override void Base_Open(params object[] args)
		{
		}

		[Token(Token = "0x60048D4")]
		[Address(RVA = "0x423E644", Offset = "0x423A644", VA = "0x423E644", Slot = "18")]
		public override void Base_Close()
		{
		}

		[Token(Token = "0x60048D5")]
		[Address(RVA = "0x423E894", Offset = "0x423A894", VA = "0x423E894", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__8))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60048D6")]
		[Address(RVA = "0x423E5A0", Offset = "0x423A5A0", VA = "0x423E5A0")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__9))]
		private UniTask Show(object[] args, bool shouldPlayAnimation)
		{
			return default;
		}

		[Token(Token = "0x60048D7")]
		[Address(RVA = "0x423E930", Offset = "0x423A930", VA = "0x423E930")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60048D8")]
		[Address(RVA = "0x423E964", Offset = "0x423A964", VA = "0x423E964")]
		public TutorialPanel()
		{
		}
	}
}
