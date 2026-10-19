using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using GameModule;
using Il2CppDummyDll;

namespace UIModuleO
{
	[Token(Token = "0x20009A8")]
	public class MysteriousStoreAffirmPanel : MysteriousStoreAffirmPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20009A9")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__4 : IAsyncStateMachine
		{
			[Token(Token = "0x4004838")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004839")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400483A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MysteriousStoreAffirmPanel _003C_003E4__this;

			[Token(Token = "0x400483B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6003971")]
			[Address(RVA = "0x41044E0", Offset = "0x41004E0", VA = "0x41044E0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003972")]
			[Address(RVA = "0x4104ABC", Offset = "0x4100ABC", VA = "0x4104ABC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004835")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int price;

		[Token(Token = "0x4004836")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private RewardConfig _rewardConfig;

		[Token(Token = "0x4004837")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private MysteriousStoreData _data;

		[Token(Token = "0x600396A")]
		[Address(RVA = "0x4103E7C", Offset = "0x40FFE7C", VA = "0x4103E7C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600396B")]
		[Address(RVA = "0x4103F94", Offset = "0x40FFF94", VA = "0x4103F94", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__4))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x600396C")]
		[Address(RVA = "0x4104028", Offset = "0x4100028", VA = "0x4104028", Slot = "12")]
		protected override void OnButtonBGClicked()
		{
		}

		[Token(Token = "0x600396D")]
		[Address(RVA = "0x41040C4", Offset = "0x41000C4", VA = "0x41040C4", Slot = "13")]
		protected override void OnButtonExtendBtnCloseClicked()
		{
		}

		[Token(Token = "0x600396E")]
		[Address(RVA = "0x4104160", Offset = "0x4100160", VA = "0x4104160", Slot = "14")]
		protected override void OnButtonExtendBtnBuyClicked()
		{
		}

		[Token(Token = "0x600396F")]
		[Address(RVA = "0x4104438", Offset = "0x4100438", VA = "0x4104438")]
		public MysteriousStoreAffirmPanel()
		{
		}
	}
}
