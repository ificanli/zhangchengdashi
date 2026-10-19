using Il2CppDummyDll;
using UnityEngine;

namespace EpicToonFX
{
	[Token(Token = "0x2000DE8")]
	public class ETFXLightFade : MonoBehaviour
	{
		[Token(Token = "0x2000DE9")]
		public enum OnLifeEnd
		{
			[Token(Token = "0x400618A")]
			DoNothing = 0,
			[Token(Token = "0x400618B")]
			Disable = 1,
			[Token(Token = "0x400618C")]
			Destroy = 2
		}

		[Token(Token = "0x4006185")]
		[FieldOffset(Offset = "0x20")]
		[Header("Seconds to dim the light")]
		public float life;

		[Token(Token = "0x4006186")]
		[FieldOffset(Offset = "0x24")]
		public OnLifeEnd onLifeEnd;

		[Token(Token = "0x4006187")]
		[FieldOffset(Offset = "0x28")]
		private Light li;

		[Token(Token = "0x4006188")]
		[FieldOffset(Offset = "0x30")]
		private float initIntensity;

		[Token(Token = "0x6005643")]
		[Address(RVA = "0x433B968", Offset = "0x4337968", VA = "0x433B968")]
		private void Start()
		{
		}

		[Token(Token = "0x6005644")]
		[Address(RVA = "0x433BA14", Offset = "0x4337A14", VA = "0x433BA14")]
		private void Update()
		{
		}

		[Token(Token = "0x6005645")]
		[Address(RVA = "0x433BB40", Offset = "0x4337B40", VA = "0x433BB40")]
		public ETFXLightFade()
		{
		}
	}
}
