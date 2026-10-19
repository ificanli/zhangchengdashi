using Il2CppDummyDll;
using UnityEngine;

namespace AllIn1VfxToolkit.Demo.Scripts
{
	[Token(Token = "0x2000017")]
	[RequireComponent(typeof(Light))]
	public class AllIn1VfxFadeLight : MonoBehaviour
	{
		[Token(Token = "0x4000093")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float fadeDuration;

		[Token(Token = "0x4000094")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool destroyWhenFaded;

		[Token(Token = "0x4000095")]
		[FieldOffset(Offset = "0x28")]
		private Light targetLight;

		[Token(Token = "0x4000096")]
		[FieldOffset(Offset = "0x30")]
		private float animationRatioRemaining;

		[Token(Token = "0x4000097")]
		[FieldOffset(Offset = "0x34")]
		private float iniLightIntensity;

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x3CF20A0", Offset = "0x3CEE0A0", VA = "0x3CF20A0")]
		private void Start()
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x3CF2104", Offset = "0x3CEE104", VA = "0x3CF2104")]
		private void Update()
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x3CF21E8", Offset = "0x3CEE1E8", VA = "0x3CF21E8")]
		public AllIn1VfxFadeLight()
		{
		}
	}
}
