using DataModule;
using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x200025F")]
	public class WuQiQiangHua : BlessBase
	{
		[Token(Token = "0x6000A4E")]
		[Address(RVA = "0x43841E0", Offset = "0x43801E0", VA = "0x43841E0")]
		public WuQiQiangHua(string blessId, float value) : base(blessId, value)
		{
		}

		[Token(Token = "0x6000A4F")]
		[Address(RVA = "0x4384218", Offset = "0x4380218", VA = "0x4384218", Slot = "4")]
		public override void HandleRoleNumber(RolePropertyTemp propertyTemp)
		{
		}
	}
}
