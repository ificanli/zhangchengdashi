using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using Il2CppDummyDll;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000BEB")]
	public class UpgradeTalentPanel : UpgradeTalentPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000BEC")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__3 : IAsyncStateMachine
		{
			[Token(Token = "0x4005667")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005668")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005669")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UpgradeTalentPanel _003C_003E4__this;

			[Token(Token = "0x400566A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x60049AD")]
			[Address(RVA = "0x424CC20", Offset = "0x4248C20", VA = "0x424CC20", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60049AE")]
			[Address(RVA = "0x424CF68", Offset = "0x4248F68", VA = "0x424CF68", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000BED")]
		[CompilerGenerated]
		private struct _003CUpdateInfo_003Ed__4 : IAsyncStateMachine
		{
			[Token(Token = "0x400566B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400566C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400566D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public UpgradeTalentPanel _003C_003E4__this;

			[Token(Token = "0x400566E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public object[] args;

			[Token(Token = "0x400566F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Image _003C_003E7__wrap1;

			[Token(Token = "0x4005670")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask<UnityEngine.Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60049AF")]
			[Address(RVA = "0x424CF74", Offset = "0x4248F74", VA = "0x424CF74", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60049B0")]
			[Address(RVA = "0x424ED18", Offset = "0x424AD18", VA = "0x424ED18", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4005664")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Talent2Data talentData;

		[Token(Token = "0x4005665")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private UserHeroCardData cardData;

		[Token(Token = "0x4005666")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private int upgradeRequireNum;

		[Token(Token = "0x60049A5")]
		[Address(RVA = "0x424C1BC", Offset = "0x42481BC", VA = "0x424C1BC", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__3))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60049A6")]
		[Address(RVA = "0x424C250", Offset = "0x4248250", VA = "0x424C250", Slot = "9")]
		[AsyncStateMachine(typeof(_003CUpdateInfo_003Ed__4))]
		public override void UpdateInfo(params object[] args)
		{
		}

		[Token(Token = "0x60049A7")]
		[Address(RVA = "0x424C2F0", Offset = "0x42482F0", VA = "0x424C2F0", Slot = "14")]
		protected override void OnButtonExtendBtnUpgradeTalentClicked()
		{
		}

		[Token(Token = "0x60049A8")]
		[Address(RVA = "0x424CA58", Offset = "0x4248A58", VA = "0x424CA58", Slot = "13")]
		protected override void OnButtonExtendBtnUpgradeTalentCloseClicked()
		{
		}

		[Token(Token = "0x60049A9")]
		[Address(RVA = "0x424CAE4", Offset = "0x4248AE4", VA = "0x424CAE4", Slot = "12")]
		protected override void OnButtonExtendBgClicked()
		{
		}

		[Token(Token = "0x60049AA")]
		[Address(RVA = "0x424CB70", Offset = "0x4248B70", VA = "0x424CB70")]
		public UpgradeTalentPanel()
		{
		}
	}
}
