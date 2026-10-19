using Il2CppDummyDll;
using UnityEngine;

namespace GPUInstancer
{
	[Token(Token = "0x200004A")]
	public class GPUInstancerSettingsExtension : ScriptableObject
	{
		[Token(Token = "0x4000347")]
		[FieldOffset(Offset = "0x18")]
		public float extensionVersionNo;

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x73DF5C4", Offset = "0x73DB5C4", VA = "0x73DF5C4", Slot = "4")]
		public virtual string GetExtensionCode()
		{
			return null;
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x73DF5FC", Offset = "0x73DB5FC", VA = "0x73DF5FC")]
		public GPUInstancerSettingsExtension()
		{
		}
	}
}
