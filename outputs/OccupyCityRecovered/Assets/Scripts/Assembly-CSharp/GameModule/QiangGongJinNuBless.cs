using DataModule;
using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x200025C")]
	public class QiangGongJinNuBless : BlessBase
	{
		[Token(Token = "0x6000A48")]
		[Address(RVA = "0x438406C", Offset = "0x438006C", VA = "0x438406C")]
		public QiangGongJinNuBless(string blessId, float value) : base(blessId, value)
		{
		}

		[Token(Token = "0x6000A49")]
		[Address(RVA = "0x43840A4", Offset = "0x43800A4", VA = "0x43840A4", Slot = "4")]
		public override void HandleRoleNumber(RolePropertyTemp propertyTemp)
		{
		}
	}
}
