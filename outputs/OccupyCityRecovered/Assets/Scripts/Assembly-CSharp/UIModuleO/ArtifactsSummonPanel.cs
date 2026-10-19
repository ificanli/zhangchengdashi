using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x20006D7")]
	public class ArtifactsSummonPanel : ArtifactsSummonPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20006D8")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__3 : IAsyncStateMachine
		{
			[Token(Token = "0x40036C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40036C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40036C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ArtifactsSummonPanel _003C_003E4__this;

			[Token(Token = "0x40036C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x60024CF")]
			[Address(RVA = "0x3F614CC", Offset = "0x3F5D4CC", VA = "0x3F614CC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60024D0")]
			[Address(RVA = "0x3F61964", Offset = "0x3F5D964", VA = "0x3F61964", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40036C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool _suppressTabCallback;

		[Token(Token = "0x1700028C")]
		public Image SummonMaskImage
		{
			[Token(Token = "0x60024C4")]
			[Address(RVA = "0x3F60E74", Offset = "0x3F5CE74", VA = "0x3F60E74")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60024C5")]
		[Address(RVA = "0x3F60F40", Offset = "0x3F5CF40", VA = "0x3F60F40", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__3))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60024C6")]
		[Address(RVA = "0x3F60FD4", Offset = "0x3F5CFD4", VA = "0x3F60FD4", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x60024C7")]
		[Address(RVA = "0x3F611F0", Offset = "0x3F5D1F0", VA = "0x3F611F0", Slot = "12")]
		protected override void OnButtonExtendCloseBtnClicked()
		{
		}

		[Token(Token = "0x60024C8")]
		[Address(RVA = "0x3F611FC", Offset = "0x3F5D1FC", VA = "0x3F611FC", Slot = "13")]
		protected override void OnToggleNormalSummonTogValueChanged(bool isOn)
		{
		}

		[Token(Token = "0x60024C9")]
		[Address(RVA = "0x3F61260", Offset = "0x3F5D260", VA = "0x3F61260", Slot = "14")]
		protected override void OnToggleSpecialSummonTogValueChanged(bool isOn)
		{
		}

		[Token(Token = "0x60024CA")]
		[Address(RVA = "0x3F610DC", Offset = "0x3F5D0DC", VA = "0x3F610DC")]
		private void SetNormalSummonSubPanelActive(bool active)
		{
		}

		[Token(Token = "0x60024CB")]
		[Address(RVA = "0x3F6110C", Offset = "0x3F5D10C", VA = "0x3F6110C")]
		private void SetSpecialSummonSubPanelActive(bool active)
		{
		}

		[Token(Token = "0x60024CC")]
		[Address(RVA = "0x3F61230", Offset = "0x3F5D230", VA = "0x3F61230")]
		private void ApplyTabBySetActive(bool normalTabVisible)
		{
		}

		[Token(Token = "0x60024CD")]
		[Address(RVA = "0x3F61424", Offset = "0x3F5D424", VA = "0x3F61424")]
		public ArtifactsSummonPanel()
		{
		}
	}
}
