using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using UIFramework;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000C36")]
	public class WeeklyClashSwitchPanelRectComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000C37")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__100 : IAsyncStateMachine
		{
			[Token(Token = "0x40057E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40057E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40057E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public WeeklyClashSwitchPanelRectComponents _003C_003E4__this;

			[Token(Token = "0x40057E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6004BAF")]
			[Address(RVA = "0x426CC94", Offset = "0x4268C94", VA = "0x426CC94", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004BB0")]
			[Address(RVA = "0x426CF0C", Offset = "0x4268F0C", VA = "0x426CF0C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40057E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Toggle _toggleWeeklyToggle;

		[Token(Token = "0x40057E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Toggle _toggleSeasonToggle;

		[Token(Token = "0x17000D6C")]
		public Toggle ToggleWeeklyToggle
		{
			[Token(Token = "0x6004BA5")]
			[Address(RVA = "0x426C938", Offset = "0x4268938", VA = "0x426C938")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D6D")]
		public Toggle ToggleSeasonToggle
		{
			[Token(Token = "0x6004BA6")]
			[Address(RVA = "0x426CA0C", Offset = "0x4268A0C", VA = "0x426CA0C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004BA7")]
		[Address(RVA = "0x426CAD4", Offset = "0x4268AD4", VA = "0x426CAD4")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6004BA8")]
		[Address(RVA = "0x426C434", Offset = "0x4268434", VA = "0x426C434", Slot = "12")]
		protected virtual void OnToggleWeeklyToggleValueChanged(bool arg)
		{
		}

		[Token(Token = "0x6004BA9")]
		[Address(RVA = "0x426C540", Offset = "0x4268540", VA = "0x426C540", Slot = "13")]
		protected virtual void OnToggleSeasonToggleValueChanged(bool arg)
		{
		}

		[Token(Token = "0x6004BAA")]
		[Address(RVA = "0x426CBBC", Offset = "0x4268BBC", VA = "0x426CBBC", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6004BAB")]
		[Address(RVA = "0x426C608", Offset = "0x4268608", VA = "0x426C608", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__100))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6004BAC")]
		[Address(RVA = "0x426CBD8", Offset = "0x4268BD8", VA = "0x426CBD8", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6004BAD")]
		[Address(RVA = "0x426C5FC", Offset = "0x42685FC", VA = "0x426C5FC")]
		public WeeklyClashSwitchPanelRectComponents()
		{
		}
	}
}
