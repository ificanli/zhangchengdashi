using Il2CppDummyDll;
using UnityEngine;

namespace GameModule.SubGameBuffBehaviour
{
	[Token(Token = "0x2000618")]
	public class SubGameBuffFleshRecycle : SubGameBuffBase
	{
		[Token(Token = "0x4003262")]
		private const int DeadCoinReward = 1;

		[Token(Token = "0x600207A")]
		[Address(RVA = "0x3F10838", Offset = "0x3F0C838", VA = "0x3F10838")]
		public SubGameBuffFleshRecycle() : base(1012)
		{
		}

		[Token(Token = "0x600207B")]
		[Address(RVA = "0x3F10844", Offset = "0x3F0C844", VA = "0x3F10844", Slot = "9")]
		public override void OnFriendlyUnitDead(bool unitIsEnemy, Vector3 deadPosition)
		{
		}
	}
}
