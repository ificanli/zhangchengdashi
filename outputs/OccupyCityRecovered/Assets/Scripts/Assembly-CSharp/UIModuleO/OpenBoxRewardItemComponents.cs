using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using UIFramework;
using UnityEngine;

namespace UIModuleO
{
	[Token(Token = "0x2000A8F")]
	public class OpenBoxRewardItemComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A90")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__188 : IAsyncStateMachine
		{
			[Token(Token = "0x4004E01")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004E02")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004E03")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public OpenBoxRewardItemComponents _003C_003E4__this;

			[Token(Token = "0x4004E04")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6003FC2")]
			[Address(RVA = "0x419D310", Offset = "0x4199310", VA = "0x419D310", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003FC3")]
			[Address(RVA = "0x419D588", Offset = "0x4199588", VA = "0x419D588", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004DFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RewardItemUI _rewardItemUIRewardItemUI;

		[Token(Token = "0x4004E00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private ParticleSystem _particleSystemGlowTrailUI;

		[Token(Token = "0x170009E4")]
		public RewardItemUI RewardItemUIRewardItemUI
		{
			[Token(Token = "0x6003FBA")]
			[Address(RVA = "0x419CB5C", Offset = "0x4198B5C", VA = "0x419CB5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009E5")]
		public ParticleSystem ParticleSystemGlowTrailUI
		{
			[Token(Token = "0x6003FBB")]
			[Address(RVA = "0x419CA94", Offset = "0x4198A94", VA = "0x419CA94")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003FBC")]
		[Address(RVA = "0x419D1B4", Offset = "0x41991B4", VA = "0x419D1B4")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6003FBD")]
		[Address(RVA = "0x419D1B8", Offset = "0x41991B8", VA = "0x419D1B8", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6003FBE")]
		[Address(RVA = "0x419D1C0", Offset = "0x41991C0", VA = "0x419D1C0", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__188))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6003FBF")]
		[Address(RVA = "0x419D254", Offset = "0x4199254", VA = "0x419D254", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6003FC0")]
		[Address(RVA = "0x419CC2C", Offset = "0x4198C2C", VA = "0x419CC2C")]
		public OpenBoxRewardItemComponents()
		{
		}
	}
}
