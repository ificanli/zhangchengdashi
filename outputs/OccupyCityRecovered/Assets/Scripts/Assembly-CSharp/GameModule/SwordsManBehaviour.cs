using System.Runtime.InteropServices;
using DataModule;
using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x200038F")]
	public class SwordsManBehaviour : TerranBehaviour
	{
		[Token(Token = "0x600100F")]
		[Address(RVA = "0x3D9C5EC", Offset = "0x3D985EC", VA = "0x3D9C5EC", Slot = "20")]
		public override void Init(GlobalRoleInfo info, bool isEnemy, int cardLevel, RareLevel rareLevel, [Optional] string relativeCardID, CardFettersType fettersType = CardFettersType.Null, AtkWayType atkWayType = AtkWayType.Null)
		{
		}

		[Token(Token = "0x6001010")]
		[Address(RVA = "0x3D9C66C", Offset = "0x3D9866C", VA = "0x3D9C66C", Slot = "22")]
		protected override void InitSkill()
		{
		}

		[Token(Token = "0x6001011")]
		[Address(RVA = "0x3D9C674", Offset = "0x3D98674", VA = "0x3D9C674")]
		public SwordsManBehaviour()
		{
		}
	}
}
