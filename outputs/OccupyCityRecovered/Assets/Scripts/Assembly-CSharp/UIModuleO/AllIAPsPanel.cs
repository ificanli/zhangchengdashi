using System.Collections.Generic;
using Il2CppDummyDll;

namespace UIModuleO
{
	[Token(Token = "0x20006A5")]
	public class AllIAPsPanel : AllIAPsPanelComponents
	{
		[Token(Token = "0x400354D")]
		[FieldOffset(Offset = "0x60")]
		private List<string> _hideIds;

		[Token(Token = "0x6002329")]
		[Address(RVA = "0x3F42320", Offset = "0x3F3E320", VA = "0x3F42320", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600232A")]
		[Address(RVA = "0x3F42764", Offset = "0x3F3E764", VA = "0x3F42764", Slot = "12")]
		protected override void OnButtonExtendBGClicked()
		{
		}

		[Token(Token = "0x600232B")]
		[Address(RVA = "0x3F427F0", Offset = "0x3F3E7F0", VA = "0x3F427F0")]
		public AllIAPsPanel()
		{
		}
	}
}
