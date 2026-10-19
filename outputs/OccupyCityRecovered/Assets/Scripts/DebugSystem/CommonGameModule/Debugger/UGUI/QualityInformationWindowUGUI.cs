using Il2CppDummyDll;

namespace CommonGameModule.Debugger.UGUI
{
	[Token(Token = "0x2000081")]
	public class QualityInformationWindowUGUI : BaseInformationWindowUGUI
	{
		[Token(Token = "0x4000232")]
		[FieldOffset(Offset = "0x2C")]
		private bool m_ApplyExpensiveChanges;

		[Token(Token = "0x4000233")]
		[FieldOffset(Offset = "0x30")]
		private ToggleBtn m_ApplyChangesToggle;

		[Token(Token = "0x4000234")]
		[FieldOffset(Offset = "0x38")]
		private ToggleBtn[] m_QualityToggles;

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x468CB4C", Offset = "0x4688B4C", VA = "0x468CB4C")]
		public QualityInformationWindowUGUI(InformationWindowUGUI windowUgui) : base(windowUgui)
		{
			throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED QualityInformationWindowUGUI..ctor RVA=0x468CB4C Token=0x060002DA; original base constructor arguments recovered; remaining original constructor body pending.");
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x468CE08", Offset = "0x4688E08", VA = "0x468CE08")]
		private void OnSelectQuality(int index)
		{
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x468CEE0", Offset = "0x4688EE0", VA = "0x468CEE0", Slot = "20")]
		protected override void OnRefreshText()
		{
		}
	}
}
