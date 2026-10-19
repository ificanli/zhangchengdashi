using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using UIFramework;

namespace UIModuleO
{
	[Token(Token = "0x20007FD")]
	public class ArtifactStarLevelUIComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20007FE")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__953 : IAsyncStateMachine
		{
			[Token(Token = "0x4003D6C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003D6D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003D6E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ArtifactStarLevelUIComponents _003C_003E4__this;

			[Token(Token = "0x4003D6F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6002CA7")]
			[Address(RVA = "0x4001368", Offset = "0x3FFD368", VA = "0x4001368", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002CA8")]
			[Address(RVA = "0x40015E0", Offset = "0x3FFD5E0", VA = "0x40015E0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x6002CA1")]
		[Address(RVA = "0x400120C", Offset = "0x3FFD20C", VA = "0x400120C")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6002CA2")]
		[Address(RVA = "0x4001210", Offset = "0x3FFD210", VA = "0x4001210", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6002CA3")]
		[Address(RVA = "0x4001218", Offset = "0x3FFD218", VA = "0x4001218", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__953))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6002CA4")]
		[Address(RVA = "0x40012AC", Offset = "0x3FFD2AC", VA = "0x40012AC", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6002CA5")]
		[Address(RVA = "0x4000CB4", Offset = "0x3FFCCB4", VA = "0x4000CB4")]
		public ArtifactStarLevelUIComponents()
		{
		}
	}
}
