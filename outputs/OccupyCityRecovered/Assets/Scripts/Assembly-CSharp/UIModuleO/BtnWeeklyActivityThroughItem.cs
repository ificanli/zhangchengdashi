using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000784")]
	public class BtnWeeklyActivityThroughItem : BtnWeeklyActivityThroughItemComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000785")]
		[CompilerGenerated]
		private struct _003CUpdateInfo_003Ed__5 : IAsyncStateMachine
		{
			[Token(Token = "0x4003A81")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003A82")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003A83")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public BtnWeeklyActivityThroughItem _003C_003E4__this;

			[Token(Token = "0x4003A84")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public object[] args;

			[Token(Token = "0x4003A85")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Image _003C_003E7__wrap1;

			[Token(Token = "0x4003A86")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask<UnityEngine.Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600294D")]
			[Address(RVA = "0x3FC1464", Offset = "0x3FBD464", VA = "0x3FC1464", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600294E")]
			[Address(RVA = "0x3FC2E48", Offset = "0x3FBEE48", VA = "0x3FC2E48", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003A7F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private RewardItemUI[] rewardItemUis;

		[Token(Token = "0x4003A80")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Tween lightTween;

		[Token(Token = "0x6002943")]
		[Address(RVA = "0x3FC0B9C", Offset = "0x3FBCB9C", VA = "0x3FC0B9C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6002944")]
		[Address(RVA = "0x3FC0CF0", Offset = "0x3FBCCF0", VA = "0x3FC0CF0", Slot = "5")]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6002945")]
		[Address(RVA = "0x3FC0E3C", Offset = "0x3FBCE3C", VA = "0x3FC0E3C")]
		private void Update()
		{
		}

		[Token(Token = "0x6002946")]
		[Address(RVA = "0x3FC1094", Offset = "0x3FBD094", VA = "0x3FC1094", Slot = "9")]
		[AsyncStateMachine(typeof(_003CUpdateInfo_003Ed__5))]
		public override void UpdateInfo(params object[] args)
		{
		}

		[Token(Token = "0x6002947")]
		[Address(RVA = "0x3FC1134", Offset = "0x3FBD134", VA = "0x3FC1134", Slot = "12")]
		protected override void OnButtonExtendBtnWeeklyActivityThroughItemClicked()
		{
		}

		[Token(Token = "0x6002948")]
		[Address(RVA = "0x3FC1274", Offset = "0x3FBD274", VA = "0x3FC1274")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6002949")]
		[Address(RVA = "0x3FC13FC", Offset = "0x3FBD3FC", VA = "0x3FC13FC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600294A")]
		[Address(RVA = "0x3FC1424", Offset = "0x3FBD424", VA = "0x3FC1424")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600294B")]
		[Address(RVA = "0x3FC144C", Offset = "0x3FBD44C", VA = "0x3FC144C")]
		public BtnWeeklyActivityThroughItem()
		{
		}
	}
}
