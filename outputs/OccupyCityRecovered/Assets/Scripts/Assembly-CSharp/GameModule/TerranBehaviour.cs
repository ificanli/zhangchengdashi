using System.Runtime.InteropServices;
using DataModule;
using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x2000390")]
	public class TerranBehaviour : RoleBehaviour
	{
		[Token(Token = "0x6001012")]
		[Address(RVA = "0x3D9C5F4", Offset = "0x3D985F4", VA = "0x3D9C5F4", Slot = "20")]
		public override void Init(GlobalRoleInfo info, bool isEnemy, int cardLevel, RareLevel rareLevel, [Optional] string relativeCardID, CardFettersType fettersType = CardFettersType.Null, AtkWayType atkWayType = AtkWayType.Null)
		{
		}

		[Token(Token = "0x6001013")]
		[Address(RVA = "0x3D9C23C", Offset = "0x3D9823C", VA = "0x3D9C23C", Slot = "30")]
		protected override void AtkCallBack(int attackNum)
		{
		}

		[Token(Token = "0x6001014")]
		[Address(RVA = "0x3D9C67C", Offset = "0x3D9867C", VA = "0x3D9C67C")]
		private void TerranCardFettersInit()
		{
		}

		[Token(Token = "0x6001015")]
		[Address(RVA = "0x3D9775C", Offset = "0x3D9375C", VA = "0x3D9775C")]
		public TerranBehaviour()
		{
		}
	}
}
