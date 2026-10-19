using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using UIFramework;
using WG.CollectKit;

namespace UIModuleO
{
	[Token(Token = "0x200084A")]
	public class CollectTweenPanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200084B")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__155 : IAsyncStateMachine
		{
			[Token(Token = "0x4003F26")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003F27")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003F28")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public CollectTweenPanelComponents _003C_003E4__this;

			[Token(Token = "0x4003F29")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6002EAC")]
			[Address(RVA = "0x4024290", Offset = "0x4020290", VA = "0x4024290", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002EAD")]
			[Address(RVA = "0x4024508", Offset = "0x4020508", VA = "0x4024508", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003F21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private CollectTweenContent _collectTweenContentUserResourceExp;

		[Token(Token = "0x4003F22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private CollectTweenContent _collectTweenContentMorale;

		[Token(Token = "0x4003F23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private CollectTweenContent _collectTweenContentInBattleWoodLeft;

		[Token(Token = "0x4003F24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private CollectTweenContent _collectTweenContentInBattleWoodRight;

		[Token(Token = "0x4003F25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private CollectTweenContent _collectTweenContentSeasonPassScore;

		[Token(Token = "0x1700056B")]
		public CollectTweenContent CollectTweenContentUserResourceExp
		{
			[Token(Token = "0x6002EA1")]
			[Address(RVA = "0x40235AC", Offset = "0x401F5AC", VA = "0x40235AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700056C")]
		public CollectTweenContent CollectTweenContentMorale
		{
			[Token(Token = "0x6002EA2")]
			[Address(RVA = "0x4023674", Offset = "0x401F674", VA = "0x4023674")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700056D")]
		public CollectTweenContent CollectTweenContentInBattleWoodLeft
		{
			[Token(Token = "0x6002EA3")]
			[Address(RVA = "0x402373C", Offset = "0x401F73C", VA = "0x402373C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700056E")]
		public CollectTweenContent CollectTweenContentInBattleWoodRight
		{
			[Token(Token = "0x6002EA4")]
			[Address(RVA = "0x4023804", Offset = "0x401F804", VA = "0x4023804")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700056F")]
		public CollectTweenContent CollectTweenContentSeasonPassScore
		{
			[Token(Token = "0x6002EA5")]
			[Address(RVA = "0x40238CC", Offset = "0x401F8CC", VA = "0x40238CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002EA6")]
		[Address(RVA = "0x40241D0", Offset = "0x40201D0", VA = "0x40241D0")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6002EA7")]
		[Address(RVA = "0x40223A8", Offset = "0x401E3A8", VA = "0x40223A8", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6002EA8")]
		[Address(RVA = "0x40223B4", Offset = "0x401E3B4", VA = "0x40223B4", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__155))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6002EA9")]
		[Address(RVA = "0x40241D4", Offset = "0x40201D4", VA = "0x40241D4", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6002EAA")]
		[Address(RVA = "0x4022398", Offset = "0x401E398", VA = "0x4022398")]
		public CollectTweenPanelComponents()
		{
		}
	}
}
