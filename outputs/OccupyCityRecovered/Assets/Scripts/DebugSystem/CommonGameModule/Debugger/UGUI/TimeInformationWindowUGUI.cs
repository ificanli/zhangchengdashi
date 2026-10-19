using Il2CppDummyDll;

namespace CommonGameModule.Debugger.UGUI
{
	[Token(Token = "0x200008B")]
	public class TimeInformationWindowUGUI : BaseInformationWindowUGUI
	{
		[Token(Token = "0x600030F")]
		[Address(RVA = "0x468FAB8", Offset = "0x468BAB8", VA = "0x468FAB8")]
		public TimeInformationWindowUGUI(InformationWindowUGUI windowUgui) : base(windowUgui)
		{
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x468FABC", Offset = "0x468BABC", VA = "0x468FABC", Slot = "17")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x468FB14", Offset = "0x468BB14", VA = "0x468FB14", Slot = "20")]
		protected override void OnRefreshText()
		{
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x4690098", Offset = "0x468C098", VA = "0x4690098")]
		private string GetTimeScaleDescription(float timeScale)
		{
			return null;
		}
	}
}
