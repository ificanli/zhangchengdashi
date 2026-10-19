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
	[Token(Token = "0x2000BCE")]
	public class TutorialPanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000BCF")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__117 : IAsyncStateMachine
		{
			[Token(Token = "0x40055C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40055C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40055C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public TutorialPanelComponents _003C_003E4__this;

			[Token(Token = "0x40055CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x60048E7")]
			[Address(RVA = "0x423F744", Offset = "0x423B744", VA = "0x423F744", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60048E8")]
			[Address(RVA = "0x423F9BC", Offset = "0x423B9BC", VA = "0x423F9BC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40055C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Button _buttonIntroBack;

		[Token(Token = "0x17000CA9")]
		public Button ButtonIntroBack
		{
			[Token(Token = "0x60048DF")]
			[Address(RVA = "0x423F414", Offset = "0x423B414", VA = "0x423F414")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60048E0")]
		[Address(RVA = "0x423F4DC", Offset = "0x423B4DC", VA = "0x423F4DC")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x60048E1")]
		[Address(RVA = "0x423F564", Offset = "0x423B564", VA = "0x423F564", Slot = "12")]
		protected virtual void OnButtonIntroBackClicked()
		{
		}

		[Token(Token = "0x60048E2")]
		[Address(RVA = "0x423F5D0", Offset = "0x423B5D0", VA = "0x423F5D0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60048E3")]
		[Address(RVA = "0x423F5EC", Offset = "0x423B5EC", VA = "0x423F5EC", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__117))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60048E4")]
		[Address(RVA = "0x423F680", Offset = "0x423B680", VA = "0x423F680", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x60048E5")]
		[Address(RVA = "0x423F734", Offset = "0x423B734", VA = "0x423F734")]
		public TutorialPanelComponents()
		{
		}
	}
}
