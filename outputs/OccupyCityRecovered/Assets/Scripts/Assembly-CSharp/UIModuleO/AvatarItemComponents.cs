using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using UIFramework;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x20006F3")]
	public class AvatarItemComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20006F4")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__35 : IAsyncStateMachine
		{
			[Token(Token = "0x4003769")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400376A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400376B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public AvatarItemComponents _003C_003E4__this;

			[Token(Token = "0x400376C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x600259B")]
			[Address(RVA = "0x3F87F60", Offset = "0x3F83F60", VA = "0x3F87F60", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600259C")]
			[Address(RVA = "0x3F881D8", Offset = "0x3F841D8", VA = "0x3F881D8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003766")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Image _imageBackground;

		[Token(Token = "0x4003767")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Image _imageMask;

		[Token(Token = "0x4003768")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Image _imageRoleIcon;

		[Token(Token = "0x170002C3")]
		public Image ImageBackground
		{
			[Token(Token = "0x6002592")]
			[Address(RVA = "0x3F87124", Offset = "0x3F83124", VA = "0x3F87124")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002C4")]
		public Image ImageMask
		{
			[Token(Token = "0x6002593")]
			[Address(RVA = "0x3F871EC", Offset = "0x3F831EC", VA = "0x3F871EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002C5")]
		public Image ImageRoleIcon
		{
			[Token(Token = "0x6002594")]
			[Address(RVA = "0x3F86494", Offset = "0x3F82494", VA = "0x3F86494")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002595")]
		[Address(RVA = "0x3F87E0C", Offset = "0x3F83E0C", VA = "0x3F87E0C")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6002596")]
		[Address(RVA = "0x3F86308", Offset = "0x3F82308", VA = "0x3F86308", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6002597")]
		[Address(RVA = "0x3F87E10", Offset = "0x3F83E10", VA = "0x3F87E10", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__35))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6002598")]
		[Address(RVA = "0x3F87EA4", Offset = "0x3F83EA4", VA = "0x3F87EA4", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6002599")]
		[Address(RVA = "0x3F86564", Offset = "0x3F82564", VA = "0x3F86564")]
		public AvatarItemComponents()
		{
		}
	}
}
