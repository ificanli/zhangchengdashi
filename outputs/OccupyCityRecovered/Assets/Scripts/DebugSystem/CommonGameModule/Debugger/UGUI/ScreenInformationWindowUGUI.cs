using Il2CppDummyDll;
using UnityEngine;

namespace CommonGameModule.Debugger.UGUI
{
	[Token(Token = "0x2000089")]
	public class ScreenInformationWindowUGUI : BaseInformationWindowUGUI
	{
		[Token(Token = "0x6000304")]
		[Address(RVA = "0x468EA20", Offset = "0x468AA20", VA = "0x468EA20")]
		public ScreenInformationWindowUGUI(InformationWindowUGUI windowUgui) : base(windowUgui)
		{
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x468EA24", Offset = "0x468AA24", VA = "0x468EA24", Slot = "17")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x468EA7C", Offset = "0x468AA7C", VA = "0x468EA7C", Slot = "20")]
		protected override void OnRefreshText()
		{
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x468F1C0", Offset = "0x468B1C0", VA = "0x468F1C0")]
		private string GetSleepTimeoutDescription(int sleepTimeout)
		{
			return null;
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x468F0FC", Offset = "0x468B0FC", VA = "0x468F0FC")]
		private string GetResolutionString(Resolution resolution)
		{
			return null;
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x468F240", Offset = "0x468B240", VA = "0x468F240")]
		private string GetCutoutsString(Rect[] cutouts)
		{
			return null;
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x468F324", Offset = "0x468B324", VA = "0x468F324")]
		private string GetResolutionsString(Resolution[] resolutions)
		{
			return null;
		}
	}
}
