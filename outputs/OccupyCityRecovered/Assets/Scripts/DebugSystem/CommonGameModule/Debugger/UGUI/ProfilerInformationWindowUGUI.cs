using Il2CppDummyDll;

namespace CommonGameModule.Debugger.UGUI
{
	[Token(Token = "0x2000080")]
	public class ProfilerInformationWindowUGUI : BaseInformationWindowUGUI
	{
		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x468C740", Offset = "0x4688740", VA = "0x468C740")]
		public ProfilerInformationWindowUGUI(InformationWindowUGUI windowUgui) : base(windowUgui)
		{
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x468C744", Offset = "0x4688744", VA = "0x468C744", Slot = "17")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x468C79C", Offset = "0x468879C", VA = "0x468C79C", Slot = "20")]
		protected override void OnRefreshText()
		{
		}
	}
}
