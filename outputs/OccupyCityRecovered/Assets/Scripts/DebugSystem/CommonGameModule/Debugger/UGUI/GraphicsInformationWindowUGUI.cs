using Il2CppDummyDll;

namespace CommonGameModule.Debugger.UGUI
{
	[Token(Token = "0x2000075")]
	public class GraphicsInformationWindowUGUI : BaseInformationWindowUGUI
	{
		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x4689A10", Offset = "0x4685A10", VA = "0x4689A10")]
		public GraphicsInformationWindowUGUI(InformationWindowUGUI windowUgui) : base(windowUgui)
		{
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x4689A14", Offset = "0x4685A14", VA = "0x4689A14", Slot = "17")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x4689A6C", Offset = "0x4685A6C", VA = "0x4689A6C", Slot = "20")]
		protected override void OnRefreshText()
		{
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x468A770", Offset = "0x4686770", VA = "0x468A770")]
		private string GetShaderLevelString(int shaderLevel)
		{
			return null;
		}
	}
}
