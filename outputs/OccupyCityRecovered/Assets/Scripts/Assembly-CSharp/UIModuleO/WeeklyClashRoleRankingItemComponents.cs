using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UIFramework;

namespace UIModuleO
{
	[Token(Token = "0x2000C2D")]
	public class WeeklyClashRoleRankingItemComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000C2E")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__95 : IAsyncStateMachine
		{
			[Token(Token = "0x40057B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40057B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40057B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public WeeklyClashRoleRankingItemComponents _003C_003E4__this;

			[Token(Token = "0x40057B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6004B6C")]
			[Address(RVA = "0x4268BE4", Offset = "0x4264BE4", VA = "0x4268BE4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004B6D")]
			[Address(RVA = "0x4268E5C", Offset = "0x4264E5C", VA = "0x4268E5C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40057B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TextMeshProUGUI _textMeshProUGUIRoleName;

		[Token(Token = "0x40057B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TextMeshProUGUI _textMeshProUGUIScoresText;

		[Token(Token = "0x40057B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private AvatarItem _avatarItemAvatarItem;

		[Token(Token = "0x17000D50")]
		public TextMeshProUGUI TextMeshProUGUIRoleName
		{
			[Token(Token = "0x6004B63")]
			[Address(RVA = "0x42688B8", Offset = "0x42648B8", VA = "0x42688B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D51")]
		public TextMeshProUGUI TextMeshProUGUIScoresText
		{
			[Token(Token = "0x6004B64")]
			[Address(RVA = "0x4268A48", Offset = "0x4264A48", VA = "0x4268A48")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D52")]
		public AvatarItem AvatarItemAvatarItem
		{
			[Token(Token = "0x6004B65")]
			[Address(RVA = "0x4268980", Offset = "0x4264980", VA = "0x4268980")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004B66")]
		[Address(RVA = "0x4268B1C", Offset = "0x4264B1C", VA = "0x4268B1C")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6004B67")]
		[Address(RVA = "0x4268B20", Offset = "0x4264B20", VA = "0x4268B20", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6004B68")]
		[Address(RVA = "0x426839C", Offset = "0x426439C", VA = "0x426839C", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__95))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6004B69")]
		[Address(RVA = "0x4268B28", Offset = "0x4264B28", VA = "0x4268B28", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6004B6A")]
		[Address(RVA = "0x4268390", Offset = "0x4264390", VA = "0x4268390")]
		public WeeklyClashRoleRankingItemComponents()
		{
		}
	}
}
