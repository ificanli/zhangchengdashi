using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using DataModule;
using Il2CppDummyDll;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x20007C9")]
	public class ImgTalentItem : ImgTalentItemComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20007CA")]
		[CompilerGenerated]
		private struct _003CEnemyInit_003Ed__5 : IAsyncStateMachine
		{
			[Token(Token = "0x4003C3F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003C40")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003C41")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ImgTalentItem _003C_003E4__this;

			[Token(Token = "0x4003C42")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool isUnlock;

			[Token(Token = "0x4003C43")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string talentId;

			[Token(Token = "0x6002B36")]
			[Address(RVA = "0x3FE9C08", Offset = "0x3FE5C08", VA = "0x3FE9C08", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002B37")]
			[Address(RVA = "0x3FE9CE4", Offset = "0x3FE5CE4", VA = "0x3FE9CE4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20007CB")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__4 : IAsyncStateMachine
		{
			[Token(Token = "0x4003C44")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003C45")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003C46")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ImgTalentItem _003C_003E4__this;

			[Token(Token = "0x4003C47")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Talent2Data data;

			[Token(Token = "0x4003C48")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public UserHeroCardData cardData;

			[Token(Token = "0x6002B38")]
			[Address(RVA = "0x3FE9CF0", Offset = "0x3FE5CF0", VA = "0x3FE9CF0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002B39")]
			[Address(RVA = "0x3FE9E04", Offset = "0x3FE5E04", VA = "0x3FE9E04", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20007CC")]
		[CompilerGenerated]
		private struct _003CUpdateUI_003Ed__6 : IAsyncStateMachine
		{
			[Token(Token = "0x4003C49")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003C4A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003C4B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ImgTalentItem _003C_003E4__this;

			[Token(Token = "0x4003C4C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string talentId;

			[Token(Token = "0x4003C4D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool isUnlock;

			[Token(Token = "0x4003C4E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Image _003C_003E7__wrap1;

			[Token(Token = "0x4003C4F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UniTask<UnityEngine.Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002B3A")]
			[Address(RVA = "0x3FE9E10", Offset = "0x3FE5E10", VA = "0x3FE9E10", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002B3B")]
			[Address(RVA = "0x3FEA720", Offset = "0x3FE6720", VA = "0x3FEA720", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003C3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Talent2Data data;

		[Token(Token = "0x4003C3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private UserHeroCardData cardData;

		[Token(Token = "0x4003C3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private bool isEnemy;

		[Token(Token = "0x6002B2D")]
		[Address(RVA = "0x3FE934C", Offset = "0x3FE534C", VA = "0x3FE934C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6002B2E")]
		[Address(RVA = "0x3FE94A4", Offset = "0x3FE54A4", VA = "0x3FE94A4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__4))]
		public void Init(Talent2Data data, UserHeroCardData cardData)
		{
		}

		[Token(Token = "0x6002B2F")]
		[Address(RVA = "0x3FE9544", Offset = "0x3FE5544", VA = "0x3FE9544")]
		[AsyncStateMachine(typeof(_003CEnemyInit_003Ed__5))]
		public void EnemyInit(bool isUnlock, string talentId)
		{
		}

		[Token(Token = "0x6002B30")]
		[Address(RVA = "0x3FE95EC", Offset = "0x3FE55EC", VA = "0x3FE95EC")]
		[AsyncStateMachine(typeof(_003CUpdateUI_003Ed__6))]
		private void UpdateUI(bool isUnlock, string talentId)
		{
		}

		[Token(Token = "0x6002B31")]
		[Address(RVA = "0x3FE9694", Offset = "0x3FE5694", VA = "0x3FE9694")]
		private void UpdateTalentNameText(bool isUnlocked)
		{
		}

		[Token(Token = "0x6002B32")]
		[Address(RVA = "0x3FE9900", Offset = "0x3FE5900", VA = "0x3FE9900")]
		private void UpgradeUpdateUI(object o)
		{
		}

		[Token(Token = "0x6002B33")]
		[Address(RVA = "0x3FE9938", Offset = "0x3FE5938", VA = "0x3FE9938", Slot = "12")]
		protected override void OnButtonExtendImgTalentItemClicked()
		{
		}

		[Token(Token = "0x6002B34")]
		[Address(RVA = "0x3FE9AD0", Offset = "0x3FE5AD0", VA = "0x3FE9AD0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6002B35")]
		[Address(RVA = "0x3FE9BF8", Offset = "0x3FE5BF8", VA = "0x3FE9BF8")]
		public ImgTalentItem()
		{
		}
	}
}
