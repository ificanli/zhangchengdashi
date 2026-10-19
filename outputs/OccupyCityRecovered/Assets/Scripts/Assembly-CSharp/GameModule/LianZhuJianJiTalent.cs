using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x20003B5")]
	public class LianZhuJianJiTalent : TalentBase
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20003B6")]
		[CompilerGenerated]
		private struct _003CHandleEvent_003Ed__2 : IAsyncStateMachine
		{
			[Token(Token = "0x4002636")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002637")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002638")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public LianZhuJianJiTalent _003C_003E4__this;

			[Token(Token = "0x4002639")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public GameEventArgs args;

			[Token(Token = "0x400263A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private RoleBehaviour _003CsourceRole_003E5__2;

			[Token(Token = "0x400263B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60010C2")]
			[Address(RVA = "0x3DA4AF4", Offset = "0x3DA0AF4", VA = "0x3DA4AF4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60010C3")]
			[Address(RVA = "0x3DA543C", Offset = "0x3DA143C", VA = "0x3DA543C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4002635")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int attackNum;

		[Token(Token = "0x60010BF")]
		[Address(RVA = "0x3DA4A48", Offset = "0x3DA0A48", VA = "0x3DA4A48")]
		public LianZhuJianJiTalent(string talentId, GameEventType eventType, float value) : base(talentId, eventType, value)
		{
		}

		[Token(Token = "0x60010C0")]
		[Address(RVA = "0x3DA4A50", Offset = "0x3DA0A50", VA = "0x3DA4A50", Slot = "6")]
		[AsyncStateMachine(typeof(_003CHandleEvent_003Ed__2))]
		protected override void HandleEvent(GameEventArgs args)
		{
		}

		[Token(Token = "0x60010C1")]
		[Address(RVA = "0x3DA4AEC", Offset = "0x3DA0AEC", VA = "0x3DA4AEC", Slot = "7")]
		public override void Clear()
		{
		}
	}
}
