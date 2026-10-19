using Il2CppDummyDll;

namespace CommonGameModule.Debugger.UGUI
{
	[Token(Token = "0x200008A")]
	public class SystemInfomationWindowUGUI : BaseInformationWindowUGUI
	{
		[Token(Token = "0x600030B")]
		[Address(RVA = "0x468F3FC", Offset = "0x468B3FC", VA = "0x468F3FC")]
		public SystemInfomationWindowUGUI(InformationWindowUGUI windowUgui) : base(windowUgui)
		{
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x468F400", Offset = "0x468B400", VA = "0x468F400", Slot = "17")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x468F458", Offset = "0x468B458", VA = "0x468F458", Slot = "20")]
		protected override void OnRefreshText()
		{
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x468FA40", Offset = "0x468BA40", VA = "0x468FA40")]
		private string GetBatteryLevelString(float batteryLevel)
		{
			return null;
		}
	}
}
