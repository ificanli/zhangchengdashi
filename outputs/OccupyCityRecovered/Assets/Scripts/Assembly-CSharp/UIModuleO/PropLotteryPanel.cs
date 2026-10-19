using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DG.Tweening;
using GameModule;
using Il2CppDummyDll;

namespace UIModuleO
{
	[Token(Token = "0x2000AB1")]
	public class PropLotteryPanel : PropLotteryPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000AB3")]
		[CompilerGenerated]
		private struct _003COnButtonExtendConfirmBtnClicked_003Ed__16 : IAsyncStateMachine
		{
			[Token(Token = "0x4004EBB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004EBC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004EBD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public PropLotteryPanel _003C_003E4__this;

			[Token(Token = "0x6004098")]
			[Address(RVA = "0x41ABE78", Offset = "0x41A7E78", VA = "0x41ABE78", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004099")]
			[Address(RVA = "0x41ABF60", Offset = "0x41A7F60", VA = "0x41ABF60", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000AB4")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__13 : IAsyncStateMachine
		{
			[Token(Token = "0x4004EBE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004EBF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004EC0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public PropLotteryPanel _003C_003E4__this;

			[Token(Token = "0x4004EC1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x4004EC2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private RewardConfig _003CrewardConfig_003E5__2;

			[Token(Token = "0x4004EC3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float _003CdelayTime_003E5__3;

			[Token(Token = "0x4004EC4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private List<int> _003CcountList_003E5__4;

			[Token(Token = "0x4004EC5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask<UnityEngine.GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x4004EC6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private UniTask.Awaiter _003C_003Eu__2;

			[Token(Token = "0x600409A")]
			[Address(RVA = "0x41ABF6C", Offset = "0x41A7F6C", VA = "0x41ABF6C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600409B")]
			[Address(RVA = "0x41AE008", Offset = "0x41AA008", VA = "0x41AE008", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004EAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private List<PropLotteryItem> _propItemItemUis;

		[Token(Token = "0x4004EAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private bool canClose;

		[Token(Token = "0x4004EB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD1")]
		private bool _isTenSummon;

		[Token(Token = "0x4004EB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private int _summonUnitCost;

		[Token(Token = "0x4004EB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private int _summonBaseCount;

		[Token(Token = "0x4004EB3")]
		private const string NormalSummonTimesLimitTipText = "剩余次数不足";

		[Token(Token = "0x4004EB4")]
		private const int AdvancedSummonBaseCount = 100;

		[Token(Token = "0x4004EB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private SummonPanelMode _summonPanelMode;

		[Token(Token = "0x4004EB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int _summonLevel;

		[Token(Token = "0x4004EB7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private BigInteger _summonExp;

		[Token(Token = "0x4004EB8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Tween _tween;

		[Token(Token = "0x4004EB9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Tween _tween2;

		[Token(Token = "0x6004088")]
		[Address(RVA = "0x41AA53C", Offset = "0x41A653C", VA = "0x41AA53C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6004089")]
		[Address(RVA = "0x41AA634", Offset = "0x41A6634", VA = "0x41AA634", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__13))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x600408A")]
		[Address(RVA = "0x41AA6D4", Offset = "0x41A66D4", VA = "0x41AA6D4", Slot = "14")]
		protected override void OnButtonExtendBtnGemSummonClicked()
		{
		}

		[Token(Token = "0x600408B")]
		[Address(RVA = "0x41AA9E0", Offset = "0x41A69E0", VA = "0x41AA9E0")]
		private string GetSummonButtonText()
		{
			return null;
		}

		[Token(Token = "0x600408C")]
		[Address(RVA = "0x41AAA8C", Offset = "0x41A6A8C", VA = "0x41AAA8C", Slot = "15")]
		[AsyncStateMachine(typeof(_003COnButtonExtendConfirmBtnClicked_003Ed__16))]
		protected override void OnButtonExtendConfirmBtnClicked()
		{
		}

		[Token(Token = "0x600408D")]
		[Address(RVA = "0x41AAB18", Offset = "0x41A6B18", VA = "0x41AAB18", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x600408E")]
		[Address(RVA = "0x41AABE8", Offset = "0x41A6BE8", VA = "0x41AABE8")]
		private void Clear()
		{
		}

		[Token(Token = "0x600408F")]
		[Address(RVA = "0x41AAD08", Offset = "0x41A6D08", VA = "0x41AAD08")]
		private void UpdateArtifacts(object o)
		{
		}

		[Token(Token = "0x6004090")]
		[Address(RVA = "0x41AB590", Offset = "0x41A7590", VA = "0x41AB590")]
		private void RefreshNormalSummonTimesLimit()
		{
		}

		[Token(Token = "0x6004091")]
		[Address(RVA = "0x41ABBC8", Offset = "0x41A7BC8", VA = "0x41ABBC8", Slot = "12")]
		protected override void OnButtonExtendBtnSummonDesClicked()
		{
		}

		[Token(Token = "0x6004092")]
		[Address(RVA = "0x41ABD0C", Offset = "0x41A7D0C", VA = "0x41ABD0C")]
		public PropLotteryPanel()
		{
		}
	}
}
