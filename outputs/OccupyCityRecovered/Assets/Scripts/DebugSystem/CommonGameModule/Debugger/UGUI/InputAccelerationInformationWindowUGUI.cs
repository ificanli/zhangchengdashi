using Il2CppDummyDll;
using UnityEngine;

namespace CommonGameModule.Debugger.UGUI
{
	[Token(Token = "0x2000076")]
	public class InputAccelerationInformationWindowUGUI : BaseInformationWindowUGUI
	{
		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x468A814", Offset = "0x4686814", VA = "0x468A814")]
		public InputAccelerationInformationWindowUGUI(InformationWindowUGUI windowUgui) : base(windowUgui)
		{
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x468A818", Offset = "0x4686818", VA = "0x468A818", Slot = "20")]
		protected override void OnRefreshText()
		{
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x468A9FC", Offset = "0x46869FC", VA = "0x468A9FC")]
		private string GetAccelerationEventString(AccelerationEvent accelerationEvent)
		{
			return null;
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x468A920", Offset = "0x4686920", VA = "0x468A920")]
		private string GetAccelerationEventsString(AccelerationEvent[] accelerationEvents)
		{
			return null;
		}
	}
}
