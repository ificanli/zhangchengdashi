using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using ljzs_lt;

namespace UIModuleO
{
	[Token(Token = "0x2000765")]
	public class BtnCrystalPackItem : BtnCrystalPackItemComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000766")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__6 : IAsyncStateMachine
		{
			[Token(Token = "0x40039E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40039E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40039E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BtnCrystalPackItem _003C_003E4__this;

			[Token(Token = "0x40039EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x40039EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600288F")]
			[Address(RVA = "0x3FB48C8", Offset = "0x3FB08C8", VA = "0x3FB48C8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002890")]
			[Address(RVA = "0x3FB4CBC", Offset = "0x3FB0CBC", VA = "0x3FB4CBC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000767")]
		[CompilerGenerated]
		private struct _003CUpdateInfo_003Ed__7 : IAsyncStateMachine
		{
			[Token(Token = "0x40039EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40039ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40039EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public BtnCrystalPackItem _003C_003E4__this;

			[Token(Token = "0x40039EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public object[] args;

			[Token(Token = "0x6002891")]
			[Address(RVA = "0x3FB4CC8", Offset = "0x3FB0CC8", VA = "0x3FB4CC8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002892")]
			[Address(RVA = "0x3FB52BC", Offset = "0x3FB12BC", VA = "0x3FB52BC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40039E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private CrystalPackConfig _pack;

		[Token(Token = "0x40039E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private readonly List<RewardItemUI> _rewardItemPool;

		[Token(Token = "0x40039E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private bool _rewardPoolInitialized;

		[Token(Token = "0x40039E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private float _cooldown;

		[Token(Token = "0x40039E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private float _timeCount;

		[Token(Token = "0x6002880")]
		[Address(RVA = "0x3FB3C70", Offset = "0x3FAFC70", VA = "0x3FB3C70", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6002881")]
		[Address(RVA = "0x3FB3D58", Offset = "0x3FAFD58", VA = "0x3FB3D58", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__6))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6002882")]
		[Address(RVA = "0x3FB3E00", Offset = "0x3FAFE00", VA = "0x3FB3E00", Slot = "9")]
		[AsyncStateMachine(typeof(_003CUpdateInfo_003Ed__7))]
		public override void UpdateInfo(params object[] args)
		{
		}

		[Token(Token = "0x6002883")]
		[Address(RVA = "0x3FB3C8C", Offset = "0x3FAFC8C", VA = "0x3FB3C8C")]
		private void EnsureRewardTemplateReady()
		{
		}

		[Token(Token = "0x6002884")]
		[Address(RVA = "0x3FB3E9C", Offset = "0x3FAFE9C", VA = "0x3FB3E9C")]
		private static void ConfigureCrystalPackRewardItem(RewardItemUI item)
		{
		}

		[Token(Token = "0x6002885")]
		[Address(RVA = "0x3FB3F18", Offset = "0x3FAFF18", VA = "0x3FB3F18")]
		private RewardItemUI CreateRewardItemInstance()
		{
			return null;
		}

		[Token(Token = "0x6002886")]
		[Address(RVA = "0x3FB3FC4", Offset = "0x3FAFFC4", VA = "0x3FB3FC4")]
		private void RefreshRewardPreview(CrystalPackConfig pack)
		{
		}

		[Token(Token = "0x6002887")]
		[Address(RVA = "0x3FB4258", Offset = "0x3FB0258", VA = "0x3FB4258")]
		private void HideAllRewardItems()
		{
		}

		[Token(Token = "0x6002888")]
		[Address(RVA = "0x3FB42F4", Offset = "0x3FB02F4", VA = "0x3FB42F4")]
		private void RefreshBenefitDisplay(CrystalPackConfig pack)
		{
		}

		[Token(Token = "0x6002889")]
		[Address(RVA = "0x3FB4448", Offset = "0x3FB0448", VA = "0x3FB4448")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600288A")]
		[Address(RVA = "0x3FB44D8", Offset = "0x3FB04D8", VA = "0x3FB44D8")]
		private void Update()
		{
		}

		[Token(Token = "0x600288B")]
		[Address(RVA = "0x3FB4630", Offset = "0x3FB0630", VA = "0x3FB4630", Slot = "12")]
		protected override void OnButtonExtendBtnCrystalPackItemClicked()
		{
		}

		[Token(Token = "0x600288C")]
		[Address(RVA = "0x3FB4834", Offset = "0x3FB0834", VA = "0x3FB4834")]
		public BtnCrystalPackItem()
		{
		}
	}
}
