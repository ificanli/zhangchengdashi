using Il2CppDummyDll;

namespace CommonGameModule.Debugger.UGUI
{
	[Token(Token = "0x2000088")]
	public class SceneInformationWindowUGUI : BaseInformationWindowUGUI
	{
		[Token(Token = "0x6000301")]
		[Address(RVA = "0x468E6C8", Offset = "0x468A6C8", VA = "0x468E6C8")]
		public SceneInformationWindowUGUI(InformationWindowUGUI windowUgui) : base(windowUgui)
		{
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x468E6CC", Offset = "0x468A6CC", VA = "0x468E6CC", Slot = "17")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x468E724", Offset = "0x468A724", VA = "0x468E724", Slot = "20")]
		protected override void OnRefreshText()
		{
		}
	}
}
