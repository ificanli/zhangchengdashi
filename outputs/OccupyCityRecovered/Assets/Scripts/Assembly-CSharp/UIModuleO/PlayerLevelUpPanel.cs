using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000A91")]
	public class PlayerLevelUpPanel : PlayerLevelUpPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A93")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__2 : IAsyncStateMachine
		{
			[Token(Token = "0x4004E08")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004E09")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004E0A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public PlayerLevelUpPanel _003C_003E4__this;

			[Token(Token = "0x4004E0B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x4004E0C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private string _003CrewardName_003E5__2;

			[Token(Token = "0x4004E0D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Image _003C_003E7__wrap2;

			[Token(Token = "0x4004E0E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask<UnityEngine.Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003FCF")]
			[Address(RVA = "0x419DC24", Offset = "0x4199C24", VA = "0x419DC24", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003FD0")]
			[Address(RVA = "0x419EA24", Offset = "0x419AA24", VA = "0x419EA24", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004E05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Tween tween;

		[Token(Token = "0x6003FC4")]
		[Address(RVA = "0x419D594", Offset = "0x4199594", VA = "0x419D594", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6003FC5")]
		[Address(RVA = "0x419D6AC", Offset = "0x41996AC", VA = "0x419D6AC", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__2))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6003FC6")]
		[Address(RVA = "0x419D748", Offset = "0x4199748", VA = "0x419D748", Slot = "12")]
		protected override void OnButtonExtendClaimBtnClicked()
		{
		}

		[Token(Token = "0x6003FC7")]
		[Address(RVA = "0x419D868", Offset = "0x4199868", VA = "0x419D868", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6003FC8")]
		[Address(RVA = "0x419D92C", Offset = "0x419992C", VA = "0x419D92C", Slot = "7")]
		protected override void OnHideAnimationComplete()
		{
		}

		[Token(Token = "0x6003FC9")]
		[Address(RVA = "0x419DAF4", Offset = "0x4199AF4", VA = "0x419DAF4")]
		public PlayerLevelUpPanel()
		{
		}
	}
}
