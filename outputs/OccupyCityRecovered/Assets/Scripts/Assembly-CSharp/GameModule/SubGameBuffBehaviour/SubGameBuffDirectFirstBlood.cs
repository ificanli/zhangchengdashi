using Il2CppDummyDll;

namespace GameModule.SubGameBuffBehaviour
{
	[Token(Token = "0x2000616")]
	public class SubGameBuffDirectFirstBlood : SubGameBuffBase
	{
		[Token(Token = "0x6002076")]
		[Address(RVA = "0x3F1075C", Offset = "0x3F0C75C", VA = "0x3F1075C")]
		public SubGameBuffDirectFirstBlood() : base(1002)
		{
		}

		[Token(Token = "0x6002077")]
		[Address(RVA = "0x3F10768", Offset = "0x3F0C768", VA = "0x3F10768", Slot = "13")]
		public override void OnMainTowerDestroyed(bool towerIsEnemy)
		{
		}
	}
}
