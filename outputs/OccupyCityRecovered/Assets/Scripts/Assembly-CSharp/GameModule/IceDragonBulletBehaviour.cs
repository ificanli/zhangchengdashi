using Il2CppDummyDll;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x200026A")]
	public class IceDragonBulletBehaviour : BulletBehaviour
	{
		[Token(Token = "0x4001F23")]
		[FieldOffset(Offset = "0x70")]
		private bool isFreeze;

		[Token(Token = "0x6000A84")]
		[Address(RVA = "0x4388318", Offset = "0x4384318", VA = "0x4388318")]
		public void IsFreezeIceBall()
		{
		}

		[Token(Token = "0x6000A85")]
		[Address(RVA = "0x4388324", Offset = "0x4384324", VA = "0x4388324", Slot = "8")]
		protected override void BulletDamageLogic()
		{
		}

		[Token(Token = "0x6000A86")]
		[Address(RVA = "0x4388554", Offset = "0x4384554", VA = "0x4388554", Slot = "9")]
		protected override void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000A87")]
		[Address(RVA = "0x4388558", Offset = "0x4384558", VA = "0x4388558", Slot = "10")]
		protected override void Clear()
		{
		}

		[Token(Token = "0x6000A88")]
		[Address(RVA = "0x4388570", Offset = "0x4384570", VA = "0x4388570")]
		public IceDragonBulletBehaviour()
		{
		}
	}
}
