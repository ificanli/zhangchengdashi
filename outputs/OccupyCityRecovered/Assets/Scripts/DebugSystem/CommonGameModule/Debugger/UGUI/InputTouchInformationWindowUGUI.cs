using Il2CppDummyDll;
using UnityEngine;

namespace CommonGameModule.Debugger.UGUI
{
	[Token(Token = "0x200007E")]
	public class InputTouchInformationWindowUGUI : BaseInformationWindowUGUI
	{
		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x468BFC4", Offset = "0x4687FC4", VA = "0x468BFC4")]
		public InputTouchInformationWindowUGUI(InformationWindowUGUI windowUgui) : base(windowUgui)
		{
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x468BFC8", Offset = "0x4687FC8", VA = "0x468BFC8", Slot = "17")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x468C020", Offset = "0x4688020", VA = "0x468C020", Slot = "20")]
		protected override void OnRefreshText()
		{
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x468C35C", Offset = "0x468835C", VA = "0x468C35C")]
		private string GetTouchString(Touch touch)
		{
			return null;
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x468C268", Offset = "0x4688268", VA = "0x468C268")]
		private string GetTouchesString(Touch[] touches)
		{
			return null;
		}
	}
}
