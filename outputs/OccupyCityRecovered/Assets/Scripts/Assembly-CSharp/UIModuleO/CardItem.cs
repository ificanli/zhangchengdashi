using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using DataModule;
using Il2CppDummyDll;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000799")]
	public class CardItem : CardItemComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200079B")]
		[CompilerGenerated]
		private struct _003COnClickCardItem_003Ed__15 : IAsyncStateMachine
		{
			[Token(Token = "0x4003B14")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003B15")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003B16")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public CardItem _003C_003E4__this;

			[Token(Token = "0x6002A10")]
			[Address(RVA = "0x3FCE010", Offset = "0x3FCA010", VA = "0x3FCE010", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002A11")]
			[Address(RVA = "0x3FCE888", Offset = "0x3FCA888", VA = "0x3FCE888", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200079C")]
		[CompilerGenerated]
		private struct _003CUpdateInfo_003Ed__9 : IAsyncStateMachine
		{
			[Token(Token = "0x4003B17")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003B18")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003B19")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public CardItem _003C_003E4__this;

			[Token(Token = "0x4003B1A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public object[] args;

			[Token(Token = "0x6002A12")]
			[Address(RVA = "0x3FCE894", Offset = "0x3FCA894", VA = "0x3FCE894", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002A13")]
			[Address(RVA = "0x3FCEB74", Offset = "0x3FCAB74", VA = "0x3FCEB74", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200079D")]
		[CompilerGenerated]
		private struct _003CUpdateUI_003Ed__10 : IAsyncStateMachine
		{
			[Token(Token = "0x4003B1B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003B1C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003B1D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public CardItem _003C_003E4__this;

			[Token(Token = "0x4003B1E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Image _003C_003E7__wrap1;

			[Token(Token = "0x4003B1F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask<UnityEngine.Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x4003B20")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private UniTask.Awaiter _003C_003Eu__2;

			[Token(Token = "0x6002A14")]
			[Address(RVA = "0x3FCEB80", Offset = "0x3FCAB80", VA = "0x3FCEB80", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002A15")]
			[Address(RVA = "0x3FD08C8", Offset = "0x3FCC8C8", VA = "0x3FD08C8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003B0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Sequence _se;

		[Token(Token = "0x4003B0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private UserHeroCardData _data;

		[Token(Token = "0x4003B0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private UserHeroCardData _toEquipData;

		[Token(Token = "0x4003B0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private bool _isChangeEquipCardIng;

		[Token(Token = "0x4003B10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private List<int> customCardUnLockTalentId;

		[Token(Token = "0x4003B11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private bool ISEnemy;

		[Token(Token = "0x6002A01")]
		[Address(RVA = "0x3FCD428", Offset = "0x3FC9428", VA = "0x3FCD428", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6002A02")]
		[Address(RVA = "0x3FCD6F0", Offset = "0x3FC96F0", VA = "0x3FCD6F0")]
		private void BeginChangeEquipCard(object o)
		{
		}

		[Token(Token = "0x6002A03")]
		[Address(RVA = "0x3FCD780", Offset = "0x3FC9780", VA = "0x3FCD780")]
		private void ChangeEquipCardEnd(object o)
		{
		}

		[Token(Token = "0x6002A04")]
		[Address(RVA = "0x3FCD78C", Offset = "0x3FC978C", VA = "0x3FCD78C", Slot = "9")]
		[AsyncStateMachine(typeof(_003CUpdateInfo_003Ed__9))]
		public override void UpdateInfo(params object[] args)
		{
		}

		[Token(Token = "0x6002A05")]
		[Address(RVA = "0x3FCD828", Offset = "0x3FC9828", VA = "0x3FCD828")]
		[AsyncStateMachine(typeof(_003CUpdateUI_003Ed__10))]
		public void UpdateUI()
		{
		}

		[Token(Token = "0x6002A06")]
		[Address(RVA = "0x3FCD8B8", Offset = "0x3FC98B8", VA = "0x3FCD8B8")]
		private void UpdateRedDot(object o)
		{
		}

		[Token(Token = "0x6002A07")]
		[Address(RVA = "0x3FCDA90", Offset = "0x3FC9A90", VA = "0x3FCDA90")]
		private void ResetUIScale(object o)
		{
		}

		[Token(Token = "0x6002A08")]
		[Address(RVA = "0x3FCDAF8", Offset = "0x3FC9AF8", VA = "0x3FCDAF8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6002A09")]
		[Address(RVA = "0x3FCDDA8", Offset = "0x3FC9DA8", VA = "0x3FCDDA8", Slot = "12")]
		protected override void OnButtonExtendCardItemClicked()
		{
		}

		[Token(Token = "0x6002A0A")]
		[Address(RVA = "0x3FCDE98", Offset = "0x3FC9E98", VA = "0x3FCDE98")]
		[AsyncStateMachine(typeof(_003COnClickCardItem_003Ed__15))]
		private void OnClickCardItem()
		{
		}

		[Token(Token = "0x6002A0B")]
		[Address(RVA = "0x3FCDF24", Offset = "0x3FC9F24", VA = "0x3FCDF24")]
		public CardItem()
		{
		}
	}
}
